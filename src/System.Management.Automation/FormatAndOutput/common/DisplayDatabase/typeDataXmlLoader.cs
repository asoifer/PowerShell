// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Security;
using System.Threading;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class XmlFileLoadInfo
    {
        internal XmlFileLoadInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1129, 554, 584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 892, 912);
                this.fileDirectory = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 939, 954);
                this.filePath = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 996, 1002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 1029, 1041);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1129, 554, 584);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 554, 584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 554, 584);
            }
        }

        internal XmlFileLoadInfo(string dir, string path, ConcurrentBag<string> errors, string psSnapinName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1129, 596, 864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 892, 912);
                this.fileDirectory = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 939, 954);
                this.filePath = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 996, 1002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 1029, 1041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 721, 741);

                fileDirectory = dir;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 755, 771);

                filePath = path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 785, 806);

                this.errors = errors;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 820, 853);

                this.psSnapinName = psSnapinName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1129, 596, 864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 596, 864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 596, 864);
            }
        }

        internal string fileDirectory;

        internal string filePath;

        internal ConcurrentBag<string> errors;

        internal string psSnapinName;

        static XmlFileLoadInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1129, 500, 1049);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1129, 500, 1049);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 500, 1049);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1129, 500, 1049);
    }
    internal sealed partial class TypeInfoDataBaseLoader : XmlLoaderBase
    {
        private const string
        resBaseName = "TypeInfoDataBaseLoaderStrings"
        ;

        [TraceSource("TypeInfoDataBaseLoader", "TypeInfoDataBaseLoader")]
        private static PSTraceSource s_tracer;
        private static class XmlTags
        {
            internal const string
            DefaultSettingsNode = "DefaultSettings"
            ;

            internal const string
            ConfigurationNode = "Configuration"
            ;

            internal const string
            SelectionSetsNode = "SelectionSets"
            ;

            internal const string
            ViewDefinitionsNode = "ViewDefinitions"
            ;

            internal const string
            ControlsNode = "Controls"
            ;

            internal const string
            MultilineTablesNode = "WrapTables"
            ;

            internal const string
            PropertyCountForTableNode = "PropertyCountForTable"
            ;

            internal const string
            ShowErrorsAsMessagesNode = "ShowError"
            ;

            internal const string
            ShowErrorsInFormattedOutputNode = "DisplayError"
            ;

            internal const string
            EnumerableExpansionsNode = "EnumerableExpansions"
            ;

            internal const string
            EnumerableExpansionNode = "EnumerableExpansion"
            ;

            internal const string
            ExpandNode = "Expand"
            ;

            internal const string
            ControlNode = "Control"
            ;

            internal const string
            ComplexControlNameNode = "CustomControlName"
            ;

            internal const string
            SelectionSetNode = "SelectionSet"
            ;

            internal const string
            SelectionSetNameNode = "SelectionSetName"
            ;

            internal const string
            SelectionConditionNode = "SelectionCondition"
            ;

            internal const string
            NameNode = "Name"
            ;

            internal const string
            TypesNode = "Types"
            ;

            internal const string
            TypeNameNode = "TypeName"
            ;

            internal const string
            ViewNode = "View"
            ;

            internal const string
            TableControlNode = "TableControl"
            ;

            internal const string
            ListControlNode = "ListControl"
            ;

            internal const string
            WideControlNode = "WideControl"
            ;

            internal const string
            ComplexControlNode = "CustomControl"
            ;

            internal const string
            FieldControlNode = "FieldControl"
            ;

            internal const string
            ViewSelectedByNode = "ViewSelectedBy"
            ;

            internal const string
            GroupByNode = "GroupBy"
            ;

            internal const string
            OutOfBandNode = "OutOfBand"
            ;

            internal const string
            HideTableHeadersNode = "HideTableHeaders"
            ;

            internal const string
            TableHeadersNode = "TableHeaders"
            ;

            internal const string
            TableColumnHeaderNode = "TableColumnHeader"
            ;

            internal const string
            TableRowEntriesNode = "TableRowEntries"
            ;

            internal const string
            TableRowEntryNode = "TableRowEntry"
            ;

            internal const string
            MultiLineNode = "Wrap"
            ;

            internal const string
            TableColumnItemsNode = "TableColumnItems"
            ;

            internal const string
            TableColumnItemNode = "TableColumnItem"
            ;

            internal const string
            WidthNode = "Width"
            ;

            internal const string
            ListEntriesNode = "ListEntries"
            ;

            internal const string
            ListEntryNode = "ListEntry"
            ;

            internal const string
            ListItemsNode = "ListItems"
            ;

            internal const string
            ListItemNode = "ListItem"
            ;

            internal const string
            ColumnNumberNode = "ColumnNumber"
            ;

            internal const string
            WideEntriesNode = "WideEntries"
            ;

            internal const string
            WideEntryNode = "WideEntry"
            ;

            internal const string
            WideItemNode = "WideItem"
            ;

            internal const string
            ComplexEntriesNode = "CustomEntries"
            ;

            internal const string
            ComplexEntryNode = "CustomEntry"
            ;

            internal const string
            ComplexItemNode = "CustomItem"
            ;

            internal const string
            ExpressionBindingNode = "ExpressionBinding"
            ;

            internal const string
            NewLineNode = "NewLine"
            ;

            internal const string
            TextNode = "Text"
            ;

            internal const string
            FrameNode = "Frame"
            ;

            internal const string
            LeftIndentNode = "LeftIndent"
            ;

            internal const string
            RightIndentNode = "RightIndent"
            ;

            internal const string
            FirstLineIndentNode = "FirstLineIndent"
            ;

            internal const string
            FirstLineHangingNode = "FirstLineHanging"
            ;

            internal const string
            EnumerateCollectionNode = "EnumerateCollection"
            ;

            internal const string
            AutoSizeNode = "AutoSize"
            ;

            internal const string
            AlignmentNode = "Alignment"
            ;

            internal const string
            PropertyNameNode = "PropertyName"
            ;

            internal const string
            ScriptBlockNode = "ScriptBlock"
            ;

            internal const string
            FormatStringNode = "FormatString"
            ;

            internal const string
            LabelNode = "Label"
            ;

            internal const string
            EntrySelectedByNode = "EntrySelectedBy"
            ;

            internal const string
            ItemSelectionConditionNode = "ItemSelectionCondition"
            ;

            internal const string
            AssemblyNameAttribute = "AssemblyName"
            ;

            internal const string
            BaseNameAttribute = "BaseName"
            ;

            internal const string
            ResourceIdAttribute = "ResourceId"
            ;

            static XmlTags()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1129, 1740, 7222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 1869, 1908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 1945, 1980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2017, 2052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2089, 2128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2165, 2190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2270, 2304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2341, 2392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2429, 2467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2504, 2552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2589, 2638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2675, 2722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2759, 2780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2893, 2916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 2953, 2997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3088, 3121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3158, 3199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3236, 3281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3318, 3335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3372, 3391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3428, 3453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3492, 3509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3610, 3643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3680, 3711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3748, 3779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3816, 3852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3889, 3922);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 3996, 4033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4070, 4093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4130, 4157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4232, 4273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4310, 4343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4380, 4423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4462, 4501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4538, 4573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4610, 4632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4669, 4710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4747, 4786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4823, 4842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4916, 4947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 4984, 5011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5048, 5075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5112, 5137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5211, 5244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5281, 5312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5349, 5376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5413, 5438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5515, 5551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5588, 5620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5657, 5687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5726, 5769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5806, 5829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5866, 5883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5920, 5939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 5976, 6005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6042, 6073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6110, 6149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6186, 6227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6266, 6313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6389, 6414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6484, 6511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6548, 6581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6618, 6649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6686, 6719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6756, 6775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6814, 6853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 6890, 6943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 7034, 7072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 7109, 7139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 7176, 7210);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1129, 1740, 7222);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 1740, 7222);
            }

        }
        private static class XMLStringValues
        {
            internal const string
            True = "TRUE"
            ;

            internal const string
            False = "FALSE"
            ;

            internal const string
            AlignmentLeft = "left"
            ;

            internal const string
            AlignmentCenter = "center"
            ;

            internal const string
            AlignmentRight = "right"
            ;

            static XMLStringValues()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1129, 7353, 7698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 7436, 7449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 7486, 7501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 7540, 7562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 7599, 7625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 7662, 7686);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1129, 7353, 7698);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 7353, 7698);
            }

        }

        private bool _suppressValidation;

        internal bool LoadXmlFile(
                    XmlFileLoadInfo info,
                    TypeInfoDataBase db,
                    PSPropertyExpressionFactory expressionFactory,
                    AuthorizationManager authorizationManager,
                    PSHost host,
                    bool preValidated)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 8909, 11981);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9203, 9291) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 9203, 9291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9238, 9291);

                    throw f_1129_9244_9290("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 9203, 9291);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9307, 9413) || true) && (info.filePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 9307, 9413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9351, 9413);

                    throw f_1129_9357_9412("info.filePath");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 9307, 9413);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9429, 9513) || true) && (db == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 9429, 9513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9462, 9513);

                    throw f_1129_9468_9512("db");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 9429, 9513);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9529, 9643) || true) && (expressionFactory == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 9529, 9643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9577, 9643);

                    throw f_1129_9583_9642("expressionFactory");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 9529, 9643);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9659, 9797) || true) && (f_1129_9663_9709(info.filePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 9659, 9797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9743, 9782);

                    f_1129_9743_9781(this, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 9659, 9797);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9813, 9879);

                this.displayResourceManagerCache = db.displayResourceManagerCache;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9895, 9938);

                this.expressionFactory = expressionFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 9952, 9986);

                f_1129_9952_9985(this, info);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 10000, 10041);

                f_1129_10000_10040(this, "loading file started");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 10101, 10132);

                XmlDocument
                newDocument = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 10146, 10174);

                bool
                isFullyTrusted = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 10190, 10287);

                newDocument = f_1129_10204_10286(this, authorizationManager, host, out isFullyTrusted);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 10530, 10699) || true) && (f_1129_10534_10572() == SystemEnforcementMode.Enforce)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 10530, 10699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 10639, 10684);

                    f_1129_10639_10683(this, isFullyTrusted);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 10530, 10699);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 10715, 10800) || true) && (newDocument == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 10715, 10800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 10772, 10785);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 10715, 10800);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 10908, 10962);

                bool
                previousSuppressValidation = _suppressValidation
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 11012, 11047);

                    _suppressValidation = preValidated;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 11111, 11142);

                        f_1129_11111_11141(this, newDocument, db);
                    }
                    catch (TooManyErrorsException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1129, 11179, 11346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 11314, 11327);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1129, 11179, 11346);
                    }
                    catch (Exception e) // will rethrow
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1129, 11364, 11636);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 11489, 11589);

                        f_1129_11489_11588(                    // Error in file {0}: {1}

                                            this, f_1129_11506_11587(f_1129_11524_11565(), f_1129_11567_11575(), f_1129_11577_11586(e)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 11611, 11617);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1129, 11364, 11636);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 11656, 11748) || true) && (f_1129_11660_11674(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 11656, 11748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 11716, 11729);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 11656, 11748);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1129, 11777, 11881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 11817, 11866);

                    _suppressValidation = previousSuppressValidation;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1129, 11777, 11881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 11897, 11944);

                f_1129_11897_11943(
                            this, "file loaded with no errors");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 11958, 11970);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 8909, 11981);

                System.Management.Automation.PSArgumentNullException
                f_1129_9244_9290(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 9244, 9290);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1129_9357_9412(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 9357, 9412);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1129_9468_9512(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 9468, 9512);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1129_9583_9642(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 9583, 9642);
                    return return_v;
                }


                bool
                f_1129_9663_9709(string
                file)
                {
                    var return_v = SecuritySupport.IsProductBinary(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 9663, 9709);
                    return return_v;
                }


                int
                f_1129_9743_9781(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, bool
                isProductCode)
                {
                    this_param.SetLoadingInfoIsProductCode(isProductCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 9743, 9781);
                    return 0;
                }


                int
                f_1129_9952_9985(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.XmlFileLoadInfo
                info)
                {
                    this_param.SetDatabaseLoadingInfo(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 9952, 9985);
                    return 0;
                }


                int
                f_1129_10000_10040(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 10000, 10040);
                    return 0;
                }


                System.Xml.XmlDocument
                f_1129_10204_10286(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.AuthorizationManager
                authorizationManager, System.Management.Automation.Host.PSHost
                host, out bool
                isFullyTrusted)
                {
                    var return_v = this_param.LoadXmlDocumentFromFileLoadingInfo(authorizationManager, host, out isFullyTrusted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 10204, 10286);
                    return return_v;
                }


                System.Management.Automation.Security.SystemEnforcementMode
                f_1129_10534_10572()
                {
                    var return_v = SystemPolicy.GetSystemLockdownPolicy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 10534, 10572);
                    return return_v;
                }


                int
                f_1129_10639_10683(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, bool
                isFullyTrusted)
                {
                    this_param.SetLoadingInfoIsFullyTrusted(isFullyTrusted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 10639, 10683);
                    return 0;
                }


                int
                f_1129_11111_11141(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlDocument
                doc, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db)
                {
                    this_param.LoadData(doc, db);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 11111, 11141);
                    return 0;
                }


                string
                f_1129_11524_11565()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ErrorInFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 11524, 11565);
                    return return_v;
                }


                string
                f_1129_11567_11575()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 11567, 11575);
                    return return_v;
                }


                string
                f_1129_11577_11586(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 11577, 11586);
                    return return_v;
                }


                string
                f_1129_11506_11587(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 11506, 11587);
                    return return_v;
                }


                int
                f_1129_11489_11588(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 11489, 11588);
                    return 0;
                }


                bool
                f_1129_11660_11674(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 11660, 11674);
                    return return_v;
                }


                int
                f_1129_11897_11943(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 11897, 11943);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 8909, 11981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 8909, 11981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool LoadFormattingData(
                    ExtendedTypeDefinition typeDefinition,
                    TypeInfoDataBase db,
                    PSPropertyExpressionFactory expressionFactory,
                    bool isBuiltInFormatData,
                    bool isForHelp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 12708, 14598);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 12980, 13088) || true) && (typeDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 12980, 13088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13025, 13088);

                    throw f_1129_13031_13087("typeDefinition");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 12980, 13088);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13102, 13228) || true) && (f_1129_13106_13129(typeDefinition) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 13102, 13228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13156, 13228);

                    throw f_1129_13162_13227("typeDefinition.TypeName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 13102, 13228);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13242, 13326) || true) && (db == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 13242, 13326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13275, 13326);

                    throw f_1129_13281_13325("db");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 13242, 13326);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13340, 13454) || true) && (expressionFactory == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 13340, 13454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13388, 13454);

                    throw f_1129_13394_13453("expressionFactory");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 13340, 13454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13470, 13513);

                this.expressionFactory = expressionFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13527, 13586);

                f_1129_13527_13585(this, "loading ExtendedTypeDefinition started");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13638, 13693);

                    f_1129_13638_13692(this, isBuiltInFormatData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13711, 13765);

                    f_1129_13711_13764(this, isBuiltInFormatData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13783, 13828);

                    f_1129_13783_13827(this, typeDefinition, db, isForHelp);
                }
                catch (TooManyErrorsException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1129, 13857, 14008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 13980, 13993);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1129, 13857, 14008);
                }
                catch (Exception e) // will rethrow
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1129, 14022, 14384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 14148, 14345);

                    f_1129_14148_14344(                // Error in formatting data "{0}": {1}

                                    this, f_1129_14212_14318(f_1129_14230_14281(), f_1129_14283_14306(typeDefinition), f_1129_14308_14317(e)), f_1129_14320_14343(typeDefinition));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 14363, 14369);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1129, 14022, 14384);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 14400, 14480) || true) && (f_1129_14404_14418(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 14400, 14480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 14452, 14465);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 14400, 14480);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 14496, 14561);

                f_1129_14496_14560(
                            this, "ExtendedTypeDefinition loaded with no errors");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 14575, 14587);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 12708, 14598);

                System.Management.Automation.PSArgumentNullException
                f_1129_13031_13087(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 13031, 13087);
                    return return_v;
                }


                string
                f_1129_13106_13129(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 13106, 13129);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1129_13162_13227(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 13162, 13227);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1129_13281_13325(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 13281, 13325);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1129_13394_13453(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 13394, 13453);
                    return return_v;
                }


                int
                f_1129_13527_13585(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 13527, 13585);
                    return 0;
                }


                int
                f_1129_13638_13692(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, bool
                isFullyTrusted)
                {
                    this_param.SetLoadingInfoIsFullyTrusted(isFullyTrusted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 13638, 13692);
                    return 0;
                }


                int
                f_1129_13711_13764(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, bool
                isProductCode)
                {
                    this_param.SetLoadingInfoIsProductCode(isProductCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 13711, 13764);
                    return 0;
                }


                int
                f_1129_13783_13827(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.ExtendedTypeDefinition
                typeDefinition, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, bool
                isForHelpOutput)
                {
                    this_param.LoadData(typeDefinition, db, isForHelpOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 13783, 13827);
                    return 0;
                }


                string
                f_1129_14230_14281()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ErrorInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 14230, 14281);
                    return return_v;
                }


                string
                f_1129_14283_14306(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 14283, 14306);
                    return return_v;
                }


                string
                f_1129_14308_14317(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 14308, 14317);
                    return return_v;
                }


                string
                f_1129_14212_14318(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 14212, 14318);
                    return return_v;
                }


                string
                f_1129_14320_14343(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 14320, 14343);
                    return return_v;
                }


                int
                f_1129_14148_14344(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 14148, 14344);
                    return 0;
                }


                bool
                f_1129_14404_14418(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 14404, 14418);
                    return return_v;
                }


                int
                f_1129_14496_14560(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 14496, 14560);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 12708, 14598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 12708, 14598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadData(XmlDocument doc, TypeInfoDataBase db)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 14965, 17939);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15049, 15135) || true) && (doc == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 15049, 15135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15083, 15135);

                    throw f_1129_15089_15134("doc");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 15049, 15135);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15151, 15235) || true) && (db == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 15151, 15235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15184, 15235);

                    throw f_1129_15190_15234("db");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 15151, 15235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15318, 15367);

                XmlElement
                documentElement = f_1129_15347_15366(doc)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15383, 15421);

                bool
                defaultSettingsNodeFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15435, 15464);

                bool
                typeGroupsFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15478, 15512);

                bool
                viewDefinitionsFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15526, 15563);

                bool
                controlDefinitionsFound = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15579, 17928) || true) && (f_1129_15583_15654(this, documentElement, XmlTags.ConfigurationNode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 15579, 17928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15734, 17811);
                    using (f_1129_15741_15773(this, documentElement))
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15815, 17792);
                            foreach (XmlNode n in f_1129_15837_15863_I(f_1129_15837_15863(documentElement)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 15815, 17792);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 15913, 17769) || true) && (f_1129_15917_15962(this, n, XmlTags.DefaultSettingsNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 15913, 17769);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16020, 16169) || true) && (defaultSettingsNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 16020, 16169);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16114, 16138);

                                        f_1129_16114_16137(this, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 16020, 16169);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16199, 16231);

                                    defaultSettingsNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16261, 16288);

                                    f_1129_16261_16287(this, db, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 15913, 17769);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 15913, 17769);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16346, 17769) || true) && (f_1129_16350_16393(this, n, XmlTags.SelectionSetsNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 16346, 17769);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16451, 16591) || true) && (typeGroupsFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 16451, 16591);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16536, 16560);

                                            f_1129_16536_16559(this, n);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 16451, 16591);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16623, 16646);

                                        typeGroupsFound = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16676, 16698);

                                        f_1129_16676_16697(this, db, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 16346, 17769);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 16346, 17769);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16756, 17769) || true) && (f_1129_16760_16805(this, n, XmlTags.ViewDefinitionsNode))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 16756, 17769);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16863, 17008) || true) && (viewDefinitionsFound)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 16863, 17008);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 16953, 16977);

                                                f_1129_16953_16976(this, n);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 16863, 17008);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 17040, 17068);

                                            viewDefinitionsFound = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 17098, 17125);

                                            f_1129_17098_17124(this, db, n);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 16756, 17769);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 16756, 17769);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 17183, 17769) || true) && (f_1129_17187_17225(this, n, XmlTags.ControlsNode))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 17183, 17769);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 17283, 17431) || true) && (controlDefinitionsFound)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 17283, 17431);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 17376, 17400);

                                                    f_1129_17376_17399(this, n);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 17283, 17431);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 17463, 17494);

                                                controlDefinitionsFound = true;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 17524, 17606);

                                                f_1129_17524_17605(this, n, db.formatControlDefinitionHolder.controlDefinitionList);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 17183, 17769);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 17183, 17769);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 17720, 17742);

                                                f_1129_17720_17741(this, n);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 17183, 17769);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 16756, 17769);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 16346, 17769);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 15913, 17769);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 15815, 17792);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 1978);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 1978);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 15734, 17811);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 15579, 17928);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 15579, 17928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 17877, 17913);

                    f_1129_17877_17912(this, documentElement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 15579, 17928);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 14965, 17939);

                System.Management.Automation.PSArgumentNullException
                f_1129_15089_15134(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 15089, 15134);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1129_15190_15234(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 15190, 15234);
                    return return_v;
                }


                System.Xml.XmlElement
                f_1129_15347_15366(System.Xml.XmlDocument
                this_param)
                {
                    var return_v = this_param.DocumentElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 15347, 15366);
                    return return_v;
                }


                bool
                f_1129_15583_15654(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlElement
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeNameWithAttributes((System.Xml.XmlNode)n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 15583, 15654);
                    return return_v;
                }


                System.IDisposable
                f_1129_15741_15773(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlElement
                n)
                {
                    var return_v = this_param.StackFrame((System.Xml.XmlNode)n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 15741, 15773);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1129_15837_15863(System.Xml.XmlElement
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 15837, 15863);
                    return return_v;
                }


                bool
                f_1129_15917_15962(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 15917, 15962);
                    return return_v;
                }


                int
                f_1129_16114_16137(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 16114, 16137);
                    return 0;
                }


                int
                f_1129_16261_16287(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Xml.XmlNode
                defaultSettingsNode)
                {
                    this_param.LoadDefaultSettings(db, defaultSettingsNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 16261, 16287);
                    return 0;
                }


                bool
                f_1129_16350_16393(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 16350, 16393);
                    return return_v;
                }


                int
                f_1129_16536_16559(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 16536, 16559);
                    return 0;
                }


                int
                f_1129_16676_16697(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Xml.XmlNode
                typeGroupsNode)
                {
                    this_param.LoadTypeGroups(db, typeGroupsNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 16676, 16697);
                    return 0;
                }


                bool
                f_1129_16760_16805(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 16760, 16805);
                    return return_v;
                }


                int
                f_1129_16953_16976(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 16953, 16976);
                    return 0;
                }


                int
                f_1129_17098_17124(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Xml.XmlNode
                viewDefinitionsNode)
                {
                    this_param.LoadViewDefinitions(db, viewDefinitionsNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 17098, 17124);
                    return 0;
                }


                bool
                f_1129_17187_17225(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 17187, 17225);
                    return return_v;
                }


                int
                f_1129_17376_17399(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 17376, 17399);
                    return 0;
                }


                int
                f_1129_17524_17605(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                definitionsNode, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
                controlDefinitionList)
                {
                    this_param.LoadControlDefinitions(definitionsNode, controlDefinitionList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 17524, 17605);
                    return 0;
                }


                int
                f_1129_17720_17741(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 17720, 17741);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1129_15837_15863_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 15837, 15863);
                    return return_v;
                }


                int
                f_1129_17877_17912(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlElement
                n)
                {
                    this_param.ProcessUnknownNode((System.Xml.XmlNode)n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 17877, 17912);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 14965, 17939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 14965, 17939);
            }
        }

        private void LoadData(ExtendedTypeDefinition typeDefinition, TypeInfoDataBase db, bool isForHelpOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 18617, 19946);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 18745, 18853) || true) && (typeDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 18745, 18853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 18790, 18853);

                    throw f_1129_18796_18852("viewDefinition");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 18745, 18853);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 18869, 18953) || true) && (db == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 18869, 18953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 18902, 18953);

                    throw f_1129_18908_18952("db");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 18869, 18953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 18969, 18987);

                int
                viewIndex = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 19001, 19935);
                    foreach (FormatViewDefinition formatView in f_1129_19045_19080_I(f_1129_19045_19080(typeDefinition)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 19001, 19935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 19114, 19211);

                        ViewDefinition
                        view = f_1129_19136_19210(this, f_1129_19160_19184(typeDefinition), formatView, viewIndex++)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 19229, 19920) || true) && (view != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 19229, 19920);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 19287, 19639);

                            f_1129_19287_19638(this, f_1129_19299_19637(f_1129_19313_19341(), "{0} view {1} is loaded from the 'FormatViewDefinition' at index {2} in 'ExtendedTypeDefinition' with type name {3}", f_1129_19511_19560(view.mainControl), view.name, viewIndex - 1, f_1129_19613_19636(typeDefinition)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 19725, 19780);

                            f_1129_19725_19779(
                                                // we are fine, add the view to the list
                                                db.viewDefinitionsSection.viewDefinitionList, view);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 19804, 19840);

                            view.loadingInfo = f_1129_19823_19839(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 19862, 19901);

                            view.isHelpFormatter = isForHelpOutput;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 19229, 19920);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 19001, 19935);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 935);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 935);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 18617, 19946);

                System.Management.Automation.PSArgumentNullException
                f_1129_18796_18852(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 18796, 18852);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1129_18908_18952(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 18908, 18952);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.FormatViewDefinition>
                f_1129_19045_19080(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.FormatViewDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 19045, 19080);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1129_19160_19184(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 19160, 19184);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1129_19136_19210(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Collections.Generic.List<string>
                typeNames, System.Management.Automation.FormatViewDefinition
                formatView, int
                viewIndex)
                {
                    var return_v = this_param.LoadViewFromObjectModel(typeNames, formatView, viewIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 19136, 19210);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1129_19313_19341()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 19313, 19341);
                    return return_v;
                }


                string
                f_1129_19511_19560(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control)
                {
                    var return_v = ControlBase.GetControlShapeName(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 19511, 19560);
                    return return_v;
                }


                string
                f_1129_19613_19636(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 19613, 19636);
                    return return_v;
                }


                string
                f_1129_19299_19637(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 19299, 19637);
                    return return_v;
                }


                int
                f_1129_19287_19638(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 19287, 19638);
                    return 0;
                }


                int
                f_1129_19725_19779(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 19725, 19779);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                f_1129_19823_19839(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.LoadingInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 19823, 19839);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.FormatViewDefinition>
                f_1129_19045_19080_I(System.Collections.Generic.List<System.Management.Automation.FormatViewDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 19045, 19080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 18617, 19946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 18617, 19946);
            }
        }

        private ViewDefinition LoadViewFromObjectModel(List<string> typeNames, FormatViewDefinition formatView, int viewIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 20265, 22958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 20450, 20488);

                AppliesTo
                appliesTo = f_1129_20472_20487()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 20502, 20692);
                    foreach (var typename in f_1129_20527_20536_I(typeNames))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 20502, 20692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 20570, 20627);

                        TypeReference
                        tr = new TypeReference { name = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => typename, 1129, 20589, 20626) }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 20645, 20677);

                        f_1129_20645_20676(appliesTo.referenceList, tr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 20502, 20692);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 191);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 20759, 20802);

                ViewDefinition
                view = f_1129_20781_20801()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 20816, 20843);

                view.appliesTo = appliesTo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 20857, 20885);

                view.name = f_1129_20869_20884(formatView);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 20901, 20934);

                var
                firstTypeName = f_1129_20921_20933(typeNames, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 20948, 20987);

                PSControl
                control = f_1129_20968_20986(formatView)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21001, 21881) || true) && (control is TableControl)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 21001, 21881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21062, 21105);

                    var
                    tableControl = control as TableControl
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21123, 21214);

                    view.mainControl = f_1129_21142_21213(this, tableControl, viewIndex, firstTypeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 21001, 21881);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 21001, 21881);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21248, 21881) || true) && (control is ListControl)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 21248, 21881);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21308, 21349);

                        var
                        listControl = control as ListControl
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21367, 21456);

                        view.mainControl = f_1129_21386_21455(this, listControl, viewIndex, firstTypeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 21248, 21881);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 21248, 21881);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21490, 21881) || true) && (control is WideControl)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 21490, 21881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21550, 21591);

                            var
                            wideControl = control as WideControl
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21609, 21698);

                            view.mainControl = f_1129_21628_21697(this, wideControl, viewIndex, firstTypeName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 21490, 21881);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 21490, 21881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21764, 21866);

                            view.mainControl = f_1129_21783_21865(this, control, viewIndex, firstTypeName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 21490, 21881);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 21248, 21881);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 21001, 21881);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 21959, 22048) || true) && (view.mainControl == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 21959, 22048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 22021, 22033);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 21959, 22048);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 22064, 22099);

                view.outOfBand = f_1129_22081_22098(control);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 22115, 22919) || true) && (f_1129_22119_22134(control) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 22115, 22919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 22176, 22458);

                    view.groupBy = new GroupBy
                    {
                        startGroup = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new StartGroup
                        {
                            expression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1129_22332_22415(this, f_1129_22362_22388(f_1129_22362_22377(control)), viewIndex, firstTypeName), 1129, 22256, 22438)
                        }, 1129, 22191, 22457)
                    };

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 22476, 22658) || true) && (f_1129_22480_22501(f_1129_22480_22495(control)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 22476, 22658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 22551, 22639);

                        view.groupBy.startGroup.labelTextToken = new TextToken { text = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1129_22615_22636(f_1129_22615_22630(control)), 1129, 22592, 22638) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 22476, 22658);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 22678, 22904) || true) && (f_1129_22682_22711(f_1129_22682_22697(control)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 22678, 22904);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 22761, 22885);

                        view.groupBy.startGroup.control = f_1129_22795_22884(this, f_1129_22828_22857(f_1129_22828_22843(control)), viewIndex, firstTypeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 22678, 22904);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 22115, 22919);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 22935, 22947);

                return view;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 20265, 22958);

                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1129_20472_20487()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.AppliesTo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 20472, 20487);
                    return return_v;
                }


                int
                f_1129_20645_20676(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeReference
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 20645, 20676);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1129_20527_20536_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 20527, 20536);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1129_20781_20801()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 20781, 20801);
                    return return_v;
                }


                string
                f_1129_20869_20884(System.Management.Automation.FormatViewDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 20869, 20884);
                    return return_v;
                }


                string
                f_1129_20921_20933(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 20921, 20933);
                    return return_v;
                }


                System.Management.Automation.PSControl
                f_1129_20968_20986(System.Management.Automation.FormatViewDefinition
                this_param)
                {
                    var return_v = this_param.Control;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 20968, 20986);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                f_1129_21142_21213(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.TableControl
                table, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadTableControlFromObjectModel(table, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 21142, 21213);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListControlBody
                f_1129_21386_21455(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.ListControl
                list, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadListControlFromObjectModel(list, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 21386, 21455);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideControlBody
                f_1129_21628_21697(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.WideControl
                wide, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadWideControlFromObjectModel(wide, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 21628, 21697);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                f_1129_21783_21865(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.PSControl
                custom, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadCustomControlFromObjectModel((System.Management.Automation.CustomControl)custom, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 21783, 21865);
                    return return_v;
                }


                bool
                f_1129_22081_22098(System.Management.Automation.PSControl
                this_param)
                {
                    var return_v = this_param.OutOfBand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22081, 22098);
                    return return_v;
                }


                System.Management.Automation.PSControlGroupBy
                f_1129_22119_22134(System.Management.Automation.PSControl
                this_param)
                {
                    var return_v = this_param.GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22119, 22134);
                    return return_v;
                }


                System.Management.Automation.PSControlGroupBy
                f_1129_22362_22377(System.Management.Automation.PSControl
                this_param)
                {
                    var return_v = this_param.GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22362, 22377);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1129_22362_22388(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22362, 22388);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1129_22332_22415(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.DisplayEntry
                displayEntry, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadExpressionFromObjectModel(displayEntry, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 22332, 22415);
                    return return_v;
                }


                System.Management.Automation.PSControlGroupBy
                f_1129_22480_22495(System.Management.Automation.PSControl
                this_param)
                {
                    var return_v = this_param.GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22480, 22495);
                    return return_v;
                }


                string
                f_1129_22480_22501(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22480, 22501);
                    return return_v;
                }


                System.Management.Automation.PSControlGroupBy
                f_1129_22615_22630(System.Management.Automation.PSControl
                this_param)
                {
                    var return_v = this_param.GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22615, 22630);
                    return return_v;
                }


                string
                f_1129_22615_22636(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22615, 22636);
                    return return_v;
                }


                System.Management.Automation.PSControlGroupBy
                f_1129_22682_22697(System.Management.Automation.PSControl
                this_param)
                {
                    var return_v = this_param.GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22682, 22697);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1129_22682_22711(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22682, 22711);
                    return return_v;
                }


                System.Management.Automation.PSControlGroupBy
                f_1129_22828_22843(System.Management.Automation.PSControl
                this_param)
                {
                    var return_v = this_param.GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22828, 22843);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1129_22828_22857(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 22828, 22857);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                f_1129_22795_22884(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.CustomControl
                custom, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadCustomControlFromObjectModel(custom, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 22795, 22884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 20265, 22958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 20265, 22958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ControlBase LoadTableControlFromObjectModel(TableControl table, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 23271, 25837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 23399, 23479);

                TableControlBody
                tableBody = new TableControlBody { autosize = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1129_23462_23476(table), 1129, 23428, 23478) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 23495, 23555);

                f_1129_23495_23554(this, tableBody, f_1129_23540_23553(table));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 23792, 24107) || true) && (f_1129_23796_23812(f_1129_23796_23806(table)) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 23792, 24107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 23850, 24062);

                    f_1129_23850_24061(this, f_1129_23914_24050(f_1129_23932_24001(), typeName, viewIndex, XmlTags.TableRowEntryNode), typeName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 24080, 24092);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 23792, 24107);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 24123, 24204);

                f_1129_24123_24203(this, tableBody, f_1129_24171_24181(table), viewIndex, typeName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 24322, 24422) || true) && (tableBody.defaultDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 24322, 24422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 24395, 24407);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 24322, 24422);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 24507, 25477) || true) && (f_1129_24511_24560(tableBody.header.columnHeaderDefinitionList) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 24507, 25477);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 24744, 25462) || true) && (f_1129_24748_24797(tableBody.header.columnHeaderDefinitionList) !=
                    f_1129_24822_24877(tableBody.defaultDefinition.rowItemDefinitionList))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 24744, 25462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 25044, 25392);

                        f_1129_25044_25391(                    // Error at XPath {0} in file {1}: Header item count = {2} does not match default row item count = {3}.
                                            this, f_1129_25112_25380(f_1129_25130_25200(), typeName, viewIndex, f_1129_25248_25297(tableBody.header.columnHeaderDefinitionList), f_1129_25324_25379(tableBody.defaultDefinition.rowItemDefinitionList)), typeName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 25416, 25428);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 24744, 25462);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 24507, 25477);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 25609, 25793);

                f_1129_25609_25792(f_1129_25628_25666(tableBody.optionalDefinitionList) == 0, "there should be no alternative row definitions because no SelectedBy is defined for TableControlRow");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 25809, 25826);

                return tableBody;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 23271, 25837);

                bool
                f_1129_23462_23476(System.Management.Automation.TableControl
                this_param)
                {
                    var return_v = this_param.AutoSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 23462, 23476);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
                f_1129_23540_23553(System.Management.Automation.TableControl
                this_param)
                {
                    var return_v = this_param.Headers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 23540, 23553);
                    return return_v;
                }


                int
                f_1129_23495_23554(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableControlBody
                tableBody, System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
                headers)
                {
                    this_param.LoadHeadersSectionFromObjectModel(tableBody, headers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 23495, 23554);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                f_1129_23796_23806(System.Management.Automation.TableControl
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 23796, 23806);
                    return return_v;
                }


                int
                f_1129_23796_23812(System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 23796, 23812);
                    return return_v;
                }


                string
                f_1129_23932_24001()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.MultipleRowEntriesFoundInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 23932, 24001);
                    return return_v;
                }


                string
                f_1129_23914_24050(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 23914, 24050);
                    return return_v;
                }


                int
                f_1129_23850_24061(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 23850, 24061);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                f_1129_24171_24181(System.Management.Automation.TableControl
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 24171, 24181);
                    return return_v;
                }


                int
                f_1129_24123_24203(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableControlBody
                tableBody, System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                rowEntries, int
                viewIndex, string
                typeName)
                {
                    this_param.LoadRowEntriesSectionFromObjectModel(tableBody, rowEntries, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 24123, 24203);
                    return 0;
                }


                int
                f_1129_24511_24560(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 24511, 24560);
                    return return_v;
                }


                int
                f_1129_24748_24797(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 24748, 24797);
                    return return_v;
                }


                int
                f_1129_24822_24877(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 24822, 24877);
                    return return_v;
                }


                string
                f_1129_25130_25200()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.IncorrectHeaderItemCountInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 25130, 25200);
                    return return_v;
                }


                int
                f_1129_25248_25297(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 25248, 25297);
                    return return_v;
                }


                int
                f_1129_25324_25379(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 25324, 25379);
                    return return_v;
                }


                string
                f_1129_25112_25380(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 25112, 25380);
                    return return_v;
                }


                int
                f_1129_25044_25391(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 25044, 25391);
                    return 0;
                }


                int
                f_1129_25628_25666(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 25628, 25666);
                    return return_v;
                }


                int
                f_1129_25609_25792(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 25609, 25792);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 23271, 25837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 23271, 25837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadHeadersSectionFromObjectModel(TableControlBody tableBody, List<TableControlColumnHeader> headers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 26037, 26979);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 26176, 26968);
                    foreach (TableControlColumnHeader header in f_1129_26220_26227_I(headers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 26176, 26968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 26261, 26329);

                        TableColumnHeaderDefinition
                        chd = f_1129_26295_26328()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 26568, 26781) || true) && (!f_1129_26573_26607(f_1129_26594_26606(header)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 26568, 26781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 26649, 26680);

                            TextToken
                            tt = f_1129_26664_26679()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 26702, 26725);

                            tt.text = f_1129_26712_26724(header);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 26747, 26762);

                            chd.label = tt;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 26568, 26781);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 26801, 26826);

                        chd.width = f_1129_26813_26825(header);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 26844, 26882);

                        chd.alignment = (int)f_1129_26865_26881(header);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 26900, 26953);

                        f_1129_26900_26952(tableBody.header.columnHeaderDefinitionList, chd);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 26176, 26968);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 793);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 26037, 26979);

                Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition
                f_1129_26295_26328()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 26295, 26328);
                    return return_v;
                }


                string
                f_1129_26594_26606(System.Management.Automation.TableControlColumnHeader
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 26594, 26606);
                    return return_v;
                }


                bool
                f_1129_26573_26607(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 26573, 26607);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1129_26664_26679()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 26664, 26679);
                    return return_v;
                }


                string
                f_1129_26712_26724(System.Management.Automation.TableControlColumnHeader
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 26712, 26724);
                    return return_v;
                }


                int
                f_1129_26813_26825(System.Management.Automation.TableControlColumnHeader
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 26813, 26825);
                    return return_v;
                }


                System.Management.Automation.Alignment
                f_1129_26865_26881(System.Management.Automation.TableControlColumnHeader
                this_param)
                {
                    var return_v = this_param.Alignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 26865, 26881);
                    return return_v;
                }


                int
                f_1129_26900_26952(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 26900, 26952);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
                f_1129_26220_26227_I(System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 26220, 26227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 26037, 26979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 26037, 26979);
            }
        }

        private void LoadRowEntriesSectionFromObjectModel(TableControlBody tableBody, List<TableControlRow> rowEntries, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 27303, 29062);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 27471, 28669);
                    foreach (TableControlRow row in f_1129_27503_27513_I(rowEntries))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 27471, 28669);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 27547, 27620);

                        TableRowDefinition
                        trd = new TableRowDefinition { multiLine = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1129_27609_27617(row), 1129, 27572, 27619) }
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 27808, 28254) || true) && (f_1129_27812_27829(f_1129_27812_27823(row)) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 27808, 28254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 27875, 27947);

                            f_1129_27875_27946(this, trd, f_1129_27913_27924(row), viewIndex, typeName);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 28057, 28235) || true) && (trd.rowItemDefinitionList == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 28057, 28235);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 28144, 28179);

                                tableBody.defaultDefinition = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 28205, 28212);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 28057, 28235);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 27808, 28254);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 28274, 28654) || true) && (f_1129_28278_28292(row) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 28274, 28654);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 28342, 28455);

                            trd.appliesTo = f_1129_28358_28454(this, f_1129_28394_28418(f_1129_28394_28408(row)), f_1129_28420_28453(f_1129_28420_28434(row)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 28477, 28519);

                            f_1129_28477_28518(tableBody.optionalDefinitionList, trd);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 28274, 28654);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 28274, 28654);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 28601, 28635);

                            tableBody.defaultDefinition = trd;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 28274, 28654);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 27471, 28669);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 1199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 1199);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 28730, 29051) || true) && (tableBody.defaultDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 28730, 29051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 28803, 29011);

                    f_1129_28803_29010(this, f_1129_28867_28999(f_1129_28885_28950(), typeName, viewIndex, XmlTags.TableRowEntryNode), typeName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 29029, 29036);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 28730, 29051);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 27303, 29062);

                bool
                f_1129_27609_27617(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.Wrap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 27609, 27617);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                f_1129_27812_27823(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.Columns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 27812, 27823);
                    return return_v;
                }


                int
                f_1129_27812_27829(System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 27812, 27829);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                f_1129_27913_27924(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.Columns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 27913, 27924);
                    return return_v;
                }


                int
                f_1129_27875_27946(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                trd, System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                columns, int
                viewIndex, string
                typeName)
                {
                    this_param.LoadColumnEntriesFromObjectModel(trd, columns, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 27875, 27946);
                    return 0;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_28278_28292(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 28278, 28292);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_28394_28408(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 28394, 28408);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1129_28394_28418(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 28394, 28418);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_28420_28434(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 28420, 28434);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1129_28420_28453(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 28420, 28453);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1129_28358_28454(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Collections.Generic.List<string>
                selectedBy, System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                condition)
                {
                    var return_v = this_param.LoadAppliesToSectionFromObjectModel(selectedBy, condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 28358, 28454);
                    return return_v;
                }


                int
                f_1129_28477_28518(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 28477, 28518);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                f_1129_27503_27513_I(System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 27503, 27513);
                    return return_v;
                }


                string
                f_1129_28885_28950()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoDefaultShapeEntryInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 28885, 28950);
                    return return_v;
                }


                string
                f_1129_28867_28999(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 28867, 28999);
                    return return_v;
                }


                int
                f_1129_28803_29010(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 28803, 29010);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 27303, 29062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 27303, 29062);
            }
        }

        private void LoadColumnEntriesFromObjectModel(TableRowDefinition trd, List<TableControlColumn> columns, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 29360, 30616);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 29520, 30605);
                    foreach (TableControlColumn column in f_1129_29558_29565_I(columns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 29520, 30605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 29599, 29657);

                        TableRowItemDefinition
                        rid = f_1129_29628_29656()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 29842, 30479) || true) && (f_1129_29846_29865(column) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 29842, 30479);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 29915, 30016);

                            ExpressionToken
                            expression = f_1129_29944_30015(this, f_1129_29974_29993(column), viewIndex, typeName)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 30038, 30199) || true) && (expression == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 30038, 30199);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 30110, 30143);

                                trd.rowItemDefinitionList = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 30169, 30176);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 30038, 30199);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 30223, 30273);

                            FieldPropertyToken
                            fpt = f_1129_30248_30272()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 30295, 30323);

                            fpt.expression = expression;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 30345, 30409);

                            fpt.fieldFormattingDirective.formatString = f_1129_30389_30408(column);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 30431, 30460);

                            f_1129_30431_30459(rid.formatTokenList, fpt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 29842, 30479);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 30499, 30537);

                        rid.alignment = (int)f_1129_30520_30536(column);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 30555, 30590);

                        f_1129_30555_30589(trd.rowItemDefinitionList, rid);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 29520, 30605);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 1086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 1086);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 29360, 30616);

                Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                f_1129_29628_29656()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 29628, 29656);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1129_29846_29865(System.Management.Automation.TableControlColumn
                this_param)
                {
                    var return_v = this_param.DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 29846, 29865);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1129_29974_29993(System.Management.Automation.TableControlColumn
                this_param)
                {
                    var return_v = this_param.DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 29974, 29993);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1129_29944_30015(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.DisplayEntry
                displayEntry, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadExpressionFromObjectModel(displayEntry, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 29944, 30015);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                f_1129_30248_30272()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 30248, 30272);
                    return return_v;
                }


                string
                f_1129_30389_30408(System.Management.Automation.TableControlColumn
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 30389, 30408);
                    return return_v;
                }


                int
                f_1129_30431_30459(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 30431, 30459);
                    return 0;
                }


                System.Management.Automation.Alignment
                f_1129_30520_30536(System.Management.Automation.TableControlColumn
                this_param)
                {
                    var return_v = this_param.Alignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 30520, 30536);
                    return return_v;
                }


                int
                f_1129_30555_30589(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 30555, 30589);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                f_1129_29558_29565_I(System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 29558, 29565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 29360, 30616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 29360, 30616);
            }
        }

        private ExpressionToken LoadExpressionFromObjectModel(DisplayEntry displayEntry, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 30952, 32763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 31089, 31135);

                ExpressionToken
                token = f_1129_31113_31134()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 31149, 32597) || true) && (f_1129_31153_31175(displayEntry) == DisplayEntryValueType.Property)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 31149, 32597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 31243, 31286);

                    token.expressionValue = f_1129_31267_31285(displayEntry);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 31304, 31317);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 31149, 32597);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 31149, 32597);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 31351, 32597) || true) && (f_1129_31355_31377(displayEntry) == DisplayEntryValueType.ScriptBlock)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 31351, 32597);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 31448, 31475);

                        token.isScriptBlock = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 31493, 31536);

                        token.expressionValue = f_1129_31517_31535(displayEntry);

                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 31742, 31914) || true) && (!f_1129_31747_31758().isFullyTrusted)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 31742, 31914);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 31823, 31891);

                                f_1129_31823_31890(this.expressionFactory, token.expressionValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 31742, 31914);
                            }
                        }
                        catch (ParseException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1129, 31951, 32297);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 32049, 32244);

                            f_1129_32049_32243(                    // Error at
                                                this, f_1129_32117_32232(f_1129_32135_32199(), typeName, viewIndex, f_1129_32222_32231(e)), typeName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 32266, 32278);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1129, 31951, 32297);
                        }
                        catch (Exception e) // will rethrow
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1129, 32315, 32549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 32391, 32502);

                            f_1129_32391_32501(false, "TypeInfoBaseLoader.VerifyScriptBlock unexpected exception " + f_1129_32480_32500(f_1129_32480_32491(e)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 32524, 32530);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1129, 32315, 32549);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 32569, 32582);

                        return token;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 31351, 32597);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 31149, 32597);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 32681, 32726);

                f_1129_32681_32725();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 32740, 32752);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 30952, 32763);

                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1129_31113_31134()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 31113, 31134);
                    return return_v;
                }


                System.Management.Automation.DisplayEntryValueType
                f_1129_31153_31175(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.ValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 31153, 31175);
                    return return_v;
                }


                string
                f_1129_31267_31285(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 31267, 31285);
                    return return_v;
                }


                System.Management.Automation.DisplayEntryValueType
                f_1129_31355_31377(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.ValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 31355, 31377);
                    return return_v;
                }


                string
                f_1129_31517_31535(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 31517, 31535);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                f_1129_31747_31758()
                {
                    var return_v = LoadingInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 31747, 31758);
                    return return_v;
                }


                int
                f_1129_31823_31890(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                this_param, string
                scriptText)
                {
                    this_param.VerifyScriptBlockText(scriptText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 31823, 31890);
                    return 0;
                }


                string
                f_1129_32135_32199()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidScriptBlockInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 32135, 32199);
                    return return_v;
                }


                string
                f_1129_32222_32231(System.Management.Automation.ParseException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 32222, 32231);
                    return return_v;
                }


                string
                f_1129_32117_32232(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 32117, 32232);
                    return return_v;
                }


                int
                f_1129_32049_32243(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 32049, 32243);
                    return 0;
                }


                System.Type
                f_1129_32480_32491(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 32480, 32491);
                    return return_v;
                }


                string
                f_1129_32480_32500(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 32480, 32500);
                    return return_v;
                }


                int
                f_1129_32391_32501(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 32391, 32501);
                    return 0;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1129_32681_32725()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 32681, 32725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 30952, 32763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 30952, 32763);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AppliesTo LoadAppliesToSectionFromObjectModel(List<string> selectedBy, List<DisplayEntry> condition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 32916, 33695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 33049, 33087);

                AppliesTo
                appliesTo = f_1129_33071_33086()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 33103, 33467) || true) && (selectedBy != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 33103, 33467);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 33159, 33452);
                        foreach (string type in f_1129_33183_33193_I(selectedBy))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 33159, 33452);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 33235, 33304) || true) && (f_1129_33239_33265(type))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 33235, 33304);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 33292, 33304);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 33235, 33304);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 33326, 33379);

                            TypeReference
                            tr = new TypeReference { name = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => type, 1129, 33345, 33378) }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 33401, 33433);

                            f_1129_33401_33432(appliesTo.referenceList, tr);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 33159, 33452);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 294);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 294);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 33103, 33467);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 33483, 33651) || true) && (condition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 33483, 33651);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 33538, 33636);
                        foreach (var cond in f_1129_33559_33568_I(condition))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 33538, 33636);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 33538, 33636);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 99);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 99);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 33483, 33651);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 33667, 33684);

                return appliesTo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 32916, 33695);

                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1129_33071_33086()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.AppliesTo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 33071, 33086);
                    return return_v;
                }


                bool
                f_1129_33239_33265(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 33239, 33265);
                    return return_v;
                }


                int
                f_1129_33401_33432(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeReference
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 33401, 33432);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1129_33183_33193_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 33183, 33193);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1129_33559_33568_I(System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 33559, 33568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 32916, 33695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 32916, 33695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ListControlBody LoadListControlFromObjectModel(ListControl list, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 34011, 34510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 34140, 34189);

                ListControlBody
                listBody = f_1129_34167_34188()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 34251, 34334);

                f_1129_34251_34333(this, listBody, f_1129_34299_34311(list), viewIndex, typeName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 34348, 34467) || true) && (listBody.defaultEntryDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 34348, 34467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 34425, 34437);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 34348, 34467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 34483, 34499);

                return listBody;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 34011, 34510);

                Microsoft.PowerShell.Commands.Internal.Format.ListControlBody
                f_1129_34167_34188()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListControlBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 34167, 34188);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                f_1129_34299_34311(System.Management.Automation.ListControl
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 34299, 34311);
                    return return_v;
                }


                int
                f_1129_34251_34333(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlBody
                listBody, System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                entries, int
                viewIndex, string
                typeName)
                {
                    this_param.LoadListControlEntriesFromObjectModel(listBody, entries, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 34251, 34333);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 34011, 34510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 34011, 34510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadListControlEntriesFromObjectModel(ListControlBody listBody, List<ListControlEntry> entries, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 34522, 36775);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 34769, 36354);
                    foreach (ListControlEntry listEntry in f_1129_34808_34815_I(entries))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 34769, 36354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 34849, 34961);

                        ListControlEntryDefinition
                        lved = f_1129_34883_34960(this, listEntry, viewIndex, typeName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 34979, 35348) || true) && (lved == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 34979, 35348);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 35037, 35239);

                            f_1129_35037_35238(this, f_1129_35105_35227(f_1129_35123_35182(), typeName, viewIndex, XmlTags.ListEntryNode), typeName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 35261, 35300);

                            listBody.defaultEntryDefinition = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 35322, 35329);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 34979, 35348);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 35447, 36339) || true) && (lved.appliesTo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 35447, 36339);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 35515, 36201) || true) && (listBody.defaultEntryDefinition == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 35515, 36201);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 35608, 35647);

                                listBody.defaultEntryDefinition = lved;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 35515, 36201);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 35515, 36201);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 35848, 36065);

                                f_1129_35848_36064(                        // Error at XPath {0} in file {1}: There cannot be more than one default {2}.
                                                        this, f_1129_35920_36053(f_1129_35938_36008(), typeName, viewIndex, XmlTags.ListEntryNode), typeName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 36091, 36130);

                                listBody.defaultEntryDefinition = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 36156, 36163);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 35515, 36201);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 35447, 36339);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 35447, 36339);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 36283, 36320);

                            f_1129_36283_36319(listBody.optionalEntryList, lved);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 35447, 36339);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 34769, 36354);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 1586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 1586);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 36406, 36764) || true) && (listBody.defaultEntryDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 36406, 36764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 36545, 36749);

                    f_1129_36545_36748(                // Error: there must be at least one default
                                    this, f_1129_36609_36737(f_1129_36627_36692(), typeName, viewIndex, XmlTags.ListEntryNode), typeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 36406, 36764);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 34522, 36775);

                Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                f_1129_34883_34960(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.ListControlEntry
                listEntry, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadListControlEntryDefinitionFromObjectModel(listEntry, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 34883, 34960);
                    return return_v;
                }


                string
                f_1129_35123_35182()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.LoadTagFailedInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 35123, 35182);
                    return return_v;
                }


                string
                f_1129_35105_35227(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 35105, 35227);
                    return return_v;
                }


                int
                f_1129_35037_35238(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 35037, 35238);
                    return 0;
                }


                string
                f_1129_35938_36008()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.TooManyDefaultShapeEntryInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 35938, 36008);
                    return return_v;
                }


                string
                f_1129_35920_36053(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 35920, 36053);
                    return return_v;
                }


                int
                f_1129_35848_36064(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 35848, 36064);
                    return 0;
                }


                int
                f_1129_36283_36319(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 36283, 36319);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                f_1129_34808_34815_I(System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 34808, 34815);
                    return return_v;
                }


                string
                f_1129_36627_36692()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoDefaultShapeEntryInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 36627, 36692);
                    return return_v;
                }


                string
                f_1129_36609_36737(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 36609, 36737);
                    return return_v;
                }


                int
                f_1129_36545_36748(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 36545, 36748);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 34522, 36775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 34522, 36775);
            }
        }

        private ListControlEntryDefinition LoadListControlEntryDefinitionFromObjectModel(ListControlEntry listEntry, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 37065, 37969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 37230, 37297);

                ListControlEntryDefinition
                lved = f_1129_37264_37296()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 37492, 37714) || true) && (f_1129_37496_37521(listEntry) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 37492, 37714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 37563, 37699);

                    lved.appliesTo = f_1129_37580_37698(this, f_1129_37616_37651(f_1129_37616_37641(listEntry)), f_1129_37653_37697(f_1129_37653_37678(listEntry)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 37492, 37714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 37730, 37820);

                f_1129_37730_37819(this, lved, f_1129_37782_37797(listEntry), viewIndex, typeName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 37834, 37930) || true) && (lved.itemDefinitionList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 37834, 37930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 37903, 37915);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 37834, 37930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 37946, 37958);

                return lved;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 37065, 37969);

                Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                f_1129_37264_37296()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 37264, 37296);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_37496_37521(System.Management.Automation.ListControlEntry
                this_param)
                {
                    var return_v = this_param.EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 37496, 37521);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_37616_37641(System.Management.Automation.ListControlEntry
                this_param)
                {
                    var return_v = this_param.EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 37616, 37641);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1129_37616_37651(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 37616, 37651);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_37653_37678(System.Management.Automation.ListControlEntry
                this_param)
                {
                    var return_v = this_param.EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 37653, 37678);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1129_37653_37697(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 37653, 37697);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1129_37580_37698(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Collections.Generic.List<string>
                selectedBy, System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                condition)
                {
                    var return_v = this_param.LoadAppliesToSectionFromObjectModel(selectedBy, condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 37580, 37698);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                f_1129_37782_37797(System.Management.Automation.ListControlEntry
                this_param)
                {
                    var return_v = this_param.Items;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 37782, 37797);
                    return return_v;
                }


                int
                f_1129_37730_37819(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                lved, System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                listItems, int
                viewIndex, string
                typeName)
                {
                    this_param.LoadListControlItemDefinitionsFromObjectModel(lved, listItems, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 37730, 37819);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 37065, 37969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 37065, 37969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadListControlItemDefinitionsFromObjectModel(ListControlEntryDefinition lved, List<ListControlEntryItem> listItems, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 38266, 40256);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 38452, 39746);
                    foreach (ListControlEntryItem listItem in f_1129_38494_38503_I(listItems))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 38452, 39746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 38537, 38602);

                        ListControlItemDefinition
                        lvid = f_1129_38570_38601()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 38788, 39439) || true) && (f_1129_38792_38813(listItem) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 38788, 39439);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 38863, 38966);

                            ExpressionToken
                            expression = f_1129_38892_38965(this, f_1129_38922_38943(listItem), viewIndex, typeName)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 38988, 39156) || true) && (expression == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 38988, 39156);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39060, 39091);

                                lved.itemDefinitionList = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39117, 39124);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 38988, 39156);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39180, 39230);

                            FieldPropertyToken
                            fpt = f_1129_39205_39229()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39252, 39280);

                            fpt.expression = expression;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39302, 39368);

                            fpt.fieldFormattingDirective.formatString = f_1129_39346_39367(listItem);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39390, 39420);

                            f_1129_39390_39419(lvid.formatTokenList, fpt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 38788, 39439);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39459, 39677) || true) && (!f_1129_39464_39500(f_1129_39485_39499(listItem)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 39459, 39677);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39542, 39573);

                            TextToken
                            tt = f_1129_39557_39572()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39595, 39620);

                            tt.text = f_1129_39605_39619(listItem);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39642, 39658);

                            lvid.label = tt;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 39459, 39677);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39697, 39731);

                        f_1129_39697_39730(
                                        lved.itemDefinitionList, lvid);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 38452, 39746);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 1295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 1295);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39825, 40245) || true) && (f_1129_39829_39858(lved.itemDefinitionList) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 39825, 40245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 39971, 40147);

                    f_1129_39971_40146(                // Error: At least one list view item must be specified.
                                    this, f_1129_40035_40135(f_1129_40053_40113(), typeName, viewIndex), typeName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 40165, 40196);

                    lved.itemDefinitionList = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 40214, 40221);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 39825, 40245);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 38266, 40256);

                Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition
                f_1129_38570_38601()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 38570, 38601);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1129_38792_38813(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 38792, 38813);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1129_38922_38943(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 38922, 38943);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1129_38892_38965(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.DisplayEntry
                displayEntry, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadExpressionFromObjectModel(displayEntry, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 38892, 38965);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                f_1129_39205_39229()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 39205, 39229);
                    return return_v;
                }


                string
                f_1129_39346_39367(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 39346, 39367);
                    return return_v;
                }


                int
                f_1129_39390_39419(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 39390, 39419);
                    return 0;
                }


                string
                f_1129_39485_39499(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 39485, 39499);
                    return return_v;
                }


                bool
                f_1129_39464_39500(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 39464, 39500);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1129_39557_39572()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 39557, 39572);
                    return return_v;
                }


                string
                f_1129_39605_39619(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 39605, 39619);
                    return return_v;
                }


                int
                f_1129_39697_39730(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 39697, 39730);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                f_1129_38494_38503_I(System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 38494, 38503);
                    return return_v;
                }


                int
                f_1129_39829_39858(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 39829, 39858);
                    return return_v;
                }


                string
                f_1129_40053_40113()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoListViewItemInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 40053, 40113);
                    return return_v;
                }


                string
                f_1129_40035_40135(string
                formatSpec, string
                o1, int
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 40035, 40135);
                    return return_v;
                }


                int
                f_1129_39971_40146(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 39971, 40146);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 38266, 40256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 38266, 40256);
            }
        }

        private WideControlBody LoadWideControlFromObjectModel(WideControl wide, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 40615, 41419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 40744, 40793);

                WideControlBody
                wideBody = f_1129_40771_40792()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 40956, 40993);

                wideBody.columns = (int)f_1129_40980_40992(wide);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 41009, 41070) || true) && (f_1129_41013_41026(wide))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 41009, 41070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 41045, 41070);

                    wideBody.autosize = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 41009, 41070);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 41086, 41169);

                f_1129_41086_41168(this, wideBody, f_1129_41134_41146(wide), viewIndex, typeName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 41183, 41376) || true) && (wideBody.defaultEntryDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 41183, 41376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 41349, 41361);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 41183, 41376);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 41392, 41408);

                return wideBody;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 40615, 41419);

                Microsoft.PowerShell.Commands.Internal.Format.WideControlBody
                f_1129_40771_40792()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WideControlBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 40771, 40792);
                    return return_v;
                }


                uint
                f_1129_40980_40992(System.Management.Automation.WideControl
                this_param)
                {
                    var return_v = this_param.Columns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 40980, 40992);
                    return return_v;
                }


                bool
                f_1129_41013_41026(System.Management.Automation.WideControl
                this_param)
                {
                    var return_v = this_param.AutoSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 41013, 41026);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                f_1129_41134_41146(System.Management.Automation.WideControl
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 41134, 41146);
                    return return_v;
                }


                int
                f_1129_41086_41168(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.WideControlBody
                wideBody, System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                wideEntries, int
                viewIndex, string
                typeName)
                {
                    this_param.LoadWideControlEntriesFromObjectModel(wideBody, wideEntries, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 41086, 41168);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 40615, 41419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 40615, 41419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadWideControlEntriesFromObjectModel(WideControlBody wideBody, List<WideControlEntryItem> wideEntries, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 41693, 43764);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 41866, 43441);
                    foreach (WideControlEntryItem wideItem in f_1129_41908_41919_I(wideEntries))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 41866, 43441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 41953, 42054);

                        WideControlEntryDefinition
                        wved = f_1129_41987_42053(this, wideItem, viewIndex, typeName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 42072, 42433) || true) && (wved == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 42072, 42433);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 42130, 42324);

                            f_1129_42130_42323(this, f_1129_42198_42312(f_1129_42216_42267(), typeName, viewIndex, XmlTags.WideEntryNode), typeName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 42346, 42385);

                            wideBody.defaultEntryDefinition = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 42407, 42414);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 42072, 42433);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 42534, 43426) || true) && (wved.appliesTo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 42534, 43426);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 42602, 43288) || true) && (wideBody.defaultEntryDefinition == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 42602, 43288);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 42695, 42734);

                                wideBody.defaultEntryDefinition = wved;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 42602, 43288);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 42602, 43288);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 42935, 43152);

                                f_1129_42935_43151(                        // Error at XPath {0} in file {1}: There cannot be more than one default {2}.
                                                        this, f_1129_43007_43140(f_1129_43025_43095(), typeName, viewIndex, XmlTags.WideEntryNode), typeName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 43178, 43217);

                                wideBody.defaultEntryDefinition = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 43243, 43250);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 42602, 43288);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 42534, 43426);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 42534, 43426);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 43370, 43407);

                            f_1129_43370_43406(wideBody.optionalEntryList, wved);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 42534, 43426);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 41866, 43441);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 1576);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 1576);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 43457, 43753) || true) && (wideBody.defaultEntryDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 43457, 43753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 43534, 43738);

                    f_1129_43534_43737(this, f_1129_43598_43726(f_1129_43616_43681(), typeName, viewIndex, XmlTags.WideEntryNode), typeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 43457, 43753);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 41693, 43764);

                Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
                f_1129_41987_42053(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.WideControlEntryItem
                wideItem, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadWideControlEntryFromObjectModel(wideItem, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 41987, 42053);
                    return return_v;
                }


                string
                f_1129_42216_42267()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 42216, 42267);
                    return return_v;
                }


                string
                f_1129_42198_42312(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 42198, 42312);
                    return return_v;
                }


                int
                f_1129_42130_42323(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 42130, 42323);
                    return 0;
                }


                string
                f_1129_43025_43095()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.TooManyDefaultShapeEntryInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 43025, 43095);
                    return return_v;
                }


                string
                f_1129_43007_43140(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 43007, 43140);
                    return return_v;
                }


                int
                f_1129_42935_43151(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 42935, 43151);
                    return 0;
                }


                int
                f_1129_43370_43406(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 43370, 43406);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                f_1129_41908_41919_I(System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 41908, 41919);
                    return return_v;
                }


                string
                f_1129_43616_43681()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoDefaultShapeEntryInFormattingData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 43616, 43681);
                    return return_v;
                }


                string
                f_1129_43598_43726(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 43598, 43726);
                    return return_v;
                }


                int
                f_1129_43534_43737(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message, string
                typeName)
                {
                    this_param.ReportErrorForLoadingFromObjectModel(message, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 43534, 43737);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 41693, 43764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 41693, 43764);
            }
        }

        private WideControlEntryDefinition LoadWideControlEntryFromObjectModel(WideControlEntryItem wideItem, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 44052, 45281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 44210, 44277);

                WideControlEntryDefinition
                wved = f_1129_44244_44276()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 44520, 44739) || true) && (f_1129_44524_44548(wideItem) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 44520, 44739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 44590, 44724);

                    wved.appliesTo = f_1129_44607_44723(this, f_1129_44643_44677(f_1129_44643_44667(wideItem)), f_1129_44679_44722(f_1129_44679_44703(wideItem)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 44520, 44739);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 44801, 44904);

                ExpressionToken
                expression = f_1129_44830_44903(this, f_1129_44860_44881(wideItem), viewIndex, typeName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 44918, 45010) || true) && (expression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 44918, 45010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 44974, 44986);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 44918, 45010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45026, 45076);

                FieldPropertyToken
                fpt = f_1129_45051_45075()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45090, 45118);

                fpt.expression = expression;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45132, 45198);

                fpt.fieldFormattingDirective.formatString = f_1129_45176_45197(wideItem);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45212, 45242);

                f_1129_45212_45241(wved.formatTokenList, fpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45258, 45270);

                return wved;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 44052, 45281);

                Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
                f_1129_44244_44276()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 44244, 44276);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_44524_44548(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 44524, 44548);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_44643_44667(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 44643, 44667);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1129_44643_44677(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 44643, 44677);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_44679_44703(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 44679, 44703);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1129_44679_44722(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 44679, 44722);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1129_44607_44723(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Collections.Generic.List<string>
                selectedBy, System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                condition)
                {
                    var return_v = this_param.LoadAppliesToSectionFromObjectModel(selectedBy, condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 44607, 44723);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1129_44860_44881(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 44860, 44881);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1129_44830_44903(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.DisplayEntry
                displayEntry, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadExpressionFromObjectModel(displayEntry, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 44830, 44903);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                f_1129_45051_45075()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 45051, 45075);
                    return return_v;
                }


                string
                f_1129_45176_45197(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 45176, 45197);
                    return return_v;
                }


                int
                f_1129_45212_45241(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 45212, 45241);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 44052, 45281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 44052, 45281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ComplexControlBody LoadCustomControlFromObjectModel(CustomControl custom, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 45370, 46181);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45508, 45583) || true) && (custom._cachedBody != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 45508, 45583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45557, 45583);

                    return custom._cachedBody;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 45508, 45583);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45599, 45634);

                var
                ccb = f_1129_45609_45633()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45650, 46066);
                    foreach (var entry in f_1129_45672_45686_I(f_1129_45672_45686(custom)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 45650, 46066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45720, 45808);

                        var
                        cced = f_1129_45731_45807(this, entry, viewIndex, typeName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45826, 46051) || true) && (cced.appliesTo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 45826, 46051);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 45894, 45918);

                            ccb.defaultEntry = cced;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 45826, 46051);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 45826, 46051);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 46000, 46032);

                            f_1129_46000_46031(ccb.optionalEntryList, cced);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 45826, 46051);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 45650, 46066);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 46082, 46145);

                f_1129_46082_46144(ref custom._cachedBody, ccb, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 46159, 46170);

                return ccb;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 45370, 46181);

                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                f_1129_45609_45633()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 45609, 45633);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                f_1129_45672_45686(System.Management.Automation.CustomControl
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 45672, 45686);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
                f_1129_45731_45807(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.CustomControlEntry
                entry, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadComplexControlEntryDefinitionFromObjectModel(entry, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 45731, 45807);
                    return return_v;
                }


                int
                f_1129_46000_46031(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 46000, 46031);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                f_1129_45672_45686_I(System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 45672, 45686);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                f_1129_46082_46144(ref Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                location1, Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                value, Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 46082, 46144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 45370, 46181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 45370, 46181);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ComplexControlEntryDefinition LoadComplexControlEntryDefinitionFromObjectModel(CustomControlEntry entry, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 46193, 46859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 46362, 46409);

                var
                cced = f_1129_46373_46408()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 46423, 46618) || true) && (f_1129_46427_46443(entry) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 46423, 46618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 46485, 46603);

                    cced.appliesTo = f_1129_46502_46602(this, f_1129_46538_46564(f_1129_46538_46554(entry)), f_1129_46566_46601(f_1129_46566_46582(entry)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 46423, 46618);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 46634, 46820);
                    foreach (var item in f_1129_46655_46672_I(f_1129_46655_46672(entry)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 46634, 46820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 46706, 46805);

                        f_1129_46706_46804(cced.itemDefinition.formatTokenList, f_1129_46746_46803(this, item, viewIndex, typeName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 46634, 46820);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 46836, 46848);

                return cced;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 46193, 46859);

                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
                f_1129_46373_46408()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 46373, 46408);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_46427_46443(System.Management.Automation.CustomControlEntry
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 46427, 46443);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_46538_46554(System.Management.Automation.CustomControlEntry
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 46538, 46554);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1129_46538_46564(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 46538, 46564);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1129_46566_46582(System.Management.Automation.CustomControlEntry
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 46566, 46582);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1129_46566_46601(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 46566, 46601);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1129_46502_46602(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Collections.Generic.List<string>
                selectedBy, System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                condition)
                {
                    var return_v = this_param.LoadAppliesToSectionFromObjectModel(selectedBy, condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 46502, 46602);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1129_46655_46672(System.Management.Automation.CustomControlEntry
                this_param)
                {
                    var return_v = this_param.CustomItems;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 46655, 46672);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatToken
                f_1129_46746_46803(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.CustomItemBase
                item, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadFormatTokenFromObjectModel(item, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 46746, 46803);
                    return return_v;
                }


                int
                f_1129_46706_46804(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatToken
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 46706, 46804);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1129_46655_46672_I(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 46655, 46672);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 46193, 46859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 46193, 46859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FormatToken LoadFormatTokenFromObjectModel(CustomItemBase item, int viewIndex, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 46871, 48909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 46999, 47039);

                var
                newline = item as CustomItemNewline
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47053, 47171) || true) && (newline != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 47053, 47171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47106, 47156);

                    return new NewLineToken { count = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1129_47140_47153(newline), 1129, 47113, 47155) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 47053, 47171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47187, 47221);

                var
                text = item as CustomItemText
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47235, 47342) || true) && (text != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 47235, 47342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47285, 47327);

                    return new TextToken { text = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1129_47315_47324(text), 1129, 47292, 47326) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 47235, 47342);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47358, 47398);

                var
                expr = item as CustomItemExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47412, 48208) || true) && (expr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 47412, 48208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47462, 47549);

                    var
                    cpt = new CompoundPropertyToken { enumerateCollection = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1129_47522_47546(expr), 1129, 47472, 47548) }
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47569, 47770) || true) && (f_1129_47573_47600(expr) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 47569, 47770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47650, 47751);

                        cpt.conditionToken = f_1129_47671_47750(this, f_1129_47701_47728(expr), viewIndex, typeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 47569, 47770);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47790, 47963) || true) && (f_1129_47794_47809(expr) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 47790, 47963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47859, 47944);

                        cpt.expression = f_1129_47876_47943(this, f_1129_47906_47921(expr), viewIndex, typeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 47790, 47963);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 47983, 48162) || true) && (f_1129_47987_48005(expr) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 47983, 48162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 48055, 48143);

                        cpt.control = f_1129_48069_48142(this, f_1129_48102_48120(expr), viewIndex, typeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 47983, 48162);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 48182, 48193);

                    return cpt;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 47412, 48208);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 48224, 48258);

                var
                frame = (CustomItemFrame)item
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 48272, 48662);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => { }
                

                var
                frameToken = new FrameToken
                {
                    frameInfoDefinition =
                    {
                        leftIndentation = (int)f_1129_48422_48438(frame),
                        rightIndentation = (int)f_1129_48486_48503(frame),
                        firstLine = (DynAbs.Tracing.TraceSender.Conditional_F1(1129, 48538, 48565) || 
                            ((f_1129_48538_48560(frame) != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1129, 48568, 48597)) || 
                            DynAbs.Tracing.TraceSender.Conditional_F3(1129, 48600, 48627))) ? -(int)f_1129_48575_48597(frame) : (int)f_1129_48606_48627(frame)                
                    }
                }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 48678, 48864);
                    foreach (var i in f_1129_48696_48713_I(f_1129_48696_48713(frame)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 48678, 48864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 48747, 48849);

                        f_1129_48747_48848(frameToken.itemDefinition.formatTokenList, f_1129_48793_48847(this, i, viewIndex, typeName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 48678, 48864);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 48880, 48898);

                return frameToken;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 46871, 48909);

                int
                f_1129_47140_47153(System.Management.Automation.CustomItemNewline
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 47140, 47153);
                    return return_v;
                }


                string
                f_1129_47315_47324(System.Management.Automation.CustomItemText
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 47315, 47324);
                    return return_v;
                }


                bool
                f_1129_47522_47546(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.EnumerateCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 47522, 47546);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1129_47573_47600(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 47573, 47600);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1129_47701_47728(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 47701, 47728);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1129_47671_47750(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.DisplayEntry
                displayEntry, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadExpressionFromObjectModel(displayEntry, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 47671, 47750);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1129_47794_47809(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 47794, 47809);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1129_47906_47921(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 47906, 47921);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1129_47876_47943(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.DisplayEntry
                displayEntry, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadExpressionFromObjectModel(displayEntry, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 47876, 47943);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1129_47987_48005(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 47987, 48005);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1129_48102_48120(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 48102, 48120);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                f_1129_48069_48142(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.CustomControl
                custom, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadCustomControlFromObjectModel(custom, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 48069, 48142);
                    return return_v;
                }


                uint
                f_1129_48422_48438(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.LeftIndent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 48422, 48438);
                    return return_v;
                }


                uint
                f_1129_48486_48503(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.RightIndent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 48486, 48503);
                    return return_v;
                }


                uint
                f_1129_48538_48560(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.FirstLineHanging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 48538, 48560);
                    return return_v;
                }


                uint
                f_1129_48575_48597(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.FirstLineHanging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 48575, 48597);
                    return return_v;
                }


                uint
                f_1129_48606_48627(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.FirstLineIndent
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 48606, 48627);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1129_48696_48713(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.CustomItems;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 48696, 48713);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatToken
                f_1129_48793_48847(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Management.Automation.CustomItemBase
                item, int
                viewIndex, string
                typeName)
                {
                    var return_v = this_param.LoadFormatTokenFromObjectModel(item, viewIndex, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 48793, 48847);
                    return return_v;
                }


                int
                f_1129_48747_48848(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatToken
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 48747, 48848);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1129_48696_48713_I(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 48696, 48713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 46871, 48909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 46871, 48909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadDefaultSettings(TypeInfoDataBase db, XmlNode defaultSettingsNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 49076, 53279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49241, 49281);

                bool
                propertyCountForTableFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49295, 49334);

                bool
                showErrorsAsMessagesFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49348, 49394);

                bool
                showErrorsInFormattedOutputFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49408, 49447);

                bool
                enumerableExpansionsFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49461, 49495);

                bool
                multilineTablesFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49511, 49524);

                bool
                tempVal
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49540, 53268);
                using (f_1129_49547_49583(this, defaultSettingsNode))
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49617, 53253);
                        foreach (XmlNode n in f_1129_49639_49669_I(f_1129_49639_49669(defaultSettingsNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 49617, 53253);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49711, 53234) || true) && (f_1129_49715_49765(this, n, XmlTags.ShowErrorsAsMessagesNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 49711, 53234);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49815, 49953) || true) && (showErrorsAsMessagesFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 49815, 49953);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49902, 49926);

                                    f_1129_49902_49925(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 49815, 49953);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 49981, 50014);

                                showErrorsAsMessagesFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50040, 50181) || true) && (f_1129_50044_50075(this, n, out tempVal))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 50040, 50181);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50106, 50181);

                                    db.defaultSettingsSection.formatErrorPolicy.ShowErrorsAsMessages = tempVal;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 50040, 50181);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 49711, 53234);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 49711, 53234);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50231, 53234) || true) && (f_1129_50235_50292(this, n, XmlTags.ShowErrorsInFormattedOutputNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 50231, 53234);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50342, 50487) || true) && (showErrorsInFormattedOutputFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 50342, 50487);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50436, 50460);

                                        f_1129_50436_50459(this, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 50342, 50487);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50515, 50555);

                                    showErrorsInFormattedOutputFound = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50581, 50729) || true) && (f_1129_50585_50616(this, n, out tempVal))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 50581, 50729);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50647, 50729);

                                        db.defaultSettingsSection.formatErrorPolicy.ShowErrorsInFormattedOutput = tempVal;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 50581, 50729);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 50231, 53234);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 50231, 53234);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50779, 53234) || true) && (f_1129_50783_50834(this, n, XmlTags.PropertyCountForTableNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 50779, 53234);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50884, 51023) || true) && (propertyCountForTableFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 50884, 51023);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 50972, 50996);

                                            f_1129_50972_50995(this, n);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 50884, 51023);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 51051, 51085);

                                        propertyCountForTableFound = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 51111, 51119);

                                        int
                                        val
                                        = default(int);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 51145, 51698) || true) && (f_1129_51149_51185(this, n, out val))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 51145, 51698);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 51243, 51322);

                                            db.defaultSettingsSection.shapeSelectionDirectives.PropertyCountForTable = val;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 51145, 51698);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 51145, 51698);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 51519, 51671);

                                            f_1129_51519_51670(                            // Error at XPath {0} in file {1}: Invalid {2} value.
                                                                        this, f_1129_51536_51669(f_1129_51554_51600(), f_1129_51602_51623(this), f_1129_51625_51633(), XmlTags.PropertyCountForTableNode));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 51145, 51698);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 50779, 53234);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 50779, 53234);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 51748, 53234) || true) && (f_1129_51752_51797(this, n, XmlTags.MultilineTablesNode))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 51748, 53234);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 51847, 51980) || true) && (multilineTablesFound)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 51847, 51980);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 51929, 51953);

                                                f_1129_51929_51952(this, n);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 51847, 51980);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 52008, 52036);

                                            multilineTablesFound = true;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 52062, 52577) || true) && (f_1129_52066_52097(this, n, out tempVal))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 52062, 52577);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 52155, 52207);

                                                db.defaultSettingsSection.MultilineTables = tempVal;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 52062, 52577);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 52062, 52577);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 52404, 52550);

                                                f_1129_52404_52549(                            // Error at XPath {0} in file {1}: Invalid {2} value.
                                                                            this, f_1129_52421_52548(f_1129_52439_52485(), f_1129_52487_52508(this), f_1129_52510_52518(), XmlTags.MultilineTablesNode));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 52062, 52577);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 51748, 53234);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 51748, 53234);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 52627, 53234) || true) && (f_1129_52631_52681(this, n, XmlTags.EnumerableExpansionsNode))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 52627, 53234);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 52731, 52869) || true) && (enumerableExpansionsFound)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 52731, 52869);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 52818, 52842);

                                                    f_1129_52818_52841(this, n);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 52731, 52869);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 52897, 52930);

                                                enumerableExpansionsFound = true;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 52956, 53086);

                                                db.defaultSettingsSection.enumerableExpansionDirectiveList =
                                                f_1129_53046_53085(this, n);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 52627, 53234);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 52627, 53234);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 53184, 53211);

                                                f_1129_53184_53210(this, n);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 52627, 53234);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 51748, 53234);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 50779, 53234);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 50231, 53234);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 49711, 53234);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 49617, 53253);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 3637);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 3637);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 49540, 53268);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 49076, 53279);

                System.IDisposable
                f_1129_49547_49583(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 49547, 49583);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1129_49639_49669(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 49639, 49669);
                    return return_v;
                }


                bool
                f_1129_49715_49765(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 49715, 49765);
                    return return_v;
                }


                int
                f_1129_49902_49925(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 49902, 49925);
                    return 0;
                }


                bool
                f_1129_50044_50075(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                collectionElement, out bool
                val)
                {
                    var return_v = this_param.ReadBooleanNode(collectionElement, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 50044, 50075);
                    return return_v;
                }


                bool
                f_1129_50235_50292(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 50235, 50292);
                    return return_v;
                }


                int
                f_1129_50436_50459(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 50436, 50459);
                    return 0;
                }


                bool
                f_1129_50585_50616(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                collectionElement, out bool
                val)
                {
                    var return_v = this_param.ReadBooleanNode(collectionElement, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 50585, 50616);
                    return return_v;
                }


                bool
                f_1129_50783_50834(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 50783, 50834);
                    return return_v;
                }


                int
                f_1129_50972_50995(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 50972, 50995);
                    return 0;
                }


                bool
                f_1129_51149_51185(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, out int
                val)
                {
                    var return_v = this_param.ReadPositiveIntegerValue(n, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 51149, 51185);
                    return return_v;
                }


                string
                f_1129_51554_51600()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidNodeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 51554, 51600);
                    return return_v;
                }


                string
                f_1129_51602_51623(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 51602, 51623);
                    return return_v;
                }


                string
                f_1129_51625_51633()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 51625, 51633);
                    return return_v;
                }


                string
                f_1129_51536_51669(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 51536, 51669);
                    return return_v;
                }


                int
                f_1129_51519_51670(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 51519, 51670);
                    return 0;
                }


                bool
                f_1129_51752_51797(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 51752, 51797);
                    return return_v;
                }


                int
                f_1129_51929_51952(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 51929, 51952);
                    return 0;
                }


                bool
                f_1129_52066_52097(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                collectionElement, out bool
                val)
                {
                    var return_v = this_param.ReadBooleanNode(collectionElement, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 52066, 52097);
                    return return_v;
                }


                string
                f_1129_52439_52485()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidNodeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 52439, 52485);
                    return return_v;
                }


                string
                f_1129_52487_52508(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 52487, 52508);
                    return return_v;
                }


                string
                f_1129_52510_52518()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 52510, 52518);
                    return return_v;
                }


                string
                f_1129_52421_52548(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 52421, 52548);
                    return return_v;
                }


                int
                f_1129_52404_52549(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 52404, 52549);
                    return 0;
                }


                bool
                f_1129_52631_52681(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 52631, 52681);
                    return return_v;
                }


                int
                f_1129_52818_52841(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 52818, 52841);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective>
                f_1129_53046_53085(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                expansionListNode)
                {
                    var return_v = this_param.LoadEnumerableExpansionDirectiveList(expansionListNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 53046, 53085);
                    return return_v;
                }


                int
                f_1129_53184_53210(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 53184, 53210);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1129_49639_49669_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 49639, 49669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 49076, 53279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 49076, 53279);
            }
        }

        private List<EnumerableExpansionDirective> LoadEnumerableExpansionDirectiveList(XmlNode expansionListNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 53291, 54609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 53422, 53540);

                List<EnumerableExpansionDirective>
                retVal =
                f_1129_53499_53539()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 53554, 54568);
                using (f_1129_53561_53595(this, expansionListNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 53629, 53639);

                    int
                    k = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 53657, 54553);
                        foreach (XmlNode n in f_1129_53679_53707_I(f_1129_53679_53707(expansionListNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 53657, 54553);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 53749, 54534) || true) && (f_1129_53753_53802(this, n, XmlTags.EnumerableExpansionNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 53749, 54534);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 53852, 53928);

                                EnumerableExpansionDirective
                                eed = f_1129_53887_53927(this, n, k++)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 53954, 54342) || true) && (eed == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 53954, 54342);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 54111, 54258);

                                    f_1129_54111_54257(                            // Error at XPath {0} in file {1}: {2} failed to load.
                                                                this, f_1129_54128_54256(f_1129_54146_54189(), f_1129_54191_54212(this), f_1129_54214_54222(), XmlTags.EnumerableExpansionNode));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 54288, 54300);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 53954, 54342);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 54370, 54386);

                                f_1129_54370_54385(
                                                        retVal, eed);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 53749, 54534);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 53749, 54534);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 54484, 54511);

                                f_1129_54484_54510(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 53749, 54534);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 53657, 54553);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 897);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 897);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 53554, 54568);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 54584, 54598);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 53291, 54609);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective>
                f_1129_53499_53539()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 53499, 53539);
                    return return_v;
                }


                System.IDisposable
                f_1129_53561_53595(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 53561, 53595);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1129_53679_53707(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 53679, 53707);
                    return return_v;
                }


                bool
                f_1129_53753_53802(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 53753, 53802);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective
                f_1129_53887_53927(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                directive, int
                index)
                {
                    var return_v = this_param.LoadEnumerableExpansionDirective(directive, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 53887, 53927);
                    return return_v;
                }


                string
                f_1129_54146_54189()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.LoadTagFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 54146, 54189);
                    return return_v;
                }


                string
                f_1129_54191_54212(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 54191, 54212);
                    return return_v;
                }


                string
                f_1129_54214_54222()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 54214, 54222);
                    return return_v;
                }


                string
                f_1129_54128_54256(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 54128, 54256);
                    return return_v;
                }


                int
                f_1129_54111_54257(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 54111, 54257);
                    return 0;
                }


                int
                f_1129_54370_54385(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 54370, 54385);
                    return 0;
                }


                int
                f_1129_54484_54510(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 54484, 54510);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1129_53679_53707_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 53679, 53707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 53291, 54609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 53291, 54609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private EnumerableExpansionDirective LoadEnumerableExpansionDirective(XmlNode directive, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 54621, 56857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 54745, 56846);
                using (f_1129_54752_54785(this, directive, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 54819, 54889);

                    EnumerableExpansionDirective
                    eed = f_1129_54854_54888()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 54909, 54941);

                    bool
                    appliesToNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 54979, 55008);

                    bool
                    expandNodeFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55048, 56800);
                        foreach (XmlNode n in f_1129_55070_55090_I(f_1129_55070_55090(directive)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 55048, 56800);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55132, 56781) || true) && (f_1129_55136_55181(this, n, XmlTags.EntrySelectedByNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 55132, 56781);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55231, 55418) || true) && (appliesToNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 55231, 55418);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55311, 55340);

                                    f_1129_55311_55339(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55370, 55382);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 55231, 55418);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55446, 55472);

                                appliesToNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55498, 55544);

                                eed.appliesTo = f_1129_55514_55543(this, n, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 55132, 56781);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 55132, 56781);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55594, 56781) || true) && (f_1129_55598_55634(this, n, XmlTags.ExpandNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 55594, 56781);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55684, 55868) || true) && (expandNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 55684, 55868);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55761, 55790);

                                        f_1129_55761_55789(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55820, 55832);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 55684, 55868);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55896, 55919);

                                    expandNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 55945, 55981);

                                    string
                                    s = f_1129_55956_55980(this, n)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 56007, 56126) || true) && (s == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 56007, 56126);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 56078, 56090);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 56007, 56126);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 56154, 56239);

                                    bool
                                    success = f_1129_56169_56238(s, out eed.enumerableExpansion)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 56265, 56633) || true) && (!success)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 56265, 56633);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 56418, 56555);

                                        f_1129_56418_56554(                            // Error at XPath {0} in file {1}: Invalid {2} value.
                                                                    this, f_1129_56435_56553(f_1129_56453_56499(), f_1129_56501_56522(this), f_1129_56524_56532(), XmlTags.ExpandNode));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 56585, 56597);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 56265, 56633);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 55594, 56781);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 55594, 56781);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 56731, 56758);

                                    f_1129_56731_56757(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 55594, 56781);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 55132, 56781);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 55048, 56800);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 1753);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 1753);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 56820, 56831);

                    return eed;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 54745, 56846);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 54621, 56857);

                System.IDisposable
                f_1129_54752_54785(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 54752, 54785);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective
                f_1129_54854_54888()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 54854, 54888);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1129_55070_55090(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 55070, 55090);
                    return return_v;
                }


                bool
                f_1129_55136_55181(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 55136, 55181);
                    return return_v;
                }


                int
                f_1129_55311_55339(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 55311, 55339);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1129_55514_55543(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                appliesToNode, bool
                allowSelectionCondition)
                {
                    var return_v = this_param.LoadAppliesToSection(appliesToNode, allowSelectionCondition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 55514, 55543);
                    return return_v;
                }


                bool
                f_1129_55598_55634(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 55598, 55634);
                    return return_v;
                }


                int
                f_1129_55761_55789(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 55761, 55789);
                    return 0;
                }


                string
                f_1129_55956_55980(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 55956, 55980);
                    return return_v;
                }


                bool
                f_1129_56169_56238(string
                expansionString, out Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansion
                expansion)
                {
                    var return_v = EnumerableExpansionConversion.Convert(expansionString, out expansion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 56169, 56238);
                    return return_v;
                }


                string
                f_1129_56453_56499()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidNodeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 56453, 56499);
                    return return_v;
                }


                string
                f_1129_56501_56522(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 56501, 56522);
                    return return_v;
                }


                string
                f_1129_56524_56532()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 56524, 56532);
                    return return_v;
                }


                string
                f_1129_56435_56553(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 56435, 56553);
                    return return_v;
                }


                int
                f_1129_56418_56554(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 56418, 56554);
                    return 0;
                }


                int
                f_1129_56731_56757(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 56731, 56757);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1129_55070_55090_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 55070, 55090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 54621, 56857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 54621, 56857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadTypeGroups(TypeInfoDataBase db, XmlNode typeGroupsNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 56930, 57554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 57027, 57543);
                using (f_1129_57034_57065(this, typeGroupsNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 57099, 57122);

                    int
                    typeGroupCount = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 57142, 57528);
                        foreach (XmlNode n in f_1129_57164_57189_I(f_1129_57164_57189(typeGroupsNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 57142, 57528);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 57231, 57509) || true) && (f_1129_57235_57277(this, n, XmlTags.SelectionSetNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 57231, 57509);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 57327, 57366);

                                f_1129_57327_57365(this, db, n, typeGroupCount++);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 57231, 57509);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 57231, 57509);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 57464, 57486);

                                f_1129_57464_57485(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 57231, 57509);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 57142, 57528);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 387);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 387);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 57027, 57543);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 56930, 57554);

                System.IDisposable
                f_1129_57034_57065(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 57034, 57065);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1129_57164_57189(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 57164, 57189);
                    return return_v;
                }


                bool
                f_1129_57235_57277(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 57235, 57277);
                    return return_v;
                }


                int
                f_1129_57327_57365(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Xml.XmlNode
                typeGroupNode, int
                index)
                {
                    this_param.LoadTypeGroup(db, typeGroupNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 57327, 57365);
                    return 0;
                }


                int
                f_1129_57464_57485(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 57464, 57485);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1129_57164_57189_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 57164, 57189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 56930, 57554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 56930, 57554);
            }
        }

        private void LoadTypeGroup(TypeInfoDataBase db, XmlNode typeGroupNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 57566, 59049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 57672, 59038);
                using (f_1129_57679_57716(this, typeGroupNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 57792, 57860);

                    TypeGroupDefinition
                    typeGroupDefinition = f_1129_57834_57859()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 57878, 57905);

                    bool
                    nameNodeFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 57925, 58750);
                        foreach (XmlNode n in f_1129_57947_57971_I(f_1129_57947_57971(typeGroupNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 57925, 58750);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58013, 58731) || true) && (f_1129_58017_58051(this, n, XmlTags.NameNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 58013, 58731);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58101, 58271) || true) && (nameNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 58101, 58271);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58176, 58205);

                                    f_1129_58176_58204(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58235, 58244);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 58101, 58271);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58299, 58320);

                                nameNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58346, 58398);

                                typeGroupDefinition.name = f_1129_58373_58397(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 58013, 58731);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 58013, 58731);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58448, 58731) || true) && (f_1129_58452_58487(this, n, XmlTags.TypesNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 58448, 58731);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58537, 58583);

                                    f_1129_58537_58582(this, n, typeGroupDefinition);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 58448, 58731);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 58448, 58731);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58681, 58708);

                                    f_1129_58681_58707(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 58448, 58731);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 58013, 58731);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 57925, 58750);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 826);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 826);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58770, 58890) || true) && (!nameNodeFound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 58770, 58890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58830, 58871);

                        f_1129_58830_58870(this, XmlTags.NameNode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 58770, 58890);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 58954, 59023);

                    f_1129_58954_59022(
                                    // finally add to the list
                                    db.typeGroupSection.typeGroupDefinitionList, typeGroupDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 57672, 59038);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 57566, 59049);

                System.IDisposable
                f_1129_57679_57716(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 57679, 57716);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition
                f_1129_57834_57859()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 57834, 57859);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1129_57947_57971(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 57947, 57971);
                    return return_v;
                }


                bool
                f_1129_58017_58051(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 58017, 58051);
                    return return_v;
                }


                int
                f_1129_58176_58204(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 58176, 58204);
                    return 0;
                }


                string
                f_1129_58373_58397(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 58373, 58397);
                    return return_v;
                }


                bool
                f_1129_58452_58487(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 58452, 58487);
                    return return_v;
                }


                int
                f_1129_58537_58582(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                typesNode, Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition
                typeGroupDefinition)
                {
                    this_param.LoadTypeGroupTypeRefs(typesNode, typeGroupDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 58537, 58582);
                    return 0;
                }


                int
                f_1129_58681_58707(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 58681, 58707);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1129_57947_57971_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 57947, 57971);
                    return return_v;
                }


                int
                f_1129_58830_58870(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingNode(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 58830, 58870);
                    return 0;
                }


                int
                f_1129_58954_59022(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 58954, 59022);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 57566, 59049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 57566, 59049);
            }
        }

        private void LoadTypeGroupTypeRefs(XmlNode typesNode, TypeGroupDefinition typeGroupDefinition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 59061, 59960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 59180, 59949);
                using (f_1129_59187_59213(this, typesNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 59247, 59268);

                    int
                    typeRefCount = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 59288, 59934);
                        foreach (XmlNode n in f_1129_59310_59330_I(f_1129_59310_59330(typesNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 59288, 59934);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 59372, 59915) || true) && (f_1129_59376_59414(this, n, XmlTags.TypeNameNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 59372, 59915);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 59464, 59772);
                                using (f_1129_59471_59505(this, n, typeRefCount++))
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 59563, 59602);

                                    TypeReference
                                    tr = f_1129_59582_59601()
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 59634, 59669);

                                    tr.name = f_1129_59644_59668(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 59699, 59745);

                                    f_1129_59699_59744(typeGroupDefinition.typeReferenceList, tr);
                                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 59464, 59772);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 59372, 59915);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 59372, 59915);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 59870, 59892);

                                f_1129_59870_59891(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 59372, 59915);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 59288, 59934);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 647);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 647);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 59180, 59949);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 59061, 59960);

                System.IDisposable
                f_1129_59187_59213(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 59187, 59213);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1129_59310_59330(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 59310, 59330);
                    return return_v;
                }


                bool
                f_1129_59376_59414(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 59376, 59414);
                    return return_v;
                }


                System.IDisposable
                f_1129_59471_59505(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 59471, 59505);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeReference
                f_1129_59582_59601()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 59582, 59601);
                    return return_v;
                }


                string
                f_1129_59644_59668(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 59644, 59668);
                    return return_v;
                }


                int
                f_1129_59699_59744(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeReference>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 59699, 59744);
                    return 0;
                }


                int
                f_1129_59870_59891(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 59870, 59891);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1129_59310_59330_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 59310, 59330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 59061, 59960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 59061, 59960);
            }
        }

        private AppliesTo LoadAppliesToSection(XmlNode appliesToNode, bool allowSelectionCondition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 60031, 62766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 60147, 62755);
                using (f_1129_60154_60184(this, appliesToNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 60218, 60256);

                    AppliesTo
                    appliesTo = f_1129_60240_60255()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 60336, 62267);
                        foreach (XmlNode n in f_1129_60358_60382_I(f_1129_60358_60382(appliesToNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 60336, 62267);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 60424, 62248);
                            using (f_1129_60431_60449(this, n))
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 60499, 62225) || true) && (f_1129_60503_60549(this, n, XmlTags.SelectionSetNameNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 60499, 62225);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 60607, 60658);

                                    TypeGroupReference
                                    tgr = f_1129_60632_60657(this, n)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 60688, 60975) || true) && (tgr != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 60688, 60975);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 60769, 60802);

                                        f_1129_60769_60801(appliesTo.referenceList, tgr);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 60688, 60975);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 60688, 60975);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 60932, 60944);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 60688, 60975);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 60499, 62225);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 60499, 62225);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 61033, 62225) || true) && (f_1129_61037_61075(this, n, XmlTags.TypeNameNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 61033, 62225);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 61133, 61173);

                                        TypeReference
                                        tr = f_1129_61152_61172(this, n)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 61203, 61488) || true) && (tr != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 61203, 61488);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 61283, 61315);

                                            f_1129_61283_61314(appliesTo.referenceList, tr);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 61203, 61488);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 61203, 61488);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 61445, 61457);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 61203, 61488);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 61033, 62225);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 61033, 62225);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 61546, 62225) || true) && (allowSelectionCondition && (DynAbs.Tracing.TraceSender.Expression_True(1129, 61550, 61625) && f_1129_61577_61625(this, n, XmlTags.SelectionConditionNode)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 61546, 62225);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 61683, 61740);

                                            TypeOrGroupReference
                                            tgr = f_1129_61710_61739(this, n)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 61770, 62057) || true) && (tgr != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 61770, 62057);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 61851, 61884);

                                                f_1129_61851_61883(appliesTo.referenceList, tgr);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 61770, 62057);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 61770, 62057);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 62014, 62026);

                                                return null;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 61770, 62057);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 61546, 62225);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 61546, 62225);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 62171, 62198);

                                            f_1129_62171_62197(this, n);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 61546, 62225);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 61033, 62225);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 60499, 62225);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 60424, 62248);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 60336, 62267);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 1932);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 1932);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 62287, 62703) || true) && (f_1129_62291_62320(appliesTo.referenceList) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 62287, 62703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 62535, 62650);

                        f_1129_62535_62649(                    // we do not accept an empty list
                                                               // Error at XPath {0} in file {1}: No type or condition is specified for applying the view.
                                            this, f_1129_62552_62648(f_1129_62570_62614(), f_1129_62616_62637(this), f_1129_62639_62647()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 62672, 62684);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 62287, 62703);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 62723, 62740);

                    return appliesTo;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 60147, 62755);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 60031, 62766);

                System.IDisposable
                f_1129_60154_60184(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 60154, 60184);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1129_60240_60255()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.AppliesTo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 60240, 60255);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1129_60358_60382(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 60358, 60382);
                    return return_v;
                }


                System.IDisposable
                f_1129_60431_60449(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 60431, 60449);
                    return return_v;
                }


                bool
                f_1129_60503_60549(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 60503, 60549);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeGroupReference
                f_1129_60632_60657(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.LoadTypeGroupReference(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 60632, 60657);
                    return return_v;
                }


                int
                f_1129_60769_60801(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeGroupReference
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 60769, 60801);
                    return 0;
                }


                bool
                f_1129_61037_61075(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 61037, 61075);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeReference
                f_1129_61152_61172(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.LoadTypeReference(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 61152, 61172);
                    return return_v;
                }


                int
                f_1129_61283_61314(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeReference
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 61283, 61314);
                    return 0;
                }


                bool
                f_1129_61577_61625(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 61577, 61625);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference
                f_1129_61710_61739(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                selectionConditionNode)
                {
                    var return_v = this_param.LoadSelectionConditionNode(selectionConditionNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 61710, 61739);
                    return return_v;
                }


                int
                f_1129_61851_61883(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 61851, 61883);
                    return 0;
                }


                int
                f_1129_62171_62197(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 62171, 62197);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1129_60358_60382_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 60358, 60382);
                    return return_v;
                }


                int
                f_1129_62291_62320(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 62291, 62320);
                    return return_v;
                }


                string
                f_1129_62570_62614()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.EmptyAppliesTo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 62570, 62614);
                    return return_v;
                }


                string
                f_1129_62616_62637(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 62616, 62637);
                    return return_v;
                }


                string
                f_1129_62639_62647()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 62639, 62647);
                    return return_v;
                }


                string
                f_1129_62552_62648(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 62552, 62648);
                    return return_v;
                }


                int
                f_1129_62535_62649(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 62535, 62649);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 60031, 62766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 60031, 62766);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeReference LoadTypeReference(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 62778, 63109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 62853, 62891);

                string
                val = f_1129_62866_62890(this, n)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 62907, 63070) || true) && (val != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 62907, 63070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 62956, 62995);

                    TypeReference
                    tr = f_1129_62975_62994()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63013, 63027);

                    tr.name = val;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63045, 63055);

                    return tr;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 62907, 63070);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63086, 63098);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 62778, 63109);

                string
                f_1129_62866_62890(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 62866, 62890);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeReference
                f_1129_62975_62994()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 62975, 62994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 62778, 63109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 62778, 63109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeGroupReference LoadTypeGroupReference(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 63121, 63475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63206, 63244);

                string
                val = f_1129_63219_63243(this, n)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63260, 63436) || true) && (val != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 63260, 63436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63309, 63359);

                    TypeGroupReference
                    tgr = f_1129_63334_63358()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63377, 63392);

                    tgr.name = val;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63410, 63421);

                    return tgr;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 63260, 63436);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63452, 63464);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 63121, 63475);

                string
                f_1129_63219_63243(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 63219, 63243);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeGroupReference
                f_1129_63334_63358()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeGroupReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 63334, 63358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 63121, 63475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 63121, 63475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeOrGroupReference LoadSelectionConditionNode(XmlNode selectionConditionNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 63487, 67752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63599, 67741);
                using (f_1129_63606_63645(this, selectionConditionNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63679, 63714);

                    TypeOrGroupReference
                    retVal = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63734, 63767);

                    bool
                    expressionNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63869, 63892);

                    bool
                    typeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 63943, 63971);

                    bool
                    typeGroupFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64024, 64092);

                    ExpressionNodeMatch
                    expressionMatch = f_1129_64062_64091(this)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64112, 66349);
                        foreach (XmlNode n in f_1129_64134_64167_I(f_1129_64134_64167(selectionConditionNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 64112, 66349);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64209, 66330) || true) && (f_1129_64213_64259(this, n, XmlTags.SelectionSetNameNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 64209, 66330);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64309, 64544) || true) && (typeGroupFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 64309, 64544);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64385, 64475);

                                    f_1129_64385_64474(this, n, XmlTags.SelectionSetNameNode, XmlTags.TypeNameNode);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64505, 64517);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 64309, 64544);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64572, 64594);

                                typeGroupFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64620, 64671);

                                TypeGroupReference
                                tgr = f_1129_64645_64670(this, n)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64697, 64936) || true) && (tgr != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 64697, 64936);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64770, 64783);

                                    retVal = tgr;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 64697, 64936);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 64697, 64936);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64897, 64909);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 64697, 64936);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 64209, 66330);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 64209, 66330);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 64986, 66330) || true) && (f_1129_64990_65028(this, n, XmlTags.TypeNameNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 64986, 66330);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65078, 65308) || true) && (typeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 65078, 65308);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65149, 65239);

                                        f_1129_65149_65238(this, n, XmlTags.SelectionSetNameNode, XmlTags.TypeNameNode);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65269, 65281);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 65078, 65308);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65336, 65353);

                                    typeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65379, 65419);

                                    TypeReference
                                    tr = f_1129_65398_65418(this, n)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65445, 65682) || true) && (tr != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 65445, 65682);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65517, 65529);

                                        retVal = tr;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 65445, 65682);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 65445, 65682);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65643, 65655);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 65445, 65682);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 64986, 66330);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 64986, 66330);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65732, 66330) || true) && (f_1129_65736_65764(expressionMatch, n))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 65732, 66330);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65814, 66008) || true) && (expressionNodeFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 65814, 66008);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65895, 65924);

                                            f_1129_65895_65923(this, n);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 65954, 65966);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 65814, 66008);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 66036, 66063);

                                        expressionNodeFound = true;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 66089, 66167) || true) && (!f_1129_66094_66124(expressionMatch, n))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 66089, 66167);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 66155, 66167);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 66089, 66167);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 65732, 66330);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 65732, 66330);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 66280, 66307);

                                        f_1129_66280_66306(this, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 65732, 66330);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 64986, 66330);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 64209, 66330);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 64112, 66349);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 2238);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 2238);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 66369, 66754) || true) && (typeFound && (DynAbs.Tracing.TraceSender.Expression_True(1129, 66373, 66400) && typeGroupFound))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 66369, 66754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 66558, 66686);

                        f_1129_66558_66685(                    // Error at XPath {0} in file {1}: Cannot have SelectionSetName and TypeName at the same time.
                                            this, f_1129_66575_66684(f_1129_66593_66650(), f_1129_66652_66673(this), f_1129_66675_66683()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 66708, 66720);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 66369, 66754);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 66774, 67027) || true) && (retVal == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 66774, 67027);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 66881, 66974);

                        f_1129_66881_66973(                    // missing mandatory node
                                            this, new string[] { XmlTags.SelectionSetNameNode, XmlTags.TypeNameNode });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 66996, 67008);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 66774, 67027);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 67047, 67429) || true) && (expressionNodeFound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 67047, 67429);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 67151, 67217);

                        retVal.conditionToken = f_1129_67175_67216(expressionMatch);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 67239, 67372) || true) && (retVal.conditionToken == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 67239, 67372);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 67322, 67334);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 67239, 67372);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 67396, 67410);

                        return retVal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 67047, 67429);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 67579, 67696);

                    f_1129_67579_67695(                // failure: expression is mandatory
                                                       // Error at XPath {0} in file {1}: An expression is expected.
                                    this, f_1129_67596_67694(f_1129_67614_67660(), f_1129_67662_67683(this), f_1129_67685_67693()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 67714, 67726);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 63599, 67741);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 63487, 67752);

                System.IDisposable
                f_1129_63606_63645(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 63606, 63645);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                f_1129_64062_64091(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                loader)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch(loader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 64062, 64091);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1129_64134_64167(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 64134, 64167);
                    return return_v;
                }


                bool
                f_1129_64213_64259(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 64213, 64259);
                    return return_v;
                }


                int
                f_1129_64385_64474(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 64385, 64474);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeGroupReference
                f_1129_64645_64670(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.LoadTypeGroupReference(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 64645, 64670);
                    return return_v;
                }


                bool
                f_1129_64990_65028(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 64990, 65028);
                    return return_v;
                }


                int
                f_1129_65149_65238(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 65149, 65238);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeReference
                f_1129_65398_65418(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.LoadTypeReference(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 65398, 65418);
                    return return_v;
                }


                bool
                f_1129_65736_65764(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.MatchNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 65736, 65764);
                    return return_v;
                }


                int
                f_1129_65895_65923(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 65895, 65923);
                    return 0;
                }


                bool
                f_1129_66094_66124(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.ProcessNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 66094, 66124);
                    return return_v;
                }


                int
                f_1129_66280_66306(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 66280, 66306);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1129_64134_64167_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 64134, 64167);
                    return return_v;
                }


                string
                f_1129_66593_66650()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.SelectionSetNameAndTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 66593, 66650);
                    return return_v;
                }


                string
                f_1129_66652_66673(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 66652, 66673);
                    return return_v;
                }


                string
                f_1129_66675_66683()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 66675, 66683);
                    return return_v;
                }


                string
                f_1129_66575_66684(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 66575, 66684);
                    return return_v;
                }


                int
                f_1129_66558_66685(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 66558, 66685);
                    return 0;
                }


                int
                f_1129_66881_66973(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string[]
                names)
                {
                    this_param.ReportMissingNodes(names);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 66881, 66973);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1129_67175_67216(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param)
                {
                    var return_v = this_param.GenerateExpressionToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 67175, 67216);
                    return return_v;
                }


                string
                f_1129_67614_67660()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ExpectExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 67614, 67660);
                    return return_v;
                }


                string
                f_1129_67662_67683(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 67662, 67683);
                    return return_v;
                }


                string
                f_1129_67685_67693()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 67685, 67693);
                    return return_v;
                }


                string
                f_1129_67596_67694(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 67596, 67694);
                    return return_v;
                }


                int
                f_1129_67579_67695(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 67579, 67695);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 63487, 67752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 63487, 67752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private GroupBy LoadGroupBySection(XmlNode groupByNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 67819, 72462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 67899, 72451);
                using (f_1129_67906_67934(this, groupByNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 67968, 68036);

                    ExpressionNodeMatch
                    expressionMatch = f_1129_68006_68035(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68054, 68119);

                    ComplexControlMatch
                    controlMatch = f_1129_68089_68118(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68139, 68172);

                    bool
                    expressionNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68277, 68303);

                    bool
                    controlFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68354, 68378);

                    bool
                    labelFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68431, 68463);

                    GroupBy
                    groupBy = f_1129_68449_68462()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68481, 68513);

                    TextToken
                    labelTextToken = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68533, 70419);
                        foreach (XmlNode n in f_1129_68555_68566_I(groupByNode))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 68533, 70419);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68608, 70400) || true) && (f_1129_68612_68640(expressionMatch, n))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 68608, 70400);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68690, 68884) || true) && (expressionNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 68690, 68884);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68771, 68800);

                                    f_1129_68771_68799(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68830, 68842);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 68690, 68884);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68912, 68939);

                                expressionNodeFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 68965, 69043) || true) && (!f_1129_68970_69000(expressionMatch, n))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 68965, 69043);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69031, 69043);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 68965, 69043);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 68608, 70400);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 68608, 70400);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69108, 70400) || true) && (f_1129_69112_69137(controlMatch, n))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 69108, 70400);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69187, 69428) || true) && (controlFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 69187, 69428);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69261, 69359);

                                        f_1129_69261_69358(this, n, XmlTags.ComplexControlNode, XmlTags.ComplexControlNameNode);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69389, 69401);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 69187, 69428);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69456, 69476);

                                    controlFound = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69502, 69577) || true) && (!f_1129_69507_69534(controlMatch, n))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 69502, 69577);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69565, 69577);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 69502, 69577);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 69108, 70400);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 69108, 70400);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69642, 70400) || true) && (f_1129_69646_69695(this, n, XmlTags.LabelNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 69642, 70400);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69745, 69984) || true) && (labelFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 69745, 69984);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69817, 69915);

                                            f_1129_69817_69914(this, n, XmlTags.ComplexControlNode, XmlTags.ComplexControlNameNode);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 69945, 69957);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 69745, 69984);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 70012, 70030);

                                        labelFound = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 70058, 70088);

                                        labelTextToken = f_1129_70075_70087(this, n);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 70114, 70252) || true) && (labelTextToken == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 70114, 70252);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 70198, 70210);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 70114, 70252);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 69642, 70400);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 69642, 70400);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 70350, 70377);

                                        f_1129_70350_70376(this, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 69642, 70400);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 69108, 70400);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 68608, 70400);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 68533, 70419);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 1887);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 1887);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 70439, 70799) || true) && (controlFound && (DynAbs.Tracing.TraceSender.Expression_True(1129, 70443, 70469) && labelFound))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 70439, 70799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 70615, 70731);

                        f_1129_70615_70730(                    // Error at XPath {0} in file {1}: Cannot have control and label at the same time.
                                            this, f_1129_70632_70729(f_1129_70650_70695(), f_1129_70697_70718(this), f_1129_70720_70728()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 70753, 70765);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 70439, 70799);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 70819, 71630) || true) && (controlFound || (DynAbs.Tracing.TraceSender.Expression_False(1129, 70823, 70849) || labelFound))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 70819, 71630);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 70891, 71283) || true) && (!expressionNodeFound)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 70891, 71283);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 71077, 71207);

                            f_1129_71077_71206(                        // Error at XPath {0} in file {1}: Cannot have control or label without an expression.
                                                    this, f_1129_71094_71205(f_1129_71112_71171(), f_1129_71173_71194(this), f_1129_71196_71204()));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 71233, 71245);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 70891, 71283);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 71307, 71611) || true) && (controlFound)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 71307, 71611);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 71373, 71423);

                            groupBy.startGroup.control = f_1129_71402_71422(controlMatch);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 71307, 71611);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 71307, 71611);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 71473, 71611) || true) && (labelFound)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 71473, 71611);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 71537, 71588);

                                groupBy.startGroup.labelTextToken = labelTextToken;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 71473, 71611);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 71307, 71611);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 70819, 71630);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 71650, 72137) || true) && (expressionNodeFound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 71650, 72137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 71799, 71870);

                        ExpressionToken
                        expression = f_1129_71828_71869(expressionMatch)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 71892, 72014) || true) && (expression == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 71892, 72014);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 71964, 71976);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 71892, 72014);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 72038, 72081);

                        groupBy.startGroup.expression = expression;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 72103, 72118);

                        return groupBy;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 71650, 72137);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 72289, 72406);

                    f_1129_72289_72405(
                                    // failure: expression is mandatory
                                    // Error at XPath {0} in file {1}: An expression is expected.
                                    this, f_1129_72306_72404(f_1129_72324_72370(), f_1129_72372_72393(this), f_1129_72395_72403()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 72424, 72436);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 67899, 72451);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 67819, 72462);

                System.IDisposable
                f_1129_67906_67934(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 67906, 67934);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                f_1129_68006_68035(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                loader)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch(loader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 68006, 68035);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ComplexControlMatch
                f_1129_68089_68118(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                loader)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ComplexControlMatch(loader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 68089, 68118);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.GroupBy
                f_1129_68449_68462()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.GroupBy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 68449, 68462);
                    return return_v;
                }


                bool
                f_1129_68612_68640(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.MatchNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 68612, 68640);
                    return return_v;
                }


                int
                f_1129_68771_68799(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 68771, 68799);
                    return 0;
                }


                bool
                f_1129_68970_69000(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.ProcessNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 68970, 69000);
                    return return_v;
                }


                bool
                f_1129_69112_69137(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ComplexControlMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.MatchNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 69112, 69137);
                    return return_v;
                }


                int
                f_1129_69261_69358(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 69261, 69358);
                    return 0;
                }


                bool
                f_1129_69507_69534(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ComplexControlMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.ProcessNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 69507, 69534);
                    return return_v;
                }


                bool
                f_1129_69646_69695(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeNameWithAttributes(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 69646, 69695);
                    return return_v;
                }


                int
                f_1129_69817_69914(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 69817, 69914);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1129_70075_70087(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                textNode)
                {
                    var return_v = this_param.LoadLabel(textNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 70075, 70087);
                    return return_v;
                }


                int
                f_1129_70350_70376(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 70350, 70376);
                    return 0;
                }


                System.Xml.XmlNode
                f_1129_68555_68566_I(System.Xml.XmlNode
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 68555, 68566);
                    return return_v;
                }


                string
                f_1129_70650_70695()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ControlAndLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 70650, 70695);
                    return return_v;
                }


                string
                f_1129_70697_70718(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 70697, 70718);
                    return return_v;
                }


                string
                f_1129_70720_70728()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 70720, 70728);
                    return return_v;
                }


                string
                f_1129_70632_70729(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 70632, 70729);
                    return return_v;
                }


                int
                f_1129_70615_70730(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 70615, 70730);
                    return 0;
                }


                string
                f_1129_71112_71171()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ControlLabelWithoutExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 71112, 71171);
                    return return_v;
                }


                string
                f_1129_71173_71194(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 71173, 71194);
                    return return_v;
                }


                string
                f_1129_71196_71204()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 71196, 71204);
                    return return_v;
                }


                string
                f_1129_71094_71205(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 71094, 71205);
                    return return_v;
                }


                int
                f_1129_71077_71206(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 71077, 71206);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                f_1129_71402_71422(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ComplexControlMatch
                this_param)
                {
                    var return_v = this_param.Control;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 71402, 71422);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1129_71828_71869(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param)
                {
                    var return_v = this_param.GenerateExpressionToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 71828, 71869);
                    return return_v;
                }


                string
                f_1129_72324_72370()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ExpectExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 72324, 72370);
                    return return_v;
                }


                string
                f_1129_72372_72393(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 72372, 72393);
                    return return_v;
                }


                string
                f_1129_72395_72403()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 72395, 72403);
                    return return_v;
                }


                string
                f_1129_72306_72404(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 72306, 72404);
                    return return_v;
                }


                int
                f_1129_72289_72405(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 72289, 72405);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 67819, 72462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 67819, 72462);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TextToken LoadLabel(XmlNode textNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 72474, 72667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 72544, 72656);
                using (f_1129_72551_72576(this, textNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 72610, 72641);

                    return f_1129_72617_72640(this, textNode);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1129, 72544, 72656);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 72474, 72667);

                System.IDisposable
                f_1129_72551_72576(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 72551, 72576);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1129_72617_72640(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.LoadTextToken(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 72617, 72640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 72474, 72667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 72474, 72667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TextToken LoadTextToken(XmlNode n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 72679, 73286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 72746, 72777);

                TextToken
                tt = f_1129_72761_72776()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 72793, 72906) || true) && (!f_1129_72798_72845(this, n, out tt.resource))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 72793, 72906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 72879, 72891);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 72793, 72906);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 72922, 73087) || true) && (tt.resource != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 72922, 73087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73022, 73044);

                    tt.text = f_1129_73032_73043(n);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73062, 73072);

                    return tt;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 72922, 73087);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73143, 73183);

                tt.text = f_1129_73153_73182(this, n);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73199, 73249) || true) && (tt.text == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 73199, 73249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73237, 73249);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 73199, 73249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73265, 73275);

                return tt;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 72679, 73286);

                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1129_72761_72776()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 72761, 72776);
                    return return_v;
                }


                bool
                f_1129_72798_72845(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, out Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                resource)
                {
                    var return_v = this_param.LoadStringResourceReference(n, out resource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 72798, 72845);
                    return return_v;
                }


                string
                f_1129_73032_73043(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.InnerText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 73032, 73043);
                    return return_v;
                }


                string
                f_1129_73153_73182(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 73153, 73182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 72679, 73286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 72679, 73286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LoadStringResourceReference(XmlNode n, out StringResourceReference resource)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 73298, 74173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73412, 73428);

                resource = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73442, 73473);

                XmlElement
                e = n as XmlElement
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73489, 73782) || true) && (e == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 73489, 73782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73618, 73736);

                    f_1129_73618_73735(                // Error at XPath {0} in file {1}: Node should be an XmlElement.
                                    this, f_1129_73635_73734(f_1129_73653_73700(), f_1129_73702_73723(this), f_1129_73725_73733()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73754, 73767);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 73489, 73782);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73798, 73927) || true) && (f_1129_73802_73820(f_1129_73802_73814(e)) <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 73798, 73927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73900, 73912);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 73798, 73927);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 73993, 74041);

                resource = f_1129_74004_74040(this, f_1129_74027_74039(e));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74138, 74162);

                return resource != null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 73298, 74173);

                string
                f_1129_73653_73700()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NonXmlElementNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 73653, 73700);
                    return return_v;
                }


                string
                f_1129_73702_73723(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 73702, 73723);
                    return return_v;
                }


                string
                f_1129_73725_73733()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 73725, 73733);
                    return return_v;
                }


                string
                f_1129_73635_73734(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 73635, 73734);
                    return return_v;
                }


                int
                f_1129_73618_73735(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 73618, 73735);
                    return 0;
                }


                System.Xml.XmlAttributeCollection
                f_1129_73802_73814(System.Xml.XmlElement
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 73802, 73814);
                    return return_v;
                }


                int
                f_1129_73802_73820(System.Xml.XmlAttributeCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 73802, 73820);
                    return return_v;
                }


                System.Xml.XmlAttributeCollection
                f_1129_74027_74039(System.Xml.XmlElement
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 74027, 74039);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                f_1129_74004_74040(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlAttributeCollection
                attributes)
                {
                    var return_v = this_param.LoadResourceAttributes(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 74004, 74040);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 73298, 74173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 73298, 74173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private StringResourceReference LoadResourceAttributes(XmlAttributeCollection attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 74185, 76811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74299, 74364);

                StringResourceReference
                resource = f_1129_74334_74363()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74378, 75430);
                    foreach (XmlAttribute a in f_1129_74405_74415_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 74378, 75430);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74449, 75415) || true) && (f_1129_74453_74505(this, a, XmlTags.AssemblyNameAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 74449, 75415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74547, 74601);

                            resource.assemblyName = f_1129_74571_74600(this, a);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74623, 74695) || true) && (resource.assemblyName == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 74623, 74695);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74683, 74695);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 74623, 74695);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 74449, 75415);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 74449, 75415);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74737, 75415) || true) && (f_1129_74741_74789(this, a, XmlTags.BaseNameAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 74737, 75415);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74831, 74881);

                                resource.baseName = f_1129_74851_74880(this, a);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74903, 74971) || true) && (resource.baseName == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 74903, 74971);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 74959, 74971);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 74903, 74971);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 74737, 75415);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 74737, 75415);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75013, 75415) || true) && (f_1129_75017_75067(this, a, XmlTags.ResourceIdAttribute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 75013, 75415);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75109, 75161);

                                    resource.resourceId = f_1129_75131_75160(this, a);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75183, 75253) || true) && (resource.resourceId == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 75183, 75253);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75241, 75253);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 75183, 75253);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 75013, 75415);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 75013, 75415);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75335, 75362);

                                    f_1129_75335_75361(this, a);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75384, 75396);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 75013, 75415);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 74737, 75415);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 74449, 75415);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 74378, 75430);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 1053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 1053);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75530, 75696) || true) && (resource.assemblyName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 75530, 75696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75597, 75651);

                    f_1129_75597_75650(this, XmlTags.AssemblyNameAttribute);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75669, 75681);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 75530, 75696);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75712, 75870) || true) && (resource.baseName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 75712, 75870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75775, 75825);

                    f_1129_75775_75824(this, XmlTags.BaseNameAttribute);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75843, 75855);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 75712, 75870);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75886, 76048) || true) && (resource.resourceId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 75886, 76048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 75951, 76003);

                    f_1129_75951_76002(this, XmlTags.ResourceIdAttribute);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 76021, 76033);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 75886, 76048);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 76099, 76139);

                resource.loadingInfo = f_1129_76122_76138(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 76214, 76768) || true) && (f_1129_76218_76244(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 76214, 76768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 76278, 76327);

                    DisplayResourceManagerCache.LoadingResult
                    result
                    = default(DisplayResourceManagerCache.LoadingResult);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 76345, 76409);

                    DisplayResourceManagerCache.AssemblyBindingStatus
                    bindingStatus
                    = default(DisplayResourceManagerCache.AssemblyBindingStatus);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 76427, 76516);

                    f_1129_76427_76515(this.displayResourceManagerCache, resource, out result, out bindingStatus);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 76534, 76753) || true) && (result != DisplayResourceManagerCache.LoadingResult.NoError)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 76534, 76753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 76639, 76700);

                        f_1129_76639_76699(this, resource, result, bindingStatus);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 76722, 76734);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 76534, 76753);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 76214, 76768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 76784, 76800);

                return resource;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 74185, 76811);

                Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                f_1129_74334_74363()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 74334, 74363);
                    return return_v;
                }


                bool
                f_1129_74453_74505(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlAttribute
                a, string
                s)
                {
                    var return_v = this_param.MatchAttributeName(a, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 74453, 74505);
                    return return_v;
                }


                string
                f_1129_74571_74600(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlAttribute
                a)
                {
                    var return_v = this_param.GetMandatoryAttributeValue(a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 74571, 74600);
                    return return_v;
                }


                bool
                f_1129_74741_74789(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlAttribute
                a, string
                s)
                {
                    var return_v = this_param.MatchAttributeName(a, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 74741, 74789);
                    return return_v;
                }


                string
                f_1129_74851_74880(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlAttribute
                a)
                {
                    var return_v = this_param.GetMandatoryAttributeValue(a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 74851, 74880);
                    return return_v;
                }


                bool
                f_1129_75017_75067(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlAttribute
                a, string
                s)
                {
                    var return_v = this_param.MatchAttributeName(a, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 75017, 75067);
                    return return_v;
                }


                string
                f_1129_75131_75160(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlAttribute
                a)
                {
                    var return_v = this_param.GetMandatoryAttributeValue(a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 75131, 75160);
                    return return_v;
                }


                int
                f_1129_75335_75361(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlAttribute
                a)
                {
                    this_param.ProcessUnknownAttribute(a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 75335, 75361);
                    return 0;
                }


                System.Xml.XmlAttributeCollection
                f_1129_74405_74415_I(System.Xml.XmlAttributeCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 74405, 74415);
                    return return_v;
                }


                int
                f_1129_75597_75650(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 75597, 75650);
                    return 0;
                }


                int
                f_1129_75775_75824(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 75775, 75824);
                    return 0;
                }


                int
                f_1129_75951_76002(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 75951, 76002);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                f_1129_76122_76138(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.LoadingInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 76122, 76138);
                    return return_v;
                }


                bool
                f_1129_76218_76244(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.VerifyStringResources;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 76218, 76244);
                    return return_v;
                }


                int
                f_1129_76427_76515(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                resourceReference, out Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.LoadingResult
                result, out Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyBindingStatus
                bindingStatus)
                {
                    this_param.VerifyResource(resourceReference, out result, out bindingStatus);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 76427, 76515);
                    return 0;
                }


                int
                f_1129_76639_76699(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                resource, Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.LoadingResult
                result, Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyBindingStatus
                bindingStatus)
                {
                    this_param.ReportStringResourceFailure(resource, result, bindingStatus);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 76639, 76699);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 74185, 76811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 74185, 76811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReportStringResourceFailure(StringResourceReference resource,
                                                            DisplayResourceManagerCache.LoadingResult result,
                                                            DisplayResourceManagerCache.AssemblyBindingStatus bindingStatus)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 76823, 79468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 77143, 77170);

                string
                assemblyDisplayName
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 77184, 77995);

                switch (bindingStatus)
                {

                    case DisplayResourceManagerCache.AssemblyBindingStatus.FoundInPath:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 77184, 77995);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 77355, 77403);

                            assemblyDisplayName = resource.assemblyLocation;
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1129, 77450, 77456);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 77184, 77995);

                    case DisplayResourceManagerCache.AssemblyBindingStatus.FoundInGac:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 77184, 77995);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 77647, 77755);

                            assemblyDisplayName = f_1129_77669_77754(f_1129_77687_77730(), resource.assemblyName);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1129, 77802, 77808);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 77184, 77995);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 77184, 77995);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 77883, 77927);

                            assemblyDisplayName = resource.assemblyName;
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1129, 77974, 77980);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 77184, 77995);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 78011, 78029);

                string
                msg = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 78043, 79419);

                switch (result)
                {

                    case DisplayResourceManagerCache.LoadingResult.AssemblyNotFound:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 78043, 79419);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 78291, 78417);

                            msg = f_1129_78297_78416(f_1129_78315_78361(), f_1129_78363_78384(this), f_1129_78386_78394(), assemblyDisplayName);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1129, 78464, 78470);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 78043, 79419);

                    case DisplayResourceManagerCache.LoadingResult.ResourceNotFound:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 78043, 79419);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 78704, 78849);

                            msg = f_1129_78710_78848(f_1129_78728_78774(), f_1129_78776_78797(this), f_1129_78799_78807(), resource.baseName, assemblyDisplayName);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1129, 78896, 78902);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 78043, 79419);

                    case DisplayResourceManagerCache.LoadingResult.StringNotFound:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 78043, 79419);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 79150, 79351);

                            msg = f_1129_79156_79350(f_1129_79174_79226(), f_1129_79228_79249(this), f_1129_79251_79259(), resource.resourceId, resource.baseName, assemblyDisplayName);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1129, 79398, 79404);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 78043, 79419);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 79435, 79457);

                f_1129_79435_79456(
                            this, msg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 76823, 79468);

                string
                f_1129_77687_77730()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.AssemblyInGAC;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 77687, 77730);
                    return return_v;
                }


                string
                f_1129_77669_77754(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 77669, 77754);
                    return return_v;
                }


                string
                f_1129_78315_78361()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.AssemblyNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 78315, 78361);
                    return return_v;
                }


                string
                f_1129_78363_78384(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 78363, 78384);
                    return return_v;
                }


                string
                f_1129_78386_78394()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 78386, 78394);
                    return return_v;
                }


                string
                f_1129_78297_78416(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 78297, 78416);
                    return return_v;
                }


                string
                f_1129_78728_78774()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ResourceNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 78728, 78774);
                    return return_v;
                }


                string
                f_1129_78776_78797(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 78776, 78797);
                    return return_v;
                }


                string
                f_1129_78799_78807()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 78799, 78807);
                    return return_v;
                }


                string
                f_1129_78710_78848(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 78710, 78848);
                    return return_v;
                }


                string
                f_1129_79174_79226()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.StringResourceNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 79174, 79226);
                    return return_v;
                }


                string
                f_1129_79228_79249(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 79228, 79249);
                    return return_v;
                }


                string
                f_1129_79251_79259()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 79251, 79259);
                    return return_v;
                }


                string
                f_1129_79156_79350(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 79156, 79350);
                    return return_v;
                }


                int
                f_1129_79435_79456(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 79435, 79456);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 76823, 79468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 76823, 79468);
            }
        }

        internal bool VerifyScriptBlock(string scriptBlockText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 79856, 80647);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 79972, 80034);

                    f_1129_79972_80033(this.expressionFactory, scriptBlockText);
                }
                catch (ParseException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1129, 80063, 80376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 80200, 80330);

                    f_1129_80200_80329(                // Error at XPath {0} in file {1}: Invalid script block "{2}".
                                    this, f_1129_80217_80328(f_1129_80235_80283(), f_1129_80285_80306(this), f_1129_80308_80316(), f_1129_80318_80327(e)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 80348, 80361);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1129, 80063, 80376);
                }
                catch (Exception e) // will rethrow
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1129, 80390, 80608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 80458, 80569);

                    f_1129_80458_80568(false, "TypeInfoBaseLoader.VerifyScriptBlock unexpected exception " + f_1129_80547_80567(f_1129_80547_80558(e)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 80587, 80593);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1129, 80390, 80608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 80624, 80636);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 79856, 80647);

                int
                f_1129_79972_80033(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                this_param, string
                scriptText)
                {
                    this_param.VerifyScriptBlockText(scriptText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 79972, 80033);
                    return 0;
                }


                string
                f_1129_80235_80283()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 80235, 80283);
                    return return_v;
                }


                string
                f_1129_80285_80306(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 80285, 80306);
                    return return_v;
                }


                string
                f_1129_80308_80316()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 80308, 80316);
                    return return_v;
                }


                string
                f_1129_80318_80327(System.Management.Automation.ParseException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 80318, 80327);
                    return return_v;
                }


                string
                f_1129_80217_80328(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 80217, 80328);
                    return return_v;
                }


                int
                f_1129_80200_80329(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 80200, 80329);
                    return 0;
                }


                System.Type
                f_1129_80547_80558(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 80547, 80558);
                    return return_v;
                }


                string
                f_1129_80547_80567(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 80547, 80567);
                    return return_v;
                }


                int
                f_1129_80458_80568(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 80458, 80568);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 79856, 80647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 79856, 80647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class ExpressionNodeMatch
        {
            internal ExpressionNodeMatch(TypeInfoDataBaseLoader loader)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1129, 80866, 80990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 84762, 84769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 84808, 84814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 84842, 84861);
                    this._fatalError = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 80958, 80975);

                    _loader = loader;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1129, 80866, 80990);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 80866, 80990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 80866, 80990);
                }
            }

            internal bool MatchNode(XmlNode n)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 81006, 81199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 81073, 81184);

                    return f_1129_81080_81130(_loader, n, XmlTags.PropertyNameNode) || (DynAbs.Tracing.TraceSender.Expression_False(1129, 81080, 81183) || f_1129_81134_81183(_loader, n, XmlTags.ScriptBlockNode));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 81006, 81199);

                    bool
                    f_1129_81080_81130(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    s)
                    {
                        var return_v = this_param.MatchNodeName(n, s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 81080, 81130);
                        return return_v;
                    }


                    bool
                    f_1129_81134_81183(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    s)
                    {
                        var return_v = this_param.MatchNodeName(n, s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 81134, 81183);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 81006, 81199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 81006, 81199);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal bool ProcessNode(XmlNode n)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 81215, 84028);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 81284, 83845) || true) && (f_1129_81288_81338(_loader, n, XmlTags.PropertyNameNode))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 81284, 83845);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 81380, 81764) || true) && (_token != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 81380, 81764);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 81448, 81687) || true) && (_token.isScriptBlock)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 81448, 81687);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 81503, 81595);

                                f_1129_81503_81594(_loader, n, XmlTags.PropertyNameNode, XmlTags.ScriptBlockNode);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 81448, 81687);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 81448, 81687);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 81655, 81687);

                                f_1129_81655_81686(_loader, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 81448, 81687);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 81713, 81726);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 81380, 81764);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 81788, 81819);

                        _token = f_1129_81797_81818();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 81841, 81899);

                        _token.expressionValue = f_1129_81866_81898(_loader, n);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 81921, 82335) || true) && (_token.expressionValue == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 81921, 82335);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82083, 82213);

                            f_1129_82083_82212(                        // Error at XPath {0} in file {1}: Missing property.
                                                    _loader, f_1129_82103_82211(f_1129_82121_82161(), f_1129_82163_82192(_loader), f_1129_82194_82210(_loader)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82239, 82258);

                            _fatalError = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82284, 82297);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 81921, 82335);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82359, 82371);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 81284, 83845);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 81284, 83845);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82413, 83845) || true) && (f_1129_82417_82466(_loader, n, XmlTags.ScriptBlockNode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 82413, 83845);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82508, 82893) || true) && (_token != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 82508, 82893);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82576, 82816) || true) && (!_token.isScriptBlock)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 82576, 82816);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82632, 82724);

                                    f_1129_82632_82723(_loader, n, XmlTags.PropertyNameNode, XmlTags.ScriptBlockNode);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 82576, 82816);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 82576, 82816);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82784, 82816);

                                    f_1129_82784_82815(_loader, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 82576, 82816);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82842, 82855);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 82508, 82893);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82917, 82948);

                            _token = f_1129_82926_82947();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 82970, 82998);

                            _token.isScriptBlock = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 83020, 83078);

                            _token.expressionValue = f_1129_83045_83077(_loader, n);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 83100, 83530) || true) && (_token.expressionValue == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 83100, 83530);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 83271, 83408);

                                f_1129_83271_83407(                        // Error at XPath {0} in file {1}: Missing script block text.
                                                        _loader, f_1129_83291_83406(f_1129_83309_83356(), f_1129_83358_83387(_loader), f_1129_83389_83405(_loader)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 83434, 83453);

                                _fatalError = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 83479, 83492);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 83100, 83530);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 83554, 83790) || true) && ((!_loader._suppressValidation) && (DynAbs.Tracing.TraceSender.Expression_True(1129, 83558, 83644) && (!f_1129_83594_83643(_loader, _token.expressionValue))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 83554, 83790);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 83694, 83713);

                                _fatalError = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 83739, 83752);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 83554, 83790);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 83814, 83826);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 82413, 83845);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 81284, 83845);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 83937, 83982);

                    f_1129_83937_83981();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 84000, 84013);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 81215, 84028);

                    bool
                    f_1129_81288_81338(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    s)
                    {
                        var return_v = this_param.MatchNodeName(n, s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 81288, 81338);
                        return return_v;
                    }


                    int
                    f_1129_81503_81594(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    node1, string
                    node2)
                    {
                        this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 81503, 81594);
                        return 0;
                    }


                    int
                    f_1129_81655_81686(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        this_param.ProcessDuplicateNode(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 81655, 81686);
                        return 0;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                    f_1129_81797_81818()
                    {
                        var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 81797, 81818);
                        return return_v;
                    }


                    string
                    f_1129_81866_81898(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        var return_v = this_param.GetMandatoryInnerText(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 81866, 81898);
                        return return_v;
                    }


                    string
                    f_1129_82121_82161()
                    {
                        var return_v = FormatAndOutXmlLoadingStrings.NoProperty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 82121, 82161);
                        return return_v;
                    }


                    string
                    f_1129_82163_82192(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.ComputeCurrentXPath();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 82163, 82192);
                        return return_v;
                    }


                    string
                    f_1129_82194_82210(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 82194, 82210);
                        return return_v;
                    }


                    string
                    f_1129_82103_82211(string
                    formatSpec, string
                    o1, string
                    o2)
                    {
                        var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 82103, 82211);
                        return return_v;
                    }


                    int
                    f_1129_82083_82212(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, string
                    message)
                    {
                        this_param.ReportError(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 82083, 82212);
                        return 0;
                    }


                    bool
                    f_1129_82417_82466(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    s)
                    {
                        var return_v = this_param.MatchNodeName(n, s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 82417, 82466);
                        return return_v;
                    }


                    int
                    f_1129_82632_82723(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    node1, string
                    node2)
                    {
                        this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 82632, 82723);
                        return 0;
                    }


                    int
                    f_1129_82784_82815(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        this_param.ProcessDuplicateNode(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 82784, 82815);
                        return 0;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                    f_1129_82926_82947()
                    {
                        var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 82926, 82947);
                        return return_v;
                    }


                    string
                    f_1129_83045_83077(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        var return_v = this_param.GetMandatoryInnerText(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 83045, 83077);
                        return return_v;
                    }


                    string
                    f_1129_83309_83356()
                    {
                        var return_v = FormatAndOutXmlLoadingStrings.NoScriptBlockText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 83309, 83356);
                        return return_v;
                    }


                    string
                    f_1129_83358_83387(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.ComputeCurrentXPath();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 83358, 83387);
                        return return_v;
                    }


                    string
                    f_1129_83389_83405(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 83389, 83405);
                        return return_v;
                    }


                    string
                    f_1129_83291_83406(string
                    formatSpec, string
                    o1, string
                    o2)
                    {
                        var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 83291, 83406);
                        return return_v;
                    }


                    int
                    f_1129_83271_83407(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, string
                    message)
                    {
                        this_param.ReportError(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 83271, 83407);
                        return 0;
                    }


                    bool
                    f_1129_83594_83643(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, string
                    scriptBlockText)
                    {
                        var return_v = this_param.VerifyScriptBlock(scriptBlockText);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 83594, 83643);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1129_83937_83981()
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 83937, 83981);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 81215, 84028);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 81215, 84028);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal ExpressionToken GenerateExpressionToken()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 84044, 84715);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 84127, 84282) || true) && (_fatalError)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 84127, 84282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 84251, 84263);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 84127, 84282);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 84302, 84666) || true) && (_token == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 84302, 84666);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 84518, 84613);

                        f_1129_84518_84612(                    // we do not have a token: we never got one
                                                               // the user should have specified either a property or a script block
                                            _loader, new string[] { XmlTags.PropertyNameNode, XmlTags.ScriptBlockNode });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 84635, 84647);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 84302, 84666);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 84686, 84700);

                    return _token;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 84044, 84715);

                    int
                    f_1129_84518_84612(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, string[]
                    names)
                    {
                        this_param.ReportMissingNodes(names);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 84518, 84612);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 84044, 84715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 84044, 84715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypeInfoDataBaseLoader _loader;

            private ExpressionToken _token;

            private bool _fatalError;

            static ExpressionNodeMatch()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1129, 80801, 84873);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1129, 80801, 84873);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 80801, 84873);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1129, 80801, 84873);
        }
        private sealed class ViewEntryNodeMatch
        {
            internal ViewEntryNodeMatch(TypeInfoDataBaseLoader loader)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1129, 85157, 85280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90760, 90773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90806, 90816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90855, 90866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90914, 90921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 85248, 85265);

                    _loader = loader;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1129, 85157, 85280);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 85157, 85280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 85157, 85280);
                }
            }

            internal bool ProcessExpressionDirectives(XmlNode containerNode, List<XmlNode> unprocessedNodes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 85296, 90493);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 85425, 85535) || true) && (containerNode == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 85425, 85535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 85473, 85535);

                        throw f_1129_85479_85534("containerNode");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 85425, 85535);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 85555, 85582);

                    string
                    formatString = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 85600, 85627);

                    TextToken
                    textToken = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 85645, 85716);

                    ExpressionNodeMatch
                    expressionMatch = f_1129_85683_85715(_loader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 85736, 85771);

                    bool
                    formatStringNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 85809, 85842);

                    bool
                    expressionNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 85882, 85909);

                    bool
                    textNodeFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 85957, 88510);
                        foreach (XmlNode n in f_1129_85979_86003_I(f_1129_85979_86003(containerNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 85957, 88510);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86045, 88491) || true) && (f_1129_86049_86077(expressionMatch, n))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 86045, 88491);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86127, 86325) || true) && (expressionNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 86127, 86325);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86208, 86240);

                                    f_1129_86208_86239(_loader, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86270, 86283);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 86127, 86325);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86353, 86380);

                                expressionNodeFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86406, 86485) || true) && (!f_1129_86411_86441(expressionMatch, n))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 86406, 86485);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86472, 86485);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 86406, 86485);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 86045, 88491);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 86045, 88491);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86550, 88491) || true) && (f_1129_86554_86604(_loader, n, XmlTags.FormatStringNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 86550, 88491);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86654, 86854) || true) && (formatStringNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 86654, 86854);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86737, 86769);

                                        f_1129_86737_86768(_loader, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86799, 86812);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 86654, 86854);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86882, 86911);

                                    formatStringNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 86937, 86985);

                                    formatString = f_1129_86952_86984(_loader, n);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 87011, 87401) || true) && (formatString == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 87011, 87401);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 87182, 87316);

                                        f_1129_87182_87315(                            // Error at XPath {0} in file {1}: Missing a format string.
                                                                    _loader, f_1129_87202_87314(f_1129_87220_87264(), f_1129_87266_87295(_loader), f_1129_87297_87313(_loader)));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 87346, 87359);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 87011, 87401);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 86550, 88491);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 86550, 88491);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 87451, 88491) || true) && (f_1129_87455_87511(_loader, n, XmlTags.TextNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 87451, 88491);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 87561, 87753) || true) && (textNodeFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 87561, 87753);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 87636, 87668);

                                            f_1129_87636_87667(_loader, n);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 87698, 87711);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 87561, 87753);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 87781, 87802);

                                        textNodeFound = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 87828, 87860);

                                        textToken = f_1129_87840_87859(_loader, n);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 87886, 88276) || true) && (textToken == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 87886, 88276);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 88042, 88191);

                                            f_1129_88042_88190(                            // Error at XPath {0} in file {1}: Invalid {2}.
                                                                        _loader, f_1129_88062_88189(f_1129_88080_88121(), f_1129_88123_88152(_loader), f_1129_88154_88170(_loader), XmlTags.TextNode));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 88221, 88234);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 87886, 88276);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 87451, 88491);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 87451, 88491);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 88444, 88468);

                                        f_1129_88444_88467(                        // for further processing by calling context
                                                                unprocessedNodes, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 87451, 88491);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 86550, 88491);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 86045, 88491);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 85957, 88510);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1129, 1, 2554);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1129, 1, 2554);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 88530, 90446) || true) && (expressionNodeFound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 88530, 90446);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 88684, 89117) || true) && (textNodeFound)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 88684, 89117);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 88855, 89040);

                            f_1129_88855_89039(                        // Error at XPath {0} in file {1}: {2} cannot be specified with an expression.
                                                    _loader, f_1129_88875_89038(f_1129_88893_88941(), f_1129_88943_88972(_loader), f_1129_89003_89019(_loader), XmlTags.TextNode));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 89066, 89079);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 88684, 89117);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 89141, 89212);

                        ExpressionToken
                        expression = f_1129_89170_89211(expressionMatch)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 89234, 89357) || true) && (expression == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 89234, 89357);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 89306, 89319);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 89234, 89357);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 89425, 89566) || true) && (!f_1129_89430_89464(formatString))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 89425, 89566);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 89514, 89543);

                            _formatString = formatString;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 89425, 89566);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 89590, 89615);

                        _expression = expression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 88530, 90446);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 88530, 90446);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 89785, 90240) || true) && (formatStringNodeFound)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 89785, 90240);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 89967, 90163);

                            f_1129_89967_90162(                        // Error at XPath {0} in file {1}: {2} cannot be specified without an expression.
                                                    _loader, f_1129_89987_90161(f_1129_90005_90056(), f_1129_90058_90087(_loader), f_1129_90118_90134(_loader), XmlTags.FormatStringNode));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90189, 90202);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 89785, 90240);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90314, 90427) || true) && (textNodeFound)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 90314, 90427);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90381, 90404);

                            _textToken = textToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 90314, 90427);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 88530, 90446);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90466, 90478);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 85296, 90493);

                    System.Management.Automation.PSArgumentNullException
                    f_1129_85479_85534(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 85479, 85534);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                    f_1129_85683_85715(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    loader)
                    {
                        var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch(loader);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 85683, 85715);
                        return return_v;
                    }


                    System.Xml.XmlNodeList
                    f_1129_85979_86003(System.Xml.XmlNode
                    this_param)
                    {
                        var return_v = this_param.ChildNodes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 85979, 86003);
                        return return_v;
                    }


                    bool
                    f_1129_86049_86077(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        var return_v = this_param.MatchNode(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 86049, 86077);
                        return return_v;
                    }


                    int
                    f_1129_86208_86239(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        this_param.ProcessDuplicateNode(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 86208, 86239);
                        return 0;
                    }


                    bool
                    f_1129_86411_86441(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        var return_v = this_param.ProcessNode(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 86411, 86441);
                        return return_v;
                    }


                    bool
                    f_1129_86554_86604(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    s)
                    {
                        var return_v = this_param.MatchNodeName(n, s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 86554, 86604);
                        return return_v;
                    }


                    int
                    f_1129_86737_86768(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        this_param.ProcessDuplicateNode(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 86737, 86768);
                        return 0;
                    }


                    string
                    f_1129_86952_86984(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        var return_v = this_param.GetMandatoryInnerText(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 86952, 86984);
                        return return_v;
                    }


                    string
                    f_1129_87220_87264()
                    {
                        var return_v = FormatAndOutXmlLoadingStrings.NoFormatString;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 87220, 87264);
                        return return_v;
                    }


                    string
                    f_1129_87266_87295(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.ComputeCurrentXPath();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 87266, 87295);
                        return return_v;
                    }


                    string
                    f_1129_87297_87313(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 87297, 87313);
                        return return_v;
                    }


                    string
                    f_1129_87202_87314(string
                    formatSpec, string
                    o1, string
                    o2)
                    {
                        var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 87202, 87314);
                        return return_v;
                    }


                    int
                    f_1129_87182_87315(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, string
                    message)
                    {
                        this_param.ReportError(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 87182, 87315);
                        return 0;
                    }


                    bool
                    f_1129_87455_87511(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    s)
                    {
                        var return_v = this_param.MatchNodeNameWithAttributes(n, s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 87455, 87511);
                        return return_v;
                    }


                    int
                    f_1129_87636_87667(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        this_param.ProcessDuplicateNode(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 87636, 87667);
                        return 0;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.TextToken
                    f_1129_87840_87859(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    textNode)
                    {
                        var return_v = this_param.LoadText(textNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 87840, 87859);
                        return return_v;
                    }


                    string
                    f_1129_88080_88121()
                    {
                        var return_v = FormatAndOutXmlLoadingStrings.InvalidNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 88080, 88121);
                        return return_v;
                    }


                    string
                    f_1129_88123_88152(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.ComputeCurrentXPath();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 88123, 88152);
                        return return_v;
                    }


                    string
                    f_1129_88154_88170(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 88154, 88170);
                        return return_v;
                    }


                    string
                    f_1129_88062_88189(string
                    formatSpec, params object[]
                    o)
                    {
                        var return_v = StringUtil.Format(formatSpec, o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 88062, 88189);
                        return return_v;
                    }


                    int
                    f_1129_88042_88190(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, string
                    message)
                    {
                        this_param.ReportError(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 88042, 88190);
                        return 0;
                    }


                    int
                    f_1129_88444_88467(System.Collections.Generic.List<System.Xml.XmlNode>
                    this_param, System.Xml.XmlNode
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 88444, 88467);
                        return 0;
                    }


                    System.Xml.XmlNodeList
                    f_1129_85979_86003_I(System.Xml.XmlNodeList
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 85979, 86003);
                        return return_v;
                    }


                    string
                    f_1129_88893_88941()
                    {
                        var return_v = FormatAndOutXmlLoadingStrings.NodeWithExpression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 88893, 88941);
                        return return_v;
                    }


                    string
                    f_1129_88943_88972(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.ComputeCurrentXPath();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 88943, 88972);
                        return return_v;
                    }


                    string
                    f_1129_89003_89019(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 89003, 89019);
                        return return_v;
                    }


                    string
                    f_1129_88875_89038(string
                    formatSpec, params object[]
                    o)
                    {
                        var return_v = StringUtil.Format(formatSpec, o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 88875, 89038);
                        return return_v;
                    }


                    int
                    f_1129_88855_89039(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, string
                    message)
                    {
                        this_param.ReportError(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 88855, 89039);
                        return 0;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                    f_1129_89170_89211(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                    this_param)
                    {
                        var return_v = this_param.GenerateExpressionToken();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 89170, 89211);
                        return return_v;
                    }


                    bool
                    f_1129_89430_89464(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 89430, 89464);
                        return return_v;
                    }


                    string
                    f_1129_90005_90056()
                    {
                        var return_v = FormatAndOutXmlLoadingStrings.NodeWithoutExpression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 90005, 90056);
                        return return_v;
                    }


                    string
                    f_1129_90058_90087(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.ComputeCurrentXPath();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 90058, 90087);
                        return return_v;
                    }


                    string
                    f_1129_90118_90134(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param)
                    {
                        var return_v = this_param.FilePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1129, 90118, 90134);
                        return return_v;
                    }


                    string
                    f_1129_89987_90161(string
                    formatSpec, params object[]
                    o)
                    {
                        var return_v = StringUtil.Format(formatSpec, o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 89987, 90161);
                        return return_v;
                    }


                    int
                    f_1129_89967_90162(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, string
                    message)
                    {
                        this_param.ReportError(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 89967, 90162);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 85296, 90493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 85296, 90493);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal string FormatString
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 90540, 90569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90546, 90567);

                        return _formatString;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 90540, 90569);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 90509, 90571);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 90509, 90571);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal TextToken TextToken
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 90618, 90644);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90624, 90642);

                        return _textToken;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 90618, 90644);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 90587, 90646);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 90587, 90646);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal ExpressionToken Expression
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 90700, 90727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 90706, 90725);

                        return _expression;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 90700, 90727);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 90662, 90729);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 90662, 90729);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private string _formatString;

            private TextToken _textToken;

            private ExpressionToken _expression;

            private TypeInfoDataBaseLoader _loader;

            static ViewEntryNodeMatch()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1129, 85093, 90933);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1129, 85093, 90933);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 85093, 90933);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1129, 85093, 90933);
        }
        private sealed class ComplexControlMatch
        {
            internal ComplexControlMatch(TypeInfoDataBaseLoader loader)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1129, 91075, 91199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92700, 92708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92754, 92761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 91167, 91184);

                    _loader = loader;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1129, 91075, 91199);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 91075, 91199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 91075, 91199);
                }
            }

            internal bool MatchNode(XmlNode n)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 91215, 91442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 91282, 91427);

                    return f_1129_91289_91341(_loader, n, XmlTags.ComplexControlNode) || (DynAbs.Tracing.TraceSender.Expression_False(1129, 91289, 91426) || f_1129_91370_91426(_loader, n, XmlTags.ComplexControlNameNode));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 91215, 91442);

                    bool
                    f_1129_91289_91341(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    s)
                    {
                        var return_v = this_param.MatchNodeName(n, s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 91289, 91341);
                        return return_v;
                    }


                    bool
                    f_1129_91370_91426(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    s)
                    {
                        var return_v = this_param.MatchNodeName(n, s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 91370, 91426);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 91215, 91442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 91215, 91442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal bool ProcessNode(XmlNode n)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 91458, 92548);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 91527, 92365) || true) && (f_1129_91531_91583(_loader, n, XmlTags.ComplexControlNode))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 91527, 92365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 91682, 91723);

                        _control = f_1129_91693_91722(_loader, n);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 91745, 91757);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 91527, 92365);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 91527, 92365);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 91799, 92365) || true) && (f_1129_91803_91859(_loader, n, XmlTags.ComplexControlNameNode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 91799, 92365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 91901, 91948);

                            string
                            name = f_1129_91915_91947(_loader, n)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 91970, 92072) || true) && (name == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1129, 91970, 92072);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92036, 92049);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 91970, 92072);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92096, 92149);

                            ControlReference
                            controlRef = f_1129_92126_92148()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92171, 92194);

                            controlRef.name = name;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92216, 92268);

                            controlRef.controlType = typeof(ComplexControlBody);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92290, 92312);

                            _control = controlRef;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92334, 92346);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 91799, 92365);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1129, 91527, 92365);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92457, 92502);

                    f_1129_92457_92501();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92520, 92533);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 91458, 92548);

                    bool
                    f_1129_91531_91583(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    s)
                    {
                        var return_v = this_param.MatchNodeName(n, s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 91531, 91583);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                    f_1129_91693_91722(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    controlNode)
                    {
                        var return_v = this_param.LoadComplexControl(controlNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 91693, 91722);
                        return return_v;
                    }


                    bool
                    f_1129_91803_91859(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n, string
                    s)
                    {
                        var return_v = this_param.MatchNodeName(n, s);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 91803, 91859);
                        return return_v;
                    }


                    string
                    f_1129_91915_91947(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                    this_param, System.Xml.XmlNode
                    n)
                    {
                        var return_v = this_param.GetMandatoryInnerText(n);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 91915, 91947);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.ControlReference
                    f_1129_92126_92148()
                    {
                        var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ControlReference();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 92126, 92148);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1129_92457_92501()
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 92457, 92501);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 91458, 92548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 91458, 92548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal ControlBase Control
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1129, 92625, 92649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 92631, 92647);

                        return _control;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1129, 92625, 92649);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1129, 92564, 92664);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 92564, 92664);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private ControlBase _control;

            private TypeInfoDataBaseLoader _loader;

            static ComplexControlMatch()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1129, 91010, 92773);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1129, 91010, 92773);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 91010, 92773);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1129, 91010, 92773);
        }

        public TypeInfoDataBaseLoader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1129, 1214, 92802);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 7870, 7897);
            this._suppressValidation = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1129, 1214, 92802);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 1214, 92802);
        }


        static TypeInfoDataBaseLoader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1129, 1214, 92802);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 1320, 1365);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1129, 1506, 1592);
            s_tracer = f_1129_1517_1592("TypeInfoDataBaseLoader", "TypeInfoDataBaseLoader");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1129, 1214, 92802);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1129, 1214, 92802);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1129, 1214, 92802);

        static System.Management.Automation.PSTraceSource
        f_1129_1517_1592(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1129, 1517, 1592);
            return return_v;
        }

    }
}

