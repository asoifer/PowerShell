// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Host;
using System.Reflection;

using Dbg = System.Management.Automation.Diagnostics;
using InternalHostUserInterface = System.Management.Automation.Internal.Host.InternalHostUserInterface;

namespace System.Management.Automation.Remoting
{
    internal class RemoteHostCall
    {
        internal string MethodName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 793, 868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 829, 853);

                    return f_1670_836_852(_methodInfo);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 793, 868);

                    string
                    f_1670_836_852(System.Management.Automation.Remoting.RemoteHostMethodInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 836, 852);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 742, 879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 742, 879);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal RemoteHostMethodId MethodId { get; }

        internal object[] Parameters { get; }

        private RemoteHostMethodInfo _methodInfo;

        private long _callId;

        internal long CallId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 1482, 1548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 1518, 1533);

                    return _callId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 1482, 1548);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 1437, 1559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 1437, 1559);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _computerName;

        internal RemoteHostCall(long callId, RemoteHostMethodId methodId, object[] parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1670, 1802, 2155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 962, 1007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 1091, 1128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 1242, 1253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 1348, 1355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 1684, 1697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 1913, 1975);

                f_1670_1913_1974(parameters != null, "Expected parameters != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 1989, 2006);

                _callId = callId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 2020, 2040);

                MethodId = methodId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 2054, 2078);

                Parameters = parameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 2092, 2144);

                _methodInfo = f_1670_2106_2143(methodId);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1670, 1802, 2155);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 1802, 2155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 1802, 2155);
            }
        }

        private static PSObject EncodeParameters(object[] parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 2246, 2785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 2433, 2475);

                ArrayList
                parameterList = f_1670_2459_2474()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 2498, 2503);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 2489, 2723) || true) && (i < f_1670_2509_2526(parameters))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 2528, 2531)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 2489, 2723))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 2489, 2723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 2565, 2661);

                        object
                        parameter = (DynAbs.Tracing.TraceSender.Conditional_F1(1670, 2584, 2605) || ((parameters[i] == null && DynAbs.Tracing.TraceSender.Conditional_F2(1670, 2608, 2612)) || DynAbs.Tracing.TraceSender.Conditional_F3(1670, 2615, 2660))) ? null : f_1670_2615_2660(parameters[i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 2679, 2708);

                        f_1670_2679_2707(parameterList, parameter);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1670, 1, 235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1670, 1, 235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 2739, 2774);

                return f_1670_2746_2773(parameterList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 2246, 2785);

                System.Collections.ArrayList
                f_1670_2459_2474()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 2459, 2474);
                    return return_v;
                }


                int
                f_1670_2509_2526(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 2509, 2526);
                    return return_v;
                }


                object
                f_1670_2615_2660(object
                obj)
                {
                    var return_v = RemoteHostEncoder.EncodeObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 2615, 2660);
                    return return_v;
                }


                int
                f_1670_2679_2707(System.Collections.ArrayList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 2679, 2707);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1670_2746_2773(System.Collections.ArrayList
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 2746, 2773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 2246, 2785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 2246, 2785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object[] DecodeParameters(PSObject parametersPSObject, Type[] parameterTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 2876, 3642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3058, 3122);

                ArrayList
                parameters = (ArrayList)f_1670_3092_3121(parametersPSObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3136, 3188);

                List<object>
                decodedParameters = f_1670_3169_3187()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3202, 3310);

                f_1670_3202_3309(f_1670_3213_3229(parameters) == f_1670_3233_3254(parameterTypes), "Expected parameters.Count == parameterTypes.Length");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3333, 3338);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3324, 3580) || true) && (i < f_1670_3344_3360(parameters))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3362, 3365)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 3324, 3580))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 3324, 3580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3399, 3514);

                        object
                        parameter = (DynAbs.Tracing.TraceSender.Conditional_F1(1670, 3418, 3439) || ((f_1670_3418_3431(parameters, i) == null && DynAbs.Tracing.TraceSender.Conditional_F2(1670, 3442, 3446)) || DynAbs.Tracing.TraceSender.Conditional_F3(1670, 3449, 3513))) ? null : f_1670_3449_3513(f_1670_3480_3493(parameters, i), parameterTypes[i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3532, 3565);

                        f_1670_3532_3564(decodedParameters, parameter);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1670, 1, 257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1670, 1, 257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3596, 3631);

                return f_1670_3603_3630(decodedParameters);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 2876, 3642);

                object
                f_1670_3092_3121(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 3092, 3121);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1670_3169_3187()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 3169, 3187);
                    return return_v;
                }


                int
                f_1670_3213_3229(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 3213, 3229);
                    return return_v;
                }


                int
                f_1670_3233_3254(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 3233, 3254);
                    return return_v;
                }


                int
                f_1670_3202_3309(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 3202, 3309);
                    return 0;
                }


                int
                f_1670_3344_3360(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 3344, 3360);
                    return return_v;
                }


                object
                f_1670_3418_3431(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 3418, 3431);
                    return return_v;
                }


                object
                f_1670_3480_3493(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 3480, 3493);
                    return return_v;
                }


                object
                f_1670_3449_3513(object
                obj, System.Type
                type)
                {
                    var return_v = RemoteHostEncoder.DecodeObject(obj, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 3449, 3513);
                    return return_v;
                }


                int
                f_1670_3532_3564(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 3532, 3564);
                    return 0;
                }


                object[]
                f_1670_3603_3630(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 3603, 3630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 2876, 3642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 2876, 3642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSObject Encode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 3722, 4406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3823, 3877);

                PSObject
                data = f_1670_3839_3876()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 3946, 4005);

                PSObject
                parametersPSObject = f_1670_3976_4004(f_1670_3993_4003())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 4078, 4157);

                f_1670_4078_4156(f_1670_4078_4093(data), f_1670_4098_4155(RemoteDataNameStrings.CallId, _callId));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 4171, 4253);

                f_1670_4171_4252(f_1670_4171_4186(data), f_1670_4191_4251(RemoteDataNameStrings.MethodId, f_1670_4242_4250()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 4267, 4367);

                f_1670_4267_4366(f_1670_4267_4282(data), f_1670_4287_4365(RemoteDataNameStrings.MethodParameters, parametersPSObject));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 4383, 4395);

                return data;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 3722, 4406);

                System.Management.Automation.PSObject
                f_1670_3839_3876()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 3839, 3876);
                    return return_v;
                }


                object[]
                f_1670_3993_4003()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 3993, 4003);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1670_3976_4004(object[]
                parameters)
                {
                    var return_v = EncodeParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 3976, 4004);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1670_4078_4093(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 4078, 4093);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1670_4098_4155(string
                name, long
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 4098, 4155);
                    return return_v;
                }


                int
                f_1670_4078_4156(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 4078, 4156);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1670_4171_4186(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 4171, 4186);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1670_4242_4250()
                {
                    var return_v = MethodId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 4242, 4250);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1670_4191_4251(string
                name, System.Management.Automation.Remoting.RemoteHostMethodId
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 4191, 4251);
                    return return_v;
                }


                int
                f_1670_4171_4252(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 4171, 4252);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1670_4267_4282(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 4267, 4282);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1670_4287_4365(string
                name, System.Management.Automation.PSObject
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 4287, 4365);
                    return return_v;
                }


                int
                f_1670_4267_4366(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 4267, 4366);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 3722, 4406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 3722, 4406);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteHostCall Decode(PSObject data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 4486, 5462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 4563, 4613);

                f_1670_4563_4612(data != null, "Expected data != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 4679, 4768);

                long
                callId = f_1670_4693_4767(data, RemoteDataNameStrings.CallId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 4782, 4901);

                PSObject
                parametersPSObject = f_1670_4812_4900(data, RemoteDataNameStrings.MethodParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 4915, 5036);

                RemoteHostMethodId
                methodId = f_1670_4945_5035(data, RemoteDataNameStrings.MethodId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 5112, 5184);

                RemoteHostMethodInfo
                methodInfo = f_1670_5146_5183(methodId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 5239, 5325);

                object[]
                parameters = f_1670_5261_5324(parametersPSObject, f_1670_5298_5323(methodInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 5395, 5451);

                return f_1670_5402_5450(callId, methodId, parameters);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 4486, 5462);

                int
                f_1670_4563_4612(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 4563, 4612);
                    return 0;
                }


                long
                f_1670_4693_4767(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<long>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 4693, 4767);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1670_4812_4900(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<PSObject>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 4812, 4900);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1670_4945_5035(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<RemoteHostMethodId>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 4945, 5035);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1670_5146_5183(System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = RemoteHostMethodInfo.LookUp(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 5146, 5183);
                    return return_v;
                }


                System.Type[]
                f_1670_5298_5323(System.Management.Automation.Remoting.RemoteHostMethodInfo
                this_param)
                {
                    var return_v = this_param.ParameterTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 5298, 5323);
                    return return_v;
                }


                object[]
                f_1670_5261_5324(System.Management.Automation.PSObject
                parametersPSObject, System.Type[]
                parameterTypes)
                {
                    var return_v = DecodeParameters(parametersPSObject, parameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 5261, 5324);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostCall
                f_1670_5402_5450(long
                callId, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostCall(callId, methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 5402, 5450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 4486, 5462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 4486, 5462);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsVoidMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 5601, 5698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 5637, 5683);

                    return f_1670_5644_5666(_methodInfo) == typeof(void);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 5601, 5698);

                    System.Type
                    f_1670_5644_5666(System.Management.Automation.Remoting.RemoteHostMethodInfo
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 5644, 5666);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 5550, 5709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 5550, 5709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void ExecuteVoidMethod(PSHost clientHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 5802, 6702);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 6010, 6088) || true) && (clientHost == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 6010, 6088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 6066, 6073);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 6010, 6088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 6104, 6148);

                RemoteRunspace
                remoteRunspaceToClose = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 6162, 6309) || true) && (f_1670_6166_6199(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 6162, 6309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 6233, 6294);

                    remoteRunspaceToClose = f_1670_6257_6293(this, clientHost);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 6162, 6309);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 6361, 6419);

                    object
                    targetObject = f_1670_6383_6418(this, clientHost)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 6437, 6483);

                    f_1670_6437_6482(f_1670_6437_6449(), targetObject, f_1670_6471_6481());
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1670, 6512, 6691);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 6552, 6676) || true) && (remoteRunspaceToClose != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 6552, 6676);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 6627, 6657);

                        f_1670_6627_6656(remoteRunspaceToClose);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 6552, 6676);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1670, 6512, 6691);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 5802, 6702);

                bool
                f_1670_6166_6199(System.Management.Automation.Remoting.RemoteHostCall
                this_param)
                {
                    var return_v = this_param.IsSetShouldExitOrPopRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 6166, 6199);
                    return return_v;
                }


                System.Management.Automation.RemoteRunspace
                f_1670_6257_6293(System.Management.Automation.Remoting.RemoteHostCall
                this_param, System.Management.Automation.Host.PSHost
                clientHost)
                {
                    var return_v = this_param.GetRemoteRunspaceToClose(clientHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 6257, 6293);
                    return return_v;
                }


                object
                f_1670_6383_6418(System.Management.Automation.Remoting.RemoteHostCall
                this_param, System.Management.Automation.Host.PSHost
                host)
                {
                    var return_v = this_param.SelectTargetObject(host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 6383, 6418);
                    return return_v;
                }


                System.Reflection.MethodBase
                f_1670_6437_6449()
                {
                    var return_v = MyMethodBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 6437, 6449);
                    return return_v;
                }


                object[]
                f_1670_6471_6481()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 6471, 6481);
                    return return_v;
                }


                object?
                f_1670_6437_6482(System.Reflection.MethodBase
                this_param, object
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 6437, 6482);
                    return return_v;
                }


                int
                f_1670_6627_6656(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 6627, 6656);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 5802, 6702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 5802, 6702);
            }
        }

        private RemoteRunspace GetRemoteRunspaceToClose(PSHost clientHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 6804, 7649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 7045, 7130);

                IHostSupportsInteractiveSession
                host = clientHost as IHostSupportsInteractiveSession
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 7144, 7247) || true) && (host == null || (DynAbs.Tracing.TraceSender.Expression_False(1670, 7148, 7186) || f_1670_7164_7186_M(!host.IsRunspacePushed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 7144, 7247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 7220, 7232);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 7144, 7247);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 7305, 7369);

                RemoteRunspace
                remoteRunspace = f_1670_7337_7350(host) as RemoteRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 7383, 7506) || true) && (remoteRunspace == null || (DynAbs.Tracing.TraceSender.Expression_False(1670, 7387, 7445) || f_1670_7413_7445_M(!remoteRunspace.ShouldCloseOnPop)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 7383, 7506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 7479, 7491);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 7383, 7506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 7616, 7638);

                return remoteRunspace;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 6804, 7649);

                bool
                f_1670_7164_7186_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 7164, 7186);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1670_7337_7350(System.Management.Automation.Host.IHostSupportsInteractiveSession
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 7337, 7350);
                    return return_v;
                }


                bool
                f_1670_7413_7445_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 7413, 7445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 6804, 7649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 6804, 7649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodBase MyMethodBase
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 7793, 7945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 7829, 7930);

                    return (MethodBase)f_1670_7848_7929(f_1670_7848_7873(_methodInfo), f_1670_7884_7900(_methodInfo), f_1670_7902_7928(_methodInfo));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 7793, 7945);

                    System.Type
                    f_1670_7848_7873(System.Management.Automation.Remoting.RemoteHostMethodInfo
                    this_param)
                    {
                        var return_v = this_param.InterfaceType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 7848, 7873);
                        return return_v;
                    }


                    string
                    f_1670_7884_7900(System.Management.Automation.Remoting.RemoteHostMethodInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 7884, 7900);
                        return return_v;
                    }


                    System.Type[]
                    f_1670_7902_7928(System.Management.Automation.Remoting.RemoteHostMethodInfo
                    this_param)
                    {
                        var return_v = this_param.ParameterTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 7902, 7928);
                        return return_v;
                    }


                    System.Reflection.MethodInfo?
                    f_1670_7848_7929(System.Type
                    this_param, string
                    name, System.Type[]
                    types)
                    {
                        var return_v = this_param.GetMethod(name, types);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 7848, 7929);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 7737, 7956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 7737, 7956);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal RemoteHostResponse ExecuteNonVoidMethod(PSHost clientHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 8053, 8632);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 8278, 8405) || true) && (clientHost == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 8278, 8405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 8334, 8390);

                    throw f_1670_8340_8389();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 8278, 8405);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 8421, 8479);

                object
                targetObject = f_1670_8443_8478(this, clientHost)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 8493, 8581);

                RemoteHostResponse
                remoteHostResponse = f_1670_8533_8580(this, targetObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 8595, 8621);

                return remoteHostResponse;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 8053, 8632);

                System.Exception
                f_1670_8340_8389()
                {
                    var return_v = RemoteHostExceptions.NewNullClientHostException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 8340, 8389);
                    return return_v;
                }


                object
                f_1670_8443_8478(System.Management.Automation.Remoting.RemoteHostCall
                this_param, System.Management.Automation.Host.PSHost
                host)
                {
                    var return_v = this_param.SelectTargetObject(host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 8443, 8478);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostResponse
                f_1670_8533_8580(System.Management.Automation.Remoting.RemoteHostCall
                this_param, object
                instance)
                {
                    var return_v = this_param.ExecuteNonVoidMethodOnObject(instance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 8533, 8580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 8053, 8632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 8053, 8632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RemoteHostResponse ExecuteNonVoidMethodOnObject(object instance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 8739, 9786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 8899, 8926);

                Exception
                exception = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 8940, 8966);

                object
                returnValue = null
                ;

                // Invoke the method and store its return values.
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 9081, 9339) || true) && (f_1670_9085_9093() == RemoteHostMethodId.GetBufferContents)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 9081, 9339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 9175, 9320);

                        throw f_1670_9181_9319(f_1670_9218_9268(), f_1670_9295_9318(_computerName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 9081, 9339);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 9359, 9415);

                    returnValue = f_1670_9373_9414(f_1670_9373_9385(), instance, f_1670_9403_9413());
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1670, 9444, 9593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 9549, 9578);

                    exception = f_1670_9561_9577(e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1670, 9444, 9593);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 9702, 9775);

                return f_1670_9709_9774(_callId, f_1670_9741_9749(), returnValue, exception);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 8739, 9786);

                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1670_9085_9093()
                {
                    var return_v = MethodId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 9085, 9093);
                    return return_v;
                }


                string
                f_1670_9218_9268()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostGetBufferContents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 9218, 9268);
                    return return_v;
                }


                string
                f_1670_9295_9318(string
                this_param)
                {
                    var return_v = this_param.ToUpper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 9295, 9318);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1670_9181_9319(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 9181, 9319);
                    return return_v;
                }


                System.Reflection.MethodBase
                f_1670_9373_9385()
                {
                    var return_v = MyMethodBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 9373, 9385);
                    return return_v;
                }


                object[]
                f_1670_9403_9413()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 9403, 9413);
                    return return_v;
                }


                object?
                f_1670_9373_9414(System.Reflection.MethodBase
                this_param, object
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 9373, 9414);
                    return return_v;
                }


                System.Exception
                f_1670_9561_9577(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 9561, 9577);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1670_9741_9749()
                {
                    var return_v = MethodId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 9741, 9749);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostResponse
                f_1670_9709_9774(long
                callId, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object
                returnValue, System.Exception
                exception)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostResponse(callId, methodId, returnValue, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 9709, 9774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 8739, 9786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 8739, 9786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object SelectTargetObject(PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 9912, 10665);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 9983, 10036) || true) && (host == null || (DynAbs.Tracing.TraceSender.Expression_False(1670, 9987, 10018) || f_1670_10003_10010(host) == null))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 9983, 10036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10022, 10034);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 9983, 10036);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10052, 10117) || true) && (f_1670_10056_10081(_methodInfo) == typeof(PSHost))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 10052, 10117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10103, 10115);

                    return host;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 10052, 10117);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10133, 10223) || true) && (f_1670_10137_10162(_methodInfo) == typeof(IHostSupportsInteractiveSession))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 10133, 10223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10209, 10221);

                    return host;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 10133, 10223);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10239, 10320) || true) && (f_1670_10243_10268(_methodInfo) == typeof(PSHostUserInterface))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 10239, 10320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10303, 10318);

                    return f_1670_10310_10317(host);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 10239, 10320);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10336, 10436) || true) && (f_1670_10340_10365(_methodInfo) == typeof(IHostUISupportsMultipleChoiceSelection))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 10336, 10436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10419, 10434);

                    return f_1670_10426_10433(host);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 10336, 10436);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10452, 10542) || true) && (f_1670_10456_10481(_methodInfo) == typeof(PSHostRawUserInterface))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 10452, 10542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10519, 10540);

                    return f_1670_10526_10539(f_1670_10526_10533(host));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 10452, 10542);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10558, 10654);

                throw f_1670_10564_10653(f_1670_10616_10652(f_1670_10616_10641(_methodInfo)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 9912, 10665);

                System.Management.Automation.Host.PSHostUserInterface
                f_1670_10003_10010(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10003, 10010);
                    return return_v;
                }


                System.Type
                f_1670_10056_10081(System.Management.Automation.Remoting.RemoteHostMethodInfo
                this_param)
                {
                    var return_v = this_param.InterfaceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10056, 10081);
                    return return_v;
                }


                System.Type
                f_1670_10137_10162(System.Management.Automation.Remoting.RemoteHostMethodInfo
                this_param)
                {
                    var return_v = this_param.InterfaceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10137, 10162);
                    return return_v;
                }


                System.Type
                f_1670_10243_10268(System.Management.Automation.Remoting.RemoteHostMethodInfo
                this_param)
                {
                    var return_v = this_param.InterfaceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10243, 10268);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1670_10310_10317(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10310, 10317);
                    return return_v;
                }


                System.Type
                f_1670_10340_10365(System.Management.Automation.Remoting.RemoteHostMethodInfo
                this_param)
                {
                    var return_v = this_param.InterfaceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10340, 10365);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1670_10426_10433(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10426, 10433);
                    return return_v;
                }


                System.Type
                f_1670_10456_10481(System.Management.Automation.Remoting.RemoteHostMethodInfo
                this_param)
                {
                    var return_v = this_param.InterfaceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10456, 10481);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1670_10526_10533(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10526, 10533);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostRawUserInterface
                f_1670_10526_10539(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.RawUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10526, 10539);
                    return return_v;
                }


                System.Type
                f_1670_10616_10641(System.Management.Automation.Remoting.RemoteHostMethodInfo
                this_param)
                {
                    var return_v = this_param.InterfaceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10616, 10641);
                    return return_v;
                }


                string
                f_1670_10616_10652(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 10616, 10652);
                    return return_v;
                }


                System.Exception
                f_1670_10564_10653(string
                className)
                {
                    var return_v = RemoteHostExceptions.NewUnknownTargetClassException(className);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 10564, 10653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 9912, 10665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 9912, 10665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsSetShouldExit
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 10811, 10914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 10847, 10899);

                    return f_1670_10854_10862() == RemoteHostMethodId.SetShouldExit;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 10811, 10914);

                    System.Management.Automation.Remoting.RemoteHostMethodId
                    f_1670_10854_10862()
                    {
                        var return_v = MethodId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 10854, 10862);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 10757, 10925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 10757, 10925);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsSetShouldExitOrPopRunspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 11100, 11291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 11136, 11276);

                    return
                    f_1670_11164_11172() == RemoteHostMethodId.SetShouldExit || (DynAbs.Tracing.TraceSender.Expression_False(1670, 11164, 11275) || f_1670_11233_11241() == RemoteHostMethodId.PopRunspace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 11100, 11291);

                    System.Management.Automation.Remoting.RemoteHostMethodId
                    f_1670_11164_11172()
                    {
                        var return_v = MethodId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 11164, 11172);
                        return return_v;
                    }


                    System.Management.Automation.Remoting.RemoteHostMethodId
                    f_1670_11233_11241()
                    {
                        var return_v = MethodId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 11233, 11241);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 11033, 11302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 11033, 11302);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Collection<RemoteHostCall> PerformSecurityChecksOnHostMessage(string computerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 11875, 16742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 11991, 12116);

                f_1670_11991_12115(!f_1670_12003_12037(computerName), "Computer Name must be passed for use in warning messages");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 12130, 12159);

                _computerName = computerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 12173, 12253);

                Collection<RemoteHostCall>
                prerequisiteCalls = f_1670_12220_12252()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 12550, 16690) || true) && (f_1670_12554_12562() == RemoteHostMethodId.PromptForCredential1 || (DynAbs.Tracing.TraceSender.Expression_False(1670, 12554, 12677) || f_1670_12626_12634() == RemoteHostMethodId.PromptForCredential2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 12550, 16690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 12774, 12836);

                    string
                    modifiedCaption = f_1670_12799_12835(this, f_1670_12821_12831()[0])
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 12919, 12995);

                    string
                    modifiedMessage = f_1670_12944_12994(this, f_1670_12966_12976()[1], computerName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 13015, 13047);

                    f_1670_13015_13025()[0] = modifiedCaption;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 13065, 13097);

                    f_1670_13065_13075()[1] = modifiedMessage;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 12550, 16690);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 12550, 16690);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 13556, 16690) || true) && (f_1670_13560_13568() == RemoteHostMethodId.Prompt)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 13556, 16690);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 13735, 15527) || true) && (f_1670_13739_13756(f_1670_13739_13749()) == 3)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 13735, 15527);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 13803, 13914);

                            Collection<FieldDescription>
                            fieldDescs =
                                                    (Collection<FieldDescription>)f_1670_13900_13910()[2]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 13938, 13968);

                            bool
                            havePSCredential = false
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 13992, 14969);
                                foreach (FieldDescription fieldDesc in f_1670_14031_14041_I(fieldDescs))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 13992, 14969);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 14091, 14125);

                                    fieldDesc.IsFromRemoteHost = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 14153, 14220);

                                    Type
                                    fieldType = f_1670_14170_14219(fieldDesc)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 14246, 14946) || true) && (fieldType != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 14246, 14946);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 14325, 14919) || true) && (fieldType == typeof(PSCredential))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 14325, 14919);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 14428, 14452);

                                            havePSCredential = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 14486, 14530);

                                            fieldDesc.ModifiedByRemotingProtocol = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 14325, 14919);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 14325, 14919);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 14596, 14919) || true) && (fieldType == typeof(System.Security.SecureString))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 14596, 14919);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 14715, 14888);

                                                f_1670_14715_14887(prerequisiteCalls, f_1670_14737_14886(this, computerName, f_1670_14828_14885()));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 14596, 14919);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 14325, 14919);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 14246, 14946);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 13992, 14969);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1670, 1, 978);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1670, 1, 978);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 14993, 15508) || true) && (havePSCredential)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 14993, 15508);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 15132, 15194);

                                string
                                modifiedCaption = f_1670_15157_15193(this, f_1670_15179_15189()[0])
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 15291, 15367);

                                string
                                modifiedMessage = f_1670_15316_15366(this, f_1670_15338_15348()[1], computerName)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 15395, 15427);

                                f_1670_15395_15405()[0] = modifiedCaption;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 15453, 15485);

                                f_1670_15453_15463()[1] = modifiedMessage;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 14993, 15508);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 13735, 15527);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 13556, 16690);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 13556, 16690);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 15827, 16690) || true) && (f_1670_15831_15839() == RemoteHostMethodId.ReadLineAsSecureString)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 15827, 16690);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 15918, 16095);

                            f_1670_15918_16094(prerequisiteCalls, f_1670_15940_16093(this, computerName, f_1670_16031_16092()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 15827, 16690);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 15827, 16690);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 16508, 16690) || true) && (f_1670_16512_16520() == RemoteHostMethodId.GetBufferContents)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 16508, 16690);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 16594, 16675);

                                f_1670_16594_16674(prerequisiteCalls, f_1670_16616_16673(this, computerName));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 16508, 16690);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 15827, 16690);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 13556, 16690);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 12550, 16690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 16706, 16731);

                return prerequisiteCalls;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 11875, 16742);

                bool
                f_1670_12003_12037(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 12003, 12037);
                    return return_v;
                }


                int
                f_1670_11991_12115(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 11991, 12115);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
                f_1670_12220_12252()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 12220, 12252);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1670_12554_12562()
                {
                    var return_v = MethodId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 12554, 12562);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1670_12626_12634()
                {
                    var return_v = MethodId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 12626, 12634);
                    return return_v;
                }


                object[]
                f_1670_12821_12831()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 12821, 12831);
                    return return_v;
                }


                string
                f_1670_12799_12835(System.Management.Automation.Remoting.RemoteHostCall
                this_param, object
                caption)
                {
                    var return_v = this_param.ModifyCaption((string)caption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 12799, 12835);
                    return return_v;
                }


                object[]
                f_1670_12966_12976()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 12966, 12976);
                    return return_v;
                }


                string
                f_1670_12944_12994(System.Management.Automation.Remoting.RemoteHostCall
                this_param, object
                message, string
                computerName)
                {
                    var return_v = this_param.ModifyMessage((string)message, computerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 12944, 12994);
                    return return_v;
                }


                object[]
                f_1670_13015_13025()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 13015, 13025);
                    return return_v;
                }


                object[]
                f_1670_13065_13075()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 13065, 13075);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1670_13560_13568()
                {
                    var return_v = MethodId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 13560, 13568);
                    return return_v;
                }


                object[]
                f_1670_13739_13749()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 13739, 13749);
                    return return_v;
                }


                int
                f_1670_13739_13756(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 13739, 13756);
                    return return_v;
                }


                object[]
                f_1670_13900_13910()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 13900, 13910);
                    return return_v;
                }


                System.Type
                f_1670_14170_14219(System.Management.Automation.Host.FieldDescription
                field)
                {
                    var return_v = InternalHostUserInterface.GetFieldType(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 14170, 14219);
                    return return_v;
                }


                string
                f_1670_14828_14885()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostPromptSecureStringPrompt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 14828, 14885);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostCall
                f_1670_14737_14886(System.Management.Automation.Remoting.RemoteHostCall
                this_param, string
                computerName, string
                resourceString)
                {
                    var return_v = this_param.ConstructWarningMessageForSecureString(computerName, resourceString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 14737, 14886);
                    return return_v;
                }


                int
                f_1670_14715_14887(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
                this_param, System.Management.Automation.Remoting.RemoteHostCall
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 14715, 14887);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                f_1670_14031_14041_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 14031, 14041);
                    return return_v;
                }


                object[]
                f_1670_15179_15189()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 15179, 15189);
                    return return_v;
                }


                string
                f_1670_15157_15193(System.Management.Automation.Remoting.RemoteHostCall
                this_param, object
                caption)
                {
                    var return_v = this_param.ModifyCaption((string)caption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 15157, 15193);
                    return return_v;
                }


                object[]
                f_1670_15338_15348()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 15338, 15348);
                    return return_v;
                }


                string
                f_1670_15316_15366(System.Management.Automation.Remoting.RemoteHostCall
                this_param, object
                message, string
                computerName)
                {
                    var return_v = this_param.ModifyMessage((string)message, computerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 15316, 15366);
                    return return_v;
                }


                object[]
                f_1670_15395_15405()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 15395, 15405);
                    return return_v;
                }


                object[]
                f_1670_15453_15463()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 15453, 15463);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1670_15831_15839()
                {
                    var return_v = MethodId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 15831, 15839);
                    return return_v;
                }


                string
                f_1670_16031_16092()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostReadLineAsSecureStringPrompt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 16031, 16092);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostCall
                f_1670_15940_16093(System.Management.Automation.Remoting.RemoteHostCall
                this_param, string
                computerName, string
                resourceString)
                {
                    var return_v = this_param.ConstructWarningMessageForSecureString(computerName, resourceString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 15940, 16093);
                    return return_v;
                }


                int
                f_1670_15918_16094(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
                this_param, System.Management.Automation.Remoting.RemoteHostCall
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 15918, 16094);
                    return 0;
                }


                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1670_16512_16520()
                {
                    var return_v = MethodId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 16512, 16520);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostCall
                f_1670_16616_16673(System.Management.Automation.Remoting.RemoteHostCall
                this_param, string
                computerName)
                {
                    var return_v = this_param.ConstructWarningMessageForGetBufferContents(computerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 16616, 16673);
                    return return_v;
                }


                int
                f_1670_16594_16674(System.Collections.ObjectModel.Collection<System.Management.Automation.Remoting.RemoteHostCall>
                this_param, System.Management.Automation.Remoting.RemoteHostCall
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 16594, 16674);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 11875, 16742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 11875, 16742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ModifyCaption(string caption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 17101, 17619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 17170, 17231);

                string
                pscaption = f_1670_17189_17230()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 17247, 17577) || true) && (!f_1670_17252_17313(caption, pscaption, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 17247, 17577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 17347, 17519);

                    string
                    modifiedCaption = f_1670_17372_17518(f_1670_17441_17508(), caption)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 17539, 17562);

                    return modifiedCaption;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 17247, 17577);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 17593, 17608);

                return caption;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 17101, 17619);

                string
                f_1670_17189_17230()
                {
                    var return_v = CredUI.PromptForCredential_DefaultCaption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 17189, 17230);
                    return return_v;
                }


                bool
                f_1670_17252_17313(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 17252, 17313);
                    return return_v;
                }


                string
                f_1670_17441_17508()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostPromptForCredentialModifiedCaption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 17441, 17508);
                    return return_v;
                }


                string
                f_1670_17372_17518(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 17372, 17518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 17101, 17619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 17101, 17619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ModifyMessage(string message, string computerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 18133, 18523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 18223, 18473);

                string
                modifiedMessage = f_1670_18248_18472(f_1670_18317_18384(), f_1670_18411_18433(computerName), message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 18489, 18512);

                return modifiedMessage;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 18133, 18523);

                string
                f_1670_18317_18384()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostPromptForCredentialModifiedMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 18317, 18384);
                    return return_v;
                }


                string
                f_1670_18411_18433(string
                this_param)
                {
                    var return_v = this_param.ToUpper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 18411, 18433);
                    return return_v;
                }


                string
                f_1670_18248_18472(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 18248, 18472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 18133, 18523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 18133, 18523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RemoteHostCall ConstructWarningMessageForSecureString(string computerName,
                    string resourceString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 19067, 19518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 19210, 19353);

                string
                warning = f_1670_19227_19352(resourceString, f_1670_19329_19351(computerName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 19369, 19507);

                return f_1670_19376_19506(ServerDispatchTable.VoidCallId, RemoteHostMethodId.WriteWarningLine, new object[] { warning });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 19067, 19518);

                string
                f_1670_19329_19351(string
                this_param)
                {
                    var return_v = this_param.ToUpper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 19329, 19351);
                    return return_v;
                }


                string
                f_1670_19227_19352(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 19227, 19352);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostCall
                f_1670_19376_19506(long
                callId, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostCall(callId, methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 19376, 19506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 19067, 19518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 19067, 19518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RemoteHostCall ConstructWarningMessageForGetBufferContents(string computerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 20020, 20476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 20132, 20311);

                string
                warning = f_1670_20149_20310(f_1670_20214_20264(), f_1670_20287_20309(computerName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 20327, 20465);

                return f_1670_20334_20464(ServerDispatchTable.VoidCallId, RemoteHostMethodId.WriteWarningLine, new object[] { warning });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 20020, 20476);

                string
                f_1670_20214_20264()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostGetBufferContents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 20214, 20264);
                    return return_v;
                }


                string
                f_1670_20287_20309(string
                this_param)
                {
                    var return_v = this_param.ToUpper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 20287, 20309);
                    return return_v;
                }


                string
                f_1670_20149_20310(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 20149, 20310);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostCall
                f_1670_20334_20464(long
                callId, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object[]
                parameters)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostCall(callId, methodId, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 20334, 20464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 20020, 20476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 20020, 20476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemoteHostCall()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1670, 623, 20483);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1670, 623, 20483);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 623, 20483);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1670, 623, 20483);

        int
        f_1670_1913_1974(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 1913, 1974);
            return 0;
        }


        System.Management.Automation.Remoting.RemoteHostMethodInfo
        f_1670_2106_2143(System.Management.Automation.Remoting.RemoteHostMethodId
        methodId)
        {
            var return_v = RemoteHostMethodInfo.LookUp(methodId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 2106, 2143);
            return return_v;
        }

    }
    internal class RemoteHostResponse
    {
        private long _callId;

        internal long CallId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 21295, 21361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 21331, 21346);

                    return _callId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 21295, 21361);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 21250, 21372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 21250, 21372);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private RemoteHostMethodId _methodId;

        private object _returnValue;

        private Exception _exception;

        internal RemoteHostResponse(long callId, RemoteHostMethodId methodId, object returnValue, Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1670, 21826, 22102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 21161, 21168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 21482, 21491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 21593, 21605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 21707, 21717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 21961, 21978);

                _callId = callId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 21992, 22013);

                _methodId = methodId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 22027, 22054);

                _returnValue = returnValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 22068, 22091);

                _exception = exception;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1670, 21826, 22102);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 21826, 22102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 21826, 22102);
            }
        }

        internal object SimulateExecution()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 22194, 22389);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 22254, 22342) || true) && (_exception != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 22254, 22342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 22310, 22327);

                    throw _exception;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 22254, 22342);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 22358, 22378);

                return _returnValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 22194, 22389);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 22194, 22389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 22194, 22389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void EncodeAndAddReturnValue(PSObject psObject, object returnValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 22490, 22865);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 22653, 22689) || true) && (returnValue == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 22653, 22689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 22680, 22687);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 22653, 22689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 22749, 22854);

                f_1670_22749_22853(psObject, RemoteDataNameStrings.MethodReturnValue, returnValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 22490, 22865);

                int
                f_1670_22749_22853(System.Management.Automation.PSObject
                psObject, string
                propertyName, object
                propertyValue)
                {
                    RemoteHostEncoder.EncodeAndAddAsProperty(psObject, propertyName, propertyValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 22749, 22853);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 22490, 22865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 22490, 22865);
            }
        }

        private static object DecodeReturnValue(PSObject psObject, Type returnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 22958, 23224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 23058, 23180);

                object
                returnValue = f_1670_23079_23179(psObject, RemoteDataNameStrings.MethodReturnValue, returnType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 23194, 23213);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 22958, 23224);

                object
                f_1670_23079_23179(System.Management.Automation.PSObject
                psObject, string
                propertyName, System.Type
                propertyValueType)
                {
                    var return_v = RemoteHostEncoder.DecodePropertyValue(psObject, propertyName, propertyValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 23079, 23179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 22958, 23224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 22958, 23224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void EncodeAndAddException(PSObject psObject, Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 23322, 23540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 23428, 23529);

                f_1670_23428_23528(psObject, RemoteDataNameStrings.MethodException, exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 23322, 23540);

                int
                f_1670_23428_23528(System.Management.Automation.PSObject
                psObject, string
                propertyName, System.Exception
                propertyValue)
                {
                    RemoteHostEncoder.EncodeAndAddAsProperty(psObject, propertyName, (object)propertyValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 23428, 23528);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 23322, 23540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 23322, 23540);
            }
        }

        private static Exception DecodeException(PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 23630, 24039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 23714, 23836);

                object
                result = f_1670_23730_23835(psObject, RemoteDataNameStrings.MethodException, typeof(Exception))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 23850, 23886) || true) && (result == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 23850, 23886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 23872, 23884);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 23850, 23886);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 23902, 23956) || true) && (result is Exception)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1670, 23902, 23956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 23929, 23954);

                    return (Exception)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1670, 23902, 23956);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 23972, 24028);

                throw f_1670_23978_24027();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 23630, 24039);

                object
                f_1670_23730_23835(System.Management.Automation.PSObject
                psObject, string
                propertyName, System.Type
                propertyValueType)
                {
                    var return_v = RemoteHostEncoder.DecodePropertyValue(psObject, propertyName, propertyValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 23730, 23835);
                    return return_v;
                }


                System.Exception
                f_1670_23978_24027()
                {
                    var return_v = RemoteHostExceptions.NewDecodingFailedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 23978, 24027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 23630, 24039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 23630, 24039);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSObject Encode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1670, 24119, 24642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 24249, 24303);

                PSObject
                data = f_1670_24265_24302()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 24317, 24361);

                f_1670_24317_24360(data, _returnValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 24375, 24415);

                f_1670_24375_24414(data, _exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 24429, 24508);

                f_1670_24429_24507(f_1670_24429_24444(data), f_1670_24449_24506(RemoteDataNameStrings.CallId, _callId));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 24522, 24605);

                f_1670_24522_24604(f_1670_24522_24537(data), f_1670_24542_24603(RemoteDataNameStrings.MethodId, _methodId));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 24619, 24631);

                return data;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1670, 24119, 24642);

                System.Management.Automation.PSObject
                f_1670_24265_24302()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 24265, 24302);
                    return return_v;
                }


                int
                f_1670_24317_24360(System.Management.Automation.PSObject
                psObject, object
                returnValue)
                {
                    EncodeAndAddReturnValue(psObject, returnValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 24317, 24360);
                    return 0;
                }


                int
                f_1670_24375_24414(System.Management.Automation.PSObject
                psObject, System.Exception
                exception)
                {
                    EncodeAndAddException(psObject, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 24375, 24414);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1670_24429_24444(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 24429, 24444);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1670_24449_24506(string
                name, long
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 24449, 24506);
                    return return_v;
                }


                int
                f_1670_24429_24507(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 24429, 24507);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1670_24522_24537(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 24522, 24537);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1670_24542_24603(string
                name, System.Management.Automation.Remoting.RemoteHostMethodId
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 24542, 24603);
                    return return_v;
                }


                int
                f_1670_24522_24604(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 24522, 24604);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 24119, 24642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 24119, 24642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RemoteHostResponse Decode(PSObject data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 24722, 25608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 24803, 24853);

                f_1670_24803_24852(data != null, "Expected data != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 24919, 25008);

                long
                callId = f_1670_24933_25007(data, RemoteDataNameStrings.CallId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 25022, 25143);

                RemoteHostMethodId
                methodId = f_1670_25052_25142(data, RemoteDataNameStrings.MethodId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 25218, 25290);

                RemoteHostMethodInfo
                methodInfo = f_1670_25252_25289(methodId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 25304, 25372);

                object
                returnValue = f_1670_25325_25371(data, f_1670_25349_25370(methodInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 25386, 25430);

                Exception
                exception = f_1670_25408_25429(data)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 25525, 25597);

                return f_1670_25532_25596(callId, methodId, returnValue, exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 24722, 25608);

                int
                f_1670_24803_24852(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 24803, 24852);
                    return 0;
                }


                long
                f_1670_24933_25007(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<long>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 24933, 25007);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodId
                f_1670_25052_25142(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<RemoteHostMethodId>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 25052, 25142);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1670_25252_25289(System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = RemoteHostMethodInfo.LookUp(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 25252, 25289);
                    return return_v;
                }


                System.Type
                f_1670_25349_25370(System.Management.Automation.Remoting.RemoteHostMethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 25349, 25370);
                    return return_v;
                }


                object
                f_1670_25325_25371(System.Management.Automation.PSObject
                psObject, System.Type
                returnType)
                {
                    var return_v = DecodeReturnValue(psObject, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 25325, 25371);
                    return return_v;
                }


                System.Exception
                f_1670_25408_25429(System.Management.Automation.PSObject
                psObject)
                {
                    var return_v = DecodeException(psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 25408, 25429);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostResponse
                f_1670_25532_25596(long
                callId, System.Management.Automation.Remoting.RemoteHostMethodId
                methodId, object
                returnValue, System.Exception
                exception)
                {
                    var return_v = new System.Management.Automation.Remoting.RemoteHostResponse(callId, methodId, returnValue, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 25532, 25596);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 24722, 25608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 24722, 25608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemoteHostResponse()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1670, 21029, 25615);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1670, 21029, 25615);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 21029, 25615);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1670, 21029, 25615);
    }
    internal static class RemoteHostExceptions
    {
        internal static Exception NewRemoteRunspaceDoesNotSupportPushRunspaceException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 25884, 26228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 25989, 26143);

                string
                resourceString = f_1670_26013_26142(f_1670_26078_26141())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 26157, 26217);

                return f_1670_26164_26216(resourceString);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 25884, 26228);

                string
                f_1670_26078_26141()
                {
                    var return_v = RemotingErrorIdStrings.RemoteRunspaceDoesNotSupportPushRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 26078, 26141);
                    return return_v;
                }


                string
                f_1670_26013_26142(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 26013, 26142);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1670_26164_26216(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 26164, 26216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 25884, 26228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 25884, 26228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception NewDecodingFailedException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 26331, 26633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 26410, 26548);

                string
                resourceString = f_1670_26434_26547(f_1670_26499_26546())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 26562, 26622);

                return f_1670_26569_26621(resourceString);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 26331, 26633);

                string
                f_1670_26499_26546()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostDecodingFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 26499, 26546);
                    return return_v;
                }


                string
                f_1670_26434_26547(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 26434, 26547);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1670_26569_26621(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 26569, 26621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 26331, 26633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 26331, 26633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception NewNotImplementedException(RemoteHostMethodId methodId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 26736, 27207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 26842, 26914);

                RemoteHostMethodInfo
                methodInfo = f_1670_26876_26913(methodId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 26928, 27089);

                string
                resourceString = f_1670_26952_27088(f_1670_27017_27070(), f_1670_27072_27087(methodInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 27103, 27196);

                return f_1670_27110_27195(resourceString, f_1670_27163_27194());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 26736, 27207);

                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1670_26876_26913(System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = RemoteHostMethodInfo.LookUp(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 26876, 26913);
                    return return_v;
                }


                string
                f_1670_27017_27070()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostMethodNotImplemented;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 27017, 27070);
                    return return_v;
                }


                string
                f_1670_27072_27087(System.Management.Automation.Remoting.RemoteHostMethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 27072, 27087);
                    return return_v;
                }


                string
                f_1670_26952_27088(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 26952, 27088);
                    return return_v;
                }


                System.Management.Automation.PSNotImplementedException
                f_1670_27163_27194()
                {
                    var return_v = new System.Management.Automation.PSNotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 27163, 27194);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1670_27110_27195(string
                message, System.Management.Automation.PSNotImplementedException
                innerException)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 27110, 27195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 26736, 27207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 26736, 27207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception NewRemoteHostCallFailedException(RemoteHostMethodId methodId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 27318, 27752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 27430, 27502);

                RemoteHostMethodInfo
                methodInfo = f_1670_27464_27501(methodId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 27516, 27667);

                string
                resourceString = f_1670_27540_27666(f_1670_27605_27648(), f_1670_27650_27665(methodInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 27681, 27741);

                return f_1670_27688_27740(resourceString);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 27318, 27752);

                System.Management.Automation.Remoting.RemoteHostMethodInfo
                f_1670_27464_27501(System.Management.Automation.Remoting.RemoteHostMethodId
                methodId)
                {
                    var return_v = RemoteHostMethodInfo.LookUp(methodId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 27464, 27501);
                    return return_v;
                }


                string
                f_1670_27605_27648()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostCallFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 27605, 27648);
                    return return_v;
                }


                string
                f_1670_27650_27665(System.Management.Automation.Remoting.RemoteHostMethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 27650, 27665);
                    return return_v;
                }


                string
                f_1670_27540_27666(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 27540, 27666);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1670_27688_27740(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 27688, 27740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 27318, 27752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 27318, 27752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception NewDecodingErrorForErrorRecordException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 27871, 28070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 27963, 28059);

                return f_1670_27970_28058(f_1670_28007_28057());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 27871, 28070);

                string
                f_1670_28007_28057()
                {
                    var return_v = RemotingErrorIdStrings.DecodingErrorForErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 28007, 28057);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1670_27970_28058(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 27970, 28058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 27871, 28070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 27871, 28070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception NewRemoteHostDataEncodingNotSupportedException(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 28197, 28535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 28305, 28355);

                f_1670_28305_28354(type != null, "Expected type != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 28369, 28524);

                return f_1670_28376_28523(f_1670_28431_28488(), f_1670_28507_28522(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 28197, 28535);

                int
                f_1670_28305_28354(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 28305, 28354);
                    return 0;
                }


                string
                f_1670_28431_28488()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostDataEncodingNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 28431, 28488);
                    return return_v;
                }


                string
                f_1670_28507_28522(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 28507, 28522);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1670_28376_28523(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 28376, 28523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 28197, 28535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 28197, 28535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception NewRemoteHostDataDecodingNotSupportedException(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 28662, 29000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 28770, 28820);

                f_1670_28770_28819(type != null, "Expected type != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 28834, 28989);

                return f_1670_28841_28988(f_1670_28896_28953(), f_1670_28972_28987(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 28662, 29000);

                int
                f_1670_28770_28819(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 28770, 28819);
                    return 0;
                }


                string
                f_1670_28896_28953()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostDataDecodingNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 28896, 28953);
                    return return_v;
                }


                string
                f_1670_28972_28987(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 28972, 28987);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1670_28841_28988(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 28841, 28988);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 28662, 29000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 28662, 29000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception NewUnknownTargetClassException(string className)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 29108, 29390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 29207, 29267);

                f_1670_29207_29266(className != null, "Expected className != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 29281, 29379);

                return f_1670_29288_29378(f_1670_29325_29366(), className);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 29108, 29390);

                int
                f_1670_29207_29266(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 29207, 29266);
                    return 0;
                }


                string
                f_1670_29325_29366()
                {
                    var return_v = RemotingErrorIdStrings.UnknownTargetClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 29325, 29366);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1670_29288_29378(string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 29288, 29378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 29108, 29390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 29108, 29390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Exception NewNullClientHostException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1670, 29402, 29585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1670, 29481, 29574);

                return f_1670_29488_29573(f_1670_29525_29572());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1670, 29402, 29585);

                string
                f_1670_29525_29572()
                {
                    var return_v = RemotingErrorIdStrings.RemoteHostNullClientHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1670, 29525, 29572);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSRemotingDataStructureException
                f_1670_29488_29573(string
                message)
                {
                    var return_v = new System.Management.Automation.Remoting.PSRemotingDataStructureException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1670, 29488, 29573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1670, 29402, 29585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 29402, 29585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RemoteHostExceptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1670, 25703, 29592);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1670, 25703, 29592);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1670, 25703, 29592);
        }

    }
}
