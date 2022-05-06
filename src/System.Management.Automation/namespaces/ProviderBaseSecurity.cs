// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Security.AccessControl;

namespace System.Management.Automation.Provider
{
    public abstract partial class CmdletProvider
    {
        internal void GetSecurityDescriptor(
                    string path,
                    AccessControlSections sections,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1207, 1367, 1972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1207, 1543, 1561);

                Context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1207, 1577, 1674);

                ISecurityDescriptorCmdletProvider
                permissionProvider = this as ISecurityDescriptorCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1207, 1782, 1848);

                f_1207_1782_1847(permissionProvider);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1207, 1904, 1961);

                f_1207_1904_1960(
                            // Call interface method

                            permissionProvider, path, sections);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1207, 1367, 1972);

                int
                f_1207_1782_1847(System.Management.Automation.Provider.ISecurityDescriptorCmdletProvider
                permissionProvider)
                {
                    CheckIfSecurityDescriptorInterfaceIsSupported(permissionProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1207, 1782, 1847);
                    return 0;
                }


                int
                f_1207_1904_1960(System.Management.Automation.Provider.ISecurityDescriptorCmdletProvider
                this_param, string
                path, System.Security.AccessControl.AccessControlSections
                includeSections)
                {
                    this_param.GetSecurityDescriptor(path, includeSections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1207, 1904, 1960);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1207, 1367, 1972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1207, 1367, 1972);
            }
        }

        internal void SetSecurityDescriptor(
                    string path,
                    ObjectSecurity securityDescriptor,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1207, 2766, 3384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1207, 2945, 2963);

                Context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1207, 2979, 3076);

                ISecurityDescriptorCmdletProvider
                permissionProvider = this as ISecurityDescriptorCmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1207, 3184, 3250);

                f_1207_3184_3249(permissionProvider);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1207, 3306, 3373);

                f_1207_3306_3372(
                            // Call interface method

                            permissionProvider, path, securityDescriptor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1207, 2766, 3384);

                int
                f_1207_3184_3249(System.Management.Automation.Provider.ISecurityDescriptorCmdletProvider
                permissionProvider)
                {
                    CheckIfSecurityDescriptorInterfaceIsSupported(permissionProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1207, 3184, 3249);
                    return 0;
                }


                int
                f_1207_3306_3372(System.Management.Automation.Provider.ISecurityDescriptorCmdletProvider
                this_param, string
                path, System.Security.AccessControl.ObjectSecurity
                securityDescriptor)
                {
                    this_param.SetSecurityDescriptor(path, securityDescriptor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1207, 3306, 3372);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1207, 2766, 3384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1207, 2766, 3384);
            }
        }

        private static void CheckIfSecurityDescriptorInterfaceIsSupported(ISecurityDescriptorCmdletProvider permissionProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1207, 3396, 3791);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1207, 3540, 3780) || true) && (permissionProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1207, 3540, 3780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1207, 3604, 3765);

                    throw
                    f_1207_3631_3764(f_1207_3696_3763());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1207, 3540, 3780);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1207, 3396, 3791);

                string
                f_1207_3696_3763()
                {
                    var return_v = ProviderBaseSecurity.ISecurityDescriptorCmdletProvider_NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1207, 3696, 3763);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1207_3631_3764(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1207, 3631, 3764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1207, 3396, 3791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1207, 3396, 3791);
            }
        }
    }
}
