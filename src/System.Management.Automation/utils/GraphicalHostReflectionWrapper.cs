// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Internal
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Management.Automation;
    using System.Reflection;
    internal class GraphicalHostReflectionWrapper
    {
        private Assembly _graphicalHostAssembly;

        private Type _graphicalHostHelperType;

        private object _graphicalHostHelperObject;

        private GraphicalHostReflectionWrapper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1013, 1861, 1923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 1286, 1308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 1473, 1497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 1670, 1696);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1013, 1861, 1923);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1013, 1861, 1923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1013, 1861, 1923);
            }
        }

        internal static GraphicalHostReflectionWrapper GetGraphicalHostReflectionWrapper(PSCmdlet parentCmdlet, string graphicalHostHelperTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1013, 2739, 3060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 2903, 3049);

                return f_1013_2910_3048(parentCmdlet, graphicalHostHelperTypeName, f_1013_3018_3047(f_1013_3018_3042(parentCmdlet)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1013, 2739, 3060);

                System.Management.Automation.CommandInfo
                f_1013_3018_3042(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1013, 3018, 3042);
                    return return_v;
                }


                string
                f_1013_3018_3047(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1013, 3018, 3047);
                    return return_v;
                }


                System.Management.Automation.Internal.GraphicalHostReflectionWrapper
                f_1013_2910_3048(System.Management.Automation.PSCmdlet
                parentCmdlet, string
                graphicalHostHelperTypeName, string
                featureName)
                {
                    var return_v = GraphicalHostReflectionWrapper.GetGraphicalHostReflectionWrapper(parentCmdlet, graphicalHostHelperTypeName, featureName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 2910, 3048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1013, 2739, 3060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1013, 2739, 3060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Assembly.Load has been found to throw unadvertised exceptions")]
        internal static GraphicalHostReflectionWrapper GetGraphicalHostReflectionWrapper(PSCmdlet parentCmdlet, string graphicalHostHelperTypeName, string featureName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1013, 3948, 7476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 4302, 4384);

                GraphicalHostReflectionWrapper
                returnValue = f_1013_4347_4383()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 4400, 4872) || true) && (f_1013_4404_4468(parentCmdlet))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1013, 4400, 4872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 4502, 4795);

                    ErrorRecord
                    error = f_1013_4522_4794(f_1013_4560_4660(f_1013_4586_4659(f_1013_4604_4645(), featureName)), "RemotingNotSupported", ErrorCategory.InvalidOperation, parentCmdlet)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 4815, 4857);

                    f_1013_4815_4856(
                                    parentCmdlet, error);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1013, 4400, 4872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 4936, 4996);

                AssemblyName
                graphicalHostAssemblyName = f_1013_4977_4995()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 5010, 5080);

                graphicalHostAssemblyName.Name = "Microsoft.PowerShell.GraphicalHost";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 5094, 5154);

                graphicalHostAssemblyName.Version = f_1013_5130_5153(3, 0, 0, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 5168, 5238);

                graphicalHostAssemblyName.CultureInfo = f_1013_5208_5237(string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 5271, 5378);

                f_1013_5271_5377(graphicalHostAssemblyName, new byte[] { 0x31, 0xbf, 0x38, 0x56, 0xad, 0x36, 0x4e, 0x35 });

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 5430, 5508);

                    returnValue._graphicalHostAssembly = f_1013_5467_5507(graphicalHostAssemblyName);
                }
                catch (FileNotFoundException fileNotFoundEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1013, 5537, 6290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 5745, 5942);

                    string
                    errorMessage = f_1013_5767_5941(f_1013_5811_5853(), featureName, f_1013_5918_5940(fileNotFoundEx))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 5962, 6275);

                    f_1013_5962_6274(
                                    parentCmdlet, f_1013_6019_6273(f_1013_6061_6116(errorMessage, fileNotFoundEx), "ErrorLoadingAssembly", ErrorCategory.ObjectNotFound, graphicalHostAssemblyName));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1013, 5537, 6290);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1013, 6304, 6630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 6356, 6615);

                    f_1013_6356_6614(parentCmdlet, f_1013_6413_6613(e, "ErrorLoadingAssembly", ErrorCategory.ObjectNotFound, graphicalHostAssemblyName));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1013, 6304, 6630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 6646, 6757);

                returnValue._graphicalHostHelperType = f_1013_6685_6756(returnValue._graphicalHostAssembly, graphicalHostHelperTypeName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 6773, 6895);

                f_1013_6773_6894(returnValue._graphicalHostHelperType != null, "the type exists in Microsoft.PowerShell.GraphicalHost");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 6909, 7136);

                ConstructorInfo
                constructor = f_1013_6939_7135(returnValue._graphicalHostHelperType, BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 7152, 7430) || true) && (constructor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1013, 7152, 7430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 7209, 7287);

                    returnValue._graphicalHostHelperObject = f_1013_7250_7286(constructor, new object[] { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 7305, 7415);

                    f_1013_7305_7414(returnValue._graphicalHostHelperObject != null, "the constructor does not throw anything");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1013, 7152, 7430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 7446, 7465);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1013, 3948, 7476);

                System.Management.Automation.Internal.GraphicalHostReflectionWrapper
                f_1013_4347_4383()
                {
                    var return_v = new System.Management.Automation.Internal.GraphicalHostReflectionWrapper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 4347, 4383);
                    return return_v;
                }


                bool
                f_1013_4404_4468(System.Management.Automation.PSCmdlet
                parentCmdlet)
                {
                    var return_v = GraphicalHostReflectionWrapper.IsInputFromRemoting(parentCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 4404, 4468);
                    return return_v;
                }


                string
                f_1013_4604_4645()
                {
                    var return_v = HelpErrors.RemotingNotSupportedForFeature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1013, 4604, 4645);
                    return return_v;
                }


                string
                f_1013_4586_4659(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 4586, 4659);
                    return return_v;
                }


                System.NotSupportedException
                f_1013_4560_4660(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 4560, 4660);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1013_4522_4794(System.NotSupportedException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSCmdlet
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 4522, 4794);
                    return return_v;
                }


                int
                f_1013_4815_4856(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 4815, 4856);
                    return 0;
                }


                System.Reflection.AssemblyName
                f_1013_4977_4995()
                {
                    var return_v = new System.Reflection.AssemblyName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 4977, 4995);
                    return return_v;
                }


                System.Version
                f_1013_5130_5153(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 5130, 5153);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1013_5208_5237(string
                name)
                {
                    var return_v = new System.Globalization.CultureInfo(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 5208, 5237);
                    return return_v;
                }


                int
                f_1013_5271_5377(System.Reflection.AssemblyName
                this_param, byte[]
                publicKeyToken)
                {
                    this_param.SetPublicKeyToken(publicKeyToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 5271, 5377);
                    return 0;
                }


                System.Reflection.Assembly
                f_1013_5467_5507(System.Reflection.AssemblyName
                assemblyRef)
                {
                    var return_v = Assembly.Load(assemblyRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 5467, 5507);
                    return return_v;
                }


                string
                f_1013_5811_5853()
                {
                    var return_v = HelpErrors.GraphicalHostAssemblyIsNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1013, 5811, 5853);
                    return return_v;
                }


                string
                f_1013_5918_5940(System.IO.FileNotFoundException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1013, 5918, 5940);
                    return return_v;
                }


                string
                f_1013_5767_5941(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 5767, 5941);
                    return return_v;
                }


                System.NotSupportedException
                f_1013_6061_6116(string
                message, System.IO.FileNotFoundException
                innerException)
                {
                    var return_v = new System.NotSupportedException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 6061, 6116);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1013_6019_6273(System.NotSupportedException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Reflection.AssemblyName
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 6019, 6273);
                    return return_v;
                }


                int
                f_1013_5962_6274(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 5962, 6274);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1013_6413_6613(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Reflection.AssemblyName
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 6413, 6613);
                    return return_v;
                }


                int
                f_1013_6356_6614(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 6356, 6614);
                    return 0;
                }


                System.Type?
                f_1013_6685_6756(System.Reflection.Assembly
                this_param, string
                name)
                {
                    var return_v = this_param.GetType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 6685, 6756);
                    return return_v;
                }


                int
                f_1013_6773_6894(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 6773, 6894);
                    return 0;
                }


                System.Reflection.ConstructorInfo?
                f_1013_6939_7135(System.Type
                this_param, System.Reflection.BindingFlags
                bindingAttr, System.Reflection.Binder?
                binder, System.Type[]
                types, System.Reflection.ParameterModifier[]?
                modifiers)
                {
                    var return_v = this_param.GetConstructor(bindingAttr, binder, types, modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 6939, 7135);
                    return return_v;
                }


                object
                f_1013_7250_7286(System.Reflection.ConstructorInfo
                this_param, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 7250, 7286);
                    return return_v;
                }


                int
                f_1013_7305_7414(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 7305, 7414);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1013, 3948, 7476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1013, 3948, 7476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string EscapeBinding(string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1013, 7761, 7910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 7843, 7899);

                return f_1013_7850_7898(f_1013_7850_7880(propertyName, "/", " "), ".", " ");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1013, 7761, 7910);

                string
                f_1013_7850_7880(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 7850, 7880);
                    return return_v;
                }


                string
                f_1013_7850_7898(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 7850, 7898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1013, 7761, 7910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1013, 7761, 7910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object CallMethod(string methodName, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1013, 8299, 8868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 8396, 8520);

                f_1013_8396_8519(_graphicalHostHelperObject != null, "there should be a constructor in order to call an instance method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 8534, 8649);

                MethodInfo
                method = f_1013_8554_8648(_graphicalHostHelperType, methodName, BindingFlags.NonPublic | BindingFlags.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 8663, 8783);

                f_1013_8663_8782(method != null, "method " + methodName + " exists in graphicalHostHelperType is verified by caller");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 8797, 8857);

                return f_1013_8804_8856(method, _graphicalHostHelperObject, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1013, 8299, 8868);

                int
                f_1013_8396_8519(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 8396, 8519);
                    return 0;
                }


                System.Reflection.MethodInfo?
                f_1013_8554_8648(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 8554, 8648);
                    return return_v;
                }


                int
                f_1013_8663_8782(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 8663, 8782);
                    return 0;
                }


                object?
                f_1013_8804_8856(System.Reflection.MethodInfo
                this_param, object
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 8804, 8856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1013, 8299, 8868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1013, 8299, 8868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object CallStaticMethod(string methodName, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1013, 9254, 9667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 9357, 9470);

                MethodInfo
                method = f_1013_9377_9469(_graphicalHostHelperType, methodName, BindingFlags.NonPublic | BindingFlags.Static)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 9484, 9604);

                f_1013_9484_9603(method != null, "method " + methodName + " exists in graphicalHostHelperType is verified by caller");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 9618, 9656);

                return f_1013_9625_9655(method, null, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1013, 9254, 9667);

                System.Reflection.MethodInfo?
                f_1013_9377_9469(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 9377, 9469);
                    return return_v;
                }


                int
                f_1013_9484_9603(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 9484, 9603);
                    return 0;
                }


                object?
                f_1013_9625_9655(System.Reflection.MethodInfo
                this_param, object?
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 9625, 9655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1013, 9254, 9667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1013, 9254, 9667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetPropertyValue(string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1013, 10029, 10611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 10107, 10238);

                f_1013_10107_10237(_graphicalHostHelperObject != null, "there should be a constructor in order to get an instance property value");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 10252, 10375);

                PropertyInfo
                property = f_1013_10276_10374(_graphicalHostHelperType, propertyName, BindingFlags.NonPublic | BindingFlags.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 10389, 10515);

                f_1013_10389_10514(property != null, "property " + propertyName + " exists in graphicalHostHelperType is verified by caller");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 10529, 10600);

                return f_1013_10536_10599(property, _graphicalHostHelperObject, new object[] { });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1013, 10029, 10611);

                int
                f_1013_10107_10237(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 10107, 10237);
                    return 0;
                }


                System.Reflection.PropertyInfo?
                f_1013_10276_10374(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetProperty(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 10276, 10374);
                    return return_v;
                }


                int
                f_1013_10389_10514(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 10389, 10514);
                    return 0;
                }


                object?
                f_1013_10536_10599(System.Reflection.PropertyInfo
                this_param, object
                obj, object[]
                index)
                {
                    var return_v = this_param.GetValue(obj, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 10536, 10599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1013, 10029, 10611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1013, 10029, 10611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetStaticPropertyValue(string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1013, 10965, 11384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 11049, 11170);

                PropertyInfo
                property = f_1013_11073_11169(_graphicalHostHelperType, propertyName, BindingFlags.NonPublic | BindingFlags.Static)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 11184, 11310);

                f_1013_11184_11309(property != null, "property " + propertyName + " exists in graphicalHostHelperType is verified by caller");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 11324, 11373);

                return f_1013_11331_11372(property, null, new object[] { });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1013, 10965, 11384);

                System.Reflection.PropertyInfo?
                f_1013_11073_11169(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetProperty(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 11073, 11169);
                    return return_v;
                }


                int
                f_1013_11184_11309(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 11184, 11309);
                    return 0;
                }


                object?
                f_1013_11331_11372(System.Reflection.PropertyInfo
                this_param, object?
                obj, object[]
                index)
                {
                    var return_v = this_param.GetValue(obj, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 11331, 11372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1013, 10965, 11384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1013, 10965, 11384);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsInputFromRemoting(PSCmdlet parentCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1013, 11724, 12057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 11811, 11909);

                f_1013_11811_11908(f_1013_11830_11855(parentCmdlet) != null, "SessionState should always be available.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 11925, 12006);

                PSVariable
                senderInfo = f_1013_11949_12005(f_1013_11949_11985(f_1013_11949_11974(parentCmdlet)), "PSSenderInfo")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1013, 12020, 12046);

                return senderInfo != null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1013, 11724, 12057);

                System.Management.Automation.SessionState
                f_1013_11830_11855(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1013, 11830, 11855);
                    return return_v;
                }


                int
                f_1013_11811_11908(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 11811, 11908);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1013_11949_11974(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1013, 11949, 11974);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1013_11949_11985(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1013, 11949, 11985);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1013_11949_12005(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name)
                {
                    var return_v = this_param.Get(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1013, 11949, 12005);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1013, 11724, 12057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1013, 11724, 12057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static GraphicalHostReflectionWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1013, 1040, 12064);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1013, 1040, 12064);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1013, 1040, 12064);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1013, 1040, 12064);
    }
}
