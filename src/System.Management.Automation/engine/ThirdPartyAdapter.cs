// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Management.Automation
{
    internal class ThirdPartyAdapter : PropertyOnlyAdapter
    {
        internal ThirdPartyAdapter(Type adaptedType, PSPropertyAdapter externalAdapter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1363, 430, 620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 728, 762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 9953, 9969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 534, 560);

                AdaptedType = adaptedType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 574, 609);

                _externalAdapter = externalAdapter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1363, 430, 620);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 430, 620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 430, 620);
            }
        }

        internal Type AdaptedType { get; }

        internal Type ExternalAdapterType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 926, 1011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 962, 996);

                    return f_1363_969_995(_externalAdapter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 926, 1011);

                    System.Type
                    f_1363_969_995(System.Management.Automation.PSPropertyAdapter
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 969, 995);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 868, 1022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 868, 1022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IEnumerable<string> GetTypeNameHierarchy(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 1142, 2102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 1238, 1282);

                Collection<string>
                typeNameHierarchy = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 1334, 1397);

                    typeNameHierarchy = f_1363_1354_1396(_externalAdapter, obj);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1363, 1426, 1723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 1486, 1708);

                    throw f_1363_1492_1707("PSPropertyAdapter.GetTypeNameHierarchyError", exception, f_1363_1646_1690(), f_1363_1692_1706(obj));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1363, 1426, 1723);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 1739, 2050) || true) && (typeNameHierarchy == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1363, 1739, 2050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 1802, 2035);

                    throw f_1363_1808_2034("PSPropertyAdapter.NullReturnValueError", null, f_1363_1952_1991(), "PSPropertyAdapter.GetTypeNameHierarchy");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1363, 1739, 2050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 2066, 2091);

                return typeNameHierarchy;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 1142, 2102);

                System.Collections.ObjectModel.Collection<string>
                f_1363_1354_1396(System.Management.Automation.PSPropertyAdapter
                this_param, object
                baseObject)
                {
                    var return_v = this_param.GetTypeNameHierarchy(baseObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 1354, 1396);
                    return return_v;
                }


                string
                f_1363_1646_1690()
                {
                    var return_v = ExtendedTypeSystem.GetTypeNameHierarchyError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 1646, 1690);
                    return return_v;
                }


                string?
                f_1363_1692_1706(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 1692, 1706);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_1492_1707(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 1492, 1707);
                    return return_v;
                }


                string
                f_1363_1952_1991()
                {
                    var return_v = ExtendedTypeSystem.NullReturnValueError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 1952, 1991);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_1808_2034(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 1808, 2034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 1142, 2102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 1142, 2102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void DoAddAllProperties<T>(object obj, PSMemberInfoInternalCollection<T> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 2228, 3323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 2353, 2401);

                Collection<PSAdaptedProperty>
                properties = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 2453, 2502);

                    properties = f_1363_2466_2501(_externalAdapter, obj);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1363, 2531, 2804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 2591, 2789);

                    throw f_1363_2597_2788("PSPropertyAdapter.GetProperties", exception, f_1363_2739_2771(), f_1363_2773_2787(obj));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1363, 2531, 2804);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 2820, 3117) || true) && (properties == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1363, 2820, 3117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 2876, 3102);

                    throw f_1363_2882_3101("PSPropertyAdapter.NullReturnValueError", null, f_1363_3026_3065(), "PSPropertyAdapter.GetProperties");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1363, 2820, 3117);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 3133, 3312);
                    foreach (PSAdaptedProperty property in f_1363_3172_3182_I(properties))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1363, 3133, 3312);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 3216, 3250);

                        f_1363_3216_3249(this, property, obj);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 3270, 3297);

                        f_1363_3270_3296(
                                        members, property);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1363, 3133, 3312);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1363, 1, 180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1363, 1, 180);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 2228, 3323);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSAdaptedProperty>
                f_1363_2466_2501(System.Management.Automation.PSPropertyAdapter
                this_param, object
                baseObject)
                {
                    var return_v = this_param.GetProperties(baseObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 2466, 2501);
                    return return_v;
                }


                string
                f_1363_2739_2771()
                {
                    var return_v = ExtendedTypeSystem.GetProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 2739, 2771);
                    return return_v;
                }


                string?
                f_1363_2773_2787(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 2773, 2787);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_2597_2788(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 2597, 2788);
                    return return_v;
                }


                string
                f_1363_3026_3065()
                {
                    var return_v = ExtendedTypeSystem.NullReturnValueError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 3026, 3065);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_2882_3101(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 2882, 3101);
                    return return_v;
                }


                int
                f_1363_3216_3249(System.Management.Automation.ThirdPartyAdapter
                this_param, System.Management.Automation.PSAdaptedProperty
                property, object
                baseObject)
                {
                    this_param.InitializeProperty(property, baseObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 3216, 3249);
                    return 0;
                }


                int
                f_1363_3270_3296(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, System.Management.Automation.PSAdaptedProperty
                member)
                {
                    this_param.Add(member as T);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 3270, 3296);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSAdaptedProperty>
                f_1363_3172_3182_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSAdaptedProperty>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 3172, 3182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 2228, 3323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 2228, 3323);
            }
        }

        protected override PSProperty DoGetProperty(object obj, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 3596, 4316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 3697, 3731);

                PSAdaptedProperty
                property = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 3783, 3842);

                    property = f_1363_3794_3841(_externalAdapter, obj, propertyName);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1363, 3871, 4154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 3931, 4139);

                    throw f_1363_3937_4138("PSPropertyAdapter.GetProperty", exception, f_1363_4077_4107(), propertyName, f_1363_4123_4137(obj));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1363, 3871, 4154);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 4170, 4273) || true) && (property != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1363, 4170, 4273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 4224, 4258);

                    f_1363_4224_4257(this, property, obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1363, 4170, 4273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 4289, 4305);

                return property;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 3596, 4316);

                System.Management.Automation.PSAdaptedProperty
                f_1363_3794_3841(System.Management.Automation.PSPropertyAdapter
                this_param, object
                baseObject, string
                propertyName)
                {
                    var return_v = this_param.GetProperty(baseObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 3794, 3841);
                    return return_v;
                }


                string
                f_1363_4077_4107()
                {
                    var return_v = ExtendedTypeSystem.GetProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 4077, 4107);
                    return return_v;
                }


                string?
                f_1363_4123_4137(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 4123, 4137);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_3937_4138(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 3937, 4138);
                    return return_v;
                }


                int
                f_1363_4224_4257(System.Management.Automation.ThirdPartyAdapter
                this_param, System.Management.Automation.PSAdaptedProperty
                property, object
                baseObject)
                {
                    this_param.InitializeProperty(property, baseObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 4224, 4257);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 3596, 4316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 3596, 4316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override PSProperty DoGetFirstPropertyOrDefault(object obj, MemberNamePredicate predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 4328, 5088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 4453, 4487);

                PSAdaptedProperty
                property = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 4539, 4609);

                    property = f_1363_4550_4608(_externalAdapter, obj, predicate);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1363, 4638, 4926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 4698, 4911);

                    throw f_1363_4704_4910("PSPropertyAdapter.GetProperty", exception, f_1363_4844_4874(), nameof(predicate), f_1363_4895_4909(obj));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1363, 4638, 4926);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 4942, 5045) || true) && (property != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1363, 4942, 5045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 4996, 5030);

                    f_1363_4996_5029(this, property, obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1363, 4942, 5045);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 5061, 5077);

                return property;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 4328, 5088);

                System.Management.Automation.PSAdaptedProperty
                f_1363_4550_4608(System.Management.Automation.PSPropertyAdapter
                this_param, object
                baseObject, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstPropertyOrDefault(baseObject, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 4550, 4608);
                    return return_v;
                }


                string
                f_1363_4844_4874()
                {
                    var return_v = ExtendedTypeSystem.GetProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 4844, 4874);
                    return return_v;
                }


                string?
                f_1363_4895_4909(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 4895, 4909);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_4704_4910(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 4704, 4910);
                    return return_v;
                }


                int
                f_1363_4996_5029(System.Management.Automation.ThirdPartyAdapter
                this_param, System.Management.Automation.PSAdaptedProperty
                property, object
                baseObject)
                {
                    this_param.InitializeProperty(property, baseObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 4996, 5029);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 4328, 5088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 4328, 5088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InitializeProperty(PSAdaptedProperty property, object baseObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 5241, 5507);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 5344, 5496) || true) && (property.adapter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1363, 5344, 5496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 5406, 5430);

                    property.adapter = this;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 5448, 5481);

                    property.baseObject = baseObject;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1363, 5344, 5496);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 5241, 5507);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 5241, 5507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 5241, 5507);
            }
        }

        protected override bool PropertyIsSettable(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 5621, 6332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 5709, 5775);

                PSAdaptedProperty
                adaptedProperty = property as PSAdaptedProperty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 5791, 5896);

                f_1363_5791_5895(adaptedProperty != null, "ThirdPartyAdapter should only receive PSAdaptedProperties");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 5948, 6000);

                    return f_1363_5955_5999(_externalAdapter, adaptedProperty);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1363, 6029, 6321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 6089, 6306);

                    throw f_1363_6095_6305("PSPropertyAdapter.PropertyIsSettableError", exception, f_1363_6247_6289(), f_1363_6291_6304(property));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1363, 6029, 6321);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 5621, 6332);

                int
                f_1363_5791_5895(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 5791, 5895);
                    return 0;
                }


                bool
                f_1363_5955_5999(System.Management.Automation.PSPropertyAdapter
                this_param, System.Management.Automation.PSAdaptedProperty
                adaptedProperty)
                {
                    var return_v = this_param.IsSettable(adaptedProperty);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 5955, 5999);
                    return return_v;
                }


                string
                f_1363_6247_6289()
                {
                    var return_v = ExtendedTypeSystem.PropertyIsSettableError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 6247, 6289);
                    return return_v;
                }


                string
                f_1363_6291_6304(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 6291, 6304);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_6095_6305(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 6095, 6305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 5621, 6332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 5621, 6332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool PropertyIsGettable(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 6446, 7157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 6534, 6600);

                PSAdaptedProperty
                adaptedProperty = property as PSAdaptedProperty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 6616, 6721);

                f_1363_6616_6720(adaptedProperty != null, "ThirdPartyAdapter should only receive PSAdaptedProperties");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 6773, 6825);

                    return f_1363_6780_6824(_externalAdapter, adaptedProperty);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1363, 6854, 7146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 6914, 7131);

                    throw f_1363_6920_7130("PSPropertyAdapter.PropertyIsGettableError", exception, f_1363_7072_7114(), f_1363_7116_7129(property));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1363, 6854, 7146);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 6446, 7157);

                int
                f_1363_6616_6720(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 6616, 6720);
                    return 0;
                }


                bool
                f_1363_6780_6824(System.Management.Automation.PSPropertyAdapter
                this_param, System.Management.Automation.PSAdaptedProperty
                adaptedProperty)
                {
                    var return_v = this_param.IsGettable(adaptedProperty);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 6780, 6824);
                    return return_v;
                }


                string
                f_1363_7072_7114()
                {
                    var return_v = ExtendedTypeSystem.PropertyIsGettableError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 7072, 7114);
                    return return_v;
                }


                string
                f_1363_7116_7129(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 7116, 7129);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_6920_7130(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 6920, 7130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 6446, 7157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 6446, 7157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object PropertyGet(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 7309, 8007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 7392, 7458);

                PSAdaptedProperty
                adaptedProperty = property as PSAdaptedProperty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 7474, 7579);

                f_1363_7474_7578(adaptedProperty != null, "ThirdPartyAdapter should only receive PSAdaptedProperties");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 7631, 7689);

                    return f_1363_7638_7688(_externalAdapter, adaptedProperty);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1363, 7718, 7996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 7778, 7981);

                    throw f_1363_7784_7980("PSPropertyAdapter.PropertyGetError", exception, f_1363_7929_7964(), f_1363_7966_7979(property));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1363, 7718, 7996);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 7309, 8007);

                int
                f_1363_7474_7578(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 7474, 7578);
                    return 0;
                }


                object
                f_1363_7638_7688(System.Management.Automation.PSPropertyAdapter
                this_param, System.Management.Automation.PSAdaptedProperty
                adaptedProperty)
                {
                    var return_v = this_param.GetPropertyValue(adaptedProperty);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 7638, 7688);
                    return return_v;
                }


                string
                f_1363_7929_7964()
                {
                    var return_v = ExtendedTypeSystem.PropertyGetError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 7929, 7964);
                    return return_v;
                }


                string
                f_1363_7966_7979(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 7966, 7979);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_7784_7980(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 7784, 7980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 7309, 8007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 7309, 8007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void PropertySet(PSProperty property, object setValue, bool convertIfPossible)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 8154, 8944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 8276, 8342);

                PSAdaptedProperty
                adaptedProperty = property as PSAdaptedProperty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 8358, 8463);

                f_1363_8358_8462(adaptedProperty != null, "ThirdPartyAdapter should only receive PSAdaptedProperties");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 8515, 8576);

                    f_1363_8515_8575(_externalAdapter, adaptedProperty, setValue);
                }
                catch (SetValueException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1363, 8605, 8641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 8633, 8639);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1363, 8605, 8641);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1363, 8655, 8933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 8715, 8918);

                    throw f_1363_8721_8917("PSPropertyAdapter.PropertySetError", exception, f_1363_8866_8901(), f_1363_8903_8916(property));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1363, 8655, 8933);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 8154, 8944);

                int
                f_1363_8358_8462(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 8358, 8462);
                    return 0;
                }


                int
                f_1363_8515_8575(System.Management.Automation.PSPropertyAdapter
                this_param, System.Management.Automation.PSAdaptedProperty
                adaptedProperty, object
                value)
                {
                    this_param.SetPropertyValue(adaptedProperty, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 8515, 8575);
                    return 0;
                }


                string
                f_1363_8866_8901()
                {
                    var return_v = ExtendedTypeSystem.PropertySetError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 8866, 8901);
                    return return_v;
                }


                string
                f_1363_8903_8916(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 8903, 8916);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_8721_8917(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 8721, 8917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 8154, 8944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 8154, 8944);
            }
        }

        protected override string PropertyType(PSProperty property, bool forDisplay)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 9076, 9915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 9177, 9243);

                PSAdaptedProperty
                adaptedProperty = property as PSAdaptedProperty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 9259, 9364);

                f_1363_9259_9363(adaptedProperty != null, "ThirdPartyAdapter should only receive PSAdaptedProperties");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 9380, 9411);

                string
                propertyTypeName = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 9463, 9536);

                    propertyTypeName = f_1363_9482_9535(_externalAdapter, adaptedProperty);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1363, 9565, 9845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 9625, 9830);

                    throw f_1363_9631_9829("PSPropertyAdapter.PropertyTypeError", exception, f_1363_9777_9813(), f_1363_9815_9828(property));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1363, 9565, 9845);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 9861, 9904);

                return propertyTypeName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1363, 9868, 9903) ?? "System.Object");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 9076, 9915);

                int
                f_1363_9259_9363(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 9259, 9363);
                    return 0;
                }


                string
                f_1363_9482_9535(System.Management.Automation.PSPropertyAdapter
                this_param, System.Management.Automation.PSAdaptedProperty
                adaptedProperty)
                {
                    var return_v = this_param.GetPropertyTypeName(adaptedProperty);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 9482, 9535);
                    return return_v;
                }


                string
                f_1363_9777_9813()
                {
                    var return_v = ExtendedTypeSystem.PropertyTypeError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 9777, 9813);
                    return return_v;
                }


                string
                f_1363_9815_9828(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 9815, 9828);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1363_9631_9829(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 9631, 9829);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 9076, 9915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 9076, 9915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSPropertyAdapter _externalAdapter;

        static ThirdPartyAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1363, 359, 9977);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1363, 359, 9977);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 359, 9977);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1363, 359, 9977);
    }
    public abstract class PSPropertyAdapter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "object")]
        public virtual Collection<string> GetTypeNameHierarchy(object baseObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 10351, 10985);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 10597, 10714) || true) && (baseObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1363, 10597, 10714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 10653, 10699);

                    throw f_1363_10659_10698("baseObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1363, 10597, 10714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 10730, 10782);

                Collection<string>
                types = f_1363_10757_10781()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 10808, 10835);

                    for (Type
        type = f_1363_10815_10835(baseObject)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 10798, 10945) || true) && (type != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 10851, 10871)
        , type = f_1363_10858_10871(type), DynAbs.Tracing.TraceSender.TraceExitCondition(1363, 10798, 10945))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1363, 10798, 10945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 10905, 10930);

                        f_1363_10905_10929(types, f_1363_10915_10928(type));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1363, 1, 148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1363, 1, 148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 10961, 10974);

                return types;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 10351, 10985);

                System.ArgumentNullException
                f_1363_10659_10698(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 10659, 10698);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1363_10757_10781()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 10757, 10781);
                    return return_v;
                }


                System.Type
                f_1363_10815_10835(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 10815, 10835);
                    return return_v;
                }


                System.Type
                f_1363_10858_10871(System.Type
                this_param)
                {
                    var return_v = this_param.BaseType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 10858, 10871);
                    return return_v;
                }


                string
                f_1363_10915_10928(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 10915, 10928);
                    return return_v;
                }


                int
                f_1363_10905_10929(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 10905, 10929);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 10351, 10985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 10351, 10985);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "object")]
        public abstract Collection<PSAdaptedProperty> GetProperties(object baseObject);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "object")]
        public abstract PSAdaptedProperty GetProperty(object baseObject, string propertyName);

        public abstract bool IsSettable(PSAdaptedProperty adaptedProperty);

        public abstract bool IsGettable(PSAdaptedProperty adaptedProperty);

        public abstract object GetPropertyValue(PSAdaptedProperty adaptedProperty);

        public abstract void SetPropertyValue(PSAdaptedProperty adaptedProperty, object value);

        public abstract string GetPropertyTypeName(PSAdaptedProperty adaptedProperty);

        public virtual PSAdaptedProperty GetFirstPropertyOrDefault(object baseObject, MemberNamePredicate predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1363, 12940, 13316);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 13073, 13277);
                    foreach (var property in f_1363_13098_13123_I(f_1363_13098_13123(this, baseObject)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1363, 13073, 13277);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 13157, 13262) || true) && (f_1363_13161_13185(predicate, f_1363_13171_13184(property)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1363, 13157, 13262);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 13227, 13243);

                            return property;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1363, 13157, 13262);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1363, 13073, 13277);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1363, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1363, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1363, 13293, 13305);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1363, 12940, 13316);

                System.Collections.ObjectModel.Collection<System.Management.Automation.PSAdaptedProperty>
                f_1363_13098_13123(System.Management.Automation.PSPropertyAdapter
                this_param, object
                baseObject)
                {
                    var return_v = this_param.GetProperties(baseObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 13098, 13123);
                    return return_v;
                }


                string
                f_1363_13171_13184(System.Management.Automation.PSAdaptedProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1363, 13171, 13184);
                    return return_v;
                }


                bool
                f_1363_13161_13185(System.Management.Automation.MemberNamePredicate
                this_param, string
                memberName)
                {
                    var return_v = this_param.Invoke(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 13161, 13185);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSAdaptedProperty>
                f_1363_13098_13123_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSAdaptedProperty>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1363, 13098, 13123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1363, 12940, 13316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 12940, 13316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSPropertyAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1363, 10186, 13323);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1363, 10186, 13323);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 10186, 13323);
        }


        static PSPropertyAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1363, 10186, 13323);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1363, 10186, 13323);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1363, 10186, 13323);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1363, 10186, 13323);
    }
}
