// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// this file contains the data structures for the in memory database
// containing display and formatting information

using System.Collections.Generic;
using Microsoft.PowerShell.Commands;
using Microsoft.PowerShell.Commands.Internal.Format;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class ComplexControlBody : ControlBody
    {
        internal ComplexControlEntryDefinition defaultEntry;

        internal List<ComplexControlEntryDefinition> optionalEntryList;

        public ComplexControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 544, 1065);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 773, 785);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 996, 1057);
            this.optionalEntryList = f_1120_1016_1057();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 544, 1065);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 544, 1065);
        }


        static ComplexControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 544, 1065);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 544, 1065);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 544, 1065);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 544, 1065);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition>
        f_1120_1016_1057()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 1016, 1057);
            return return_v;
        }

    }
    internal sealed class ComplexControlEntryDefinition
    {
        internal AppliesTo appliesTo;

        internal ComplexControlItemDefinition itemDefinition;

        public ComplexControlEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 1073, 1526);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 1296, 1312);
            this.appliesTo = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 1467, 1518);
            this.itemDefinition = f_1120_1484_1518();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 1073, 1526);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 1073, 1526);
        }


        static ComplexControlEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 1073, 1526);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 1073, 1526);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 1073, 1526);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 1073, 1526);

        Microsoft.PowerShell.Commands.Internal.Format.ComplexControlItemDefinition
        f_1120_1484_1518()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexControlItemDefinition();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 1484, 1518);
            return return_v;
        }

    }
    internal sealed class ComplexControlItemDefinition
    {
        internal List<FormatToken> formatTokenList;

        public ComplexControlItemDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 1534, 1774);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 1725, 1766);
            this.formatTokenList = f_1120_1743_1766();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 1534, 1774);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 1534, 1774);
        }


        static ComplexControlItemDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 1534, 1774);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 1534, 1774);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 1534, 1774);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 1534, 1774);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
        f_1120_1743_1766()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 1743, 1766);
            return return_v;
        }

    }

}

namespace System.Management.Automation
{
    public sealed class CustomControl : PSControl
    {
        public List<CustomControlEntry> Entries { get; set; }

        internal ComplexControlBody _cachedBody;

        internal CustomControl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 2069, 2170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 1952, 2005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2045, 2056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2118, 2159);

                Entries = f_1120_2128_2158();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 2069, 2170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 2069, 2170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 2069, 2170);
            }
        }

        internal CustomControl(ComplexControlBody body, ViewDefinition viewDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 2182, 2910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 1952, 2005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2045, 2056);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2348, 2533) || true) && (viewDefinition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 2348, 2533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2408, 2445);

                    OutOfBand = viewDefinition.outOfBand;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2463, 2518);

                    GroupBy = f_1120_2473_2517(viewDefinition.groupBy);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 2348, 2533);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2549, 2590);

                Entries = f_1120_2559_2589();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2636, 2688);

                var
                cce = f_1120_2646_2687(body.defaultEntry)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2702, 2719);

                f_1120_2702_2718(f_1120_2702_2709(), cce);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2735, 2899);
                    foreach (var entry in f_1120_2757_2779_I(body.optionalEntryList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 2735, 2899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2813, 2849);

                        cce = f_1120_2819_2848(entry);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 2867, 2884);

                        f_1120_2867_2883(f_1120_2867_2874(), cce);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 2735, 2899);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1120, 1, 165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1120, 1, 165);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 2182, 2910);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 2182, 2910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 2182, 2910);
            }
        }

        public static CustomControlBuilder Create(bool outOfBand = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1120, 2946, 3172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3036, 3100);

                var
                customControl = new CustomControl { OutOfBand = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => outOfBand, 1120, 3056, 3099) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3114, 3161);

                return f_1120_3121_3160(customControl);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1120, 2946, 3172);

                System.Management.Automation.CustomControlBuilder
                f_1120_3121_3160(System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.CustomControlBuilder(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 3121, 3160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 2946, 3172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 2946, 3172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void WriteToXml(FormatXmlWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 3184, 3309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3266, 3298);

                f_1120_3266_3297(writer, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 3184, 3309);

                int
                f_1120_3266_3297(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    this_param.WriteCustomControl(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 3266, 3297);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 3184, 3309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 3184, 3309);
            }
        }

        internal override bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 3321, 3636);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3384, 3441) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SafeForExport(), 1120, 3389, 3409))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 3384, 3441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3428, 3441);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 3384, 3441);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3457, 3597);
                    foreach (var entry in f_1120_3479_3486_I(f_1120_3479_3486()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 3457, 3597);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3520, 3582) || true) && (!f_1120_3525_3546(entry))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 3520, 3582);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3569, 3582);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 3520, 3582);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 3457, 3597);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1120, 1, 141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1120, 1, 141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3613, 3625);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 3321, 3636);

                System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                f_1120_3479_3486()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 3479, 3486);
                    return return_v;
                }


                bool
                f_1120_3525_3546(System.Management.Automation.CustomControlEntry
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 3525, 3546);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                f_1120_3479_3486_I(System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 3479, 3486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 3321, 3636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 3321, 3636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool CompatibleWithOldPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 3648, 3826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3802, 3815);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 3648, 3826);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 3648, 3826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 3648, 3826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomControl()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 1866, 3833);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 1866, 3833);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 1866, 3833);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 1866, 3833);

        System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
        f_1120_2128_2158()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 2128, 2158);
            return return_v;
        }


        System.Management.Automation.PSControlGroupBy
        f_1120_2473_2517(Microsoft.PowerShell.Commands.Internal.Format.GroupBy
        groupBy)
        {
            var return_v = PSControlGroupBy.Get(groupBy);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 2473, 2517);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
        f_1120_2559_2589()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 2559, 2589);
            return return_v;
        }


        System.Management.Automation.CustomControlEntry
        f_1120_2646_2687(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
        entry)
        {
            var return_v = new System.Management.Automation.CustomControlEntry(entry);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 2646, 2687);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
        f_1120_2702_2709()
        {
            var return_v = Entries;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 2702, 2709);
            return return_v;
        }


        int
        f_1120_2702_2718(System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
        this_param, System.Management.Automation.CustomControlEntry
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 2702, 2718);
            return 0;
        }


        System.Management.Automation.CustomControlEntry
        f_1120_2819_2848(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
        entry)
        {
            var return_v = new System.Management.Automation.CustomControlEntry(entry);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 2819, 2848);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
        f_1120_2867_2874()
        {
            var return_v = Entries;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 2867, 2874);
            return return_v;
        }


        int
        f_1120_2867_2883(System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
        this_param, System.Management.Automation.CustomControlEntry
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 2867, 2883);
            return 0;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition>
        f_1120_2757_2779_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 2757, 2779);
            return return_v;
        }

    }
    public sealed class CustomControlEntry
    {
        internal CustomControlEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 3916, 4022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4530, 4577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4613, 4666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 3970, 4011);

                CustomItems = f_1120_3984_4010();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 3916, 4022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 3916, 4022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 3916, 4022);
            }
        }

        internal CustomControlEntry(ComplexControlEntryDefinition entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 4034, 4494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4530, 4577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4613, 4666);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4123, 4263) || true) && (entry.appliesTo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 4123, 4263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4184, 4248);

                    SelectedBy = f_1120_4197_4247(entry.appliesTo.referenceList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 4123, 4263);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4279, 4320);

                CustomItems = f_1120_4293_4319();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4334, 4483);
                    foreach (var tok in f_1120_4354_4390_I(entry.itemDefinition.formatTokenList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 4334, 4483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4424, 4468);

                        f_1120_4424_4467(f_1120_4424_4435(), f_1120_4440_4466(tok));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 4334, 4483);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1120, 1, 150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1120, 1, 150);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 4034, 4494);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 4034, 4494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 4034, 4494);
            }
        }

        public EntrySelectedBy SelectedBy { get; set; }

        public List<CustomItemBase> CustomItems { get; set; }

        internal bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 4678, 4957);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4732, 4874);
                    foreach (var item in f_1120_4753_4764_I(f_1120_4753_4764()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 4732, 4874);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4798, 4859) || true) && (!f_1120_4803_4823(item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 4798, 4859);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4846, 4859);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 4798, 4859);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 4732, 4874);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1120, 1, 143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1120, 1, 143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 4890, 4946);

                return f_1120_4897_4907() == null || (DynAbs.Tracing.TraceSender.Expression_False(1120, 4897, 4945) || f_1120_4919_4945(f_1120_4919_4929()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 4678, 4957);

                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_4753_4764()
                {
                    var return_v = CustomItems;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 4753, 4764);
                    return return_v;
                }


                bool
                f_1120_4803_4823(System.Management.Automation.CustomItemBase
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 4803, 4823);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_4753_4764_I(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 4753, 4764);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1120_4897_4907()
                {
                    var return_v = SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 4897, 4907);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1120_4919_4929()
                {
                    var return_v = SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 4919, 4929);
                    return return_v;
                }


                bool
                f_1120_4919_4945(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 4919, 4945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 4678, 4957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 4678, 4957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomControlEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 3861, 4964);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 3861, 4964);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 3861, 4964);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 3861, 4964);

        System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
        f_1120_3984_4010()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.CustomItemBase>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 3984, 4010);
            return return_v;
        }


        System.Management.Automation.EntrySelectedBy
        f_1120_4197_4247(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
        references)
        {
            var return_v = EntrySelectedBy.Get(references);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 4197, 4247);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
        f_1120_4293_4319()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.CustomItemBase>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 4293, 4319);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
        f_1120_4424_4435()
        {
            var return_v = CustomItems;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 4424, 4435);
            return return_v;
        }


        System.Management.Automation.CustomItemBase
        f_1120_4440_4466(Microsoft.PowerShell.Commands.Internal.Format.FormatToken
        token)
        {
            var return_v = CustomItemBase.Create(token);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 4440, 4466);
            return return_v;
        }


        int
        f_1120_4424_4467(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
        this_param, System.Management.Automation.CustomItemBase
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 4424, 4467);
            return 0;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
        f_1120_4354_4390_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 4354, 4390);
            return return_v;
        }

    }
    public abstract class CustomItemBase
    {
        internal virtual bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 5045, 5130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5107, 5119);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 5045, 5130);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 5045, 5130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 5045, 5130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CustomItemBase Create(FormatToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1120, 5142, 7514);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5223, 5328) || true) && (token is NewLineToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 5223, 5328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5282, 5313);

                    return f_1120_5289_5312();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 5223, 5328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5344, 5379);

                var
                textToken = token as TextToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5393, 5515) || true) && (textToken != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 5393, 5515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5448, 5500);

                    return new CustomItemText { Text = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => textToken.text, 1120, 5455, 5499) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 5393, 5515);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5531, 5568);

                var
                frameToken = token as FrameToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5582, 6501) || true) && (frameToken != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 5582, 6501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5638, 5885);

                    var
                    frame = new CustomItemFrame
                    {
                        RightIndent = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (uint)frameToken.frameInfoDefinition.rightIndentation, 1120, 5650, 5884),
                        LeftIndent = (uint)frameToken.frameInfoDefinition.leftIndentation
                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5903, 5960);

                    var
                    firstLine = frameToken.frameInfoDefinition.firstLine
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 5978, 6239) || true) && (firstLine > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 5978, 6239);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6037, 6077);

                        frame.FirstLineIndent = (uint)firstLine;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 5978, 6239);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 5978, 6239);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6119, 6239) || true) && (firstLine < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 6119, 6239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6178, 6220);

                            frame.FirstLineHanging = (uint)-firstLine;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 6119, 6239);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 5978, 6239);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6259, 6453);
                        foreach (var frameItemToken in f_1120_6290_6331_I(frameToken.itemDefinition.formatTokenList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 6259, 6453);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6373, 6434);

                            f_1120_6373_6433(f_1120_6373_6390(frame), f_1120_6395_6432(frameItemToken));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 6259, 6453);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1120, 1, 195);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1120, 1, 195);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6473, 6486);

                    return frame;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 5582, 6501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6517, 6558);

                var
                cpt = token as CompoundPropertyToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6572, 7283) || true) && (cpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 6572, 7283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6621, 6706);

                    var
                    cie = new CustomItemExpression { EnumerateCollection = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => cpt.enumerateCollection, 1120, 6631, 6705) }
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6726, 6883) || true) && (cpt.conditionToken != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 6726, 6883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6798, 6864);

                        cie.ItemSelectionCondition = f_1120_6827_6863(cpt.conditionToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 6726, 6883);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6903, 7056) || true) && (cpt.expression.expressionValue != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 6903, 7056);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 6987, 7037);

                        cie.Expression = f_1120_7004_7036(cpt.expression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 6903, 7056);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7076, 7237) || true) && (cpt.control != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 7076, 7237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7141, 7218);

                        cie.CustomControl = f_1120_7161_7217((ComplexControlBody)cpt.control, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 7076, 7237);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7257, 7268);

                    return cie;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 6572, 7283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7299, 7337);

                var
                fpt = token as FieldPropertyToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7351, 7397) || true) && (fpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 7351, 7397);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 7351, 7397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7413, 7475);

                f_1120_7413_7474(false, "Unexpected formatting token kind");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7491, 7503);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1120, 5142, 7514);

                System.Management.Automation.CustomItemNewline
                f_1120_5289_5312()
                {
                    var return_v = new System.Management.Automation.CustomItemNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 5289, 5312);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_6373_6390(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.CustomItems;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 6373, 6390);
                    return return_v;
                }


                System.Management.Automation.CustomItemBase
                f_1120_6395_6432(Microsoft.PowerShell.Commands.Internal.Format.FormatToken
                token)
                {
                    var return_v = CustomItemBase.Create(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 6395, 6432);
                    return return_v;
                }


                int
                f_1120_6373_6433(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                this_param, System.Management.Automation.CustomItemBase
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 6373, 6433);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                f_1120_6290_6331_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 6290, 6331);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1120_6827_6863(Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                expression)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 6827, 6863);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1120_7004_7036(Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                expression)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 7004, 7036);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1120_7161_7217(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                body, Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                viewDefinition)
                {
                    var return_v = new System.Management.Automation.CustomControl((Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody)body, viewDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 7161, 7217);
                    return return_v;
                }


                int
                f_1120_7413_7474(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 7413, 7474);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 5142, 7514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 5142, 7514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomItemBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 4992, 7521);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 4992, 7521);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 4992, 7521);
        }


        static CustomItemBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 4992, 7521);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 4992, 7521);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 4992, 7521);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 4992, 7521);
    }
    public sealed class CustomItemExpression : CustomItemBase
    {
        internal CustomItemExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 7623, 7658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7694, 7750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7786, 7830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7866, 7911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 7947, 7995);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 7623, 7658);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 7623, 7658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 7623, 7658);
            }
        }

        public DisplayEntry ItemSelectionCondition { get; set; }

        public DisplayEntry Expression { get; set; }

        public bool EnumerateCollection { get; set; }

        public CustomControl CustomControl { get; set; }

        internal override bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 8007, 8317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 8070, 8306);

                return (f_1120_8078_8100() == null || (DynAbs.Tracing.TraceSender.Expression_False(1120, 8078, 8150) || f_1120_8112_8150(f_1120_8112_8134()))) && (DynAbs.Tracing.TraceSender.Expression_True(1120, 8077, 8225) && (f_1120_8176_8186() == null || (DynAbs.Tracing.TraceSender.Expression_False(1120, 8176, 8224) || f_1120_8198_8224(f_1120_8198_8208())))) && (DynAbs.Tracing.TraceSender.Expression_True(1120, 8077, 8305) && (f_1120_8250_8263() == null || (DynAbs.Tracing.TraceSender.Expression_False(1120, 8250, 8304) || f_1120_8275_8304(f_1120_8275_8288()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 8007, 8317);

                System.Management.Automation.DisplayEntry
                f_1120_8078_8100()
                {
                    var return_v = ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 8078, 8100);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1120_8112_8134()
                {
                    var return_v = ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 8112, 8134);
                    return return_v;
                }


                bool
                f_1120_8112_8150(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 8112, 8150);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1120_8176_8186()
                {
                    var return_v = Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 8176, 8186);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1120_8198_8208()
                {
                    var return_v = Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 8198, 8208);
                    return return_v;
                }


                bool
                f_1120_8198_8224(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 8198, 8224);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1120_8250_8263()
                {
                    var return_v = CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 8250, 8263);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1120_8275_8288()
                {
                    var return_v = CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 8275, 8288);
                    return return_v;
                }


                bool
                f_1120_8275_8304(System.Management.Automation.CustomControl
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 8275, 8304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 8007, 8317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 8007, 8317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomItemExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 7549, 8324);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 7549, 8324);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 7549, 8324);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 7549, 8324);
    }
    public sealed class CustomItemFrame : CustomItemBase
    {
        public uint LeftIndent { get; set; }

        public uint RightIndent { get; set; }

        public uint FirstLineHanging { get; set; }

        public uint FirstLineIndent { get; set; }

        internal CustomItemFrame()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 8715, 8818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 8445, 8481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 8515, 8552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 8586, 8628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 8662, 8703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 8854, 8907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 8766, 8807);

                CustomItems = f_1120_8780_8806();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 8715, 8818);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 8715, 8818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 8715, 8818);
            }
        }

        public List<CustomItemBase> CustomItems { get; set; }

        internal override bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 8919, 9173);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 8982, 9134);
                    foreach (var frameItem in f_1120_9008_9019_I(f_1120_9008_9019()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 8982, 9134);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 9053, 9119) || true) && (!f_1120_9058_9083(frameItem))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 9053, 9119);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 9106, 9119);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 9053, 9119);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 8982, 9134);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1120, 1, 153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1120, 1, 153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 9150, 9162);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 8919, 9173);

                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_9008_9019()
                {
                    var return_v = CustomItems;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 9008, 9019);
                    return return_v;
                }


                bool
                f_1120_9058_9083(System.Management.Automation.CustomItemBase
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 9058, 9083);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_9008_9019_I(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 9008, 9019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 8919, 9173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 8919, 9173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomItemFrame()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 8352, 9180);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 8352, 9180);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 8352, 9180);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 8352, 9180);

        System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
        f_1120_8780_8806()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.CustomItemBase>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 8780, 8806);
            return return_v;
        }

    }
    public sealed class CustomItemNewline : CustomItemBase
    {
        public CustomItemNewline()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 9303, 9380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 9414, 9444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 9354, 9369);

                this.Count = 1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 9303, 9380);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 9303, 9380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 9303, 9380);
            }
        }

        public int Count { get; set; }

        static CustomItemNewline()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 9208, 9451);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 9208, 9451);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 9208, 9451);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 9208, 9451);
    }
    public sealed class CustomItemText : CustomItemBase
    {
        public string Text { get; set; }

        public CustomItemText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 9479, 9610);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 9571, 9603);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 9479, 9610);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 9479, 9610);
        }


        static CustomItemText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 9479, 9610);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 9479, 9610);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 9479, 9610);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 9479, 9610);
    }
    public sealed class CustomEntryBuilder
    {
        private readonly Stack<List<CustomItemBase>> _entryStack;

        private readonly CustomControlBuilder _controlBuilder;

        internal CustomEntryBuilder(CustomControlBuilder controlBuilder, CustomControlEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 9826, 10097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 9738, 9749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 9798, 9813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 9941, 9989);

                _entryStack = f_1120_9955_9988();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 10003, 10039);

                f_1120_10003_10038(_entryStack, f_1120_10020_10037(entry));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 10053, 10086);

                _controlBuilder = controlBuilder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 9826, 10097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 9826, 10097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 9826, 10097);
            }
        }

        public CustomEntryBuilder AddNewline(int count = 1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 10133, 10310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 10209, 10273);

                f_1120_10209_10272(f_1120_10209_10227(_entryStack), new CustomItemNewline { Count = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => count, 1120, 10232, 10271) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 10287, 10299);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 10133, 10310);

                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_10209_10227(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 10209, 10227);
                    return return_v;
                }


                int
                f_1120_10209_10272(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                this_param, System.Management.Automation.CustomItemNewline
                item)
                {
                    this_param.Add((System.Management.Automation.CustomItemBase)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 10209, 10272);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 10133, 10310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 10133, 10310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomEntryBuilder AddText(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 10346, 10513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 10417, 10476);

                f_1120_10417_10475(f_1120_10417_10435(_entryStack), new CustomItemText { Text = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => text, 1120, 10440, 10474) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 10490, 10502);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 10346, 10513);

                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_10417_10435(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 10417, 10435);
                    return return_v;
                }


                int
                f_1120_10417_10475(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                this_param, System.Management.Automation.CustomItemText
                item)
                {
                    this_param.Add((System.Management.Automation.CustomItemBase)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 10417, 10475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 10346, 10513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 10346, 10513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddDisplayExpressionBinding(
                    string value,
                    DisplayEntryValueType valueType,
                    bool enumerateCollection = false,
                    string selectedByType = null,
                    string selectedByScript = null,
                    CustomControl customControl = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 10525, 11444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 10848, 11433);

                f_1120_10848_11432(f_1120_10848_10866(_entryStack), new CustomItemExpression()
                {
                    ItemSelectionCondition = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (DynAbs.Tracing.TraceSender.Conditional_F1(1120, 10955, 10979) || ((selectedByScript != null
    && DynAbs.Tracing.TraceSender.Conditional_F2(1120, 11003, 11072)) || DynAbs.Tracing.TraceSender.Conditional_F3(1120, 11096, 11242))) ? f_1120_11003_11072(selectedByScript, DisplayEntryValueType.ScriptBlock) : (DynAbs.Tracing.TraceSender.Conditional_F1(1120, 11096, 11118) || ((selectedByType != null
    && DynAbs.Tracing.TraceSender.Conditional_F2(1120, 11146, 11210)) || DynAbs.Tracing.TraceSender.Conditional_F3(1120, 11238, 11242))) ? f_1120_11146_11210(selectedByType, DisplayEntryValueType.Property) : null, 1120, 10871, 11431),
                    EnumerateCollection = enumerateCollection,
                    Expression = f_1120_11334_11368(value, valueType),
                    CustomControl = customControl
                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 10525, 11444);

                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_10848_10866(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 10848, 10866);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1120_11003_11072(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 11003, 11072);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1120_11146_11210(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 11146, 11210);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1120_11334_11368(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 11334, 11368);
                    return return_v;
                }


                int
                f_1120_10848_11432(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                this_param, System.Management.Automation.CustomItemExpression
                item)
                {
                    this_param.Add((System.Management.Automation.CustomItemBase)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 10848, 11432);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 10525, 11444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 10525, 11444);
            }
        }

        public CustomEntryBuilder AddPropertyExpressionBinding(
                    string property,
                    bool enumerateCollection = false,
                    string selectedByType = null,
                    string selectedByScript = null,
                    CustomControl customControl = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 11480, 11951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 11774, 11914);

                f_1120_11774_11913(this, property, DisplayEntryValueType.Property, enumerateCollection, selectedByType, selectedByScript, customControl);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 11928, 11940);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 11480, 11951);

                int
                f_1120_11774_11913(System.Management.Automation.CustomEntryBuilder
                this_param, string
                value, System.Management.Automation.DisplayEntryValueType
                valueType, bool
                enumerateCollection, string
                selectedByType, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    this_param.AddDisplayExpressionBinding(value, valueType, enumerateCollection, selectedByType, selectedByScript, customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 11774, 11913);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 11480, 11951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 11480, 11951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomEntryBuilder AddScriptBlockExpressionBinding(
                    string scriptBlock,
                    bool enumerateCollection = false,
                    string selectedByType = null,
                    string selectedByScript = null,
                    CustomControl customControl = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 11987, 12470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 12287, 12433);

                f_1120_12287_12432(this, scriptBlock, DisplayEntryValueType.ScriptBlock, enumerateCollection, selectedByType, selectedByScript, customControl);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 12447, 12459);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 11987, 12470);

                int
                f_1120_12287_12432(System.Management.Automation.CustomEntryBuilder
                this_param, string
                value, System.Management.Automation.DisplayEntryValueType
                valueType, bool
                enumerateCollection, string
                selectedByType, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    this_param.AddDisplayExpressionBinding(value, valueType, enumerateCollection, selectedByType, selectedByScript, customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 12287, 12432);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 11987, 12470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 11987, 12470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomEntryBuilder AddCustomControlExpressionBinding(
                    CustomControl customControl,
                    bool enumerateCollection = false,
                    string selectedByType = null,
                    string selectedByScript = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 12506, 13326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 12768, 13287);

                f_1120_12768_13286(f_1120_12768_12786(_entryStack), new CustomItemExpression()
                {
                    ItemSelectionCondition = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (DynAbs.Tracing.TraceSender.Conditional_F1(1120, 12875, 12899) || ((selectedByScript != null
    && DynAbs.Tracing.TraceSender.Conditional_F2(1120, 12923, 12992)) || DynAbs.Tracing.TraceSender.Conditional_F3(1120, 13016, 13162))) ? f_1120_12923_12992(selectedByScript, DisplayEntryValueType.ScriptBlock) : (DynAbs.Tracing.TraceSender.Conditional_F1(1120, 13016, 13038) || ((selectedByType != null
    && DynAbs.Tracing.TraceSender.Conditional_F2(1120, 13066, 13130)) || DynAbs.Tracing.TraceSender.Conditional_F3(1120, 13158, 13162))) ? f_1120_13066_13130(selectedByType, DisplayEntryValueType.Property) : null, 1120, 12791, 13285),
                    EnumerateCollection = enumerateCollection,
                    CustomControl = customControl
                });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 13303, 13315);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 12506, 13326);

                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_12768_12786(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 12768, 12786);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1120_12923_12992(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 12923, 12992);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1120_13066_13130(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 13066, 13130);
                    return return_v;
                }


                int
                f_1120_12768_13286(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                this_param, System.Management.Automation.CustomItemExpression
                item)
                {
                    this_param.Add((System.Management.Automation.CustomItemBase)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 12768, 13286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 12506, 13326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 12506, 13326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomEntryBuilder StartFrame(uint leftIndent = 0, uint rightIndent = 0, uint firstLineHanging = 0, uint firstLineIndent = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 13362, 14307);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 13554, 13697) || true) && (leftIndent != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1120, 13558, 13593) && rightIndent != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 13554, 13697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 13627, 13682);

                    throw f_1120_13633_13681("leftIndent");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 13554, 13697);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 13748, 13907) || true) && (firstLineHanging != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1120, 13752, 13797) && firstLineIndent != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 13748, 13907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 13831, 13892);

                    throw f_1120_13837_13891("firstLineHanging");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 13748, 13907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 13923, 14176);

                var
                frame = new CustomItemFrame
                {
                    LeftIndent = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => leftIndent, 1120, 13935, 14175),
                    RightIndent = rightIndent,
                    FirstLineHanging = firstLineHanging,
                    FirstLineIndent = firstLineIndent
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14190, 14220);

                f_1120_14190_14219(f_1120_14190_14208(_entryStack), frame);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14234, 14270);

                f_1120_14234_14269(_entryStack, f_1120_14251_14268(frame));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14284, 14296);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 13362, 14307);

                System.Management.Automation.PSArgumentException
                f_1120_13633_13681(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 13633, 13681);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1120_13837_13891(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 13837, 13891);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_14190_14208(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 14190, 14208);
                    return return_v;
                }


                int
                f_1120_14190_14219(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                this_param, System.Management.Automation.CustomItemFrame
                item)
                {
                    this_param.Add((System.Management.Automation.CustomItemBase)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 14190, 14219);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_14251_14268(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.CustomItems;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 14251, 14268);
                    return return_v;
                }


                int
                f_1120_14234_14269(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
                this_param, System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 14234, 14269);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 13362, 14307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 13362, 14307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomEntryBuilder EndFrame()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 14343, 14600);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14404, 14529) || true) && (f_1120_14408_14425(_entryStack) < 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 14404, 14529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14463, 14514);

                    throw f_1120_14469_14513();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 14404, 14529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14545, 14563);

                f_1120_14545_14562(
                            _entryStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14577, 14589);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 14343, 14600);

                int
                f_1120_14408_14425(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 14408, 14425);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1120_14469_14513()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 14469, 14513);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_14545_14562(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 14545, 14562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 14343, 14600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 14343, 14600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomControlBuilder EndEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 14636, 14907);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14699, 14825) || true) && (f_1120_14703_14720(_entryStack) != 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1120, 14699, 14825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14759, 14810);

                    throw f_1120_14765_14809();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1120, 14699, 14825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14841, 14859);

                f_1120_14841_14858(
                            _entryStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 14873, 14896);

                return _controlBuilder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 14636, 14907);

                int
                f_1120_14703_14720(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 14703, 14720);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1120_14765_14809()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 14765, 14809);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1120_14841_14858(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 14841, 14858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 14636, 14907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 14636, 14907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomEntryBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 9638, 14914);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 9638, 14914);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 9638, 14914);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 9638, 14914);

        System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
        f_1120_9955_9988()
        {
            var return_v = new System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 9955, 9988);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
        f_1120_10020_10037(System.Management.Automation.CustomControlEntry
        this_param)
        {
            var return_v = this_param.CustomItems;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 10020, 10037);
            return return_v;
        }


        int
        f_1120_10003_10038(System.Collections.Generic.Stack<System.Collections.Generic.List<System.Management.Automation.CustomItemBase>>
        this_param, System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
        item)
        {
            this_param.Push(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 10003, 10038);
            return 0;
        }

    }
    public sealed class CustomControlBuilder
    {
        internal CustomControl _control;

        internal CustomControlBuilder(CustomControl control)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1120, 15043, 15150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 15022, 15030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 15120, 15139);

                _control = control;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1120, 15043, 15150);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 15043, 15150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 15043, 15150);
            }
        }

        public CustomControlBuilder GroupByProperty(string property, CustomControl customControl = null, string label = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 15255, 15673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 15397, 15636);

                _control.GroupBy = new PSControlGroupBy
                {
                    Expression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1120_15482_15540(property, DisplayEntryValueType.Property), 1120, 15416, 15635),
                    CustomControl = customControl,
                    Label = label
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 15650, 15662);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 15255, 15673);

                System.Management.Automation.DisplayEntry
                f_1120_15482_15540(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 15482, 15540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 15255, 15673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 15255, 15673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomControlBuilder GroupByScriptBlock(string scriptBlock, CustomControl customControl = null, string label = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 15788, 16218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 15936, 16181);

                _control.GroupBy = new PSControlGroupBy
                {
                    Expression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1120_16021_16085(scriptBlock, DisplayEntryValueType.ScriptBlock), 1120, 15955, 16180),
                    CustomControl = customControl,
                    Label = label
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 16195, 16207);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 15788, 16218);

                System.Management.Automation.DisplayEntry
                f_1120_16021_16085(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 16021, 16085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 15788, 16218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 15788, 16218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomEntryBuilder StartEntry(IEnumerable<string> entrySelectedByType = null, IEnumerable<DisplayEntry> entrySelectedByCondition = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 16254, 16694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 16422, 16584);

                var
                entry = new CustomControlEntry
                {
                    SelectedBy = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1120_16502_16568(entrySelectedByType, entrySelectedByCondition), 1120, 16434, 16583)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 16598, 16626);

                f_1120_16598_16625(f_1120_16598_16614(_control), entry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 16640, 16683);

                return f_1120_16647_16682(this, entry);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 16254, 16694);

                System.Management.Automation.EntrySelectedBy
                f_1120_16502_16568(System.Collections.Generic.IEnumerable<string>
                entrySelectedByType, System.Collections.Generic.IEnumerable<System.Management.Automation.DisplayEntry>
                entrySelectedByCondition)
                {
                    var return_v = EntrySelectedBy.Get(entrySelectedByType, entrySelectedByCondition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 16502, 16568);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                f_1120_16598_16614(System.Management.Automation.CustomControl
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1120, 16598, 16614);
                    return return_v;
                }


                int
                f_1120_16598_16625(System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                this_param, System.Management.Automation.CustomControlEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 16598, 16625);
                    return 0;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1120_16647_16682(System.Management.Automation.CustomControlBuilder
                controlBuilder, System.Management.Automation.CustomControlEntry
                entry)
                {
                    var return_v = new System.Management.Automation.CustomEntryBuilder(controlBuilder, entry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1120, 16647, 16682);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 16254, 16694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 16254, 16694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomControl EndControl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1120, 16730, 16815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1120, 16788, 16804);

                return _control;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1120, 16730, 16815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1120, 16730, 16815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 16730, 16815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomControlBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1120, 14942, 16822);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1120, 14942, 16822);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1120, 14942, 16822);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1120, 14942, 16822);
    }
}
