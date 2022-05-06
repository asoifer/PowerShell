// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.PowerShell.Cmdletization
{
    public abstract class CmdletAdapter<TObjectInstance>
            where TObjectInstance : class
    {
        internal void Initialize(PSCmdlet cmdlet, string className, string classVersion, IDictionary<string, string> privateData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 713, 2204);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 859, 968) || true) && (cmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1065, 859, 968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 911, 953);

                    throw f_1065_917_952("cmdlet");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1065, 859, 968);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 984, 1113) || true) && (f_1065_988_1019(className))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1065, 984, 1113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1053, 1098);

                    throw f_1065_1059_1097("className");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1065, 984, 1113);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1129, 1304) || true) && (classVersion == null)
                ) // possible and ok to have classVersion==string.Empty

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1065, 1129, 1304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1241, 1289);

                    throw f_1065_1247_1288("classVersion");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1065, 1129, 1304);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1320, 1439) || true) && (privateData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1065, 1320, 1439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1377, 1424);

                    throw f_1065_1383_1423("privateData");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1065, 1320, 1439);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1455, 1472);

                _cmdlet = cmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1486, 1509);

                _className = className;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1523, 1552);

                _classVersion = classVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1566, 1593);

                _privateData = privateData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1609, 1660);

                var
                compiledScript = f_1065_1630_1641(this) as PSScriptCmdlet
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1674, 2193) || true) && (compiledScript != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1065, 1674, 2193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1734, 1802);

                    compiledScript.StoppingEvent += delegate
                    { this.StopProcessing(); };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 1820, 2178);

                    compiledScript.DisposingEvent +=
                                            delegate
                                            {
                                                var disposable = this as IDisposable;
                                                if (disposable != null)
                                                {
                                                    disposable.Dispose();
                                                }
                                            };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1065, 1674, 2193);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 713, 2204);

                System.ArgumentNullException
                f_1065_917_952(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 917, 952);
                    return return_v;
                }


                bool
                f_1065_988_1019(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 988, 1019);
                    return return_v;
                }


                System.ArgumentNullException
                f_1065_1059_1097(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 1059, 1097);
                    return return_v;
                }


                System.ArgumentNullException
                f_1065_1247_1288(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 1247, 1288);
                    return return_v;
                }


                System.ArgumentNullException
                f_1065_1383_1423(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 1383, 1423);
                    return return_v;
                }


                System.Management.Automation.PSCmdlet
                f_1065_1630_1641(Microsoft.PowerShell.Cmdletization.CmdletAdapter<TObjectInstance>
                this_param)
                {
                    var return_v = this_param.Cmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1065, 1630, 1641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 713, 2204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 713, 2204);
            }
        }

        public void Initialize(PSCmdlet cmdlet, string className, string classVersion, Version moduleVersion, IDictionary<string, string> privateData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 2531, 2813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 2698, 2729);

                _moduleVersion = moduleVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 2745, 2802);

                f_1065_2745_2801(this, cmdlet, className, classVersion, privateData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 2531, 2813);

                int
                f_1065_2745_2801(Microsoft.PowerShell.Cmdletization.CmdletAdapter<TObjectInstance>
                this_param, System.Management.Automation.PSCmdlet
                cmdlet, string
                className, string
                classVersion, System.Collections.Generic.IDictionary<string, string>
                privateData)
                {
                    this_param.Initialize(cmdlet, className, classVersion, privateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 2745, 2801);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 2531, 2813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 2531, 2813);
            }
        }

        public virtual QueryBuilder GetQueryBuilder()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 3045, 3162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 3115, 3151);

                throw f_1065_3121_3150();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 3045, 3162);

                System.NotImplementedException
                f_1065_3121_3150()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 3121, 3150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 3045, 3162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 3045, 3162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual void ProcessRecord(QueryBuilder query)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 3424, 3549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 3502, 3538);

                throw f_1065_3508_3537();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 3424, 3549);

                System.NotImplementedException
                f_1065_3508_3537()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 3508, 3537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 3424, 3549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 3424, 3549);
            }
        }

        public virtual void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 3772, 3831);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 3772, 3831);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 3772, 3831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 3772, 3831);
            }
        }

        public virtual void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 4050, 4107);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 4050, 4107);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 4050, 4107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 4050, 4107);
            }
        }

        public virtual void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 4655, 4713);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 4655, 4713);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 4655, 4713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 4655, 4713);
            }
        }

        public virtual void ProcessRecord(TObjectInstance objectInstance, MethodInvocationInfo methodInvocationInfo, bool passThru)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 5177, 5372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 5325, 5361);

                throw f_1065_5331_5360();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 5177, 5372);

                System.NotImplementedException
                f_1065_5331_5360()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 5331, 5360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 5177, 5372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 5177, 5372);
            }
        }

        public virtual void ProcessRecord(QueryBuilder query, MethodInvocationInfo methodInvocationInfo, bool passThru)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 5899, 6082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 6035, 6071);

                throw f_1065_6041_6070();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 5899, 6082);

                System.NotImplementedException
                f_1065_6041_6070()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 6041, 6070);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 5899, 6082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 5899, 6082);
            }
        }

        public virtual void ProcessRecord(
                    MethodInvocationInfo methodInvocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 6282, 6444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 6397, 6433);

                throw f_1065_6403_6432();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 6282, 6444);

                System.NotImplementedException
                f_1065_6403_6432()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1065, 6403, 6432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 6282, 6444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 6282, 6444);
            }
        }

        public PSCmdlet Cmdlet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 6619, 6685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 6655, 6670);

                    return _cmdlet;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 6619, 6685);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 6572, 6696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 6572, 6696);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSCmdlet _cmdlet;

        public string ClassName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 6981, 7050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 7017, 7035);

                    return _className;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 6981, 7050);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 6933, 7061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 6933, 7061);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _className;

        public string ClassVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 7453, 7525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 7489, 7510);

                    return _classVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 7453, 7525);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 7402, 7536);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 7402, 7536);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _classVersion;

        public Version ModuleVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 7718, 7791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 7754, 7776);

                    return _moduleVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 7718, 7791);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 7665, 7802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 7665, 7802);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Version _moduleVersion;

        public IDictionary<string, string> PrivateData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1065, 8081, 8152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 8117, 8137);

                    return _privateData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1065, 8081, 8152);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1065, 8010, 8163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 8010, 8163);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private IDictionary<string, string> _privateData;

        public CmdletAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1065, 605, 8231);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 6725, 6732);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 7088, 7098);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 7563, 7576);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 7830, 7844);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1065, 8211, 8223);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1065, 605, 8231);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 605, 8231);
        }


        static CmdletAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1065, 605, 8231);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1065, 605, 8231);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1065, 605, 8231);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1065, 605, 8231);
    }
}
