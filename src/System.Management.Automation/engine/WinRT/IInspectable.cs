// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Management.Automation
{
    /// <summary>
    /// IInspectable represents the base interface for all WinRT types.
    /// Any run time class exposed through WInRT language projections
    /// like C#, VB.Net, C++ and JavaScript would have implemented
    /// the IInspectable interface.
    /// This interface is needed on long term basis to efficiently support identifying
    /// WinRT type instances created in Powershell session. Hence being
    /// included as part of SMA.
    /// The only purpose of this interface is to identify if the created object is of WinRT type.
    /// Users should not implement this interface for any custom functionalities.
    /// This is like a PInvoke. WinRT team have defined IInspectable in the COM layer.
    /// Through PInvoke this interface is being used in the managed layer.
    /// </summary>
    [Guid("AF86E2E0-B12D-4c6a-9C5A-D7AA65101E90")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IInspectable { }
    internal class WinRTHelper
    {
        internal static bool IsWinRTType(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1565, 1318, 1858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1565, 1786, 1847);

                return f_1565_1793_1846(f_1565_1793_1819(f_1565_1793_1808(type)), "WindowsRuntime");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1565, 1318, 1858);

                System.Reflection.TypeAttributes
                f_1565_1793_1808(System.Type
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1565, 1793, 1808);
                    return return_v;
                }


                string
                f_1565_1793_1819(System.Reflection.TypeAttributes
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1565, 1793, 1819);
                    return return_v;
                }


                bool
                f_1565_1793_1846(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1565, 1793, 1846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1565, 1318, 1858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1565, 1318, 1858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WinRTHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1565, 1275, 1865);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1565, 1275, 1865);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1565, 1275, 1865);
        }


        static WinRTHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1565, 1275, 1865);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1565, 1275, 1865);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1565, 1275, 1865);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1565, 1275, 1865);
    }
}
