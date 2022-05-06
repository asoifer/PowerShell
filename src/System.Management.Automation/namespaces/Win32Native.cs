// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// NOTE: A vast majority of this code was copied from BCL in
// Namespace: Microsoft.Win32
//
/*
 * Notes to PInvoke users:  Getting the syntax exactly correct is crucial, and
 * more than a little confusing.  Here's some guidelines.
 *
 * For handles, you should use a SafeHandle subclass specific to your handle
 * type.
*/

namespace Microsoft.PowerShell.Commands.Internal
{
    using System;
    using System.Security;
    using System.Text;
    using System.Runtime.InteropServices;
    using System.Runtime.Versioning;
    using System.Management.Automation;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.ConstrainedExecution;

    using BOOL = System.Int32;
    using DWORD = System.UInt32;
    using ULONG = System.UInt32;
    [SuppressUnmanagedCodeSecurityAttribute()]
    internal static class Win32Native
    {
        internal const int
        ERROR_INSUFFICIENT_BUFFER = 0x7A
        ;



        internal enum TOKEN_INFORMATION_CLASS
        {
            TokenUser = 1,
            TokenGroups,
            TokenPrivileges,
            TokenOwner,
            TokenPrimaryGroup,
            TokenDefaultDacl,
            TokenSource,
            TokenType,
            TokenImpersonationLevel,
            TokenStatistics,
            TokenRestrictedSids,
            TokenSessionId,
            TokenGroupsAndPrivileges,
            TokenSessionReference,
            TokenSandBoxInert,
            TokenAuditPolicy,
            TokenOrigin
        }

        internal enum SID_NAME_USE
        {
            SidTypeUser = 1,
            SidTypeGroup,
            SidTypeDomain,
            SidTypeAlias,
            SidTypeWellKnownGroup,
            SidTypeDeletedAccount,
            SidTypeInvalid,
            SidTypeUnknown,
            SidTypeComputer
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct SID_AND_ATTRIBUTES
        {

            internal IntPtr Sid;

            internal uint Attributes;
            static SID_AND_ATTRIBUTES()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1220, 2289, 2492);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1220, 2289, 2492);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1220, 2289, 2492);
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct TOKEN_USER
        {

            internal SID_AND_ATTRIBUTES User;
            static TOKEN_USER()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1220, 2504, 2673);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1220, 2504, 2673);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1220, 2504, 2673);
            }
        }

        [DllImport(PinvokeDllNames.LookupAccountSidDllName, CharSet = CharSet.Unicode, SetLastError = true, BestFitMapping = false)]
        [ResourceExposure(ResourceScope.Machine)]
        [SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern unsafe bool LookupAccountSid(string lpSystemName,
                                                             IntPtr sid,
                                                             char* lpName,
                                                             ref int cchName,
                                                             char* referencedDomainName,
                                                             ref int cchReferencedDomainName,
                                                             out SID_NAME_USE peUse);

        internal static unsafe bool LookupAccountSid(string lpSystemName,
                                                             IntPtr sid,
                                                             Span<char> userName,
                                                             ref int cchName,
                                                             Span<char> domainName,
                                                             ref int cchDomainName,
                                                             out SID_NAME_USE peUse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1220, 4247, 5348);
                // LAFHIS
                fixed (char* userNamePtr = &MemoryMarshal.GetReference(userName))
                {
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1220, 4809, 4845);
                    fixed (char* domainNamePtr = &MemoryMarshal.GetReference(domainName))
                    {
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1220, 4890, 4928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1220, 4962, 5322);

                        return f_1220_4969_5321(lpSystemName, sid, userNamePtr, ref cchName, domainNamePtr, ref cchDomainName, out peUse);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1220, 4247, 5348);


                unsafe bool
                f_1220_4969_5321(string
                lpSystemName, System.IntPtr
                sid, char*
                lpName, ref int
                cchName, char*
                referencedDomainName, ref int
                cchReferencedDomainName, out Microsoft.PowerShell.Commands.Internal.Win32Native.SID_NAME_USE
                peUse)
                {
                    var return_v = LookupAccountSid(lpSystemName, sid, lpName, ref cchName, referencedDomainName, ref cchReferencedDomainName, out peUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1220, 4969, 5321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1220, 4247, 5348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1220, 4247, 5348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DllImport(PinvokeDllNames.CloseHandleDllName, SetLastError = true)]
        [ResourceExposure(ResourceScope.Machine)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool CloseHandle(IntPtr handle);

        [DllImport(PinvokeDllNames.OpenProcessTokenDllName, CharSet = CharSet.Unicode, SetLastError = true, BestFitMapping = false)]
        [ResourceExposure(ResourceScope.Machine)]
        [SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool OpenProcessToken(IntPtr processHandle, uint desiredAccess, out IntPtr tokenHandle);

        [DllImport(PinvokeDllNames.GetTokenInformationDllName, CharSet = CharSet.Unicode, SetLastError = true, BestFitMapping = false)]
        [ResourceExposure(ResourceScope.Machine)]
        [SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetTokenInformation(IntPtr tokenHandle,
                                                                TOKEN_INFORMATION_CLASS tokenInformationClass,
                                                                IntPtr tokenInformation,
                                                                int tokenInformationLength,
                                                                out int returnLength);

        static Win32Native()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1220, 1063, 7939);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1220, 1213, 1245);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1220, 1063, 7939);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1220, 1063, 7939);
        }

    }
}
