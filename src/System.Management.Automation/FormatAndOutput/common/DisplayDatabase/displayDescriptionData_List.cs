// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// this file contains the data structures for the in memory database
// containing display and formatting information

using System.Collections.Generic;
using Microsoft.PowerShell.Commands;
using Microsoft.PowerShell.Commands.Internal.Format;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class ListControlBody : ControlBody
    {
        internal ListControlEntryDefinition defaultEntryDefinition;

        internal List<ListControlEntryDefinition> optionalEntryList;

        internal override ControlBase Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 1069, 1594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 1130, 1177);

                ListControlBody
                result = f_1121_1155_1176()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 1191, 1223);

                result.autosize = this.autosize;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 1237, 1387) || true) && (defaultEntryDefinition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 1237, 1387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 1305, 1372);

                    result.defaultEntryDefinition = f_1121_1337_1371(this.defaultEntryDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 1237, 1387);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 1403, 1553);
                    foreach (ListControlEntryDefinition lced in f_1121_1447_1469_I(this.optionalEntryList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 1403, 1553);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 1503, 1538);

                        f_1121_1503_1537(result.optionalEntryList, lced);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 1403, 1553);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 1569, 1583);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 1069, 1594);

                Microsoft.PowerShell.Commands.Internal.Format.ListControlBody
                f_1121_1155_1176()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListControlBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 1155, 1176);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                f_1121_1337_1371(Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 1337, 1371);
                    return return_v;
                }


                int
                f_1121_1503_1537(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 1503, 1537);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
                f_1121_1447_1469_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 1447, 1469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 1069, 1594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 1069, 1594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ListControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 538, 1601);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 761, 790);
            this.defaultEntryDefinition = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 998, 1056);
            this.optionalEntryList = f_1121_1018_1056();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 538, 1601);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 538, 1601);
        }


        static ListControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1121, 538, 1601);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1121, 538, 1601);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 538, 1601);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1121, 538, 1601);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
        f_1121_1018_1056()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 1018, 1056);
            return return_v;
        }

    }
    internal sealed class ListControlEntryDefinition
    {
        internal AppliesTo appliesTo;

        internal List<ListControlItemDefinition> itemDefinitionList;

        internal ListControlEntryDefinition Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 2341, 2731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 2408, 2477);

                ListControlEntryDefinition
                result = f_1121_2444_2476()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 2491, 2525);

                result.appliesTo = this.appliesTo;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 2539, 2690);
                    foreach (ListControlItemDefinition lcid in f_1121_2582_2605_I(this.itemDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 2539, 2690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 2639, 2675);

                        f_1121_2639_2674(result.itemDefinitionList, lcid);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 2539, 2690);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 2706, 2720);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 2341, 2731);

                Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                f_1121_2444_2476()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 2444, 2476);
                    return return_v;
                }


                int
                f_1121_2639_2674(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 2639, 2674);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
                f_1121_2582_2605_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 2582, 2605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 2341, 2731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 2341, 2731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ListControlEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 1713, 2738);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 1933, 1949);
            this.appliesTo = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 2131, 2189);
            this.itemDefinitionList = f_1121_2152_2189();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 1713, 2738);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 1713, 2738);
        }


        static ListControlEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1121, 1713, 2738);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1121, 1713, 2738);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 1713, 2738);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1121, 1713, 2738);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
        f_1121_2152_2189()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 2152, 2189);
            return return_v;
        }

    }
    internal sealed class ListControlItemDefinition
    {
        internal ExpressionToken conditionToken;

        internal TextToken label;

        internal List<FormatToken> formatTokenList;

        public ListControlItemDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 2824, 3628);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 3018, 3032);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 3256, 3268);
            this.label = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 3579, 3620);
            this.formatTokenList = f_1121_3597_3620();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 2824, 3628);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 2824, 3628);
        }


        static ListControlItemDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1121, 2824, 3628);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1121, 2824, 3628);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 2824, 3628);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1121, 2824, 3628);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
        f_1121_3597_3620()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 3597, 3620);
            return return_v;
        }

    }

}

namespace System.Management.Automation
{
    public sealed class ListControl : PSControl
    {
        public List<ListControlEntry> Entries { get; internal set; }

        public static ListControlBuilder Create(bool outOfBand = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1121, 3998, 4196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 4086, 4135);

                var
                list = new ListControl { OutOfBand = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 1121, 4097, 4134) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 4149, 4185);

                return f_1121_4156_4184(list);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1121, 3998, 4196);

                System.Management.Automation.ListControlBuilder
                f_1121_4156_4184(System.Management.Automation.ListControl
                list)
                {
                    var return_v = new System.Management.Automation.ListControlBuilder(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 4156, 4184);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 3998, 4196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 3998, 4196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void WriteToXml(FormatXmlWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 4208, 4331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 4290, 4320);

                f_1121_4290_4319(writer, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 4208, 4331);

                int
                f_1121_4290_4319(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.ListControl
                listControl)
                {
                    this_param.WriteListControl(listControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 4290, 4319);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 4208, 4331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 4208, 4331);
            }
        }

        internal override bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 4455, 4770);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 4518, 4575) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SafeForExport(), 1121, 4523, 4543))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 4518, 4575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 4562, 4575);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 4518, 4575);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 4591, 4731);
                    foreach (var entry in f_1121_4613_4620_I(f_1121_4613_4620()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 4591, 4731);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 4654, 4716) || true) && (!f_1121_4659_4680(entry))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 4654, 4716);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 4703, 4716);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 4654, 4716);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 4591, 4731);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 4747, 4759);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 4455, 4770);

                System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                f_1121_4613_4620()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 4613, 4620);
                    return return_v;
                }


                bool
                f_1121_4659_4680(System.Management.Automation.ListControlEntry
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 4659, 4680);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                f_1121_4613_4620_I(System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 4613, 4620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 4455, 4770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 4455, 4770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ListControl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 4850, 4945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 3893, 3953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 4895, 4934);

                Entries = f_1121_4905_4933();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 4850, 4945);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 4850, 4945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 4850, 4945);
            }
        }

        internal ListControl(ListControlBody listcontrolbody, ViewDefinition viewDefinition)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 5057, 5587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 5188, 5248);

                this.GroupBy = f_1121_5203_5247(viewDefinition.groupBy);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 5262, 5304);

                this.OutOfBand = viewDefinition.outOfBand;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 5320, 5394);

                f_1121_5320_5393(f_1121_5320_5327(), f_1121_5332_5392(listcontrolbody.defaultEntryDefinition));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 5410, 5576);
                    foreach (ListControlEntryDefinition lced in f_1121_5454_5487_I(listcontrolbody.optionalEntryList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 5410, 5576);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 5521, 5561);

                        f_1121_5521_5560(f_1121_5521_5528(), f_1121_5533_5559(lced));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 5410, 5576);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 167);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 5057, 5587);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 5057, 5587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 5057, 5587);
            }
        }

        public ListControl(IEnumerable<ListControlEntry> entries)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 5666, 6004);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 5770, 5864) || true) && (entries == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 5770, 5864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 5808, 5864);

                    throw f_1121_5814_5863("entries");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 5770, 5864);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 5878, 5993);
                    foreach (ListControlEntry entry in f_1121_5913_5920_I(entries))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 5878, 5993);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 5954, 5978);

                        f_1121_5954_5977(f_1121_5954_5966(this), entry);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 5878, 5993);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 116);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 5666, 6004);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 5666, 6004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 5666, 6004);
            }
        }

        internal override bool CompatibleWithOldPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 6016, 6373);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6093, 6164) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CompatibleWithOldPowerShell(), 1121, 6098, 6132))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 6093, 6164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6151, 6164);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 6093, 6164);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6180, 6334);
                    foreach (var entry in f_1121_6202_6209_I(f_1121_6202_6209()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 6180, 6334);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6243, 6319) || true) && (!f_1121_6248_6283(entry))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 6243, 6319);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6306, 6319);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 6243, 6319);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 6180, 6334);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 155);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6350, 6362);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 6016, 6373);

                System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                f_1121_6202_6209()
                {
                    var return_v = Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 6202, 6209);
                    return return_v;
                }


                bool
                f_1121_6248_6283(System.Management.Automation.ListControlEntry
                this_param)
                {
                    var return_v = this_param.CompatibleWithOldPowerShell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 6248, 6283);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                f_1121_6202_6209_I(System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 6202, 6209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 6016, 6373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 6016, 6373);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ListControl()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1121, 3772, 6380);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1121, 3772, 6380);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 3772, 6380);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1121, 3772, 6380);

        System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
        f_1121_4905_4933()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.ListControlEntry>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 4905, 4933);
            return return_v;
        }


        System.Management.Automation.PSControlGroupBy
        f_1121_5203_5247(Microsoft.PowerShell.Commands.Internal.Format.GroupBy
        groupBy)
        {
            var return_v = PSControlGroupBy.Get(groupBy);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 5203, 5247);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
        f_1121_5320_5327()
        {
            var return_v = Entries;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 5320, 5327);
            return return_v;
        }


        System.Management.Automation.ListControlEntry
        f_1121_5332_5392(Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
        entrydefn)
        {
            var return_v = new System.Management.Automation.ListControlEntry(entrydefn);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 5332, 5392);
            return return_v;
        }


        int
        f_1121_5320_5393(System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
        this_param, System.Management.Automation.ListControlEntry
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 5320, 5393);
            return 0;
        }


        System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
        f_1121_5521_5528()
        {
            var return_v = Entries;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 5521, 5528);
            return return_v;
        }


        System.Management.Automation.ListControlEntry
        f_1121_5533_5559(Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
        entrydefn)
        {
            var return_v = new System.Management.Automation.ListControlEntry(entrydefn);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 5533, 5559);
            return return_v;
        }


        int
        f_1121_5521_5560(System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
        this_param, System.Management.Automation.ListControlEntry
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 5521, 5560);
            return 0;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
        f_1121_5454_5487_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 5454, 5487);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1121_5814_5863(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 5814, 5863);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
        f_1121_5954_5966(System.Management.Automation.ListControl
        this_param)
        {
            var return_v = this_param.Entries;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 5954, 5966);
            return return_v;
        }


        int
        f_1121_5954_5977(System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
        this_param, System.Management.Automation.ListControlEntry
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 5954, 5977);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.ListControlEntry>
        f_1121_5913_5920_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ListControlEntry>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 5913, 5920);
            return return_v;
        }

    }
    public sealed class ListControlEntry
    {
        public List<ListControlEntryItem> Items { get; internal set; }

        public List<string> SelectedBy
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 6821, 7046);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6857, 6980) || true) && (f_1121_6861_6876() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 6857, 6980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6907, 6980);

                        EntrySelectedBy = new EntrySelectedBy { TypeNames = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1121_6959_6977(), 1121, 6925, 6979) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 6857, 6980);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6998, 7031);

                    return f_1121_7005_7030(f_1121_7005_7020());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 6821, 7046);

                    System.Management.Automation.EntrySelectedBy
                    f_1121_6861_6876()
                    {
                        var return_v = EntrySelectedBy;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 6861, 6876);
                        return return_v;
                    }


                    System.Collections.Generic.List<string>
                    f_1121_6959_6977()
                    {
                        var return_v = new System.Collections.Generic.List<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 6959, 6977);
                        return return_v;
                    }


                    System.Management.Automation.EntrySelectedBy
                    f_1121_7005_7020()
                    {
                        var return_v = EntrySelectedBy;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 7005, 7020);
                        return return_v;
                    }


                    System.Collections.Generic.List<string>
                    f_1121_7005_7030(System.Management.Automation.EntrySelectedBy
                    this_param)
                    {
                        var return_v = this_param.TypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 7005, 7030);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 6766, 7057);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 6766, 7057);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public EntrySelectedBy EntrySelectedBy { get; internal set; }

        public ListControlEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 7312, 7414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6585, 6647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 7166, 7227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 7362, 7403);

                Items = f_1121_7370_7402();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 7312, 7414);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 7312, 7414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 7312, 7414);
            }
        }

        internal ListControlEntry(ListControlEntryDefinition entrydefn)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 7426, 7886);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 7536, 7689) || true) && (entrydefn.appliesTo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 7536, 7689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 7601, 7674);

                    EntrySelectedBy = f_1121_7619_7673(entrydefn.appliesTo.referenceList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 7536, 7689);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 7705, 7875);
                    foreach (ListControlItemDefinition itemdefn in f_1121_7752_7780_I(entrydefn.itemDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 7705, 7875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 7814, 7860);

                        f_1121_7814_7859(f_1121_7814_7819(), f_1121_7824_7858(itemdefn));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 7705, 7875);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 7426, 7886);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 7426, 7886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 7426, 7886);
            }
        }

        public ListControlEntry(IEnumerable<ListControlEntryItem> listItems)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 7970, 8325);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8085, 8183) || true) && (listItems == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 8085, 8183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8125, 8183);

                    throw f_1121_8131_8182("listItems");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 8085, 8183);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8197, 8314);
                    foreach (ListControlEntryItem item in f_1121_8235_8244_I(listItems))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 8197, 8314);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8278, 8299);

                        f_1121_8278_8298(f_1121_8278_8288(this), item);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 8197, 8314);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 7970, 8325);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 7970, 8325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 7970, 8325);
            }
        }

        public ListControlEntry(IEnumerable<ListControlEntryItem> listItems, IEnumerable<string> selectedBy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 8409, 8987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 6585, 6647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 7166, 7227);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8534, 8632) || true) && (listItems == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 8534, 8632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8574, 8632);

                    throw f_1121_8580_8631("listItems");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 8534, 8632);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8646, 8746) || true) && (selectedBy == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 8646, 8746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8687, 8746);

                    throw f_1121_8693_8745("selectedBy");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 8646, 8746);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8762, 8845);

                EntrySelectedBy = new EntrySelectedBy { TypeNames = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1121_8814_8842(selectedBy), 1121, 8780, 8844) };
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8859, 8976);
                    foreach (ListControlEntryItem item in f_1121_8897_8906_I(listItems))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 8859, 8976);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 8940, 8961);

                        f_1121_8940_8960(f_1121_8940_8950(this), item);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 8859, 8976);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 8409, 8987);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 8409, 8987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 8409, 8987);
            }
        }

        internal bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 8999, 9282);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9053, 9189);
                    foreach (var item in f_1121_9074_9079_I(f_1121_9074_9079()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 9053, 9189);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9113, 9174) || true) && (!f_1121_9118_9138(item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 9113, 9174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9161, 9174);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 9113, 9174);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 9053, 9189);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9205, 9271);

                return f_1121_9212_9227() == null || (DynAbs.Tracing.TraceSender.Expression_False(1121, 9212, 9270) || f_1121_9239_9270(f_1121_9239_9254()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 8999, 9282);

                System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                f_1121_9074_9079()
                {
                    var return_v = Items;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 9074, 9079);
                    return return_v;
                }


                bool
                f_1121_9118_9138(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 9118, 9138);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                f_1121_9074_9079_I(System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 9074, 9079);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1121_9212_9227()
                {
                    var return_v = EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 9212, 9227);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1121_9239_9254()
                {
                    var return_v = EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 9239, 9254);
                    return return_v;
                }


                bool
                f_1121_9239_9270(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 9239, 9270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 8999, 9282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 8999, 9282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CompatibleWithOldPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 9294, 9619);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9362, 9512);
                    foreach (var item in f_1121_9383_9388_I(f_1121_9383_9388()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 9362, 9512);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9422, 9497) || true) && (!f_1121_9427_9461(item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 9422, 9497);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9484, 9497);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 9422, 9497);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 9362, 9512);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1121, 1, 151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1121, 1, 151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9528, 9608);

                return f_1121_9535_9550() == null || (DynAbs.Tracing.TraceSender.Expression_False(1121, 9535, 9607) || f_1121_9562_9607(f_1121_9562_9577()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 9294, 9619);

                System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                f_1121_9383_9388()
                {
                    var return_v = Items;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 9383, 9388);
                    return return_v;
                }


                bool
                f_1121_9427_9461(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.CompatibleWithOldPowerShell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 9427, 9461);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                f_1121_9383_9388_I(System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 9383, 9388);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1121_9535_9550()
                {
                    var return_v = EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 9535, 9550);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1121_9562_9577()
                {
                    var return_v = EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 9562, 9577);
                    return return_v;
                }


                bool
                f_1121_9562_9607(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.CompatibleWithOldPowerShell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 9562, 9607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 9294, 9619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 9294, 9619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ListControlEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1121, 6473, 9626);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1121, 6473, 9626);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 6473, 9626);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1121, 6473, 9626);

        System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
        f_1121_7370_7402()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 7370, 7402);
            return return_v;
        }


        System.Management.Automation.EntrySelectedBy
        f_1121_7619_7673(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
        references)
        {
            var return_v = EntrySelectedBy.Get(references);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 7619, 7673);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
        f_1121_7814_7819()
        {
            var return_v = Items;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 7814, 7819);
            return return_v;
        }


        System.Management.Automation.ListControlEntryItem
        f_1121_7824_7858(Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition
        definition)
        {
            var return_v = new System.Management.Automation.ListControlEntryItem(definition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 7824, 7858);
            return return_v;
        }


        int
        f_1121_7814_7859(System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
        this_param, System.Management.Automation.ListControlEntryItem
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 7814, 7859);
            return 0;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
        f_1121_7752_7780_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 7752, 7780);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1121_8131_8182(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 8131, 8182);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
        f_1121_8278_8288(System.Management.Automation.ListControlEntry
        this_param)
        {
            var return_v = this_param.Items;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 8278, 8288);
            return return_v;
        }


        int
        f_1121_8278_8298(System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
        this_param, System.Management.Automation.ListControlEntryItem
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 8278, 8298);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.ListControlEntryItem>
        f_1121_8235_8244_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ListControlEntryItem>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 8235, 8244);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1121_8580_8631(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 8580, 8631);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1121_8693_8745(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 8693, 8745);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1121_8814_8842(System.Collections.Generic.IEnumerable<string>
        collection)
        {
            var return_v = new System.Collections.Generic.List<string>(collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 8814, 8842);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
        f_1121_8940_8950(System.Management.Automation.ListControlEntry
        this_param)
        {
            var return_v = this_param.Items;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 8940, 8950);
            return return_v;
        }


        int
        f_1121_8940_8960(System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
        this_param, System.Management.Automation.ListControlEntryItem
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 8940, 8960);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.ListControlEntryItem>
        f_1121_8897_8906_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ListControlEntryItem>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 8897, 8906);
            return return_v;
        }

    }
    public sealed class ListControlEntryItem
    {
        public string Label { get; internal set; }

        public DisplayEntry DisplayEntry { get; internal set; }

        public DisplayEntry ItemSelectionCondition { get; internal set; }

        public string FormatString { get; internal set; }

        internal ListControlEntryItem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 10355, 10408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9971, 10013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10071, 10126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10162, 10227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10294, 10343);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 10355, 10408);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 10355, 10408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 10355, 10408);
            }
        }

        internal ListControlEntryItem(ListControlItemDefinition definition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 10420, 11225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9971, 10013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10071, 10126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10162, 10227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10294, 10343);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10512, 10619) || true) && (definition.label != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 10512, 10619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10574, 10604);

                    Label = definition.label.text;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 10512, 10619);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10635, 10712);

                FieldPropertyToken
                fpt = f_1121_10660_10689(definition.formatTokenList, 0) as FieldPropertyToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10726, 11214) || true) && (fpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 10726, 11214);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10775, 10946) || true) && (fpt.fieldFormattingDirective.formatString != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 10775, 10946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10870, 10927);

                        FormatString = fpt.fieldFormattingDirective.formatString;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 10775, 10946);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10966, 11014);

                    DisplayEntry = f_1121_10981_11013(fpt.expression);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 11032, 11199) || true) && (definition.conditionToken != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 11032, 11199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 11111, 11180);

                        ItemSelectionCondition = f_1121_11136_11179(definition.conditionToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 11032, 11199);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 10726, 11214);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 10420, 11225);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 10420, 11225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 10420, 11225);
            }
        }

        public ListControlEntryItem(string label, DisplayEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 11469, 11625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 9971, 10013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10071, 10126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10162, 10227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 10294, 10343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 11555, 11574);

                this.Label = label;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 11588, 11614);

                this.DisplayEntry = entry;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 11469, 11625);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 11469, 11625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 11469, 11625);
            }
        }

        internal bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 11637, 11836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 11691, 11825);

                return f_1121_11698_11726(f_1121_11698_11710()) && (DynAbs.Tracing.TraceSender.Expression_True(1121, 11698, 11824) && (f_1121_11751_11773() == null || (DynAbs.Tracing.TraceSender.Expression_False(1121, 11751, 11823) || f_1121_11785_11823(f_1121_11785_11807()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 11637, 11836);

                System.Management.Automation.DisplayEntry
                f_1121_11698_11710()
                {
                    var return_v = DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 11698, 11710);
                    return return_v;
                }


                bool
                f_1121_11698_11726(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 11698, 11726);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1121_11751_11773()
                {
                    var return_v = ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 11751, 11773);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1121_11785_11807()
                {
                    var return_v = ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 11785, 11807);
                    return return_v;
                }


                bool
                f_1121_11785_11823(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 11785, 11823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 11637, 11836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 11637, 11836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CompatibleWithOldPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 11848, 12051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 12002, 12040);

                return f_1121_12009_12031() == null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 11848, 12051);

                System.Management.Automation.DisplayEntry
                f_1121_12009_12031()
                {
                    var return_v = ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 12009, 12031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 11848, 12051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 11848, 12051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ListControlEntryItem()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1121, 9723, 12058);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1121, 9723, 12058);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 9723, 12058);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1121, 9723, 12058);

        Microsoft.PowerShell.Commands.Internal.Format.FormatToken
        f_1121_10660_10689(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 10660, 10689);
            return return_v;
        }


        System.Management.Automation.DisplayEntry
        f_1121_10981_11013(Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
        expression)
        {
            var return_v = new System.Management.Automation.DisplayEntry(expression);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 10981, 11013);
            return return_v;
        }


        System.Management.Automation.DisplayEntry
        f_1121_11136_11179(Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
        expression)
        {
            var return_v = new System.Management.Automation.DisplayEntry(expression);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 11136, 11179);
            return return_v;
        }

    }
    public class ListEntryBuilder
    {
        private readonly ListControlBuilder _listBuilder;

        internal ListControlEntry _listEntry;

        internal ListEntryBuilder(ListControlBuilder listBuilder, ListControlEntry listEntry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 12240, 12425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 12168, 12180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 12217, 12227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 12350, 12377);

                _listBuilder = listBuilder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 12391, 12414);

                _listEntry = listEntry;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 12240, 12425);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 12240, 12425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 12240, 12425);
            }
        }

        private ListEntryBuilder AddItem(string value, string label, DisplayEntryValueType kind, string format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 12437, 12938);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 12565, 12672) || true) && (f_1121_12569_12596(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1121, 12565, 12672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 12615, 12672);

                    throw f_1121_12621_12671("property");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1121, 12565, 12672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 12688, 12899);

                f_1121_12688_12898(f_1121_12688_12704(_listEntry), new ListControlEntryItem
                {
                    DisplayEntry = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1121_12781_12810(value, kind), 1121, 12709, 12897),
                    Label = label,
                    FormatString = format
                });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 12915, 12927);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 12437, 12938);

                bool
                f_1121_12569_12596(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 12569, 12596);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1121_12621_12671(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 12621, 12671);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                f_1121_12688_12704(System.Management.Automation.ListControlEntry
                this_param)
                {
                    var return_v = this_param.Items;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 12688, 12704);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1121_12781_12810(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 12781, 12810);
                    return return_v;
                }


                int
                f_1121_12688_12898(System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                this_param, System.Management.Automation.ListControlEntryItem
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 12688, 12898);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 12437, 12938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 12437, 12938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ListEntryBuilder AddItemScriptBlock(string scriptBlock, string label = null, string format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 12983, 13202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 13113, 13191);

                return f_1121_13120_13190(this, scriptBlock, label, DisplayEntryValueType.ScriptBlock, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 12983, 13202);

                System.Management.Automation.ListEntryBuilder
                f_1121_13120_13190(System.Management.Automation.ListEntryBuilder
                this_param, string
                value, string
                label, System.Management.Automation.DisplayEntryValueType
                kind, string
                format)
                {
                    var return_v = this_param.AddItem(value, label, kind, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 13120, 13190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 12983, 13202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 12983, 13202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ListEntryBuilder AddItemProperty(string property, string label = null, string format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 13247, 13454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 13371, 13443);

                return f_1121_13378_13442(this, property, label, DisplayEntryValueType.Property, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 13247, 13454);

                System.Management.Automation.ListEntryBuilder
                f_1121_13378_13442(System.Management.Automation.ListEntryBuilder
                this_param, string
                value, string
                label, System.Management.Automation.DisplayEntryValueType
                kind, string
                format)
                {
                    var return_v = this_param.AddItem(value, label, kind, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 13378, 13442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 13247, 13454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 13247, 13454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ListControlBuilder EndEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 13499, 13591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 13560, 13580);

                return _listBuilder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 13499, 13591);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 13499, 13591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 13499, 13591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ListEntryBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1121, 12086, 13598);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1121, 12086, 13598);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 12086, 13598);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1121, 12086, 13598);
    }
    public class ListControlBuilder
    {
        internal ListControl _list;

        internal ListControlBuilder(ListControl list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1121, 13722, 13816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 13704, 13709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 13792, 13805);

                _list = list;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1121, 13722, 13816);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 13722, 13816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 13722, 13816);
            }
        }

        public ListControlBuilder GroupByProperty(string property, CustomControl customControl = null, string label = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 13921, 14334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 14061, 14297);

                _list.GroupBy = new PSControlGroupBy
                {
                    Expression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1121_14143_14201(property, DisplayEntryValueType.Property), 1121, 14077, 14296),
                    CustomControl = customControl,
                    Label = label
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 14311, 14323);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 13921, 14334);

                System.Management.Automation.DisplayEntry
                f_1121_14143_14201(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 14143, 14201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 13921, 14334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 13921, 14334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ListControlBuilder GroupByScriptBlock(string scriptBlock, CustomControl customControl = null, string label = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 14449, 14874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 14595, 14837);

                _list.GroupBy = new PSControlGroupBy
                {
                    Expression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1121_14677_14741(scriptBlock, DisplayEntryValueType.ScriptBlock), 1121, 14611, 14836),
                    CustomControl = customControl,
                    Label = label
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 14851, 14863);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 14449, 14874);

                System.Management.Automation.DisplayEntry
                f_1121_14677_14741(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 14677, 14741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 14449, 14874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 14449, 14874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ListEntryBuilder StartEntry(IEnumerable<string> entrySelectedByType = null, IEnumerable<DisplayEntry> entrySelectedByCondition = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 14919, 15367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 15085, 15254);

                var
                listEntry = new ListControlEntry
                {
                    EntrySelectedBy = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1121_15172_15238(entrySelectedByType, entrySelectedByCondition), 1121, 15101, 15253)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 15268, 15297);

                f_1121_15268_15296(f_1121_15268_15281(_list), listEntry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 15311, 15356);

                return f_1121_15318_15355(this, listEntry);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 14919, 15367);

                System.Management.Automation.EntrySelectedBy
                f_1121_15172_15238(System.Collections.Generic.IEnumerable<string>
                entrySelectedByType, System.Collections.Generic.IEnumerable<System.Management.Automation.DisplayEntry>
                entrySelectedByCondition)
                {
                    var return_v = EntrySelectedBy.Get(entrySelectedByType, entrySelectedByCondition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 15172, 15238);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                f_1121_15268_15281(System.Management.Automation.ListControl
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1121, 15268, 15281);
                    return return_v;
                }


                int
                f_1121_15268_15296(System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                this_param, System.Management.Automation.ListControlEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 15268, 15296);
                    return 0;
                }


                System.Management.Automation.ListEntryBuilder
                f_1121_15318_15355(System.Management.Automation.ListControlBuilder
                listBuilder, System.Management.Automation.ListControlEntry
                listEntry)
                {
                    var return_v = new System.Management.Automation.ListEntryBuilder(listBuilder, listEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1121, 15318, 15355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 14919, 15367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 14919, 15367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ListControl EndList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1121, 15412, 15489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1121, 15465, 15478);

                return _list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1121, 15412, 15489);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1121, 15412, 15489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 15412, 15489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ListControlBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1121, 13635, 15496);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1121, 13635, 15496);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1121, 13635, 15496);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1121, 13635, 15496);
    }
}
