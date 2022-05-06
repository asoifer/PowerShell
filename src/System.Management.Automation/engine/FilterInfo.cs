// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
    public class FilterInfo : FunctionInfo
    {
        internal FilterInfo(string name, ScriptBlock filter, ExecutionContext context) : this(f_1277_1006_1010_C(name), filter, context, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1277, 920, 1056);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1277, 920, 1056);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1277, 920, 1056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1277, 920, 1056);
            }
        }

        internal FilterInfo(string name, ScriptBlock filter, ExecutionContext context, string helpFile)
        : base(f_1277_1863_1867_C(name), filter, context, helpFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1277, 1747, 1967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1277, 1920, 1956);

                f_1277_1920_1955(this, CommandTypes.Filter);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1277, 1747, 1967);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1277, 1747, 1967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1277, 1747, 1967);
            }
        }

        internal FilterInfo(string name, ScriptBlock filter, ScopedItemOptions options, ExecutionContext context) : this(f_1277_2826_2830_C(name), filter, options, context, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1277, 2713, 2885);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1277, 2713, 2885);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1277, 2713, 2885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1277, 2713, 2885);
            }
        }

        internal FilterInfo(string name, ScriptBlock filter, ScopedItemOptions options, ExecutionContext context, string helpFile)
        : base(f_1277_3876_3880_C(name), filter, options, context, helpFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1277, 3733, 3989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1277, 3942, 3978);

                f_1277_3942_3977(this, CommandTypes.Filter);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1277, 3733, 3989);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1277, 3733, 3989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1277, 3733, 3989);
            }
        }

        internal FilterInfo(FilterInfo other)
        : base(f_1277_4179_4184_C(other))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1277, 4121, 4207);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1277, 4121, 4207);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1277, 4121, 4207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1277, 4121, 4207);
            }
        }

        internal FilterInfo(string name, FilterInfo other)
        : base(f_1277_4410_4414_C(name), other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1277, 4339, 4444);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1277, 4339, 4444);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1277, 4339, 4444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1277, 4339, 4444);
            }
        }

        internal override CommandInfo CreateGetCommandCopy(object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1277, 4685, 4940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1277, 4780, 4819);

                FilterInfo
                copy = f_1277_4798_4818(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1277, 4833, 4862);

                copy.IsGetCommandCopy = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1277, 4876, 4903);

                copy.Arguments = arguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1277, 4917, 4929);

                return copy;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1277, 4685, 4940);

                System.Management.Automation.FilterInfo
                f_1277_4798_4818(System.Management.Automation.FilterInfo
                other)
                {
                    var return_v = new System.Management.Automation.FilterInfo(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1277, 4798, 4818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1277, 4685, 4940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1277, 4685, 4940);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override HelpCategory HelpCategory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1277, 5047, 5082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1277, 5053, 5080);

                    return HelpCategory.Filter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1277, 5047, 5082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1277, 4979, 5093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1277, 4979, 5093);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static FilterInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1277, 264, 5100);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1277, 264, 5100);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1277, 264, 5100);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1277, 264, 5100);

        static string
        f_1277_1006_1010_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1277, 920, 1056);
            return return_v;
        }


        int
        f_1277_1920_1955(System.Management.Automation.FilterInfo
        this_param, System.Management.Automation.CommandTypes
        newType)
        {
            this_param.SetCommandType(newType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1277, 1920, 1955);
            return 0;
        }


        static string
        f_1277_1863_1867_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1277, 1747, 1967);
            return return_v;
        }


        static string
        f_1277_2826_2830_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1277, 2713, 2885);
            return return_v;
        }


        int
        f_1277_3942_3977(System.Management.Automation.FilterInfo
        this_param, System.Management.Automation.CommandTypes
        newType)
        {
            this_param.SetCommandType(newType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1277, 3942, 3977);
            return 0;
        }


        static string
        f_1277_3876_3880_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1277, 3733, 3989);
            return return_v;
        }


        static System.Management.Automation.FunctionInfo
        f_1277_4179_4184_C(System.Management.Automation.FunctionInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1277, 4121, 4207);
            return return_v;
        }


        static string
        f_1277_4410_4414_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1277, 4339, 4444);
            return return_v;
        }

    }
}
