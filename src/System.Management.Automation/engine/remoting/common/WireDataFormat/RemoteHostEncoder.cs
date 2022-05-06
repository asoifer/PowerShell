// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation.Host;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class RemoteHostEncoder
    {
        private static bool IsKnownType(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 1230, 1415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 1297, 1368);

                TypeSerializationInfo
                info = f_1671_1326_1367(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 1382, 1404);

                return (info != null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 1230, 1415);

                System.Management.Automation.TypeSerializationInfo
                f_1671_1326_1367(System.Type
                type)
                {
                    var return_v = KnownTypes.GetTypeSerializationInfo(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 1326, 1367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 1230, 1415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 1230, 1415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsEncodingAllowedForClassOrStruct(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 1528, 2326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 1701, 2315);

                return
                                // Struct types.
                                type == typeof(KeyInfo) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 1759, 1830) || type == typeof(Coordinates)) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 1759, 1871) || type == typeof(Size)) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 1759, 1918) || type == typeof(BufferCell)) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 1759, 1964) || type == typeof(Rectangle)) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 1759, 2050) ||
                                // Class types.
                                type == typeof(ProgressRecord)) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 1759, 2103) || type == typeof(FieldDescription)) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 1759, 2157) || type == typeof(ChoiceDescription)) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 1759, 2202) || type == typeof(HostInfo)) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 1759, 2254) || type == typeof(HostDefaultData)) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 1759, 2314) || type == typeof(RemoteSessionCapability));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 1528, 2326);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 1528, 2326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 1528, 2326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject EncodeClassOrStruct(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 2422, 3234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 2502, 2560);

                PSObject
                psObject = f_1671_2522_2559()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 2574, 2693);

                FieldInfo[]
                fieldInfos = f_1671_2599_2692(f_1671_2599_2612(obj), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 2777, 3191);
                    foreach (FieldInfo fieldInfo in f_1671_2809_2819_I(fieldInfos))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 2777, 3191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 2853, 2897);

                        object
                        fieldValue = f_1671_2873_2896(fieldInfo, obj)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 2915, 3007) || true) && (fieldValue == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 2915, 3007);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 2979, 2988);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 2915, 3007);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 3027, 3079);

                        object
                        encodedFieldValue = f_1671_3054_3078(fieldValue)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 3097, 3176);

                        f_1671_3097_3175(f_1671_3097_3116(psObject), f_1671_3121_3174(f_1671_3140_3154(fieldInfo), encodedFieldValue));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 2777, 3191);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 415);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 3207, 3223);

                return psObject;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 2422, 3234);

                System.Management.Automation.PSObject
                f_1671_2522_2559()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 2522, 2559);
                    return return_v;
                }


                System.Type
                f_1671_2599_2612(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 2599, 2612);
                    return return_v;
                }


                System.Reflection.FieldInfo[]
                f_1671_2599_2692(System.Type
                this_param, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetFields(bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 2599, 2692);
                    return return_v;
                }


                object?
                f_1671_2873_2896(System.Reflection.FieldInfo
                this_param, object
                obj)
                {
                    var return_v = this_param.GetValue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 2873, 2896);
                    return return_v;
                }


                object
                f_1671_3054_3078(object
                obj)
                {
                    var return_v = EncodeObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 3054, 3078);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_3097_3116(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 3097, 3116);
                    return return_v;
                }


                string
                f_1671_3140_3154(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 3140, 3154);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1671_3121_3174(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 3121, 3174);
                    return return_v;
                }


                int
                f_1671_3097_3175(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 3097, 3175);
                    return 0;
                }


                System.Reflection.FieldInfo[]
                f_1671_2809_2819_I(System.Reflection.FieldInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 2809, 2819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 2422, 3234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 2422, 3234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object DecodeClassOrStruct(PSObject psObject, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 3330, 4237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 3426, 3486);

                object
                obj = f_1671_3439_3485(type)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 3604, 4199);
                    foreach (PSPropertyInfo propertyInfo in f_1671_3644_3663_I(f_1671_3644_3663(psObject)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 3604, 4199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 3697, 3822);

                        FieldInfo
                        fieldInfo = f_1671_3719_3821(type, f_1671_3733_3750(propertyInfo), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 3840, 3932) || true) && (f_1671_3844_3862(propertyInfo) == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 3840, 3932);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 3874, 3930);

                            throw f_1671_3880_3929();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 3840, 3932);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 3952, 4026);

                        object
                        fieldValue = f_1671_3972_4025(f_1671_3985_4003(propertyInfo), f_1671_4005_4024(fieldInfo))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 4044, 4128) || true) && (fieldValue == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 4044, 4128);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 4070, 4126);

                            throw f_1671_4076_4125();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 4044, 4128);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 4148, 4184);

                        f_1671_4148_4183(
                                        fieldInfo, obj, fieldValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 3604, 4199);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 596);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 4215, 4226);

                return obj;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 3330, 4237);

                object
                f_1671_3439_3485(System.Type
                type)
                {
                    var return_v = FormatterServices.GetUninitializedObject(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 3439, 3485);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_3644_3663(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 3644, 3663);
                    return return_v;
                }


                string
                f_1671_3733_3750(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 3733, 3750);
                    return return_v;
                }


                System.Reflection.FieldInfo?
                f_1671_3719_3821(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 3719, 3821);
                    return return_v;
                }


                object
                f_1671_3844_3862(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 3844, 3862);
                    return return_v;
                }


                System.Exception
                f_1671_3880_3929()
                {
                    var return_v = RemoteHostExceptions.NewDecodingFailedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 3880, 3929);
                    return return_v;
                }


                object
                f_1671_3985_4003(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 3985, 4003);
                    return return_v;
                }


                System.Type
                f_1671_4005_4024(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.FieldType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 4005, 4024);
                    return return_v;
                }


                object
                f_1671_3972_4025(object
                obj, System.Type
                type)
                {
                    var return_v = DecodeObject(obj, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 3972, 4025);
                    return return_v;
                }


                System.Exception
                f_1671_4076_4125()
                {
                    var return_v = RemoteHostExceptions.NewDecodingFailedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 4076, 4125);
                    return return_v;
                }


                int
                f_1671_4148_4183(System.Reflection.FieldInfo
                this_param, object
                obj, object
                value)
                {
                    this_param.SetValue(obj, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 4148, 4183);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_3644_3663_I(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 3644, 3663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 3330, 4237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 3330, 4237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsCollection(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 4324, 4493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 4392, 4482);

                return f_1671_4399_4417(type) && (DynAbs.Tracing.TraceSender.Expression_True(1671, 4399, 4481) && f_1671_4421_4481(f_1671_4421_4452(type), typeof(Collection<>)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 4324, 4493);

                bool
                f_1671_4399_4417(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 4399, 4417);
                    return return_v;
                }


                System.Type
                f_1671_4421_4452(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 4421, 4452);
                    return return_v;
                }


                bool
                f_1671_4421_4481(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 4421, 4481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 4324, 4493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 4324, 4493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsGenericIEnumerableOfInt(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 4505, 4642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 4586, 4631);

                return f_1671_4593_4630(type, typeof(IEnumerable<int>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 4505, 4642);

                bool
                f_1671_4593_4630(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 4593, 4630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 4505, 4642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 4505, 4642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject EncodeCollection(IList collection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 4733, 5041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 4816, 4854);

                ArrayList
                arrayList = f_1671_4838_4853()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 4868, 4983);
                    foreach (object obj in f_1671_4891_4901_I(collection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 4868, 4983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 4935, 4968);

                        f_1671_4935_4967(arrayList, f_1671_4949_4966(obj));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 4868, 4983);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 4999, 5030);

                return f_1671_5006_5029(arrayList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 4733, 5041);

                System.Collections.ArrayList
                f_1671_4838_4853()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 4838, 4853);
                    return return_v;
                }


                object
                f_1671_4949_4966(object
                obj)
                {
                    var return_v = EncodeObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 4949, 4966);
                    return return_v;
                }


                int
                f_1671_4935_4967(System.Collections.ArrayList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 4935, 4967);
                    return return_v;
                }


                System.Collections.IList
                f_1671_4891_4901_I(System.Collections.IList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 4891, 4901);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_5006_5029(System.Collections.ArrayList
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 5006, 5029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 4733, 5041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 4733, 5041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IList DecodeCollection(PSObject psObject, Type collectionType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 5132, 5885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 5272, 5331);

                Type[]
                elementTypes = f_1671_5294_5330(collectionType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 5345, 5419);

                f_1671_5345_5418(f_1671_5356_5375(elementTypes) == 1, "Expected elementTypes.Length == 1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 5433, 5468);

                Type
                elementType = elementTypes[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 5546, 5609);

                ArrayList
                arrayList = f_1671_5568_5608(psObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 5623, 5690);

                IList
                collection = (IList)f_1671_5649_5689(collectionType)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 5704, 5840);
                    foreach (object element in f_1671_5731_5740_I(arrayList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 5704, 5840);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 5774, 5825);

                        f_1671_5774_5824(collection, f_1671_5789_5823(element, elementType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 5704, 5840);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 5856, 5874);

                return collection;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 5132, 5885);

                System.Type[]
                f_1671_5294_5330(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 5294, 5330);
                    return return_v;
                }


                int
                f_1671_5356_5375(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 5356, 5375);
                    return return_v;
                }


                int
                f_1671_5345_5418(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 5345, 5418);
                    return 0;
                }


                System.Collections.ArrayList
                f_1671_5568_5608(System.Management.Automation.PSObject
                psObject)
                {
                    var return_v = SafelyGetBaseObject<ArrayList>(psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 5568, 5608);
                    return return_v;
                }


                object?
                f_1671_5649_5689(System.Type
                type)
                {
                    var return_v = Activator.CreateInstance(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 5649, 5689);
                    return return_v;
                }


                object
                f_1671_5789_5823(object
                obj, System.Type
                type)
                {
                    var return_v = DecodeObject(obj, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 5789, 5823);
                    return return_v;
                }


                int
                f_1671_5774_5824(System.Collections.IList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 5774, 5824);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1671_5731_5740_I(System.Collections.ArrayList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 5731, 5740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 5132, 5885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 5132, 5885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDictionary(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 5972, 6142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 6040, 6131);

                return f_1671_6047_6065(type) && (DynAbs.Tracing.TraceSender.Expression_True(1671, 6047, 6130) && f_1671_6069_6130(f_1671_6069_6100(type), typeof(Dictionary<,>)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 5972, 6142);

                bool
                f_1671_6047_6065(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 6047, 6065);
                    return return_v;
                }


                System.Type
                f_1671_6069_6100(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6069, 6100);
                    return return_v;
                }


                bool
                f_1671_6069_6130(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6069, 6130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 5972, 6142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 5972, 6142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject EncodeDictionary(IDictionary dictionary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 6233, 6814);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 6398, 6537) || true) && (f_1671_6402_6446(f_1671_6425_6445(dictionary)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 6398, 6537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 6480, 6522);

                    return f_1671_6487_6521(dictionary);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 6398, 6537);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 6553, 6591);

                Hashtable
                hashtable = f_1671_6575_6590()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 6605, 6756);
                    foreach (object key in f_1671_6628_6643_I(f_1671_6628_6643(dictionary)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 6605, 6756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 6677, 6741);

                        f_1671_6677_6740(hashtable, f_1671_6691_6708(key), f_1671_6710_6739(f_1671_6723_6738(dictionary, key)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 6605, 6756);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 6772, 6803);

                return f_1671_6779_6802(hashtable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 6233, 6814);

                System.Type
                f_1671_6425_6445(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6425, 6445);
                    return return_v;
                }


                bool
                f_1671_6402_6446(System.Type
                dictionaryType)
                {
                    var return_v = IsObjectDictionaryType(dictionaryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6402, 6446);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_6487_6521(System.Collections.IDictionary
                dictionary)
                {
                    var return_v = EncodeObjectDictionary(dictionary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6487, 6521);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1671_6575_6590()
                {
                    var return_v = new System.Collections.Hashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6575, 6590);
                    return return_v;
                }


                System.Collections.ICollection
                f_1671_6628_6643(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 6628, 6643);
                    return return_v;
                }


                object
                f_1671_6691_6708(object
                obj)
                {
                    var return_v = EncodeObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6691, 6708);
                    return return_v;
                }


                object
                f_1671_6723_6738(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 6723, 6738);
                    return return_v;
                }


                object
                f_1671_6710_6739(object
                obj)
                {
                    var return_v = EncodeObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6710, 6739);
                    return return_v;
                }


                int
                f_1671_6677_6740(System.Collections.Hashtable
                this_param, object
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6677, 6740);
                    return 0;
                }


                System.Collections.ICollection
                f_1671_6628_6643_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6628, 6643);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_6779_6802(System.Collections.Hashtable
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 6779, 6802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 6233, 6814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 6233, 6814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IDictionary DecodeDictionary(PSObject psObject, Type dictionaryType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 6905, 8034);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 7089, 7236) || true) && (f_1671_7093_7131(dictionaryType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 7089, 7236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 7165, 7221);

                    return f_1671_7172_7220(psObject, dictionaryType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 7089, 7236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 7290, 7349);

                Type[]
                elementTypes = f_1671_7312_7348(dictionaryType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 7363, 7437);

                f_1671_7363_7436(f_1671_7374_7393(elementTypes) == 2, "Expected elementTypes.Length == 2");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 7451, 7482);

                Type
                keyType = elementTypes[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 7496, 7529);

                Type
                valueType = elementTypes[1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 7606, 7669);

                Hashtable
                hashtable = f_1671_7628_7668(psObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 7683, 7762);

                IDictionary
                dictionary = (IDictionary)f_1671_7721_7761(dictionaryType)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 7776, 7989);
                    foreach (object key in f_1671_7799_7813_I(f_1671_7799_7813(hashtable)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 7776, 7989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 7847, 7974);

                        f_1671_7847_7973(dictionary, f_1671_7884_7910(key, keyType), f_1671_7933_7972(f_1671_7946_7960(hashtable, key), valueType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 7776, 7989);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 8005, 8023);

                return dictionary;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 6905, 8034);

                bool
                f_1671_7093_7131(System.Type
                dictionaryType)
                {
                    var return_v = IsObjectDictionaryType(dictionaryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 7093, 7131);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1671_7172_7220(System.Management.Automation.PSObject
                psObject, System.Type
                dictionaryType)
                {
                    var return_v = DecodeObjectDictionary(psObject, dictionaryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 7172, 7220);
                    return return_v;
                }


                System.Type[]
                f_1671_7312_7348(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 7312, 7348);
                    return return_v;
                }


                int
                f_1671_7374_7393(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 7374, 7393);
                    return return_v;
                }


                int
                f_1671_7363_7436(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 7363, 7436);
                    return 0;
                }


                System.Collections.Hashtable
                f_1671_7628_7668(System.Management.Automation.PSObject
                psObject)
                {
                    var return_v = SafelyGetBaseObject<Hashtable>(psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 7628, 7668);
                    return return_v;
                }


                object?
                f_1671_7721_7761(System.Type
                type)
                {
                    var return_v = Activator.CreateInstance(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 7721, 7761);
                    return return_v;
                }


                System.Collections.ICollection
                f_1671_7799_7813(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 7799, 7813);
                    return return_v;
                }


                object
                f_1671_7884_7910(object
                obj, System.Type
                type)
                {
                    var return_v = DecodeObject(obj, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 7884, 7910);
                    return return_v;
                }


                object
                f_1671_7946_7960(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 7946, 7960);
                    return return_v;
                }


                object
                f_1671_7933_7972(object
                obj, System.Type
                type)
                {
                    var return_v = DecodeObject(obj, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 7933, 7972);
                    return return_v;
                }


                int
                f_1671_7847_7973(System.Collections.IDictionary
                this_param, object
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 7847, 7973);
                    return 0;
                }


                System.Collections.ICollection
                f_1671_7799_7813_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 7799, 7813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 6905, 8034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 6905, 8034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject EncodePSObject(PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 8124, 8903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 8876, 8892);

                return psObject;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 8124, 8903);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 8124, 8903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 8124, 8903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject DecodePSObject(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 8993, 9568);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 9068, 9557) || true) && (obj is PSObject)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 9068, 9557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 9121, 9142);

                    return (PSObject)obj;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 9068, 9557);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 9068, 9557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 9517, 9542);

                    return f_1671_9524_9541(obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 9068, 9557);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 8993, 9568);

                System.Management.Automation.PSObject
                f_1671_9524_9541(object
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 9524, 9541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 8993, 9568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 8993, 9568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject EncodeException(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 9658, 10988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 10017, 10048);

                ErrorRecord
                errorRecord = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 10062, 10139);

                IContainsErrorRecord
                containsErrorRecord = exception as IContainsErrorRecord
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 10153, 10782) || true) && (containsErrorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 10153, 10782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 10295, 10402);

                    errorRecord = f_1671_10309_10401(exception, "RemoteHostExecutionException", ErrorCategory.NotSpecified, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 10153, 10782);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 10153, 10782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 10649, 10695);

                    errorRecord = f_1671_10663_10694(containsErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 10713, 10767);

                    errorRecord = f_1671_10727_10766(errorRecord, exception);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 10153, 10782);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 10798, 10867);

                PSObject
                errorRecordPSObject = f_1671_10829_10866()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 10881, 10936);

                f_1671_10881_10935(errorRecord, errorRecordPSObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 10950, 10977);

                return errorRecordPSObject;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 9658, 10988);

                System.Management.Automation.ErrorRecord
                f_1671_10309_10401(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 10309, 10401);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1671_10663_10694(System.Management.Automation.IContainsErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 10663, 10694);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1671_10727_10766(System.Management.Automation.ErrorRecord
                errorRecord, System.Exception
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 10727, 10766);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_10829_10866()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 10829, 10866);
                    return return_v;
                }


                int
                f_1671_10881_10935(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.PSObject
                dest)
                {
                    this_param.ToPSObjectForRemoting(dest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 10881, 10935);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 9658, 10988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 9658, 10988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Exception DecodeException(PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 11078, 11465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 11162, 11234);

                ErrorRecord
                errorRecord = f_1671_11188_11233(psObject)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 11248, 11454) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 11248, 11454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 11305, 11374);

                    throw f_1671_11311_11373();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 11248, 11454);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 11248, 11454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 11425, 11454);

                    return f_1671_11432_11453(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 11248, 11454);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 11078, 11465);

                System.Management.Automation.ErrorRecord
                f_1671_11188_11233(System.Management.Automation.PSObject
                serializedErrorRecord)
                {
                    var return_v = ErrorRecord.FromPSObjectForRemoting(serializedErrorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 11188, 11233);
                    return return_v;
                }


                System.Exception
                f_1671_11311_11373()
                {
                    var return_v = RemoteHostExceptions.NewDecodingErrorForErrorRecordException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 11311, 11373);
                    return return_v;
                }


                System.Exception
                f_1671_11432_11453(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 11432, 11453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 11078, 11465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 11078, 11465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static FieldDescription UpcastFieldDescriptionSubclassAndDropAttributes(FieldDescription fieldDescription1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 11592, 12725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 11885, 11967);

                FieldDescription
                fieldDescription2 = f_1671_11922_11966(f_1671_11943_11965(fieldDescription1))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12052, 12102);

                fieldDescription2.Label = f_1671_12078_12101(fieldDescription1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12116, 12178);

                fieldDescription2.HelpMessage = f_1671_12148_12177(fieldDescription1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12192, 12254);

                fieldDescription2.IsMandatory = f_1671_12224_12253(fieldDescription1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12268, 12332);

                fieldDescription2.DefaultValue = f_1671_12301_12331(fieldDescription1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12393, 12469);

                f_1671_12393_12468(
                            // Set the type related fields.
                            fieldDescription2, f_1671_12432_12467(fieldDescription1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12483, 12567);

                f_1671_12483_12566(fieldDescription2, f_1671_12526_12565(fieldDescription1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12581, 12673);

                f_1671_12581_12672(fieldDescription2, f_1671_12628_12671(fieldDescription1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12689, 12714);

                return fieldDescription2;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 11592, 12725);

                string
                f_1671_11943_11965(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 11943, 11965);
                    return return_v;
                }


                System.Management.Automation.Host.FieldDescription
                f_1671_11922_11966(string
                name)
                {
                    var return_v = new System.Management.Automation.Host.FieldDescription(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 11922, 11966);
                    return return_v;
                }


                string
                f_1671_12078_12101(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 12078, 12101);
                    return return_v;
                }


                string
                f_1671_12148_12177(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.HelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 12148, 12177);
                    return return_v;
                }


                bool
                f_1671_12224_12253(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.IsMandatory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 12224, 12253);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_12301_12331(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.DefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 12301, 12331);
                    return return_v;
                }


                string
                f_1671_12432_12467(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.ParameterTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 12432, 12467);
                    return return_v;
                }


                int
                f_1671_12393_12468(System.Management.Automation.Host.FieldDescription
                this_param, string
                nameOfType)
                {
                    this_param.SetParameterTypeName(nameOfType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 12393, 12468);
                    return 0;
                }


                string
                f_1671_12526_12565(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.ParameterTypeFullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 12526, 12565);
                    return return_v;
                }


                int
                f_1671_12483_12566(System.Management.Automation.Host.FieldDescription
                this_param, string
                fullNameOfType)
                {
                    this_param.SetParameterTypeFullName(fullNameOfType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 12483, 12566);
                    return 0;
                }


                string
                f_1671_12628_12671(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.ParameterAssemblyFullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 12628, 12671);
                    return return_v;
                }


                int
                f_1671_12581_12672(System.Management.Automation.Host.FieldDescription
                this_param, string
                fullNameOfAssembly)
                {
                    this_param.SetParameterAssemblyFullName(fullNameOfAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 12581, 12672);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 11592, 12725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 11592, 12725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object EncodeObject(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 12812, 15739);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12884, 12960) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 12884, 12960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12933, 12945);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 12884, 12960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 12976, 13002);

                Type
                type = f_1671_12988_13001(obj)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13016, 15728) || true) && (obj is PSObject)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13016, 15728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13145, 13182);

                    return f_1671_13152_13181(obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13016, 15728);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13016, 15728);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13216, 15728) || true) && (obj is ProgressRecord)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13216, 15728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13275, 13328);

                        return f_1671_13282_13327(((ProgressRecord)obj));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13216, 15728);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13216, 15728);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13362, 15728) || true) && (f_1671_13366_13383(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13362, 15728);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13417, 13428);

                            return obj;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13362, 15728);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13362, 15728);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13462, 15728) || true) && (f_1671_13466_13477(type))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13462, 15728);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13511, 13527);

                                return (int)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13462, 15728);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13462, 15728);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13561, 15728) || true) && (obj is CultureInfo)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13561, 15728);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13696, 13718);

                                    return f_1671_13703_13717(obj);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13561, 15728);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13561, 15728);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13752, 15728) || true) && (obj is Exception)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13752, 15728);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13806, 13845);

                                        return f_1671_13813_13844(obj);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13752, 15728);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13752, 15728);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13879, 15728) || true) && (type == typeof(object[]))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13879, 15728);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 13941, 13981);

                                            return f_1671_13948_13980(obj);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13879, 15728);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 13879, 15728);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14015, 15728) || true) && (f_1671_14019_14031(type))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14015, 15728);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14065, 14096);

                                                return f_1671_14072_14095(obj);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14015, 15728);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14015, 15728);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14130, 15728) || true) && (obj is IList && (DynAbs.Tracing.TraceSender.Expression_True(1671, 14134, 14168) && f_1671_14150_14168(type)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14130, 15728);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14202, 14238);

                                                    return f_1671_14209_14237(obj);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14130, 15728);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14130, 15728);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14272, 15728) || true) && (obj is IDictionary && (DynAbs.Tracing.TraceSender.Expression_True(1671, 14276, 14316) && f_1671_14298_14316(type)))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14272, 15728);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14350, 14392);

                                                        return f_1671_14357_14391(obj);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14272, 15728);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14272, 15728);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14426, 15728) || true) && (f_1671_14430_14473(type, typeof(FieldDescription)) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 14430, 14509) || type == typeof(FieldDescription)))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14426, 15728);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14712, 14811);

                                                            return f_1671_14719_14810(f_1671_14739_14809(obj));
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14426, 15728);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14426, 15728);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14845, 15728) || true) && (f_1671_14849_14888(type))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14845, 15728);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14922, 14954);

                                                                return f_1671_14929_14953(obj);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14845, 15728);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14845, 15728);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 14988, 15728) || true) && (obj is RemoteHostCall)
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14988, 15728);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15047, 15085);

                                                                    return f_1671_15054_15084(((RemoteHostCall)obj));
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14988, 15728);
                                                                }

                                                                else
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 14988, 15728);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15119, 15728) || true) && (obj is RemoteHostResponse)
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 15119, 15728);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15182, 15224);

                                                                        return f_1671_15189_15223(((RemoteHostResponse)obj));
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 15119, 15728);
                                                                    }

                                                                    else
                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 15119, 15728);

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15258, 15728) || true) && (obj is SecureString)
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 15258, 15728);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15315, 15326);

                                                                            return obj;
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 15258, 15728);
                                                                        }

                                                                        else
                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 15258, 15728);

                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15360, 15728) || true) && (obj is PSCredential)
                                                                            )

                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 15360, 15728);
                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15417, 15428);

                                                                                return obj;
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 15360, 15728);
                                                                            }

                                                                            else
                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 15360, 15728);

                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15462, 15728) || true) && (f_1671_15466_15497(type))
                                                                                )

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 15462, 15728);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15531, 15567);

                                                                                    return f_1671_15538_15566(obj);
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 15462, 15728);
                                                                                }

                                                                                else

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 15462, 15728);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15633, 15713);

                                                                                    throw f_1671_15639_15712(type);
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 15462, 15728);
                                                                                }
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 15360, 15728);
                                                                            }
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 15258, 15728);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 15119, 15728);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14988, 15728);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14845, 15728);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14426, 15728);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14272, 15728);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14130, 15728);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 14015, 15728);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13879, 15728);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13752, 15728);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13561, 15728);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13462, 15728);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13362, 15728);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13216, 15728);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 13016, 15728);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 12812, 15739);

                System.Type
                f_1671_12988_13001(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 12988, 13001);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_13152_13181(object
                psObject)
                {
                    var return_v = EncodePSObject((System.Management.Automation.PSObject)psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 13152, 13181);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_13282_13327(System.Management.Automation.ProgressRecord
                this_param)
                {
                    var return_v = this_param.ToPSObjectForRemoting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 13282, 13327);
                    return return_v;
                }


                bool
                f_1671_13366_13383(System.Type
                type)
                {
                    var return_v = IsKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 13366, 13383);
                    return return_v;
                }


                bool
                f_1671_13466_13477(System.Type
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 13466, 13477);
                    return return_v;
                }


                string?
                f_1671_13703_13717(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 13703, 13717);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_13813_13844(object
                exception)
                {
                    var return_v = EncodeException((System.Exception)exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 13813, 13844);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_13948_13980(object
                objects)
                {
                    var return_v = EncodeObjectArray((object[])objects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 13948, 13980);
                    return return_v;
                }


                bool
                f_1671_14019_14031(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 14019, 14031);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_14072_14095(object
                array)
                {
                    var return_v = EncodeArray((System.Array)array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 14072, 14095);
                    return return_v;
                }


                bool
                f_1671_14150_14168(System.Type
                type)
                {
                    var return_v = IsCollection(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 14150, 14168);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_14209_14237(object
                collection)
                {
                    var return_v = EncodeCollection((System.Collections.IList)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 14209, 14237);
                    return return_v;
                }


                bool
                f_1671_14298_14316(System.Type
                type)
                {
                    var return_v = IsDictionary(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 14298, 14316);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_14357_14391(object
                dictionary)
                {
                    var return_v = EncodeDictionary((System.Collections.IDictionary)dictionary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 14357, 14391);
                    return return_v;
                }


                bool
                f_1671_14430_14473(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 14430, 14473);
                    return return_v;
                }


                System.Management.Automation.Host.FieldDescription
                f_1671_14739_14809(object
                fieldDescription1)
                {
                    var return_v = UpcastFieldDescriptionSubclassAndDropAttributes((System.Management.Automation.Host.FieldDescription)fieldDescription1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 14739, 14809);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_14719_14810(System.Management.Automation.Host.FieldDescription
                obj)
                {
                    var return_v = EncodeClassOrStruct((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 14719, 14810);
                    return return_v;
                }


                bool
                f_1671_14849_14888(System.Type
                type)
                {
                    var return_v = IsEncodingAllowedForClassOrStruct(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 14849, 14888);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_14929_14953(object
                obj)
                {
                    var return_v = EncodeClassOrStruct(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 14929, 14953);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_15054_15084(System.Management.Automation.Remoting.RemoteHostCall
                this_param)
                {
                    var return_v = this_param.Encode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 15054, 15084);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_15189_15223(System.Management.Automation.Remoting.RemoteHostResponse
                this_param)
                {
                    var return_v = this_param.Encode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 15189, 15223);
                    return return_v;
                }


                bool
                f_1671_15466_15497(System.Type
                type)
                {
                    var return_v = IsGenericIEnumerableOfInt(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 15466, 15497);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_15538_15566(object
                collection)
                {
                    var return_v = EncodeCollection((System.Collections.IList)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 15538, 15566);
                    return return_v;
                }


                System.Exception
                f_1671_15639_15712(System.Type
                type)
                {
                    var return_v = RemoteHostExceptions.NewRemoteHostDataEncodingNotSupportedException(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 15639, 15712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 12812, 15739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 12812, 15739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object DecodeObject(object obj, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 15826, 19574);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15909, 15985) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 15909, 15985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 15958, 15970);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 15909, 15985);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16001, 16051);

                f_1671_16001_16050(type != null, "Expected type != null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16065, 19563) || true) && (type == typeof(PSObject))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16065, 19563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16127, 16154);

                    return f_1671_16134_16153(obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16065, 19563);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16065, 19563);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16188, 19563) || true) && (type == typeof(ProgressRecord))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16188, 19563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16256, 16328);

                        return f_1671_16263_16327(f_1671_16302_16326(obj));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16188, 19563);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16188, 19563);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16362, 19563) || true) && (f_1671_16366_16383(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16362, 19563);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16417, 16428);

                            return obj;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16362, 19563);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16362, 19563);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16462, 19563) || true) && (obj is SecureString)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16462, 19563);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16519, 16530);

                                return obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16462, 19563);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16462, 19563);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16564, 19563) || true) && (obj is PSCredential)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16564, 19563);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16621, 16632);

                                    return obj;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16564, 19563);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16564, 19563);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16666, 19563) || true) && (obj is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1671, 16670, 16717) && type == typeof(PSCredential)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16666, 19563);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 16972, 17011);

                                        PSObject
                                        objAsPSObject = (PSObject)obj
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17029, 17054);

                                        PSCredential
                                        cred = null
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17116, 17295);

                                            cred = f_1671_17123_17294((string)f_1671_17148_17190(f_1671_17148_17184(f_1671_17148_17172(objAsPSObject), "UserName")), (SecureString)f_1671_17251_17293(f_1671_17251_17287(f_1671_17251_17275(objAsPSObject), "Password")));
                                        }
                                        catch (GetValueException)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1671, 17332, 17429);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17398, 17410);

                                            cred = null;
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1671, 17332, 17429);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17449, 17461);

                                        return cred;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16666, 19563);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 16666, 19563);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17495, 19563) || true) && (obj is int && (DynAbs.Tracing.TraceSender.Expression_True(1671, 17499, 17524) && f_1671_17513_17524(type)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 17495, 19563);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17558, 17595);

                                            return f_1671_17565_17594(type, obj);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 17495, 19563);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 17495, 19563);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17629, 19563) || true) && (obj is string && (DynAbs.Tracing.TraceSender.Expression_True(1671, 17633, 17677) && type == typeof(CultureInfo)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 17629, 19563);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17711, 17747);

                                                return f_1671_17718_17746((string)obj);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 17629, 19563);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 17629, 19563);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17781, 19563) || true) && (obj is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1671, 17785, 17829) && type == typeof(Exception)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 17781, 19563);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17863, 17901);

                                                    return f_1671_17870_17900(obj);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 17781, 19563);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 17781, 19563);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 17935, 19563) || true) && (obj is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1671, 17939, 17982) && type == typeof(object[])))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 17935, 19563);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 18016, 18056);

                                                        return f_1671_18023_18055(obj);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 17935, 19563);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 17935, 19563);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 18090, 19563) || true) && (obj is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1671, 18094, 18125) && f_1671_18113_18125(type)))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 18090, 19563);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 18159, 18199);

                                                            return f_1671_18166_18198(obj, type);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 18090, 19563);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 18090, 19563);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 18233, 19563) || true) && (obj is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1671, 18237, 18274) && f_1671_18256_18274(type)))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 18233, 19563);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 18308, 18353);

                                                                return f_1671_18315_18352(obj, type);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 18233, 19563);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 18233, 19563);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 18387, 19563) || true) && (obj is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1671, 18391, 18428) && f_1671_18410_18428(type)))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 18387, 19563);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 18462, 18507);

                                                                    return f_1671_18469_18506(obj, type);
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 18387, 19563);
                                                                }

                                                                else
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 18387, 19563);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 18541, 19563) || true) && (obj is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1671, 18545, 18603) && f_1671_18564_18603(type)))
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 18541, 19563);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 18637, 18685);

                                                                        return f_1671_18644_18684(obj, type);
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 18541, 19563);
                                                                    }

                                                                    else
                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 18541, 19563);

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 18719, 19563) || true) && (obj is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1671, 18723, 18773) && f_1671_18742_18773(type)))
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 18719, 19563);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 19000, 19064);

                                                                            return f_1671_19007_19063(obj, typeof(Collection<int>));
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 18719, 19563);
                                                                        }

                                                                        else
                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 18719, 19563);

                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 19098, 19563) || true) && (obj is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1671, 19102, 19151) && type == typeof(RemoteHostCall)))
                                                                            )

                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 19098, 19563);
                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 19185, 19229);

                                                                                return f_1671_19192_19228(obj);
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 19098, 19563);
                                                                            }

                                                                            else
                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 19098, 19563);

                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 19263, 19563) || true) && (obj is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1671, 19267, 19320) && type == typeof(RemoteHostResponse)))
                                                                                )

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 19263, 19563);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 19354, 19402);

                                                                                    return f_1671_19361_19401(obj);
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 19263, 19563);
                                                                                }

                                                                                else

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 19263, 19563);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 19468, 19548);

                                                                                    throw f_1671_19474_19547(type);
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 19263, 19563);
                                                                                }
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 19098, 19563);
                                                                            }
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 18719, 19563);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 18541, 19563);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 18387, 19563);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 18233, 19563);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 18090, 19563);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 17935, 19563);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 17781, 19563);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 17629, 19563);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 17495, 19563);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16666, 19563);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16564, 19563);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16462, 19563);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16362, 19563);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16188, 19563);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 16065, 19563);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 15826, 19574);

                int
                f_1671_16001_16050(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 16001, 16050);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1671_16134_16153(object
                obj)
                {
                    var return_v = DecodePSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 16134, 16153);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_16302_16326(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 16302, 16326);
                    return return_v;
                }


                System.Management.Automation.ProgressRecord
                f_1671_16263_16327(System.Management.Automation.PSObject
                progressAsPSObject)
                {
                    var return_v = ProgressRecord.FromPSObjectForRemoting(progressAsPSObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 16263, 16327);
                    return return_v;
                }


                bool
                f_1671_16366_16383(System.Type
                type)
                {
                    var return_v = IsKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 16366, 16383);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_17148_17172(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 17148, 17172);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1671_17148_17184(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 17148, 17184);
                    return return_v;
                }


                object
                f_1671_17148_17190(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 17148, 17190);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_17251_17275(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 17251, 17275);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1671_17251_17287(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 17251, 17287);
                    return return_v;
                }


                object
                f_1671_17251_17293(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 17251, 17293);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1671_17123_17294(object
                userName, object
                password)
                {
                    var return_v = new System.Management.Automation.PSCredential((string)userName, (System.Security.SecureString)password);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 17123, 17294);
                    return return_v;
                }


                bool
                f_1671_17513_17524(System.Type
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 17513, 17524);
                    return return_v;
                }


                object
                f_1671_17565_17594(System.Type
                enumType, object
                value)
                {
                    var return_v = Enum.ToObject(enumType, (int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 17565, 17594);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1671_17718_17746(object
                name)
                {
                    var return_v = new System.Globalization.CultureInfo((string)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 17718, 17746);
                    return return_v;
                }


                System.Exception
                f_1671_17870_17900(object
                psObject)
                {
                    var return_v = DecodeException((System.Management.Automation.PSObject)psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 17870, 17900);
                    return return_v;
                }


                object[]
                f_1671_18023_18055(object
                psObject)
                {
                    var return_v = DecodeObjectArray((System.Management.Automation.PSObject)psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 18023, 18055);
                    return return_v;
                }


                bool
                f_1671_18113_18125(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 18113, 18125);
                    return return_v;
                }


                System.Array
                f_1671_18166_18198(object
                psObject, System.Type
                type)
                {
                    var return_v = DecodeArray((System.Management.Automation.PSObject)psObject, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 18166, 18198);
                    return return_v;
                }


                bool
                f_1671_18256_18274(System.Type
                type)
                {
                    var return_v = IsCollection(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 18256, 18274);
                    return return_v;
                }


                System.Collections.IList
                f_1671_18315_18352(object
                psObject, System.Type
                collectionType)
                {
                    var return_v = DecodeCollection((System.Management.Automation.PSObject)psObject, collectionType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 18315, 18352);
                    return return_v;
                }


                bool
                f_1671_18410_18428(System.Type
                type)
                {
                    var return_v = IsDictionary(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 18410, 18428);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1671_18469_18506(object
                psObject, System.Type
                dictionaryType)
                {
                    var return_v = DecodeDictionary((System.Management.Automation.PSObject)psObject, dictionaryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 18469, 18506);
                    return return_v;
                }


                bool
                f_1671_18564_18603(System.Type
                type)
                {
                    var return_v = IsEncodingAllowedForClassOrStruct(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 18564, 18603);
                    return return_v;
                }


                object
                f_1671_18644_18684(object
                psObject, System.Type
                type)
                {
                    var return_v = DecodeClassOrStruct((System.Management.Automation.PSObject)psObject, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 18644, 18684);
                    return return_v;
                }


                bool
                f_1671_18742_18773(System.Type
                type)
                {
                    var return_v = IsGenericIEnumerableOfInt(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 18742, 18773);
                    return return_v;
                }


                System.Collections.IList
                f_1671_19007_19063(object
                psObject, System.Type
                collectionType)
                {
                    var return_v = DecodeCollection((System.Management.Automation.PSObject)psObject, collectionType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 19007, 19063);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostCall
                f_1671_19192_19228(object
                data)
                {
                    var return_v = RemoteHostCall.Decode((System.Management.Automation.PSObject)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 19192, 19228);
                    return return_v;
                }


                System.Management.Automation.Remoting.RemoteHostResponse
                f_1671_19361_19401(object
                data)
                {
                    var return_v = RemoteHostResponse.Decode((System.Management.Automation.PSObject)data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 19361, 19401);
                    return return_v;
                }


                System.Exception
                f_1671_19474_19547(System.Type
                type)
                {
                    var return_v = RemoteHostExceptions.NewRemoteHostDataDecodingNotSupportedException(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 19474, 19547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 15826, 19574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 15826, 19574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void EncodeAndAddAsProperty(PSObject psObject, string propertyName, object propertyValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 19674, 20151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 19804, 19862);

                f_1671_19804_19861(psObject != null, "Expected psObject != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 19876, 19942);

                f_1671_19876_19941(propertyName != null, "Expected propertyName != null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 19956, 20037) || true) && (propertyValue == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 19956, 20037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 20015, 20022);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 19956, 20037);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 20053, 20140);

                f_1671_20053_20139(f_1671_20053_20072(psObject), f_1671_20077_20138(propertyName, f_1671_20110_20137(propertyValue)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 19674, 20151);

                int
                f_1671_19804_19861(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 19804, 19861);
                    return 0;
                }


                int
                f_1671_19876_19941(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 19876, 19941);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_20053_20072(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 20053, 20072);
                    return return_v;
                }


                object
                f_1671_20110_20137(object
                obj)
                {
                    var return_v = EncodeObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 20110, 20137);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1671_20077_20138(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 20077, 20138);
                    return return_v;
                }


                int
                f_1671_20053_20139(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 20053, 20139);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 19674, 20151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 19674, 20151);
            }
        }

        internal static object DecodePropertyValue(PSObject psObject, string propertyName, Type propertyValueType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 20246, 20973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 20377, 20435);

                f_1671_20377_20434(psObject != null, "Expected psObject != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 20449, 20515);

                f_1671_20449_20514(propertyName != null, "Expected propertyName != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 20529, 20605);

                f_1671_20529_20604(propertyValueType != null, "Expected propertyValueType != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 20619, 20716);

                ReadOnlyPSMemberInfoCollection<PSPropertyInfo>
                matches = f_1671_20676_20715(f_1671_20676_20695(psObject), propertyName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 20730, 20813) || true) && (f_1671_20734_20747(matches) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 20730, 20813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 20786, 20798);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 20730, 20813);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 20829, 20891);

                f_1671_20829_20890(f_1671_20840_20853(matches) == 1, "Expected matches.Count == 1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 20905, 20962);

                return f_1671_20912_20961(f_1671_20925_20941(f_1671_20925_20935(matches, 0)), propertyValueType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 20246, 20973);

                int
                f_1671_20377_20434(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 20377, 20434);
                    return 0;
                }


                int
                f_1671_20449_20514(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 20449, 20514);
                    return 0;
                }


                int
                f_1671_20529_20604(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 20529, 20604);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_20676_20695(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 20676, 20695);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_20676_20715(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                name)
                {
                    var return_v = this_param.Match(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 20676, 20715);
                    return return_v;
                }


                int
                f_1671_20734_20747(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 20734, 20747);
                    return return_v;
                }


                int
                f_1671_20840_20853(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 20840, 20853);
                    return return_v;
                }


                int
                f_1671_20829_20890(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 20829, 20890);
                    return 0;
                }


                System.Management.Automation.PSPropertyInfo
                f_1671_20925_20935(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 20925, 20935);
                    return return_v;
                }


                object
                f_1671_20925_20941(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 20925, 20941);
                    return return_v;
                }


                object
                f_1671_20912_20961(object
                obj, System.Type
                type)
                {
                    var return_v = DecodeObject(obj, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 20912, 20961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 20246, 20973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 20246, 20973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject EncodeObjectArray(object[] objects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 21066, 21380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21150, 21188);

                ArrayList
                arrayList = f_1671_21172_21187()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21202, 21322);
                    foreach (object obj in f_1671_21225_21232_I(objects))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 21202, 21322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21266, 21307);

                        f_1671_21266_21306(arrayList, f_1671_21280_21305(obj));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 21202, 21322);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21338, 21369);

                return f_1671_21345_21368(arrayList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 21066, 21380);

                System.Collections.ArrayList
                f_1671_21172_21187()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 21172, 21187);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_21280_21305(object
                obj)
                {
                    var return_v = EncodeObjectWithType(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 21280, 21305);
                    return return_v;
                }


                int
                f_1671_21266_21306(System.Collections.ArrayList
                this_param, System.Management.Automation.PSObject
                value)
                {
                    var return_v = this_param.Add((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 21266, 21306);
                    return return_v;
                }


                object[]
                f_1671_21225_21232_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 21225, 21232);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_21345_21368(System.Collections.ArrayList
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 21345, 21368);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 21066, 21380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 21066, 21380);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object[] DecodeObjectArray(PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 21473, 21932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21615, 21678);

                ArrayList
                arrayList = f_1671_21637_21677(psObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21692, 21739);

                object[]
                objects = new object[f_1671_21722_21737(arrayList)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21762, 21767);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21753, 21890) || true) && (i < f_1671_21773_21788(arrayList))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21790, 21793)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 21753, 21890))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 21753, 21890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21827, 21875);

                        objects[i] = f_1671_21840_21874(f_1671_21861_21873(arrayList, i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 21906, 21921);

                return objects;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 21473, 21932);

                System.Collections.ArrayList
                f_1671_21637_21677(System.Management.Automation.PSObject
                psObject)
                {
                    var return_v = SafelyGetBaseObject<ArrayList>(psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 21637, 21677);
                    return return_v;
                }


                int
                f_1671_21722_21737(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 21722, 21737);
                    return return_v;
                }


                int
                f_1671_21773_21788(System.Collections.ArrayList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 21773, 21788);
                    return return_v;
                }


                object
                f_1671_21861_21873(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 21861, 21873);
                    return return_v;
                }


                object
                f_1671_21840_21874(object
                obj)
                {
                    var return_v = DecodeObjectWithType(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 21840, 21874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 21473, 21932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 21473, 21932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject EncodeObjectWithType(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 22029, 22531);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22110, 22186) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 22110, 22186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22159, 22171);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 22110, 22186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22202, 22260);

                PSObject
                psObject = f_1671_22222_22259()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22274, 22378);

                f_1671_22274_22377(f_1671_22274_22293(psObject), f_1671_22298_22376(RemoteDataNameStrings.ObjectType, f_1671_22351_22375(f_1671_22351_22364(obj))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22392, 22490);

                f_1671_22392_22489(f_1671_22392_22411(psObject), f_1671_22416_22488(RemoteDataNameStrings.ObjectValue, f_1671_22470_22487(obj)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22504, 22520);

                return psObject;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 22029, 22531);

                System.Management.Automation.PSObject
                f_1671_22222_22259()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22222, 22259);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_22274_22293(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 22274, 22293);
                    return return_v;
                }


                System.Type
                f_1671_22351_22364(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22351, 22364);
                    return return_v;
                }


                string
                f_1671_22351_22375(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22351, 22375);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1671_22298_22376(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22298, 22376);
                    return return_v;
                }


                int
                f_1671_22274_22377(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22274, 22377);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_22392_22411(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 22392, 22411);
                    return return_v;
                }


                object
                f_1671_22470_22487(object
                obj)
                {
                    var return_v = EncodeObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22470, 22487);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1671_22416_22488(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22416, 22488);
                    return return_v;
                }


                int
                f_1671_22392_22489(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22392, 22489);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 22029, 22531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 22029, 22531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object DecodeObjectWithType(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 22628, 23188);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22707, 22783) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 22707, 22783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22756, 22768);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 22707, 22783);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22799, 22851);

                PSObject
                psObject = f_1671_22819_22850(obj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22865, 22958);

                string
                typeName = f_1671_22883_22957(psObject, RemoteDataNameStrings.ObjectType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 22972, 23029);

                Type
                type = f_1671_22984_23028(typeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23043, 23132);

                object
                val = f_1671_23056_23131(psObject, RemoteDataNameStrings.ObjectValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23146, 23177);

                return f_1671_23153_23176(val, type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 22628, 23188);

                System.Management.Automation.PSObject
                f_1671_22819_22850(object
                obj)
                {
                    var return_v = SafelyCastObject<PSObject>(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22819, 22850);
                    return return_v;
                }


                string
                f_1671_22883_22957(System.Management.Automation.PSObject
                psObject, string
                key)
                {
                    var return_v = SafelyGetPropertyValue<string>(psObject, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22883, 22957);
                    return return_v;
                }


                System.Type
                f_1671_22984_23028(string
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<Type>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 22984, 23028);
                    return return_v;
                }


                object
                f_1671_23056_23131(System.Management.Automation.PSObject
                psObject, string
                key)
                {
                    var return_v = SafelyGetPropertyValue<object>(psObject, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 23056, 23131);
                    return return_v;
                }


                object
                f_1671_23153_23176(object
                obj, System.Type
                type)
                {
                    var return_v = DecodeObject(obj, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 23153, 23176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 22628, 23188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 22628, 23188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        private static bool ArrayIsZeroBased(Array array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 23281, 23732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23474, 23496);

                int
                rank = f_1671_23485_23495(array)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23519, 23524);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23510, 23693) || true) && (i < rank)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23536, 23539)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 23510, 23693))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 23510, 23693);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23573, 23678) || true) && (f_1671_23577_23599(array, i) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 23573, 23678);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23646, 23659);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 23573, 23678);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23709, 23721);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 23281, 23732);

                int
                f_1671_23485_23495(System.Array
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 23485, 23495);
                    return return_v;
                }


                int
                f_1671_23577_23599(System.Array
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 23577, 23599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 23281, 23732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 23281, 23732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject EncodeArray(Array array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 23818, 24986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23891, 23943);

                f_1671_23891_23942(array != null, "Expected array != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 23957, 24029);

                f_1671_23957_24028(f_1671_23968_23991(array), "Expected ArrayIsZeroBased(array)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24043, 24076);

                Type
                arrayType = f_1671_24060_24075(array)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24090, 24136);

                Type
                elementType = f_1671_24109_24135(arrayType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24150, 24172);

                int
                rank = f_1671_24161_24171(array)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24186, 24216);

                int[]
                lengths = new int[rank]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24239, 24244);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24230, 24348) || true) && (i < rank)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24256, 24259)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 24230, 24348))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 24230, 24348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24293, 24333);

                        lengths[i] = f_1671_24306_24328(array, i) + 1;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24364, 24403);

                Indexer
                indexer = f_1671_24382_24402(lengths)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24417, 24454);

                ArrayList
                elements = f_1671_24438_24453()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24468, 24651);
                    foreach (int[] index in f_1671_24492_24499_I(indexer))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 24468, 24651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24533, 24577);

                        object
                        elementValue = f_1671_24555_24576(array, index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24595, 24636);

                        f_1671_24595_24635(elements, f_1671_24608_24634(elementValue));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 24468, 24651);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24667, 24725);

                PSObject
                psObject = f_1671_24687_24724()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24739, 24836);

                f_1671_24739_24835(f_1671_24739_24758(psObject), f_1671_24763_24834(RemoteDataNameStrings.MethodArrayElements, elements));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24850, 24945);

                f_1671_24850_24944(f_1671_24850_24869(psObject), f_1671_24874_24943(RemoteDataNameStrings.MethodArrayLengths, lengths));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 24959, 24975);

                return psObject;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 23818, 24986);

                int
                f_1671_23891_23942(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 23891, 23942);
                    return 0;
                }


                bool
                f_1671_23968_23991(System.Array
                array)
                {
                    var return_v = ArrayIsZeroBased(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 23968, 23991);
                    return return_v;
                }


                int
                f_1671_23957_24028(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 23957, 24028);
                    return 0;
                }


                System.Type
                f_1671_24060_24075(System.Array
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24060, 24075);
                    return return_v;
                }


                System.Type?
                f_1671_24109_24135(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24109, 24135);
                    return return_v;
                }


                int
                f_1671_24161_24171(System.Array
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 24161, 24171);
                    return return_v;
                }


                int
                f_1671_24306_24328(System.Array
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetUpperBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24306, 24328);
                    return return_v;
                }


                System.Management.Automation.Remoting.Indexer
                f_1671_24382_24402(int[]
                lengths)
                {
                    var return_v = new System.Management.Automation.Remoting.Indexer(lengths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24382, 24402);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1671_24438_24453()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24438, 24453);
                    return return_v;
                }


                object?
                f_1671_24555_24576(System.Array
                this_param, params int[]
                indices)
                {
                    var return_v = this_param.GetValue(indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24555, 24576);
                    return return_v;
                }


                object
                f_1671_24608_24634(object
                obj)
                {
                    var return_v = EncodeObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24608, 24634);
                    return return_v;
                }


                int
                f_1671_24595_24635(System.Collections.ArrayList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24595, 24635);
                    return return_v;
                }


                System.Management.Automation.Remoting.Indexer
                f_1671_24492_24499_I(System.Management.Automation.Remoting.Indexer
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24492, 24499);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_24687_24724()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24687, 24724);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_24739_24758(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 24739, 24758);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1671_24763_24834(string
                name, System.Collections.ArrayList
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24763, 24834);
                    return return_v;
                }


                int
                f_1671_24739_24835(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24739, 24835);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_24850_24869(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 24850, 24869);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1671_24874_24943(string
                name, int[]
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24874, 24943);
                    return return_v;
                }


                int
                f_1671_24850_24944(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 24850, 24944);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 23818, 24986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 23818, 24986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Array DecodeArray(PSObject psObject, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 25072, 26404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 25193, 25243);

                f_1671_25193_25242(f_1671_25204_25216(type), "Expected type.IsArray");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 25257, 25298);

                Type
                elementType = f_1671_25276_25297(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 25362, 25486);

                PSObject
                psObjectContainingElements = f_1671_25400_25485(psObject, RemoteDataNameStrings.MethodArrayElements)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 25500, 25580);

                ArrayList
                elements = f_1671_25521_25579(psObjectContainingElements)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 25643, 25765);

                PSObject
                psObjectContainingLengths = f_1671_25680_25764(psObject, RemoteDataNameStrings.MethodArrayLengths)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 25779, 25866);

                ArrayList
                lengthsArrayList = f_1671_25808_25865(psObjectContainingLengths)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 25880, 25941);

                int[]
                lengths = (int[])f_1671_25903_25940(lengthsArrayList, typeof(int))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 25997, 26036);

                Indexer
                indexer = f_1671_26015_26035(lengths)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26050, 26107);

                Array
                array = f_1671_26064_26106(elementType, lengths)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26121, 26142);

                int
                elementIndex = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26156, 26364);
                    foreach (int[] index in f_1671_26180_26187_I(indexer))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 26156, 26364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26221, 26295);

                        object
                        elementValue = f_1671_26243_26294(f_1671_26256_26280(elements, elementIndex++), elementType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26313, 26349);

                        f_1671_26313_26348(array, elementValue, index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 26156, 26364);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26380, 26393);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 25072, 26404);

                bool
                f_1671_25204_25216(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 25204, 25216);
                    return return_v;
                }


                int
                f_1671_25193_25242(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 25193, 25242);
                    return 0;
                }


                System.Type?
                f_1671_25276_25297(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 25276, 25297);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_25400_25485(System.Management.Automation.PSObject
                psObject, string
                key)
                {
                    var return_v = SafelyGetPropertyValue<PSObject>(psObject, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 25400, 25485);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1671_25521_25579(System.Management.Automation.PSObject
                psObject)
                {
                    var return_v = SafelyGetBaseObject<ArrayList>(psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 25521, 25579);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_25680_25764(System.Management.Automation.PSObject
                psObject, string
                key)
                {
                    var return_v = SafelyGetPropertyValue<PSObject>(psObject, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 25680, 25764);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1671_25808_25865(System.Management.Automation.PSObject
                psObject)
                {
                    var return_v = SafelyGetBaseObject<ArrayList>(psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 25808, 25865);
                    return return_v;
                }


                System.Array
                f_1671_25903_25940(System.Collections.ArrayList
                this_param, System.Type
                type)
                {
                    var return_v = this_param.ToArray(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 25903, 25940);
                    return return_v;
                }


                System.Management.Automation.Remoting.Indexer
                f_1671_26015_26035(int[]
                lengths)
                {
                    var return_v = new System.Management.Automation.Remoting.Indexer(lengths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 26015, 26035);
                    return return_v;
                }


                System.Array
                f_1671_26064_26106(System.Type
                elementType, params int[]
                lengths)
                {
                    var return_v = Array.CreateInstance(elementType, lengths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 26064, 26106);
                    return return_v;
                }


                object
                f_1671_26256_26280(System.Collections.ArrayList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 26256, 26280);
                    return return_v;
                }


                object
                f_1671_26243_26294(object
                obj, System.Type
                type)
                {
                    var return_v = DecodeObject(obj, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 26243, 26294);
                    return return_v;
                }


                int
                f_1671_26313_26348(System.Array
                this_param, object
                value, params int[]
                indices)
                {
                    this_param.SetValue(value, indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 26313, 26348);
                    return 0;
                }


                System.Management.Automation.Remoting.Indexer
                f_1671_26180_26187_I(System.Management.Automation.Remoting.Indexer
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 26180, 26187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 25072, 26404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 25072, 26404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsObjectDictionaryType(Type dictionaryType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 26503, 26973);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26676, 26728) || true) && (!f_1671_26681_26709(dictionaryType))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 26676, 26728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26713, 26726);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 26676, 26728);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26744, 26803);

                Type[]
                elementTypes = f_1671_26766_26802(dictionaryType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26817, 26864) || true) && (f_1671_26821_26840(elementTypes) != 2)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 26817, 26864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26849, 26862);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 26817, 26864);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26880, 26913);

                Type
                valueType = elementTypes[1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 26927, 26962);

                return valueType == typeof(object);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 26503, 26973);

                bool
                f_1671_26681_26709(System.Type
                type)
                {
                    var return_v = IsDictionary(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 26681, 26709);
                    return return_v;
                }


                System.Type[]
                f_1671_26766_26802(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 26766, 26802);
                    return return_v;
                }


                int
                f_1671_26821_26840(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 26821, 26840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 26503, 26973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 26503, 26973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject EncodeObjectDictionary(IDictionary dictionary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 27071, 27619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 27166, 27280);

                f_1671_27166_27279(f_1671_27177_27221(f_1671_27200_27220(dictionary)), "Expected IsObjectDictionaryType(dictionary.GetType())");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 27350, 27388);

                Hashtable
                hashtable = f_1671_27372_27387()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 27402, 27561);
                    foreach (object key in f_1671_27425_27440_I(f_1671_27425_27440(dictionary)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 27402, 27561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 27474, 27546);

                        f_1671_27474_27545(hashtable, f_1671_27488_27505(key), f_1671_27507_27544(f_1671_27528_27543(dictionary, key)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 27402, 27561);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 160);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 27577, 27608);

                return f_1671_27584_27607(hashtable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 27071, 27619);

                System.Type
                f_1671_27200_27220(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27200, 27220);
                    return return_v;
                }


                bool
                f_1671_27177_27221(System.Type
                dictionaryType)
                {
                    var return_v = IsObjectDictionaryType(dictionaryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27177, 27221);
                    return return_v;
                }


                int
                f_1671_27166_27279(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27166, 27279);
                    return 0;
                }


                System.Collections.Hashtable
                f_1671_27372_27387()
                {
                    var return_v = new System.Collections.Hashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27372, 27387);
                    return return_v;
                }


                System.Collections.ICollection
                f_1671_27425_27440(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 27425, 27440);
                    return return_v;
                }


                object
                f_1671_27488_27505(object
                obj)
                {
                    var return_v = EncodeObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27488, 27505);
                    return return_v;
                }


                object
                f_1671_27528_27543(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 27528, 27543);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_27507_27544(object
                obj)
                {
                    var return_v = EncodeObjectWithType(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27507, 27544);
                    return return_v;
                }


                int
                f_1671_27474_27545(System.Collections.Hashtable
                this_param, object
                key, System.Management.Automation.PSObject
                value)
                {
                    this_param.Add(key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27474, 27545);
                    return 0;
                }


                System.Collections.ICollection
                f_1671_27425_27440_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27425, 27440);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1671_27584_27607(System.Collections.Hashtable
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27584, 27607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 27071, 27619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 27071, 27619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IDictionary DecodeObjectDictionary(PSObject psObject, Type dictionaryType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 27717, 28822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 27831, 27933);

                f_1671_27831_27932(f_1671_27842_27880(dictionaryType), "Expected IsObjectDictionaryType(dictionaryType)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 27987, 28046);

                Type[]
                elementTypes = f_1671_28009_28045(dictionaryType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 28060, 28134);

                f_1671_28060_28133(f_1671_28071_28090(elementTypes) == 2, "Expected elementTypes.Length == 2");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 28148, 28179);

                Type
                keyType = elementTypes[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 28193, 28226);

                Type
                valueType = elementTypes[1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 28240, 28320);

                f_1671_28240_28319(valueType == typeof(object), "Expected valueType == typeof(object)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 28397, 28460);

                Hashtable
                hashtable = f_1671_28419_28459(psObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 28474, 28553);

                IDictionary
                dictionary = (IDictionary)f_1671_28512_28552(dictionaryType)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 28567, 28777);
                    foreach (object key in f_1671_28590_28604_I(f_1671_28590_28604(hashtable)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 28567, 28777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 28638, 28762);

                        f_1671_28638_28761(dictionary, f_1671_28675_28701(key, keyType), f_1671_28724_28760(f_1671_28745_28759(hashtable, key)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 28567, 28777);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1671, 1, 211);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1671, 1, 211);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 28793, 28811);

                return dictionary;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 27717, 28822);

                bool
                f_1671_27842_27880(System.Type
                dictionaryType)
                {
                    var return_v = IsObjectDictionaryType(dictionaryType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27842, 27880);
                    return return_v;
                }


                int
                f_1671_27831_27932(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 27831, 27932);
                    return 0;
                }


                System.Type[]
                f_1671_28009_28045(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 28009, 28045);
                    return return_v;
                }


                int
                f_1671_28071_28090(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 28071, 28090);
                    return return_v;
                }


                int
                f_1671_28060_28133(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 28060, 28133);
                    return 0;
                }


                int
                f_1671_28240_28319(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 28240, 28319);
                    return 0;
                }


                System.Collections.Hashtable
                f_1671_28419_28459(System.Management.Automation.PSObject
                psObject)
                {
                    var return_v = SafelyGetBaseObject<Hashtable>(psObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 28419, 28459);
                    return return_v;
                }


                object?
                f_1671_28512_28552(System.Type
                type)
                {
                    var return_v = Activator.CreateInstance(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 28512, 28552);
                    return return_v;
                }


                System.Collections.ICollection
                f_1671_28590_28604(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 28590, 28604);
                    return return_v;
                }


                object
                f_1671_28675_28701(object
                obj, System.Type
                type)
                {
                    var return_v = DecodeObject(obj, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 28675, 28701);
                    return return_v;
                }


                object
                f_1671_28745_28759(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 28745, 28759);
                    return return_v;
                }


                object
                f_1671_28724_28760(object
                obj)
                {
                    var return_v = DecodeObjectWithType(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 28724, 28760);
                    return return_v;
                }


                int
                f_1671_28638_28761(System.Collections.IDictionary
                this_param, object
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 28638, 28761);
                    return 0;
                }


                System.Collections.ICollection
                f_1671_28590_28604_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 28590, 28604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 27717, 28822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 27717, 28822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T SafelyGetBaseObject<T>(PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 28918, 29245);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 29001, 29188) || true) && (psObject == null || (DynAbs.Tracing.TraceSender.Expression_False(1671, 29005, 29052) || f_1671_29025_29044(psObject) == null) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 29005, 29083) || !(f_1671_29058_29077(psObject) is T)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 29001, 29188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 29117, 29173);

                    throw f_1671_29123_29172();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 29001, 29188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 29204, 29234);

                return (T)f_1671_29214_29233(psObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 28918, 29245);

                object
                f_1671_29025_29044(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 29025, 29044);
                    return return_v;
                }


                object
                f_1671_29058_29077(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 29058, 29077);
                    return return_v;
                }


                System.Exception
                f_1671_29123_29172()
                {
                    var return_v = RemoteHostExceptions.NewDecodingFailedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 29123, 29172);
                    return return_v;
                }


                object
                f_1671_29214_29233(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 29214, 29233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 28918, 29245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 28918, 29245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T SafelyCastObject<T>(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 29337, 29568);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 29410, 29485) || true) && (obj is T)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 29410, 29485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 29456, 29470);

                    return (T)obj;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 29410, 29485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 29501, 29557);

                throw f_1671_29507_29556();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 29337, 29568);

                System.Exception
                f_1671_29507_29556()
                {
                    var return_v = RemoteHostExceptions.NewDecodingFailedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 29507, 29556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 29337, 29568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 29337, 29568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T SafelyGetPropertyValue<T>(PSObject psObject, string key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1671, 29667, 30079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 29765, 29820);

                PSPropertyInfo
                propertyInfo = f_1671_29795_29819(f_1671_29795_29814(psObject), key)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 29834, 30023) || true) && (propertyInfo == null || (DynAbs.Tracing.TraceSender.Expression_False(1671, 29838, 29888) || f_1671_29862_29880(propertyInfo) == null) || (DynAbs.Tracing.TraceSender.Expression_False(1671, 29838, 29918) || !(f_1671_29894_29912(propertyInfo) is T)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1671, 29834, 30023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 29952, 30008);

                    throw f_1671_29958_30007();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1671, 29834, 30023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1671, 30039, 30068);

                return (T)f_1671_30049_30067(propertyInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1671, 29667, 30079);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1671_29795_29814(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 29795, 29814);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1671_29795_29819(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 29795, 29819);
                    return return_v;
                }


                object
                f_1671_29862_29880(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 29862, 29880);
                    return return_v;
                }


                object
                f_1671_29894_29912(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 29894, 29912);
                    return return_v;
                }


                System.Exception
                f_1671_29958_30007()
                {
                    var return_v = RemoteHostExceptions.NewDecodingFailedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1671, 29958, 30007);
                    return return_v;
                }


                object
                f_1671_30049_30067(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1671, 30049, 30067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1671, 29667, 30079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 29667, 30079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RemoteHostEncoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1671, 1106, 30086);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1671, 1106, 30086);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 1106, 30086);
        }


        static RemoteHostEncoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1671, 1106, 30086);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1671, 1106, 30086);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1671, 1106, 30086);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1671, 1106, 30086);
    }
}
