// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation
{
    public class ConfigurationInfo : FunctionInfo
    {
        internal ConfigurationInfo(string name, ScriptBlock configuration, ExecutionContext context) : this(f_1256_1076_1080_C(name), configuration, context, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1256, 976, 1133);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1256, 976, 1133);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1256, 976, 1133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1256, 976, 1133);
            }
        }

        internal ConfigurationInfo(string name, ScriptBlock configuration, ExecutionContext context, string helpFile)
        : base(f_1256_2003_2007_C(name), configuration, context, helpFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1256, 1873, 2121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1256, 6813, 6876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1256, 2067, 2110);

                f_1256_2067_2109(this, CommandTypes.Configuration);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1256, 1873, 2121);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1256, 1873, 2121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1256, 1873, 2121);
            }
        }

        internal ConfigurationInfo(string name, ScriptBlock configuration, ScopedItemOptions options, ExecutionContext context) : this(f_1256_3036_3040_C(name), configuration, options, context, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1256, 2909, 3102);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1256, 2909, 3102);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1256, 2909, 3102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1256, 2909, 3102);
            }
        }

        internal ConfigurationInfo(string name, ScriptBlock configuration, ScopedItemOptions options, ExecutionContext context, string helpFile, bool isMetaConfig)
        : base(f_1256_4266_4270_C(name), configuration, options, context, helpFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1256, 4090, 4442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1256, 6813, 6876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1256, 4339, 4382);

                f_1256_4339_4381(this, CommandTypes.Configuration);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1256, 4396, 4431);

                IsMetaConfiguration = isMetaConfig;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1256, 4090, 4442);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1256, 4090, 4442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1256, 4090, 4442);
            }
        }

        internal ConfigurationInfo(string name, ScriptBlock configuration, ScopedItemOptions options, ExecutionContext context, string helpFile)
        : this(f_1256_5496_5500_C(name), configuration, options, context, helpFile, false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1256, 5339, 5573);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1256, 5339, 5573);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1256, 5339, 5573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1256, 5339, 5573);
            }
        }

        internal ConfigurationInfo(ConfigurationInfo other)
        : base(f_1256_5777_5782_C(other))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1256, 5705, 5805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1256, 6813, 6876);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1256, 5705, 5805);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1256, 5705, 5805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1256, 5705, 5805);
            }
        }

        internal ConfigurationInfo(string name, ConfigurationInfo other)
        : base(f_1256_6022_6026_C(name), other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1256, 5937, 6056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1256, 6813, 6876);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1256, 5937, 6056);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1256, 5937, 6056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1256, 5937, 6056);
            }
        }

        internal override CommandInfo CreateGetCommandCopy(object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1256, 6297, 6519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1256, 6392, 6482);

                var
                copy = new ConfigurationInfo(this) { IsGetCommandCopy = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1256, 6403, 6481), Arguments = arguments }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1256, 6496, 6508);

                return copy;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1256, 6297, 6519);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1256, 6297, 6519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1256, 6297, 6519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override HelpCategory HelpCategory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1256, 6626, 6668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1256, 6632, 6666);

                    return HelpCategory.Configuration;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1256, 6626, 6668);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1256, 6558, 6679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1256, 6558, 6679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsMetaConfiguration
        { get; internal set; }

        static ConfigurationInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1256, 271, 6883);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1256, 271, 6883);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1256, 271, 6883);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1256, 271, 6883);

        static string
        f_1256_1076_1080_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1256, 976, 1133);
            return return_v;
        }


        int
        f_1256_2067_2109(System.Management.Automation.ConfigurationInfo
        this_param, System.Management.Automation.CommandTypes
        newType)
        {
            this_param.SetCommandType(newType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1256, 2067, 2109);
            return 0;
        }


        static string
        f_1256_2003_2007_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1256, 1873, 2121);
            return return_v;
        }


        static string
        f_1256_3036_3040_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1256, 2909, 3102);
            return return_v;
        }


        int
        f_1256_4339_4381(System.Management.Automation.ConfigurationInfo
        this_param, System.Management.Automation.CommandTypes
        newType)
        {
            this_param.SetCommandType(newType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1256, 4339, 4381);
            return 0;
        }


        static string
        f_1256_4266_4270_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1256, 4090, 4442);
            return return_v;
        }


        static string
        f_1256_5496_5500_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1256, 5339, 5573);
            return return_v;
        }


        static System.Management.Automation.FunctionInfo
        f_1256_5777_5782_C(System.Management.Automation.FunctionInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1256, 5705, 5805);
            return return_v;
        }


        static string
        f_1256_6022_6026_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1256, 5937, 6056);
            return return_v;
        }

    }
}
