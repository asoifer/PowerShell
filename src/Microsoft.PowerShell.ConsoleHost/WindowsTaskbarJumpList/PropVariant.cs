// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.PowerShell
{
    [StructLayout(LayoutKind.Explicit)]
    internal sealed class PropVariant : IDisposable
    {
        [FieldOffset(0)]
        ushort _valueType;

        [FieldOffset(8)]
        IntPtr _ptr;

        internal PropVariant(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(133, 938, 1454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 785, 795);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 997, 1125) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(133, 997, 1125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1048, 1110);

                    throw f_133_1054_1109("PropVariantNullString", "value");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(133, 997, 1125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1244, 1283);

                _valueType = (ushort)VarEnum.VT_LPWSTR;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1400, 1443);

                _ptr = f_133_1407_1442(value);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(133, 938, 1454);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 938, 1454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 938, 1454);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(133, 1573, 1720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1619, 1667);

                f_133_1619_1666(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1683, 1709);

                f_133_1683_1708(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(133, 1573, 1720);

                int
                f_133_1619_1666(Microsoft.PowerShell.PropVariant
                pvar)
                {
                    PropVariantNativeMethods.PropVariantClear(pvar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 1619, 1666);
                    return 0;
                }


                int
                f_133_1683_1708(Microsoft.PowerShell.PropVariant
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 1683, 1708);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(133, 1573, 1720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 1573, 1720);
            }
        }

        /// <summary>
        /// Finalizer.
        /// </summary>
        ~PropVariant()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(133, 1842, 1852);

            f_133_1842_1851(this);
        }
        private class PropVariantNativeMethods
        {
            [DllImport("Ole32.dll", PreserveSig = false)]
            internal static extern void PropVariantClear([In, Out] PropVariant pvar);

            public PropVariantNativeMethods()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(133, 1875, 2081);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(133, 1875, 2081);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 1875, 2081);
            }


            static PropVariantNativeMethods()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(133, 1875, 2081);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(133, 1875, 2081);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 1875, 2081);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(133, 1875, 2081);
        }

        static PropVariant()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(133, 536, 2088);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(133, 536, 2088);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(133, 536, 2088);
        }

        [FieldOffset(16)]
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(133, 536, 2088);

        System.ArgumentException
        f_133_1054_1109(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 1054, 1109);
            return return_v;
        }


        System.IntPtr
        f_133_1407_1442(string
        s)
        {
            var return_v = Marshal.StringToCoTaskMemUni(s);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 1407, 1442);
            return return_v;
        }


        int
        f_133_1842_1851(Microsoft.PowerShell.PropVariant
        this_param)
        {
            this_param.Dispose();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(133, 1842, 1851);
            return 0;
        }

    }
}
