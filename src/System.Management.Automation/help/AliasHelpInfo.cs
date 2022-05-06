// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis; // for fxcop

namespace System.Management.Automation
{
    internal class AliasHelpInfo : HelpInfo
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        private AliasHelpInfo(AliasInfo aliasInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1140, 671, 1867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 2019, 2073);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 2229, 2287);
                this.Synopsis = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 2666, 2681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 836, 869);

                _fullHelpObject = f_1140_854_868();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 885, 1002);

                string
                name = (DynAbs.Tracing.TraceSender.Conditional_F1(1140, 899, 934) || (((f_1140_900_925(aliasInfo) == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1140, 937, 968)) || DynAbs.Tracing.TraceSender.Conditional_F3(1140, 971, 1001))) ? f_1140_937_968(aliasInfo) : f_1140_971_1001(f_1140_971_996(aliasInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 1018, 1044);

                this.ForwardTarget = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 1119, 1288);

                this.ForwardHelpCategory = HelpCategory.Cmdlet |
                                HelpCategory.Function | HelpCategory.ExternalScript | HelpCategory.ScriptCommand | HelpCategory.Filter;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 1304, 1423) || true) && (!f_1140_1309_1345(f_1140_1330_1344(aliasInfo)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1140, 1304, 1423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 1379, 1408);

                    Name = f_1140_1386_1407(f_1140_1386_1400(aliasInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1140, 1304, 1423);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 1439, 1542) || true) && (!f_1140_1444_1470(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1140, 1439, 1542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 1504, 1527);

                    Synopsis = f_1140_1515_1526(name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1140, 1439, 1542);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 1558, 1592);

                f_1140_1558_1591(f_1140_1558_1583(_fullHelpObject));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 1606, 1739);

                f_1140_1606_1738(f_1140_1606_1631(_fullHelpObject), f_1140_1636_1737(f_1140_1650_1692(), "AliasHelpInfo#{0}", f_1140_1732_1736()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 1753, 1800);

                f_1140_1753_1799(f_1140_1753_1778(_fullHelpObject), "AliasHelpInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 1814, 1856);

                f_1140_1814_1855(f_1140_1814_1839(_fullHelpObject), "HelpInfo");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1140, 671, 1867);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1140, 671, 1867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1140, 671, 1867);
            }
        }

        internal override string Name { get; }

        internal override string Synopsis { get; }

        internal override HelpCategory HelpCategory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1140, 2549, 2626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 2585, 2611);

                    return HelpCategory.Alias;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1140, 2549, 2626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1140, 2481, 2637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1140, 2481, 2637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSObject _fullHelpObject;

        internal override PSObject FullHelp
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1140, 2915, 2989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 2951, 2974);

                    return _fullHelpObject;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1140, 2915, 2989);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1140, 2855, 3000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1140, 2855, 3000);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static AliasHelpInfo GetHelpInfo(AliasInfo aliasInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1140, 3384, 3920);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 3471, 3523) || true) && (aliasInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1140, 3471, 3523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 3511, 3523);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1140, 3471, 3523);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 3539, 3650) || true) && (f_1140_3543_3568(aliasInfo) == null && (DynAbs.Tracing.TraceSender.Expression_True(1140, 3543, 3619) && f_1140_3580_3611(aliasInfo) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1140, 3539, 3650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 3638, 3650);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1140, 3539, 3650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 3666, 3725);

                AliasHelpInfo
                aliasHelpInfo = f_1140_3696_3724(aliasInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 3741, 3816) || true) && (f_1140_3745_3785(f_1140_3766_3784(aliasHelpInfo)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1140, 3741, 3816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 3804, 3816);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1140, 3741, 3816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 3832, 3872);

                f_1140_3832_3871(
                            aliasHelpInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1140, 3888, 3909);

                return aliasHelpInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1140, 3384, 3920);

                System.Management.Automation.CommandInfo
                f_1140_3543_3568(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.ResolvedCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 3543, 3568);
                    return return_v;
                }


                string
                f_1140_3580_3611(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.UnresolvedCommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 3580, 3611);
                    return return_v;
                }


                System.Management.Automation.AliasHelpInfo
                f_1140_3696_3724(System.Management.Automation.AliasInfo
                aliasInfo)
                {
                    var return_v = new System.Management.Automation.AliasHelpInfo(aliasInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 3696, 3724);
                    return return_v;
                }


                string
                f_1140_3766_3784(System.Management.Automation.AliasHelpInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 3766, 3784);
                    return return_v;
                }


                bool
                f_1140_3745_3785(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 3745, 3785);
                    return return_v;
                }


                int
                f_1140_3832_3871(System.Management.Automation.AliasHelpInfo
                this_param)
                {
                    this_param.AddCommonHelpProperties();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 3832, 3871);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1140, 3384, 3920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1140, 3384, 3920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AliasHelpInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1140, 301, 3927);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1140, 301, 3927);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1140, 301, 3927);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1140, 301, 3927);

        System.Management.Automation.PSObject
        f_1140_854_868()
        {
            var return_v = new System.Management.Automation.PSObject();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 854, 868);
            return return_v;
        }


        System.Management.Automation.CommandInfo
        f_1140_900_925(System.Management.Automation.AliasInfo
        this_param)
        {
            var return_v = this_param.ResolvedCommand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 900, 925);
            return return_v;
        }


        string
        f_1140_937_968(System.Management.Automation.AliasInfo
        this_param)
        {
            var return_v = this_param.UnresolvedCommandName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 937, 968);
            return return_v;
        }


        System.Management.Automation.CommandInfo
        f_1140_971_996(System.Management.Automation.AliasInfo
        this_param)
        {
            var return_v = this_param.ResolvedCommand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 971, 996);
            return return_v;
        }


        string
        f_1140_971_1001(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 971, 1001);
            return return_v;
        }


        string
        f_1140_1330_1344(System.Management.Automation.AliasInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 1330, 1344);
            return return_v;
        }


        bool
        f_1140_1309_1345(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 1309, 1345);
            return return_v;
        }


        string
        f_1140_1386_1400(System.Management.Automation.AliasInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 1386, 1400);
            return return_v;
        }


        string
        f_1140_1386_1407(string
        this_param)
        {
            var return_v = this_param.Trim();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 1386, 1407);
            return return_v;
        }


        bool
        f_1140_1444_1470(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 1444, 1470);
            return return_v;
        }


        string
        f_1140_1515_1526(string
        this_param)
        {
            var return_v = this_param.Trim();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 1515, 1526);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1140_1558_1583(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.TypeNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 1558, 1583);
            return return_v;
        }


        int
        f_1140_1558_1591(System.Collections.ObjectModel.Collection<string>
        this_param)
        {
            this_param.Clear();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 1558, 1591);
            return 0;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1140_1606_1631(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.TypeNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 1606, 1631);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_1140_1650_1692()
        {
            var return_v = Globalization.CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 1650, 1692);
            return return_v;
        }


        string
        f_1140_1732_1736()
        {
            var return_v = Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 1732, 1736);
            return return_v;
        }


        string
        f_1140_1636_1737(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 1636, 1737);
            return return_v;
        }


        int
        f_1140_1606_1738(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 1606, 1738);
            return 0;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1140_1753_1778(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.TypeNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 1753, 1778);
            return return_v;
        }


        int
        f_1140_1753_1799(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 1753, 1799);
            return 0;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1140_1814_1839(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.TypeNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1140, 1814, 1839);
            return return_v;
        }


        int
        f_1140_1814_1855(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1140, 1814, 1855);
            return 0;
        }

    }
}
