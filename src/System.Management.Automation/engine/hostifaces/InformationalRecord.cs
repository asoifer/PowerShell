// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace System.Management.Automation
{
    [DataContract()]
    public abstract class InformationalRecord
    {
        internal InformationalRecord(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1462, 727, 952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5817, 5825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5859, 5874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5917, 5939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5963, 5985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 796, 815);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 829, 852);

                _invocationInfo = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 866, 896);

                _pipelineIterationInfo = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 910, 941);

                _serializeExtendedInfo = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1462, 727, 952);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 727, 952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 727, 952);
            }
        }

        internal InformationalRecord(PSObject serializedObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1462, 1127, 2016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5817, 5825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5859, 5874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5917, 5939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5963, 5985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 1207, 1315);

                _message = (string)f_1462_1226_1314(serializedObject, "InformationalRecord_Message");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 1329, 1465);

                _serializeExtendedInfo = (bool)f_1462_1360_1464(serializedObject, "InformationalRecord_SerializeInvocationInfo");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 1481, 2005) || true) && (_serializeExtendedInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1462, 1481, 2005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 1541, 1596);

                    _invocationInfo = f_1462_1559_1595(serializedObject);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 1616, 1777);

                    ArrayList
                    pipelineIterationInfo = (ArrayList)f_1462_1661_1776(serializedObject, "InformationalRecord_PipelineIterationInfo")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 1797, 1901);

                    _pipelineIterationInfo = f_1462_1822_1900((int[])f_1462_1857_1899(pipelineIterationInfo, typeof(int)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1462, 1481, 2005);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1462, 1481, 2005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 1967, 1990);

                    _invocationInfo = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1462, 1481, 2005);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1462, 1127, 2016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 1127, 2016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 1127, 2016);
            }
        }

        public string Message
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1462, 2195, 2262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 2231, 2247);

                    return _message;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1462, 2195, 2262);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 2149, 2314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 2149, 2314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1462, 2278, 2303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 2284, 2301);

                    _message = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1462, 2278, 2303);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 2149, 2314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 2149, 2314);
                }
            }
        }

        public InvocationInfo InvocationInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1462, 2642, 2716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 2678, 2701);

                    return _invocationInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1462, 2642, 2716);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 2581, 2727);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 2581, 2727);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ReadOnlyCollection<int> PipelineIterationInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1462, 3075, 3156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 3111, 3141);

                    return _pipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1462, 3075, 3156);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 2998, 3167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 2998, 3167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SetInvocationInfo(InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1462, 3308, 3849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 3395, 3428);

                _invocationInfo = invocationInfo;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 3589, 3838) || true) && (f_1462_3593_3629(invocationInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1462, 3589, 3838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 3671, 3740);

                    int[]
                    snapshot = (int[])f_1462_3695_3739(f_1462_3695_3731(invocationInfo))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 3760, 3823);

                    _pipelineIterationInfo = f_1462_3785_3822(snapshot);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1462, 3589, 3838);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1462, 3308, 3849);

                int[]
                f_1462_3593_3629(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1462, 3593, 3629);
                    return return_v;
                }


                int[]
                f_1462_3695_3731(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelineIterationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1462, 3695, 3731);
                    return return_v;
                }


                object
                f_1462_3695_3739(int[]
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 3695, 3739);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<int>
                f_1462_3785_3822(int[]
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<int>((System.Collections.Generic.IList<int>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 3785, 3822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 3308, 3849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 3308, 3849);
            }
        }

        internal bool SerializeExtendedInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1462, 4068, 4149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 4104, 4134);

                    return _serializeExtendedInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1462, 4068, 4149);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 4008, 4258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 4008, 4258);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1462, 4165, 4247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 4201, 4232);

                    _serializeExtendedInfo = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1462, 4165, 4247);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 4008, 4258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 4008, 4258);
                }
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1462, 4360, 4449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 4418, 4438);

                return f_1462_4425_4437(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1462, 4360, 4449);

                string
                f_1462_4425_4437(System.Management.Automation.InformationalRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1462, 4425, 4437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 4360, 4449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 4360, 4449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void ToPSObjectForRemoting(PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1462, 4692, 5766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 4779, 4880);

                f_1462_4779_4879(psObject, "InformationalRecord_Message", () => this.Message);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5166, 5755) || true) && (f_1462_5170_5197_M(!this.SerializeExtendedInfo) || (DynAbs.Tracing.TraceSender.Expression_False(1462, 5170, 5224) || _invocationInfo == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1462, 5166, 5755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5258, 5360);

                    f_1462_5258_5359(psObject, "InformationalRecord_SerializeInvocationInfo", () => false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1462, 5166, 5755);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1462, 5166, 5755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5426, 5527);

                    f_1462_5426_5526(psObject, "InformationalRecord_SerializeInvocationInfo", () => true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5545, 5593);

                    f_1462_5545_5592(_invocationInfo, psObject);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 5611, 5740);

                    f_1462_5611_5739(psObject, "InformationalRecord_PipelineIterationInfo", () => this.PipelineIterationInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1462, 5166, 5755);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1462, 4692, 5766);

                int
                f_1462_4779_4879(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<string>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 4779, 4879);
                    return 0;
                }


                bool
                f_1462_5170_5197_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1462, 5170, 5197);
                    return return_v;
                }


                int
                f_1462_5258_5359(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<bool>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 5258, 5359);
                    return 0;
                }


                int
                f_1462_5426_5526(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<bool>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 5426, 5526);
                    return 0;
                }


                int
                f_1462_5545_5592(System.Management.Automation.InvocationInfo
                this_param, System.Management.Automation.PSObject
                psObject)
                {
                    this_param.ToPSObjectForRemoting(psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 5545, 5592);
                    return 0;
                }


                int
                f_1462_5611_5739(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<object>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty<object>(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 5611, 5739);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 4692, 5766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 4692, 5766);
            }
        }

        [DataMember()]
        private string _message;

        private InvocationInfo _invocationInfo;

        private ReadOnlyCollection<int> _pipelineIterationInfo;

        private bool _serializeExtendedInfo;

        static InformationalRecord()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1462, 528, 5993);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1462, 528, 5993);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 528, 5993);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1462, 528, 5993);

        object
        f_1462_1226_1314(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 1226, 1314);
            return return_v;
        }


        object
        f_1462_1360_1464(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPropertyValue(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 1360, 1464);
            return return_v;
        }


        System.Management.Automation.InvocationInfo
        f_1462_1559_1595(System.Management.Automation.PSObject
        psObject)
        {
            var return_v = new System.Management.Automation.InvocationInfo(psObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 1559, 1595);
            return return_v;
        }


        object
        f_1462_1661_1776(System.Management.Automation.PSObject
        psObject, string
        propertyName)
        {
            var return_v = SerializationUtilities.GetPsObjectPropertyBaseObject(psObject, propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 1661, 1776);
            return return_v;
        }


        System.Array
        f_1462_1857_1899(System.Collections.ArrayList
        this_param, System.Type
        type)
        {
            var return_v = this_param.ToArray(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 1857, 1899);
            return return_v;
        }


        System.Collections.ObjectModel.ReadOnlyCollection<int>
        f_1462_1822_1900(int[]
        list)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<int>((System.Collections.Generic.IList<int>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1462, 1822, 1900);
            return return_v;
        }

    }
    [DataContract()]
    public class WarningRecord : InformationalRecord
    {
        public WarningRecord(string message)
        : base(f_1462_6332_6339_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1462, 6275, 6353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 7764, 7788);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1462, 6275, 6353);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 6275, 6353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 6275, 6353);
            }
        }

        public WarningRecord(PSObject record)
        : base(f_1462_6513_6519_C(record))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1462, 6455, 6533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 7764, 7788);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1462, 6455, 6533);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 6455, 6533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 6455, 6533);
            }
        }

        public WarningRecord(string fullyQualifiedWarningId, string message)
        : base(f_1462_6885_6892_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1462, 6796, 6980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 7764, 7788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 6918, 6969);

                _fullyQualifiedWarningId = fullyQualifiedWarningId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1462, 6796, 6980);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 6796, 6980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 6796, 6980);
            }
        }

        public WarningRecord(string fullyQualifiedWarningId, PSObject record)
        : base(f_1462_7342_7348_C(record))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1462, 7252, 7436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 7764, 7788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 7374, 7425);

                _fullyQualifiedWarningId = fullyQualifiedWarningId;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1462, 7252, 7436);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 7252, 7436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 7252, 7436);
            }
        }

        public string FullyQualifiedWarningId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1462, 7627, 7726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1462, 7663, 7711);

                    return _fullyQualifiedWarningId ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1462, 7670, 7710) ?? string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1462, 7627, 7726);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 7565, 7737);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 7565, 7737);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _fullyQualifiedWarningId;

        static WarningRecord()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1462, 6097, 7796);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1462, 6097, 7796);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 6097, 7796);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1462, 6097, 7796);

        static string
        f_1462_6332_6339_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1462, 6275, 6353);
            return return_v;
        }


        static System.Management.Automation.PSObject
        f_1462_6513_6519_C(System.Management.Automation.PSObject
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1462, 6455, 6533);
            return return_v;
        }


        static string
        f_1462_6885_6892_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1462, 6796, 6980);
            return return_v;
        }


        static System.Management.Automation.PSObject
        f_1462_7342_7348_C(System.Management.Automation.PSObject
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1462, 7252, 7436);
            return return_v;
        }

    }
    [DataContract()]
    public class DebugRecord : InformationalRecord
    {
        public DebugRecord(string message)
        : base(f_1462_8129_8136_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1462, 8074, 8150);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1462, 8074, 8150);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 8074, 8150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 8074, 8150);
            }
        }

        public DebugRecord(PSObject record)
        : base(f_1462_8308_8314_C(record))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1462, 8252, 8328);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1462, 8252, 8328);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 8252, 8328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 8252, 8328);
            }
        }

        static DebugRecord()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1462, 7898, 8335);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1462, 7898, 8335);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 7898, 8335);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1462, 7898, 8335);

        static string
        f_1462_8129_8136_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1462, 8074, 8150);
            return return_v;
        }


        static System.Management.Automation.PSObject
        f_1462_8308_8314_C(System.Management.Automation.PSObject
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1462, 8252, 8328);
            return return_v;
        }

    }
    [DataContract()]
    public class VerboseRecord : InformationalRecord
    {
        public VerboseRecord(string message)
        : base(f_1462_8674_8681_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1462, 8617, 8695);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1462, 8617, 8695);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 8617, 8695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 8617, 8695);
            }
        }

        public VerboseRecord(PSObject record)
        : base(f_1462_8855_8861_C(record))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1462, 8797, 8875);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1462, 8797, 8875);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1462, 8797, 8875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 8797, 8875);
            }
        }

        static VerboseRecord()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1462, 8439, 8882);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1462, 8439, 8882);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1462, 8439, 8882);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1462, 8439, 8882);

        static string
        f_1462_8674_8681_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1462, 8617, 8695);
            return return_v;
        }


        static System.Management.Automation.PSObject
        f_1462_8855_8861_C(System.Management.Automation.PSObject
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1462, 8797, 8875);
            return return_v;
        }

    }
}
