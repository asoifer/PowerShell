// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#define TRACE

using System.Reflection;
using System.Management.Automation.Internal;
using System.Collections.Generic;
using System.Threading;

namespace System.Management.Automation
{
    public partial class PSTraceSource
    {
        private static object s_getTracerLock;

        internal static PSTraceSource GetTracer(
                    string name,
                    string description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 2854, 3045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 2978, 3034);

                return f_1025_2985_3033(name, description, true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 2854, 3045);

                System.Management.Automation.PSTraceSource
                f_1025_2985_3033(string
                name, string
                description, bool
                traceHeaders)
                {
                    var return_v = PSTraceSource.GetTracer(name, description, traceHeaders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 2985, 3033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 2854, 3045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 2854, 3045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSTraceSource GetTracer(
                    string name,
                    string description,
                    bool traceHeaders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 3910, 7392);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 4066, 4378) || true) && (f_1025_4070_4096(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 4066, 4378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 4323, 4363);

                    throw f_1025_4329_4362("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 4066, 4378);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 4400, 4429);

                lock (PSTraceSource.s_getTracerLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 4463, 4491);

                    PSTraceSource
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 4601, 4658);

                    f_1025_4601_4657(f_1025_4601_4627(), name, out result);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 4818, 6431) || true) && (result == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 4818, 6431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 4878, 4900);

                        string
                        keyName = name
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 4922, 5537) || true) && (!f_1025_4927_4986(f_1025_4927_4965(), keyName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 4922, 5537);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 5036, 5514) || true) && (f_1025_5040_5054(keyName) > 16)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 5036, 5514);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 5117, 5152);

                                keyName = f_1025_5127_5151(keyName, 0, 16);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 5182, 5358) || true) && (!f_1025_5187_5246(f_1025_5187_5225(), keyName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 5182, 5358);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 5312, 5327);

                                    keyName = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 5182, 5358);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 5036, 5514);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 5036, 5514);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 5472, 5487);

                                keyName = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 5036, 5514);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 4922, 5537);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 5561, 6412) || true) && (keyName != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 5561, 6412);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 5711, 5795);

                            PSTraceSource
                            preconfiguredSource = f_1025_5747_5794(f_1025_5747_5785(), keyName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 5823, 5900);

                            result = f_1025_5832_5899(keyName, description, traceHeaders);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 5926, 5971);

                            result.Options = f_1025_5943_5970(preconfiguredSource);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 5997, 6022);

                            f_1025_5997_6021(f_1025_5997_6013(result));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 6048, 6105);

                            f_1025_6048_6104(f_1025_6048_6064(result), f_1025_6074_6103(preconfiguredSource));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 6188, 6236);

                            f_1025_6188_6235(f_1025_6188_6214(), keyName, result);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 6334, 6389);

                            f_1025_6334_6388(f_1025_6334_6372(), keyName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 5561, 6412);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 4818, 6431);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 6753, 6981) || true) && (result == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 6753, 6981);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 6813, 6887);

                        result = f_1025_6822_6886(name, description, traceHeaders);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 6909, 6962);

                        f_1025_6909_6935()[f_1025_6936_6951(result)] = result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 6753, 6981);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 7001, 7332) || true) && (f_1025_7005_7019(result) != PSTraceSourceOptions.None && (DynAbs.Tracing.TraceSender.Expression_True(1025, 7005, 7085) && traceHeaders))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 7001, 7332);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 7127, 7163);

                        f_1025_7127_7162(result);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 7256, 7313);

                        f_1025_7256_7312(
                                            // Trace the object specific tracer information
                                            result, f_1025_7282_7311());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 7001, 7332);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 7352, 7366);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 3910, 7392);

                bool
                f_1025_4070_4096(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 4070, 4096);
                    return return_v;
                }


                System.ArgumentNullException
                f_1025_4329_4362(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 4329, 4362);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                f_1025_4601_4627()
                {
                    var return_v =
                                    // See if we can find an PSTraceSource for this category in the catalog.
                                    PSTraceSource.TraceCatalog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 4601, 4627);
                    return return_v;
                }


                bool
                f_1025_4601_4657(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                this_param, string
                key, out System.Management.Automation.PSTraceSource
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 4601, 4657);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                f_1025_4927_4965()
                {
                    var return_v = PSTraceSource.PreConfiguredTraceSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 4927, 4965);
                    return return_v;
                }


                bool
                f_1025_4927_4986(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 4927, 4986);
                    return return_v;
                }


                int
                f_1025_5040_5054(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 5040, 5054);
                    return return_v;
                }


                string
                f_1025_5127_5151(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 5127, 5151);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                f_1025_5187_5225()
                {
                    var return_v = PSTraceSource.PreConfiguredTraceSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 5187, 5225);
                    return return_v;
                }


                bool
                f_1025_5187_5246(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 5187, 5246);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                f_1025_5747_5785()
                {
                    var return_v = PSTraceSource.PreConfiguredTraceSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 5747, 5785);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1025_5747_5794(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 5747, 5794);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1025_5832_5899(string
                name, string
                description, bool
                traceHeaders)
                {
                    var return_v = PSTraceSource.GetNewTraceSource(name, description, traceHeaders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 5832, 5899);
                    return return_v;
                }


                System.Management.Automation.PSTraceSourceOptions
                f_1025_5943_5970(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 5943, 5970);
                    return return_v;
                }


                System.Diagnostics.TraceListenerCollection
                f_1025_5997_6013(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.Listeners;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 5997, 6013);
                    return return_v;
                }


                int
                f_1025_5997_6021(System.Diagnostics.TraceListenerCollection
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 5997, 6021);
                    return 0;
                }


                System.Diagnostics.TraceListenerCollection
                f_1025_6048_6064(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.Listeners;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 6048, 6064);
                    return return_v;
                }


                System.Diagnostics.TraceListenerCollection
                f_1025_6074_6103(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.Listeners;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 6074, 6103);
                    return return_v;
                }


                int
                f_1025_6048_6104(System.Diagnostics.TraceListenerCollection
                this_param, System.Diagnostics.TraceListenerCollection
                value)
                {
                    this_param.AddRange(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 6048, 6104);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                f_1025_6188_6214()
                {
                    var return_v =
                                            // Add it to the TraceCatalog
                                            PSTraceSource.TraceCatalog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 6188, 6214);
                    return return_v;
                }


                int
                f_1025_6188_6235(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                this_param, string
                key, System.Management.Automation.PSTraceSource
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 6188, 6235);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                f_1025_6334_6372()
                {
                    var return_v =
                                            // Remove it from the pre-configured catalog
                                            PSTraceSource.PreConfiguredTraceSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 6334, 6372);
                    return return_v;
                }


                bool
                f_1025_6334_6388(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 6334, 6388);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1025_6822_6886(string
                name, string
                description, bool
                traceHeaders)
                {
                    var return_v = PSTraceSource.GetNewTraceSource(name, description, traceHeaders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 6822, 6886);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSTraceSource>
                f_1025_6909_6935()
                {
                    var return_v = PSTraceSource.TraceCatalog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 6909, 6935);
                    return return_v;
                }


                string
                f_1025_6936_6951(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 6936, 6951);
                    return return_v;
                }


                System.Management.Automation.PSTraceSourceOptions
                f_1025_7005_7019(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 7005, 7019);
                    return return_v;
                }


                int
                f_1025_7127_7162(System.Management.Automation.PSTraceSource
                this_param)
                {
                    this_param.TraceGlobalAppDomainHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 7127, 7162);
                    return 0;
                }


                System.Reflection.Assembly
                f_1025_7282_7311()
                {
                    var return_v = Assembly.GetCallingAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 7282, 7311);
                    return return_v;
                }


                int
                f_1025_7256_7312(System.Management.Automation.PSTraceSource
                this_param, System.Reflection.Assembly
                callingAssembly)
                {
                    this_param.TracerObjectHeader(callingAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 7256, 7312);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 3910, 7392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 3910, 7392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSTraceSource GetNewTraceSource(
                    string name,
                    string description,
                    bool traceHeaders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 7404, 8904);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 7568, 7864) || true) && (f_1025_7572_7598(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 7568, 7864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 7813, 7849);

                    throw f_1025_7819_7848("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 7568, 7864);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 8054, 8077);

                string
                fullName = name
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 8679, 8865);

                PSTraceSource
                result =
                f_1025_8719_8864(fullName, name, description, traceHeaders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 8879, 8893);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 7404, 8904);

                bool
                f_1025_7572_7598(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 7572, 7598);
                    return return_v;
                }


                System.ArgumentException
                f_1025_7819_7848(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 7819, 7848);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1025_8719_8864(string
                fullName, string
                name, string
                description, bool
                traceHeaders)
                {
                    var return_v = new System.Management.Automation.PSTraceSource(fullName, name, description, traceHeaders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 8719, 8864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 7404, 8904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 7404, 8904);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSArgumentNullException NewArgumentNullException(string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 9433, 9872);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 9540, 9669) || true) && (f_1025_9544_9575(paramName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 9540, 9669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 9609, 9654);

                    throw f_1025_9615_9653("paramName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 9540, 9669);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 9685, 9766);

                string
                message = f_1025_9702_9765(f_1025_9720_9753(), paramName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 9780, 9836);

                var
                e = f_1025_9788_9835(paramName, message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 9852, 9861);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 9433, 9872);

                bool
                f_1025_9544_9575(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 9544, 9575);
                    return return_v;
                }


                System.ArgumentNullException
                f_1025_9615_9653(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 9615, 9653);
                    return return_v;
                }


                string
                f_1025_9720_9753()
                {
                    var return_v = AutomationExceptions.ArgumentNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 9720, 9753);
                    return return_v;
                }


                string
                f_1025_9702_9765(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 9702, 9765);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_9788_9835(string
                paramName, string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 9788, 9835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 9433, 9872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 9433, 9872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSArgumentNullException NewArgumentNullException(
                    string paramName, string resourceString, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 10606, 11293);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 10772, 10900) || true) && (f_1025_10776_10807(paramName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 10772, 10900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 10841, 10885);

                    throw f_1025_10847_10884("paramName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 10772, 10900);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 10916, 11054) || true) && (f_1025_10920_10956(resourceString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 10916, 11054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 10990, 11039);

                    throw f_1025_10996_11038("resourceString");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 10916, 11054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 11070, 11127);

                string
                message = f_1025_11087_11126(resourceString, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 11201, 11257);

                var
                e = f_1025_11209_11256(paramName, message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 11273, 11282);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 10606, 11293);

                bool
                f_1025_10776_10807(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 10776, 10807);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_10847_10884(string
                paramName)
                {
                    var return_v = NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 10847, 10884);
                    return return_v;
                }


                bool
                f_1025_10920_10956(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 10920, 10956);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_10996_11038(string
                paramName)
                {
                    var return_v = NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 10996, 11038);
                    return return_v;
                }


                string
                f_1025_11087_11126(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 11087, 11126);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_11209_11256(string
                paramName, string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 11209, 11256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 10606, 11293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 10606, 11293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSArgumentException NewArgumentException(string paramName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 11841, 12320);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 11940, 12069) || true) && (f_1025_11944_11975(paramName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 11940, 12069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 12009, 12054);

                    throw f_1025_12015_12053("paramName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 11940, 12069);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 12085, 12162);

                string
                message = f_1025_12102_12161(f_1025_12120_12149(), paramName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 12232, 12284);

                var
                e = f_1025_12240_12283(message, paramName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 12300, 12309);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 11841, 12320);

                bool
                f_1025_11944_11975(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 11944, 11975);
                    return return_v;
                }


                System.ArgumentNullException
                f_1025_12015_12053(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 12015, 12053);
                    return return_v;
                }


                string
                f_1025_12120_12149()
                {
                    var return_v = AutomationExceptions.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 12120, 12149);
                    return return_v;
                }


                string
                f_1025_12102_12161(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 12102, 12161);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1025_12240_12283(string
                message, string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 12240, 12283);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 11841, 12320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 11841, 12320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSArgumentException NewArgumentException(
                    string paramName, string resourceString, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 13054, 13727);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 13212, 13340) || true) && (f_1025_13216_13247(paramName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 13212, 13340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 13281, 13325);

                    throw f_1025_13287_13324("paramName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 13212, 13340);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 13356, 13494) || true) && (f_1025_13360_13396(resourceString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 13356, 13494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 13430, 13479);

                    throw f_1025_13436_13478("resourceString");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 13356, 13494);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 13510, 13567);

                string
                message = f_1025_13527_13566(resourceString, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 13639, 13691);

                var
                e = f_1025_13647_13690(message, paramName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 13707, 13716);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 13054, 13727);

                bool
                f_1025_13216_13247(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 13216, 13247);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_13287_13324(string
                paramName)
                {
                    var return_v = NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 13287, 13324);
                    return return_v;
                }


                bool
                f_1025_13360_13396(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 13360, 13396);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_13436_13478(string
                paramName)
                {
                    var return_v = NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 13436, 13478);
                    return return_v;
                }


                string
                f_1025_13527_13566(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 13527, 13566);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1025_13647_13690(string
                message, string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 13647, 13690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 13054, 13727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 13054, 13727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSInvalidOperationException NewInvalidOperationException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 13972, 14331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 14071, 14232);

                string
                message = f_1025_14088_14231(f_1025_14106_14143(), f_1025_14166_14230(f_1025_14166_14225(f_1025_14166_14213(f_1025_14166_14201(), 1))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 14246, 14295);

                var
                e = f_1025_14254_14294(message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 14311, 14320);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 13972, 14331);

                string
                f_1025_14106_14143()
                {
                    var return_v = AutomationExceptions.InvalidOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 14106, 14143);
                    return return_v;
                }


                System.Diagnostics.StackTrace
                f_1025_14166_14201()
                {
                    var return_v = new System.Diagnostics.StackTrace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 14166, 14201);
                    return return_v;
                }


                System.Diagnostics.StackFrame?
                f_1025_14166_14213(System.Diagnostics.StackTrace
                this_param, int
                index)
                {
                    var return_v = this_param.GetFrame(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 14166, 14213);
                    return return_v;
                }


                System.Reflection.MethodBase?
                f_1025_14166_14225(System.Diagnostics.StackFrame
                this_param)
                {
                    var return_v = this_param.GetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 14166, 14225);
                    return return_v;
                }


                string
                f_1025_14166_14230(System.Reflection.MethodBase
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 14166, 14230);
                    return return_v;
                }


                string
                f_1025_14088_14231(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 14088, 14231);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1025_14254_14294(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 14254, 14294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 13972, 14331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 13972, 14331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSInvalidOperationException NewInvalidOperationException(
                    string resourceString, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 14933, 15399);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 15089, 15227) || true) && (f_1025_15093_15129(resourceString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 15089, 15227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 15163, 15212);

                    throw f_1025_15169_15211("resourceString");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 15089, 15227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 15243, 15300);

                string
                message = f_1025_15260_15299(resourceString, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 15316, 15365);

                var
                e = f_1025_15324_15364(message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 15379, 15388);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 14933, 15399);

                bool
                f_1025_15093_15129(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 15093, 15129);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_15169_15211(string
                paramName)
                {
                    var return_v = NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 15169, 15211);
                    return return_v;
                }


                string
                f_1025_15260_15299(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 15260, 15299);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1025_15324_15364(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 15324, 15364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 14933, 15399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 14933, 15399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSInvalidOperationException NewInvalidOperationException(
                    Exception innerException,
                    string resourceString, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 16140, 16661);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 16335, 16473) || true) && (f_1025_16339_16375(resourceString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 16335, 16473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 16409, 16458);

                    throw f_1025_16415_16457("resourceString");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 16335, 16473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 16489, 16546);

                string
                message = f_1025_16506_16545(resourceString, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 16562, 16627);

                var
                e = f_1025_16570_16626(message, innerException)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 16641, 16650);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 16140, 16661);

                bool
                f_1025_16339_16375(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 16339, 16375);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_16415_16457(string
                paramName)
                {
                    var return_v = NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 16415, 16457);
                    return return_v;
                }


                string
                f_1025_16506_16545(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 16506, 16545);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1025_16570_16626(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 16570, 16626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 16140, 16661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 16140, 16661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSNotSupportedException NewNotSupportedException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 17001, 17334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 17092, 17239);

                string
                message = f_1025_17109_17238(f_1025_17127_17160(), f_1025_17179_17237(f_1025_17179_17226(f_1025_17179_17214(), 0)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 17253, 17298);

                var
                e = f_1025_17261_17297(message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 17314, 17323);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 17001, 17334);

                string
                f_1025_17127_17160()
                {
                    var return_v = AutomationExceptions.NotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 17127, 17160);
                    return return_v;
                }


                System.Diagnostics.StackTrace
                f_1025_17179_17214()
                {
                    var return_v = new System.Diagnostics.StackTrace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 17179, 17214);
                    return return_v;
                }


                System.Diagnostics.StackFrame?
                f_1025_17179_17226(System.Diagnostics.StackTrace
                this_param, int
                index)
                {
                    var return_v = this_param.GetFrame(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 17179, 17226);
                    return return_v;
                }


                string
                f_1025_17179_17237(System.Diagnostics.StackFrame
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 17179, 17237);
                    return return_v;
                }


                string
                f_1025_17109_17238(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 17109, 17238);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1025_17261_17297(string
                message)
                {
                    var return_v = new System.Management.Automation.PSNotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 17261, 17297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 17001, 17334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 17001, 17334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSNotSupportedException NewNotSupportedException(
                    string resourceString,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 17918, 18385);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 18079, 18217) || true) && (f_1025_18083_18119(resourceString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 18079, 18217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 18153, 18202);

                    throw f_1025_18159_18201("resourceString");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 18079, 18217);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 18233, 18290);

                string
                message = f_1025_18250_18289(resourceString, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 18304, 18349);

                var
                e = f_1025_18312_18348(message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 18365, 18374);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 17918, 18385);

                bool
                f_1025_18083_18119(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 18083, 18119);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_18159_18201(string
                paramName)
                {
                    var return_v = NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 18159, 18201);
                    return return_v;
                }


                string
                f_1025_18250_18289(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 18250, 18289);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1025_18312_18348(string
                message)
                {
                    var return_v = new System.Management.Automation.PSNotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 18312, 18348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 17918, 18385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 17918, 18385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSNotImplementedException NewNotImplementedException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 18725, 19066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 18820, 18969);

                string
                message = f_1025_18837_18968(f_1025_18855_18890(), f_1025_18909_18967(f_1025_18909_18956(f_1025_18909_18944(), 0)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 18983, 19030);

                var
                e = f_1025_18991_19029(message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 19046, 19055);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 18725, 19066);

                string
                f_1025_18855_18890()
                {
                    var return_v = AutomationExceptions.NotImplemented;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 18855, 18890);
                    return return_v;
                }


                System.Diagnostics.StackTrace
                f_1025_18909_18944()
                {
                    var return_v = new System.Diagnostics.StackTrace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 18909, 18944);
                    return return_v;
                }


                System.Diagnostics.StackFrame?
                f_1025_18909_18956(System.Diagnostics.StackTrace
                this_param, int
                index)
                {
                    var return_v = this_param.GetFrame(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 18909, 18956);
                    return return_v;
                }


                string
                f_1025_18909_18967(System.Diagnostics.StackFrame
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 18909, 18967);
                    return return_v;
                }


                string
                f_1025_18837_18968(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 18837, 18968);
                    return return_v;
                }


                System.Management.Automation.PSNotImplementedException
                f_1025_18991_19029(string
                message)
                {
                    var return_v = new System.Management.Automation.PSNotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 18991, 19029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 18725, 19066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 18725, 19066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSArgumentOutOfRangeException NewArgumentOutOfRangeException(string paramName, object actualValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 19752, 20248);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 19891, 20020) || true) && (f_1025_19895_19926(paramName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 19891, 20020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 19960, 20005);

                    throw f_1025_19966_20004("paramName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 19891, 20020);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 20036, 20123);

                string
                message = f_1025_20053_20122(f_1025_20071_20110(), paramName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 20137, 20212);

                var
                e = f_1025_20145_20211(paramName, actualValue, message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 20228, 20237);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 19752, 20248);

                bool
                f_1025_19895_19926(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 19895, 19926);
                    return return_v;
                }


                System.ArgumentNullException
                f_1025_19966_20004(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 19966, 20004);
                    return return_v;
                }


                string
                f_1025_20071_20110()
                {
                    var return_v = AutomationExceptions.ArgumentOutOfRange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 20071, 20110);
                    return return_v;
                }


                string
                f_1025_20053_20122(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 20053, 20122);
                    return return_v;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_1025_20145_20211(string
                paramName, object
                actualValue, string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentOutOfRangeException(paramName, actualValue, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 20145, 20211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 19752, 20248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 19752, 20248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSArgumentOutOfRangeException NewArgumentOutOfRangeException(
                    string paramName, object actualValue, string resourceString, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 21105, 21783);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 21303, 21431) || true) && (f_1025_21307_21338(paramName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 21303, 21431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 21372, 21416);

                    throw f_1025_21378_21415("paramName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 21303, 21431);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 21447, 21585) || true) && (f_1025_21451_21487(resourceString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 21447, 21585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 21521, 21570);

                    throw f_1025_21527_21569("resourceString");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 21447, 21585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 21601, 21658);

                string
                message = f_1025_21618_21657(resourceString, args)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 21672, 21747);

                var
                e = f_1025_21680_21746(paramName, actualValue, message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 21763, 21772);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 21105, 21783);

                bool
                f_1025_21307_21338(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 21307, 21338);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_21378_21415(string
                paramName)
                {
                    var return_v = NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 21378, 21415);
                    return return_v;
                }


                bool
                f_1025_21451_21487(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 21451, 21487);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_21527_21569(string
                paramName)
                {
                    var return_v = NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 21527, 21569);
                    return return_v;
                }


                string
                f_1025_21618_21657(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 21618, 21657);
                    return return_v;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_1025_21680_21746(string
                paramName, object
                actualValue, string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentOutOfRangeException(paramName, actualValue, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 21680, 21746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 21105, 21783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 21105, 21783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSObjectDisposedException NewObjectDisposedException(string objectName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1025, 22435, 22886);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 22547, 22677) || true) && (f_1025_22551_22583(objectName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1025, 22547, 22677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 22617, 22662);

                    throw f_1025_22623_22661("objectName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1025, 22547, 22677);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 22693, 22777);

                string
                message = f_1025_22710_22776(f_1025_22728_22763(), objectName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 22791, 22850);

                var
                e = f_1025_22799_22849(objectName, message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 22866, 22875);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1025, 22435, 22886);

                bool
                f_1025_22551_22583(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 22551, 22583);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1025_22623_22661(string
                paramName)
                {
                    var return_v = NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 22623, 22661);
                    return return_v;
                }


                string
                f_1025_22728_22763()
                {
                    var return_v = AutomationExceptions.ObjectDisposed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1025, 22728, 22763);
                    return return_v;
                }


                string
                f_1025_22710_22776(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 22710, 22776);
                    return return_v;
                }


                System.Management.Automation.PSObjectDisposedException
                f_1025_22799_22849(string
                objectName, string
                message)
                {
                    var return_v = new System.Management.Automation.PSObjectDisposedException(objectName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 22799, 22849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1025, 22435, 22886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 22435, 22886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSTraceSource()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1025, 1954, 22956);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1025, 2125, 2155);
            s_getTracerLock = f_1025_2143_2155();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 10241, 10263);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 40711, 40750);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 40835, 40878);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 40963, 41006);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 41088, 41124);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 41215, 41273);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 41307, 41366);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 41453, 41511);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 41545, 41604);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 41690, 41739);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 41773, 41822);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 41910, 41970);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 42004, 42064);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 42159, 42235);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 42269, 42345);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 42438, 42508);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 42542, 42612);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 42702, 42757);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 42791, 42866);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 42951, 43002);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 43036, 43089);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 43123, 43182);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 47727, 47770);
            s_localIndentLevel = f_1043_47748_47770();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 50926, 51072);
            TraceCatalog = f_1043_51000_51071(f_1043_51038_51070());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1043, 51470, 51628);
            PreConfiguredTraceSource = f_1043_51556_51627(f_1043_51594_51626());
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1025, 1954, 22956);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1025, 1954, 22956);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1025, 1954, 22956);

        static object
        f_1025_2143_2155()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1025, 2143, 2155);
            return return_v;
        }

        static ThreadLocal<int>
        f_1043_47748_47770()
        {
            var return_v = new ThreadLocal<int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 47748, 47770);
            return return_v;
        }

        static StringComparer
        f_1043_51038_51070()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 51038, 51070);
            return return_v;
        }

        static Dictionary<string, PSTraceSource> 
        f_1043_51000_51071(StringComparer comp)
        {
            var return_v = new Dictionary<string, PSTraceSource>(comp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 51000, 51071);
            return return_v;
        }

        static StringComparer
        f_1043_51594_51626()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 51594, 51626);
            return return_v;
        }

        static Dictionary<string, PSTraceSource>
        f_1043_51556_51627(StringComparer comp)
        {
            var return_v = new Dictionary<string, PSTraceSource>(comp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1043, 51556, 51627);
            return return_v;
        }

    }
}

