// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation
{
    public class SettingValueExceptionEventArgs : EventArgs
    {
        public bool ShouldThrow { get; set; }

        public Exception Exception { get; }

        internal SettingValueExceptionEventArgs(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1294, 1701, 1852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 1187, 1224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 1352, 1387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 1786, 1808);

                Exception = exception;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 1822, 1841);

                ShouldThrow = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1294, 1701, 1852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 1701, 1852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 1701, 1852);
            }
        }

        static SettingValueExceptionEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1294, 704, 1859);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1294, 704, 1859);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 704, 1859);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1294, 704, 1859);
    }
    public class GettingValueExceptionEventArgs : EventArgs
    {
        public bool ShouldThrow { get; set; }

        public Exception Exception { get; }

        internal GettingValueExceptionEventArgs(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1294, 3191, 3380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 2677, 2714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 2842, 2877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 3729, 3773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 3276, 3298);

                Exception = exception;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 3312, 3336);

                ValueReplacement = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 3350, 3369);

                ShouldThrow = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1294, 3191, 3380);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 3191, 3380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 3191, 3380);
            }
        }

        public object ValueReplacement { get; set; }

        static GettingValueExceptionEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1294, 2354, 3780);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1294, 2354, 3780);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 2354, 3780);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1294, 2354, 3780);
    }
    public class PSObjectPropertyDescriptor : PropertyDescriptor
    {
        internal event EventHandler<SettingValueExceptionEventArgs>
SettingValueException
;
        internal event EventHandler<GettingValueExceptionEventArgs>
GettingValueException
;

        internal PSObjectPropertyDescriptor(string propertyName, Type propertyType, bool isReadOnly, AttributeCollection propertyAttributes)
        : base(f_1294_4573_4585_C(propertyName), f_1294_4587_4611())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1294, 4420, 4760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 4883, 4938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 5070, 5110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 6626, 6668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 4637, 4661);

                IsReadOnly = isReadOnly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 4675, 4707);

                Attributes = propertyAttributes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 4721, 4749);

                PropertyType = propertyType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1294, 4420, 4760);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 4420, 4760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 4420, 4760);
            }
        }

        public override AttributeCollection Attributes { get; }

        public override bool IsReadOnly { get; }

        public override void ResetValue(object component)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 5412, 5465);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 5412, 5465);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 5412, 5465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 5412, 5465);
            }
        }

        public override bool CanResetValue(object component)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 5722, 5792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 5777, 5790);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 5722, 5792);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 5722, 5792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 5722, 5792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool ShouldSerializeValue(object component)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 6091, 6198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 6175, 6187);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 6091, 6198);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 6091, 6198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 6091, 6198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Type ComponentType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 6474, 6506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 6480, 6504);

                    return typeof(PSObject);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 6474, 6506);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 6415, 6517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 6415, 6517);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Type PropertyType { get; }

        public override object GetValue(object component)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 7987, 9716);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8061, 8189) || true) && (component == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 8061, 8189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8116, 8174);

                    throw f_1294_8122_8173("component");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 8061, 8189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8205, 8255);

                PSObject
                mshObj = f_1294_8223_8254(component)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8269, 8293);

                PSPropertyInfo
                property
                = default(PSPropertyInfo);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8343, 8401);

                    property = f_1294_8354_8382(f_1294_8354_8371(mshObj), f_1294_8372_8381(this)) as PSPropertyInfo;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8419, 9155) || true) && (property == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 8419, 9155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8481, 8593);

                        f_1294_8481_8592(PSObjectTypeDescriptor.typeDescriptor, "Could not find property \"{0}\" to get its value.", f_1294_8582_8591(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8615, 8847);

                        ExtendedTypeSystemException
                        e = f_1294_8647_8846("PropertyNotFoundInPropertyDescriptorGetValue", null, f_1294_8783_8834(), f_1294_8836_8845(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8869, 8886);

                        bool
                        shouldThrow
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8908, 8975);

                        object
                        returnValue = f_1294_8929_8974(this, e, out shouldThrow)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 8997, 9093) || true) && (shouldThrow)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 8997, 9093);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 9062, 9070);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 8997, 9093);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 9117, 9136);

                        return returnValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 8419, 9155);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 9175, 9197);

                    return f_1294_9182_9196(property);
                }
                catch (ExtendedTypeSystemException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1294, 9226, 9705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 9296, 9431);

                    f_1294_9296_9430(PSObjectTypeDescriptor.typeDescriptor, "Exception getting the value of the property \"{0}\": \"{1}\".", f_1294_9409_9418(this), f_1294_9420_9429(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 9449, 9466);

                    bool
                    shouldThrow
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 9484, 9551);

                    object
                    returnValue = f_1294_9505_9550(this, e, out shouldThrow)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 9569, 9651) || true) && (shouldThrow)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 9569, 9651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 9626, 9632);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 9569, 9651);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 9671, 9690);

                    return returnValue;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1294, 9226, 9705);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 7987, 9716);

                System.Management.Automation.PSArgumentNullException
                f_1294_8122_8173(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 8122, 8173);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_8223_8254(object
                component)
                {
                    var return_v = GetComponentPSObject(component);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 8223, 8254);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1294_8354_8371(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 8354, 8371);
                    return return_v;
                }


                string
                f_1294_8372_8381(System.Management.Automation.PSObjectPropertyDescriptor
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 8372, 8381);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1294_8354_8382(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 8354, 8382);
                    return return_v;
                }


                string
                f_1294_8582_8591(System.Management.Automation.PSObjectPropertyDescriptor
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 8582, 8591);
                    return return_v;
                }


                int
                f_1294_8481_8592(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 8481, 8592);
                    return 0;
                }


                string
                f_1294_8783_8834()
                {
                    var return_v = ExtendedTypeSystem.PropertyNotFoundInTypeDescriptor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 8783, 8834);
                    return return_v;
                }


                string
                f_1294_8836_8845(System.Management.Automation.PSObjectPropertyDescriptor
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 8836, 8845);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1294_8647_8846(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 8647, 8846);
                    return return_v;
                }


                object
                f_1294_8929_8974(System.Management.Automation.PSObjectPropertyDescriptor
                this_param, System.Management.Automation.ExtendedTypeSystemException
                e, out bool
                shouldThrow)
                {
                    var return_v = this_param.DealWithGetValueException(e, out shouldThrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 8929, 8974);
                    return return_v;
                }


                object
                f_1294_9182_9196(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 9182, 9196);
                    return return_v;
                }


                string
                f_1294_9409_9418(System.Management.Automation.PSObjectPropertyDescriptor
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 9409, 9418);
                    return return_v;
                }


                string
                f_1294_9420_9429(System.Management.Automation.ExtendedTypeSystemException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 9420, 9429);
                    return return_v;
                }


                int
                f_1294_9296_9430(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 9296, 9430);
                    return 0;
                }


                object
                f_1294_9505_9550(System.Management.Automation.PSObjectPropertyDescriptor
                this_param, System.Management.Automation.ExtendedTypeSystemException
                e, out bool
                shouldThrow)
                {
                    var return_v = this_param.DealWithGetValueException(e, out shouldThrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 9505, 9550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 7987, 9716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 7987, 9716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject GetComponentPSObject(object component)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1294, 9728, 10728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 9994, 10034);

                PSObject
                mshObj = component as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 10048, 10687) || true) && (mshObj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 10048, 10687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 10100, 10172);

                    PSObjectTypeDescriptor
                    descriptor = component as PSObjectTypeDescriptor
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 10190, 10623) || true) && (descriptor == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 10190, 10623);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 10254, 10604);

                        throw f_1294_10260_10603("component", f_1294_10308_10343(), "component", f_1294_10482_10503(typeof(PSObject)), f_1294_10567_10602(typeof(PSObjectTypeDescriptor)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 10190, 10623);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 10643, 10672);

                    mshObj = f_1294_10652_10671(descriptor);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 10048, 10687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 10703, 10717);

                return mshObj;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1294, 9728, 10728);

                string
                f_1294_10308_10343()
                {
                    var return_v = ExtendedTypeSystem.InvalidComponent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 10308, 10343);
                    return return_v;
                }


                string
                f_1294_10482_10503(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 10482, 10503);
                    return return_v;
                }


                string
                f_1294_10567_10602(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 10567, 10602);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1294_10260_10603(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 10260, 10603);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_10652_10671(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 10652, 10671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 9728, 10728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 9728, 10728);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object DealWithGetValueException(ExtendedTypeSystemException e, out bool shouldThrow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 10740, 11422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 10858, 10939);

                GettingValueExceptionEventArgs
                eventArgs = f_1294_10901_10938(e)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 10953, 11311) || true) && (GettingValueException != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 10953, 11311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 11020, 11070);

                    f_1294_11020_11069(GettingValueException, this, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 11088, 11296);

                    f_1294_11088_11295(PSObjectTypeDescriptor.typeDescriptor, "GettingValueException event has been triggered resulting in ValueReplacement:\"{0}\".", f_1294_11268_11294(eventArgs));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 10953, 11311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 11327, 11363);

                shouldThrow = f_1294_11341_11362(eventArgs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 11377, 11411);

                return f_1294_11384_11410(eventArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 10740, 11422);

                System.Management.Automation.GettingValueExceptionEventArgs
                f_1294_10901_10938(System.Management.Automation.ExtendedTypeSystemException
                exception)
                {
                    var return_v = new System.Management.Automation.GettingValueExceptionEventArgs((System.Exception)exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 10901, 10938);
                    return return_v;
                }


                int
                f_1294_11020_11069(System.EventHandler<System.Management.Automation.GettingValueExceptionEventArgs>
                eventHandler, System.Management.Automation.PSObjectPropertyDescriptor
                sender, System.Management.Automation.GettingValueExceptionEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.GettingValueExceptionEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 11020, 11069);
                    return 0;
                }


                object
                f_1294_11268_11294(System.Management.Automation.GettingValueExceptionEventArgs
                this_param)
                {
                    var return_v = this_param.ValueReplacement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 11268, 11294);
                    return return_v;
                }


                int
                f_1294_11088_11295(System.Management.Automation.PSTraceSource
                this_param, string
                format, object
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 11088, 11295);
                    return 0;
                }


                bool
                f_1294_11341_11362(System.Management.Automation.GettingValueExceptionEventArgs
                this_param)
                {
                    var return_v = this_param.ShouldThrow;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 11341, 11362);
                    return return_v;
                }


                object
                f_1294_11384_11410(System.Management.Automation.GettingValueExceptionEventArgs
                this_param)
                {
                    var return_v = this_param.ValueReplacement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 11384, 11410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 10740, 11422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 10740, 11422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void SetValue(object component, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 12723, 14408);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 12809, 12937) || true) && (component == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 12809, 12937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 12864, 12922);

                    throw f_1294_12870_12921("component");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 12809, 12937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 12953, 13003);

                PSObject
                mshObj = f_1294_12971_13002(component)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13053, 13126);

                    PSPropertyInfo
                    property = f_1294_13079_13107(f_1294_13079_13096(mshObj), f_1294_13097_13106(this)) as PSPropertyInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13144, 13847) || true) && (property == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 13144, 13847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13206, 13318);

                        f_1294_13206_13317(PSObjectTypeDescriptor.typeDescriptor, "Could not find property \"{0}\" to set its value.", f_1294_13307_13316(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13340, 13572);

                        ExtendedTypeSystemException
                        e = f_1294_13372_13571("PropertyNotFoundInPropertyDescriptorSetValue", null, f_1294_13508_13559(), f_1294_13561_13570(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13594, 13611);

                        bool
                        shouldThrow
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13633, 13679);

                        f_1294_13633_13678(this, e, out shouldThrow);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13701, 13797) || true) && (shouldThrow)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 13701, 13797);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13766, 13774);

                            throw e;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 13701, 13797);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13821, 13828);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 13144, 13847);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13867, 13890);

                    property.Value = value;
                }
                catch (ExtendedTypeSystemException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1294, 13919, 14338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 13989, 14124);

                    f_1294_13989_14123(PSObjectTypeDescriptor.typeDescriptor, "Exception setting the value of the property \"{0}\": \"{1}\".", f_1294_14102_14111(this), f_1294_14113_14122(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 14142, 14159);

                    bool
                    shouldThrow
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 14177, 14223);

                    f_1294_14177_14222(this, e, out shouldThrow);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 14241, 14323) || true) && (shouldThrow)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 14241, 14323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 14298, 14304);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 14241, 14323);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1294, 13919, 14338);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 14354, 14397);

                f_1294_14354_14396(this, component, EventArgs.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 12723, 14408);

                System.Management.Automation.PSArgumentNullException
                f_1294_12870_12921(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 12870, 12921);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_12971_13002(object
                component)
                {
                    var return_v = GetComponentPSObject(component);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 12971, 13002);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1294_13079_13096(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 13079, 13096);
                    return return_v;
                }


                string
                f_1294_13097_13106(System.Management.Automation.PSObjectPropertyDescriptor
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 13097, 13106);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1294_13079_13107(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 13079, 13107);
                    return return_v;
                }


                string
                f_1294_13307_13316(System.Management.Automation.PSObjectPropertyDescriptor
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 13307, 13316);
                    return return_v;
                }


                int
                f_1294_13206_13317(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 13206, 13317);
                    return 0;
                }


                string
                f_1294_13508_13559()
                {
                    var return_v = ExtendedTypeSystem.PropertyNotFoundInTypeDescriptor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 13508, 13559);
                    return return_v;
                }


                string
                f_1294_13561_13570(System.Management.Automation.PSObjectPropertyDescriptor
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 13561, 13570);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1294_13372_13571(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 13372, 13571);
                    return return_v;
                }


                int
                f_1294_13633_13678(System.Management.Automation.PSObjectPropertyDescriptor
                this_param, System.Management.Automation.ExtendedTypeSystemException
                e, out bool
                shouldThrow)
                {
                    this_param.DealWithSetValueException(e, out shouldThrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 13633, 13678);
                    return 0;
                }


                string
                f_1294_14102_14111(System.Management.Automation.PSObjectPropertyDescriptor
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 14102, 14111);
                    return return_v;
                }


                string
                f_1294_14113_14122(System.Management.Automation.ExtendedTypeSystemException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 14113, 14122);
                    return return_v;
                }


                int
                f_1294_13989_14123(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 13989, 14123);
                    return 0;
                }


                int
                f_1294_14177_14222(System.Management.Automation.PSObjectPropertyDescriptor
                this_param, System.Management.Automation.ExtendedTypeSystemException
                e, out bool
                shouldThrow)
                {
                    this_param.DealWithSetValueException(e, out shouldThrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 14177, 14222);
                    return 0;
                }


                int
                f_1294_14354_14396(System.Management.Automation.PSObjectPropertyDescriptor
                this_param, object
                component, System.EventArgs
                e)
                {
                    this_param.OnValueChanged(component, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 14354, 14396);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 12723, 14408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 12723, 14408);
            }
        }

        private void DealWithSetValueException(ExtendedTypeSystemException e, out bool shouldThrow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 14420, 15063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 14536, 14617);

                SettingValueExceptionEventArgs
                eventArgs = f_1294_14579_14616(e)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 14631, 14979) || true) && (SettingValueException != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 14631, 14979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 14698, 14748);

                    f_1294_14698_14747(SettingValueException, this, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 14766, 14964);

                    f_1294_14766_14963(PSObjectTypeDescriptor.typeDescriptor, "SettingValueException event has been triggered resulting in ShouldThrow:\"{0}\".", f_1294_14941_14962(eventArgs));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 14631, 14979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 14995, 15031);

                shouldThrow = f_1294_15009_15030(eventArgs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 15045, 15052);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 14420, 15063);

                System.Management.Automation.SettingValueExceptionEventArgs
                f_1294_14579_14616(System.Management.Automation.ExtendedTypeSystemException
                exception)
                {
                    var return_v = new System.Management.Automation.SettingValueExceptionEventArgs((System.Exception)exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 14579, 14616);
                    return return_v;
                }


                int
                f_1294_14698_14747(System.EventHandler<System.Management.Automation.SettingValueExceptionEventArgs>
                eventHandler, System.Management.Automation.PSObjectPropertyDescriptor
                sender, System.Management.Automation.SettingValueExceptionEventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.Management.Automation.SettingValueExceptionEventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 14698, 14747);
                    return 0;
                }


                bool
                f_1294_14941_14962(System.Management.Automation.SettingValueExceptionEventArgs
                this_param)
                {
                    var return_v = this_param.ShouldThrow;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 14941, 14962);
                    return return_v;
                }


                int
                f_1294_14766_14963(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 14766, 14963);
                    return 0;
                }


                bool
                f_1294_15009_15030(System.Management.Automation.SettingValueExceptionEventArgs
                this_param)
                {
                    var return_v = this_param.ShouldThrow;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 15009, 15030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 14420, 15063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 14420, 15063);
            }
        }

        static PSObjectPropertyDescriptor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1294, 4157, 15070);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1294, 4157, 15070);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 4157, 15070);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1294, 4157, 15070);

        static System.Attribute[]
        f_1294_4587_4611()
        {
            var return_v = Array.Empty<Attribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 4587, 4611);
            return return_v;
        }


        static string
        f_1294_4573_4585_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1294, 4420, 4760);
            return return_v;
        }

    }
    public class PSObjectTypeDescriptor : CustomTypeDescriptor
    {
        internal static PSTraceSource typeDescriptor;

        /// <summary>
        /// Occurs when there was an exception setting the value of a property.
        /// </summary>
        /// <remarks>
        /// The ShouldThrow property of the <see cref="SettingValueExceptionEventArgs"/> allows
        /// subscribers to prevent the exception from being thrown.
        /// </remarks>
        public event EventHandler<SettingValueExceptionEventArgs>
SettingValueException
;

        /// <summary>
        /// Occurs when there was an exception getting the value of a property.
        /// </summary>
        /// <remarks>
        /// The ShouldThrow property of the <see cref="GettingValueExceptionEventArgs"/> allows
        /// subscribers to prevent the exception from being thrown.
        /// </remarks>
        public event EventHandler<GettingValueExceptionEventArgs>
GettingValueException
;

        public PSObjectTypeDescriptor(PSObject instance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1294, 16714, 16818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 16970, 17003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 16787, 16807);

                Instance = instance;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1294, 16714, 16818);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 16714, 16818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 16714, 16818);
            }
        }

        public PSObject Instance { get; }

        private void CheckAndAddProperty(PSPropertyInfo propertyInfo, Attribute[] attributes, ref PropertyDescriptorCollection returnValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 17015, 20300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 17171, 20289);
                using (f_1294_17178_17252(typeDescriptor, "Checking property \"{0}\".", f_1294_17234_17251(propertyInfo)))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 17396, 17616) || true) && (f_1294_17400_17424_M(!propertyInfo.IsGettable))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 17396, 17616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 17466, 17568);

                        f_1294_17466_17567(typeDescriptor, "Property \"{0}\" is write-only so it has been skipped.", f_1294_17549_17566(propertyInfo));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 17590, 17597);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 17396, 17616);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 17636, 17682);

                    AttributeCollection
                    propertyAttributes = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 17700, 17735);

                    Type
                    propertyType = typeof(object)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 17753, 19589) || true) && (attributes != null && (DynAbs.Tracing.TraceSender.Expression_True(1294, 17757, 17801) && f_1294_17779_17796(attributes) != 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 17753, 19589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 17843, 17892);

                        PSProperty
                        property = propertyInfo as PSProperty
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 17914, 19570) || true) && (property != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 17914, 19570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 17984, 18090);

                            DotNetAdapter.PropertyCacheEntry
                            propertyEntry = property.adapterData as DotNetAdapter.PropertyCacheEntry
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 18116, 19547) || true) && (propertyEntry == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 18116, 19547);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 18199, 18345);

                                f_1294_18199_18344(typeDescriptor, "Skipping attribute check for property \"{0}\" because it is an adapted property (not a .NET property).", f_1294_18330_18343(property));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 18116, 19547);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 18116, 19547);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 18403, 19547) || true) && (property.isDeserialized)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 18403, 19547);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 18669, 18792);

                                    f_1294_18669_18791(                            // At the moment we are not serializing attributes, so we can skip
                                                                                   // the attribute check if the property is deserialized.
                                                                typeDescriptor, "Skipping attribute check for property \"{0}\" because it has been deserialized.", f_1294_18777_18790(property));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 18403, 19547);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 18403, 19547);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 18906, 18948);

                                    propertyType = propertyEntry.propertyType;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 18978, 19024);

                                    propertyAttributes = f_1294_18999_19023(propertyEntry);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 19054, 19520);
                                        foreach (Attribute attribute in f_1294_19086_19096_I(attributes))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 19054, 19520);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 19162, 19489) || true) && (!f_1294_19167_19205(propertyAttributes, attribute))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 19162, 19489);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 19279, 19409);

                                                f_1294_19279_19408(typeDescriptor, "Property \"{0}\" does not contain attribute \"{1}\" so it has been skipped.", f_1294_19383_19396(property), attribute);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 19447, 19454);

                                                return;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 19162, 19489);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 19054, 19520);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1294, 1, 467);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1294, 1, 467);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 18403, 19547);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 18116, 19547);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 17914, 19570);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 17753, 19589);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 19609, 19747) || true) && (propertyAttributes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 19609, 19747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 19681, 19728);

                        propertyAttributes = f_1294_19702_19727();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 19609, 19747);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 19767, 19839);

                    f_1294_19767_19838(
                                    typeDescriptor, "Adding property \"{0}\".", f_1294_19820_19837(propertyInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 19859, 20038);

                    PSObjectPropertyDescriptor
                    propertyDescriptor =
                    f_1294_19928_20037(f_1294_19959_19976(propertyInfo), propertyType, f_1294_19992_20016_M(!propertyInfo.IsSettable), propertyAttributes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 20058, 20129);

                    propertyDescriptor.SettingValueException += this.SettingValueException;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 20147, 20218);

                    propertyDescriptor.GettingValueException += this.GettingValueException;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 20238, 20274);

                    f_1294_20238_20273(
                                    returnValue, propertyDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1294, 17171, 20289);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 17015, 20300);

                string
                f_1294_17234_17251(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 17234, 17251);
                    return return_v;
                }


                System.IDisposable
                f_1294_17178_17252(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 17178, 17252);
                    return return_v;
                }


                bool
                f_1294_17400_17424_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 17400, 17424);
                    return return_v;
                }


                string
                f_1294_17549_17566(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 17549, 17566);
                    return return_v;
                }


                int
                f_1294_17466_17567(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 17466, 17567);
                    return 0;
                }


                int
                f_1294_17779_17796(System.Attribute[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 17779, 17796);
                    return return_v;
                }


                string
                f_1294_18330_18343(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 18330, 18343);
                    return return_v;
                }


                int
                f_1294_18199_18344(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 18199, 18344);
                    return 0;
                }


                string
                f_1294_18777_18790(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 18777, 18790);
                    return return_v;
                }


                int
                f_1294_18669_18791(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 18669, 18791);
                    return 0;
                }


                System.ComponentModel.AttributeCollection
                f_1294_18999_19023(System.Management.Automation.DotNetAdapter.PropertyCacheEntry
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 18999, 19023);
                    return return_v;
                }


                bool
                f_1294_19167_19205(System.ComponentModel.AttributeCollection
                this_param, System.Attribute
                attribute)
                {
                    var return_v = this_param.Contains(attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 19167, 19205);
                    return return_v;
                }


                string
                f_1294_19383_19396(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 19383, 19396);
                    return return_v;
                }


                int
                f_1294_19279_19408(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, System.Attribute
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 19279, 19408);
                    return 0;
                }


                System.Attribute[]
                f_1294_19086_19096_I(System.Attribute[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 19086, 19096);
                    return return_v;
                }


                System.ComponentModel.AttributeCollection
                f_1294_19702_19727(params System.Attribute[]
                attributes)
                {
                    var return_v = new System.ComponentModel.AttributeCollection(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 19702, 19727);
                    return return_v;
                }


                string
                f_1294_19820_19837(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 19820, 19837);
                    return return_v;
                }


                int
                f_1294_19767_19838(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 19767, 19838);
                    return 0;
                }


                string
                f_1294_19959_19976(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 19959, 19976);
                    return return_v;
                }


                bool
                f_1294_19992_20016_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 19992, 20016);
                    return return_v;
                }


                System.Management.Automation.PSObjectPropertyDescriptor
                f_1294_19928_20037(string
                propertyName, System.Type
                propertyType, bool
                isReadOnly, System.ComponentModel.AttributeCollection
                propertyAttributes)
                {
                    var return_v = new System.Management.Automation.PSObjectPropertyDescriptor(propertyName, propertyType, isReadOnly, propertyAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 19928, 20037);
                    return return_v;
                }


                int
                f_1294_20238_20273(System.ComponentModel.PropertyDescriptorCollection
                this_param, System.Management.Automation.PSObjectPropertyDescriptor
                value)
                {
                    var return_v = this_param.Add((System.ComponentModel.PropertyDescriptor)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 20238, 20273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 17015, 20300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 17015, 20300);
            }
        }

        public override PropertyDescriptorCollection GetProperties()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 20653, 20776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 20738, 20765);

                return f_1294_20745_20764(this, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 20653, 20776);

                System.ComponentModel.PropertyDescriptorCollection
                f_1294_20745_20764(System.Management.Automation.PSObjectTypeDescriptor
                this_param, System.Attribute[]
                attributes)
                {
                    var return_v = this_param.GetProperties(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 20745, 20764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 20653, 20776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 20653, 20776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 21283, 21939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 21390, 21928);
                using (f_1294_21397_21445(typeDescriptor, "Getting properties."))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 21479, 21561);

                    PropertyDescriptorCollection
                    returnValue = f_1294_21522_21560(null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 21579, 21679) || true) && (f_1294_21583_21591() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 21579, 21679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 21641, 21660);

                        return returnValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 21579, 21679);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 21699, 21874);
                        foreach (PSPropertyInfo property in f_1294_21735_21754_I(f_1294_21735_21754(f_1294_21735_21743())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 21699, 21874);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 21796, 21855);

                            f_1294_21796_21854(this, property, attributes, ref returnValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 21699, 21874);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1294, 1, 176);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1294, 1, 176);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 21894, 21913);

                    return returnValue;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1294, 21390, 21928);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 21283, 21939);

                System.IDisposable
                f_1294_21397_21445(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 21397, 21445);
                    return return_v;
                }


                System.ComponentModel.PropertyDescriptorCollection
                f_1294_21522_21560(System.ComponentModel.PropertyDescriptor[]
                properties)
                {
                    var return_v = new System.ComponentModel.PropertyDescriptorCollection(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 21522, 21560);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_21583_21591()
                {
                    var return_v = Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 21583, 21591);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_21735_21743()
                {
                    var return_v = Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 21735, 21743);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1294_21735_21754(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 21735, 21754);
                    return return_v;
                }


                int
                f_1294_21796_21854(System.Management.Automation.PSObjectTypeDescriptor
                this_param, System.Management.Automation.PSPropertyInfo
                propertyInfo, System.Attribute[]
                attributes, ref System.ComponentModel.PropertyDescriptorCollection
                returnValue)
                {
                    this_param.CheckAndAddProperty(propertyInfo, attributes, ref returnValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 21796, 21854);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1294_21735_21754_I(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 21735, 21754);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 21283, 21939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 21283, 21939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 22338, 22779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 22402, 22463);

                PSObjectTypeDescriptor
                other = obj as PSObjectTypeDescriptor
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 22477, 22556) || true) && (other == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 22477, 22556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 22528, 22541);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 22477, 22556);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 22572, 22708) || true) && (f_1294_22576_22589(this) == null || (DynAbs.Tracing.TraceSender.Expression_False(1294, 22576, 22623) || f_1294_22601_22615(other) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 22572, 22708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 22657, 22693);

                    return f_1294_22664_22692(this, other);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 22572, 22708);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 22724, 22768);

                return f_1294_22731_22767(f_1294_22731_22745(other), f_1294_22753_22766(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 22338, 22779);

                System.Management.Automation.PSObject
                f_1294_22576_22589(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 22576, 22589);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_22601_22615(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 22601, 22615);
                    return return_v;
                }


                bool
                f_1294_22664_22692(System.Management.Automation.PSObjectTypeDescriptor
                objA, System.Management.Automation.PSObjectTypeDescriptor
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 22664, 22692);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_22731_22745(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 22731, 22745);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_22753_22766(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 22753, 22766);
                    return return_v;
                }


                bool
                f_1294_22731_22767(System.Management.Automation.PSObject
                this_param, System.Management.Automation.PSObject
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 22731, 22767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 22338, 22779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 22338, 22779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 22960, 23180);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 23018, 23118) || true) && (f_1294_23022_23035(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 23018, 23118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 23077, 23103);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 1294, 23084, 23102);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 23018, 23118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 23134, 23169);

                return f_1294_23141_23168(f_1294_23141_23154(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 22960, 23180);

                System.Management.Automation.PSObject
                f_1294_23022_23035(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 23022, 23035);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_23141_23154(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 23141, 23154);
                    return return_v;
                }


                int
                f_1294_23141_23168(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 23141, 23168);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 22960, 23180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 22960, 23180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PropertyDescriptor GetDefaultProperty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 23515, 25419);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 23595, 23681) || true) && (f_1294_23599_23612(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 23595, 23681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 23654, 23666);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 23595, 23681);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 23697, 23727);

                string
                defaultProperty = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 23741, 23803);

                PSMemberSet
                standardMembers = f_1294_23771_23802(f_1294_23771_23784(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 23817, 24128) || true) && (standardMembers != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 23817, 24128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 23878, 23979);

                    PSNoteProperty
                    note = f_1294_23900_23960(f_1294_23900_23926(standardMembers), TypeTable.DefaultDisplayProperty) as PSNoteProperty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 23997, 24113) || true) && (note != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 23997, 24113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 24055, 24094);

                        defaultProperty = f_1294_24073_24083(note) as string;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 23997, 24113);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 23817, 24128);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 24144, 24760) || true) && (defaultProperty == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 24144, 24760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 24205, 24337);

                    object[]
                    defaultPropertyAttributes = f_1294_24242_24336(f_1294_24242_24276(f_1294_24242_24266(f_1294_24242_24255(this))), typeof(DefaultPropertyAttribute), true)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 24355, 24745) || true) && (f_1294_24359_24391(defaultPropertyAttributes) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 24355, 24745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 24438, 24547);

                        DefaultPropertyAttribute
                        defaultPropertyAttribute = defaultPropertyAttributes[0] as DefaultPropertyAttribute
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 24569, 24726) || true) && (defaultPropertyAttribute != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 24569, 24726);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 24655, 24703);

                            defaultProperty = f_1294_24673_24702(defaultPropertyAttribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 24569, 24726);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 24355, 24745);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 24144, 24760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 24776, 24839);

                PropertyDescriptorCollection
                properties = f_1294_24818_24838(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 24855, 25380) || true) && (defaultProperty != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 24855, 25380);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 25074, 25365);
                        foreach (PropertyDescriptor descriptor in f_1294_25116_25126_I(properties))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 25074, 25365);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 25168, 25346) || true) && (f_1294_25172_25255(f_1294_25186_25201(descriptor), defaultProperty, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 25168, 25346);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 25305, 25323);

                                return descriptor;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 25168, 25346);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 25074, 25365);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1294, 1, 292);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1294, 1, 292);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 24855, 25380);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 25396, 25408);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 23515, 25419);

                System.Management.Automation.PSObject
                f_1294_23599_23612(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 23599, 23612);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_23771_23784(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 23771, 23784);
                    return return_v;
                }


                System.Management.Automation.PSMemberSet
                f_1294_23771_23802(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.PSStandardMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 23771, 23802);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1294_23900_23926(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 23900, 23926);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1294_23900_23960(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 23900, 23960);
                    return return_v;
                }


                object
                f_1294_24073_24083(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 24073, 24083);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_24242_24255(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 24242, 24255);
                    return return_v;
                }


                object
                f_1294_24242_24266(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 24242, 24266);
                    return return_v;
                }


                System.Type
                f_1294_24242_24276(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 24242, 24276);
                    return return_v;
                }


                object[]
                f_1294_24242_24336(System.Type
                this_param, System.Type
                attributeType, bool
                inherit)
                {
                    var return_v = this_param.GetCustomAttributes(attributeType, inherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 24242, 24336);
                    return return_v;
                }


                int
                f_1294_24359_24391(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 24359, 24391);
                    return return_v;
                }


                string
                f_1294_24673_24702(System.ComponentModel.DefaultPropertyAttribute
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 24673, 24702);
                    return return_v;
                }


                System.ComponentModel.PropertyDescriptorCollection
                f_1294_24818_24838(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.GetProperties();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 24818, 24838);
                    return return_v;
                }


                string
                f_1294_25186_25201(System.ComponentModel.PropertyDescriptor
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 25186, 25201);
                    return return_v;
                }


                bool
                f_1294_25172_25255(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 25172, 25255);
                    return return_v;
                }


                System.ComponentModel.PropertyDescriptorCollection
                f_1294_25116_25126_I(System.ComponentModel.PropertyDescriptorCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 25116, 25126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 23515, 25419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 23515, 25419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override TypeConverter GetConverter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 25740, 26361);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 25809, 26062) || true) && (f_1294_25813_25826(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 25809, 26062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 26020, 26047);

                    return f_1294_26027_26046();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 25809, 26062);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 26078, 26123);

                object
                baseObject = f_1294_26098_26122(f_1294_26098_26111(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 26137, 26320);

                TypeConverter
                retValue = f_1294_26162_26221(f_1294_26194_26214(baseObject), null) as TypeConverter ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.ComponentModel.TypeConverter>(1294, 26162, 26319) ?? f_1294_26280_26319(baseObject))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 26334, 26350);

                return retValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 25740, 26361);

                System.Management.Automation.PSObject
                f_1294_25813_25826(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 25813, 25826);
                    return return_v;
                }


                System.ComponentModel.TypeConverter
                f_1294_26027_26046()
                {
                    var return_v = new System.ComponentModel.TypeConverter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 26027, 26046);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_26098_26111(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 26098, 26111);
                    return return_v;
                }


                object
                f_1294_26098_26122(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 26098, 26122);
                    return return_v;
                }


                System.Type
                f_1294_26194_26214(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 26194, 26214);
                    return return_v;
                }


                object
                f_1294_26162_26221(System.Type
                type, System.Management.Automation.Runspaces.TypeTable
                backupTypeTable)
                {
                    var return_v = LanguagePrimitives.GetConverter(type, backupTypeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 26162, 26221);
                    return return_v;
                }


                System.ComponentModel.TypeConverter
                f_1294_26280_26319(object
                component)
                {
                    var return_v = TypeDescriptor.GetConverter(component);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 26280, 26319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 25740, 26361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 25740, 26361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object GetPropertyOwner(PropertyDescriptor pd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 26709, 26828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 26796, 26817);

                return f_1294_26803_26816(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 26709, 26828);

                System.Management.Automation.PSObject
                f_1294_26803_26816(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 26803, 26816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 26709, 26828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 26709, 26828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override EventDescriptor GetDefaultEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 28050, 28301);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 28124, 28210) || true) && (f_1294_28128_28141(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 28124, 28210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 28183, 28195);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 28124, 28210);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 28226, 28290);

                return f_1294_28233_28289(f_1294_28264_28288(f_1294_28264_28277(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 28050, 28301);

                System.Management.Automation.PSObject
                f_1294_28128_28141(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 28128, 28141);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_28264_28277(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 28264, 28277);
                    return return_v;
                }


                object
                f_1294_28264_28288(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 28264, 28288);
                    return return_v;
                }


                System.ComponentModel.EventDescriptor
                f_1294_28233_28289(object
                component)
                {
                    var return_v = TypeDescriptor.GetDefaultEvent(component);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 28233, 28289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 28050, 28301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 28050, 28301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override EventDescriptorCollection GetEvents()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 28557, 28837);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 28635, 28752) || true) && (f_1294_28639_28652(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 28635, 28752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 28694, 28737);

                    return f_1294_28701_28736(null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 28635, 28752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 28768, 28826);

                return f_1294_28775_28825(f_1294_28800_28824(f_1294_28800_28813(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 28557, 28837);

                System.Management.Automation.PSObject
                f_1294_28639_28652(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 28639, 28652);
                    return return_v;
                }


                System.ComponentModel.EventDescriptorCollection
                f_1294_28701_28736(System.ComponentModel.EventDescriptor[]
                events)
                {
                    var return_v = new System.ComponentModel.EventDescriptorCollection(events);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 28701, 28736);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_28800_28813(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 28800, 28813);
                    return return_v;
                }


                object
                f_1294_28800_28824(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 28800, 28824);
                    return return_v;
                }


                System.ComponentModel.EventDescriptorCollection
                f_1294_28775_28825(object
                component)
                {
                    var return_v = TypeDescriptor.GetEvents(component);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 28775, 28825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 28557, 28837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 28557, 28837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 29283, 29566);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 29383, 29469) || true) && (f_1294_29387_29400(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 29383, 29469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 29442, 29454);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 29383, 29469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 29485, 29555);

                return f_1294_29492_29554(f_1294_29517_29541(f_1294_29517_29530(this)), attributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 29283, 29566);

                System.Management.Automation.PSObject
                f_1294_29387_29400(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 29387, 29400);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_29517_29530(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 29517, 29530);
                    return return_v;
                }


                object
                f_1294_29517_29541(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 29517, 29541);
                    return return_v;
                }


                System.ComponentModel.EventDescriptorCollection
                f_1294_29492_29554(object
                component, System.Attribute[]
                attributes)
                {
                    var return_v = TypeDescriptor.GetEvents(component, attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 29492, 29554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 29283, 29566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 29283, 29566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AttributeCollection GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 29814, 30086);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 29890, 29997) || true) && (f_1294_29894_29907(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 29890, 29997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 29949, 29982);

                    return f_1294_29956_29981();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 29890, 29997);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 30013, 30075);

                return f_1294_30020_30074(f_1294_30049_30073(f_1294_30049_30062(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 29814, 30086);

                System.Management.Automation.PSObject
                f_1294_29894_29907(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 29894, 29907);
                    return return_v;
                }


                System.ComponentModel.AttributeCollection
                f_1294_29956_29981(params System.Attribute[]
                attributes)
                {
                    var return_v = new System.ComponentModel.AttributeCollection(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 29956, 29981);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_30049_30062(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 30049, 30062);
                    return return_v;
                }


                object
                f_1294_30049_30073(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 30049, 30073);
                    return return_v;
                }


                System.ComponentModel.AttributeCollection
                f_1294_30020_30074(object
                component)
                {
                    var return_v = TypeDescriptor.GetAttributes(component);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 30020, 30074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 29814, 30086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 29814, 30086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string GetClassName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 30340, 30576);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 30402, 30488) || true) && (f_1294_30406_30419(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 30402, 30488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 30461, 30473);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 30402, 30488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 30504, 30565);

                return f_1294_30511_30564(f_1294_30539_30563(f_1294_30539_30552(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 30340, 30576);

                System.Management.Automation.PSObject
                f_1294_30406_30419(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 30406, 30419);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_30539_30552(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 30539, 30552);
                    return return_v;
                }


                object
                f_1294_30539_30563(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 30539, 30563);
                    return return_v;
                }


                string
                f_1294_30511_30564(object
                component)
                {
                    var return_v = TypeDescriptor.GetClassName(component);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 30511, 30564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 30340, 30576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 30340, 30576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string GetComponentName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 30815, 31059);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 30881, 30967) || true) && (f_1294_30885_30898(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 30881, 30967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 30940, 30952);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 30881, 30967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 30983, 31048);

                return f_1294_30990_31047(f_1294_31022_31046(f_1294_31022_31035(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 30815, 31059);

                System.Management.Automation.PSObject
                f_1294_30885_30898(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 30885, 30898);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_31022_31035(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 31022, 31035);
                    return return_v;
                }


                object
                f_1294_31022_31046(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 31022, 31046);
                    return return_v;
                }


                string
                f_1294_30990_31047(object
                component)
                {
                    var return_v = TypeDescriptor.GetComponentName(component);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 30990, 31047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 30815, 31059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 30815, 31059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object GetEditor(Type editorBaseType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 31480, 31745);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 31558, 31644) || true) && (f_1294_31562_31575(this) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1294, 31558, 31644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 31617, 31629);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1294, 31558, 31644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 31660, 31734);

                return f_1294_31667_31733(f_1294_31692_31716(f_1294_31692_31705(this)), editorBaseType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 31480, 31745);

                System.Management.Automation.PSObject
                f_1294_31562_31575(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 31562, 31575);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1294_31692_31705(System.Management.Automation.PSObjectTypeDescriptor
                this_param)
                {
                    var return_v = this_param.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 31692, 31705);
                    return return_v;
                }


                object
                f_1294_31692_31716(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1294, 31692, 31716);
                    return return_v;
                }


                object
                f_1294_31667_31733(object
                component, System.Type
                editorBaseType)
                {
                    var return_v = TypeDescriptor.GetEditor(component, editorBaseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 31667, 31733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 31480, 31745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 31480, 31745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSObjectTypeDescriptor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1294, 15218, 31796);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 15323, 15502);
            typeDescriptor = f_1294_15340_15502("TypeDescriptor", "Traces the behavior of PSObjectTypeDescriptor, PSObjectTypeDescriptionProvider and PSObjectPropertyDescriptor.", false);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1294, 15218, 31796);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 15218, 31796);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1294, 15218, 31796);

        static System.Management.Automation.PSTraceSource
        f_1294_15340_15502(string
        name, string
        description, bool
        traceHeaders)
        {
            var return_v = PSTraceSource.GetTracer(name, description, traceHeaders);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 15340, 15502);
            return return_v;
        }

    }
    public class PSObjectTypeDescriptionProvider : TypeDescriptionProvider
    {        /// <summary>
             /// Occurs when there was an exception setting the value of a property.
             /// </summary>
             /// <remarks>
             /// The ShouldThrow property of the <see cref="SettingValueExceptionEventArgs"/> allows
             /// subscribers to prevent the exception from being thrown.
             /// </remarks>
        public event EventHandler<SettingValueExceptionEventArgs>
SettingValueException
;

        /// <summary>
        /// Occurs when there was an exception getting the value of a property.
        /// </summary>
        /// <remarks>
        /// The ShouldThrow property of the <see cref="GettingValueExceptionEventArgs"/> allows
        /// subscribers to prevent the exception from being thrown.
        /// </remarks>
        public event EventHandler<GettingValueExceptionEventArgs>
GettingValueException
;

        public PSObjectTypeDescriptionProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1294, 33085, 33147);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1294, 33085, 33147);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 33085, 33147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 33085, 33147);
            }
        }

        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1294, 34019, 36660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 34133, 34172);

                PSObject
                mshObj = instance as PSObject
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 36376, 36451);

                PSObjectTypeDescriptor
                typeDescriptor = f_1294_36416_36450(mshObj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 36465, 36532);

                typeDescriptor.SettingValueException += this.SettingValueException;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 36546, 36613);

                typeDescriptor.GettingValueException += this.GettingValueException;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1294, 36627, 36649);

                return typeDescriptor;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1294, 34019, 36660);

                System.Management.Automation.PSObjectTypeDescriptor
                f_1294_36416_36450(System.Management.Automation.PSObject
                instance)
                {
                    var return_v = new System.Management.Automation.PSObjectTypeDescriptor(instance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1294, 36416, 36450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1294, 34019, 36660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 34019, 36660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSObjectTypeDescriptionProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1294, 31996, 36667);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1294, 31996, 36667);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1294, 31996, 36667);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1294, 31996, 36667);
    }
}

