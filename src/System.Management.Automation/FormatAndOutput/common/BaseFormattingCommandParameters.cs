// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class FormattingCommandLineParameters
    {
        internal List<MshParameter> mshParameterList;

        internal MshParameter groupByParameter;

        internal string viewName;

        internal bool forceFormattingAlsoOnOutOfBand;

        internal bool? autosize;

        internal bool repeatHeader;

        internal bool? showErrorsAsMessages;

        internal bool? showErrorsInFormattedOutput;

        internal EnumerableExpansion? expansion;

        internal ShapeSpecificParameters shapeParameters;

        public FormattingCommandLineParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 582, 2469);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 850, 893);
            this.mshParameterList = f_1082_869_893();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 1035, 1058);
            this.groupByParameter = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 1198, 1213);
            this.viewName = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 1351, 1389);
            this.forceFormattingAlsoOnOutOfBand = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 1603, 1618);
            this.autosize = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 1797, 1817);
            this.repeatHeader = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 1947, 1974);
            this.showErrorsAsMessages = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 2104, 2138);
            this.showErrorsInFormattedOutput = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 2266, 2282);
            this.expansion = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 2439, 2461);
            this.shapeParameters = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 582, 2469);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 582, 2469);
        }


        static FormattingCommandLineParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 582, 2469);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 582, 2469);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 582, 2469);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 582, 2469);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
        f_1082_869_893()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 869, 893);
            return return_v;
        }

    }
    internal abstract class ShapeSpecificParameters
    {
        public ShapeSpecificParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 2575, 2636);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 2575, 2636);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 2575, 2636);
        }


        static ShapeSpecificParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 2575, 2636);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 2575, 2636);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 2575, 2636);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 2575, 2636);
    }
    internal sealed class TableSpecificParameters : ShapeSpecificParameters
    {
        internal bool? hideHeaders;

        internal bool? multiLine;

        public TableSpecificParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 2644, 2815);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 2747, 2765);
            this.hideHeaders = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 2791, 2807);
            this.multiLine = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 2644, 2815);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 2644, 2815);
        }


        static TableSpecificParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 2644, 2815);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 2644, 2815);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 2644, 2815);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 2644, 2815);
    }
    internal sealed class WideSpecificParameters : ShapeSpecificParameters
    {
        internal int? columns;

        public WideSpecificParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 2823, 2946);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 2924, 2938);
            this.columns = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 2823, 2946);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 2823, 2946);
        }


        static WideSpecificParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 2823, 2946);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 2823, 2946);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 2823, 2946);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 2823, 2946);
    }
    internal sealed class ComplexSpecificParameters : ShapeSpecificParameters
    {        /// <summary>
             /// Options for class info display on objects.
             /// </summary>
        internal enum ClassInfoDisplay { none, fullName, shortName }

        internal ClassInfoDisplay classDisplay;

        internal const int
        maxDepthAllowable = 5
        ;

        internal int maxDepth;

        public ComplexSpecificParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 2954, 3500);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 3245, 3286);
            this.classDisplay = ClassInfoDisplay.shortName;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 3464, 3492);
            this.maxDepth = maxDepthAllowable;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 2954, 3500);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 2954, 3500);
        }


        static ComplexSpecificParameters()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 2954, 3500);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 3318, 3339);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 2954, 3500);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 2954, 3500);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 2954, 3500);
    }
    internal class ExpressionEntryDefinition : HashtableEntryDefinition
    {
        internal ExpressionEntryDefinition() : this(f_1082_3788_3793_C(false))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 3744, 3816);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 3744, 3816);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 3744, 3816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 3744, 3816);
            }
        }

        internal ExpressionEntryDefinition(bool noGlobbing) : base(f_1082_3887_3935_C(FormatParameterDefinitionKeys.ExpressionEntryKey), new Type[] { typeof(string), typeof(ScriptBlock) }, true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 3828, 4092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 8432, 8443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 4056, 4081);

                _noGlobbing = noGlobbing;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 3828, 4092);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 3828, 4092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 3828, 4092);
            }
        }

        internal override Hashtable CreateHashtableFromSingleType(object val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 4104, 4348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 4198, 4231);

                Hashtable
                hash = f_1082_4215_4230()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 4247, 4311);

                f_1082_4247_4310(
                            hash, FormatParameterDefinitionKeys.ExpressionEntryKey, val);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 4325, 4337);

                return hash;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 4104, 4348);

                System.Collections.Hashtable
                f_1082_4215_4230()
                {
                    var return_v = new System.Collections.Hashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 4215, 4230);
                    return return_v;
                }


                int
                f_1082_4247_4310(System.Collections.Hashtable
                this_param, string
                key, object
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 4247, 4310);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 4104, 4348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 4104, 4348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override object Verify(object val,
                                                TerminatingErrorContext invocationContext,
                                                bool originalParameterWasHashTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 5364, 6725);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 5593, 5709) || true) && (val == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 5593, 5709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 5642, 5694);

                    throw f_1082_5648_5693("val");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 5593, 5709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 5818, 5854);

                ScriptBlock
                sb = val as ScriptBlock
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 5868, 6014) || true) && (sb != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 5868, 6014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 5916, 5971);

                    PSPropertyExpression
                    ex = f_1082_5942_5970(sb)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 5989, 5999);

                    return ex;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 5868, 6014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6030, 6055);

                string
                s = val as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6069, 6630) || true) && (s != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 6069, 6630);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6116, 6278) || true) && (f_1082_6120_6143(s))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 6116, 6278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6185, 6259);

                        f_1082_6185_6258(this, originalParameterWasHashTable, invocationContext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 6116, 6278);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6298, 6352);

                    PSPropertyExpression
                    ex = f_1082_6324_6351(s)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6370, 6585) || true) && (_noGlobbing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 6370, 6585);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6427, 6566) || true) && (f_1082_6431_6455(ex))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 6427, 6566);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6482, 6566);

                            f_1082_6482_6565(this, originalParameterWasHashTable, s, invocationContext);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 6427, 6566);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 6370, 6585);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6605, 6615);

                    return ex;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 6069, 6630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6646, 6688);

                f_1082_6646_6687("val");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6702, 6714);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 5364, 6725);

                System.Management.Automation.PSArgumentNullException
                f_1082_5648_5693(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 5648, 5693);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1082_5942_5970(System.Management.Automation.ScriptBlock
                scriptBlock)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 5942, 5970);
                    return return_v;
                }


                bool
                f_1082_6120_6143(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 6120, 6143);
                    return return_v;
                }


                int
                f_1082_6185_6258(Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition
                this_param, bool
                originalParameterWasHashTable, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext)
                {
                    this_param.ProcessEmptyStringError(originalParameterWasHashTable, invocationContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 6185, 6258);
                    return 0;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1082_6324_6351(string
                s)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 6324, 6351);
                    return return_v;
                }


                bool
                f_1082_6431_6455(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.HasWildCardCharacters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 6431, 6455);
                    return return_v;
                }


                int
                f_1082_6482_6565(Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition
                this_param, bool
                originalParameterWasHashTable, string
                expression, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext)
                {
                    this_param.ProcessGlobbingCharactersError(originalParameterWasHashTable, expression, invocationContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 6482, 6565);
                    return 0;
                }


                System.Management.Automation.PSArgumentException
                f_1082_6646_6687(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 6646, 6687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 5364, 6725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 5364, 6725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ProcessEmptyStringError(bool originalParameterWasHashTable,
                                                        TerminatingErrorContext invocationContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 6773, 7565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6962, 6973);

                string
                msg
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 6987, 7002);

                string
                errorID
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 7016, 7455) || true) && (originalParameterWasHashTable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 7016, 7455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 7083, 7195);

                    msg = f_1082_7089_7194(f_1082_7107_7158(), f_1082_7181_7193(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 7213, 7248);

                    errorID = "ExpressionEmptyString1";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 7016, 7455);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 7016, 7455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 7314, 7387);

                    msg = f_1082_7320_7386(f_1082_7338_7385());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 7405, 7440);

                    errorID = "ExpressionEmptyString2";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 7016, 7455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 7471, 7554);

                f_1082_7471_7553(invocationContext, errorID, msg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 6773, 7565);

                string
                f_1082_7107_7158()
                {
                    var return_v = FormatAndOut_MshParameter.MshExEmptyStringHashError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 7107, 7158);
                    return return_v;
                }


                string
                f_1082_7181_7193(Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 7181, 7193);
                    return return_v;
                }


                string
                f_1082_7089_7194(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 7089, 7194);
                    return return_v;
                }


                string
                f_1082_7338_7385()
                {
                    var return_v = FormatAndOut_MshParameter.MshExEmptyStringError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 7338, 7385);
                    return return_v;
                }


                string
                f_1082_7320_7386(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 7320, 7386);
                    return return_v;
                }


                int
                f_1082_7471_7553(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 7471, 7553);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 6773, 7565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 6773, 7565);
            }
        }

        private void ProcessGlobbingCharactersError(bool originalParameterWasHashTable, string expression, TerminatingErrorContext invocationContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 7577, 8385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 7743, 7754);

                string
                msg
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 7768, 7783);

                string
                errorID
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 7797, 8275) || true) && (originalParameterWasHashTable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 7797, 8275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 7864, 7985);

                    msg = f_1082_7870_7984(f_1082_7888_7936(), f_1082_7959_7971(this), expression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 8003, 8035);

                    errorID = "ExpressionGlobbing1";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 7797, 8275);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 7797, 8275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 8101, 8210);

                    msg = f_1082_8107_8209(f_1082_8125_8175(), expression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 8228, 8260);

                    errorID = "ExpressionGlobbing2";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 7797, 8275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 8291, 8374);

                f_1082_8291_8373(invocationContext, errorID, msg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 7577, 8385);

                string
                f_1082_7888_7936()
                {
                    var return_v = FormatAndOut_MshParameter.MshExGlobbingHashError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 7888, 7936);
                    return return_v;
                }


                string
                f_1082_7959_7971(Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 7959, 7971);
                    return return_v;
                }


                string
                f_1082_7870_7984(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 7870, 7984);
                    return return_v;
                }


                string
                f_1082_8125_8175()
                {
                    var return_v = FormatAndOut_MshParameter.MshExGlobbingStringError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 8125, 8175);
                    return return_v;
                }


                string
                f_1082_8107_8209(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 8107, 8209);
                    return return_v;
                }


                int
                f_1082_8291_8373(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 8291, 8373);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 7577, 8385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 7577, 8385);
            }
        }

        private bool _noGlobbing;

        static ExpressionEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 3660, 8451);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 3660, 8451);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 3660, 8451);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 3660, 8451);

        static bool
        f_1082_3788_3793_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1082, 3744, 3816);
            return return_v;
        }


        static string
        f_1082_3887_3935_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1082, 3828, 4092);
            return return_v;
        }

    }
    internal class AlignmentEntryDefinition : HashtableEntryDefinition
    {
        internal AlignmentEntryDefinition() : base(f_1082_8585_8632_C(FormatParameterDefinitionKeys.AlignmentEntryKey), new Type[] { typeof(string) })
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 8542, 8723);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 8542, 8723);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 8542, 8723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 8542, 8723);
            }
        }

        internal override object Verify(object val,
                                                TerminatingErrorContext invocationContext,
                                                bool originalParameterWasHashTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 8735, 10014);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 8964, 9143) || true) && (!originalParameterWasHashTable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 8964, 9143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9077, 9128);

                    throw f_1082_9083_9127();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 8964, 9143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9279, 9304);

                string
                s = val as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9320, 9863) || true) && (!f_1082_9325_9348(s))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 9320, 9863);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9391, 9396);
                        for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9382, 9848) || true) && (k < f_1082_9402_9422(s_legalValues))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9424, 9427)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 9382, 9848))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 9382, 9848);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9469, 9829) || true) && (f_1082_9473_9537(s, s_legalValues[k]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 9469, 9829);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9587, 9654) || true) && (k == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 9587, 9654);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9628, 9654);

                                    return TextAlignment.Left;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 9587, 9654);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9682, 9751) || true) && (k == 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 9682, 9751);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9723, 9751);

                                    return TextAlignment.Center;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 9682, 9751);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9779, 9806);

                                return TextAlignment.Right;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 9469, 9829);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1082, 1, 467);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1082, 1, 467);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 9320, 9863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9935, 9977);

                f_1082_9935_9976(this, s, invocationContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 9991, 10003);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 8735, 10014);

                System.Management.Automation.PSInvalidOperationException
                f_1082_9083_9127()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 9083, 9127);
                    return return_v;
                }


                bool
                f_1082_9325_9348(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 9325, 9348);
                    return return_v;
                }


                int
                f_1082_9402_9422(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 9402, 9422);
                    return return_v;
                }


                bool
                f_1082_9473_9537(string
                key, string
                normalizedKey)
                {
                    var return_v = CommandParameterDefinition.FindPartialMatch(key, normalizedKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 9473, 9537);
                    return return_v;
                }


                int
                f_1082_9935_9976(Microsoft.PowerShell.Commands.Internal.Format.AlignmentEntryDefinition
                this_param, string
                s, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext)
                {
                    this_param.ProcessIllegalValue(s, invocationContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 9935, 9976);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 8735, 10014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 8735, 10014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ProcessIllegalValue(string s, TerminatingErrorContext invocationContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 10062, 10522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 10172, 10398);

                string
                msg = f_1082_10185_10397(f_1082_10203_10255(), s, f_1082_10294_10306(this), f_1082_10325_10378(s_legalValues))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 10412, 10511);

                f_1082_10412_10510(invocationContext, "AlignmentIllegalValue", msg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 10062, 10522);

                string
                f_1082_10203_10255()
                {
                    var return_v = FormatAndOut_MshParameter.IllegalAlignmentValueError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 10203, 10255);
                    return return_v;
                }


                string
                f_1082_10294_10306(Microsoft.PowerShell.Commands.Internal.Format.AlignmentEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 10294, 10306);
                    return return_v;
                }


                string
                f_1082_10325_10378(string[]
                arr)
                {
                    var return_v = ParameterProcessor.CatenateStringArray(arr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 10325, 10378);
                    return return_v;
                }


                string
                f_1082_10185_10397(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 10185, 10397);
                    return return_v;
                }


                int
                f_1082_10412_10510(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 10412, 10510);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 10062, 10522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 10062, 10522);
            }
        }

        private static readonly string[] s_legalValues;

        private const string
        LeftAlign = "left"
        ;

        private const string
        CenterAlign = "center"
        ;

        private const string
        RightAlign = "right"
        ;

        static AlignmentEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 8459, 10822);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 10589, 10656);
            s_legalValues = new string[] { LeftAlign, CenterAlign, RightAlign };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 10690, 10708);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 10740, 10762);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 10794, 10814);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 8459, 10822);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 8459, 10822);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 8459, 10822);

        static string
        f_1082_8585_8632_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1082, 8542, 8723);
            return return_v;
        }

    }
    internal class WidthEntryDefinition : HashtableEntryDefinition
    {
        internal WidthEntryDefinition() : base(f_1082_10948_10991_C(FormatParameterDefinitionKeys.WidthEntryKey), new Type[] { typeof(int) })
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 10909, 11079);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 10909, 11079);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 10909, 11079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 10909, 11079);
            }
        }

        internal override object Verify(object val,
                                                TerminatingErrorContext invocationContext,
                                                bool originalParameterWasHashTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 11091, 11661);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 11320, 11499) || true) && (!originalParameterWasHashTable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 11320, 11499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 11433, 11484);

                    throw f_1082_11439_11483();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 11320, 11499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 11583, 11624);

                f_1082_11583_11623(this, val, invocationContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 11638, 11650);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 11091, 11661);

                System.Management.Automation.PSInvalidOperationException
                f_1082_11439_11483()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 11439, 11483);
                    return return_v;
                }


                int
                f_1082_11583_11623(Microsoft.PowerShell.Commands.Internal.Format.WidthEntryDefinition
                this_param, object
                width, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext)
                {
                    this_param.VerifyRange((int)width, invocationContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 11583, 11623);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 11091, 11661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 11091, 11661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VerifyRange(int width, TerminatingErrorContext invocationContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 11673, 12130);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 11776, 12119) || true) && (width <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 11776, 12119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 11824, 11993);

                    string
                    msg = f_1082_11837_11992(f_1082_11855_11906(), width, f_1082_11957_11969(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 12011, 12104);

                    f_1082_12011_12103(invocationContext, "WidthOutOfRange", msg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 11776, 12119);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 11673, 12130);

                string
                f_1082_11855_11906()
                {
                    var return_v = FormatAndOut_MshParameter.OutOfRangeWidthValueError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 11855, 11906);
                    return return_v;
                }


                string
                f_1082_11957_11969(Microsoft.PowerShell.Commands.Internal.Format.WidthEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 11957, 11969);
                    return return_v;
                }


                string
                f_1082_11837_11992(string
                formatSpec, int
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 11837, 11992);
                    return return_v;
                }


                int
                f_1082_12011_12103(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 12011, 12103);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 11673, 12130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 11673, 12130);
            }
        }

        static WidthEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 10830, 12137);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 10830, 12137);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 10830, 12137);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 10830, 12137);

        static string
        f_1082_10948_10991_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1082, 10909, 11079);
            return return_v;
        }

    }
    internal class LabelEntryDefinition : HashtableEntryDefinition
    {
        internal LabelEntryDefinition() : base(f_1082_12263_12306_C(FormatParameterDefinitionKeys.LabelEntryKey), new string[] { NameEntryDefinition.NameEntryKey }, new Type[] { typeof(string) }, false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 12224, 12418);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 12224, 12418);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 12224, 12418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 12224, 12418);
            }
        }

        static LabelEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 12145, 12425);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 12145, 12425);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 12145, 12425);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 12145, 12425);

        static string
        f_1082_12263_12306_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1082, 12224, 12418);
            return return_v;
        }

    }
    internal class FormatStringDefinition : HashtableEntryDefinition
    {
        internal FormatStringDefinition() : base(f_1082_12555_12605_C(FormatParameterDefinitionKeys.FormatStringEntryKey), new Type[] { typeof(string) })
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 12514, 12696);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 12514, 12696);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 12514, 12696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 12514, 12696);
            }
        }

        internal override object Verify(object val,
                                                TerminatingErrorContext invocationContext,
                                                bool originalParameterWasHashTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 12708, 13749);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 12937, 13116) || true) && (!originalParameterWasHashTable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 12937, 13116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 13050, 13101);

                    throw f_1082_13056_13100();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 12937, 13116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 13132, 13157);

                string
                s = val as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 13171, 13505) || true) && (f_1082_13175_13198(s))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 13171, 13505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 13232, 13375);

                    string
                    msg = f_1082_13245_13374(f_1082_13263_13316(), f_1082_13339_13351(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 13395, 13490);

                    f_1082_13395_13489(invocationContext, "FormatStringEmpty", msg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 13171, 13505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 13598, 13666);

                FieldFormattingDirective
                directive = f_1082_13635_13665()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 13680, 13707);

                directive.formatString = s;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 13721, 13738);

                return directive;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 12708, 13749);

                System.Management.Automation.PSInvalidOperationException
                f_1082_13056_13100()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 13056, 13100);
                    return return_v;
                }


                bool
                f_1082_13175_13198(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 13175, 13198);
                    return return_v;
                }


                string
                f_1082_13263_13316()
                {
                    var return_v = FormatAndOut_MshParameter.EmptyFormatStringValueError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 13263, 13316);
                    return return_v;
                }


                string
                f_1082_13339_13351(Microsoft.PowerShell.Commands.Internal.Format.FormatStringDefinition
                this_param)
                {
                    var return_v = this_param.KeyName
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1082, 13339, 13351);
                    return return_v;
                }


                string
                f_1082_13245_13374(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 13245, 13374);
                    return return_v;
                }


                int
                f_1082_13395_13489(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 13395, 13489);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                f_1082_13635_13665()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 13635, 13665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 12708, 13749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 12708, 13749);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FormatStringDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 12433, 13756);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 12433, 13756);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 12433, 13756);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 12433, 13756);

        static string
        f_1082_12555_12605_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1082, 12514, 12696);
            return return_v;
        }

    }
    internal class BooleanEntryDefinition : HashtableEntryDefinition
    {
        internal BooleanEntryDefinition(string entryKey) : base(f_1082_13901_13909_C(entryKey), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 13845, 13938);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 13845, 13938);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 13845, 13938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 13845, 13938);
            }
        }

        internal override object Verify(object val,
                                                TerminatingErrorContext invocationContext,
                                                bool originalParameterWasHashTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 13950, 14423);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 14179, 14358) || true) && (!originalParameterWasHashTable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1082, 14179, 14358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 14292, 14343);

                    throw f_1082_14298_14342();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1082, 14179, 14358);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 14374, 14412);

                return f_1082_14381_14411(val);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 13950, 14423);

                System.Management.Automation.PSInvalidOperationException
                f_1082_14298_14342()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 14298, 14342);
                    return return_v;
                }


                bool
                f_1082_14381_14411(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 14381, 14411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 13950, 14423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 13950, 14423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BooleanEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 13764, 14430);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 13764, 14430);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 13764, 14430);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 13764, 14430);

        static string
        f_1082_13901_13909_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1082, 13845, 13938);
            return return_v;
        }

    }
    internal static class FormatParameterDefinitionKeys
    {
        internal const string
        ExpressionEntryKey = "expression"
        ;

        internal const string
        FormatStringEntryKey = "formatString"
        ;

        internal const string
        AlignmentEntryKey = "alignment"
        ;

        internal const string
        WidthEntryKey = "width"
        ;

        internal const string
        LabelEntryKey = "label"
        ;

        internal const string
        DepthEntryKey = "depth"
        ;

        static FormatParameterDefinitionKeys()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 14519, 15207);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 14636, 14669);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 14702, 14739);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 14811, 14842);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 14875, 14898);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 14984, 15007);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 15176, 15199);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 14519, 15207);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 14519, 15207);
        }

    }
    internal class FormatGroupByParameterDefinition : CommandParameterDefinition
    {
        protected override void SetEntries()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 15308, 15562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 15369, 15423);

                f_1082_15369_15422(this.hashEntries, f_1082_15390_15421());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 15437, 15488);

                f_1082_15437_15487(this.hashEntries, f_1082_15458_15486());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 15502, 15551);

                f_1082_15502_15550(this.hashEntries, f_1082_15523_15549());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 15308, 15562);

                Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition
                f_1082_15390_15421()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 15390, 15421);
                    return return_v;
                }


                int
                f_1082_15369_15422(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 15369, 15422);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatStringDefinition
                f_1082_15458_15486()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatStringDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 15458, 15486);
                    return return_v;
                }


                int
                f_1082_15437_15487(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatStringDefinition
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 15437, 15487);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.LabelEntryDefinition
                f_1082_15523_15549()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.LabelEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 15523, 15549);
                    return return_v;
                }


                int
                f_1082_15502_15550(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.LabelEntryDefinition
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 15502, 15550);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 15308, 15562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 15308, 15562);
            }
        }

        public FormatGroupByParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 15215, 15569);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 15215, 15569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 15215, 15569);
        }


        static FormatGroupByParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 15215, 15569);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 15215, 15569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 15215, 15569);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 15215, 15569);
    }
    internal class FormatParameterDefinitionBase : CommandParameterDefinition
    {
        protected override void SetEntries()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 15667, 15858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 15728, 15782);

                f_1082_15728_15781(this.hashEntries, f_1082_15749_15780());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 15796, 15847);

                f_1082_15796_15846(this.hashEntries, f_1082_15817_15845());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 15667, 15858);

                Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition
                f_1082_15749_15780()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 15749, 15780);
                    return return_v;
                }


                int
                f_1082_15728_15781(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 15728, 15781);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatStringDefinition
                f_1082_15817_15845()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatStringDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 15817, 15845);
                    return return_v;
                }


                int
                f_1082_15796_15846(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatStringDefinition
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 15796, 15846);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 15667, 15858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 15667, 15858);
            }
        }

        public FormatParameterDefinitionBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 15577, 15865);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 15577, 15865);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 15577, 15865);
        }


        static FormatParameterDefinitionBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 15577, 15865);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 15577, 15865);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 15577, 15865);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 15577, 15865);
    }
    internal class FormatTableParameterDefinition : FormatParameterDefinitionBase
    {
        protected override void SetEntries()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 15967, 16250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 16028, 16046);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetEntries(), 1082, 16028, 16045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 16060, 16109);

                f_1082_16060_16108(this.hashEntries, f_1082_16081_16107());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 16123, 16176);

                f_1082_16123_16175(this.hashEntries, f_1082_16144_16174());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 16190, 16239);

                f_1082_16190_16238(this.hashEntries, f_1082_16211_16237());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 15967, 16250);

                Microsoft.PowerShell.Commands.Internal.Format.WidthEntryDefinition
                f_1082_16081_16107()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WidthEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16081, 16107);
                    return return_v;
                }


                int
                f_1082_16060_16108(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.WidthEntryDefinition
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16060, 16108);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AlignmentEntryDefinition
                f_1082_16144_16174()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.AlignmentEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16144, 16174);
                    return return_v;
                }


                int
                f_1082_16123_16175(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.AlignmentEntryDefinition
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16123, 16175);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.LabelEntryDefinition
                f_1082_16211_16237()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.LabelEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16211, 16237);
                    return return_v;
                }


                int
                f_1082_16190_16238(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.LabelEntryDefinition
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16190, 16238);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 15967, 16250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 15967, 16250);
            }
        }

        public FormatTableParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 15873, 16257);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 15873, 16257);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 15873, 16257);
        }


        static FormatTableParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 15873, 16257);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 15873, 16257);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 15873, 16257);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 15873, 16257);
    }
    internal class FormatListParameterDefinition : FormatParameterDefinitionBase
    {
        protected override void SetEntries()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 16358, 16511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 16419, 16437);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetEntries(), 1082, 16419, 16436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 16451, 16500);

                f_1082_16451_16499(this.hashEntries, f_1082_16472_16498());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 16358, 16511);

                Microsoft.PowerShell.Commands.Internal.Format.LabelEntryDefinition
                f_1082_16472_16498()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.LabelEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16472, 16498);
                    return return_v;
                }


                int
                f_1082_16451_16499(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.LabelEntryDefinition
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16451, 16499);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 16358, 16511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 16358, 16511);
            }
        }

        public FormatListParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 16265, 16518);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 16265, 16518);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 16265, 16518);
        }


        static FormatListParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 16265, 16518);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 16265, 16518);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 16265, 16518);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 16265, 16518);
    }
    internal class FormatWideParameterDefinition : FormatParameterDefinitionBase
    {
        public FormatWideParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 16526, 16650);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 16526, 16650);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 16526, 16650);
        }


        static FormatWideParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 16526, 16650);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 16526, 16650);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 16526, 16650);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 16526, 16650);
    }
    internal class FormatObjectParameterDefinition : CommandParameterDefinition
    {
        protected override void SetEntries()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1082, 16750, 17014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 16811, 16865);

                f_1082_16811_16864(this.hashEntries, f_1082_16832_16863());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1082, 16879, 17003);

                f_1082_16879_17002(this.hashEntries, f_1082_16900_17001(FormatParameterDefinitionKeys.DepthEntryKey, new Type[] { typeof(int) }));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1082, 16750, 17014);

                Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition
                f_1082_16832_16863()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16832, 16863);
                    return return_v;
                }


                int
                f_1082_16811_16864(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionEntryDefinition
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16811, 16864);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1082_16900_17001(string
                name, System.Type[]
                types)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition(name, types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16900, 17001);
                    return return_v;
                }


                int
                f_1082_16879_17002(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1082, 16879, 17002);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1082, 16750, 17014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 16750, 17014);
            }
        }

        public FormatObjectParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1082, 16658, 17021);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1082, 16658, 17021);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 16658, 17021);
        }


        static FormatObjectParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1082, 16658, 17021);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1082, 16658, 17021);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1082, 16658, 17021);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1082, 16658, 17021);
    }
}

