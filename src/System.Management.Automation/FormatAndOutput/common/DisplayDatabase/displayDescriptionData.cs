// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// this file contains the data structures for the in memory database
// containing display and formatting information

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.PowerShell.Commands;
using Microsoft.PowerShell.Commands.Internal.Format;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal enum EnumerableExpansion
    {
        /// <summary>
        /// Process core only, ignore IEumerable.
        /// </summary>
        CoreOnly,

        /// <summary>
        /// Process IEnumerable, ignore core.
        /// </summary>
        EnumOnly,

        /// <summary>
        /// Process both core and IEnumerable, core first.
        /// </summary>
        Both,
    }
    internal sealed partial class TypeInfoDataBase
    {
        internal DefaultSettingsSection defaultSettingsSection;

        internal TypeGroupsSection typeGroupSection;

        internal ViewDefinitionsSection viewDefinitionsSection;

        internal FormatControlDefinitionHolder formatControlDefinitionHolder;

        internal DisplayResourceManagerCache displayResourceManagerCache;

        public TypeInfoDataBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 902, 1628);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1056, 1109);
            this.defaultSettingsSection = f_1118_1081_1109();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1147, 1189);
            this.typeGroupSection = f_1118_1166_1189();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1232, 1285);
            this.viewDefinitionsSection = f_1118_1257_1285();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1335, 1402);
            this.formatControlDefinitionHolder = f_1118_1367_1402();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1557, 1620);
            this.displayResourceManagerCache = f_1118_1587_1620();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 902, 1628);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 902, 1628);
        }


        static TypeInfoDataBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 902, 1628);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 902, 1628);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 902, 1628);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 902, 1628);

        Microsoft.PowerShell.Commands.Internal.Format.DefaultSettingsSection
        f_1118_1081_1109()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.DefaultSettingsSection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 1081, 1109);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.TypeGroupsSection
        f_1118_1166_1189()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeGroupsSection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 1166, 1189);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.ViewDefinitionsSection
        f_1118_1257_1285()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ViewDefinitionsSection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 1257, 1285);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.FormatControlDefinitionHolder
        f_1118_1367_1402()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatControlDefinitionHolder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 1367, 1402);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
        f_1118_1587_1620()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 1587, 1620);
            return return_v;
        }

    }
    internal sealed class DatabaseLoadingInfo
    {
        internal string fileDirectory;

        internal string filePath;

        internal bool isFullyTrusted;

        internal bool isProductCode;

        internal string xPath;

        internal DateTime loadTime;

        public DatabaseLoadingInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 1636, 1964);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1710, 1730);
            this.fileDirectory = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1757, 1772);
            this.filePath = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1797, 1819);
            this.isFullyTrusted = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1844, 1865);
            this.isProductCode = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1892, 1904);
            this.xPath = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 1933, 1956);
            this.loadTime = DateTime.Now;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 1636, 1964);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 1636, 1964);
        }


        static DatabaseLoadingInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 1636, 1964);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 1636, 1964);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 1636, 1964);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 1636, 1964);
    }
    internal sealed class DefaultSettingsSection
    {
        internal bool MultilineTables
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 2954, 3121);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 2990, 3106) || true) && (f_1118_2994_3020_M(!_multilineTables.HasValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 2990, 3106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 3062, 3087);

                        _multilineTables = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 2990, 3106);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 2954, 3121);

                    bool
                    f_1118_2994_3020_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 2994, 3020);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 2900, 3312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 2900, 3312);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 3137, 3301);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 3173, 3255) || true) && (f_1118_3177_3202(_multilineTables))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 3173, 3255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 3225, 3255);

                        return f_1118_3232_3254(_multilineTables);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 3173, 3255);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 3273, 3286);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 3137, 3301);

                    bool
                    f_1118_3177_3202(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 3177, 3202);
                        return return_v;
                    }


                    bool
                    f_1118_3232_3254(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 3232, 3254);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 2900, 3312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 2900, 3312);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool? _multilineTables;

        internal FormatErrorPolicy formatErrorPolicy;

        internal ShapeSelectionDirectives shapeSelectionDirectives;

        internal List<EnumerableExpansionDirective> enumerableExpansionDirectiveList;

        public DefaultSettingsSection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 2839, 3677);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 3338, 3354);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 3394, 3437);
            this.formatErrorPolicy = f_1118_3414_3437();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 3482, 3539);
            this.shapeSelectionDirectives = f_1118_3509_3539();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 3594, 3669);
            this.enumerableExpansionDirectiveList = f_1118_3629_3669();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 2839, 3677);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 2839, 3677);
        }


        static DefaultSettingsSection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 2839, 3677);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 2839, 3677);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 2839, 3677);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 2839, 3677);

        Microsoft.PowerShell.Commands.Internal.Format.FormatErrorPolicy
        f_1118_3414_3437()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatErrorPolicy();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 3414, 3437);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.ShapeSelectionDirectives
        f_1118_3509_3539()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ShapeSelectionDirectives();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 3509, 3539);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective>
        f_1118_3629_3669()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 3629, 3669);
            return return_v;
        }

    }
    internal sealed class FormatErrorPolicy
    {
        internal bool ShowErrorsAsMessages
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 3893, 4070);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 3929, 4055) || true) && (f_1118_3933_3964_M(!_showErrorsAsMessages.HasValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 3929, 4055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4006, 4036);

                        _showErrorsAsMessages = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 3929, 4055);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 3893, 4070);

                    bool
                    f_1118_3933_3964_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 3933, 3964);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 3834, 4271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 3834, 4271);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 4086, 4260);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4122, 4214) || true) && (f_1118_4126_4156(_showErrorsAsMessages))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 4122, 4214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4179, 4214);

                        return f_1118_4186_4213(_showErrorsAsMessages);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 4122, 4214);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4232, 4245);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 4086, 4260);

                    bool
                    f_1118_4126_4156(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 4126, 4156);
                        return return_v;
                    }


                    bool
                    f_1118_4186_4213(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 4186, 4213);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 3834, 4271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 3834, 4271);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool? _showErrorsAsMessages;

        internal bool ShowErrorsInFormattedOutput
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 4551, 4742);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4587, 4727) || true) && (f_1118_4591_4629_M(!_showErrorsInFormattedOutput.HasValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 4587, 4727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4671, 4708);

                        _showErrorsInFormattedOutput = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 4587, 4727);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 4551, 4742);

                    bool
                    f_1118_4591_4629_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 4591, 4629);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 4485, 4957);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 4485, 4957);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 4758, 4946);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4794, 4900) || true) && (f_1118_4798_4835(_showErrorsInFormattedOutput))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 4794, 4900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4858, 4900);

                        return f_1118_4865_4899(_showErrorsInFormattedOutput);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 4794, 4900);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4918, 4931);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 4758, 4946);

                    bool
                    f_1118_4798_4835(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 4798, 4835);
                        return return_v;
                    }


                    bool
                    f_1118_4865_4899(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 4865, 4899);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 4485, 4957);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 4485, 4957);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool? _showErrorsInFormattedOutput;

        internal string errorStringInFormattedOutput;

        internal string formatErrorStringInFormattedOutput;

        public FormatErrorPolicy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 3685, 5533);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4297, 4318);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 4983, 5011);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 5232, 5269);
            this.errorStringInFormattedOutput = "#ERR";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 5479, 5525);
            this.formatErrorStringInFormattedOutput = "#FMTERR";
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 3685, 5533);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 3685, 5533);
        }


        static FormatErrorPolicy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 3685, 5533);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 3685, 5533);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 3685, 5533);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 3685, 5533);
    }
    internal sealed class ShapeSelectionDirectives
    {
        internal int PropertyCountForTable
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 5663, 5842);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 5699, 5827) || true) && (f_1118_5703_5735_M(!_propertyCountForTable.HasValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 5699, 5827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 5777, 5808);

                        _propertyCountForTable = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 5699, 5827);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 5663, 5842);

                    bool
                    f_1118_5703_5735_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 5703, 5735);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 5604, 6041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 5604, 6041);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 5858, 6030);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 5894, 5988) || true) && (f_1118_5898_5929(_propertyCountForTable))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 5894, 5988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 5952, 5988);

                        return f_1118_5959_5987(_propertyCountForTable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 5894, 5988);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 6006, 6015);

                    return 4;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 5858, 6030);

                    bool
                    f_1118_5898_5929(int?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 5898, 5929);
                        return return_v;
                    }


                    int
                    f_1118_5959_5987(int?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 5959, 5987);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 5604, 6041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 5604, 6041);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int? _propertyCountForTable;

        internal List<FormatShapeSelectionOnType> formatShapeSelectionOnTypeList;

        public ShapeSelectionDirectives()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 5541, 6222);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 6066, 6088);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 6143, 6214);
            this.formatShapeSelectionOnTypeList = f_1118_6176_6214();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 5541, 6222);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 5541, 6222);
        }


        static ShapeSelectionDirectives()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 5541, 6222);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 5541, 6222);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 5541, 6222);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 5541, 6222);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatShapeSelectionOnType>
        f_1118_6176_6214()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatShapeSelectionOnType>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 6176, 6214);
            return return_v;
        }

    }

    internal enum FormatShape { Table, List, Wide, Complex, Undefined }
    internal abstract class FormatShapeSelectionBase
    {
        internal FormatShape formatShape;

        public FormatShapeSelectionBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 6305, 6434);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 6391, 6426);
            this.formatShape = FormatShape.Undefined;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 6305, 6434);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 6305, 6434);
        }


        static FormatShapeSelectionBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 6305, 6434);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 6305, 6434);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 6305, 6434);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 6305, 6434);
    }
    internal sealed class FormatShapeSelectionOnType : FormatShapeSelectionBase
    {
        internal AppliesTo appliesTo;

        public FormatShapeSelectionOnType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 6442, 6570);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 6553, 6562);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 6442, 6570);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 6442, 6570);
        }


        static FormatShapeSelectionOnType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 6442, 6570);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 6442, 6570);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 6442, 6570);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 6442, 6570);
    }
    internal sealed class EnumerableExpansionDirective
    {
        internal EnumerableExpansion enumerableExpansion;

        internal AppliesTo appliesTo;

        public EnumerableExpansionDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 6578, 6771);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 6674, 6724);
            this.enumerableExpansion = EnumerableExpansion.EnumOnly;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 6754, 6763);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 6578, 6771);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 6578, 6771);
        }


        static EnumerableExpansionDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 6578, 6771);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 6578, 6771);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 6578, 6771);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 6578, 6771);
    }
    internal sealed class TypeGroupsSection
    {
        internal List<TypeGroupDefinition> typeGroupDefinitionList;

        public TypeGroupsSection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 6836, 6992);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 6927, 6984);
            this.typeGroupDefinitionList = f_1118_6953_6984();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 6836, 6992);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 6836, 6992);
        }


        static TypeGroupsSection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 6836, 6992);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 6836, 6992);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 6836, 6992);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 6836, 6992);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition>
        f_1118_6953_6984()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 6953, 6984);
            return return_v;
        }

    }
    internal sealed class TypeGroupDefinition
    {
        internal string name;

        internal List<TypeReference> typeReferenceList;

        public TypeGroupDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 7000, 7171);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 7074, 7078);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 7118, 7163);
            this.typeReferenceList = f_1118_7138_7163();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 7000, 7171);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7000, 7171);
        }


        static TypeGroupDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 7000, 7171);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 7000, 7171);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7000, 7171);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 7000, 7171);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeReference>
        f_1118_7138_7163()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeReference>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 7138, 7163);
            return return_v;
        }

    }
    internal abstract class TypeOrGroupReference
    {
        internal string name;

        internal ExpressionToken conditionToken;

        public TypeOrGroupReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 7179, 7432);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 7256, 7260);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 7403, 7424);
            this.conditionToken = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 7179, 7432);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7179, 7432);
        }


        static TypeOrGroupReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 7179, 7432);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 7179, 7432);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7179, 7432);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 7179, 7432);
    }
    internal sealed class TypeReference : TypeOrGroupReference
    {
        public TypeReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 7440, 7512);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 7440, 7512);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7440, 7512);
        }


        static TypeReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 7440, 7512);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 7440, 7512);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7440, 7512);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 7440, 7512);
    }
    internal sealed class TypeGroupReference : TypeOrGroupReference
    {
        public TypeGroupReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 7520, 7597);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 7520, 7597);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7520, 7597);
        }


        static TypeGroupReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 7520, 7597);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 7520, 7597);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7520, 7597);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 7520, 7597);
    }
    internal abstract class FormatToken
    {
        public FormatToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 7656, 7705);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 7656, 7705);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7656, 7705);
        }


        static FormatToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 7656, 7705);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 7656, 7705);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7656, 7705);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 7656, 7705);
    }
    internal sealed class TextToken : FormatToken
    {
        internal string text;

        internal StringResourceReference resource;

        public TextToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 7713, 7855);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 7791, 7795);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 7839, 7847);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 7713, 7855);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7713, 7855);
        }


        static TextToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 7713, 7855);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 7713, 7855);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7713, 7855);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 7713, 7855);
    }
    internal sealed class NewLineToken : FormatToken
    {
        internal int count;

        public NewLineToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 7863, 7958);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 7941, 7950);
            this.count = 1;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 7863, 7958);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7863, 7958);
        }


        static NewLineToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 7863, 7958);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 7863, 7958);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7863, 7958);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 7863, 7958);
    }
    internal sealed class FrameToken : FormatToken
    {
        internal ComplexControlItemDefinition itemDefinition;

        internal FrameInfoDefinition frameInfoDefinition;

        public FrameToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 7966, 8429);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 8171, 8222);
            this.itemDefinition = f_1118_8188_8222();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 8374, 8421);
            this.frameInfoDefinition = f_1118_8396_8421();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 7966, 8429);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7966, 8429);
        }


        static FrameToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 7966, 8429);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 7966, 8429);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 7966, 8429);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 7966, 8429);

        Microsoft.PowerShell.Commands.Internal.Format.ComplexControlItemDefinition
        f_1118_8188_8222()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexControlItemDefinition();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 8188, 8222);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.FrameInfoDefinition
        f_1118_8396_8421()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FrameInfoDefinition();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 8396, 8421);
            return return_v;
        }

    }
    internal sealed class FrameInfoDefinition
    {
        internal int leftIndentation;

        internal int rightIndentation;

        internal int firstLine;

        public FrameInfoDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 8437, 9421);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 8667, 8686);
            this.leftIndentation = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 8872, 8892);
            this.rightIndentation = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 9400, 9413);
            this.firstLine = 0;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 8437, 9421);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 8437, 9421);
        }


        static FrameInfoDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 8437, 9421);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 8437, 9421);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 8437, 9421);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 8437, 9421);
    }
    internal sealed class ExpressionToken
    {
        internal ExpressionToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 9483, 9513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 9743, 9756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 9783, 9798);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 9483, 9513);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 9483, 9513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 9483, 9513);
            }
        }

        internal ExpressionToken(string expressionValue, bool isScriptBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 9525, 9717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 9743, 9756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 9783, 9798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 9618, 9657);

                this.expressionValue = expressionValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 9671, 9706);

                this.isScriptBlock = isScriptBlock;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 9525, 9717);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 9525, 9717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 9525, 9717);
            }
        }

        internal bool isScriptBlock;

        internal string expressionValue;

        static ExpressionToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 9429, 9806);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 9429, 9806);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 9429, 9806);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 9429, 9806);
    }
    internal abstract class PropertyTokenBase : FormatToken
    {
        internal ExpressionToken conditionToken;

        internal ExpressionToken expression;

        internal bool enumerateCollection;

        public PropertyTokenBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 9814, 10169);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 10016, 10037);
            this.conditionToken = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 10075, 10109);
            this.expression = f_1118_10088_10109();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 10134, 10161);
            this.enumerateCollection = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 9814, 10169);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 9814, 10169);
        }


        static PropertyTokenBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 9814, 10169);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 9814, 10169);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 9814, 10169);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 9814, 10169);

        Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
        f_1118_10088_10109()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 10088, 10109);
            return return_v;
        }

    }
    internal sealed class CompoundPropertyToken : PropertyTokenBase
    {
        internal ControlBase control;

        public CompoundPropertyToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 10177, 10418);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 10396, 10410);
            this.control = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 10177, 10418);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 10177, 10418);
        }


        static CompoundPropertyToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 10177, 10418);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 10177, 10418);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 10177, 10418);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 10177, 10418);
    }
    internal sealed class FieldPropertyToken : PropertyTokenBase
    {
        internal FieldFormattingDirective fieldFormattingDirective;

        public FieldPropertyToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 10426, 10602);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 10537, 10594);
            this.fieldFormattingDirective = f_1118_10564_10594();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 10426, 10602);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 10426, 10602);
        }


        static FieldPropertyToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 10426, 10602);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 10426, 10602);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 10426, 10602);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 10426, 10602);

        Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
        f_1118_10564_10594()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 10564, 10594);
            return return_v;
        }

    }
    internal sealed class FieldFormattingDirective
    {
        internal string formatString;

        public FieldFormattingDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 10610, 10728);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 10689, 10708);
            this.formatString = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 10610, 10728);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 10610, 10728);
        }


        static FieldFormattingDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 10610, 10728);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 10610, 10728);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 10610, 10728);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 10610, 10728);
    }
    internal abstract class ControlBase
    {
        internal static string GetControlShapeName(ControlBase control)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1118, 10958, 11605);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 11046, 11162) || true) && (control is TableControlBody)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 11046, 11162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 11111, 11147);

                    return f_1118_11118_11146(FormatShape.Table);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 11046, 11162);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 11178, 11292) || true) && (control is ListControlBody)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 11178, 11292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 11242, 11277);

                    return f_1118_11249_11276(FormatShape.List);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 11178, 11292);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 11308, 11422) || true) && (control is WideControlBody)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 11308, 11422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 11372, 11407);

                    return f_1118_11379_11406(FormatShape.Wide);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 11308, 11422);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 11438, 11558) || true) && (control is ComplexControlBody)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 11438, 11558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 11505, 11543);

                    return f_1118_11512_11542(FormatShape.Complex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 11438, 11558);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 11574, 11594);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1118, 10958, 11605);

                string
                f_1118_11118_11146(Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 11118, 11146);
                    return return_v;
                }


                string
                f_1118_11249_11276(Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 11249, 11276);
                    return return_v;
                }


                string
                f_1118_11379_11406(Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 11379, 11406);
                    return return_v;
                }


                string
                f_1118_11512_11542(Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 11512, 11542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 10958, 11605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 10958, 11605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual ControlBase Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 11756, 12023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 11816, 11986);

                f_1118_11816_11985(false, "This should never be called directly on the base. Let the derived class implement this method.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 12000, 12012);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 11756, 12023);

                int
                f_1118_11816_11985(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    System.Management.Automation.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 11816, 11985);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 11756, 12023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 11756, 12023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ControlBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 10906, 12030);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 10906, 12030);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 10906, 12030);
        }


        static ControlBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 10906, 12030);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 10906, 12030);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 10906, 12030);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 10906, 12030);
    }
    internal sealed class ControlReference : ControlBase
    {
        internal string name;

        internal Type controlType;

        public ControlReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 12110, 12483);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 12307, 12318);
            this.name = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 12457, 12475);
            this.controlType = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 12110, 12483);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 12110, 12483);
        }


        static ControlReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 12110, 12483);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 12110, 12483);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 12110, 12483);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 12110, 12483);
    }
    internal abstract class ControlBody : ControlBase
    {
        internal bool? autosize;

        internal bool repeatHeader;

        public ControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 12710, 13051);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 12893, 12908);
            this.autosize = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 13023, 13043);
            this.repeatHeader = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 12710, 13051);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 12710, 13051);
        }


        static ControlBody()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 12710, 13051);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 12710, 13051);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 12710, 13051);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 12710, 13051);
    }
    internal sealed class ControlDefinition
    {
        internal string name;

        internal ControlBody controlBody;

        public ControlDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 13148, 13511);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 13330, 13341);
            this.name = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 13485, 13503);
            this.controlBody = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 13148, 13511);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 13148, 13511);
        }


        static ControlDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 13148, 13511);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 13148, 13511);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 13148, 13511);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 13148, 13511);
    }
    internal sealed class ViewDefinitionsSection
    {
        internal List<ViewDefinition> viewDefinitionList;

        public ViewDefinitionsSection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 13580, 13726);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 13671, 13718);
            this.viewDefinitionList = f_1118_13692_13718();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 13580, 13726);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 13580, 13726);
        }


        static ViewDefinitionsSection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 13580, 13726);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 13580, 13726);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 13580, 13726);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 13580, 13726);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
        f_1118_13692_13718()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 13692, 13718);
            return return_v;
        }

    }
    internal sealed partial class AppliesTo
    {
        internal List<TypeOrGroupReference> referenceList;

        public AppliesTo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 13734, 13947);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 13891, 13939);
            this.referenceList = f_1118_13907_13939();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 13734, 13947);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 13734, 13947);
        }


        static AppliesTo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 13734, 13947);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 13734, 13947);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 13734, 13947);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 13734, 13947);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
        f_1118_13907_13939()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 13907, 13939);
            return return_v;
        }

    }
    internal sealed class GroupBy
    {
        internal StartGroup startGroup;

        public GroupBy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 13955, 14295);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 14021, 14050);
            this.startGroup = f_1118_14034_14050();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 13955, 14295);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 13955, 14295);
        }


        static GroupBy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 13955, 14295);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 13955, 14295);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 13955, 14295);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 13955, 14295);

        Microsoft.PowerShell.Commands.Internal.Format.StartGroup
        f_1118_14034_14050()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.StartGroup();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 14034, 14050);
            return return_v;
        }

    }
    internal sealed class StartGroup
    {
        internal ExpressionToken expression;

        internal ControlBase control;

        internal TextToken labelTextToken;

        public StartGroup()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 14303, 14911);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 14483, 14500);
            this.expression = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 14652, 14666);
            this.control = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 14882, 14903);
            this.labelTextToken = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 14303, 14911);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 14303, 14911);
        }


        static StartGroup()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 14303, 14911);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 14303, 14911);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 14303, 14911);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 14303, 14911);
    }
    internal sealed class FormatControlDefinitionHolder
    {
        internal List<ControlDefinition> controlDefinitionList;

        public FormatControlDefinitionHolder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 15002, 15253);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 15192, 15245);
            this.controlDefinitionList = f_1118_15216_15245();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 15002, 15253);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 15002, 15253);
        }


        static FormatControlDefinitionHolder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 15002, 15253);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 15002, 15253);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 15002, 15253);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 15002, 15253);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
        f_1118_15216_15245()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 15216, 15245);
            return return_v;
        }

    }
    internal sealed class ViewDefinition
    {
        internal DatabaseLoadingInfo loadingInfo;

        internal string name;

        internal AppliesTo appliesTo;

        internal GroupBy groupBy;

        internal FormatControlDefinitionHolder formatControlDefinitionHolder;

        internal ControlBase mainControl;

        internal bool outOfBand;

        internal bool isHelpFormatter;

        internal Guid InstanceId { get; private set; }

        internal ViewDefinition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 16720, 16809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 15413, 15424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 15554, 15558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 15688, 15715);
                this.appliesTo = f_1118_15700_15715();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 15834, 15841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 16005, 16072);
                this.formatControlDefinitionHolder = f_1118_16037_16072();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 16240, 16251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 16377, 16386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 16634, 16649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 16770, 16798);

                InstanceId = Guid.NewGuid();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 16720, 16809);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 16720, 16809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 16720, 16809);
            }
        }

        static ViewDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 15331, 16816);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 15331, 16816);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 15331, 16816);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 15331, 16816);

        Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
        f_1118_15700_15715()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.AppliesTo();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 15700, 15715);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.FormatControlDefinitionHolder
        f_1118_16037_16072()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatControlDefinitionHolder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 16037, 16072);
            return return_v;
        }

    }
    internal abstract class FormatDirective
    {
        public FormatDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 16922, 16975);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 16922, 16975);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 16922, 16975);
        }


        static FormatDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 16922, 16975);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 16922, 16975);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 16922, 16975);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 16922, 16975);
    }
    internal sealed class StringResourceReference
    {
        internal DatabaseLoadingInfo loadingInfo;

        internal string assemblyName;

        internal string assemblyLocation;

        internal string baseName;

        internal string resourceId;

        public StringResourceReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 17036, 17335);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 17127, 17145);
            this.loadingInfo = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 17172, 17191);
            this.assemblyName = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 17218, 17241);
            this.assemblyLocation = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 17268, 17283);
            this.baseName = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 17310, 17327);
            this.resourceId = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 17036, 17335);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 17036, 17335);
        }


        static StringResourceReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 17036, 17335);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 17036, 17335);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 17036, 17335);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 17036, 17335);
    }

}

namespace System.Management.Automation
{
    public sealed class ExtendedTypeDefinition
    {
        public string TypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 17928, 17956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 17934, 17954);

                    return f_1118_17941_17953(f_1118_17941_17950(), 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 17928, 17956);

                    System.Collections.Generic.List<string>
                    f_1118_17941_17950()
                    {
                        var return_v = TypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 17941, 17950);
                        return return_v;
                    }


                    string
                    f_1118_17941_17953(System.Collections.Generic.List<string>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 17941, 17953);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 17881, 17967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 17881, 17967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public List<string> TypeNames { get; internal set; }

        public List<FormatViewDefinition> FormatViewDefinition { get; internal set; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 18540, 18625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 18598, 18614);

                return f_1118_18605_18613();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 18540, 18625);

                string
                f_1118_18605_18613()
                {
                    var return_v = TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 18605, 18613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 18540, 18625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 18540, 18625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ExtendedTypeDefinition(string typeName, IEnumerable<FormatViewDefinition> viewDefinitions) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 18838, 19413);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 18969, 19079) || true) && (f_1118_18973_19003(typeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 18969, 19079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19022, 19079);

                    throw f_1118_19028_19078("typeName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 18969, 19079);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19093, 19203) || true) && (viewDefinitions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 19093, 19203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19139, 19203);

                    throw f_1118_19145_19202("viewDefinitions");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 19093, 19203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19219, 19243);

                f_1118_19219_19242(f_1118_19219_19228(), typeName);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19257, 19402);
                    foreach (FormatViewDefinition definition in f_1118_19301_19316_I(viewDefinitions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 19257, 19402);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19350, 19387);

                        f_1118_19350_19386(f_1118_19350_19370(), definition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 19257, 19402);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1118, 1, 146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1118, 1, 146);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 18838, 19413);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 18838, 19413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 18838, 19413);
            }
        }

        public ExtendedTypeDefinition(string typeName) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 19597, 19838);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19677, 19787) || true) && (f_1118_19681_19711(typeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 19677, 19787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19730, 19787);

                    throw f_1118_19736_19786("typeName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 19677, 19787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19803, 19827);

                f_1118_19803_19826(f_1118_19803_19812(), typeName);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 19597, 19838);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 19597, 19838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 19597, 19838);
            }
        }

        internal ExtendedTypeDefinition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 19850, 20020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 18105, 18157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 18297, 18374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19908, 19964);

                FormatViewDefinition = f_1118_19931_19963();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 19978, 20009);

                TypeNames = f_1118_19990_20008();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 19850, 20020);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 19850, 20020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 19850, 20020);
            }
        }

        static ExtendedTypeDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 17508, 20027);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 17508, 20027);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 17508, 20027);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 17508, 20027);

        bool
        f_1118_18973_19003(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 18973, 19003);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1118_19028_19078(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 19028, 19078);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1118_19145_19202(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 19145, 19202);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1118_19219_19228()
        {
            var return_v = TypeNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 19219, 19228);
            return return_v;
        }


        int
        f_1118_19219_19242(System.Collections.Generic.List<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 19219, 19242);
            return 0;
        }


        System.Collections.Generic.List<System.Management.Automation.FormatViewDefinition>
        f_1118_19350_19370()
        {
            var return_v = FormatViewDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 19350, 19370);
            return return_v;
        }


        int
        f_1118_19350_19386(System.Collections.Generic.List<System.Management.Automation.FormatViewDefinition>
        this_param, System.Management.Automation.FormatViewDefinition
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 19350, 19386);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
        f_1118_19301_19316_I(System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 19301, 19316);
            return return_v;
        }


        bool
        f_1118_19681_19711(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 19681, 19711);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1118_19736_19786(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 19736, 19786);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1118_19803_19812()
        {
            var return_v = TypeNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 19803, 19812);
            return return_v;
        }


        int
        f_1118_19803_19826(System.Collections.Generic.List<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 19803, 19826);
            return 0;
        }


        System.Collections.Generic.List<System.Management.Automation.FormatViewDefinition>
        f_1118_19931_19963()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.FormatViewDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 19931, 19963);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1118_19990_20008()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 19990, 20008);
            return return_v;
        }

    }
    [DebuggerDisplay("{Name}")]
    public sealed class FormatViewDefinition
    {
        public string Name { get; private set; }

        public PSControl Control { get; private set; }

        internal Guid InstanceId { get; set; }

        internal FormatViewDefinition(string name, PSControl control, Guid instanceid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 20740, 20936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 20316, 20356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 20487, 20533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 20843, 20855);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 20869, 20887);

                Control = control;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 20901, 20925);

                InstanceId = instanceid;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 20740, 20936);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 20740, 20936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 20740, 20936);
            }
        }

        public FormatViewDefinition(string name, PSControl control)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 20972, 21337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 20316, 20356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 20487, 20533);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 21056, 21158) || true) && (f_1118_21060_21086(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 21056, 21158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 21105, 21158);

                    throw f_1118_21111_21157("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 21056, 21158);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 21172, 21266) || true) && (control == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 21172, 21266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 21210, 21266);

                    throw f_1118_21216_21265("control");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 21172, 21266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 21282, 21294);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 21308, 21326);

                Control = control;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 20972, 21337);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 20972, 21337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 20972, 21337);
            }
        }

        static FormatViewDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 20132, 21344);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 20132, 21344);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 20132, 21344);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 20132, 21344);

        bool
        f_1118_21060_21086(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 21060, 21086);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1118_21111_21157(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 21111, 21157);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1118_21216_21265(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 21216, 21265);
            return return_v;
        }

    }
    public abstract class PSControl
    {
        public PSControlGroupBy GroupBy { get; set; }

        public bool OutOfBand { get; set; }

        internal abstract void WriteToXml(FormatXmlWriter writer);

        internal virtual bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 22384, 22509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 22446, 22498);

                return f_1118_22453_22460() == null || (DynAbs.Tracing.TraceSender.Expression_False(1118, 22453, 22497) || f_1118_22472_22497(f_1118_22472_22479()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 22384, 22509);

                System.Management.Automation.PSControlGroupBy
                f_1118_22453_22460()
                {
                    var return_v = GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 22453, 22460);
                    return return_v;
                }


                System.Management.Automation.PSControlGroupBy
                f_1118_22472_22479()
                {
                    var return_v = GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 22472, 22479);
                    return return_v;
                }


                bool
                f_1118_22472_22497(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.IsSafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 22472, 22497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 22384, 22509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 22384, 22509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool CompatibleWithOldPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 22521, 22859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 22825, 22848);

                return f_1118_22832_22839() == null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 22521, 22859);

                System.Management.Automation.PSControlGroupBy
                f_1118_22832_22839()
                {
                    var return_v = GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 22832, 22839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 22521, 22859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 22521, 22859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSControl()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 21466, 22866);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 21730, 21775);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 22267, 22302);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 21466, 22866);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 21466, 22866);
        }


        static PSControl()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 21466, 22866);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 21466, 22866);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 21466, 22866);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 21466, 22866);
    }
    public sealed class PSControlGroupBy
    {
        public DisplayEntry Expression { get; set; }

        public string Label { get; set; }

        public CustomControl CustomControl { get; set; }

        internal bool IsSafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 23629, 23834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 23685, 23823);

                return (f_1118_23693_23703() == null || (DynAbs.Tracing.TraceSender.Expression_False(1118, 23693, 23741) || f_1118_23715_23741(f_1118_23715_23725()))) && (DynAbs.Tracing.TraceSender.Expression_True(1118, 23692, 23822) && (f_1118_23767_23780() == null || (DynAbs.Tracing.TraceSender.Expression_False(1118, 23767, 23821) || f_1118_23792_23821(f_1118_23792_23805()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 23629, 23834);

                System.Management.Automation.DisplayEntry
                f_1118_23693_23703()
                {
                    var return_v = Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 23693, 23703);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1118_23715_23725()
                {
                    var return_v = Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 23715, 23725);
                    return return_v;
                }


                bool
                f_1118_23715_23741(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 23715, 23741);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1118_23767_23780()
                {
                    var return_v = CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 23767, 23780);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1118_23792_23805()
                {
                    var return_v = CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 23792, 23805);
                    return return_v;
                }


                bool
                f_1118_23792_23821(System.Management.Automation.CustomControl
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 23792, 23821);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 23629, 23834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 23629, 23834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSControlGroupBy Get(GroupBy groupBy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1118, 23846, 24411);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 23924, 24372) || true) && (groupBy != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 23924, 24372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 24031, 24083);

                    var
                    expressionToken = groupBy.startGroup.expression
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 24101, 24357);

                    return new PSControlGroupBy
                    {
                        Expression = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1118_24182_24215(expressionToken), 1118, 24108, 24356),
                        Label = (DynAbs.Tracing.TraceSender.Conditional_F1(1118, 24246, 24289) || (((groupBy.startGroup.labelTextToken != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1118, 24292, 24330)) || DynAbs.Tracing.TraceSender.Conditional_F3(1118, 24333, 24337))) ? groupBy.startGroup.labelTextToken.text : null
                    };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 23924, 24372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 24388, 24400);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1118, 23846, 24411);

                System.Management.Automation.DisplayEntry
                f_1118_24182_24215(Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                expression)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 24182, 24215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 23846, 24411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 23846, 24411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSControlGroupBy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 23048, 24418);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 23237, 23281);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 23415, 23448);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 23569, 23617);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 23048, 24418);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 23048, 24418);
        }


        static PSControlGroupBy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 23048, 24418);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 23048, 24418);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 23048, 24418);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 23048, 24418);
    }
    public sealed class DisplayEntry
    {
        public DisplayEntryValueType ValueType { get; internal set; }

        public string Value { get; internal set; }

        internal DisplayEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 24842, 24869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 24653, 24714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 24788, 24830);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 24842, 24869);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 24842, 24869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 24842, 24869);
            }
        }

        public DisplayEntry(string value, DisplayEntryValueType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 24949, 25293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 24653, 24714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 24788, 24830);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25035, 25221) || true) && (f_1118_25039_25066(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 25035, 25221);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25085, 25221) || true) && (value == null || (DynAbs.Tracing.TraceSender.Expression_False(1118, 25089, 25144) || type == DisplayEntryValueType.Property))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 25085, 25221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25167, 25221);

                        throw f_1118_25173_25220("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 25085, 25221);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 25035, 25221);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25237, 25251);

                Value = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25265, 25282);

                ValueType = type;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 24949, 25293);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 24949, 25293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 24949, 25293);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 25329, 25487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25387, 25476);

                return ((DynAbs.Tracing.TraceSender.Conditional_F1(1118, 25395, 25438) || ((f_1118_25395_25404() == DisplayEntryValueType.Property && DynAbs.Tracing.TraceSender.Conditional_F2(1118, 25441, 25453)) || DynAbs.Tracing.TraceSender.Conditional_F3(1118, 25456, 25466))) ? "property: " : "script: ") + f_1118_25470_25475();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 25329, 25487);

                System.Management.Automation.DisplayEntryValueType
                f_1118_25395_25404()
                {
                    var return_v = ValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 25395, 25404);
                    return return_v;
                }


                string
                f_1118_25470_25475()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 25470, 25475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 25329, 25487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 25329, 25487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal DisplayEntry(ExpressionToken expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 25499, 25946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 24653, 24714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 24788, 24830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25573, 25608);

                Value = expression.expressionValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25622, 25728);

                ValueType = (DynAbs.Tracing.TraceSender.Conditional_F1(1118, 25634, 25658) || ((expression.isScriptBlock && DynAbs.Tracing.TraceSender.Conditional_F2(1118, 25661, 25694)) || DynAbs.Tracing.TraceSender.Conditional_F3(1118, 25697, 25727))) ? DisplayEntryValueType.ScriptBlock : DisplayEntryValueType.Property;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25744, 25935) || true) && (f_1118_25748_25775(f_1118_25769_25774()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 25744, 25935);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25794, 25935) || true) && (f_1118_25798_25803() == null || (DynAbs.Tracing.TraceSender.Expression_False(1118, 25798, 25858) || f_1118_25815_25824() == DisplayEntryValueType.Property))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 25794, 25935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 25881, 25935);

                        throw f_1118_25887_25934("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 25794, 25935);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 25744, 25935);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 25499, 25946);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 25499, 25946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 25499, 25946);
            }
        }

        internal bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 25958, 26077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 26012, 26066);

                return f_1118_26019_26028() != DisplayEntryValueType.ScriptBlock;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 25958, 26077);

                System.Management.Automation.DisplayEntryValueType
                f_1118_26019_26028()
                {
                    var return_v = ValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 26019, 26028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 25958, 26077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 25958, 26077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DisplayEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 24541, 26084);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 24541, 26084);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 24541, 26084);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 24541, 26084);

        bool
        f_1118_25039_25066(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 25039, 25066);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1118_25173_25220(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 25173, 25220);
            return return_v;
        }


        string
        f_1118_25769_25774()
        {
            var return_v = Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 25769, 25774);
            return return_v;
        }


        bool
        f_1118_25748_25775(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 25748, 25775);
            return return_v;
        }


        string
        f_1118_25798_25803()
        {
            var return_v = Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 25798, 25803);
            return return_v;
        }


        System.Management.Automation.DisplayEntryValueType
        f_1118_25815_25824()
        {
            var return_v = ValueType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 25815, 25824);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1118_25887_25934(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 25887, 25934);
            return return_v;
        }

    }
    public sealed class EntrySelectedBy
    {
        public List<string> TypeNames { get; set; }

        public List<DisplayEntry> SelectionCondition { get; set; }

        internal static EntrySelectedBy Get(IEnumerable<string> entrySelectedByType, IEnumerable<DisplayEntry> entrySelectedByCondition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1118, 27115, 28164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27268, 27298);

                EntrySelectedBy
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27312, 28123) || true) && (entrySelectedByType != null || (DynAbs.Tracing.TraceSender.Expression_False(1118, 27316, 27379) || entrySelectedByCondition != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 27312, 28123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27413, 27444);

                    result = f_1118_27422_27443();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27462, 27482);

                    bool
                    isEmpty = true
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27500, 27744) || true) && (entrySelectedByType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 27500, 27744);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27573, 27630);

                        result.TypeNames = f_1118_27592_27629(entrySelectedByType);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27652, 27725) || true) && (f_1118_27656_27678(f_1118_27656_27672(result)) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 27652, 27725);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27709, 27725);

                            isEmpty = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 27652, 27725);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 27500, 27744);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27764, 28042) || true) && (entrySelectedByCondition != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 27764, 28042);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27842, 27919);

                        result.SelectionCondition = f_1118_27870_27918(entrySelectedByCondition);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27941, 28023) || true) && (f_1118_27945_27976(f_1118_27945_27970(result)) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 27941, 28023);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28007, 28023);

                            isEmpty = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 27941, 28023);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 27764, 28042);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28062, 28108) || true) && (isEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 28062, 28108);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28096, 28108);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 28062, 28108);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 27312, 28123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28139, 28153);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1118, 27115, 28164);

                System.Management.Automation.EntrySelectedBy
                f_1118_27422_27443()
                {
                    var return_v = new System.Management.Automation.EntrySelectedBy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 27422, 27443);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1118_27592_27629(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 27592, 27629);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1118_27656_27672(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 27656, 27672);
                    return return_v;
                }


                int
                f_1118_27656_27678(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 27656, 27678);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1118_27870_27918(System.Collections.Generic.IEnumerable<System.Management.Automation.DisplayEntry>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.DisplayEntry>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 27870, 27918);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1118_27945_27970(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 27945, 27970);
                    return return_v;
                }


                int
                f_1118_27945_27976(System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 27945, 27976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 27115, 28164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 27115, 28164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static EntrySelectedBy Get(List<TypeOrGroupReference> references)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1118, 28176, 29169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28275, 28305);

                EntrySelectedBy
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28319, 29128) || true) && (references != null && (DynAbs.Tracing.TraceSender.Expression_True(1118, 28323, 28365) && f_1118_28345_28361(references) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 28319, 29128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28399, 28430);

                    result = f_1118_28408_28429();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28448, 29113);
                        foreach (TypeOrGroupReference tr in f_1118_28484_28494_I(references))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 28448, 29113);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28536, 28860) || true) && (tr.conditionToken != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 28536, 28860);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28615, 28707) || true) && (f_1118_28619_28644(result) == null)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 28615, 28707);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28654, 28707);

                                    result.SelectionCondition = f_1118_28682_28706();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 28615, 28707);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28735, 28802);

                                f_1118_28735_28801(f_1118_28735_28760(result), f_1118_28765_28800(tr.conditionToken));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28828, 28837);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 28536, 28860);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28884, 28948) || true) && (tr is TypeGroupReference)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 28884, 28948);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28939, 28948);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 28884, 28948);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 28972, 29040) || true) && (f_1118_28976_28992(result) == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 28972, 29040);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 29002, 29040);

                                result.TypeNames = f_1118_29021_29039();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 28972, 29040);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 29064, 29094);

                            f_1118_29064_29093(f_1118_29064_29080(result), tr.name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 28448, 29113);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1118, 1, 666);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1118, 1, 666);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 28319, 29128);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 29144, 29158);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1118, 28176, 29169);

                int
                f_1118_28345_28361(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 28345, 28361);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1118_28408_28429()
                {
                    var return_v = new System.Management.Automation.EntrySelectedBy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 28408, 28429);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1118_28619_28644(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 28619, 28644);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1118_28682_28706()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.DisplayEntry>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 28682, 28706);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1118_28735_28760(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 28735, 28760);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1118_28765_28800(Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                expression)
                {
                    var return_v = new System.Management.Automation.DisplayEntry(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 28765, 28800);
                    return return_v;
                }


                int
                f_1118_28735_28801(System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                this_param, System.Management.Automation.DisplayEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 28735, 28801);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1118_28976_28992(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 28976, 28992);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1118_29021_29039()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 29021, 29039);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1118_29064_29080(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 29064, 29080);
                    return return_v;
                }


                int
                f_1118_29064_29093(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 29064, 29093);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                f_1118_28484_28494_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 28484, 28494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 28176, 29169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 28176, 29169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool SafeForExport()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 29181, 29500);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 29235, 29296) || true) && (f_1118_29239_29257() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 29235, 29296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 29284, 29296);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 29235, 29296);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 29312, 29461);
                    foreach (var cond in f_1118_29333_29351_I(f_1118_29333_29351()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 29312, 29461);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 29385, 29446) || true) && (!f_1118_29390_29410(cond))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1118, 29385, 29446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 29433, 29446);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 29385, 29446);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1118, 29312, 29461);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1118, 1, 150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1118, 1, 150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 29477, 29489);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 29181, 29500);

                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1118_29239_29257()
                {
                    var return_v = SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 29239, 29257);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1118_29333_29351()
                {
                    var return_v = SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 29333, 29351);
                    return return_v;
                }


                bool
                f_1118_29390_29410(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.SafeForExport();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 29390, 29410);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1118_29333_29351_I(System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1118, 29333, 29351);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 29181, 29500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 29181, 29500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CompatibleWithOldPowerShell()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1118, 29512, 29742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 29664, 29731);

                return f_1118_29671_29689() == null || (DynAbs.Tracing.TraceSender.Expression_False(1118, 29671, 29730) || f_1118_29701_29725(f_1118_29701_29719()) == 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1118, 29512, 29742);

                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1118_29671_29689()
                {
                    var return_v = SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 29671, 29689);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1118_29701_29719()
                {
                    var return_v = SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 29701, 29719);
                    return return_v;
                }


                int
                f_1118_29701_29725(System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1118, 29701, 29725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1118, 29512, 29742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 29512, 29742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EntrySelectedBy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1118, 26714, 29749);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 26881, 26924);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1118, 27045, 27103);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1118, 26714, 29749);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 26714, 29749);
        }


        static EntrySelectedBy()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1118, 26714, 29749);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1118, 26714, 29749);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1118, 26714, 29749);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1118, 26714, 29749);
    }

    /// <summary>
    /// Specifies possible alignment enumerations for display cells.
    /// </summary>
    public enum Alignment
    {
        /// <summary>
        /// Not defined.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Left of the cell, contents will trail with a ... if exceeded - ex "Display..."
        /// </summary>
        Left = 1,

        /// <summary>
        /// Center of the cell.
        /// </summary>
        Center = 2,

        /// <summary>
        /// Right of the cell, contents will lead with a ... if exceeded - ex "...456"
        /// </summary>
        Right = 3,
    }

    /// <summary>
    /// Specifies the type of entry value.
    /// </summary>
    public enum DisplayEntryValueType
    {
        /// <summary>
        /// The value is a property. Look for a property with the specified name.
        /// </summary>
        Property = 0,

        /// <summary>
        /// The value is a scriptblock. Evaluate the script block and fill the entry with the result.
        /// </summary>
        ScriptBlock = 1,
    }
}
