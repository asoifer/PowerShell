// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Provider;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Dbg = System.Management.Automation;

namespace Microsoft.PowerShell.Commands
{
    internal class FileSystemContentReaderWriter : IContentReader, IContentWriter
    {
        [Dbg.TraceSourceAttribute(
                    "FileSystemContentStream",
                    "The provider content reader and writer for the file system")]
        private static Dbg.PSTraceSource s_tracer;

        private string _path;

        private string _streamName;

        private FileMode _mode;

        private FileAccess _access;

        private FileShare _share;

        private Encoding _encoding;

        private CmdletProvider _provider;

        private FileStream _stream;

        private StreamReader _reader;

        private StreamWriter _writer;

        private bool _usingByteEncoding;

        private const char
        DefaultDelimiter = '\n'
        ;

        private string _delimiter;

        private int[] _offsetDictionary;

        private bool _usingDelimiter;

        private StringBuilder _currentLineContent;

        private bool _waitForChanges;

        private bool _isRawStream;

        private long _fileOffset;

        private FileAttributes _oldAttributes;

        private bool _haveOldAttributes;

        private FileStreamBackReader _backReader;

        private bool _alreadyDetectEncoding;

        private bool _suppressNewline;

        public FileSystemContentReaderWriter(
                    string path, FileMode mode, FileAccess access,
                    FileShare share, Encoding encoding, bool usingByteEncoding,
                    bool waitForChanges, CmdletProvider provider, bool isRawStream) : this(f_1192_4338_4342_C(path), null, mode, access, share, encoding, usingByteEncoding, waitForChanges, provider, isRawStream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1192, 4066, 4460);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1192, 4066, 4460);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 4066, 4460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 4066, 4460);
            }
        }

        public FileSystemContentReaderWriter(
                    string path, string streamName, FileMode mode, FileAccess access, FileShare share,
                    Encoding encoding, bool usingByteEncoding, bool waitForChanges, CmdletProvider provider,
                    bool isRawStream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1192, 5906, 7029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 1698, 1703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 1729, 1740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 1768, 1773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 1803, 1810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 1839, 1845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 1873, 1882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 1916, 1925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 1957, 1964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 1996, 2003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2035, 2042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2066, 2084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2163, 2197);
                this._delimiter = $"{DefaultDelimiter}";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2222, 2239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2263, 2278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2311, 2330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2354, 2369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2393, 2405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2429, 2440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2476, 2490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2514, 2532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2627, 2638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2662, 2692);
                this._alreadyDetectEncoding = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2799, 2823);
                this._suppressNewline = false;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6197, 6329) || true) && (f_1192_6201_6227(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 6197, 6329);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6261, 6314);

                    throw f_1192_6267_6313("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 6197, 6329);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6345, 6573) || true) && (f_1192_6349_6367(s_tracer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 6345, 6573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6401, 6440);

                    f_1192_6401_6439(s_tracer, "path = {0}", path);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6458, 6497);

                    f_1192_6458_6496(s_tracer, "mode = {0}", mode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6515, 6558);

                    f_1192_6515_6557(s_tracer, "access = {0}", access);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 6345, 6573);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6589, 6602);

                _path = path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6616, 6641);

                _streamName = streamName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6655, 6668);

                _mode = mode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6682, 6699);

                _access = access;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6713, 6728);

                _share = share;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6742, 6763);

                _encoding = encoding;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6777, 6816);

                _usingByteEncoding = usingByteEncoding;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6830, 6863);

                _waitForChanges = waitForChanges;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6877, 6898);

                _provider = provider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6912, 6939);

                _isRawStream = isRawStream;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 6955, 7018);

                f_1192_6955_7017(this, path, streamName, mode, access, share, encoding);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1192, 5906, 7029);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 5906, 7029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 5906, 7029);
            }
        }

        public FileSystemContentReaderWriter(
                    string path, string streamName, FileMode mode, FileAccess access, FileShare share,
                    Encoding encoding, bool usingByteEncoding, bool waitForChanges, CmdletProvider provider,
                    bool isRawStream, bool suppressNewline)
        : this(f_1192_8936_8940_C(path), streamName, mode, access, share, encoding, usingByteEncoding, waitForChanges, provider, isRawStream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1192, 8623, 9113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 9067, 9102);

                _suppressNewline = suppressNewline;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1192, 8623, 9113);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 8623, 9113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 8623, 9113);
            }
        }

        public FileSystemContentReaderWriter(
                    string path,
                    string streamName,
                    FileMode mode,
                    FileAccess access,
                    FileShare share,
                    string delimiter,
                    Encoding encoding,
                    bool waitForChanges,
                    CmdletProvider provider,
                    bool isRawStream)
        : this(f_1192_10945_10949_C(path), streamName, mode, access, share, encoding, false, waitForChanges, provider, isRawStream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1192, 10573, 13451);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 11228, 13440) || true) && (!(f_1192_11234_11250(delimiter) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1192, 11234, 11291) && f_1192_11259_11271(delimiter, 0) == DefaultDelimiter)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 11228, 13440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 11326, 11349);

                    _delimiter = delimiter;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 11367, 11390);

                    _usingDelimiter = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 11509, 11543);

                    const int
                    DefaultLineLength = 256
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 11561, 11620);

                    _currentLineContent = f_1192_11583_11619(DefaultLineLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 12649, 12682);

                    _offsetDictionary = new int[256];
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 12820, 12825);

                        // If next char from file is not in search pattern safe shift is the search pattern length.
                        for (var
        n = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 12811, 12962) || true) && (n < f_1192_12831_12855(_offsetDictionary))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 12857, 12860)
        , n++, DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 12811, 12962))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 12811, 12962);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 12902, 12943);

                            _offsetDictionary[n] = f_1192_12925_12942(_delimiter);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 1, 152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 1, 152);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 13080, 13097);

                    char
                    currentChar
                    = default(char);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 13115, 13128);

                    byte
                    lowByte
                    = default(byte);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 13155, 13160);
                        for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 13146, 13425) || true) && (i < f_1192_13166_13183(_delimiter))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 13185, 13188)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 13146, 13425))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 13146, 13425);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 13230, 13258);

                            currentChar = f_1192_13244_13257(_delimiter, i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 13280, 13329);

                            lowByte = f_1192_13290_13328(ref currentChar);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 13351, 13406);

                            _offsetDictionary[lowByte] = f_1192_13380_13397(_delimiter) - i - 1;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 1, 280);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 1, 280);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 11228, 13440);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1192, 10573, 13451);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 10573, 13451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 10573, 13451);
            }
        }

        public IList Read(long readCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 14020, 16975);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 14078, 14262) || true) && (_isRawStream && (DynAbs.Tracing.TraceSender.Expression_True(1192, 14082, 14113) && _waitForChanges))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 14078, 14262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 14147, 14247);

                    throw f_1192_14153_14246(f_1192_14196_14245());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 14078, 14262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 14278, 14313);

                bool
                waitChanges = _waitForChanges
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 14329, 14385);

                f_1192_14329_14384(
                            s_tracer, "blocks requested = {0}", readCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 14401, 14433);

                var
                blocks = f_1192_14414_14432()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 14447, 14481);

                bool
                readToEnd = (readCount <= 0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 14497, 15101) || true) && (_alreadyDetectEncoding && (DynAbs.Tracing.TraceSender.Expression_True(1192, 14501, 14559) && f_1192_14527_14554(f_1192_14527_14545(_reader)) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 14497, 15101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 14593, 14640);

                    Encoding
                    curEncoding = f_1192_14616_14639(_reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 14937, 14955);

                    f_1192_14937_14954(                // Close the stream, and reopen the stream to make the BOM correctly processed.
                                                       // The reader has already detected encoding, so if we don't reopen the stream, the BOM (if there is any)
                                                       // will be treated as a regular character.
                                    _stream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 14973, 15037);

                    f_1192_14973_15036(this, _path, null, _mode, _access, _share, curEncoding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15055, 15086);

                    _alreadyDetectEncoding = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 14497, 15101);
                }

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15163, 15179);
                        for (long
        currentBlock = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15153, 16144) || true) && ((currentBlock < readCount) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 15181, 15222) || (readToEnd)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15224, 15238)
        , ++currentBlock, DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 15153, 16144))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 15153, 16144);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15280, 15364) || true) && (waitChanges && (DynAbs.Tracing.TraceSender.Expression_True(1192, 15284, 15317) && f_1192_15299_15317(_provider)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 15280, 15364);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15344, 15364);

                                waitChanges = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 15280, 15364);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15388, 16125) || true) && (_usingByteEncoding)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 15388, 16125);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15460, 15559) || true) && (!f_1192_15465_15522(this, waitChanges, blocks, readBackward: false))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 15460, 15559);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1192, 15553, 15559);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 15460, 15559);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 15388, 16125);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 15388, 16125);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15657, 16102) || true) && (_usingDelimiter || (DynAbs.Tracing.TraceSender.Expression_False(1192, 15661, 15692) || _isRawStream))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 15657, 16102);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15750, 15863) || true) && (!f_1192_15755_15822(this, waitChanges, blocks, readBackward: false, _delimiter))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 15750, 15863);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1192, 15857, 15863);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 15750, 15863);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 15657, 16102);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 15657, 16102);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 15977, 16075) || true) && (!f_1192_15982_16034(this, waitChanges, blocks, readBackward: false))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 15977, 16075);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1192, 16069, 16075);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 15977, 16075);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 15657, 16102);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 15388, 16125);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 1, 992);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 1, 992);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 16164, 16218);

                    f_1192_16164_16217(
                                    s_tracer, "blocks read = {0}", f_1192_16204_16216(blocks));
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1192, 16247, 16924);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 16299, 16909) || true) && ((e is IOException) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 16303, 16370) || (e is ArgumentException)) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 16303, 16435) || (e is System.Security.SecurityException)) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 16303, 16494) || (e is UnauthorizedAccessException)) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 16303, 16547) || (e is ArgumentNullException)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 16299, 16909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 16706, 16806);

                        f_1192_16706_16805(                    // Exception contains specific message about the error occured and so no need for errordetails.
                                            _provider, f_1192_16727_16804(e, "GetContentReaderIOError", ErrorCategory.ReadError, _path));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 16828, 16840);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 16299, 16909);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 16299, 16909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 16903, 16909);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 16299, 16909);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1192, 16247, 16924);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 16940, 16964);

                return f_1192_16947_16963(blocks);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 14020, 16975);

                string
                f_1192_14196_14245()
                {
                    var return_v = FileSystemProviderStrings.RawAndWaitCannotCoexist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 14196, 14245);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1192_14153_14246(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 14153, 14246);
                    return return_v;
                }


                int
                f_1192_14329_14384(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 14329, 14384);
                    return 0;
                }


                System.Collections.Generic.List<object>
                f_1192_14414_14432()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 14414, 14432);
                    return return_v;
                }


                System.IO.Stream
                f_1192_14527_14545(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.BaseStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 14527, 14545);
                    return return_v;
                }


                long
                f_1192_14527_14554(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 14527, 14554);
                    return return_v;
                }


                System.Text.Encoding
                f_1192_14616_14639(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.CurrentEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 14616, 14639);
                    return return_v;
                }


                int
                f_1192_14937_14954(System.IO.FileStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 14937, 14954);
                    return 0;
                }


                int
                f_1192_14973_15036(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, string
                filePath, string
                streamName, System.IO.FileMode
                fileMode, System.IO.FileAccess
                fileAccess, System.IO.FileShare
                fileShare, System.Text.Encoding
                fileEncoding)
                {
                    this_param.CreateStreams(filePath, streamName, fileMode, fileAccess, fileShare, fileEncoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 14973, 15036);
                    return 0;
                }


                bool
                f_1192_15299_15317(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.Stopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 15299, 15317);
                    return return_v;
                }


                bool
                f_1192_15465_15522(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, bool
                waitChanges, System.Collections.Generic.List<object>
                blocks, bool
                readBackward)
                {
                    var return_v = this_param.ReadByteEncoded(waitChanges, blocks, readBackward: readBackward);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 15465, 15522);
                    return return_v;
                }


                bool
                f_1192_15755_15822(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, bool
                waitChanges, System.Collections.Generic.List<object>
                blocks, bool
                readBackward, string
                actualDelimiter)
                {
                    var return_v = this_param.ReadDelimited(waitChanges, blocks, readBackward: readBackward, actualDelimiter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 15755, 15822);
                    return return_v;
                }


                bool
                f_1192_15982_16034(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, bool
                waitChanges, System.Collections.Generic.List<object>
                blocks, bool
                readBackward)
                {
                    var return_v = this_param.ReadByLine(waitChanges, blocks, readBackward: readBackward);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 15982, 16034);
                    return return_v;
                }


                int
                f_1192_16204_16216(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 16204, 16216);
                    return return_v;
                }


                int
                f_1192_16164_16217(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 16164, 16217);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1192_16727_16804(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 16727, 16804);
                    return return_v;
                }


                int
                f_1192_16706_16805(System.Management.Automation.Provider.CmdletProvider
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 16706, 16805);
                    return 0;
                }


                object[]
                f_1192_16947_16963(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 16947, 16963);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 14020, 16975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 14020, 16975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IList ReadWithoutWaitingChanges(long readCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 17184, 17542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 17265, 17303);

                bool
                oldWaitChanges = _waitForChanges
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 17317, 17341);

                _waitForChanges = false;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 17391, 17414);

                    return f_1192_17398_17413(this, readCount);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1192, 17443, 17531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 17483, 17516);

                    _waitForChanges = oldWaitChanges;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1192, 17443, 17531);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 17184, 17542);

                System.Collections.IList
                f_1192_17398_17413(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, long
                readCount)
                {
                    var return_v = this_param.Read(readCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 17398, 17413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 17184, 17542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 17184, 17542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SeekItemsBackward(int backCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 17843, 23196);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 17914, 18127) || true) && (backCount < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 17914, 18127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18058, 18112);

                    throw f_1192_18064_18111("backCount");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 17914, 18127);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18143, 18327) || true) && (_isRawStream && (DynAbs.Tracing.TraceSender.Expression_True(1192, 18147, 18178) && _waitForChanges))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 18143, 18327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18212, 18312);

                    throw f_1192_18218_18311(f_1192_18261_18310());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 18143, 18327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18343, 18404);

                f_1192_18343_18403(
                            s_tracer, "blocks seek backwards = {0}", backCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18420, 18452);

                var
                blocks = f_1192_18433_18451()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18466, 18711) || true) && (_reader != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 18466, 18711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18589, 18615);

                    f_1192_18589_18614(this, 0, SeekOrigin.Begin);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18633, 18648);

                    f_1192_18633_18647(_reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18666, 18696);

                    _alreadyDetectEncoding = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 18466, 18711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18727, 18751);

                f_1192_18727_18750(this, 0, SeekOrigin.End);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 18767, 19049) || true) && (backCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 18767, 19049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 19027, 19034);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 18767, 19049);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 19065, 19417);

                string
                actualDelimiter = f_1192_19090_19416(f_1192_19122_19139(_delimiter), _delimiter, (chars, buf) =>
                                {
                                    for (int i = 0, j = buf.Length - 1; i < chars.Length; i++, j--)
                                    {
                                        chars[i] = buf[j];
                                    }
                                })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 19433, 19455);

                long
                currentBlock = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 19469, 19502);

                string
                lastDelimiterMatch = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 19554, 19883) || true) && (_isRawStream)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 19554, 19883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 19809, 19835);

                        f_1192_19809_19834(this, 0, SeekOrigin.Begin);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 19857, 19864);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 19554, 19883);
                    }
                    try
                    {
                        for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 19903, 21495) || true) && (currentBlock < backCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 19936, 19950)
        , ++currentBlock, DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 19903, 21495))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 19903, 21495);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 19992, 21437) || true) && (_usingByteEncoding)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 19992, 21437);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 20064, 20169) || true) && (!f_1192_20069_20132(this, waitChanges: false, blocks, readBackward: true))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 20064, 20169);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1192, 20163, 20169);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 20064, 20169);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 19992, 21437);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 19992, 21437);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 20267, 21414) || true) && (_usingDelimiter)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 20267, 21414);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 20344, 20468) || true) && (!f_1192_20349_20427(this, waitChanges: false, blocks, readBackward: true, actualDelimiter))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 20344, 20468);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1192, 20462, 20468);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 20344, 20468);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 20960, 20999);

                                    lastDelimiterMatch = (string)f_1192_20989_20998(blocks, 0);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 21029, 21169) || true) && (currentBlock == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1192, 21033, 21122) && f_1192_21054_21122(lastDelimiterMatch, actualDelimiter, StringComparison.Ordinal)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 21029, 21169);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 21157, 21169);

                                        backCount++;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 21029, 21169);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 20267, 21414);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 20267, 21414);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 21283, 21387) || true) && (!f_1192_21288_21346(this, waitChanges: false, blocks, readBackward: true))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 21283, 21387);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1192, 21381, 21387);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 21283, 21387);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 20267, 21414);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 19992, 21437);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 21461, 21476);

                            f_1192_21461_21475(
                                                blocks);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 1, 1593);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 1, 1593);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 21608, 22426) || true) && (!_usingByteEncoding)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 21608, 22426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 21673, 21731);

                        long
                        curStreamPosition = f_1192_21698_21730(_backReader)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 21753, 22341) || true) && (_usingDelimiter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 21753, 22341);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 21822, 22318) || true) && (currentBlock == backCount)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 21822, 22318);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 21909, 22032);

                                f_1192_21909_22031(lastDelimiterMatch != null, "lastDelimiterMatch should not be null when currentBlock == backCount");

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 22062, 22291) || true) && (f_1192_22066_22136(lastDelimiterMatch, actualDelimiter, StringComparison.Ordinal))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 22062, 22291);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 22202, 22260);

                                    curStreamPosition += f_1192_22223_22259(_backReader, _delimiter);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 22062, 22291);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 21822, 22318);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 21753, 22341);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 22365, 22407);

                        f_1192_22365_22406(this, curStreamPosition, SeekOrigin.Begin);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 21608, 22426);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 22446, 22513);

                    f_1192_22446_22512(
                                    s_tracer, "blocks seek position = {0}", f_1192_22495_22511(_stream));
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1192, 22542, 23185);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 22594, 23170) || true) && ((e is IOException) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 22598, 22665) || (e is ArgumentException)) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 22598, 22730) || (e is System.Security.SecurityException)) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 22598, 22789) || (e is UnauthorizedAccessException)) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 22598, 22842) || (e is ArgumentNullException)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 22594, 23170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 23001, 23101);

                        f_1192_23001_23100(                    // Exception contains specific message about the error occured and so no need for errordetails.
                                            _provider, f_1192_23022_23099(e, "GetContentReaderIOError", ErrorCategory.ReadError, _path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 22594, 23170);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 22594, 23170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 23164, 23170);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 22594, 23170);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1192, 22542, 23185);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 17843, 23196);

                System.Management.Automation.PSArgumentException
                f_1192_18064_18111(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 18064, 18111);
                    return return_v;
                }


                string
                f_1192_18261_18310()
                {
                    var return_v = FileSystemProviderStrings.RawAndWaitCannotCoexist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 18261, 18310);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1192_18218_18311(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 18218, 18311);
                    return return_v;
                }


                int
                f_1192_18343_18403(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 18343, 18403);
                    return 0;
                }


                System.Collections.Generic.List<object>
                f_1192_18433_18451()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 18433, 18451);
                    return return_v;
                }


                int
                f_1192_18589_18614(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 18589, 18614);
                    return 0;
                }


                int
                f_1192_18633_18647(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 18633, 18647);
                    return return_v;
                }


                int
                f_1192_18727_18750(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 18727, 18750);
                    return 0;
                }


                int
                f_1192_19122_19139(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 19122, 19139);
                    return return_v;
                }


                string
                f_1192_19090_19416(int
                length, string
                state, System.Buffers.SpanAction<char, string>
                action)
                {
                    var return_v = string.Create(length, state, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 19090, 19416);
                    return return_v;
                }


                int
                f_1192_19809_19834(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 19809, 19834);
                    return 0;
                }


                bool
                f_1192_20069_20132(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, bool
                waitChanges, System.Collections.Generic.List<object>
                blocks, bool
                readBackward)
                {
                    var return_v = this_param.ReadByteEncoded(waitChanges: waitChanges, blocks, readBackward: readBackward);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 20069, 20132);
                    return return_v;
                }


                bool
                f_1192_20349_20427(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, bool
                waitChanges, System.Collections.Generic.List<object>
                blocks, bool
                readBackward, string
                actualDelimiter)
                {
                    var return_v = this_param.ReadDelimited(waitChanges: waitChanges, blocks, readBackward: readBackward, actualDelimiter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 20349, 20427);
                    return return_v;
                }


                object
                f_1192_20989_20998(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 20989, 20998);
                    return return_v;
                }


                bool
                f_1192_21054_21122(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 21054, 21122);
                    return return_v;
                }


                bool
                f_1192_21288_21346(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, bool
                waitChanges, System.Collections.Generic.List<object>
                blocks, bool
                readBackward)
                {
                    var return_v = this_param.ReadByLine(waitChanges: waitChanges, blocks, readBackward: readBackward);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 21288, 21346);
                    return return_v;
                }


                int
                f_1192_21461_21475(System.Collections.Generic.List<object>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 21461, 21475);
                    return 0;
                }


                long
                f_1192_21698_21730(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.GetCurrentPosition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 21698, 21730);
                    return return_v;
                }


                int
                f_1192_21909_22031(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 21909, 22031);
                    return 0;
                }


                bool
                f_1192_22066_22136(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 22066, 22136);
                    return return_v;
                }


                int
                f_1192_22223_22259(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param, string
                delimiter)
                {
                    var return_v = this_param.GetByteCount(delimiter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 22223, 22259);
                    return return_v;
                }


                int
                f_1192_22365_22406(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, long
                offset, System.IO.SeekOrigin
                origin)
                {
                    this_param.Seek(offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 22365, 22406);
                    return 0;
                }


                long
                f_1192_22495_22511(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 22495, 22511);
                    return return_v;
                }


                int
                f_1192_22446_22512(System.Management.Automation.PSTraceSource
                this_param, string
                format, long
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 22446, 22512);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1192_23022_23099(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 23022, 23099);
                    return return_v;
                }


                int
                f_1192_23001_23100(System.Management.Automation.Provider.CmdletProvider
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 23001, 23100);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 17843, 23196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 17843, 23196);
            }
        }

        private bool ReadByLine(bool waitChanges, List<object> blocks, bool readBackward)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 23208, 24336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 23355, 23428);

                string
                line = (DynAbs.Tracing.TraceSender.Conditional_F1(1192, 23369, 23381) || ((readBackward && DynAbs.Tracing.TraceSender.Conditional_F2(1192, 23384, 23406)) || DynAbs.Tracing.TraceSender.Conditional_F3(1192, 23409, 23427))) ? f_1192_23384_23406(_backReader) : f_1192_23409_23427(_reader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 23444, 23969) || true) && (line == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 23444, 23969);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 23494, 23954) || true) && (waitChanges)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 23494, 23954);
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 23668, 23935);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 23719, 23790);

                                    f_1192_23719_23789(this, _path, _mode, _access, _share, f_1192_23765_23788(_reader));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 23816, 23842);

                                    line = f_1192_23823_23841(_reader);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 23668, 23935);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 23668, 23935) || true) && ((line == null) && (DynAbs.Tracing.TraceSender.Expression_True(1192, 23894, 23933) && (f_1192_23913_23932_M(!_provider.Stopping))))
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 23668, 23935);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 23668, 23935);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 23494, 23954);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 23444, 23969);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 23985, 24067) || true) && (line != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 23985, 24067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 24035, 24052);

                    f_1192_24035_24051(blocks, line);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 23985, 24067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 24083, 24151);

                int
                peekResult = (DynAbs.Tracing.TraceSender.Conditional_F1(1192, 24100, 24112) || ((readBackward && DynAbs.Tracing.TraceSender.Conditional_F2(1192, 24115, 24133)) || DynAbs.Tracing.TraceSender.Conditional_F3(1192, 24136, 24150))) ? f_1192_24115_24133(_backReader) : f_1192_24136_24150(_reader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 24165, 24325) || true) && (peekResult == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 24165, 24325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 24219, 24232);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 24165, 24325);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 24165, 24325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 24298, 24310);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 24165, 24325);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 23208, 24336);

                string
                f_1192_23384_23406(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 23384, 23406);
                    return return_v;
                }


                string?
                f_1192_23409_23427(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 23409, 23427);
                    return return_v;
                }


                System.Text.Encoding
                f_1192_23765_23788(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.CurrentEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 23765, 23788);
                    return return_v;
                }


                int
                f_1192_23719_23789(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, string
                filePath, System.IO.FileMode
                fileMode, System.IO.FileAccess
                fileAccess, System.IO.FileShare
                fileShare, System.Text.Encoding
                fileEncoding)
                {
                    this_param.WaitForChanges(filePath, fileMode, fileAccess, fileShare, fileEncoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 23719, 23789);
                    return 0;
                }


                string?
                f_1192_23823_23841(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 23823, 23841);
                    return return_v;
                }


                bool
                f_1192_23913_23932_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 23913, 23932);
                    return return_v;
                }


                int
                f_1192_24035_24051(System.Collections.Generic.List<object>
                this_param, string
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 24035, 24051);
                    return 0;
                }


                int
                f_1192_24115_24133(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 24115, 24133);
                    return return_v;
                }


                int
                f_1192_24136_24150(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 24136, 24150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 23208, 24336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 23208, 24336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ReadDelimited(bool waitChanges, List<object> blocks, bool readBackward, string actualDelimiter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 24348, 30771);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 24481, 24966) || true) && (_isRawStream)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 24481, 24966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 24686, 24727);

                    string
                    contentRead = f_1192_24707_24726(_reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 24745, 24856) || true) && (f_1192_24749_24767(contentRead) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 24745, 24856);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 24813, 24837);

                        f_1192_24813_24836(blocks, contentRead);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 24745, 24856);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 24938, 24951);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 24481, 24966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 25539, 25555);

                int
                numRead = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 25569, 25612);

                int
                currentOffset = f_1192_25589_25611(actualDelimiter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 25626, 25681);

                Span<char>
                readBuffer = stackalloc char[currentOffset]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 25695, 25725);

                bool
                delimiterNotFound = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 25739, 25767);

                f_1192_25739_25766(_currentLineContent);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 25783, 29263);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 25879, 26074);

                            numRead = (DynAbs.Tracing.TraceSender.Conditional_F1(1192, 25889, 25901) || ((readBackward
                            && DynAbs.Tracing.TraceSender.Conditional_F2(1192, 25937, 25989)) || DynAbs.Tracing.TraceSender.Conditional_F3(1192, 26025, 26073))) ? f_1192_25937_25989(_backReader, readBuffer.Slice(0, currentOffset)) : f_1192_26025_26073(_reader, readBuffer.Slice(0, currentOffset));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 26230, 27114) || true) && (numRead == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 26230, 27114);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 26288, 27095) || true) && (waitChanges)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 26288, 27095);
                                    try
                                    {
                                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 26426, 27072) || true) && ((numRead < currentOffset) && (DynAbs.Tracing.TraceSender.Expression_True(1192, 26433, 26483) && (f_1192_26463_26482_M(!_provider.Stopping))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 26426, 27072);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 26874, 26945);

                                            f_1192_26874_26944(this, _path, _mode, _access, _share, f_1192_26920_26943(_reader));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 26975, 27045);

                                            numRead += f_1192_26986_27044(_reader, readBuffer.Slice(0, currentOffset - numRead));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 26426, 27072);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 26426, 27072);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 26426, 27072);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 26288, 27095);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 26230, 27114);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 27134, 29190) || true) && (numRead > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 27134, 29190);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 27191, 27248);

                                f_1192_27191_27247(_currentLineContent, readBuffer.Slice(0, numRead));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 27732, 27802);

                                var
                                currentChar = f_1192_27750_27801(_currentLineContent, f_1192_27770_27796(_currentLineContent) - 1)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 27824, 27898);

                                currentOffset = _offsetDictionary[f_1192_27858_27896(ref currentChar)];
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28028, 28053);

                                delimiterNotFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28337, 29171) || true) && (currentOffset == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 28337, 29171);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28409, 28427);

                                    currentOffset = 1;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28455, 29148) || true) && (f_1192_28459_28481(actualDelimiter) <= f_1192_28485_28511(_currentLineContent))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 28455, 29148);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28569, 28595);

                                        delimiterNotFound = false;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28625, 28635);

                                        int
                                        i = 0
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28665, 28725);

                                        int
                                        j = f_1192_28673_28699(_currentLineContent) - f_1192_28702_28724(actualDelimiter)
                                        ;
                                        try
                                        {
                                            for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28755, 29121) || true) && (i < f_1192_28766_28788(actualDelimiter))
           ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28790, 28793)
           , i++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28795, 28798)
           , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 28755, 29121))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 28755, 29121);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28864, 29090) || true) && (f_1192_28868_28886(actualDelimiter, i) != f_1192_28890_28912(_currentLineContent, j))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 28864, 29090);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 28986, 29011);

                                                    delimiterNotFound = true;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(1192, 29049, 29055);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 28864, 29090);
                                                }
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 1, 367);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 1, 367);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 28455, 29148);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 28337, 29171);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 27134, 29190);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 25783, 29263);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 25783, 29263) || true) && (delimiterNotFound && (DynAbs.Tracing.TraceSender.Expression_True(1192, 29226, 29261) && (numRead != 0)))
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 25783, 29263);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 25783, 29263);
                    }
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 29341, 30359) || true) && (f_1192_29345_29371(_currentLineContent) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 29341, 30359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 30104, 30344);

                    f_1192_30104_30343(                // Add the block read to the ouptut array list, trimming a trailing delimiter, if present.
                                                       // Note: If -Tail was specified, we get here in the course of 2 distinct passes:
                                                       //  - Once while reading backward simply to determine the appropriate *start position* for later forward reading, ignoring the content of the blocks read (in reverse).
                                                       //  - Then again during forward reading, for regular output processing; it is only then that trimming the delimiter is necessary.
                                                       //    (Trimming it during backward reading would not only be unnecessary, but could interfere with determining the correct start position.)
                                    blocks, (DynAbs.Tracing.TraceSender.Conditional_F1(1192, 30137, 30172) || ((!readBackward && (DynAbs.Tracing.TraceSender.Expression_True(1192, 30137, 30172) && !delimiterNotFound
                    ) && DynAbs.Tracing.TraceSender.Conditional_F2(1192, 30200, 30284)) || DynAbs.Tracing.TraceSender.Conditional_F3(1192, 30312, 30342))) ? f_1192_30200_30284(_currentLineContent, 0, f_1192_30232_30258(_currentLineContent) - f_1192_30261_30283(actualDelimiter)) : f_1192_30312_30342(_currentLineContent));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 29341, 30359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 30375, 30443);

                int
                peekResult = (DynAbs.Tracing.TraceSender.Conditional_F1(1192, 30392, 30404) || ((readBackward && DynAbs.Tracing.TraceSender.Conditional_F2(1192, 30407, 30425)) || DynAbs.Tracing.TraceSender.Conditional_F3(1192, 30428, 30442))) ? f_1192_30407_30425(_backReader) : f_1192_30428_30442(_reader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 30457, 30760) || true) && (peekResult != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 30457, 30760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 30511, 30523);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 30457, 30760);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 30457, 30760);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 30589, 30712) || true) && (readBackward && (DynAbs.Tracing.TraceSender.Expression_True(1192, 30593, 30639) && f_1192_30609_30635(_currentLineContent) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 30589, 30712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 30681, 30693);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 30589, 30712);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 30732, 30745);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 30457, 30760);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 24348, 30771);

                string
                f_1192_24707_24726(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 24707, 24726);
                    return return_v;
                }


                int
                f_1192_24749_24767(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 24749, 24767);
                    return return_v;
                }


                int
                f_1192_24813_24836(System.Collections.Generic.List<object>
                this_param, string
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 24813, 24836);
                    return 0;
                }


                int
                f_1192_25589_25611(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 25589, 25611);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1192_25739_25766(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 25739, 25766);
                    return return_v;
                }


                int
                f_1192_25937_25989(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param, System.Span<char>
                buffer)
                {
                    var return_v = this_param.Read(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 25937, 25989);
                    return return_v;
                }


                int
                f_1192_26025_26073(System.IO.StreamReader
                this_param, System.Span<char>
                buffer)
                {
                    var return_v = this_param.Read(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 26025, 26073);
                    return return_v;
                }


                bool
                f_1192_26463_26482_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 26463, 26482);
                    return return_v;
                }


                System.Text.Encoding
                f_1192_26920_26943(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.CurrentEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 26920, 26943);
                    return return_v;
                }


                int
                f_1192_26874_26944(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, string
                filePath, System.IO.FileMode
                fileMode, System.IO.FileAccess
                fileAccess, System.IO.FileShare
                fileShare, System.Text.Encoding
                fileEncoding)
                {
                    this_param.WaitForChanges(filePath, fileMode, fileAccess, fileShare, fileEncoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 26874, 26944);
                    return 0;
                }


                int
                f_1192_26986_27044(System.IO.StreamReader
                this_param, System.Span<char>
                buffer)
                {
                    var return_v = this_param.Read(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 26986, 27044);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1192_27191_27247(System.Text.StringBuilder
                this_param, System.Span<char>
                value)
                {
                    var return_v = this_param.Append((System.ReadOnlySpan<char>)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 27191, 27247);
                    return return_v;
                }


                int
                f_1192_27770_27796(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 27770, 27796);
                    return return_v;
                }


                char
                f_1192_27750_27801(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 27750, 27801);
                    return return_v;
                }


                byte
                f_1192_27858_27896(ref char
                source)
                {
                    var return_v = Unsafe.As<char, byte>(ref source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 27858, 27896);
                    return return_v;
                }


                int
                f_1192_28459_28481(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 28459, 28481);
                    return return_v;
                }


                int
                f_1192_28485_28511(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 28485, 28511);
                    return return_v;
                }


                int
                f_1192_28673_28699(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 28673, 28699);
                    return return_v;
                }


                int
                f_1192_28702_28724(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 28702, 28724);
                    return return_v;
                }


                int
                f_1192_28766_28788(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 28766, 28788);
                    return return_v;
                }


                char
                f_1192_28868_28886(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 28868, 28886);
                    return return_v;
                }


                char
                f_1192_28890_28912(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 28890, 28912);
                    return return_v;
                }


                int
                f_1192_29345_29371(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 29345, 29371);
                    return return_v;
                }


                int
                f_1192_30232_30258(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 30232, 30258);
                    return return_v;
                }


                int
                f_1192_30261_30283(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 30261, 30283);
                    return return_v;
                }


                string
                f_1192_30200_30284(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.ToString(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 30200, 30284);
                    return return_v;
                }


                string
                f_1192_30312_30342(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 30312, 30342);
                    return return_v;
                }


                int
                f_1192_30104_30343(System.Collections.Generic.List<object>
                this_param, string
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 30104, 30343);
                    return 0;
                }


                int
                f_1192_30407_30425(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 30407, 30425);
                    return return_v;
                }


                int
                f_1192_30428_30442(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 30428, 30442);
                    return return_v;
                }


                int
                f_1192_30609_30635(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 30609, 30635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 24348, 30771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 24348, 30771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ReadByteEncoded(bool waitChanges, List<object> blocks, bool readBackward)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 30783, 33131);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 30894, 31981) || true) && (_isRawStream)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 30894, 31981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31078, 31118);

                    byte[]
                    bytes = new byte[f_1192_31102_31116(_stream)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31136, 31177);

                    int
                    numBytesToRead = (int)f_1192_31162_31176(_stream)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31195, 31216);

                    int
                    numBytesRead = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31234, 31717) || true) && (numBytesToRead > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 31234, 31717);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31376, 31434);

                            int
                            n = f_1192_31384_31433(_stream, bytes, numBytesRead, numBytesToRead)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31525, 31614) || true) && (n == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 31525, 31614);
                                DynAbs.Tracing.TraceSender.TraceBreak(1192, 31585, 31591);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 31525, 31614);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31638, 31656);

                            numBytesRead += n;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31678, 31698);

                            numBytesToRead -= n;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 31234, 31717);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 31234, 31717);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 31234, 31717);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31737, 31966) || true) && (numBytesRead == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 31737, 31966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31800, 31813);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 31737, 31966);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 31737, 31966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31895, 31913);

                        f_1192_31895_31912(blocks, bytes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31935, 31947);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 31737, 31966);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 30894, 31981);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 31997, 32322) || true) && (readBackward)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 31997, 32322);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32047, 32146) || true) && (f_1192_32051_32067(_stream) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 32047, 32146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32114, 32127);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 32047, 32146);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32166, 32185);

                    f_1192_32166_32184_M(_stream.Position--);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32203, 32240);

                    f_1192_32203_32239(blocks, (byte)f_1192_32220_32238(_stream));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32258, 32277);

                    f_1192_32258_32276_M(_stream.Position--);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32295, 32307);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 31997, 32322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32380, 32414);

                int
                byteRead = f_1192_32395_32413(_stream)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32479, 32842) || true) && (byteRead == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 32479, 32842);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32621, 32827) || true) && (waitChanges)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 32621, 32827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32678, 32756);

                        f_1192_32678_32755(this, _path, _mode, _access, _share, f_1192_32724_32754());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32778, 32808);

                        byteRead = f_1192_32789_32807(_stream);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 32621, 32827);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 32479, 32842);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32917, 33120) || true) && (byteRead != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 32917, 33120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 32969, 32996);

                    f_1192_32969_32995(blocks, (byte)byteRead);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 33014, 33026);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 32917, 33120);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 32917, 33120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 33092, 33105);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 32917, 33120);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 30783, 33131);

                long
                f_1192_31102_31116(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 31102, 31116);
                    return return_v;
                }


                long
                f_1192_31162_31176(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 31162, 31176);
                    return return_v;
                }


                int
                f_1192_31384_31433(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 31384, 31433);
                    return return_v;
                }


                int
                f_1192_31895_31912(System.Collections.Generic.List<object>
                this_param, byte[]
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 31895, 31912);
                    return 0;
                }


                long
                f_1192_32051_32067(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 32051, 32067);
                    return return_v;
                }


                long
                f_1192_32166_32184_M(long
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 32166, 32184);
                    return return_v;
                }


                int
                f_1192_32220_32238(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 32220, 32238);
                    return return_v;
                }


                int
                f_1192_32203_32239(System.Collections.Generic.List<object>
                this_param, byte
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 32203, 32239);
                    return 0;
                }


                long
                f_1192_32258_32276_M(long
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 32258, 32276);
                    return return_v;
                }


                int
                f_1192_32395_32413(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 32395, 32413);
                    return return_v;
                }


                System.Text.Encoding
                f_1192_32724_32754()
                {
                    var return_v = ClrFacade.GetDefaultEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 32724, 32754);
                    return return_v;
                }


                int
                f_1192_32678_32755(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, string
                filePath, System.IO.FileMode
                fileMode, System.IO.FileAccess
                fileAccess, System.IO.FileShare
                fileShare, System.Text.Encoding
                fileEncoding)
                {
                    this_param.WaitForChanges(filePath, fileMode, fileAccess, fileShare, fileEncoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 32678, 32755);
                    return 0;
                }


                int
                f_1192_32789_32807(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 32789, 32807);
                    return return_v;
                }


                int
                f_1192_32969_32995(System.Collections.Generic.List<object>
                this_param, byte
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 32969, 32995);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 30783, 33131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 30783, 33131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CreateStreams(string filePath, string streamName, FileMode fileMode, FileAccess fileAccess, FileShare fileShare, Encoding fileEncoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 33143, 36343);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 33428, 34142) || true) && (f_1192_33432_33453(filePath) && (DynAbs.Tracing.TraceSender.Expression_True(1192, 33432, 33472) && f_1192_33457_33472(_provider)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 33428, 34142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 33615, 33661);

                    _oldAttributes = f_1192_33632_33660(filePath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 33679, 33705);

                    _haveOldAttributes = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 33816, 33862);

                    var
                    attributesToClear = FileAttributes.Hidden
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 33880, 34028) || true) && ((fileAccess & (FileAccess.Write)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 33880, 34028);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 33964, 34009);

                        attributesToClear |= FileAttributes.ReadOnly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 33880, 34028);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 34048, 34127);

                    f_1192_34048_34126(_path, (f_1192_34075_34103(filePath) & ~attributesToClear));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 33428, 34142);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 34326, 34366);

                FileAccess
                requestedAccess = fileAccess
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 34380, 34505) || true) && ((fileAccess & (FileAccess.Write)) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 34380, 34505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 34456, 34490);

                    fileAccess = FileAccess.ReadWrite;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 34380, 34505);
                }

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 34568, 34935) || true) && (!f_1192_34573_34605(streamName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 34568, 34935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 34647, 34758);

                        _stream = f_1192_34657_34757(filePath, streamName, fileMode, fileAccess, fileShare);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 34568, 34935);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 34568, 34935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 34848, 34916);

                        _stream = f_1192_34858_34915(filePath, fileMode, fileAccess, fileShare);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 34568, 34935);
                    }
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1192, 34964, 35419);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 35027, 35404) || true) && (!f_1192_35032_35064(streamName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 35027, 35404);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 35106, 35222);

                        _stream = f_1192_35116_35221(filePath, streamName, fileMode, requestedAccess, fileShare);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 35027, 35404);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 35027, 35404);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 35312, 35385);

                        _stream = f_1192_35322_35384(filePath, fileMode, requestedAccess, fileShare);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 35027, 35404);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1192, 34964, 35419);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 35435, 36332) || true) && (!_usingByteEncoding)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 35435, 36332);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 35535, 35771) || true) && ((fileAccess & (FileAccess.Read)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 35535, 35771);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 35618, 35668);

                        _reader = f_1192_35628_35667(_stream, fileEncoding);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 35690, 35752);

                        _backReader = f_1192_35704_35751(_stream, fileEncoding);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 35535, 35771);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 35834, 36317) || true) && ((fileAccess & (FileAccess.Write)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 35834, 36317);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 35982, 36224) || true) && ((_reader != null) && (DynAbs.Tracing.TraceSender.Expression_True(1192, 35986, 36071) && ((fileAccess & (FileAccess.Read)) != 0)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 35982, 36224);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 36121, 36136);

                            f_1192_36121_36135(_reader);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 36162, 36201);

                            fileEncoding = f_1192_36177_36200(_reader);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 35982, 36224);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 36248, 36298);

                        _writer = f_1192_36258_36297(_stream, fileEncoding);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 35834, 36317);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 35435, 36332);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 33143, 36343);

                bool
                f_1192_33432_33453(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 33432, 33453);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1192_33457_33472(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 33457, 33472);
                    return return_v;
                }


                System.IO.FileAttributes
                f_1192_33632_33660(string
                path)
                {
                    var return_v = File.GetAttributes(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 33632, 33660);
                    return return_v;
                }


                System.IO.FileAttributes
                f_1192_34075_34103(string
                path)
                {
                    var return_v = File.GetAttributes(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 34075, 34103);
                    return return_v;
                }


                int
                f_1192_34048_34126(string
                path, System.IO.FileAttributes
                fileAttributes)
                {
                    File.SetAttributes(path, fileAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 34048, 34126);
                    return 0;
                }


                bool
                f_1192_34573_34605(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 34573, 34605);
                    return return_v;
                }


                System.IO.FileStream
                f_1192_34657_34757(string
                path, string
                streamName, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = AlternateDataStreamUtilities.CreateFileStream(path, streamName, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 34657, 34757);
                    return return_v;
                }


                System.IO.FileStream
                f_1192_34858_34915(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 34858, 34915);
                    return return_v;
                }


                bool
                f_1192_35032_35064(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 35032, 35064);
                    return return_v;
                }


                System.IO.FileStream
                f_1192_35116_35221(string
                path, string
                streamName, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = AlternateDataStreamUtilities.CreateFileStream(path, streamName, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 35116, 35221);
                    return return_v;
                }


                System.IO.FileStream
                f_1192_35322_35384(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 35322, 35384);
                    return return_v;
                }


                System.IO.StreamReader
                f_1192_35628_35667(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 35628, 35667);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.FileStreamBackReader
                f_1192_35704_35751(System.IO.FileStream
                fileStream, System.Text.Encoding
                encoding)
                {
                    var return_v = new Microsoft.PowerShell.Commands.FileStreamBackReader(fileStream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 35704, 35751);
                    return return_v;
                }


                int
                f_1192_36121_36135(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 36121, 36135);
                    return return_v;
                }


                System.Text.Encoding
                f_1192_36177_36200(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.CurrentEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 36177, 36200);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1192_36258_36297(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 36258, 36297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 33143, 36343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 33143, 36343);
            }
        }

        private void WaitForChanges(string filePath, FileMode fileMode, FileAccess fileAccess, FileShare fileShare, Encoding fileEncoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 37081, 41117);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 37306, 37441) || true) && (_stream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 37306, 37441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 37359, 37390);

                    _fileOffset = f_1192_37373_37389(_stream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 37408, 37426);

                    f_1192_37408_37425(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 37306, 37441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 37512, 37556);

                FileInfo
                watchFile = f_1192_37533_37555(filePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 37570, 37609);

                long
                originalLength = f_1192_37592_37608(watchFile)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 37625, 40281);
                using (FileSystemWatcher
                watcher = f_1192_37660_37722(f_1192_37682_37705(watchFile), f_1192_37707_37721(watchFile))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 37756, 37793);

                    ErrorEventArgs
                    errorEventArgs = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 37811, 37869);

                    var
                    tcs = f_1192_37821_37868()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 37887, 37996);

                    FileSystemEventHandler
                    onChangedHandler = (object source, FileSystemEventArgs e) => { tcs.TrySetResult(e); }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 38014, 38117);

                    RenamedEventHandler
                    onRenamedHandler = (object source, RenamedEventArgs e) => { tcs.TrySetResult(e); }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 38135, 38415);

                    ErrorEventHandler
                    onErrorHandler = (object source, ErrorEventArgs e) =>
                                    {
                                        errorEventArgs = e;
                                        tcs.TrySetResult(new FileSystemEventArgs(WatcherChangeTypes.All, watchFile.DirectoryName, watchFile.Name));
                                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 38536, 38572);

                    watcher.Changed += onChangedHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 38590, 38626);

                    watcher.Created += onChangedHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 38644, 38680);

                    watcher.Deleted += onChangedHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 38698, 38734);

                    watcher.Renamed += onRenamedHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 38752, 38784);

                    watcher.Error += onErrorHandler;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 38848, 38883);

                        watcher.EnableRaisingEvents = true;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 38907, 39681) || true) && (f_1192_38914_38933_M(!_provider.Stopping))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 38907, 39681);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 38983, 39025);

                                bool
                                isTaskCompleted = f_1192_39006_39024(f_1192_39006_39014(tcs), 500)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 39053, 39200) || true) && (errorEventArgs != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 39053, 39200);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 39137, 39173);

                                    throw f_1192_39143_39172(errorEventArgs);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 39053, 39200);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 39228, 39284) || true) && (isTaskCompleted)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 39228, 39284);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1192, 39278, 39284);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 39228, 39284);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 39483, 39503);

                                f_1192_39483_39502(
                                                        // If a process is still writing, .NET doesn't generate a change notification.
                                                        // So do a simple comparison on file size
                                                        watchFile);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 39529, 39658) || true) && (originalLength != f_1192_39551_39567(watchFile))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 39529, 39658);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1192, 39625, 39631);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 39529, 39658);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 38907, 39681);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 38907, 39681);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 38907, 39681);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1192, 39718, 40266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 39925, 39961);

                        watcher.EnableRaisingEvents = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 39983, 40019);

                        watcher.Changed -= onChangedHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40041, 40077);

                        watcher.Created -= onChangedHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40099, 40135);

                        watcher.Deleted -= onChangedHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40157, 40193);

                        watcher.Renamed -= onRenamedHandler;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40215, 40247);

                        watcher.Error -= onErrorHandler;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1192, 39718, 40266);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1192, 37625, 40281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40477, 40512);

                f_1192_40477_40511(100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40564, 40641);

                f_1192_40564_40640(this, filePath, null, fileMode, fileAccess, fileShare, fileEncoding);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40779, 40846) || true) && (_fileOffset > f_1192_40797_40811(_stream))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 40779, 40846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40830, 40846);

                    _fileOffset = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 40779, 40846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40914, 40958);

                f_1192_40914_40957(
                            // Seek to the place we last left off.
                            _stream, _fileOffset, SeekOrigin.Begin);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40972, 41027) || true) && (_reader != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 40972, 41027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 40995, 41025);

                    f_1192_40995_41024(_reader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 40972, 41027);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41043, 41106) || true) && (_backReader != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 41043, 41106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41070, 41104);

                    f_1192_41070_41103(_backReader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 41043, 41106);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 37081, 41117);

                long
                f_1192_37373_37389(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 37373, 37389);
                    return return_v;
                }


                int
                f_1192_37408_37425(System.IO.FileStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 37408, 37425);
                    return 0;
                }


                System.IO.FileInfo
                f_1192_37533_37555(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 37533, 37555);
                    return return_v;
                }


                long
                f_1192_37592_37608(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 37592, 37608);
                    return return_v;
                }


                string
                f_1192_37682_37705(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.DirectoryName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 37682, 37705);
                    return return_v;
                }


                string
                f_1192_37707_37721(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 37707, 37721);
                    return return_v;
                }


                System.IO.FileSystemWatcher
                f_1192_37660_37722(string
                path, string
                filter)
                {
                    var return_v = new System.IO.FileSystemWatcher(path, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 37660, 37722);
                    return return_v;
                }


                System.Threading.Tasks.TaskCompletionSource<System.IO.FileSystemEventArgs>
                f_1192_37821_37868()
                {
                    var return_v = new System.Threading.Tasks.TaskCompletionSource<System.IO.FileSystemEventArgs>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 37821, 37868);
                    return return_v;
                }


                bool
                f_1192_38914_38933_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 38914, 38933);
                    return return_v;
                }


                System.Threading.Tasks.Task<System.IO.FileSystemEventArgs>
                f_1192_39006_39014(System.Threading.Tasks.TaskCompletionSource<System.IO.FileSystemEventArgs>
                this_param)
                {
                    var return_v = this_param.Task;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 39006, 39014);
                    return return_v;
                }


                bool
                f_1192_39006_39024(System.Threading.Tasks.Task<System.IO.FileSystemEventArgs>
                this_param, int
                millisecondsTimeout)
                {
                    var return_v = this_param.Wait(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 39006, 39024);
                    return return_v;
                }


                System.Exception
                f_1192_39143_39172(System.IO.ErrorEventArgs
                this_param)
                {
                    var return_v = this_param.GetException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 39143, 39172);
                    return return_v;
                }


                int
                f_1192_39483_39502(System.IO.FileInfo
                this_param)
                {
                    this_param.Refresh();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 39483, 39502);
                    return 0;
                }


                long
                f_1192_39551_39567(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 39551, 39567);
                    return return_v;
                }


                int
                f_1192_40477_40511(int
                millisecondsTimeout)
                {
                    System.Threading.Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 40477, 40511);
                    return 0;
                }


                int
                f_1192_40564_40640(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, string
                filePath, string
                streamName, System.IO.FileMode
                fileMode, System.IO.FileAccess
                fileAccess, System.IO.FileShare
                fileShare, System.Text.Encoding
                fileEncoding)
                {
                    this_param.CreateStreams(filePath, streamName, fileMode, fileAccess, fileShare, fileEncoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 40564, 40640);
                    return 0;
                }


                long
                f_1192_40797_40811(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 40797, 40811);
                    return return_v;
                }


                long
                f_1192_40914_40957(System.IO.FileStream
                this_param, long
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek(offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 40914, 40957);
                    return return_v;
                }


                int
                f_1192_40995_41024(System.IO.StreamReader
                this_param)
                {
                    this_param.DiscardBufferedData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 40995, 41024);
                    return 0;
                }


                int
                f_1192_41070_41103(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    this_param.DiscardBufferedData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 41070, 41103);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 37081, 41117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 37081, 41117);
            }
        }

        public void Seek(long offset, SeekOrigin origin)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 41476, 41853);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41549, 41590) || true) && (_writer != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 41549, 41590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41572, 41588);

                    f_1192_41572_41587(_writer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 41549, 41590);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41606, 41635);

                f_1192_41606_41634(
                            _stream, offset, origin);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41651, 41692) || true) && (_writer != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 41651, 41692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41674, 41690);

                    f_1192_41674_41689(_writer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 41651, 41692);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41708, 41763) || true) && (_reader != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 41708, 41763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41731, 41761);

                    f_1192_41731_41760(_reader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 41708, 41763);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41779, 41842) || true) && (_backReader != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 41779, 41842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41806, 41840);

                    f_1192_41806_41839(_backReader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 41779, 41842);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 41476, 41853);

                int
                f_1192_41572_41587(System.IO.StreamWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 41572, 41587);
                    return 0;
                }


                long
                f_1192_41606_41634(System.IO.FileStream
                this_param, long
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek(offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 41606, 41634);
                    return return_v;
                }


                int
                f_1192_41674_41689(System.IO.StreamWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 41674, 41689);
                    return 0;
                }


                int
                f_1192_41731_41760(System.IO.StreamReader
                this_param)
                {
                    this_param.DiscardBufferedData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 41731, 41760);
                    return 0;
                }


                int
                f_1192_41806_41839(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    this_param.DiscardBufferedData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 41806, 41839);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 41476, 41853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 41476, 41853);
            }
        }

        public void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 41942, 42938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 41986, 42012);

                bool
                streamClosed = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42028, 42320) || true) && (_writer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 42028, 42320);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42125, 42141);

                        f_1192_42125_42140(_writer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42163, 42181);

                        f_1192_42163_42180(_writer);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1192, 42218, 42305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42266, 42286);

                        streamClosed = true;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1192, 42218, 42305);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 42028, 42320);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42336, 42460) || true) && (_reader != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 42336, 42460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42389, 42407);

                    f_1192_42389_42406(_reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42425, 42445);

                    streamClosed = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 42336, 42460);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42476, 42608) || true) && (_backReader != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 42476, 42608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42533, 42555);

                    f_1192_42533_42554(_backReader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42573, 42593);

                    streamClosed = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 42476, 42608);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42624, 42742) || true) && (!streamClosed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 42624, 42742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42675, 42691);

                    f_1192_42675_42690(_stream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42709, 42727);

                    f_1192_42709_42726(_stream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 42624, 42742);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42795, 42927) || true) && (_haveOldAttributes && (DynAbs.Tracing.TraceSender.Expression_True(1192, 42799, 42836) && f_1192_42821_42836(_provider)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 42795, 42927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 42870, 42912);

                    f_1192_42870_42911(_path, _oldAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 42795, 42927);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 41942, 42938);

                int
                f_1192_42125_42140(System.IO.StreamWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 42125, 42140);
                    return 0;
                }


                int
                f_1192_42163_42180(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 42163, 42180);
                    return 0;
                }


                int
                f_1192_42389_42406(System.IO.StreamReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 42389, 42406);
                    return 0;
                }


                int
                f_1192_42533_42554(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 42533, 42554);
                    return 0;
                }


                int
                f_1192_42675_42690(System.IO.FileStream
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 42675, 42690);
                    return 0;
                }


                int
                f_1192_42709_42726(System.IO.FileStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 42709, 42726);
                    return 0;
                }


                System.Management.Automation.SwitchParameter
                f_1192_42821_42836(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 42821, 42836);
                    return return_v;
                }


                int
                f_1192_42870_42911(string
                path, System.IO.FileAttributes
                fileAttributes)
                {
                    File.SetAttributes(path, fileAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 42870, 42911);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 41942, 42938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 41942, 42938);
            }
        }

        public IList Write(IList content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 43248, 43797);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 43306, 43755);
                    foreach (object line in f_1192_43330_43337_I(content))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 43306, 43755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 43371, 43412);

                        object[]
                        contentArray = line as object[]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 43430, 43740) || true) && (contentArray != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 43430, 43740);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 43496, 43621);
                                foreach (object obj in f_1192_43519_43531_I(contentArray))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 43496, 43621);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 43581, 43598);

                                    f_1192_43581_43597(this, obj);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 43496, 43621);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 1, 126);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 1, 126);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 43430, 43740);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 43430, 43740);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 43703, 43721);

                            f_1192_43703_43720(this, line);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 43430, 43740);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 43306, 43755);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 1, 450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 1, 450);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 43771, 43786);

                return content;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 43248, 43797);

                int
                f_1192_43581_43597(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, object
                content)
                {
                    this_param.WriteObject(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 43581, 43597);
                    return 0;
                }


                object[]
                f_1192_43519_43531_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 43519, 43531);
                    return return_v;
                }


                int
                f_1192_43703_43720(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, object
                content)
                {
                    this_param.WriteObject(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 43703, 43720);
                    return 0;
                }


                System.Collections.IList
                f_1192_43330_43337_I(System.Collections.IList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 43330, 43337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 43248, 43797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 43248, 43797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteObject(object content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 43809, 44702);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 43874, 43949) || true) && (content == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 43874, 43949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 43927, 43934);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 43874, 43949);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 43965, 44691) || true) && (_usingByteEncoding)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 43965, 44691);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 44065, 44098);

                        byte
                        byteToWrite = (byte)content
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 44122, 44153);

                        f_1192_44122_44152(
                                            _stream, byteToWrite);
                    }
                    catch (InvalidCastException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1192, 44190, 44375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 44259, 44356);

                        throw f_1192_44265_44355("content", f_1192_44311_44354());
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1192, 44190, 44375);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 43965, 44691);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 43965, 44691);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 44441, 44676) || true) && (_suppressNewline)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 44441, 44676);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 44503, 44537);

                        f_1192_44503_44536(_writer, f_1192_44517_44535(content));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 44441, 44676);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 44441, 44676);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 44619, 44657);

                        f_1192_44619_44656(_writer, f_1192_44637_44655(content));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 44441, 44676);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 43965, 44691);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 43809, 44702);

                int
                f_1192_44122_44152(System.IO.FileStream
                this_param, byte
                value)
                {
                    this_param.WriteByte(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 44122, 44152);
                    return 0;
                }


                string
                f_1192_44311_44354()
                {
                    var return_v = FileSystemProviderStrings.ByteEncodingError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 44311, 44354);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1192_44265_44355(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 44265, 44355);
                    return return_v;
                }


                string?
                f_1192_44517_44535(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 44517, 44535);
                    return return_v;
                }


                int
                f_1192_44503_44536(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 44503, 44536);
                    return 0;
                }


                string?
                f_1192_44637_44655(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 44637, 44655);
                    return return_v;
                }


                int
                f_1192_44619_44656(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 44619, 44656);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 43809, 44702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 43809, 44702);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 44798, 44909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 44844, 44858);

                f_1192_44844_44857(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 44872, 44898);

                f_1192_44872_44897(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 44798, 44909);

                int
                f_1192_44844_44857(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                this_param, bool
                isDisposing)
                {
                    this_param.Dispose(isDisposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 44844, 44857);
                    return 0;
                }


                int
                f_1192_44872_44897(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 44872, 44897);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 44798, 44909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 44798, 44909);
            }
        }

        internal void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 44921, 45362);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 44985, 45351) || true) && (isDisposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 44985, 45351);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45034, 45094) || true) && (_stream != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 45034, 45094);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45076, 45094);

                        f_1192_45076_45093(_stream);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 45034, 45094);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45112, 45172) || true) && (_reader != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 45112, 45172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45154, 45172);

                        f_1192_45154_45171(_reader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 45112, 45172);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45190, 45258) || true) && (_backReader != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 45190, 45258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45236, 45258);

                        f_1192_45236_45257(_backReader);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 45190, 45258);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45276, 45336) || true) && (_writer != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 45276, 45336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45318, 45336);

                        f_1192_45318_45335(_writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 45276, 45336);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 44985, 45351);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 44921, 45362);

                int
                f_1192_45076_45093(System.IO.FileStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 45076, 45093);
                    return 0;
                }


                int
                f_1192_45154_45171(System.IO.StreamReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 45154, 45171);
                    return 0;
                }


                int
                f_1192_45236_45257(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 45236, 45257);
                    return 0;
                }


                int
                f_1192_45318_45335(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 45318, 45335);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 44921, 45362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 44921, 45362);
            }
        }

        static FileSystemContentReaderWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1192, 1000, 45369);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 1488, 1641);
            s_tracer = f_1192_1512_1641("FileSystemContentStream", "The provider content reader and writer for the file system");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 2114, 2137);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1192, 1000, 45369);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 1000, 45369);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1192, 1000, 45369);

        static System.Management.Automation.PSTraceSource
        f_1192_1512_1641(string
        name, string
        description)
        {
            var return_v = Dbg.PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 1512, 1641);
            return return_v;
        }


        static string
        f_1192_4338_4342_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1192, 4066, 4460);
            return return_v;
        }


        bool
        f_1192_6201_6227(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 6201, 6227);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1192_6267_6313(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 6267, 6313);
            return return_v;
        }


        bool
        f_1192_6349_6367(System.Management.Automation.PSTraceSource
        this_param)
        {
            var return_v = this_param.IsEnabled;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 6349, 6367);
            return return_v;
        }


        int
        f_1192_6401_6439(System.Management.Automation.PSTraceSource
        this_param, string
        format, string
        arg1)
        {
            this_param.WriteLine(format, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 6401, 6439);
            return 0;
        }


        int
        f_1192_6458_6496(System.Management.Automation.PSTraceSource
        this_param, string
        format, System.IO.FileMode
        arg1)
        {
            this_param.WriteLine(format, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 6458, 6496);
            return 0;
        }


        int
        f_1192_6515_6557(System.Management.Automation.PSTraceSource
        this_param, string
        format, System.IO.FileAccess
        arg1)
        {
            this_param.WriteLine(format, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 6515, 6557);
            return 0;
        }


        int
        f_1192_6955_7017(Microsoft.PowerShell.Commands.FileSystemContentReaderWriter
        this_param, string
        filePath, string
        streamName, System.IO.FileMode
        fileMode, System.IO.FileAccess
        fileAccess, System.IO.FileShare
        fileShare, System.Text.Encoding
        fileEncoding)
        {
            this_param.CreateStreams(filePath, streamName, fileMode, fileAccess, fileShare, fileEncoding);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 6955, 7017);
            return 0;
        }


        static string
        f_1192_8936_8940_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1192, 8623, 9113);
            return return_v;
        }


        int
        f_1192_11234_11250(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 11234, 11250);
            return return_v;
        }


        char
        f_1192_11259_11271(string
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 11259, 11271);
            return return_v;
        }


        System.Text.StringBuilder
        f_1192_11583_11619(int
        capacity)
        {
            var return_v = new System.Text.StringBuilder(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 11583, 11619);
            return return_v;
        }


        int
        f_1192_12831_12855(int[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 12831, 12855);
            return return_v;
        }


        int
        f_1192_12925_12942(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 12925, 12942);
            return return_v;
        }


        int
        f_1192_13166_13183(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 13166, 13183);
            return return_v;
        }


        char
        f_1192_13244_13257(string
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 13244, 13257);
            return return_v;
        }


        byte
        f_1192_13290_13328(ref char
        source)
        {
            var return_v = Unsafe.As<char, byte>(ref source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 13290, 13328);
            return return_v;
        }


        int
        f_1192_13380_13397(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 13380, 13397);
            return return_v;
        }


        static string
        f_1192_10945_10949_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1192, 10573, 13451);
            return return_v;
        }

    }
    internal sealed class FileStreamBackReader : StreamReader
    {
        internal FileStreamBackReader(FileStream fileStream, Encoding encoding)
        : base(f_1192_45543_45553_C(fileStream), encoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1192, 45451, 46254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46294, 46301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46338, 46354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46391, 46403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46440, 46460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46541, 46571);
                this._byteBuff = new byte[BuffSize];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46606, 46636);
                this._charBuff = new char[BuffSize];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46659, 46673);
                this._byteCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46696, 46710);
                this._charCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46734, 46754);
                this._currentPosition = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46779, 46804);
                this._singleByteCharSet = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45589, 45610);

                _stream = fileStream;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45624, 46243) || true) && (f_1192_45628_45642(_stream) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 45624, 46243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45680, 45716);

                    long
                    curPosition = f_1192_45699_45715(_stream)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45734, 45768);

                    f_1192_45734_45767(_stream, 0, SeekOrigin.Begin);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45786, 45798);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Peek(), 1192, 45786, 45797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45816, 45847);

                    _stream.Position = curPosition;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45865, 45905);

                    _currentEncoding = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.CurrentEncoding, 1192, 45884, 45904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 45923, 45959);

                    _currentPosition = f_1192_45942_45958(_stream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46054, 46126);

                    _oemEncoding = f_1192_46069_46125(null, EncodingConversion.OEM);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46144, 46228);

                    _defaultAnsiEncoding = f_1192_46167_46227(null, EncodingConversion.Default);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 45624, 46243);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1192, 45451, 46254);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 45451, 46254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 45451, 46254);
            }
        }

        private readonly FileStream _stream;

        private readonly Encoding _currentEncoding;

        private readonly Encoding _oemEncoding;

        private readonly Encoding _defaultAnsiEncoding;

        private const int
        BuffSize = 4096
        ;

        private readonly byte[] _byteBuff;

        private readonly char[] _charBuff;

        private int _byteCount;

        private int _charCount;

        private long _currentPosition;

        private bool? _singleByteCharSet;

        private const byte
        BothTopBitsSet = 0xC0
        ;

        private const byte
        TopBitUnset = 0x80
        ;

        private bool IsSingleByteCharacterSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 47131, 47943);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 47195, 47276) || true) && (_singleByteCharSet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 47195, 47276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 47244, 47276);

                    return (bool)_singleByteCharSet;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 47195, 47276);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 47377, 47862) || true) && ((f_1192_47382_47419(_currentEncoding, _oemEncoding) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 47382, 47486) || f_1192_47441_47486(_currentEncoding, _defaultAnsiEncoding)))
                && (DynAbs.Tracing.TraceSender.Expression_True(1192, 47381, 47526) && f_1192_47508_47526()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 47377, 47862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 47560, 47588);

                    NativeMethods.CPINFO
                    cpInfo
                    = default(NativeMethods.CPINFO);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 47606, 47847) || true) && (f_1192_47610_47678(f_1192_47640_47665(_currentEncoding), out cpInfo) && (DynAbs.Tracing.TraceSender.Expression_True(1192, 47610, 47726) && cpInfo.MaxCharSize == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 47606, 47847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 47768, 47794);

                        _singleByteCharSet = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 47816, 47828);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 47606, 47847);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 47377, 47862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 47878, 47905);

                _singleByteCharSet = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 47919, 47932);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 47131, 47943);

                bool
                f_1192_47382_47419(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 47382, 47419);
                    return return_v;
                }


                bool
                f_1192_47441_47486(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 47441, 47486);
                    return return_v;
                }


                bool
                f_1192_47508_47526()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 47508, 47526);
                    return return_v;
                }


                int
                f_1192_47640_47665(System.Text.Encoding
                this_param)
                {
                    var return_v = this_param.CodePage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 47640, 47665);
                    return return_v;
                }


                bool
                f_1192_47610_47678(int
                codePage, out Microsoft.PowerShell.Commands.FileStreamBackReader.NativeMethods.CPINFO
                lpCpInfo)
                {
                    var return_v = NativeMethods.GetCPInfo((uint)codePage, out lpCpInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 47610, 47678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 47131, 47943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 47131, 47943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int ReadBlock(char[] buffer, int index, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 48288, 48492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 48434, 48481);

                throw f_1192_48440_48480();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 48288, 48492);

                System.Management.Automation.PSNotSupportedException
                f_1192_48440_48480()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 48440, 48480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 48288, 48492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 48288, 48492);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ReadToEnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 48710, 48882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 48824, 48871);

                throw f_1192_48830_48870();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 48710, 48882);

                System.Management.Automation.PSNotSupportedException
                f_1192_48830_48870()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 48830, 48870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 48710, 48882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 48710, 48882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal new void DiscardBufferedData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 49239, 49449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 49303, 49330);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DiscardBufferedData(), 1192, 49303, 49329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 49344, 49380);

                _currentPosition = f_1192_49363_49379(_stream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 49394, 49409);

                _charCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 49423, 49438);

                _byteCount = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 49239, 49449);

                long
                f_1192_49363_49379(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 49363, 49379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 49239, 49449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 49239, 49449);
            }
        }

        internal long GetCurrentPosition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 49597, 49900);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 49656, 49718) || true) && (_charCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 49656, 49718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 49694, 49718);

                    return _currentPosition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 49656, 49718);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 49765, 49837);

                int
                byteCount = f_1192_49781_49836(_currentEncoding, _charBuff, 0, _charCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 49851, 49889);

                return (_currentPosition + byteCount);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 49597, 49900);

                int
                f_1192_49781_49836(System.Text.Encoding
                this_param, char[]
                chars, int
                index, int
                count)
                {
                    var return_v = this_param.GetByteCount(chars, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 49781, 49836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 49597, 49900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 49597, 49900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetByteCount(string delimiter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 50122, 50315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 50190, 50229);

                char[]
                chars = f_1192_50205_50228(delimiter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 50243, 50304);

                return f_1192_50250_50303(_currentEncoding, chars, 0, f_1192_50290_50302(chars));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 50122, 50315);

                char[]
                f_1192_50205_50228(string
                this_param)
                {
                    var return_v = this_param.ToCharArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 50205, 50228);
                    return return_v;
                }


                int
                f_1192_50290_50302(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 50290, 50302);
                    return return_v;
                }


                int
                f_1192_50250_50303(System.Text.Encoding
                this_param, char[]
                chars, int
                index, int
                count)
                {
                    var return_v = this_param.GetByteCount(chars, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 50250, 50303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 50122, 50315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 50122, 50315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Peek()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 50488, 50875);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 50539, 50706) || true) && (_charCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 50539, 50706);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 50592, 50691) || true) && (f_1192_50596_50614(this) == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 50592, 50691);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 50662, 50672);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 50592, 50691);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 50539, 50706);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 50826, 50864);

                return (int)_charBuff[_charCount - 1];
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 50488, 50875);

                int
                f_1192_50596_50614(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.RefillCharBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 50596, 50614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 50488, 50875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 50488, 50875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Read()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 51048, 51349);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 51099, 51266) || true) && (_charCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 51099, 51266);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 51152, 51251) || true) && (f_1192_51156_51174(this) == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 51152, 51251);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 51222, 51232);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 51152, 51251);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 51099, 51266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 51282, 51295);

                _charCount--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 51309, 51338);

                return _charBuff[_charCount];
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 51048, 51349);

                int
                f_1192_51156_51174(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.RefillCharBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 51156, 51174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 51048, 51349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 51048, 51349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Read(char[] buffer, int index, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 51912, 52063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 51998, 52052);

                return f_1192_52005_52051(this, f_1192_52014_52050(buffer, index, count));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 51912, 52063);

                System.Span<char>
                f_1192_52014_52050(char[]
                array, int
                start, int
                length)
                {
                    var return_v = new System.Span<char>(array, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 52014, 52050);
                    return return_v;
                }


                int
                f_1192_52005_52051(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param, System.Span<char>
                buffer)
                {
                    var return_v = this_param.ReadSpan(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 52005, 52051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 51912, 52063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 51912, 52063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Read(Span<char> buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 52362, 52465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 52430, 52454);

                return f_1192_52437_52453(this, buffer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 52362, 52465);

                int
                f_1192_52437_52453(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param, System.Span<char>
                buffer)
                {
                    var return_v = this_param.ReadSpan(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 52437, 52453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 52362, 52465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 52362, 52465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int ReadSpan(Span<char> buffer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 52477, 53258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 52591, 52608);

                int
                charRead = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 52622, 52636);

                int
                index = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 52650, 52676);

                int
                count = buffer.Length
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 52692, 53215);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 52727, 52924) || true) && (_charCount == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 52727, 52924);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 52788, 52905) || true) && (f_1192_52792_52810(this) == -1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 52788, 52905);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 52866, 52882);

                                    return charRead;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 52788, 52905);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 52727, 52924);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 52944, 52997);

                            int
                            toRead = (DynAbs.Tracing.TraceSender.Conditional_F1(1192, 52957, 52975) || ((_charCount > count && DynAbs.Tracing.TraceSender.Conditional_F2(1192, 52978, 52983)) || DynAbs.Tracing.TraceSender.Conditional_F3(1192, 52986, 52996))) ? count : _charCount
                            ;
                            try
                            {
                                for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53017, 53168) || true) && (toRead > 0)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53036, 53044)
                , toRead--, DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53046, 53053)
                , count--, DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53055, 53065)
                , charRead++, DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 53017, 53168))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 53017, 53168);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53107, 53149);

                                    buffer[index++] = _charBuff[--_charCount];
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 1, 152);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 1, 152);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 52692, 53215);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 52692, 53215) || true) && (count > 0)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 52692, 53215);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 52692, 53215);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53231, 53247);

                return charRead;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 52477, 53258);

                int
                f_1192_52792_52810(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.RefillCharBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 52792, 52810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 52477, 53258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 52477, 53258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ReadLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 53445, 55220);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53503, 53611) || true) && (_charCount == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1192, 53507, 53550) && f_1192_53526_53544(this) == -1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 53503, 53611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53584, 53596);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 53503, 53611);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53627, 53649);

                int
                charsToRemove = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53663, 53704);

                StringBuilder
                line = f_1192_53684_53703()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53720, 54422) || true) && (_charBuff[_charCount - 1] == '\r' || (DynAbs.Tracing.TraceSender.Expression_False(1192, 53724, 53811) || _charBuff[_charCount - 1] == '\n'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 53720, 54422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53845, 53861);

                    charsToRemove++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53879, 53919);

                    f_1192_53879_53918(line, 0, _charBuff[--_charCount]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 53939, 54407) || true) && (_charBuff[_charCount] == '\n')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 53939, 54407);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54014, 54154) || true) && (_charCount == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1192, 54018, 54061) && f_1192_54037_54055(this) == -1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 54014, 54154);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54111, 54131);

                            return string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 54014, 54154);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54178, 54388) || true) && (_charCount > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1192, 54182, 54233) && _charBuff[_charCount - 1] == '\r'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 54178, 54388);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54283, 54299);

                            charsToRemove++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54325, 54365);

                            f_1192_54325_54364(line, 0, _charBuff[--_charCount]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 54178, 54388);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 53939, 54407);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 53720, 54422);
                }
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 54438, 55209);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54473, 54970) || true) && (_charCount > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 54473, 54970);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54536, 54951) || true) && (_charBuff[_charCount - 1] == '\r' || (DynAbs.Tracing.TraceSender.Expression_False(1192, 54540, 54635) || _charBuff[_charCount - 1] == '\n'))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 54536, 54951);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54685, 54741);

                                        f_1192_54685_54740(line, f_1192_54697_54708(line) - charsToRemove, charsToRemove);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54767, 54790);

                                        return f_1192_54774_54789(line);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 54536, 54951);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 54536, 54951);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54888, 54928);

                                        f_1192_54888_54927(line, 0, _charBuff[--_charCount]);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 54536, 54951);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 54473, 54970);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 54473, 54970);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 54473, 54970);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54990, 55180) || true) && (f_1192_54994_55012(this) == -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 54990, 55180);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 55060, 55116);

                                f_1192_55060_55115(line, f_1192_55072_55083(line) - charsToRemove, charsToRemove);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 55138, 55161);

                                return f_1192_55145_55160(line);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 54990, 55180);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 54438, 55209);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 54438, 55209) || true) && (true)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 54438, 55209);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 54438, 55209);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 53445, 55220);

                int
                f_1192_53526_53544(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.RefillCharBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 53526, 53544);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1192_53684_53703()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 53684, 53703);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1192_53879_53918(System.Text.StringBuilder
                this_param, int
                index, char
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 53879, 53918);
                    return return_v;
                }


                int
                f_1192_54037_54055(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.RefillCharBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 54037, 54055);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1192_54325_54364(System.Text.StringBuilder
                this_param, int
                index, char
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 54325, 54364);
                    return return_v;
                }


                int
                f_1192_54697_54708(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 54697, 54708);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1192_54685_54740(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 54685, 54740);
                    return return_v;
                }


                string
                f_1192_54774_54789(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 54774, 54789);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1192_54888_54927(System.Text.StringBuilder
                this_param, int
                index, char
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 54888, 54927);
                    return return_v;
                }


                int
                f_1192_54994_55012(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.RefillCharBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 54994, 55012);
                    return return_v;
                }


                int
                f_1192_55072_55083(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 55072, 55083);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1192_55060_55115(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 55060, 55115);
                    return return_v;
                }


                string
                f_1192_55145_55160(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 55145, 55160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 53445, 55220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 53445, 55220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int RefillCharBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 55363, 55643);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 55418, 55505) || true) && ((f_1192_55423_55439(this)) == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 55418, 55505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 55480, 55490);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 55418, 55505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 55521, 55600);

                _charCount = f_1192_55534_55599(_currentEncoding, _byteBuff, 0, _byteCount, _charBuff, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 55614, 55632);

                return _charCount;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 55363, 55643);

                int
                f_1192_55423_55439(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.RefillByteBuff();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 55423, 55439);
                    return return_v;
                }


                int
                f_1192_55534_55599(System.Text.Encoding
                this_param, byte[]
                bytes, int
                byteIndex, int
                byteCount, char[]
                chars, int
                charIndex)
                {
                    var return_v = this_param.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 55534, 55599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 55363, 55643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 55363, 55643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int RefillByteBuff()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1192, 55781, 59410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 55834, 55869);

                long
                lengthLeft = f_1192_55852_55868(_stream)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 55885, 55963) || true) && (lengthLeft == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 55885, 55963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 55938, 55948);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 55885, 55963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 55979, 56043);

                int
                toRead = (DynAbs.Tracing.TraceSender.Conditional_F1(1192, 55992, 56013) || ((lengthLeft > BuffSize && DynAbs.Tracing.TraceSender.Conditional_F2(1192, 56016, 56024)) || DynAbs.Tracing.TraceSender.Conditional_F3(1192, 56027, 56042))) ? BuffSize : (int)lengthLeft
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 56057, 56099);

                f_1192_56057_56098(_stream, -toRead, SeekOrigin.Current);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 56115, 59365) || true) && (f_1192_56119_56157(_currentEncoding, f_1192_56143_56156()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 56115, 59365);
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 56274, 56772);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 56317, 56353);

                                _currentPosition = f_1192_56336_56352(_stream);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 56375, 56415);

                                byte
                                curByte = (byte)f_1192_56396_56414(_stream)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 56437, 56714) || true) && ((curByte & BothTopBitsSet) == BothTopBitsSet || (DynAbs.Tracing.TraceSender.Expression_False(1192, 56441, 56545) || (curByte & TopBitUnset) == 0x00))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 56437, 56714);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 56595, 56618);

                                    _byteBuff[0] = curByte;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 56644, 56659);

                                    _byteCount = 1;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1192, 56685, 56691);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 56437, 56714);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 56274, 56772);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 56274, 56772) || true) && (lengthLeft > f_1192_56754_56770(_stream))
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1192, 56274, 56772);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1192, 56274, 56772);
                        }
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 56792, 57079) || true) && (lengthLeft == f_1192_56810_56826(_stream))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 56792, 57079);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 56981, 57023);

                        f_1192_56981_57022(                    // Cannot find a starting byte. The file is NOT UTF-8 format. Read 'toRead' number of bytes
                                            _stream, -toRead, SeekOrigin.Current);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 57045, 57060);

                        _byteCount = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 56792, 57079);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 57099, 57187);

                    _byteCount += f_1192_57113_57186(_stream, _byteBuff, _byteCount, (lengthLeft - f_1192_57168_57184(_stream)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 57205, 57241);

                    _stream.Position = _currentPosition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 56115, 59365);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 56115, 59365);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 57275, 59365) || true) && (f_1192_57279_57320(_currentEncoding, f_1192_57303_57319()) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 57279, 57391) || f_1192_57341_57391(_currentEncoding, f_1192_57365_57390())) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 57279, 57451) || f_1192_57412_57451(_currentEncoding, f_1192_57436_57450())) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 57279, 57511) || f_1192_57472_57511(_currentEncoding, f_1192_57496_57510())) || (DynAbs.Tracing.TraceSender.Expression_False(1192, 57279, 57558) || f_1192_57532_57558(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 57275, 59365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 58218, 58254);

                        _currentPosition = f_1192_58237_58253(_stream);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 58272, 58320);

                        _byteCount = f_1192_58285_58319(_stream, _byteBuff, 0, toRead);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 58338, 58374);

                        _stream.Position = _currentPosition;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 57275, 59365);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1192, 57275, 59365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 59075, 59243);

                        string
                        errMsg = f_1192_59091_59242(f_1192_59131_59189(), f_1192_59212_59241(_currentEncoding))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 59261, 59350);

                        throw f_1192_59267_59349(errMsg, f_1192_59319_59348(_currentEncoding));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 57275, 59365);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1192, 56115, 59365);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 59381, 59399);

                return _byteCount;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1192, 55781, 59410);

                long
                f_1192_55852_55868(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 55852, 55868);
                    return return_v;
                }


                long
                f_1192_56057_56098(System.IO.FileStream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 56057, 56098);
                    return return_v;
                }


                System.Text.Encoding
                f_1192_56143_56156()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 56143, 56156);
                    return return_v;
                }


                bool
                f_1192_56119_56157(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 56119, 56157);
                    return return_v;
                }


                long
                f_1192_56336_56352(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 56336, 56352);
                    return return_v;
                }


                int
                f_1192_56396_56414(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 56396, 56414);
                    return return_v;
                }


                long
                f_1192_56754_56770(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 56754, 56770);
                    return return_v;
                }


                long
                f_1192_56810_56826(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 56810, 56826);
                    return return_v;
                }


                long
                f_1192_56981_57022(System.IO.FileStream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 56981, 57022);
                    return return_v;
                }


                long
                f_1192_57168_57184(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 57168, 57184);
                    return return_v;
                }


                int
                f_1192_57113_57186(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, long
                count)
                {
                    var return_v = this_param.Read(array, offset, (int)count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 57113, 57186);
                    return return_v;
                }


                System.Text.Encoding
                f_1192_57303_57319()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 57303, 57319);
                    return return_v;
                }


                bool
                f_1192_57279_57320(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 57279, 57320);
                    return return_v;
                }


                System.Text.Encoding
                f_1192_57365_57390()
                {
                    var return_v = Encoding.BigEndianUnicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 57365, 57390);
                    return return_v;
                }


                bool
                f_1192_57341_57391(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 57341, 57391);
                    return return_v;
                }


                System.Text.Encoding
                f_1192_57436_57450()
                {
                    var return_v = Encoding.UTF32;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 57436, 57450);
                    return return_v;
                }


                bool
                f_1192_57412_57451(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 57412, 57451);
                    return return_v;
                }


                System.Text.Encoding
                f_1192_57496_57510()
                {
                    var return_v = Encoding.ASCII;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 57496, 57510);
                    return return_v;
                }


                bool
                f_1192_57472_57511(System.Text.Encoding
                this_param, System.Text.Encoding
                value)
                {
                    var return_v = this_param.Equals((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 57472, 57511);
                    return return_v;
                }


                bool
                f_1192_57532_57558(Microsoft.PowerShell.Commands.FileStreamBackReader
                this_param)
                {
                    var return_v = this_param.IsSingleByteCharacterSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 57532, 57558);
                    return return_v;
                }


                long
                f_1192_58237_58253(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 58237, 58253);
                    return return_v;
                }


                int
                f_1192_58285_58319(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 58285, 58319);
                    return return_v;
                }


                string
                f_1192_59131_59189()
                {
                    var return_v = FileSystemProviderStrings.ReadBackward_Encoding_NotSupport;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 59131, 59189);
                    return return_v;
                }


                string
                f_1192_59212_59241(System.Text.Encoding
                this_param)
                {
                    var return_v = this_param.EncodingName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 59212, 59241);
                    return return_v;
                }


                string
                f_1192_59091_59242(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 59091, 59242);
                    return return_v;
                }


                string
                f_1192_59319_59348(System.Text.Encoding
                this_param)
                {
                    var return_v = this_param.EncodingName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 59319, 59348);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.BackReaderEncodingNotSupportedException
                f_1192_59267_59349(string
                message, string
                encodingName)
                {
                    var return_v = new Microsoft.PowerShell.Commands.BackReaderEncodingNotSupportedException(message, encodingName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 59267, 59349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 55781, 59410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 55781, 59410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private static class NativeMethods
        {
            private const int
            MAX_DEFAULTCHAR = 2
            ;

            private const int
            MAX_LEADBYTES = 12
            ;

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            internal struct CPINFO
            {

                [MarshalAs(UnmanagedType.U4)]
                internal int MaxCharSize;

                [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_DEFAULTCHAR)]
                public byte[] DefaultChar;

                [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_LEADBYTES)]
                public byte[] LeadBytes;
                static CPINFO()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1192, 59617, 60094);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1192, 59617, 60094);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 59617, 60094);
                }
            };

            [DllImport(PinvokeDllNames.GetCPInfoDllName, CharSet = CharSet.Unicode, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool GetCPInfo(uint codePage, out CPINFO lpCpInfo);

            static NativeMethods()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1192, 59422, 60600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 59530, 59549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 59582, 59600);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1192, 59422, 60600);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 59422, 60600);
            }

        }

        static FileStreamBackReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1192, 45377, 60607);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46491, 46506);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46836, 46857);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 46887, 46905);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1192, 45377, 60607);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 45377, 60607);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1192, 45377, 60607);

        long
        f_1192_45628_45642(System.IO.FileStream
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 45628, 45642);
            return return_v;
        }


        long
        f_1192_45699_45715(System.IO.FileStream
        this_param)
        {
            var return_v = this_param.Position;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 45699, 45715);
            return return_v;
        }


        long
        f_1192_45734_45767(System.IO.FileStream
        this_param, int
        offset, System.IO.SeekOrigin
        origin)
        {
            var return_v = this_param.Seek((long)offset, origin);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 45734, 45767);
            return return_v;
        }


        long
        f_1192_45942_45958(System.IO.FileStream
        this_param)
        {
            var return_v = this_param.Position;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1192, 45942, 45958);
            return return_v;
        }


        System.Text.Encoding
        f_1192_46069_46125(System.Management.Automation.Cmdlet
        cmdlet, string
        encoding)
        {
            var return_v = EncodingConversion.Convert(cmdlet, encoding);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 46069, 46125);
            return return_v;
        }


        System.Text.Encoding
        f_1192_46167_46227(System.Management.Automation.Cmdlet
        cmdlet, string
        encoding)
        {
            var return_v = EncodingConversion.Convert(cmdlet, encoding);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1192, 46167, 46227);
            return return_v;
        }


        static System.IO.Stream
        f_1192_45543_45553_C(System.IO.Stream
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1192, 45451, 46254);
            return return_v;
        }

    }
    [SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Justification = "This exception is internal and never thrown by any public API")]
    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "This exception is internal and never thrown by any public API")]
    internal sealed class BackReaderEncodingNotSupportedException : NotSupportedException
    {
        internal BackReaderEncodingNotSupportedException(string message, string encodingName)
        : base(f_1192_61298_61305_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1192, 61192, 61370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 61610, 61647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 61331, 61359);

                EncodingName = encodingName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1192, 61192, 61370);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 61192, 61370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 61192, 61370);
            }
        }

        internal BackReaderEncodingNotSupportedException(string encodingName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1192, 61382, 61515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 61610, 61647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1192, 61476, 61504);

                EncodingName = encodingName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1192, 61382, 61515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1192, 61382, 61515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 61382, 61515);
            }
        }

        internal string EncodingName { get; }

        static BackReaderEncodingNotSupportedException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1192, 60745, 61654);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1192, 60745, 61654);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1192, 60745, 61654);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1192, 60745, 61654);

        static string
        f_1192_61298_61305_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1192, 61192, 61370);
            return return_v;
        }

    }
}
