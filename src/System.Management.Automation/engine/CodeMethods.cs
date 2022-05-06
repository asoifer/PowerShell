// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Reflection;
using System.Globalization;
using System.Management.Automation;
using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices;
using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell
{
    public static partial class ToStringCodeMethods
    {
        public static string PropertyValueCollection(PSObject instance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1244, 811, 1469);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 899, 958) || true) && (instance == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1244, 899, 958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 938, 958);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1244, 899, 958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 974, 1032);

                var
                values = (PropertyValueCollection)f_1244_1012_1031(instance)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 1046, 1103) || true) && (values == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1244, 1046, 1103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 1083, 1103);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1244, 1046, 1103);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 1119, 1362) || true) && (f_1244_1123_1135(values) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1244, 1119, 1362);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 1174, 1276) || true) && (f_1244_1178_1187(values, 0) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1244, 1174, 1276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 1237, 1257);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1244, 1174, 1276);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 1296, 1347);

                    return (f_1244_1304_1345(f_1244_1304_1334(f_1244_1324_1333(values, 0))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1244, 1119, 1362);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 1378, 1458);

                return f_1244_1385_1457(null, values, null, null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1244, 811, 1469);

                object
                f_1244_1012_1031(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1244, 1012, 1031);
                    return return_v;
                }


                int
                f_1244_1123_1135(System.DirectoryServices.PropertyValueCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1244, 1123, 1135);
                    return return_v;
                }


                object
                f_1244_1178_1187(System.DirectoryServices.PropertyValueCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1244, 1178, 1187);
                    return return_v;
                }


                object
                f_1244_1324_1333(System.DirectoryServices.PropertyValueCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1244, 1324, 1333);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1244_1304_1334(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 1304, 1334);
                    return return_v;
                }


                string
                f_1244_1304_1345(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 1304, 1345);
                    return return_v;
                }


                string
                f_1244_1385_1457(System.Management.Automation.ExecutionContext
                context, System.DirectoryServices.PropertyValueCollection
                enumerable, string
                separator, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = PSObject.ToStringEnumerable(context, (System.Collections.IEnumerable)enumerable, separator, format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 1385, 1457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1244, 811, 1469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1244, 811, 1469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ToStringCodeMethods()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1244, 533, 1476);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1244, 533, 1476);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1244, 533, 1476);
        }

    }
    public static class AdapterCodeMethods
    {
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "integer")]
        public static Int64 ConvertLargeIntegerToInt64(PSObject deInstance, PSObject largeIntegerInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1244, 2242, 3860);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 2482, 2628) || true) && (largeIntegerInstance == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1244, 2482, 2628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 2548, 2613);

                    throw f_1244_2554_2612("largeIntegerInstance");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1244, 2482, 2628);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 2644, 2708);

                object
                largeIntObject = (object)f_1244_2676_2707(largeIntegerInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 2722, 2767);

                Type
                largeIntType = f_1244_2742_2766(largeIntObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 2893, 3142);

                int
                highPart = (int)f_1244_2913_3141(largeIntType, "HighPart", BindingFlags.GetProperty | BindingFlags.Public, null, largeIntObject, null, f_1244_3112_3140())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 3156, 3403);

                int
                lowPart = (int)f_1244_3175_3402(largeIntType, "LowPart", BindingFlags.GetProperty | BindingFlags.Public, null, largeIntObject, null, f_1244_3373_3401())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 3647, 3673);

                byte[]
                data = new byte[8]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 3687, 3734);

                f_1244_3687_3733(f_1244_3687_3717(lowPart), data, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 3748, 3796);

                f_1244_3748_3795(f_1244_3748_3779(highPart), data, 4);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 3812, 3849);

                return f_1244_3819_3848(data, 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1244, 2242, 3860);

                System.Management.Automation.PSArgumentException
                f_1244_2554_2612(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 2554, 2612);
                    return return_v;
                }


                object
                f_1244_2676_2707(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1244, 2676, 2707);
                    return return_v;
                }


                System.Type
                f_1244_2742_2766(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 2742, 2766);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1244_3112_3140()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1244, 3112, 3140);
                    return return_v;
                }


                object?
                f_1244_2913_3141(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                invokeAttr, System.Reflection.Binder?
                binder, object
                target, object?[]?
                args, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.InvokeMember(name, invokeAttr, binder, target, args, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 2913, 3141);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1244_3373_3401()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1244, 3373, 3401);
                    return return_v;
                }


                object?
                f_1244_3175_3402(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                invokeAttr, System.Reflection.Binder?
                binder, object
                target, object?[]?
                args, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.InvokeMember(name, invokeAttr, binder, target, args, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 3175, 3402);
                    return return_v;
                }


                byte[]
                f_1244_3687_3717(int
                value)
                {
                    var return_v = BitConverter.GetBytes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 3687, 3717);
                    return return_v;
                }


                int
                f_1244_3687_3733(byte[]
                this_param, byte[]
                array, int
                index)
                {
                    this_param.CopyTo((System.Array)array, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 3687, 3733);
                    return 0;
                }


                byte[]
                f_1244_3748_3779(int
                value)
                {
                    var return_v = BitConverter.GetBytes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 3748, 3779);
                    return return_v;
                }


                int
                f_1244_3748_3795(byte[]
                this_param, byte[]
                array, int
                index)
                {
                    this_param.CopyTo((System.Array)array, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 3748, 3795);
                    return 0;
                }


                long
                f_1244_3819_3848(byte[]
                value, int
                startIndex)
                {
                    var return_v = BitConverter.ToInt64(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 3819, 3848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1244, 2242, 3860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1244, 2242, 3860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "dn", Justification = "DN represents valid prefix w.r.t Active Directory.")]
        public static string ConvertDNWithBinaryToString(PSObject deInstance, PSObject dnWithBinaryInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1244, 4242, 5277);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 4548, 4694) || true) && (dnWithBinaryInstance == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1244, 4548, 4694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 4614, 4679);

                    throw f_1244_4620_4678("dnWithBinaryInstance");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1244, 4548, 4694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 4710, 4778);

                object
                dnWithBinaryObject = (object)f_1244_4746_4777(dnWithBinaryInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 4792, 4845);

                Type
                dnWithBinaryType = f_1244_4816_4844(dnWithBinaryObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 4971, 5234);

                string
                dnString = (string)f_1244_4997_5233(dnWithBinaryType, "DNString", BindingFlags.GetProperty | BindingFlags.Public, null, dnWithBinaryObject, null, f_1244_5204_5232())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1244, 5250, 5266);

                return dnString;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1244, 4242, 5277);

                System.Management.Automation.PSArgumentException
                f_1244_4620_4678(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 4620, 4678);
                    return return_v;
                }


                object
                f_1244_4746_4777(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1244, 4746, 4777);
                    return return_v;
                }


                System.Type
                f_1244_4816_4844(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 4816, 4844);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1244_5204_5232()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1244, 5204, 5232);
                    return return_v;
                }


                object?
                f_1244_4997_5233(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                invokeAttr, System.Reflection.Binder?
                binder, object
                target, object?[]?
                args, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.InvokeMember(name, invokeAttr, binder, target, args, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1244, 4997, 5233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1244, 4242, 5277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1244, 4242, 5277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AdapterCodeMethods()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1244, 1767, 5306);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1244, 1767, 5306);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1244, 1767, 5306);
        }

    }
}
