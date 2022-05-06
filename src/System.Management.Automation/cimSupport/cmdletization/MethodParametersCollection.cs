// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.ObjectModel;

namespace Microsoft.PowerShell.Cmdletization
{
    internal sealed class MethodParametersCollection : KeyedCollection<string, MethodParameter>
    {
        public MethodParametersCollection()
        : base(f_1064_697_719_C(f_1064_697_719()), 5)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1064, 641, 745);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1064, 641, 745);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1064, 641, 745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1064, 641, 745);
            }
        }

        protected override string GetKeyForItem(MethodParameter item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1064, 924, 1038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1064, 1010, 1027);

                return f_1064_1017_1026(item);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1064, 924, 1038);

                string
                f_1064_1017_1026(Microsoft.PowerShell.Cmdletization.MethodParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1064, 1017, 1026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1064, 924, 1038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1064, 924, 1038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodParametersCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1064, 423, 1045);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1064, 423, 1045);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1064, 423, 1045);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1064, 423, 1045);

        static System.StringComparer
        f_1064_697_719()
        {
            var return_v = StringComparer.Ordinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1064, 697, 719);
            return return_v;
        }


        static System.Collections.Generic.IEqualityComparer<string>
        f_1064_697_719_C(System.Collections.Generic.IEqualityComparer<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1064, 641, 745);
            return return_v;
        }

    }
}
