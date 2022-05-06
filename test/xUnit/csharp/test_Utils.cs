// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Threading;
using System.Reflection;
using Microsoft.PowerShell.Commands;
using Xunit;

namespace PSTests.Parallel
{
    public static class UtilsTests
    {
        [SkippableFact]
        public static void TestIsWinPEHost()
        {
            Skip.IfNot(Platform.IsWindows);
            CustomAssert.False(Utils.IsWinPEHost());
        }

        [Fact]
        public static void TestHistoryStack()
        {
            var historyStack = new HistoryStack<string>(20);
            CustomAssert.Equal(0, historyStack.UndoCount);
            CustomAssert.Equal(0, historyStack.RedoCount);

            historyStack.Push("first item");
            historyStack.Push("second item");
            CustomAssert.Equal(2, historyStack.UndoCount);
            CustomAssert.Equal(0, historyStack.RedoCount);

            CustomAssert.Equal("second item", historyStack.Undo("second item"));
            CustomAssert.Equal("first item", historyStack.Undo("first item"));
            CustomAssert.Equal(0, historyStack.UndoCount);
            CustomAssert.Equal(2, historyStack.RedoCount);

            CustomAssert.Equal("first item", historyStack.Redo("first item"));
            CustomAssert.Equal(1, historyStack.UndoCount);
            CustomAssert.Equal(1, historyStack.RedoCount);

            // Pushing a new item should invalidate the RedoCount
            historyStack.Push("third item");
            CustomAssert.Equal(2, historyStack.UndoCount);
            CustomAssert.Equal(0, historyStack.RedoCount);

            // Check for the correct exception when the Redo/Undo stack is empty.
            CustomAssert.Throws<InvalidOperationException>(() => historyStack.Redo("bar"));
            historyStack.Undo("third item");
            historyStack.Undo("first item");
            CustomAssert.Equal(0, historyStack.UndoCount);
            CustomAssert.Throws<InvalidOperationException>(() => historyStack.Undo("foo"));
        }

        [Fact]
        public static void TestBoundedStack()
        {
            uint capacity = 20;
            var boundedStack = new BoundedStack<string>(capacity);
            CustomAssert.Throws<InvalidOperationException>(() => boundedStack.Pop());

            for (int i = 0; i < capacity; i++)
            {
                boundedStack.Push($"{i}");
            }

            for (int i = 0; i < capacity; i++)
            {
                var poppedItem = boundedStack.Pop();
                CustomAssert.Equal($"{20 - 1 - i}", poppedItem);
            }

            CustomAssert.Throws<InvalidOperationException>(() => boundedStack.Pop());
        }

        [Fact]
        public static void TestConvertToJsonBasic()
        {
            var context = new JsonObject.ConvertToJsonContext(maxDepth: 1, enumsAsStrings: false, compressOutput: true);
            string expected = "{\"name\":\"req\",\"type\":\"http\"}";
            OrderedDictionary hash = new OrderedDictionary {
                {"name", "req"},
                {"type", "http"}
            };
            string json = JsonObject.ConvertToJson(hash, in context);
            CustomAssert.Equal(expected, json);

            hash.Add("self", hash);
            json = JsonObject.ConvertToJson(hash, context);
            expected = "{\"name\":\"req\",\"type\":\"http\",\"self\":{\"name\":\"req\",\"type\":\"http\",\"self\":\"System.Collections.Specialized.OrderedDictionary\"}}";
            CustomAssert.Equal(expected, json);
        }

        [Fact]
        public static void TestConvertToJsonWithEnum()
        {
            var context = new JsonObject.ConvertToJsonContext(maxDepth: 1, enumsAsStrings: false, compressOutput: true);
            string expected = "{\"type\":1}";
            Hashtable hash = new Hashtable {
                {"type", CommandTypes.Alias}
            };
            string json = JsonObject.ConvertToJson(hash, in context);
            CustomAssert.Equal(expected, json);

            context = new JsonObject.ConvertToJsonContext(maxDepth: 1, enumsAsStrings: true, compressOutput: true);
            json = JsonObject.ConvertToJson(hash, in context);
            expected = "{\"type\":\"Alias\"}";
            CustomAssert.Equal(expected, json);
        }

        [Fact]
        public static void TestConvertToJsonWithoutCompress()
        {
            var context = new JsonObject.ConvertToJsonContext(maxDepth: 1, enumsAsStrings: true, compressOutput: false);
            string expected = @"{
  ""type"": ""Alias""
}";
            Hashtable hash = new Hashtable {
                {"type", CommandTypes.Alias}
            };
            string json = JsonObject.ConvertToJson(hash, in context);
            CustomAssert.Equal(expected, json);
        }

        [Fact]
        public static void TestConvertToJsonCancellation()
        {
            var source = new CancellationTokenSource();
            var context = new JsonObject.ConvertToJsonContext(
                maxDepth: 1,
                enumsAsStrings: true,
                compressOutput: false,
                source.Token,
                Newtonsoft.Json.StringEscapeHandling.Default,
                targetCmdlet: null);

            source.Cancel();
            Hashtable hash = new Hashtable {
                {"type", CommandTypes.Alias}
            };

            string json = JsonObject.ConvertToJson(hash, in context);
            CustomAssert.Null(json);
        }
    }
}
