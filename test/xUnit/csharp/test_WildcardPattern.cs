// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using Xunit;

namespace PSTests.Parallel
{
    public class WildcardPatternTests
    {
        [Fact]
        public void TestEscape_Null()
        {
            CustomAssert.Throws<System.Management.Automation.PSArgumentNullException>(delegate { WildcardPattern.Escape(null); });
        }

        [Fact]
        public void TestEscape_Empty()
        {
            CustomAssert.Equal(WildcardPattern.Escape(string.Empty), string.Empty);
        }

        // LAFHIS: we expand the theories for keeping these tests separated
        [Fact]
        public void TestEscape_String_A()
        {
            string source = "a";
            string expected = "a";
            CustomAssert.Equal(WildcardPattern.Escape(source), expected);
        }

        [Fact]
        public void TestEscape_String_B()
        {
            string source = "a*";
            string expected = "a`*";
            CustomAssert.Equal(WildcardPattern.Escape(source), expected);
        }

        [Fact]
        public void TestEscape_String_C()
        {
            string source = "*?[]";
            string expected = "`*`?`[`]";
            CustomAssert.Equal(WildcardPattern.Escape(source), expected);
        }

        [Fact]
        public void TestEscape_String_NotEscape_A()
        {
            string source = "a";
            string expected = "a";
            CustomAssert.Equal(WildcardPattern.Escape(source, new[] { '*', '?', '[', ']' }), expected);
        }

        [Fact]
        public void TestEscape_String_NotEscape_B()
        {
            string source = "a*";
            string expected = "a*";
            CustomAssert.Equal(WildcardPattern.Escape(source, new[] { '*', '?', '[', ']' }), expected);
        }

        [Fact]
        public void TestEscape_String_NotEscape_C()
        {
            string source = "*?[]";
            string expected = "*?[]";
            CustomAssert.Equal(WildcardPattern.Escape(source, new[] { '*', '?', '[', ']' }), expected);
        }

        [Fact]
        public void TestUnescape_Null()
        {
            CustomAssert.Throws<System.Management.Automation.PSArgumentNullException>(delegate { WildcardPattern.Unescape(null); });
        }

        [Fact]
        public void TestUnescape_Empty()
        {
            CustomAssert.Equal(WildcardPattern.Unescape(string.Empty), string.Empty);
        }

        [Fact]
        public void TestUnescape_String_A()
        {
            string source = "a";
            string expected = "a";
            CustomAssert.Equal(WildcardPattern.Unescape(source), expected);
        }

        [Fact]
        public void TestUnescape_String_B()
        {
            string source = "a`*";
            string expected = "a*";
            CustomAssert.Equal(WildcardPattern.Unescape(source), expected);
        }

        [Fact]
        public void TestUnescape_String_C()
        {
            string source = "`*`?`[`]";
            string expected = "*?[]";
            CustomAssert.Equal(WildcardPattern.Unescape(source), expected);
        }
    }
}
