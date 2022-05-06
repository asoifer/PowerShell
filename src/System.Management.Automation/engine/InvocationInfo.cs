// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;

namespace System.Management.Automation
{
    [DebuggerDisplay("Command = {MyCommand}")]
    public class InvocationInfo
    {
        internal InvocationInfo(InternalCommand command)
        : this(f_1284_867_886_C(f_1284_867_886(command)), f_1284_908_932(command) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.IScriptExtent>(1284, 908, 965) ?? f_1284_936_965()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1284, 798, 1040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 991, 1029);

                CommandOrigin = f_1284_1007_1028(command);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1284, 798, 1040);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 798, 1040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 798, 1040);
            }
        }

        internal InvocationInfo(CommandInfo commandInfo, IScriptExtent scriptPosition)
        : this(f_1284_1541_1552_C(commandInfo), scriptPosition, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1284, 1442, 1632);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1284, 1442, 1632);
                // nothing to do here
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 1442, 1632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 1442, 1632);
            }
        }

        internal InvocationInfo(CommandInfo commandInfo, IScriptExtent scriptPosition, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1284, 2163, 3177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7611, 7626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7652, 7667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7713, 7729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7761, 7778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 8012, 8049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 9872, 9922);
                this.HistoryId = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 12477, 12525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 12742, 12792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 12910, 12959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 13148, 13205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 13319, 13375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 15145, 15217);
                this.PipelineIterationInfo = f_1284_15198_15216();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2292, 2316);

                MyCommand = commandInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2330, 2369);

                CommandOrigin = CommandOrigin.Internal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2383, 2416);

                _scriptPosition = scriptPosition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2432, 2469);

                ExecutionContext
                contextToUse = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2483, 2735) || true) && ((commandInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1284, 2487, 2541) && (f_1284_2513_2532(commandInfo) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 2483, 2735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2575, 2610);

                    contextToUse = f_1284_2590_2609(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 2483, 2735);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 2483, 2735);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2644, 2735) || true) && (context != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 2644, 2735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2697, 2720);

                        contextToUse = context;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 2644, 2735);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 2483, 2735);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2807, 3166) || true) && (contextToUse != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 2807, 3166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2865, 2961);

                    Runspaces.LocalRunspace
                    localRunspace = f_1284_2905_2933(contextToUse) as Runspaces.LocalRunspace
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 2979, 3151) || true) && (localRunspace != null && (DynAbs.Tracing.TraceSender.Expression_True(1284, 2983, 3037) && f_1284_3008_3029(localRunspace) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 2979, 3151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 3079, 3132);

                        HistoryId = f_1284_3091_3131(f_1284_3091_3112(localRunspace));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 2979, 3151);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 2807, 3166);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1284, 2163, 3177);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 2163, 3177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 2163, 3177);
            }
        }

        internal InvocationInfo(PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1284, 3348, 7510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7611, 7626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7652, 7667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7713, 7729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7761, 7778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 8012, 8049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 9872, 9922);
                this.HistoryId = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 12477, 12525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 12742, 12792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 12910, 12959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 13148, 13205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 13319, 13375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 15145, 15217);
                this.PipelineIterationInfo = f_1284_15198_15216();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 3415, 3541);

                CommandOrigin = (CommandOrigin)f_1284_3446_3540(psObject, "InvocationInfo_CommandOrigin");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 3555, 3661);

                ExpectingInput = (bool)f_1284_3578_3660(psObject, "InvocationInfo_ExpectingInput");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 3675, 3784);

                _invocationName = (string)f_1284_3701_3783(psObject, "InvocationInfo_InvocationName");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 3798, 3894);

                HistoryId = (long)f_1284_3816_3893(psObject, "InvocationInfo_HistoryId");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 3908, 4013);

                PipelineLength = (int)f_1284_3930_4012(psObject, "InvocationInfo_PipelineLength");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 4027, 4136);

                PipelinePosition = (int)f_1284_4051_4135(psObject, "InvocationInfo_PipelinePosition");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 4152, 4259);

                string
                scriptName = (string)f_1284_4180_4258(psObject, "InvocationInfo_ScriptName")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 4273, 4386);

                int
                scriptLineNumber = (int)f_1284_4301_4385(psObject, "InvocationInfo_ScriptLineNumber")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 4400, 4505);

                int
                offsetInLine = (int)f_1284_4424_4504(psObject, "InvocationInfo_OffsetInLine")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 4519, 4614);

                string
                line = (string)f_1284_4541_4613(psObject, "InvocationInfo_Line")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 4628, 4718);

                var
                scriptPosition = f_1284_4649_4717(scriptName, scriptLineNumber, offsetInLine, line)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 4734, 4767);

                ScriptPosition
                scriptEndPosition
                = default(ScriptPosition);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 4781, 5098) || true) && (!f_1284_4786_4812(line))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 4781, 5098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 4846, 4878);

                    int
                    endColumn = f_1284_4862_4873(line) + 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 4896, 4982);

                    scriptEndPosition = f_1284_4916_4981(scriptName, scriptLineNumber, endColumn, line);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 4781, 5098);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 4781, 5098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 5048, 5083);

                    scriptEndPosition = scriptPosition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 4781, 5098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 5114, 5184);

                _scriptPosition = f_1284_5132_5183(scriptPosition, scriptEndPosition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 5200, 5264);

                MyCommand = f_1284_5212_5263(psObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 5485, 5610);

                var
                list = (ArrayList)f_1284_5507_5609(psObject, "InvocationInfo_PipelineIterationInfo")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 5624, 5855) || true) && (list != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 5624, 5855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 5674, 5731);

                    PipelineIterationInfo = (int[])f_1284_5705_5730(list, typeof(int));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 5624, 5855);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 5624, 5855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 5797, 5840);

                    PipelineIterationInfo = f_1284_5821_5839();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 5624, 5855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 6087, 6217);

                Hashtable
                hashtable = (Hashtable)f_1284_6120_6216(psObject, "InvocationInfo_BoundParameters")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 6233, 6306);

                Dictionary<string, object>
                dictionary = f_1284_6273_6305()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 6322, 6543) || true) && (hashtable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 6322, 6543);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 6377, 6528);
                        foreach (DictionaryEntry entry in f_1284_6411_6420_I(hashtable))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 6377, 6528);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 6462, 6509);

                            f_1284_6462_6508(dictionary, entry.Key, entry.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 6377, 6528);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1284, 1, 152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1284, 1, 152);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 6322, 6543);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 6559, 6589);

                _boundParameters = dictionary;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 6746, 6878);

                var
                unboundArguments = (ArrayList)f_1284_6780_6877(psObject, "InvocationInfo_UnboundArguments")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 6894, 6933);

                _unboundArguments = f_1284_6914_6932();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 6949, 7149) || true) && (unboundArguments != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 6949, 7149);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7011, 7134);
                        foreach (object o in f_1284_7032_7048_I(unboundArguments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 7011, 7134);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7090, 7115);

                            f_1284_7090_7114(_unboundArguments, o);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 7011, 7134);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1284, 1, 124);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1284, 1, 124);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 6949, 7149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7165, 7249);

                object
                value = f_1284_7180_7248(psObject, "SerializeExtent")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7263, 7292);

                bool
                serializeExtent = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7308, 7374) || true) && (value != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 7308, 7374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7344, 7374);

                    serializeExtent = (bool)value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 7308, 7374);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7390, 7499) || true) && (serializeExtent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 7390, 7499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 7428, 7499);

                    DisplayScriptPosition = f_1284_7452_7498(psObject);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 7390, 7499);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1284, 3348, 7510);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 3348, 7510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 3348, 7510);
            }
        }

        private IScriptExtent _scriptPosition;

        private string _invocationName;

        private Dictionary<string, object> _boundParameters;

        private List<object> _unboundArguments;

        public CommandInfo MyCommand { get; }

        public Dictionary<string, object> BoundParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 8304, 8492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 8340, 8477);

                    return _boundParameters ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, object>>(1284, 8347, 8476) ?? (_boundParameters = f_1284_8411_8475(f_1284_8442_8474())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 8304, 8492);

                    System.StringComparer
                    f_1284_8442_8474()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 8442, 8474);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, object>
                    f_1284_8411_8475(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, object>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 8411, 8475);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 8230, 8561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 8230, 8561);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 8508, 8550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 8523, 8548);

                    _boundParameters = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 8508, 8550);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 8230, 8561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 8230, 8561);
                }
            }
        }

        public List<object> UnboundArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 8777, 8854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 8783, 8852);

                    return _unboundArguments ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<object>>(1284, 8790, 8851) ?? (_unboundArguments = f_1284_8832_8850()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 8777, 8854);

                    System.Collections.Generic.List<object>
                    f_1284_8832_8850()
                    {
                        var return_v = new System.Collections.Generic.List<object>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 8832, 8850);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 8716, 8924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 8716, 8924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 8870, 8913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 8885, 8911);

                    _unboundArguments = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 8870, 8913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 8716, 8924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 8716, 8924);
                }
            }
        }

        public int ScriptLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 9203, 9249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 9209, 9247);

                    return f_1284_9216_9246(f_1284_9216_9230());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 9203, 9249);

                    System.Management.Automation.Language.IScriptExtent
                    f_1284_9216_9230()
                    {
                        var return_v = ScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 9216, 9230);
                        return return_v;
                    }


                    int
                    f_1284_9216_9246(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.StartLineNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 9216, 9246);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 9151, 9260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 9151, 9260);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int OffsetInLine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 9601, 9649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 9607, 9647);

                    return f_1284_9614_9646(f_1284_9614_9628());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 9601, 9649);

                    System.Management.Automation.Language.IScriptExtent
                    f_1284_9614_9628()
                    {
                        var return_v = ScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 9614, 9628);
                        return return_v;
                    }


                    int
                    f_1284_9614_9646(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.StartColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 9614, 9646);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 9553, 9660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 9553, 9660);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public long HistoryId { get; internal set; }

        public string ScriptName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 10163, 10214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 10169, 10212);

                    return f_1284_10176_10195(f_1284_10176_10190()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1284, 10176, 10211) ?? string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 10163, 10214);

                    System.Management.Automation.Language.IScriptExtent
                    f_1284_10176_10190()
                    {
                        var return_v = ScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 10176, 10190);
                        return return_v;
                    }


                    string
                    f_1284_10176_10195(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.File;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 10176, 10195);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 10114, 10225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 10114, 10225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Line
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 10473, 10718);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 10509, 10663) || true) && (f_1284_10513_10547(f_1284_10513_10527()) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 10509, 10663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 10597, 10644);

                        return f_1284_10604_10643(f_1284_10604_10638(f_1284_10604_10618()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 10509, 10663);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 10683, 10703);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 10473, 10718);

                    System.Management.Automation.Language.IScriptExtent
                    f_1284_10513_10527()
                    {
                        var return_v = ScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 10513, 10527);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptPosition
                    f_1284_10513_10547(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.StartScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 10513, 10547);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1284_10604_10618()
                    {
                        var return_v = ScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 10604, 10618);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptPosition
                    f_1284_10604_10638(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.StartScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 10604, 10638);
                        return return_v;
                    }


                    string
                    f_1284_10604_10643(System.Management.Automation.Language.IScriptPosition
                    this_param)
                    {
                        var return_v = this_param.Line;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 10604, 10643);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 10430, 10729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 10430, 10729);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string PositionMessage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 11027, 11091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 11033, 11089);

                    return f_1284_11040_11088(f_1284_11073_11087());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 11027, 11091);

                    System.Management.Automation.Language.IScriptExtent
                    f_1284_11073_11087()
                    {
                        var return_v = ScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 11073, 11087);
                        return return_v;
                    }


                    string
                    f_1284_11040_11088(System.Management.Automation.Language.IScriptExtent
                    position)
                    {
                        var return_v = PositionUtilities.VerboseMessage(position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 11040, 11088);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 10973, 11102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 10973, 11102);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string PSScriptRoot
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 11298, 11608);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 11334, 11593) || true) && (!f_1284_11339_11380(f_1284_11360_11379(f_1284_11360_11374())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 11334, 11593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 11422, 11472);

                        return f_1284_11429_11471(f_1284_11451_11470(f_1284_11451_11465()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 11334, 11593);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 11334, 11593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 11554, 11574);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 11334, 11593);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 11298, 11608);

                    System.Management.Automation.Language.IScriptExtent
                    f_1284_11360_11374()
                    {
                        var return_v = ScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 11360, 11374);
                        return return_v;
                    }


                    string
                    f_1284_11360_11379(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.File;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 11360, 11379);
                        return return_v;
                    }


                    bool
                    f_1284_11339_11380(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 11339, 11380);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1284_11451_11465()
                    {
                        var return_v = ScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 11451, 11465);
                        return return_v;
                    }


                    string
                    f_1284_11451_11470(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.File;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 11451, 11470);
                        return return_v;
                    }


                    string?
                    f_1284_11429_11471(string
                    path)
                    {
                        var return_v = Path.GetDirectoryName(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 11429, 11471);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 11247, 11619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 11247, 11619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string PSCommandPath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 11831, 11866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 11837, 11864);

                    return f_1284_11844_11863(f_1284_11844_11858());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 11831, 11866);

                    System.Management.Automation.Language.IScriptExtent
                    f_1284_11844_11858()
                    {
                        var return_v = ScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 11844, 11858);
                        return return_v;
                    }


                    string
                    f_1284_11844_11863(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.File;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 11844, 11863);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 11779, 11877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 11779, 11877);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string InvocationName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 12166, 12213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 12172, 12211);

                    return _invocationName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1284, 12179, 12210) ?? string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 12166, 12213);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 12113, 12281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 12113, 12281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 12229, 12270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 12244, 12268);

                    _invocationName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 12229, 12270);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 12113, 12281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 12113, 12281);
                }
            }
        }

        public int PipelineLength { get; internal set; }

        public int PipelinePosition { get; internal set; }

        public bool ExpectingInput { get; internal set; }

        public CommandOrigin CommandOrigin { get; internal set; }

        public IScriptExtent DisplayScriptPosition { get; set; }

        public static InvocationInfo Create(
                    CommandInfo commandInfo,
                    IScriptExtent scriptPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1284, 13587, 13915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 13729, 13798);

                var
                invocationInfo = f_1284_13750_13797(commandInfo, scriptPosition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 13812, 13866);

                invocationInfo.DisplayScriptPosition = scriptPosition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 13882, 13904);

                return invocationInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1284, 13587, 13915);

                System.Management.Automation.InvocationInfo
                f_1284_13750_13797(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 13750, 13797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 13587, 13915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 13587, 13915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IScriptExtent ScriptPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 14164, 14443);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 14200, 14428) || true) && (f_1284_14204_14225() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 14200, 14428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 14275, 14304);

                        return f_1284_14282_14303();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 14200, 14428);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 14200, 14428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 14386, 14409);

                        return _scriptPosition;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 14200, 14428);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 14164, 14443);

                    System.Management.Automation.Language.IScriptExtent
                    f_1284_14204_14225()
                    {
                        var return_v = DisplayScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 14204, 14225);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1284_14282_14303()
                    {
                        var return_v = DisplayScriptPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 14282, 14303);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 14102, 14502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 14102, 14502);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 14459, 14491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 14465, 14489);

                    _scriptPosition = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 14459, 14491);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 14102, 14502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 14102, 14502);
                }
            }
        }

        internal string GetFullScript()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 14636, 14860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 14692, 14849);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1284, 14699, 14771) || (((f_1284_14700_14714() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1284, 14699, 14771) && (f_1284_14728_14762(f_1284_14728_14742()) != null)) && DynAbs.Tracing.TraceSender.Conditional_F2(1284, 14791, 14841)) || DynAbs.Tracing.TraceSender.Conditional_F3(1284, 14844, 14848))) ? f_1284_14791_14841(f_1284_14791_14825(f_1284_14791_14805())) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 14636, 14860);

                System.Management.Automation.Language.IScriptExtent
                f_1284_14700_14714()
                {
                    var return_v = ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 14700, 14714);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1284_14728_14742()
                {
                    var return_v = ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 14728, 14742);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1284_14728_14762(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 14728, 14762);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1284_14791_14805()
                {
                    var return_v = ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 14791, 14805);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1284_14791_14825(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 14791, 14825);
                    return return_v;
                }


                string
                f_1284_14791_14841(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.GetFullScript();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 14791, 14841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 14636, 14860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 14636, 14860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int[] PipelineIterationInfo { get; set; }

        internal void ToPSObjectForRemoting(PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 15722, 18455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 15801, 15913);

                f_1284_15801_15912(psObject, "InvocationInfo_BoundParameters", () => this.BoundParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 15927, 16042);

                f_1284_15927_16041(psObject, "InvocationInfo_CommandOrigin", () => this.CommandOrigin);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 16056, 16164);

                f_1284_16056_16163(psObject, "InvocationInfo_ExpectingInput", () => this.ExpectingInput);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 16178, 16288);

                f_1284_16178_16287(psObject, "InvocationInfo_InvocationName", () => this.InvocationName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 16302, 16392);

                f_1284_16302_16391(psObject, "InvocationInfo_Line", () => this.Line);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 16406, 16509);

                f_1284_16406_16508(psObject, "InvocationInfo_OffsetInLine", () => this.OffsetInLine);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 16523, 16621);

                f_1284_16523_16620(psObject, "InvocationInfo_HistoryId", () => this.HistoryId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 16635, 16758);

                f_1284_16635_16757(psObject, "InvocationInfo_PipelineIterationInfo", () => this.PipelineIterationInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 16772, 16879);

                f_1284_16772_16878(psObject, "InvocationInfo_PipelineLength", () => this.PipelineLength);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 16893, 17004);

                f_1284_16893_17003(psObject, "InvocationInfo_PipelinePosition", () => this.PipelinePosition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 17018, 17124);

                f_1284_17018_17123(psObject, "InvocationInfo_PSScriptRoot", () => this.PSScriptRoot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 17138, 17246);

                f_1284_17138_17245(psObject, "InvocationInfo_PSCommandPath", () => this.PSCommandPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 17454, 17566);

                f_1284_17454_17565(psObject, "InvocationInfo_PositionMessage", () => this.PositionMessage);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 17580, 17691);

                f_1284_17580_17690(psObject, "InvocationInfo_ScriptLineNumber", () => this.ScriptLineNumber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 17705, 17807);

                f_1284_17705_17806(psObject, "InvocationInfo_ScriptName", () => this.ScriptName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 17821, 17935);

                f_1284_17821_17934(psObject, "InvocationInfo_UnboundArguments", () => this.UnboundArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 17951, 18011);

                ScriptExtent
                extent = f_1284_17973_17994() as ScriptExtent
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 18025, 18362) || true) && (extent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 18025, 18362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 18077, 18116);

                    f_1284_18077_18115(extent, psObject);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 18134, 18207);

                    f_1284_18134_18206(psObject, "SerializeExtent", () => true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 18025, 18362);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 18025, 18362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 18273, 18347);

                    f_1284_18273_18346(psObject, "SerializeExtent", () => false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 18025, 18362);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 18378, 18444);

                f_1284_18378_18443(f_1284_18418_18432(this), psObject);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 15722, 18455);

                int
                f_1284_15801_15912(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<object>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<object>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 15801, 15912);
                    return 0;
                }


                int
                f_1284_15927_16041(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<System.Management.Automation.CommandOrigin>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<CommandOrigin>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 15927, 16041);
                    return 0;
                }


                int
                f_1284_16056_16163(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<bool>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<bool>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 16056, 16163);
                    return 0;
                }


                int
                f_1284_16178_16287(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 16178, 16287);
                    return 0;
                }


                int
                f_1284_16302_16391(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 16302, 16391);
                    return 0;
                }


                int
                f_1284_16406_16508(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<int>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<int>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 16406, 16508);
                    return 0;
                }


                int
                f_1284_16523_16620(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<long>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<long>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 16523, 16620);
                    return 0;
                }


                int
                f_1284_16635_16757(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<int[]>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<int[]>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 16635, 16757);
                    return 0;
                }


                int
                f_1284_16772_16878(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<int>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<int>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 16772, 16878);
                    return 0;
                }


                int
                f_1284_16893_17003(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<int>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<int>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 16893, 17003);
                    return 0;
                }


                int
                f_1284_17018_17123(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 17018, 17123);
                    return 0;
                }


                int
                f_1284_17138_17245(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 17138, 17245);
                    return 0;
                }


                int
                f_1284_17454_17565(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 17454, 17565);
                    return 0;
                }


                int
                f_1284_17580_17690(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<int>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<int>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 17580, 17690);
                    return 0;
                }


                int
                f_1284_17705_17806(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 17705, 17806);
                    return 0;
                }


                int
                f_1284_17821_17934(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<object>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<object>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 17821, 17934);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1284_17973_17994()
                {
                    var return_v = DisplayScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 17973, 17994);
                    return return_v;
                }


                int
                f_1284_18077_18115(System.Management.Automation.Language.ScriptExtent
                this_param, System.Management.Automation.PSObject
                dest)
                {
                    this_param.ToPSObjectForRemoting(dest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 18077, 18115);
                    return 0;
                }


                int
                f_1284_18134_18206(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<bool>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 18134, 18206);
                    return 0;
                }


                int
                f_1284_18273_18346(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<bool>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 18273, 18346);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1284_18418_18432(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 18418, 18432);
                    return return_v;
                }


                int
                f_1284_18378_18443(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.PSObject
                psObject)
                {
                    RemoteCommandInfo.ToPSObjectForRemoting(commandInfo, psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 18378, 18443);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 15722, 18455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 15722, 18455);
            }
        }

        static InvocationInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1284, 485, 18501);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1284, 485, 18501);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 485, 18501);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1284, 485, 18501);

        static System.Management.Automation.CommandInfo
        f_1284_867_886(System.Management.Automation.Internal.InternalCommand
        this_param)
        {
            var return_v = this_param.CommandInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 867, 886);
            return return_v;
        }


        static System.Management.Automation.Language.IScriptExtent
        f_1284_908_932(System.Management.Automation.Internal.InternalCommand
        this_param)
        {
            var return_v = this_param.InvocationExtent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 908, 932);
            return return_v;
        }


        static System.Management.Automation.Language.IScriptExtent
        f_1284_936_965()
        {
            var return_v = PositionUtilities.EmptyExtent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 936, 965);
            return return_v;
        }


        System.Management.Automation.CommandOrigin
        f_1284_1007_1028(System.Management.Automation.Internal.InternalCommand
        this_param)
        {
            var return_v = this_param.CommandOrigin;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 1007, 1028);
            return return_v;
        }


        static System.Management.Automation.CommandInfo
        f_1284_867_886_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1284, 798, 1040);
            return return_v;
        }


        static System.Management.Automation.CommandInfo
        f_1284_1541_1552_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1284, 1442, 1632);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1284_2513_2532(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 2513, 2532);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1284_2590_2609(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 2590, 2609);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1284_2905_2933(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.CurrentRunspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 2905, 2933);
            return return_v;
        }


        Microsoft.PowerShell.Commands.History
        f_1284_3008_3029(System.Management.Automation.Runspaces.LocalRunspace
        this_param)
        {
            var return_v = this_param.History;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 3008, 3029);
            return return_v;
        }


        Microsoft.PowerShell.Commands.History
        f_1284_3091_3112(System.Management.Automation.Runspaces.LocalRunspace
        this_param)
        {
            var return_v = this_param.History;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 3091, 3112);
            return return_v;
        }


        long
        f_1284_3091_3131(Microsoft.PowerShell.Commands.History
        this_param)
        {
            var return_v = this_param.GetNextHistoryId();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 3091, 3131);
            return return_v;
        }


        object
        f_1284_3446_3540(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPsObjectPropertyBaseObject(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 3446, 3540);
            return return_v;
        }


        object
        f_1284_3578_3660(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 3578, 3660);
            return return_v;
        }


        object
        f_1284_3701_3783(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 3701, 3783);
            return return_v;
        }


        object
        f_1284_3816_3893(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 3816, 3893);
            return return_v;
        }


        object
        f_1284_3930_4012(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 3930, 4012);
            return return_v;
        }


        object
        f_1284_4051_4135(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 4051, 4135);
            return return_v;
        }


        object
        f_1284_4180_4258(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 4180, 4258);
            return return_v;
        }


        object
        f_1284_4301_4385(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 4301, 4385);
            return return_v;
        }


        object
        f_1284_4424_4504(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 4424, 4504);
            return return_v;
        }


        object
        f_1284_4541_4613(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 4541, 4613);
            return return_v;
        }


        System.Management.Automation.Language.ScriptPosition
        f_1284_4649_4717(string
        scriptName, int
        scriptLineNumber, int
        offsetInLine, string
        line)
        {
            var return_v = new System.Management.Automation.Language.ScriptPosition(scriptName, scriptLineNumber, offsetInLine, line);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 4649, 4717);
            return return_v;
        }


        bool
        f_1284_4786_4812(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 4786, 4812);
            return return_v;
        }


        int
        f_1284_4862_4873(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1284, 4862, 4873);
            return return_v;
        }


        System.Management.Automation.Language.ScriptPosition
        f_1284_4916_4981(string
        scriptName, int
        scriptLineNumber, int
        offsetInLine, string
        line)
        {
            var return_v = new System.Management.Automation.Language.ScriptPosition(scriptName, scriptLineNumber, offsetInLine, line);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 4916, 4981);
            return return_v;
        }


        System.Management.Automation.Language.ScriptExtent
        f_1284_5132_5183(System.Management.Automation.Language.ScriptPosition
        startPosition, System.Management.Automation.Language.ScriptPosition
        endPosition)
        {
            var return_v = new System.Management.Automation.Language.ScriptExtent(startPosition, endPosition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 5132, 5183);
            return return_v;
        }


        System.Management.Automation.RemoteCommandInfo
        f_1284_5212_5263(System.Management.Automation.PSObject
        psObject)
        {
            var return_v = RemoteCommandInfo.FromPSObjectForRemoting(psObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 5212, 5263);
            return return_v;
        }


        object
        f_1284_5507_5609(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPsObjectPropertyBaseObject(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 5507, 5609);
            return return_v;
        }


        System.Array
        f_1284_5705_5730(System.Collections.ArrayList
        this_param, System.Type
        type)
        {
            var return_v = this_param.ToArray(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 5705, 5730);
            return return_v;
        }


        int[]
        f_1284_5821_5839()
        {
            var return_v = Array.Empty<int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 5821, 5839);
            return return_v;
        }


        object
        f_1284_6120_6216(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPsObjectPropertyBaseObject(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 6120, 6216);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, object>
        f_1284_6273_6305()
        {
            var return_v = new System.Collections.Generic.Dictionary<string, object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 6273, 6305);
            return return_v;
        }


        int
        f_1284_6462_6508(System.Collections.Generic.Dictionary<string, object>
        this_param, object
        key, object
        value)
        {
            this_param.Add((string)key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 6462, 6508);
            return 0;
        }


        System.Collections.Hashtable
        f_1284_6411_6420_I(System.Collections.Hashtable
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 6411, 6420);
            return return_v;
        }


        object
        f_1284_6780_6877(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPsObjectPropertyBaseObject(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 6780, 6877);
            return return_v;
        }


        System.Collections.Generic.List<object>
        f_1284_6914_6932()
        {
            var return_v = new System.Collections.Generic.List<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 6914, 6932);
            return return_v;
        }


        int
        f_1284_7090_7114(System.Collections.Generic.List<object>
        this_param, object
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 7090, 7114);
            return 0;
        }


        System.Collections.ArrayList
        f_1284_7032_7048_I(System.Collections.ArrayList
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 7032, 7048);
            return return_v;
        }


        object
        f_1284_7180_7248(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 7180, 7248);
            return return_v;
        }


        System.Management.Automation.Language.ScriptExtent
        f_1284_7452_7498(System.Management.Automation.PSObject
        serializedScriptExtent)
        {
            var return_v = ScriptExtent.FromPSObjectForRemoting(serializedScriptExtent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 7452, 7498);
            return return_v;
        }


        int[]
        f_1284_15198_15216()
        {
            var return_v = Array.Empty<int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 15198, 15216);
            return return_v;
        }

    }
    public class RemoteCommandInfo : CommandInfo
    {
        private RemoteCommandInfo(string name, CommandTypes type)
        : base(f_1284_18852_18856_C(name), type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1284, 18774, 18920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 21601, 21612);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1284, 18774, 18920);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 18774, 18920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 18774, 18920);
            }
        }

        public override string Definition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 19081, 19108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 19087, 19106);

                    return _definition;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 19081, 19108);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 19045, 19110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 19045, 19110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static RemoteCommandInfo FromPSObjectForRemoting(PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1284, 19278, 20202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 19379, 19416);

                RemoteCommandInfo
                commandInfo = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 19432, 19537);

                object
                ctype = f_1284_19447_19536(psObject, "CommandInfo_CommandType")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 19553, 20156) || true) && (ctype != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 19553, 20156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 19604, 19708);

                    CommandTypes
                    type = f_1284_19624_19707(psObject, "CommandInfo_CommandType")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 19726, 19811);

                    string
                    name = f_1284_19740_19810(psObject, "CommandInfo_Name")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 19831, 19879);

                    commandInfo = f_1284_19845_19878(name, type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 19897, 20000);

                    commandInfo._definition = f_1284_19923_19999(psObject, "CommandInfo_Definition");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 20018, 20141);

                    commandInfo.Visibility = f_1284_20043_20140(psObject, "CommandInfo_Visibility");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 19553, 20156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 20172, 20191);

                return commandInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1284, 19278, 20202);

                object
                f_1284_19447_19536(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = SerializationUtilities.GetPsObjectPropertyBaseObject(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 19447, 19536);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1284_19624_19707(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<CommandTypes>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 19624, 19707);
                    return return_v;
                }


                string
                f_1284_19740_19810(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 19740, 19810);
                    return return_v;
                }


                System.Management.Automation.RemoteCommandInfo
                f_1284_19845_19878(string
                name, System.Management.Automation.CommandTypes
                type)
                {
                    var return_v = new System.Management.Automation.RemoteCommandInfo(name, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 19845, 19878);
                    return return_v;
                }


                string
                f_1284_19923_19999(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 19923, 19999);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1284_20043_20140(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<SessionStateEntryVisibility>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 20043, 20140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 19278, 20202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 19278, 20202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ToPSObjectForRemoting(CommandInfo commandInfo, PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1284, 20695, 21384);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 20806, 21373) || true) && (commandInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1284, 20806, 21373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 20863, 20977);

                    f_1284_20863_20976(psObject, "CommandInfo_CommandType", () => commandInfo.CommandType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 20995, 21101);

                    f_1284_20995_21100(psObject, "CommandInfo_Definition", () => commandInfo.Definition);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 21119, 21213);

                    f_1284_21119_21212(psObject, "CommandInfo_Name", () => commandInfo.Name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 21231, 21358);

                    f_1284_21231_21357(psObject, "CommandInfo_Visibility", () => commandInfo.Visibility);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1284, 20806, 21373);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1284, 20695, 21384);

                int
                f_1284_20863_20976(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<System.Management.Automation.CommandTypes>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<CommandTypes>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 20863, 20976);
                    return 0;
                }


                int
                f_1284_20995_21100(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 20995, 21100);
                    return 0;
                }


                int
                f_1284_21119_21212(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 21119, 21212);
                    return 0;
                }


                int
                f_1284_21231_21357(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<System.Management.Automation.SessionStateEntryVisibility>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<SessionStateEntryVisibility>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1284, 21231, 21357);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 20695, 21384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 20695, 21384);
            }
        }

        public override ReadOnlyCollection<PSTypeName> OutputType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1284, 21543, 21563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1284, 21549, 21561);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1284, 21543, 21563);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1284, 21461, 21574);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 21461, 21574);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _definition;

        static RemoteCommandInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1284, 18666, 21620);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1284, 18666, 21620);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1284, 18666, 21620);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1284, 18666, 21620);

        static string
        f_1284_18852_18856_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1284, 18774, 18920);
            return return_v;
        }

    }
}

