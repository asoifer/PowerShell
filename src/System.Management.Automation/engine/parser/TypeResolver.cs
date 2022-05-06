// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml;

using Microsoft.Management.Infrastructure;
using Microsoft.PowerShell.Commands;

namespace System.Management.Automation.Language
{
    internal static class TypeResolver
    {
        private static Type LookForTypeInSingleAssembly(Assembly assembly, string typename)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 1388, 1720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 1496, 1554);

                Type
                targetType = f_1560_1514_1553(assembly, typename, false, true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 1568, 1681) || true) && (targetType != null && (DynAbs.Tracing.TraceSender.Expression_True(1560, 1572, 1614) && f_1560_1594_1614(targetType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 1568, 1681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 1648, 1666);

                    return targetType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 1568, 1681);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 1697, 1709);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 1388, 1720);

                System.Type?
                f_1560_1514_1553(System.Reflection.Assembly
                this_param, string
                name, bool
                throwOnError, bool
                ignoreCase)
                {
                    var return_v = this_param.GetType(name, throwOnError, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 1514, 1553);
                    return return_v;
                }


                bool
                f_1560_1594_1614(System.Type
                type)
                {
                    var return_v = IsPublic(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 1594, 1614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 1388, 1720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 1388, 1720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal class AmbiguousTypeException : InvalidCastException
        {
            public string[] Candidates { private set; get; }

            public TypeName TypeName { private set; get; }

            public AmbiguousTypeException(TypeName typeName, IEnumerable<string> candidates)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1560, 2093, 2437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 1967, 2015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 2031, 2077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 2206, 2240);

                    Candidates = f_1560_2219_2239(candidates);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 2258, 2278);

                    TypeName = typeName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 2296, 2422);

                    f_1560_2296_2421(f_1560_2315_2332(f_1560_2315_2325()) > 1, "AmbiguousTypeException can be created only when there are more then 1 candidate.");
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1560, 2093, 2437);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 2093, 2437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 2093, 2437);
                }
            }

            static AmbiguousTypeException()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1560, 1882, 2448);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1560, 1882, 2448);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 1882, 2448);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1560, 1882, 2448);

            string[]
            f_1560_2219_2239(System.Collections.Generic.IEnumerable<string>
            source)
            {
                var return_v = source.ToArray<string>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 2219, 2239);
                return return_v;
            }


            string[]
            f_1560_2315_2325()
            {
                var return_v = Candidates;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 2315, 2325);
                return return_v;
            }


            int
            f_1560_2315_2332(string[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 2315, 2332);
                return return_v;
            }


            int
            f_1560_2296_2421(bool
            condition, string
            whyThisShouldNeverHappen)
            {
                Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 2296, 2421);
                return 0;
            }

        }

        private static Type LookForTypeInAssemblies(TypeName typeName,
                                                            IEnumerable<Assembly> assemblies,
                                                            HashSet<Assembly> searchedAssemblies,
                                                            TypeResolutionState typeResolutionState,
                                                            bool reportAmbiguousException,
                                                            out Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 2460, 5825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 2981, 2998);

                exception = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3012, 3097);

                string
                alternateNameToFind = f_1560_3041_3096(typeResolutionState, f_1560_3082_3095(typeName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3111, 3133);

                Type
                foundType = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3147, 3170);

                Type
                foundType2 = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3184, 5531);
                    foreach (Assembly assembly in f_1560_3214_3224_I(assemblies))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 3184, 5531);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3351, 3407) || true) && (f_1560_3355_3392(searchedAssemblies, assembly))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 3351, 3407);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3396, 3405);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 3351, 3407);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3471, 3542);

                            Type
                            targetType = f_1560_3489_3541(assembly, f_1560_3527_3540(typeName))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3564, 3762) || true) && (targetType == null && (DynAbs.Tracing.TraceSender.Expression_True(1560, 3568, 3617) && alternateNameToFind != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 3564, 3762);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3667, 3739);

                                targetType = f_1560_3680_3738(assembly, alternateNameToFind);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 3564, 3762);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3786, 5368) || true) && (targetType != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 3786, 5368);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 3858, 4106) || true) && (!reportAmbiguousException)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 3858, 4106);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 4061, 4079);

                                    return targetType;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 3858, 4106);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 4651, 5098) || true) && (foundType != targetType)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 4651, 5098);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 4736, 5071) || true) && (foundType != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 4736, 5071);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 4823, 4847);

                                        foundType2 = targetType;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1560, 4881, 4887);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 4736, 5071);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 4736, 5071);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 5017, 5040);

                                        foundType = targetType;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 4736, 5071);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 4651, 5098);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 3786, 5368);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 3786, 5368);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 5312, 5345);

                                f_1560_5312_5344(                        // We didn't find a match from the current assembly, so update the searchedAssemblies set.
                                                        searchedAssemblies, assembly);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 3786, 5368);
                            }
                        }
                        catch (Exception) // Assembly.GetType might throw unadvertised exceptions
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1560, 5405, 5516);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1560, 5405, 5516);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 3184, 5531);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 2348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 2348);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 5547, 5781) || true) && (foundType2 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 5547, 5781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 5603, 5736);

                    exception = f_1560_5615_5735(typeName, new string[] { f_1560_5667_5698(foundType), f_1560_5700_5732(foundType2) });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 5754, 5766);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 5547, 5781);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 5797, 5814);

                return foundType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 2460, 5825);

                string
                f_1560_3082_3095(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 3082, 3095);
                    return return_v;
                }


                string
                f_1560_3041_3096(System.Management.Automation.Language.TypeResolutionState
                this_param, string
                typeName)
                {
                    var return_v = this_param.GetAlternateTypeName(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 3041, 3096);
                    return return_v;
                }


                bool
                f_1560_3355_3392(System.Collections.Generic.HashSet<System.Reflection.Assembly>
                this_param, System.Reflection.Assembly
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 3355, 3392);
                    return return_v;
                }


                string
                f_1560_3527_3540(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 3527, 3540);
                    return return_v;
                }


                System.Type
                f_1560_3489_3541(System.Reflection.Assembly
                assembly, string
                typename)
                {
                    var return_v = LookForTypeInSingleAssembly(assembly, typename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 3489, 3541);
                    return return_v;
                }


                System.Type
                f_1560_3680_3738(System.Reflection.Assembly
                assembly, string
                typename)
                {
                    var return_v = LookForTypeInSingleAssembly(assembly, typename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 3680, 3738);
                    return return_v;
                }


                bool
                f_1560_5312_5344(System.Collections.Generic.HashSet<System.Reflection.Assembly>
                this_param, System.Reflection.Assembly
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 5312, 5344);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                f_1560_3214_3224_I(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 3214, 3224);
                    return return_v;
                }


                string
                f_1560_5667_5698(System.Type
                this_param)
                {
                    var return_v = this_param.AssemblyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 5667, 5698);
                    return return_v;
                }


                string
                f_1560_5700_5732(System.Type
                this_param)
                {
                    var return_v = this_param.AssemblyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 5700, 5732);
                    return return_v;
                }


                System.Management.Automation.Language.TypeResolver.AmbiguousTypeException
                f_1560_5615_5735(System.Management.Automation.Language.TypeName
                typeName, string[]
                candidates)
                {
                    var return_v = new System.Management.Automation.Language.TypeResolver.AmbiguousTypeException(typeName, (System.Collections.Generic.IEnumerable<string>)candidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 5615, 5735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 2460, 5825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 2460, 5825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPublic(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 5977, 6485);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 6042, 6120) || true) && (f_1560_6046_6059(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 6042, 6120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 6093, 6105);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 6042, 6120);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 6136, 6222) || true) && (f_1560_6140_6160_M(!type.IsNestedPublic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 6136, 6222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 6194, 6207);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 6136, 6222);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 6238, 6446) || true) && ((type = f_1560_6253_6271(type)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 6238, 6446);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 6314, 6431) || true) && (!(f_1560_6320_6333(type) || (DynAbs.Tracing.TraceSender.Expression_False(1560, 6320, 6356) || f_1560_6337_6356(type))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 6314, 6431);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 6399, 6412);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 6314, 6431);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 6238, 6446);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 6238, 6446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 6238, 6446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 6462, 6474);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 5977, 6485);

                bool
                f_1560_6046_6059(System.Type
                this_param)
                {
                    var return_v = this_param.IsPublic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 6046, 6059);
                    return return_v;
                }


                bool
                f_1560_6140_6160_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 6140, 6160);
                    return return_v;
                }


                System.Type
                f_1560_6253_6271(System.Type
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 6253, 6271);
                    return return_v;
                }


                bool
                f_1560_6320_6333(System.Type
                this_param)
                {
                    var return_v = this_param.IsPublic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 6320, 6333);
                    return return_v;
                }


                bool
                f_1560_6337_6356(System.Type
                this_param)
                {
                    var return_v = this_param.IsNestedPublic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 6337, 6356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 5977, 6485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 5977, 6485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Type ResolveTypeNameWorker(TypeName typeName,
                                                          SessionStateScope currentScope,
                                                          IEnumerable<Assembly> loadedAssemblies,
                                                          HashSet<Assembly> searchedAssemblies,
                                                          TypeResolutionState typeResolutionState,
                                                          bool onlySearchInGivenAssemblies,
                                                          bool reportAmbiguousException,
                                                          out Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 6497, 8483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7180, 7192);

                Type
                result
                = default(Type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7206, 7223);

                exception = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7239, 7820) || true) && (!onlySearchInGivenAssemblies)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 7239, 7820);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7305, 7627) || true) && (currentScope != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 7305, 7627);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7374, 7422);

                            result = f_1560_7383_7421(currentScope, f_1560_7407_7420(typeName));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7444, 7549) || true) && (result != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 7444, 7549);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7512, 7526);

                                return result;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 7444, 7549);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7573, 7608);

                            currentScope = f_1560_7588_7607(currentScope);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 7305, 7627);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 7305, 7627);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 7305, 7627);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7647, 7805) || true) && (f_1560_7651_7730(TypeAccelerators.builtinTypeAccelerators, f_1560_7704_7717(typeName), out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 7647, 7805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7772, 7786);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 7647, 7805);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 7239, 7820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7836, 7979);

                result = f_1560_7845_7978(typeName, loadedAssemblies, searchedAssemblies, typeResolutionState, reportAmbiguousException, out exception);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 7993, 8146) || true) && (exception != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 7993, 8146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 8117, 8131);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 7993, 8146);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 8162, 8442) || true) && (!onlySearchInGivenAssemblies && (DynAbs.Tracing.TraceSender.Expression_True(1560, 8166, 8212) && result == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 8162, 8442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 8252, 8289);
                    lock (TypeAccelerators.userTypeAccelerators)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 8331, 8408);

                        f_1560_8331_8407(TypeAccelerators.userTypeAccelerators, f_1560_8381_8394(typeName), out result);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 8162, 8442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 8458, 8472);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 6497, 8483);

                string
                f_1560_7407_7420(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 7407, 7420);
                    return return_v;
                }


                System.Type
                f_1560_7383_7421(System.Management.Automation.SessionStateScope
                this_param, string
                name)
                {
                    var return_v = this_param.LookupType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 7383, 7421);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1560_7588_7607(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 7588, 7607);
                    return return_v;
                }


                string
                f_1560_7704_7717(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 7704, 7717);
                    return return_v;
                }


                bool
                f_1560_7651_7730(System.Collections.Generic.Dictionary<string, System.Type>
                this_param, string
                key, out System.Type
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 7651, 7730);
                    return return_v;
                }


                System.Type
                f_1560_7845_7978(System.Management.Automation.Language.TypeName
                typeName, System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                assemblies, System.Collections.Generic.HashSet<System.Reflection.Assembly>
                searchedAssemblies, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, bool
                reportAmbiguousException, out System.Exception
                exception)
                {
                    var return_v = LookForTypeInAssemblies(typeName, assemblies, searchedAssemblies, typeResolutionState, reportAmbiguousException, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 7845, 7978);
                    return return_v;
                }


                string
                f_1560_8381_8394(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 8381, 8394);
                    return return_v;
                }


                bool
                f_1560_8331_8407(System.Collections.Generic.Dictionary<string, System.Type>
                this_param, string
                key, out System.Type
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 8331, 8407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 6497, 8483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 6497, 8483);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [ThreadStatic]
        private static HashSet<Assembly> s_searchedAssemblies;

        private static Type CallResolveTypeNameWorkerHelper(TypeName typeName,
                                                                    ExecutionContext context,
                                                                    IEnumerable<Assembly> assemblies,
                                                                    bool isAssembliesExplicitlyPassedIn,
                                                                    TypeResolutionState typeResolutionState,
                                                                    out Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 9380, 12316);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 9943, 10266) || true) && (s_searchedAssemblies == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 9943, 10266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 10009, 10056);

                    s_searchedAssemblies = f_1560_10032_10055();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 9943, 10266);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 9943, 10266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 10222, 10251);

                    f_1560_10222_10250(                // Clear the set before starting a full search to make sure we have a clean start.
                                    s_searchedAssemblies);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 9943, 10266);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 10318, 10335);

                    exception = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 10353, 10437);

                    var
                    currentScope = (DynAbs.Tracing.TraceSender.Conditional_F1(1560, 10372, 10387) || ((context != null && DynAbs.Tracing.TraceSender.Conditional_F2(1560, 10390, 10429)) || DynAbs.Tracing.TraceSender.Conditional_F3(1560, 10432, 10436))) ? f_1560_10390_10429(f_1560_10390_10416(context)) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 10455, 10734);

                    Type
                    result = f_1560_10469_10733(typeName, currentScope, typeResolutionState.assemblies, s_searchedAssemblies, typeResolutionState, false, true, out exception)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 10752, 12052) || true) && (exception == null && (DynAbs.Tracing.TraceSender.Expression_True(1560, 10756, 10791) && result == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 10752, 12052);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 10833, 11595) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1560, 10837, 10887) && !isAssembliesExplicitlyPassedIn))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 10833, 11595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 11300, 11572);

                            result = f_1560_11309_11571(typeName, currentScope, f_1560_11355_11383(f_1560_11355_11376(context)), s_searchedAssemblies, typeResolutionState, true, false, out exception);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 10833, 11595);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 11619, 12033) || true) && (result == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 11619, 12033);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 11756, 12010);

                            result = f_1560_11765_12009(typeName, currentScope, assemblies, s_searchedAssemblies, typeResolutionState, true, false, out exception);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 11619, 12033);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 10752, 12052);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 12072, 12086);

                    return result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1560, 12115, 12305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 12261, 12290);

                    f_1560_12261_12289(                // Clear the set after a full search, so dynamic assemblies can get reclaimed as needed.
                                    s_searchedAssemblies);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1560, 12115, 12305);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 9380, 12316);

                System.Collections.Generic.HashSet<System.Reflection.Assembly>
                f_1560_10032_10055()
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Reflection.Assembly>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 10032, 10055);
                    return return_v;
                }


                int
                f_1560_10222_10250(System.Collections.Generic.HashSet<System.Reflection.Assembly>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 10222, 10250);
                    return 0;
                }


                System.Management.Automation.SessionStateInternal
                f_1560_10390_10416(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 10390, 10416);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1560_10390_10429(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 10390, 10429);
                    return return_v;
                }


                System.Type
                f_1560_10469_10733(System.Management.Automation.Language.TypeName
                typeName, System.Management.Automation.SessionStateScope
                currentScope, System.Reflection.Assembly[]
                loadedAssemblies, System.Collections.Generic.HashSet<System.Reflection.Assembly>
                searchedAssemblies, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, bool
                onlySearchInGivenAssemblies, bool
                reportAmbiguousException, out System.Exception
                exception)
                {
                    var return_v = ResolveTypeNameWorker(typeName, currentScope, (System.Collections.Generic.IEnumerable<System.Reflection.Assembly>)loadedAssemblies, searchedAssemblies, typeResolutionState, onlySearchInGivenAssemblies, reportAmbiguousException, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 10469, 10733);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                f_1560_11355_11376(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.AssemblyCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 11355, 11376);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>.ValueCollection
                f_1560_11355_11383(System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 11355, 11383);
                    return return_v;
                }


                System.Type
                f_1560_11309_11571(System.Management.Automation.Language.TypeName
                typeName, System.Management.Automation.SessionStateScope
                currentScope, System.Collections.Generic.Dictionary<string, System.Reflection.Assembly>.ValueCollection
                loadedAssemblies, System.Collections.Generic.HashSet<System.Reflection.Assembly>
                searchedAssemblies, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, bool
                onlySearchInGivenAssemblies, bool
                reportAmbiguousException, out System.Exception
                exception)
                {
                    var return_v = ResolveTypeNameWorker(typeName, currentScope, (System.Collections.Generic.IEnumerable<System.Reflection.Assembly>)loadedAssemblies, searchedAssemblies, typeResolutionState, onlySearchInGivenAssemblies, reportAmbiguousException, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 11309, 11571);
                    return return_v;
                }


                System.Type
                f_1560_11765_12009(System.Management.Automation.Language.TypeName
                typeName, System.Management.Automation.SessionStateScope
                currentScope, System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                loadedAssemblies, System.Collections.Generic.HashSet<System.Reflection.Assembly>
                searchedAssemblies, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, bool
                onlySearchInGivenAssemblies, bool
                reportAmbiguousException, out System.Exception
                exception)
                {
                    var return_v = ResolveTypeNameWorker(typeName, currentScope, loadedAssemblies, searchedAssemblies, typeResolutionState, onlySearchInGivenAssemblies, reportAmbiguousException, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 11765, 12009);
                    return return_v;
                }


                int
                f_1560_12261_12289(System.Collections.Generic.HashSet<System.Reflection.Assembly>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 12261, 12289);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 9380, 12316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 9380, 12316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Type ResolveAssemblyQualifiedTypeName(TypeName typeName, out Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 12328, 13442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 12592, 12609);

                exception = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 13012, 13160);

                    var
                    result = f_1560_13025_13069(f_1560_13038_13055(typeName), false, true) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1560, 13025, 13159) ?? f_1560_13103_13159("System." + f_1560_13128_13145(typeName), false, true))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 13180, 13293) || true) && (result != null && (DynAbs.Tracing.TraceSender.Expression_True(1560, 13184, 13218) && f_1560_13202_13218(result)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 13180, 13293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 13260, 13274);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 13180, 13293);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1560, 13322, 13403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 13374, 13388);

                    exception = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1560, 13322, 13403);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 13419, 13431);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 12328, 13442);

                string
                f_1560_13038_13055(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 13038, 13055);
                    return return_v;
                }


                System.Type?
                f_1560_13025_13069(string
                typeName, bool
                throwOnError, bool
                ignoreCase)
                {
                    var return_v = Type.GetType(typeName, throwOnError, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 13025, 13069);
                    return return_v;
                }


                string
                f_1560_13128_13145(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 13128, 13145);
                    return return_v;
                }


                System.Type?
                f_1560_13103_13159(string
                typeName, bool
                throwOnError, bool
                ignoreCase)
                {
                    var return_v = Type.GetType(typeName, throwOnError, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 13103, 13159);
                    return return_v;
                }


                bool
                f_1560_13202_13218(System.Type
                type)
                {
                    var return_v = IsPublic(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 13202, 13218);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 12328, 13442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 12328, 13442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Type ResolveTypeNameWithContext(TypeName typeName, out Exception exception, Assembly[] assemblies, TypeResolutionState typeResolutionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 13454, 21150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 13634, 13666);

                ExecutionContext
                context = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 13680, 13697);

                exception = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 13713, 14053) || true) && (typeResolutionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 13713, 14053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 13895, 13948);

                    context = f_1560_13905_13947();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 13966, 14038);

                    typeResolutionState = f_1560_13988_14037(context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 13713, 14053);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 14201, 14360);

                var
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(1560, 14214, 14268) || ((f_1560_14214_14268(typeResolutionState, f_1560_14254_14267(typeName)) && DynAbs.Tracing.TraceSender.Conditional_F2(1560, 14288, 14292)) || DynAbs.Tracing.TraceSender.Conditional_F3(1560, 14312, 14359))) ? null
                : f_1560_14312_14359(typeName, typeResolutionState)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 14374, 14455) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 14374, 14455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 14426, 14440);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 14374, 14455);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 14471, 14723) || true) && (f_1560_14475_14496(typeName) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 14471, 14723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 14538, 14605);

                    result = f_1560_14547_14604(typeName, out exception);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 14623, 14676);

                    f_1560_14623_14675(typeName, typeResolutionState, result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 14694, 14708);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 14471, 14723);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 17634, 17762) || true) && (typeName._typeDefinitionAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 17634, 17762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 17707, 17747);

                    return f_1560_17714_17746(typeName._typeDefinitionAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 17634, 17762);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 17778, 17899) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 17778, 17899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 17831, 17884);

                    context = f_1560_17841_17883();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 17778, 17899);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18078, 18163);

                var
                assemList = assemblies ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Reflection.Assembly[]>(1560, 18094, 18162) ?? f_1560_18108_18162(typeResolutionState, typeName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18177, 18233);

                var
                isAssembliesExplicitlyPassedIn = assemblies != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18249, 18388);

                result = f_1560_18258_18387(typeName, context, assemList, isAssembliesExplicitlyPassedIn, typeResolutionState, out exception);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18404, 18556) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 18404, 18556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18456, 18509);

                    f_1560_18456_18508(typeName, typeResolutionState, result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18527, 18541);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 18404, 18556);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18572, 20363) || true) && (exception == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 18572, 20363);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18627, 20348);
                        foreach (var ns in f_1560_18646_18676_I(typeResolutionState.namespaces))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 18627, 20348);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18718, 18769);

                            var
                            newTypeNameToSearch = ns + "." + f_1560_18755_18768(typeName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18791, 18941);

                            newTypeNameToSearch = f_1560_18813_18874(typeResolutionState, newTypeNameToSearch) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1560, 18813, 18940) ?? newTypeNameToSearch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 18963, 19032);

                            var
                            newTypeName = f_1560_18981_19031(f_1560_18994_19009(typeName), newTypeNameToSearch)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 19067, 19489) || true) && (!isAssembliesExplicitlyPassedIn)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 19067, 19489);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 19396, 19466);

                                assemList = f_1560_19408_19465(typeResolutionState, newTypeName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 19067, 19489);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 19519, 19668);

                            var
                            newResult = f_1560_19535_19667(newTypeName, context, assemList, isAssembliesExplicitlyPassedIn, typeResolutionState, out exception)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 19692, 19792) || true) && (exception != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 19692, 19792);
                                DynAbs.Tracing.TraceSender.TraceBreak(1560, 19763, 19769);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 19692, 19792);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 19816, 20329) || true) && (newResult != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 19816, 20329);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 19887, 20306) || true) && (result == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 19887, 20306);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 19963, 19982);

                                    result = newResult;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 19887, 20306);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 19887, 20306);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 20096, 20199);

                                    exception = f_1560_20108_20198(typeName, new string[] { f_1560_20160_20175(result), f_1560_20177_20195(newResult) });
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 20229, 20243);

                                    result = null;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1560, 20273, 20279);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 19887, 20306);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 19816, 20329);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 18627, 20348);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 1722);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 1722);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 18572, 20363);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 20379, 20973) || true) && (exception != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 20379, 20973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 20514, 20575);

                    var
                    ambiguousException = exception as AmbiguousTypeException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 20593, 20958) || true) && (ambiguousException != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 20593, 20958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 20665, 20939);

                        exception = f_1560_20677_20938("AmbiguousTypeReference", exception, f_1560_20762_20798(), f_1560_20800_20832(f_1560_20800_20827(ambiguousException)), f_1560_20871_20900(ambiguousException)[0], f_1560_20905_20934(ambiguousException)[1]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 20593, 20958);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 20379, 20973);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 20989, 21109) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 20989, 21109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 21041, 21094);

                    f_1560_21041_21093(typeName, typeResolutionState, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 20989, 21109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 21125, 21139);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 13454, 21150);

                System.Management.Automation.ExecutionContext
                f_1560_13905_13947()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 13905, 13947);
                    return return_v;
                }


                System.Management.Automation.Language.TypeResolutionState
                f_1560_13988_14037(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = TypeResolutionState.GetDefaultUsingState(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 13988, 14037);
                    return return_v;
                }


                string
                f_1560_14254_14267(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 14254, 14267);
                    return return_v;
                }


                bool
                f_1560_14214_14268(System.Management.Automation.Language.TypeResolutionState
                this_param, string
                type)
                {
                    var return_v = this_param.ContainsTypeDefined(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 14214, 14268);
                    return return_v;
                }


                System.Type
                f_1560_14312_14359(System.Management.Automation.Language.TypeName
                typeName, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState)
                {
                    var return_v = TypeCache.Lookup((System.Management.Automation.Language.ITypeName)typeName, typeResolutionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 14312, 14359);
                    return return_v;
                }


                string
                f_1560_14475_14496(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 14475, 14496);
                    return return_v;
                }


                System.Type
                f_1560_14547_14604(System.Management.Automation.Language.TypeName
                typeName, out System.Exception
                exception)
                {
                    var return_v = ResolveAssemblyQualifiedTypeName(typeName, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 14547, 14604);
                    return return_v;
                }


                int
                f_1560_14623_14675(System.Management.Automation.Language.TypeName
                typeName, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, System.Type
                type)
                {
                    TypeCache.Add((System.Management.Automation.Language.ITypeName)typeName, typeResolutionState, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 14623, 14675);
                    return 0;
                }


                System.Type
                f_1560_17714_17746(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 17714, 17746);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1560_17841_17883()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 17841, 17883);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                f_1560_18108_18162(System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, System.Management.Automation.Language.TypeName
                typeName)
                {
                    var return_v = ClrFacade.GetAssemblies(typeResolutionState, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 18108, 18162);
                    return return_v;
                }


                System.Type
                f_1560_18258_18387(System.Management.Automation.Language.TypeName
                typeName, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                assemblies, bool
                isAssembliesExplicitlyPassedIn, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, out System.Exception
                exception)
                {
                    var return_v = CallResolveTypeNameWorkerHelper(typeName, context, assemblies, isAssembliesExplicitlyPassedIn, typeResolutionState, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 18258, 18387);
                    return return_v;
                }


                int
                f_1560_18456_18508(System.Management.Automation.Language.TypeName
                typeName, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, System.Type
                type)
                {
                    TypeCache.Add((System.Management.Automation.Language.ITypeName)typeName, typeResolutionState, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 18456, 18508);
                    return 0;
                }


                string
                f_1560_18755_18768(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 18755, 18768);
                    return return_v;
                }


                string
                f_1560_18813_18874(System.Management.Automation.Language.TypeResolutionState
                this_param, string
                typeName)
                {
                    var return_v = this_param.GetAlternateTypeName(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 18813, 18874);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1560_18994_19009(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 18994, 19009);
                    return return_v;
                }


                System.Management.Automation.Language.TypeName
                f_1560_18981_19031(System.Management.Automation.Language.IScriptExtent
                extent, string
                name)
                {
                    var return_v = new System.Management.Automation.Language.TypeName(extent, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 18981, 19031);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                f_1560_19408_19465(System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, System.Management.Automation.Language.TypeName
                typeName)
                {
                    var return_v = ClrFacade.GetAssemblies(typeResolutionState, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 19408, 19465);
                    return return_v;
                }


                System.Type
                f_1560_19535_19667(System.Management.Automation.Language.TypeName
                typeName, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                assemblies, bool
                isAssembliesExplicitlyPassedIn, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, out System.Exception
                exception)
                {
                    var return_v = CallResolveTypeNameWorkerHelper(typeName, context, assemblies, isAssembliesExplicitlyPassedIn, typeResolutionState, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 19535, 19667);
                    return return_v;
                }


                string
                f_1560_20160_20175(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 20160, 20175);
                    return return_v;
                }


                string
                f_1560_20177_20195(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 20177, 20195);
                    return return_v;
                }


                System.Management.Automation.Language.TypeResolver.AmbiguousTypeException
                f_1560_20108_20198(System.Management.Automation.Language.TypeName
                typeName, string[]
                candidates)
                {
                    var return_v = new System.Management.Automation.Language.TypeResolver.AmbiguousTypeException(typeName, (System.Collections.Generic.IEnumerable<string>)candidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 20108, 20198);
                    return return_v;
                }


                string[]
                f_1560_18646_18676_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 18646, 18676);
                    return return_v;
                }


                string
                f_1560_20762_20798()
                {
                    var return_v = ParserStrings.AmbiguousTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 20762, 20798);
                    return return_v;
                }


                System.Management.Automation.Language.TypeName
                f_1560_20800_20827(System.Management.Automation.Language.TypeResolver.AmbiguousTypeException
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 20800, 20827);
                    return return_v;
                }


                string
                f_1560_20800_20832(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 20800, 20832);
                    return return_v;
                }


                string[]
                f_1560_20871_20900(System.Management.Automation.Language.TypeResolver.AmbiguousTypeException
                this_param)
                {
                    var return_v = this_param.Candidates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 20871, 20900);
                    return return_v;
                }


                string[]
                f_1560_20905_20934(System.Management.Automation.Language.TypeResolver.AmbiguousTypeException
                this_param)
                {
                    var return_v = this_param.Candidates;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 20905, 20934);
                    return return_v;
                }


                System.Management.Automation.PSInvalidCastException
                f_1560_20677_20938(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.PSInvalidCastException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 20677, 20938);
                    return return_v;
                }


                int
                f_1560_21041_21093(System.Management.Automation.Language.TypeName
                typeName, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState, System.Type
                type)
                {
                    TypeCache.Add((System.Management.Automation.Language.ITypeName)typeName, typeResolutionState, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 21041, 21093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 13454, 21150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 13454, 21150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Type ResolveTypeName(TypeName typeName, out Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 21162, 21349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 21267, 21338);

                return f_1560_21274_21337(typeName, out exception, null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 21162, 21349);

                System.Type
                f_1560_21274_21337(System.Management.Automation.Language.TypeName
                typeName, out System.Exception
                exception, System.Reflection.Assembly[]
                assemblies, System.Management.Automation.Language.TypeResolutionState
                typeResolutionState)
                {
                    var return_v = ResolveTypeNameWithContext(typeName, out exception, assemblies, typeResolutionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 21274, 21337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 21162, 21349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 21162, 21349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryResolveType(string typeName, out Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 21361, 21578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 21453, 21473);

                Exception
                exception
                = default(Exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 21487, 21531);

                type = f_1560_21494_21530(typeName, out exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 21545, 21567);

                return (type != null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 21361, 21578);

                System.Type
                f_1560_21494_21530(string
                strTypeName, out System.Exception
                exception)
                {
                    var return_v = ResolveType(strTypeName, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 21494, 21530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 21361, 21578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 21361, 21578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Type ResolveITypeName(ITypeName iTypeName, out Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 21590, 22248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 21698, 21715);

                exception = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 21729, 21766);

                var
                typeName = iTypeName as TypeName
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 21780, 22173) || true) && (typeName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 21780, 22173);
                    // The type is something more complicated - generic or array.
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 21957, 21994);

                        return f_1560_21964_21993(iTypeName);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1560, 22031, 22158);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 22091, 22105);

                        exception = e;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 22127, 22139);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1560, 22031, 22158);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 21780, 22173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 22189, 22237);

                return f_1560_22196_22236(typeName, out exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 21590, 22248);

                System.Type
                f_1560_21964_21993(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 21964, 21993);
                    return return_v;
                }


                System.Type
                f_1560_22196_22236(System.Management.Automation.Language.TypeName
                typeName, out System.Exception
                exception)
                {
                    var return_v = ResolveTypeName(typeName, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 22196, 22236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 21590, 22248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 21590, 22248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Type ResolveType(string strTypeName, out Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 22684, 23175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 22786, 22803);

                exception = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 22817, 22920) || true) && (f_1560_22821_22859(strTypeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 22817, 22920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 22893, 22905);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 22817, 22920);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 22936, 23002);

                var
                iTypeName = f_1560_22952_23001(strTypeName, ignoreErrors: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 23016, 23098) || true) && (iTypeName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 23016, 23098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 23071, 23083);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 23016, 23098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 23114, 23164);

                return f_1560_23121_23163(iTypeName, out exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 22684, 23175);

                bool
                f_1560_22821_22859(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 22821, 22859);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1560_22952_23001(string
                typename, bool
                ignoreErrors)
                {
                    var return_v = Parser.ScanType(typename, ignoreErrors: ignoreErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 22952, 23001);
                    return return_v;
                }


                System.Type
                f_1560_23121_23163(System.Management.Automation.Language.ITypeName
                iTypeName, out System.Exception
                exception)
                {
                    var return_v = ResolveITypeName(iTypeName, out exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 23121, 23163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 22684, 23175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 22684, 23175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeResolver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1560, 841, 23182);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 9224, 9251);
            s_searchedAssemblies = null;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1560, 841, 23182);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 841, 23182);
        }

    }
    internal class TypeResolutionState
    {
        internal static readonly string[] systemNamespace;

        internal static readonly Assembly[] emptyAssemblies;

        internal static readonly TypeResolutionState UsingSystem;

        internal readonly string[] namespaces;

        internal readonly Assembly[] assemblies;

        private readonly HashSet<string> _typesDefined;

        internal readonly int genericArgumentCount;

        internal readonly bool attribute;

        private TypeResolutionState()
        : this(f_1560_24446_24461_C(systemNamespace), emptyAssemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1560, 24396, 24501);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1560, 24396, 24501);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 24396, 24501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 24396, 24501);
            }
        }

        internal TypeResolutionState CloneWithAddTypesDefined(IEnumerable<string> types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1560, 24864, 25256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24969, 25060);

                var
                newTypesDefined = f_1560_24991_25059(_typesDefined, f_1560_25026_25058())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25074, 25175);
                    foreach (var type in f_1560_25095_25100_I(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 25074, 25175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25134, 25160);

                        f_1560_25134_25159(newTypesDefined, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 25074, 25175);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25191, 25245);

                return f_1560_25198_25244(this, newTypesDefined);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1560, 24864, 25256);

                System.StringComparer
                f_1560_25026_25058()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 25026, 25058);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1560_24991_25059(System.Collections.Generic.HashSet<string>
                collection, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEnumerable<string>)collection, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 24991, 25059);
                    return return_v;
                }


                bool
                f_1560_25134_25159(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 25134, 25159);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1560_25095_25100_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 25095, 25100);
                    return return_v;
                }


                System.Management.Automation.Language.TypeResolutionState
                f_1560_25198_25244(System.Management.Automation.Language.TypeResolutionState
                other, System.Collections.Generic.HashSet<string>
                typesDefined)
                {
                    var return_v = new System.Management.Automation.Language.TypeResolutionState(other, typesDefined);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 25198, 25244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 24864, 25256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 24864, 25256);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ContainsTypeDefined(string type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1560, 25268, 25386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25339, 25375);

                return f_1560_25346_25374(_typesDefined, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1560, 25268, 25386);

                bool
                f_1560_25346_25374(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 25346, 25374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 25268, 25386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 25268, 25386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeResolutionState(string[] namespaces, Assembly[] assemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1560, 25398, 25700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24170, 24180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24220, 24230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24274, 24287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24320, 24340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24374, 24383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25495, 25543);

                this.namespaces = namespaces ?? (DynAbs.Tracing.TraceSender.Expression_Null<string[]>(1560, 25513, 25542) ?? systemNamespace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25557, 25605);

                this.assemblies = assemblies ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Reflection.Assembly[]>(1560, 25575, 25604) ?? emptyAssemblies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25619, 25689);

                _typesDefined = f_1560_25635_25688(f_1560_25655_25687());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1560, 25398, 25700);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 25398, 25700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 25398, 25700);
            }
        }

        internal TypeResolutionState(TypeResolutionState other, int genericArgumentCount, bool attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1560, 25712, 26083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24170, 24180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24220, 24230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24274, 24287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24320, 24340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24374, 24383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25834, 25869);

                this.namespaces = other.namespaces;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25883, 25918);

                this.assemblies = other.assemblies;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25932, 25968);

                _typesDefined = other._typesDefined;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 25982, 26031);

                this.genericArgumentCount = genericArgumentCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26045, 26072);

                this.attribute = attribute;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1560, 25712, 26083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 25712, 26083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 25712, 26083);
            }
        }

        private TypeResolutionState(TypeResolutionState other, HashSet<string> typesDefined)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1560, 26095, 26458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24170, 24180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24220, 24230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24274, 24287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24320, 24340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24374, 24383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26204, 26239);

                this.namespaces = other.namespaces;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26253, 26288);

                this.assemblies = other.assemblies;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26302, 26331);

                _typesDefined = typesDefined;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26345, 26400);

                this.genericArgumentCount = other.genericArgumentCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26414, 26447);

                this.attribute = other.attribute;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1560, 26095, 26458);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 26095, 26458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 26095, 26458);
            }
        }

        internal static TypeResolutionState GetDefaultUsingState(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 26470, 26915);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26577, 26698) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 26577, 26698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26630, 26683);

                    context = f_1560_26640_26682();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 26577, 26698);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26714, 26849) || true) && (context != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 26714, 26849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26767, 26834);

                    return f_1560_26774_26833(f_1560_26774_26813(f_1560_26774_26800(context)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 26714, 26849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 26865, 26904);

                return TypeResolutionState.UsingSystem;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 26470, 26915);

                System.Management.Automation.ExecutionContext
                f_1560_26640_26682()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 26640, 26682);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1560_26774_26800(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 26774, 26800);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1560_26774_26813(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 26774, 26813);
                    return return_v;
                }


                System.Management.Automation.Language.TypeResolutionState
                f_1560_26774_26833(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.TypeResolutionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 26774, 26833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 26470, 26915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 26470, 26915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetAlternateTypeName(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1560, 26927, 27446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27005, 27033);

                string
                alternateName = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27047, 27398) || true) && (genericArgumentCount > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1560, 27051, 27104) && f_1560_27079_27100(typeName, '`') < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 27047, 27398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27138, 27192);

                    alternateName = typeName + "`" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (genericArgumentCount).ToString(), 1560, 27171, 27191);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 27047, 27398);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 27047, 27398);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27226, 27398) || true) && (attribute && (DynAbs.Tracing.TraceSender.Expression_True(1560, 27230, 27310) && !f_1560_27244_27310(typeName, "Attribute", StringComparison.OrdinalIgnoreCase)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 27226, 27398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27344, 27383);

                        alternateName = typeName + "Attribute";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 27226, 27398);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 27047, 27398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27414, 27435);

                return alternateName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1560, 26927, 27446);

                int
                f_1560_27079_27100(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 27079, 27100);
                    return return_v;
                }


                bool
                f_1560_27244_27310(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 27244, 27310);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 26927, 27446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 26927, 27446);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1560, 27458, 28707);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27522, 27590) || true) && (f_1560_27526_27559(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 27522, 27590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27578, 27590);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 27522, 27590);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27606, 27645);

                var
                other = obj as TypeResolutionState
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27661, 27710) || true) && (other == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 27661, 27710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27697, 27710);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 27661, 27710);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27726, 27795) || true) && (this.attribute != other.attribute)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 27726, 27795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27782, 27795);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 27726, 27795);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27811, 27902) || true) && (this.genericArgumentCount != other.genericArgumentCount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 27811, 27902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27889, 27902);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 27811, 27902);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27918, 28003) || true) && (f_1560_27922_27944(this.namespaces) != f_1560_27948_27971(other.namespaces))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 27918, 28003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 27990, 28003);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 27918, 28003);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28019, 28104) || true) && (f_1560_28023_28045(this.assemblies) != f_1560_28049_28072(other.assemblies))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 28019, 28104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28091, 28104);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 28019, 28104);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28129, 28134);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28120, 28334) || true) && (i < f_1560_28140_28157(namespaces))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28159, 28162)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 28120, 28334))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 28120, 28334);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28196, 28319) || true) && (!f_1560_28201_28283(this.namespaces[i], other.namespaces[i], StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 28196, 28319);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28306, 28319);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 28196, 28319);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 215);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28359, 28364);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28350, 28528) || true) && (i < f_1560_28370_28387(assemblies))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28389, 28392)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 28350, 28528))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 28350, 28528);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28426, 28513) || true) && (!f_1560_28431_28477(this.assemblies[i], other.assemblies[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 28426, 28513);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28500, 28513);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 28426, 28513);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 179);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28544, 28628) || true) && (f_1560_28548_28567(_typesDefined) != f_1560_28571_28596(other._typesDefined))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 28544, 28628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28615, 28628);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 28544, 28628);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28644, 28696);

                return f_1560_28651_28695(_typesDefined, other._typesDefined);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1560, 27458, 28707);

                bool
                f_1560_27526_27559(System.Management.Automation.Language.TypeResolutionState
                objA, object
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 27526, 27559);
                    return return_v;
                }


                int
                f_1560_27922_27944(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 27922, 27944);
                    return return_v;
                }


                int
                f_1560_27948_27971(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 27948, 27971);
                    return return_v;
                }


                int
                f_1560_28023_28045(System.Reflection.Assembly[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 28023, 28045);
                    return return_v;
                }


                int
                f_1560_28049_28072(System.Reflection.Assembly[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 28049, 28072);
                    return return_v;
                }


                int
                f_1560_28140_28157(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 28140, 28157);
                    return return_v;
                }


                bool
                f_1560_28201_28283(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 28201, 28283);
                    return return_v;
                }


                int
                f_1560_28370_28387(System.Reflection.Assembly[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 28370, 28387);
                    return return_v;
                }


                bool
                f_1560_28431_28477(System.Reflection.Assembly
                this_param, System.Reflection.Assembly
                o)
                {
                    var return_v = this_param.Equals((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 28431, 28477);
                    return return_v;
                }


                int
                f_1560_28548_28567(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 28548, 28567);
                    return return_v;
                }


                int
                f_1560_28571_28596(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 28571, 28596);
                    return return_v;
                }


                bool
                f_1560_28651_28695(System.Collections.Generic.HashSet<string>
                this_param, System.Collections.Generic.HashSet<string>
                other)
                {
                    var return_v = this_param.SetEquals((System.Collections.Generic.IEnumerable<string>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 28651, 28695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 27458, 28707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 27458, 28707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1560, 28719, 29505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28777, 28831);

                var
                stringComparer = f_1560_28798_28830()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28845, 28942);

                int
                result = f_1560_28858_28941(f_1560_28881_28915(genericArgumentCount), f_1560_28917_28940(attribute))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28965, 28970);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28956, 29130) || true) && (i < f_1560_28976_28993(namespaces))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 28995, 28998)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 28956, 29130))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 28956, 29130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 29032, 29115);

                        result = f_1560_29041_29114(result, f_1560_29072_29113(stringComparer, namespaces[i]));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 175);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 29155, 29160);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 29146, 29311) || true) && (i < f_1560_29166_29183(assemblies))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 29185, 29188)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 29146, 29311))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 29146, 29311);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 29222, 29296);

                        result = f_1560_29231_29295(result, f_1560_29262_29294(this.assemblies[i]));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 166);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 166);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 29327, 29464);
                    foreach (var t in f_1560_29345_29358_I(_typesDefined))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 29327, 29464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 29392, 29449);

                        result = f_1560_29401_29448(result, f_1560_29432_29447(t));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 29327, 29464);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 29480, 29494);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1560, 28719, 29505);

                System.StringComparer
                f_1560_28798_28830()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 28798, 28830);
                    return return_v;
                }


                int
                f_1560_28881_28915(int
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 28881, 28915);
                    return return_v;
                }


                int
                f_1560_28917_28940(bool
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 28917, 28940);
                    return return_v;
                }


                int
                f_1560_28858_28941(int
                h1, int
                h2)
                {
                    var return_v = Utils.CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 28858, 28941);
                    return return_v;
                }


                int
                f_1560_28976_28993(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 28976, 28993);
                    return return_v;
                }


                int
                f_1560_29072_29113(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 29072, 29113);
                    return return_v;
                }


                int
                f_1560_29041_29114(int
                h1, int
                h2)
                {
                    var return_v = Utils.CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 29041, 29114);
                    return return_v;
                }


                int
                f_1560_29166_29183(System.Reflection.Assembly[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 29166, 29183);
                    return return_v;
                }


                int
                f_1560_29262_29294(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 29262, 29294);
                    return return_v;
                }


                int
                f_1560_29231_29295(int
                h1, int
                h2)
                {
                    var return_v = Utils.CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 29231, 29295);
                    return return_v;
                }


                int
                f_1560_29432_29447(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 29432, 29447);
                    return return_v;
                }


                int
                f_1560_29401_29448(int
                h1, int
                h2)
                {
                    var return_v = Utils.CombineHashCodes(h1, h2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 29401, 29448);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1560_29345_29358_I(System.Collections.Generic.HashSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 29345, 29358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 28719, 29505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 28719, 29505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeResolutionState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1560, 23832, 29512);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 23917, 23947);
            systemNamespace = new string[] { "System" };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 23994, 24035);
            emptyAssemblies = f_1560_24012_24035();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 24091, 24130);
            UsingSystem = f_1560_24105_24130();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1560, 23832, 29512);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 23832, 29512);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1560, 23832, 29512);

        static System.Reflection.Assembly[]
        f_1560_24012_24035()
        {
            var return_v = Array.Empty<Assembly>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 24012, 24035);
            return return_v;
        }


        static System.Management.Automation.Language.TypeResolutionState
        f_1560_24105_24130()
        {
            var return_v = new System.Management.Automation.Language.TypeResolutionState();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 24105, 24130);
            return return_v;
        }


        static string[]
        f_1560_24446_24461_C(string[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1560, 24396, 24501);
            return return_v;
        }


        System.StringComparer
        f_1560_25655_25687()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 25655, 25687);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_1560_25635_25688(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 25635, 25688);
            return return_v;
        }

    }
    internal class TypeCache
    {
        private class KeyComparer : IEqualityComparer<Tuple<ITypeName, TypeResolutionState>>
        {
            public bool Equals(Tuple<ITypeName, TypeResolutionState> x,
                                           Tuple<ITypeName, TypeResolutionState> y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1560, 29670, 29908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 29835, 29893);

                    return f_1560_29842_29865(f_1560_29842_29849(x), f_1560_29857_29864(y)) && (DynAbs.Tracing.TraceSender.Expression_True(1560, 29842, 29892) && f_1560_29869_29892(f_1560_29869_29876(x), f_1560_29884_29891(y)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1560, 29670, 29908);

                    System.Management.Automation.Language.ITypeName
                    f_1560_29842_29849(System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>
                    this_param)
                    {
                        var return_v = this_param.Item1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 29842, 29849);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1560_29857_29864(System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>
                    this_param)
                    {
                        var return_v = this_param.Item1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 29857, 29864);
                        return return_v;
                    }


                    bool
                    f_1560_29842_29865(System.Management.Automation.Language.ITypeName
                    this_param, System.Management.Automation.Language.ITypeName
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 29842, 29865);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeResolutionState
                    f_1560_29869_29876(System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>
                    this_param)
                    {
                        var return_v = this_param.Item2;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 29869, 29876);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeResolutionState
                    f_1560_29884_29891(System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>
                    this_param)
                    {
                        var return_v = this_param.Item2;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 29884, 29891);
                        return return_v;
                    }


                    bool
                    f_1560_29869_29892(System.Management.Automation.Language.TypeResolutionState
                    this_param, System.Management.Automation.Language.TypeResolutionState
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 29869, 29892);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 29670, 29908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 29670, 29908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(Tuple<ITypeName, TypeResolutionState> obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1560, 29924, 30062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 30022, 30047);

                    return f_1560_30029_30046(obj);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1560, 29924, 30062);

                    int
                    f_1560_30029_30046(System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 30029, 30046);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 29924, 30062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 29924, 30062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public KeyComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1560, 29561, 30073);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1560, 29561, 30073);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 29561, 30073);
            }


            static KeyComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1560, 29561, 30073);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1560, 29561, 30073);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 29561, 30073);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1560, 29561, 30073);
        }

        private static readonly ConcurrentDictionary<Tuple<ITypeName, TypeResolutionState>, Type> s_cache;

        internal static Type Lookup(ITypeName typeName, TypeResolutionState typeResolutionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 30286, 30541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 30399, 30411);

                Type
                result
                = default(Type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 30425, 30502);

                f_1560_30425_30501(s_cache, f_1560_30445_30488(typeName, typeResolutionState), out result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 30516, 30530);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 30286, 30541);

                System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>
                f_1560_30445_30488(System.Management.Automation.Language.ITypeName
                item1, System.Management.Automation.Language.TypeResolutionState
                item2)
                {
                    var return_v = Tuple.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 30445, 30488);
                    return return_v;
                }


                bool
                f_1560_30425_30501(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>, System.Type>
                this_param, System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>
                key, out System.Type
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 30425, 30501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 30286, 30541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 30286, 30541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void Add(ITypeName typeName, TypeResolutionState typeResolutionState, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 30553, 30753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 30674, 30742);

                f_1560_30674_30741(s_cache, f_1560_30691_30734(typeName, typeResolutionState), type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 30553, 30753);

                System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>
                f_1560_30691_30734(System.Management.Automation.Language.ITypeName
                item1, System.Management.Automation.Language.TypeResolutionState
                item2)
                {
                    var return_v = Tuple.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 30691, 30734);
                    return return_v;
                }


                System.Type
                f_1560_30674_30741(System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>, System.Type>
                this_param, System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>
                key, System.Type
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 30674, 30741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 30553, 30753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 30553, 30753);
            }
        }

        public TypeCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1560, 29520, 30760);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1560, 29520, 30760);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 29520, 30760);
        }


        static TypeCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1560, 29520, 30760);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 30175, 30273);
            s_cache = f_1560_30185_30273(f_1560_30255_30272());
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1560, 29520, 30760);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 29520, 30760);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1560, 29520, 30760);

        static System.Management.Automation.Language.TypeCache.KeyComparer
        f_1560_30255_30272()
        {
            var return_v = new System.Management.Automation.Language.TypeCache.KeyComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 30255, 30272);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>, System.Type>
        f_1560_30185_30273(System.Management.Automation.Language.TypeCache.KeyComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>, System.Type>((System.Collections.Generic.IEqualityComparer<System.Tuple<System.Management.Automation.Language.ITypeName, System.Management.Automation.Language.TypeResolutionState>>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 30185, 30273);
            return return_v;
        }

    }
}

namespace System.Management.Automation
{
    internal static class CoreTypes
    {
        internal static Lazy<Dictionary<Type, string[]>> Items;

        internal static bool Contains(Type inputType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 40604, 41244);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 40674, 40773) || true) && (f_1560_40678_40712(f_1560_40678_40689(Items), inputType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 40674, 40773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 40746, 40758);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 40674, 40773);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 40789, 40870) || true) && (f_1560_40793_40809(inputType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 40789, 40870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 40843, 40855);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 40789, 40870);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 40886, 41150) || true) && (f_1560_40890_40913(inputType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 40886, 41150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 40947, 41012);

                    var
                    genericTypeDefinition = f_1560_40975_41011(inputType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 41030, 41135);

                    return genericTypeDefinition == typeof(Nullable<>) || (DynAbs.Tracing.TraceSender.Expression_False(1560, 41037, 41134) || genericTypeDefinition == typeof(FlagsExpression<>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 40886, 41150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 41166, 41233);

                return (f_1560_41174_41191(inputType) && (DynAbs.Tracing.TraceSender.Expression_True(1560, 41174, 41231) && f_1560_41195_41231(f_1560_41204_41230(inputType))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 40604, 41244);

                System.Collections.Generic.Dictionary<System.Type, string[]>
                f_1560_40678_40689(System.Lazy<System.Collections.Generic.Dictionary<System.Type, string[]>>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 40678, 40689);
                    return return_v;
                }


                bool
                f_1560_40678_40712(System.Collections.Generic.Dictionary<System.Type, string[]>
                this_param, System.Type
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 40678, 40712);
                    return return_v;
                }


                bool
                f_1560_40793_40809(System.Type
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 40793, 40809);
                    return return_v;
                }


                bool
                f_1560_40890_40913(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 40890, 40913);
                    return return_v;
                }


                System.Type
                f_1560_40975_41011(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 40975, 41011);
                    return return_v;
                }


                bool
                f_1560_41174_41191(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 41174, 41191);
                    return return_v;
                }


                System.Type?
                f_1560_41204_41230(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 41204, 41230);
                    return return_v;
                }


                bool
                f_1560_41195_41231(System.Type
                inputType)
                {
                    var return_v = Contains(inputType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 41195, 41231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 40604, 41244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 40604, 41244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CoreTypes()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1560, 30903, 41251);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 31755, 40591);
            Items = f_1560_31763_40591(() =>
                            new Dictionary<Type, string[]>
                            {
                    { typeof(AliasAttribute),                              new[] { "Alias" } },
                    { typeof(AllowEmptyCollectionAttribute),               new[] { "AllowEmptyCollection" } },
                    { typeof(AllowEmptyStringAttribute),                   new[] { "AllowEmptyString" } },
                    { typeof(AllowNullAttribute),                          new[] { "AllowNull" } },
                    { typeof(ArgumentCompleterAttribute),                  new[] { "ArgumentCompleter" } },
                    { typeof(ArgumentCompletionsAttribute),                new[] { "ArgumentCompletions" } },
                    { typeof(Array),                                       new[] { "array" } },
                    { typeof(bool),                                        new[] { "bool" } },
                    { typeof(byte),                                        new[] { "byte" } },
                    { typeof(char),                                        new[] { "char" } },
                    { typeof(CmdletBindingAttribute),                      new[] { "CmdletBinding" } },
                    { typeof(DateTime),                                    new[] { "datetime" } },
                    { typeof(decimal),                                     new[] { "decimal" } },
                    { typeof(double),                                      new[] { "double" } },
                    { typeof(DscResourceAttribute),                        new[] { "DscResource" } },
                    { typeof(ExperimentAction),                            new[] { "ExperimentAction" } },
                    { typeof(ExperimentalAttribute),                       new[] { "Experimental" } },
                    { typeof(ExperimentalFeature),                         new[] { "ExperimentalFeature" } },
                    { typeof(float),                                       new[] { "float", "single" } },
                    { typeof(Guid),                                        new[] { "guid" } },
                    { typeof(Hashtable),                                   new[] { "hashtable" } },
                    { typeof(int),                                         new[] { "int", "int32" } },
                    { typeof(Int16),                                       new[] { "short", "int16" } },
                    { typeof(long),                                        new[] { "long", "int64" } },
                    { typeof(CimInstance),                                 new[] { "ciminstance" } },
                    { typeof(CimClass),                                    new[] { "cimclass" } },
                    { typeof(Microsoft.Management.Infrastructure.CimType), new[] { "cimtype" } },
                    { typeof(CimConverter),                                new[] { "cimconverter" } },
                    { typeof(ModuleSpecification),                         null },
                    { typeof(IPEndPoint),                                  new[] { "IPEndpoint" } },
                    { typeof(NullString),                                  new[] { "NullString" } },
                    { typeof(OutputTypeAttribute),                         new[] { "OutputType" } },
                    { typeof(object[]),                                    null },
                    { typeof(ObjectSecurity),                              new[] { "ObjectSecurity" } },
                    { typeof(ParameterAttribute),                          new[] { "Parameter" } },
                    { typeof(PhysicalAddress),                             new[] { "PhysicalAddress" } },
                    { typeof(PSCredential),                                new[] { "pscredential" } },
                    { typeof(PSDefaultValueAttribute),                     new[] { "PSDefaultValue" } },
                    { typeof(PSListModifier),                              new[] { "pslistmodifier" } },
                    { typeof(PSObject),                                    new[] { "psobject", "pscustomobject" } },
                    { typeof(PSPrimitiveDictionary),                       new[] { "psprimitivedictionary" } },
                    { typeof(PSReference),                                 new[] { "ref" } },
                    { typeof(PSTypeNameAttribute),                         new[] { "PSTypeNameAttribute" } },
                    { typeof(Regex),                                       new[] { "regex" } },
                    { typeof(DscPropertyAttribute),                        new[] { "DscProperty" } },
                    { typeof(sbyte),                                       new[] { "sbyte" } },
                    { typeof(string),                                      new[] { "string" } },
                    { typeof(SupportsWildcardsAttribute),                  new[] { "SupportsWildcards" } },
                    { typeof(SwitchParameter),                             new[] { "switch" } },
                    { typeof(CultureInfo),                                 new[] { "cultureinfo" } },
                    { typeof(BigInteger),                                  new[] { "bigint" } },
                    { typeof(SecureString),                                new[] { "securestring" } },
                    { typeof(TimeSpan),                                    new[] { "timespan" } },
                    { typeof(UInt16),                                      new[] { "ushort", "uint16" } },
                    { typeof(UInt32),                                      new[] { "uint", "uint32" } },
                    { typeof(UInt64),                                      new[] { "ulong", "uint64" } },
                    { typeof(Uri),                                         new[] { "uri" } },
                    { typeof(ValidateCountAttribute),                      new[] { "ValidateCount" } },
                    { typeof(ValidateDriveAttribute),                      new[] { "ValidateDrive" } },
                    { typeof(ValidateLengthAttribute),                     new[] { "ValidateLength" } },
                    { typeof(ValidateNotNullAttribute),                    new[] { "ValidateNotNull" } },
                    { typeof(ValidateNotNullOrEmptyAttribute),             new[] { "ValidateNotNullOrEmpty" } },
                    { typeof(ValidatePatternAttribute),                    new[] { "ValidatePattern" } },
                    { typeof(ValidateRangeAttribute),                      new[] { "ValidateRange" } },
                    { typeof(ValidateScriptAttribute),                     new[] { "ValidateScript" } },
                    { typeof(ValidateSetAttribute),                        new[] { "ValidateSet" } },
                    { typeof(ValidateTrustedDataAttribute),                new[] { "ValidateTrustedData" } },
                    { typeof(ValidateUserDriveAttribute),                  new[] { "ValidateUserDrive"} },
                    { typeof(Version),                                     new[] { "version" } },
                    { typeof(void),                                        new[] { "void" } },
                    { typeof(IPAddress),                                   new[] { "ipaddress" } },
                    { typeof(DscLocalConfigurationManagerAttribute),       new[] {"DscLocalConfigurationManager"}},
                    { typeof(WildcardPattern),                             new[] { "WildcardPattern" } },
                    { typeof(X509Certificate),                             new[] { "X509Certificate" } },
                    { typeof(X500DistinguishedName),                       new[] { "X500DistinguishedName" } },
                    { typeof(XmlDocument),                                 new[] { "xml" } },
                    { typeof(CimSession),                                  new[] { "CimSession" } },
                    { typeof(MailAddress),                                 new[] { "mailaddress" } },
                    { typeof(SemanticVersion),                             new[] { "semver" } },
#if !UNIX
                    { typeof(DirectoryEntry),                              new[] { "adsi" } },
                    { typeof(DirectorySearcher),                           new[] { "adsisearcher" } },
                    { typeof(ManagementClass),                             new[] { "wmiclass" } },
                    { typeof(ManagementObject),                            new[] { "wmi" } },
                    { typeof(ManagementObjectSearcher),                    new[] { "wmisearcher" } }
#endif
                            });
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1560, 30903, 41251);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 30903, 41251);
        }


        static System.Lazy<System.Collections.Generic.Dictionary<System.Type, string[]>>
        f_1560_31763_40591(System.Func<System.Collections.Generic.Dictionary<System.Type, string[]>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Generic.Dictionary<System.Type, string[]>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 31763, 40591);
            return return_v;
        }

    }
    internal static class TypeAccelerators
    {
        internal static Dictionary<string, Type> builtinTypeAccelerators;

        internal static Dictionary<string, Type> userTypeAccelerators;

        private static Dictionary<string, Type> s_allTypeAccelerators;

        static TypeAccelerators()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1560, 42396, 44222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 41680, 41772);
                builtinTypeAccelerators = f_1560_41706_41772(64, f_1560_41739_41771());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 42030, 42119);
                userTypeAccelerators = f_1560_42053_42119(64, f_1560_42086_42118());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 42362, 42383);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 42485, 42865);
                    foreach (KeyValuePair<Type, string[]> coreType in f_1560_42535_42556_I(f_1560_42535_42556(CoreTypes.Items)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 42485, 42865);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 42590, 42850) || true) && (coreType.Value != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 42590, 42850);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 42658, 42831);
                                foreach (string accelerator in f_1560_42689_42703_I(coreType.Value))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 42658, 42831);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 42753, 42808);

                                    f_1560_42753_42807(builtinTypeAccelerators, accelerator, coreType.Key);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 42658, 42831);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 174);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 174);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 42590, 42850);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 42485, 42865);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 381);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43069, 43133);

                f_1560_43069_43132(
                            // Add additional utility types that are useful as type accelerators, but aren't
                            // fundamentally "core language", or may be unsafe to expose to untrusted input.
                            builtinTypeAccelerators, "scriptblock", typeof(ScriptBlock));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43147, 43229);

                f_1560_43147_43228(builtinTypeAccelerators, "pspropertyexpression", typeof(PSPropertyExpression));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43243, 43305);

                f_1560_43243_43304(builtinTypeAccelerators, "psvariable", typeof(PSVariable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43319, 43369);

                f_1560_43319_43368(builtinTypeAccelerators, "type", typeof(Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43383, 43449);

                f_1560_43383_43448(builtinTypeAccelerators, "psmoduleinfo", typeof(PSModuleInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43463, 43525);

                f_1560_43463_43524(builtinTypeAccelerators, "powershell", typeof(PowerShell));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43539, 43611);

                f_1560_43539_43610(builtinTypeAccelerators, "runspacefactory", typeof(RunspaceFactory));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43625, 43683);

                f_1560_43625_43682(builtinTypeAccelerators, "runspace", typeof(Runspace));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43697, 43777);

                f_1560_43697_43776(builtinTypeAccelerators, "initialsessionstate", typeof(InitialSessionState));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43791, 43861);

                f_1560_43791_43860(builtinTypeAccelerators, "psscriptmethod", typeof(PSScriptMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43875, 43949);

                f_1560_43875_43948(builtinTypeAccelerators, "psscriptproperty", typeof(PSScriptProperty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 43963, 44033);

                f_1560_43963_44032(builtinTypeAccelerators, "psnoteproperty", typeof(PSNoteProperty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 44047, 44119);

                f_1560_44047_44118(builtinTypeAccelerators, "psaliasproperty", typeof(PSAliasProperty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 44133, 44211);

                f_1560_44133_44210(builtinTypeAccelerators, "psvariableproperty", typeof(PSVariableProperty));
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1560, 42396, 44222);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 42396, 44222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 42396, 44222);
            }
        }

        internal static string FindBuiltinAccelerator(Type type, string expectedKey = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 44234, 45174);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 44463, 45135) || true) && (expectedKey == null || (DynAbs.Tracing.TraceSender.Expression_False(1560, 44467, 44530) || f_1560_44490_44530(typeof(Attribute), type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 44463, 45135);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 44564, 44806);
                        foreach (KeyValuePair<string, Type> entry in f_1560_44609_44632_I(builtinTypeAccelerators))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 44564, 44806);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 44674, 44787) || true) && (entry.Value == type)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 44674, 44787);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 44747, 44764);

                                return entry.Key;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 44674, 44787);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 44564, 44806);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 243);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 243);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 44463, 45135);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 44463, 45135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 44872, 44895);

                    Type
                    resultType = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 44913, 44978);

                    f_1560_44913_44977(builtinTypeAccelerators, expectedKey, out resultType);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 44996, 45120) || true) && (resultType != null && (DynAbs.Tracing.TraceSender.Expression_True(1560, 45000, 45040) && resultType == type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 44996, 45120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 45082, 45101);

                        return expectedKey;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 44996, 45120);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 44463, 45135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 45151, 45163);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 44234, 45174);

                bool
                f_1560_44490_44530(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 44490, 44530);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Type>
                f_1560_44609_44632_I(System.Collections.Generic.Dictionary<string, System.Type>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 44609, 44632);
                    return return_v;
                }


                bool
                f_1560_44913_44977(System.Collections.Generic.Dictionary<string, System.Type>
                this_param, string
                key, out System.Type
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 44913, 44977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 44234, 45174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 44234, 45174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void Add(string typeName, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 45413, 45672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 45488, 45526);

                userTypeAccelerators[typeName] = type;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 45540, 45661) || true) && (s_allTypeAccelerators != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 45540, 45661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 45607, 45646);

                    s_allTypeAccelerators[typeName] = type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 45540, 45661);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 45413, 45672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 45413, 45672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 45413, 45672);
            }
        }

        public static bool Remove(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 45928, 46207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 45995, 46033);

                f_1560_45995_46032(userTypeAccelerators, typeName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 46047, 46168) || true) && (s_allTypeAccelerators != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 46047, 46168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 46114, 46153);

                    f_1560_46114_46152(s_allTypeAccelerators, typeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 46047, 46168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 46184, 46196);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 45928, 46207);

                bool
                f_1560_45995_46032(System.Collections.Generic.Dictionary<string, System.Type>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 45995, 46032);
                    return return_v;
                }


                bool
                f_1560_46114_46152(System.Collections.Generic.Dictionary<string, System.Type>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 46114, 46152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 45928, 46207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 45928, 46207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Dictionary<string, Type> Get
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 46865, 47201);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 46901, 47137) || true) && (s_allTypeAccelerators == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 46901, 47137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 46976, 47063);

                        s_allTypeAccelerators = f_1560_47000_47062(f_1560_47029_47061());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 47085, 47118);

                        f_1560_47085_47117(s_allTypeAccelerators);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 46901, 47137);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 47157, 47186);

                    return s_allTypeAccelerators;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 46865, 47201);

                    System.StringComparer
                    f_1560_47029_47061()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 47029, 47061);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Type>
                    f_1560_47000_47062(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Type>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 47000, 47062);
                        return return_v;
                    }


                    int
                    f_1560_47085_47117(System.Collections.Generic.Dictionary<string, System.Type>
                    cache)
                    {
                        FillCache(cache);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 47085, 47117);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 46798, 47212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 46798, 47212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static void FillCache(Dictionary<string, Type> cache)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1560, 47224, 47625);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 47311, 47456);
                    foreach (KeyValuePair<string, Type> val in f_1560_47354_47377_I(builtinTypeAccelerators))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 47311, 47456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 47411, 47441);

                        f_1560_47411_47440(cache, val.Key, val.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 47311, 47456);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 146);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 47472, 47614);
                    foreach (KeyValuePair<string, Type> val in f_1560_47515_47535_I(userTypeAccelerators))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1560, 47472, 47614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1560, 47569, 47599);

                        f_1560_47569_47598(cache, val.Key, val.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1560, 47472, 47614);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1560, 1, 143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1560, 1, 143);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1560, 47224, 47625);

                int
                f_1560_47411_47440(System.Collections.Generic.Dictionary<string, System.Type>
                this_param, string
                key, System.Type
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 47411, 47440);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Type>
                f_1560_47354_47377_I(System.Collections.Generic.Dictionary<string, System.Type>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 47354, 47377);
                    return return_v;
                }


                int
                f_1560_47569_47598(System.Collections.Generic.Dictionary<string, System.Type>
                this_param, string
                key, System.Type
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 47569, 47598);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Type>
                f_1560_47515_47535_I(System.Collections.Generic.Dictionary<string, System.Type>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 47515, 47535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1560, 47224, 47625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1560, 47224, 47625);
            }
        }

        static System.StringComparer
        f_1560_41739_41771()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 41739, 41771);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, System.Type>
        f_1560_41706_41772(int
        capacity, System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Type>(capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 41706, 41772);
            return return_v;
        }


        static System.StringComparer
        f_1560_42086_42118()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 42086, 42118);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, System.Type>
        f_1560_42053_42119(int
        capacity, System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Type>(capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 42053, 42119);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<System.Type, string[]>
        f_1560_42535_42556(System.Lazy<System.Collections.Generic.Dictionary<System.Type, string[]>>
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1560, 42535, 42556);
            return return_v;
        }


        static int
        f_1560_42753_42807(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 42753, 42807);
            return 0;
        }


        static string[]
        f_1560_42689_42703_I(string[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 42689, 42703);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<System.Type, string[]>
        f_1560_42535_42556_I(System.Collections.Generic.Dictionary<System.Type, string[]>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 42535, 42556);
            return return_v;
        }


        static int
        f_1560_43069_43132(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43069, 43132);
            return 0;
        }


        static int
        f_1560_43147_43228(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43147, 43228);
            return 0;
        }


        static int
        f_1560_43243_43304(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43243, 43304);
            return 0;
        }


        static int
        f_1560_43319_43368(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43319, 43368);
            return 0;
        }


        static int
        f_1560_43383_43448(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43383, 43448);
            return 0;
        }


        static int
        f_1560_43463_43524(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43463, 43524);
            return 0;
        }


        static int
        f_1560_43539_43610(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43539, 43610);
            return 0;
        }


        static int
        f_1560_43625_43682(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43625, 43682);
            return 0;
        }


        static int
        f_1560_43697_43776(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43697, 43776);
            return 0;
        }


        static int
        f_1560_43791_43860(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43791, 43860);
            return 0;
        }


        static int
        f_1560_43875_43948(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43875, 43948);
            return 0;
        }


        static int
        f_1560_43963_44032(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 43963, 44032);
            return 0;
        }


        static int
        f_1560_44047_44118(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 44047, 44118);
            return 0;
        }


        static int
        f_1560_44133_44210(System.Collections.Generic.Dictionary<string, System.Type>
        this_param, string
        key, System.Type
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1560, 44133, 44210);
            return 0;
        }

    }
}
