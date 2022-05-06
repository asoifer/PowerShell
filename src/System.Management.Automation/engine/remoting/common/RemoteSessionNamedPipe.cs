// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting.Server;
using System.Management.Automation.Tracing;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Win32.SafeHandles;

using Dbg = System.Diagnostics.Debug;

namespace System.Management.Automation.Remoting
{
    internal static class NamedPipeUtils
    {
        internal const string
        NamedPipeNamePrefix = "PSHost."
        ;

        internal const string
        DefaultAppDomainName = "DefaultAppDomain"
        ;

        internal const string
        NamedPipeNamePrefixSearch = "PSHost*"
        ;

        internal const int
        MaxNamedPipeNameSize = 104
        ;

        internal static string CreateProcessPipeName(
                    int procId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 1737, 1941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 1832, 1930);

                return f_1627_1839_1929(f_1627_1879_1928(procId));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 1737, 1941);

                System.Diagnostics.Process
                f_1627_1879_1928(int
                processId)
                {
                    var return_v = System.Diagnostics.Process.GetProcessById(processId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 1879, 1928);
                    return return_v;
                }


                string
                f_1627_1839_1929(System.Diagnostics.Process
                proc)
                {
                    var return_v = CreateProcessPipeName(proc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 1839, 1929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 1737, 1941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 1737, 1941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CreateProcessPipeName(
                    System.Diagnostics.Process proc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 2245, 2429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 2361, 2418);

                return f_1627_2368_2417(proc, DefaultAppDomainName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 2245, 2429);

                string
                f_1627_2368_2417(System.Diagnostics.Process
                proc, string
                appDomainName)
                {
                    var return_v = CreateProcessPipeName(proc, appDomainName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 2368, 2417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 2245, 2429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 2245, 2429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CreateProcessPipeName(
                    int procId,
                    string appDomainName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 2844, 3080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 2974, 3069);

                return f_1627_2981_3068(f_1627_3003_3052(procId), appDomainName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 2844, 3080);

                System.Diagnostics.Process
                f_1627_3003_3052(int
                processId)
                {
                    var return_v = System.Diagnostics.Process.GetProcessById(processId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 3003, 3052);
                    return return_v;
                }


                string
                f_1627_2981_3068(System.Diagnostics.Process
                proc, string
                appDomainName)
                {
                    var return_v = CreateProcessPipeName(proc, appDomainName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 2981, 3068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 2844, 3080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 2844, 3080);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CreateProcessPipeName(
                    System.Diagnostics.Process proc,
                    string appDomainName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 3494, 5499);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 3645, 3752) || true) && (proc == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 3645, 3752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 3695, 3737);

                    throw f_1627_3701_3736("proc");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 3645, 3752);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 3768, 3893) || true) && (f_1627_3772_3807(appDomainName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 3768, 3893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 3841, 3878);

                    appDomainName = DefaultAppDomainName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 3768, 3893);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 3909, 4005);

                System.Text.StringBuilder
                pipeNameBuilder = f_1627_3953_4004(MaxNamedPipeNameSize)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 4019, 4914);

                f_1627_4019_4913(f_1627_4019_4870(f_1627_4019_4840(f_1627_4019_4769(f_1627_4019_4739(f_1627_4019_4666(f_1627_4019_4628(f_1627_4019_4062(pipeNameBuilder, NamedPipeNamePrefix), f_1627_4561_4627(proc.StartTime.ToFileTime(), f_1627_4598_4626())), '.'), f_1627_4692_4738(f_1627_4692_4699(proc), f_1627_4709_4737())), '.'), f_1627_4795_4839(appDomainName)), '.'), f_1627_4896_4912(proc));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 5454, 5488);

                return f_1627_5461_5487(pipeNameBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 3494, 5499);

                System.Management.Automation.PSArgumentNullException
                f_1627_3701_3736(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 3701, 3736);
                    return return_v;
                }


                bool
                f_1627_3772_3807(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 3772, 3807);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1627_3953_4004(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 3953, 4004);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1627_4019_4062(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4019, 4062);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1627_4598_4626()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 4598, 4626);
                    return return_v;
                }


                string
                f_1627_4561_4627(long
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4561, 4627);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1627_4019_4628(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4019, 4628);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1627_4019_4666(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4019, 4666);
                    return return_v;
                }


                int
                f_1627_4692_4699(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 4692, 4699);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1627_4709_4737()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 4709, 4737);
                    return return_v;
                }


                string
                f_1627_4692_4738(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4692, 4738);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1627_4019_4739(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4019, 4739);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1627_4019_4769(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4019, 4769);
                    return return_v;
                }


                string
                f_1627_4795_4839(string
                appDomainName)
                {
                    var return_v = CleanAppDomainNameForPipeName(appDomainName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4795, 4839);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1627_4019_4840(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4019, 4840);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1627_4019_4870(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4019, 4870);
                    return return_v;
                }


                string
                f_1627_4896_4912(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.ProcessName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 4896, 4912);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1627_4019_4913(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 4019, 4913);
                    return return_v;
                }


                string
                f_1627_5461_5487(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 5461, 5487);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 3494, 5499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 3494, 5499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string CleanAppDomainNameForPipeName(string appDomainName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 5511, 5785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 5699, 5774);

                return f_1627_5706_5773(f_1627_5706_5746(appDomainName, ":", string.Empty), " ", string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 5511, 5785);

                string
                f_1627_5706_5746(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 5706, 5746);
                    return return_v;
                }


                string
                f_1627_5706_5773(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 5706, 5773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 5511, 5785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 5511, 5785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetCurrentAppDomainName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 5956, 6376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 6128, 6156);

                return DefaultAppDomainName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 5956, 6376);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 5956, 6376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 5956, 6376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamedPipeUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1627, 736, 6405);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 840, 871);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 1122, 1163);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 1196, 1233);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 1352, 1378);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1627, 736, 6405);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 736, 6405);
        }

    }
    internal static class NamedPipeNative
    {
        internal const uint
        PIPE_ACCESS_DUPLEX = 0x00000003
        ;

        internal const uint
        PIPE_ACCESS_OUTBOUND = 0x00000002
        ;

        internal const uint
        PIPE_ACCESS_INBOUND = 0x00000001
        ;

        internal const uint
        PIPE_TYPE_BYTE = 0x00000000
        ;

        internal const uint
        PIPE_TYPE_MESSAGE = 0x00000004
        ;

        internal const uint
        FILE_FLAG_OVERLAPPED = 0x40000000
        ;

        internal const uint
        FILE_FLAG_FIRST_PIPE_INSTANCE = 0x00080000
        ;

        internal const uint
        PIPE_WAIT = 0x00000000
        ;

        internal const uint
        PIPE_NOWAIT = 0x00000001
        ;

        internal const uint
        PIPE_READMODE_BYTE = 0x00000000
        ;

        internal const uint
        PIPE_READMODE_MESSAGE = 0x00000002
        ;

        internal const uint
        PIPE_ACCEPT_REMOTE_CLIENTS = 0x00000000
        ;

        internal const uint
        PIPE_REJECT_REMOTE_CLIENTS = 0x00000008
        ;

        internal const uint
        ERROR_FILE_NOT_FOUND = 2
        ;

        internal const uint
        ERROR_BROKEN_PIPE = 109
        ;

        internal const uint
        ERROR_PIPE_BUSY = 231
        ;

        internal const uint
        ERROR_NO_DATA = 232
        ;

        internal const uint
        ERROR_MORE_DATA = 234
        ;

        internal const uint
        ERROR_PIPE_CONNECTED = 535
        ;

        internal const uint
        ERROR_IO_INCOMPLETE = 996
        ;

        internal const uint
        ERROR_IO_PENDING = 997
        ;

        internal const uint
        GENERIC_READ = 0x80000000
        ;

        internal const uint
        GENERIC_WRITE = 0x40000000
        ;

        internal const uint
        GENERIC_EXECUTE = 0x20000000
        ;

        internal const uint
        GENERIC_ALL = 0x10000000
        ;

        internal const uint
        CREATE_NEW = 1
        ;

        internal const uint
        CREATE_ALWAYS = 2
        ;

        internal const uint
        OPEN_EXISTING = 3
        ;

        internal const uint
        OPEN_ALWAYS = 4
        ;

        internal const uint
        TRUNCATE_EXISTING = 5
        ;

        internal const uint
        SECURITY_IMPERSONATIONLEVEL_ANONYMOUS = 0
        ;

        internal const uint
        SECURITY_IMPERSONATIONLEVEL_IDENTIFICATION = 1
        ;

        internal const uint
        SECURITY_IMPERSONATIONLEVEL_IMPERSONATION = 2
        ;

        internal const uint
        SECURITY_IMPERSONATIONLEVEL_DELEGATION = 3
        ;

        internal const uint
        INFINITE = 0xFFFFFFFF
        ;
        [StructLayout(LayoutKind.Sequential)]
        internal class SECURITY_ATTRIBUTES
        {
            public int NLength;

            public IntPtr LPSecurityDescriptor;

            public bool InheritHandle;

            public SECURITY_ATTRIBUTES()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 9740, 9834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 9146, 9153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 9339, 9373);
                    this.LPSecurityDescriptor = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 9577, 9590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 9801, 9819);

                    this.NLength = 12;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 9740, 9834);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 9740, 9834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 9740, 9834);
                }
            }

            static SECURITY_ATTRIBUTES()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1627, 8853, 9845);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1627, 8853, 9845);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 8853, 9845);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1627, 8853, 9845);
        }

        [DllImport(PinvokeDllNames.CreateNamedPipeDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern SafePipeHandle CreateNamedPipe(
                   string lpName,
                   uint dwOpenMode,
                   uint dwPipeMode,
                   uint nMaxInstances,
                   uint nOutBufferSize,
                   uint nInBufferSize,
                   uint nDefaultTimeOut,
                   SECURITY_ATTRIBUTES securityAttributes);

        internal static SECURITY_ATTRIBUTES GetSecurityAttributes(GCHandle securityDescriptorPinnedHandle, bool inheritHandle = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 10355, 10894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 10506, 10589);

                SECURITY_ATTRIBUTES
                securityAttributes = f_1627_10547_10588()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 10603, 10652);

                securityAttributes.InheritHandle = inheritHandle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 10666, 10735);

                securityAttributes.NLength = (int)f_1627_10700_10734(securityAttributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 10749, 10843);

                securityAttributes.LPSecurityDescriptor = securityDescriptorPinnedHandle.AddrOfPinnedObject();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 10857, 10883);

                return securityAttributes;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 10355, 10894);

                System.Management.Automation.Remoting.NamedPipeNative.SECURITY_ATTRIBUTES
                f_1627_10547_10588()
                {
                    var return_v = new System.Management.Automation.Remoting.NamedPipeNative.SECURITY_ATTRIBUTES();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 10547, 10588);
                    return return_v;
                }


                int
                f_1627_10700_10734(System.Management.Automation.Remoting.NamedPipeNative.SECURITY_ATTRIBUTES
                structure)
                {
                    var return_v = Marshal.SizeOf(structure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 10700, 10734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 10355, 10894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 10355, 10894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DllImport(PinvokeDllNames.CreateFileDllName, SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern SafePipeHandle CreateFile(
                      string lpFileName,
                      uint dwDesiredAccess,
                      uint dwShareMode,
                      IntPtr SecurityAttributes,
                      uint dwCreationDisposition,
                      uint dwFlagsAndAttributes,
                      IntPtr hTemplateFile);

        [DllImport(PinvokeDllNames.WaitNamedPipeDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool WaitNamedPipe(string lpNamedPipeName, uint nTimeOut);

        [DllImport(PinvokeDllNames.ImpersonateNamedPipeClientDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool ImpersonateNamedPipeClient(IntPtr hNamedPipe);

        [DllImport(PinvokeDllNames.RevertToSelfDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool RevertToSelf();

        static NamedPipeNative()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1627, 6489, 12118);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 6625, 6656);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 6687, 6720);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 6751, 6783);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 6839, 6866);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 6897, 6927);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 6958, 6991);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7022, 7064);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7095, 7117);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7148, 7172);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7203, 7234);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7265, 7299);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7330, 7369);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7400, 7439);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7496, 7520);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7551, 7574);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7605, 7626);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7657, 7676);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7707, 7728);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7759, 7785);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7816, 7841);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7872, 7894);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 7963, 7988);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8019, 8045);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8076, 8104);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8135, 8159);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8192, 8206);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8237, 8254);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8285, 8302);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8333, 8348);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8379, 8400);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8433, 8474);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8505, 8551);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8582, 8627);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8658, 8700);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 8762, 8783);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1627, 6489, 12118);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 6489, 12118);
        }

    }
    internal sealed class ListenerEndedEventArgs : EventArgs
    {
        public Exception Reason
        {
            private set;
            get;
        }

        public bool RestartListener
        {
            private set;
            get;
        }

        private ListenerEndedEventArgs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 12882, 12918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 12511, 12600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 12723, 12816);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 12882, 12918);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 12882, 12918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 12882, 12918);
            }
        }

        public ListenerEndedEventArgs(
                    Exception reason,
                    bool restartListener)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 13135, 13331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 12511, 12600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 12723, 12816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 13256, 13272);

                Reason = reason;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 13286, 13320);

                RestartListener = restartListener;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 13135, 13331);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 13135, 13331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 13135, 13331);
            }
        }

        static ListenerEndedEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1627, 12221, 13360);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1627, 12221, 13360);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 12221, 13360);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1627, 12221, 13360);
    }
    public sealed class RemoteSessionNamedPipeServer : IDisposable
    {
        private readonly object _syncObject;

        private PowerShellTraceSource _tracer;

        private const string
        _threadName = "IPC Listener Thread"
        ;

        private const int
        _namedPipeBufferSizeForRemoting = 32768
        ;

        private const int
        _maxPipePathLengthLinux = 108
        ;

        private const int
        _maxPipePathLengthMacOS = 104
        ;

        private static object s_syncObject;

        internal static RemoteSessionNamedPipeServer IPCNamedPipeServer;

        internal static bool IPCNamedPipeServerEnabled;

        private static RemoteSessionNamedPipeServer _customNamedPipeServer;

        private const int
        _pipeAccessMaskFullControl = 0x1f019f
        ;

        internal NamedPipeServerStream Stream { get; }

        internal string PipeName { get; }

        internal bool IsListenerRunning { get; private set; }

        internal string ConfigurationName { get; set; }

        internal StreamReader TextReader { get; private set; }

        internal StreamWriter TextWriter { get; private set; }

        internal bool IsDisposed { get; private set; }

        internal static int NamedPipeBufferSizeForRemoting
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 16082, 16129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 16088, 16127);

                    return _namedPipeBufferSizeForRemoting;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 16082, 16129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 16007, 16140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 16007, 16140);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }



        /// <summary>
        /// Event raised when the named pipe server listening thread
        /// ends.
        /// </summary>
        internal event EventHandler<ListenerEndedEventArgs>
ListenerEnded
;

        internal static RemoteSessionNamedPipeServer CreateRemoteSessionNamedPipeServer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 16681, 17037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 16787, 16851);

                string
                appDomainName = f_1627_16810_16850()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 16867, 17026);

                return f_1627_16874_17025(f_1627_16907_17024(f_1627_16962_17008(), appDomainName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 16681, 17037);

                string
                f_1627_16810_16850()
                {
                    var return_v = NamedPipeUtils.GetCurrentAppDomainName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 16810, 16850);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1627_16962_17008()
                {
                    var return_v = System.Diagnostics.Process.GetCurrentProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 16962, 17008);
                    return return_v;
                }


                string
                f_1627_16907_17024(System.Diagnostics.Process
                proc, string
                appDomainName)
                {
                    var return_v = NamedPipeUtils.CreateProcessPipeName(proc, appDomainName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 16907, 17024);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                f_1627_16874_17025(string
                pipeName)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteSessionNamedPipeServer(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 16874, 17025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 16681, 17037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 16681, 17037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal RemoteSessionNamedPipeServer(
                    string pipeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 17235, 17740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 13768, 13779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 13820, 13875);
                this._tracer = f_1627_13830_13875();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 14912, 14958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 15059, 15092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 15211, 15264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 15367, 15414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 15522, 15576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 15684, 15738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 15856, 15902);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 17328, 17443) || true) && (pipeName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 17328, 17443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 17382, 17428);

                    throw f_1627_17388_17427("pipeName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 17328, 17443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 17459, 17486);

                _syncObject = f_1627_17473_17485();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 17500, 17520);

                PipeName = pipeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 17536, 17729);

                Stream = f_1627_17545_17728(this, serverName: ".", namespaceName: "pipe", coreName: pipeName, securityDesc: f_1627_17704_17727());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 17235, 17740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 17235, 17740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 17235, 17740);
            }
        }

        private NamedPipeServerStream CreateNamedPipe(
                    string serverName,
                    string namespaceName,
                    string coreName,
                    CommonSecurityDescriptor securityDesc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 18296, 21446);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 18516, 18592) || true) && (serverName == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 18516, 18592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 18542, 18590);

                    throw f_1627_18548_18589("serverName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 18516, 18592);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 18608, 18690) || true) && (namespaceName == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 18608, 18690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 18637, 18688);

                    throw f_1627_18643_18687("namespaceName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 18608, 18690);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 18706, 18778) || true) && (coreName == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 18706, 18778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 18730, 18776);

                    throw f_1627_18736_18775("coreName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 18706, 18778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 18805, 18887);

                string
                fullPipeName = @"\\" + serverName + @"\" + namespaceName + @"\" + coreName
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 18987, 19049);

                NamedPipeNative.SECURITY_ATTRIBUTES
                securityAttributes = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 19063, 19099);

                GCHandle?
                securityDescHandle = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 19113, 19516) || true) && (securityDesc != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 19113, 19516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 19171, 19235);

                    byte[]
                    securityDescBuffer = new byte[f_1627_19208_19233(securityDesc)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 19253, 19303);

                    f_1627_19253_19302(securityDesc, securityDescBuffer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 19321, 19398);

                    securityDescHandle = GCHandle.Alloc(securityDescBuffer, GCHandleType.Pinned);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 19416, 19501);

                    securityAttributes = f_1627_19437_19500(securityDescHandle.Value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 19113, 19516);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 19567, 20068);

                SafePipeHandle
                pipeHandle = f_1627_19595_20067(fullPipeName, NamedPipeNative.PIPE_ACCESS_DUPLEX | NamedPipeNative.FILE_FLAG_FIRST_PIPE_INSTANCE | NamedPipeNative.FILE_FLAG_OVERLAPPED, NamedPipeNative.PIPE_TYPE_MESSAGE | NamedPipeNative.PIPE_READMODE_MESSAGE, 1, _namedPipeBufferSizeForRemoting, _namedPipeBufferSizeForRemoting, 0, securityAttributes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 20084, 20128);

                int
                lastError = f_1627_20100_20127()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 20142, 20253) || true) && (securityDescHandle != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 20142, 20253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 20206, 20238);

                    securityDescHandle.Value.Free();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 20142, 20253);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 20269, 20478) || true) && (f_1627_20273_20293(pipeHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 20269, 20478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 20327, 20463);

                    throw f_1627_20333_20462(f_1627_20387_20461(f_1627_20405_20449(), lastError));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 20269, 20478);
                }

                // Create the .Net NamedPipeServerStream wrapper.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 20593, 20826);

                    return f_1627_20600_20825(PipeDirection.InOut, true, false, pipeHandle);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 20855, 20965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 20905, 20926);

                    f_1627_20905_20925(pipeHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 20944, 20950);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 20855, 20965);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 18296, 21446);

                System.Management.Automation.PSArgumentNullException
                f_1627_18548_18589(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 18548, 18589);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1627_18643_18687(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 18643, 18687);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1627_18736_18775(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 18736, 18775);
                    return return_v;
                }


                int
                f_1627_19208_19233(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.BinaryLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 19208, 19233);
                    return return_v;
                }


                int
                f_1627_19253_19302(System.Security.AccessControl.CommonSecurityDescriptor
                this_param, byte[]
                binaryForm, int
                offset)
                {
                    this_param.GetBinaryForm(binaryForm, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 19253, 19302);
                    return 0;
                }


                System.Management.Automation.Remoting.NamedPipeNative.SECURITY_ATTRIBUTES
                f_1627_19437_19500(System.Runtime.InteropServices.GCHandle
                securityDescriptorPinnedHandle)
                {
                    var return_v = NamedPipeNative.GetSecurityAttributes(securityDescriptorPinnedHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 19437, 19500);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafePipeHandle
                f_1627_19595_20067(string
                lpName, uint
                dwOpenMode, uint
                dwPipeMode, int
                nMaxInstances, int
                nOutBufferSize, int
                nInBufferSize, int
                nDefaultTimeOut, System.Management.Automation.Remoting.NamedPipeNative.SECURITY_ATTRIBUTES
                securityAttributes)
                {
                    var return_v = NamedPipeNative.CreateNamedPipe(lpName, dwOpenMode, dwPipeMode, (uint)nMaxInstances, (uint)nOutBufferSize, (uint)nInBufferSize, (uint)nDefaultTimeOut, securityAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 19595, 20067);
                    return return_v;
                }


                int
                f_1627_20100_20127()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 20100, 20127);
                    return return_v;
                }


                bool
                f_1627_20273_20293(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    var return_v = this_param.IsInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 20273, 20293);
                    return return_v;
                }


                string
                f_1627_20405_20449()
                {
                    var return_v = RemotingErrorIdStrings.CannotCreateNamedPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 20405, 20449);
                    return return_v;
                }


                string
                f_1627_20387_20461(string
                formatSpec, int
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 20387, 20461);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1627_20333_20462(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 20333, 20462);
                    return return_v;
                }


                System.IO.Pipes.NamedPipeServerStream
                f_1627_20600_20825(System.IO.Pipes.PipeDirection
                direction, bool
                isAsync, bool
                isConnected, Microsoft.Win32.SafeHandles.SafePipeHandle
                safePipeHandle)
                {
                    var return_v = new System.IO.Pipes.NamedPipeServerStream(direction, isAsync, isConnected, safePipeHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 20600, 20825);
                    return return_v;
                }


                int
                f_1627_20905_20925(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 20905, 20925);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 18296, 21446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 18296, 21446);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemoteSessionNamedPipeServer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1627, 21458, 21937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 13909, 13944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 13973, 14012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 14041, 14070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 14099, 14128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 14193, 14205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 14261, 14279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 14311, 14336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 14429, 14451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 14712, 14749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 21520, 21548);

                s_syncObject = f_1627_21535_21547();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 21686, 21719);

                IPCNamedPipeServerEnabled = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 21735, 21771);

                f_1627_21735_21770();
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1627, 21458, 21937);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 21458, 21937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 21458, 21937);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 22071, 22834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22123, 22134);
                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22168, 22195) || true) && (f_1627_22172_22182())
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 22168, 22195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22186, 22193);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 22168, 22195);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22215, 22233);

                    IsDisposed = true;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22264, 22455) || true) && (f_1627_22268_22278() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 22264, 22455);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22326, 22347);

                        f_1627_22326_22346(f_1627_22326_22336());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 22367, 22402);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 22367, 22402);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22422, 22440);

                    TextReader = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 22264, 22455);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22471, 22662) || true) && (f_1627_22475_22485() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 22471, 22662);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22533, 22554);

                        f_1627_22533_22553(f_1627_22533_22543());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 22574, 22609);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 22574, 22609);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22629, 22647);

                    TextWriter = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 22471, 22662);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22678, 22823) || true) && (f_1627_22682_22688() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 22678, 22823);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 22736, 22753);

                        f_1627_22736_22752(f_1627_22736_22742());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 22773, 22808);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 22773, 22808);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 22678, 22823);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 22071, 22834);

                bool
                f_1627_22172_22182()
                {
                    var return_v = IsDisposed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 22172, 22182);
                    return return_v;
                }


                System.IO.StreamReader
                f_1627_22268_22278()
                {
                    var return_v = TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 22268, 22278);
                    return return_v;
                }


                System.IO.StreamReader
                f_1627_22326_22336()
                {
                    var return_v = TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 22326, 22336);
                    return return_v;
                }


                int
                f_1627_22326_22346(System.IO.StreamReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 22326, 22346);
                    return 0;
                }


                System.IO.StreamWriter
                f_1627_22475_22485()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 22475, 22485);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1627_22533_22543()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 22533, 22543);
                    return return_v;
                }


                int
                f_1627_22533_22553(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 22533, 22553);
                    return 0;
                }


                System.IO.Pipes.NamedPipeServerStream
                f_1627_22682_22688()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 22682, 22688);
                    return return_v;
                }


                System.IO.Pipes.NamedPipeServerStream
                f_1627_22736_22742()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 22736, 22742);
                    return return_v;
                }


                int
                f_1627_22736_22752(System.IO.Pipes.NamedPipeServerStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 22736, 22752);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 22071, 22834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 22071, 22834);
            }
        }

        public static void CreateCustomNamedPipeServer(string pipeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 23100, 25496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 23194, 23206);
                lock (s_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 23240, 23766) || true) && (_customNamedPipeServer != null && (DynAbs.Tracing.TraceSender.Expression_True(1627, 23244, 23312) && f_1627_23278_23312_M(!_customNamedPipeServer.IsDisposed)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 23240, 23766);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 23354, 23582) || true) && (pipeName == f_1627_23370_23401(_customNamedPipeServer))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 23354, 23582);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 23552, 23559);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 23354, 23582);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 23714, 23747);

                        f_1627_23714_23746(
                                            // Dispose of the current pipe server so we can create a new one with the new pipeName
                                            _customNamedPipeServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 23240, 23766);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 23786, 24421) || true) && (f_1627_23790_23809_M(!Platform.IsWindows))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 23786, 24421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 23851, 23970);

                        int
                        maxNameLength = ((DynAbs.Tracing.TraceSender.Conditional_F1(1627, 23872, 23888) || ((f_1627_23872_23888() && DynAbs.Tracing.TraceSender.Conditional_F2(1627, 23891, 23914)) || DynAbs.Tracing.TraceSender.Conditional_F3(1627, 23917, 23940))) ? _maxPipePathLengthLinux : _maxPipePathLengthMacOS) - f_1627_23944_23969(f_1627_23944_23962())
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 23992, 24402) || true) && (f_1627_23996_24011(pipeName) > maxNameLength)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 23992, 24402);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 24077, 24379);

                            throw f_1627_24083_24378(f_1627_24143_24377(f_1627_24191_24235(), maxNameLength, pipeName, f_1627_24361_24376(pipeName)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 23992, 24402);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 23786, 24421);
                    }

                    try
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 24537, 24605);

                            _customNamedPipeServer = f_1627_24562_24604(pipeName);
                        }
                        catch (IOException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 24650, 24950);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 24920, 24927);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 24650, 24950);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 25065, 25134);

                        _customNamedPipeServer.ListenerEnded += OnCustomNamedPipeServerEnded;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 25262, 25326);

                        f_1627_25262_25325(
                                            // Start the pipe server listening thread, and provide client connection callback.
                                            _customNamedPipeServer, ClientConnectionCallback);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 25363, 25470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 25421, 25451);

                        _customNamedPipeServer = null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 25363, 25470);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 23100, 25496);

                bool
                f_1627_23278_23312_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 23278, 23312);
                    return return_v;
                }


                string
                f_1627_23370_23401(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                this_param)
                {
                    var return_v = this_param.PipeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 23370, 23401);
                    return return_v;
                }


                int
                f_1627_23714_23746(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 23714, 23746);
                    return 0;
                }


                bool
                f_1627_23790_23809_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 23790, 23809);
                    return return_v;
                }


                bool
                f_1627_23872_23888()
                {
                    var return_v = Platform.IsLinux;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 23872, 23888);
                    return return_v;
                }


                string
                f_1627_23944_23962()
                {
                    var return_v = Path.GetTempPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 23944, 23962);
                    return return_v;
                }


                int
                f_1627_23944_23969(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 23944, 23969);
                    return return_v;
                }


                int
                f_1627_23996_24011(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 23996, 24011);
                    return return_v;
                }


                string
                f_1627_24191_24235()
                {
                    var return_v = RemotingErrorIdStrings.CustomPipeNameTooLong;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 24191, 24235);
                    return return_v;
                }


                int
                f_1627_24361_24376(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 24361, 24376);
                    return return_v;
                }


                string
                f_1627_24143_24377(string
                format, int
                arg0, string
                arg1, int
                arg2)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 24143, 24377);
                    return return_v;
                }


                System.InvalidOperationException
                f_1627_24083_24378(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 24083, 24378);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                f_1627_24562_24604(string
                pipeName)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteSessionNamedPipeServer(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 24562, 24604);
                    return return_v;
                }


                int
                f_1627_25262_25325(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                this_param, System.Action<System.Management.Automation.Remoting.RemoteSessionNamedPipeServer>
                clientConnectCallback)
                {
                    this_param.StartListening(clientConnectCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 25262, 25325);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 23100, 25496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 23100, 25496);
            }
        }

        internal void StartListening(
                    Action<RemoteSessionNamedPipeServer> clientConnectCallback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 26054, 26918);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 26181, 26322) || true) && (clientConnectCallback == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 26181, 26322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 26248, 26307);

                    throw f_1627_26254_26306("clientConnectCallback");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 26181, 26322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 26344, 26355);

                lock (_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 26389, 26557) || true) && (f_1627_26393_26410())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 26389, 26557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 26452, 26538);

                        throw f_1627_26458_26537(f_1627_26488_26536());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 26389, 26557);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 26577, 26602);

                    IsListenerRunning = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 26666, 26725);

                    Thread
                    listenerThread = f_1627_26690_26724(ProcessListeningThread)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 26743, 26777);

                    listenerThread.Name = _threadName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 26795, 26830);

                    listenerThread.IsBackground = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 26848, 26892);

                    f_1627_26848_26891(listenerThread, clientConnectCallback);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 26054, 26918);

                System.Management.Automation.PSArgumentNullException
                f_1627_26254_26306(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 26254, 26306);
                    return return_v;
                }


                bool
                f_1627_26393_26410()
                {
                    var return_v = IsListenerRunning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 26393, 26410);
                    return return_v;
                }


                string
                f_1627_26488_26536()
                {
                    var return_v = RemotingErrorIdStrings.NamedPipeAlreadyListening;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 26488, 26536);
                    return return_v;
                }


                System.InvalidOperationException
                f_1627_26458_26537(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 26458, 26537);
                    return return_v;
                }


                System.Threading.Thread
                f_1627_26690_26724(System.Threading.ParameterizedThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 26690, 26724);
                    return return_v;
                }


                int
                f_1627_26848_26891(System.Threading.Thread
                this_param, System.Action<System.Management.Automation.Remoting.RemoteSessionNamedPipeServer>
                parameter)
                {
                    this_param.Start((object)parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 26848, 26891);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 26054, 26918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 26054, 26918);
            }
        }

        internal static CommonSecurityDescriptor GetServerPipeSecurity()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 26930, 28366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 27097, 27199);

                SecurityIdentifier
                adminSID = f_1627_27127_27198(WellKnownSidType.BuiltinAdministratorsSid, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 27213, 27275);

                DiscretionaryAcl
                dacl = f_1627_27237_27274(false, false, 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 27289, 27499);

                f_1627_27289_27498(dacl, AccessControlType.Allow, adminSID, _pipeAccessMaskFullControl, InheritanceFlags.None, PropagationFlags.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 27515, 27772);

                CommonSecurityDescriptor
                securityDesc = f_1627_27555_27771(false, false, ControlFlags.DiscretionaryAclPresent | ControlFlags.OwnerDefaulted | ControlFlags.GroupDefaulted, null, null, null, dacl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 27831, 27948);

                bool
                isAdminElevated = f_1627_27854_27947(f_1627_27854_27904(f_1627_27875_27903()), WindowsBuiltInRole.Administrator)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 27962, 28311) || true) && (!isAdminElevated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 27962, 28311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 28016, 28296);

                    f_1627_28016_28295(f_1627_28016_28045(securityDesc), AccessControlType.Allow, f_1627_28124_28157(f_1627_28124_28152()), _pipeAccessMaskFullControl, InheritanceFlags.None, PropagationFlags.None);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 27962, 28311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 28327, 28347);

                return securityDesc;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 26930, 28366);

                System.Security.Principal.SecurityIdentifier
                f_1627_27127_27198(System.Security.Principal.WellKnownSidType
                sidType, System.Security.Principal.SecurityIdentifier
                domainSid)
                {
                    var return_v = new System.Security.Principal.SecurityIdentifier(sidType, domainSid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 27127, 27198);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1627_27237_27274(bool
                isContainer, bool
                isDS, int
                capacity)
                {
                    var return_v = new System.Security.AccessControl.DiscretionaryAcl(isContainer, isDS, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 27237, 27274);
                    return return_v;
                }


                int
                f_1627_27289_27498(System.Security.AccessControl.DiscretionaryAcl
                this_param, System.Security.AccessControl.AccessControlType
                accessType, System.Security.Principal.SecurityIdentifier
                sid, int
                accessMask, System.Security.AccessControl.InheritanceFlags
                inheritanceFlags, System.Security.AccessControl.PropagationFlags
                propagationFlags)
                {
                    this_param.AddAccess(accessType, sid, accessMask, inheritanceFlags, propagationFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 27289, 27498);
                    return 0;
                }


                System.Security.AccessControl.CommonSecurityDescriptor
                f_1627_27555_27771(bool
                isContainer, bool
                isDS, System.Security.AccessControl.ControlFlags
                flags, System.Security.Principal.SecurityIdentifier
                owner, System.Security.Principal.SecurityIdentifier
                group, System.Security.AccessControl.SystemAcl
                systemAcl, System.Security.AccessControl.DiscretionaryAcl
                discretionaryAcl)
                {
                    var return_v = new System.Security.AccessControl.CommonSecurityDescriptor(isContainer, isDS, flags, owner, group, systemAcl, discretionaryAcl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 27555, 27771);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1627_27875_27903()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 27875, 27903);
                    return return_v;
                }


                System.Security.Principal.WindowsPrincipal
                f_1627_27854_27904(System.Security.Principal.WindowsIdentity
                ntIdentity)
                {
                    var return_v = new System.Security.Principal.WindowsPrincipal(ntIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 27854, 27904);
                    return return_v;
                }


                bool
                f_1627_27854_27947(System.Security.Principal.WindowsPrincipal
                this_param, System.Security.Principal.WindowsBuiltInRole
                role)
                {
                    var return_v = this_param.IsInRole(role);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 27854, 27947);
                    return return_v;
                }


                System.Security.AccessControl.DiscretionaryAcl
                f_1627_28016_28045(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.DiscretionaryAcl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 28016, 28045);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1627_28124_28152()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 28124, 28152);
                    return return_v;
                }


                System.Security.Principal.SecurityIdentifier
                f_1627_28124_28157(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.User;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 28124, 28157);
                    return return_v;
                }


                int
                f_1627_28016_28295(System.Security.AccessControl.DiscretionaryAcl
                this_param, System.Security.AccessControl.AccessControlType
                accessType, System.Security.Principal.SecurityIdentifier
                sid, int
                accessMask, System.Security.AccessControl.InheritanceFlags
                inheritanceFlags, System.Security.AccessControl.PropagationFlags
                propagationFlags)
                {
                    this_param.AddAccess(accessType, sid, accessMask, inheritanceFlags, propagationFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 28016, 28295);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 26930, 28366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 26930, 28366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WaitForConnection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 28466, 28561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 28523, 28550);

                f_1627_28523_28549(f_1627_28523_28529());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 28466, 28561);

                System.IO.Pipes.NamedPipeServerStream
                f_1627_28523_28529()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 28523, 28529);
                    return return_v;
                }


                int
                f_1627_28523_28549(System.IO.Pipes.NamedPipeServerStream
                this_param)
                {
                    this_param.WaitForConnection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 28523, 28549);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 28466, 28561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 28466, 28561);
            }
        }

        [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Runtime.InteropServices.SafeHandle.DangerousGetHandle")]
        private void ProcessListeningThread(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 28726, 35005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 28969, 29077);

                string
                processId = f_1627_28988_29076(f_1627_28988_29037(f_1627_28988_29034()), f_1627_29047_29075())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 29091, 29155);

                string
                appDomainName = f_1627_29114_29154()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 29196, 29386);

                f_1627_29196_29385(
                            // Logging.
                            _tracer, "RemoteSessionNamedPipeServer", "StartListening", Guid.Empty, "Listener thread started on Process {0} in AppDomainName {1}.", processId, appDomainName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 29400, 29624);

                f_1627_29400_29623(PSEventId.NamedPipeIPC_ServerListenerStarted, PSOpcode.Open, PSTask.NamedPipe, PSKeyword.UseAlwaysOperational, processId, appDomainName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 29640, 29660);

                Exception
                ex = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 29674, 29705);

                string
                userName = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 29719, 29753);

                bool
                restartListenerThread = true
                ;

                // Wait for connection.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 29900, 29925);

                    f_1627_29900_29924(                // Begin listening for a client connect.
                                    this);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 30067, 30112);

                        userName = f_1627_30078_30111(f_1627_30078_30106());
                    }
                    catch (System.Security.SecurityException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 30157, 30202);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 30157, 30202);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 30251, 30470);

                    f_1627_30251_30469(
                                    // Logging.
                                    _tracer, "RemoteSessionNamedPipeServer", "StartListening", Guid.Empty, "Client connection started on Process {0} in AppDomainName {1} for User {2}.", processId, appDomainName, userName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 30488, 30729);

                    f_1627_30488_30728(PSEventId.NamedPipeIPC_ServerConnect, PSOpcode.Connect, PSTask.NamedPipe, PSKeyword.UseAlwaysOperational, processId, appDomainName, userName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 30799, 30837);

                    TextReader = f_1627_30812_30836(f_1627_30829_30835());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 30855, 30893);

                    TextWriter = f_1627_30868_30892(f_1627_30885_30891());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 30911, 30939);

                    f_1627_30911_30921().AutoFlush = true;
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 30968, 31042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 31020, 31027);

                    ex = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 30968, 31042);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 31058, 31855) || true) && (ex != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 31058, 31855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 31200, 31284);

                    string
                    errorMessage = (DynAbs.Tracing.TraceSender.Conditional_F1(1627, 31222, 31255) || ((!f_1627_31223_31255(f_1627_31244_31254(ex)) && DynAbs.Tracing.TraceSender.Conditional_F2(1627, 31258, 31268)) || DynAbs.Tracing.TraceSender.Conditional_F3(1627, 31271, 31283))) ? f_1627_31258_31268(ex) : string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 31302, 31542);

                    f_1627_31302_31541(_tracer, "RemoteSessionNamedPipeServer", "StartListening", Guid.Empty, "Unexpected error in listener thread on process {0} in AppDomainName {1}.  Error Message: {2}", processId, appDomainName, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 31560, 31785);

                    f_1627_31560_31784(PSEventId.NamedPipeIPC_ServerListenerError, PSOpcode.Exception, PSTask.NamedPipe, PSKeyword.UseAlwaysOperational, processId, appDomainName, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 31805, 31815);

                    f_1627_31805_31814(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 31833, 31840);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 31058, 31855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 31927, 31937);

                ex = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 31987, 32094);

                    Action<RemoteSessionNamedPipeServer>
                    clientConnectCallback = state as Action<RemoteSessionNamedPipeServer>
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 32112, 32195);

                    f_1627_32112_32194(clientConnectCallback != null, "Client callback should never be null.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 32495, 32523);

                    f_1627_32495_32522(clientConnectCallback, this);
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 32552, 32653);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 32552, 32653);
                    // Expected connection terminated.
                }
                catch (ObjectDisposedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 32667, 32790);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 32667, 32790);
                    // Expected from PS transport close/dispose.
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 32804, 32926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 32856, 32863);

                    ex = e;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 32881, 32911);

                    restartListenerThread = false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 32804, 32926);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 32967, 33180);

                f_1627_32967_33179(
                            // Logging.
                            _tracer, "RemoteSessionNamedPipeServer", "StartListening", Guid.Empty, "Client connection ended on process {0} in AppDomainName {1} for User {2}.", processId, appDomainName, userName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 33194, 33424);

                f_1627_33194_33423(PSEventId.NamedPipeIPC_ServerDisconnect, PSOpcode.Close, PSTask.NamedPipe, PSKeyword.UseAlwaysOperational, processId, appDomainName, userName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 33440, 34657) || true) && (ex == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 33440, 34657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 33530, 33722);

                    f_1627_33530_33721(                // Normal listener exit.
                                    _tracer, "RemoteSessionNamedPipeServer", "StartListening", Guid.Empty, "Listener thread ended on process {0} in AppDomainName {1}.", processId, appDomainName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 33740, 33953);

                    f_1627_33740_33952(PSEventId.NamedPipeIPC_ServerListenerEnded, PSOpcode.Close, PSTask.NamedPipe, PSKeyword.UseAlwaysOperational, processId, appDomainName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 33440, 34657);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 33440, 34657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 34057, 34141);

                    string
                    errorMessage = (DynAbs.Tracing.TraceSender.Conditional_F1(1627, 34079, 34112) || ((!f_1627_34080_34112(f_1627_34101_34111(ex)) && DynAbs.Tracing.TraceSender.Conditional_F2(1627, 34115, 34125)) || DynAbs.Tracing.TraceSender.Conditional_F3(1627, 34128, 34140))) ? f_1627_34115_34125(ex) : string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 34159, 34399);

                    f_1627_34159_34398(_tracer, "RemoteSessionNamedPipeServer", "StartListening", Guid.Empty, "Unexpected error in listener thread on process {0} in AppDomainName {1}.  Error Message: {2}", processId, appDomainName, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 34417, 34642);

                    f_1627_34417_34641(PSEventId.NamedPipeIPC_ServerListenerError, PSOpcode.Exception, PSTask.NamedPipe, PSKeyword.UseAlwaysOperational, processId, appDomainName, errorMessage);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 33440, 34657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 34679, 34690);

                lock (_syncObject)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 34724, 34750);

                    IsListenerRunning = false;
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 34847, 34857);

                f_1627_34847_34856(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 34873, 34994);

                f_1627_34873_34993(
                            ListenerEnded, this, f_1627_34939_34992(ex, restartListenerThread));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 28726, 35005);

                System.Diagnostics.Process
                f_1627_28988_29034()
                {
                    var return_v = System.Diagnostics.Process.GetCurrentProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 28988, 29034);
                    return return_v;
                }


                int
                f_1627_28988_29037(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 28988, 29037);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1627_29047_29075()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 29047, 29075);
                    return return_v;
                }


                string
                f_1627_28988_29076(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 28988, 29076);
                    return return_v;
                }


                string
                f_1627_29114_29154()
                {
                    var return_v = NamedPipeUtils.GetCurrentAppDomainName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 29114, 29154);
                    return return_v;
                }


                int
                f_1627_29196_29385(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 29196, 29385);
                    return 0;
                }


                int
                f_1627_29400_29623(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 29400, 29623);
                    return 0;
                }


                int
                f_1627_29900_29924(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                this_param)
                {
                    this_param.WaitForConnection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 29900, 29924);
                    return 0;
                }


                System.Security.Principal.WindowsIdentity
                f_1627_30078_30106()
                {
                    var return_v = WindowsIdentity.GetCurrent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 30078, 30106);
                    return return_v;
                }


                string
                f_1627_30078_30111(System.Security.Principal.WindowsIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 30078, 30111);
                    return return_v;
                }


                int
                f_1627_30251_30469(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 30251, 30469);
                    return 0;
                }


                int
                f_1627_30488_30728(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 30488, 30728);
                    return 0;
                }


                System.IO.Pipes.NamedPipeServerStream
                f_1627_30829_30835()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 30829, 30835);
                    return return_v;
                }


                System.IO.StreamReader
                f_1627_30812_30836(System.IO.Pipes.NamedPipeServerStream
                stream)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 30812, 30836);
                    return return_v;
                }


                System.IO.Pipes.NamedPipeServerStream
                f_1627_30885_30891()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 30885, 30891);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1627_30868_30892(System.IO.Pipes.NamedPipeServerStream
                stream)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 30868, 30892);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1627_30911_30921()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 30911, 30921);
                    return return_v;
                }


                string
                f_1627_31244_31254(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 31244, 31254);
                    return return_v;
                }


                bool
                f_1627_31223_31255(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 31223, 31255);
                    return return_v;
                }


                string
                f_1627_31258_31268(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 31258, 31268);
                    return return_v;
                }


                int
                f_1627_31302_31541(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 31302, 31541);
                    return 0;
                }


                int
                f_1627_31560_31784(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 31560, 31784);
                    return 0;
                }


                int
                f_1627_31805_31814(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 31805, 31814);
                    return 0;
                }


                int
                f_1627_32112_32194(bool
                condition, string
                message)
                {
                    Dbg.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 32112, 32194);
                    return 0;
                }


                int
                f_1627_32495_32522(System.Action<System.Management.Automation.Remoting.RemoteSessionNamedPipeServer>
                this_param, System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 32495, 32522);
                    return 0;
                }


                int
                f_1627_32967_33179(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 32967, 33179);
                    return 0;
                }


                int
                f_1627_33194_33423(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 33194, 33423);
                    return 0;
                }


                int
                f_1627_33530_33721(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 33530, 33721);
                    return 0;
                }


                int
                f_1627_33740_33952(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalInformation(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 33740, 33952);
                    return 0;
                }


                string
                f_1627_34101_34111(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 34101, 34111);
                    return return_v;
                }


                bool
                f_1627_34080_34112(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 34080, 34112);
                    return return_v;
                }


                string
                f_1627_34115_34125(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 34115, 34125);
                    return return_v;
                }


                int
                f_1627_34159_34398(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 34159, 34398);
                    return 0;
                }


                int
                f_1627_34417_34641(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 34417, 34641);
                    return 0;
                }


                int
                f_1627_34847_34856(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 34847, 34856);
                    return 0;
                }


                System.Management.Automation.Remoting.ListenerEndedEventArgs
                f_1627_34939_34992(System.Exception
                reason, bool
                restartListener)
                {
                    var return_v = new System.Management.Automation.Remoting.ListenerEndedEventArgs(reason, restartListener);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 34939, 34992);
                    return return_v;
                }


                int
                f_1627_34873_34993(System.EventHandler<System.Management.Automation.Remoting.ListenerEndedEventArgs>
                eventHandler, System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                sender, System.Management.Automation.Remoting.ListenerEndedEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.Remoting.ListenerEndedEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 34873, 34993);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 28726, 35005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 28726, 35005);
            }
        }

        internal static void RunServerMode(string configurationName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 35569, 36526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 35654, 35687);

                IPCNamedPipeServerEnabled = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 35701, 35737);

                f_1627_35701_35736();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 35753, 35910) || true) && (IPCNamedPipeServer == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 35753, 35910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 35817, 35895);

                    throw f_1627_35823_35894(f_1627_35844_35893());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 35753, 35910);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 35926, 35983);

                IPCNamedPipeServer.ConfigurationName = configurationName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 35999, 36076);

                ManualResetEventSlim
                clientConnectionEnded = f_1627_36044_36075(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 36090, 36152);

                IPCNamedPipeServer.ListenerEnded -= OnIPCNamedPipeServerEnded;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 36166, 36305);

                IPCNamedPipeServer.ListenerEnded += (sender, e) =>
                                {
                                    clientConnectionEnded.Set();
                                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 36392, 36421);

                f_1627_36392_36420(
                            // Wait for server to service a single client connection.
                            clientConnectionEnded);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 36435, 36467);

                f_1627_36435_36466(clientConnectionEnded);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 36481, 36515);

                IPCNamedPipeServerEnabled = false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 35569, 36526);

                int
                f_1627_35701_35736()
                {
                    CreateIPCNamedPipeServerSingleton();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 35701, 35736);
                    return 0;
                }


                string
                f_1627_35844_35893()
                {
                    var return_v = RemotingErrorIdStrings.NamedPipeServerCannotStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 35844, 35893);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1627_35823_35894(string
                message)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 35823, 35894);
                    return return_v;
                }


                System.Threading.ManualResetEventSlim
                f_1627_36044_36075(bool
                initialState)
                {
                    var return_v = new System.Threading.ManualResetEventSlim(initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 36044, 36075);
                    return return_v;
                }


                int
                f_1627_36392_36420(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Wait();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 36392, 36420);
                    return 0;
                }


                int
                f_1627_36435_36466(System.Threading.ManualResetEventSlim
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 36435, 36466);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 35569, 36526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 35569, 36526);
            }
        }

        internal static void CreateIPCNamedPipeServerSingleton()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 36706, 38136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 36793, 36805);
                lock (s_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 36839, 36882) || true) && (!IPCNamedPipeServerEnabled)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 36839, 36882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 36873, 36880);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 36839, 36882);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 36902, 38110) || true) && (IPCNamedPipeServer == null || (DynAbs.Tracing.TraceSender.Expression_False(1627, 36906, 36965) || f_1627_36936_36965(IPCNamedPipeServer)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 36902, 38110);
                        try
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 37119, 37177);

                                IPCNamedPipeServer = f_1627_37140_37176();
                            }
                            catch (IOException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 37230, 37550);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 37516, 37523);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 37230, 37550);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 37673, 37735);

                            IPCNamedPipeServer.ListenerEnded += OnIPCNamedPipeServerEnded;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 37871, 37931);

                            f_1627_37871_37930(
                                                    // Start the pipe server listening thread, and provide client connection callback.
                                                    IPCNamedPipeServer, ClientConnectionCallback);
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 37976, 38091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 38042, 38068);

                            IPCNamedPipeServer = null;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 37976, 38091);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 36902, 38110);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 36706, 38136);

                bool
                f_1627_36936_36965(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                this_param)
                {
                    var return_v = this_param.IsDisposed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 36936, 36965);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                f_1627_37140_37176()
                {
                    var return_v = CreateRemoteSessionNamedPipeServer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 37140, 37176);
                    return return_v;
                }


                int
                f_1627_37871_37930(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                this_param, System.Action<System.Management.Automation.Remoting.RemoteSessionNamedPipeServer>
                clientConnectCallback)
                {
                    this_param.StartListening(clientConnectCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 37871, 37930);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 36706, 38136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 36706, 38136);
            }
        }

        private static void OnIPCNamedPipeServerEnded(object sender, ListenerEndedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 39197, 39431);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 39311, 39420) || true) && (f_1627_39315_39335(args))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 39311, 39420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 39369, 39405);

                    f_1627_39369_39404();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 39311, 39420);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 39197, 39431);

                bool
                f_1627_39315_39335(System.Management.Automation.Remoting.ListenerEndedEventArgs
                this_param)
                {
                    var return_v = this_param.RestartListener;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 39315, 39335);
                    return return_v;
                }


                int
                f_1627_39369_39404()
                {
                    CreateIPCNamedPipeServerSingleton();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 39369, 39404);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 39197, 39431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 39197, 39431);
            }
        }

        private static void OnCustomNamedPipeServerEnded(object sender, ListenerEndedEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 39443, 39738);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 39560, 39727) || true) && (f_1627_39564_39584(args) && (DynAbs.Tracing.TraceSender.Expression_True(1627, 39564, 39633) && sender is RemoteSessionNamedPipeServer server))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 39560, 39727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 39667, 39712);

                    f_1627_39667_39711(f_1627_39695_39710(server));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 39560, 39727);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 39443, 39738);

                bool
                f_1627_39564_39584(System.Management.Automation.Remoting.ListenerEndedEventArgs
                this_param)
                {
                    var return_v = this_param.RestartListener;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 39564, 39584);
                    return return_v;
                }


                string
                f_1627_39695_39710(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                this_param)
                {
                    var return_v = this_param.PipeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 39695, 39710);
                    return return_v;
                }


                int
                f_1627_39667_39711(string
                pipeName)
                {
                    CreateCustomNamedPipeServer(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 39667, 39711);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 39443, 39738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 39443, 39738);
            }
        }

        private static void ClientConnectionCallback(RemoteSessionNamedPipeServer pipeServer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1627, 39750, 40045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 39944, 40034);

                f_1627_39944_40033(string.Empty, pipeServer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1627, 39750, 40045);

                int
                f_1627_39944_40033(string
                initialCommand, System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
                namedPipeServer)
                {
                    NamedPipeProcessMediator.Run(initialCommand, namedPipeServer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 39944, 40033);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 39750, 40045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 39750, 40045);
            }
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1627, 13638, 40074);

        System.Management.Automation.Tracing.PowerShellTraceSource
        f_1627_13830_13875()
        {
            var return_v = PowerShellTraceSourceFactory.GetTraceSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 13830, 13875);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1627_17388_17427(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 17388, 17427);
            return return_v;
        }


        object
        f_1627_17473_17485()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 17473, 17485);
            return return_v;
        }


        System.Security.AccessControl.CommonSecurityDescriptor
        f_1627_17704_17727()
        {
            var return_v = GetServerPipeSecurity();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 17704, 17727);
            return return_v;
        }


        System.IO.Pipes.NamedPipeServerStream
        f_1627_17545_17728(System.Management.Automation.Remoting.RemoteSessionNamedPipeServer
        this_param, string
        serverName, string
        namespaceName, string
        coreName, System.Security.AccessControl.CommonSecurityDescriptor
        securityDesc)
        {
            var return_v = this_param.CreateNamedPipe(serverName: serverName, namespaceName: namespaceName, coreName: coreName, securityDesc: securityDesc);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 17545, 17728);
            return return_v;
        }


        static object
        f_1627_21535_21547()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 21535, 21547);
            return return_v;
        }


        static int
        f_1627_21735_21770()
        {
            CreateIPCNamedPipeServerSingleton();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 21735, 21770);
            return 0;
        }

    }
    internal class NamedPipeClientBase : IDisposable
    {
        private NamedPipeClientStream _clientPipeStream;

        private PowerShellTraceSource _tracer;

        protected string _pipeName;

        public StreamReader TextReader { get; private set; }

        public StreamWriter TextWriter { get; private set; }

        public string PipeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 40991, 41016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 40997, 41014);

                    return _pipeName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 40991, 41016);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 40944, 41027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 40944, 41027);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedPipeClientBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 41092, 41133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 40333, 40350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 40391, 40446);
                this._tracer = f_1627_40401_40446();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 40476, 40485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 40646, 40698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 40806, 40858);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 41092, 41133);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 41092, 41133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 41092, 41133);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 41267, 41905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 41313, 41504) || true) && (f_1627_41317_41327() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 41313, 41504);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 41375, 41396);

                        f_1627_41375_41395(f_1627_41375_41385());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 41416, 41451);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 41416, 41451);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 41471, 41489);

                    TextReader = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 41313, 41504);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 41520, 41711) || true) && (f_1627_41524_41534() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 41520, 41711);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 41582, 41603);

                        f_1627_41582_41602(f_1627_41582_41592());
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 41623, 41658);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 41623, 41658);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 41678, 41696);

                    TextWriter = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 41520, 41711);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 41727, 41894) || true) && (_clientPipeStream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 41727, 41894);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 41796, 41824);

                        f_1627_41796_41823(_clientPipeStream);
                    }
                    catch (ObjectDisposedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 41844, 41879);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 41844, 41879);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 41727, 41894);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 41267, 41905);

                System.IO.StreamReader
                f_1627_41317_41327()
                {
                    var return_v = TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 41317, 41327);
                    return return_v;
                }


                System.IO.StreamReader
                f_1627_41375_41385()
                {
                    var return_v = TextReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 41375, 41385);
                    return return_v;
                }


                int
                f_1627_41375_41395(System.IO.StreamReader
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 41375, 41395);
                    return 0;
                }


                System.IO.StreamWriter
                f_1627_41524_41534()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 41524, 41534);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1627_41582_41592()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 41582, 41592);
                    return return_v;
                }


                int
                f_1627_41582_41602(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 41582, 41602);
                    return 0;
                }


                int
                f_1627_41796_41823(System.IO.Pipes.NamedPipeClientStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 41796, 41823);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 41267, 41905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 41267, 41905);
            }
        }

        public void Connect(
                    int timeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 42240, 42815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 42403, 42442);

                _clientPipeStream = f_1627_42423_42441(this, timeout);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 42504, 42553);

                TextReader = f_1627_42517_42552(_clientPipeStream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 42567, 42616);

                TextWriter = f_1627_42580_42615(_clientPipeStream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 42630, 42658);

                f_1627_42630_42640().AutoFlush = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 42674, 42804);

                f_1627_42674_42803(
                            _tracer, "NamedPipeClientBase", "Connect", Guid.Empty, "Connection started on pipe: {0}", _pipeName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 42240, 42815);

                System.IO.Pipes.NamedPipeClientStream
                f_1627_42423_42441(System.Management.Automation.Remoting.NamedPipeClientBase
                this_param, int
                timeout)
                {
                    var return_v = this_param.DoConnect(timeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 42423, 42441);
                    return return_v;
                }


                System.IO.StreamReader
                f_1627_42517_42552(System.IO.Pipes.NamedPipeClientStream
                stream)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 42517, 42552);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1627_42580_42615(System.IO.Pipes.NamedPipeClientStream
                stream)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 42580, 42615);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1627_42630_42640()
                {
                    var return_v = TextWriter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 42630, 42640);
                    return return_v;
                }


                int
                f_1627_42674_42803(System.Management.Automation.Tracing.PowerShellTraceSource
                this_param, string
                className, string
                methodName, System.Guid
                workflowId, string
                message, params string[]
                parameters)
                {
                    this_param.WriteMessage(className, methodName, workflowId, message, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 42674, 42803);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 42240, 42815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 42240, 42815);
            }
        }

        public void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 42910, 43071);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 42954, 43060) || true) && (_clientPipeStream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 42954, 43060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 43017, 43045);

                    f_1627_43017_43044(_clientPipeStream);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 42954, 43060);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 42910, 43071);

                int
                f_1627_43017_43044(System.IO.Pipes.NamedPipeClientStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 43017, 43044);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 42910, 43071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 42910, 43071);
            }
        }

        public virtual void AbortConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 43083, 43130);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 43083, 43130);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 43083, 43130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 43083, 43130);
            }
        }

        protected virtual NamedPipeClientStream DoConnect(int timeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 43142, 43252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 43229, 43241);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 43142, 43252);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 43142, 43252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 43142, 43252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamedPipeClientBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1627, 40211, 43281);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1627, 40211, 43281);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 40211, 43281);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1627, 40211, 43281);

        System.Management.Automation.Tracing.PowerShellTraceSource
        f_1627_40401_40446()
        {
            var return_v = PowerShellTraceSourceFactory.GetTraceSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 40401, 40446);
            return return_v;
        }

    }
    internal sealed class RemoteSessionNamedPipeClient : NamedPipeClientBase
    {
        private volatile bool _connecting;

        private RemoteSessionNamedPipeClient()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 43715, 43766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 43637, 43648);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 43715, 43766);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 43715, 43766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 43715, 43766);
            }
        }

        public RemoteSessionNamedPipeClient(
                    System.Diagnostics.Process process, string appDomainName) : this(f_1627_44194_44254_C(f_1627_44194_44254(process, appDomainName)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 44066, 44268);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 44066, 44268);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 44066, 44268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 44066, 44268);
            }
        }

        public RemoteSessionNamedPipeClient(
                    int procId, string appDomainName) : this(f_1627_44662_44721_C(f_1627_44662_44721(procId, appDomainName)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 44558, 44735);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 44558, 44735);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 44558, 44735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 44558, 44735);
            }
        }

        internal RemoteSessionNamedPipeClient(
                   string pipeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 44924, 45311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 43637, 43648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 45016, 45131) || true) && (pipeName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 45016, 45131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 45070, 45116);

                    throw f_1627_45076_45115("pipeName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 45016, 45131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 45147, 45168);

                _pipeName = pipeName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 44924, 45311);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 44924, 45311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 44924, 45311);
            }
        }

        internal RemoteSessionNamedPipeClient(
                    string serverName,
                    string namespaceName,
                    string coreName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 45538, 46191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 43637, 43648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 45698, 45774) || true) && (serverName == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 45698, 45774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 45724, 45772);

                    throw f_1627_45730_45771("serverName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 45698, 45774);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 45790, 45872) || true) && (namespaceName == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 45790, 45872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 45819, 45870);

                    throw f_1627_45825_45869("namespaceName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 45790, 45872);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 45888, 45960) || true) && (coreName == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 45888, 45960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 45912, 45958);

                    throw f_1627_45918_45957("coreName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 45888, 45960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 45976, 46048);

                _pipeName = @"\\" + serverName + @"\" + namespaceName + @"\" + coreName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 45538, 46191);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 45538, 46191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 45538, 46191);
            }
        }

        public override void AbortConnect()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 46345, 46436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 46405, 46425);

                _connecting = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 46345, 46436);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 46345, 46436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 46345, 46436);
            }
        }

        protected override NamedPipeClientStream DoConnect(int timeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 46507, 47655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 46672, 46710);

                int
                startTime = f_1627_46688_46709()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 46724, 46744);

                int
                elapsedTime = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 46758, 46777);

                _connecting = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 46793, 47039);

                NamedPipeClientStream
                namedPipeClientStream = f_1627_46839_47038(serverName: ".", pipeName: _pipeName, direction: PipeDirection.InOut, options: PipeOptions.Asynchronous)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 47055, 47087);

                f_1627_47055_47086(
                            namedPipeClientStream);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 47103, 47517);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 47138, 47367) || true) && (f_1627_47142_47176_M(!namedPipeClientStream.IsConnected))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 47138, 47367);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 47218, 47236);

                                f_1627_47218_47235(100);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 47258, 47317);

                                elapsedTime = unchecked(f_1627_47282_47303() - startTime);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 47339, 47348);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 47138, 47367);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 47387, 47407);

                            _connecting = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 47425, 47454);

                            return namedPipeClientStream;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 47103, 47517);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 47103, 47517) || true) && (_connecting && (DynAbs.Tracing.TraceSender.Expression_True(1627, 47477, 47515) && (elapsedTime < timeout)))
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1627, 47103, 47517);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1627, 47103, 47517);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 47533, 47553);

                _connecting = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 47569, 47644);

                throw f_1627_47575_47643(f_1627_47596_47642());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 46507, 47655);

                int
                f_1627_46688_46709()
                {
                    var return_v = Environment.TickCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 46688, 46709);
                    return return_v;
                }


                System.IO.Pipes.NamedPipeClientStream
                f_1627_46839_47038(string
                serverName, string
                pipeName, System.IO.Pipes.PipeDirection
                direction, System.IO.Pipes.PipeOptions
                options)
                {
                    var return_v = new System.IO.Pipes.NamedPipeClientStream(serverName: serverName, pipeName: pipeName, direction: direction, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 46839, 47038);
                    return return_v;
                }


                int
                f_1627_47055_47086(System.IO.Pipes.NamedPipeClientStream
                this_param)
                {
                    this_param.Connect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 47055, 47086);
                    return 0;
                }


                bool
                f_1627_47142_47176_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 47142, 47176);
                    return return_v;
                }


                int
                f_1627_47218_47235(int
                millisecondsTimeout)
                {
                    Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 47218, 47235);
                    return 0;
                }


                int
                f_1627_47282_47303()
                {
                    var return_v = Environment.TickCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 47282, 47303);
                    return return_v;
                }


                string
                f_1627_47596_47642()
                {
                    var return_v = RemotingErrorIdStrings.ConnectNamedPipeTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 47596, 47642);
                    return return_v;
                }


                System.TimeoutException
                f_1627_47575_47643(string
                message)
                {
                    var return_v = new System.TimeoutException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 47575, 47643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 46507, 47655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 46507, 47655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemoteSessionNamedPipeClient()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1627, 43499, 47684);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1627, 43499, 47684);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 43499, 47684);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1627, 43499, 47684);

        static string
        f_1627_44194_44254(System.Diagnostics.Process
        proc, string
        appDomainName)
        {
            var return_v = NamedPipeUtils.CreateProcessPipeName(proc, appDomainName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 44194, 44254);
            return return_v;
        }


        static string
        f_1627_44194_44254_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1627, 44066, 44268);
            return return_v;
        }


        static string
        f_1627_44662_44721(int
        procId, string
        appDomainName)
        {
            var return_v = NamedPipeUtils.CreateProcessPipeName(procId, appDomainName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 44662, 44721);
            return return_v;
        }


        static string
        f_1627_44662_44721_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1627, 44558, 44735);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1627_45076_45115(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 45076, 45115);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1627_45730_45771(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 45730, 45771);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1627_45825_45869(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 45825, 45869);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1627_45918_45957(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 45918, 45957);
            return return_v;
        }

    }
    internal sealed class ContainerSessionNamedPipeClient : NamedPipeClientBase
    {
        public ContainerSessionNamedPipeClient(
                    int procId,
                    string appDomainName,
                    string containerObRoot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1627, 48454, 49038);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 48615, 48758) || true) && (f_1627_48619_48656(containerObRoot))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 48615, 48758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 48690, 48743);

                    throw f_1627_48696_48742("containerObRoot");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 48615, 48758);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 48896, 49027);

                _pipeName = containerObRoot + @"\Device\NamedPipe\" +
                f_1627_48967_49026(procId, appDomainName);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1627, 48454, 49038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 48454, 49038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 48454, 49038);
            }
        }

        protected override NamedPipeClientStream DoConnect(int timeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1627, 49290, 51421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 49413, 49467);

                uint
                pipeFlags = NamedPipeNative.FILE_FLAG_OVERLAPPED
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 49697, 49735);

                int
                startTime = f_1627_49713_49734()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 49749, 49769);

                int
                elapsedTime = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 49783, 49816);

                SafePipeHandle
                pipeHandle = null
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 49832, 51056);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 49907, 50239);

                            pipeHandle = f_1627_49920_50238(_pipeName, NamedPipeNative.GENERIC_READ | NamedPipeNative.GENERIC_WRITE, 0, IntPtr.Zero, NamedPipeNative.OPEN_EXISTING, pipeFlags, IntPtr.Zero);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 50259, 50303);

                            int
                            lastError = f_1627_50275_50302()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 50321, 51010) || true) && (f_1627_50325_50345(pipeHandle))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 50321, 51010);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 50387, 50903) || true) && (lastError == NamedPipeNative.ERROR_FILE_NOT_FOUND)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 50387, 50903);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 50490, 50549);

                                    elapsedTime = unchecked(f_1627_50514_50535() - startTime);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 50575, 50593);

                                    f_1627_50575_50592(100);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 50619, 50628);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 50387, 50903);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 50387, 50903);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 50726, 50880);

                                    throw f_1627_50732_50879(f_1627_50794_50878(f_1627_50812_50866(), lastError));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 50387, 50903);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 50321, 51010);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1627, 50321, 51010);
                                DynAbs.Tracing.TraceSender.TraceBreak(1627, 50985, 50991);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 50321, 51010);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1627, 49832, 51056);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 49832, 51056) || true) && (elapsedTime < timeout)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1627, 49832, 51056);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1627, 49832, 51056);
                    }
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 51108, 51271);

                    return f_1627_51115_51270(PipeDirection.InOut, true, true, pipeHandle);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1627, 51300, 51410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 51350, 51371);

                    f_1627_51350_51370(pipeHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1627, 51389, 51395);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1627, 51300, 51410);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1627, 49290, 51421);

                int
                f_1627_49713_49734()
                {
                    var return_v = Environment.TickCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 49713, 49734);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafePipeHandle
                f_1627_49920_50238(string
                lpFileName, uint
                dwDesiredAccess, int
                dwShareMode, System.IntPtr
                SecurityAttributes, uint
                dwCreationDisposition, uint
                dwFlagsAndAttributes, System.IntPtr
                hTemplateFile)
                {
                    var return_v = NamedPipeNative.CreateFile(lpFileName, dwDesiredAccess, (uint)dwShareMode, SecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 49920, 50238);
                    return return_v;
                }


                int
                f_1627_50275_50302()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 50275, 50302);
                    return return_v;
                }


                bool
                f_1627_50325_50345(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    var return_v = this_param.IsInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 50325, 50345);
                    return return_v;
                }


                int
                f_1627_50514_50535()
                {
                    var return_v = Environment.TickCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 50514, 50535);
                    return return_v;
                }


                int
                f_1627_50575_50592(int
                millisecondsTimeout)
                {
                    Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 50575, 50592);
                    return 0;
                }


                string
                f_1627_50812_50866()
                {
                    var return_v = RemotingErrorIdStrings.CannotConnectContainerNamedPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1627, 50812, 50866);
                    return return_v;
                }


                string
                f_1627_50794_50878(string
                formatSpec, int
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 50794, 50878);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1627_50732_50879(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 50732, 50879);
                    return return_v;
                }


                System.IO.Pipes.NamedPipeClientStream
                f_1627_51115_51270(System.IO.Pipes.PipeDirection
                direction, bool
                isAsync, bool
                isConnected, Microsoft.Win32.SafeHandles.SafePipeHandle
                safePipeHandle)
                {
                    var return_v = new System.IO.Pipes.NamedPipeClientStream(direction, isAsync, isConnected, safePipeHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 51115, 51270);
                    return return_v;
                }


                int
                f_1627_51350_51370(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 51350, 51370);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1627, 49290, 51421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 49290, 51421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ContainerSessionNamedPipeClient()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1627, 47934, 51450);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1627, 47934, 51450);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1627, 47934, 51450);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1627, 47934, 51450);

        bool
        f_1627_48619_48656(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 48619, 48656);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1627_48696_48742(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 48696, 48742);
            return return_v;
        }


        string
        f_1627_48967_49026(int
        procId, string
        appDomainName)
        {
            var return_v = NamedPipeUtils.CreateProcessPipeName(procId, appDomainName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1627, 48967, 49026);
            return return_v;
        }

    }
}
