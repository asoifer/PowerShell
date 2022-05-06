// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using Xunit;

namespace PSTests.Parallel
{
    public class MshSnapinInfoTests
    {
        [SkippableFact]
        public void TestReadRegistryInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(956, 367, 717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(956, 451, 482);

                f_956_451_481(f_956_462_480());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(956, 496, 523);

                Version
                someVersion = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(956, 537, 562);

                string
                someString = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(956, 576, 706);

                f_956_576_705(out someVersion, out someString, out someString, out someString, out someString, out someVersion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(956, 367, 717);

                bool
                f_956_462_480()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(956, 462, 480);
                    return return_v;
                }


                int
                f_956_451_481(bool
                condition)
                {
                    Skip.IfNot(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(956, 451, 481);
                    return 0;
                }


                int
                f_956_576_705(out System.Version
                assemblyVersion, out string
                publicKeyToken, out string
                culture, out string
                architecture, out string
                applicationBase, out System.Version
                psVersion)
                {
                    PSSnapInReader.ReadRegistryInfo(out assemblyVersion, out publicKeyToken, out culture, out architecture, out applicationBase, out psVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(956, 576, 705);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(956, 367, 717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(956, 367, 717);
            }
        }

        [SkippableFact]
        public void TestReadCoreEngineSnapIn()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(956, 773, 1081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(956, 861, 892);

                f_956_861_891(f_956_872_890());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(956, 906, 972);

                PSSnapInInfo
                pSSnapInInfo = f_956_934_971()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(956, 986, 1070);

                f_956_986_1069("PublicKeyToken=31bf3856ad364e35", f_956_1043_1068(pSSnapInInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(956, 773, 1081);

                bool
                f_956_872_890()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(956, 872, 890);
                    return return_v;
                }


                int
                f_956_861_891(bool
                condition)
                {
                    Skip.IfNot(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(956, 861, 891);
                    return 0;
                }


                System.Management.Automation.PSSnapInInfo
                f_956_934_971()
                {
                    var return_v = PSSnapInReader.ReadCoreEngineSnapIn();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(956, 934, 971);
                    return return_v;
                }


                string
                f_956_1043_1068(System.Management.Automation.PSSnapInInfo
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(956, 1043, 1068);
                    return return_v;
                }


                bool
                f_956_986_1069(string
                expectedSubstring, string
                actualString)
                {
                    var return_v = CustomAssert.Contains(expectedSubstring, actualString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(956, 986, 1069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(956, 773, 1081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(956, 773, 1081);
            }
        }

        public MshSnapinInfoTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(956, 266, 1088);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(956, 266, 1088);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(956, 266, 1088);
        }


        static MshSnapinInfoTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(956, 266, 1088);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(956, 266, 1088);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(956, 266, 1088);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(956, 266, 1088);
    }
}
