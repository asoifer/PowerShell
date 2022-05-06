// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;

using Microsoft.Win32.SafeHandles;

namespace System.Management.Automation
{
    internal class PlatformInvokes
    {
        [StructLayout(LayoutKind.Sequential)]
        internal class FILETIME
        {
            internal uint dwLowDateTime;

            internal uint dwHighDateTime;

            internal FILETIME()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1033, 575, 697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 502, 515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 544, 558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 627, 645);

                    dwLowDateTime = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 663, 682);

                    dwHighDateTime = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1033, 575, 697);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 575, 697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 575, 697);
                }
            }

            internal FILETIME(long fileTime)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1033, 713, 882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 502, 515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 544, 558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 778, 809);

                    dwLowDateTime = (uint)fileTime;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 827, 867);

                    dwHighDateTime = (uint)(fileTime >> 32);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1033, 713, 882);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 713, 882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 713, 882);
                }
            }

            public long ToTicks()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1033, 898, 1019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 952, 1004);

                    return ((long)dwHighDateTime << 32) + dwLowDateTime;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1033, 898, 1019);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 898, 1019);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 898, 1019);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static FILETIME()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 393, 1031);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 393, 1031);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 393, 1031);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1033, 393, 1031);
        }
       ;
        [Flags]
        // dwDesiredAccess of CreateFile
        internal enum FileDesiredAccess : uint
        {
            GenericRead = 0x80000000,
            GenericWrite = 0x40000000,
            GenericExecute = 0x20000000,
            GenericAll = 0x10000000,
        }

        [Flags]
        // dwShareMode of CreateFile
        internal enum FileShareMode : uint
        {
            None = 0x00000000,
            Read = 0x00000001,
            Write = 0x00000002,
            Delete = 0x00000004,
        }

        // dwCreationDisposition of CreateFile
        internal enum FileCreationDisposition : uint
        {
            New = 1,
            CreateAlways = 2,
            OpenExisting = 3,
            OpenAlways = 4,
            TruncateExisting = 5,
        }

        [Flags]
        // dwFlagsAndAttributes
        internal enum FileAttributes : uint
        {
            ReadOnly = 0x00000001,
            Hidden = 0x00000002,
            System = 0x00000004,
            Directory = 0x00000010,
            Archive = 0x00000020,
            Normal = 0x00000080,
            Temporary = 0x00000100,
            Offline = 0x00001000,
            NotContentIndexed = 0x00002000,
            Encrypted = 0x00004000,
            Write_Through = 0x80000000,
            Overlapped = 0x40000000,
            NoBuffering = 0x20000000,
            RandomAccess = 0x10000000,
            SequentialScan = 0x08000000,
            DeleteOnClose = 0x04000000,
            BackupSemantics = 0x02000000,
            PosixSemantics = 0x01000000,
            OpenReparsePoint = 0x00200000,
            OpenNoRecall = 0x00100000,
            SessionAware = 0x00800000
        }
        [StructLayout(LayoutKind.Sequential)]
        internal class SecurityAttributes
        {
            internal int nLength;

            internal SafeLocalMemHandle lpSecurityDescriptor;

            internal bool bInheritHandle;

            internal SecurityAttributes()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1033, 3039, 3267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 2911, 2918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 2961, 2981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 3010, 3024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 3101, 3119);

                    this.nLength = 12;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 3137, 3164);

                    this.bInheritHandle = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 3182, 3252);

                    this.lpSecurityDescriptor = f_1033_3210_3251(IntPtr.Zero, true);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1033, 3039, 3267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 3039, 3267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 3039, 3267);
                }
            }

            static SecurityAttributes()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 2793, 3278);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 2793, 3278);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 2793, 3278);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1033, 2793, 3278);

            System.Management.Automation.PlatformInvokes.SafeLocalMemHandle
            f_1033_3210_3251(System.IntPtr
            existingHandle, bool
            ownsHandle)
            {
                var return_v = new System.Management.Automation.PlatformInvokes.SafeLocalMemHandle(existingHandle, ownsHandle);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 3210, 3251);
                return return_v;
            }

        }
        internal sealed class SafeLocalMemHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            internal SafeLocalMemHandle()
            : base(f_1033_3469_3473_C(true))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1033, 3415, 3504);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1033, 3415, 3504);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 3415, 3504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 3415, 3504);
                }
            }

            [SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
            internal SafeLocalMemHandle(IntPtr existingHandle, bool ownsHandle)
            : base(f_1033_3695_3705_C(ownsHandle))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1033, 3520, 3785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 3739, 3770);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetHandle(existingHandle), 1033, 3739, 3769);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1033, 3520, 3785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 3520, 3785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 3520, 3785);
                }
            }

            [DllImport(PinvokeDllNames.LocalFreeDllName), ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            private static extern IntPtr LocalFree(IntPtr hMem);

            protected override bool ReleaseHandle()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1033, 3993, 4127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 4065, 4112);

                    return (f_1033_4073_4095(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.handle, 1033, 4083, 4094)) == IntPtr.Zero);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1033, 3993, 4127);

                    System.IntPtr
                    f_1033_4073_4095(System.IntPtr
                    hMem)
                    {
                        var return_v = LocalFree(hMem);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 4073, 4095);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 3993, 4127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 3993, 4127);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SafeLocalMemHandle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 3290, 4138);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 3290, 4138);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 3290, 4138);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1033, 3290, 4138);

            static bool
            f_1033_3469_3473_C(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1033, 3415, 3504);
                return return_v;
            }


            static bool
            f_1033_3695_3705_C(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1033, 3520, 3785);
                return return_v;
            }

        }

        [DllImport(PinvokeDllNames.CreateFileDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern IntPtr CreateFile(
                    string lpFileName,
                    FileDesiredAccess dwDesiredAccess,
                    FileShareMode dwShareMode,
                    IntPtr lpSecurityAttributes,
                    FileCreationDisposition dwCreationDisposition,
                    FileAttributes dwFlagsAndAttributes,
                    IntPtr hTemplateFile);

        [DllImport(PinvokeDllNames.CloseHandleDllName, SetLastError = true)]//, ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [return: MarshalAs(UnmanagedType.Bool)]
        // [SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
        internal static extern bool CloseHandle(IntPtr handle);

        [DllImport(PinvokeDllNames.DosDateTimeToFileTimeDllName, SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DosDateTimeToFileTime(
                    short wFatDate, // _In_   WORD
                    short wFatTime, // _In_   WORD
                    FILETIME lpFileTime);

        [DllImport(PinvokeDllNames.LocalFileTimeToFileTimeDllName, SetLastError = false, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool LocalFileTimeToFileTime(
                    FILETIME lpLocalFileTime, // _In_   const FILETIME *
                    FILETIME lpFileTime);

        [DllImport(PinvokeDllNames.SetFileTimeDllName, SetLastError = false, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetFileTime(
                    IntPtr hFile, // _In_      HANDLE
                    FILETIME lpCreationTime, // _In_opt_ const FILETIME *
                    FILETIME lpLastAccessTime, // _In_opt_ const FILETIME *
                    FILETIME lpLastWriteTime);

        [DllImport(PinvokeDllNames.SetFileAttributesWDllName, SetLastError = false, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetFileAttributesW(
                    [MarshalAs(UnmanagedType.LPWStr)] string lpFileName, // _In_ LPCTSTR
                    FileAttributes dwFileAttributes);

        internal static bool EnableTokenPrivilege(string privilegeName, ref TOKEN_PRIVILEGE oldPrivilegeState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1033, 13446, 17690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 13573, 13594);

                bool
                success = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 13608, 13666);

                TOKEN_PRIVILEGE
                newPrivilegeState = f_1033_13644_13665()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 13753, 17648) || true) && (f_1033_13757_13836(null, privilegeName, ref newPrivilegeState.Privilege.Luid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 13753, 17648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 13936, 13980);

                    IntPtr
                    processHandler = f_1033_13960_13979()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 13998, 17633) || true) && (processHandler != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 13998, 17633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 14151, 14185);

                        IntPtr
                        tokenHandler = IntPtr.Zero
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 14207, 17336) || true) && (f_1033_14211_14300(processHandler, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, out tokenHandler))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 14207, 17336);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 14430, 14484);

                            PRIVILEGE_SET
                            requiredPrivilege = f_1033_14464_14483()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 14510, 14578);

                            requiredPrivilege.Privilege.Luid = newPrivilegeState.Privilege.Luid;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 14604, 14641);

                            requiredPrivilege.PrivilegeCount = 1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 14739, 14769);

                            requiredPrivilege.Control = 1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 14795, 14825);

                            bool
                            privilegeEnabled = false
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 14853, 17313) || true) && (f_1033_14857_14930(tokenHandler, ref requiredPrivilege, out privilegeEnabled) && (DynAbs.Tracing.TraceSender.Expression_True(1033, 14857, 14950) && privilegeEnabled))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 14853, 17313);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 15083, 15120);

                                oldPrivilegeState.PrivilegeCount = 0;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 15150, 15165);

                                success = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 14853, 17313);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 14853, 17313);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 15366, 15403);

                                newPrivilegeState.PrivilegeCount = 1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 15433, 15495);

                                newPrivilegeState.Privilege.Attributes = SE_PRIVILEGE_ENABLED;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 15525, 15576);

                                int
                                bufferSize = f_1033_15542_15575()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 15606, 15625);

                                int
                                returnSize = 0
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 15720, 17286) || true) && (f_1033_15724_15840(tokenHandler, false, ref newPrivilegeState, bufferSize, out oldPrivilegeState, ref returnSize))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 15720, 17286);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 16047, 16089);

                                    int
                                    retCode = f_1033_16061_16088()
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 16123, 17255) || true) && (retCode == ERROR_SUCCESS)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 16123, 17255);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 16225, 16240);

                                        success = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 16123, 17255);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 16123, 17255);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 16314, 17255) || true) && (retCode == 1300)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 16314, 17255);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 17130, 17167);

                                            oldPrivilegeState.PrivilegeCount = 0;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 17205, 17220);

                                            success = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 16314, 17255);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 16123, 17255);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 15720, 17286);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 14853, 17313);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 14207, 17336);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 17432, 17562) || true) && (tokenHandler != IntPtr.Zero)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 17432, 17562);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 17513, 17539);

                            f_1033_17513_17538(tokenHandler);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 17432, 17562);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 17586, 17614);

                        f_1033_17586_17613(processHandler);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 13998, 17633);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 13753, 17648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 17664, 17679);

                return success;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1033, 13446, 17690);

                System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
                f_1033_13644_13665()
                {
                    var return_v = new System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 13644, 13665);
                    return return_v;
                }


                bool
                f_1033_13757_13836(string
                lpSystemName, string
                lpName, ref System.Management.Automation.PlatformInvokes.LUID
                lpLuid)
                {
                    var return_v = LookupPrivilegeValue(lpSystemName, lpName, ref lpLuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 13757, 13836);
                    return return_v;
                }


                System.IntPtr
                f_1033_13960_13979()
                {
                    var return_v = GetCurrentProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 13960, 13979);
                    return return_v;
                }


                bool
                f_1033_14211_14300(System.IntPtr
                processHandle, int
                desiredAccess, out System.IntPtr
                tokenHandle)
                {
                    var return_v = OpenProcessToken(processHandle, (uint)desiredAccess, out tokenHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 14211, 14300);
                    return return_v;
                }


                System.Management.Automation.PlatformInvokes.PRIVILEGE_SET
                f_1033_14464_14483()
                {
                    var return_v = new System.Management.Automation.PlatformInvokes.PRIVILEGE_SET();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 14464, 14483);
                    return return_v;
                }


                bool
                f_1033_14857_14930(System.IntPtr
                tokenHandler, ref System.Management.Automation.PlatformInvokes.PRIVILEGE_SET
                requiredPrivileges, out bool
                pfResult)
                {
                    var return_v = PrivilegeCheck(tokenHandler, ref requiredPrivileges, out pfResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 14857, 14930);
                    return return_v;
                }


                int
                f_1033_15542_15575()
                {
                    var return_v = Marshal.SizeOf<TOKEN_PRIVILEGE>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 15542, 15575);
                    return return_v;
                }


                bool
                f_1033_15724_15840(System.IntPtr
                tokenHandler, bool
                disableAllPrivilege, ref System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
                newPrivilegeState, int
                bufferLength, out System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
                previousPrivilegeState, ref int
                returnLength)
                {
                    var return_v = AdjustTokenPrivileges(tokenHandler, disableAllPrivilege, ref newPrivilegeState, bufferLength, out previousPrivilegeState, ref returnLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 15724, 15840);
                    return return_v;
                }


                int
                f_1033_16061_16088()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 16061, 16088);
                    return return_v;
                }


                bool
                f_1033_17513_17538(System.IntPtr
                handle)
                {
                    var return_v = CloseHandle(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 17513, 17538);
                    return return_v;
                }


                bool
                f_1033_17586_17613(System.IntPtr
                handle)
                {
                    var return_v = CloseHandle(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 17586, 17613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 13446, 17690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 13446, 17690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool RestoreTokenPrivilege(string privilegeName, ref TOKEN_PRIVILEGE previousPrivilegeState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1033, 17942, 20279);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 18149, 18256) || true) && (previousPrivilegeState.PrivilegeCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 18149, 18256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 18229, 18241);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 18149, 18256);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 18272, 18293);

                bool
                success = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 18307, 18356);

                TOKEN_PRIVILEGE
                newState = f_1033_18334_18355()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 18604, 20237) || true) && (f_1033_18608_18678(null, privilegeName, ref newState.Privilege.Luid) && (DynAbs.Tracing.TraceSender.Expression_True(1033, 18608, 18781) && newState.Privilege.Luid.HighPart == previousPrivilegeState.Privilege.Luid.HighPart) && (DynAbs.Tracing.TraceSender.Expression_True(1033, 18608, 18882) && newState.Privilege.Luid.LowPart == previousPrivilegeState.Privilege.Luid.LowPart))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 18604, 20237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 18982, 19026);

                    IntPtr
                    processHandler = f_1033_19006_19025()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 19044, 20222) || true) && (processHandler != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 19044, 20222);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 19197, 19231);

                        IntPtr
                        tokenHandler = IntPtr.Zero
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 19253, 19997) || true) && (f_1033_19257_19346(processHandler, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, out tokenHandler))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 19253, 19997);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 19396, 19447);

                            int
                            bufferSize = f_1033_19413_19446()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 19473, 19492);

                            int
                            returnSize = 0
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 19613, 19974) || true) && (f_1033_19617_19729(tokenHandler, false, ref previousPrivilegeState, bufferSize, out newState, ref returnSize))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 19613, 19974);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 19787, 19947) || true) && (f_1033_19791_19818() == ERROR_SUCCESS)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 19787, 19947);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 19901, 19916);

                                    success = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 19787, 19947);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 19613, 19974);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 19253, 19997);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 20021, 20151) || true) && (tokenHandler != IntPtr.Zero)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 20021, 20151);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 20102, 20128);

                            f_1033_20102_20127(tokenHandler);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 20021, 20151);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 20175, 20203);

                        f_1033_20175_20202(processHandler);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 19044, 20222);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 18604, 20237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 20253, 20268);

                return success;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1033, 17942, 20279);

                System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
                f_1033_18334_18355()
                {
                    var return_v = new System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 18334, 18355);
                    return return_v;
                }


                bool
                f_1033_18608_18678(string
                lpSystemName, string
                lpName, ref System.Management.Automation.PlatformInvokes.LUID
                lpLuid)
                {
                    var return_v = LookupPrivilegeValue(lpSystemName, lpName, ref lpLuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 18608, 18678);
                    return return_v;
                }


                System.IntPtr
                f_1033_19006_19025()
                {
                    var return_v = GetCurrentProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 19006, 19025);
                    return return_v;
                }


                bool
                f_1033_19257_19346(System.IntPtr
                processHandle, int
                desiredAccess, out System.IntPtr
                tokenHandle)
                {
                    var return_v = OpenProcessToken(processHandle, (uint)desiredAccess, out tokenHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 19257, 19346);
                    return return_v;
                }


                int
                f_1033_19413_19446()
                {
                    var return_v = Marshal.SizeOf<TOKEN_PRIVILEGE>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 19413, 19446);
                    return return_v;
                }


                bool
                f_1033_19617_19729(System.IntPtr
                tokenHandler, bool
                disableAllPrivilege, ref System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
                newPrivilegeState, int
                bufferLength, out System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
                previousPrivilegeState, ref int
                returnLength)
                {
                    var return_v = AdjustTokenPrivileges(tokenHandler, disableAllPrivilege, ref newPrivilegeState, bufferLength, out previousPrivilegeState, ref returnLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 19617, 19729);
                    return return_v;
                }


                int
                f_1033_19791_19818()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 19791, 19818);
                    return return_v;
                }


                bool
                f_1033_20102_20127(System.IntPtr
                handle)
                {
                    var return_v = CloseHandle(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 20102, 20127);
                    return return_v;
                }


                bool
                f_1033_20175_20202(System.IntPtr
                handle)
                {
                    var return_v = CloseHandle(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 20175, 20202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 17942, 20279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 17942, 20279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DllImport(PinvokeDllNames.LookupPrivilegeValueDllName, CharSet = CharSet.Unicode, SetLastError = true, BestFitMapping = false)]
        [SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, ref LUID lpLuid);

        [DllImport(PinvokeDllNames.PrivilegeCheckDllName, CharSet = CharSet.Unicode, SetLastError = true, BestFitMapping = false)]
        [SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool PrivilegeCheck(IntPtr tokenHandler, ref PRIVILEGE_SET requiredPrivileges, out bool pfResult);

        [DllImport(PinvokeDllNames.AdjustTokenPrivilegesDllName, CharSet = CharSet.Unicode, SetLastError = true, BestFitMapping = false)]
        [SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AdjustTokenPrivileges(IntPtr tokenHandler, bool disableAllPrivilege,
                                                                  ref TOKEN_PRIVILEGE newPrivilegeState, int bufferLength,
                                                                  out TOKEN_PRIVILEGE previousPrivilegeState,
                                                                  ref int returnLength);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TOKEN_PRIVILEGE
        {

            internal uint PrivilegeCount;

            internal LUID_AND_ATTRIBUTES Privilege;
            static TOKEN_PRIVILEGE()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 23278, 23501);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 23278, 23501);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 23278, 23501);
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct LUID
        {

            internal uint LowPart;

            internal uint HighPart;
            static LUID()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 23513, 23702);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 23513, 23702);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 23513, 23702);
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct LUID_AND_ATTRIBUTES
        {

            internal LUID Luid;

            internal uint Attributes;
            static LUID_AND_ATTRIBUTES()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 23714, 23917);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 23714, 23917);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 23714, 23917);
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct PRIVILEGE_SET
        {

            internal uint PrivilegeCount;

            internal uint Control;

            internal LUID_AND_ATTRIBUTES Privilege;
            static PRIVILEGE_SET()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 23929, 24186);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 23929, 24186);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 23929, 24186);
            }
        }

        [DllImport(PinvokeDllNames.GetCurrentProcessDllName)]
        [SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport(PinvokeDllNames.OpenProcessTokenDllName, CharSet = CharSet.Unicode, SetLastError = true, BestFitMapping = false)]
        [SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool OpenProcessToken(IntPtr processHandle, uint desiredAccess, out IntPtr tokenHandle);

        internal const int
        TOKEN_ADJUST_PRIVILEGES = 0x00000020
        ;

        internal const int
        TOKEN_QUERY = 0x00000008
        ;

        internal const int
        TOKEN_ALL_ACCESS = 0x001f01ff
        ;

        internal const uint
        SE_PRIVILEGE_DISABLED = 0x00000000
        ;

        internal const uint
        SE_PRIVILEGE_ENABLED_BY_DEFAULT = 0x00000001
        ;

        internal const uint
        SE_PRIVILEGE_ENABLED = 0x00000002
        ;

        internal const uint
        SE_PRIVILEGE_USED_FOR_ACCESS = 0x80000000
        ;

        internal const int
        ERROR_SUCCESS = 0x0
        ;

        internal static readonly IntPtr INVALID_HANDLE_VALUE;

        internal static UInt32 GENERIC_READ;

        internal static UInt32 GENERIC_WRITE;

        internal static UInt32 FILE_ATTRIBUTE_NORMAL;

        internal static UInt32 CREATE_ALWAYS;

        internal static UInt32 FILE_SHARE_WRITE;

        internal static UInt32 FILE_SHARE_READ;

        internal static UInt32 OF_READWRITE;

        internal static UInt32 OPEN_EXISTING;
        [StructLayout(LayoutKind.Sequential)]
        internal class PROCESS_INFORMATION
        {
            public IntPtr hProcess;

            public IntPtr hThread;

            public int dwProcessId;

            public int dwThreadId;

            public PROCESS_INFORMATION()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1033, 27195, 27344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 27131, 27142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 27168, 27178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 27256, 27284);

                    this.hProcess = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 27302, 27329);

                    this.hThread = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1033, 27195, 27344);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 27195, 27344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 27195, 27344);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1033, 27441, 27524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 27495, 27509);

                    f_1033_27495_27508(this, true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1033, 27441, 27524);

                    int
                    f_1033_27495_27508(System.Management.Automation.PlatformInvokes.PROCESS_INFORMATION
                    this_param, bool
                    disposing)
                    {
                        this_param.Dispose(disposing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 27495, 27508);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 27441, 27524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 27441, 27524);
                }
            }

            private void Dispose(bool disposing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1033, 27671, 28222);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 27740, 28207) || true) && (disposing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 27740, 28207);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 27795, 27981) || true) && (this.hProcess != IntPtr.Zero)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 27795, 27981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 27877, 27904);

                            f_1033_27877_27903(this.hProcess);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 27930, 27958);

                            this.hProcess = IntPtr.Zero;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 27795, 27981);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28005, 28188) || true) && (this.hThread != IntPtr.Zero)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 28005, 28188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28086, 28112);

                            f_1033_28086_28111(this.hThread);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28138, 28165);

                            this.hThread = IntPtr.Zero;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 28005, 28188);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 27740, 28207);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1033, 27671, 28222);

                    bool
                    f_1033_27877_27903(System.IntPtr
                    handle)
                    {
                        var return_v = CloseHandle(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 27877, 27903);
                        return return_v;
                    }


                    bool
                    f_1033_28086_28111(System.IntPtr
                    handle)
                    {
                        var return_v = CloseHandle(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 28086, 28111);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 27671, 28222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 27671, 28222);
                }
            }

            static PROCESS_INFORMATION()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 26941, 28233);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 26941, 28233);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 26941, 28233);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1033, 26941, 28233);
        }
        [StructLayout(LayoutKind.Sequential)]
        internal class STARTUPINFO
        {
            public int cb;

            public IntPtr lpReserved;

            public IntPtr lpDesktop;

            public IntPtr lpTitle;

            public int dwX;

            public int dwY;

            public int dwXSize;

            public int dwYSize;

            public int dwXCountChars;

            public int dwYCountChars;

            public int dwFillAttribute;

            public int dwFlags;

            public short wShowWindow;

            public short cbReserved2;

            public IntPtr lpReserved2;

            public SafeFileHandle hStdInput;

            public SafeFileHandle hStdOutput;

            public SafeFileHandle hStdError;

            public STARTUPINFO()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1033, 29017, 29528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28354, 28356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28495, 28498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28524, 28527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28553, 28560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28586, 28593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28619, 28632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28658, 28671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28697, 28712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28738, 28745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28773, 28784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28812, 28823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28900, 28909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28946, 28956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 28993, 29002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29070, 29100);

                    this.lpReserved = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29118, 29147);

                    this.lpDesktop = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29165, 29192);

                    this.lpTitle = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29210, 29241);

                    this.lpReserved2 = IntPtr.Zero;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29259, 29315);

                    this.hStdInput = f_1033_29276_29314(IntPtr.Zero, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29333, 29390);

                    this.hStdOutput = f_1033_29351_29389(IntPtr.Zero, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29408, 29464);

                    this.hStdError = f_1033_29425_29463(IntPtr.Zero, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29482, 29513);

                    this.cb = f_1033_29492_29512(this);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1033, 29017, 29528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 29017, 29528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 29017, 29528);
                }
            }

            public void Dispose(bool disposing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1033, 29544, 30362);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29612, 30347) || true) && (disposing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 29612, 30347);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29667, 29870) || true) && ((this.hStdInput != null) && (DynAbs.Tracing.TraceSender.Expression_True(1033, 29671, 29724) && f_1033_29699_29724_M(!this.hStdInput.IsInvalid)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 29667, 29870);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29774, 29799);

                            f_1033_29774_29798(this.hStdInput);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29825, 29847);

                            this.hStdInput = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 29667, 29870);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 29894, 30101) || true) && ((this.hStdOutput != null) && (DynAbs.Tracing.TraceSender.Expression_True(1033, 29898, 29953) && f_1033_29927_29953_M(!this.hStdOutput.IsInvalid)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 29894, 30101);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30003, 30029);

                            f_1033_30003_30028(this.hStdOutput);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30055, 30078);

                            this.hStdOutput = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 29894, 30101);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30125, 30328) || true) && ((this.hStdError != null) && (DynAbs.Tracing.TraceSender.Expression_True(1033, 30129, 30182) && f_1033_30157_30182_M(!this.hStdError.IsInvalid)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1033, 30125, 30328);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30232, 30257);

                            f_1033_30232_30256(this.hStdError);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30283, 30305);

                            this.hStdError = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 30125, 30328);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1033, 29612, 30347);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1033, 29544, 30362);

                    bool
                    f_1033_29699_29724_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1033, 29699, 29724);
                        return return_v;
                    }


                    int
                    f_1033_29774_29798(Microsoft.Win32.SafeHandles.SafeFileHandle
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 29774, 29798);
                        return 0;
                    }


                    bool
                    f_1033_29927_29953_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1033, 29927, 29953);
                        return return_v;
                    }


                    int
                    f_1033_30003_30028(Microsoft.Win32.SafeHandles.SafeFileHandle
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 30003, 30028);
                        return 0;
                    }


                    bool
                    f_1033_30157_30182_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1033, 30157, 30182);
                        return return_v;
                    }


                    int
                    f_1033_30232_30256(Microsoft.Win32.SafeHandles.SafeFileHandle
                    this_param)
                    {
                        this_param.Dispose();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 30232, 30256);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 29544, 30362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 29544, 30362);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1033, 30378, 30461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30432, 30446);

                    f_1033_30432_30445(this, true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1033, 30378, 30461);

                    int
                    f_1033_30432_30445(System.Management.Automation.PlatformInvokes.STARTUPINFO
                    this_param, bool
                    disposing)
                    {
                        this_param.Dispose(disposing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 30432, 30445);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 30378, 30461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 30378, 30461);
                }
            }

            static STARTUPINFO()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 28245, 30472);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 28245, 30472);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 28245, 30472);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1033, 28245, 30472);

            Microsoft.Win32.SafeHandles.SafeFileHandle
            f_1033_29276_29314(System.IntPtr
            preexistingHandle, bool
            ownsHandle)
            {
                var return_v = new Microsoft.Win32.SafeHandles.SafeFileHandle(preexistingHandle, ownsHandle);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 29276, 29314);
                return return_v;
            }


            Microsoft.Win32.SafeHandles.SafeFileHandle
            f_1033_29351_29389(System.IntPtr
            preexistingHandle, bool
            ownsHandle)
            {
                var return_v = new Microsoft.Win32.SafeHandles.SafeFileHandle(preexistingHandle, ownsHandle);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 29351, 29389);
                return return_v;
            }


            Microsoft.Win32.SafeHandles.SafeFileHandle
            f_1033_29425_29463(System.IntPtr
            preexistingHandle, bool
            ownsHandle)
            {
                var return_v = new Microsoft.Win32.SafeHandles.SafeFileHandle(preexistingHandle, ownsHandle);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 29425, 29463);
                return return_v;
            }


            int
            f_1033_29492_29512(System.Management.Automation.PlatformInvokes.STARTUPINFO
            structure)
            {
                var return_v = Marshal.SizeOf(structure);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 29492, 29512);
                return return_v;
            }

        }
        [StructLayout(LayoutKind.Sequential)]
        internal class SECURITY_ATTRIBUTES
        {
            public int nLength;

            public SafeLocalMemHandle lpSecurityDescriptor;

            public bool bInheritHandle;

            public SECURITY_ATTRIBUTES()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1033, 30725, 30952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30601, 30608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30649, 30669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30696, 30710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30786, 30804);

                    this.nLength = 12;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30822, 30849);

                    this.bInheritHandle = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 30867, 30937);

                    this.lpSecurityDescriptor = f_1033_30895_30936(IntPtr.Zero, true);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1033, 30725, 30952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1033, 30725, 30952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 30725, 30952);
                }
            }

            static SECURITY_ATTRIBUTES()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 30484, 30963);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 30484, 30963);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 30484, 30963);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1033, 30484, 30963);

            System.Management.Automation.PlatformInvokes.SafeLocalMemHandle
            f_1033_30895_30936(System.IntPtr
            existingHandle, bool
            ownsHandle)
            {
                var return_v = new System.Management.Automation.PlatformInvokes.SafeLocalMemHandle(existingHandle, ownsHandle);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 30895, 30936);
                return return_v;
            }

        }

        [DllImport(PinvokeDllNames.CreateProcessDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CreateProcess(
                    [MarshalAs(UnmanagedType.LPWStr)] string lpApplicationName,
                    [MarshalAs(UnmanagedType.LPWStr)] string lpCommandLine,
                    SECURITY_ATTRIBUTES lpProcessAttributes,
                    SECURITY_ATTRIBUTES lpThreadAttributes,
                    bool bInheritHandles,
                    int dwCreationFlags,
                    IntPtr lpEnvironment,
                    [MarshalAs(UnmanagedType.LPWStr)] string lpCurrentDirectory,
                    STARTUPINFO lpStartupInfo,
                    PROCESS_INFORMATION lpProcessInformation);

        [DllImport(PinvokeDllNames.ResumeThreadDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern uint ResumeThread(IntPtr threadHandle);

        internal static uint RESUME_THREAD_FAILED;

        [DllImport(PinvokeDllNames.CreateFileDllName, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern System.IntPtr CreateFileW(
                    [In, MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
                    UInt32 dwDesiredAccess,
                    UInt32 dwShareMode,
                    SECURITY_ATTRIBUTES lpSecurityAttributes,
                    UInt32 dwCreationDisposition,
                    UInt32 dwFlagsAndAttributes,
                    System.IntPtr hTemplateFile);





        internal enum StandardHandleId : uint
        {
            Error = unchecked((uint)-12),
            Output = unchecked((uint)-11),
            Input = unchecked((uint)-10),
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr GetStdHandle(uint handleId);

        public PlatformInvokes()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1033, 346, 32920);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1033, 346, 32920);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 346, 32920);
        }


        static PlatformInvokes()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1033, 346, 32920);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 25605, 25641);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 25768, 25792);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 25933, 25962);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 25995, 26029);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26060, 26104);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26135, 26168);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26199, 26240);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26272, 26291);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26418, 26455);
            INVALID_HANDLE_VALUE = f_1033_26441_26455(-1);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26489, 26514);
            GENERIC_READ = 0x80000000;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26548, 26574);
            GENERIC_WRITE = 0x40000000;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26608, 26642);
            FILE_ATTRIBUTE_NORMAL = 0x80000000;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26676, 26693);
            CREATE_ALWAYS = 2;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26727, 26756);
            FILE_SHARE_WRITE = 0x00000002;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26790, 26818);
            FILE_SHARE_READ = 0x00000001;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26852, 26877);
            OF_READWRITE = 0x00000002;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 26911, 26928);
            OPEN_EXISTING = 3;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1033, 31905, 31950);
            RESUME_THREAD_FAILED = System.UInt32.MaxValue;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1033, 346, 32920);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1033, 346, 32920);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1033, 346, 32920);

        static System.IntPtr
        f_1033_26441_26455(int
        value)
        {
            var return_v = new System.IntPtr(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1033, 26441, 26455);
            return return_v;
        }

    }
}
