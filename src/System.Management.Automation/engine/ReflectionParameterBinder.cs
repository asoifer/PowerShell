// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Management.Automation.Internal;
using System.Reflection;

using Microsoft.PowerShell.Commands;

namespace System.Management.Automation
{
    internal class ReflectionParameterBinder : ParameterBinderBase
    {
        internal ReflectionParameterBinder(
                    object target,
                    Cmdlet command)
        : base(f_1328_1230_1236_C(target), f_1328_1238_1258(command), f_1328_1260_1275(command), command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1328, 1117, 1307);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1328, 1117, 1307);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1328, 1117, 1307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1328, 1117, 1307);
            }
        }

        internal ReflectionParameterBinder(
                    object target,
                    Cmdlet command,
                    CommandLineParameters commandLineParameters)
        : base(f_1328_2164_2170_C(target), f_1328_2172_2192(command), f_1328_2194_2209(command), command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1328, 1993, 2306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 2244, 2295);

                this.CommandLineParameters = commandLineParameters;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1328, 1993, 2306);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1328, 1993, 2306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1328, 1993, 2306);
            }
        }

        internal override object GetDefaultParameterValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1328, 2918, 3803);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 3041, 3090);

                    // LAFHIS
                    //return f_1328_3048_3089(f_1328_3048_3081(f_1328_3058_3074(f_1328_3058_3064()), name)(f_1328_3082_3088()), f_1328_3082_3088());
                    var temp = (f_1328_3048_3081(f_1328_3058_3074(f_1328_3058_3064()), name)(f_1328_3082_3088()));
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 3048, 3089);
                    return temp;
                }
                catch (TargetInvocationException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1328, 3119, 3467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 3188, 3230);

                    Exception
                    inner = f_1328_3206_3223(ex) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Exception>(1328, 3206, 3229) ?? ex)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 3248, 3452);

                    throw f_1328_3254_3451("CatchFromBaseAdapterGetValueTI", inner, f_1328_3369_3408(), name, f_1328_3437_3450(inner));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1328, 3119, 3467);
                }
                catch (GetValueException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1328, 3481, 3517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 3509, 3515);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1328, 3481, 3517);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1328, 3531, 3792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 3583, 3777);

                    throw f_1328_3589_3776("CatchFromBaseAdapterGetValue", e, f_1328_3698_3737(), name, f_1328_3766_3775(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1328, 3531, 3792);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1328, 2918, 3803);

                object
                f_1328_3058_3064()
                {
                    var return_v = Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 3058, 3064);
                    return return_v;
                }


                System.Type
                f_1328_3058_3074(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 3058, 3074);
                    return return_v;
                }


                System.Func<object, object>
                f_1328_3048_3081(System.Type
                type, string
                property)
                {
                    var return_v = GetGetter(type, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 3048, 3081);
                    return return_v;
                }


                object
                f_1328_3082_3088()
                {
                    var return_v = Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 3082, 3088);
                    return return_v;
                }


                //System.Func<object, object>
                //f_1328_3048_3089(System.Func<object, object>
                //this_param, object
                //arg)
                //{
                //    var return_v = this_param.Invoke(arg);
                //    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 3048, 3089);
                //    return return_v;
                //}


                System.Exception
                f_1328_3206_3223(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 3206, 3223);
                    return return_v;
                }


                string
                f_1328_3369_3408()
                {
                    var return_v = ExtendedTypeSystem.ExceptionWhenGetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 3369, 3408);
                    return return_v;
                }


                string
                f_1328_3437_3450(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 3437, 3450);
                    return return_v;
                }


                System.Management.Automation.GetValueInvocationException
                f_1328_3254_3451(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.GetValueInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 3254, 3451);
                    return return_v;
                }


                string
                f_1328_3698_3737()
                {
                    var return_v = ExtendedTypeSystem.ExceptionWhenGetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 3698, 3737);
                    return return_v;
                }


                string
                f_1328_3766_3775(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 3766, 3775);
                    return return_v;
                }


                System.Management.Automation.GetValueInvocationException
                f_1328_3589_3776(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.GetValueInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 3589, 3776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1328, 2918, 3803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1328, 2918, 3803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void BindParameter(string name, object value, CompiledCommandParameter parameterMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1328, 4651, 5883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 4783, 4866);

                f_1328_4783_4865(!f_1328_4803_4829(name), "caller to verify name parameter");

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 4918, 5130);

                    var
                    setter = (DynAbs.Tracing.TraceSender.Conditional_F1(1328, 4931, 4956) || ((parameterMetadata != null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1328, 4980, 5072)) || DynAbs.Tracing.TraceSender.Conditional_F3(1328, 5096, 5129))) ? (f_1328_4981_5005(parameterMetadata) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Action<object, object>>(1328, 4981, 5071) ?? (parameterMetadata.Setter = f_1328_5037_5070(f_1328_5047_5063(f_1328_5047_5053()), name))))
                    : f_1328_5096_5129(f_1328_5106_5122(f_1328_5106_5112()), name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 5148, 5170);

                    f_1328_5148_5169(setter, f_1328_5155_5161(), value);
                }
                catch (TargetInvocationException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1328, 5199, 5547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 5268, 5310);

                    Exception
                    inner = f_1328_5286_5303(ex) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Exception>(1328, 5286, 5309) ?? ex)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 5328, 5532);

                    throw f_1328_5334_5531("CatchFromBaseAdapterSetValueTI", inner, f_1328_5449_5488(), name, f_1328_5517_5530(inner));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1328, 5199, 5547);
                }
                catch (SetValueException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1328, 5561, 5597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 5589, 5595);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1328, 5561, 5597);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1328, 5611, 5872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 5663, 5857);

                    throw f_1328_5669_5856("CatchFromBaseAdapterSetValue", e, f_1328_5778_5817(), name, f_1328_5846_5855(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1328, 5611, 5872);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1328, 4651, 5883);

                bool
                f_1328_4803_4829(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 4803, 4829);
                    return return_v;
                }


                int
                f_1328_4783_4865(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 4783, 4865);
                    return 0;
                }


                System.Action<object, object>
                f_1328_4981_5005(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Setter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 4981, 5005);
                    return return_v;
                }


                object
                f_1328_5047_5053()
                {
                    var return_v = Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 5047, 5053);
                    return return_v;
                }


                System.Type
                f_1328_5047_5063(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 5047, 5063);
                    return return_v;
                }


                System.Action<object, object>
                f_1328_5037_5070(System.Type
                type, string
                property)
                {
                    var return_v = GetSetter(type, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 5037, 5070);
                    return return_v;
                }


                object
                f_1328_5106_5112()
                {
                    var return_v = Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 5106, 5112);
                    return return_v;
                }


                System.Type
                f_1328_5106_5122(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 5106, 5122);
                    return return_v;
                }


                System.Action<object, object>
                f_1328_5096_5129(System.Type
                type, string
                property)
                {
                    var return_v = GetSetter(type, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 5096, 5129);
                    return return_v;
                }


                object
                f_1328_5155_5161()
                {
                    var return_v = Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 5155, 5161);
                    return return_v;
                }


                int
                f_1328_5148_5169(System.Action<object, object>
                this_param, object
                arg1, object
                arg2)
                {
                    this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 5148, 5169);
                    return 0;
                }


                System.Exception
                f_1328_5286_5303(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 5286, 5303);
                    return return_v;
                }


                string
                f_1328_5449_5488()
                {
                    var return_v = ExtendedTypeSystem.ExceptionWhenSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 5449, 5488);
                    return return_v;
                }


                string
                f_1328_5517_5530(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 5517, 5530);
                    return return_v;
                }


                System.Management.Automation.SetValueInvocationException
                f_1328_5334_5531(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.SetValueInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 5334, 5531);
                    return return_v;
                }


                string
                f_1328_5778_5817()
                {
                    var return_v = ExtendedTypeSystem.ExceptionWhenSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 5778, 5817);
                    return return_v;
                }


                string
                f_1328_5846_5855(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 5846, 5855);
                    return return_v;
                }


                System.Management.Automation.SetValueInvocationException
                f_1328_5669_5856(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.SetValueInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 5669, 5856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1328, 4651, 5883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1328, 4651, 5883);
            }
        }

        static ReflectionParameterBinder()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1328, 6009, 11666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 11766, 11866);
                s_getterMethods = f_1328_11797_11866();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 11967, 12069);
                s_setterMethods = f_1328_11998_12069();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 6197, 6317);

                f_1328_6197_6316(            // Statically add delegates that we typically need on startup or every time we run PowerShell - this avoids the JIT
                            s_getterMethods, f_1328_6220_6274(typeof(OutDefaultCommand), "InputObject"), o => ((OutDefaultCommand)o).InputObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 6331, 6470);

                f_1328_6331_6469(s_setterMethods, f_1328_6354_6408(typeof(OutDefaultCommand), "InputObject"), (o, v) => ((OutDefaultCommand)o).InputObject = (PSObject)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 6486, 6612);

                f_1328_6486_6611(
                            s_getterMethods, f_1328_6509_6566(typeof(OutLineOutputCommand), "InputObject"), o => ((OutLineOutputCommand)o).InputObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 6626, 6750);

                f_1328_6626_6749(s_getterMethods, f_1328_6649_6705(typeof(OutLineOutputCommand), "LineOutput"), o => ((OutLineOutputCommand)o).LineOutput);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 6764, 6909);

                f_1328_6764_6908(s_setterMethods, f_1328_6787_6844(typeof(OutLineOutputCommand), "InputObject"), (o, v) => ((OutLineOutputCommand)o).InputObject = (PSObject)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 6923, 7056);

                f_1328_6923_7055(s_setterMethods, f_1328_6946_7002(typeof(OutLineOutputCommand), "LineOutput"), (o, v) => ((OutLineOutputCommand)o).LineOutput = v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 7072, 7198);

                f_1328_7072_7197(
                            s_getterMethods, f_1328_7095_7152(typeof(FormatDefaultCommand), "InputObject"), o => ((FormatDefaultCommand)o).InputObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 7212, 7357);

                f_1328_7212_7356(s_setterMethods, f_1328_7235_7292(typeof(FormatDefaultCommand), "InputObject"), (o, v) => ((FormatDefaultCommand)o).InputObject = (PSObject)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 7373, 7509);

                f_1328_7373_7508(
                            s_setterMethods, f_1328_7396_7445(typeof(SetStrictModeCommand), "Off"), (o, v) => ((SetStrictModeCommand)o).Off = (SwitchParameter)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 7523, 7659);

                f_1328_7523_7658(s_setterMethods, f_1328_7546_7599(typeof(SetStrictModeCommand), "Version"), (o, v) => ((SetStrictModeCommand)o).Version = (Version)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 7675, 7801);

                f_1328_7675_7800(
                            s_getterMethods, f_1328_7698_7755(typeof(ForEachObjectCommand), "InputObject"), o => ((ForEachObjectCommand)o).InputObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 7815, 7960);

                f_1328_7815_7959(s_setterMethods, f_1328_7838_7895(typeof(ForEachObjectCommand), "InputObject"), (o, v) => ((ForEachObjectCommand)o).InputObject = (PSObject)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 7974, 8116);

                f_1328_7974_8115(s_setterMethods, f_1328_7997_8050(typeof(ForEachObjectCommand), "Process"), (o, v) => ((ForEachObjectCommand)o).Process = (ScriptBlock[])v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 8132, 8254);

                f_1328_8132_8253(
                            s_getterMethods, f_1328_8155_8210(typeof(WhereObjectCommand), "InputObject"), o => ((WhereObjectCommand)o).InputObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 8268, 8409);

                f_1328_8268_8408(s_setterMethods, f_1328_8291_8346(typeof(WhereObjectCommand), "InputObject"), (o, v) => ((WhereObjectCommand)o).InputObject = (PSObject)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 8423, 8569);

                f_1328_8423_8568(s_setterMethods, f_1328_8446_8502(typeof(WhereObjectCommand), "FilterScript"), (o, v) => ((WhereObjectCommand)o).FilterScript = (ScriptBlock)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 8585, 8714);

                f_1328_8585_8713(
                            s_setterMethods, f_1328_8608_8657(typeof(ImportModuleCommand), "Name"), (o, v) => ((ImportModuleCommand)o).Name = (string[])v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 8728, 8875);

                f_1328_8728_8874(s_setterMethods, f_1328_8751_8806(typeof(ImportModuleCommand), "ModuleInfo"), (o, v) => ((ImportModuleCommand)o).ModuleInfo = (PSModuleInfo[])v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 8889, 9018);

                f_1328_8889_9017(s_setterMethods, f_1328_8912_8962(typeof(ImportModuleCommand), "Scope"), (o, v) => ((ImportModuleCommand)o).Scope = (string)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 9032, 9176);

                f_1328_9032_9175(s_setterMethods, f_1328_9055_9108(typeof(ImportModuleCommand), "PassThru"), (o, v) => ((ImportModuleCommand)o).PassThru = (SwitchParameter)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 9192, 9317);

                f_1328_9192_9316(
                            s_setterMethods, f_1328_9215_9262(typeof(GetCommandCommand), "Name"), (o, v) => ((GetCommandCommand)o).Name = (string[])v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 9331, 9460);

                f_1328_9331_9459(s_setterMethods, f_1328_9354_9403(typeof(GetCommandCommand), "Module"), (o, v) => ((GetCommandCommand)o).Module = (string[])v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 9476, 9599);

                f_1328_9476_9598(
                            s_setterMethods, f_1328_9499_9545(typeof(GetModuleCommand), "Name"), (o, v) => ((GetModuleCommand)o).Name = (string[])v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 9613, 9761);

                f_1328_9613_9760(s_setterMethods, f_1328_9636_9691(typeof(GetModuleCommand), "ListAvailable"), (o, v) => ((GetModuleCommand)o).ListAvailable = (SwitchParameter)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 9775, 9939);

                f_1328_9775_9938(s_setterMethods, f_1328_9798_9858(typeof(GetModuleCommand), "FullyQualifiedName"), (o, v) => ((GetModuleCommand)o).FullyQualifiedName = (ModuleSpecification[])v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 9955, 10100);

                f_1328_9955_10099(
                            s_setterMethods, f_1328_9978_10031(typeof(CommonParameters), "ErrorAction"), (o, v) => ((CommonParameters)o).ErrorAction = (ActionPreference)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 10114, 10263);

                f_1328_10114_10262(s_setterMethods, f_1328_10137_10192(typeof(CommonParameters), "WarningAction"), (o, v) => ((CommonParameters)o).WarningAction = (ActionPreference)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 10277, 10434);

                f_1328_10277_10433(s_setterMethods, f_1328_10300_10359(typeof(CommonParameters), "InformationAction"), (o, v) => ((CommonParameters)o).InformationAction = (ActionPreference)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 10448, 10584);

                f_1328_10448_10583(s_setterMethods, f_1328_10471_10520(typeof(CommonParameters), "Verbose"), (o, v) => ((CommonParameters)o).Verbose = (SwitchParameter)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 10598, 10730);

                f_1328_10598_10729(s_setterMethods, f_1328_10621_10668(typeof(CommonParameters), "Debug"), (o, v) => ((CommonParameters)o).Debug = (SwitchParameter)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 10744, 10883);

                f_1328_10744_10882(s_setterMethods, f_1328_10767_10822(typeof(CommonParameters), "ErrorVariable"), (o, v) => ((CommonParameters)o).ErrorVariable = (string)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 10897, 11040);

                f_1328_10897_11039(s_setterMethods, f_1328_10920_10977(typeof(CommonParameters), "WarningVariable"), (o, v) => ((CommonParameters)o).WarningVariable = (string)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 11054, 11205);

                f_1328_11054_11204(s_setterMethods, f_1328_11077_11138(typeof(CommonParameters), "InformationVariable"), (o, v) => ((CommonParameters)o).InformationVariable = (string)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 11219, 11354);

                f_1328_11219_11353(s_setterMethods, f_1328_11242_11295(typeof(CommonParameters), "OutVariable"), (o, v) => ((CommonParameters)o).OutVariable = (string)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 11368, 11496);

                f_1328_11368_11495(s_setterMethods, f_1328_11391_11442(typeof(CommonParameters), "OutBuffer"), (o, v) => ((CommonParameters)o).OutBuffer = (int)v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 11510, 11655);

                f_1328_11510_11654(s_setterMethods, f_1328_11533_11591(typeof(CommonParameters), "PipelineVariable"), (o, v) => ((CommonParameters)o).PipelineVariable = (string)v);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1328, 6009, 11666);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1328, 6009, 11666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1328, 6009, 11666);
            }
        }

        private static readonly ConcurrentDictionary<Tuple<Type, string>, Func<object, object>> s_getterMethods
        ;

        private static readonly ConcurrentDictionary<Tuple<Type, string>, Action<object, object>> s_setterMethods;

        private static Func<object, object> GetGetter(Type type, string property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1328, 12082, 12725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 12180, 12714);

                return f_1328_12187_12713(s_getterMethods, f_1328_12212_12240(type, property), (Tuple<Type, string> _) =>
                                {
                                    var target = Expression.Parameter(typeof(object));
                                    return Expression.Lambda<Func<object, object>>(
                                        Expression.Convert(
                                            GetPropertyOrFieldExpr(type, property, Expression.Convert(target, type)),
                                            typeof(object)),
                                        new[] { target }).Compile();
                                });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1328, 12082, 12725);

                System.Tuple<System.Type, string>
                f_1328_12212_12240(System.Type
                item1, string
                item2)
                {
                    var return_v = Tuple.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 12212, 12240);
                    return return_v;
                }


                System.Func<object, object>
                f_1328_12187_12713(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Func<object, object>>
                this_param, System.Tuple<System.Type, string>
                key, System.Func<System.Tuple<System.Type, string>, System.Func<object, object>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 12187, 12713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1328, 12082, 12725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1328, 12082, 12725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Action<object, object> GetSetter(Type type, string property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1328, 12737, 14641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 12837, 14630);

                return f_1328_12844_14629(s_setterMethods, f_1328_12869_12897(type, property), _ =>
                                {
                                    var target = Expression.Parameter(typeof(object));
                                    var value = Expression.Parameter(typeof(object));
                                    var propertyExpr = GetPropertyOrFieldExpr(type, property, Expression.Convert(target, type));

                                    Expression expr = Expression.Assign(propertyExpr, Expression.Convert(value, propertyExpr.Type));
                                    if (propertyExpr.Type.IsValueType && Nullable.GetUnderlyingType(propertyExpr.Type) == null)
                                    {
                                        var throwInvalidCastExceptionExpr =
                                            Expression.Call(Language.CachedReflectionInfo.LanguagePrimitives_ThrowInvalidCastException,
                                                            Language.ExpressionCache.NullConstant,
                                                            Expression.Constant(propertyExpr.Type, typeof(Type)));

                        // The return type of 'ThrowInvalidCastException' is System.Object, but the method actually always
                        // throws 'PSInvalidCastException' when it's executed. So converting 'throwInvalidCastExceptionExpr'
                        // to 'propertyExpr.Type' is fine, because the conversion will never be hit.
                        expr = Expression.Condition(Expression.Equal(value, Language.ExpressionCache.NullConstant),
                                                                    Expression.Convert(throwInvalidCastExceptionExpr, propertyExpr.Type),
                                                                    expr);
                                    }

                                    return Expression.Lambda<Action<object, object>>(expr, new[] { target, value }).Compile();
                                });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1328, 12737, 14641);

                System.Tuple<System.Type, string>
                f_1328_12869_12897(System.Type
                item1, string
                item2)
                {
                    var return_v = Tuple.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 12869, 12897);
                    return return_v;
                }


                System.Action<object, object>
                f_1328_12844_14629(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
                this_param, System.Tuple<System.Type, string>
                key, System.Func<System.Tuple<System.Type, string>, System.Action<object, object>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 12844, 14629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1328, 12737, 14641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1328, 12737, 14641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Expression GetPropertyOrFieldExpr(Type type, string name, Expression target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1328, 14653, 16606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 14769, 14879);

                const BindingFlags
                bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 14929, 14985);

                    var
                    propertyInfo = f_1328_14948_14984(type, name, bindingFlags)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 15003, 15099) || true) && (propertyInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1328, 15003, 15099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 15050, 15099);

                        return f_1328_15057_15098(target, propertyInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1328, 15003, 15099);
                    }
                }
                catch (AmbiguousMatchException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1328, 15128, 15852);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 15533, 15837);
                        foreach (var propertyInfo in f_1328_15562_15594_I(f_1328_15562_15594(type, bindingFlags)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1328, 15533, 15837);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 15636, 15818) || true) && (f_1328_15640_15696(f_1328_15640_15657(propertyInfo), name, StringComparison.Ordinal))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1328, 15636, 15818);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 15746, 15795);

                                return f_1328_15753_15794(target, propertyInfo);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1328, 15636, 15818);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1328, 15533, 15837);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1328, 1, 305);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1328, 1, 305);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1328, 15128, 15852);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 15904, 15954);

                    var
                    fieldInfo = f_1328_15920_15953(type, name, bindingFlags)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 15972, 16059) || true) && (fieldInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1328, 15972, 16059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 16016, 16059);

                        return f_1328_16023_16058(target, fieldInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1328, 15972, 16059);
                    }
                }
                catch (AmbiguousMatchException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1328, 16088, 16455);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 16152, 16440);
                        foreach (var fieldInfo in f_1328_16178_16206_I(f_1328_16178_16206(type, bindingFlags)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1328, 16152, 16440);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 16248, 16421) || true) && (f_1328_16252_16305(f_1328_16252_16266(fieldInfo), name, StringComparison.Ordinal))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1328, 16248, 16421);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 16355, 16398);

                                return f_1328_16362_16397(target, fieldInfo);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1328, 16248, 16421);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1328, 16152, 16440);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1328, 1, 289);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1328, 1, 289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1328, 16088, 16455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 16471, 16530);

                f_1328_16471_16529(false, "Can't find property or field?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1328, 16544, 16595);

                throw f_1328_16550_16594();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1328, 14653, 16606);

                System.Reflection.PropertyInfo?
                f_1328_14948_14984(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetProperty(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 14948, 14984);
                    return return_v;
                }


                System.Linq.Expressions.MemberExpression
                f_1328_15057_15098(System.Linq.Expressions.Expression
                expression, System.Reflection.PropertyInfo
                property)
                {
                    var return_v = Expression.Property(expression, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 15057, 15098);
                    return return_v;
                }


                System.Reflection.PropertyInfo[]
                f_1328_15562_15594(System.Type
                this_param, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetProperties(bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 15562, 15594);
                    return return_v;
                }


                string
                f_1328_15640_15657(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 15640, 15657);
                    return return_v;
                }


                bool
                f_1328_15640_15696(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 15640, 15696);
                    return return_v;
                }


                System.Linq.Expressions.MemberExpression
                f_1328_15753_15794(System.Linq.Expressions.Expression
                expression, System.Reflection.PropertyInfo
                property)
                {
                    var return_v = Expression.Property(expression, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 15753, 15794);
                    return return_v;
                }


                System.Reflection.PropertyInfo[]
                f_1328_15562_15594_I(System.Reflection.PropertyInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 15562, 15594);
                    return return_v;
                }


                System.Reflection.FieldInfo?
                f_1328_15920_15953(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 15920, 15953);
                    return return_v;
                }


                System.Linq.Expressions.MemberExpression
                f_1328_16023_16058(System.Linq.Expressions.Expression
                expression, System.Reflection.FieldInfo
                field)
                {
                    var return_v = Expression.Field(expression, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 16023, 16058);
                    return return_v;
                }


                System.Reflection.FieldInfo[]
                f_1328_16178_16206(System.Type
                this_param, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetFields(bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 16178, 16206);
                    return return_v;
                }


                string
                f_1328_16252_16266(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 16252, 16266);
                    return return_v;
                }


                bool
                f_1328_16252_16305(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 16252, 16305);
                    return return_v;
                }


                System.Linq.Expressions.MemberExpression
                f_1328_16362_16397(System.Linq.Expressions.Expression
                expression, System.Reflection.FieldInfo
                field)
                {
                    var return_v = Expression.Field(expression, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 16362, 16397);
                    return return_v;
                }


                System.Reflection.FieldInfo[]
                f_1328_16178_16206_I(System.Reflection.FieldInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 16178, 16206);
                    return return_v;
                }


                int
                f_1328_16471_16529(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 16471, 16529);
                    return 0;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1328_16550_16594()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 16550, 16594);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1328, 14653, 16606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1328, 14653, 16606);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1328, 494, 16651);

        static System.Management.Automation.InvocationInfo
        f_1328_1238_1258(System.Management.Automation.Cmdlet
        this_param)
        {
            var return_v = this_param.MyInvocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 1238, 1258);
            return return_v;
        }


        static System.Management.Automation.ExecutionContext
        f_1328_1260_1275(System.Management.Automation.Cmdlet
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 1260, 1275);
            return return_v;
        }


        static object
        f_1328_1230_1236_C(object
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1328, 1117, 1307);
            return return_v;
        }


        static System.Management.Automation.InvocationInfo
        f_1328_2172_2192(System.Management.Automation.Cmdlet
        this_param)
        {
            var return_v = this_param.MyInvocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 2172, 2192);
            return return_v;
        }


        static System.Management.Automation.ExecutionContext
        f_1328_2194_2209(System.Management.Automation.Cmdlet
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1328, 2194, 2209);
            return return_v;
        }


        static object
        f_1328_2164_2170_C(object
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1328, 1993, 2306);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_6220_6274(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6220, 6274);
            return return_v;
        }


        static bool
        f_1328_6197_6316(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Func<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Func<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6197, 6316);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_6354_6408(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6354, 6408);
            return return_v;
        }


        static bool
        f_1328_6331_6469(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6331, 6469);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_6509_6566(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6509, 6566);
            return return_v;
        }


        static bool
        f_1328_6486_6611(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Func<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Func<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6486, 6611);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_6649_6705(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6649, 6705);
            return return_v;
        }


        static bool
        f_1328_6626_6749(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Func<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Func<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6626, 6749);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_6787_6844(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6787, 6844);
            return return_v;
        }


        static bool
        f_1328_6764_6908(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6764, 6908);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_6946_7002(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6946, 7002);
            return return_v;
        }


        static bool
        f_1328_6923_7055(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 6923, 7055);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_7095_7152(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7095, 7152);
            return return_v;
        }


        static bool
        f_1328_7072_7197(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Func<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Func<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7072, 7197);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_7235_7292(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7235, 7292);
            return return_v;
        }


        static bool
        f_1328_7212_7356(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7212, 7356);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_7396_7445(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7396, 7445);
            return return_v;
        }


        static bool
        f_1328_7373_7508(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7373, 7508);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_7546_7599(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7546, 7599);
            return return_v;
        }


        static bool
        f_1328_7523_7658(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7523, 7658);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_7698_7755(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7698, 7755);
            return return_v;
        }


        static bool
        f_1328_7675_7800(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Func<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Func<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7675, 7800);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_7838_7895(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7838, 7895);
            return return_v;
        }


        static bool
        f_1328_7815_7959(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7815, 7959);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_7997_8050(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7997, 8050);
            return return_v;
        }


        static bool
        f_1328_7974_8115(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 7974, 8115);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_8155_8210(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8155, 8210);
            return return_v;
        }


        static bool
        f_1328_8132_8253(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Func<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Func<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8132, 8253);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_8291_8346(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8291, 8346);
            return return_v;
        }


        static bool
        f_1328_8268_8408(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8268, 8408);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_8446_8502(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8446, 8502);
            return return_v;
        }


        static bool
        f_1328_8423_8568(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8423, 8568);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_8608_8657(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8608, 8657);
            return return_v;
        }


        static bool
        f_1328_8585_8713(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8585, 8713);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_8751_8806(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8751, 8806);
            return return_v;
        }


        static bool
        f_1328_8728_8874(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8728, 8874);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_8912_8962(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8912, 8962);
            return return_v;
        }


        static bool
        f_1328_8889_9017(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 8889, 9017);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_9055_9108(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9055, 9108);
            return return_v;
        }


        static bool
        f_1328_9032_9175(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9032, 9175);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_9215_9262(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9215, 9262);
            return return_v;
        }


        static bool
        f_1328_9192_9316(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9192, 9316);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_9354_9403(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9354, 9403);
            return return_v;
        }


        static bool
        f_1328_9331_9459(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9331, 9459);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_9499_9545(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9499, 9545);
            return return_v;
        }


        static bool
        f_1328_9476_9598(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9476, 9598);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_9636_9691(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9636, 9691);
            return return_v;
        }


        static bool
        f_1328_9613_9760(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9613, 9760);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_9798_9858(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9798, 9858);
            return return_v;
        }


        static bool
        f_1328_9775_9938(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9775, 9938);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_9978_10031(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9978, 10031);
            return return_v;
        }


        static bool
        f_1328_9955_10099(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 9955, 10099);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_10137_10192(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10137, 10192);
            return return_v;
        }


        static bool
        f_1328_10114_10262(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10114, 10262);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_10300_10359(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10300, 10359);
            return return_v;
        }


        static bool
        f_1328_10277_10433(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10277, 10433);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_10471_10520(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10471, 10520);
            return return_v;
        }


        static bool
        f_1328_10448_10583(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10448, 10583);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_10621_10668(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10621, 10668);
            return return_v;
        }


        static bool
        f_1328_10598_10729(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10598, 10729);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_10767_10822(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10767, 10822);
            return return_v;
        }


        static bool
        f_1328_10744_10882(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10744, 10882);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_10920_10977(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10920, 10977);
            return return_v;
        }


        static bool
        f_1328_10897_11039(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 10897, 11039);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_11077_11138(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 11077, 11138);
            return return_v;
        }


        static bool
        f_1328_11054_11204(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 11054, 11204);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_11242_11295(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 11242, 11295);
            return return_v;
        }


        static bool
        f_1328_11219_11353(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 11219, 11353);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_11391_11442(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 11391, 11442);
            return return_v;
        }


        static bool
        f_1328_11368_11495(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 11368, 11495);
            return return_v;
        }


        static System.Tuple<System.Type, string>
        f_1328_11533_11591(System.Type
        item1, string
        item2)
        {
            var return_v = Tuple.Create(item1, item2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 11533, 11591);
            return return_v;
        }


        static bool
        f_1328_11510_11654(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        this_param, System.Tuple<System.Type, string>
        key, System.Action<object, object>
        value)
        {
            var return_v = this_param.TryAdd(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 11510, 11654);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Func<object, object>>
        f_1328_11797_11866()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Func<object, object>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 11797, 11866);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>
        f_1328_11998_12069()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type, string>, System.Action<object, object>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1328, 11998, 12069);
            return return_v;
        }

    }
}
