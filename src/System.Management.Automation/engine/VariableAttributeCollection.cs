// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    internal class PSVariableAttributeCollection : Collection<Attribute>
    {
        internal PSVariableAttributeCollection(PSVariable variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1373, 991, 1249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 5976, 5985);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 1075, 1201) || true) && (variable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1373, 1075, 1201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 1129, 1186);

                    throw f_1373_1135_1185("variable");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1373, 1075, 1201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 1217, 1238);

                _variable = variable;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1373, 991, 1249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1373, 991, 1249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1373, 991, 1249);
            }
        }

        protected override void InsertItem(int index, Attribute item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1373, 2150, 2399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 2236, 2284);

                object
                variableValue = f_1373_2259_2283(this, item)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 2300, 2329);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InsertItem(index, item), 1373, 2300, 2328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 2345, 2388);

                f_1373_2345_2387(
                            _variable, variableValue, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1373, 2150, 2399);

                object
                f_1373_2259_2283(System.Management.Automation.PSVariableAttributeCollection
                this_param, System.Attribute
                item)
                {
                    var return_v = this_param.VerifyNewAttribute(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1373, 2259, 2283);
                    return return_v;
                }


                int
                f_1373_2345_2387(System.Management.Automation.PSVariable
                this_param, object
                newValue, bool
                preserveValueTypeSemantics)
                {
                    this_param.SetValueRaw(newValue, preserveValueTypeSemantics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1373, 2345, 2387);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1373, 2150, 2399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1373, 2150, 2399);
            }
        }

        protected override void SetItem(int index, Attribute item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1373, 3004, 3247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 3087, 3135);

                object
                variableValue = f_1373_3110_3134(this, item)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 3151, 3177);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetItem(index, item), 1373, 3151, 3176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 3193, 3236);

                f_1373_3193_3235(
                            _variable, variableValue, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1373, 3004, 3247);

                object
                f_1373_3110_3134(System.Management.Automation.PSVariableAttributeCollection
                this_param, System.Attribute
                item)
                {
                    var return_v = this_param.VerifyNewAttribute(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1373, 3110, 3134);
                    return return_v;
                }


                int
                f_1373_3193_3235(System.Management.Automation.PSVariable
                this_param, object
                newValue, bool
                preserveValueTypeSemantics)
                {
                    this_param.SetValueRaw(newValue, preserveValueTypeSemantics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1373, 3193, 3235);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1373, 3004, 3247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1373, 3004, 3247);
            }
        }

        internal void AddAttributeNoCheck(Attribute item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1373, 3850, 3969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 3924, 3958);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InsertItem(f_1373_3940_3950(this), item), 1373, 3924, 3957);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1373, 3850, 3969);

                int
                f_1373_3940_3950(System.Management.Automation.PSVariableAttributeCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1373, 3940, 3950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1373, 3850, 3969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1373, 3850, 3969);
            }
        }

        private object VerifyNewAttribute(Attribute item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1373, 4446, 5795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 4520, 4559);

                object
                variableValue = f_1373_4543_4558(_variable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 4632, 4729);

                ArgumentTransformationAttribute
                argumentTransformation = item as ArgumentTransformationAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 4743, 5277) || true) && (argumentTransformation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1373, 4743, 5277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 4899, 4979);

                    ExecutionContext
                    context = f_1373_4926_4978()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 4997, 5028);

                    EngineIntrinsics
                    engine = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 5048, 5162) || true) && (context != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1373, 5048, 5162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 5109, 5143);

                        engine = f_1373_5118_5142(context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1373, 5048, 5162);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 5182, 5262);

                    variableValue = f_1373_5198_5261(argumentTransformation, engine, variableValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1373, 4743, 5277);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 5293, 5747) || true) && (!f_1373_5298_5342(variableValue, item))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1373, 5293, 5747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 5376, 5704);

                    ValidationMetadataException
                    e = f_1373_5408_5703("ValidateSetFailure", null, f_1373_5532_5571(), f_1373_5594_5608(_variable), ((DynAbs.Tracing.TraceSender.Conditional_F1(1373, 5632, 5657) || (((f_1373_5633_5648(_variable) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1373, 5660, 5686)) || DynAbs.Tracing.TraceSender.Conditional_F3(1373, 5689, 5701))) ? f_1373_5660_5686(f_1373_5660_5675(_variable)) : string.Empty))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 5724, 5732);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1373, 5293, 5747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1373, 5763, 5784);

                return variableValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1373, 4446, 5795);

                object
                f_1373_4543_4558(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1373, 4543, 4558);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1373_4926_4978()
                {
                    var return_v = Runspaces.LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1373, 4926, 4978);
                    return return_v;
                }


                System.Management.Automation.EngineIntrinsics
                f_1373_5118_5142(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineIntrinsics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1373, 5118, 5142);
                    return return_v;
                }


                object
                f_1373_5198_5261(System.Management.Automation.ArgumentTransformationAttribute
                this_param, System.Management.Automation.EngineIntrinsics
                engineIntrinsics, object
                inputData)
                {
                    var return_v = this_param.TransformInternal(engineIntrinsics, inputData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1373, 5198, 5261);
                    return return_v;
                }


                bool
                f_1373_5298_5342(object
                value, System.Attribute
                attribute)
                {
                    var return_v = PSVariable.IsValidValue(value, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1373, 5298, 5342);
                    return return_v;
                }


                string
                f_1373_5532_5571()
                {
                    var return_v = Metadata.InvalidMetadataForCurrentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1373, 5532, 5571);
                    return return_v;
                }


                string
                f_1373_5594_5608(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1373, 5594, 5608);
                    return return_v;
                }


                object
                f_1373_5633_5648(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1373, 5633, 5648);
                    return return_v;
                }


                object
                f_1373_5660_5675(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1373, 5660, 5675);
                    return return_v;
                }


                string?
                f_1373_5660_5686(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1373, 5660, 5686);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1373_5408_5703(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1373, 5408, 5703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1373, 4446, 5795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1373, 4446, 5795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSVariable _variable;

        static PSVariableAttributeCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1373, 338, 6026);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1373, 338, 6026);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1373, 338, 6026);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1373, 338, 6026);

        System.Management.Automation.PSArgumentNullException
        f_1373_1135_1185(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1373, 1135, 1185);
            return return_v;
        }

    }
}

