// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Management.Automation
{
    public class ApplicationInfo : CommandInfo
    {
        internal ApplicationInfo(string name, string path, ExecutionContext context) : base(f_1234_1475_1479_C(name), CommandTypes.Application)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1234, 1391, 1931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 1968, 1976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 2114, 2157);
                this.Path = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 2273, 2321);
                this.Extension = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 3359, 3367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 4405, 4423);
                this._outputType = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 1531, 1659) || true) && (f_1234_1535_1561(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1234, 1531, 1659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 1595, 1644);

                    throw f_1234_1601_1643("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1234, 1531, 1659);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 1675, 1799) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1234, 1675, 1799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 1728, 1784);

                    throw f_1234_1734_1783("context");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1234, 1675, 1799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 1815, 1827);

                Path = path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 1841, 1887);

                Extension = f_1234_1853_1886(path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 1901, 1920);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1234, 1391, 1931);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1234, 1391, 1931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1234, 1391, 1931);
            }
        }

        private ExecutionContext _context;

        public string Path { get; }

        public string Extension { get; }

        public override string Definition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1234, 2490, 2553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 2526, 2538);

                    return f_1234_2533_2537();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1234, 2490, 2553);

                    string
                    f_1234_2533_2537()
                    {
                        var return_v = Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1234, 2533, 2537);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1234, 2432, 2564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1234, 2432, 2564);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Source
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1234, 2723, 2754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 2729, 2752);

                    return f_1234_2736_2751(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1234, 2723, 2754);

                    string
                    f_1234_2736_2751(System.Management.Automation.ApplicationInfo
                    this_param)
                    {
                        var return_v = this_param.Definition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1234, 2736, 2751);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1234, 2669, 2765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1234, 2669, 2765);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Version Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1234, 2918, 3320);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 2954, 3269) || true) && (_version == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1234, 2954, 3269);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 3016, 3083);

                        FileVersionInfo
                        versionInfo = f_1234_3046_3082(f_1234_3077_3081())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 3105, 3250);

                        _version = f_1234_3116_3249(f_1234_3128_3156(versionInfo), f_1234_3158_3186(versionInfo), f_1234_3188_3216(versionInfo), f_1234_3218_3248(versionInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1234, 2954, 3269);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 3289, 3305);

                    return _version;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1234, 2918, 3320);

                    string
                    f_1234_3077_3081()
                    {
                        var return_v = Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1234, 3077, 3081);
                        return return_v;
                    }


                    System.Diagnostics.FileVersionInfo
                    f_1234_3046_3082(string
                    fileName)
                    {
                        var return_v = FileVersionInfo.GetVersionInfo(fileName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 3046, 3082);
                        return return_v;
                    }


                    int
                    f_1234_3128_3156(System.Diagnostics.FileVersionInfo
                    this_param)
                    {
                        var return_v = this_param.ProductMajorPart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1234, 3128, 3156);
                        return return_v;
                    }


                    int
                    f_1234_3158_3186(System.Diagnostics.FileVersionInfo
                    this_param)
                    {
                        var return_v = this_param.ProductMinorPart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1234, 3158, 3186);
                        return return_v;
                    }


                    int
                    f_1234_3188_3216(System.Diagnostics.FileVersionInfo
                    this_param)
                    {
                        var return_v = this_param.ProductBuildPart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1234, 3188, 3216);
                        return return_v;
                    }


                    int
                    f_1234_3218_3248(System.Diagnostics.FileVersionInfo
                    this_param)
                    {
                        var return_v = this_param.ProductPrivatePart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1234, 3218, 3248);
                        return return_v;
                    }


                    System.Version
                    f_1234_3116_3249(int
                    major, int
                    minor, int
                    build, int
                    revision)
                    {
                        var return_v = new System.Version(major, minor, build, revision);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 3116, 3249);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1234, 2862, 3331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1234, 2862, 3331);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Version _version;

        public override SessionStateEntryVisibility Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1234, 3563, 3682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 3599, 3667);

                    return f_1234_3606_3666(f_1234_3606_3633(_context), f_1234_3661_3665());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1234, 3563, 3682);

                    System.Management.Automation.SessionStateInternal
                    f_1234_3606_3633(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1234, 3606, 3633);
                        return return_v;
                    }


                    string
                    f_1234_3661_3665()
                    {
                        var return_v = Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1234, 3661, 3665);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateEntryVisibility
                    f_1234_3606_3666(System.Management.Automation.SessionStateInternal
                    this_param, string
                    applicationPath)
                    {
                        var return_v = this_param.CheckApplicationVisibility(applicationPath);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 3606, 3666);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1234, 3484, 3766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1234, 3484, 3766);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1234, 3698, 3755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 3704, 3753);

                    throw f_1234_3710_3752();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1234, 3698, 3755);

                    System.Management.Automation.PSNotImplementedException
                    f_1234_3710_3752()
                    {
                        var return_v = PSTraceSource.NewNotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 3710, 3752);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1234, 3484, 3766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1234, 3484, 3766);
                }
            }
        }

        public override ReadOnlyCollection<PSTypeName> OutputType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1234, 3991, 4343);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 4027, 4289) || true) && (_outputType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1234, 4027, 4289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 4092, 4136);

                        List<PSTypeName>
                        l = f_1234_4113_4135()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 4158, 4196);

                        f_1234_4158_4195(l, f_1234_4164_4194(typeof(string)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 4218, 4270);

                        _outputType = f_1234_4232_4269(l);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1234, 4027, 4289);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1234, 4309, 4328);

                    return _outputType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1234, 3991, 4343);

                    System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    f_1234_4113_4135()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 4113, 4135);
                        return return_v;
                    }


                    System.Management.Automation.PSTypeName
                    f_1234_4164_4194(System.Type
                    type)
                    {
                        var return_v = new System.Management.Automation.PSTypeName(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 4164, 4194);
                        return return_v;
                    }


                    int
                    f_1234_4158_4195(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    this_param, System.Management.Automation.PSTypeName
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 4158, 4195);
                        return 0;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    f_1234_4232_4269(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    list)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>((System.Collections.Generic.IList<System.Management.Automation.PSTypeName>)list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 4232, 4269);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1234, 3909, 4354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1234, 3909, 4354);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReadOnlyCollection<PSTypeName> _outputType;

        static ApplicationInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1234, 575, 4431);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1234, 575, 4431);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1234, 575, 4431);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1234, 575, 4431);

        bool
        f_1234_1535_1561(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 1535, 1561);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1234_1601_1643(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 1601, 1643);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1234_1734_1783(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 1734, 1783);
            return return_v;
        }


        string?
        f_1234_1853_1886(string
        path)
        {
            var return_v = System.IO.Path.GetExtension(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1234, 1853, 1886);
            return return_v;
        }


        static string
        f_1234_1475_1479_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1234, 1391, 1931);
            return return_v;
        }

    }
}
