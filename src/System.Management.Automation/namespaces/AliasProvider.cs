// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Provider;

using Dbg = System.Management.Automation;

namespace Microsoft.PowerShell.Commands
{
    [CmdletProvider(AliasProvider.ProviderName, ProviderCapabilities.ShouldProcess)]
    [OutputType(typeof(AliasInfo), ProviderCmdlet = ProviderCmdlet.SetItem)]
    [OutputType(typeof(AliasInfo), ProviderCmdlet = ProviderCmdlet.RenameItem)]
    [OutputType(typeof(AliasInfo), ProviderCmdlet = ProviderCmdlet.CopyItem)]
    [OutputType(typeof(AliasInfo), ProviderCmdlet = ProviderCmdlet.GetChildItem)]
    [OutputType(typeof(AliasInfo), ProviderCmdlet = ProviderCmdlet.NewItem)]
    public sealed class AliasProvider : SessionStateProviderBase
    {
        public const string
        ProviderName = "Alias"
        ;

        public AliasProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1187, 1466, 1510);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1187, 1466, 1510);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 1466, 1510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 1466, 1510);
            }
        }

        protected override Collection<PSDriveInfo> InitializeDefaultDrives()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 1824, 2385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 1917, 1980);

                string
                description = f_1187_1938_1979()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 1996, 2230);

                PSDriveInfo
                aliasDrive =
                f_1187_2038_2229(DriveNames.AliasDrive, f_1187_2120_2132(), string.Empty, description, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 2246, 2309);

                Collection<PSDriveInfo>
                drives = f_1187_2279_2308()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 2323, 2346);

                f_1187_2323_2345(drives, aliasDrive);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 2360, 2374);

                return drives;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 1824, 2385);

                string
                f_1187_1938_1979()
                {
                    var return_v = SessionStateStrings.AliasDriveDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 1938, 1979);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1187_2120_2132()
                {
                    var return_v = ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 2120, 2132);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1187_2038_2229(string
                name, System.Management.Automation.ProviderInfo
                provider, string
                root, string
                description, System.Management.Automation.PSCredential
                credential)
                {
                    var return_v = new System.Management.Automation.PSDriveInfo(name, provider, root, description, credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 2038, 2229);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1187_2279_2308()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 2279, 2308);
                    return return_v;
                }


                int
                f_1187_2323_2345(System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                this_param, System.Management.Automation.PSDriveInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 2323, 2345);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 1824, 2385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 1824, 2385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object NewItemDynamicParameters(string path, string type, object newItemValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 3002, 3179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 3124, 3168);

                return f_1187_3131_3167();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 3002, 3179);

                Microsoft.PowerShell.Commands.AliasProviderDynamicParameters
                f_1187_3131_3167()
                {
                    var return_v = new Microsoft.PowerShell.Commands.AliasProviderDynamicParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 3131, 3167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 3002, 3179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 3002, 3179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object SetItemDynamicParameters(string path, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 3622, 3779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 3724, 3768);

                return f_1187_3731_3767();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 3622, 3779);

                Microsoft.PowerShell.Commands.AliasProviderDynamicParameters
                f_1187_3731_3767()
                {
                    var return_v = new Microsoft.PowerShell.Commands.AliasProviderDynamicParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 3731, 3767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 3622, 3779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 3622, 3779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override object GetSessionStateItem(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 4183, 4522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 4265, 4395);

                f_1187_4265_4394(!f_1187_4307_4333(name), "The caller should verify this parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 4411, 4482);

                AliasInfo
                value = f_1187_4429_4481(f_1187_4429_4450(f_1187_4429_4441()), name, f_1187_4466_4480(f_1187_4466_4473()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 4498, 4511);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 4183, 4522);

                bool
                f_1187_4307_4333(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 4307, 4333);
                    return return_v;
                }


                int
                f_1187_4265_4394(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 4265, 4394);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1187_4429_4441()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 4429, 4441);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1187_4429_4450(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 4429, 4450);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1187_4466_4473()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 4466, 4473);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1187_4466_4480(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Origin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 4466, 4480);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1187_4429_4481(System.Management.Automation.SessionStateInternal
                this_param, string
                aliasName, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.GetAlias(aliasName, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 4429, 4481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 4183, 4522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 4183, 4522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override object GetValueOfItem(object item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 5065, 5502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 5142, 5257);

                f_1187_5142_5256(item != null, "Caller should verify the item parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 5273, 5293);

                object
                value = item
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 5309, 5349);

                AliasInfo
                aliasInfo = item as AliasInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 5363, 5462) || true) && (aliasInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 5363, 5462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 5418, 5447);

                    value = f_1187_5426_5446(aliasInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 5363, 5462);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 5478, 5491);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 5065, 5502);

                int
                f_1187_5142_5256(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 5142, 5256);
                    return 0;
                }


                string
                f_1187_5426_5446(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 5426, 5446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 5065, 5502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 5065, 5502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void SetSessionStateItem(string name, object value, bool writeItem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 6003, 8791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 6113, 6243);

                f_1187_6113_6242(!f_1187_6155_6181(name), "The caller should verify this parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 6259, 6379);

                AliasProviderDynamicParameters
                dynamicParameters =
                f_1187_6327_6344() as AliasProviderDynamicParameters
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 6395, 6417);

                AliasInfo
                item = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 6433, 6525);

                bool
                dynamicParametersSpecified = dynamicParameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1187, 6467, 6524) && f_1187_6496_6524(dynamicParameters))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 6541, 8646) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 6541, 8646);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 6592, 7001) || true) && (dynamicParametersSpecified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 6592, 7001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 6664, 6708);

                        item = (AliasInfo)f_1187_6682_6707(this, name);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 6732, 6871) || true) && (item != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 6732, 6871);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 6798, 6848);

                            f_1187_6798_6847(item, f_1187_6814_6839(dynamicParameters), f_1187_6841_6846());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 6732, 6871);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 6592, 7001);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 6592, 7001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 6953, 6982);

                        f_1187_6953_6981(this, name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 6592, 7001);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 6541, 8646);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 6541, 8646);
                    {
                        try
                        {
                            do // false loop

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 7067, 8631);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 7124, 7161);

                                string
                                stringValue = value as string
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 7183, 7739) || true) && (stringValue != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 7183, 7739);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 7256, 7682) || true) && (dynamicParametersSpecified)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 7256, 7682);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 7344, 7456);

                                        item = f_1187_7351_7455(f_1187_7351_7372(f_1187_7351_7363()), name, stringValue, f_1187_7406_7431(dynamicParameters), f_1187_7433_7438(), f_1187_7440_7454(f_1187_7440_7447()));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 7256, 7682);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 7256, 7682);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 7570, 7655);

                                        item = f_1187_7577_7654(f_1187_7577_7598(f_1187_7577_7589()), name, stringValue, f_1187_7632_7637(), f_1187_7639_7653(f_1187_7639_7646()));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 7256, 7682);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(1187, 7710, 7716);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 7183, 7739);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 7763, 7800);

                                AliasInfo
                                alias = value as AliasInfo
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 7822, 8523) || true) && (alias != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 7822, 8523);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 7889, 8160);

                                    AliasInfo
                                    newAliasInfo =
                                    f_1187_7943_8159(name, f_1187_8030_8046(alias), f_1187_8081_8110(f_1187_8081_8093(this)), f_1187_8145_8158(alias))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 8188, 8361) || true) && (dynamicParametersSpecified)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 8188, 8361);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 8276, 8334);

                                        f_1187_8276_8333(newAliasInfo, f_1187_8300_8325(dynamicParameters), f_1187_8327_8332());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 8188, 8361);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 8389, 8468);

                                    item = f_1187_8396_8467(f_1187_8396_8417(f_1187_8396_8408()), newAliasInfo, f_1187_8445_8450(), f_1187_8452_8466(f_1187_8452_8459()));
                                    DynAbs.Tracing.TraceSender.TraceBreak(1187, 8494, 8500);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 7822, 8523);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 8547, 8597);

                                throw f_1187_8553_8596("value");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 7067, 8631);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 7067, 8631) || true) && (false)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1187, 7067, 8631);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1187, 7067, 8631);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 6541, 8646);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 8662, 8780) || true) && (writeItem && (DynAbs.Tracing.TraceSender.Expression_True(1187, 8666, 8691) && item != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 8662, 8780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 8725, 8765);

                    f_1187_8725_8764(this, item, f_1187_8747_8756(item), false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 8662, 8780);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 6003, 8791);

                bool
                f_1187_6155_6181(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 6155, 6181);
                    return return_v;
                }


                int
                f_1187_6113_6242(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 6113, 6242);
                    return 0;
                }


                object
                f_1187_6327_6344()
                {
                    var return_v = DynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 6327, 6344);
                    return return_v;
                }


                bool
                f_1187_6496_6524(Microsoft.PowerShell.Commands.AliasProviderDynamicParameters
                this_param)
                {
                    var return_v = this_param.OptionsSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 6496, 6524);
                    return return_v;
                }


                object
                f_1187_6682_6707(Microsoft.PowerShell.Commands.AliasProvider
                this_param, string
                name)
                {
                    var return_v = this_param.GetSessionStateItem(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 6682, 6707);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1187_6814_6839(Microsoft.PowerShell.Commands.AliasProviderDynamicParameters
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 6814, 6839);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1187_6841_6846()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 6841, 6846);
                    return return_v;
                }


                int
                f_1187_6798_6847(System.Management.Automation.AliasInfo
                this_param, System.Management.Automation.ScopedItemOptions
                newOptions, System.Management.Automation.SwitchParameter
                force)
                {
                    this_param.SetOptions(newOptions, (bool)force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 6798, 6847);
                    return 0;
                }


                int
                f_1187_6953_6981(Microsoft.PowerShell.Commands.AliasProvider
                this_param, string
                name)
                {
                    this_param.RemoveSessionStateItem(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 6953, 6981);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1187_7351_7363()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7351, 7363);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1187_7351_7372(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7351, 7372);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1187_7406_7431(Microsoft.PowerShell.Commands.AliasProviderDynamicParameters
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7406, 7431);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1187_7433_7438()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7433, 7438);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1187_7440_7447()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7440, 7447);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1187_7440_7454(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Origin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7440, 7454);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1187_7351_7455(System.Management.Automation.SessionStateInternal
                this_param, string
                aliasName, string
                value, System.Management.Automation.ScopedItemOptions
                options, System.Management.Automation.SwitchParameter
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasValue(aliasName, value, options, (bool)force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 7351, 7455);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1187_7577_7589()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7577, 7589);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1187_7577_7598(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7577, 7598);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1187_7632_7637()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7632, 7637);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1187_7639_7646()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7639, 7646);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1187_7639_7653(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Origin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 7639, 7653);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1187_7577_7654(System.Management.Automation.SessionStateInternal
                this_param, string
                aliasName, string
                value, System.Management.Automation.SwitchParameter
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasValue(aliasName, value, (bool)force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 7577, 7654);
                    return return_v;
                }


                string
                f_1187_8030_8046(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8030, 8046);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1187_8081_8093(Microsoft.PowerShell.Commands.AliasProvider
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8081, 8093);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1187_8081_8110(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8081, 8110);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1187_8145_8158(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8145, 8158);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1187_7943_8159(string
                name, string
                definition, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.ScopedItemOptions
                options)
                {
                    var return_v = new System.Management.Automation.AliasInfo(name, definition, context, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 7943, 8159);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1187_8300_8325(Microsoft.PowerShell.Commands.AliasProviderDynamicParameters
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8300, 8325);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1187_8327_8332()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8327, 8332);
                    return return_v;
                }


                int
                f_1187_8276_8333(System.Management.Automation.AliasInfo
                this_param, System.Management.Automation.ScopedItemOptions
                newOptions, System.Management.Automation.SwitchParameter
                force)
                {
                    this_param.SetOptions(newOptions, (bool)force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 8276, 8333);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1187_8396_8408()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8396, 8408);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1187_8396_8417(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8396, 8417);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1187_8445_8450()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8445, 8450);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1187_8452_8459()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8452, 8459);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1187_8452_8466(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Origin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8452, 8466);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1187_8396_8467(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.AliasInfo
                alias, System.Management.Automation.SwitchParameter
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetAliasItem(alias, (bool)force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 8396, 8467);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1187_8553_8596(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 8553, 8596);
                    return return_v;
                }


                string
                f_1187_8747_8756(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 8747, 8756);
                    return return_v;
                }


                int
                f_1187_8725_8764(Microsoft.PowerShell.Commands.AliasProvider
                this_param, System.Management.Automation.AliasInfo
                item, string
                path, bool
                isContainer)
                {
                    this_param.WriteItemObject((object)item, path, isContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 8725, 8764);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 6003, 8791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 6003, 8791);
            }
        }

        internal override void RemoveSessionStateItem(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 9061, 9348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 9144, 9274);

                f_1187_9144_9273(!f_1187_9186_9212(name), "The caller should verify this parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 9290, 9337);

                f_1187_9290_9336(f_1187_9290_9311(f_1187_9290_9302()), name, f_1187_9330_9335());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 9061, 9348);

                bool
                f_1187_9186_9212(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 9186, 9212);
                    return return_v;
                }


                int
                f_1187_9144_9273(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 9144, 9273);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1187_9290_9302()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 9290, 9302);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1187_9290_9311(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 9290, 9311);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1187_9330_9335()
                {
                    var return_v = Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 9330, 9335);
                    return return_v;
                }


                int
                f_1187_9290_9336(System.Management.Automation.SessionStateInternal
                this_param, string
                aliasName, System.Management.Automation.SwitchParameter
                force)
                {
                    this_param.RemoveAlias(aliasName, (bool)force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 9290, 9336);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 9061, 9348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 9061, 9348);
            }
        }

        internal override IDictionary GetSessionStateTable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 9626, 9772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 9703, 9761);

                return (IDictionary)f_1187_9723_9760(f_1187_9723_9744(f_1187_9723_9735()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 9626, 9772);

                System.Management.Automation.SessionState
                f_1187_9723_9735()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 9723, 9735);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1187_9723_9744(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 9723, 9744);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.AliasInfo>
                f_1187_9723_9760(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GetAliasTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 9723, 9760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 9626, 9772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 9626, 9772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool CanRenameItem(object item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 10191, 11074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 10265, 10285);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 10301, 10341);

                AliasInfo
                aliasInfo = item as AliasInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 10355, 11033) || true) && (aliasInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 10355, 11033);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 10410, 10984) || true) && ((f_1187_10415_10432(aliasInfo) & ScopedItemOptions.Constant) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1187, 10414, 10557) || ((f_1187_10494_10511(aliasInfo) & ScopedItemOptions.ReadOnly) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1187, 10493, 10556) && f_1187_10550_10556_M(!Force)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1187, 10410, 10984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 10599, 10933);

                        SessionStateUnauthorizedAccessException
                        e =
                        f_1187_10668_10932(f_1187_10742_10756(aliasInfo), SessionStateCategory.Alias, "CannotRenameAlias", f_1187_10894_10931())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 10957, 10965);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 10410, 10984);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 11004, 11018);

                    result = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1187, 10355, 11033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 11049, 11063);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 10191, 11074);

                System.Management.Automation.ScopedItemOptions
                f_1187_10415_10432(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 10415, 10432);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1187_10494_10511(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 10494, 10511);
                    return return_v;
                }


                bool
                f_1187_10550_10556_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 10550, 10556);
                    return return_v;
                }


                string
                f_1187_10742_10756(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 10742, 10756);
                    return return_v;
                }


                string
                f_1187_10894_10931()
                {
                    var return_v = SessionStateStrings.CannotRenameAlias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1187, 10894, 10931);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1187_10668_10932(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1187, 10668, 10932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 10191, 11074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 10191, 11074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AliasProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1187, 575, 11121);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 1248, 1270);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1187, 575, 11121);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 575, 11121);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1187, 575, 11121);
    }
    public class AliasProviderDynamicParameters
    {
        [Parameter]
        public ScopedItemOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 11505, 11529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 11511, 11527);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 11505, 11529);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 11427, 11661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 11427, 11661);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 11545, 11650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 11581, 11600);

                    _optionsSet = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 11618, 11635);

                    _options = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 11545, 11650);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 11427, 11661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 11427, 11661);
                }
            }
        }

        private ScopedItemOptions _options;

        internal bool OptionsSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1187, 11903, 11930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 11909, 11928);

                    return _optionsSet;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1187, 11903, 11930);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1187, 11854, 11941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 11854, 11941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _optionsSet;

        public AliasProviderDynamicParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1187, 11258, 11993);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 11699, 11707);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1187, 11966, 11985);
            this._optionsSet = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1187, 11258, 11993);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 11258, 11993);
        }


        static AliasProviderDynamicParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1187, 11258, 11993);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1187, 11258, 11993);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1187, 11258, 11993);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1187, 11258, 11993);
    }
}

