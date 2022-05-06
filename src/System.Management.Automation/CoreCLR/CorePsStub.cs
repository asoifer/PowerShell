// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;

using Microsoft.Win32;

#pragma warning disable 1591, 1572, 1571, 1573, 1587, 1570, 0067

// Include PS types that are not needed for PowerShell on CSS

namespace System.Management.Automation
{
    public sealed class PSTransactionContext : IDisposable
    {
        internal PSTransactionContext(Internal.PSTransactionManager transactionManager)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1076, 678, 761);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1076, 678, 761);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 678, 761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 678, 761);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 773, 798);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 773, 798);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 773, 798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 773, 798);
            }
        }

        static PSTransactionContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1076, 607, 805);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1076, 607, 805);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 607, 805);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1076, 607, 805);
    }

    /// <summary>
    /// The severity of error that causes PowerShell to automatically
    /// rollback the transaction.
    /// </summary>
    public enum RollbackSeverity
    {
        /// <summary>
        /// Non-terminating errors or worse.
        /// </summary>
        Error,

        /// <summary>
        /// Terminating errors or worse.
        /// </summary>
        TerminatingError,

        /// <summary>
        /// Do not rollback the transaction on error.
        /// </summary>
        Never
    }

}

namespace System.Management.Automation.Internal
{
    internal sealed class PSTransactionManager : IDisposable
    {
        internal bool HasTransaction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 1965, 2029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 2001, 2014);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 1965, 2029);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 1912, 2040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 1912, 2040);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsLastTransactionCommitted
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 2232, 2347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 2268, 2332);

                    throw f_1076_2274_2331("IsLastTransactionCommitted");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 2232, 2347);

                    System.NotImplementedException
                    f_1076_2274_2331(string
                    message)
                    {
                        var return_v = new System.NotImplementedException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 2274, 2331);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 2167, 2358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 2167, 2358);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsLastTransactionRolledBack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 2553, 2669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 2589, 2654);

                    throw f_1076_2595_2653("IsLastTransactionRolledBack");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 2553, 2669);

                    System.NotImplementedException
                    f_1076_2595_2653(string
                    message)
                    {
                        var return_v = new System.NotImplementedException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 2595, 2653);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 2487, 2680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 2487, 2680);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal RollbackSeverity RollbackPreference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 2878, 2985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 2914, 2970);

                    throw f_1076_2920_2969("RollbackPreference");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 2878, 2985);

                    System.NotImplementedException
                    f_1076_2920_2969(string
                    message)
                    {
                        var return_v = new System.NotImplementedException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 2920, 2969);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 2809, 2996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 2809, 2996);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static IDisposable GetEngineProtectionScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 3249, 3351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 3328, 3340);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 3249, 3351);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 3249, 3351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 3249, 3351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Rollback(bool suppressErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 3502, 3627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 3570, 3616);

                throw f_1076_3576_3615("Rollback");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 3502, 3627);

                System.NotImplementedException
                f_1076_3576_3615(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 3576, 3615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 3502, 3627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 3502, 3627);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 3639, 3664);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 3639, 3664);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 3639, 3664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 3639, 3664);
            }
        }

        public PSTransactionManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1076, 1614, 3671);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1076, 1614, 3671);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 1614, 3671);
        }


        static PSTransactionManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1076, 1614, 3671);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1076, 1614, 3671);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 1614, 3671);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1076, 1614, 3671);
    }
}

namespace System.Management.Automation.ComInterop
{
    using System.Dynamic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    internal static class ComBinder
    {
        public static bool TryBindGetIndex(GetIndexBinder binder, DynamicMetaObject instance, DynamicMetaObject[] args, out DynamicMetaObject result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 4318, 4536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 4484, 4498);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 4512, 4525);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 4318, 4536);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 4318, 4536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 4318, 4536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryBindSetIndex(SetIndexBinder binder, DynamicMetaObject instance, DynamicMetaObject[] args, DynamicMetaObject value, out DynamicMetaObject result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 4761, 5004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 4952, 4966);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 4980, 4993);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 4761, 5004);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 4761, 5004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 4761, 5004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryBindGetMember(GetMemberBinder binder, DynamicMetaObject instance, out DynamicMetaObject result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 5230, 5424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 5372, 5386);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 5400, 5413);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 5230, 5424);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 5230, 5424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 5230, 5424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryBindSetMember(SetMemberBinder binder, DynamicMetaObject instance, DynamicMetaObject value, out DynamicMetaObject result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 5650, 5869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 5817, 5831);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 5845, 5858);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 5650, 5869);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 5650, 5869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 5650, 5869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryBindInvokeMember(InvokeMemberBinder binder, bool isSetProperty, DynamicMetaObject instance, DynamicMetaObject[] args, out DynamicMetaObject result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 6098, 6344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 6292, 6306);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 6320, 6333);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 6098, 6344);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 6098, 6344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 6098, 6344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ComBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1076, 4057, 6351);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1076, 4057, 6351);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 4057, 6351);
        }

    }
    internal class VarEnumSelector
    {
        private static readonly Dictionary<VarEnum, Type> _ComToManagedPrimitiveTypes;

        internal static Type GetTypeForVarEnum(VarEnum vt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 6615, 8364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 6690, 6700);

                Type
                type
                = default(Type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 6716, 8325);

                switch (vt)
                {

                    case VarEnum.VT_EMPTY:
                    case VarEnum.VT_NULL:
                    case VarEnum.VT_RECORD:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 6716, 8325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 6981, 7001);

                        type = typeof(void);
                        DynAbs.Tracing.TraceSender.TraceBreak(1076, 7023, 7029);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 6716, 8325);

                    case VarEnum.VT_VOID:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 6716, 8325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 7187, 7207);

                        type = typeof(void);
                        DynAbs.Tracing.TraceSender.TraceBreak(1076, 7229, 7235);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 6716, 8325);

                    case VarEnum.VT_HRESULT:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 6716, 8325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 7301, 7320);

                        type = typeof(int);
                        DynAbs.Tracing.TraceSender.TraceBreak(1076, 7342, 7348);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 6716, 8325);

                    case ((VarEnum)37): // VT_INT_PTR:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 6716, 8325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 7424, 7446);

                        type = typeof(IntPtr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1076, 7468, 7474);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 6716, 8325);

                    case ((VarEnum)38): // VT_UINT_PTR:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 6716, 8325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 7551, 7574);

                        type = typeof(UIntPtr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1076, 7596, 7602);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 6716, 8325);

                    case VarEnum.VT_SAFEARRAY:
                    case VarEnum.VT_CARRAY:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 6716, 8325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 7711, 7732);

                        type = typeof(Array);
                        DynAbs.Tracing.TraceSender.TraceBreak(1076, 7754, 7760);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 6716, 8325);

                    case VarEnum.VT_LPSTR:
                    case VarEnum.VT_LPWSTR:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 6716, 8325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 7865, 7887);

                        type = typeof(string);
                        DynAbs.Tracing.TraceSender.TraceBreak(1076, 7909, 7915);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 6716, 8325);

                    case VarEnum.VT_PTR:
                    case VarEnum.VT_USERDEFINED:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 6716, 8325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 8023, 8045);

                        type = typeof(object);
                        DynAbs.Tracing.TraceSender.TraceBreak(1076, 8067, 8073);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 6716, 8325);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 6716, 8325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 8233, 8282);

                        type = f_1076_8240_8281(vt);
                        DynAbs.Tracing.TraceSender.TraceBreak(1076, 8304, 8310);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 6716, 8325);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 8341, 8353);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 6615, 8364);

                System.Type
                f_1076_8240_8281(System.Runtime.InteropServices.VarEnum
                varEnum)
                {
                    var return_v = VarEnumSelector.GetManagedMarshalType(varEnum);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 8240, 8281);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 6615, 8364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 6615, 8364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Type GetManagedMarshalType(VarEnum varEnum)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 9142, 10142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 9226, 9274);

                f_1076_9226_9273((varEnum & VarEnum.VT_BYREF) == 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 9290, 9398) || true) && (varEnum == VarEnum.VT_CY)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 9290, 9398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 9352, 9383);

                    return typeof(CurrencyWrapper);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 9290, 9398);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 9414, 9535) || true) && (f_1076_9418_9442(varEnum))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 9414, 9535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 9476, 9520);

                    return f_1076_9483_9519(_ComToManagedPrimitiveTypes, varEnum);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 9414, 9535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 9551, 10131);

                switch (varEnum)
                {

                    case VarEnum.VT_EMPTY:
                    case VarEnum.VT_NULL:
                    case VarEnum.VT_UNKNOWN:
                    case VarEnum.VT_DISPATCH:
                    case VarEnum.VT_VARIANT:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 9551, 10131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 9810, 9832);

                        return typeof(object);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 9551, 10131);

                    case VarEnum.VT_ERROR:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 9551, 10131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 9896, 9924);

                        return typeof(ErrorWrapper);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 9551, 10131);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 9551, 10131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 9974, 10116);

                        throw f_1076_9980_10115(f_1076_10010_10114(f_1076_10024_10071(), f_1076_10073_10104(), varEnum));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 9551, 10131);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 9142, 10142);

                int
                f_1076_9226_9273(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 9226, 9273);
                    return 0;
                }


                bool
                f_1076_9418_9442(System.Runtime.InteropServices.VarEnum
                varEnum)
                {
                    var return_v = IsPrimitiveType(varEnum);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 9418, 9442);
                    return return_v;
                }


                System.Type
                f_1076_9483_9519(System.Collections.Generic.Dictionary<System.Runtime.InteropServices.VarEnum, System.Type>
                this_param, System.Runtime.InteropServices.VarEnum
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1076, 9483, 9519);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1076_10024_10071()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1076, 10024, 10071);
                    return return_v;
                }


                string
                f_1076_10073_10104()
                {
                    var return_v = ParserStrings.UnexpectedVarEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1076, 10073, 10104);
                    return return_v;
                }


                string
                f_1076_10010_10114(System.Globalization.CultureInfo
                provider, string
                format, System.Runtime.InteropServices.VarEnum
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 10010, 10114);
                    return return_v;
                }


                System.InvalidOperationException
                f_1076_9980_10115(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 9980, 10115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 9142, 10142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 9142, 10142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Dictionary<VarEnum, Type> CreateComToManagedPrimitiveTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 10154, 11606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10254, 10319);

                Dictionary<VarEnum, Type>
                dict = f_1076_10287_10318()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10482, 10518);

                dict[VarEnum.VT_I1] = typeof(sbyte);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10532, 10568);

                dict[VarEnum.VT_I2] = typeof(Int16);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10582, 10618);

                dict[VarEnum.VT_I4] = typeof(Int32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10632, 10668);

                dict[VarEnum.VT_I8] = typeof(Int64);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10682, 10718);

                dict[VarEnum.VT_UI1] = typeof(byte);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10732, 10770);

                dict[VarEnum.VT_UI2] = typeof(UInt16);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10784, 10822);

                dict[VarEnum.VT_UI4] = typeof(UInt32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10836, 10874);

                dict[VarEnum.VT_UI8] = typeof(UInt64);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10888, 10925);

                dict[VarEnum.VT_INT] = typeof(Int32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10939, 10978);

                dict[VarEnum.VT_UINT] = typeof(UInt32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 10992, 11030);

                dict[VarEnum.VT_PTR] = typeof(IntPtr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11044, 11081);

                dict[VarEnum.VT_BOOL] = typeof(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11095, 11132);

                dict[VarEnum.VT_R4] = typeof(Single);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11146, 11183);

                dict[VarEnum.VT_R8] = typeof(double);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11197, 11240);

                dict[VarEnum.VT_DECIMAL] = typeof(decimal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11254, 11295);

                dict[VarEnum.VT_DATE] = typeof(DateTime);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11309, 11348);

                dict[VarEnum.VT_BSTR] = typeof(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11362, 11400);

                dict[VarEnum.VT_CLSID] = typeof(Guid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11461, 11507);

                dict[VarEnum.VT_CY] = typeof(CurrencyWrapper);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11521, 11567);

                dict[VarEnum.VT_ERROR] = typeof(ErrorWrapper);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11583, 11595);

                return dict;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 10154, 11606);

                System.Collections.Generic.Dictionary<System.Runtime.InteropServices.VarEnum, System.Type>
                f_1076_10287_10318()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Runtime.InteropServices.VarEnum, System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 10287, 10318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 10154, 11606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 10154, 11606);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPrimitiveType(VarEnum varEnum)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 11900, 12787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 11978, 12747);

                switch (varEnum)
                {

                    case VarEnum.VT_I1:
                    case VarEnum.VT_I2:
                    case VarEnum.VT_I4:
                    case VarEnum.VT_I8:
                    case VarEnum.VT_UI1:
                    case VarEnum.VT_UI2:
                    case VarEnum.VT_UI4:
                    case VarEnum.VT_UI8:
                    case VarEnum.VT_INT:
                    case VarEnum.VT_UINT:
                    case VarEnum.VT_BOOL:
                    case VarEnum.VT_ERROR:
                    case VarEnum.VT_R4:
                    case VarEnum.VT_R8:
                    case VarEnum.VT_DECIMAL:
                    case VarEnum.VT_CY:
                    case VarEnum.VT_DATE:
                    case VarEnum.VT_BSTR:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1076, 11978, 12747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 12720, 12732);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1076, 11978, 12747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 12763, 12776);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 11900, 12787);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 11900, 12787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 11900, 12787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public VarEnumSelector()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1076, 6441, 12794);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1076, 6441, 12794);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 6441, 12794);
        }


        static VarEnumSelector()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1076, 6441, 12794);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 6538, 6602);
            _ComToManagedPrimitiveTypes = f_1076_6568_6602();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1076, 6441, 12794);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 6441, 12794);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1076, 6441, 12794);

        static System.Collections.Generic.Dictionary<System.Runtime.InteropServices.VarEnum, System.Type>
        f_1076_6568_6602()
        {
            var return_v = CreateComToManagedPrimitiveTypes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 6568, 6602);
            return return_v;
        }

    }
#pragma warning restore 618
}

namespace Microsoft.PowerShell.Commands.Internal
{
    using System.Security.AccessControl;
    using System.Security.Principal;
    internal abstract class TransactedRegistryKey : IDisposable
    {
        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 13082, 13107);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 13082, 13107);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 13082, 13107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 13082, 13107);
            }
        }

        public void SetValue(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 13119, 13344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 13191, 13333);

                throw f_1076_13197_13332("SetValue(string name, obj value) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 13119, 13344);

                System.NotImplementedException
                f_1076_13197_13332(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 13197, 13332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 13119, 13344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 13119, 13344);
            }
        }

        public void SetValue(string name, object value, RegistryValueKind valueKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 13356, 13639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 13457, 13628);

                throw f_1076_13463_13627("SetValue(string name, obj value, RegistryValueKind valueKind) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 13356, 13639);

                System.NotImplementedException
                f_1076_13463_13627(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 13463, 13627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 13356, 13639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 13356, 13639);
            }
        }

        public string[] GetValueNames()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 13651, 13843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 13707, 13832);

                throw f_1076_13713_13831("GetValueNames() is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 13651, 13843);

                System.NotImplementedException
                f_1076_13713_13831(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 13713, 13831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 13651, 13843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 13651, 13843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void DeleteValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 13855, 14061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 13916, 14050);

                throw f_1076_13922_14049("DeleteValue(string name) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 13855, 14061);

                System.NotImplementedException
                f_1076_13922_14049(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 13922, 14049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 13855, 14061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 13855, 14061);
            }
        }

        public string[] GetSubKeyNames()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 14073, 14267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 14130, 14256);

                throw f_1076_14136_14255("GetSubKeyNames() is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 14073, 14267);

                System.NotImplementedException
                f_1076_14136_14255(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 14136, 14255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 14073, 14267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 14073, 14267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TransactedRegistryKey CreateSubKey(string subkey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 14279, 14508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 14360, 14497);

                throw f_1076_14366_14496("CreateSubKey(string subkey) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 14279, 14508);

                System.NotImplementedException
                f_1076_14366_14496(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 14366, 14496);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 14279, 14508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 14279, 14508);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TransactedRegistryKey OpenSubKey(string name, bool writable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 14520, 14772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 14612, 14761);

                throw f_1076_14618_14760("OpenSubKey(string name, bool writeable) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 14520, 14772);

                System.NotImplementedException
                f_1076_14618_14760(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 14618, 14760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 14520, 14772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 14520, 14772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void DeleteSubKeyTree(string subkey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 14784, 15004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 14852, 14993);

                throw f_1076_14858_14992("DeleteSubKeyTree(string subkey) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 14784, 15004);

                System.NotImplementedException
                f_1076_14858_14992(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 14858, 14992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 14784, 15004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 14784, 15004);
            }
        }

        public object GetValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 15016, 15218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 15076, 15207);

                throw f_1076_15082_15206("GetValue(string name) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 15016, 15218);

                System.NotImplementedException
                f_1076_15082_15206(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 15082, 15206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 15016, 15218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 15016, 15218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object GetValue(string name, object defaultValue, RegistryValueOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 15230, 15534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 15341, 15523);

                throw f_1076_15347_15522("GetValue(string name, object defaultValue, RegistryValueOptions options) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 15230, 15534);

                System.NotImplementedException
                f_1076_15347_15522(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 15347, 15522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 15230, 15534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 15230, 15534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RegistryValueKind GetValueKind(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 15546, 15767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 15621, 15756);

                throw f_1076_15627_15755("GetValueKind(string name) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 15546, 15767);

                System.NotImplementedException
                f_1076_15627_15755(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 15627, 15755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 15546, 15767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 15546, 15767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 15779, 15951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 15823, 15940);

                throw f_1076_15829_15939("Close() is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 15779, 15951);

                System.NotImplementedException
                f_1076_15829_15939(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 15829, 15939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 15779, 15951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 15779, 15951);
            }
        }

        public abstract string Name { get; }

        public abstract int SubKeyCount { get; }

        public void SetAccessControl(ObjectSecurity securityDescriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 16063, 16323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 16151, 16312);

                throw f_1076_16157_16311("SetAccessControl(ObjectSecurity securityDescriptor) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 16063, 16323);

                System.NotImplementedException
                f_1076_16157_16311(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 16157, 16311);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 16063, 16323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 16063, 16323);
            }
        }

        public ObjectSecurity GetAccessControl(AccessControlSections includeSections)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 16335, 16613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 16437, 16602);

                throw f_1076_16443_16601("GetAccessControl(AccessControlSections includeSections) is not implemented. TransactedRegistry related APIs should not be used.");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 16335, 16613);

                System.NotImplementedException
                f_1076_16443_16601(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 16443, 16601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 16335, 16613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 16335, 16613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TransactedRegistryKey()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1076, 13006, 16620);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1076, 13006, 16620);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 13006, 16620);
        }


        static TransactedRegistryKey()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1076, 13006, 16620);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1076, 13006, 16620);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 13006, 16620);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1076, 13006, 16620);
    }
    internal sealed class TransactedRegistry
    {
        internal static readonly TransactedRegistryKey LocalMachine;

        internal static readonly TransactedRegistryKey ClassesRoot;

        internal static readonly TransactedRegistryKey Users;

        internal static readonly TransactedRegistryKey CurrentConfig;

        internal static readonly TransactedRegistryKey CurrentUser;

        public TransactedRegistry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1076, 16628, 17024);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1076, 16628, 17024);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 16628, 17024);
        }


        static TransactedRegistry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1076, 16628, 17024);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 16732, 16744);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 16802, 16813);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 16871, 16876);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 16934, 16947);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 17005, 17016);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1076, 16628, 17024);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 16628, 17024);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1076, 16628, 17024);
    }
    internal sealed class TransactedRegistrySecurity : ObjectSecurity
    {
        public override Type AccessRightType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 17175, 17262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 17211, 17247);

                    throw f_1076_17217_17246();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 17175, 17262);

                    System.NotImplementedException
                    f_1076_17217_17246()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 17217, 17246);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 17114, 17273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 17114, 17273);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Type AccessRuleType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 17345, 17432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 17381, 17417);

                    throw f_1076_17387_17416();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 17345, 17432);

                    System.NotImplementedException
                    f_1076_17387_17416()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 17387, 17416);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 17285, 17443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 17285, 17443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Type AuditRuleType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 17514, 17601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 17550, 17586);

                    throw f_1076_17556_17585();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 17514, 17601);

                    System.NotImplementedException
                    f_1076_17556_17585()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 17556, 17585);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 17455, 17612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 17455, 17612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 17624, 17905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 17858, 17894);

                throw f_1076_17864_17893();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 17624, 17905);

                System.NotImplementedException
                f_1076_17864_17893()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 17864, 17893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 17624, 17905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 17624, 17905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 17917, 18190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 18143, 18179);

                throw f_1076_18149_18178();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 17917, 18190);

                System.NotImplementedException
                f_1076_18149_18178()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 18149, 18178);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 17917, 18190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 17917, 18190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 18202, 18386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 18339, 18375);

                throw f_1076_18345_18374();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 18202, 18386);

                System.NotImplementedException
                f_1076_18345_18374()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 18345, 18374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 18202, 18386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 18202, 18386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool ModifyAudit(AccessControlModification modification, AuditRule rule, out bool modified)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 18398, 18580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 18533, 18569);

                throw f_1076_18539_18568();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 18398, 18580);

                System.NotImplementedException
                f_1076_18539_18568()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 18539, 18568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 18398, 18580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 18398, 18580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TransactedRegistrySecurity()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1076, 17032, 18587);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1076, 17032, 18587);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 17032, 18587);
        }


        static TransactedRegistrySecurity()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1076, 17032, 18587);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1076, 17032, 18587);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 17032, 18587);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1076, 17032, 18587);
    }

}


// -- Will port the actual PS component [update: Not necessarily porting all PS components listed here]

namespace System.Management.Automation.Internal
{
    using Microsoft.PowerShell.Commands;
    internal static class PowerShellModuleAssemblyAnalyzer
    {
        internal static BinaryAnalysisResult AnalyzeModuleAssembly(string path, out Version assemblyVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 19250, 19453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 19375, 19416);

                assemblyVersion = f_1076_19393_19415("0.0.0.0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 19430, 19442);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 19250, 19453);

                System.Version
                f_1076_19393_19415(string
                version)
                {
                    var return_v = new System.Version(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 19393, 19415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 19250, 19453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 19250, 19453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PowerShellModuleAssemblyAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1076, 19179, 19460);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1076, 19179, 19460);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 19179, 19460);
        }

    }
}

namespace System.Management.Automation
{
    using Microsoft.Win32;
    internal sealed class RegistryStringResourceIndirect : IDisposable
    {
        internal static RegistryStringResourceIndirect GetResourceIndirectReader()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 19673, 19827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 19772, 19816);

                return f_1076_19779_19815();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 19673, 19827);

                System.Management.Automation.RegistryStringResourceIndirect
                f_1076_19779_19815()
                {
                    var return_v = new System.Management.Automation.RegistryStringResourceIndirect();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 19779, 19815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 19673, 19827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 19673, 19827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 19987, 20030);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 19987, 20030);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 19987, 20030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 19987, 20030);
            }
        }

        internal string GetResourceStringIndirect(
                    string assemblyName,
                    string modulePath,
                    string baseNameRIDPair)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 20042, 20328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 20212, 20317);

                throw f_1076_20218_20316("RegistryStringResourceIndirect.GetResourceStringIndirect - 3 params");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 20042, 20328);

                System.NotImplementedException
                f_1076_20218_20316(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 20218, 20316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 20042, 20328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 20042, 20328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetResourceStringIndirect(
                    RegistryKey key,
                    string valueName,
                    string assemblyName,
                    string modulePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1076, 20340, 20650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 20534, 20639);

                throw f_1076_20540_20638("RegistryStringResourceIndirect.GetResourceStringIndirect - 4 params");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1076, 20340, 20650);

                System.NotImplementedException
                f_1076_20540_20638(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1076, 20540, 20638);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 20340, 20650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 20340, 20650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RegistryStringResourceIndirect()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1076, 19590, 20657);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1076, 19590, 20657);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 19590, 20657);
        }


        static RegistryStringResourceIndirect()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1076, 19590, 20657);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1076, 19590, 20657);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 19590, 20657);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1076, 19590, 20657);
    }

}


namespace Microsoft.PowerShell
{
    internal static class NativeCultureResolver
    {
        internal static void SetThreadUILanguage(Int16 langId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 31130, 31188);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 31130, 31188);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 31130, 31188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 31130, 31188);
            }
        }

        internal static CultureInfo UICulture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 31262, 31487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 31298, 31334);

                    return f_1076_31305_31333();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 31262, 31487);

                    System.Globalization.CultureInfo
                    f_1076_31305_31333()
                    {
                        var return_v = CultureInfo.CurrentUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1076, 31305, 31333);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 31200, 31498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 31200, 31498);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static CultureInfo Culture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1076, 31570, 31793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1076, 31606, 31640);

                    return f_1076_31613_31639();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1076, 31570, 31793);

                    System.Globalization.CultureInfo
                    f_1076_31613_31639()
                    {
                        var return_v = CultureInfo.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1076, 31613, 31639);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1076, 31510, 31804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 31510, 31804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static NativeCultureResolver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1076, 31070, 31811);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1076, 31070, 31811);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1076, 31070, 31811);
        }

    }
}


#pragma warning restore 1591, 1572, 1571, 1573, 1587, 1570, 0067
