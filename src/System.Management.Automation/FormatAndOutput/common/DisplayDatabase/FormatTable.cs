// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Runtime.Serialization;
using System.Security.Permissions;

using Microsoft.PowerShell.Commands.Internal.Format;

namespace System.Management.Automation.Runspaces
{
    [Serializable]
    [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "FormatTable")]
    public class FormatTableLoadException : RuntimeException
    {
        private Collection<string> _errors;

        public FormatTableLoadException() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1126, 1136, 1238);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 991, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 1203, 1227);

                f_1126_1203_1226(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1126, 1136, 1238);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 1136, 1238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 1136, 1238);
            }
        }

        public FormatTableLoadException(string message) : base(f_1126_1513_1520_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1126, 1458, 1581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 991, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 1546, 1570);

                f_1126_1546_1569(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1126, 1458, 1581);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 1458, 1581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 1458, 1581);
            }
        }

        public FormatTableLoadException(string message, Exception innerException)
        : base(f_1126_2005_2012_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1126, 1911, 2089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 991, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 2054, 2078);

                f_1126_2054_2077(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1126, 1911, 2089);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 1911, 2089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 1911, 2089);
            }
        }

        internal FormatTableLoadException(ConcurrentBag<string> loadErrors) : base(f_1126_2441_2511_C(f_1126_2441_2511(f_1126_2459_2510())))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1126, 2353, 2641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 991, 998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 2537, 2592);

                _errors = f_1126_2547_2591(f_1126_2570_2590(loadErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 2606, 2630);

                f_1126_2606_2629(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1126, 2353, 2641);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 2353, 2641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 2353, 2641);
            }
        }

        protected FormatTableLoadException(SerializationInfo info, StreamingContext context)
        : base(f_1126_2950_2954_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1126, 2845, 3541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 991, 998);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 2989, 3096) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1126, 2989, 3096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 3039, 3081);

                    throw f_1126_3045_3080("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1126, 2989, 3096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 3112, 3157);

                int
                errorCount = f_1126_3129_3156(info, "ErrorCount")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 3171, 3530) || true) && (errorCount > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1126, 3171, 3530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 3223, 3258);

                    _errors = f_1126_3233_3257();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 3285, 3294);
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 3276, 3515) || true) && (index < errorCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 3316, 3323)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1126, 3276, 3515))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1126, 3276, 3515);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 3365, 3441);

                            string
                            key = f_1126_3378_3440(f_1126_3392_3420(), "Error{0}", index)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 3463, 3496);

                            f_1126_3463_3495(_errors, f_1126_3475_3494(info, key));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1126, 1, 240);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1126, 1, 240);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1126, 3171, 3530);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1126, 2845, 3541);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 2845, 3541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 2845, 3541);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1126, 3808, 4688);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4010, 4117) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1126, 4010, 4117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4060, 4102);

                    throw f_1126_4066_4101("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1126, 4010, 4117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4133, 4167);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1126, 4133, 4166);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4259, 4677) || true) && (_errors != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1126, 4259, 4677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4312, 4343);

                    int
                    errorCount = f_1126_4329_4342(_errors)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4361, 4401);

                    f_1126_4361_4400(info, "ErrorCount", errorCount);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4430, 4439);

                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4421, 4662) || true) && (index < errorCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4461, 4468)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1126, 4421, 4662))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1126, 4421, 4662);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4510, 4586);

                            string
                            key = f_1126_4523_4585(f_1126_4537_4565(), "Error{0}", index)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4608, 4643);

                            f_1126_4608_4642(info, key, f_1126_4627_4641(_errors, index));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1126, 1, 242);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1126, 1, 242);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1126, 4259, 4677);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1126, 3808, 4688);

                System.Management.Automation.PSArgumentNullException
                f_1126_4066_4101(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 4066, 4101);
                    return return_v;
                }


                int
                f_1126_4329_4342(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1126, 4329, 4342);
                    return return_v;
                }


                int
                f_1126_4361_4400(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, int
                value)
                {
                    this_param.AddValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 4361, 4400);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1126_4537_4565()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1126, 4537, 4565);
                    return return_v;
                }


                string
                f_1126_4523_4585(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 4523, 4585);
                    return return_v;
                }


                string
                f_1126_4627_4641(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1126, 4627, 4641);
                    return return_v;
                }


                int
                f_1126_4608_4642(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 4608, 4642);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 3808, 4688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 3808, 4688);
            }
        }

        protected void SetDefaultErrorRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1126, 4789, 4975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4852, 4896);

                f_1126_4852_4895(this, ErrorCategory.InvalidData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 4910, 4964);

                f_1126_4910_4963(this, f_1126_4921_4962(typeof(FormatTableLoadException)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1126, 4789, 4975);

                int
                f_1126_4852_4895(System.Management.Automation.Runspaces.FormatTableLoadException
                this_param, System.Management.Automation.ErrorCategory
                errorCategory)
                {
                    this_param.SetErrorCategory(errorCategory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 4852, 4895);
                    return 0;
                }


                string
                f_1126_4921_4962(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1126, 4921, 4962);
                    return return_v;
                }


                int
                f_1126_4910_4963(System.Management.Automation.Runspaces.FormatTableLoadException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 4910, 4963);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 4789, 4975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 4789, 4975);
            }
        }

        public Collection<string> Errors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1126, 5142, 5208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 5178, 5193);

                    return _errors;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1126, 5142, 5208);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 5085, 5219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 5085, 5219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static FormatTableLoadException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1126, 755, 5226);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1126, 755, 5226);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 755, 5226);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1126, 755, 5226);

        int
        f_1126_1203_1226(System.Management.Automation.Runspaces.FormatTableLoadException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 1203, 1226);
            return 0;
        }


        int
        f_1126_1546_1569(System.Management.Automation.Runspaces.FormatTableLoadException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 1546, 1569);
            return 0;
        }


        static string
        f_1126_1513_1520_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1126, 1458, 1581);
            return return_v;
        }


        int
        f_1126_2054_2077(System.Management.Automation.Runspaces.FormatTableLoadException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 2054, 2077);
            return 0;
        }


        static string
        f_1126_2005_2012_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1126, 1911, 2089);
            return return_v;
        }


        static string
        f_1126_2459_2510()
        {
            var return_v = FormatAndOutXmlLoadingStrings.FormatTableLoadErrors;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1126, 2459, 2510);
            return return_v;
        }


        static string
        f_1126_2441_2511(string
        formatSpec, params object[]
        o)
        {
            var return_v = StringUtil.Format(formatSpec, o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 2441, 2511);
            return return_v;
        }


        string[]
        f_1126_2570_2590(System.Collections.Concurrent.ConcurrentBag<string>
        this_param)
        {
            var return_v = this_param.ToArray();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 2570, 2590);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1126_2547_2591(string[]
        list)
        {
            var return_v = new System.Collections.ObjectModel.Collection<string>((System.Collections.Generic.IList<string>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 2547, 2591);
            return return_v;
        }


        int
        f_1126_2606_2629(System.Management.Automation.Runspaces.FormatTableLoadException
        this_param)
        {
            this_param.SetDefaultErrorRecord();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 2606, 2629);
            return 0;
        }


        static string
        f_1126_2441_2511_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1126, 2353, 2641);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1126_3045_3080(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 3045, 3080);
            return return_v;
        }


        int
        f_1126_3129_3156(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetInt32(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 3129, 3156);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1126_3233_3257()
        {
            var return_v = new System.Collections.ObjectModel.Collection<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 3233, 3257);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_1126_3392_3420()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1126, 3392, 3420);
            return return_v;
        }


        string
        f_1126_3378_3440(System.Globalization.CultureInfo
        provider, string
        format, int
        arg0)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 3378, 3440);
            return return_v;
        }


        string?
        f_1126_3475_3494(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 3475, 3494);
            return return_v;
        }


        int
        f_1126_3463_3495(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 3463, 3495);
            return 0;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1126_2950_2954_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1126, 2845, 3541);
            return return_v;
        }

    }
    [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "FormatTable")]
    public sealed class FormatTable
    {
        private TypeInfoDataBaseManager _formatDBMgr;

        internal FormatTable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1126, 5747, 5850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 5588, 5600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 5794, 5839);

                _formatDBMgr = f_1126_5809_5838();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1126, 5747, 5850);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 5747, 5850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 5747, 5850);
            }
        }

        public FormatTable(IEnumerable<string> formatFiles) : this(f_1126_6546_6557_C(formatFiles), null, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1126, 6487, 6592);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1126, 6487, 6592);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 6487, 6592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 6487, 6592);
            }
        }

        public void AppendFormatData(IEnumerable<ExtendedTypeDefinition> formatData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1126, 7222, 7494);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 7323, 7423) || true) && (formatData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1126, 7323, 7423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 7364, 7423);

                    throw f_1126_7370_7422("formatData");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1126, 7323, 7423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 7437, 7483);

                f_1126_7437_7482(_formatDBMgr, formatData, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1126, 7222, 7494);

                System.Management.Automation.PSArgumentNullException
                f_1126_7370_7422(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 7370, 7422);
                    return return_v;
                }


                int
                f_1126_7437_7482(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                formatData, bool
                shouldPrepend)
                {
                    this_param.AddFormatData(formatData, shouldPrepend);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 7437, 7482);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 7222, 7494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 7222, 7494);
            }
        }

        public void PrependFormatData(IEnumerable<ExtendedTypeDefinition> formatData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1126, 8125, 8397);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 8227, 8327) || true) && (formatData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1126, 8227, 8327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 8268, 8327);

                    throw f_1126_8274_8326("formatData");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1126, 8227, 8327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 8341, 8386);

                f_1126_8341_8385(_formatDBMgr, formatData, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1126, 8125, 8397);

                System.Management.Automation.PSArgumentNullException
                f_1126_8274_8326(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 8274, 8326);
                    return return_v;
                }


                int
                f_1126_8341_8385(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                formatData, bool
                shouldPrepend)
                {
                    this_param.AddFormatData(formatData, shouldPrepend);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 8341, 8385);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 8125, 8397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 8125, 8397);
            }
        }

        internal FormatTable(IEnumerable<string> formatFiles, AuthorizationManager authorizationManager, PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1126, 9412, 9795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 5588, 5600);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 9546, 9678) || true) && (formatFiles == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1126, 9546, 9678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 9603, 9663);

                    throw f_1126_9609_9662("formatFiles");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1126, 9546, 9678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 9694, 9784);

                _formatDBMgr = f_1126_9709_9783(formatFiles, true, authorizationManager, host);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1126, 9412, 9795);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 9412, 9795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 9412, 9795);
            }
        }

        internal TypeInfoDataBaseManager FormatDBManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1126, 9951, 9979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 9957, 9977);

                    return _formatDBMgr;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1126, 9951, 9979);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 9878, 9990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 9878, 9990);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void Add(string formatFile, bool shouldPrepend)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1126, 10482, 10618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 10563, 10607);

                f_1126_10563_10606(_formatDBMgr, formatFile, shouldPrepend);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1126, 10482, 10618);

                int
                f_1126_10563_10606(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                this_param, string
                formatFile, bool
                shouldPrepend)
                {
                    this_param.Add(formatFile, shouldPrepend);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 10563, 10606);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 10482, 10618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 10482, 10618);
            }
        }

        internal void Remove(string formatFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1126, 10902, 11009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 10966, 10998);

                f_1126_10966_10997(_formatDBMgr, formatFile);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1126, 10902, 11009);

                int
                f_1126_10966_10997(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                this_param, string
                formatFile)
                {
                    this_param.Remove(formatFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 10966, 10997);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 10902, 11009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 10902, 11009);
            }
        }

        public static FormatTable LoadDefaultFormatFiles()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1126, 11253, 11705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 11328, 11375);

                string
                psHome = f_1126_11344_11374()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 11389, 11442);

                List<string>
                defaultFormatFiles = f_1126_11423_11441()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 11456, 11635) || true) && (!f_1126_11461_11489(psHome))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1126, 11456, 11635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 11523, 11620);

                    f_1126_11523_11619(defaultFormatFiles, f_1126_11551_11618(Platform.FormatFileNames, file => Path.Combine(psHome, file)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1126, 11456, 11635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1126, 11651, 11694);

                return f_1126_11658_11693(defaultFormatFiles);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1126, 11253, 11705);

                string
                f_1126_11344_11374()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1126, 11344, 11374);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1126_11423_11441()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 11423, 11441);
                    return return_v;
                }


                bool
                f_1126_11461_11489(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 11461, 11489);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1126_11551_11618(System.Collections.Generic.List<string>
                source, System.Func<string, string>
                selector)
                {
                    var return_v = source.Select<string, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 11551, 11618);
                    return return_v;
                }


                int
                f_1126_11523_11619(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 11523, 11619);
                    return 0;
                }


                System.Management.Automation.Runspaces.FormatTable
                f_1126_11658_11693(System.Collections.Generic.List<string>
                formatFiles)
                {
                    var return_v = new System.Management.Automation.Runspaces.FormatTable((System.Collections.Generic.IEnumerable<string>)formatFiles);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 11658, 11693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1126, 11253, 11705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 11253, 11705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FormatTable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1126, 5360, 11747);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1126, 5360, 11747);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1126, 5360, 11747);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1126, 5360, 11747);

        Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
        f_1126_5809_5838()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 5809, 5838);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<string>
        f_1126_6546_6557_C(System.Collections.Generic.IEnumerable<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1126, 6487, 6592);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1126_9609_9662(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 9609, 9662);
            return return_v;
        }


        Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
        f_1126_9709_9783(System.Collections.Generic.IEnumerable<string>
        formatFiles, bool
        isShared, System.Management.Automation.AuthorizationManager
        authorizationManager, System.Management.Automation.Host.PSHost
        host)
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager(formatFiles, isShared, authorizationManager, host);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1126, 9709, 9783);
            return return_v;
        }

    }
}
