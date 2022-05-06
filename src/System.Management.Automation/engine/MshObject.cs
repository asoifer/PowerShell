// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

using Microsoft.Management.Infrastructure;
using System.DirectoryServices;
using System.Management;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings
#pragma warning disable 56500

namespace System.Management.Automation
{
    [TypeDescriptionProvider(typeof(PSObjectTypeDescriptionProvider))]
    [Serializable]
    public class PSObject : IFormattable, IComparable, ISerializable, IDynamicMetaObjectProvider
    {
        internal TypeTable GetTypeTable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 1752, 2087);
                System.Management.Automation.Runspaces.TypeTable typeTable = default(System.Management.Automation.Runspaces.TypeTable);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 1810, 1950) || true) && (_typeTable != null && (DynAbs.Tracing.TraceSender.Expression_True(1293, 1814, 1884) && f_1293_1836_1884(_typeTable, out typeTable)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 1810, 1950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 1918, 1935);

                    return typeTable;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 1810, 1950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 1966, 2036);

                ExecutionContext
                context = f_1293_1993_2035()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2050, 2076);

                return f_1293_2057_2075_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(context, 1293, 2057, 2075)?.TypeTable);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 1752, 2087);

                bool
                f_1293_1836_1884(System.WeakReference<System.Management.Automation.Runspaces.TypeTable>
                this_param, out System.Management.Automation.Runspaces.TypeTable
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 1836, 1884);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1293_1993_2035()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 1993, 2035);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1293_2057_2075_M(System.Management.Automation.Runspaces.TypeTable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 2057, 2075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 1752, 2087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 1752, 2087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T TypeTableGetMemberDelegate<T>(PSObject msjObj, string name) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 2099, 2347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2224, 2264);

                TypeTable
                table = f_1293_2242_2263(msjObj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2278, 2336);

                return f_1293_2285_2335(msjObj, table, name);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 2099, 2347);

                System.Management.Automation.Runspaces.TypeTable
                f_1293_2242_2263(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 2242, 2263);
                    return return_v;
                }


                T
                f_1293_2285_2335(System.Management.Automation.PSObject
                msjObj, System.Management.Automation.Runspaces.TypeTable
                typeTableToUse, string
                name) 

                {
                    var return_v = TypeTableGetMemberDelegate<T>(msjObj, typeTableToUse, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 2285, 2335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 2099, 2347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 2099, 2347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T TypeTableGetMemberDelegate<T>(PSObject msjObj, TypeTable typeTableToUse, string name) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 2359, 3398);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2509, 2596) || true) && (typeTableToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 2509, 2596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2569, 2581);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 2509, 2596);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2612, 2736);

                PSMemberInfoInternalCollection<PSMemberInfo>
                allMembers = f_1293_2670_2735(typeTableToUse, f_1293_2710_2734(msjObj))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2750, 2789);

                PSMemberInfo
                member = f_1293_2772_2788(allMembers, name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2803, 2980) || true) && (member == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 2803, 2980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2855, 2935);

                    f_1293_2855_2934(f_1293_2855_2880(), "\"{0}\" NOT present in type table.", name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2953, 2965);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 2803, 2980);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 2996, 3181) || true) && (member is T memberAsT)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 2996, 3181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 3055, 3131);

                    f_1293_3055_3130(f_1293_3055_3080(), "\"{0}\" present in type table.", name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 3149, 3166);

                    return memberAsT;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 2996, 3181);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 3197, 3361);

                f_1293_3197_3360(f_1293_3197_3222(), "\"{0}\" from types table ignored because it has type {1} instead of {2}.", name, f_1293_3332_3348(member), typeof(T));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 3375, 3387);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 2359, 3398);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_2710_2734(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 2710, 2734);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1293_2670_2735(System.Management.Automation.Runspaces.TypeTable
                this_param, System.Management.Automation.Runspaces.ConsolidatedString
                types) 

                {
                    var return_v = this_param.GetMembers<System.Management.Automation.PSMemberInfo>(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 2670, 2735);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1293_2772_2788(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0) 

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 2772, 2788);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1293_2855_2880() 

                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 2855, 2880);
                    return return_v;
                }


                int
                f_1293_2855_2934(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1) 

                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 2855, 2934);
                    return 0;
                }


                System.Management.Automation.PSTraceSource
                f_1293_3055_3080() 

                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 3055, 3080);
                    return return_v;
                }


                int
                f_1293_3055_3130(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1) 

                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 3055, 3130);
                    return 0;
                }


                System.Management.Automation.PSTraceSource
                f_1293_3197_3222() 

                {
                    var return_v =
                                PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 3197, 3222);
                    return return_v;
                }


                System.Type
                f_1293_3332_3348(System.Management.Automation.PSMemberInfo
                this_param) 

                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 3332, 3348);
                    return return_v;
                }


                int
                f_1293_3197_3360(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, System.Type
                arg2, System.Type
                arg3) 

                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2, (object)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 3197, 3360);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 2359, 3398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 2359, 3398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSMemberInfoInternalCollection<T> TypeTableGetMembersDelegate<T>(PSObject msjObj) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 3410, 3673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 3555, 3595);

                TypeTable
                table = f_1293_3573_3594(msjObj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 3609, 3662);

                return f_1293_3616_3661(msjObj, table);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 3410, 3673);

                System.Management.Automation.Runspaces.TypeTable
                f_1293_3573_3594(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 3573, 3594);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1293_3616_3661(System.Management.Automation.PSObject
                msjObj, System.Management.Automation.Runspaces.TypeTable
                typeTableToUse) 

                {
                    var return_v = TypeTableGetMembersDelegate<T>(msjObj, typeTableToUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 3616, 3661);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 3410, 3673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 3410, 3673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSMemberInfoInternalCollection<T> TypeTableGetMembersDelegate<T>(PSObject msjObj, TypeTable typeTableToUse) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 3685, 4226);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 3856, 3978) || true) && (typeTableToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 3856, 3978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 3916, 3963);

                    return f_1293_3923_3962();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 3856, 3978);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 3994, 4093);

                PSMemberInfoInternalCollection<T>
                members = f_1293_4038_4092(typeTableToUse, f_1293_4067_4091(msjObj))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 4107, 4186);

                f_1293_4107_4185(f_1293_4107_4132(), "Type table members: {0}.", f_1293_4171_4184(members));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 4200, 4215);

                return members;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 3685, 4226);

                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1293_3923_3962() 

                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 3923, 3962);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_4067_4091(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 4067, 4091);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1293_4038_4092(System.Management.Automation.Runspaces.TypeTable
                this_param, System.Management.Automation.Runspaces.ConsolidatedString
                types) 

                {
                    var return_v = this_param.GetMembers<T>(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 4038, 4092);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1293_4107_4132() 

                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 4107, 4132);
                    return return_v;
                }


                int
                f_1293_4171_4184(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param) 

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 4171, 4184);
                    return return_v;
                }


                int
                f_1293_4107_4185(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1) 

                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 4107, 4185);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 3685, 4226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 3685, 4226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T TypeTableGetFirstMemberOrDefaultDelegate<T>(PSObject msjObj, MemberNamePredicate predicate) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 4238, 4537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 4395, 4435);

                TypeTable
                table = f_1293_4413_4434(msjObj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 4449, 4526);

                return f_1293_4456_4525(msjObj, table, predicate);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 4238, 4537);

                System.Management.Automation.Runspaces.TypeTable
                f_1293_4413_4434(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 4413, 4434);
                    return return_v;
                }


                T
                f_1293_4456_4525(System.Management.Automation.PSObject
                msjObj, System.Management.Automation.Runspaces.TypeTable
                typeTableToUse, System.Management.Automation.MemberNamePredicate
                predicate) 

                {
                    var return_v = TypeTableGetFirstOrDefaultMemberDelegate<T>(msjObj, typeTableToUse, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 4456, 4525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 4238, 4537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 4238, 4537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T TypeTableGetFirstOrDefaultMemberDelegate<T>(PSObject msjObj, TypeTable typeTableToUse, MemberNamePredicate predicate) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 4549, 4830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 4732, 4819);

                return f_1293_4739_4818_I(((TypeTable)DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(typeTableToUse, 1293, 4739, 4818))?.GetFirstMemberOrDefault<T>(f_1293_4782_4806(msjObj), predicate));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 4549, 4830);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_4782_4806(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 4782, 4806);
                    return return_v;
                }


                T
                f_1293_4739_4818_I(T
                i) 

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 4739, 4818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 4549, 4830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 4549, 4830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T AdapterGetMemberDelegate<T>(PSObject msjObj, string name) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 4842, 5667);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 4964, 5401) || true) && (f_1293_4968_4989(msjObj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 4964, 5401);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 5023, 5129) || true) && (f_1293_5027_5048(msjObj) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 5023, 5129);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 5098, 5110);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 5023, 5129);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 5149, 5200);

                    T
                    adaptedMember = f_1293_5167_5194(f_1293_5167_5188(msjObj), name) as T
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 5218, 5347);

                    f_1293_5218_5346(f_1293_5218_5243(), "Serialized adapted member: {0}.", (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 5289, 5310) || ((adaptedMember == null && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 5313, 5324)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 5327, 5345))) ? "not found" : f_1293_5327_5345(adaptedMember));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 5365, 5386);

                    return adaptedMember;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 4964, 5401);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 5417, 5504);

                T
                retValue = f_1293_5430_5503(f_1293_5430_5452(msjObj), f_1293_5470_5496(msjObj), name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 5518, 5626);

                f_1293_5518_5625(f_1293_5518_5543(), "Adapted member: {0}.", (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 5578, 5594) || ((retValue == null && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 5597, 5608)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 5611, 5624))) ? "not found" : f_1293_5611_5624(retValue));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 5640, 5656);

                return retValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 4842, 5667);

                bool
                f_1293_4968_4989(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.IsDeserialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 4968, 4989);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_5027_5048(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5027, 5048);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_5167_5188(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5167, 5188);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1293_5167_5194(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0) 

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5167, 5194);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1293_5218_5243() 

                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5218, 5243);
                    return return_v;
                }


                string
                f_1293_5327_5345(T
                this_param) 

                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5327, 5345);
                    return return_v;
                }


                int
                f_1293_5218_5346(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1) 

                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 5218, 5346);
                    return 0;
                }


                System.Management.Automation.Adapter
                f_1293_5430_5452(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5430, 5452);
                    return return_v;
                }


                object
                f_1293_5470_5496(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5470, 5496);
                    return return_v;
                }


                T
                f_1293_5430_5503(System.Management.Automation.Adapter
                this_param, object
                obj, string
                memberName) 

                {
                    var return_v = this_param.BaseGetMember<T>(obj, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 5430, 5503);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1293_5518_5543() 

                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5518, 5543);
                    return return_v;
                }


                string
                f_1293_5611_5624(T
                this_param) 

                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5611, 5624);
                    return return_v;
                }


                int
                f_1293_5518_5625(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1) 

                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 5518, 5625);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 4842, 5667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 4842, 5667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T AdapterGetFirstMemberOrDefaultDelegate<T>(PSObject msjObj, MemberNamePredicate predicate) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 5679, 6495);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 5833, 6331) || true) && (f_1293_5837_5858(msjObj) && (DynAbs.Tracing.TraceSender.Expression_True(1293, 5837, 5912) && f_1293_5862_5912(typeof(T), typeof(PSPropertyInfo))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 5833, 6331);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 5946, 6052) || true) && (f_1293_5950_5971(msjObj) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 5946, 6052);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 6021, 6033);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 5946, 6052);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 6072, 6316);
                        foreach (var adaptedMember in f_1293_6102_6123_I(f_1293_6102_6123(msjObj)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 6072, 6316);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 6165, 6297) || true) && (f_1293_6169_6198(predicate, f_1293_6179_6197(adaptedMember)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 6165, 6297);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 6248, 6274);

                                return adaptedMember as T;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 6165, 6297);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 6072, 6316);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 245);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 245);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 5833, 6331);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 6347, 6454);

                T
                retValue = f_1293_6360_6453(f_1293_6360_6382(msjObj), msjObj._immediateBaseObject, predicate)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 6468, 6484);

                return retValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 5679, 6495);

                bool
                f_1293_5837_5858(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.IsDeserialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5837, 5858);
                    return return_v;
                }


                bool
                f_1293_5862_5912(System.Type
                this_param, System.Type
                c) 

                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 5862, 5912);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_5950_5971(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 5950, 5971);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_6102_6123(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 6102, 6123);
                    return return_v;
                }


                string
                f_1293_6179_6197(System.Management.Automation.PSPropertyInfo
                this_param) 

                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 6179, 6197);
                    return return_v;
                }


                bool
                f_1293_6169_6198(System.Management.Automation.MemberNamePredicate
                this_param, string
                memberName) 

                {
                    var return_v = this_param.Invoke(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 6169, 6198);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_6102_6123_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 6102, 6123);
                    return return_v;
                }


                System.Management.Automation.Adapter
                f_1293_6360_6382(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 6360, 6382);
                    return return_v;
                }


                T
                f_1293_6360_6453(System.Management.Automation.Adapter
                this_param, object
                obj, System.Management.Automation.MemberNamePredicate
                predicate) 

                {
                    var return_v = this_param.BaseGetFirstMemberOrDefault<T>(obj, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 6360, 6453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 5679, 6495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 5679, 6495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSMemberInfoInternalCollection<U> TransformMemberInfoCollection<T, U>(PSMemberInfoCollection<T> source) where T : PSMemberInfo where U : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 6507, 7262);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 6697, 6919) || true) && (typeof(T) == typeof(U))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 6697, 6919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 6853, 6904);

                    return source as PSMemberInfoInternalCollection<U>;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 6697, 6919);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 6935, 7023);

                PSMemberInfoInternalCollection<U>
                returnValue = f_1293_6983_7022()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7037, 7216);
                    foreach (T member in f_1293_7058_7064_I(source))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 7037, 7216);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7098, 7201) || true) && (member is U tAsU)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 7098, 7201);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7160, 7182);

                            f_1293_7160_7181(returnValue, tAsU);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 7098, 7201);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 7037, 7216);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7232, 7251);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 6507, 7262);

                System.Management.Automation.PSMemberInfoInternalCollection<U>
                f_1293_6983_7022() 

                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<U>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 6983, 7022);
                    return return_v;
                }


                int
                f_1293_7160_7181(System.Management.Automation.PSMemberInfoInternalCollection<U>
                this_param, U
                member) 

                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 7160, 7181);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<T>
                f_1293_7058_7064_I(System.Management.Automation.PSMemberInfoCollection<T>
                i) 
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 7058, 7064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 6507, 7262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 6507, 7262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSMemberInfoInternalCollection<T> AdapterGetMembersDelegate<T>(PSObject msjObj) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 7274, 8119);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7416, 7849) || true) && (f_1293_7420_7441(msjObj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 7416, 7849);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7475, 7616) || true) && (f_1293_7479_7500(msjObj) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 7475, 7616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7550, 7597);

                        return f_1293_7557_7596();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 7475, 7616);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7636, 7737);

                    f_1293_7636_7736(f_1293_7636_7661(), "Serialized adapted members: {0}.", f_1293_7708_7735(f_1293_7708_7729(msjObj)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7755, 7834);

                    return f_1293_7762_7833(f_1293_7811_7832(msjObj));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 7416, 7849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7865, 7980);

                PSMemberInfoInternalCollection<T>
                retValue = f_1293_7910_7979(f_1293_7910_7932(msjObj), msjObj._immediateBaseObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 7994, 8078);

                f_1293_7994_8077(f_1293_7994_8019(), "Adapted members: {0}.", f_1293_8055_8076(retValue));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 8092, 8108);

                return retValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 7274, 8119);

                bool
                f_1293_7420_7441(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.IsDeserialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 7420, 7441);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_7479_7500(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 7479, 7500);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1293_7557_7596() 

                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 7557, 7596);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1293_7636_7661() 

                {
                    var return_v =
                                    PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 7636, 7661);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_7708_7729(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 7708, 7729);
                    return return_v;
                }


                int
                f_1293_7708_7735(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                this_param) 

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 7708, 7735);
                    return return_v;
                }


                int
                f_1293_7636_7736(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1) 

                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 7636, 7736);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_7811_7832(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 7811, 7832);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1293_7762_7833(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                source) 

                {
                    var return_v = TransformMemberInfoCollection<PSPropertyInfo, T>((System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 7762, 7833);
                    return return_v;
                }


                System.Management.Automation.Adapter
                f_1293_7910_7932(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 7910, 7932);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1293_7910_7979(System.Management.Automation.Adapter
                this_param, object
                obj) 

                {
                    var return_v = this_param.BaseGetMembers<T>(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 7910, 7979);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1293_7994_8019() 

                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 7994, 8019);
                    return return_v;
                }


                int
                f_1293_8055_8076(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param) 

                {
                    var return_v = this_param.VisibleCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 8055, 8076);
                    return return_v;
                }


                int
                f_1293_7994_8077(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1) 

                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 7994, 8077);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 7274, 8119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 7274, 8119);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSMemberInfoInternalCollection<T> DotNetGetMembersDelegate<T>(PSObject msjObj) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 8131, 8773);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 8346, 8699) || true) && (f_1293_8350_8382(msjObj) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 8346, 8699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 8424, 8549);

                    PSMemberInfoInternalCollection<T>
                    retValue = f_1293_8469_8548(f_1293_8469_8501(msjObj), msjObj._immediateBaseObject)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 8567, 8650);

                    f_1293_8567_8649(f_1293_8567_8592(), "DotNet members: {0}.", f_1293_8627_8648(retValue));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 8668, 8684);

                    return retValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 8346, 8699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 8715, 8762);

                return f_1293_8722_8761();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 8131, 8773);

                System.Management.Automation.Adapter
                f_1293_8350_8382(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalBaseDotNetAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 8350, 8382);
                    return return_v;
                }


                System.Management.Automation.Adapter
                f_1293_8469_8501(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalBaseDotNetAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 8469, 8501);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1293_8469_8548(System.Management.Automation.Adapter
                this_param, object
                obj) 

                {
                    var return_v = this_param.BaseGetMembers<T>(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 8469, 8548);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1293_8567_8592() 

                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 8567, 8592);
                    return return_v;
                }


                int
                f_1293_8627_8648(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param) 

                {
                    var return_v = this_param.VisibleCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 8627, 8648);
                    return return_v;
                }


                int
                f_1293_8567_8649(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1) 

                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 8567, 8649);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1293_8722_8761() 

                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 8722, 8761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 8131, 8773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 8131, 8773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T DotNetGetMemberDelegate<T>(PSObject msjObj, string name) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 8785, 9368);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 8979, 9329) || true) && (f_1293_8983_9015(msjObj) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 8979, 9329);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 9057, 9155);

                    T
                    retValue = f_1293_9070_9154(f_1293_9070_9102(msjObj), msjObj._immediateBaseObject, name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 9173, 9280);

                    f_1293_9173_9279(f_1293_9173_9198(), "DotNet member: {0}.", (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 9232, 9248) || ((retValue == null && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 9251, 9262)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 9265, 9278))) ? "not found" : f_1293_9265_9278(retValue));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 9298, 9314);

                    return retValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 8979, 9329);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 9345, 9357);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 8785, 9368);

                System.Management.Automation.Adapter
                f_1293_8983_9015(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalBaseDotNetAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 8983, 9015);
                    return return_v;
                }


                System.Management.Automation.Adapter
                f_1293_9070_9102(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalBaseDotNetAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 9070, 9102);
                    return return_v;
                }


                T
                f_1293_9070_9154(System.Management.Automation.Adapter
                this_param, object
                obj, string
                memberName) 

                {
                    var return_v = this_param.BaseGetMember<T>(obj, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 9070, 9154);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1293_9173_9198() 

                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 9173, 9198);
                    return return_v;
                }


                string
                f_1293_9265_9278(T
                this_param) 

                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 9265, 9278);
                    return return_v;
                }


                int
                f_1293_9173_9279(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1) 

                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 9173, 9279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 8785, 9368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 8785, 9368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T DotNetGetFirstMemberOrDefaultDelegate<T>(PSObject msjObj, MemberNamePredicate predicate) where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 9380, 9729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 9606, 9718);

                return f_1293_9613_9717_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1293_9613_9645(msjObj), 1293, 9613, 9717)?.BaseGetFirstMemberOrDefault<T>(msjObj._immediateBaseObject, predicate));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 9380, 9729);

                System.Management.Automation.Adapter
                f_1293_9613_9645(System.Management.Automation.PSObject
                this_param) 

                {
                    var return_v = this_param.InternalBaseDotNetAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 9613, 9645);
                    return return_v;
                }


                T
                f_1293_9613_9717_I(T
                i) 

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 9613, 9717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 9380, 9729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 9380, 9729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Collection<CollectionEntry<PSMemberInfo>> GetMemberCollection(PSMemberViewTypes viewType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 10087, 10271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 10217, 10260);

                return f_1293_10224_10259(viewType, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 10087, 10271);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                f_1293_10224_10259(System.Management.Automation.PSMemberViewTypes
                viewType, System.Management.Automation.Runspaces.TypeTable
                backupTypeTable)
                {
                    var return_v = GetMemberCollection(viewType, backupTypeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 10224, 10259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 10087, 10271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 10087, 10271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Collection<CollectionEntry<PSMemberInfo>> GetMemberCollection(
                    PSMemberViewTypes viewType,
                    TypeTable backupTypeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 10801, 13434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 10985, 11089);

                Collection<CollectionEntry<PSMemberInfo>>
                returnValue = f_1293_11041_11088()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 11103, 12219) || true) && ((viewType & PSMemberViewTypes.Extended) == PSMemberViewTypes.Extended)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 11103, 12219);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 11210, 12204) || true) && (backupTypeTable == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 11210, 12204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 11279, 11633);

                        f_1293_11279_11632(returnValue, f_1293_11295_11631(PSObject.TypeTableGetMembersDelegate<PSMemberInfo>, PSObject.TypeTableGetMemberDelegate<PSMemberInfo>, PSObject.TypeTableGetFirstMemberOrDefaultDelegate<PSMemberInfo>, true, true, "type table members"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 11210, 12204);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 11210, 12204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 11715, 12185);

                        f_1293_11715_12184(returnValue, f_1293_11731_12183(msjObj => TypeTableGetMembersDelegate<PSMemberInfo>(msjObj, backupTypeTable), (msjObj, name) => TypeTableGetMemberDelegate<PSMemberInfo>(msjObj, backupTypeTable, name), (msjObj, predicate) => TypeTableGetFirstOrDefaultMemberDelegate<PSMemberInfo>(msjObj, backupTypeTable, predicate), true, true, "type table members"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 11210, 12204);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 11103, 12219);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 12235, 12810) || true) && ((viewType & PSMemberViewTypes.Adapted) == PSMemberViewTypes.Adapted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 12235, 12810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 12340, 12795);

                    f_1293_12340_12794(returnValue, f_1293_12356_12793(PSObject.AdapterGetMembersDelegate<PSMemberInfo>, PSObject.AdapterGetMemberDelegate<PSMemberInfo>, PSObject.AdapterGetFirstMemberOrDefaultDelegate<PSMemberInfo>, shouldReplicateWhenReturning: false, shouldCloneWhenReturning: false, collectionNameForTracing: "adapted members"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 12235, 12810);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 12826, 13388) || true) && ((viewType & PSMemberViewTypes.Base) == PSMemberViewTypes.Base)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 12826, 13388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 12925, 13373);

                    f_1293_12925_13372(returnValue, f_1293_12941_13371(PSObject.DotNetGetMembersDelegate<PSMemberInfo>, PSObject.DotNetGetMemberDelegate<PSMemberInfo>, PSObject.DotNetGetFirstMemberOrDefaultDelegate<PSMemberInfo>, shouldReplicateWhenReturning: false, shouldCloneWhenReturning: false, collectionNameForTracing: "clr members"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 12826, 13388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 13404, 13423);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 10801, 13434);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                f_1293_11041_11088()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 11041, 11088);
                    return return_v;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>
                f_1293_11295_11631(System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning, shouldCloneWhenReturning, collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 11295, 11631);
                    return return_v;
                }


                int
                f_1293_11279_11632(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 11279, 11632);
                    return 0;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>
                f_1293_11731_12183(System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning, shouldCloneWhenReturning, collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 11731, 12183);
                    return return_v;
                }


                int
                f_1293_11715_12184(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 11715, 12184);
                    return 0;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>
                f_1293_12356_12793(System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning: shouldReplicateWhenReturning, shouldCloneWhenReturning: shouldCloneWhenReturning, collectionNameForTracing: collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 12356, 12793);
                    return return_v;
                }


                int
                f_1293_12340_12794(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 12340, 12794);
                    return 0;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>
                f_1293_12941_13371(System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning: shouldReplicateWhenReturning, shouldCloneWhenReturning: shouldCloneWhenReturning, collectionNameForTracing: collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 12941, 13371);
                    return return_v;
                }


                int
                f_1293_12925_13372(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 12925, 13372);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 10801, 13434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 10801, 13434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Collection<CollectionEntry<PSMethodInfo>> GetMethodCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 13446, 15092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 13549, 15048);

                Collection<CollectionEntry<PSMethodInfo>>
                returnValue = new Collection<CollectionEntry<PSMethodInfo>>
                            {
DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1293_13683_14127(PSObject.TypeTableGetMembersDelegate<PSMethodInfo>, PSObject.TypeTableGetMemberDelegate<PSMethodInfo>, PSObject.TypeTableGetFirstMemberOrDefaultDelegate<PSMethodInfo>, shouldReplicateWhenReturning: true, shouldCloneWhenReturning: true, collectionNameForTracing: "type table members"),1293,13605,15047),f_1293_14146_14583(PSObject.AdapterGetMembersDelegate<PSMethodInfo>, PSObject.AdapterGetMemberDelegate<PSMethodInfo>, PSObject.AdapterGetFirstMemberOrDefaultDelegate<PSMethodInfo>, shouldReplicateWhenReturning: false, shouldCloneWhenReturning: false, collectionNameForTracing: "adapted members"),f_1293_14602_15032(PSObject.DotNetGetMembersDelegate<PSMethodInfo>, PSObject.DotNetGetMemberDelegate<PSMethodInfo>, PSObject.DotNetGetFirstMemberOrDefaultDelegate<PSMethodInfo>, shouldReplicateWhenReturning: false, shouldCloneWhenReturning: false, collectionNameForTracing: "clr members")            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 15062, 15081);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 13446, 15092);

                System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>
                f_1293_13683_14127(System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning: shouldReplicateWhenReturning, shouldCloneWhenReturning: shouldCloneWhenReturning, collectionNameForTracing: collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 13683, 14127);
                    return return_v;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>
                f_1293_14146_14583(System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning: shouldReplicateWhenReturning, shouldCloneWhenReturning: shouldCloneWhenReturning, collectionNameForTracing: collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 14146, 14583);
                    return return_v;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>
                f_1293_14602_15032(System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning: shouldReplicateWhenReturning, shouldCloneWhenReturning: shouldCloneWhenReturning, collectionNameForTracing: collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 14602, 15032);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 13446, 15092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 13446, 15092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Collection<CollectionEntry<PSPropertyInfo>> GetPropertyCollection(
                    PSMemberViewTypes viewType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 15453, 15657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 15601, 15646);

                return f_1293_15608_15645(viewType, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 15453, 15657);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
                f_1293_15608_15645(System.Management.Automation.PSMemberViewTypes
                viewType, System.Management.Automation.Runspaces.TypeTable
                backupTypeTable)
                {
                    var return_v = GetPropertyCollection(viewType, backupTypeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 15608, 15645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 15453, 15657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 15453, 15657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Collection<CollectionEntry<PSPropertyInfo>> GetPropertyCollection(
                    PSMemberViewTypes viewType,
                    TypeTable backupTypeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 16190, 18565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 16378, 16486);

                Collection<CollectionEntry<PSPropertyInfo>>
                returnValue = f_1293_16436_16485()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 16500, 17582) || true) && ((viewType & PSMemberViewTypes.Extended) == PSMemberViewTypes.Extended)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 16500, 17582);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 16607, 17567) || true) && (backupTypeTable == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 16607, 17567);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 16676, 17038);

                        f_1293_16676_17037(returnValue, f_1293_16692_17036(PSObject.TypeTableGetMembersDelegate<PSPropertyInfo>, PSObject.TypeTableGetMemberDelegate<PSPropertyInfo>, PSObject.TypeTableGetFirstMemberOrDefaultDelegate<PSPropertyInfo>, true, true, "type table members"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 16607, 17567);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 16607, 17567);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 17120, 17548);

                        f_1293_17120_17547(returnValue, f_1293_17136_17546(msjObj => TypeTableGetMembersDelegate<PSPropertyInfo>(msjObj, backupTypeTable), (msjObj, name) => TypeTableGetMemberDelegate<PSPropertyInfo>(msjObj, backupTypeTable, name), PSObject.TypeTableGetFirstMemberOrDefaultDelegate<PSPropertyInfo>, true, true, "type table members"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 16607, 17567);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 16500, 17582);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 17598, 18057) || true) && ((viewType & PSMemberViewTypes.Adapted) == PSMemberViewTypes.Adapted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 17598, 18057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 17703, 18042);

                    f_1293_17703_18041(returnValue, f_1293_17719_18040(PSObject.AdapterGetMembersDelegate<PSPropertyInfo>, PSObject.AdapterGetMemberDelegate<PSPropertyInfo>, PSObject.AdapterGetFirstMemberOrDefaultDelegate<PSPropertyInfo>, false, false, "adapted members"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 17598, 18057);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 18073, 18519) || true) && ((viewType & PSMemberViewTypes.Base) == PSMemberViewTypes.Base)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 18073, 18519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 18172, 18504);

                    f_1293_18172_18503(returnValue, f_1293_18188_18502(PSObject.DotNetGetMembersDelegate<PSPropertyInfo>, PSObject.DotNetGetMemberDelegate<PSPropertyInfo>, PSObject.DotNetGetFirstMemberOrDefaultDelegate<PSPropertyInfo>, false, false, "clr members"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 18073, 18519);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 18535, 18554);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 16190, 18565);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
                f_1293_16436_16485()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 16436, 16485);
                    return return_v;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>
                f_1293_16692_17036(System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning, shouldCloneWhenReturning, collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 16692, 17036);
                    return return_v;
                }


                int
                f_1293_16676_17037(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 16676, 17037);
                    return 0;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>
                f_1293_17136_17546(System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning, shouldCloneWhenReturning, collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 17136, 17546);
                    return return_v;
                }


                int
                f_1293_17120_17547(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 17120, 17547);
                    return 0;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>
                f_1293_17719_18040(System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning, shouldCloneWhenReturning, collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 17719, 18040);
                    return return_v;
                }


                int
                f_1293_17703_18041(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 17703, 18041);
                    return 0;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>
                f_1293_18188_18502(System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning, shouldCloneWhenReturning, collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 18188, 18502);
                    return return_v;
                }


                int
                f_1293_18172_18503(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 18172, 18503);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 16190, 18565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 16190, 18565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CommonInitialization(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 18577, 19012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 18647, 18701);

                f_1293_18647_18700(obj != null, "checked by callers");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 18715, 18828) || true) && (obj is PSCustomObject)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 18715, 18828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 18774, 18813);

                    this.ImmediateBaseObjectIsEmpty = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 18715, 18828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 18844, 18871);

                _immediateBaseObject = obj;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 18885, 18942);

                var
                context = f_1293_18899_18941()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 18956, 19001);

                _typeTable = f_1293_18969_19000_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(context, 1293, 18969, 19000)?.TypeTableWeakReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 18577, 19012);

                int
                f_1293_18647_18700(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 18647, 18700);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1293_18899_18941()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 18899, 18941);
                    return return_v;
                }


                System.WeakReference<System.Management.Automation.Runspaces.TypeTable>
                f_1293_18969_19000_M(System.WeakReference<System.Management.Automation.Runspaces.TypeTable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 18969, 19000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 18577, 19012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 18577, 19012);
            }
        }

        private static readonly ConcurrentDictionary<Type, AdapterSet> s_adapterMapping;

        private static readonly List<Func<object, AdapterSet>> s_adapterSetMappers;

        private static AdapterSet MappedInternalAdapterSet(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 19609, 20471);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 19696, 19762) || true) && (obj is PSMemberSet)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 19696, 19762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 19722, 19760);

                    return PSObject.s_mshMemberSetAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 19696, 19762);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 19778, 19838) || true) && (obj is PSObject)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 19778, 19838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 19801, 19836);

                    return PSObject.s_mshObjectAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 19778, 19838);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 19854, 19919) || true) && (obj is CimInstance)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 19854, 19919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 19880, 19917);

                    return PSObject.s_cimInstanceAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 19854, 19919);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 19944, 20017) || true) && (obj is ManagementClass)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 19944, 20017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 19974, 20015);

                    return PSObject.s_managementClassAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 19944, 20017);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20033, 20112) || true) && (obj is ManagementBaseObject)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 20033, 20112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20068, 20110);

                    return PSObject.s_managementObjectAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 20033, 20112);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20128, 20199) || true) && (obj is DirectoryEntry)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 20128, 20199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20157, 20197);

                    return PSObject.s_directoryEntryAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 20128, 20199);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20221, 20286) || true) && (obj is DataRowView)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 20221, 20286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20247, 20284);

                    return PSObject.s_dataRowViewAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 20221, 20286);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20302, 20359) || true) && (obj is DataRow)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 20302, 20359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20324, 20357);

                    return PSObject.s_dataRowAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 20302, 20359);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20375, 20432) || true) && (obj is XmlNode)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 20375, 20432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20397, 20430);

                    return PSObject.s_xmlNodeAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 20375, 20432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20448, 20460);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 19609, 20471);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 19609, 20471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 19609, 20471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AdapterSet GetMappedAdapter(object obj, TypeTable typeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 20674, 23937);
                System.Management.Automation.PSObject.AdapterSet result = default(System.Management.Automation.PSObject.AdapterSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20775, 20807);

                Type
                objectType = f_1293_20793_20806(obj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20823, 20891);

                PSObject.AdapterSet
                adapter = f_1293_20853_20890_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(typeTable, 1293, 20853, 20890)?.GetTypeAdapter(objectType))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 20907, 21186) || true) && (adapter != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 20907, 21186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 21156, 21171);

                    return adapter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 20907, 21186);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 21202, 21332) || true) && (f_1293_21206_21269(s_adapterMapping, objectType, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 21202, 21332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 21303, 21317);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 21202, 21332);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 21354, 21373);

                lock (s_adapterSetMappers)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 21407, 21650);
                        foreach (var mapper in f_1293_21430_21449_I(s_adapterSetMappers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 21407, 21650);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 21491, 21512);

                            result = f_1293_21500_21511(mapper, obj);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 21534, 21631) || true) && (result != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 21534, 21631);
                                DynAbs.Tracing.TraceSender.TraceBreak(1293, 21602, 21608);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 21534, 21631);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 21407, 21650);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 244);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 244);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 21681, 23705) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 21681, 23705);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 21733, 23690) || true) && (f_1293_21737_21759(objectType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 21733, 23690);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 21963, 23544) || true) && (f_1293_21967_22002(objectType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 21963, 23544);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 22052, 22097);

                            result = PSObject.s_dotNetInstanceAdapterSet;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 21963, 23544);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 21963, 23544);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 22498, 23544) || true) && (f_1293_22502_22550(f_1293_22502_22521(objectType), "System.__ComObject"))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 22498, 23544);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 22872, 22928);

                                ComTypeInfo
                                info = f_1293_22891_22927(obj)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 22954, 23146);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 22961, 22973) || ((info != null
                                && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 23012, 23071)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 23110, 23145))) ? f_1293_23012_23071(f_1293_23027_23047(info), f_1293_23049_23070()) : PSObject.s_dotNetInstanceAdapterSet;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 22498, 23544);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 22498, 23544);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 23244, 23300);

                                ComTypeInfo
                                info = f_1293_23263_23299(obj)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 23326, 23521);

                                result = (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 23335, 23347) || ((info != null
                                && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 23386, 23446)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 23485, 23520))) ? f_1293_23386_23446(f_1293_23401_23439(info), null) : PSObject.s_dotNetInstanceAdapterSet;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 22498, 23544);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 21963, 23544);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 21733, 23690);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 21733, 23690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 23626, 23671);

                        result = PSObject.s_dotNetInstanceAdapterSet;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 21733, 23690);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 21681, 23705);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 23721, 23787);

                var
                existingOrNew = f_1293_23741_23786(s_adapterMapping, objectType, result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 23801, 23896);

                f_1293_23801_23895(existingOrNew == result, "There is a logic error in caching adapter sets.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 23912, 23926);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 20674, 23937);

                System.Type
                f_1293_20793_20806(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 20793, 20806);
                    return return_v;
                }


                System.Management.Automation.PSObject.AdapterSet
                f_1293_20853_20890_I(System.Management.Automation.PSObject.AdapterSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 20853, 20890);
                    return return_v;
                }


                bool
                f_1293_21206_21269(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Management.Automation.PSObject.AdapterSet>
                this_param, System.Type
                key, out System.Management.Automation.PSObject.AdapterSet
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 21206, 21269);
                    return return_v;
                }


                System.Management.Automation.PSObject.AdapterSet
                f_1293_21500_21511(System.Func<object, System.Management.Automation.PSObject.AdapterSet>
                this_param, object
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 21500, 21511);
                    return return_v;
                }


                System.Collections.Generic.List<System.Func<object, System.Management.Automation.PSObject.AdapterSet>>
                f_1293_21430_21449_I(System.Collections.Generic.List<System.Func<object, System.Management.Automation.PSObject.AdapterSet>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 21430, 21449);
                    return return_v;
                }


                bool
                f_1293_21737_21759(System.Type
                this_param)
                {
                    var return_v = this_param.IsCOMObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 21737, 21759);
                    return return_v;
                }


                bool
                f_1293_21967_22002(System.Type
                type)
                {
                    var return_v = WinRTHelper.IsWinRTType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 21967, 22002);
                    return return_v;
                }


                string
                f_1293_22502_22521(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 22502, 22521);
                    return return_v;
                }


                bool
                f_1293_22502_22550(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 22502, 22550);
                    return return_v;
                }


                System.Management.Automation.ComTypeInfo
                f_1293_22891_22927(object
                comObject)
                {
                    var return_v = ComTypeInfo.GetDispatchTypeInfo(comObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 22891, 22927);
                    return return_v;
                }


                System.Management.Automation.ComAdapter
                f_1293_23027_23047(System.Management.Automation.ComTypeInfo
                typeinfo)
                {
                    var return_v = new System.Management.Automation.ComAdapter(typeinfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 23027, 23047);
                    return return_v;
                }


                System.Management.Automation.DotNetAdapter
                f_1293_23049_23070()
                {
                    var return_v = DotNetInstanceAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 23049, 23070);
                    return return_v;
                }


                System.Management.Automation.PSObject.AdapterSet
                f_1293_23012_23071(System.Management.Automation.ComAdapter
                adapter, System.Management.Automation.DotNetAdapter
                dotnetAdapter)
                {
                    var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 23012, 23071);
                    return return_v;
                }


                System.Management.Automation.ComTypeInfo
                f_1293_23263_23299(object
                comObject)
                {
                    var return_v = ComTypeInfo.GetDispatchTypeInfo(comObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 23263, 23299);
                    return return_v;
                }


                System.Management.Automation.DotNetAdapterWithComTypeName
                f_1293_23401_23439(System.Management.Automation.ComTypeInfo
                comTypeInfo)
                {
                    var return_v = new System.Management.Automation.DotNetAdapterWithComTypeName(comTypeInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 23401, 23439);
                    return return_v;
                }


                System.Management.Automation.PSObject.AdapterSet
                f_1293_23386_23446(System.Management.Automation.DotNetAdapterWithComTypeName
                adapter, System.Management.Automation.DotNetAdapter
                dotnetAdapter)
                {
                    var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 23386, 23446);
                    return return_v;
                }


                System.Management.Automation.PSObject.AdapterSet
                f_1293_23741_23786(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Management.Automation.PSObject.AdapterSet>
                this_param, System.Type
                key, System.Management.Automation.PSObject.AdapterSet
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 23741, 23786);
                    return return_v;
                }


                int
                f_1293_23801_23895(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 23801, 23895);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 20674, 23937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 20674, 23937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AdapterSet CreateThirdPartyAdapterSet(Type adaptedType, PSPropertyAdapter adapter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 23971, 24204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 24094, 24193);

                return f_1293_24101_24192(f_1293_24116_24159(adaptedType, adapter), s_baseAdapterForAdaptedObjects);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 23971, 24204);

                System.Management.Automation.ThirdPartyAdapter
                f_1293_24116_24159(System.Type
                adaptedType, System.Management.Automation.PSPropertyAdapter
                externalAdapter)
                {
                    var return_v = new System.Management.Automation.ThirdPartyAdapter(adaptedType, externalAdapter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 24116, 24159);
                    return return_v;
                }


                System.Management.Automation.PSObject.AdapterSet
                f_1293_24101_24192(System.Management.Automation.ThirdPartyAdapter
                adapter, System.Management.Automation.DotNetAdapter
                dotnetAdapter)
                {
                    var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 24101, 24192);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 23971, 24204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 23971, 24204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1293, 24400, 24503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27044, 27070);
                this._lockObject = f_1293_27058_27070();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27110, 27120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27310, 27330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27376, 27386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27416, 27427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27491, 27507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27574, 27582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27651, 27662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27729, 27737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27772, 27778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 99647, 99686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 99804, 99861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100001, 100051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100261, 100345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100723, 100803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 24442, 24492);

                f_1293_24442_24491(this, PSCustomObject.SelfInstance);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1293, 24400, 24503);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 24400, 24503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 24400, 24503);
            }
        }

        public PSObject(int instanceMemberCapacity) : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1293, 24814, 24994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 24891, 24983);

                _instanceMembers = f_1293_24910_24982(instanceMemberCapacity);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1293, 24814, 24994);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 24814, 24994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 24814, 24994);
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "obj", Justification = "This is shipped as part of V1. Retaining this for backward compatibility.")]
        public PSObject(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1293, 25314, 25741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27044, 27070);
                this._lockObject = f_1293_27058_27070();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27110, 27120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27310, 27330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27376, 27386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27416, 27427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27491, 27507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27574, 27582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27651, 27662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27729, 27737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27772, 27778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 99647, 99686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 99804, 99861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100001, 100051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100261, 100345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100723, 100803);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 25572, 25688) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 25572, 25688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 25621, 25673);

                    throw f_1293_25627_25672("obj");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 25572, 25688);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 25704, 25730);

                f_1293_25704_25729(this, obj);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1293, 25314, 25741);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 25314, 25741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 25314, 25741);
            }
        }

        protected PSObject(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1293, 26032, 26716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27044, 27070);
                this._lockObject = f_1293_27058_27070();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27110, 27120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27310, 27330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27376, 27386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27416, 27427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27491, 27507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27574, 27582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27651, 27662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27729, 27737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27772, 27778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 99647, 99686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 99804, 99861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100001, 100051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100261, 100345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100723, 100803);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 26125, 26243) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 26125, 26243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 26175, 26228);

                    throw f_1293_26181_26227("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 26125, 26243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 26259, 26333);

                string
                serializedData = f_1293_26283_26322(info, "CliXml", typeof(string)) as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 26349, 26477) || true) && (serializedData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 26349, 26477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 26409, 26462);

                    throw f_1293_26415_26461("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 26349, 26477);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 26493, 26573);

                PSObject
                result = f_1293_26511_26572(f_1293_26531_26571(serializedData))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 26587, 26636);

                f_1293_26587_26635(this, f_1293_26608_26634(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 26652, 26705);

                f_1293_26652_26704(source: result, target: this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1293, 26032, 26716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 26032, 26716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 26032, 26716);
            }
        }

        internal static PSObject ConstructPSObjectFromSerializationInfo(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 26728, 26912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 26866, 26901);

                return f_1293_26873_26900(info, context);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 26728, 26912);

                System.Management.Automation.PSObject
                f_1293_26873_26900(System.Runtime.Serialization.SerializationInfo
                info, System.Runtime.Serialization.StreamingContext
                context)
                {
                    var return_v = new System.Management.Automation.PSObject(info, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 26873, 26900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 26728, 26912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 26728, 26912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly object _lockObject;

        private ConsolidatedString _typeNames;

        private object _immediateBaseObject;

        private WeakReference<TypeTable> _typeTable;

        private AdapterSet _adapterSet;

        private PSMemberInfoInternalCollection<PSMemberInfo> _instanceMembers;

        private PSMemberInfoIntegratingCollection<PSMemberInfo> _members;

        private PSMemberInfoIntegratingCollection<PSPropertyInfo> _properties;

        private PSMemberInfoIntegratingCollection<PSMethodInfo> _methods;

        private PSObjectFlags _flags;

        private static readonly PSTraceSource s_memberResolution;

        private static readonly ConditionalWeakTable<object, ConsolidatedString> s_typeNamesResurrectionTable;

        private static readonly Collection<CollectionEntry<PSMemberInfo>> s_memberCollection;

        private static readonly Collection<CollectionEntry<PSMethodInfo>> s_methodCollection;

        private static readonly Collection<CollectionEntry<PSPropertyInfo>> s_propertyCollection;

        private static readonly DotNetAdapter s_dotNetInstanceAdapter;

        private static readonly DotNetAdapter s_baseAdapterForAdaptedObjects;

        private static readonly DotNetAdapter s_dotNetStaticAdapter;

        private static readonly AdapterSet s_dotNetInstanceAdapterSet;

        private static readonly AdapterSet s_mshMemberSetAdapter;

        private static readonly AdapterSet s_mshObjectAdapter;

        private static readonly PSObject.AdapterSet s_cimInstanceAdapter;

        private static readonly AdapterSet s_managementObjectAdapter;

        private static readonly AdapterSet s_managementClassAdapter;

        private static readonly AdapterSet s_directoryEntryAdapter;

        private static readonly AdapterSet s_dataRowViewAdapter;

        private static readonly AdapterSet s_dataRowAdapter;

        private static readonly AdapterSet s_xmlNodeAdapter;

        internal PSMemberInfoInternalCollection<PSMemberInfo> InstanceMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 30660, 31310);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 30696, 31251) || true) && (_instanceMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 30696, 31251);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 30772, 30783);
                        lock (_lockObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 30833, 31209) || true) && (_instanceMembers == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 30833, 31209);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 30919, 31182);

                                _instanceMembers =
                                f_1293_30971_31181(s_instanceMembersResurrectionTable, f_1293_31053_31086(this), _ => new PSMemberInfoInternalCollection<PSMemberInfo>());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 30833, 31209);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 30696, 31251);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 31271, 31295);

                    return _instanceMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 30660, 31310);

                    object
                    f_1293_31053_31086(System.Management.Automation.PSObject
                    obj)
                    {
                        var return_v = GetKeyForResurrectionTables((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 31053, 31086);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                    f_1293_30971_31181(System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                    this_param, object
                    key, System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>.CreateValueCallback
                    createValueCallback)
                    {
                        var return_v = this_param.GetValue(key, createValueCallback);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 30971, 31181);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 30566, 31369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 30566, 31369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 31330, 31357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 31333, 31357);
                    _instanceMembers = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 31330, 31357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 30566, 31369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 30566, 31369);
                }
            }
        }

        internal Adapter InternalAdapter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 31538, 31575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 31541, 31575);
                    return f_1293_31541_31575(f_1293_31541_31559());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 31538, 31575);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 31538, 31575);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 31538, 31575);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Adapter InternalBaseDotNetAdapter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 32173, 32208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 32176, 32208);
                    return f_1293_32176_32208(f_1293_32176_32194());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 32173, 32208);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 32173, 32208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 32173, 32208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private AdapterSet InternalAdapterSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 32541, 32982);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 32577, 32928) || true) && (_adapterSet == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 32577, 32928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 32648, 32659);
                        lock (_lockObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 32709, 32886) || true) && (_adapterSet == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 32709, 32886);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 32790, 32859);

                                _adapterSet = f_1293_32804_32858(_immediateBaseObject, f_1293_32843_32857(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 32709, 32886);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 32577, 32928);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 32948, 32967);

                    return _adapterSet;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 32541, 32982);

                    System.Management.Automation.Runspaces.TypeTable
                    f_1293_32843_32857(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.GetTypeTable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 32843, 32857);
                        return return_v;
                    }


                    System.Management.Automation.PSObject.AdapterSet
                    f_1293_32804_32858(object
                    obj, System.Management.Automation.Runspaces.TypeTable
                    typeTable)
                    {
                        var return_v = GetMappedAdapter(obj, typeTable);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 32804, 32858);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 32479, 32993);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 32479, 32993);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSMemberInfoCollection<PSMemberInfo> Members
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 33169, 33621);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 33205, 33570) || true) && (_members == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 33205, 33570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 33273, 33284);
                        lock (_lockObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 33334, 33528) || true) && (_members == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 33334, 33528);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 33412, 33501);

                                _members = f_1293_33423_33500(this, s_memberCollection);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 33334, 33528);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 33205, 33570);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 33590, 33606);

                    return _members;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 33169, 33621);

                    System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>
                    f_1293_33423_33500(System.Management.Automation.PSObject
                    owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                    collections)
                    {
                        var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>((object)owner, collections);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 33423, 33500);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 33093, 33632);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 33093, 33632);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSMemberInfoCollection<PSPropertyInfo> Properties
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 33860, 34328);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 33896, 34274) || true) && (_properties == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 33896, 34274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 33967, 33978);
                        lock (_lockObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 34028, 34232) || true) && (_properties == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 34028, 34232);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 34109, 34205);

                                _properties = f_1293_34123_34204(this, s_propertyCollection);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 34028, 34232);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 33896, 34274);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 34294, 34313);

                    return _properties;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 33860, 34328);

                    System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>
                    f_1293_34123_34204(System.Management.Automation.PSObject
                    owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
                    collections)
                    {
                        var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>((object)owner, collections);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 34123, 34204);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 33779, 34339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 33779, 34339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSMemberInfoCollection<PSMethodInfo> Methods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 34559, 35011);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 34595, 34960) || true) && (_methods == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 34595, 34960);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 34663, 34674);
                        lock (_lockObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 34724, 34918) || true) && (_methods == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 34724, 34918);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 34802, 34891);

                                _methods = f_1293_34813_34890(this, s_methodCollection);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 34724, 34918);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 34595, 34960);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 34980, 34996);

                    return _methods;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 34559, 35011);

                    System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>
                    f_1293_34813_34890(System.Management.Automation.PSObject
                    owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
                    collections)
                    {
                        var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>((object)owner, collections);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 34813, 34890);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 34483, 35022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 34483, 35022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public object ImmediateBaseObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 35295, 35318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 35298, 35318);
                    return _immediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 35295, 35318);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 35295, 35318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 35295, 35318);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public object BaseObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 35608, 35959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 35644, 35663);

                    object
                    returnValue
                    = default(object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 35681, 35704);

                    PSObject
                    mshObj = this
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 35722, 35905);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 35765, 35807);

                                returnValue = mshObj._immediateBaseObject;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 35829, 35862);

                                mshObj = returnValue as PSObject;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 35722, 35905);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 35722, 35905) || true) && (mshObj != null)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 35722, 35905);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 35722, 35905);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 35925, 35944);

                    return returnValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 35608, 35959);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 35559, 35970);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 35559, 35970);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Collection<string> TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 36181, 37271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 36217, 36248);

                    var
                    result = f_1293_36230_36247()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 36266, 37222) || true) && (f_1293_36270_36287(result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 36266, 37222);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 36335, 36346);
                        lock (_lockObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 36511, 37180) || true) && (f_1293_36515_36532(result))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 36511, 37180);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 36590, 36808);

                                _typeNames = f_1293_36603_36807(s_typeNamesResurrectionTable, f_1293_36687_36720(this), _ => new ConsolidatedString(_typeNames));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 36840, 36868);

                                object
                                baseObj = f_1293_36857_36867()
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 36996, 37103) || true) && (baseObj != null)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 36996, 37103);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 37019, 37101);

                                    f_1293_37019_37100(f_1293_37082_37099(baseObj));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 36996, 37103);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 37135, 37153);

                                return _typeNames;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 36511, 37180);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 36266, 37222);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 37242, 37256);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 36181, 37271);

                    System.Management.Automation.Runspaces.ConsolidatedString
                    f_1293_36230_36247()
                    {
                        var return_v = InternalTypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 36230, 36247);
                        return return_v;
                    }


                    bool
                    f_1293_36270_36287(System.Management.Automation.Runspaces.ConsolidatedString
                    this_param)
                    {
                        var return_v = this_param.IsReadOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 36270, 36287);
                        return return_v;
                    }


                    bool
                    f_1293_36515_36532(System.Management.Automation.Runspaces.ConsolidatedString
                    this_param)
                    {
                        var return_v = this_param.IsReadOnly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 36515, 36532);
                        return return_v;
                    }


                    object
                    f_1293_36687_36720(System.Management.Automation.PSObject
                    obj)
                    {
                        var return_v = GetKeyForResurrectionTables((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 36687, 36720);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.ConsolidatedString
                    f_1293_36603_36807(System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.Runspaces.ConsolidatedString>
                    this_param, object
                    key, System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.Runspaces.ConsolidatedString>.CreateValueCallback
                    createValueCallback)
                    {
                        var return_v = this_param.GetValue(key, createValueCallback);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 36603, 36807);
                        return return_v;
                    }


                    object
                    f_1293_36857_36867()
                    {
                        var return_v = BaseObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 36857, 36867);
                        return return_v;
                    }


                    System.Type
                    f_1293_37082_37099(object
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 37082, 37099);
                        return return_v;
                    }


                    int
                    f_1293_37019_37100(System.Type
                    type)
                    {
                        PSVariableAssignmentBinder.NoteTypeHasInstanceMemberOrTypeName(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 37019, 37100);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 36121, 37282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 36121, 37282);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ConsolidatedString InternalTypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 37364, 38597);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 37400, 38544) || true) && (_typeNames == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 37400, 38544);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 37470, 37481);
                        lock (_lockObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 37531, 38502) || true) && (_typeNames == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 37531, 38502);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 37611, 38475) || true) && (!f_1293_37616_37707(s_typeNamesResurrectionTable, f_1293_37657_37690(this), out _typeNames))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 37611, 38475);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 38368, 38444);

                                    _typeNames = f_1293_38381_38443(f_1293_38381_38396(), _immediateBaseObject);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 37611, 38475);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 37531, 38502);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 37400, 38544);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 38564, 38582);

                    return _typeNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 37364, 38597);

                    object
                    f_1293_37657_37690(System.Management.Automation.PSObject
                    obj)
                    {
                        var return_v = GetKeyForResurrectionTables((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 37657, 37690);
                        return return_v;
                    }


                    bool
                    f_1293_37616_37707(System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.Runspaces.ConsolidatedString>
                    this_param, object
                    key, out System.Management.Automation.Runspaces.ConsolidatedString
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 37616, 37707);
                        return return_v;
                    }


                    System.Management.Automation.Adapter
                    f_1293_38381_38396()
                    {
                        var return_v = InternalAdapter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 38381, 38396);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.ConsolidatedString
                    f_1293_38381_38443(System.Management.Automation.Adapter
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.BaseGetTypeNameHierarchy(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 38381, 38443);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 37294, 38650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 37294, 38650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 38617, 38638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 38620, 38638);
                    _typeNames = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 38617, 38638);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 37294, 38650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 37294, 38650);
                }
            }
        }

        internal static ConsolidatedString GetTypeNames(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 38662, 39106);
                System.Management.Automation.Runspaces.ConsolidatedString result = default(System.Management.Automation.Runspaces.ConsolidatedString);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 38746, 38851) || true) && (obj is PSObject psobj)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 38746, 38851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 38805, 38836);

                    return f_1293_38812_38835(psobj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 38746, 38851);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 38867, 38989) || true) && (f_1293_38871_38926(obj, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 38867, 38989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 38960, 38974);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 38867, 38989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 39005, 39095);

                return f_1293_39012_39094(f_1293_39012_39064(f_1293_39012_39048(obj, null)), obj);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 38662, 39106);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_38812_38835(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 38812, 38835);
                    return return_v;
                }


                bool
                f_1293_38871_38926(object
                obj, out System.Management.Automation.Runspaces.ConsolidatedString
                result)
                {
                    var return_v = HasInstanceTypeName(obj, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 38871, 38926);
                    return return_v;
                }


                System.Management.Automation.PSObject.AdapterSet
                f_1293_39012_39048(object
                obj, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = PSObject.GetMappedAdapter(obj, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 39012, 39048);
                    return return_v;
                }


                System.Management.Automation.Adapter
                f_1293_39012_39064(System.Management.Automation.PSObject.AdapterSet
                this_param)
                {
                    var return_v = this_param.OriginalAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 39012, 39064);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_39012_39094(System.Management.Automation.Adapter
                this_param, object
                obj)
                {
                    var return_v = this_param.BaseGetTypeNameHierarchy(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 39012, 39094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 38662, 39106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 38662, 39106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasInstanceTypeName(object obj, out ConsolidatedString result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 39118, 39331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 39226, 39320);

                return f_1293_39233_39319(s_typeNamesResurrectionTable, f_1293_39274_39306(obj), out result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 39118, 39331);

                object
                f_1293_39274_39306(object
                obj)
                {
                    var return_v = GetKeyForResurrectionTables(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 39274, 39306);
                    return return_v;
                }


                bool
                f_1293_39233_39319(System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.Runspaces.ConsolidatedString>
                this_param, object
                key, out System.Management.Automation.Runspaces.ConsolidatedString
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 39233, 39319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 39118, 39331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 39118, 39331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasInstanceMembers(object obj, out PSMemberInfoInternalCollection<PSMemberInfo> instanceMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 39408, 40336);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 39550, 40249) || true) && (obj is PSObject psobj)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 39550, 40249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 39615, 39620);
                    lock (psobj)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 39662, 39880) || true) && (psobj._instanceMembers == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 39662, 39880);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 39746, 39857);

                            f_1293_39746_39856(s_instanceMembersResurrectionTable, f_1293_39793_39827(psobj), out psobj._instanceMembers);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 39662, 39880);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 39919, 39960);

                    instanceMembers = psobj._instanceMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 39550, 40249);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 39550, 40249);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 39994, 40249) || true) && (obj != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 39994, 40249);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 40043, 40145);

                        f_1293_40043_40144(s_instanceMembersResurrectionTable, f_1293_40090_40122(obj), out instanceMembers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 39994, 40249);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 39994, 40249);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 40211, 40234);

                        instanceMembers = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 39994, 40249);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 39550, 40249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 40265, 40325);

                return instanceMembers != null && (DynAbs.Tracing.TraceSender.Expression_True(1293, 40272, 40324) && f_1293_40299_40320(instanceMembers) > 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 39408, 40336);

                object
                f_1293_39793_39827(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = GetKeyForResurrectionTables((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 39793, 39827);
                    return return_v;
                }


                bool
                f_1293_39746_39856(System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, object
                key, out System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 39746, 39856);
                    return return_v;
                }


                object
                f_1293_40090_40122(object
                obj)
                {
                    var return_v = GetKeyForResurrectionTables(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 40090, 40122);
                    return return_v;
                }


                bool
                f_1293_40043_40144(System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
                this_param, object
                key, out System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 40043, 40144);
                    return return_v;
                }


                int
                f_1293_40299_40320(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 40299, 40320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 39408, 40336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 39408, 40336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ConditionalWeakTable<object, PSMemberInfoInternalCollection<PSMemberInfo>> s_instanceMembersResurrectionTable;

        /// <summary>
        /// </summary>
        /// <param name="valueToConvert"></param>
        /// <returns></returns>
        public static implicit operator PSObject(int valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 40721, 40860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 40806, 40849);

                return f_1293_40813_40848(valueToConvert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 40721, 40860);

                System.Management.Automation.PSObject
                f_1293_40813_40848(int
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 40813, 40848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 40721, 40860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 40721, 40860);
            }
        }        /// <summary>
                 /// </summary>
                 /// <param name="valueToConvert"></param>
                 /// <returns></returns>
        public static implicit operator PSObject(string valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 41001, 41143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 41089, 41132);

                return f_1293_41096_41131(valueToConvert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 41001, 41143);

                System.Management.Automation.PSObject
                f_1293_41096_41131(string
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 41096, 41131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 41001, 41143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 41001, 41143);
            }
        }        /// <summary>
                 /// </summary>
                 /// <param name="valueToConvert"></param>
                 /// <returns></returns>
        public static implicit operator PSObject(Hashtable valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 41284, 41429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 41375, 41418);

                return f_1293_41382_41417(valueToConvert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 41284, 41429);

                System.Management.Automation.PSObject
                f_1293_41382_41417(System.Collections.Hashtable
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 41382, 41417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 41284, 41429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 41284, 41429);
            }
        }        /// <summary>
                 /// </summary>
                 /// <param name="valueToConvert"></param>
                 /// <returns></returns>
        public static implicit operator PSObject(double valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 41570, 41712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 41658, 41701);

                return f_1293_41665_41700(valueToConvert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 41570, 41712);

                System.Management.Automation.PSObject
                f_1293_41665_41700(double
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 41665, 41700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 41570, 41712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 41570, 41712);
            }
        }        /// <summary>
                 /// </summary>
                 /// <param name="valueToConvert"></param>
                 /// <returns></returns>
        public static implicit operator PSObject(bool valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 41853, 41993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 41939, 41982);

                return f_1293_41946_41981(valueToConvert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 41853, 41993);

                System.Management.Automation.PSObject
                f_1293_41946_41981(bool
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 41946, 41981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 41853, 41993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 41853, 41993);
            }
        }
        internal static object Base(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 42248, 42934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42312, 42346);

                PSObject
                mshObj = obj as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42360, 42438) || true) && (mshObj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 42360, 42438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42412, 42423);

                    return obj;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 42360, 42438);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42454, 42519) || true) && (mshObj == f_1293_42468_42488())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 42454, 42519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42507, 42519);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 42454, 42519);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42533, 42630) || true) && (f_1293_42537_42570(mshObj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 42533, 42630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42604, 42615);

                    return obj;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 42533, 42630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42646, 42665);

                object
                returnValue
                = default(object);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 42679, 42888);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42714, 42756);

                            returnValue = mshObj._immediateBaseObject;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42774, 42807);

                            mshObj = returnValue as PSObject;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 42679, 42888);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42679, 42888) || true) && ((mshObj != null) && (DynAbs.Tracing.TraceSender.Expression_True(1293, 42830, 42886) && (f_1293_42851_42885_M(!mshObj.ImmediateBaseObjectIsEmpty))))
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 42679, 42888);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 42679, 42888);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 42904, 42923);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 42248, 42934);

                System.Management.Automation.PSObject
                f_1293_42468_42488()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 42468, 42488);
                    return return_v;
                }


                bool
                f_1293_42537_42570(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObjectIsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 42537, 42570);
                    return return_v;
                }


                bool
                f_1293_42851_42885_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 42851, 42885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 42248, 42934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 42248, 42934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSMemberInfo GetStaticCLRMember(object obj, string methodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 42946, 43372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 43049, 43074);

                obj = f_1293_43055_43073(obj);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 43088, 43212) || true) && (obj == null || (DynAbs.Tracing.TraceSender.Expression_False(1293, 43092, 43125) || methodName == null) || (DynAbs.Tracing.TraceSender.Expression_False(1293, 43092, 43151) || f_1293_43129_43146(methodName) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 43088, 43212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 43185, 43197);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 43088, 43212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 43228, 43271);

                var
                objType = obj as Type ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1293, 43242, 43270) ?? f_1293_43257_43270(obj))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 43285, 43361);

                return f_1293_43292_43360(f_1293_43292_43311(), objType, methodName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 42946, 43372);

                object
                f_1293_43055_43073(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 43055, 43073);
                    return return_v;
                }


                int
                f_1293_43129_43146(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 43129, 43146);
                    return return_v;
                }


                System.Type
                f_1293_43257_43270(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 43257, 43270);
                    return return_v;
                }


                System.Management.Automation.DotNetAdapter
                f_1293_43292_43311()
                {
                    var return_v = DotNetStaticAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 43292, 43311);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1293_43292_43360(System.Management.Automation.DotNetAdapter
                this_param, System.Type
                obj, string
                memberName)
                {
                    var return_v = this_param.BaseGetMember<System.Management.Automation.PSMemberInfo>((object)obj, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 43292, 43360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 42946, 43372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 42946, 43372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "obj", Justification = "This is shipped as part of V1. Retaining this for backward compatibility.")]
        public static PSObject AsPSObject(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 43828, 44145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 44104, 44134);

                return f_1293_44111_44133(obj, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 43828, 44145);

                System.Management.Automation.PSObject
                f_1293_44111_44133(object
                obj, bool
                storeTypeNameAndInstanceMembersLocally)
                {
                    var return_v = AsPSObject(obj, storeTypeNameAndInstanceMembersLocally);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 44111, 44133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 43828, 44145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 43828, 44145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "obj", Justification = "AsPSObject is shipped as part of V1. This is a new overload method.")]
        internal static PSObject AsPSObject(object obj, bool storeTypeNameAndInstanceMembersLocally)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 44634, 45300);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 44951, 45067) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 44951, 45067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 45000, 45052);

                    throw f_1293_45006_45051("obj");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 44951, 45067);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 45083, 45164) || true) && (obj is PSObject so)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 45083, 45164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 45139, 45149);

                    return so;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 45083, 45164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 45180, 45289);

                return new PSObject(obj) { StoreTypeNameAndInstanceMembersLocally = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => storeTypeNameAndInstanceMembersLocally, 1293, 45187, 45288) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 44634, 45300);

                System.Management.Automation.PSArgumentNullException
                f_1293_45006_45051(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 45006, 45051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 44634, 45300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 44634, 45300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GetKeyForResurrectionTables(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 45870, 46660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 45957, 45983);

                var
                pso = obj as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 45997, 46072) || true) && (pso == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 45997, 46072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 46046, 46057);

                    return obj;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 45997, 46072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 46088, 46121);

                PSObject
                psObjectAboveBase = pso
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 46135, 46308) || true) && (f_1293_46142_46179(psObjectAboveBase) is PSObject)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 46135, 46308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 46225, 46293);

                        psObjectAboveBase = (PSObject)f_1293_46255_46292(psObjectAboveBase);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 46135, 46308);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 46135, 46308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 46135, 46308);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 46324, 46588) || true) && (f_1293_46328_46365(psObjectAboveBase) is PSCustomObject
                || (DynAbs.Tracing.TraceSender.Expression_False(1293, 46328, 46451) || f_1293_46404_46441(psObjectAboveBase) is string
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1293, 46328, 46514) || f_1293_46472_46514(pso)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 46324, 46588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 46548, 46573);

                    return psObjectAboveBase;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 46324, 46588);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 46604, 46649);

                return f_1293_46611_46648(psObjectAboveBase);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 45870, 46660);

                object
                f_1293_46142_46179(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 46142, 46179);
                    return return_v;
                }


                object
                f_1293_46255_46292(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 46255, 46292);
                    return return_v;
                }


                object
                f_1293_46328_46365(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 46328, 46365);
                    return return_v;
                }


                object
                f_1293_46404_46441(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 46404, 46441);
                    return return_v;
                }


                bool
                f_1293_46472_46514(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.StoreTypeNameAndInstanceMembersLocally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 46472, 46514);
                    return return_v;
                }


                object
                f_1293_46611_46648(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 46611, 46648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 45870, 46660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 45870, 46660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetSeparator(ExecutionContext context, string separator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 46771, 47183);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 46874, 46961) || true) && (separator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 46874, 46961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 46929, 46946);

                    return separator;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 46874, 46961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 46977, 47045);

                object
                obj = f_1293_46990_47044_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(context, 1293, 46990, 47044)?.GetVariableValue(SpecialVariables.OFSVarPath))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47059, 47145) || true) && (obj != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 47059, 47145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47108, 47130);

                    return f_1293_47115_47129(obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 47059, 47145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47161, 47172);

                return " ";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 46771, 47183);

                object
                f_1293_46990_47044_I(object
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 46990, 47044);
                    return return_v;
                }


                string?
                f_1293_47115_47129(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 47115, 47129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 46771, 47183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 46771, 47183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ToStringEnumerator(ExecutionContext context, IEnumerator enumerator, string separator, string format, IFormatProvider formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 47195, 48105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47376, 47424);

                StringBuilder
                returnValue = f_1293_47404_47423()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47438, 47495);

                string
                separatorToUse = f_1293_47462_47494(context, separator)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47509, 47790) || true) && (f_1293_47516_47537(enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 47509, 47790);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47571, 47603);

                        object
                        obj = f_1293_47584_47602(enumerator)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47621, 47722);

                        f_1293_47621_47721(returnValue, f_1293_47640_47720(context, obj, separator, format, formatProvider, false, false));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47740, 47775);

                        f_1293_47740_47774(returnValue, separatorToUse);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 47509, 47790);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 47509, 47790);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 47509, 47790);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47806, 47902) || true) && (f_1293_47810_47828(returnValue) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 47806, 47902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47867, 47887);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 47806, 47902);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47918, 47962);

                int
                separatorLength = f_1293_47940_47961(separatorToUse)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 47976, 48050);

                f_1293_47976_48049(returnValue, f_1293_47995_48013(returnValue) - separatorLength, separatorLength);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48064, 48094);

                return f_1293_48071_48093(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 47195, 48105);

                System.Text.StringBuilder
                f_1293_47404_47423()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 47404, 47423);
                    return return_v;
                }


                string
                f_1293_47462_47494(System.Management.Automation.ExecutionContext
                context, string
                separator)
                {
                    var return_v = GetSeparator(context, separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 47462, 47494);
                    return return_v;
                }


                bool
                f_1293_47516_47537(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 47516, 47537);
                    return return_v;
                }


                object
                f_1293_47584_47602(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 47584, 47602);
                    return return_v;
                }


                string
                f_1293_47640_47720(System.Management.Automation.ExecutionContext
                context, object
                obj, string
                separator, string
                format, System.IFormatProvider
                formatProvider, bool
                recurse, bool
                unravelEnumeratorOnRecurse)
                {
                    var return_v = PSObject.ToString(context, obj, separator, format, formatProvider, recurse, unravelEnumeratorOnRecurse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 47640, 47720);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_47621_47721(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 47621, 47721);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_47740_47774(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 47740, 47774);
                    return return_v;
                }


                int
                f_1293_47810_47828(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 47810, 47828);
                    return return_v;
                }


                int
                f_1293_47940_47961(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 47940, 47961);
                    return return_v;
                }


                int
                f_1293_47995_48013(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 47995, 48013);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_47976_48049(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 47976, 48049);
                    return return_v;
                }


                string
                f_1293_48071_48093(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 48071, 48093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 47195, 48105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 47195, 48105);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ToStringEnumerable(ExecutionContext context, IEnumerable enumerable, string separator, string format, IFormatProvider formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 48117, 49128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48298, 48346);

                StringBuilder
                returnValue = f_1293_48326_48345()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48360, 48417);

                string
                separatorToUse = f_1293_48384_48416(context, separator)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48431, 48813);
                    foreach (object obj in f_1293_48454_48464_I(enumerable))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 48431, 48813);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48498, 48743) || true) && (obj != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 48498, 48743);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48555, 48598);

                            PSObject
                            mshObj = f_1293_48573_48597(obj)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48620, 48724);

                            f_1293_48620_48723(returnValue, f_1293_48639_48722(context, mshObj, separator, format, formatProvider, false, false));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 48498, 48743);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48763, 48798);

                        f_1293_48763_48797(
                                        returnValue, separatorToUse);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 48431, 48813);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 383);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48829, 48925) || true) && (f_1293_48833_48851(returnValue) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 48829, 48925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48890, 48910);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 48829, 48925);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48941, 48985);

                int
                separatorLength = f_1293_48963_48984(separatorToUse)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 48999, 49073);

                f_1293_48999_49072(returnValue, f_1293_49018_49036(returnValue) - separatorLength, separatorLength);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49087, 49117);

                return f_1293_49094_49116(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 48117, 49128);

                System.Text.StringBuilder
                f_1293_48326_48345()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 48326, 48345);
                    return return_v;
                }


                string
                f_1293_48384_48416(System.Management.Automation.ExecutionContext
                context, string
                separator)
                {
                    var return_v = GetSeparator(context, separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 48384, 48416);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1293_48573_48597(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 48573, 48597);
                    return return_v;
                }


                string
                f_1293_48639_48722(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.PSObject
                obj, string
                separator, string
                format, System.IFormatProvider
                formatProvider, bool
                recurse, bool
                unravelEnumeratorOnRecurse)
                {
                    var return_v = PSObject.ToString(context, (object)obj, separator, format, formatProvider, recurse, unravelEnumeratorOnRecurse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 48639, 48722);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_48620_48723(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 48620, 48723);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_48763_48797(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 48763, 48797);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1293_48454_48464_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 48454, 48464);
                    return return_v;
                }


                int
                f_1293_48833_48851(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 48833, 48851);
                    return return_v;
                }


                int
                f_1293_48963_48984(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 48963, 48984);
                    return return_v;
                }


                int
                f_1293_49018_49036(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 49018, 49036);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_48999_49072(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 48999, 49072);
                    return return_v;
                }


                string
                f_1293_49094_49116(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 49094, 49116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 48117, 49128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 48117, 49128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ToStringEmptyBaseObject(ExecutionContext context, PSObject mshObj, string separator, string format, IFormatProvider formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 49140, 50270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49318, 49370);

                StringBuilder
                returnValue = f_1293_49346_49369("@{")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49384, 49404);

                bool
                isFirst = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49418, 50079);
                    foreach (PSPropertyInfo property in f_1293_49454_49471_I(f_1293_49454_49471(mshObj)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 49418, 50079);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49505, 49603) || true) && (!isFirst)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 49505, 49603);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49559, 49584);

                            f_1293_49559_49583(returnValue, "; ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 49505, 49603);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49623, 49639);

                        isFirst = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49657, 49691);

                        f_1293_49657_49690(returnValue, f_1293_49676_49689(property));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49709, 49733);

                        f_1293_49709_49732(returnValue, "=");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49837, 49933);

                        var
                        propertyValue = (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 49857, 49885) || ((property is PSScriptProperty && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 49888, 49915)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 49918, 49932))) ? f_1293_49888_49915(f_1293_49888_49906(property)) : f_1293_49918_49932(property)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 49953, 50064);

                        f_1293_49953_50063(
                                        returnValue, f_1293_49972_50062(context, propertyValue, separator, format, formatProvider, false, false));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 49418, 50079);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 662);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 662);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 50095, 50175) || true) && (isFirst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 50095, 50175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 50140, 50160);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 50095, 50175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 50191, 50215);

                f_1293_50191_50214(
                            returnValue, "}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 50229, 50259);

                return f_1293_50236_50258(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 49140, 50270);

                System.Text.StringBuilder
                f_1293_49346_49369(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 49346, 49369);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_49454_49471(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 49454, 49471);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_49559_49583(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 49559, 49583);
                    return return_v;
                }


                string
                f_1293_49676_49689(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 49676, 49689);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_49657_49690(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 49657, 49690);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_49709_49732(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 49709, 49732);
                    return return_v;
                }


                System.Type
                f_1293_49888_49906(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 49888, 49906);
                    return return_v;
                }


                string
                f_1293_49888_49915(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 49888, 49915);
                    return return_v;
                }


                object
                f_1293_49918_49932(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 49918, 49932);
                    return return_v;
                }


                string
                f_1293_49972_50062(System.Management.Automation.ExecutionContext
                context, object
                obj, string
                separator, string
                format, System.IFormatProvider
                formatProvider, bool
                recurse, bool
                unravelEnumeratorOnRecurse)
                {
                    var return_v = PSObject.ToString(context, obj, separator, format, formatProvider, recurse, unravelEnumeratorOnRecurse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 49972, 50062);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_49953_50063(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 49953, 50063);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_49454_49471_I(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 49454, 49471);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_50191_50214(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 50191, 50214);
                    return return_v;
                }


                string
                f_1293_50236_50258(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 50236, 50258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 49140, 50270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 49140, 50270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ToStringParser(ExecutionContext context, object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 51223, 51400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 51323, 51389);

                return f_1293_51330_51388(context, obj, f_1293_51359_51387());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 51223, 51400);

                System.Globalization.CultureInfo
                f_1293_51359_51387()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 51359, 51387);
                    return return_v;
                }


                string
                f_1293_51330_51388(System.Management.Automation.ExecutionContext
                context, object
                obj, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = ToStringParser(context, obj, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 51330, 51388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 51223, 51400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 51223, 51400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ToStringParser(ExecutionContext context, object obj, IFormatProvider formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 52448, 52975);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 52616, 52686);

                    return f_1293_52623_52685(context, obj, null, null, formatProvider, true, true);
                }
                catch (ExtendedTypeSystemException etse)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 52715, 52964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 52788, 52949);

                    throw f_1293_52794_52948("InvalidCastFromAnyTypeToString", f_1293_52855_52874(etse), f_1293_52897_52947());
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 52715, 52964);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 52448, 52975);

                string
                f_1293_52623_52685(System.Management.Automation.ExecutionContext
                context, object
                obj, string
                separator, string
                format, System.IFormatProvider
                formatProvider, bool
                recurse, bool
                unravelEnumeratorOnRecurse)
                {
                    var return_v = ToString(context, obj, separator, format, formatProvider, recurse, unravelEnumeratorOnRecurse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 52623, 52685);
                    return return_v;
                }


                System.Exception
                f_1293_52855_52874(System.Management.Automation.ExtendedTypeSystemException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 52855, 52874);
                    return return_v;
                }


                string
                f_1293_52897_52947()
                {
                    var return_v = ExtendedTypeSystem.InvalidCastCannotRetrieveString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 52897, 52947);
                    return return_v;
                }


                System.Management.Automation.PSInvalidCastException
                f_1293_52794_52948(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.PSInvalidCastException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 52794, 52948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 52448, 52975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 52448, 52975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ToString(ExecutionContext context, object obj, string separator, string format, IFormatProvider formatProvider, bool recurse, bool unravelEnumeratorOnRecurse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 54847, 64786);
                string objString = default(string);
                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo> instanceMembers = default(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>);
                string baseObjString = default(string);

                bool TryFastTrackPrimitiveTypes(object value, out string str)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 55053, 56557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 55147, 56510);

                        switch (f_1293_55155_55181(value))
                        {

                            case TypeCode.String:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 55147, 56510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 55270, 55290);

                                str = (string)value;
                                DynAbs.Tracing.TraceSender.TraceBreak(1293, 55316, 55322);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 55147, 56510);

                            case TypeCode.Byte:
                            case TypeCode.SByte:
                            case TypeCode.Int16:
                            case TypeCode.UInt16:
                            case TypeCode.Int32:
                            case TypeCode.UInt32:
                            case TypeCode.Int64:
                            case TypeCode.UInt64:
                            case TypeCode.DateTime:
                            case TypeCode.Decimal:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 55147, 56510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 55775, 55813);

                                var
                                formattable = (IFormattable)value
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 55839, 55890);

                                str = f_1293_55845_55889(formattable, format, formatProvider);
                                DynAbs.Tracing.TraceSender.TraceBreak(1293, 55916, 55922);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 55147, 56510);

                            case TypeCode.Double:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 55147, 56510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 55991, 56015);

                                var
                                dbl = (double)value
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56041, 56122);

                                str = f_1293_56047_56121(dbl, format ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1293, 56060, 56104) ?? LanguagePrimitives.DoublePrecision), formatProvider);
                                DynAbs.Tracing.TraceSender.TraceBreak(1293, 56148, 56154);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 55147, 56510);

                            case TypeCode.Single:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 55147, 56510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56223, 56246);

                                var
                                sgl = (float)value
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56272, 56353);

                                str = f_1293_56278_56352(sgl, format ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1293, 56291, 56335) ?? LanguagePrimitives.SinglePrecision), formatProvider);
                                DynAbs.Tracing.TraceSender.TraceBreak(1293, 56379, 56385);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 55147, 56510);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 55147, 56510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56441, 56452);

                                str = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56478, 56491);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 55147, 56510);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56530, 56542);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 55053, 56557);

                        System.TypeCode
                        f_1293_55155_55181(object
                        value)
                        {
                            var return_v = Convert.GetTypeCode(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 55155, 55181);
                            return return_v;
                        }


                        string
                        f_1293_55845_55889(System.IFormattable
                        this_param, string
                        format, System.IFormatProvider
                        formatProvider)
                        {
                            var return_v = this_param.ToString(format, formatProvider);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 55845, 55889);
                            return return_v;
                        }


                        string
                        f_1293_56047_56121(double
                        this_param, string
                        format, System.IFormatProvider
                        provider)
                        {
                            var return_v = this_param.ToString(format, provider);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 56047, 56121);
                            return return_v;
                        }


                        string
                        f_1293_56278_56352(float
                        this_param, string
                        format, System.IFormatProvider
                        provider)
                        {
                            var return_v = this_param.ToString(format, provider);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 56278, 56352);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 55053, 56557);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 55053, 56557);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56573, 56607);

                PSObject
                mshObj = obj as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56657, 59327) || true) && (mshObj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 56657, 59327);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56709, 56805) || true) && (obj == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 56709, 56805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56766, 56786);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 56709, 56805);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56825, 56960) || true) && (f_1293_56829_56882(obj, out objString))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 56825, 56960);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 56924, 56941);

                        return objString;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 56825, 56960);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 57013, 58356) || true) && (recurse)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 57013, 58356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 57066, 57129);

                        IEnumerable
                        enumerable = f_1293_57091_57128(obj)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 57151, 57616) || true) && (enumerable != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 57151, 57616);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 57283, 57365);

                                return f_1293_57290_57364(context, enumerable, separator, format, formatProvider);
                            }
                            catch (Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 57418, 57593);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 57418, 57593);
                                // We do want to ignore exceptions here to try the regular ToString below.
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 57151, 57616);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 57640, 58337) || true) && (unravelEnumeratorOnRecurse)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 57640, 58337);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 57720, 57783);

                            IEnumerator
                            enumerator = f_1293_57745_57782(obj)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 57809, 58314) || true) && (enumerator != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 57809, 58314);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 57957, 58039);

                                    return f_1293_57964_58038(context, enumerator, separator, format, formatProvider);
                                }
                                catch (Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 58100, 58287);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 58100, 58287);
                                    // We do want to ignore exceptions here to try the regular ToString below.
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 57809, 58314);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 57640, 58337);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 57013, 58356);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 58455, 58505);

                    IFormattable
                    objFormattable = obj as IFormattable
                    ;
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 58567, 58926) || true) && (objFormattable == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 58567, 58926);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 58643, 58667);

                            Type
                            type = obj as Type
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 58693, 58853) || true) && (type != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 58693, 58853);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 58767, 58826);

                                return f_1293_58774_58825(type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 58693, 58853);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 58881, 58903);

                            return f_1293_58888_58902(obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 58567, 58926);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 58950, 59005);

                        return f_1293_58957_59004(objFormattable, format, formatProvider);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 59042, 59268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 59102, 59249);

                        throw f_1293_59108_59248("ToStringObjectBasicException", e, f_1293_59200_59236(), f_1293_59238_59247(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 59042, 59268);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 56657, 59327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 59616, 59643);

                PSMethodInfo
                method = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 59657, 59864) || true) && (f_1293_59661_59762(mshObj, out instanceMembers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 59657, 59864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 59796, 59849);

                    method = f_1293_59805_59832(instanceMembers, "ToString") as PSMethodInfo;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 59657, 59864);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 59880, 60498) || true) && (method == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 59880, 60498);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 59932, 60483) || true) && (f_1293_59936_59966(f_1293_59936_59960(mshObj)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 59932, 60483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 60013, 60053);

                        TypeTable
                        table = f_1293_60031_60052(mshObj)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 60075, 60464) || true) && (table != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 60075, 60464);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 60142, 60220);

                            method = f_1293_60151_60219(f_1293_60151_60207(table, f_1293_60182_60206(mshObj)), "ToString");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 60246, 60441) || true) && (method != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 60246, 60441);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 60322, 60359);

                                method = (PSMethodInfo)f_1293_60345_60358(method);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 60389, 60414);

                                method.instance = mshObj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 60246, 60441);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 60075, 60464);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 59932, 60483);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 59880, 60498);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 60514, 61497) || true) && (method != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 60514, 61497);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 60775, 60789);

                        object
                        retObj
                        = default(object);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 60811, 61080) || true) && (formatProvider != null && (DynAbs.Tracing.TraceSender.Expression_True(1293, 60815, 60877) && f_1293_60841_60873(f_1293_60841_60867(method)) > 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 60811, 61080);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 60927, 60974);

                            retObj = f_1293_60936_60973(method, format, formatProvider);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 61000, 61057);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 61007, 61021) || ((retObj != null && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 61024, 61041)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 61044, 61056))) ? f_1293_61024_61041(retObj) : string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 60811, 61080);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 61104, 61129);

                        retObj = f_1293_61113_61128(method);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 61151, 61208);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 61158, 61172) || ((retObj != null && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 61175, 61192)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 61195, 61207))) ? f_1293_61175_61192(retObj) : string.Empty;
                    }
                    catch (MethodException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 61245, 61482);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 61311, 61463);

                        throw f_1293_61317_61462("MethodExceptionNullFormatProvider", e, f_1293_61414_61450(), f_1293_61452_61461(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 61245, 61482);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 60514, 61497);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 61705, 63408) || true) && (recurse)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 61705, 63408);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 61750, 62200) || true) && (f_1293_61754_61787(mshObj))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 61750, 62200);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 61881, 61973);

                            return f_1293_61888_61972(context, mshObj, separator, format, formatProvider);
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 62018, 62181);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 62018, 62181);
                            // We do want to ignore exceptions here to try the regular ToString below.
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 61750, 62200);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 62220, 62286);

                    IEnumerable
                    enumerable = f_1293_62245_62285(mshObj)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 62304, 62729) || true) && (enumerable != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 62304, 62729);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 62420, 62502);

                            return f_1293_62427_62501(context, enumerable, separator, format, formatProvider);
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 62547, 62710);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 62547, 62710);
                            // We do want to ignore exceptions here to try the regular ToString below.
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 62304, 62729);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 62749, 63393) || true) && (unravelEnumeratorOnRecurse)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 62749, 63393);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 62821, 62887);

                        IEnumerator
                        enumerator = f_1293_62846_62886(mshObj)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 62909, 63374) || true) && (enumerator != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 62909, 63374);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 63041, 63123);

                                return f_1293_63048_63122(context, enumerator, separator, format, formatProvider);
                            }
                            catch (Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 63176, 63351);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 63176, 63351);
                                // We do want to ignore exceptions here to try the regular ToString below.
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 62909, 63374);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 62749, 63393);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 61705, 63408);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 63677, 63778) || true) && (f_1293_63681_63697(mshObj) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 63677, 63778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 63739, 63763);

                    return f_1293_63746_63762(mshObj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 63677, 63778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 63949, 63997);

                object
                baseObject = mshObj._immediateBaseObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 64013, 64151) || true) && (f_1293_64017_64081(baseObject, out baseObjString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 64013, 64151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 64115, 64136);

                    return baseObjString;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 64013, 64151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 64167, 64227);

                IFormattable
                msjObjFormattable = baseObject as IFormattable
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 64277, 64393);

                    var
                    result = (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 64290, 64315) || ((msjObjFormattable == null && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 64318, 64339)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 64342, 64392))) ? f_1293_64318_64339(baseObject) : f_1293_64342_64392(msjObjFormattable, format, formatProvider)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 64413, 64443);

                    return result ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1293, 64420, 64442) ?? string.Empty);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 64472, 64684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 64524, 64669);

                    throw f_1293_64530_64668("ToStringPSObjectBasicException", e, f_1293_64620_64656(), f_1293_64658_64667(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 64472, 64684);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 54847, 64786);

                bool
                f_1293_56829_56882(object
                value, out string
                str)
                {
                    var return_v = TryFastTrackPrimitiveTypes(value, out str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 56829, 56882);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1293_57091_57128(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 57091, 57128);
                    return return_v;
                }


                string
                f_1293_57290_57364(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerable
                enumerable, string
                separator, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = ToStringEnumerable(context, enumerable, separator, format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 57290, 57364);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1293_57745_57782(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 57745, 57782);
                    return return_v;
                }


                string
                f_1293_57964_58038(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator, string
                separator, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = ToStringEnumerator(context, enumerator, separator, format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 57964, 58038);
                    return return_v;
                }


                string
                f_1293_58774_58825(System.Type
                type)
                {
                    var return_v = Microsoft.PowerShell.ToStringCodeMethods.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 58774, 58825);
                    return return_v;
                }


                string?
                f_1293_58888_58902(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 58888, 58902);
                    return return_v;
                }


                string
                f_1293_58957_59004(System.IFormattable
                this_param, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = this_param.ToString(format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 58957, 59004);
                    return return_v;
                }


                string
                f_1293_59200_59236()
                {
                    var return_v = ExtendedTypeSystem.ToStringException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 59200, 59236);
                    return return_v;
                }


                string
                f_1293_59238_59247(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 59238, 59247);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1293_59108_59248(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 59108, 59248);
                    return return_v;
                }


                bool
                f_1293_59661_59762(System.Management.Automation.PSObject
                obj, out System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                instanceMembers)
                {
                    var return_v = PSObject.HasInstanceMembers((object)obj, out instanceMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 59661, 59762);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1293_59805_59832(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 59805, 59832);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_59936_59960(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 59936, 59960);
                    return return_v;
                }


                int
                f_1293_59936_59966(System.Management.Automation.Runspaces.ConsolidatedString
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 59936, 59966);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1293_60031_60052(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 60031, 60052);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_60182_60206(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 60182, 60206);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMethodInfo>
                f_1293_60151_60207(System.Management.Automation.Runspaces.TypeTable
                this_param, System.Management.Automation.Runspaces.ConsolidatedString
                types)
                {
                    var return_v = this_param.GetMembers<System.Management.Automation.PSMethodInfo>(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 60151, 60207);
                    return return_v;
                }


                System.Management.Automation.PSMethodInfo
                f_1293_60151_60219(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMethodInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 60151, 60219);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1293_60345_60358(System.Management.Automation.PSMethodInfo
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 60345, 60358);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1293_60841_60867(System.Management.Automation.PSMethodInfo
                this_param)
                {
                    var return_v = this_param.OverloadDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 60841, 60867);
                    return return_v;
                }


                int
                f_1293_60841_60873(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 60841, 60873);
                    return return_v;
                }


                object
                f_1293_60936_60973(System.Management.Automation.PSMethodInfo
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.Invoke(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 60936, 60973);
                    return return_v;
                }


                string?
                f_1293_61024_61041(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 61024, 61041);
                    return return_v;
                }


                object
                f_1293_61113_61128(System.Management.Automation.PSMethodInfo
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.Invoke(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 61113, 61128);
                    return return_v;
                }


                string?
                f_1293_61175_61192(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 61175, 61192);
                    return return_v;
                }


                string
                f_1293_61414_61450()
                {
                    var return_v = ExtendedTypeSystem.ToStringException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 61414, 61450);
                    return return_v;
                }


                string
                f_1293_61452_61461(System.Management.Automation.MethodException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 61452, 61461);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1293_61317_61462(string
                errorId, System.Management.Automation.MethodException
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, (System.Exception)innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 61317, 61462);
                    return return_v;
                }


                bool
                f_1293_61754_61787(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObjectIsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 61754, 61787);
                    return return_v;
                }


                string
                f_1293_61888_61972(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.PSObject
                mshObj, string
                separator, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = PSObject.ToStringEmptyBaseObject(context, mshObj, separator, format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 61888, 61972);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1293_62245_62285(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 62245, 62285);
                    return return_v;
                }


                string
                f_1293_62427_62501(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerable
                enumerable, string
                separator, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = ToStringEnumerable(context, enumerable, separator, format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 62427, 62501);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1293_62846_62886(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 62846, 62886);
                    return return_v;
                }


                string
                f_1293_63048_63122(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator, string
                separator, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = ToStringEnumerator(context, enumerator, separator, format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 63048, 63122);
                    return return_v;
                }


                string
                f_1293_63681_63697(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TokenText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 63681, 63697);
                    return return_v;
                }


                string
                f_1293_63746_63762(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TokenText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 63746, 63762);
                    return return_v;
                }


                bool
                f_1293_64017_64081(object
                value, out string
                str)
                {
                    var return_v = TryFastTrackPrimitiveTypes(value, out str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 64017, 64081);
                    return return_v;
                }


                string?
                f_1293_64318_64339(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 64318, 64339);
                    return return_v;
                }


                string
                f_1293_64342_64392(System.IFormattable
                this_param, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = this_param.ToString(format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 64342, 64392);
                    return return_v;
                }


                string
                f_1293_64620_64656()
                {
                    var return_v = ExtendedTypeSystem.ToStringException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 64620, 64656);
                    return return_v;
                }


                string
                f_1293_64658_64667(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 64658, 64667);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1293_64530_64668(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 64530, 64668);
                    return return_v;
                }


            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 54847, 64786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 54847, 64786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 65251, 65630);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 65412, 65535) || true) && (f_1293_65416_65443() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 65412, 65535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 65485, 65520);

                    return f_1293_65492_65519();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 65412, 65535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 65551, 65619);

                return f_1293_65558_65618(null, this, null, null, null, true, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 65251, 65630);

                string
                f_1293_65416_65443()
                {
                    var return_v = ToStringFromDeserialization;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 65416, 65443);
                    return return_v;
                }


                string
                f_1293_65492_65519()
                {
                    var return_v = ToStringFromDeserialization;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 65492, 65519);
                    return return_v;
                }


                string
                f_1293_65558_65618(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.PSObject
                obj, string
                separator, string
                format, System.IFormatProvider
                formatProvider, bool
                recurse, bool
                unravelEnumeratorOnRecurse)
                {
                    var return_v = PSObject.ToString(context, (object)obj, separator, format, formatProvider, recurse, unravelEnumeratorOnRecurse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 65558, 65618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 65251, 65630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 65251, 65630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 66287, 66714);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 66484, 66607) || true) && (f_1293_66488_66515() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 66484, 66607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 66557, 66592);

                    return f_1293_66564_66591();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 66484, 66607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 66623, 66703);

                return f_1293_66630_66702(null, this, null, format, formatProvider, true, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 66287, 66714);

                string
                f_1293_66488_66515()
                {
                    var return_v = ToStringFromDeserialization;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 66488, 66515);
                    return return_v;
                }


                string
                f_1293_66564_66591()
                {
                    var return_v = ToStringFromDeserialization;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 66564, 66591);
                    return return_v;
                }


                string
                f_1293_66630_66702(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.PSObject
                obj, string
                separator, string
                format, System.IFormatProvider
                formatProvider, bool
                recurse, bool
                unravelEnumeratorOnRecurse)
                {
                    var return_v = PSObject.ToString(context, (object)obj, separator, format, formatProvider, recurse, unravelEnumeratorOnRecurse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 66630, 66702);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 66287, 66714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 66287, 66714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string PrivateToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 66726, 67069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 66783, 66797);

                string
                result
                = default(string);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 66847, 66872);

                    result = f_1293_66856_66871(this);
                }
                catch (ExtendedTypeSystemException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 66901, 67028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 66969, 67013);

                    result = f_1293_66978_67012(f_1293_66978_67003(f_1293_66978_66993(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 66901, 67028);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 67044, 67058);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 66726, 67069);

                string
                f_1293_66856_66871(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 66856, 66871);
                    return return_v;
                }


                object
                f_1293_66978_66993(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 66978, 66993);
                    return return_v;
                }


                System.Type
                f_1293_66978_67003(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 66978, 67003);
                    return return_v;
                }


                string
                f_1293_66978_67012(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 66978, 67012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 66726, 67069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 66726, 67069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual PSObject Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 67444, 70580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 67499, 67555);

                PSObject
                returnValue = (PSObject)f_1293_67532_67554(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 67571, 67971) || true) && (f_1293_67575_67590(this) is PSCustomObject)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 67571, 67971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 67642, 67705);

                    returnValue._immediateBaseObject = PSCustomObject.SelfInstance;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 67723, 67769);

                    returnValue.ImmediateBaseObjectIsEmpty = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 67571, 67971);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 67571, 67971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 67835, 67891);

                    returnValue._immediateBaseObject = _immediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 67909, 67956);

                    returnValue.ImmediateBaseObjectIsEmpty = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 67571, 67971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 68083, 68119);

                returnValue._instanceMembers = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 68357, 68387);

                returnValue._typeNames = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 68403, 68511);

                returnValue._members = f_1293_68426_68510(returnValue, s_memberCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 68525, 68640);

                returnValue._properties = f_1293_68551_68639(returnValue, s_propertyCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 68654, 68762);

                returnValue._methods = f_1293_68677_68761(returnValue, s_methodCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 68778, 68883);

                returnValue._adapterSet = f_1293_68804_68882(returnValue._immediateBaseObject, f_1293_68855_68881(returnValue));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 68899, 69069) || true) && (returnValue._immediateBaseObject is ICloneable cloneableBase)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 68899, 69069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 68997, 69054);

                    returnValue._immediateBaseObject = f_1293_69032_69053(cloneableBase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 68899, 69069);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 69085, 69266) || true) && (returnValue._immediateBaseObject is ValueType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 69085, 69266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 69168, 69251);

                    returnValue._immediateBaseObject = f_1293_69203_69250(returnValue._immediateBaseObject);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 69085, 69266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 69443, 69590);

                bool
                needToReAddInstanceMembersAndTypeNames = !f_1293_69490_69589(f_1293_69513_69546(this), f_1293_69548_69588(returnValue))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 69604, 70418) || true) && (needToReAddInstanceMembersAndTypeNames)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 69604, 70418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 69680, 69852);

                    f_1293_69680_69851(!f_1293_69700_69733(f_1293_69700_69727(returnValue)), "needToReAddInstanceMembersAndTypeNames should mean that the new object has a fresh/empty list of instance members");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 69870, 70188);
                        foreach (PSMemberInfo member in f_1293_69902_69922_I(f_1293_69902_69922(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 69870, 70188);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 69964, 70065) || true) && (f_1293_69968_69983(member))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 69964, 70065);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70033, 70042);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 69964, 70065);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70137, 70169);

                            f_1293_70137_70168(f_1293_70137_70156(returnValue), member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 69870, 70188);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 319);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 319);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70208, 70238);

                    f_1293_70208_70237(f_1293_70208_70229(returnValue));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70256, 70403);
                        foreach (string typeName in f_1293_70284_70306_I(f_1293_70284_70306(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 70256, 70403);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70348, 70384);

                            f_1293_70348_70383(f_1293_70348_70369(returnValue), typeName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 70256, 70403);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 148);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 69604, 70418);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70434, 70472);

                returnValue.WriteStream = f_1293_70460_70471();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70486, 70534);

                returnValue.HasGeneratedReservedMembers = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70550, 70569);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 67444, 70580);

                object
                f_1293_67532_67554(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.MemberwiseClone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 67532, 67554);
                    return return_v;
                }


                object
                f_1293_67575_67590(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 67575, 67590);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>
                f_1293_68426_68510(System.Management.Automation.PSObject
                owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                collections)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>((object)owner, collections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 68426, 68510);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_68551_68639(System.Management.Automation.PSObject
                owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
                collections)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>((object)owner, collections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 68551, 68639);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>
                f_1293_68677_68761(System.Management.Automation.PSObject
                owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
                collections)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>((object)owner, collections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 68677, 68761);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1293_68855_68881(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 68855, 68881);
                    return return_v;
                }


                System.Management.Automation.PSObject.AdapterSet
                f_1293_68804_68882(object
                obj, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = GetMappedAdapter(obj, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 68804, 68882);
                    return return_v;
                }


                object
                f_1293_69032_69053(System.ICloneable
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 69032, 69053);
                    return return_v;
                }


                object
                f_1293_69203_69250(object
                obj)
                {
                    var return_v = CopyValueType(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 69203, 69250);
                    return return_v;
                }


                object
                f_1293_69513_69546(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = GetKeyForResurrectionTables((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 69513, 69546);
                    return return_v;
                }


                object
                f_1293_69548_69588(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = GetKeyForResurrectionTables((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 69548, 69588);
                    return return_v;
                }


                bool
                f_1293_69490_69589(object
                objA, object
                objB)
                {
                    var return_v = object.ReferenceEquals(objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 69490, 69589);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1293_69700_69727(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 69700, 69727);
                    return return_v;
                }


                bool
                f_1293_69700_69733(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.PSMemberInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 69700, 69733);
                    return return_v;
                }


                int
                f_1293_69680_69851(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 69680, 69851);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1293_69902_69922(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 69902, 69922);
                    return return_v;
                }


                bool
                f_1293_69968_69983(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 69968, 69983);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1293_70137_70156(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 70137, 70156);
                    return return_v;
                }


                int
                f_1293_70137_70168(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 70137, 70168);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1293_69902_69922_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 69902, 69922);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1293_70208_70229(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 70208, 70229);
                    return return_v;
                }


                int
                f_1293_70208_70237(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 70208, 70237);
                    return 0;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_70284_70306(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 70284, 70306);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1293_70348_70369(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 70348, 70369);
                    return return_v;
                }


                int
                f_1293_70348_70383(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 70348, 70383);
                    return 0;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_70284_70306_I(System.Management.Automation.Runspaces.ConsolidatedString
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 70284, 70306);
                    return return_v;
                }


                System.Management.Automation.WriteStreamType
                f_1293_70460_70471()
                {
                    var return_v = WriteStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 70460, 70471);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 67444, 70580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 67444, 70580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CopyValueType(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 70592, 70951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70792, 70850);

                var
                newBaseArray = f_1293_70811_70849(f_1293_70832_70845(obj), 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70864, 70894);

                f_1293_70864_70893(newBaseArray, obj, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 70908, 70940);

                return f_1293_70915_70939(newBaseArray, 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 70592, 70951);

                System.Type
                f_1293_70832_70845(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 70832, 70845);
                    return return_v;
                }


                System.Array
                f_1293_70811_70849(System.Type
                elementType, int
                length)
                {
                    var return_v = Array.CreateInstance(elementType, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 70811, 70849);
                    return return_v;
                }


                int
                f_1293_70864_70893(System.Array
                this_param, object
                value, int
                index)
                {
                    this_param.SetValue(value, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 70864, 70893);
                    return 0;
                }


                object?
                f_1293_70915_70939(System.Array
                this_param, int
                index)
                {
                    var return_v = this_param.GetValue(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 70915, 70939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 70592, 70951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 70592, 70951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int CompareTo(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 71876, 72823);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 72152, 72247) || true) && (f_1293_72156_72189(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 72152, 72247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 72223, 72232);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 72152, 72247);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 72442, 72498);

                    return f_1293_72449_72497(f_1293_72476_72491(this), obj);
                }
                catch (ArgumentException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1293, 72527, 72812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 72587, 72797);

                    throw f_1293_72593_72796("PSObjectCompareTo", e, f_1293_72670_72719(), f_1293_72721_72743(this), f_1293_72745_72780(f_1293_72745_72769(obj)), "IComparable");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1293, 72527, 72812);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 71876, 72823);

                bool
                f_1293_72156_72189(System.Management.Automation.PSObject
                objA, object
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 72156, 72189);
                    return return_v;
                }


                object
                f_1293_72476_72491(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 72476, 72491);
                    return return_v;
                }


                int
                f_1293_72449_72497(object
                first, object
                second)
                {
                    var return_v = LanguagePrimitives.Compare(first, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 72449, 72497);
                    return return_v;
                }


                string
                f_1293_72670_72719()
                {
                    var return_v = ExtendedTypeSystem.NotTheSameTypeOrNotIcomparable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 72670, 72719);
                    return return_v;
                }


                string
                f_1293_72721_72743(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.PrivateToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 72721, 72743);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1293_72745_72769(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 72745, 72769);
                    return return_v;
                }


                string
                f_1293_72745_72780(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 72745, 72780);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1293_72593_72796(string
                errorId, System.ArgumentException
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, (System.Exception)innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 72593, 72796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 71876, 72823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 71876, 72823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 73234, 74433);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 73730, 73828) || true) && (f_1293_73734_73767(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 73730, 73828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 73801, 73813);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 73730, 73828);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 74084, 74218) || true) && (f_1293_74088_74156(f_1293_74111_74126(this), PSCustomObject.SelfInstance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 74084, 74218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 74190, 74203);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 74084, 74218);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 74367, 74422);

                return f_1293_74374_74421(f_1293_74400_74415(this), obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 73234, 74433);

                bool
                f_1293_73734_73767(System.Management.Automation.PSObject
                objA, object
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 73734, 73767);
                    return return_v;
                }


                object
                f_1293_74111_74126(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 74111, 74126);
                    return return_v;
                }


                bool
                f_1293_74088_74156(object
                objA, System.Management.Automation.PSCustomObject
                objB)
                {
                    var return_v = object.ReferenceEquals(objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 74088, 74156);
                    return return_v;
                }


                object
                f_1293_74400_74415(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 74400, 74415);
                    return return_v;
                }


                bool
                f_1293_74374_74421(object
                first, object
                second)
                {
                    var return_v = LanguagePrimitives.Equals(first, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 74374, 74421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 73234, 74433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 73234, 74433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 74700, 74806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 74758, 74795);

                return f_1293_74765_74794(f_1293_74765_74780(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 74700, 74806);

                object
                f_1293_74765_74780(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 74765, 74780);
                    return return_v;
                }


                int
                f_1293_74765_74794(object
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 74765, 74794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 74700, 74806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 74700, 74806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AddOrSetProperty(string memberName, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 74863, 75277);
                System.Management.Automation.PSMemberInfo memberInfo = default(System.Management.Automation.PSMemberInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 74951, 75266) || true) && (f_1293_74955_75040(this, memberName, out memberInfo) && (DynAbs.Tracing.TraceSender.Expression_True(1293, 74955, 75072) && memberInfo is PSPropertyInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 74951, 75266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 75106, 75131);

                    memberInfo.Value = value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 74951, 75266);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 74951, 75266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 75197, 75251);

                    f_1293_75197_75250(f_1293_75197_75207(), f_1293_75212_75249(memberName, value));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 74951, 75266);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 74863, 75277);

                bool
                f_1293_74955_75040(System.Management.Automation.PSObject
                value, string
                memberName, out System.Management.Automation.PSMemberInfo
                memberInfo)
                {
                    var return_v = PSGetMemberBinder.TryGetInstanceMember((object)value, memberName, out memberInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 74955, 75040);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_75197_75207()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 75197, 75207);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1293_75212_75249(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 75212, 75249);
                    return return_v;
                }


                int
                f_1293_75197_75250(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 75197, 75250);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 74863, 75277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 74863, 75277);
            }
        }

        internal void AddOrSetProperty(PSNoteProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 75289, 75678);
                System.Management.Automation.PSMemberInfo memberInfo = default(System.Management.Automation.PSMemberInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 75369, 75667) || true) && (f_1293_75373_75461(this, f_1293_75418_75431(property), out memberInfo) && (DynAbs.Tracing.TraceSender.Expression_True(1293, 75373, 75493) && memberInfo is PSPropertyInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 75369, 75667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 75527, 75561);

                    memberInfo.Value = f_1293_75546_75560(property);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 75369, 75667);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 75369, 75667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 75627, 75652);

                    f_1293_75627_75651(f_1293_75627_75637(), property);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 75369, 75667);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 75289, 75678);

                string
                f_1293_75418_75431(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 75418, 75431);
                    return return_v;
                }


                bool
                f_1293_75373_75461(System.Management.Automation.PSObject
                value, string
                memberName, out System.Management.Automation.PSMemberInfo
                memberInfo)
                {
                    var return_v = PSGetMemberBinder.TryGetInstanceMember((object)value, memberName, out memberInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 75373, 75461);
                    return return_v;
                }


                object
                f_1293_75546_75560(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 75546, 75560);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_75627_75637()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 75627, 75637);
                    return return_v;
                }


                int
                f_1293_75627_75651(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 75627, 75651);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 75289, 75678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 75289, 75678);
            }
        }

        public const string
        AdaptedMemberSetName = "psadapted"
        ;

        public const string
        ExtendedMemberSetName = "psextended"
        ;

        public const string
        BaseObjectMemberSetName = "psbase"
        ;

        internal const string
        PSObjectMemberSetName = "psobject"
        ;

        internal const string
        PSTypeNames = "pstypenames"
        ;

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 77655, 78418);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 77763, 77881) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 77763, 77881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 77813, 77866);

                    throw f_1293_77819_77865("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 77763, 77881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 77986, 78011);

                string
                serializedContent
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 78025, 78348) || true) && (f_1293_78029_78060(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 78025, 78348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 78094, 78140);

                    PSObject
                    serializeTarget = f_1293_78121_78139(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 78158, 78218);

                    serializedContent = f_1293_78178_78217(serializeTarget);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 78025, 78348);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 78025, 78348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 78284, 78333);

                    serializedContent = f_1293_78304_78332(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 78025, 78348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 78364, 78407);

                f_1293_78364_78406(
                            info, "CliXml", serializedContent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 77655, 78418);

                System.Management.Automation.PSArgumentNullException
                f_1293_77819_77865(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 77819, 77865);
                    return return_v;
                }


                bool
                f_1293_78029_78060(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObjectIsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 78029, 78060);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1293_78121_78139(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 78121, 78139);
                    return return_v;
                }


                string
                f_1293_78178_78217(System.Management.Automation.PSObject
                source)
                {
                    var return_v = PSSerializer.Serialize((object)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 78178, 78217);
                    return return_v;
                }


                string
                f_1293_78304_78332(System.Management.Automation.PSObject
                source)
                {
                    var return_v = PSSerializer.Serialize((object)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 78304, 78332);
                    return return_v;
                }


                int
                f_1293_78364_78406(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 78364, 78406);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 77655, 78418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 77655, 78418);
            }
        }

        internal static object GetNoteSettingValue(PSMemberSet settings, string noteName,
                    object defaultValue, Type expectedType,
                    bool shouldReplicateInstance, PSObject ownerObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 78982, 79843);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79206, 79295) || true) && (settings == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 79206, 79295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79260, 79280);

                    return defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 79206, 79295);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79311, 79427) || true) && (shouldReplicateInstance)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 79311, 79427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79372, 79412);

                    f_1293_79372_79411(settings, ownerObject);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 79311, 79427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79443, 79510);

                PSNoteProperty
                note = f_1293_79465_79491(f_1293_79465_79481(settings), noteName) as PSNoteProperty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79524, 79609) || true) && (note == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 79524, 79609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79574, 79594);

                    return defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 79524, 79609);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79625, 79655);

                object
                noteValue = f_1293_79644_79654(note)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79669, 79798) || true) && (noteValue == null || (DynAbs.Tracing.TraceSender.Expression_False(1293, 79673, 79729) || f_1293_79694_79713(noteValue) != expectedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 79669, 79798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79763, 79783);

                    return defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 79669, 79798);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79814, 79832);

                return f_1293_79821_79831(note);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 78982, 79843);

                int
                f_1293_79372_79411(System.Management.Automation.PSMemberSet
                this_param, System.Management.Automation.PSObject
                particularInstance)
                {
                    this_param.ReplicateInstance((object)particularInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 79372, 79411);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1293_79465_79481(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 79465, 79481);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1293_79465_79491(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 79465, 79491);
                    return return_v;
                }


                object
                f_1293_79644_79654(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 79644, 79654);
                    return return_v;
                }


                System.Type
                f_1293_79694_79713(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 79694, 79713);
                    return return_v;
                }


                object
                f_1293_79821_79831(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 79821, 79831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 78982, 79843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 78982, 79843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetSerializationDepth(TypeTable backupTypeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 79855, 80426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79941, 79956);

                int
                result = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 79972, 80033);

                TypeTable
                typeTable = backupTypeTable ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Runspaces.TypeTable>(1293, 79994, 80032) ?? f_1293_80013_80032(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 80047, 80385) || true) && (typeTable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 80047, 80385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 80102, 80241);

                    PSMemberSet
                    standardMemberSet = f_1293_80134_80240(this, typeTable, TypeTable.PSStandardMembers)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 80259, 80370);

                    result = (int)f_1293_80273_80369(standardMemberSet, TypeTable.SerializationDepth, 0, typeof(int), true, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 80047, 80385);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 80401, 80415);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 79855, 80426);

                System.Management.Automation.Runspaces.TypeTable
                f_1293_80013_80032(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 80013, 80032);
                    return return_v;
                }


                System.Management.Automation.PSMemberSet
                f_1293_80134_80240(System.Management.Automation.PSObject
                msjObj, System.Management.Automation.Runspaces.TypeTable
                typeTableToUse, string
                name)
                {
                    var return_v = TypeTableGetMemberDelegate<PSMemberSet>(msjObj, typeTableToUse, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 80134, 80240);
                    return return_v;
                }


                object
                f_1293_80273_80369(System.Management.Automation.PSMemberSet
                settings, string
                noteName, int
                defaultValue, System.Type
                expectedType, bool
                shouldReplicateInstance, System.Management.Automation.PSObject
                ownerObject)
                {
                    var return_v = GetNoteSettingValue(settings, noteName, (object)defaultValue, expectedType, shouldReplicateInstance, ownerObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 80273, 80369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 79855, 80426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 79855, 80426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSPropertyInfo GetStringSerializationSource(TypeTable backupTypeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 80798, 81060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 80902, 81003);

                PSMemberInfo
                result = f_1293_80924_81002(this, backupTypeTable, TypeTable.StringSerializationSource)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 81017, 81049);

                return result as PSPropertyInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 80798, 81060);

                System.Management.Automation.PSMemberInfo
                f_1293_80924_81002(System.Management.Automation.PSObject
                this_param, System.Management.Automation.Runspaces.TypeTable
                backupTypeTable, string
                memberName)
                {
                    var return_v = this_param.GetPSStandardMember(backupTypeTable, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 80924, 81002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 80798, 81060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 80798, 81060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SerializationMethod GetSerializationMethod(TypeTable backupTypeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 81432, 82168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 81535, 81601);

                SerializationMethod
                result = TypeTable.DefaultSerializationMethod
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 81617, 81678);

                TypeTable
                typeTable = backupTypeTable ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Runspaces.TypeTable>(1293, 81639, 81677) ?? f_1293_81658_81677(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 81692, 82127) || true) && (typeTable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 81692, 82127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 81747, 81886);

                    PSMemberSet
                    standardMemberSet = f_1293_81779_81885(this, typeTable, TypeTable.PSStandardMembers)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 81904, 82112);

                    result = (SerializationMethod)f_1293_81934_82111(standardMemberSet, TypeTable.SerializationMethodNode, TypeTable.DefaultSerializationMethod, typeof(SerializationMethod), true, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 81692, 82127);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82143, 82157);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 81432, 82168);

                System.Management.Automation.Runspaces.TypeTable
                f_1293_81658_81677(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 81658, 81677);
                    return return_v;
                }


                System.Management.Automation.PSMemberSet
                f_1293_81779_81885(System.Management.Automation.PSObject
                msjObj, System.Management.Automation.Runspaces.TypeTable
                typeTableToUse, string
                name)
                {
                    var return_v = TypeTableGetMemberDelegate<PSMemberSet>(msjObj, typeTableToUse, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 81779, 81885);
                    return return_v;
                }


                object
                f_1293_81934_82111(System.Management.Automation.PSMemberSet
                settings, string
                noteName, System.Management.Automation.SerializationMethod
                defaultValue, System.Type
                expectedType, bool
                shouldReplicateInstance, System.Management.Automation.PSObject
                ownerObject)
                {
                    var return_v = GetNoteSettingValue(settings, noteName, (object)defaultValue, expectedType, shouldReplicateInstance, ownerObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 81934, 82111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 81432, 82168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 81432, 82168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSMemberSet PSStandardMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 82243, 82730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82279, 82367);

                    var
                    retVal = f_1293_82292_82366(this, TypeTable.PSStandardMembers)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82385, 82589) || true) && (retVal != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 82385, 82589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82445, 82481);

                        retVal = (PSMemberSet)f_1293_82467_82480(retVal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82503, 82534);

                        f_1293_82503_82533(retVal, this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82556, 82570);

                        return retVal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 82385, 82589);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82609, 82683);

                    retVal = f_1293_82618_82667(f_1293_82618_82638(this), TypeTable.PSStandardMembers) as PSMemberSet;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82701, 82715);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 82243, 82730);

                    System.Management.Automation.PSMemberSet
                    f_1293_82292_82366(System.Management.Automation.PSObject
                    msjObj, string
                    name)
                    {
                        var return_v = TypeTableGetMemberDelegate<PSMemberSet>(msjObj, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 82292, 82366);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfo
                    f_1293_82467_82480(System.Management.Automation.PSMemberSet
                    this_param)
                    {
                        var return_v = this_param.Copy();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 82467, 82480);
                        return return_v;
                    }


                    int
                    f_1293_82503_82533(System.Management.Automation.PSMemberSet
                    this_param, System.Management.Automation.PSObject
                    particularInstance)
                    {
                        this_param.ReplicateInstance((object)particularInstance);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 82503, 82533);
                        return 0;
                    }


                    System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                    f_1293_82618_82638(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.InstanceMembers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 82618, 82638);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfo
                    f_1293_82618_82667(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 82618, 82667);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 82180, 82741);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 82180, 82741);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PSMemberInfo GetPSStandardMember(TypeTable backupTypeTable, string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 82753, 83794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82865, 82892);

                PSMemberInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82908, 82969);

                TypeTable
                typeTable = backupTypeTable ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Runspaces.TypeTable>(1293, 82930, 82968) ?? f_1293_82949_82968(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 82983, 83690) || true) && (typeTable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 82983, 83690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 83038, 83178);

                    PSMemberSet
                    standardMemberSet = f_1293_83070_83177(this, typeTable, TypeTable.PSStandardMembers)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 83196, 83675) || true) && (standardMemberSet != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 83196, 83675);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 83267, 83309);

                        f_1293_83267_83308(standardMemberSet, this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 83331, 83605);

                        PSMemberInfoIntegratingCollection<PSMemberInfo>
                        members =
                        f_1293_83414_83604(standardMemberSet, f_1293_83544_83603(PSMemberViewTypes.All, backupTypeTable))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 83627, 83656);

                        result = f_1293_83636_83655(members, memberName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 83196, 83675);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 82983, 83690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 83706, 83783);

                return result ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSMemberInfo>(1293, 83713, 83782) ?? f_1293_83723_83767(f_1293_83723_83738(), TypeTable.PSStandardMembers) as PSMemberSet);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 82753, 83794);

                System.Management.Automation.Runspaces.TypeTable
                f_1293_82949_82968(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 82949, 82968);
                    return return_v;
                }


                System.Management.Automation.PSMemberSet
                f_1293_83070_83177(System.Management.Automation.PSObject
                msjObj, System.Management.Automation.Runspaces.TypeTable
                typeTableToUse, string
                name)
                {
                    var return_v = TypeTableGetMemberDelegate<PSMemberSet>(msjObj, typeTableToUse, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 83070, 83177);
                    return return_v;
                }


                int
                f_1293_83267_83308(System.Management.Automation.PSMemberSet
                this_param, System.Management.Automation.PSObject
                particularInstance)
                {
                    this_param.ReplicateInstance((object)particularInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 83267, 83308);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                f_1293_83544_83603(System.Management.Automation.PSMemberViewTypes
                viewType, System.Management.Automation.Runspaces.TypeTable
                backupTypeTable)
                {
                    var return_v = GetMemberCollection(viewType, backupTypeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 83544, 83603);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>
                f_1293_83414_83604(System.Management.Automation.PSMemberSet
                owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                collections)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>((object)owner, collections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 83414, 83604);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1293_83636_83655(System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 83636, 83655);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1293_83723_83738()
                {
                    var return_v = InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 83723, 83738);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1293_83723_83767(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 83723, 83767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 82753, 83794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 82753, 83794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Type GetTargetTypeForDeserialization(TypeTable backupTypeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 84273, 84536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 84370, 84478);

                PSMemberInfo
                targetType = f_1293_84396_84477(this, backupTypeTable, TypeTable.TargetTypeForDeserialization)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 84492, 84525);

                return f_1293_84499_84516_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(targetType, 1293, 84499, 84516)?.Value) as Type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 84273, 84536);

                System.Management.Automation.PSMemberInfo
                f_1293_84396_84477(System.Management.Automation.PSObject
                this_param, System.Management.Automation.Runspaces.TypeTable
                backupTypeTable, string
                memberName)
                {
                    var return_v = this_param.GetPSStandardMember(backupTypeTable, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 84396, 84477);
                    return return_v;
                }


                object
                f_1293_84499_84516_M(object
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 84499, 84516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 84273, 84536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 84273, 84536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> GetSpecificPropertiesToSerialize(TypeTable backupTypeTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 85052, 85496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 85164, 85225);

                TypeTable
                typeTable = backupTypeTable ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Runspaces.TypeTable>(1293, 85186, 85224) ?? f_1293_85205_85224(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 85239, 85419) || true) && (typeTable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 85239, 85419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 85294, 85375);

                    Collection<string>
                    tmp = f_1293_85319_85374(typeTable, f_1293_85351_85373(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 85393, 85404);

                    return tmp;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 85239, 85419);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 85435, 85485);

                return f_1293_85442_85484(f_1293_85465_85483());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 85052, 85496);

                System.Management.Automation.Runspaces.TypeTable
                f_1293_85205_85224(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 85205, 85224);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_85351_85373(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 85351, 85373);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1293_85319_85374(System.Management.Automation.Runspaces.TypeTable
                this_param, System.Management.Automation.Runspaces.ConsolidatedString
                types)
                {
                    var return_v = this_param.GetSpecificProperties(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 85319, 85374);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1293_85465_85483()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 85465, 85483);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1293_85442_85484(System.Collections.Generic.List<string>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>((System.Collections.Generic.IList<string>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 85442, 85484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 85052, 85496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 85052, 85496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ShouldSerializeAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 85508, 85745);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 85571, 85678) || true) && (f_1293_85575_85594(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 85571, 85678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 85628, 85663);

                    return f_1293_85635_85654(this) != null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 85571, 85678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 85694, 85734);

                return f_1293_85701_85733_M(!this.ImmediateBaseObjectIsEmpty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 85508, 85745);

                bool
                f_1293_85575_85594(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.IsDeserialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 85575, 85594);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_85635_85654(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 85635, 85654);
                    return return_v;
                }


                bool
                f_1293_85701_85733_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 85701, 85733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 85508, 85745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 85508, 85745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSMemberInfoInternalCollection<PSPropertyInfo> GetAdaptedProperties()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 85757, 85935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 85860, 85924);

                return f_1293_85867_85923(this, f_1293_85881_85900(this), f_1293_85902_85922(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 85757, 85935);

                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_85881_85900(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 85881, 85900);
                    return return_v;
                }


                System.Management.Automation.Adapter
                f_1293_85902_85922(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 85902, 85922);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_85867_85923(System.Management.Automation.PSObject
                this_param, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                serializedMembers, System.Management.Automation.Adapter
                particularAdapter)
                {
                    var return_v = this_param.GetProperties(serializedMembers, particularAdapter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 85867, 85923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 85757, 85935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 85757, 85935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSMemberInfoInternalCollection<PSPropertyInfo> GetProperties(PSMemberInfoInternalCollection<PSPropertyInfo> serializedMembers, Adapter particularAdapter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 85947, 86599);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86133, 86230) || true) && (f_1293_86137_86156(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 86133, 86230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86190, 86215);

                    return serializedMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 86133, 86230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86246, 86360);

                PSMemberInfoInternalCollection<PSPropertyInfo>
                returnValue = f_1293_86307_86359()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86376, 86553);
                    foreach (PSPropertyInfo member in f_1293_86410_86480_I(f_1293_86410_86480(particularAdapter, _immediateBaseObject)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 86376, 86553);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86514, 86538);

                        f_1293_86514_86537(returnValue, member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 86376, 86553);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86569, 86588);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 85947, 86599);

                bool
                f_1293_86137_86156(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.IsDeserialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 86137, 86156);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_86307_86359()
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 86307, 86359);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_86410_86480(System.Management.Automation.Adapter
                this_param, object
                obj)
                {
                    var return_v = this_param.BaseGetMembers<System.Management.Automation.PSPropertyInfo>(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 86410, 86480);
                    return return_v;
                }


                int
                f_1293_86514_86537(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSPropertyInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 86514, 86537);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_86410_86480_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 86410, 86480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 85947, 86599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 85947, 86599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void CopyDeserializerFields(PSObject source, PSObject target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 86611, 87202);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86713, 86954) || true) && (f_1293_86717_86739_M(!target.IsDeserialized))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 86713, 86954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86773, 86819);

                    target.IsDeserialized = f_1293_86797_86818(source);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86837, 86883);

                    target.AdaptedMembers = f_1293_86861_86882(source);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86901, 86939);

                    target.ClrMembers = f_1293_86921_86938(source);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 86713, 86954);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 86970, 87191) || true) && (f_1293_86974_87008(target) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 86970, 87191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 87050, 87122);

                    target.ToStringFromDeserialization = f_1293_87087_87121(source);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 87140, 87176);

                    target.TokenText = f_1293_87159_87175(source);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 86970, 87191);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 86611, 87202);

                bool
                f_1293_86717_86739_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 86717, 86739);
                    return return_v;
                }


                bool
                f_1293_86797_86818(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.IsDeserialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 86797, 86818);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_86861_86882(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 86861, 86882);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_86921_86938(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ClrMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 86921, 86938);
                    return return_v;
                }


                string
                f_1293_86974_87008(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToStringFromDeserialization;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 86974, 87008);
                    return return_v;
                }


                string
                f_1293_87087_87121(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToStringFromDeserialization;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 87087, 87121);
                    return return_v;
                }


                string
                f_1293_87159_87175(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TokenText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 87159, 87175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 86611, 87202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 86611, 87202);
            }
        }

        internal void SetCoreOnDeserialization(object value, bool overrideTypeInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 87538, 88186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 87638, 87754);

                f_1293_87638_87753(f_1293_87657_87688(this), "BaseObject should be PSCustomObject for deserialized objects");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 87768, 87834);

                f_1293_87768_87833(value != null, "known objects are never null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 87848, 87888);

                this.ImmediateBaseObjectIsEmpty = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 87902, 87931);

                _immediateBaseObject = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 87945, 88014);

                _adapterSet = f_1293_87959_88013(_immediateBaseObject, f_1293_87998_88012(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 88028, 88175) || true) && (overrideTypeInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 88028, 88175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 88082, 88160);

                    this.InternalTypeNames = f_1293_88107_88159(f_1293_88107_88127(this), value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 88028, 88175);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 87538, 88186);

                bool
                f_1293_87657_87688(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObjectIsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 87657, 87688);
                    return return_v;
                }


                int
                f_1293_87638_87753(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 87638, 87753);
                    return 0;
                }


                int
                f_1293_87768_87833(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 87768, 87833);
                    return 0;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1293_87998_88012(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 87998, 88012);
                    return return_v;
                }


                System.Management.Automation.PSObject.AdapterSet
                f_1293_87959_88013(object
                obj, System.Management.Automation.Runspaces.TypeTable
                typeTable)
                {
                    var return_v = GetMappedAdapter(obj, typeTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 87959, 88013);
                    return return_v;
                }


                System.Management.Automation.Adapter
                f_1293_88107_88127(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 88107, 88127);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1293_88107_88159(System.Management.Automation.Adapter
                this_param, object
                obj)
                {
                    var return_v = this_param.BaseGetTypeNameHierarchy(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 88107, 88159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 87538, 88186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 87538, 88186);
            }
        }
        internal class AdapterSet
        {
            internal Adapter OriginalAdapter { get; set; }

            internal DotNetAdapter DotNetAdapter { get; }

            internal AdapterSet(Adapter adapter, DotNetAdapter dotnetAdapter)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1293, 90030, 90217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 89845, 89891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 89907, 89952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 90128, 90154);

                    OriginalAdapter = adapter;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 90172, 90202);

                    DotNetAdapter = dotnetAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1293, 90030, 90217);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 90030, 90217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 90030, 90217);
                }
            }

            static AdapterSet()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1293, 89409, 90254);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1293, 89409, 90254);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 89409, 90254);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1293, 89409, 90254);
        }
        internal class PSDynamicMetaObject : DynamicMetaObject
        {
            internal PSDynamicMetaObject(Expression expression, PSObject value)
            : base(f_1293_90490_90500_C(expression), BindingRestrictions.Empty, value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1293, 90398, 90565);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1293, 90398, 90565);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 90398, 90565);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 90398, 90565);
                }
            }

            private new PSObject Value
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 90608, 90631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 90611, 90631);
                        return (PSObject)DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Value, 1293, 90621, 90631);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 90608, 90631);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 90608, 90631);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 90608, 90631);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private DynamicMetaObject GetUnwrappedObject()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 90648, 90882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 90727, 90867);

                    return f_1293_90734_90866(f_1293_90756_90824(CachedReflectionInfo.PSObject_Base, f_1293_90808_90823(this)), f_1293_90826_90843(this), f_1293_90845_90865(f_1293_90859_90864()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 90648, 90882);

                    System.Linq.Expressions.Expression
                    f_1293_90808_90823(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 90808, 90823);
                        return return_v;
                    }


                    System.Linq.Expressions.MethodCallExpression
                    f_1293_90756_90824(System.Reflection.MethodInfo
                    method, System.Linq.Expressions.Expression
                    arg0)
                    {
                        var return_v = Expression.Call(method, arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 90756, 90824);
                        return return_v;
                    }


                    System.Dynamic.BindingRestrictions
                    f_1293_90826_90843(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.Restrictions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 90826, 90843);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1293_90859_90864()
                    {
                        var return_v = Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 90859, 90864);
                        return return_v;
                    }


                    object
                    f_1293_90845_90865(System.Management.Automation.PSObject
                    obj)
                    {
                        var return_v = PSObject.Base((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 90845, 90865);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_90734_90866(System.Linq.Expressions.MethodCallExpression
                    expression, System.Dynamic.BindingRestrictions
                    restrictions, object
                    value)
                    {
                        var return_v = new System.Dynamic.DynamicMetaObject((System.Linq.Expressions.Expression)expression, restrictions, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 90734, 90866);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 90648, 90882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 90648, 90882);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override IEnumerable<string> GetDynamicMemberNames()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 90898, 91062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 90990, 91047);

                    return (DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from member in Value.Members select member.Name, 1293, 90998, 91045));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 90898, 91062);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 90898, 91062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 90898, 91062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool MustDeferIDMOP()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 91078, 91288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 91140, 91178);

                    var
                    baseObject = f_1293_91157_91177(f_1293_91171_91176())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 91196, 91273);

                    return baseObject is IDynamicMetaObjectProvider && (DynAbs.Tracing.TraceSender.Expression_True(1293, 91203, 91272) && !(baseObject is PSObject));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 91078, 91288);

                    System.Management.Automation.PSObject
                    f_1293_91171_91176()
                    {
                        var return_v = Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 91171, 91176);
                        return return_v;
                    }


                    object
                    f_1293_91157_91177(System.Management.Automation.PSObject
                    obj)
                    {
                        var return_v = PSObject.Base((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 91157, 91177);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 91078, 91288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 91078, 91288);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private DynamicMetaObject DeferForIDMOP(DynamicMetaObjectBinder binder, params DynamicMetaObject[] args)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 91304, 92321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 91441, 91526);

                    f_1293_91441_91525(f_1293_91460_91476(this), "Defer only works for idmop wrapped PSObjects");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 91546, 91599);

                    Expression[]
                    exprs = new Expression[f_1293_91582_91593(args) + 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 91617, 91749);

                    BindingRestrictions
                    restrictions = (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 91652, 91698) || ((f_1293_91652_91669(this) == BindingRestrictions.Empty && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 91701, 91728)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 91731, 91748))) ? f_1293_91701_91728(this) : f_1293_91731_91748(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 91769, 91870);

                    exprs[0] = f_1293_91780_91869(CachedReflectionInfo.PSObject_Base, f_1293_91832_91868(f_1293_91832_91847(this), typeof(object)));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 91897, 91902);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 91888, 92182) || true) && (i < f_1293_91908_91919(args))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 91921, 91924)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 91888, 92182))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 91888, 92182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 91966, 92000);

                            exprs[i + 1] = f_1293_91981_91999(args[i]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 92022, 92163);

                            restrictions = f_1293_92037_92162(restrictions, (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 92056, 92105) || ((f_1293_92056_92076(args[i]) == BindingRestrictions.Empty && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 92108, 92138)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 92141, 92161))) ? f_1293_92108_92138(args[i]) : f_1293_92141_92161(args[i]));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 295);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 92202, 92306);

                    return f_1293_92209_92305(f_1293_92231_92290(binder, f_1293_92265_92282(binder), exprs), restrictions);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 91304, 92321);

                    bool
                    f_1293_91460_91476(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 91460, 91476);
                        return return_v;
                    }


                    int
                    f_1293_91441_91525(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 91441, 91525);
                        return 0;
                    }


                    int
                    f_1293_91582_91593(System.Dynamic.DynamicMetaObject[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 91582, 91593);
                        return return_v;
                    }


                    System.Dynamic.BindingRestrictions
                    f_1293_91652_91669(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.Restrictions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 91652, 91669);
                        return return_v;
                    }


                    System.Dynamic.BindingRestrictions
                    f_1293_91701_91728(System.Management.Automation.PSObject.PSDynamicMetaObject
                    obj)
                    {
                        var return_v = obj.PSGetTypeRestriction();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 91701, 91728);
                        return return_v;
                    }


                    System.Dynamic.BindingRestrictions
                    f_1293_91731_91748(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.Restrictions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 91731, 91748);
                        return return_v;
                    }


                    System.Linq.Expressions.Expression
                    f_1293_91832_91847(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 91832, 91847);
                        return return_v;
                    }


                    System.Linq.Expressions.Expression
                    f_1293_91832_91868(System.Linq.Expressions.Expression
                    expr, System.Type
                    type)
                    {
                        var return_v = expr.Cast(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 91832, 91868);
                        return return_v;
                    }


                    System.Linq.Expressions.MethodCallExpression
                    f_1293_91780_91869(System.Reflection.MethodInfo
                    method, System.Linq.Expressions.Expression
                    arg0)
                    {
                        var return_v = Expression.Call(method, arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 91780, 91869);
                        return return_v;
                    }


                    int
                    f_1293_91908_91919(System.Dynamic.DynamicMetaObject[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 91908, 91919);
                        return return_v;
                    }


                    System.Linq.Expressions.Expression
                    f_1293_91981_91999(System.Dynamic.DynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 91981, 91999);
                        return return_v;
                    }


                    System.Dynamic.BindingRestrictions
                    f_1293_92056_92076(System.Dynamic.DynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.Restrictions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 92056, 92076);
                        return return_v;
                    }


                    System.Dynamic.BindingRestrictions
                    f_1293_92108_92138(System.Dynamic.DynamicMetaObject
                    obj)
                    {
                        var return_v = obj.PSGetTypeRestriction();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 92108, 92138);
                        return return_v;
                    }


                    System.Dynamic.BindingRestrictions
                    f_1293_92141_92161(System.Dynamic.DynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.Restrictions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 92141, 92161);
                        return return_v;
                    }


                    System.Dynamic.BindingRestrictions
                    f_1293_92037_92162(System.Dynamic.BindingRestrictions
                    this_param, System.Dynamic.BindingRestrictions
                    restrictions)
                    {
                        var return_v = this_param.Merge(restrictions);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 92037, 92162);
                        return return_v;
                    }


                    System.Type
                    f_1293_92265_92282(System.Dynamic.DynamicMetaObjectBinder
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 92265, 92282);
                        return return_v;
                    }


                    System.Linq.Expressions.DynamicExpression
                    f_1293_92231_92290(System.Dynamic.DynamicMetaObjectBinder
                    binder, System.Type
                    returnType, params System.Linq.Expressions.Expression[]
                    arguments)
                    {
                        var return_v = DynamicExpression.Dynamic((System.Runtime.CompilerServices.CallSiteBinder)binder, returnType, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 92231, 92290);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_92209_92305(System.Linq.Expressions.DynamicExpression
                    expression, System.Dynamic.BindingRestrictions
                    restrictions)
                    {
                        var return_v = new System.Dynamic.DynamicMetaObject((System.Linq.Expressions.Expression)expression, restrictions);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 92209, 92305);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 91304, 92321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 91304, 92321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 92337, 92691);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 92476, 92591) || true) && (f_1293_92480_92496(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 92476, 92591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 92538, 92572);

                        return f_1293_92545_92571(this, binder, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 92476, 92591);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 92611, 92676);

                    return f_1293_92618_92675(binder, f_1293_92649_92669(this), arg);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 92337, 92691);

                    bool
                    f_1293_92480_92496(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 92480, 92496);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_92545_92571(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.BinaryOperationBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 92545, 92571);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_92649_92669(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.GetUnwrappedObject();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 92649, 92669);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_92618_92675(System.Dynamic.BinaryOperationBinder
                    this_param, System.Dynamic.DynamicMetaObject
                    target, System.Dynamic.DynamicMetaObject
                    arg)
                    {
                        var return_v = this_param.FallbackBinaryOperation(target, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 92618, 92675);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 92337, 92691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 92337, 92691);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindConvert(ConvertBinder binder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 92707, 93437);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 92807, 92917) || true) && (f_1293_92811_92827(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 92807, 92917);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 92869, 92898);

                        return f_1293_92876_92897(this, binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 92807, 92917);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 93386, 93422);

                    return f_1293_93393_93421(binder, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 92707, 93437);

                    bool
                    f_1293_92811_92827(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 92811, 92827);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_92876_92897(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.ConvertBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 92876, 92897);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_93393_93421(System.Dynamic.ConvertBinder
                    this_param, System.Management.Automation.PSObject.PSDynamicMetaObject
                    target)
                    {
                        var return_v = this_param.FallbackConvert((System.Dynamic.DynamicMetaObject)target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 93393, 93421);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 92707, 93437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 92707, 93437);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 93453, 93809);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 93590, 93709) || true) && (f_1293_93594_93610(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 93590, 93709);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 93652, 93690);

                        return f_1293_93659_93689(this, binder, indexes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 93590, 93709);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 93729, 93794);

                    return f_1293_93736_93793(binder, f_1293_93763_93783(this), indexes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 93453, 93809);

                    bool
                    f_1293_93594_93610(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 93594, 93610);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_93659_93689(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.DeleteIndexBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 93659, 93689);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_93763_93783(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.GetUnwrappedObject();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 93763, 93783);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_93736_93793(System.Dynamic.DeleteIndexBinder
                    this_param, System.Dynamic.DynamicMetaObject
                    target, System.Dynamic.DynamicMetaObject[]
                    indexes)
                    {
                        var return_v = this_param.FallbackDeleteIndex(target, indexes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 93736, 93793);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 93453, 93809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 93453, 93809);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 93825, 94137);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 93935, 94045) || true) && (f_1293_93939_93955(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 93935, 94045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 93997, 94026);

                        return f_1293_94004_94025(this, binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 93935, 94045);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 94065, 94122);

                    return f_1293_94072_94121(binder, f_1293_94100_94120(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 93825, 94137);

                    bool
                    f_1293_93939_93955(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 93939, 93955);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_94004_94025(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.DeleteMemberBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94004, 94025);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_94100_94120(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.GetUnwrappedObject();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94100, 94120);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_94072_94121(System.Dynamic.DeleteMemberBinder
                    this_param, System.Dynamic.DynamicMetaObject
                    target)
                    {
                        var return_v = this_param.FallbackDeleteMember(target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94072, 94121);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 93825, 94137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 93825, 94137);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 94153, 94500);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 94284, 94403) || true) && (f_1293_94288_94304(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 94284, 94403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 94346, 94384);

                        return f_1293_94353_94383(this, binder, indexes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 94284, 94403);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 94423, 94485);

                    return f_1293_94430_94484(binder, f_1293_94454_94474(this), indexes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 94153, 94500);

                    bool
                    f_1293_94288_94304(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94288, 94304);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_94353_94383(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.GetIndexBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94353, 94383);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_94454_94474(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.GetUnwrappedObject();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94454, 94474);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_94430_94484(System.Dynamic.GetIndexBinder
                    this_param, System.Dynamic.DynamicMetaObject
                    target, System.Dynamic.DynamicMetaObject[]
                    indexes)
                    {
                        var return_v = this_param.FallbackGetIndex(target, indexes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94430, 94484);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 94153, 94500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 94153, 94500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 94516, 94848);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 94640, 94756) || true) && (f_1293_94644_94660(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 94640, 94756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 94702, 94737);

                        return f_1293_94709_94736(this, binder, args);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 94640, 94756);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 94776, 94833);

                    return f_1293_94783_94832(binder, f_1293_94805_94825(this), args);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 94516, 94848);

                    bool
                    f_1293_94644_94660(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94644, 94660);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_94709_94736(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.InvokeBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94709, 94736);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_94805_94825(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.GetUnwrappedObject();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94805, 94825);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_94783_94832(System.Dynamic.InvokeBinder
                    this_param, System.Dynamic.DynamicMetaObject
                    target, System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.FallbackInvoke(target, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 94783, 94832);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 94516, 94848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 94516, 94848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 94864, 95267);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 95020, 95163) || true) && (f_1293_95024_95040(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 95020, 95163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 95082, 95144);

                        return f_1293_95089_95143(this, binder, f_1293_95111_95142(f_1293_95111_95132(indexes, value)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 95020, 95163);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 95183, 95252);

                    return f_1293_95190_95251(binder, f_1293_95214_95234(this), indexes, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 94864, 95267);

                    bool
                    f_1293_95024_95040(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95024, 95040);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Dynamic.DynamicMetaObject>
                    f_1293_95111_95132(System.Dynamic.DynamicMetaObject[]
                    source, System.Dynamic.DynamicMetaObject
                    element)
                    {
                        var return_v = source.Append<System.Dynamic.DynamicMetaObject>(element);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95111, 95132);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject[]
                    f_1293_95111_95142(System.Collections.Generic.IEnumerable<System.Dynamic.DynamicMetaObject>
                    source)
                    {
                        var return_v = source.ToArray<System.Dynamic.DynamicMetaObject>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95111, 95142);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_95089_95143(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.SetIndexBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95089, 95143);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_95214_95234(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.GetUnwrappedObject();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95214, 95234);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_95190_95251(System.Dynamic.SetIndexBinder
                    this_param, System.Dynamic.DynamicMetaObject
                    target, System.Dynamic.DynamicMetaObject[]
                    indexes, System.Dynamic.DynamicMetaObject
                    value)
                    {
                        var return_v = this_param.FallbackSetIndex(target, indexes, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95190, 95251);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 94864, 95267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 94864, 95267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 95283, 95601);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 95397, 95507) || true) && (f_1293_95401_95417(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 95397, 95507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 95459, 95488);

                        return f_1293_95466_95487(this, binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 95397, 95507);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 95527, 95586);

                    return f_1293_95534_95585(binder, f_1293_95564_95584(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 95283, 95601);

                    bool
                    f_1293_95401_95417(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95401, 95417);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_95466_95487(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.UnaryOperationBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95466, 95487);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_95564_95584(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.GetUnwrappedObject();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95564, 95584);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_95534_95585(System.Dynamic.UnaryOperationBinder
                    this_param, System.Dynamic.DynamicMetaObject
                    target)
                    {
                        var return_v = this_param.FallbackUnaryOperation(target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95534, 95585);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 95283, 95601);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 95283, 95601);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 95617, 96169);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 95753, 95869) || true) && (f_1293_95757_95773(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 95753, 95869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 95815, 95850);

                        return f_1293_95822_95849(this, binder, args);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 95753, 95869);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 95889, 96154);

                    return f_1293_95896_96153((binder as PSInvokeMemberBinder ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.PSInvokeMemberBinder>(1293, 95897, 96119) ?? (InvokeMemberBinder)(binder as PSInvokeBaseCtorBinder) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Dynamic.InvokeMemberBinder>(1293, 95956, 96119) ?? f_1293_96039_96119(f_1293_96064_96075(binder), f_1293_96077_96092(binder), false, false, null, null)))), this, args);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 95617, 96169);

                    bool
                    f_1293_95757_95773(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95757, 95773);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_95822_95849(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.InvokeMemberBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95822, 95849);
                        return return_v;
                    }


                    string
                    f_1293_96064_96075(System.Dynamic.InvokeMemberBinder
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 96064, 96075);
                        return return_v;
                    }


                    System.Dynamic.CallInfo
                    f_1293_96077_96092(System.Dynamic.InvokeMemberBinder
                    this_param)
                    {
                        var return_v = this_param.CallInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 96077, 96092);
                        return return_v;
                    }


                    System.Management.Automation.Language.PSInvokeMemberBinder
                    f_1293_96039_96119(string
                    memberName, System.Dynamic.CallInfo
                    callInfo, bool
                    @static, bool
                    propertySetter, System.Management.Automation.PSMethodInvocationConstraints
                    constraints, System.Type
                    classScope)
                    {
                        var return_v = PSInvokeMemberBinder.Get(memberName, callInfo, @static, propertySetter, constraints, classScope);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 96039, 96119);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_95896_96153(System.Dynamic.InvokeMemberBinder
                    this_param, System.Management.Automation.PSObject.PSDynamicMetaObject
                    target, System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.FallbackInvokeMember((System.Dynamic.DynamicMetaObject)target, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 95896, 96153);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 95617, 96169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 95617, 96169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 96185, 96552);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 96289, 96399) || true) && (f_1293_96293_96309(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 96289, 96399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 96351, 96380);

                        return f_1293_96358_96379(this, binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 96289, 96399);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 96419, 96537);

                    return f_1293_96426_96536((binder as PSGetMemberBinder ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.PSGetMemberBinder>(1293, 96427, 96511) ?? f_1293_96458_96511(f_1293_96480_96491(binder), null, false))), this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 96185, 96552);

                    bool
                    f_1293_96293_96309(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 96293, 96309);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_96358_96379(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.GetMemberBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 96358, 96379);
                        return return_v;
                    }


                    string
                    f_1293_96480_96491(System.Dynamic.GetMemberBinder
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 96480, 96491);
                        return return_v;
                    }


                    System.Management.Automation.Language.PSGetMemberBinder
                    f_1293_96458_96511(string
                    memberName, System.Type
                    classScope, bool
                    @static)
                    {
                        var return_v = PSGetMemberBinder.Get(memberName, classScope, @static);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 96458, 96511);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_96426_96536(System.Management.Automation.Language.PSGetMemberBinder
                    this_param, System.Management.Automation.PSObject.PSDynamicMetaObject
                    target)
                    {
                        var return_v = this_param.FallbackGetMember((System.Dynamic.DynamicMetaObject)target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 96426, 96536);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 96185, 96552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 96185, 96552);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 96568, 96974);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 96697, 96814) || true) && (f_1293_96701_96717(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 96697, 96814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 96759, 96795);

                        return f_1293_96766_96794(this, binder, value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 96697, 96814);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 96834, 96959);

                    return f_1293_96841_96958((binder as PSSetMemberBinder ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.PSSetMemberBinder>(1293, 96842, 96926) ?? f_1293_96873_96926(f_1293_96895_96906(binder), null, false))), this, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 96568, 96974);

                    bool
                    f_1293_96701_96717(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param)
                    {
                        var return_v = this_param.MustDeferIDMOP();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 96701, 96717);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_96766_96794(System.Management.Automation.PSObject.PSDynamicMetaObject
                    this_param, System.Dynamic.SetMemberBinder
                    binder, params System.Dynamic.DynamicMetaObject[]
                    args)
                    {
                        var return_v = this_param.DeferForIDMOP((System.Dynamic.DynamicMetaObjectBinder)binder, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 96766, 96794);
                        return return_v;
                    }


                    string
                    f_1293_96895_96906(System.Dynamic.SetMemberBinder
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 96895, 96906);
                        return return_v;
                    }


                    System.Management.Automation.Language.PSSetMemberBinder
                    f_1293_96873_96926(string
                    memberName, System.Type
                    classScope, bool
                    @static)
                    {
                        var return_v = PSSetMemberBinder.Get(memberName, classScope, @static);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 96873, 96926);
                        return return_v;
                    }


                    System.Dynamic.DynamicMetaObject
                    f_1293_96841_96958(System.Management.Automation.Language.PSSetMemberBinder
                    this_param, System.Management.Automation.PSObject.PSDynamicMetaObject
                    target, System.Dynamic.DynamicMetaObject
                    value)
                    {
                        var return_v = this_param.FallbackSetMember((System.Dynamic.DynamicMetaObject)target, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 96841, 96958);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 96568, 96974);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 96568, 96974);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static PSDynamicMetaObject()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1293, 90319, 96985);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1293, 90319, 96985);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 90319, 96985);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1293, 90319, 96985);

            static System.Linq.Expressions.Expression
            f_1293_90490_90500_C(System.Linq.Expressions.Expression
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1293, 90398, 90565);
                return return_v;
            }

        }

        DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 96997, 97161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 97102, 97150);

                return f_1293_97109_97149(parameter, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 96997, 97161);

                System.Management.Automation.PSObject.PSDynamicMetaObject
                f_1293_97109_97149(System.Linq.Expressions.Expression
                expression, System.Management.Automation.PSObject
                value)
                {
                    var return_v = new System.Management.Automation.PSObject.PSDynamicMetaObject(expression, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 97109, 97149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 96997, 97161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 96997, 97161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsDeserialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 97252, 97299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 97255, 97299);
                    return f_1293_97255_97299(_flags, PSObjectFlags.IsDeserialized);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 97252, 97299);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 97195, 97607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 97195, 97607);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 97314, 97596);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 97350, 97581) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 97350, 97581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 97401, 97440);

                        _flags |= PSObjectFlags.IsDeserialized;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 97350, 97581);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 97350, 97581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 97522, 97562);

                        _flags &= ~PSObjectFlags.IsDeserialized;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 97350, 97581);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 97314, 97596);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 97195, 97607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 97195, 97607);
                }
            }
        }

        private bool StoreTypeNameAndInstanceMembersLocally
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 97699, 97770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 97702, 97770);
                    return f_1293_97702_97770(_flags, PSObjectFlags.StoreTypeNameAndInstanceMembersLocally);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 97699, 97770);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 97619, 98126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 97619, 98126);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 97785, 98115);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 97821, 98100) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 97821, 98100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 97872, 97935);

                        _flags |= PSObjectFlags.StoreTypeNameAndInstanceMembersLocally;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 97821, 98100);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 97821, 98100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 98017, 98081);

                        _flags &= ~PSObjectFlags.StoreTypeNameAndInstanceMembersLocally;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 97821, 98100);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 97785, 98115);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 97619, 98126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 97619, 98126);
                }
            }
        }

        internal bool IsHelpObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 98193, 98238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 98196, 98238);
                    return f_1293_98196_98238(_flags, PSObjectFlags.IsHelpObject);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 98193, 98238);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 98138, 98542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 98138, 98542);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 98253, 98531);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 98289, 98516) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 98289, 98516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 98340, 98377);

                        _flags |= PSObjectFlags.IsHelpObject;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 98289, 98516);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 98289, 98516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 98459, 98497);

                        _flags &= ~PSObjectFlags.IsHelpObject;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 98289, 98516);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 98253, 98531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 98138, 98542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 98138, 98542);
                }
            }
        }

        internal bool HasGeneratedReservedMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 98624, 98684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 98627, 98684);
                    return f_1293_98627_98684(_flags, PSObjectFlags.HasGeneratedReservedMembers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 98624, 98684);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 98554, 99018);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 98554, 99018);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 98699, 99007);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 98735, 98992) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 98735, 98992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 98786, 98838);

                        _flags |= PSObjectFlags.HasGeneratedReservedMembers;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 98735, 98992);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 98735, 98992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 98920, 98973);

                        _flags &= ~PSObjectFlags.HasGeneratedReservedMembers;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 98735, 98992);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 98699, 99007);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 98554, 99018);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 98554, 99018);
                }
            }
        }

        internal bool ImmediateBaseObjectIsEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 99099, 99158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 99102, 99158);
                    return f_1293_99102_99158(_flags, PSObjectFlags.ImmediateBaseObjectIsEmpty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 99099, 99158);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 99030, 99490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 99030, 99490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 99173, 99479);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 99209, 99464) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 99209, 99464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 99260, 99311);

                        _flags |= PSObjectFlags.ImmediateBaseObjectIsEmpty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 99209, 99464);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 99209, 99464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 99393, 99445);

                        _flags &= ~PSObjectFlags.ImmediateBaseObjectIsEmpty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 99209, 99464);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 99173, 99479);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 99030, 99490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 99030, 99490);
                }
            }
        }

        internal string TokenText { get; set; }

        internal string ToStringFromDeserialization { get; set; }

        internal WriteStreamType WriteStream { get; set; }

        internal PSMemberInfoInternalCollection<PSPropertyInfo> AdaptedMembers { get; set; }

        internal static DotNetAdapter DotNetStaticAdapter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 100407, 100431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100410, 100431);
                    return s_dotNetStaticAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 100407, 100431);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 100407, 100431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 100407, 100431);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static PSTraceSource MemberResolution
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 100491, 100512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100494, 100512);
                    return s_memberResolution;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 100491, 100512);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 100491, 100512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 100491, 100512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PSMemberInfoInternalCollection<PSPropertyInfo> ClrMembers { get; set; }

        internal static DotNetAdapter DotNetInstanceAdapter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 100867, 100893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 100870, 100893);
                    return s_dotNetInstanceAdapter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 100867, 100893);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 100867, 100893);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 100867, 100893);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PSPropertyInfo GetFirstPropertyOrDefault(MemberNamePredicate predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 101042, 101202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 101147, 101191);

                return f_1293_101154_101190(f_1293_101154_101164(), predicate);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 101042, 101202);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1293_101154_101164()
                {
                    var return_v = Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 101154, 101164);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1293_101154_101190(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.FirstOrDefault(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 101154, 101190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 101042, 101202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 101042, 101202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Flags]
        private enum PSObjectFlags : byte
        {
            None = 0,

            /// <summary>
            /// This flag is set in deserialized shellobject.
            /// </summary>
            IsDeserialized = 0b00000001,

            /// <summary>
            /// Set to true when the BaseObject is PSCustomObject.
            /// </summary>
            HasGeneratedReservedMembers = 0b00000010,
            ImmediateBaseObjectIsEmpty = 0b00000100,
            IsHelpObject = 0b00001000,

            /// <summary>
            /// Indicate whether we store the instance members and type names locally
            /// for this PSObject instance.
            /// </summary>
            StoreTypeNameAndInstanceMembersLocally = 0b00010000,
        }

        static PSObject()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1293, 1472, 102007);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 19123, 19186);
            s_adapterMapping = f_1293_19142_19186();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 19252, 19596);
            s_adapterSetMappers = new List<Func<object, AdapterSet>>
                                                                                    {
                                                                                        (Func<object, AdapterSet>)(DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => 
                                                                                        (Func<object, AdapterSet>)MappedInternalAdapterSet,1293,19274,19596))
                                                                                    };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 27867, 28036);
            s_memberResolution = f_1293_27888_28036("MemberResolution", "Traces the resolution from member name to the member. A member can be a property, method, etc.", false);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 28122, 28207);
            s_typeNamesResurrectionTable = f_1293_28153_28207();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 28286, 28349);
            s_memberCollection = f_1293_28307_28349(PSMemberViewTypes.All);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 28426, 28468);
            s_methodCollection = f_1293_28447_28468();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 28547, 28614);
            s_propertyCollection = f_1293_28570_28614(PSMemberViewTypes.All);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 28665, 28710);
            s_dotNetInstanceAdapter = f_1293_28691_28710();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 28759, 28832);
            s_baseAdapterForAdaptedObjects = f_1293_28792_28832();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 28881, 28928);
            s_dotNetStaticAdapter = f_1293_28905_28928(true);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 28976, 29048);
            s_dotNetInstanceAdapterSet = f_1293_29005_29048(f_1293_29020_29041(), null);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 29094, 29164);
            s_mshMemberSetAdapter = f_1293_29118_29164(f_1293_29133_29157(), null);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 29210, 29274);
            s_mshObjectAdapter = f_1293_29231_29274(f_1293_29246_29267(), null);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 29329, 29647);
            s_cimInstanceAdapter = f_1293_29365_29647(f_1293_29389_29577(typeof(Microsoft.Management.Infrastructure.CimInstance), f_1293_29527_29576()), f_1293_29616_29646());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 29704, 29800);
            s_managementObjectAdapter = f_1293_29732_29800(f_1293_29747_29776(), f_1293_29778_29799());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 29846, 29941);
            s_managementClassAdapter = f_1293_29873_29941(f_1293_29888_29917(), f_1293_29919_29940());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 29987, 30079);
            s_directoryEntryAdapter = f_1293_30013_30079(f_1293_30028_30055(), f_1293_30057_30078());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 30133, 30228);
            s_dataRowViewAdapter = f_1293_30156_30228(f_1293_30171_30195(), s_baseAdapterForAdaptedObjects);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 30274, 30361);
            s_dataRowAdapter = f_1293_30293_30361(f_1293_30308_30328(), s_baseAdapterForAdaptedObjects);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 30407, 30494);
            s_xmlNodeAdapter = f_1293_30426_30494(f_1293_30441_30461(), s_baseAdapterForAdaptedObjects);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 40447, 40577);
            s_instanceMembersResurrectionTable = f_1293_40497_40577();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 76030, 76064);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 76339, 76375);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 76658, 76692);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 76947, 76981);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 77244, 77271);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1293, 1472, 102007);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 1472, 102007);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1293, 1472, 102007);

        static System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Management.Automation.PSObject.AdapterSet>
        f_1293_19142_19186()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Management.Automation.PSObject.AdapterSet>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 19142, 19186);
            return return_v;
        }


        int
        f_1293_24442_24491(System.Management.Automation.PSObject
        this_param, System.Management.Automation.PSCustomObject
        obj)
        {
            this_param.CommonInitialization((object)obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 24442, 24491);
            return 0;
        }


        System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
        f_1293_24910_24982(int
        capacity)
        {
            var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 24910, 24982);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1293_25627_25672(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 25627, 25672);
            return return_v;
        }


        int
        f_1293_25704_25729(System.Management.Automation.PSObject
        this_param, object
        obj)
        {
            this_param.CommonInitialization(obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 25704, 25729);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1293_26181_26227(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 26181, 26227);
            return return_v;
        }


        object?
        f_1293_26283_26322(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 26283, 26322);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1293_26415_26461(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 26415, 26461);
            return return_v;
        }


        object
        f_1293_26531_26571(string
        source)
        {
            var return_v = PSSerializer.Deserialize(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 26531, 26571);
            return return_v;
        }


        System.Management.Automation.PSObject
        f_1293_26511_26572(object
        obj)
        {
            var return_v = PSObject.AsPSObject(obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 26511, 26572);
            return return_v;
        }


        object
        f_1293_26608_26634(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.ImmediateBaseObject;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 26608, 26634);
            return return_v;
        }


        int
        f_1293_26587_26635(System.Management.Automation.PSObject
        this_param, object
        obj)
        {
            this_param.CommonInitialization(obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 26587, 26635);
            return 0;
        }


        int
        f_1293_26652_26704(System.Management.Automation.PSObject
        source, System.Management.Automation.PSObject
        target)
        {
            CopyDeserializerFields(source: source, target: target);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 26652, 26704);
            return 0;
        }


        object
        f_1293_27058_27070()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 27058, 27070);
            return return_v;
        }


        static System.Management.Automation.PSTraceSource
        f_1293_27888_28036(string
        name, string
        description, bool
        traceHeaders)
        {
            var return_v = PSTraceSource.GetTracer(name, description, traceHeaders);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 27888, 28036);
            return return_v;
        }


        static System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.Runspaces.ConsolidatedString>
        f_1293_28153_28207()
        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.Runspaces.ConsolidatedString>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 28153, 28207);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
        f_1293_28307_28349(System.Management.Automation.PSMemberViewTypes
        viewType)
        {
            var return_v = GetMemberCollection(viewType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 28307, 28349);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
        f_1293_28447_28468()
        {
            var return_v = GetMethodCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 28447, 28468);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
        f_1293_28570_28614(System.Management.Automation.PSMemberViewTypes
        viewType)
        {
            var return_v = GetPropertyCollection(viewType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 28570, 28614);
            return return_v;
        }


        static System.Management.Automation.DotNetAdapter
        f_1293_28691_28710()
        {
            var return_v = new System.Management.Automation.DotNetAdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 28691, 28710);
            return return_v;
        }


        static System.Management.Automation.BaseDotNetAdapterForAdaptedObjects
        f_1293_28792_28832()
        {
            var return_v = new System.Management.Automation.BaseDotNetAdapterForAdaptedObjects();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 28792, 28832);
            return return_v;
        }


        static System.Management.Automation.DotNetAdapter
        f_1293_28905_28928(bool
        isStatic)
        {
            var return_v = new System.Management.Automation.DotNetAdapter(isStatic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 28905, 28928);
            return return_v;
        }


        static System.Management.Automation.DotNetAdapter
        f_1293_29020_29041()
        {
            var return_v = DotNetInstanceAdapter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 29020, 29041);
            return return_v;
        }


        static System.Management.Automation.PSObject.AdapterSet
        f_1293_29005_29048(System.Management.Automation.DotNetAdapter
        adapter, System.Management.Automation.DotNetAdapter
        dotnetAdapter)
        {
            var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29005, 29048);
            return return_v;
        }


        static System.Management.Automation.PSMemberSetAdapter
        f_1293_29133_29157()
        {
            var return_v = new System.Management.Automation.PSMemberSetAdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29133, 29157);
            return return_v;
        }


        static System.Management.Automation.PSObject.AdapterSet
        f_1293_29118_29164(System.Management.Automation.PSMemberSetAdapter
        adapter, System.Management.Automation.DotNetAdapter
        dotnetAdapter)
        {
            var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29118, 29164);
            return return_v;
        }


        static System.Management.Automation.PSObjectAdapter
        f_1293_29246_29267()
        {
            var return_v = new System.Management.Automation.PSObjectAdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29246, 29267);
            return return_v;
        }


        static System.Management.Automation.PSObject.AdapterSet
        f_1293_29231_29274(System.Management.Automation.PSObjectAdapter
        adapter, System.Management.Automation.DotNetAdapter
        dotnetAdapter)
        {
            var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29231, 29274);
            return return_v;
        }


        static Microsoft.PowerShell.Cim.CimInstanceAdapter
        f_1293_29527_29576()
        {
            var return_v = new Microsoft.PowerShell.Cim.CimInstanceAdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29527, 29576);
            return return_v;
        }


        static System.Management.Automation.ThirdPartyAdapter
        f_1293_29389_29577(System.Type
        adaptedType, Microsoft.PowerShell.Cim.CimInstanceAdapter
        externalAdapter)
        {
            var return_v = new System.Management.Automation.ThirdPartyAdapter(adaptedType, (System.Management.Automation.PSPropertyAdapter)externalAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29389, 29577);
            return return_v;
        }


        static System.Management.Automation.DotNetAdapter
        f_1293_29616_29646()
        {
            var return_v = PSObject.DotNetInstanceAdapter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 29616, 29646);
            return return_v;
        }


        static System.Management.Automation.PSObject.AdapterSet
        f_1293_29365_29647(System.Management.Automation.ThirdPartyAdapter
        adapter, System.Management.Automation.DotNetAdapter
        dotnetAdapter)
        {
            var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29365, 29647);
            return return_v;
        }


        static System.Management.Automation.ManagementObjectAdapter
        f_1293_29747_29776()
        {
            var return_v = new System.Management.Automation.ManagementObjectAdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29747, 29776);
            return return_v;
        }


        static System.Management.Automation.DotNetAdapter
        f_1293_29778_29799()
        {
            var return_v = DotNetInstanceAdapter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 29778, 29799);
            return return_v;
        }


        static System.Management.Automation.PSObject.AdapterSet
        f_1293_29732_29800(System.Management.Automation.ManagementObjectAdapter
        adapter, System.Management.Automation.DotNetAdapter
        dotnetAdapter)
        {
            var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29732, 29800);
            return return_v;
        }


        static System.Management.Automation.ManagementClassApdapter
        f_1293_29888_29917()
        {
            var return_v = new System.Management.Automation.ManagementClassApdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29888, 29917);
            return return_v;
        }


        static System.Management.Automation.DotNetAdapter
        f_1293_29919_29940()
        {
            var return_v = DotNetInstanceAdapter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 29919, 29940);
            return return_v;
        }


        static System.Management.Automation.PSObject.AdapterSet
        f_1293_29873_29941(System.Management.Automation.ManagementClassApdapter
        adapter, System.Management.Automation.DotNetAdapter
        dotnetAdapter)
        {
            var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 29873, 29941);
            return return_v;
        }


        static System.Management.Automation.DirectoryEntryAdapter
        f_1293_30028_30055()
        {
            var return_v = new System.Management.Automation.DirectoryEntryAdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 30028, 30055);
            return return_v;
        }


        static System.Management.Automation.DotNetAdapter
        f_1293_30057_30078()
        {
            var return_v = DotNetInstanceAdapter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 30057, 30078);
            return return_v;
        }


        static System.Management.Automation.PSObject.AdapterSet
        f_1293_30013_30079(System.Management.Automation.DirectoryEntryAdapter
        adapter, System.Management.Automation.DotNetAdapter
        dotnetAdapter)
        {
            var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 30013, 30079);
            return return_v;
        }


        static System.Management.Automation.DataRowViewAdapter
        f_1293_30171_30195()
        {
            var return_v = new System.Management.Automation.DataRowViewAdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 30171, 30195);
            return return_v;
        }


        static System.Management.Automation.PSObject.AdapterSet
        f_1293_30156_30228(System.Management.Automation.DataRowViewAdapter
        adapter, System.Management.Automation.DotNetAdapter
        dotnetAdapter)
        {
            var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 30156, 30228);
            return return_v;
        }


        static System.Management.Automation.DataRowAdapter
        f_1293_30308_30328()
        {
            var return_v = new System.Management.Automation.DataRowAdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 30308, 30328);
            return return_v;
        }


        static System.Management.Automation.PSObject.AdapterSet
        f_1293_30293_30361(System.Management.Automation.DataRowAdapter
        adapter, System.Management.Automation.DotNetAdapter
        dotnetAdapter)
        {
            var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 30293, 30361);
            return return_v;
        }


        static System.Management.Automation.XmlNodeAdapter
        f_1293_30441_30461()
        {
            var return_v = new System.Management.Automation.XmlNodeAdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 30441, 30461);
            return return_v;
        }


        static System.Management.Automation.PSObject.AdapterSet
        f_1293_30426_30494(System.Management.Automation.XmlNodeAdapter
        adapter, System.Management.Automation.DotNetAdapter
        dotnetAdapter)
        {
            var return_v = new System.Management.Automation.PSObject.AdapterSet((System.Management.Automation.Adapter)adapter, dotnetAdapter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 30426, 30494);
            return return_v;
        }


        System.Management.Automation.PSObject.AdapterSet
        f_1293_31541_31559()
        {
            var return_v = InternalAdapterSet;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 31541, 31559);
            return return_v;
        }


        System.Management.Automation.Adapter
        f_1293_31541_31575(System.Management.Automation.PSObject.AdapterSet
        this_param)
        {
            var return_v = this_param.OriginalAdapter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 31541, 31575);
            return return_v;
        }


        System.Management.Automation.PSObject.AdapterSet
        f_1293_32176_32194()
        {
            var return_v = InternalAdapterSet;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 32176, 32194);
            return return_v;
        }


        System.Management.Automation.DotNetAdapter
        f_1293_32176_32208(System.Management.Automation.PSObject.AdapterSet
        this_param)
        {
            var return_v = this_param.DotNetAdapter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 32176, 32208);
            return return_v;
        }


        static System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>
        f_1293_40497_40577()
        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 40497, 40577);
            return return_v;
        }


        bool
        f_1293_97255_97299(System.Management.Automation.PSObject.PSObjectFlags
        this_param, System.Management.Automation.PSObject.PSObjectFlags
        flag)
        {
            var return_v = this_param.HasFlag((System.Enum)flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 97255, 97299);
            return return_v;
        }


        bool
        f_1293_97702_97770(System.Management.Automation.PSObject.PSObjectFlags
        this_param, System.Management.Automation.PSObject.PSObjectFlags
        flag)
        {
            var return_v = this_param.HasFlag((System.Enum)flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 97702, 97770);
            return return_v;
        }


        bool
        f_1293_98196_98238(System.Management.Automation.PSObject.PSObjectFlags
        this_param, System.Management.Automation.PSObject.PSObjectFlags
        flag)
        {
            var return_v = this_param.HasFlag((System.Enum)flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 98196, 98238);
            return return_v;
        }


        bool
        f_1293_98627_98684(System.Management.Automation.PSObject.PSObjectFlags
        this_param, System.Management.Automation.PSObject.PSObjectFlags
        flag)
        {
            var return_v = this_param.HasFlag((System.Enum)flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 98627, 98684);
            return return_v;
        }


        bool
        f_1293_99102_99158(System.Management.Automation.PSObject.PSObjectFlags
        this_param, System.Management.Automation.PSObject.PSObjectFlags
        flag)
        {
            var return_v = this_param.HasFlag((System.Enum)flag);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 99102, 99158);
            return return_v;
        }

    }

    /// <summary>
    /// Specifies special stream write processing.
    /// </summary>
    internal enum WriteStreamType : byte
    {
        None,
        Output,
        Error,
        Warning,
        Verbose,
        Debug,
        Information
    }
    public class PSCustomObject
    {
        private PSCustomObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1293, 102583, 102611);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1293, 102583, 102611);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 102583, 102611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 102583, 102611);
            }
        }

        internal static PSCustomObject SelfInstance;

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1293, 102785, 102874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 102843, 102863);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1293, 102785, 102874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 102785, 102874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 102785, 102874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSCustomObject()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1293, 102433, 102881);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 102654, 102689);
            SelfInstance = f_1293_102669_102689();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1293, 102433, 102881);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 102433, 102881);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1293, 102433, 102881);

        static System.Management.Automation.PSCustomObject
        f_1293_102669_102689()
        {
            var return_v = new System.Management.Automation.PSCustomObject();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 102669, 102689);
            return return_v;
        }

    }

    /// <summary>
    /// </summary>
    /// <remarks>
    /// Please keep in sync with SerializationMethod from
    /// C:\e\win7_powershell\admin\monad\nttargets\assemblies\logging\ETW\Manifests\Microsoft-Windows-PowerShell-Instrumentation.man
    /// </remarks>
    internal enum SerializationMethod
    {
        AllPublicProperties = 0,
        String = 1,
        SpecificProperties = 2
    }
}

#pragma warning restore 56500

namespace Microsoft.PowerShell
{
    public static partial class ToStringCodeMethods
    {
        private static void AddGenericArguments(StringBuilder sb, Type[] genericArguments, bool dropNamespaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 103556, 103955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 103684, 103699);

                f_1293_103684_103698(sb, '[');
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 103722, 103727);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 103713, 103913) || true) && (i < f_1293_103733_103756(genericArguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 103758, 103761)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 103713, 103913))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 103713, 103913);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 103795, 103825) || true) && (i > 0)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 103795, 103825);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 103808, 103823);

                            f_1293_103808_103822(sb, ',');
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 103795, 103825);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 103845, 103898);

                        f_1293_103845_103897(
                                        sb, f_1293_103855_103896(genericArguments[i], dropNamespaces));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 103929, 103944);

                f_1293_103929_103943(
                            sb, ']');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 103556, 103955);

                System.Text.StringBuilder
                f_1293_103684_103698(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 103684, 103698);
                    return return_v;
                }


                int
                f_1293_103733_103756(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 103733, 103756);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_103808_103822(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 103808, 103822);
                    return return_v;
                }


                string
                f_1293_103855_103896(System.Type
                type, bool
                dropNamespaces)
                {
                    var return_v = Type(type, dropNamespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 103855, 103896);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_103845_103897(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 103845, 103897);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_103929_103943(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 103929, 103943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 103556, 103955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 103556, 103955);
            }
        }

        internal static string Type(Type type, bool dropNamespaces = false, string key = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 103967, 107664);
                System.Type roundTripType = default(System.Type);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 104078, 104163) || true) && (type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 104078, 104163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 104128, 104148);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 104078, 104163);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 104179, 104193);

                string
                result
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 104207, 106983) || true) && (f_1293_104211_104229(type) && (DynAbs.Tracing.TraceSender.Expression_True(1293, 104211, 104262) && f_1293_104233_104262_M(!type.IsGenericTypeDefinition)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 104207, 106983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 104296, 104377);

                    string
                    genericDefinition = f_1293_104323_104376(f_1293_104328_104359(type), dropNamespaces)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 104896, 104986);

                    int
                    backtickOrLeftBracketIndex = f_1293_104929_104985(genericDefinition, (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 104959, 104972) || ((f_1293_104959_104972(type) && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 104975, 104978)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 104981, 104984))) ? '[' : '`')
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105004, 105086);

                    var
                    sb = f_1293_105013_105085(genericDefinition, 0, backtickOrLeftBracketIndex, 512)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105104, 105172);

                    f_1293_105104_105171(sb, f_1293_105128_105154(type), dropNamespaces);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105190, 105213);

                    result = f_1293_105199_105212(sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 104207, 106983);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 104207, 106983);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105247, 106983) || true) && (f_1293_105251_105263(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 105247, 106983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105297, 105368);

                        string
                        elementDefinition = f_1293_105324_105367(f_1293_105329_105350(type), dropNamespaces)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105386, 105463);

                        var
                        sb = f_1293_105395_105462(elementDefinition, f_1293_105432_105456(elementDefinition) + 10)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105481, 105496);

                        f_1293_105481_105495(sb, "[");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105523, 105528);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105514, 105638) || true) && (i < f_1293_105534_105553(type) - 1)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105559, 105562)
            , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 105514, 105638))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 105514, 105638);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105604, 105619);

                                f_1293_105604_105618(sb, ",");
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1293, 1, 125);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1293, 1, 125);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105658, 105673);

                        f_1293_105658_105672(
                                        sb, "]");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105691, 105714);

                        result = f_1293_105700_105713(sb);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 105247, 106983);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 105247, 106983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105780, 105840);

                        result = f_1293_105789_105839(type, key);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105858, 106968) || true) && (result == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 105858, 106968);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 105918, 106042) || true) && (type == typeof(PSCustomObject))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 105918, 106042);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 106002, 106019);

                                return f_1293_106009_106018(type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 105918, 106042);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 106066, 106949) || true) && (dropNamespaces)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 106066, 106949);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 106134, 106803) || true) && (f_1293_106138_106151(type))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 106134, 106803);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 106406, 106440);

                                    string
                                    fullName = f_1293_106424_106439(type)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 106470, 106643);

                                    result = (DynAbs.Tracing.TraceSender.Conditional_F1(1293, 106479, 106501) || ((f_1293_106479_106493(type) == null
                                    && DynAbs.Tracing.TraceSender.Conditional_F2(1293, 106545, 106553)) || DynAbs.Tracing.TraceSender.Conditional_F3(1293, 106597, 106642))) ? fullName
                                    : f_1293_106597_106642(fullName, f_1293_106616_106637(f_1293_106616_106630(type)) + 1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 106134, 106803);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 106134, 106803);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 106757, 106776);

                                    result = f_1293_106766_106775(type);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 106134, 106803);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 106066, 106949);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 106066, 106949);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 106901, 106926);

                                result = f_1293_106910_106925(type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 106066, 106949);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 105858, 106968);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 105247, 106983);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 104207, 106983);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 107144, 107623) || true) && (f_1293_107148_107172_M(!type.IsGenericParameter) && (DynAbs.Tracing.TraceSender.Expression_True(1293, 107148, 107224) && f_1293_107193_107224_M(!type.ContainsGenericParameters)) && (DynAbs.Tracing.TraceSender.Expression_True(1293, 107148, 107260) && !dropNamespaces
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1293, 107148, 107374) && !f_1293_107282_107374(f_1293_107282_107368(f_1293_107282_107295(type), typeof(DynamicClassImplementationAssemblyAttribute)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 107144, 107623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 107408, 107468);

                    f_1293_107408_107467(result, out roundTripType);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 107486, 107608) || true) && (roundTripType != type)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 107486, 107608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 107553, 107589);

                        result = f_1293_107562_107588(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 107486, 107608);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 107144, 107623);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 107639, 107653);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 103967, 107664);

                bool
                f_1293_104211_104229(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 104211, 104229);
                    return return_v;
                }


                bool
                f_1293_104233_104262_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 104233, 104262);
                    return return_v;
                }


                System.Type
                f_1293_104328_104359(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 104328, 104359);
                    return return_v;
                }


                string
                f_1293_104323_104376(System.Type
                type, bool
                dropNamespaces)
                {
                    var return_v = Type(type, dropNamespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 104323, 104376);
                    return return_v;
                }


                bool
                f_1293_104959_104972(System.Type
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 104959, 104972);
                    return return_v;
                }


                int
                f_1293_104929_104985(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 104929, 104985);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_105013_105085(string
                value, int
                startIndex, int
                length, int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(value, startIndex, length, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105013, 105085);
                    return return_v;
                }


                System.Type[]
                f_1293_105128_105154(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105128, 105154);
                    return return_v;
                }


                int
                f_1293_105104_105171(System.Text.StringBuilder
                sb, System.Type[]
                genericArguments, bool
                dropNamespaces)
                {
                    AddGenericArguments(sb, genericArguments, dropNamespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105104, 105171);
                    return 0;
                }


                string
                f_1293_105199_105212(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105199, 105212);
                    return return_v;
                }


                bool
                f_1293_105251_105263(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 105251, 105263);
                    return return_v;
                }


                System.Type?
                f_1293_105329_105350(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105329, 105350);
                    return return_v;
                }


                string
                f_1293_105324_105367(System.Type
                type, bool
                dropNamespaces)
                {
                    var return_v = Type(type, dropNamespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105324, 105367);
                    return return_v;
                }


                int
                f_1293_105432_105456(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 105432, 105456);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_105395_105462(string
                value, int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(value, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105395, 105462);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_105481_105495(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105481, 105495);
                    return return_v;
                }


                int
                f_1293_105534_105553(System.Type
                this_param)
                {
                    var return_v = this_param.GetArrayRank();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105534, 105553);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_105604_105618(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105604, 105618);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1293_105658_105672(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105658, 105672);
                    return return_v;
                }


                string
                f_1293_105700_105713(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105700, 105713);
                    return return_v;
                }


                string
                f_1293_105789_105839(System.Type
                type, string
                expectedKey)
                {
                    var return_v = TypeAccelerators.FindBuiltinAccelerator(type, expectedKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 105789, 105839);
                    return return_v;
                }


                string
                f_1293_106009_106018(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 106009, 106018);
                    return return_v;
                }


                bool
                f_1293_106138_106151(System.Type
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 106138, 106151);
                    return return_v;
                }


                string
                f_1293_106424_106439(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 106424, 106439);
                    return return_v;
                }


                string
                f_1293_106479_106493(System.Type
                this_param)
                {
                    var return_v = this_param.Namespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 106479, 106493);
                    return return_v;
                }


                string
                f_1293_106616_106630(System.Type
                this_param)
                {
                    var return_v = this_param.Namespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 106616, 106630);
                    return return_v;
                }


                int
                f_1293_106616_106637(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 106616, 106637);
                    return return_v;
                }


                string
                f_1293_106597_106642(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 106597, 106642);
                    return return_v;
                }


                string
                f_1293_106766_106775(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 106766, 106775);
                    return return_v;
                }


                string
                f_1293_106910_106925(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 106910, 106925);
                    return return_v;
                }


                bool
                f_1293_107148_107172_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 107148, 107172);
                    return return_v;
                }


                bool
                f_1293_107193_107224_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 107193, 107224);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1293_107282_107295(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 107282, 107295);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Attribute>
                f_1293_107282_107368(System.Reflection.Assembly
                element, System.Type
                attributeType)
                {
                    var return_v = element.GetCustomAttributes(attributeType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 107282, 107368);
                    return return_v;
                }


                bool
                f_1293_107282_107374(System.Collections.Generic.IEnumerable<System.Attribute>
                source)
                {
                    var return_v = source.Any<System.Attribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 107282, 107374);
                    return return_v;
                }


                bool
                f_1293_107408_107467(string
                typeName, out System.Type
                type)
                {
                    var return_v = TypeResolver.TryResolveType(typeName, out type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 107408, 107467);
                    return return_v;
                }


                string
                f_1293_107562_107588(System.Type
                this_param)
                {
                    var return_v = this_param.AssemblyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 107562, 107588);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 103967, 107664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 103967, 107664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string Type(PSObject instance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 107852, 108076);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 107921, 108010) || true) && (instance == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 107921, 108010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 107975, 107995);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 107921, 108010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 108026, 108065);

                return f_1293_108033_108064(f_1293_108044_108063(instance));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 107852, 108076);

                object
                f_1293_108044_108063(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 108044, 108063);
                    return return_v;
                }


                string
                f_1293_108033_108064(object
                type)
                {
                    var return_v = Type((System.Type)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 108033, 108064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 107852, 108076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 107852, 108076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string XmlNode(PSObject instance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 108271, 108536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 108343, 108388);

                XmlNode
                node = (XmlNode)f_1293_108367_108387_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(instance, 1293, 108367, 108387)?.BaseObject)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 108402, 108487) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 108402, 108487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 108452, 108472);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 108402, 108487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 108503, 108525);

                return f_1293_108510_108524(node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 108271, 108536);

                object
                f_1293_108367_108387_M(object
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 108367, 108387);
                    return return_v;
                }


                string
                f_1293_108510_108524(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.LocalName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 108510, 108524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 108271, 108536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 108271, 108536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string XmlNodeList(PSObject instance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1293, 108739, 109372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 108815, 108869);

                XmlNodeList
                nodes = (XmlNodeList)f_1293_108848_108868_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(instance, 1293, 108848, 108868)?.BaseObject)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 108883, 108969) || true) && (nodes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 108883, 108969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 108934, 108954);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 108883, 108969);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 108985, 109223) || true) && (f_1293_108989_109000(nodes) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 108985, 109223);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 109039, 109140) || true) && (f_1293_109043_109051(nodes, 0) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1293, 109039, 109140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 109101, 109121);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 109039, 109140);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 109160, 109208);

                    return f_1293_109167_109207(f_1293_109167_109196(f_1293_109187_109195(nodes, 0)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1293, 108985, 109223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1293, 109239, 109361);

                return f_1293_109246_109360(context: null, enumerable: nodes, separator: null, format: null, formatProvider: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1293, 108739, 109372);

                object
                f_1293_108848_108868_M(object
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 108848, 108868);
                    return return_v;
                }


                int
                f_1293_108989_109000(System.Xml.XmlNodeList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 108989, 109000);
                    return return_v;
                }


                System.Xml.XmlNode
                f_1293_109043_109051(System.Xml.XmlNodeList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 109043, 109051);
                    return return_v;
                }


                System.Xml.XmlNode
                f_1293_109187_109195(System.Xml.XmlNodeList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1293, 109187, 109195);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1293_109167_109196(System.Xml.XmlNode
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 109167, 109196);
                    return return_v;
                }


                string
                f_1293_109167_109207(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 109167, 109207);
                    return return_v;
                }


                string
                f_1293_109246_109360(System.Management.Automation.ExecutionContext
                context, System.Xml.XmlNodeList
                enumerable, string
                separator, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = PSObject.ToStringEnumerable(context: context, enumerable: (System.Collections.IEnumerable)enumerable, separator: separator, format: format, formatProvider: formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1293, 109246, 109360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1293, 108739, 109372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1293, 108739, 109372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
