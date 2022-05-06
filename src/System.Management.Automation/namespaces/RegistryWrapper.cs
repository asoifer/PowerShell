// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

/*
 * The registry wrapper provides a common interface to both the transacted
 * and non-transacted registry APIs.  It is used exclusively by the registry provider
 * to perform registry operations.  In most cases, the wrapper simply forwards the
 * call to the appropriate registry API.
 */

using System;
using System.Globalization;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.Management.Automation.Provider;
using Microsoft.PowerShell.Commands.Internal;

namespace Microsoft.PowerShell.Commands
{
    internal interface IRegistryWrapper
    {

        void SetValue(string name, object value);

        void SetValue(string name, object value, RegistryValueKind valueKind);

        string[] GetValueNames();

        void DeleteValue(string name);

        string[] GetSubKeyNames();

        IRegistryWrapper CreateSubKey(string subkey);

        IRegistryWrapper OpenSubKey(string name, bool writable);

        void DeleteSubKeyTree(string subkey);

        object GetValue(string name);

        object GetValue(string name, object defaultValue, RegistryValueOptions options);

        RegistryValueKind GetValueKind(string name);

        object RegistryKey { get; }

        void SetAccessControl(ObjectSecurity securityDescriptor);

        ObjectSecurity GetAccessControl(AccessControlSections includeSections);

        void Close();

        string Name { get; }

        int SubKeyCount { get; }
    }
    internal static class RegistryWrapperUtils
    {
        public static object ConvertValueToUIntFromRegistryIfNeeded(string name, object value, RegistryValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1211, 1634, 2710);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 1898, 2516) || true) && (kind == RegistryValueKind.DWord)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 1898, 2516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 1975, 1994);

                        value = (int)value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 2016, 2175) || true) && ((int)value < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 2016, 2175);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 2084, 2152);

                            value = f_1211_2092_2151(f_1211_2114_2147(value), 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 2016, 2175);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 1898, 2516);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 1898, 2516);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 2217, 2516) || true) && (kind == RegistryValueKind.QWord)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 2217, 2516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 2294, 2314);

                            value = (long)value;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 2336, 2497) || true) && ((long)value < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 2336, 2497);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 2405, 2474);

                                value = f_1211_2413_2473(f_1211_2435_2469(value), 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 2336, 2497);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 2217, 2516);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 1898, 2516);
                    }
                }
                catch (System.IO.IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1211, 2545, 2670);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1211, 2545, 2670);
                    // This is expected if the value does not exist.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 2686, 2699);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1211, 1634, 2710);

                byte[]
                f_1211_2114_2147(object
                value)
                {
                    var return_v = BitConverter.GetBytes((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 2114, 2147);
                    return return_v;
                }


                uint
                f_1211_2092_2151(byte[]
                value, int
                startIndex)
                {
                    var return_v = BitConverter.ToUInt32(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 2092, 2151);
                    return return_v;
                }


                byte[]
                f_1211_2435_2469(object
                value)
                {
                    var return_v = BitConverter.GetBytes((long)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 2435, 2469);
                    return return_v;
                }


                ulong
                f_1211_2413_2473(byte[]
                value, int
                startIndex)
                {
                    var return_v = BitConverter.ToUInt64(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 2413, 2473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 1634, 2710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 1634, 2710);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object ConvertUIntToValueForRegistryIfNeeded(object value, RegistryValueKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1211, 2722, 4129);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 2932, 4089) || true) && (kind == RegistryValueKind.DWord)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 2932, 4089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 3001, 3021);

                    UInt32
                    intValue = 0
                    ;

                    // See if it's already a positive number
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 3143, 3208);

                        intValue = f_1211_3154_3207(value, f_1211_3178_3206());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 3230, 3295);

                        value = f_1211_3238_3294(f_1211_3259_3290(intValue), 0);
                    }
                    catch (OverflowException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1211, 3332, 3486);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1211, 3332, 3486);
                        // It must be a negative Int32, and therefore need no more conversion
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 2932, 4089);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 2932, 4089);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 3520, 4089) || true) && (kind == RegistryValueKind.QWord)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 3520, 4089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 3589, 3609);

                        UInt64
                        intValue = 0
                        ;

                        // See if it's already a positive number
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 3731, 3796);

                            intValue = f_1211_3742_3795(value, f_1211_3766_3794());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 3818, 3883);

                            value = f_1211_3826_3882(f_1211_3847_3878(intValue), 0);
                        }
                        catch (OverflowException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1211, 3920, 4074);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1211, 3920, 4074);
                            // It must be a negative Int64, and therefore need no more conversion
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 3520, 4089);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 2932, 4089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 4105, 4118);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1211, 2722, 4129);

                System.Globalization.CultureInfo
                f_1211_3178_3206()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 3178, 3206);
                    return return_v;
                }


                uint
                f_1211_3154_3207(object
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToUInt32(value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 3154, 3207);
                    return return_v;
                }


                byte[]
                f_1211_3259_3290(uint
                value)
                {
                    var return_v = BitConverter.GetBytes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 3259, 3290);
                    return return_v;
                }


                int
                f_1211_3238_3294(byte[]
                value, int
                startIndex)
                {
                    var return_v = BitConverter.ToInt32(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 3238, 3294);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1211_3766_3794()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 3766, 3794);
                    return return_v;
                }


                ulong
                f_1211_3742_3795(object
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToUInt64(value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 3742, 3795);
                    return return_v;
                }


                byte[]
                f_1211_3847_3878(ulong
                value)
                {
                    var return_v = BitConverter.GetBytes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 3847, 3878);
                    return return_v;
                }


                long
                f_1211_3826_3882(byte[]
                value, int
                startIndex)
                {
                    var return_v = BitConverter.ToInt64(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 3826, 3882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 2722, 4129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 2722, 4129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RegistryWrapperUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1211, 1575, 4136);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1211, 1575, 4136);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 1575, 4136);
        }

    }
    internal class RegistryWrapper : IRegistryWrapper
    {
        private RegistryKey _regKey;

        internal RegistryWrapper(RegistryKey regKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1211, 4250, 4347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 4230, 4237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 4319, 4336);

                _regKey = regKey;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1211, 4250, 4347);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 4250, 4347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 4250, 4347);
            }
        }

        public void SetValue(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 4403, 4516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 4475, 4505);

                f_1211_4475_4504(_regKey, name, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 4403, 4516);

                int
                f_1211_4475_4504(Microsoft.Win32.RegistryKey
                this_param, string
                name, object
                value)
                {
                    this_param.SetValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 4475, 4504);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 4403, 4516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 4403, 4516);
            }
        }

        public void SetValue(string name, object value, RegistryValueKind valueKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 4528, 4854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 4629, 4687);

                value = f_1211_4637_4686(value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 4701, 4786);

                value = f_1211_4709_4785(value, valueKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 4802, 4843);

                f_1211_4802_4842(
                            _regKey, name, value, valueKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 4528, 4854);

                object
                f_1211_4637_4686(object
                obj)
                {
                    var return_v = System.Management.Automation.PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 4637, 4686);
                    return return_v;
                }


                object
                f_1211_4709_4785(object
                value, Microsoft.Win32.RegistryValueKind
                kind)
                {
                    var return_v = RegistryWrapperUtils.ConvertUIntToValueForRegistryIfNeeded(value, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 4709, 4785);
                    return return_v;
                }


                int
                f_1211_4802_4842(Microsoft.Win32.RegistryKey
                this_param, string
                name, object
                value, Microsoft.Win32.RegistryValueKind
                valueKind)
                {
                    this_param.SetValue(name, value, valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 4802, 4842);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 4528, 4854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 4528, 4854);
            }
        }

        public string[] GetValueNames()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 4866, 4964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 4922, 4953);

                return f_1211_4929_4952(_regKey);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 4866, 4964);

                string[]
                f_1211_4929_4952(Microsoft.Win32.RegistryKey
                this_param)
                {
                    var return_v = this_param.GetValueNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 4929, 4952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 4866, 4964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 4866, 4964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void DeleteValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 4976, 5074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5037, 5063);

                f_1211_5037_5062(_regKey, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 4976, 5074);

                int
                f_1211_5037_5062(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    this_param.DeleteValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 5037, 5062);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 4976, 5074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 4976, 5074);
            }
        }

        public string[] GetSubKeyNames()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 5086, 5186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5143, 5175);

                return f_1211_5150_5174(_regKey);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 5086, 5186);

                string[]
                f_1211_5150_5174(Microsoft.Win32.RegistryKey
                this_param)
                {
                    var return_v = this_param.GetSubKeyNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 5150, 5174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 5086, 5186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 5086, 5186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IRegistryWrapper CreateSubKey(string subkey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 5198, 5469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5274, 5324);

                RegistryKey
                newKey = f_1211_5295_5323(_regKey, subkey)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5338, 5458) || true) && (newKey == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 5338, 5458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5375, 5387);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 5338, 5458);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 5338, 5458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5423, 5458);

                    return f_1211_5430_5457(newKey);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 5338, 5458);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 5198, 5469);

                Microsoft.Win32.RegistryKey
                f_1211_5295_5323(Microsoft.Win32.RegistryKey
                this_param, string
                subkey)
                {
                    var return_v = this_param.CreateSubKey(subkey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 5295, 5323);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.RegistryWrapper
                f_1211_5430_5457(Microsoft.Win32.RegistryKey
                regKey)
                {
                    var return_v = new Microsoft.PowerShell.Commands.RegistryWrapper(regKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 5430, 5457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 5198, 5469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 5198, 5469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IRegistryWrapper OpenSubKey(string name, bool writable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 5481, 5769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5568, 5624);

                RegistryKey
                newKey = f_1211_5589_5623(_regKey, name, writable)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5638, 5758) || true) && (newKey == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 5638, 5758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5675, 5687);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 5638, 5758);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 5638, 5758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5723, 5758);

                    return f_1211_5730_5757(newKey);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 5638, 5758);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 5481, 5769);

                Microsoft.Win32.RegistryKey
                f_1211_5589_5623(Microsoft.Win32.RegistryKey
                this_param, string
                name, bool
                writable)
                {
                    var return_v = this_param.OpenSubKey(name, writable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 5589, 5623);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.RegistryWrapper
                f_1211_5730_5757(Microsoft.Win32.RegistryKey
                regKey)
                {
                    var return_v = new Microsoft.PowerShell.Commands.RegistryWrapper(regKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 5730, 5757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 5481, 5769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 5481, 5769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void DeleteSubKeyTree(string subkey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 5781, 5893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5849, 5882);

                f_1211_5849_5881(_regKey, subkey);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 5781, 5893);

                int
                f_1211_5849_5881(Microsoft.Win32.RegistryKey
                this_param, string
                subkey)
                {
                    this_param.DeleteSubKeyTree(subkey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 5849, 5881);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 5781, 5893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 5781, 5893);
            }
        }

        public object GetValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 5905, 6350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 5965, 6003);

                object
                value = f_1211_5980_6002(_regKey, name)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 6055, 6156);

                    value = f_1211_6063_6155(name, value, f_1211_6136_6154(this, name));
                }
                catch (System.IO.IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1211, 6185, 6310);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1211, 6185, 6310);
                    // This is expected if the value does not exist.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 6326, 6339);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 5905, 6350);

                object
                f_1211_5980_6002(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 5980, 6002);
                    return return_v;
                }


                Microsoft.Win32.RegistryValueKind
                f_1211_6136_6154(Microsoft.PowerShell.Commands.RegistryWrapper
                this_param, string
                name)
                {
                    var return_v = this_param.GetValueKind(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 6136, 6154);
                    return return_v;
                }


                object
                f_1211_6063_6155(string
                name, object
                value, Microsoft.Win32.RegistryValueKind
                kind)
                {
                    var return_v = RegistryWrapperUtils.ConvertValueToUIntFromRegistryIfNeeded(name, value, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 6063, 6155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 5905, 6350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 5905, 6350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object GetValue(string name, object defaultValue, RegistryValueOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 6362, 6881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 6473, 6534);

                object
                value = f_1211_6488_6533(_regKey, name, defaultValue, options)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 6586, 6687);

                    value = f_1211_6594_6686(name, value, f_1211_6667_6685(this, name));
                }
                catch (System.IO.IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1211, 6716, 6841);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1211, 6716, 6841);
                    // This is expected if the value does not exist.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 6857, 6870);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 6362, 6881);

                object
                f_1211_6488_6533(Microsoft.Win32.RegistryKey
                this_param, string
                name, object
                defaultValue, Microsoft.Win32.RegistryValueOptions
                options)
                {
                    var return_v = this_param.GetValue(name, defaultValue, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 6488, 6533);
                    return return_v;
                }


                Microsoft.Win32.RegistryValueKind
                f_1211_6667_6685(Microsoft.PowerShell.Commands.RegistryWrapper
                this_param, string
                name)
                {
                    var return_v = this_param.GetValueKind(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 6667, 6685);
                    return return_v;
                }


                object
                f_1211_6594_6686(string
                name, object
                value, Microsoft.Win32.RegistryValueKind
                kind)
                {
                    var return_v = RegistryWrapperUtils.ConvertValueToUIntFromRegistryIfNeeded(name, value, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 6594, 6686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 6362, 6881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 6362, 6881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RegistryValueKind GetValueKind(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 6893, 7013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 6968, 7002);

                return f_1211_6975_7001(_regKey, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 6893, 7013);

                Microsoft.Win32.RegistryValueKind
                f_1211_6975_7001(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.GetValueKind(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 6975, 7001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 6893, 7013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 6893, 7013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 7025, 7098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 7069, 7087);

                f_1211_7069_7086(_regKey);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 7025, 7098);

                int
                f_1211_7069_7086(Microsoft.Win32.RegistryKey
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 7069, 7086);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 7025, 7098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 7025, 7098);
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 7153, 7181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 7159, 7179);

                    return f_1211_7166_7178(_regKey);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 7153, 7181);

                    string
                    f_1211_7166_7178(Microsoft.Win32.RegistryKey
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 7166, 7178);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 7110, 7192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 7110, 7192);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int SubKeyCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 7251, 7286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 7257, 7284);

                    return f_1211_7264_7283(_regKey);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 7251, 7286);

                    int
                    f_1211_7264_7283(Microsoft.Win32.RegistryKey
                    this_param)
                    {
                        var return_v = this_param.SubKeyCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 7264, 7283);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 7204, 7297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 7204, 7297);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public object RegistryKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 7359, 7382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 7365, 7380);

                    return _regKey;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 7359, 7382);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 7309, 7393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 7309, 7393);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void SetAccessControl(ObjectSecurity securityDescriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 7405, 7567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 7493, 7556);

                f_1211_7493_7555(_regKey, securityDescriptor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 7405, 7567);

                int
                f_1211_7493_7555(Microsoft.Win32.RegistryKey
                this_param, System.Security.AccessControl.ObjectSecurity
                registrySecurity)
                {
                    this_param.SetAccessControl((System.Security.AccessControl.RegistrySecurity)registrySecurity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 7493, 7555);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 7405, 7567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 7405, 7567);
            }
        }

        public ObjectSecurity GetAccessControl(AccessControlSections includeSections)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 7579, 7741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 7681, 7730);

                return f_1211_7688_7729(_regKey, includeSections);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 7579, 7741);

                System.Security.AccessControl.RegistrySecurity
                f_1211_7688_7729(Microsoft.Win32.RegistryKey
                this_param, System.Security.AccessControl.AccessControlSections
                includeSections)
                {
                    var return_v = this_param.GetAccessControl(includeSections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 7688, 7729);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 7579, 7741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 7579, 7741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RegistryWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1211, 4144, 7770);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1211, 4144, 7770);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 4144, 7770);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1211, 4144, 7770);
    }
    internal class TransactedRegistryWrapper : IRegistryWrapper
    {
        private TransactedRegistryKey _txRegKey;

        private CmdletProvider _provider;

        internal TransactedRegistryWrapper(TransactedRegistryKey txRegKey, CmdletProvider provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1211, 7949, 8132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 7884, 7893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 7927, 7936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 8065, 8086);

                _txRegKey = txRegKey;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 8100, 8121);

                _provider = provider;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1211, 7949, 8132);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 7949, 8132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 7949, 8132);
            }
        }

        public void SetValue(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 8188, 8389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 8260, 8378);
                using (f_1211_8267_8297(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 8331, 8363);

                    f_1211_8331_8362(_txRegKey, name, value);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 8260, 8378);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 8188, 8389);

                System.Management.Automation.PSTransactionContext
                f_1211_8267_8297(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 8267, 8297);
                    return return_v;
                }


                int
                f_1211_8331_8362(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, string
                name, object
                value)
                {
                    this_param.SetValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 8331, 8362);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 8188, 8389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 8188, 8389);
            }
        }

        public void SetValue(string name, object value, RegistryValueKind valueKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 8401, 8823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 8502, 8812);
                using (f_1211_8509_8539(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 8573, 8631);

                    value = f_1211_8581_8630(value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 8649, 8734);

                    value = f_1211_8657_8733(value, valueKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 8754, 8797);

                    f_1211_8754_8796(
                                    _txRegKey, name, value, valueKind);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 8502, 8812);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 8401, 8823);

                System.Management.Automation.PSTransactionContext
                f_1211_8509_8539(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 8509, 8539);
                    return return_v;
                }


                object
                f_1211_8581_8630(object
                obj)
                {
                    var return_v = System.Management.Automation.PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 8581, 8630);
                    return return_v;
                }


                object
                f_1211_8657_8733(object
                value, Microsoft.Win32.RegistryValueKind
                kind)
                {
                    var return_v = RegistryWrapperUtils.ConvertUIntToValueForRegistryIfNeeded(value, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 8657, 8733);
                    return return_v;
                }


                int
                f_1211_8754_8796(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, string
                name, object
                value, Microsoft.Win32.RegistryValueKind
                valueKind)
                {
                    this_param.SetValue(name, value, valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 8754, 8796);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 8401, 8823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 8401, 8823);
            }
        }

        public string[] GetValueNames()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 8835, 9021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 8891, 9010);
                using (f_1211_8898_8928(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 8962, 8995);

                    return f_1211_8969_8994(_txRegKey);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 8891, 9010);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 8835, 9021);

                System.Management.Automation.PSTransactionContext
                f_1211_8898_8928(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 8898, 8928);
                    return return_v;
                }


                string[]
                f_1211_8969_8994(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param)
                {
                    var return_v = this_param.GetValueNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 8969, 8994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 8835, 9021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 8835, 9021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void DeleteValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 9033, 9219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 9094, 9208);
                using (f_1211_9101_9131(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 9165, 9193);

                    f_1211_9165_9192(_txRegKey, name);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 9094, 9208);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 9033, 9219);

                System.Management.Automation.PSTransactionContext
                f_1211_9101_9131(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 9101, 9131);
                    return return_v;
                }


                int
                f_1211_9165_9192(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, string
                name)
                {
                    this_param.DeleteValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 9165, 9192);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 9033, 9219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 9033, 9219);
            }
        }

        public string[] GetSubKeyNames()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 9231, 9419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 9288, 9408);
                using (f_1211_9295_9325(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 9359, 9393);

                    return f_1211_9366_9392(_txRegKey);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 9288, 9408);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 9231, 9419);

                System.Management.Automation.PSTransactionContext
                f_1211_9295_9325(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 9295, 9325);
                    return return_v;
                }


                string[]
                f_1211_9366_9392(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param)
                {
                    var return_v = this_param.GetSubKeyNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 9366, 9392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 9231, 9419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 9231, 9419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IRegistryWrapper CreateSubKey(string subkey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 9431, 9837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 9507, 9826);
                using (f_1211_9514_9544(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 9578, 9640);

                    TransactedRegistryKey
                    newKey = f_1211_9609_9639(_txRegKey, subkey)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 9658, 9811) || true) && (newKey == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 9658, 9811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 9699, 9711);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 9658, 9811);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 9658, 9811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 9755, 9811);

                        return f_1211_9762_9810(newKey, _provider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 9658, 9811);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 9507, 9826);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 9431, 9837);

                System.Management.Automation.PSTransactionContext
                f_1211_9514_9544(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 9514, 9544);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                f_1211_9609_9639(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, string
                subkey)
                {
                    var return_v = this_param.CreateSubKey(subkey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 9609, 9639);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.TransactedRegistryWrapper
                f_1211_9762_9810(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                txRegKey, System.Management.Automation.Provider.CmdletProvider
                provider)
                {
                    var return_v = new Microsoft.PowerShell.Commands.TransactedRegistryWrapper(txRegKey, provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 9762, 9810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 9431, 9837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 9431, 9837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IRegistryWrapper OpenSubKey(string name, bool writable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 9849, 10272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 9936, 10261);
                using (f_1211_9943_9973(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 10007, 10075);

                    TransactedRegistryKey
                    newKey = f_1211_10038_10074(_txRegKey, name, writable)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 10093, 10246) || true) && (newKey == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 10093, 10246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 10134, 10146);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 10093, 10246);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1211, 10093, 10246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 10190, 10246);

                        return f_1211_10197_10245(newKey, _provider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1211, 10093, 10246);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 9936, 10261);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 9849, 10272);

                System.Management.Automation.PSTransactionContext
                f_1211_9943_9973(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 9943, 9973);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                f_1211_10038_10074(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, string
                name, bool
                writable)
                {
                    var return_v = this_param.OpenSubKey(name, writable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 10038, 10074);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.TransactedRegistryWrapper
                f_1211_10197_10245(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                txRegKey, System.Management.Automation.Provider.CmdletProvider
                provider)
                {
                    var return_v = new Microsoft.PowerShell.Commands.TransactedRegistryWrapper(txRegKey, provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 10197, 10245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 9849, 10272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 9849, 10272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void DeleteSubKeyTree(string subkey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 10284, 10484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 10352, 10473);
                using (f_1211_10359_10389(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 10423, 10458);

                    f_1211_10423_10457(_txRegKey, subkey);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 10352, 10473);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 10284, 10484);

                System.Management.Automation.PSTransactionContext
                f_1211_10359_10389(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 10359, 10389);
                    return return_v;
                }


                int
                f_1211_10423_10457(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, string
                subkey)
                {
                    this_param.DeleteSubKeyTree(subkey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 10423, 10457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 10284, 10484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 10284, 10484);
            }
        }

        public object GetValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 10496, 11065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 10556, 11054);
                using (f_1211_10563_10593(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 10627, 10667);

                    object
                    value = f_1211_10642_10666(_txRegKey, name)
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 10731, 10832);

                        value = f_1211_10739_10831(name, value, f_1211_10812_10830(this, name));
                    }
                    catch (System.IO.IOException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1211, 10869, 11006);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1211, 10869, 11006);
                        // This is expected if the value does not exist.
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 11026, 11039);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 10556, 11054);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 10496, 11065);

                System.Management.Automation.PSTransactionContext
                f_1211_10563_10593(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 10563, 10593);
                    return return_v;
                }


                object
                f_1211_10642_10666(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 10642, 10666);
                    return return_v;
                }


                Microsoft.Win32.RegistryValueKind
                f_1211_10812_10830(Microsoft.PowerShell.Commands.TransactedRegistryWrapper
                this_param, string
                name)
                {
                    var return_v = this_param.GetValueKind(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 10812, 10830);
                    return return_v;
                }


                object
                f_1211_10739_10831(string
                name, object
                value, Microsoft.Win32.RegistryValueKind
                kind)
                {
                    var return_v = RegistryWrapperUtils.ConvertValueToUIntFromRegistryIfNeeded(name, value, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 10739, 10831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 10496, 11065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 10496, 11065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object GetValue(string name, object defaultValue, RegistryValueOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 11077, 11720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 11188, 11709);
                using (f_1211_11195_11225(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 11259, 11322);

                    object
                    value = f_1211_11274_11321(_txRegKey, name, defaultValue, options)
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 11386, 11487);

                        value = f_1211_11394_11486(name, value, f_1211_11467_11485(this, name));
                    }
                    catch (System.IO.IOException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1211, 11524, 11661);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1211, 11524, 11661);
                        // This is expected if the value does not exist.
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 11681, 11694);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 11188, 11709);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 11077, 11720);

                System.Management.Automation.PSTransactionContext
                f_1211_11195_11225(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 11195, 11225);
                    return return_v;
                }


                object
                f_1211_11274_11321(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, string
                name, object
                defaultValue, Microsoft.Win32.RegistryValueOptions
                options)
                {
                    var return_v = this_param.GetValue(name, defaultValue, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 11274, 11321);
                    return return_v;
                }


                Microsoft.Win32.RegistryValueKind
                f_1211_11467_11485(Microsoft.PowerShell.Commands.TransactedRegistryWrapper
                this_param, string
                name)
                {
                    var return_v = this_param.GetValueKind(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 11467, 11485);
                    return return_v;
                }


                object
                f_1211_11394_11486(string
                name, object
                value, Microsoft.Win32.RegistryValueKind
                kind)
                {
                    var return_v = RegistryWrapperUtils.ConvertValueToUIntFromRegistryIfNeeded(name, value, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 11394, 11486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 11077, 11720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 11077, 11720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RegistryValueKind GetValueKind(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 11732, 11940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 11807, 11929);
                using (f_1211_11814_11844(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 11878, 11914);

                    return f_1211_11885_11913(_txRegKey, name);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 11807, 11929);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 11732, 11940);

                System.Management.Automation.PSTransactionContext
                f_1211_11814_11844(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 11814, 11844);
                    return return_v;
                }


                Microsoft.Win32.RegistryValueKind
                f_1211_11885_11913(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.GetValueKind(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 11885, 11913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 11732, 11940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 11732, 11940);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Close()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 11952, 12111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 11996, 12100);
                using (f_1211_12003_12033(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 12067, 12085);

                    f_1211_12067_12084(_txRegKey);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 11996, 12100);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 11952, 12111);

                System.Management.Automation.PSTransactionContext
                f_1211_12003_12033(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 12003, 12033);
                    return return_v;
                }


                int
                f_1211_12067_12084(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 12067, 12084);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 11952, 12111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 11952, 12111);
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 12166, 12337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 12202, 12322);
                    using (f_1211_12209_12239(_provider))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 12281, 12303);

                        return f_1211_12288_12302(_txRegKey);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 12202, 12322);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 12166, 12337);

                    System.Management.Automation.PSTransactionContext
                    f_1211_12209_12239(System.Management.Automation.Provider.CmdletProvider
                    this_param)
                    {
                        var return_v = this_param.CurrentPSTransaction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 12209, 12239);
                        return return_v;
                    }


                    string
                    f_1211_12288_12302(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 12288, 12302);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 12123, 12348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 12123, 12348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int SubKeyCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 12407, 12585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 12443, 12570);
                    using (f_1211_12450_12480(_provider))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 12522, 12551);

                        return f_1211_12529_12550(_txRegKey);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 12443, 12570);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 12407, 12585);

                    System.Management.Automation.PSTransactionContext
                    f_1211_12450_12480(System.Management.Automation.Provider.CmdletProvider
                    this_param)
                    {
                        var return_v = this_param.CurrentPSTransaction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 12450, 12480);
                        return return_v;
                    }


                    int
                    f_1211_12529_12550(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                    this_param)
                    {
                        var return_v = this_param.SubKeyCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 12529, 12550);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 12360, 12596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 12360, 12596);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public object RegistryKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 12658, 12683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 12664, 12681);

                    return _txRegKey;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 12658, 12683);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 12608, 12694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 12608, 12694);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void SetAccessControl(ObjectSecurity securityDescriptor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 12706, 12966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 12794, 12955);
                using (f_1211_12801_12831(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 12865, 12940);

                    f_1211_12865_12939(_txRegKey, (TransactedRegistrySecurity)securityDescriptor);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 12794, 12955);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 12706, 12966);

                System.Management.Automation.PSTransactionContext
                f_1211_12801_12831(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 12801, 12831);
                    return return_v;
                }


                int
                f_1211_12865_12939(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, Microsoft.PowerShell.Commands.Internal.TransactedRegistrySecurity
                securityDescriptor)
                {
                    this_param.SetAccessControl((System.Security.AccessControl.ObjectSecurity)securityDescriptor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 12865, 12939);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 12706, 12966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 12706, 12966);
            }
        }

        public ObjectSecurity GetAccessControl(AccessControlSections includeSections)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1211, 12978, 13228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 13080, 13217);
                using (f_1211_13087_13117(_provider))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1211, 13151, 13202);

                    return f_1211_13158_13201(_txRegKey, includeSections);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1211, 13080, 13217);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1211, 12978, 13228);

                System.Management.Automation.PSTransactionContext
                f_1211_13087_13117(System.Management.Automation.Provider.CmdletProvider
                this_param)
                {
                    var return_v = this_param.CurrentPSTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1211, 13087, 13117);
                    return return_v;
                }


                System.Security.AccessControl.ObjectSecurity
                f_1211_13158_13201(Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey
                this_param, System.Security.AccessControl.AccessControlSections
                includeSections)
                {
                    var return_v = this_param.GetAccessControl(includeSections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1211, 13158, 13201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1211, 12978, 13228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 12978, 13228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TransactedRegistryWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1211, 7778, 13257);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1211, 7778, 13257);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1211, 7778, 13257);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1211, 7778, 13257);
    }
}
