// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation.Provider;
using System.Reflection;
using System.Threading;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public class ProviderInfo
    {
        public Type ImplementingType { get; }

        public string HelpFile { get; }

        private SessionState _sessionState;

        private string _fullName;

        public string Name { get; }

        internal string FullName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 1585, 2855);

                    string GetFullName(string name, string psSnapInName, string moduleName)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 1621, 2742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1733, 1754);

                            string
                            result = name
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1776, 2685) || true) && (!f_1262_1781_1815(psSnapInName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 1776, 2685);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1865, 2133);

                                result =
                                f_1262_1903_2132(f_1262_1951_2000(), "{0}\\{1}", psSnapInName, name);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 1776, 2685);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 1776, 2685);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 2309, 2685) || true) && (!f_1262_2314_2346(moduleName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 2309, 2685);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 2396, 2662);

                                    result =
                                    f_1262_2434_2661(f_1262_2482_2531(), "{0}\\{1}", moduleName, name);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 2309, 2685);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 1776, 2685);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 2709, 2723);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 1621, 2742);

                            bool
                            f_1262_1781_1815(string
                            value)
                            {
                                var return_v = string.IsNullOrEmpty(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 1781, 1815);
                                return return_v;
                            }


                            System.Globalization.CultureInfo
                            f_1262_1951_2000()
                            {
                                var return_v = System.Globalization.CultureInfo.InvariantCulture;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 1951, 2000);
                                return return_v;
                            }


                            string
                            f_1262_1903_2132(System.Globalization.CultureInfo
                            provider, string
                            format, string
                            arg0, string
                            arg1)
                            {
                                var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 1903, 2132);
                                return return_v;
                            }


                            bool
                            f_1262_2314_2346(string
                            value)
                            {
                                var return_v = string.IsNullOrEmpty(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 2314, 2346);
                                return return_v;
                            }


                            System.Globalization.CultureInfo
                            f_1262_2482_2531()
                            {
                                var return_v = System.Globalization.CultureInfo.InvariantCulture;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 2482, 2531);
                                return return_v;
                            }


                            string
                            f_1262_2434_2661(System.Globalization.CultureInfo
                            provider, string
                            format, string
                            arg0, string
                            arg1)
                            {
                                var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 2434, 2661);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 1621, 2742);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 1621, 2742);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 2762, 2840);

                    return _fullName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1262, 2769, 2839) ?? (_fullName = f_1262_2795_2838(f_1262_2807_2811(), f_1262_2813_2825(), f_1262_2827_2837())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 1585, 2855);

                    string
                    f_1262_2807_2811()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 2807, 2811);
                        return return_v;
                    }


                    string
                    f_1262_2813_2825()
                    {
                        var return_v = PSSnapInName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 2813, 2825);
                        return return_v;
                    }


                    string
                    f_1262_2827_2837()
                    {
                        var return_v = ModuleName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 2827, 2837);
                        return return_v;
                    }


                    string
                    f_1262_2795_2838(string
                    name, string
                    psSnapInName, string
                    moduleName)
                    {
                        var return_v = GetFullName(name, psSnapInName, moduleName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 2795, 2838);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 1536, 2866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 1536, 2866);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSSnapInInfo PSSnapIn { get; }

        internal string PSSnapInName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 3215, 3443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 3251, 3272);

                    string
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 3290, 3394) || true) && (f_1262_3294_3302() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 3290, 3394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 3352, 3375);

                        result = f_1262_3361_3374(f_1262_3361_3369());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 3290, 3394);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 3414, 3428);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 3215, 3443);

                    System.Management.Automation.PSSnapInInfo
                    f_1262_3294_3302()
                    {
                        var return_v = PSSnapIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 3294, 3302);
                        return return_v;
                    }


                    System.Management.Automation.PSSnapInInfo
                    f_1262_3361_3369()
                    {
                        var return_v = PSSnapIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 3361, 3369);
                        return return_v;
                    }


                    string
                    f_1262_3361_3374(System.Management.Automation.PSSnapInInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 3361, 3374);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 3162, 3454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 3162, 3454);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string ApplicationBase
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 3522, 3882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 3558, 3579);

                    string
                    psHome = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 3641, 3681);

                        psHome = f_1262_3650_3680();
                    }
                    catch (System.Security.SecurityException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1262, 3718, 3833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 3800, 3814);

                        psHome = null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1262, 3718, 3833);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 3853, 3867);

                    return psHome;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 3522, 3882);

                    string
                    f_1262_3650_3680()
                    {
                        var return_v = Utils.DefaultPowerShellAppBase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 3650, 3680);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 3466, 3893);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 3466, 3893);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string ModuleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 4066, 4297);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4102, 4166) || true) && (f_1262_4106_4114() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 4102, 4166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4145, 4166);

                        return f_1262_4152_4165(f_1262_4152_4160());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 4102, 4166);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4184, 4244) || true) && (f_1262_4188_4194() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 4184, 4244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4225, 4244);

                        return f_1262_4232_4243(f_1262_4232_4238());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 4184, 4244);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4262, 4282);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 4066, 4297);

                    System.Management.Automation.PSSnapInInfo
                    f_1262_4106_4114()
                    {
                        var return_v = PSSnapIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 4106, 4114);
                        return return_v;
                    }


                    System.Management.Automation.PSSnapInInfo
                    f_1262_4152_4160()
                    {
                        var return_v = PSSnapIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 4152, 4160);
                        return return_v;
                    }


                    string
                    f_1262_4152_4165(System.Management.Automation.PSSnapInInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 4152, 4165);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1262_4188_4194()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 4188, 4194);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1262_4232_4238()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 4232, 4238);
                        return return_v;
                    }


                    string
                    f_1262_4232_4243(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 4232, 4243);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 4017, 4308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 4017, 4308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSModuleInfo Module { get; private set; }

        internal void SetModule(PSModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 4483, 4610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4552, 4568);

                Module = module;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4582, 4599);

                _fullName = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 4483, 4610);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 4483, 4610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 4483, 4610);
            }
        }

        public string Description { get; set; }

        public Provider.ProviderCapabilities Capabilities
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 4974, 6009);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 5010, 5953) || true) && (!_capabilitiesRead)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 5010, 5953);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 5201, 5243);

                            Type
                            providerType = f_1262_5221_5242(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 5271, 5348);

                            var
                            attrs = f_1262_5283_5347(providerType, false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 5374, 5459);

                            var
                            cmdletProviderAttributes = attrs as CmdletProviderAttribute[] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Provider.CmdletProviderAttribute[]>(1262, 5405, 5458) ?? f_1262_5443_5458(attrs))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 5487, 5732) || true) && (f_1262_5491_5522(cmdletProviderAttributes) == 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 5487, 5732);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 5585, 5650);

                                _capabilities = f_1262_5601_5649(cmdletProviderAttributes[0]);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 5680, 5705);

                                _capabilitiesRead = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 5487, 5732);
                            }
                        }
                        catch (Exception) // Catch-all OK, 3rd party callout
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1262, 5777, 5934);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1262, 5777, 5934);
                            // Assume no capabilities for now
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 5010, 5953);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 5973, 5994);

                    return _capabilities;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 4974, 6009);

                    System.Type
                    f_1262_5221_5242(System.Management.Automation.ProviderInfo
                    this_param)
                    {
                        var return_v = this_param.ImplementingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 5221, 5242);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Management.Automation.Provider.CmdletProviderAttribute>
                    f_1262_5283_5347(System.Type
                    type, bool
                    inherit)
                    {
                        var return_v = type.GetCustomAttributes<System.Management.Automation.Provider.CmdletProviderAttribute>(inherit);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 5283, 5347);
                        return return_v;
                    }


                    System.Management.Automation.Provider.CmdletProviderAttribute[]
                    f_1262_5443_5458(System.Collections.Generic.IEnumerable<System.Management.Automation.Provider.CmdletProviderAttribute>
                    source)
                    {
                        var return_v = source.ToArray<System.Management.Automation.Provider.CmdletProviderAttribute>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 5443, 5458);
                        return return_v;
                    }


                    int
                    f_1262_5491_5522(System.Management.Automation.Provider.CmdletProviderAttribute[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 5491, 5522);
                        return return_v;
                    }


                    System.Management.Automation.Provider.ProviderCapabilities
                    f_1262_5601_5649(System.Management.Automation.Provider.CmdletProviderAttribute
                    this_param)
                    {
                        var return_v = this_param.ProviderCapabilities;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 5601, 5649);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 4900, 6020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 4900, 6020);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ProviderCapabilities _capabilities;

        private bool _capabilitiesRead;

        public string Home { get; set; }

        public Collection<PSDriveInfo> Drives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 6703, 6809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 6739, 6794);

                    return f_1262_6746_6793(f_1262_6746_6765(_sessionState), f_1262_6784_6792());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 6703, 6809);

                    System.Management.Automation.DriveManagementIntrinsics
                    f_1262_6746_6765(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Drive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 6746, 6765);
                        return return_v;
                    }


                    string
                    f_1262_6784_6792()
                    {
                        var return_v = FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 6784, 6792);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                    f_1262_6746_6793(System.Management.Automation.DriveManagementIntrinsics
                    this_param, string
                    providerName)
                    {
                        var return_v = this_param.GetAllForProvider(providerName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 6746, 6793);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 6641, 6820);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 6641, 6820);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSDriveInfo _hiddenDrive;

        internal PSDriveInfo HiddenDrive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 7285, 7356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 7321, 7341);

                    return _hiddenDrive;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 7285, 7356);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 7228, 7367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 7228, 7367);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 7722, 7807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 7780, 7796);

                return f_1262_7787_7795();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 7722, 7807);

                string
                f_1262_7787_7795()
                {
                    var return_v = FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 7787, 7795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 7722, 7807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 7722, 7807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool VolumeSeparatedByColon { get; internal set; }

        public char ItemSeparator { get; private set; }

        public char AltItemSeparator { get; private set; }

        protected ProviderInfo(ProviderInfo providerInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1262, 9830, 10703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 860, 897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1011, 1058);
                this.HelpFile = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1206, 1219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1247, 1256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1360, 1387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 2993, 3030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4423, 4471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4729, 4768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 6061, 6102);
                this._capabilities = ProviderCapabilities.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 6126, 6143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 6456, 6488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 7025, 7037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 8538, 8603);
                this.VolumeSeparatedByColon = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 8736, 8783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 8918, 8968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24557, 24576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24612, 24625);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 9904, 10038) || true) && (providerInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 9904, 10038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 9962, 10023);

                    throw f_1262_9968_10022("providerInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 9904, 10038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10054, 10079);

                Name = f_1262_10061_10078(providerInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10093, 10142);

                ImplementingType = f_1262_10112_10141(providerInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10156, 10199);

                _capabilities = providerInfo._capabilities;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10213, 10252);

                Description = f_1262_10227_10251(providerInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10266, 10307);

                _hiddenDrive = providerInfo._hiddenDrive;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10321, 10346);

                Home = f_1262_10328_10345(providerInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10360, 10393);

                HelpFile = f_1262_10371_10392(providerInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10407, 10440);

                PSSnapIn = f_1262_10418_10439(providerInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10454, 10497);

                _sessionState = providerInfo._sessionState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10511, 10572);

                VolumeSeparatedByColon = f_1262_10536_10571(providerInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10586, 10629);

                ItemSeparator = f_1262_10602_10628(providerInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 10643, 10692);

                AltItemSeparator = f_1262_10662_10691(providerInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1262, 9830, 10703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 9830, 10703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 9830, 10703);
            }
        }

        internal ProviderInfo(
                    SessionState sessionState,
                    Type implementingType,
                    string name,
                    string helpFile,
                    PSSnapInInfo psSnapIn)
        : this(f_1262_12004_12016_C(sessionState), implementingType, name, string.Empty, string.Empty, helpFile, psSnapIn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1262, 11793, 12111);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1262, 11793, 12111);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 11793, 12111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 11793, 12111);
            }
        }

        internal ProviderInfo(
                    SessionState sessionState,
                    Type implementingType,
                    string name,
                    string description,
                    string home,
                    string helpFile,
                    PSSnapInInfo psSnapIn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1262, 13416, 15105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 860, 897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1011, 1058);
                this.HelpFile = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1206, 1219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1247, 1256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 1360, 1387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 2993, 3030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4423, 4471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 4729, 4768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 6061, 6102);
                this._capabilities = ProviderCapabilities.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 6126, 6143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 6456, 6488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 7025, 7037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 8538, 8603);
                this.VolumeSeparatedByColon = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 8736, 8783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 8918, 8968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24557, 24576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24612, 24625);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 13724, 13858) || true) && (sessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 13724, 13858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 13782, 13843);

                    throw f_1262_13788_13842("sessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 13724, 13858);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 13874, 14016) || true) && (implementingType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 13874, 14016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 13936, 14001);

                    throw f_1262_13942_14000("implementingType");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 13874, 14016);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14032, 14160) || true) && (f_1262_14036_14062(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 14032, 14160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14096, 14145);

                    throw f_1262_14102_14144("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 14032, 14160);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14176, 14205);

                _sessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14221, 14233);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14247, 14273);

                Description = description;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14287, 14299);

                Home = home;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14313, 14349);

                ImplementingType = implementingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14363, 14383);

                HelpFile = helpFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14397, 14417);

                PSSnapIn = psSnapIn;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14570, 14779);

                _hiddenDrive =
                f_1262_14602_14778(f_1262_14640_14653(this), this, string.Empty, string.Empty, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14795, 14822);

                _hiddenDrive.Hidden = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 14911, 15094) || true) && (implementingType == typeof(Microsoft.PowerShell.Commands.FileSystemProvider) && (DynAbs.Tracing.TraceSender.Expression_True(1262, 14915, 15014) && f_1262_14995_15014_M(!Platform.IsWindows)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 14911, 15094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 15048, 15079);

                    VolumeSeparatedByColon = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 14911, 15094);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1262, 13416, 15105);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 13416, 15105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 13416, 15105);
            }
        }

        internal bool NameEquals(string providerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 15567, 17050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 15637, 15731);

                PSSnapinQualifiedName
                qualifiedProviderName = f_1262_15683_15730(providerName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 15747, 15767);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 15781, 17009) || true) && (qualifiedProviderName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 15781, 17009);
                    {
                        try
                        {
                            do // false loop

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 15943, 16759);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 16000, 16598) || true) && (!f_1262_16005_16061(f_1262_16026_16060(qualifiedProviderName)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 16000, 16598);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 16239, 16575) || true) && (!f_1262_16244_16348(f_1262_16258_16292(qualifiedProviderName), f_1262_16294_16311(this), StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1262, 16243, 16484) && !f_1262_16382_16484(f_1262_16396_16430(qualifiedProviderName), f_1262_16432_16447(this), StringComparison.OrdinalIgnoreCase)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 16239, 16575);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1262, 16542, 16548);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 16239, 16575);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 16000, 16598);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 16622, 16725);

                                result = f_1262_16631_16724(f_1262_16645_16676(qualifiedProviderName), f_1262_16678_16687(this), StringComparison.OrdinalIgnoreCase);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 15943, 16759);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 15943, 16759) || true) && (false)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1262, 15943, 16759);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1262, 15943, 16759);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 15781, 17009);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 15781, 17009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 16915, 16994);

                    result = f_1262_16924_16993(providerName, f_1262_16952_16956(), StringComparison.OrdinalIgnoreCase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 15781, 17009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 17025, 17039);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 15567, 17050);

                System.Management.Automation.PSSnapinQualifiedName
                f_1262_15683_15730(string
                name)
                {
                    var return_v = PSSnapinQualifiedName.GetInstance(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 15683, 15730);
                    return return_v;
                }


                string
                f_1262_16026_16060(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 16026, 16060);
                    return return_v;
                }


                bool
                f_1262_16005_16061(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 16005, 16061);
                    return return_v;
                }


                string
                f_1262_16258_16292(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 16258, 16292);
                    return return_v;
                }


                string
                f_1262_16294_16311(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 16294, 16311);
                    return return_v;
                }


                bool
                f_1262_16244_16348(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 16244, 16348);
                    return return_v;
                }


                string
                f_1262_16396_16430(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 16396, 16430);
                    return return_v;
                }


                string
                f_1262_16432_16447(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 16432, 16447);
                    return return_v;
                }


                bool
                f_1262_16382_16484(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 16382, 16484);
                    return return_v;
                }


                string
                f_1262_16645_16676(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 16645, 16676);
                    return return_v;
                }


                string
                f_1262_16678_16687(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 16678, 16687);
                    return return_v;
                }


                bool
                f_1262_16631_16724(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 16631, 16724);
                    return return_v;
                }


                string
                f_1262_16952_16956()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 16952, 16956);
                    return return_v;
                }


                bool
                f_1262_16924_16993(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 16924, 16993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 15567, 17050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 15567, 17050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsMatch(string providerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 17062, 17624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 17129, 17223);

                PSSnapinQualifiedName
                psSnapinQualifiedName = f_1262_17175_17222(providerName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 17239, 17274);

                WildcardPattern
                namePattern = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 17290, 17546) || true) && (psSnapinQualifiedName != null && (DynAbs.Tracing.TraceSender.Expression_True(1262, 17294, 17402) && f_1262_17327_17402(f_1262_17370_17401(psSnapinQualifiedName))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 17290, 17546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 17436, 17531);

                    namePattern = f_1262_17450_17530(f_1262_17470_17501(psSnapinQualifiedName), WildcardOptions.IgnoreCase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 17290, 17546);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 17562, 17613);

                return f_1262_17569_17612(this, namePattern, psSnapinQualifiedName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 17062, 17624);

                System.Management.Automation.PSSnapinQualifiedName
                f_1262_17175_17222(string
                name)
                {
                    var return_v = PSSnapinQualifiedName.GetInstance(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 17175, 17222);
                    return return_v;
                }


                string
                f_1262_17370_17401(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 17370, 17401);
                    return return_v;
                }


                bool
                f_1262_17327_17402(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 17327, 17402);
                    return return_v;
                }


                string
                f_1262_17470_17501(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 17470, 17501);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1262_17450_17530(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 17450, 17530);
                    return return_v;
                }


                bool
                f_1262_17569_17612(System.Management.Automation.ProviderInfo
                this_param, System.Management.Automation.WildcardPattern
                namePattern, System.Management.Automation.PSSnapinQualifiedName
                psSnapinQualifiedName)
                {
                    var return_v = this_param.IsMatch(namePattern, psSnapinQualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 17569, 17612);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 17062, 17624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 17062, 17624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsMatch(WildcardPattern namePattern, PSSnapinQualifiedName psSnapinQualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 17636, 18502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 17756, 17776);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 17792, 18461) || true) && (psSnapinQualifiedName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 17792, 18461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 17859, 17873);

                    result = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 17792, 18461);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 17792, 18461);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 17939, 18446) || true) && (namePattern == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 17939, 18446);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 18004, 18254) || true) && (f_1262_18008_18096(f_1262_18022_18026(), f_1262_18028_18059(psSnapinQualifiedName), StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1262, 18008, 18167) && f_1262_18125_18167(this, psSnapinQualifiedName)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 18004, 18254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 18217, 18231);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 18004, 18254);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 17939, 18446);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 17939, 18446);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 18296, 18446) || true) && (f_1262_18300_18325(namePattern, f_1262_18320_18324()) && (DynAbs.Tracing.TraceSender.Expression_True(1262, 18300, 18371) && f_1262_18329_18371(this, psSnapinQualifiedName)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 18296, 18446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 18413, 18427);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 18296, 18446);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 17939, 18446);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 17792, 18461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 18477, 18491);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 17636, 18502);

                string
                f_1262_18022_18026()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 18022, 18026);
                    return return_v;
                }


                string
                f_1262_18028_18059(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 18028, 18059);
                    return return_v;
                }


                bool
                f_1262_18008_18096(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 18008, 18096);
                    return return_v;
                }


                bool
                f_1262_18125_18167(System.Management.Automation.ProviderInfo
                this_param, System.Management.Automation.PSSnapinQualifiedName
                psSnapinQualifiedName)
                {
                    var return_v = this_param.IsPSSnapinNameMatch(psSnapinQualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 18125, 18167);
                    return return_v;
                }


                string
                f_1262_18320_18324()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 18320, 18324);
                    return return_v;
                }


                bool
                f_1262_18300_18325(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 18300, 18325);
                    return return_v;
                }


                bool
                f_1262_18329_18371(System.Management.Automation.ProviderInfo
                this_param, System.Management.Automation.PSSnapinQualifiedName
                psSnapinQualifiedName)
                {
                    var return_v = this_param.IsPSSnapinNameMatch(psSnapinQualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 18329, 18371);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 17636, 18502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 17636, 18502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsPSSnapinNameMatch(PSSnapinQualifiedName psSnapinQualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 18514, 18936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 18616, 18636);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 18652, 18895) || true) && (f_1262_18656_18712(f_1262_18677_18711(psSnapinQualifiedName)) || (DynAbs.Tracing.TraceSender.Expression_False(1262, 18656, 18832) || f_1262_18733_18832(f_1262_18747_18781(psSnapinQualifiedName), f_1262_18783_18795(), StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 18652, 18895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 18866, 18880);

                    result = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 18652, 18895);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 18911, 18925);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 18514, 18936);

                string
                f_1262_18677_18711(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 18677, 18711);
                    return return_v;
                }


                bool
                f_1262_18656_18712(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 18656, 18712);
                    return return_v;
                }


                string
                f_1262_18747_18781(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 18747, 18781);
                    return return_v;
                }


                string
                f_1262_18783_18795()
                {
                    var return_v = PSSnapInName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 18783, 18795);
                    return return_v;
                }


                bool
                f_1262_18733_18832(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 18733, 18832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 18514, 18936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 18514, 18936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Provider.CmdletProvider CreateInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 19385, 23183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 20841, 20872);

                object
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 20950, 20987);

                Exception
                invocationException = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 21039, 21127);

                    providerInstance =
                    f_1262_21079_21126(f_1262_21104_21125(this));
                }
                catch (TargetInvocationException targetException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1262, 21156, 21306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 21238, 21291);

                    invocationException = f_1262_21260_21290(targetException);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1262, 21156, 21306);
                }
                catch (MissingMethodException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1262, 21320, 21380);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1262, 21320, 21380);
                }
                catch (MemberAccessException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1262, 21394, 21453);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1262, 21394, 21453);
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1262, 21467, 21522);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1262, 21467, 21522);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 21700, 22686) || true) && (providerInstance == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 21700, 22686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 21762, 21797);

                    ProviderNotFoundException
                    e = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 21817, 22643) || true) && (invocationException != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 21817, 22643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 21890, 22240);

                        e =
                        f_1262_21919_22239(f_1262_21979_21988(this), SessionStateCategory.CmdletProvider, "ProviderCtorException", f_1262_22139_22180(), f_1262_22211_22238(invocationException));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 21817, 22643);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 21817, 22643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 22322, 22624);

                        e =
                        f_1262_22351_22623(f_1262_22411_22420(this), SessionStateCategory.CmdletProvider, "ProviderNotFoundInAssembly", f_1262_22576_22622());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 21817, 22643);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 22663, 22671);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 21700, 22686);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 22702, 22779);

                Provider.CmdletProvider
                result = providerInstance as Provider.CmdletProvider
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 22793, 22830);

                ItemSeparator = f_1262_22809_22829(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 22844, 22887);

                AltItemSeparator = f_1262_22863_22886(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 22903, 23092);

                f_1262_22903_23091(result != null, "DiscoverProvider should verify that the class is derived from CmdletProvider so this is just validation of that");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 23108, 23144);

                f_1262_23108_23143(
                            result, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 23158, 23172);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 19385, 23183);

                System.Type
                f_1262_21104_21125(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 21104, 21125);
                    return return_v;
                }


                object?
                f_1262_21079_21126(System.Type
                type)
                {
                    var return_v = Activator.CreateInstance(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 21079, 21126);
                    return return_v;
                }


                System.Exception
                f_1262_21260_21290(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 21260, 21290);
                    return return_v;
                }


                string
                f_1262_21979_21988(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 21979, 21988);
                    return return_v;
                }


                string
                f_1262_22139_22180()
                {
                    var return_v = SessionStateStrings.ProviderCtorException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 22139, 22180);
                    return return_v;
                }


                string
                f_1262_22211_22238(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 22211, 22238);
                    return return_v;
                }


                System.Management.Automation.ProviderNotFoundException
                f_1262_21919_22239(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.ProviderNotFoundException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 21919, 22239);
                    return return_v;
                }


                string
                f_1262_22411_22420(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 22411, 22420);
                    return return_v;
                }


                string
                f_1262_22576_22622()
                {
                    var return_v = SessionStateStrings.ProviderNotFoundInAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 22576, 22622);
                    return return_v;
                }


                System.Management.Automation.ProviderNotFoundException
                f_1262_22351_22623(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.ProviderNotFoundException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 22351, 22623);
                    return return_v;
                }


                char
                f_1262_22809_22829(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.ItemSeparator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 22809, 22829);
                    return return_v;
                }


                char
                f_1262_22863_22886(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.AltItemSeparator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 22863, 22886);
                    return return_v;
                }


                int
                f_1262_22903_23091(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 22903, 23091);
                    return 0;
                }


                int
                f_1262_23108_23143(System.Management.Automation.Provider.CmdletProvider
                this_param, System.Management.Automation.ProviderInfo
                providerInfoToSet)
                {
                    this_param.SetProviderInformation(providerInfoToSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 23108, 23143);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 19385, 23183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 19385, 23183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GetOutputTypes(string cmdletname, List<PSTypeName> listToAppend)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 23329, 24500);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 23432, 24260) || true) && (_providerOutputType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 23432, 24260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 23497, 23562);

                    _providerOutputType = f_1262_23519_23561();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 23580, 24245);
                        foreach (OutputTypeAttribute outputType in f_1262_23623_23687_I(f_1262_23623_23687(f_1262_23623_23639(), false)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 23580, 24245);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 23729, 23862) || true) && (f_1262_23733_23780(f_1262_23754_23779(outputType)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 23729, 23862);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 23830, 23839);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 23729, 23862);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 23886, 23905);

                            List<PSTypeName>
                            l
                            = default(List<PSTypeName>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 23927, 24174) || true) && (!f_1262_23932_23997(_providerOutputType, f_1262_23964_23989(outputType), out l))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 23927, 24174);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24047, 24074);

                                l = f_1262_24051_24073();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24100, 24151);

                                _providerOutputType[f_1262_24120_24145(outputType)] = l;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 23927, 24174);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24198, 24226);

                            f_1262_24198_24225(
                                                l, f_1262_24209_24224(outputType));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 23580, 24245);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1262, 1, 666);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1262, 1, 666);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 23432, 24260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24276, 24317);

                List<PSTypeName>
                cmdletOutputType = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24331, 24489) || true) && (f_1262_24335_24400(_providerOutputType, cmdletname, out cmdletOutputType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 24331, 24489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24434, 24474);

                    f_1262_24434_24473(listToAppend, cmdletOutputType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 24331, 24489);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 23329, 24500);

                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.PSTypeName>>
                f_1262_23519_23561()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.PSTypeName>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 23519, 23561);
                    return return_v;
                }


                System.Type
                f_1262_23623_23639()
                {
                    var return_v = ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 23623, 23639);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.OutputTypeAttribute>
                f_1262_23623_23687(System.Type
                type, bool
                inherit)
                {
                    var return_v = type.GetCustomAttributes<System.Management.Automation.OutputTypeAttribute>(inherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 23623, 23687);
                    return return_v;
                }


                string
                f_1262_23754_23779(System.Management.Automation.OutputTypeAttribute
                this_param)
                {
                    var return_v = this_param.ProviderCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 23754, 23779);
                    return return_v;
                }


                bool
                f_1262_23733_23780(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 23733, 23780);
                    return return_v;
                }


                string
                f_1262_23964_23989(System.Management.Automation.OutputTypeAttribute
                this_param)
                {
                    var return_v = this_param.ProviderCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 23964, 23989);
                    return return_v;
                }


                bool
                f_1262_23932_23997(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.PSTypeName>>
                this_param, string
                key, out System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 23932, 23997);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1262_24051_24073()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 24051, 24073);
                    return return_v;
                }


                string
                f_1262_24120_24145(System.Management.Automation.OutputTypeAttribute
                this_param)
                {
                    var return_v = this_param.ProviderCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 24120, 24145);
                    return return_v;
                }


                System.Management.Automation.PSTypeName[]
                f_1262_24209_24224(System.Management.Automation.OutputTypeAttribute
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 24209, 24224);
                    return return_v;
                }


                int
                f_1262_24198_24225(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName[]
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 24198, 24225);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.OutputTypeAttribute>
                f_1262_23623_23687_I(System.Collections.Generic.IEnumerable<System.Management.Automation.OutputTypeAttribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 23623, 23687);
                    return return_v;
                }


                bool
                f_1262_24335_24400(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.PSTypeName>>
                this_param, string
                key, out System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 24335, 24400);
                    return return_v;
                }


                int
                f_1262_24434_24473(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 24434, 24473);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 23329, 24500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 23329, 24500);
            }
        }

        private Dictionary<string, List<PSTypeName>> _providerOutputType;

        private PSNoteProperty _noteProperty;

        internal PSNoteProperty GetNotePropertyForProviderCmdlets(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1262, 24636, 24983);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24731, 24935) || true) && (_noteProperty == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1262, 24731, 24935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24790, 24920);

                    f_1262_24790_24919(ref _noteProperty, f_1262_24882_24912(name, this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1262, 24731, 24935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1262, 24951, 24972);

                return _noteProperty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1262, 24636, 24983);

                System.Management.Automation.PSNoteProperty
                f_1262_24882_24912(string
                name, System.Management.Automation.ProviderInfo
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 24882, 24912);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1262_24790_24919(ref System.Management.Automation.PSNoteProperty
                location1, System.Management.Automation.PSNoteProperty
                value, System.Management.Automation.PSNoteProperty
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 24790, 24919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1262, 24636, 24983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 24636, 24983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ProviderInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1262, 694, 24990);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1262, 694, 24990);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1262, 694, 24990);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1262, 694, 24990);

        System.Management.Automation.PSArgumentNullException
        f_1262_9968_10022(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 9968, 10022);
            return return_v;
        }


        string
        f_1262_10061_10078(System.Management.Automation.ProviderInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 10061, 10078);
            return return_v;
        }


        System.Type
        f_1262_10112_10141(System.Management.Automation.ProviderInfo
        this_param)
        {
            var return_v = this_param.ImplementingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 10112, 10141);
            return return_v;
        }


        string
        f_1262_10227_10251(System.Management.Automation.ProviderInfo
        this_param)
        {
            var return_v = this_param.Description;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 10227, 10251);
            return return_v;
        }


        string
        f_1262_10328_10345(System.Management.Automation.ProviderInfo
        this_param)
        {
            var return_v = this_param.Home;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 10328, 10345);
            return return_v;
        }


        string
        f_1262_10371_10392(System.Management.Automation.ProviderInfo
        this_param)
        {
            var return_v = this_param.HelpFile;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 10371, 10392);
            return return_v;
        }


        System.Management.Automation.PSSnapInInfo
        f_1262_10418_10439(System.Management.Automation.ProviderInfo
        this_param)
        {
            var return_v = this_param.PSSnapIn;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 10418, 10439);
            return return_v;
        }


        bool
        f_1262_10536_10571(System.Management.Automation.ProviderInfo
        this_param)
        {
            var return_v = this_param.VolumeSeparatedByColon;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 10536, 10571);
            return return_v;
        }


        char
        f_1262_10602_10628(System.Management.Automation.ProviderInfo
        this_param)
        {
            var return_v = this_param.ItemSeparator;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 10602, 10628);
            return return_v;
        }


        char
        f_1262_10662_10691(System.Management.Automation.ProviderInfo
        this_param)
        {
            var return_v = this_param.AltItemSeparator;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 10662, 10691);
            return return_v;
        }


        static System.Management.Automation.SessionState
        f_1262_12004_12016_C(System.Management.Automation.SessionState
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1262, 11793, 12111);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1262_13788_13842(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 13788, 13842);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1262_13942_14000(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 13942, 14000);
            return return_v;
        }


        bool
        f_1262_14036_14062(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 14036, 14062);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1262_14102_14144(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 14102, 14144);
            return return_v;
        }


        string
        f_1262_14640_14653(System.Management.Automation.ProviderInfo
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 14640, 14653);
            return return_v;
        }


        System.Management.Automation.PSDriveInfo
        f_1262_14602_14778(string
        name, System.Management.Automation.ProviderInfo
        provider, string
        root, string
        description, System.Management.Automation.PSCredential
        credential)
        {
            var return_v = new System.Management.Automation.PSDriveInfo(name, provider, root, description, credential);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1262, 14602, 14778);
            return return_v;
        }


        bool
        f_1262_14995_15014_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1262, 14995, 15014);
            return return_v;
        }

    }
}

