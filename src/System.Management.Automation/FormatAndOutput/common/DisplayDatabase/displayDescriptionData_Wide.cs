// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// this file contains the data structures for the in memory database
// containing display and formatting information

using System.Collections.Generic;
using Microsoft.PowerShell.Commands;
using Microsoft.PowerShell.Commands.Internal.Format;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class WideControlBody : ControlBody
    {
        internal int columns;

        internal WideControlEntryDefinition defaultEntryDefinition;

        internal List<WideControlEntryDefinition> optionalEntryList;

        public WideControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 538, 1204);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 722, 733);
            this.columns = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 901, 930);
            this.defaultEntryDefinition = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 1138, 1196);
            this.optionalEntryList = f_1124_1158_1196();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 538, 1204);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 538, 1204);
        }


        static WideControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1124, 538, 1204);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1124, 538, 1204);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 538, 1204);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1124, 538, 1204);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition>
        f_1124_1158_1196()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 1158, 1196);
            return return_v;
        }

    }
    internal sealed class WideControlEntryDefinition
    {
        internal AppliesTo appliesTo;

        internal List<FormatToken> formatTokenList;

        public WideControlEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 1316, 1912);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 1536, 1552);
            this.appliesTo = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 1863, 1904);
            this.formatTokenList = f_1124_1881_1904();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 1316, 1912);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 1316, 1912);
        }


        static WideControlEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1124, 1316, 1912);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1124, 1316, 1912);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 1316, 1912);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1124, 1316, 1912);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
        f_1124_1881_1904()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 1881, 1904);
            return return_v;
        }

    }

}

namespace System.Management.Automation
{
    public sealed class WideControl : PSControl
    {
        public List<WideControlEntryItem> Entries { get; internal set; }

        public bool AutoSize { get; set; }

        public uint Columns { get; internal set; }

        public static WideControlBuilder Create(bool outOfBand = false, bool autoSize = false, uint columns = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1124, 2581, 2866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 2710, 2802);

                var
                control = new WideControl { OutOfBand = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 1124, 2724, 2801), AutoSize = autoSize, Columns = columns }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 2816, 2855);

                return f_1124_2823_2854(control);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1124, 2581, 2866);

                System.Management.Automation.WideControlBuilder
                f_1124_2823_2854(System.Management.Automation.WideControl
                control)
                {
                    var return_v = new System.Management.Automation.WideControlBuilder(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 2823, 2854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 2581, 2866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 2581, 2866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void WriteToXml(FormatXmlWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 2878, 3001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 2960, 2990);

                f_1124_2960_2989(writer, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 2878, 3001);

                int
                f_1124_2960_2989(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.WideControl
                wideControl)
                {
                    this_param.WriteWideControl(wideControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 2960, 2989);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 2878, 3001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 2878, 3001);
            }
        }

        internal override bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 3236, 3551);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3299, 3356) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SafeForExport(), 1124, 3304, 3324))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 3299, 3356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3343, 3356);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 3299, 3356);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3372, 3512);
                    foreach (var entry in f_1124_3394_3401_I(f_1124_3394_3401()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 3372, 3512);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3435, 3497) || true) && (!f_1124_3440_3461(entry))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 3435, 3497);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3484, 3497);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 3435, 3497);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 3372, 3512);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1124, 1, 141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1124, 1, 141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3528, 3540);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 3236, 3551);

                System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                f_1124_3394_3401()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 3394, 3401);
                    return return_v;
                }


                bool
                f_1124_3440_3461(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 3440, 3461);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                f_1124_3394_3401_I(System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 3394, 3401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 3236, 3551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 3236, 3551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool CompatibleWithOldPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 3563, 3920);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3640, 3711) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CompatibleWithOldPowerShell(), 1124, 3645, 3679))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 3640, 3711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3698, 3711);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 3640, 3711);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3727, 3881);
                    foreach (var entry in f_1124_3749_3756_I(f_1124_3749_3756()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 3727, 3881);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3790, 3866) || true) && (!f_1124_3795_3830(entry))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 3790, 3866);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3853, 3866);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 3790, 3866);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 3727, 3881);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1124, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1124, 1, 155);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 3897, 3909);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 3563, 3920);

                System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                f_1124_3749_3756()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 3749, 3756);
                    return return_v;
                }


                bool
                f_1124_3795_3830(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.CompatibleWithOldPowerShell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 3795, 3830);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                f_1124_3749_3756_I(System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 3749, 3756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 3563, 3920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 3563, 3920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WideControl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 4000, 4099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 2177, 2241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 2355, 2389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 2466, 2508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 4045, 4088);

                Entries = f_1124_4055_4087();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 4000, 4099);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 4000, 4099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 4000, 4099);
            }
        }

        internal WideControl(WideControlBody widecontrolbody, ViewDefinition viewDefinition) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 4111, 4787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 4229, 4266);

                OutOfBand = viewDefinition.outOfBand;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 4280, 4335);

                GroupBy = f_1124_4290_4334(viewDefinition.groupBy);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 4351, 4430);

                AutoSize = f_1124_4362_4395(widecontrolbody.autosize) && (DynAbs.Tracing.TraceSender.Expression_True(1124, 4362, 4429) && f_1124_4399_4429(widecontrolbody.autosize));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 4444, 4484);

                Columns = (uint)widecontrolbody.columns;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 4500, 4578);

                f_1124_4500_4577(f_1124_4500_4507(), f_1124_4512_4576(widecontrolbody.defaultEntryDefinition));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 4594, 4776);
                    foreach (WideControlEntryDefinition definition in f_1124_4644_4677_I(widecontrolbody.optionalEntryList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 4594, 4776);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 4711, 4761);

                        f_1124_4711_4760(f_1124_4711_4718(), f_1124_4723_4759(definition));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 4594, 4776);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1124, 1, 183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1124, 1, 183);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 4111, 4787);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 4111, 4787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 4111, 4787);
            }
        }

        public WideControl(IEnumerable<WideControlEntryItem> wideEntries) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 4866, 5225);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 4965, 5067) || true) && (wideEntries == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 4965, 5067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 5007, 5067);

                    throw f_1124_5013_5066("wideEntries");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 4965, 5067);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 5083, 5214);
                    foreach (WideControlEntryItem entryItem in f_1124_5126_5137_I(wideEntries))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 5083, 5214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 5171, 5199);

                        f_1124_5171_5198(f_1124_5171_5183(this), entryItem);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 5083, 5214);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1124, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1124, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 4866, 5225);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 4866, 5225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 4866, 5225);
            }
        }

        public WideControl(IEnumerable<WideControlEntryItem> wideEntries, uint columns) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 5304, 5716);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 5417, 5519) || true) && (wideEntries == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 5417, 5519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 5459, 5519);

                    throw f_1124_5465_5518("wideEntries");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 5417, 5519);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 5535, 5666);
                    foreach (WideControlEntryItem entryItem in f_1124_5578_5589_I(wideEntries))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 5535, 5666);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 5623, 5651);

                        f_1124_5623_5650(f_1124_5623_5635(this), entryItem);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 5535, 5666);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1124, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1124, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 5682, 5705);

                this.Columns = columns;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 5304, 5716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 5304, 5716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 5304, 5716);
            }
        }

        public WideControl(uint columns) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 5795, 5895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 5861, 5884);

                this.Columns = columns;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 5795, 5895);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 5795, 5895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 5795, 5895);
            }
        }

        static WideControl()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1124, 2056, 5902);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1124, 2056, 5902);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 2056, 5902);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1124, 2056, 5902);

        System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
        f_1124_4055_4087()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 4055, 4087);
            return return_v;
        }


        System.Management.Automation.PSControlGroupBy
        f_1124_4290_4334(Microsoft.PowerShell.Commands.Internal.Format.GroupBy
        groupBy)
        {
            var return_v = PSControlGroupBy.Get(groupBy);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 4290, 4334);
            return return_v;
        }


        bool
        f_1124_4362_4395(bool?
        this_param)
        {
            var return_v = this_param.HasValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 4362, 4395);
            return return_v;
        }


        bool
        f_1124_4399_4429(bool?
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 4399, 4429);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
        f_1124_4500_4507()
        {
            var return_v = Entries;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 4500, 4507);
            return return_v;
        }


        System.Management.Automation.WideControlEntryItem
        f_1124_4512_4576(Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
        definition)
        {
            var return_v = new System.Management.Automation.WideControlEntryItem(definition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 4512, 4576);
            return return_v;
        }


        int
        f_1124_4500_4577(System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
        this_param, System.Management.Automation.WideControlEntryItem
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 4500, 4577);
            return 0;
        }


        System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
        f_1124_4711_4718()
        {
            var return_v = Entries;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 4711, 4718);
            return return_v;
        }


        System.Management.Automation.WideControlEntryItem
        f_1124_4723_4759(Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
        definition)
        {
            var return_v = new System.Management.Automation.WideControlEntryItem(definition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 4723, 4759);
            return return_v;
        }


        int
        f_1124_4711_4760(System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
        this_param, System.Management.Automation.WideControlEntryItem
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 4711, 4760);
            return 0;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition>
        f_1124_4644_4677_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 4644, 4677);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1124_5013_5066(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 5013, 5066);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
        f_1124_5171_5183(System.Management.Automation.WideControl
        this_param)
        {
            var return_v = this_param.Entries;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 5171, 5183);
            return return_v;
        }


        int
        f_1124_5171_5198(System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
        this_param, System.Management.Automation.WideControlEntryItem
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 5171, 5198);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.WideControlEntryItem>
        f_1124_5126_5137_I(System.Collections.Generic.IEnumerable<System.Management.Automation.WideControlEntryItem>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 5126, 5137);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1124_5465_5518(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 5465, 5518);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
        f_1124_5623_5635(System.Management.Automation.WideControl
        this_param)
        {
            var return_v = this_param.Entries;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 5623, 5635);
            return return_v;
        }


        int
        f_1124_5623_5650(System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
        this_param, System.Management.Automation.WideControlEntryItem
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 5623, 5650);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.WideControlEntryItem>
        f_1124_5578_5589_I(System.Collections.Generic.IEnumerable<System.Management.Automation.WideControlEntryItem>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 5578, 5589);
            return return_v;
        }

    }
    public sealed class WideControlEntryItem
    {
        public DisplayEntry DisplayEntry { get; internal set; }

        public List<string> SelectedBy
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 6332, 6557);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 6368, 6491) || true) && (f_1124_6372_6387() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 6368, 6491);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 6418, 6491);

                        EntrySelectedBy = new EntrySelectedBy { TypeNames = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1124_6470_6488(), 1124, 6436, 6490) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 6368, 6491);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 6509, 6542);

                    return f_1124_6516_6541(f_1124_6516_6531());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 6332, 6557);

                    System.Management.Automation.EntrySelectedBy
                    f_1124_6372_6387()
                    {
                        var return_v = EntrySelectedBy;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 6372, 6387);
                        return return_v;
                    }


                    System.Collections.Generic.List<string>
                    f_1124_6470_6488()
                    {
                        var return_v = new System.Collections.Generic.List<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 6470, 6488);
                        return return_v;
                    }


                    System.Management.Automation.EntrySelectedBy
                    f_1124_6516_6531()
                    {
                        var return_v = EntrySelectedBy;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 6516, 6531);
                        return return_v;
                    }


                    System.Collections.Generic.List<string>
                    f_1124_6516_6541(System.Management.Automation.EntrySelectedBy
                    this_param)
                    {
                        var return_v = this_param.TypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 6516, 6541);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 6277, 6568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 6277, 6568);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public EntrySelectedBy EntrySelectedBy { get; internal set; }

        public string FormatString { get; internal set; }

        internal WideControlEntryItem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 6866, 6919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 6103, 6158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 6677, 6738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 6805, 6854);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 6866, 6919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 6866, 6919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 6866, 6919);
            }
        }

        internal WideControlEntryItem(WideControlEntryDefinition definition) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 6931, 7493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 7033, 7110);

                FieldPropertyToken
                fpt = f_1124_7058_7087(definition.formatTokenList, 0) as FieldPropertyToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 7124, 7311) || true) && (fpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 7124, 7311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 7173, 7221);

                    DisplayEntry = f_1124_7188_7220(fpt.expression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 7239, 7296);

                    FormatString = fpt.fieldFormattingDirective.formatString;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 7124, 7311);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 7327, 7482) || true) && (definition.appliesTo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 7327, 7482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 7393, 7467);

                    EntrySelectedBy = f_1124_7411_7466(definition.appliesTo.referenceList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 7327, 7482);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 6931, 7493);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 6931, 7493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 6931, 7493);
            }
        }

        public WideControlEntryItem(DisplayEntry entry) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 7610, 7832);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 7691, 7781) || true) && (entry == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 7691, 7781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 7727, 7781);

                    throw f_1124_7733_7780("entry");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 7691, 7781);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 7795, 7821);

                this.DisplayEntry = entry;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 7610, 7832);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 7610, 7832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 7610, 7832);
            }
        }

        public WideControlEntryItem(DisplayEntry entry, IEnumerable<string> selectedBy) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 7949, 8394);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 8062, 8152) || true) && (entry == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 8062, 8152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 8098, 8152);

                    throw f_1124_8104_8151("entry");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 8062, 8152);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 8166, 8266) || true) && (selectedBy == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1124, 8166, 8266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 8207, 8266);

                    throw f_1124_8213_8265("selectedBy");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1124, 8166, 8266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 8282, 8308);

                this.DisplayEntry = entry;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 8322, 8383);

                this.EntrySelectedBy = f_1124_8345_8382(selectedBy, null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 7949, 8394);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 7949, 8394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 7949, 8394);
            }
        }

        internal bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 8406, 8571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 8460, 8560);

                return f_1124_8467_8495(f_1124_8467_8479()) && (DynAbs.Tracing.TraceSender.Expression_True(1124, 8467, 8559) && (f_1124_8500_8515() == null || (DynAbs.Tracing.TraceSender.Expression_False(1124, 8500, 8558) || f_1124_8527_8558(f_1124_8527_8542()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 8406, 8571);

                System.Management.Automation.DisplayEntry
                f_1124_8467_8479()
                {
                    var return_v = DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 8467, 8479);
                    return return_v;
                }


                bool
                f_1124_8467_8495(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 8467, 8495);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1124_8500_8515()
                {
                    var return_v = EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 8500, 8515);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1124_8527_8542()
                {
                    var return_v = EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 8527, 8542);
                    return return_v;
                }


                bool
                f_1124_8527_8558(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 8527, 8558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 8406, 8571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 8406, 8571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CompatibleWithOldPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 8583, 8904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 8767, 8893);

                return f_1124_8774_8786() == null && (DynAbs.Tracing.TraceSender.Expression_True(1124, 8774, 8892) && (f_1124_8819_8834() == null || (DynAbs.Tracing.TraceSender.Expression_False(1124, 8819, 8891) || f_1124_8846_8891(f_1124_8846_8861()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 8583, 8904);

                string
                f_1124_8774_8786()
                {
                    var return_v = FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 8774, 8786);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1124_8819_8834()
                {
                    var return_v = EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 8819, 8834);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1124_8846_8861()
                {
                    var return_v = EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 8846, 8861);
                    return return_v;
                }


                bool
                f_1124_8846_8891(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.CompatibleWithOldPowerShell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 8846, 8891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 8583, 8904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 8583, 8904);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static WideControlEntryItem()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1124, 6000, 8911);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1124, 6000, 8911);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 6000, 8911);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1124, 6000, 8911);

        Microsoft.PowerShell.Commands.Internal.Format.FormatToken
        f_1124_7058_7087(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 7058, 7087);
            return return_v;
        }


        System.Management.Automation.DisplayEntry
        f_1124_7188_7220(Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
        expression)
        {
            var return_v = new System.Management.Automation.DisplayEntry(expression);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 7188, 7220);
            return return_v;
        }


        System.Management.Automation.EntrySelectedBy
        f_1124_7411_7466(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
        references)
        {
            var return_v = EntrySelectedBy.Get(references);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 7411, 7466);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1124_7733_7780(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 7733, 7780);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1124_8104_8151(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 8104, 8151);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1124_8213_8265(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 8213, 8265);
            return return_v;
        }


        System.Management.Automation.EntrySelectedBy
        f_1124_8345_8382(System.Collections.Generic.IEnumerable<string>
        entrySelectedByType, System.Collections.Generic.IEnumerable<System.Management.Automation.DisplayEntry>
        entrySelectedByCondition)
        {
            var return_v = EntrySelectedBy.Get(entrySelectedByType, entrySelectedByCondition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 8345, 8382);
            return return_v;
        }

    }
    public sealed class WideControlBuilder
    {
        private readonly WideControl _control;

        internal WideControlBuilder(WideControl control)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1124, 9042, 9145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 9023, 9031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 9115, 9134);

                _control = control;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1124, 9042, 9145);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 9042, 9145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 9042, 9145);
            }
        }

        public WideControlBuilder GroupByProperty(string property, CustomControl customControl = null, string label = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 9250, 9666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 9390, 9629);

                _control.GroupBy = new PSControlGroupBy
                {
                    Expression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1124_9475_9533(property, DisplayEntryValueType.Property), 1124, 9409, 9628),
                    CustomControl = customControl,
                    Label = label
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 9643, 9655);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 9250, 9666);

                System.Management.Automation.DisplayEntry
                f_1124_9475_9533(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 9475, 9533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 9250, 9666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 9250, 9666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WideControlBuilder GroupByScriptBlock(string scriptBlock, CustomControl customControl = null, string label = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 9781, 10209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 9927, 10172);

                _control.GroupBy = new PSControlGroupBy
                {
                    Expression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1124_10012_10076(scriptBlock, DisplayEntryValueType.ScriptBlock), 1124, 9946, 10171),
                    CustomControl = customControl,
                    Label = label
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 10186, 10198);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 9781, 10209);

                System.Management.Automation.DisplayEntry
                f_1124_10012_10076(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 10012, 10076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 9781, 10209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 9781, 10209);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WideControlBuilder AddScriptBlockEntry(string scriptBlock, string format = null, IEnumerable<string> entrySelectedByType = null, IEnumerable<DisplayEntry> entrySelectedByCondition = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 10245, 10778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 10464, 10699);

                var
                entry = new WideControlEntryItem(f_1124_10501_10565(scriptBlock, DisplayEntryValueType.ScriptBlock))
                {
                    EntrySelectedBy = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1124_10617_10683(entrySelectedByType, entrySelectedByCondition), 1124, 10476, 10698)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 10713, 10741);

                f_1124_10713_10740(f_1124_10713_10729(_control), entry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 10755, 10767);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 10245, 10778);

                System.Management.Automation.DisplayEntry
                f_1124_10501_10565(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 10501, 10565);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1124_10617_10683(System.Collections.Generic.IEnumerable<string>
                entrySelectedByType, System.Collections.Generic.IEnumerable<System.Management.Automation.DisplayEntry>
                entrySelectedByCondition)
                {
                    var return_v = EntrySelectedBy.Get(entrySelectedByType, entrySelectedByCondition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 10617, 10683);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                f_1124_10713_10729(System.Management.Automation.WideControl
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 10713, 10729);
                    return return_v;
                }


                int
                f_1124_10713_10740(System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                this_param, System.Management.Automation.WideControlEntryItem
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 10713, 10740);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 10245, 10778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 10245, 10778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WideControlBuilder AddPropertyEntry(string propertyName, string format = null, IEnumerable<string> entrySelectedByType = null, IEnumerable<DisplayEntry> entrySelectedByCondition = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 10814, 11343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 11031, 11264);

                var
                entry = new WideControlEntryItem(f_1124_11068_11130(propertyName, DisplayEntryValueType.Property))
                {
                    EntrySelectedBy = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1124_11182_11248(entrySelectedByType, entrySelectedByCondition), 1124, 11043, 11263)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 11278, 11306);

                f_1124_11278_11305(f_1124_11278_11294(_control), entry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 11320, 11332);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 10814, 11343);

                System.Management.Automation.DisplayEntry
                f_1124_11068_11130(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 11068, 11130);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1124_11182_11248(System.Collections.Generic.IEnumerable<string>
                entrySelectedByType, System.Collections.Generic.IEnumerable<System.Management.Automation.DisplayEntry>
                entrySelectedByCondition)
                {
                    var return_v = EntrySelectedBy.Get(entrySelectedByType, entrySelectedByCondition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 11182, 11248);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                f_1124_11278_11294(System.Management.Automation.WideControl
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1124, 11278, 11294);
                    return return_v;
                }


                int
                f_1124_11278_11305(System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                this_param, System.Management.Automation.WideControlEntryItem
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1124, 11278, 11305);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 10814, 11343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 10814, 11343);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WideControl EndWideControl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1124, 11379, 11466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1124, 11439, 11455);

                return _control;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1124, 11379, 11466);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1124, 11379, 11466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 11379, 11466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static WideControlBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1124, 8939, 11473);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1124, 8939, 11473);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1124, 8939, 11473);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1124, 8939, 11473);
    }
}
