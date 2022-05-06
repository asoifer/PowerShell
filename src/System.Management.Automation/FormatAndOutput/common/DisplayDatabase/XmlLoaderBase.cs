// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Text;
using System.Xml;

/*
 SUMMARY: this file contains a general purpose, reusable framework for
    loading XML files, and do data validation.
    It provides the capability of:
    * logging errors, warnings and traces to a file or in memory
    * managing the XML dom traversal using an add hoc stack frame management scheme
    * validating common error conditions (e.g. missing node or unknown node)
*/

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal abstract class TypeInfoDataBaseLoaderException : SystemException
    {
        public TypeInfoDataBaseLoaderException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1135, 936, 1023);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1135, 936, 1023);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 936, 1023);
        }


        static TypeInfoDataBaseLoaderException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1135, 936, 1023);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1135, 936, 1023);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 936, 1023);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1135, 936, 1023);
    }
    internal class TooManyErrorsException : TypeInfoDataBaseLoaderException
    {
        internal int errorCount;

        public TooManyErrorsException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1135, 1157, 1378);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 1360, 1370);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1135, 1157, 1378);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 1157, 1378);
        }


        static TooManyErrorsException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1135, 1157, 1378);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1135, 1157, 1378);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 1157, 1378);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1135, 1157, 1378);
    }
    internal class XmlLoaderLoggerEntry
    {
        internal enum EntryType { Error, Trace };

        internal EntryType entryType;

        internal string filePath;

        internal string xPath;

        internal string message;

        internal bool failToLoadFile;

        public XmlLoaderLoggerEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1135, 1503, 2331);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 1721, 1730);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 1856, 1871);
            this.filePath = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 1992, 2004);
            this.xPath = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 2130, 2144);
            this.message = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 2301, 2323);
            this.failToLoadFile = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1135, 1503, 2331);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 1503, 2331);
        }


        static XmlLoaderLoggerEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1135, 1503, 2331);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1135, 1503, 2331);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 1503, 2331);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1135, 1503, 2331);
    }
    internal class XmlLoaderLogger : IDisposable
    {
        [TraceSource("FormatFileLoading", "Loading format files")]
        private static PSTraceSource s_formatFileLoadingtracer;

        internal void LogEntry(XmlLoaderLoggerEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 3019, 3406);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 3094, 3190) || true) && (entry.entryType == XmlLoaderLoggerEntry.EntryType.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 3094, 3190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 3172, 3190);

                    _hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 3094, 3190);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 3206, 3262) || true) && (_saveInMemory)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 3206, 3262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 3242, 3262);

                    f_1135_3242_3261(_entries, entry);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 3206, 3262);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 3278, 3395) || true) && ((f_1135_3283_3316(s_formatFileLoadingtracer) | PSTraceSourceOptions.WriteLine) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 3278, 3395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 3374, 3395);

                    f_1135_3374_3394(this, entry);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 3278, 3395);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 3019, 3406);

                int
                f_1135_3242_3261(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 3242, 3261);
                    return 0;
                }


                System.Management.Automation.PSTraceSourceOptions
                f_1135_3283_3316(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 3283, 3316);
                    return return_v;
                }


                int
                f_1135_3374_3394(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
                this_param, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry
                entry)
                {
                    this_param.WriteToTracer(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 3374, 3394);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 3019, 3406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 3019, 3406);
            }
        }

        private void WriteToTracer(XmlLoaderLoggerEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 3418, 4025);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 3497, 4014) || true) && (entry.entryType == XmlLoaderLoggerEntry.EntryType.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 3497, 4014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 3590, 3731);

                    f_1135_3590_3730(s_formatFileLoadingtracer, "ERROR:\r\n FilePath: {0}\r\n XPath: {1}\r\n Message = {2}", entry.filePath, entry.xPath, entry.message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 3497, 4014);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 3497, 4014);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 3765, 4014) || true) && (entry.entryType == XmlLoaderLoggerEntry.EntryType.Trace)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 3765, 4014);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 3858, 3999);

                        f_1135_3858_3998(s_formatFileLoadingtracer, "TRACE:\r\n FilePath: {0}\r\n XPath: {1}\r\n Message = {2}", entry.filePath, entry.xPath, entry.message);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 3765, 4014);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 3497, 4014);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 3418, 4025);

                int
                f_1135_3590_3730(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2, string
                arg3)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2, (object)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 3590, 3730);
                    return 0;
                }


                int
                f_1135_3858_3998(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2, string
                arg3)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2, (object)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 3858, 3998);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 3418, 4025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 3418, 4025);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 4195, 4308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 4241, 4255);

                f_1135_4241_4254(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 4271, 4297);

                f_1135_4271_4296(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 4195, 4308);

                int
                f_1135_4241_4254(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 4241, 4254);
                    return 0;
                }


                int
                f_1135_4271_4296(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 4271, 4296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 4195, 4308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 4195, 4308);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 4320, 4446);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 4391, 4435) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 4391, 4435);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 4391, 4435);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 4320, 4446);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 4320, 4446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 4320, 4446);
            }
        }

        internal List<XmlLoaderLoggerEntry> LogEntries
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 4529, 4596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 4565, 4581);

                    return _entries;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 4529, 4596);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 4458, 4607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 4458, 4607);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 4667, 4736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 4703, 4721);

                    return _hasErrors;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 4667, 4736);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 4619, 4747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 4619, 4747);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _saveInMemory;

        private List<XmlLoaderLoggerEntry> _entries;

        private bool _hasErrors;

        public XmlLoaderLogger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1135, 2533, 5228);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 4864, 4884);
            this._saveInMemory = true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 5040, 5083);
            this._entries = f_1135_5051_5083();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 5202, 5220);
            this._hasErrors = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1135, 2533, 5228);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 2533, 5228);
        }


        static XmlLoaderLogger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1135, 2533, 5228);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 2747, 2850);
            s_formatFileLoadingtracer = f_1135_2775_2850("FormatFileLoading", "Loading format files", false);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1135, 2533, 5228);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 2533, 5228);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1135, 2533, 5228);

        static System.Management.Automation.PSTraceSource
        f_1135_2775_2850(string
        name, string
        description, bool
        traceHeaders)
        {
            var return_v = PSTraceSource.GetTracer(name, description, traceHeaders);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 2775, 2850);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
        f_1135_5051_5083()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 5051, 5083);
            return return_v;
        }

    }
    internal abstract class XmlLoaderBase : IDisposable
    {
        [TraceSource("XmlLoaderBase", "XmlLoaderBase")]
        private static PSTraceSource s_tracer;
        private sealed class XmlLoaderStackFrame : IDisposable
        {
            internal XmlLoaderStackFrame(XmlLoaderBase loader, XmlNode n, int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1135, 5970, 6176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 6670, 6677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 6815, 6819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 7045, 7055);
                    this.index = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 6075, 6092);

                    _loader = loader;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 6110, 6124);

                    this.node = n;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 6142, 6161);

                    this.index = index;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1135, 5970, 6176);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 5970, 6176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 5970, 6176);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 6292, 6505);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 6346, 6490) || true) && (_loader != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 6346, 6490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 6407, 6434);

                        f_1135_6407_6433(_loader);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 6456, 6471);

                        _loader = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 6346, 6490);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 6292, 6505);

                    int
                    f_1135_6407_6433(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                    this_param)
                    {
                        this_param.RemoveStackFrame();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 6407, 6433);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 6292, 6505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 6292, 6505);
                }
            }

            private XmlLoaderBase _loader;

            internal XmlNode node;

            internal int index;

            static XmlLoaderStackFrame()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1135, 5891, 7067);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1135, 5891, 7067);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 5891, 7067);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1135, 5891, 7067);
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 7237, 7350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 7283, 7297);

                f_1135_7283_7296(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 7313, 7339);

                f_1135_7313_7338(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 7237, 7350);

                int
                f_1135_7283_7296(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 7283, 7296);
                    return 0;
                }


                int
                f_1135_7313_7338(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 7313, 7338);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 7237, 7350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 7237, 7350);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 7362, 7641);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 7433, 7630) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 7433, 7630);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 7480, 7615) || true) && (_logger != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 7480, 7615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 7541, 7559);

                        f_1135_7541_7558(_logger);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 7581, 7596);

                        _logger = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 7480, 7615);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 7433, 7630);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 7362, 7641);

                int
                f_1135_7541_7558(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 7541, 7558);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 7362, 7641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 7362, 7641);
            }
        }

        internal List<XmlLoaderLoggerEntry> LogEntries
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 7878, 7955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 7914, 7940);

                    return f_1135_7921_7939(_logger);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 7878, 7955);

                    System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry>
                    f_1135_7921_7939(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
                    this_param)
                    {
                        var return_v = this_param.LogEntries;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 7921, 7939);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 7807, 7966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 7807, 7966);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 8180, 8256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 8216, 8241);

                    return f_1135_8223_8240(_logger);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 8180, 8256);

                    bool
                    f_1135_8223_8240(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
                    this_param)
                    {
                        var return_v = this_param.HasErrors;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 8223, 8240);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 8132, 8267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 8132, 8267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected IDisposable StackFrame(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 8597, 8701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 8665, 8690);

                return f_1135_8672_8689(this, n, -1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 8597, 8701);

                System.IDisposable
                f_1135_8672_8689(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 8672, 8689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 8597, 8701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 8597, 8701);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected IDisposable StackFrame(XmlNode n, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 9124, 9426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9203, 9268);

                XmlLoaderStackFrame
                sf = f_1135_9228_9267(this, n, index)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9284, 9309);

                f_1135_9284_9308(
                            _executionStack, sf);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9323, 9391) || true) && (_logStackActivity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 9323, 9391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9363, 9391);

                    f_1135_9363_9390(this, "Enter");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 9323, 9391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9405, 9415);

                return sf;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 9124, 9426);

                Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase.XmlLoaderStackFrame
                f_1135_9228_9267(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                loader, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase.XmlLoaderStackFrame(loader, n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 9228, 9267);
                    return return_v;
                }


                int
                f_1135_9284_9308(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase.XmlLoaderStackFrame>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase.XmlLoaderStackFrame
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 9284, 9308);
                    return 0;
                }


                int
                f_1135_9363_9390(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                label)
                {
                    this_param.WriteStackLocation(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 9363, 9390);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 9124, 9426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 9124, 9426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RemoveStackFrame()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 9602, 9772);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9658, 9725) || true) && (_logStackActivity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 9658, 9725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9698, 9725);

                    f_1135_9698_9724(this, "Exit");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 9658, 9725);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9739, 9761);

                f_1135_9739_9760(_executionStack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 9602, 9772);

                int
                f_1135_9698_9724(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                label)
                {
                    this_param.WriteStackLocation(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 9698, 9724);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase.XmlLoaderStackFrame
                f_1135_9739_9760(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase.XmlLoaderStackFrame>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 9739, 9760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 9602, 9772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 9602, 9772);
            }
        }

        protected void ProcessUnknownNode(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 9784, 9954);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9853, 9903) || true) && (f_1135_9857_9877(n))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 9853, 9903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9896, 9903);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 9853, 9903);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 9919, 9943);

                f_1135_9919_9942(this, n);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 9784, 9954);

                bool
                f_1135_9857_9877(System.Xml.XmlNode
                n)
                {
                    var return_v = IsFilteredOutNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 9857, 9877);
                    return return_v;
                }


                int
                f_1135_9919_9942(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ReportIllegalXmlNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 9919, 9942);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 9784, 9954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 9784, 9954);
            }
        }

        protected void ProcessUnknownAttribute(XmlAttribute a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 9966, 10085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10045, 10074);

                f_1135_10045_10073(this, a);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 9966, 10085);

                int
                f_1135_10045_10073(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, System.Xml.XmlAttribute
                a)
                {
                    this_param.ReportIllegalXmlAttribute(a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 10045, 10073);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 9966, 10085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 9966, 10085);
            }
        }

        protected static bool IsFilteredOutNode(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1135, 10097, 10230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10172, 10219);

                return (n is XmlComment || (DynAbs.Tracing.TraceSender.Expression_False(1135, 10180, 10217) || n is XmlWhitespace));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1135, 10097, 10230);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 10097, 10230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 10097, 10230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool VerifyNodeHasNoChildren(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 10242, 10788);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10316, 10374) || true) && (f_1135_10320_10338(f_1135_10320_10332(n)) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 10316, 10374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10362, 10374);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 10316, 10374);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10390, 10531) || true) && (f_1135_10394_10412(f_1135_10394_10406(n)) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 10390, 10531);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10451, 10516) || true) && (f_1135_10455_10470(f_1135_10455_10467(n), 0) is XmlText)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 10451, 10516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10504, 10516);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 10451, 10516);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 10390, 10531);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10624, 10750);

                f_1135_10624_10749(            // Error at XPath {0} in file {1}: Node {2} cannot have children.
                            this, f_1135_10641_10748(f_1135_10659_10706(), f_1135_10708_10729(this), f_1135_10731_10739(), f_1135_10741_10747(n)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10764, 10777);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 10242, 10788);

                System.Xml.XmlNodeList
                f_1135_10320_10332(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 10320, 10332);
                    return return_v;
                }


                int
                f_1135_10320_10338(System.Xml.XmlNodeList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 10320, 10338);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1135_10394_10406(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 10394, 10406);
                    return return_v;
                }


                int
                f_1135_10394_10412(System.Xml.XmlNodeList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 10394, 10412);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1135_10455_10467(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 10455, 10467);
                    return return_v;
                }


                System.Xml.XmlNode
                f_1135_10455_10470(System.Xml.XmlNodeList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 10455, 10470);
                    return return_v;
                }


                string
                f_1135_10659_10706()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoChildrenAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 10659, 10706);
                    return return_v;
                }


                string
                f_1135_10708_10729(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 10708, 10729);
                    return return_v;
                }


                string
                f_1135_10731_10739()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 10731, 10739);
                    return return_v;
                }


                string
                f_1135_10741_10747(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 10741, 10747);
                    return return_v;
                }


                string
                f_1135_10641_10748(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 10641, 10748);
                    return return_v;
                }


                int
                f_1135_10624_10749(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 10624, 10749);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 10242, 10788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 10242, 10788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetMandatoryInnerText(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 10800, 11059);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10873, 11013) || true) && (f_1135_10877_10910(f_1135_10898_10909(n)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 10873, 11013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10944, 10968);

                    f_1135_10944_10967(this, n);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 10986, 10998);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 10873, 11013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 11029, 11048);

                return f_1135_11036_11047(n);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 10800, 11059);

                string
                f_1135_10898_10909(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.InnerText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 10898, 10909);
                    return return_v;
                }


                bool
                f_1135_10877_10910(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 10877, 10910);
                    return return_v;
                }


                int
                f_1135_10944_10967(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ReportEmptyNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 10944, 10967);
                    return 0;
                }


                string
                f_1135_11036_11047(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.InnerText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 11036, 11047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 10800, 11059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 10800, 11059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetMandatoryAttributeValue(XmlAttribute a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 11071, 11337);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 11154, 11295) || true) && (f_1135_11158_11187(f_1135_11179_11186(a)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 11154, 11295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 11221, 11250);

                    f_1135_11221_11249(this, a);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 11268, 11280);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 11154, 11295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 11311, 11326);

                return f_1135_11318_11325(a);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 11071, 11337);

                string
                f_1135_11179_11186(System.Xml.XmlAttribute
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 11179, 11186);
                    return return_v;
                }


                bool
                f_1135_11158_11187(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 11158, 11187);
                    return return_v;
                }


                int
                f_1135_11221_11249(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, System.Xml.XmlAttribute
                a)
                {
                    this_param.ReportEmptyAttribute(a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 11221, 11249);
                    return 0;
                }


                string
                f_1135_11318_11325(System.Xml.XmlAttribute
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 11318, 11325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 11071, 11337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 11071, 11337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MatchNodeNameHelper(XmlNode n, string s, bool allowAttributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 11891, 13202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 11991, 12010);

                bool
                match = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 12024, 12692) || true) && (f_1135_12028_12078(f_1135_12042_12048(n), s, StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 12024, 12692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 12163, 12176);

                    match = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 12024, 12692);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 12024, 12692);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 12210, 12692) || true) && (f_1135_12214_12274(f_1135_12228_12234(n), s, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 12210, 12692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 12490, 12547);

                        string
                        fmtString = "XML tag differ in case only {0} {1}"
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 12565, 12644);

                        f_1135_12565_12643(this, f_1135_12577_12642(f_1135_12591_12619(), fmtString, f_1135_12632_12638(n), s));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 12664, 12677);

                        match = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 12210, 12692);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 12024, 12692);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 12708, 13162) || true) && (match && (DynAbs.Tracing.TraceSender.Expression_True(1135, 12712, 12737) && !allowAttributes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 12708, 13162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 12771, 12802);

                    XmlElement
                    e = n as XmlElement
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 12820, 13147) || true) && (e != null && (DynAbs.Tracing.TraceSender.Expression_True(1135, 12824, 12859) && f_1135_12837_12855(f_1135_12837_12849(e)) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 12820, 13147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 13004, 13128);

                        f_1135_13004_13127(this, f_1135_13016_13126(f_1135_13034_13084(), f_1135_13086_13107(this), f_1135_13109_13117(), f_1135_13119_13125(n)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 12820, 13147);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 12708, 13162);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 13178, 13191);

                return match;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 11891, 13202);

                string
                f_1135_12042_12048(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 12042, 12048);
                    return return_v;
                }


                bool
                f_1135_12028_12078(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 12028, 12078);
                    return return_v;
                }


                string
                f_1135_12228_12234(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 12228, 12234);
                    return return_v;
                }


                bool
                f_1135_12214_12274(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 12214, 12274);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1135_12591_12619()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 12591, 12619);
                    return return_v;
                }


                string
                f_1135_12632_12638(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 12632, 12638);
                    return return_v;
                }


                string
                f_1135_12577_12642(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 12577, 12642);
                    return return_v;
                }


                int
                f_1135_12565_12643(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 12565, 12643);
                    return 0;
                }


                System.Xml.XmlAttributeCollection
                f_1135_12837_12849(System.Xml.XmlElement
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 12837, 12849);
                    return return_v;
                }


                int
                f_1135_12837_12855(System.Xml.XmlAttributeCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 12837, 12855);
                    return return_v;
                }


                string
                f_1135_13034_13084()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.AttributesNotAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 13034, 13084);
                    return return_v;
                }


                string
                f_1135_13086_13107(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 13086, 13107);
                    return return_v;
                }


                string
                f_1135_13109_13117()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 13109, 13117);
                    return return_v;
                }


                string
                f_1135_13119_13125(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 13119, 13125);
                    return return_v;
                }


                string
                f_1135_13016_13126(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 13016, 13126);
                    return return_v;
                }


                int
                f_1135_13004_13127(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 13004, 13127);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 11891, 13202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 11891, 13202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool MatchNodeNameWithAttributes(XmlNode n, string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 13214, 13351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 13301, 13340);

                return f_1135_13308_13339(this, n, s, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 13214, 13351);

                bool
                f_1135_13308_13339(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, System.Xml.XmlNode
                n, string
                s, bool
                allowAttributes)
                {
                    var return_v = this_param.MatchNodeNameHelper(n, s, allowAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 13308, 13339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 13214, 13351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 13214, 13351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool MatchNodeName(XmlNode n, string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 13363, 13487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 13436, 13476);

                return f_1135_13443_13475(this, n, s, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 13363, 13487);

                bool
                f_1135_13443_13475(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, System.Xml.XmlNode
                n, string
                s, bool
                allowAttributes)
                {
                    var return_v = this_param.MatchNodeNameHelper(n, s, allowAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 13443, 13475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 13363, 13487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 13363, 13487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool MatchAttributeName(XmlAttribute a, string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 13499, 14292);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 13582, 14252) || true) && (f_1135_13586_13636(f_1135_13600_13606(a), s, StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 13582, 14252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 13721, 13733);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 13582, 14252);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 13582, 14252);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 13767, 14252) || true) && (f_1135_13771_13831(f_1135_13785_13791(a), s, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 13767, 14252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 14047, 14110);

                        string
                        fmtString = "XML attribute differ in case only {0} {1}"
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 14128, 14207);

                        f_1135_14128_14206(this, f_1135_14140_14205(f_1135_14154_14182(), fmtString, f_1135_14195_14201(a), s));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 14225, 14237);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 13767, 14252);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 13582, 14252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 14268, 14281);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 13499, 14292);

                string
                f_1135_13600_13606(System.Xml.XmlAttribute
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 13600, 13606);
                    return return_v;
                }


                bool
                f_1135_13586_13636(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 13586, 13636);
                    return return_v;
                }


                string
                f_1135_13785_13791(System.Xml.XmlAttribute
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 13785, 13791);
                    return return_v;
                }


                bool
                f_1135_13771_13831(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 13771, 13831);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1135_14154_14182()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 14154, 14182);
                    return return_v;
                }


                string
                f_1135_14195_14201(System.Xml.XmlAttribute
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 14195, 14201);
                    return return_v;
                }


                string
                f_1135_14140_14205(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 14140, 14205);
                    return return_v;
                }


                int
                f_1135_14128_14206(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 14128, 14206);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 13499, 14292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 13499, 14292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ProcessDuplicateNode(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 14304, 14607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 14439, 14596);

                f_1135_14439_14595(this, f_1135_14460_14556(f_1135_14478_14522(), f_1135_14524_14545(this), f_1135_14547_14555()), XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 14304, 14607);

                string
                f_1135_14478_14522()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.DuplicatedNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 14478, 14522);
                    return return_v;
                }


                string
                f_1135_14524_14545(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 14524, 14545);
                    return return_v;
                }


                string
                f_1135_14547_14555()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 14547, 14555);
                    return return_v;
                }


                string
                f_1135_14460_14556(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 14460, 14556);
                    return return_v;
                }


                int
                f_1135_14439_14595(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 14439, 14595);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 14304, 14607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 14304, 14607);
            }
        }

        internal void ProcessDuplicateAlternateNode(string node1, string node2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 14619, 14988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 14799, 14977);

                f_1135_14799_14976(this, f_1135_14820_14937(f_1135_14838_14889(), f_1135_14891_14912(this), f_1135_14914_14922(), node1, node2), XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 14619, 14988);

                string
                f_1135_14838_14889()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.MutuallyExclusiveNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 14838, 14889);
                    return return_v;
                }


                string
                f_1135_14891_14912(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 14891, 14912);
                    return return_v;
                }


                string
                f_1135_14914_14922()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 14914, 14922);
                    return return_v;
                }


                string
                f_1135_14820_14937(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 14820, 14937);
                    return return_v;
                }


                int
                f_1135_14799_14976(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 14799, 14976);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 14619, 14988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 14619, 14988);
            }
        }

        internal void ProcessDuplicateAlternateNode(XmlNode n, string node1, string node2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 15000, 15398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 15196, 15387);

                f_1135_15196_15386(this, f_1135_15217_15347(f_1135_15235_15291(), f_1135_15293_15314(this), f_1135_15316_15324(), f_1135_15326_15332(n), node1, node2), XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 15000, 15398);

                string
                f_1135_15235_15291()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ThreeMutuallyExclusiveNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 15235, 15291);
                    return return_v;
                }


                string
                f_1135_15293_15314(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 15293, 15314);
                    return return_v;
                }


                string
                f_1135_15316_15324()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 15316, 15324);
                    return return_v;
                }


                string
                f_1135_15326_15332(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 15326, 15332);
                    return return_v;
                }


                string
                f_1135_15217_15347(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 15217, 15347);
                    return return_v;
                }


                int
                f_1135_15196_15386(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 15196, 15386);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 15000, 15398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 15000, 15398);
            }
        }

        private void ReportIllegalXmlNode(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 15410, 15736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 15563, 15725);

                f_1135_15563_15724(this, f_1135_15584_15685(f_1135_15602_15643(), f_1135_15645_15666(this), f_1135_15668_15676(), f_1135_15678_15684(n)), XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 15410, 15736);

                string
                f_1135_15602_15643()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.UnknownNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 15602, 15643);
                    return return_v;
                }


                string
                f_1135_15645_15666(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 15645, 15666);
                    return return_v;
                }


                string
                f_1135_15668_15676()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 15668, 15676);
                    return return_v;
                }


                string
                f_1135_15678_15684(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 15678, 15684);
                    return return_v;
                }


                string
                f_1135_15584_15685(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 15584, 15685);
                    return return_v;
                }


                int
                f_1135_15563_15724(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 15563, 15724);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 15410, 15736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 15410, 15736);
            }
        }

        private void ReportIllegalXmlAttribute(XmlAttribute a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 15748, 16082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 15904, 16071);

                f_1135_15904_16070(this, f_1135_15925_16031(f_1135_15943_15989(), f_1135_15991_16012(this), f_1135_16014_16022(), f_1135_16024_16030(a)), XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 15748, 16082);

                string
                f_1135_15943_15989()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.UnknownAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 15943, 15989);
                    return return_v;
                }


                string
                f_1135_15991_16012(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 15991, 16012);
                    return return_v;
                }


                string
                f_1135_16014_16022()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 16014, 16022);
                    return return_v;
                }


                string
                f_1135_16024_16030(System.Xml.XmlAttribute
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 16024, 16030);
                    return return_v;
                }


                string
                f_1135_15925_16031(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 15925, 16031);
                    return return_v;
                }


                int
                f_1135_15904_16070(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 15904, 16070);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 15748, 16082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 15748, 16082);
            }
        }

        protected void ReportMissingAttribute(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 16094, 16421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 16245, 16410);

                f_1135_16245_16409(this, f_1135_16266_16370(f_1135_16284_16330(), f_1135_16332_16353(this), f_1135_16355_16363(), name), XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 16094, 16421);

                string
                f_1135_16284_16330()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.MissingAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 16284, 16330);
                    return return_v;
                }


                string
                f_1135_16332_16353(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 16332, 16353);
                    return return_v;
                }


                string
                f_1135_16355_16363()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 16355, 16363);
                    return return_v;
                }


                string
                f_1135_16266_16370(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 16266, 16370);
                    return return_v;
                }


                int
                f_1135_16245_16409(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 16245, 16409);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 16094, 16421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 16094, 16421);
            }
        }

        protected void ReportMissingNode(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 16433, 16740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 16569, 16729);

                f_1135_16569_16728(this, f_1135_16590_16689(f_1135_16608_16649(), f_1135_16651_16672(this), f_1135_16674_16682(), name), XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 16433, 16740);

                string
                f_1135_16608_16649()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.MissingNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 16608, 16649);
                    return return_v;
                }


                string
                f_1135_16651_16672(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 16651, 16672);
                    return return_v;
                }


                string
                f_1135_16674_16682()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 16674, 16682);
                    return return_v;
                }


                string
                f_1135_16590_16689(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 16590, 16689);
                    return return_v;
                }


                int
                f_1135_16569_16728(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 16569, 16728);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 16433, 16740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 16433, 16740);
            }
        }

        protected void ReportMissingNodes(string[] names)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 16752, 17143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 16897, 16943);

                string
                namesString = f_1135_16918_16942(", ", names)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 16957, 17132);

                f_1135_16957_17131(this, f_1135_16978_17092(f_1135_16996_17045(), f_1135_17047_17068(this), f_1135_17070_17078(), namesString), XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 16752, 17143);

                string
                f_1135_16918_16942(string
                separator, params string[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 16918, 16942);
                    return return_v;
                }


                string
                f_1135_16996_17045()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.MissingNodeFromList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 16996, 17045);
                    return return_v;
                }


                string
                f_1135_17047_17068(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 17047, 17068);
                    return return_v;
                }


                string
                f_1135_17070_17078()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 17070, 17078);
                    return return_v;
                }


                string
                f_1135_16978_17092(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 16978, 17092);
                    return return_v;
                }


                int
                f_1135_16957_17131(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 16957, 17131);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 16752, 17143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 16752, 17143);
            }
        }

        protected void ReportEmptyNode(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 17155, 17462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 17291, 17451);

                f_1135_17291_17450(this, f_1135_17312_17411(f_1135_17330_17369(), f_1135_17371_17392(this), f_1135_17394_17402(), f_1135_17404_17410(n)), XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 17155, 17462);

                string
                f_1135_17330_17369()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.EmptyNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 17330, 17369);
                    return return_v;
                }


                string
                f_1135_17371_17392(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 17371, 17392);
                    return return_v;
                }


                string
                f_1135_17394_17402()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 17394, 17402);
                    return return_v;
                }


                string
                f_1135_17404_17410(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 17404, 17410);
                    return return_v;
                }


                string
                f_1135_17312_17411(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 17312, 17411);
                    return return_v;
                }


                int
                f_1135_17291_17450(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 17291, 17450);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 17155, 17462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 17155, 17462);
            }
        }

        protected void ReportEmptyAttribute(XmlAttribute a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 17474, 17816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 17640, 17805);

                f_1135_17640_17804(this, f_1135_17661_17765(f_1135_17679_17723(), f_1135_17725_17746(this), f_1135_17748_17756(), f_1135_17758_17764(a)), XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 17474, 17816);

                string
                f_1135_17679_17723()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.EmptyAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 17679, 17723);
                    return return_v;
                }


                string
                f_1135_17725_17746(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 17725, 17746);
                    return return_v;
                }


                string
                f_1135_17748_17756()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 17748, 17756);
                    return return_v;
                }


                string
                f_1135_17758_17764(System.Xml.XmlAttribute
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 17758, 17764);
                    return return_v;
                }


                string
                f_1135_17661_17765(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 17661, 17765);
                    return return_v;
                }


                int
                f_1135_17640_17804(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 17640, 17804);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 17474, 17816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 17474, 17816);
            }
        }

        protected void ReportTrace(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 18047, 18193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 18114, 18182);

                f_1135_18114_18181(this, message, XmlLoaderLoggerEntry.EntryType.Trace);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 18047, 18193);

                int
                f_1135_18114_18181(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 18114, 18181);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 18047, 18193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 18047, 18193);
            }
        }

        protected void ReportError(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 18205, 18351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 18272, 18340);

                f_1135_18272_18339(this, message, XmlLoaderLoggerEntry.EntryType.Error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 18205, 18351);

                int
                f_1135_18272_18339(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType)
                {
                    this_param.ReportLogEntryHelper(message, entryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 18272, 18339);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 18205, 18351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 18205, 18351);
            }
        }

        private void ReportLogEntryHelper(string message, XmlLoaderLoggerEntry.EntryType entryType, bool failToLoadFile = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 18363, 20349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 18508, 18551);

                string
                currentPath = f_1135_18529_18550(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 18565, 18621);

                XmlLoaderLoggerEntry
                entry = f_1135_18594_18620()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 18637, 18665);

                entry.entryType = entryType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 18679, 18710);

                entry.filePath = f_1135_18696_18709(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 18724, 18750);

                entry.xPath = currentPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 18764, 18788);

                entry.message = message;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 18804, 19081) || true) && (failToLoadFile)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 18804, 19081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 18856, 19020);

                    f_1135_18856_19019(entryType == XmlLoaderLoggerEntry.EntryType.Error, "the entry type should be 'error' when a file cannot be loaded");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19038, 19066);

                    entry.failToLoadFile = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 18804, 19081);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19097, 19121);

                f_1135_19097_19120(
                            _logger, entry);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19137, 20338) || true) && (entryType == XmlLoaderLoggerEntry.EntryType.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 19137, 20338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19224, 19245);

                    _currentErrorCount++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19263, 20323) || true) && (_currentErrorCount >= _maxNumberOfErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 19263, 20323);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19415, 19998) || true) && (_maxNumberOfErrors > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 19415, 19998);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19491, 19551);

                            XmlLoaderLoggerEntry
                            lastEntry = f_1135_19524_19550()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19579, 19638);

                            lastEntry.entryType = XmlLoaderLoggerEntry.EntryType.Error;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19664, 19699);

                            lastEntry.filePath = f_1135_19685_19698(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19725, 19755);

                            lastEntry.xPath = currentPath;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19781, 19874);

                            lastEntry.message = f_1135_19801_19873(f_1135_19819_19862(), f_1135_19864_19872());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19900, 19928);

                            f_1135_19900_19927(_logger, lastEntry);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 19954, 19975);

                            _currentErrorCount++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 19415, 19998);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 20160, 20216);

                        TooManyErrorsException
                        e = f_1135_20187_20215()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 20240, 20274);

                        e.errorCount = _currentErrorCount;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 20296, 20304);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 19263, 20323);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 19137, 20338);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 18363, 20349);

                string
                f_1135_18529_18550(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 18529, 18550);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry
                f_1135_18594_18620()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 18594, 18620);
                    return return_v;
                }


                string
                f_1135_18696_18709(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 18696, 18709);
                    return return_v;
                }


                int
                f_1135_18856_19019(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    System.Management.Automation.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 18856, 19019);
                    return 0;
                }


                int
                f_1135_19097_19120(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
                this_param, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry
                entry)
                {
                    this_param.LogEntry(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 19097, 19120);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry
                f_1135_19524_19550()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 19524, 19550);
                    return return_v;
                }


                string
                f_1135_19685_19698(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 19685, 19698);
                    return return_v;
                }


                string
                f_1135_19819_19862()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.TooManyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 19819, 19862);
                    return return_v;
                }


                string
                f_1135_19864_19872()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 19864, 19872);
                    return return_v;
                }


                string
                f_1135_19801_19873(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 19801, 19873);
                    return return_v;
                }


                int
                f_1135_19900_19927(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
                this_param, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry
                entry)
                {
                    this_param.LogEntry(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 19900, 19927);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TooManyErrorsException
                f_1135_20187_20215()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TooManyErrorsException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 20187, 20215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 18363, 20349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 18363, 20349);
            }
        }

        protected void ReportErrorForLoadingFromObjectModel(string message, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 20571, 21840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 20680, 20736);

                XmlLoaderLoggerEntry
                entry = f_1135_20709_20735()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 20752, 20807);

                entry.entryType = XmlLoaderLoggerEntry.EntryType.Error;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 20821, 20845);

                entry.message = message;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 20859, 20883);

                f_1135_20859_20882(_logger, entry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 20899, 20920);

                _currentErrorCount++;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 20934, 21829) || true) && (_currentErrorCount >= _maxNumberOfErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 20934, 21829);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 21074, 21528) || true) && (_maxNumberOfErrors > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 21074, 21528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 21142, 21202);

                        XmlLoaderLoggerEntry
                        lastEntry = f_1135_21175_21201()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 21226, 21285);

                        lastEntry.entryType = XmlLoaderLoggerEntry.EntryType.Error;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 21307, 21416);

                        lastEntry.message = f_1135_21327_21415(f_1135_21345_21404(), typeName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 21438, 21466);

                        f_1135_21438_21465(_logger, lastEntry);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 21488, 21509);

                        _currentErrorCount++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 21074, 21528);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 21678, 21734);

                    TooManyErrorsException
                    e = f_1135_21705_21733()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 21754, 21788);

                    e.errorCount = _currentErrorCount;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 21806, 21814);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 20934, 21829);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 20571, 21840);

                Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry
                f_1135_20709_20735()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 20709, 20735);
                    return return_v;
                }


                int
                f_1135_20859_20882(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
                this_param, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry
                entry)
                {
                    this_param.LogEntry(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 20859, 20882);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry
                f_1135_21175_21201()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 21175, 21201);
                    return return_v;
                }


                string
                f_1135_21345_21404()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.TooManyErrorsInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 21345, 21404);
                    return return_v;
                }


                string
                f_1135_21327_21415(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 21327, 21415);
                    return return_v;
                }


                int
                f_1135_21438_21465(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
                this_param, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry
                entry)
                {
                    this_param.LogEntry(entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 21438, 21465);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TooManyErrorsException
                f_1135_21705_21733()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TooManyErrorsException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 21705, 21733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 20571, 21840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 20571, 21840);
            }
        }

        private void WriteStackLocation(string label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 21852, 21952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 21922, 21941);

                f_1135_21922_21940(this, label);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 21852, 21952);

                int
                f_1135_21922_21940(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 21922, 21940);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 21852, 21952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 21852, 21952);
            }
        }

        protected string ComputeCurrentXPath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 21964, 22609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 22027, 22068);

                StringBuilder
                path = f_1135_22048_22067()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 22082, 22534);
                    foreach (XmlLoaderStackFrame sf in f_1135_22117_22132_I(_executionStack))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 22082, 22534);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 22166, 22186);

                        f_1135_22166_22185(path, 0, "/");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 22204, 22519) || true) && (sf.index != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 22204, 22519);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 22264, 22389);

                            f_1135_22264_22388(path, 1, f_1135_22279_22387(f_1135_22293_22321(), "{0}[{1}]", f_1135_22360_22372(sf.node), sf.index + 1));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 22204, 22519);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 22204, 22519);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 22471, 22500);

                            f_1135_22471_22499(path, 1, f_1135_22486_22498(sf.node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 22204, 22519);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 22082, 22534);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1135, 1, 453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1135, 1, 453);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 22550, 22598);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1135, 22557, 22572) || ((f_1135_22557_22568(path) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1135, 22575, 22590)) || DynAbs.Tracing.TraceSender.Conditional_F3(1135, 22593, 22597))) ? f_1135_22575_22590(path) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 21964, 22609);

                System.Text.StringBuilder
                f_1135_22048_22067()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 22048, 22067);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1135_22166_22185(System.Text.StringBuilder
                this_param, int
                index, string
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 22166, 22185);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1135_22293_22321()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 22293, 22321);
                    return return_v;
                }


                string
                f_1135_22360_22372(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 22360, 22372);
                    return return_v;
                }


                string
                f_1135_22279_22387(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 22279, 22387);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1135_22264_22388(System.Text.StringBuilder
                this_param, int
                index, string
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 22264, 22388);
                    return return_v;
                }


                string
                f_1135_22486_22498(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 22486, 22498);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1135_22471_22499(System.Text.StringBuilder
                this_param, int
                index, string
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 22471, 22499);
                    return return_v;
                }


                System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase.XmlLoaderStackFrame>
                f_1135_22117_22132_I(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase.XmlLoaderStackFrame>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 22117, 22132);
                    return return_v;
                }


                int
                f_1135_22557_22568(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 22557, 22568);
                    return return_v;
                }


                string
                f_1135_22575_22590(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 22575, 22590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 21964, 22609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 21964, 22609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected XmlDocument LoadXmlDocumentFromFileLoadingInfo(AuthorizationManager authorizationManager, PSHost host, out bool isFullyTrusted)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 22674, 24623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 22870, 22945);

                ExternalScriptInfo
                ps1xmlInfo = f_1135_22902_22944(f_1135_22925_22933(), f_1135_22935_22943())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 22959, 23007);

                string
                fileContents = f_1135_22981_23006(ps1xmlInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 23023, 23046);

                isFullyTrusted = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 23060, 23197) || true) && (f_1135_23064_23095(ps1xmlInfo) == PSLanguageMode.FullLanguage)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 23060, 23197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 23160, 23182);

                    isFullyTrusted = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 23060, 23197);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 23213, 23917) || true) && (authorizationManager != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1135, 23213, 23917);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 23323, 23404);

                        f_1135_23323_23403(authorizationManager, ps1xmlInfo, CommandOrigin.Internal, host);
                    }
                    catch (PSSecurityException reason)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1135, 23441, 23902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 23516, 23732);

                        string
                        errorMessage = f_1135_23538_23731(f_1135_23556_23591(), string.Empty, f_1135_23681_23689(), f_1135_23716_23730(reason))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 23754, 23849);

                        f_1135_23754_23848(this, errorMessage, XmlLoaderLoggerEntry.EntryType.Error, failToLoadFile: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 23871, 23883);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1135, 23441, 23902);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1135, 23213, 23917);
                }

                // load file into XML document
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 24013, 24206);

                    XmlDocument
                    doc = f_1135_24031_24205(fileContents, true, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 24252, 24294);

                    f_1135_24252_24293(this, "XmlDocument loaded OK");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 24312, 24323);

                    return doc;
                }
                catch (XmlException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1135, 24352, 24612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 24407, 24507);

                    f_1135_24407_24506(this, f_1135_24424_24505(f_1135_24442_24483(), f_1135_24485_24493(), f_1135_24495_24504(e)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 24525, 24567);

                    f_1135_24525_24566(this, "XmlDocument discarded");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 24585, 24597);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1135, 24352, 24612);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 22674, 24623);

                string
                f_1135_22925_22933()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 22925, 22933);
                    return return_v;
                }


                string
                f_1135_22935_22943()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 22935, 22943);
                    return return_v;
                }


                System.Management.Automation.ExternalScriptInfo
                f_1135_22902_22944(string
                name, string
                path)
                {
                    var return_v = new System.Management.Automation.ExternalScriptInfo(name, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 22902, 22944);
                    return return_v;
                }


                string
                f_1135_22981_23006(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.ScriptContents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 22981, 23006);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1135_23064_23095(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.DefiningLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 23064, 23095);
                    return return_v;
                }


                int
                f_1135_23323_23403(System.Management.Automation.AuthorizationManager
                this_param, System.Management.Automation.ExternalScriptInfo
                commandInfo, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.Host.PSHost
                host)
                {
                    this_param.ShouldRunInternal((System.Management.Automation.CommandInfo)commandInfo, origin, host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 23323, 23403);
                    return 0;
                }


                string
                f_1135_23556_23591()
                {
                    var return_v = TypesXmlStrings.ValidationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 23556, 23591);
                    return return_v;
                }


                string
                f_1135_23681_23689()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 23681, 23689);
                    return return_v;
                }


                string
                f_1135_23716_23730(System.Management.Automation.PSSecurityException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 23716, 23730);
                    return return_v;
                }


                string
                f_1135_23538_23731(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 23538, 23731);
                    return return_v;
                }


                int
                f_1135_23754_23848(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message, Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLoggerEntry.EntryType
                entryType, bool
                failToLoadFile)
                {
                    this_param.ReportLogEntryHelper(message, entryType, failToLoadFile: failToLoadFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 23754, 23848);
                    return 0;
                }


                System.Xml.XmlDocument
                f_1135_24031_24205(string
                xmlContents, bool
                preserveNonElements, int?
                maxCharactersInDocument)
                {
                    var return_v = InternalDeserializer.LoadUnsafeXmlDocument(xmlContents, preserveNonElements, maxCharactersInDocument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 24031, 24205);
                    return return_v;
                }


                int
                f_1135_24252_24293(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 24252, 24293);
                    return 0;
                }


                string
                f_1135_24442_24483()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ErrorInFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 24442, 24483);
                    return return_v;
                }


                string
                f_1135_24485_24493()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 24485, 24493);
                    return return_v;
                }


                string
                f_1135_24495_24504(System.Xml.XmlException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1135, 24495, 24504);
                    return return_v;
                }


                string
                f_1135_24424_24505(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 24424, 24505);
                    return return_v;
                }


                int
                f_1135_24407_24506(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 24407, 24506);
                    return 0;
                }


                int
                f_1135_24525_24566(Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 24525, 24566);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 22674, 24623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 22674, 24623);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected string FilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 24818, 24898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 24854, 24883);

                    return _loadingInfo.filePath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 24818, 24898);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 24768, 24909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 24768, 24909);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected void SetDatabaseLoadingInfo(XmlFileLoadInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 24921, 25116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25005, 25053);

                _loadingInfo.fileDirectory = info.fileDirectory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25067, 25105);

                _loadingInfo.filePath = info.filePath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 24921, 25116);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 24921, 25116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 24921, 25116);
            }
        }

        protected void SetLoadingInfoIsFullyTrusted(bool isFullyTrusted)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 25128, 25273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25217, 25262);

                _loadingInfo.isFullyTrusted = isFullyTrusted;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 25128, 25273);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 25128, 25273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 25128, 25273);
            }
        }

        protected void SetLoadingInfoIsProductCode(bool isProductCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 25285, 25426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25372, 25415);

                _loadingInfo.isProductCode = isProductCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 25285, 25426);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 25285, 25426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 25285, 25426);
            }
        }

        private DatabaseLoadingInfo _loadingInfo;

        protected DatabaseLoadingInfo LoadingInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1135, 25585, 25975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25621, 25674);

                    DatabaseLoadingInfo
                    info = f_1135_25648_25673()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25692, 25730);

                    info.filePath = _loadingInfo.filePath;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25748, 25796);

                    info.fileDirectory = _loadingInfo.fileDirectory;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25814, 25864);

                    info.isFullyTrusted = _loadingInfo.isFullyTrusted;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25882, 25930);

                    info.isProductCode = _loadingInfo.isProductCode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25948, 25960);

                    return info;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1135, 25585, 25975);

                    Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                    f_1135_25648_25673()
                    {
                        var return_v = new Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 25648, 25673);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1135, 25519, 25986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 25519, 25986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected PSPropertyExpressionFactory expressionFactory;

        protected DisplayResourceManagerCache displayResourceManagerCache;

        internal bool VerifyStringResources { get; }

        private int _maxNumberOfErrors;

        private int _currentErrorCount;

        private bool _logStackActivity;

        private Stack<XmlLoaderStackFrame> _executionStack;

        private XmlLoaderLogger _logger;

        public XmlLoaderBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1135, 5475, 26515);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 25466, 25506);
            this._loadingInfo = f_1135_25481_25506();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 26036, 26053);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 26104, 26131);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 26144, 26196);
            this.VerifyStringResources = true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 26220, 26243);
            this._maxNumberOfErrors = 30;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 26268, 26290);
            this._currentErrorCount = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 26316, 26341);
            this._logStackActivity = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 26389, 26439);
            this._executionStack = f_1135_26407_26439();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 26476, 26507);
            this._logger = f_1135_26486_26507();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1135, 5475, 26515);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 5475, 26515);
        }


        static XmlLoaderBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1135, 5475, 26515);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1135, 5653, 5721);
            s_tracer = f_1135_5664_5721("XmlLoaderBase", "XmlLoaderBase");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1135, 5475, 26515);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1135, 5475, 26515);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1135, 5475, 26515);

        static System.Management.Automation.PSTraceSource
        f_1135_5664_5721(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 5664, 5721);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
        f_1135_25481_25506()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 25481, 25506);
            return return_v;
        }


        System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase.XmlLoaderStackFrame>
        f_1135_26407_26439()
        {
            var return_v = new System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderBase.XmlLoaderStackFrame>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 26407, 26439);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger
        f_1135_26486_26507()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.XmlLoaderLogger();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1135, 26486, 26507);
            return return_v;
        }

    }
}
