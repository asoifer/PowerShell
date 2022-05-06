// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Management.Automation;
using System.Runtime.InteropServices;

namespace Microsoft.PowerShell
{
    public static class ProcessCodeMethods
    {
        const int
        InvalidProcessId = -1
        ;

        internal static Process GetParent(this Process process)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1315, 441, 1069);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 557, 589);

                    var
                    pid = f_1315_567_588(process)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 607, 707) || true) && (pid == InvalidProcessId)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1315, 607, 707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 676, 688);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1315, 607, 707);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 727, 771);

                    var
                    candidate = f_1315_743_770(pid)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 886, 952);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1315, 893, 932) || ((f_1315_893_912(candidate) > f_1315_915_932(process) && DynAbs.Tracing.TraceSender.Conditional_F2(1315, 935, 939)) || DynAbs.Tracing.TraceSender.Conditional_F3(1315, 942, 951))) ? null : candidate;
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1315, 981, 1058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 1031, 1043);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1315, 981, 1058);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1315, 441, 1069);

                int
                f_1315_567_588(System.Diagnostics.Process
                process)
                {
                    var return_v = GetParentPid(process);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1315, 567, 588);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1315_743_770(int
                processId)
                {
                    var return_v = Process.GetProcessById(processId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1315, 743, 770);
                    return return_v;
                }


                System.DateTime
                f_1315_893_912(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StartTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1315, 893, 912);
                    return return_v;
                }


                System.DateTime
                f_1315_915_932(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StartTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1315, 915, 932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1315, 441, 1069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1315, 441, 1069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object GetParentProcess(PSObject obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1315, 1333, 1506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 1409, 1453);

                var
                process = f_1315_1423_1441(obj) as Process
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 1467, 1495);

                return f_1315_1482_1494(process);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1315, 1333, 1506);

                object
                f_1315_1423_1441(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1315, 1423, 1441);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1315_1482_1494(System.Diagnostics.Process
                process)
                {
                    var return_v = process?.GetParent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1315, 1482, 1494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1315, 1333, 1506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1315, 1333, 1506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetParentPid(Process process)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1315, 1909, 2371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 1983, 2064);

                f_1315_1983_2063(process != null, "Ensure process is not null before calling");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 2078, 2108);

                PROCESS_BASIC_INFORMATION
                pbi
                = default(PROCESS_BASIC_INFORMATION);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 2122, 2131);

                int
                size
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 2145, 2264);

                var
                res = f_1315_2155_2263(f_1315_2181_2195(process), 0, out pbi, f_1315_2209_2252(), out size)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 2280, 2360);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1315, 2287, 2295) || ((res != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1315, 2298, 2314)) || DynAbs.Tracing.TraceSender.Conditional_F3(1315, 2317, 2359))) ? InvalidProcessId : pbi.InheritedFromUniqueProcessId.ToInt32();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1315, 1909, 2371);

                int
                f_1315_1983_2063(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1315, 1983, 2063);
                    return 0;
                }


                System.IntPtr
                f_1315_2181_2195(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1315, 2181, 2195);
                    return return_v;
                }


                int
                f_1315_2209_2252()
                {
                    var return_v = Marshal.SizeOf<PROCESS_BASIC_INFORMATION>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1315, 2209, 2252);
                    return return_v;
                }


                int
                f_1315_2155_2263(System.IntPtr
                processHandle, int
                processInformationClass, out Microsoft.PowerShell.ProcessCodeMethods.PROCESS_BASIC_INFORMATION
                processInformation, int
                processInformationLength, out int
                returnLength)
                {
                    var return_v = NtQueryInformationProcess(processHandle, processInformationClass, out processInformation, processInformationLength, out returnLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1315, 2155, 2263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1315, 1909, 2371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1315, 1909, 2371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [StructLayout(LayoutKind.Sequential)]
        struct PROCESS_BASIC_INFORMATION
        {

            public IntPtr ExitStatus;

            public IntPtr PebBaseAddress;

            public IntPtr AffinityMask;

            public IntPtr BasePriority;

            public IntPtr UniqueProcessId;

            public IntPtr InheritedFromUniqueProcessId;
            static PROCESS_BASIC_INFORMATION()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1315, 2383, 2749);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1315, 2383, 2749);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1315, 2383, 2749);
            }
        }

        [DllImport("ntdll.dll", SetLastError = true)]
        static extern int NtQueryInformationProcess(
                        IntPtr processHandle,
                        int processInformationClass,
                        out PROCESS_BASIC_INFORMATION processInformation,
                        int processInformationLength,
                        out int returnLength);

        static ProcessCodeMethods()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1315, 342, 3116);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1315, 407, 428);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1315, 342, 3116);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1315, 342, 3116);
        }

    }
}
