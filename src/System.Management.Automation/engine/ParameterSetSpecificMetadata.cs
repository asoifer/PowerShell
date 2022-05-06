// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
    internal class ParameterSetSpecificMetadata
    {
        internal ParameterSetSpecificMetadata(ParameterAttribute attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1309, 655, 1447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 2484, 2518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 2803, 2849);
                this.Position = int.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 3382, 3432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 3458, 3475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 3796, 3827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 4366, 4402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 4524, 4568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 4683, 4737);
                this.HelpMessageResourceId = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 4920, 4959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 5135, 5179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7965, 7975);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 747, 875) || true) && (attribute == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1309, 747, 875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 802, 860);

                    throw f_1309_808_859("attribute");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1309, 747, 875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 891, 914);

                _attribute = attribute;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 928, 962);

                IsMandatory = f_1309_942_961(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 976, 1006);

                Position = f_1309_987_1005(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 1020, 1088);

                ValueFromRemainingArguments = f_1309_1050_1087(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 1102, 1155);

                this.valueFromPipeline = f_1309_1127_1154(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 1169, 1250);

                this.valueFromPipelineByPropertyName = f_1309_1208_1249(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 1264, 1300);

                HelpMessage = f_1309_1278_1299(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 1314, 1366);

                HelpMessageBaseName = f_1309_1336_1365(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 1380, 1436);

                HelpMessageResourceId = f_1309_1404_1435(attribute);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1309, 655, 1447);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1309, 655, 1447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1309, 655, 1447);
            }
        }

        internal ParameterSetSpecificMetadata(
                    bool isMandatory,
                    int position,
                    bool valueFromRemainingArguments,
                    bool valueFromPipeline,
                    bool valueFromPipelineByPropertyName,
                    string helpMessageBaseName,
                    string helpMessageResourceId,
                    string helpMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1309, 1459, 2273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 2484, 2518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 2803, 2849);
                this.Position = int.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 3382, 3432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 3458, 3475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 3796, 3827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 4366, 4402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 4524, 4568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 4683, 4737);
                this.HelpMessageResourceId = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 4920, 4959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 5135, 5179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7965, 7975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 1832, 1858);

                IsMandatory = isMandatory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 1872, 1892);

                Position = position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 1906, 1964);

                ValueFromRemainingArguments = valueFromRemainingArguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 1978, 2021);

                this.valueFromPipeline = valueFromPipeline;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 2035, 2106);

                this.valueFromPipelineByPropertyName = valueFromPipelineByPropertyName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 2120, 2162);

                HelpMessageBaseName = helpMessageBaseName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 2176, 2222);

                HelpMessageResourceId = helpMessageResourceId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 2236, 2262);

                HelpMessage = helpMessage;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1309, 1459, 2273);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1309, 1459, 2273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1309, 1459, 2273);
            }
        }

        internal bool IsMandatory { get; }

        internal int Position { get; }

        internal bool IsPositional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1309, 3060, 3143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 3096, 3128);

                    return f_1309_3103_3111() != int.MinValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1309, 3060, 3143);

                    int
                    f_1309_3103_3111()
                    {
                        var return_v = Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 3103, 3111);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1309, 3009, 3154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1309, 3009, 3154);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ValueFromRemainingArguments { get; }

        internal bool valueFromPipeline;

        internal bool ValueFromPipeline
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1309, 3683, 3759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 3719, 3744);

                    return valueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1309, 3683, 3759);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1309, 3627, 3770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1309, 3627, 3770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool valueFromPipelineByPropertyName;

        internal bool ValueFromPipelineByPropertyName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1309, 4112, 4202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 4148, 4187);

                    return valueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1309, 4112, 4202);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1309, 4042, 4213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1309, 4042, 4213);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string HelpMessage { get; }

        internal string HelpMessageBaseName { get; }

        internal string HelpMessageResourceId { get; }

        internal bool IsInAllSets { get; set; }

        internal uint ParameterSetFlag { get; set; }

        internal string GetHelpMessage(Cmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1309, 6324, 7926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 6394, 6417);

                string
                helpInfo = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 6431, 6486);

                bool
                isHelpMsgSet = !f_1309_6452_6485(f_1309_6473_6484())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 6500, 6571);

                bool
                isHelpMsgBaseNameSet = !f_1309_6529_6570(f_1309_6550_6569())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 6585, 6655);

                bool
                isHelpMsgResIdSet = !f_1309_6611_6654(f_1309_6632_6653())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 6671, 6877) || true) && (isHelpMsgBaseNameSet ^ isHelpMsgResIdSet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1309, 6671, 6877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 6749, 6862);

                    throw f_1309_6755_6861((DynAbs.Tracing.TraceSender.Conditional_F1(1309, 6790, 6810) || ((isHelpMsgBaseNameSet && DynAbs.Tracing.TraceSender.Conditional_F2(1309, 6813, 6836)) || DynAbs.Tracing.TraceSender.Conditional_F3(1309, 6839, 6860))) ? "HelpMessageResourceId" : "HelpMessageBaseName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1309, 6671, 6877);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 6893, 7883) || true) && (isHelpMsgBaseNameSet && (DynAbs.Tracing.TraceSender.Expression_True(1309, 6897, 6938) && isHelpMsgResIdSet))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1309, 6893, 7883);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7016, 7096);

                        helpInfo = f_1309_7027_7095(cmdlet, f_1309_7052_7071(), f_1309_7073_7094());
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1309, 7133, 7434);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7199, 7415) || true) && (isHelpMsgSet)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1309, 7199, 7415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7265, 7288);

                            helpInfo = f_1309_7276_7287();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1309, 7199, 7415);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1309, 7199, 7415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7386, 7392);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1309, 7199, 7415);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1309, 7133, 7434);
                    }
                    catch (InvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1309, 7452, 7761);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7526, 7742) || true) && (isHelpMsgSet)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1309, 7526, 7742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7592, 7615);

                            helpInfo = f_1309_7603_7614();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1309, 7526, 7742);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1309, 7526, 7742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7713, 7719);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1309, 7526, 7742);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1309, 7452, 7761);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1309, 6893, 7883);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1309, 6893, 7883);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7795, 7883) || true) && (isHelpMsgSet)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1309, 7795, 7883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7845, 7868);

                        helpInfo = f_1309_7856_7867();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1309, 7795, 7883);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1309, 6893, 7883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1309, 7899, 7915);

                return helpInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1309, 6324, 7926);

                string
                f_1309_6473_6484()
                {
                    var return_v = HelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 6473, 6484);
                    return return_v;
                }


                bool
                f_1309_6452_6485(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1309, 6452, 6485);
                    return return_v;
                }


                string
                f_1309_6550_6569()
                {
                    var return_v = HelpMessageBaseName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 6550, 6569);
                    return return_v;
                }


                bool
                f_1309_6529_6570(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1309, 6529, 6570);
                    return return_v;
                }


                string
                f_1309_6632_6653()
                {
                    var return_v = HelpMessageResourceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 6632, 6653);
                    return return_v;
                }


                bool
                f_1309_6611_6654(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1309, 6611, 6654);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1309_6755_6861(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1309, 6755, 6861);
                    return return_v;
                }


                string
                f_1309_7052_7071()
                {
                    var return_v = HelpMessageBaseName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 7052, 7071);
                    return return_v;
                }


                string
                f_1309_7073_7094()
                {
                    var return_v = HelpMessageResourceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 7073, 7094);
                    return return_v;
                }


                string
                f_1309_7027_7095(System.Management.Automation.Cmdlet
                this_param, string
                baseName, string
                resourceId)
                {
                    var return_v = this_param.GetResourceString(baseName, resourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1309, 7027, 7095);
                    return return_v;
                }


                string
                f_1309_7276_7287()
                {
                    var return_v = HelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 7276, 7287);
                    return return_v;
                }


                string
                f_1309_7603_7614()
                {
                    var return_v = HelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 7603, 7614);
                    return return_v;
                }


                string
                f_1309_7856_7867()
                {
                    var return_v = HelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 7856, 7867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1309, 6324, 7926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1309, 6324, 7926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterAttribute _attribute;

        static ParameterSetSpecificMetadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1309, 147, 7983);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1309, 147, 7983);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1309, 147, 7983);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1309, 147, 7983);

        System.Management.Automation.PSArgumentNullException
        f_1309_808_859(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1309, 808, 859);
            return return_v;
        }


        bool
        f_1309_942_961(System.Management.Automation.ParameterAttribute
        this_param)
        {
            var return_v = this_param.Mandatory;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 942, 961);
            return return_v;
        }


        int
        f_1309_987_1005(System.Management.Automation.ParameterAttribute
        this_param)
        {
            var return_v = this_param.Position;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 987, 1005);
            return return_v;
        }


        bool
        f_1309_1050_1087(System.Management.Automation.ParameterAttribute
        this_param)
        {
            var return_v = this_param.ValueFromRemainingArguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 1050, 1087);
            return return_v;
        }


        bool
        f_1309_1127_1154(System.Management.Automation.ParameterAttribute
        this_param)
        {
            var return_v = this_param.ValueFromPipeline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 1127, 1154);
            return return_v;
        }


        bool
        f_1309_1208_1249(System.Management.Automation.ParameterAttribute
        this_param)
        {
            var return_v = this_param.ValueFromPipelineByPropertyName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 1208, 1249);
            return return_v;
        }


        string
        f_1309_1278_1299(System.Management.Automation.ParameterAttribute
        this_param)
        {
            var return_v = this_param.HelpMessage;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 1278, 1299);
            return return_v;
        }


        string
        f_1309_1336_1365(System.Management.Automation.ParameterAttribute
        this_param)
        {
            var return_v = this_param.HelpMessageBaseName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 1336, 1365);
            return return_v;
        }


        string
        f_1309_1404_1435(System.Management.Automation.ParameterAttribute
        this_param)
        {
            var return_v = this_param.HelpMessageResourceId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1309, 1404, 1435);
            return return_v;
        }

    }
}

