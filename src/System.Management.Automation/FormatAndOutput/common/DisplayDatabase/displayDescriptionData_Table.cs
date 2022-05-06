// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// this file contains the data structures for the in memory database
// containing display and formatting information

using System.Collections.Generic;
using Microsoft.PowerShell.Commands;
using Microsoft.PowerShell.Commands.Internal.Format;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal static class TextAlignment
    {
        internal const int
        Undefined = 0
        ;

        internal const int
        Left = 1
        ;

        internal const int
        Center = 2
        ;

        internal const int
        Right = 3
        ;

        static TextAlignment()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 655, 864);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 726, 739);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 769, 777);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 807, 817);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 847, 856);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 655, 864);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 655, 864);
        }

    }
    internal sealed class TableControlBody : ControlBody
    {
        internal TableHeaderDefinition header;

        internal TableRowDefinition defaultDefinition;

        internal List<TableRowDefinition> optionalDefinitionList;

        internal override ControlBase Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 1651, 2233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 1712, 1877);

                TableControlBody
                result = new TableControlBody
                {
                    autosize = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => this.autosize, 1123, 1738, 1876),
                    header = f_1123_1843_1861(this.header)
                }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 1891, 2026) || true) && (defaultDefinition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 1891, 2026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 1954, 2011);

                    result.defaultDefinition = f_1123_1981_2010(this.defaultDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 1891, 2026);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 2042, 2192);
                    foreach (TableRowDefinition trd in f_1123_2077_2104_I(this.optionalDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 2042, 2192);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 2138, 2177);

                        f_1123_2138_2176(result.optionalDefinitionList, trd);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 2042, 2192);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 2208, 2222);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 1651, 2233);

                Microsoft.PowerShell.Commands.Internal.Format.TableHeaderDefinition
                f_1123_1843_1861(Microsoft.PowerShell.Commands.Internal.Format.TableHeaderDefinition
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 1843, 1861);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                f_1123_1981_2010(Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 1981, 2010);
                    return return_v;
                }


                int
                f_1123_2138_2176(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 2138, 2176);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                f_1123_2077_2104_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 2077, 2104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 1651, 2233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 1651, 2233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 951, 2240);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 1184, 1220);
            this.header = f_1123_1193_1220();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 1373, 1390);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 1583, 1638);
            this.optionalDefinitionList = f_1123_1608_1638();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 951, 2240);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 951, 2240);
        }


        static TableControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 951, 2240);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 951, 2240);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 951, 2240);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 951, 2240);

        Microsoft.PowerShell.Commands.Internal.Format.TableHeaderDefinition
        f_1123_1193_1220()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableHeaderDefinition();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 1193, 1220);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
        f_1123_1608_1638()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 1608, 1638);
            return return_v;
        }

    }
    internal sealed class TableHeaderDefinition
    {
        internal bool hideHeader;

        internal List<TableColumnHeaderDefinition> columnHeaderDefinitionList;

        internal TableHeaderDefinition Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 3034, 3410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 3096, 3186);

                TableHeaderDefinition
                result = new TableHeaderDefinition { hideHeader = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => this.hideHeader, 1123, 3127, 3185) }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 3200, 3369);
                    foreach (TableColumnHeaderDefinition tchd in f_1123_3245_3276_I(this.columnHeaderDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 3200, 3369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 3310, 3354);

                        f_1123_3310_3353(result.columnHeaderDefinitionList, tchd);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 3200, 3369);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 3385, 3399);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 3034, 3410);

                int
                f_1123_3310_3353(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 3310, 3353);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                f_1123_3245_3276_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 3245, 3276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 3034, 3410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 3034, 3410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableHeaderDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 2415, 3417);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 2614, 2624);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 2785, 2882);
            this.columnHeaderDefinitionList = f_1123_2843_2882();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 2415, 3417);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 2415, 3417);
        }


        static TableHeaderDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 2415, 3417);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 2415, 3417);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 2415, 3417);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 2415, 3417);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
        f_1123_2843_2882()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 2843, 2882);
            return return_v;
        }

    }
    internal sealed class TableColumnHeaderDefinition
    {
        internal TextToken label;

        internal int alignment;

        internal int width;

        public TableColumnHeaderDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 3425, 4120);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 3701, 3713);
            this.label = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 3948, 3983);
            this.alignment = TextAlignment.Undefined;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 4090, 4099);
            this.width = 0;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 3425, 4120);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 3425, 4120);
        }


        static TableColumnHeaderDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 3425, 4120);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 3425, 4120);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 3425, 4120);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 3425, 4120);
    }
    internal sealed class TableRowDefinition
    {
        internal AppliesTo appliesTo;

        internal bool multiLine;

        internal List<TableRowItemDefinition> rowItemDefinitionList;

        internal TableRowDefinition Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 5039, 5477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 5098, 5268);

                TableRowDefinition
                result = new TableRowDefinition
                {
                    appliesTo = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => this.appliesTo, 1123, 5126, 5267),
                    multiLine = this.multiLine
                }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 5282, 5436);
                    foreach (TableRowItemDefinition trid in f_1123_5322_5348_I(this.rowItemDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 5282, 5436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 5382, 5421);

                        f_1123_5382_5420(result.rowItemDefinitionList, trid);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 5282, 5436);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 155);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 5452, 5466);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 5039, 5477);

                int
                f_1123_5382_5420(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 5382, 5420);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                f_1123_5322_5348_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 5322, 5348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 5039, 5477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 5039, 5477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableRowDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 4231, 5484);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 4443, 4452);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 4644, 4653);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 4829, 4887);
            this.rowItemDefinitionList = f_1123_4853_4887();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 4231, 5484);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 4231, 5484);
        }


        static TableRowDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 4231, 5484);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 4231, 5484);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 4231, 5484);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 4231, 5484);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
        f_1123_4853_4887()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 4853, 4887);
            return return_v;
        }

    }
    internal sealed class TableRowItemDefinition
    {
        internal int alignment;

        internal List<FormatToken> formatTokenList;

        public TableRowItemDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 5570, 6167);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 5772, 5807);
            this.alignment = TextAlignment.Undefined;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 6118, 6159);
            this.formatTokenList = f_1123_6136_6159();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 5570, 6167);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 5570, 6167);
        }


        static TableRowItemDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 5570, 6167);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 5570, 6167);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 5570, 6167);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 5570, 6167);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
        f_1123_6136_6159()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 6136, 6159);
            return return_v;
        }

    }

}

namespace System.Management.Automation
{
    public sealed class TableControl : PSControl
    {
        public List<TableControlColumnHeader> Headers { get; set; }

        public List<TableControlRow> Rows { get; set; }

        public bool AutoSize { get; set; }

        public bool HideTableHeaders { get; set; }

        public static TableControlBuilder Create(bool outOfBand = false, bool autoSize = false, bool hideTableHeaders = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1123, 7029, 7348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 7172, 7285);

                var
                table = new TableControl { OutOfBand = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => outOfBand, 1123, 7184, 7284), AutoSize = autoSize, HideTableHeaders = hideTableHeaders }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 7299, 7337);

                return f_1123_7306_7336(table);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1123, 7029, 7348);

                System.Management.Automation.TableControlBuilder
                f_1123_7306_7336(System.Management.Automation.TableControl
                table)
                {
                    var return_v = new System.Management.Automation.TableControlBuilder(table);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 7306, 7336);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 7029, 7348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 7029, 7348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableControl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 7436, 7589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 6468, 6527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 6624, 6671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 6792, 6826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 6913, 6955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 7482, 7529);

                Headers = f_1123_7492_7528();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 7543, 7578);

                Rows = f_1123_7550_7577();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 7436, 7589);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 7436, 7589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 7436, 7589);
            }
        }

        internal override void WriteToXml(FormatXmlWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 7601, 7725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 7683, 7714);

                f_1123_7683_7713(writer, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 7601, 7725);

                int
                f_1123_7683_7713(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.TableControl
                tableControl)
                {
                    this_param.WriteTableControl(tableControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 7683, 7713);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 7601, 7725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 7601, 7725);
            }
        }

        internal override bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 7909, 8217);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 7972, 8029) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SafeForExport(), 1123, 7977, 7997))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 7972, 8029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8016, 8029);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 7972, 8029);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8045, 8178);
                    foreach (var row in f_1123_8065_8069_I(f_1123_8065_8069()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 8045, 8178);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8103, 8163) || true) && (!f_1123_8108_8127(row))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 8103, 8163);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8150, 8163);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 8103, 8163);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 8045, 8178);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8194, 8206);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 7909, 8217);

                System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                f_1123_8065_8069()
                {
                    var return_v = Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 8065, 8069);
                    return return_v;
                }


                bool
                f_1123_8108_8127(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 8108, 8127);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                f_1123_8065_8069_I(System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 8065, 8069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 7909, 8217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 7909, 8217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool CompatibleWithOldPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 8229, 8579);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8306, 8377) || true) && (!DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CompatibleWithOldPowerShell(), 1123, 8311, 8345))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 8306, 8377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8364, 8377);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 8306, 8377);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8393, 8540);
                    foreach (var row in f_1123_8413_8417_I(f_1123_8413_8417()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 8393, 8540);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8451, 8525) || true) && (!f_1123_8456_8489(row))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 8451, 8525);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8512, 8525);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 8451, 8525);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 8393, 8540);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8556, 8568);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 8229, 8579);

                System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                f_1123_8413_8417()
                {
                    var return_v = Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 8413, 8417);
                    return return_v;
                }


                bool
                f_1123_8456_8489(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.CompatibleWithOldPowerShell();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 8456, 8489);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                f_1123_8413_8417_I(System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 8413, 8417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 8229, 8579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 8229, 8579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TableControl(TableControlBody tcb, ViewDefinition viewDefinition) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 8591, 9512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8699, 8741);

                this.OutOfBand = viewDefinition.outOfBand;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8755, 8815);

                this.GroupBy = f_1123_8770_8814(viewDefinition.groupBy);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8831, 8891);

                this.AutoSize = f_1123_8847_8868(tcb.autosize) && (DynAbs.Tracing.TraceSender.Expression_True(1123, 8847, 8890) && f_1123_8872_8890(tcb.autosize));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8905, 8951);

                this.HideTableHeaders = tcb.header.hideHeader;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 8967, 9032);

                TableControlRow
                row = f_1123_8989_9031(tcb.defaultDefinition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 9048, 9062);

                f_1123_9048_9061(f_1123_9048_9052(), row);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 9078, 9251);
                    foreach (TableRowDefinition rd in f_1123_9112_9138_I(tcb.optionalDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 9078, 9251);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 9172, 9202);

                        row = f_1123_9178_9201(rd);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 9222, 9236);

                        f_1123_9222_9235(f_1123_9222_9226(), row);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 9078, 9251);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 174);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 9267, 9501);
                    foreach (TableColumnHeaderDefinition hd in f_1123_9310_9347_I(tcb.header.columnHeaderDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 9267, 9501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 9381, 9448);

                        TableControlColumnHeader
                        header = f_1123_9415_9447(hd)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 9466, 9486);

                        f_1123_9466_9485(f_1123_9466_9473(), header);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 9267, 9501);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 235);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 8591, 9512);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 8591, 9512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 8591, 9512);
            }
        }

        public TableControl(TableControlRow tableControlRow) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 9708, 9963);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 9794, 9905) || true) && (tableControlRow == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 9794, 9905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 9840, 9905);

                    throw f_1123_9846_9904("tableControlRows");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 9794, 9905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 9921, 9952);

                f_1123_9921_9951(f_1123_9921_9930(this), tableControlRow);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 9708, 9963);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 9708, 9963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 9708, 9963);
            }
        }

        public TableControl(TableControlRow tableControlRow, IEnumerable<TableControlColumnHeader> tableControlColumnHeaders) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 10253, 10874);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 10404, 10515) || true) && (tableControlRow == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 10404, 10515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 10450, 10515);

                    throw f_1123_10456_10514("tableControlRows");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 10404, 10515);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 10529, 10659) || true) && (tableControlColumnHeaders == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 10529, 10659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 10585, 10659);

                    throw f_1123_10591_10658("tableControlColumnHeaders");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 10529, 10659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 10675, 10706);

                f_1123_10675_10705(f_1123_10675_10684(this), tableControlRow);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 10720, 10863);
                    foreach (TableControlColumnHeader header in f_1123_10764_10789_I(tableControlColumnHeaders))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 10720, 10863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 10823, 10848);

                        f_1123_10823_10847(f_1123_10823_10835(this), header);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 10720, 10863);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 144);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 10253, 10874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 10253, 10874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 10253, 10874);
            }
        }

        static TableControl()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 6312, 10881);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 6312, 10881);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 6312, 10881);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 6312, 10881);

        System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
        f_1123_7492_7528()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 7492, 7528);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.TableControlRow>
        f_1123_7550_7577()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.TableControlRow>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 7550, 7577);
            return return_v;
        }


        System.Management.Automation.PSControlGroupBy
        f_1123_8770_8814(Microsoft.PowerShell.Commands.Internal.Format.GroupBy
        groupBy)
        {
            var return_v = PSControlGroupBy.Get(groupBy);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 8770, 8814);
            return return_v;
        }


        bool
        f_1123_8847_8868(bool?
        this_param)
        {
            var return_v = this_param.HasValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 8847, 8868);
            return return_v;
        }


        bool
        f_1123_8872_8890(bool?
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 8872, 8890);
            return return_v;
        }


        System.Management.Automation.TableControlRow
        f_1123_8989_9031(Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
        rowdefinition)
        {
            var return_v = new System.Management.Automation.TableControlRow(rowdefinition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 8989, 9031);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.TableControlRow>
        f_1123_9048_9052()
        {
            var return_v = Rows;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 9048, 9052);
            return return_v;
        }


        int
        f_1123_9048_9061(System.Collections.Generic.List<System.Management.Automation.TableControlRow>
        this_param, System.Management.Automation.TableControlRow
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 9048, 9061);
            return 0;
        }


        System.Management.Automation.TableControlRow
        f_1123_9178_9201(Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
        rowdefinition)
        {
            var return_v = new System.Management.Automation.TableControlRow(rowdefinition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 9178, 9201);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.TableControlRow>
        f_1123_9222_9226()
        {
            var return_v = Rows;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 9222, 9226);
            return return_v;
        }


        int
        f_1123_9222_9235(System.Collections.Generic.List<System.Management.Automation.TableControlRow>
        this_param, System.Management.Automation.TableControlRow
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 9222, 9235);
            return 0;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
        f_1123_9112_9138_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 9112, 9138);
            return return_v;
        }


        System.Management.Automation.TableControlColumnHeader
        f_1123_9415_9447(Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition
        colheaderdefinition)
        {
            var return_v = new System.Management.Automation.TableControlColumnHeader(colheaderdefinition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 9415, 9447);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
        f_1123_9466_9473()
        {
            var return_v = Headers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 9466, 9473);
            return return_v;
        }


        int
        f_1123_9466_9485(System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
        this_param, System.Management.Automation.TableControlColumnHeader
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 9466, 9485);
            return 0;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
        f_1123_9310_9347_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 9310, 9347);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1123_9846_9904(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 9846, 9904);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.TableControlRow>
        f_1123_9921_9930(System.Management.Automation.TableControl
        this_param)
        {
            var return_v = this_param.Rows;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 9921, 9930);
            return return_v;
        }


        int
        f_1123_9921_9951(System.Collections.Generic.List<System.Management.Automation.TableControlRow>
        this_param, System.Management.Automation.TableControlRow
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 9921, 9951);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1123_10456_10514(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 10456, 10514);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1123_10591_10658(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 10591, 10658);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.TableControlRow>
        f_1123_10675_10684(System.Management.Automation.TableControl
        this_param)
        {
            var return_v = this_param.Rows;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 10675, 10684);
            return return_v;
        }


        int
        f_1123_10675_10705(System.Collections.Generic.List<System.Management.Automation.TableControlRow>
        this_param, System.Management.Automation.TableControlRow
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 10675, 10705);
            return 0;
        }


        System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
        f_1123_10823_10835(System.Management.Automation.TableControl
        this_param)
        {
            var return_v = this_param.Headers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 10823, 10835);
            return return_v;
        }


        int
        f_1123_10823_10847(System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
        this_param, System.Management.Automation.TableControlColumnHeader
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 10823, 10847);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.TableControlColumnHeader>
        f_1123_10764_10789_I(System.Collections.Generic.IEnumerable<System.Management.Automation.TableControlColumnHeader>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 10764, 10789);
            return return_v;
        }

    }
    public sealed class TableControlColumnHeader
    {
        public string Label { get; set; }

        public Alignment Alignment { get; set; }

        public int Width { get; set; }

        internal TableControlColumnHeader(TableColumnHeaderDefinition colheaderdefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 11408, 11768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11114, 11147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11233, 11273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11366, 11396);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11515, 11640) || true) && (colheaderdefinition.label != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 11515, 11640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11586, 11625);

                    Label = colheaderdefinition.label.text;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 11515, 11640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11656, 11709);

                Alignment = (Alignment)colheaderdefinition.alignment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11723, 11757);

                Width = colheaderdefinition.width;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 11408, 11768);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 11408, 11768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 11408, 11768);
            }
        }

        public TableControlColumnHeader()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 11832, 11887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11114, 11147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11233, 11273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11366, 11396);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 11832, 11887);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 11832, 11887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 11832, 11887);
            }
        }

        public TableControlColumnHeader(string label, int width, Alignment alignment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 12249, 12570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11114, 11147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11233, 11273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 11366, 11396);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12351, 12450) || true) && (width < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 12351, 12450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12383, 12450);

                    throw f_1123_12389_12449("width", width);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 12351, 12450);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12466, 12485);

                this.Label = label;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12499, 12518);

                this.Width = width;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12532, 12559);

                this.Alignment = alignment;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 12249, 12570);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 12249, 12570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 12249, 12570);
            }
        }

        static TableControlColumnHeader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 11000, 12577);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 11000, 12577);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 11000, 12577);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 11000, 12577);

        System.Management.Automation.PSArgumentOutOfRangeException
        f_1123_12389_12449(string
        paramName, int
        actualValue)
        {
            var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 12389, 12449);
            return return_v;
        }

    }
    public sealed class TableControlColumn
    {
        public Alignment Alignment { get; set; }

        public DisplayEntry DisplayEntry { get; set; }

        public string FormatString { get; internal set; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 13222, 13317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 13280, 13306);

                return f_1123_13287_13305(f_1123_13287_13299());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 13222, 13317);

                System.Management.Automation.DisplayEntry
                f_1123_13287_13299()
                {
                    var return_v = DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 13287, 13299);
                    return return_v;
                }


                string
                f_1123_13287_13305(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 13287, 13305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 13222, 13317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 13222, 13317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableControlColumn()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 13381, 13430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12825, 12865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12923, 12969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 13036, 13085);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 13381, 13430);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 13381, 13430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 13381, 13430);
            }
        }

        internal TableControlColumn(string text, int alignment, bool isscriptblock, string formatString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 13442, 13785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12825, 12865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12923, 12969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 13036, 13085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 13563, 13596);

                Alignment = (Alignment)alignment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 13610, 13732);

                DisplayEntry = f_1123_13625_13731(text, (DynAbs.Tracing.TraceSender.Conditional_F1(1123, 13648, 13661) || ((isscriptblock && DynAbs.Tracing.TraceSender.Conditional_F2(1123, 13664, 13697)) || DynAbs.Tracing.TraceSender.Conditional_F3(1123, 13700, 13730))) ? DisplayEntryValueType.ScriptBlock : DisplayEntryValueType.Property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 13746, 13774);

                FormatString = formatString;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 13442, 13785);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 13442, 13785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 13442, 13785);
            }
        }

        public TableControlColumn(Alignment alignment, DisplayEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 13988, 14157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12825, 12865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 12923, 12969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 13036, 13085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 14079, 14106);

                this.Alignment = alignment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 14120, 14146);

                this.DisplayEntry = entry;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 13988, 14157);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 13988, 14157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 13988, 14157);
            }
        }

        internal bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 14169, 14270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 14223, 14259);

                return f_1123_14230_14258(f_1123_14230_14242());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 14169, 14270);

                System.Management.Automation.DisplayEntry
                f_1123_14230_14242()
                {
                    var return_v = DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 14230, 14242);
                    return return_v;
                }


                bool
                f_1123_14230_14258(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 14230, 14258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 14169, 14270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 14169, 14270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TableControlColumn()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 12703, 14277);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 12703, 14277);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 12703, 14277);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 12703, 14277);

        System.Management.Automation.DisplayEntry
        f_1123_13625_13731(string
        value, System.Management.Automation.DisplayEntryValueType
        type)
        {
            var return_v = new System.Management.Automation.DisplayEntry(value, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 13625, 13731);
            return return_v;
        }

    }
    public sealed class TableControlRow
    {
        public List<TableControlColumn> Columns { get; set; }

        public EntrySelectedBy SelectedBy { get; internal set; }

        public bool Wrap { get; set; }

        public TableControlRow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 14930, 15031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 14504, 14557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 14643, 14699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 14817, 14847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 14979, 15020);

                Columns = f_1123_14989_15019();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 14930, 15031);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 14930, 15031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 14930, 15031);
            }
        }

        internal TableControlRow(TableRowDefinition rowdefinition) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 15043, 16053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 15135, 15166);

                Wrap = rowdefinition.multiLine;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 15180, 15336) || true) && (rowdefinition.appliesTo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 15180, 15336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 15249, 15321);

                    SelectedBy = f_1123_15262_15320(rowdefinition.appliesTo.referenceList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 15180, 15336);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 15352, 16042);
                    foreach (TableRowItemDefinition itemdef in f_1123_15395_15430_I(rowdefinition.rowItemDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 15352, 16042);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 15464, 15538);

                        FieldPropertyToken
                        fpt = f_1123_15489_15515(itemdef.formatTokenList, 0) as FieldPropertyToken
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 15556, 15582);

                        TableControlColumn
                        column
                        = default(TableControlColumn);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 15602, 15987) || true) && (fpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 15602, 15987);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 15659, 15852);

                            column = f_1123_15668_15851(fpt.expression.expressionValue, itemdef.alignment, fpt.expression.isScriptBlock, fpt.fieldFormattingDirective.formatString);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 15602, 15987);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 15602, 15987);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 15934, 15968);

                            column = f_1123_15943_15967();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 15602, 15987);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 16007, 16027);

                        f_1123_16007_16026(f_1123_16007_16014(), column);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 15352, 16042);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 691);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 15043, 16053);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 15043, 16053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 15043, 16053);
            }
        }

        public TableControlRow(IEnumerable<TableControlColumn> columns) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 16137, 16467);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 16234, 16328) || true) && (columns == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 16234, 16328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 16272, 16328);

                    throw f_1123_16278_16327("columns");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 16234, 16328);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 16342, 16456);
                    foreach (TableControlColumn column in f_1123_16380_16387_I(columns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 16342, 16456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 16421, 16441);

                        f_1123_16421_16440(f_1123_16421_16428(), column);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 16342, 16456);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 115);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 16137, 16467);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 16137, 16467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 16137, 16467);
            }
        }

        internal bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 16479, 16758);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 16533, 16675);
                    foreach (var column in f_1123_16556_16563_I(f_1123_16556_16563()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 16533, 16675);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 16597, 16660) || true) && (!f_1123_16602_16624(column))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 16597, 16660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 16647, 16660);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 16597, 16660);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 16533, 16675);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1123, 1, 143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1123, 1, 143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 16691, 16747);

                return f_1123_16698_16708() != null && (DynAbs.Tracing.TraceSender.Expression_True(1123, 16698, 16746) && f_1123_16720_16746(f_1123_16720_16730()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 16479, 16758);

                System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                f_1123_16556_16563()
                {
                    var return_v = Columns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 16556, 16563);
                    return return_v;
                }


                bool
                f_1123_16602_16624(System.Management.Automation.TableControlColumn
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 16602, 16624);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                f_1123_16556_16563_I(System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 16556, 16563);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1123_16698_16708()
                {
                    var return_v = SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 16698, 16708);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1123_16720_16730()
                {
                    var return_v = SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 16720, 16730);
                    return return_v;
                }


                bool
                f_1123_16720_16746(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 16720, 16746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 16479, 16758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 16479, 16758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CompatibleWithOldPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 16770, 16958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 16921, 16947);

                return f_1123_16928_16938() == null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 16770, 16958);

                System.Management.Automation.EntrySelectedBy
                f_1123_16928_16938()
                {
                    var return_v = SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 16928, 16938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 16770, 16958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 16770, 16958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TableControlRow()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 14374, 16965);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 14374, 16965);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 14374, 16965);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 14374, 16965);

        System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
        f_1123_14989_15019()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.TableControlColumn>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 14989, 15019);
            return return_v;
        }


        System.Management.Automation.EntrySelectedBy
        f_1123_15262_15320(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
        references)
        {
            var return_v = EntrySelectedBy.Get(references);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 15262, 15320);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.FormatToken
        f_1123_15489_15515(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 15489, 15515);
            return return_v;
        }


        System.Management.Automation.TableControlColumn
        f_1123_15668_15851(string
        text, int
        alignment, bool
        isscriptblock, string
        formatString)
        {
            var return_v = new System.Management.Automation.TableControlColumn(text, alignment, isscriptblock, formatString);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 15668, 15851);
            return return_v;
        }


        System.Management.Automation.TableControlColumn
        f_1123_15943_15967()
        {
            var return_v = new System.Management.Automation.TableControlColumn();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 15943, 15967);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
        f_1123_16007_16014()
        {
            var return_v = Columns;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 16007, 16014);
            return return_v;
        }


        int
        f_1123_16007_16026(System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
        this_param, System.Management.Automation.TableControlColumn
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 16007, 16026);
            return 0;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
        f_1123_15395_15430_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 15395, 15430);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1123_16278_16327(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 16278, 16327);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
        f_1123_16421_16428()
        {
            var return_v = Columns;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 16421, 16428);
            return return_v;
        }


        int
        f_1123_16421_16440(System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
        this_param, System.Management.Automation.TableControlColumn
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 16421, 16440);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.TableControlColumn>
        f_1123_16380_16387_I(System.Collections.Generic.IEnumerable<System.Management.Automation.TableControlColumn>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 16380, 16387);
            return return_v;
        }

    }
    public sealed class TableRowDefinitionBuilder
    {
        internal readonly TableControlBuilder _tcb;

        internal readonly TableControlRow _tcr;

        internal TableRowDefinitionBuilder(TableControlBuilder tcb, TableControlRow tcr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 17210, 17362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 17144, 17148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 17193, 17197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 17315, 17326);

                _tcb = tcb;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 17340, 17351);

                _tcr = tcr;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 17210, 17362);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 17210, 17362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 17210, 17362);
            }
        }

        private TableRowDefinitionBuilder AddItem(string value, DisplayEntryValueType entryType, Alignment alignment, string format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 17374, 17893);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 17523, 17623) || true) && (f_1123_17527_17554(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 17523, 17623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 17573, 17623);

                    throw f_1123_17579_17622("value");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 17523, 17623);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 17639, 17803);

                var
                tableControlColumn = new TableControlColumn(alignment, f_1123_17698_17732(value, entryType))
                {
                    FormatString = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => format, 1123, 17664, 17802)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 17817, 17854);

                f_1123_17817_17853(f_1123_17817_17829(_tcr), tableControlColumn);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 17870, 17882);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 17374, 17893);

                bool
                f_1123_17527_17554(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 17527, 17554);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1123_17579_17622(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 17579, 17622);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1123_17698_17732(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 17698, 17732);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                f_1123_17817_17829(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.Columns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 17817, 17829);
                    return return_v;
                }


                int
                f_1123_17817_17853(System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                this_param, System.Management.Automation.TableControlColumn
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 17817, 17853);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 17374, 17893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 17374, 17893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableRowDefinitionBuilder AddScriptBlockColumn(string scriptBlock, Alignment alignment = Alignment.Undefined, string format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 18035, 18291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 18198, 18280);

                return f_1123_18205_18279(this, scriptBlock, DisplayEntryValueType.ScriptBlock, alignment, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 18035, 18291);

                System.Management.Automation.TableRowDefinitionBuilder
                f_1123_18205_18279(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                value, System.Management.Automation.DisplayEntryValueType
                entryType, System.Management.Automation.Alignment
                alignment, string
                format)
                {
                    var return_v = this_param.AddItem(value, entryType, alignment, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 18205, 18279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 18035, 18291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 18035, 18291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableRowDefinitionBuilder AddPropertyColumn(string propertyName, Alignment alignment = Alignment.Undefined, string format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 18434, 18686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 18595, 18675);

                return f_1123_18602_18674(this, propertyName, DisplayEntryValueType.Property, alignment, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 18434, 18686);

                System.Management.Automation.TableRowDefinitionBuilder
                f_1123_18602_18674(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                value, System.Management.Automation.DisplayEntryValueType
                entryType, System.Management.Automation.Alignment
                alignment, string
                format)
                {
                    var return_v = this_param.AddItem(value, entryType, alignment, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 18602, 18674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 18434, 18686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 18434, 18686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableControlBuilder EndRowDefinition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 18785, 18878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 18855, 18867);

                return _tcb;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 18785, 18878);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 18785, 18878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 18785, 18878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TableRowDefinitionBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 17044, 18885);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 17044, 18885);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 17044, 18885);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 17044, 18885);
    }
    public sealed class TableControlBuilder
    {
        internal readonly TableControl _table;

        internal TableControlBuilder(TableControl table)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1123, 19068, 19167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 19051, 19057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 19141, 19156);

                _table = table;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1123, 19068, 19167);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 19068, 19167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 19068, 19167);
            }
        }

        public TableControlBuilder GroupByProperty(string property, CustomControl customControl = null, string label = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 19272, 19687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 19413, 19650);

                _table.GroupBy = new PSControlGroupBy
                {
                    Expression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1123_19496_19554(property, DisplayEntryValueType.Property), 1123, 19430, 19649),
                    CustomControl = customControl,
                    Label = label
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 19664, 19676);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 19272, 19687);

                System.Management.Automation.DisplayEntry
                f_1123_19496_19554(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 19496, 19554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 19272, 19687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 19272, 19687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableControlBuilder GroupByScriptBlock(string scriptBlock, CustomControl customControl = null, string label = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 19802, 20229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 19949, 20192);

                _table.GroupBy = new PSControlGroupBy
                {
                    Expression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1123_20032_20096(scriptBlock, DisplayEntryValueType.ScriptBlock), 1123, 19966, 20191),
                    CustomControl = customControl,
                    Label = label
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 20206, 20218);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 19802, 20229);

                System.Management.Automation.DisplayEntry
                f_1123_20032_20096(string
                value, System.Management.Automation.DisplayEntryValueType
                type)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 20032, 20096);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 19802, 20229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 19802, 20229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableControlBuilder AddHeader(Alignment alignment = Alignment.Undefined, int width = 0, string label = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 20286, 20537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 20426, 20500);

                f_1123_20426_20499(f_1123_20426_20440(_table), f_1123_20445_20498(label, width, alignment));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 20514, 20526);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 20286, 20537);

                System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
                f_1123_20426_20440(System.Management.Automation.TableControl
                this_param)
                {
                    var return_v = this_param.Headers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 20426, 20440);
                    return return_v;
                }


                System.Management.Automation.TableControlColumnHeader
                f_1123_20445_20498(string
                label, int
                width, System.Management.Automation.Alignment
                alignment)
                {
                    var return_v = new System.Management.Automation.TableControlColumnHeader(label, width, alignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 20445, 20498);
                    return return_v;
                }


                int
                f_1123_20426_20499(System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
                this_param, System.Management.Automation.TableControlColumnHeader
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 20426, 20499);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 20286, 20537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 20286, 20537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableRowDefinitionBuilder StartRowDefinition(bool wrap = false, IEnumerable<string> entrySelectedByType = null, IEnumerable<DisplayEntry> entrySelectedByCondition = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 20594, 21498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 20796, 20842);

                var
                row = new TableControlRow { Wrap = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => wrap, 1123, 20806, 20841) }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 20856, 21388) || true) && (entrySelectedByType != null || (DynAbs.Tracing.TraceSender.Expression_False(1123, 20860, 20923) || entrySelectedByCondition != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 20856, 21388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 20957, 20996);

                    row.SelectedBy = f_1123_20974_20995();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 21014, 21171) || true) && (entrySelectedByType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 21014, 21171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 21087, 21152);

                        f_1123_21087_21101(row).TypeNames = f_1123_21114_21151(entrySelectedByType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 21014, 21171);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 21191, 21373) || true) && (entrySelectedByCondition != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1123, 21191, 21373);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 21269, 21354);

                        f_1123_21269_21283(row).SelectionCondition = f_1123_21305_21353(entrySelectedByCondition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 21191, 21373);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1123, 20856, 21388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 21404, 21425);

                f_1123_21404_21424(f_1123_21404_21415(_table), row);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 21439, 21487);

                return f_1123_21446_21486(this, row);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 20594, 21498);

                System.Management.Automation.EntrySelectedBy
                f_1123_20974_20995()
                {
                    var return_v = new System.Management.Automation.EntrySelectedBy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 20974, 20995);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1123_21087_21101(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 21087, 21101);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1123_21114_21151(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 21114, 21151);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1123_21269_21283(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 21269, 21283);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1123_21305_21353(System.Collections.Generic.IEnumerable<System.Management.Automation.DisplayEntry>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.DisplayEntry>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 21305, 21353);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                f_1123_21404_21415(System.Management.Automation.TableControl
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1123, 21404, 21415);
                    return return_v;
                }


                int
                f_1123_21404_21424(System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                this_param, System.Management.Automation.TableControlRow
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 21404, 21424);
                    return 0;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1123_21446_21486(System.Management.Automation.TableControlBuilder
                tcb, System.Management.Automation.TableControlRow
                tcr)
                {
                    var return_v = new System.Management.Automation.TableRowDefinitionBuilder(tcb, tcr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1123, 21446, 21486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 20594, 21498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 20594, 21498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableControl EndTable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1123, 21570, 21650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1123, 21625, 21639);

                return _table;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1123, 21570, 21650);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1123, 21570, 21650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 21570, 21650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TableControlBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1123, 18964, 21657);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1123, 18964, 21657);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1123, 18964, 21657);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1123, 18964, 21657);
    }
}
