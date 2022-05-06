// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;

namespace Microsoft.PowerShell.Cmdletization
{
    /// <summary>
    /// Describes whether to report errors when a given filter doesnt match any objects.
    /// </summary>
    public enum BehaviorOnNoMatch
    {
        /// <summary>
        /// Default behavior is to be consistent with the built-in cmdlets:
        /// - When a wildcard is specified, then no errors are reported (i.e. Get-Process -Name noSuchProcess*)
        /// - When no wildcard is specified, then errors are reported (i.e. Get-Process -Name noSuchProcess)
        ///
        /// Note that the following conventions are adopted:
        /// - Min/max queries
        ///   (<see cref="QueryBuilder.FilterByMinPropertyValue(string,object,BehaviorOnNoMatch)"/> and
        ///    <see cref="QueryBuilder.FilterByMaxPropertyValue(string,object,BehaviorOnNoMatch)"/>)
        ///   are treated as wildcards
        /// - Exclusions
        ///   (<see cref="QueryBuilder.ExcludeByProperty(string,System.Collections.IEnumerable,bool,BehaviorOnNoMatch)"/>)
        ///   are treated as wildcards
        /// - Associations
        ///   (<see cref="QueryBuilder.FilterByAssociatedInstance(object,string,string,string,BehaviorOnNoMatch)"/>)
        ///   are treated as not a wildcard.
        /// </summary>
        Default = 0,

        /// <summary>
        /// <c>ReportErrors</c> forces reporting of errors that in other circumstances would be reported if no objects matched the filters.
        /// </summary>
        ReportErrors,

        /// <summary>
        /// <c>SilentlyContinue</c> suppresses errors that in other circumstances would be reported if no objects matched the filters.
        /// </summary>
        SilentlyContinue,
    }
    public abstract class QueryBuilder
    {
        public virtual void FilterByProperty(string propertyName, IEnumerable allowedPropertyValues, bool wildcardsEnabled, BehaviorOnNoMatch behaviorOnNoMatch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1066, 2803, 3027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1066, 2980, 3016);

                throw f_1066_2986_3015();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1066, 2803, 3027);

                System.NotImplementedException
                f_1066_2986_3015()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1066, 2986, 3015);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1066, 2803, 3027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1066, 2803, 3027);
            }
        }

        public virtual void ExcludeByProperty(string propertyName, IEnumerable excludedPropertyValues, bool wildcardsEnabled, BehaviorOnNoMatch behaviorOnNoMatch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1066, 3754, 3980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1066, 3933, 3969);

                throw f_1066_3939_3968();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1066, 3754, 3980);

                System.NotImplementedException
                f_1066_3939_3968()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1066, 3939, 3968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1066, 3754, 3980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1066, 3754, 3980);
            }
        }

        public virtual void FilterByMinPropertyValue(string propertyName, object minPropertyValue, BehaviorOnNoMatch behaviorOnNoMatch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1066, 4499, 4698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1066, 4651, 4687);

                throw f_1066_4657_4686();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1066, 4499, 4698);

                System.NotImplementedException
                f_1066_4657_4686()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1066, 4657, 4686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1066, 4499, 4698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1066, 4499, 4698);
            }
        }

        public virtual void FilterByMaxPropertyValue(string propertyName, object maxPropertyValue, BehaviorOnNoMatch behaviorOnNoMatch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1066, 5214, 5413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1066, 5366, 5402);

                throw f_1066_5372_5401();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1066, 5214, 5413);

                System.NotImplementedException
                f_1066_5372_5401()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1066, 5372, 5401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1066, 5214, 5413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1066, 5214, 5413);
            }
        }

        public virtual void FilterByAssociatedInstance(object associatedInstance, string associationName, string sourceRole, string resultRole, BehaviorOnNoMatch behaviorOnNoMatch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1066, 6155, 6399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1066, 6352, 6388);

                throw f_1066_6358_6387();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1066, 6155, 6399);

                System.NotImplementedException
                f_1066_6358_6387()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1066, 6358, 6387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1066, 6155, 6399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1066, 6155, 6399);
            }
        }

        public virtual void AddQueryOption(string optionName, object optionValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1066, 6587, 6732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1066, 6685, 6721);

                throw f_1066_6691_6720();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1066, 6587, 6732);

                System.NotImplementedException
                f_1066_6691_6720()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1066, 6691, 6720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1066, 6587, 6732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1066, 6587, 6732);
            }
        }

        public QueryBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1066, 2042, 6739);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1066, 2042, 6739);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1066, 2042, 6739);
        }


        static QueryBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1066, 2042, 6739);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1066, 2042, 6739);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1066, 2042, 6739);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1066, 2042, 6739);
    }
}
