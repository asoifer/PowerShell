// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.PowerShell.Commands;

using CimClass = Microsoft.Management.Infrastructure.CimClass;
using CimInstance = Microsoft.Management.Infrastructure.CimInstance;

namespace System.Management.Automation
{
    /// <summary>
    /// Enum describing permissions to use runtime evaluation during type inference.
    /// </summary>
    public enum TypeInferenceRuntimePermissions
    {
        /// <summary>
        /// No runtime use is allowed.
        /// </summary>
        None = 0,

        /// <summary>
        /// Use of SafeExprEvaluator visitor is allowed.
        /// </summary>
        AllowSafeEval = 1,
    }
    internal static class AstTypeInference
    {
        public static IList<PSTypeName> InferTypeOf(Ast ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 1526, 1676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 1603, 1665);

                return f_1559_1610_1664(ast, TypeInferenceRuntimePermissions.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 1526, 1676);

                System.Collections.Generic.IList<System.Management.Automation.PSTypeName>
                f_1559_1610_1664(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.TypeInferenceRuntimePermissions
                evalPermissions)
                {
                    var return_v = InferTypeOf(ast, evalPermissions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 1610, 1664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 1526, 1676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 1526, 1676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IList<PSTypeName> InferTypeOf(Ast ast, TypeInferenceRuntimePermissions evalPermissions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 2060, 2287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 2186, 2276);

                return f_1559_2193_2275(ast, f_1559_2210_2257(RunspaceMode.CurrentRunspace), evalPermissions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 2060, 2287);

                System.Management.Automation.PowerShell
                f_1559_2210_2257(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 2210, 2257);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSTypeName>
                f_1559_2193_2275(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.PowerShell
                powerShell, System.Management.Automation.TypeInferenceRuntimePermissions
                evalPersmissions)
                {
                    var return_v = InferTypeOf(ast, powerShell, evalPersmissions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 2193, 2275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 2060, 2287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 2060, 2287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IList<PSTypeName> InferTypeOf(Ast ast, PowerShell powerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 2724, 2909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 2824, 2898);

                return f_1559_2831_2897(ast, powerShell, TypeInferenceRuntimePermissions.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 2724, 2909);

                System.Collections.Generic.IList<System.Management.Automation.PSTypeName>
                f_1559_2831_2897(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.PowerShell
                powerShell, System.Management.Automation.TypeInferenceRuntimePermissions
                evalPersmissions)
                {
                    var return_v = InferTypeOf(ast, powerShell, evalPersmissions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 2831, 2897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 2724, 2909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 2724, 2909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IList<PSTypeName> InferTypeOf(Ast ast, PowerShell powerShell, TypeInferenceRuntimePermissions evalPersmissions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 3428, 3705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 3578, 3629);

                var
                context = f_1559_3592_3628(powerShell)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 3643, 3694);

                return f_1559_3650_3693(ast, context, evalPersmissions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 3428, 3705);

                System.Management.Automation.TypeInferenceContext
                f_1559_3592_3628(System.Management.Automation.PowerShell
                powerShell)
                {
                    var return_v = new System.Management.Automation.TypeInferenceContext(powerShell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 3592, 3628);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSTypeName>
                f_1559_3650_3693(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.TypeInferenceContext
                context, System.Management.Automation.TypeInferenceRuntimePermissions
                evalPersmissions)
                {
                    var return_v = InferTypeOf(ast, context, evalPersmissions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 3650, 3693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 3428, 3705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 3428, 3705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IList<PSTypeName> InferTypeOf(
                    Ast ast,
                    TypeInferenceContext context,
                    TypeInferenceRuntimePermissions evalPersmissions = TypeInferenceRuntimePermissions.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 4169, 4841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 4407, 4467);

                var
                originalRuntimePermissions = f_1559_4440_4466(context)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 4517, 4563);

                    context.RuntimePermissions = evalPersmissions;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 4581, 4690);

                    return f_1559_4588_4689(f_1559_4588_4680(f_1559_4588_4645(context, ast, f_1559_4611_4644(context)), f_1559_4655_4679()));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1559, 4719, 4830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 4759, 4815);

                    context.RuntimePermissions = originalRuntimePermissions;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1559, 4719, 4830);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 4169, 4841);

                System.Management.Automation.TypeInferenceRuntimePermissions
                f_1559_4440_4466(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.RuntimePermissions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 4440, 4466);
                    return return_v;
                }


                System.Management.Automation.TypeInferenceVisitor
                f_1559_4611_4644(System.Management.Automation.TypeInferenceContext
                context)
                {
                    var return_v = new System.Management.Automation.TypeInferenceVisitor(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 4611, 4644);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_4588_4645(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.Language.Ast
                ast, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.InferType(ast, visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 4588, 4645);
                    return return_v;
                }


                System.Management.Automation.PSTypeNameComparer
                f_1559_4655_4679()
                {
                    var return_v = new System.Management.Automation.PSTypeNameComparer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 4655, 4679);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_4588_4680(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                source, System.Management.Automation.PSTypeNameComparer
                comparer)
                {
                    var return_v = source.Distinct<System.Management.Automation.PSTypeName>((System.Collections.Generic.IEqualityComparer<System.Management.Automation.PSTypeName>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 4588, 4680);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_4588_4689(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 4588, 4689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 4169, 4841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 4169, 4841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AstTypeInference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1559, 1179, 4848);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1559, 1179, 4848);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 1179, 4848);
        }

    }
    class PSTypeNameComparer : IEqualityComparer<PSTypeName>
    {
        public bool Equals(PSTypeName x, PSTypeName y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 4929, 5040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 5000, 5029);

                return f_1559_5007_5028(f_1559_5007_5013(x), f_1559_5021_5027(y));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 4929, 5040);

                string
                f_1559_5007_5013(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 5007, 5013);
                    return return_v;
                }


                string
                f_1559_5021_5027(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 5021, 5027);
                    return return_v;
                }


                bool
                f_1559_5007_5028(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 5007, 5028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 4929, 5040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 4929, 5040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(PSTypeName obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 5052, 5156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 5115, 5145);

                return f_1559_5122_5144(f_1559_5122_5130(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 5052, 5156);

                string
                f_1559_5122_5130(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 5122, 5130);
                    return return_v;
                }


                int
                f_1559_5122_5144(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 5122, 5144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 5052, 5156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 5052, 5156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSTypeNameComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1559, 4856, 5163);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1559, 4856, 5163);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 4856, 5163);
        }


        static PSTypeNameComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1559, 4856, 5163);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1559, 4856, 5163);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 4856, 5163);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1559, 4856, 5163);
    }
    internal class TypeInferenceContext
    {
        public static readonly PSTypeName[] EmptyPSTypeNameArray;

        private readonly PowerShell _powerShell;

        public TypeInferenceContext() : this(f_1559_5407_5454_C(f_1559_5407_5454(RunspaceMode.CurrentRunspace)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1559, 5370, 5477);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1559, 5370, 5477);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 5370, 5477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 5370, 5477);
            }
        }

        public TypeInferenceContext(PowerShell powerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1559, 5837, 6130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 5346, 5357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6298, 6345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6357, 6420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6432, 6503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6515, 6565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 5912, 6013);

                f_1559_5912_6012(f_1559_5931_5950(powerShell) != null, "Callers are required to ensure we have a runspace");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6027, 6052);

                _powerShell = powerShell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6068, 6119);

                Helper = f_1559_6077_6118(powerShell);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1559, 5837, 6130);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 5837, 6130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 5837, 6130);
            }
        }

        public PSTypeName CurrentThisType { get; set; }

        public TypeDefinitionAst CurrentTypeDefinitionAst { get; set; }

        public TypeInferenceRuntimePermissions RuntimePermissions { get; set; }

        internal PowerShellExecutionHelper Helper { get; }

        internal ExecutionContext ExecutionContext
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 6620, 6660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6623, 6660);
                    return f_1559_6623_6660(f_1559_6623_6643(_powerShell));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 6620, 6660);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 6620, 6660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 6620, 6660);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool TryGetRepresentativeTypeNameFromExpressionSafeEval(ExpressionAst expression, out PSTypeName typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 6673, 7207);
                object value = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6811, 6827);

                typeName = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6841, 6974) || true) && (f_1559_6845_6863() != TypeInferenceRuntimePermissions.AllowSafeEval)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 6841, 6974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6946, 6959);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 6841, 6974);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 6990, 7196);

                return expression != null && (DynAbs.Tracing.TraceSender.Expression_True(1559, 6997, 7113) && f_1559_7039_7113(expression, f_1559_7081_7097(), out value)) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 6997, 7195) && f_1559_7137_7195(value, out typeName));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 6673, 7207);

                System.Management.Automation.TypeInferenceRuntimePermissions
                f_1559_6845_6863()
                {
                    var return_v = RuntimePermissions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 6845, 6863);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1559_7081_7097()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 7081, 7097);
                    return return_v;
                }


                bool
                f_1559_7039_7113(System.Management.Automation.Language.ExpressionAst
                ast, System.Management.Automation.ExecutionContext
                executionContext, out object
                value)
                {
                    var return_v = SafeExprEvaluator.TrySafeEval(ast, executionContext, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 7039, 7113);
                    return return_v;
                }


                bool
                f_1559_7137_7195(object
                value, out System.Management.Automation.PSTypeName
                type)
                {
                    var return_v = TryGetRepresentativeTypeNameFromValue(value, out type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 7137, 7195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 6673, 7207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 6673, 7207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IList<object> GetMembersByInferredType(PSTypeName typename, bool isStatic, Func<object, bool> filter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 7219, 8592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 7354, 7396);

                List<object>
                results = f_1559_7377_7395()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 7412, 7453);

                Func<object, bool>
                filterToCall = filter
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 7467, 7721) || true) && (typename is PSSyntheticTypeName synthetic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 7467, 7721);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 7546, 7706);
                        foreach (var mem in f_1559_7566_7583_I(f_1559_7566_7583(synthetic)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 7546, 7706);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 7625, 7687);

                            f_1559_7625_7686(results, f_1559_7637_7685(mem.Name, mem.PSTypeName));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 7546, 7706);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 161);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 161);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 7467, 7721);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 7737, 8550) || true) && (f_1559_7741_7754(typename) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 7737, 8550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 7796, 7880);

                    f_1559_7796_7879(this, typename, isStatic, filter, filterToCall, results);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 7737, 8550);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 7737, 8550);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 7914, 8550) || true) && (f_1559_7918_7944(typename) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 7914, 8550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 7986, 8075);

                        f_1559_7986_8074(this, typename, isStatic, filter, filterToCall, results);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 7914, 8550);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 7914, 8550);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 8191, 8450) || true) && (!isStatic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 8191, 8450);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 8246, 8319);

                            var
                            consolidatedString = f_1559_8271_8318(new[] { f_1559_8302_8315(typename) })
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 8341, 8431);

                            f_1559_8341_8430(results, f_1559_8358_8429(f_1559_8358_8384(f_1559_8358_8374()), consolidatedString));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 8191, 8450);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 8470, 8535);

                        f_1559_8470_8534(this, typename, results, filterToCall);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 7914, 8550);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 7737, 8550);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 8566, 8581);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 7219, 8592);

                System.Collections.Generic.List<object>
                f_1559_7377_7395()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 7377, 7395);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                f_1559_7566_7583(System.Management.Automation.PSSyntheticTypeName
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 7566, 7583);
                    return return_v;
                }


                System.Management.Automation.PSInferredProperty
                f_1559_7637_7685(string
                name, System.Management.Automation.PSTypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSInferredProperty(name, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 7637, 7685);
                    return return_v;
                }


                int
                f_1559_7625_7686(System.Collections.Generic.List<object>
                this_param, System.Management.Automation.PSInferredProperty
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 7625, 7686);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                f_1559_7566_7583_I(System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 7566, 7583);
                    return return_v;
                }


                System.Type
                f_1559_7741_7754(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 7741, 7754);
                    return return_v;
                }


                int
                f_1559_7796_7879(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.PSTypeName
                typename, bool
                isStatic, System.Func<object, bool>
                filter, System.Func<object, bool>
                filterToCall, System.Collections.Generic.List<object>
                results)
                {
                    this_param.AddMembersByInferredTypesClrType(typename, isStatic, filter, filterToCall, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 7796, 7879);
                    return 0;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_7918_7944(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.TypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 7918, 7944);
                    return return_v;
                }


                int
                f_1559_7986_8074(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.PSTypeName
                typename, bool
                isStatic, System.Func<object, bool>
                filter, System.Func<object, bool>
                filterToCall, System.Collections.Generic.List<object>
                results)
                {
                    this_param.AddMembersByInferredTypeDefinitionAst(typename, isStatic, filter, filterToCall, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 7986, 8074);
                    return 0;
                }


                string
                f_1559_8302_8315(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 8302, 8315);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1559_8271_8318(string[]
                strings)
                {
                    var return_v = new System.Management.Automation.Runspaces.ConsolidatedString((System.Collections.Generic.IEnumerable<string>)strings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 8271, 8318);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1559_8358_8374()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 8358, 8374);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1559_8358_8384(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TypeTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 8358, 8384);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1559_8358_8429(System.Management.Automation.Runspaces.TypeTable
                this_param, System.Management.Automation.Runspaces.ConsolidatedString
                types)
                {
                    var return_v = this_param.GetMembers<System.Management.Automation.PSMemberInfo>(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 8358, 8429);
                    return return_v;
                }


                int
                f_1559_8341_8430(System.Collections.Generic.List<object>
                this_param, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 8341, 8430);
                    return 0;
                }


                int
                f_1559_8470_8534(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.PSTypeName
                typename, System.Collections.Generic.List<object>
                results, System.Func<object, bool>
                filterToCall)
                {
                    this_param.AddMembersByInferredTypeCimType(typename, results, filterToCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 8470, 8534);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 7219, 8592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 7219, 8592);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AddMembersByInferredTypesClrType(PSTypeName typename, bool isStatic, Func<object, bool> filter, Func<object, bool> filterToCall, List<object> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 8604, 10947);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 8793, 9186) || true) && (f_1559_8797_8821() == null || (DynAbs.Tracing.TraceSender.Expression_False(1559, 8797, 8879) || f_1559_8833_8862(f_1559_8833_8857()) != f_1559_8866_8879(typename)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 8793, 9186);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 8913, 9171) || true) && (filterToCall == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 8913, 9171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 8979, 9018);

                        filterToCall = o => !IsMemberHidden(o);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 8913, 9171);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 8913, 9171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9100, 9152);

                        filterToCall = o => !IsMemberHidden(o) && filter(o);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 8913, 9171);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 8793, 9186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9202, 9233);

                IEnumerable<Type>
                elementTypes
                = default(IEnumerable<Type>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9247, 9819) || true) && (f_1559_9251_9272(f_1559_9251_9264(typename)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 9247, 9819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9306, 9362);

                    elementTypes = new[] { f_1559_9329_9359(f_1559_9329_9342(typename)) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 9247, 9819);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 9247, 9819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9428, 9463);

                    var
                    elementList = f_1559_9446_9462()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9481, 9757);
                        foreach (var t in f_1559_9499_9528_I(f_1559_9499_9528(f_1559_9499_9512(typename))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 9481, 9757);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9570, 9738) || true) && (f_1559_9574_9589(t) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 9574, 9646) && f_1559_9593_9621(t) == typeof(IEnumerable<>)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 9570, 9738);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9696, 9715);

                                f_1559_9696_9714(elementList, t);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 9570, 9738);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 9481, 9757);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 277);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 277);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9777, 9804);

                    elementTypes = elementList;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 9247, 9819);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9835, 10936);
                    foreach (var type in f_1559_9856_9891_I(f_1559_9856_9891(elementTypes, f_1559_9877_9890(typename))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 9835, 10936);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 9975, 10235) || true) && (!isStatic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 9975, 10235);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 10030, 10104);

                            var
                            consolidatedString = f_1559_10055_10103(type)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 10126, 10216);

                            f_1559_10126_10215(results, f_1559_10143_10214(f_1559_10143_10169(f_1559_10143_10159()), consolidatedString));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 9975, 10235);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 10255, 10476);

                        var
                        members = (DynAbs.Tracing.TraceSender.Conditional_F1(1559, 10269, 10277) || ((isStatic
                        && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 10311, 10374)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 10408, 10475))) ? f_1559_10311_10374(f_1559_10311_10339(), type) : f_1559_10408_10475(f_1559_10408_10438(), type, false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 10496, 10921) || true) && (filterToCall != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 10496, 10921);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 10562, 10794);
                                foreach (var member in f_1559_10585_10592_I(members))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 10562, 10794);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 10642, 10771) || true) && (f_1559_10646_10666(filterToCall, member))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 10642, 10771);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 10724, 10744);

                                        f_1559_10724_10743(results, member);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 10642, 10771);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 10562, 10794);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 233);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 233);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 10496, 10921);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 10496, 10921);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 10876, 10902);

                            f_1559_10876_10901(results, members);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 10496, 10921);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 9835, 10936);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 1102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 1102);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 8604, 10947);

                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_8797_8821()
                {
                    var return_v = CurrentTypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 8797, 8821);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_8833_8857()
                {
                    var return_v = CurrentTypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 8833, 8857);
                    return return_v;
                }


                System.Type
                f_1559_8833_8862(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 8833, 8862);
                    return return_v;
                }


                System.Type
                f_1559_8866_8879(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 8866, 8879);
                    return return_v;
                }


                System.Type
                f_1559_9251_9264(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 9251, 9264);
                    return return_v;
                }


                bool
                f_1559_9251_9272(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 9251, 9272);
                    return return_v;
                }


                System.Type
                f_1559_9329_9342(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 9329, 9342);
                    return return_v;
                }


                System.Type?
                f_1559_9329_9359(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 9329, 9359);
                    return return_v;
                }


                System.Collections.Generic.List<System.Type>
                f_1559_9446_9462()
                {
                    var return_v = new System.Collections.Generic.List<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 9446, 9462);
                    return return_v;
                }


                System.Type
                f_1559_9499_9512(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 9499, 9512);
                    return return_v;
                }


                System.Type[]
                f_1559_9499_9528(System.Type
                this_param)
                {
                    var return_v = this_param.GetInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 9499, 9528);
                    return return_v;
                }


                bool
                f_1559_9574_9589(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 9574, 9589);
                    return return_v;
                }


                System.Type
                f_1559_9593_9621(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 9593, 9621);
                    return return_v;
                }


                int
                f_1559_9696_9714(System.Collections.Generic.List<System.Type>
                this_param, System.Type
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 9696, 9714);
                    return 0;
                }


                System.Type[]
                f_1559_9499_9528_I(System.Type[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 9499, 9528);
                    return return_v;
                }


                System.Type
                f_1559_9877_9890(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 9877, 9890);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Type>
                f_1559_9856_9891(System.Collections.Generic.IEnumerable<System.Type>
                collection, System.Type
                element)
                {
                    var return_v = collection.Prepend<System.Type>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 9856, 9891);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1559_10055_10103(System.Type
                type)
                {
                    var return_v = DotNetAdapter.GetInternedTypeNameHierarchy(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 10055, 10103);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1559_10143_10159()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 10143, 10159);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1559_10143_10169(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TypeTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 10143, 10169);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1559_10143_10214(System.Management.Automation.Runspaces.TypeTable
                this_param, System.Management.Automation.Runspaces.ConsolidatedString
                types)
                {
                    var return_v = this_param.GetMembers<System.Management.Automation.PSMemberInfo>(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 10143, 10214);
                    return return_v;
                }


                int
                f_1559_10126_10215(System.Collections.Generic.List<object>
                this_param, System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 10126, 10215);
                    return 0;
                }


                System.Management.Automation.DotNetAdapter
                f_1559_10311_10339()
                {
                    var return_v = PSObject.DotNetStaticAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 10311, 10339);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1559_10311_10374(System.Management.Automation.DotNetAdapter
                this_param, System.Type
                obj)
                {
                    var return_v = this_param.BaseGetMembers<System.Management.Automation.PSMemberInfo>((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 10311, 10374);
                    return return_v;
                }


                System.Management.Automation.DotNetAdapter
                f_1559_10408_10438()
                {
                    var return_v = PSObject.DotNetInstanceAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 10408, 10438);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<object>
                f_1559_10408_10475(System.Management.Automation.DotNetAdapter
                this_param, System.Type
                type, bool
                @static)
                {
                    var return_v = this_param.GetPropertiesAndMethods(type, @static);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 10408, 10475);
                    return return_v;
                }


                bool
                f_1559_10646_10666(System.Func<object, bool>
                this_param, object
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 10646, 10666);
                    return return_v;
                }


                int
                f_1559_10724_10743(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 10724, 10743);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<object>
                f_1559_10585_10592_I(System.Collections.Generic.IEnumerable<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 10585, 10592);
                    return return_v;
                }


                int
                f_1559_10876_10901(System.Collections.Generic.List<object>
                this_param, System.Collections.Generic.IEnumerable<object>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 10876, 10901);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Type>
                f_1559_9856_9891_I(System.Collections.Generic.IEnumerable<System.Type>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 9856, 9891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 8604, 10947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 8604, 10947);
            }
        }

        internal void AddMembersByInferredTypeDefinitionAst(
                    PSTypeName typename,
                    bool isStatic,
                    Func<object, bool> filter,
                    Func<object, bool> filterToCall,
                    List<object> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 10959, 14107);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 11219, 11584) || true) && (f_1559_11223_11247() != f_1559_11251_11277(typename))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 11219, 11584);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 11311, 11569) || true) && (filterToCall == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 11311, 11569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 11377, 11416);

                        filterToCall = o => !IsMemberHidden(o);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 11311, 11569);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 11311, 11569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 11498, 11550);

                        filterToCall = o => !IsMemberHidden(o) && filter(o);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 11311, 11569);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 11219, 11584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 11600, 11630);

                bool
                foundConstructor = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 11644, 12437);
                    foreach (var member in f_1559_11667_11701_I(f_1559_11667_11701(f_1559_11667_11693(typename))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 11644, 12437);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 11735, 11744);

                        bool
                        add
                        = default(bool);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 11762, 12175) || true) && (member is PropertyMemberAst propertyMember)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 11762, 12175);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 11850, 11892);

                            add = f_1559_11856_11879(propertyMember) == isStatic;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 11762, 12175);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 11762, 12175);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 11974, 12021);

                            var
                            functionMember = (FunctionMemberAst)member
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12043, 12085);

                            add = f_1559_12049_12072(functionMember) == isStatic;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12107, 12156);

                            foundConstructor |= f_1559_12127_12155(functionMember);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 11762, 12175);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12195, 12314) || true) && (filterToCall != null && (DynAbs.Tracing.TraceSender.Expression_True(1559, 12199, 12226) && add))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 12195, 12314);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12268, 12295);

                            add = f_1559_12274_12294(filterToCall, member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 12195, 12314);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12334, 12422) || true) && (add)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 12334, 12422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12383, 12403);

                            f_1559_12383_12402(results, member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 12334, 12422);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 11644, 12437);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 794);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12502, 12977);
                    foreach (var baseType in f_1559_12527_12563_I(f_1559_12527_12563(f_1559_12527_12553(typename))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 12502, 12977);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12597, 12646);

                        var
                        baseTypeName = f_1559_12616_12633(baseType) as TypeName
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12664, 12758) || true) && (baseTypeName == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 12664, 12758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12730, 12739);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 12664, 12758);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12778, 12838);

                        var
                        baseTypeDefinitionAst = baseTypeName._typeDefinitionAst
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 12856, 12962);

                        f_1559_12856_12961(results, f_1559_12873_12960(this, f_1559_12898_12935(baseTypeDefinitionAst), isStatic, filterToCall));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 12502, 12977);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 476);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 13054, 13981) || true) && (isStatic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 13054, 13981);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 13154, 13404) || true) && (filter == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 13154, 13404);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 13214, 13252);

                        filterToCall = o => !IsConstructor(o);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 13154, 13404);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 13154, 13404);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 13334, 13385);

                        filterToCall = o => !IsConstructor(o) && filter(o);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 13154, 13404);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 13424, 13777) || true) && (!foundConstructor)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 13424, 13777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 13487, 13758);

                        f_1559_13487_13757(results, f_1559_13525_13756(f_1559_13594_13623(), f_1559_13654_13680(typename), SpecialMemberFunctionType.DefaultConstructor));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 13424, 13777);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 13054, 13981);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 13054, 13981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 13944, 13966);

                    filterToCall = filter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 13054, 13981);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 13997, 14096);

                f_1559_13997_14095(
                            results, f_1559_14014_14094(this, f_1559_14039_14069(typeof(object)), isStatic, filterToCall));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 10959, 14107);

                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_11223_11247()
                {
                    var return_v = CurrentTypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 11223, 11247);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_11251_11277(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.TypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 11251, 11277);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_11667_11693(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.TypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 11667, 11693);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                f_1559_11667_11701(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 11667, 11701);
                    return return_v;
                }


                bool
                f_1559_11856_11879(System.Management.Automation.Language.PropertyMemberAst
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 11856, 11879);
                    return return_v;
                }


                bool
                f_1559_12049_12072(System.Management.Automation.Language.FunctionMemberAst
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 12049, 12072);
                    return return_v;
                }


                bool
                f_1559_12127_12155(System.Management.Automation.Language.FunctionMemberAst
                this_param)
                {
                    var return_v = this_param.IsConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 12127, 12155);
                    return return_v;
                }


                bool
                f_1559_12274_12294(System.Func<object, bool>
                this_param, System.Management.Automation.Language.MemberAst
                arg)
                {
                    var return_v = this_param.Invoke((object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 12274, 12294);
                    return return_v;
                }


                int
                f_1559_12383_12402(System.Collections.Generic.List<object>
                this_param, System.Management.Automation.Language.MemberAst
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 12383, 12402);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                f_1559_11667_11701_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 11667, 11701);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_12527_12553(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.TypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 12527, 12553);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                f_1559_12527_12563(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.BaseTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 12527, 12563);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1559_12616_12633(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 12616, 12633);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_12898_12935(System.Management.Automation.Language.TypeDefinitionAst
                typeDefinitionAst)
                {
                    var return_v = new System.Management.Automation.PSTypeName(typeDefinitionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 12898, 12935);
                    return return_v;
                }


                System.Collections.Generic.IList<object>
                f_1559_12873_12960(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.PSTypeName
                typename, bool
                isStatic, System.Func<object, bool>
                filter)
                {
                    var return_v = this_param.GetMembersByInferredType(typename, isStatic, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 12873, 12960);
                    return return_v;
                }


                int
                f_1559_12856_12961(System.Collections.Generic.List<object>
                this_param, System.Collections.Generic.IList<object>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 12856, 12961);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                f_1559_12527_12563_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 12527, 12563);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1559_13594_13623()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 13594, 13623);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_13654_13680(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.TypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 13654, 13680);
                    return return_v;
                }


                System.Management.Automation.Language.CompilerGeneratedMemberFunctionAst
                f_1559_13525_13756(System.Management.Automation.Language.IScriptExtent
                extent, System.Management.Automation.Language.TypeDefinitionAst
                definingType, System.Management.Automation.Language.SpecialMemberFunctionType
                type)
                {
                    var return_v = new System.Management.Automation.Language.CompilerGeneratedMemberFunctionAst(extent, definingType, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 13525, 13756);
                    return return_v;
                }


                int
                f_1559_13487_13757(System.Collections.Generic.List<object>
                this_param, System.Management.Automation.Language.CompilerGeneratedMemberFunctionAst
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 13487, 13757);
                    return 0;
                }


                System.Management.Automation.PSTypeName
                f_1559_14039_14069(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14039, 14069);
                    return return_v;
                }


                System.Collections.Generic.IList<object>
                f_1559_14014_14094(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.PSTypeName
                typename, bool
                isStatic, System.Func<object, bool>
                filter)
                {
                    var return_v = this_param.GetMembersByInferredType(typename, isStatic, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14014, 14094);
                    return return_v;
                }


                int
                f_1559_13997_14095(System.Collections.Generic.List<object>
                this_param, System.Collections.Generic.IList<object>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 13997, 14095);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 10959, 14107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 10959, 14107);
            }
        }

        internal void AddMembersByInferredTypeCimType(PSTypeName typename, List<object> results, Func<object, bool> filterToCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 14119, 15712);
                string cimNamespace = default(string);
                string className = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 14265, 15701) || true) && (f_1559_14269_14344(typename, out cimNamespace, out className))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 14265, 15701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 14378, 14417);

                    var
                    powerShellExecutionHelper = f_1559_14410_14416()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 14435, 14680);

                    f_1559_14435_14679(f_1559_14435_14603(f_1559_14435_14520(powerShellExecutionHelper, "CimCmdlets\\Get-CimClass"), "Namespace", cimNamespace), "Class", className);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 14700, 14772);

                    var
                    classes = f_1559_14714_14771(powerShellExecutionHelper, out _)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 14790, 14828);

                    var
                    cimClasses = f_1559_14807_14827()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 14846, 15059);
                        foreach (var c in f_1559_14864_14871_I(classes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 14846, 15059);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 14913, 15040) || true) && (f_1559_14917_14933(c) is CimClass cc)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 14913, 15040);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 14998, 15017);

                                f_1559_14998_15016(cimClasses, cc);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 14913, 15040);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 14846, 15059);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 214);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 214);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 15079, 15686);
                        foreach (var cimClass in f_1559_15104_15114_I(cimClasses))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 15079, 15686);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 15156, 15667) || true) && (filterToCall == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 15156, 15667);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 15230, 15276);

                                f_1559_15230_15275(results, f_1559_15247_15274(cimClass));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 15156, 15667);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 15156, 15667);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 15374, 15644);
                                    foreach (var prop in f_1559_15395_15422_I(f_1559_15395_15422(cimClass)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 15374, 15644);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 15480, 15617) || true) && (f_1559_15484_15502(filterToCall, prop))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 15480, 15617);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 15568, 15586);

                                            f_1559_15568_15585(results, prop);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 15480, 15617);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 15374, 15644);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 271);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 271);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 15156, 15667);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 15079, 15686);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 608);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 608);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 14265, 15701);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 14119, 15712);

                bool
                f_1559_14269_14344(System.Management.Automation.PSTypeName
                typename, out string
                cimNamespace, out string
                className)
                {
                    var return_v = ParseCimCommandsTypeName(typename, out cimNamespace, out className);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14269, 14344);
                    return return_v;
                }


                System.Management.Automation.PowerShellExecutionHelper
                f_1559_14410_14416()
                {
                    var return_v = Helper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 14410, 14416);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1559_14435_14520(System.Management.Automation.PowerShellExecutionHelper
                helper, string
                command)
                {
                    var return_v = helper.AddCommandWithPreferenceSetting(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14435, 14520);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1559_14435_14603(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14435, 14603);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1559_14435_14679(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14435, 14679);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1559_14714_14771(System.Management.Automation.PowerShellExecutionHelper
                this_param, out System.Exception
                exceptionThrown)
                {
                    var return_v = this_param.ExecuteCurrentPowerShell(out exceptionThrown);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14714, 14771);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.Management.Infrastructure.CimClass>
                f_1559_14807_14827()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.Management.Infrastructure.CimClass>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14807, 14827);
                    return return_v;
                }


                object
                f_1559_14917_14933(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14917, 14933);
                    return return_v;
                }


                int
                f_1559_14998_15016(System.Collections.Generic.List<Microsoft.Management.Infrastructure.CimClass>
                this_param, Microsoft.Management.Infrastructure.CimClass
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14998, 15016);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1559_14864_14871_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 14864, 14871);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.Generic.CimReadOnlyKeyedCollection<Microsoft.Management.Infrastructure.CimPropertyDeclaration>
                f_1559_15247_15274(Microsoft.Management.Infrastructure.CimClass
                this_param)
                {
                    var return_v = this_param.CimClassProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 15247, 15274);
                    return return_v;
                }


                int
                f_1559_15230_15275(System.Collections.Generic.List<object>
                this_param, Microsoft.Management.Infrastructure.Generic.CimReadOnlyKeyedCollection<Microsoft.Management.Infrastructure.CimPropertyDeclaration>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 15230, 15275);
                    return 0;
                }


                Microsoft.Management.Infrastructure.Generic.CimReadOnlyKeyedCollection<Microsoft.Management.Infrastructure.CimPropertyDeclaration>
                f_1559_15395_15422(Microsoft.Management.Infrastructure.CimClass
                this_param)
                {
                    var return_v = this_param.CimClassProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 15395, 15422);
                    return return_v;
                }


                bool
                f_1559_15484_15502(System.Func<object, bool>
                this_param, Microsoft.Management.Infrastructure.CimPropertyDeclaration
                arg)
                {
                    var return_v = this_param.Invoke((object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 15484, 15502);
                    return return_v;
                }


                int
                f_1559_15568_15585(System.Collections.Generic.List<object>
                this_param, Microsoft.Management.Infrastructure.CimPropertyDeclaration
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 15568, 15585);
                    return 0;
                }


                Microsoft.Management.Infrastructure.Generic.CimReadOnlyKeyedCollection<Microsoft.Management.Infrastructure.CimPropertyDeclaration>
                f_1559_15395_15422_I(Microsoft.Management.Infrastructure.Generic.CimReadOnlyKeyedCollection<Microsoft.Management.Infrastructure.CimPropertyDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 15395, 15422);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.Management.Infrastructure.CimClass>
                f_1559_15104_15114_I(System.Collections.Generic.List<Microsoft.Management.Infrastructure.CimClass>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 15104, 15114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 14119, 15712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 14119, 15712);
            }
        }

        internal IEnumerable<PSTypeName> InferType(Ast ast, TypeInferenceVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 15724, 16007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 15830, 15860);

                var
                res = f_1559_15840_15859(ast, visitor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 15874, 15946);

                f_1559_15874_15945(res != null, "Fix visit methods to not return null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 15960, 15996);

                return (IEnumerable<PSTypeName>)res;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 15724, 16007);

                object
                f_1559_15840_15859(System.Management.Automation.Language.Ast
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 15840, 15859);
                    return return_v;
                }


                int
                f_1559_15874_15945(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 15874, 15945);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 15724, 16007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 15724, 16007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetRepresentativeTypeNameFromValue(object value, out PSTypeName type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 16019, 16625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16136, 16148);

                type = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16162, 16585) || true) && (value != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 16162, 16585);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16213, 16352) || true) && (value is IList list
                    && (DynAbs.Tracing.TraceSender.Expression_True(1559, 16217, 16275) && f_1559_16261_16271(list) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 16213, 16352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16317, 16333);

                        value = f_1559_16325_16332(list, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 16213, 16352);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16372, 16401);

                    value = f_1559_16380_16400(value);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16419, 16570) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 16419, 16570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16478, 16517);

                        type = f_1559_16485_16516(f_1559_16500_16515(value));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16539, 16551);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 16419, 16570);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 16162, 16585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16601, 16614);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 16019, 16625);

                int
                f_1559_16261_16271(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 16261, 16271);
                    return return_v;
                }


                object
                f_1559_16325_16332(System.Collections.IList
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 16325, 16332);
                    return return_v;
                }


                object
                f_1559_16380_16400(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 16380, 16400);
                    return return_v;
                }


                System.Type
                f_1559_16500_16515(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 16500, 16515);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_16485_16516(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 16485, 16516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 16019, 16625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 16019, 16625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ParseCimCommandsTypeName(PSTypeName typename, out string cimNamespace, out string className)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 16637, 17576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16775, 16795);

                cimNamespace = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16809, 16826);

                className = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16840, 16922) || true) && (typename == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 16840, 16922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16894, 16907);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 16840, 16922);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16938, 17025) || true) && (f_1559_16942_16955(typename) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 16938, 17025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 16997, 17010);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 16938, 17025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17041, 17148);

                var
                match = f_1559_17053_17147(f_1559_17065_17078(typename), "(?<NetTypeName>.*)#(?<CimNamespace>.*)[/\\\\](?<CimClassName>.*)")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17162, 17242) || true) && (f_1559_17166_17180_M(!match.Success))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 17162, 17242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17214, 17227);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 17162, 17242);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17258, 17412) || true) && (!f_1559_17263_17350(f_1559_17263_17296(f_1559_17263_17290(f_1559_17263_17275(match), "NetTypeName")), f_1559_17321_17349(typeof(CimInstance))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 17258, 17412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17384, 17397);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 17258, 17412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17428, 17478);

                cimNamespace = f_1559_17443_17477(f_1559_17443_17471(f_1559_17443_17455(match), "CimNamespace"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17492, 17539);

                className = f_1559_17504_17538(f_1559_17504_17532(f_1559_17504_17516(match), "CimClassName"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17553, 17565);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 16637, 17576);

                System.Type
                f_1559_16942_16955(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 16942, 16955);
                    return return_v;
                }


                string
                f_1559_17065_17078(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17065, 17078);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1559_17053_17147(string
                input, string
                pattern)
                {
                    var return_v = Regex.Match(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 17053, 17147);
                    return return_v;
                }


                bool
                f_1559_17166_17180_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17166, 17180);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1559_17263_17275(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17263, 17275);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1559_17263_17290(System.Text.RegularExpressions.GroupCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17263, 17290);
                    return return_v;
                }


                string
                f_1559_17263_17296(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17263, 17296);
                    return return_v;
                }


                string
                f_1559_17321_17349(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17321, 17349);
                    return return_v;
                }


                bool
                f_1559_17263_17350(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 17263, 17350);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1559_17443_17455(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17443, 17455);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1559_17443_17471(System.Text.RegularExpressions.GroupCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17443, 17471);
                    return return_v;
                }


                string
                f_1559_17443_17477(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17443, 17477);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1559_17504_17516(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17504, 17516);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1559_17504_17532(System.Text.RegularExpressions.GroupCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17504, 17532);
                    return return_v;
                }


                string
                f_1559_17504_17538(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17504, 17538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 16637, 17576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 16637, 17576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsMemberHidden(object member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 17588, 18214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17662, 18174);

                switch (member)
                {

                    case PSMemberInfo psMemberInfo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 17662, 18174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17763, 17792);

                        return f_1559_17770_17791(psMemberInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 17662, 18174);

                    case MemberInfo memberInfo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 17662, 18174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 17859, 17941);

                        return f_1559_17866_17935(f_1559_17866_17928(memberInfo, typeof(HiddenAttribute), false)) != 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 17662, 18174);

                    case PropertyMemberAst propertyMember:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 17662, 18174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 18019, 18050);

                        return f_1559_18026_18049(propertyMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 17662, 18174);

                    case FunctionMemberAst functionMember:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 17662, 18174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 18128, 18159);

                        return f_1559_18135_18158(functionMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 17662, 18174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 18190, 18203);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 17588, 18214);

                bool
                f_1559_17770_17791(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17770, 17791);
                    return return_v;
                }


                object[]
                f_1559_17866_17928(System.Reflection.MemberInfo
                this_param, System.Type
                attributeType, bool
                inherit)
                {
                    var return_v = this_param.GetCustomAttributes(attributeType, inherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 17866, 17928);
                    return return_v;
                }


                int
                f_1559_17866_17935(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 17866, 17935);
                    return return_v;
                }


                bool
                f_1559_18026_18049(System.Management.Automation.Language.PropertyMemberAst
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 18026, 18049);
                    return return_v;
                }


                bool
                f_1559_18135_18158(System.Management.Automation.Language.FunctionMemberAst
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 18135, 18158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 17588, 18214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 17588, 18214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsConstructor(object member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 18226, 18555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 18299, 18333);

                var
                psMethod = member as PSMethod
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 18347, 18426);

                var
                methodCacheEntry = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(psMethod, 1559, 18370, 18391)?.adapterData as DotNetAdapter.MethodCacheEntry
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 18440, 18544);

                return methodCacheEntry != null && (DynAbs.Tracing.TraceSender.Expression_True(1559, 18447, 18543) && f_1559_18475_18543(methodCacheEntry.methodInformationStructures[0].method));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 18226, 18555);

                bool
                f_1559_18475_18543(System.Reflection.MethodBase
                this_param)
                {
                    var return_v = this_param.IsConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 18475, 18543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 18226, 18555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 18226, 18555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeInferenceContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1559, 5171, 18562);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 5259, 5307);
            EmptyPSTypeNameArray = f_1559_5282_5307();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1559, 5171, 18562);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 5171, 18562);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1559, 5171, 18562);

        static System.Management.Automation.PSTypeName[]
        f_1559_5282_5307()
        {
            var return_v = Array.Empty<PSTypeName>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 5282, 5307);
            return return_v;
        }


        static System.Management.Automation.PowerShell
        f_1559_5407_5454(System.Management.Automation.RunspaceMode
        runspace)
        {
            var return_v = PowerShell.Create(runspace);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 5407, 5454);
            return return_v;
        }


        static System.Management.Automation.PowerShell
        f_1559_5407_5454_C(System.Management.Automation.PowerShell
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1559, 5370, 5477);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1559_5931_5950(System.Management.Automation.PowerShell
        this_param)
        {
            var return_v = this_param.Runspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 5931, 5950);
            return return_v;
        }


        int
        f_1559_5912_6012(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 5912, 6012);
            return 0;
        }


        System.Management.Automation.PowerShellExecutionHelper
        f_1559_6077_6118(System.Management.Automation.PowerShell
        powershell)
        {
            var return_v = new System.Management.Automation.PowerShellExecutionHelper(powershell);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 6077, 6118);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1559_6623_6643(System.Management.Automation.PowerShell
        this_param)
        {
            var return_v = this_param.Runspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 6623, 6643);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1559_6623_6660(System.Management.Automation.Runspaces.Runspace
        this_param)
        {
            var return_v = this_param.ExecutionContext;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 6623, 6660);
            return return_v;
        }

    }
    internal class TypeInferenceVisitor : ICustomAstVisitor2
    {
        private readonly TypeInferenceContext _context;

        private static readonly PSTypeName StringPSTypeName;

        public TypeInferenceVisitor(TypeInferenceContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1559, 18799, 18911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 18681, 18689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 18881, 18900);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1559, 18799, 18911);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 18799, 18911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 18799, 18911);
            }
        }

        private IEnumerable<PSTypeName> InferTypes(Ast ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 18923, 19047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 18999, 19036);

                return f_1559_19006_19035(_context, ast, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 18923, 19047);

                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_19006_19035(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.Language.Ast
                ast, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.InferType(ast, visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 19006, 19035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 18923, 19047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 18923, 19047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitTypeExpression(TypeExpressionAst typeExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 19059, 19238);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 19165, 19227);

                return new[] { f_1559_19180_19224(f_1559_19195_19223(typeExpressionAst)) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 19059, 19238);

                System.Type
                f_1559_19195_19223(System.Management.Automation.Language.TypeExpressionAst
                this_param)
                {
                    var return_v = this_param.StaticType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 19195, 19223);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_19180_19224(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 19180, 19224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 19059, 19238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 19059, 19238);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitMemberExpression(MemberExpressionAst memberExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 19250, 19416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 19362, 19405);

                return f_1559_19369_19404(this, memberExpressionAst);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 19250, 19416);

                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_19369_19404(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.MemberExpressionAst
                memberExpressionAst)
                {
                    var return_v = this_param.InferTypesFrom(memberExpressionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 19369, 19404);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 19250, 19416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 19250, 19416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitInvokeMemberExpression(InvokeMemberExpressionAst invokeMemberExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 19428, 19618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 19558, 19607);

                return f_1559_19565_19606(this, invokeMemberExpressionAst);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 19428, 19618);

                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_19565_19606(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.InvokeMemberExpressionAst
                memberExpressionAst)
                {
                    var return_v = this_param.InferTypesFrom((System.Management.Automation.Language.MemberExpressionAst)memberExpressionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 19565, 19606);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 19428, 19618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 19428, 19618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitArrayExpression(ArrayExpressionAst arrayExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 19630, 19999);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 19739, 19896) || true) && (f_1559_19743_19792(f_1559_19743_19786(f_1559_19743_19775(arrayExpressionAst))) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 19739, 19896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 19831, 19881);

                    return new[] { f_1559_19846_19878(typeof(object[])) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 19739, 19896);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 19912, 19988);

                return new[] { f_1559_19927_19985(this, f_1559_19940_19984(this, f_1559_19951_19983(arrayExpressionAst))) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 19630, 19999);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_19743_19775(System.Management.Automation.Language.ArrayExpressionAst
                this_param)
                {
                    var return_v = this_param.SubExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 19743, 19775);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1559_19743_19786(System.Management.Automation.Language.StatementBlockAst
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 19743, 19786);
                    return return_v;
                }


                int
                f_1559_19743_19792(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 19743, 19792);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_19846_19878(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 19846, 19878);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1559_19951_19983(System.Management.Automation.Language.ArrayExpressionAst
                this_param)
                {
                    var return_v = this_param.SubExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 19951, 19983);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_19940_19984(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 19940, 19984);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_19927_19985(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    var return_v = this_param.GetArrayType(inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 19927, 19985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 19630, 19999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 19630, 19999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 20011, 20418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20111, 20161);

                var
                inferredElementTypes = f_1559_20138_20160()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20175, 20339);
                    foreach (ExpressionAst expression in f_1559_20212_20236_I(f_1559_20212_20236(arrayLiteralAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 20175, 20339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20270, 20324);

                        f_1559_20270_20323(inferredElementTypes, f_1559_20300_20322(this, expression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 20175, 20339);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20355, 20407);

                return new[] { f_1559_20370_20404(this, inferredElementTypes) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 20011, 20418);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_20138_20160()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 20138, 20160);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1559_20212_20236(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 20212, 20236);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_20300_20322(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.ExpressionAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 20300, 20322);
                    return return_v;
                }


                int
                f_1559_20270_20323(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 20270, 20323);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1559_20212_20236_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 20212, 20236);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_20370_20404(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    var return_v = this_param.GetArrayType((System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>)inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 20370, 20404);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 20011, 20418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 20011, 20418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitHashtable(HashtableAst hashtableAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 20430, 23111);
                object nameValue = default(object);
                object safeValue = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20521, 23033) || true) && (f_1559_20525_20557(f_1559_20525_20551(hashtableAst)) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 20521, 23033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20595, 20644);

                    var
                    properties = f_1559_20612_20643()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20664, 22923);
                        foreach (var kv in f_1559_20683_20709_I(f_1559_20683_20709(hashtableAst)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 20664, 22923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20751, 20770);

                            string
                            name = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20792, 20815);

                            string
                            typeName = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20837, 21447) || true) && (f_1559_20841_20849(kv) is StringConstantExpressionAst stringConstantExpressionAst)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 20837, 21447);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 20958, 20999);

                                name = f_1559_20965_20998(stringConstantExpressionAst);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 20837, 21447);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 20837, 21447);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 21049, 21447) || true) && (f_1559_21053_21061(kv) is ConstantExpressionAst constantExpressionAst)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 21049, 21447);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 21158, 21204);

                                    name = f_1559_21165_21203(f_1559_21165_21192(constantExpressionAst));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 21049, 21447);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 21049, 21447);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 21254, 21447) || true) && (f_1559_21258_21346(f_1559_21288_21296(kv), f_1559_21298_21323(_context), out nameValue))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 21254, 21447);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 21396, 21424);

                                        name = f_1559_21403_21423(nameValue);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 21254, 21447);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 21049, 21447);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 20837, 21447);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 21471, 22904) || true) && (name != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 21471, 22904);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 21537, 21557);

                                object
                                value = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 21583, 22651) || true) && (f_1559_21587_21595(kv) is PipelineAst pipelineAst && (DynAbs.Tracing.TraceSender.Expression_True(1559, 21587, 21685) && f_1559_21626_21657(pipelineAst) is ExpressionAst expression))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 21583, 22651);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 21743, 22624);

                                    switch (expression)
                                    {

                                        case ConstantExpressionAst constantExpression:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 21743, 22624);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 21911, 21944);

                                            value = f_1559_21919_21943(constantExpression);
                                            DynAbs.Tracing.TraceSender.TraceBreak(1559, 21982, 21988);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 21743, 22624);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 21743, 22624);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 22068, 22123);

                                            typeName = f_1559_22079_22122_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1559_22079_22116(f_1559_22079_22099(this, f_1559_22090_22098(kv))), 1559, 22079, 22122)?.Name);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 22161, 22547) || true) && (typeName == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 22161, 22547);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 22263, 22508) || true) && (f_1559_22267_22357(expression, f_1559_22309_22334(_context), out safeValue))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 22263, 22508);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 22447, 22465);

                                                    value = safeValue;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 22263, 22508);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 22161, 22547);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(1559, 22587, 22593);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 21743, 22624);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 21583, 22651);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 22679, 22790);

                                var
                                pstypeName = (DynAbs.Tracing.TraceSender.Conditional_F1(1559, 22696, 22709) || ((value != null && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 22712, 22743)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 22746, 22789))) ? f_1559_22712_22743(f_1559_22727_22742(value)) : f_1559_22746_22789(typeName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1559, 22761, 22788) ?? "System.Object"))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 22816, 22881);

                                f_1559_22816_22880(properties, f_1559_22831_22879(name, pstypeName, value));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 21471, 22904);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 20664, 22923);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 2260);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 2260);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 22943, 23018);

                    return new[] { f_1559_22958_23015(typeof(Hashtable), properties) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 20521, 23033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 23049, 23100);

                return new[] { f_1559_23064_23097(typeof(Hashtable)) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 20430, 23111);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1559_20525_20551(System.Management.Automation.Language.HashtableAst
                this_param)
                {
                    var return_v = this_param.KeyValuePairs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 20525, 20551);
                    return return_v;
                }


                int
                f_1559_20525_20557(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 20525, 20557);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                f_1559_20612_20643()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 20612, 20643);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1559_20683_20709(System.Management.Automation.Language.HashtableAst
                this_param)
                {
                    var return_v = this_param.KeyValuePairs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 20683, 20709);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_20841_20849(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 20841, 20849);
                    return return_v;
                }


                string
                f_1559_20965_20998(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 20965, 20998);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_21053_21061(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 21053, 21061);
                    return return_v;
                }


                object
                f_1559_21165_21192(System.Management.Automation.Language.ConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 21165, 21192);
                    return return_v;
                }


                string?
                f_1559_21165_21203(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 21165, 21203);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_21288_21296(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 21288, 21296);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1559_21298_21323(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 21298, 21323);
                    return return_v;
                }


                bool
                f_1559_21258_21346(System.Management.Automation.Language.ExpressionAst
                ast, System.Management.Automation.ExecutionContext
                executionContext, out object
                value)
                {
                    var return_v = SafeExprEvaluator.TrySafeEval(ast, executionContext, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 21258, 21346);
                    return return_v;
                }


                string?
                f_1559_21403_21423(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 21403, 21423);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1559_21587_21595(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 21587, 21595);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_21626_21657(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.GetPureExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 21626, 21657);
                    return return_v;
                }


                object
                f_1559_21919_21943(System.Management.Automation.Language.ConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 21919, 21943);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1559_22090_22098(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 22090, 22098);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_22079_22099(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 22079, 22099);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_22079_22116(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 22079, 22116);
                    return return_v;
                }


                string
                f_1559_22079_22122_M(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 22079, 22122);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1559_22309_22334(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 22309, 22334);
                    return return_v;
                }


                bool
                f_1559_22267_22357(System.Management.Automation.Language.ExpressionAst
                ast, System.Management.Automation.ExecutionContext
                executionContext, out object
                value)
                {
                    var return_v = SafeExprEvaluator.TrySafeEval(ast, executionContext, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 22267, 22357);
                    return return_v;
                }


                System.Type
                f_1559_22727_22742(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 22727, 22742);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_22712_22743(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 22712, 22743);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_22746_22789(string
                name)
                {
                    var return_v = new System.Management.Automation.PSTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 22746, 22789);
                    return return_v;
                }


                System.Management.Automation.PSMemberNameAndType
                f_1559_22831_22879(string
                name, System.Management.Automation.PSTypeName
                typeName, object
                value)
                {
                    var return_v = new System.Management.Automation.PSMemberNameAndType(name, typeName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 22831, 22879);
                    return return_v;
                }


                int
                f_1559_22816_22880(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param, System.Management.Automation.PSMemberNameAndType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 22816, 22880);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1559_20683_20709_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 20683, 20709);
                    return return_v;
                }


                System.Management.Automation.PSSyntheticTypeName
                f_1559_22958_23015(System.Type
                type, System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                membersTypes)
                {
                    var return_v = PSSyntheticTypeName.Create(type, (System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>)membersTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 22958, 23015);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_23064_23097(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 23064, 23097);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 20430, 23111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 20430, 23111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 23123, 23314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 23250, 23303);

                return new[] { f_1559_23265_23300(typeof(ScriptBlock)) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 23123, 23314);

                System.Management.Automation.PSTypeName
                f_1559_23265_23300(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 23265, 23300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 23123, 23314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 23123, 23314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitParenExpression(ParenExpressionAst parenExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 23326, 23494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 23435, 23483);

                return f_1559_23442_23482(f_1559_23442_23469(parenExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 23326, 23494);

                System.Management.Automation.Language.PipelineBaseAst
                f_1559_23442_23469(System.Management.Automation.Language.ParenExpressionAst
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 23442, 23469);
                    return return_v;
                }


                object
                f_1559_23442_23482(System.Management.Automation.Language.PipelineBaseAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 23442, 23482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 23326, 23494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 23326, 23494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 23506, 23693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 23648, 23682);

                return new[] { StringPSTypeName };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 23506, 23693);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 23506, 23693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 23506, 23693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitIndexExpression(IndexExpressionAst indexExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 23705, 23866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 23814, 23855);

                return f_1559_23821_23854(this, indexExpressionAst);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 23705, 23866);

                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_23821_23854(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.IndexExpressionAst
                indexExpressionAst)
                {
                    var return_v = this_param.InferTypeFrom(indexExpressionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 23821, 23854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 23705, 23866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 23705, 23866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 23878, 24063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 24002, 24052);

                return f_1559_24009_24051(f_1559_24009_24038(attributedExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 23878, 24063);

                System.Management.Automation.Language.ExpressionAst
                f_1559_24009_24038(System.Management.Automation.Language.AttributedExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 24009, 24038);
                    return return_v;
                }


                object
                f_1559_24009_24051(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 24009, 24051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 23878, 24063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 23878, 24063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitBlockStatement(BlockStatementAst blockStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 24075, 24235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 24181, 24224);

                return f_1559_24188_24223(f_1559_24188_24210(blockStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 24075, 24235);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_24188_24210(System.Management.Automation.Language.BlockStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 24188, 24210);
                    return return_v;
                }


                object
                f_1559_24188_24223(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 24188, 24223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 24075, 24235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 24075, 24235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitUsingExpression(UsingExpressionAst usingExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 24247, 24420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 24356, 24409);

                return f_1559_24363_24408(f_1559_24363_24395(usingExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 24247, 24420);

                System.Management.Automation.Language.ExpressionAst
                f_1559_24363_24395(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.SubExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 24363, 24395);
                    return return_v;
                }


                object
                f_1559_24363_24408(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 24363, 24408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 24247, 24420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 24247, 24420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitVariableExpression(VariableExpressionAst ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 24432, 24669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 24532, 24575);

                var
                inferredTypes = f_1559_24552_24574()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 24589, 24623);

                f_1559_24589_24622(this, ast, inferredTypes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 24637, 24658);

                return inferredTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 24432, 24669);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_24552_24574()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 24552, 24574);
                    return return_v;
                }


                int
                f_1559_24589_24622(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.VariableExpressionAst
                variableExpressionAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.InferTypeFrom(variableExpressionAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 24589, 24622);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 24432, 24669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 24432, 24669);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitMergingRedirection(MergingRedirectionAst mergingRedirectionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 24681, 24859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 24799, 24848);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 24681, 24859);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 24681, 24859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 24681, 24859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 24871, 25038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 24983, 25027);

                return f_1559_24990_25026(this, f_1559_25001_25025(binaryExpressionAst));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 24871, 25038);

                System.Management.Automation.Language.ExpressionAst
                f_1559_25001_25025(System.Management.Automation.Language.BinaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 25001, 25025);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_24990_25026(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.ExpressionAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 24990, 25026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 24871, 25038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 24871, 25038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 25050, 25419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 25159, 25204);

                var
                tokenKind = f_1559_25175_25203(unaryExpressionAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 25218, 25408);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1559, 25225, 25287) || (((tokenKind == TokenKind.Not || (DynAbs.Tracing.TraceSender.Expression_False(1559, 25226, 25286) || tokenKind == TokenKind.Exclaim))
                && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 25310, 25347)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 25370, 25407))) ? BinaryExpressionAst.BoolTypeNameArray
                : f_1559_25370_25407(f_1559_25370_25394(unaryExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 25050, 25419);

                System.Management.Automation.Language.TokenKind
                f_1559_25175_25203(System.Management.Automation.Language.UnaryExpressionAst
                this_param)
                {
                    var return_v = this_param.TokenKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 25175, 25203);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_25370_25394(System.Management.Automation.Language.UnaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 25370, 25394);
                    return return_v;
                }


                object
                f_1559_25370_25407(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 25370, 25407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 25050, 25419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 25050, 25419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitConvertExpression(ConvertExpressionAst convertExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 25431, 26359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 25733, 25799);

                var
                type = f_1559_25744_25798(f_1559_25744_25778(f_1559_25744_25769(convertExpressionAst)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 25815, 26175) || true) && (type == typeof(PSObject) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 25819, 25902) && f_1559_25847_25873(convertExpressionAst) is HashtableAst hashtableAst))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 25815, 26175);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 25936, 26160) || true) && (f_1559_25940_25981(f_1559_25940_25964(this, hashtableAst)) is PSSyntheticTypeName syntheticTypeName)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 25936, 26160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 26064, 26141);

                        return new[] { f_1559_26079_26138(type, f_1559_26112_26137(syntheticTypeName)) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 25936, 26160);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 25815, 26175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 26191, 26306);

                var
                psTypeName = (DynAbs.Tracing.TraceSender.Conditional_F1(1559, 26208, 26220) || ((type != null && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 26223, 26243)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 26246, 26305))) ? f_1559_26223_26243(type) : f_1559_26246_26305(f_1559_26261_26304(f_1559_26261_26295(f_1559_26261_26286(convertExpressionAst))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 26320, 26348);

                return new[] { psTypeName };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 25431, 26359);

                System.Management.Automation.Language.TypeConstraintAst
                f_1559_25744_25769(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 25744, 25769);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1559_25744_25778(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 25744, 25778);
                    return return_v;
                }


                System.Type
                f_1559_25744_25798(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 25744, 25798);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_25847_25873(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 25847, 25873);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_25940_25964(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.HashtableAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 25940, 25964);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_25940_25981(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 25940, 25981);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                f_1559_26112_26137(System.Management.Automation.PSSyntheticTypeName
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 26112, 26137);
                    return return_v;
                }


                System.Management.Automation.PSSyntheticTypeName
                f_1559_26079_26138(System.Type
                type, System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                membersTypes)
                {
                    var return_v = PSSyntheticTypeName.Create(type, membersTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 26079, 26138);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_26223_26243(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 26223, 26243);
                    return return_v;
                }


                System.Management.Automation.Language.TypeConstraintAst
                f_1559_26261_26286(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 26261, 26286);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1559_26261_26295(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 26261, 26295);
                    return return_v;
                }


                string
                f_1559_26261_26304(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 26261, 26304);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_26246_26305(string
                name)
                {
                    var return_v = new System.Management.Automation.PSTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 26246, 26305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 25431, 26359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 25431, 26359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitConstantExpression(ConstantExpressionAst constantExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 26371, 26663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 26489, 26529);

                var
                value = f_1559_26501_26528(constantExpressionAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 26543, 26652);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1559, 26550, 26563) || ((value != null && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 26566, 26607)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 26610, 26651))) ? new[] { f_1559_26574_26605(f_1559_26589_26604(value)) } : TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 26371, 26663);

                object
                f_1559_26501_26528(System.Management.Automation.Language.ConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 26501, 26528);
                    return return_v;
                }


                System.Type
                f_1559_26589_26604(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 26589, 26604);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_26574_26605(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 26574, 26605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 26371, 26663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 26371, 26663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 26675, 26856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 26811, 26845);

                return new[] { StringPSTypeName };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 26675, 26856);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 26675, 26856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 26675, 26856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitSubExpression(SubExpressionAst subExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 26868, 27033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 26971, 27022);

                return f_1559_26978_27021(f_1559_26978_27008(subExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 26868, 27033);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_26978_27008(System.Management.Automation.Language.SubExpressionAst
                this_param)
                {
                    var return_v = this_param.SubExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 26978, 27008);
                    return return_v;
                }


                object
                f_1559_26978_27021(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 26978, 27021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 26868, 27033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 26868, 27033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitErrorStatement(ErrorStatementAst errorStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 27045, 27694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27151, 27194);

                var
                inferredTypes = f_1559_27171_27193()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27208, 27345);
                    foreach (var ast in f_1559_27228_27256_I(f_1559_27228_27256(errorStatementAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 27208, 27345);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27290, 27330);

                        f_1559_27290_27329(inferredTypes, f_1559_27313_27328(this, ast));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 27208, 27345);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 138);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27361, 27494);
                    foreach (var ast in f_1559_27381_27405_I(f_1559_27381_27405(errorStatementAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 27361, 27494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27439, 27479);

                        f_1559_27439_27478(inferredTypes, f_1559_27462_27477(this, ast));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 27361, 27494);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 134);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27510, 27646);
                    foreach (var ast in f_1559_27530_27557_I(f_1559_27530_27557(errorStatementAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 27510, 27646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27591, 27631);

                        f_1559_27591_27630(inferredTypes, f_1559_27614_27629(this, ast));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 27510, 27646);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27662, 27683);

                return inferredTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 27045, 27694);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_27171_27193()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27171, 27193);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                f_1559_27228_27256(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Conditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 27228, 27256);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_27313_27328(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = this_param.InferTypes(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27313, 27328);
                    return return_v;
                }


                int
                f_1559_27290_27329(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27290, 27329);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                f_1559_27228_27256_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27228, 27256);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                f_1559_27381_27405(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Bodies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 27381, 27405);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_27462_27477(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = this_param.InferTypes(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27462, 27477);
                    return return_v;
                }


                int
                f_1559_27439_27478(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27439, 27478);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                f_1559_27381_27405_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27381, 27405);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                f_1559_27530_27557(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.NestedAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 27530, 27557);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_27614_27629(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = this_param.InferTypes(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27614, 27629);
                    return return_v;
                }


                int
                f_1559_27591_27630(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27591, 27630);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                f_1559_27530_27557_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27530, 27557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 27045, 27694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 27045, 27694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitErrorExpression(ErrorExpressionAst errorExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 27706, 28057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27815, 27858);

                var
                inferredTypes = f_1559_27835_27857()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27872, 28009);
                    foreach (var ast in f_1559_27892_27920_I(f_1559_27892_27920(errorExpressionAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 27872, 28009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 27954, 27994);

                        f_1559_27954_27993(inferredTypes, f_1559_27977_27992(this, ast));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 27872, 28009);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28025, 28046);

                return inferredTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 27706, 28057);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_27835_27857()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27835, 27857);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                f_1559_27892_27920(System.Management.Automation.Language.ErrorExpressionAst
                this_param)
                {
                    var return_v = this_param.NestedAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 27892, 27920);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_27977_27992(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = this_param.InferTypes(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27977, 27992);
                    return return_v;
                }


                int
                f_1559_27954_27993(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27954, 27993);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                f_1559_27892_27920_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Ast>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 27892, 27920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 27706, 28057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 27706, 28057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitScriptBlock(ScriptBlockAst scriptBlockAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 28069, 28879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28166, 28201);

                var
                res = f_1559_28176_28200(10)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28215, 28258);

                var
                beginBlock = f_1559_28232_28257(scriptBlockAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28272, 28319);

                var
                processBlock = f_1559_28291_28318(scriptBlockAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28333, 28372);

                var
                endBlock = f_1559_28348_28371(scriptBlockAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28485, 28593) || true) && (beginBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 28485, 28593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28541, 28578);

                    f_1559_28541_28577(res, f_1559_28554_28576(this, beginBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 28485, 28593);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28609, 28721) || true) && (processBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 28609, 28721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28667, 28706);

                    f_1559_28667_28705(res, f_1559_28680_28704(this, processBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 28609, 28721);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28737, 28841) || true) && (endBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 28737, 28841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28791, 28826);

                    f_1559_28791_28825(res, f_1559_28804_28824(this, endBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 28737, 28841);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28857, 28868);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 28069, 28879);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_28176_28200(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 28176, 28200);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1559_28232_28257(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.BeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 28232, 28257);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1559_28291_28318(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 28291, 28318);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1559_28348_28371(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 28348, 28371);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_28554_28576(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.NamedBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 28554, 28576);
                    return return_v;
                }


                int
                f_1559_28541_28577(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 28541, 28577);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_28680_28704(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.NamedBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 28680, 28704);
                    return return_v;
                }


                int
                f_1559_28667_28705(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 28667, 28705);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_28804_28824(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.NamedBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 28804, 28824);
                    return return_v;
                }


                int
                f_1559_28791_28825(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 28791, 28825);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 28069, 28879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 28069, 28879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitParamBlock(ParamBlockAst paramBlockAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 28891, 29045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 28985, 29034);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 28891, 29045);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 28891, 29045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 28891, 29045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitNamedBlock(NamedBlockAst namedBlockAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 29057, 29472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 29151, 29194);

                var
                inferredTypes = f_1559_29171_29193()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 29217, 29226);
                    for (var
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 29208, 29424) || true) && (index < f_1559_29236_29266(f_1559_29236_29260(namedBlockAst)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 29268, 29275)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 29208, 29424))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 29208, 29424);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 29309, 29351);

                        var
                        ast = f_1559_29319_29350(f_1559_29319_29343(namedBlockAst), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 29369, 29409);

                        f_1559_29369_29408(inferredTypes, f_1559_29392_29407(this, ast));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 217);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 29440, 29461);

                return inferredTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 29057, 29472);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_29171_29193()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 29171, 29193);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1559_29236_29260(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 29236, 29260);
                    return return_v;
                }


                int
                f_1559_29236_29266(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 29236, 29266);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1559_29319_29343(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 29319, 29343);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1559_29319_29350(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 29319, 29350);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_29392_29407(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 29392, 29407);
                    return return_v;
                }


                int
                f_1559_29369_29408(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 29369, 29408);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 29057, 29472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 29057, 29472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitTypeConstraint(TypeConstraintAst typeConstraintAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 29484, 29650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 29590, 29639);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 29484, 29650);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 29484, 29650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 29484, 29650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitAttribute(AttributeAst attributeAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 29662, 29813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 29753, 29802);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 29662, 29813);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 29662, 29813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 29662, 29813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 29825, 30015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 29955, 30004);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 29825, 30015);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 29825, 30015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 29825, 30015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitParameter(ParameterAst parameterAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 30027, 31385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 30118, 30151);

                var
                res = f_1559_30128_30150()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 30165, 30206);

                var
                attributes = f_1559_30182_30205(parameterAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 30220, 30253);

                bool
                typeConstraintAdded = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 30267, 31347);
                    foreach (var attrib in f_1559_30290_30300_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 30267, 31347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 30334, 31332);

                        switch (attrib)
                        {

                            case TypeConstraintAst typeConstraint:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 30334, 31332);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 30454, 30669) || true) && (!typeConstraintAdded)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 30454, 30669);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 30536, 30585);

                                    f_1559_30536_30584(res, f_1559_30544_30583(f_1559_30559_30582(typeConstraint)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 30615, 30642);

                                    typeConstraintAdded = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 30454, 30669);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 30697, 30703);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 30334, 31332);

                            case AttributeAst attributeAst:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 30334, 31332);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 30782, 30819);

                                PSTypeNameAttribute
                                attribute = null
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 30905, 30968);

                                    attribute = f_1559_30917_30944(attributeAst) as PSTypeNameAttribute;
                                }
                                catch (RuntimeException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1559, 31021, 31099);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1559, 31021, 31099);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 31127, 31279) || true) && (attribute != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 31127, 31279);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 31206, 31252);

                                    f_1559_31206_31251(res, f_1559_31214_31250(f_1559_31229_31249(attribute)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 31127, 31279);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 31307, 31313);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 30334, 31332);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 30267, 31347);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 1081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 1081);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 31363, 31374);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 30027, 31385);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_30128_30150()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 30128, 30150);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
                f_1559_30182_30205(System.Management.Automation.Language.ParameterAst
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 30182, 30205);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1559_30559_30582(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 30559, 30582);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_30544_30583(System.Management.Automation.Language.ITypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSTypeName(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 30544, 30583);
                    return return_v;
                }


                int
                f_1559_30536_30584(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 30536, 30584);
                    return 0;
                }


                System.Attribute
                f_1559_30917_30944(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.GetAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 30917, 30944);
                    return return_v;
                }


                string
                f_1559_31229_31249(System.Management.Automation.PSTypeNameAttribute
                this_param)
                {
                    var return_v = this_param.PSTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 31229, 31249);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_31214_31250(string
                name)
                {
                    var return_v = new System.Management.Automation.PSTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 31214, 31250);
                    return return_v;
                }


                int
                f_1559_31206_31251(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 31206, 31251);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
                f_1559_30290_30300_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 30290, 30300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 30027, 31385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 30027, 31385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 31397, 31575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 31515, 31564);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 31397, 31575);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 31397, 31575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 31397, 31575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitStatementBlock(StatementBlockAst statementBlockAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 31587, 31935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 31693, 31736);

                var
                inferredTypes = f_1559_31713_31735()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 31750, 31887);
                    foreach (var ast in f_1559_31770_31798_I(f_1559_31770_31798(statementBlockAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 31750, 31887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 31832, 31872);

                        f_1559_31832_31871(inferredTypes, f_1559_31855_31870(this, ast));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 31750, 31887);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 31903, 31924);

                return inferredTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 31587, 31935);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_31713_31735()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 31713, 31735);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1559_31770_31798(System.Management.Automation.Language.StatementBlockAst
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 31770, 31798);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_31855_31870(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 31855, 31870);
                    return return_v;
                }


                int
                f_1559_31832_31871(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 31832, 31871);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1559_31770_31798_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 31770, 31798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 31587, 31935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 31587, 31935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitIfStatement(IfStatementAst ifStmtAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 31947, 32430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32039, 32072);

                var
                res = f_1559_32049_32071()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32088, 32216);
                    foreach (var clause in f_1559_32111_32128_I(f_1559_32111_32128(ifStmtAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 32088, 32216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32162, 32201);

                        f_1559_32162_32200(res, f_1559_32175_32199(this, f_1559_32186_32198(clause)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 32088, 32216);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32232, 32270);

                var
                elseClause = f_1559_32249_32269(ifStmtAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32284, 32392) || true) && (elseClause != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 32284, 32392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32340, 32377);

                    f_1559_32340_32376(res, f_1559_32353_32375(this, elseClause));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 32284, 32392);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32408, 32419);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 31947, 32430);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_32049_32071()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32049, 32071);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>>
                f_1559_32111_32128(System.Management.Automation.Language.IfStatementAst
                this_param)
                {
                    var return_v = this_param.Clauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 32111, 32128);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1559_32186_32198(System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 32186, 32198);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_32175_32199(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32175, 32199);
                    return return_v;
                }


                int
                f_1559_32162_32200(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32162, 32200);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>>
                f_1559_32111_32128_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32111, 32128);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1559_32249_32269(System.Management.Automation.Language.IfStatementAst
                this_param)
                {
                    var return_v = this_param.ElseClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 32249, 32269);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_32353_32375(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32353, 32375);
                    return return_v;
                }


                int
                f_1559_32340_32376(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32340, 32376);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 31947, 32430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 31947, 32430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitTrap(TrapStatementAst trapStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 32442, 32589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32536, 32578);

                return f_1559_32543_32577(f_1559_32543_32564(trapStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 32442, 32589);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_32543_32564(System.Management.Automation.Language.TrapStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 32543, 32564);
                    return return_v;
                }


                object
                f_1559_32543_32577(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32543, 32577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 32442, 32589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 32442, 32589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitSwitchStatement(SwitchStatementAst switchStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 32601, 33171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32710, 32744);

                var
                res = f_1559_32720_32743(8)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32758, 32799);

                var
                clauses = f_1559_32772_32798(switchStatementAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32813, 32863);

                var
                defaultStatement = f_1559_32836_32862(switchStatementAst)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32879, 32997);
                    foreach (var clause in f_1559_32902_32909_I(clauses))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 32879, 32997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 32943, 32982);

                        f_1559_32943_32981(res, f_1559_32956_32980(this, f_1559_32967_32979(clause)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 32879, 32997);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 119);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 33013, 33133) || true) && (defaultStatement != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 33013, 33133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 33075, 33118);

                    f_1559_33075_33117(res, f_1559_33088_33116(this, defaultStatement));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 33013, 33133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 33149, 33160);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 32601, 33171);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_32720_32743(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32720, 32743);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementBlockAst>>
                f_1559_32772_32798(System.Management.Automation.Language.SwitchStatementAst
                this_param)
                {
                    var return_v = this_param.Clauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 32772, 32798);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1559_32836_32862(System.Management.Automation.Language.SwitchStatementAst
                this_param)
                {
                    var return_v = this_param.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 32836, 32862);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1559_32967_32979(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementBlockAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 32967, 32979);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_32956_32980(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32956, 32980);
                    return return_v;
                }


                int
                f_1559_32943_32981(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32943, 32981);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementBlockAst>>
                f_1559_32902_32909_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementBlockAst>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 32902, 32909);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_33088_33116(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 33088, 33116);
                    return return_v;
                }


                int
                f_1559_33075_33117(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 33075, 33117);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 32601, 33171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 32601, 33171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitDataStatement(DataStatementAst dataStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 33183, 33339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 33286, 33328);

                return f_1559_33293_33327(f_1559_33293_33314(dataStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 33183, 33339);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_33293_33314(System.Management.Automation.Language.DataStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 33293, 33314);
                    return return_v;
                }


                object
                f_1559_33293_33327(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 33293, 33327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 33183, 33339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 33183, 33339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitForEachStatement(ForEachStatementAst forEachStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 33351, 33519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 33463, 33508);

                return f_1559_33470_33507(f_1559_33470_33494(forEachStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 33351, 33519);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_33470_33494(System.Management.Automation.Language.ForEachStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 33470, 33494);
                    return return_v;
                }


                object
                f_1559_33470_33507(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 33470, 33507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 33351, 33519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 33351, 33519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 33531, 33699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 33643, 33688);

                return f_1559_33650_33687(f_1559_33650_33674(doWhileStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 33531, 33699);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_33650_33674(System.Management.Automation.Language.DoWhileStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 33650, 33674);
                    return return_v;
                }


                object
                f_1559_33650_33687(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 33650, 33687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 33531, 33699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 33531, 33699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitForStatement(ForStatementAst forStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 33711, 33863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 33811, 33852);

                return f_1559_33818_33851(f_1559_33818_33838(forStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 33711, 33863);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_33818_33838(System.Management.Automation.Language.ForStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 33818, 33838);
                    return return_v;
                }


                object
                f_1559_33818_33851(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 33818, 33851);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 33711, 33863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 33711, 33863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitWhileStatement(WhileStatementAst whileStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 33875, 34035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 33981, 34024);

                return f_1559_33988_34023(f_1559_33988_34010(whileStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 33875, 34035);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_33988_34010(System.Management.Automation.Language.WhileStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 33988, 34010);
                    return return_v;
                }


                object
                f_1559_33988_34023(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 33988, 34023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 33875, 34035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 33875, 34035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitCatchClause(CatchClauseAst catchClauseAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 34047, 34195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 34144, 34184);

                return f_1559_34151_34183(f_1559_34151_34170(catchClauseAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 34047, 34195);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_34151_34170(System.Management.Automation.Language.CatchClauseAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 34151, 34170);
                    return return_v;
                }


                object
                f_1559_34151_34183(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 34151, 34183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 34047, 34195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 34047, 34195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitTryStatement(TryStatementAst tryStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 34207, 34753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 34307, 34341);

                var
                res = f_1559_34317_34340(5)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 34355, 34402);

                f_1559_34355_34401(res, f_1559_34368_34400(this, f_1559_34379_34399(tryStatementAst)));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 34416, 34565);
                    foreach (var catchClauseAst in f_1559_34447_34475_I(f_1559_34447_34475(tryStatementAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 34416, 34565);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 34509, 34550);

                        f_1559_34509_34549(res, f_1559_34522_34548(this, catchClauseAst));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 34416, 34565);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 150);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 34581, 34715) || true) && (f_1559_34585_34608(tryStatementAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 34581, 34715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 34650, 34700);

                    f_1559_34650_34699(res, f_1559_34663_34698(this, f_1559_34674_34697(tryStatementAst)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 34581, 34715);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 34731, 34742);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 34207, 34753);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_34317_34340(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 34317, 34340);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1559_34379_34399(System.Management.Automation.Language.TryStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 34379, 34399);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_34368_34400(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 34368, 34400);
                    return return_v;
                }


                int
                f_1559_34355_34401(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 34355, 34401);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
                f_1559_34447_34475(System.Management.Automation.Language.TryStatementAst
                this_param)
                {
                    var return_v = this_param.CatchClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 34447, 34475);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_34522_34548(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CatchClauseAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 34522, 34548);
                    return return_v;
                }


                int
                f_1559_34509_34549(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 34509, 34549);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
                f_1559_34447_34475_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 34447, 34475);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1559_34585_34608(System.Management.Automation.Language.TryStatementAst
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 34585, 34608);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1559_34674_34697(System.Management.Automation.Language.TryStatementAst
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 34674, 34697);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_34663_34698(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 34663, 34698);
                    return return_v;
                }


                int
                f_1559_34650_34699(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 34650, 34699);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 34207, 34753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 34207, 34753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitBreakStatement(BreakStatementAst breakStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 34765, 34931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 34871, 34920);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 34765, 34931);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 34765, 34931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 34765, 34931);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitContinueStatement(ContinueStatementAst continueStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 34943, 35118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 35058, 35107);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 34943, 35118);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 34943, 35118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 34943, 35118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitReturnStatement(ReturnStatementAst returnStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 35130, 35298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 35239, 35287);

                return f_1559_35246_35286(f_1559_35246_35273(returnStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 35130, 35298);

                System.Management.Automation.Language.PipelineBaseAst
                f_1559_35246_35273(System.Management.Automation.Language.ReturnStatementAst
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 35246, 35273);
                    return return_v;
                }


                object
                f_1559_35246_35286(System.Management.Automation.Language.PipelineBaseAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 35246, 35286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 35130, 35298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 35130, 35298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitExitStatement(ExitStatementAst exitStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 35310, 35473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 35413, 35462);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 35310, 35473);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 35310, 35473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 35310, 35473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitThrowStatement(ThrowStatementAst throwStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 35485, 35651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 35591, 35640);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 35485, 35651);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 35485, 35651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 35485, 35651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 35663, 35831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 35775, 35820);

                return f_1559_35782_35819(f_1559_35782_35806(doUntilStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 35663, 35831);

                System.Management.Automation.Language.StatementBlockAst
                f_1559_35782_35806(System.Management.Automation.Language.DoUntilStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 35782, 35806);
                    return return_v;
                }


                object
                f_1559_35782_35819(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 35782, 35819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 35663, 35831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 35663, 35831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 35843, 36023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 35964, 36012);

                return f_1559_35971_36011(f_1559_35971_35998(assignmentStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 35843, 36023);

                System.Management.Automation.Language.ExpressionAst
                f_1559_35971_35998(System.Management.Automation.Language.AssignmentStatementAst
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 35971, 35998);
                    return return_v;
                }


                object
                f_1559_35971_36011(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 35971, 36011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 35843, 36023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 35843, 36023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitPipeline(PipelineAst pipelineAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 36035, 36298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 36123, 36186);

                var
                pipelineAstPipelineElements = f_1559_36157_36185(pipelineAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 36200, 36287);

                return f_1559_36207_36286(f_1559_36207_36273(pipelineAstPipelineElements, f_1559_36235_36268(pipelineAstPipelineElements) - 1), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 36035, 36298);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1559_36157_36185(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 36157, 36185);
                    return return_v;
                }


                int
                f_1559_36235_36268(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 36235, 36268);
                    return return_v;
                }


                System.Management.Automation.Language.CommandBaseAst
                f_1559_36207_36273(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 36207, 36273);
                    return return_v;
                }


                object
                f_1559_36207_36286(System.Management.Automation.Language.CommandBaseAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 36207, 36286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 36035, 36298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 36035, 36298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitCommand(CommandAst commandAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 36310, 36540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 36395, 36438);

                var
                inferredTypes = f_1559_36415_36437()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 36452, 36494);

                f_1559_36452_36493(this, commandAst, inferredTypes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 36508, 36529);

                return inferredTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 36310, 36540);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_36415_36437()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 36415, 36437);
                    return return_v;
                }


                int
                f_1559_36452_36493(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandAst
                commandAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.InferTypesFrom(commandAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 36452, 36493);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 36310, 36540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 36310, 36540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitCommandExpression(CommandExpressionAst commandExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 36552, 36730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 36667, 36719);

                return f_1559_36674_36718(f_1559_36674_36705(commandExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 36552, 36730);

                System.Management.Automation.Language.ExpressionAst
                f_1559_36674_36705(System.Management.Automation.Language.CommandExpressionAst
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 36674, 36705);
                    return return_v;
                }


                object
                f_1559_36674_36718(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 36674, 36718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 36552, 36730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 36552, 36730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitCommandParameter(CommandParameterAst commandParameterAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 36742, 36914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 36854, 36903);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 36742, 36914);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 36742, 36914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 36742, 36914);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor.VisitFileRedirection(FileRedirectionAst fileRedirectionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 36926, 37095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 37035, 37084);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 36926, 37095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 36926, 37095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 36926, 37095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InferTypesFrom(CommandAst commandAst, List<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 37107, 39704);
                System.Management.Automation.Language.AstParameterArgumentPair pathArgument = default(System.Management.Automation.Language.AstParameterArgumentPair);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 37214, 37394);

                PseudoBindingInfo
                pseudoBinding = f_1559_37248_37393(f_1559_37248_37275(), commandAst, null, null, PseudoParameterBinder.BindingType.ParameterCompletion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 37410, 37504) || true) && (f_1559_37414_37440_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(pseudoBinding, 1559, 37414, 37440)?.CommandInfo) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 37410, 37504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 37482, 37489);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 37410, 37504);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 37520, 37554);

                string
                pathParameterName = "Path"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 37568, 37833) || true) && (!f_1559_37573_37654(f_1559_37573_37601(pseudoBinding), pathParameterName, out pathArgument))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 37568, 37833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 37688, 37722);

                    pathParameterName = "LiteralPath";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 37740, 37818);

                    f_1559_37740_37817(f_1559_37740_37768(pseudoBinding), pathParameterName, out pathArgument);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 37568, 37833);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 38258, 38302);

                var
                commandInfo = f_1559_38276_38301(pseudoBinding)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 38316, 38363);

                var
                pathArgumentPair = pathArgument as AstPair
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 38377, 38787) || true) && (f_1559_38381_38407_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(pathArgumentPair, 1559, 38381, 38407)?.Argument) is StringConstantExpressionAst ast)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 38377, 38787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 38476, 38502);

                    var
                    pathValue = f_1559_38492_38501(ast)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 38564, 38664);

                        commandInfo = f_1559_38578_38663(commandInfo, new object[] { "-" + pathParameterName, pathValue });
                    }
                    catch (InvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1559, 38701, 38772);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1559, 38701, 38772);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 38377, 38787);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 38803, 39228) || true) && (commandInfo is CmdletInfo cmdletInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 38803, 39228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 38911, 39012);

                    var
                    inferTypesFromObjectCmdlets = f_1559_38945_39011(this, commandAst, cmdletInfo, pseudoBinding)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 39030, 39213) || true) && (f_1559_39034_39067(inferTypesFromObjectCmdlets) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 39030, 39213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 39113, 39165);

                        f_1559_39113_39164(inferredTypes, inferTypesFromObjectCmdlets);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 39187, 39194);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 39030, 39213);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 38803, 39228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 39646, 39693);

                f_1559_39646_39692(
                            // The OutputType property ignores the parameter set specified in the OutputTypeAttribute.
                            // With psuedo-binding, we actually know the candidate parameter sets, so we could take
                            // advantage of it here, but I opted for the simpler code because so few cmdlets use
                            // ParameterSetName in OutputType and of the ones I know about, it isn't that useful.
                            inferredTypes, f_1559_39669_39691(commandInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 37107, 39704);

                System.Management.Automation.Language.PseudoParameterBinder
                f_1559_37248_37275()
                {
                    var return_v = new System.Management.Automation.Language.PseudoParameterBinder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 37248, 37275);
                    return return_v;
                }


                System.Management.Automation.Language.PseudoBindingInfo
                f_1559_37248_37393(System.Management.Automation.Language.PseudoParameterBinder
                this_param, System.Management.Automation.Language.CommandAst
                command, System.Type
                pipeArgumentType, System.Management.Automation.Language.CommandParameterAst
                paramAstAtCursor, System.Management.Automation.Language.PseudoParameterBinder.BindingType
                bindingType)
                {
                    var return_v = this_param.DoPseudoParameterBinding(command, pipeArgumentType, paramAstAtCursor, bindingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 37248, 37393);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1559_37414_37440_M(System.Management.Automation.CommandInfo
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 37414, 37440);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_37573_37601(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 37573, 37601);
                    return return_v;
                }


                bool
                f_1559_37573_37654(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 37573, 37654);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_37740_37768(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 37740, 37768);
                    return return_v;
                }


                bool
                f_1559_37740_37817(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 37740, 37817);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1559_38276_38301(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 38276, 38301);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1559_38381_38407_M(System.Management.Automation.Language.CommandElementAst
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 38381, 38407);
                    return return_v;
                }


                string
                f_1559_38492_38501(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 38492, 38501);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1559_38578_38663(System.Management.Automation.CommandInfo
                this_param, object[]
                argumentList)
                {
                    var return_v = this_param.CreateGetCommandCopy(argumentList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 38578, 38663);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_38945_39011(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandAst
                commandAst, System.Management.Automation.CmdletInfo
                cmdletInfo, System.Management.Automation.Language.PseudoBindingInfo
                pseudoBinding)
                {
                    var return_v = this_param.InferTypesFromObjectCmdlets(commandAst, cmdletInfo, pseudoBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 38945, 39011);
                    return return_v;
                }


                int
                f_1559_39034_39067(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 39034, 39067);
                    return return_v;
                }


                int
                f_1559_39113_39164(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 39113, 39164);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                f_1559_39669_39691(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.OutputType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 39669, 39691);
                    return return_v;
                }


                int
                f_1559_39646_39692(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 39646, 39692);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 37107, 39704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 37107, 39704);
            }
        }

        private List<PSTypeName> InferTypesFromObjectCmdlets(CommandAst commandAst, CmdletInfo cmdletInfo, PseudoBindingInfo pseudoBinding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 40154, 42991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 40310, 40355);

                var
                inferredTypes = f_1559_40330_40354(16)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 40371, 42943) || true) && (f_1559_40375_40485(f_1559_40375_40411(f_1559_40375_40402(cmdletInfo)), "Microsoft.PowerShell.Commands.NewObjectCommand"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 40371, 42943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 40603, 40669);

                    var
                    newObjectType = f_1559_40623_40668(pseudoBinding)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 40687, 40806) || true) && (newObjectType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 40687, 40806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 40754, 40787);

                        f_1559_40754_40786(inferredTypes, newObjectType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 40687, 40806);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 40371, 42943);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 40371, 42943);

                    if (
                    (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 40840, 42943) || true) && (f_1559_40862_40994(f_1559_40862_40898(f_1559_40862_40889(cmdletInfo)), "Microsoft.Management.Infrastructure.CimCmdlets.GetCimInstanceCommand") || (DynAbs.Tracing.TraceSender.Expression_False(1559, 40862, 41147) || f_1559_41015_41147(f_1559_41015_41051(f_1559_41015_41042(cmdletInfo)), "Microsoft.Management.Infrastructure.CimCmdlets.NewCimInstanceCommand")))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 40840, 42943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 41332, 41387);

                        f_1559_41332_41386(pseudoBinding, inferredTypes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 40840, 42943);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 40840, 42943);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 41421, 42943) || true) && (f_1559_41425_41452(cmdletInfo) == typeof(WhereObjectCommand) || (DynAbs.Tracing.TraceSender.Expression_False(1559, 41425, 41619) || f_1559_41508_41619(f_1559_41508_41544(f_1559_41508_41535(cmdletInfo)), "Microsoft.PowerShell.Commands.SortObjectCommand")))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 41421, 42943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 41787, 41848);

                            f_1559_41787_41847(this, commandAst, inferredTypes);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 41421, 42943);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 41421, 42943);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 41882, 42943) || true) && (f_1559_41886_41913(cmdletInfo) == typeof(ForEachObjectCommand))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 41882, 42943);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 42062, 42133);

                                f_1559_42062_42132(this, pseudoBinding, commandAst, inferredTypes);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 41882, 42943);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 41882, 42943);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 42167, 42943) || true) && (f_1559_42171_42284(f_1559_42171_42207(f_1559_42171_42198(cmdletInfo)), "Microsoft.PowerShell.Commands.SelectObjectCommand"))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 42167, 42943);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 42469, 42539);

                                    f_1559_42469_42538(this, pseudoBinding, commandAst, inferredTypes);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 42167, 42943);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 42167, 42943);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 42573, 42943) || true) && (f_1559_42577_42689(f_1559_42577_42613(f_1559_42577_42604(cmdletInfo)), "Microsoft.PowerShell.Commands.GroupObjectCommand"))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 42573, 42943);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 42859, 42928);

                                        f_1559_42859_42927(this, pseudoBinding, commandAst, inferredTypes);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 42573, 42943);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 42167, 42943);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 41882, 42943);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 41421, 42943);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 40840, 42943);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 40371, 42943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 42959, 42980);

                return inferredTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 40154, 42991);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_40330_40354(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 40330, 40354);
                    return return_v;
                }


                System.Type
                f_1559_40375_40402(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 40375, 40402);
                    return return_v;
                }


                string
                f_1559_40375_40411(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 40375, 40411);
                    return return_v;
                }


                bool
                f_1559_40375_40485(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 40375, 40485);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_40623_40668(System.Management.Automation.Language.PseudoBindingInfo
                pseudoBinding)
                {
                    var return_v = InferTypesFromNewObjectCommand(pseudoBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 40623, 40668);
                    return return_v;
                }


                int
                f_1559_40754_40786(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 40754, 40786);
                    return 0;
                }


                System.Type
                f_1559_40862_40889(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 40862, 40889);
                    return return_v;
                }


                string
                f_1559_40862_40898(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 40862, 40898);
                    return return_v;
                }


                bool
                f_1559_40862_40994(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 40862, 40994);
                    return return_v;
                }


                System.Type
                f_1559_41015_41042(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 41015, 41042);
                    return return_v;
                }


                string
                f_1559_41015_41051(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 41015, 41051);
                    return return_v;
                }


                bool
                f_1559_41015_41147(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 41015, 41147);
                    return return_v;
                }


                int
                f_1559_41332_41386(System.Management.Automation.Language.PseudoBindingInfo
                pseudoBinding, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    InferTypesFromCimCommand(pseudoBinding, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 41332, 41386);
                    return 0;
                }


                System.Type
                f_1559_41425_41452(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 41425, 41452);
                    return return_v;
                }


                System.Type
                f_1559_41508_41535(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 41508, 41535);
                    return return_v;
                }


                string
                f_1559_41508_41544(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 41508, 41544);
                    return return_v;
                }


                bool
                f_1559_41508_41619(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 41508, 41619);
                    return return_v;
                }


                int
                f_1559_41787_41847(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandAst
                commandAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.InferTypesFromWhereAndSortCommand(commandAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 41787, 41847);
                    return 0;
                }


                System.Type
                f_1559_41886_41913(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 41886, 41913);
                    return return_v;
                }


                int
                f_1559_42062_42132(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.PseudoBindingInfo
                pseudoBinding, System.Management.Automation.Language.CommandAst
                commandAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.InferTypesFromForeachCommand(pseudoBinding, commandAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 42062, 42132);
                    return 0;
                }


                System.Type
                f_1559_42171_42198(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 42171, 42198);
                    return return_v;
                }


                string
                f_1559_42171_42207(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 42171, 42207);
                    return return_v;
                }


                bool
                f_1559_42171_42284(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 42171, 42284);
                    return return_v;
                }


                int
                f_1559_42469_42538(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.PseudoBindingInfo
                pseudoBinding, System.Management.Automation.Language.CommandAst
                commandAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.InferTypesFromSelectCommand(pseudoBinding, commandAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 42469, 42538);
                    return 0;
                }


                System.Type
                f_1559_42577_42604(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ImplementingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 42577, 42604);
                    return return_v;
                }


                string
                f_1559_42577_42613(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 42577, 42613);
                    return return_v;
                }


                bool
                f_1559_42577_42689(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 42577, 42689);
                    return return_v;
                }


                int
                f_1559_42859_42927(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.PseudoBindingInfo
                pseudoBinding, System.Management.Automation.Language.CommandAst
                commandAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.InferTypesFromGroupCommand(pseudoBinding, commandAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 42859, 42927);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 40154, 42991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 40154, 42991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void InferTypesFromCimCommand(PseudoBindingInfo pseudoBinding, List<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 43003, 44308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 43137, 43427);

                string
                pseudoboundNamespace =
                f_1559_43180_43426(f_1559_43180_43375(f_1559_43296_43324(pseudoBinding), "Namespace"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 43443, 43733);

                string
                pseudoboundClassName =
                f_1559_43486_43732(f_1559_43486_43681(f_1559_43602_43630(pseudoBinding), "ClassName"))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 43749, 44226) || true) && (!f_1559_43754_43801(pseudoboundClassName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 43749, 44226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 43835, 44163);

                    var
                    typeName = f_1559_43850_44162(f_1559_43887_44161(f_1559_43927_43955(), "{0}#{1}/{2}", f_1559_44022_44050(typeof(CimInstance)), pseudoboundNamespace ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1559, 44077, 44113) ?? "root/cimv2"), pseudoboundClassName))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 44183, 44211);

                    f_1559_44183_44210(
                                    inferredTypes, typeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 43749, 44226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 44242, 44297);

                f_1559_44242_44296(
                            inferredTypes, f_1559_44260_44295(typeof(CimInstance)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 43003, 44308);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_43296_43324(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 43296, 43324);
                    return return_v;
                }


                System.Collections.Generic.IList<string>
                f_1559_43180_43375(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                boundArguments, string
                parameterName)
                {
                    var return_v = CompletionCompleters.NativeCommandArgumentCompletion_ExtractSecondaryArgument(boundArguments, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 43180, 43375);
                    return return_v;
                }


                string
                f_1559_43180_43426(System.Collections.Generic.IList<string>
                source)
                {
                    var return_v = source.FirstOrDefault<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 43180, 43426);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_43602_43630(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 43602, 43630);
                    return return_v;
                }


                System.Collections.Generic.IList<string>
                f_1559_43486_43681(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                boundArguments, string
                parameterName)
                {
                    var return_v = CompletionCompleters.NativeCommandArgumentCompletion_ExtractSecondaryArgument(boundArguments, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 43486, 43681);
                    return return_v;
                }


                string
                f_1559_43486_43732(System.Collections.Generic.IList<string>
                source)
                {
                    var return_v = source.FirstOrDefault<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 43486, 43732);
                    return return_v;
                }


                bool
                f_1559_43754_43801(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 43754, 43801);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1559_43927_43955()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 43927, 43955);
                    return return_v;
                }


                string
                f_1559_44022_44050(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 44022, 44050);
                    return return_v;
                }


                string
                f_1559_43887_44161(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 43887, 44161);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_43850_44162(string
                name)
                {
                    var return_v = new System.Management.Automation.PSTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 43850, 44162);
                    return return_v;
                }


                int
                f_1559_44183_44210(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 44183, 44210);
                    return 0;
                }


                System.Management.Automation.PSTypeName
                f_1559_44260_44295(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 44260, 44295);
                    return return_v;
                }


                int
                f_1559_44242_44296(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 44242, 44296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 43003, 44308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 43003, 44308);
            }
        }

        private void InferTypesFromForeachCommand(PseudoBindingInfo pseudoBinding, CommandAst commandAst, List<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 44320, 46110);
                System.Management.Automation.Language.AstParameterArgumentPair argument = default(System.Management.Automation.Language.AstParameterArgumentPair);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 44474, 45508) || true) && (f_1559_44478_44571(f_1559_44478_44506(pseudoBinding), "MemberName", out argument))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 44474, 45508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 44605, 44674);

                    var
                    previousPipelineElement = f_1559_44635_44673(commandAst)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 44692, 44795) || true) && (previousPipelineElement == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 44692, 44795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 44769, 44776);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 44692, 44795);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 44815, 45493);
                        foreach (var t in f_1559_44833_44868_I(f_1559_44833_44868(this, previousPipelineElement)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 44815, 45493);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 44941, 45014);

                            var
                            temp = (f_1559_44953_44981(((AstPair)argument)) as StringConstantExpressionAst)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 45036, 45086);

                            var
                            memberName = (DynAbs.Tracing.TraceSender.Conditional_F1(1559, 45053, 45065) || ((temp != null && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 45068, 45078)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 45081, 45085))) ? f_1559_45068_45078(temp) : null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 45110, 45474) || true) && (memberName != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 45110, 45474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 45182, 45246);

                                var
                                members = f_1559_45196_45245(_context, t, false, null)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 45272, 45306);

                                bool
                                maybeWantDefaultCtor = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 45332, 45451);

                                f_1559_45332_45450(this, t, memberName, members, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst: false, inferredTypes);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 45110, 45474);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 44815, 45493);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 679);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 679);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 44474, 45508);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 45524, 45705) || true) && (f_1559_45528_45591(f_1559_45528_45556(pseudoBinding), "Begin", out argument))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 45524, 45705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 45625, 45690);

                    f_1559_45625_45689(this, argument, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 45524, 45705);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 45721, 45904) || true) && (f_1559_45725_45790(f_1559_45725_45753(pseudoBinding), "Process", out argument))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 45721, 45904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 45824, 45889);

                    f_1559_45824_45888(this, argument, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 45721, 45904);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 45920, 46099) || true) && (f_1559_45924_45985(f_1559_45924_45952(pseudoBinding), "End", out argument))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 45920, 46099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 46019, 46084);

                    f_1559_46019_46083(this, argument, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 45920, 46099);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 44320, 46110);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_44478_44506(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 44478, 44506);
                    return return_v;
                }


                bool
                f_1559_44478_44571(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 44478, 44571);
                    return return_v;
                }


                System.Management.Automation.Language.CommandBaseAst
                f_1559_44635_44673(System.Management.Automation.Language.CommandAst
                commandAst)
                {
                    var return_v = GetPreviousPipelineCommand(commandAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 44635, 44673);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_44833_44868(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandBaseAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 44833, 44868);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1559_44953_44981(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 44953, 44981);
                    return return_v;
                }


                string
                f_1559_45068_45078(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 45068, 45078);
                    return return_v;
                }


                System.Collections.Generic.IList<object>
                f_1559_45196_45245(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.PSTypeName
                typename, bool
                isStatic, System.Func<object, bool>
                filter)
                {
                    var return_v = this_param.GetMembersByInferredType(typename, isStatic, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 45196, 45245);
                    return return_v;
                }


                int
                f_1559_45332_45450(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.PSTypeName
                thisType, string
                memberName, System.Collections.Generic.IList<object>
                members, ref bool
                maybeWantDefaultCtor, bool
                isInvokeMemberExpressionAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.GetTypesOfMembers(thisType, memberName, members, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst: isInvokeMemberExpressionAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 45332, 45450);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_44833_44868_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 44833, 44868);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_45528_45556(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 45528, 45556);
                    return return_v;
                }


                bool
                f_1559_45528_45591(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 45528, 45591);
                    return return_v;
                }


                int
                f_1559_45625_45689(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.AstParameterArgumentPair
                argument, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.GetInferredTypeFromScriptBlockParameter(argument, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 45625, 45689);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_45725_45753(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 45725, 45753);
                    return return_v;
                }


                bool
                f_1559_45725_45790(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 45725, 45790);
                    return return_v;
                }


                int
                f_1559_45824_45888(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.AstParameterArgumentPair
                argument, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.GetInferredTypeFromScriptBlockParameter(argument, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 45824, 45888);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_45924_45952(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 45924, 45952);
                    return return_v;
                }


                bool
                f_1559_45924_45985(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 45924, 45985);
                    return return_v;
                }


                int
                f_1559_46019_46083(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.AstParameterArgumentPair
                argument, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.GetInferredTypeFromScriptBlockParameter(argument, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 46019, 46083);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 44320, 46110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 44320, 46110);
            }
        }

        private void InferTypesFromGroupCommand(PseudoBindingInfo pseudoBinding, CommandAst commandAst, List<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 46122, 50561);
                System.Management.Automation.Language.AstParameterArgumentPair _ = default(System.Management.Automation.Language.AstParameterArgumentPair);
                System.Management.Automation.Language.AstParameterArgumentPair propertyArgumentPair = default(System.Management.Automation.Language.AstParameterArgumentPair);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 46274, 46492) || true) && (f_1559_46278_46365(f_1559_46278_46306(pseudoBinding), "AsHashTable", out _))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 46274, 46492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 46399, 46452);

                    f_1559_46399_46451(inferredTypes, f_1559_46417_46450(typeof(Hashtable)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 46470, 46477);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 46274, 46492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 46508, 46610);

                var
                noElement = f_1559_46524_46609(f_1559_46524_46552(pseudoBinding), "NoElement", out _)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 46626, 46653);

                string[]
                properties = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 46667, 46700);

                bool
                scriptBlockProperty = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 46714, 47721) || true) && (f_1559_46718_46821(f_1559_46718_46746(pseudoBinding), "Property", out propertyArgumentPair))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 46714, 47721);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 46855, 47706) || true) && (propertyArgumentPair is AstPair astPair)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 46855, 47706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 46940, 47687);

                        switch (f_1559_46948_46964(astPair))
                        {

                            case StringConstantExpressionAst stringConstant:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 46940, 47687);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 47092, 47136);

                                properties = new[] { f_1559_47113_47133(stringConstant) };
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 47166, 47172);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 46940, 47687);

                            case ArrayLiteralAst arrayLiteral:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 46940, 47687);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 47262, 47366);

                                properties = f_1559_47275_47365(f_1559_47275_47355(f_1559_47275_47334(f_1559_47275_47296(arrayLiteral)), c => c.Value));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 47396, 47484);

                                scriptBlockProperty = f_1559_47418_47483(f_1559_47418_47477(f_1559_47418_47439(arrayLiteral)));
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 47514, 47520);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 46940, 47687);

                            case CommandElementAst _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 46940, 47687);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 47601, 47628);

                                scriptBlockProperty = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 47658, 47664);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 46940, 47687);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 46855, 47706);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 46714, 47721);
                }

                bool IsInPropertyArgument(object o)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 47737, 48531);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 47805, 47900) || true) && (properties == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 47805, 47900);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 47869, 47881);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 47805, 47900);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 47920, 47932);

                        string
                        name
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 47950, 48213);

                        switch (o)
                        {

                            case string s:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 47950, 48213);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48041, 48050);

                                name = s;
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 48076, 48082);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 47950, 48213);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 47950, 48213);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48138, 48162);

                                name = f_1559_48145_48161(o);
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 48188, 48194);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 47950, 48213);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48233, 48483);
                            foreach (var propertyName in f_1559_48262_48272_I(properties))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 48233, 48483);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48314, 48464) || true) && (f_1559_48318_48379(name, propertyName, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 48314, 48464);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48429, 48441);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 48314, 48464);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 48233, 48483);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 251);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 251);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48503, 48516);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 47737, 48531);

                        string
                        f_1559_48145_48161(object
                        member)
                        {
                            var return_v = GetMemberName(member);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48145, 48161);
                            return return_v;
                        }


                        bool
                        f_1559_48318_48379(string
                        this_param, string
                        value, System.StringComparison
                        comparisonType)
                        {
                            var return_v = this_param.Equals(value, comparisonType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48318, 48379);
                            return return_v;
                        }


                        string[]
                        f_1559_48262_48272_I(string[]
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48262, 48272);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 47737, 48531);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 47737, 48531);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48547, 48616);

                var
                previousPipelineElement = f_1559_48577_48615(commandAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48630, 48687);

                var
                typeName = "Microsoft.PowerShell.Commands.GroupInfo"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48701, 48747);

                var
                members = f_1559_48715_48746()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48761, 50550);
                    foreach (var prevType in f_1559_48786_48821_I(f_1559_48786_48821(this, previousPipelineElement)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 48761, 50550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48855, 48871);

                        f_1559_48855_48870(members);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48889, 49159) || true) && (noElement)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 48889, 49159);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 48944, 49022);

                            f_1559_48944_49021(members, f_1559_48956_49020("Values", f_1559_48990_49019(f_1559_49005_49018(prevType))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49044, 49109);

                            f_1559_49044_49108(inferredTypes, f_1559_49062_49107(typeName, members));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49131, 49140);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 48889, 49159);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49179, 49271);

                        var
                        memberNameAndTypes = f_1559_49204_49270(this, prevType, IsInPropertyArgument)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49289, 49388) || true) && (!f_1559_49294_49318(memberNameAndTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 49289, 49388);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49360, 49369);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 49289, 49388);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49408, 50450) || true) && (properties != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 49408, 50450);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49472, 49911);
                                foreach (var memType in f_1559_49496_49514_I(memberNameAndTypes))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 49472, 49911);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49564, 49580);

                                    f_1559_49564_49579(members);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49606, 49683);

                                    f_1559_49606_49682(members, f_1559_49618_49681("Group", f_1559_49651_49680(f_1559_49666_49679(prevType))));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49709, 49797);

                                    f_1559_49709_49796(members, f_1559_49721_49795("Values", f_1559_49755_49794(f_1559_49770_49793(memType.PSTypeName))));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 49823, 49888);

                                    f_1559_49823_49887(inferredTypes, f_1559_49841_49886(typeName, members));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 49472, 49911);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 440);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 440);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 49408, 50450);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 49408, 50450);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 50101, 50178);

                            f_1559_50101_50177(                    // No Property parameter given
                                                                   // group infers to IList<PrevType>
                                                members, f_1559_50113_50176("Group", f_1559_50146_50175(f_1559_50161_50174(prevType))));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 50256, 50431) || true) && (!scriptBlockProperty)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 50256, 50431);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 50330, 50408);

                                f_1559_50330_50407(members, f_1559_50342_50406("Values", f_1559_50376_50405(f_1559_50391_50404(prevType))));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 50256, 50431);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 49408, 50450);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 50470, 50535);

                        f_1559_50470_50534(
                                        inferredTypes, f_1559_50488_50533(typeName, members));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 48761, 50550);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 1790);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 1790);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 46122, 50561);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_46278_46306(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 46278, 46306);
                    return return_v;
                }


                bool
                f_1559_46278_46365(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 46278, 46365);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_46417_46450(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 46417, 46450);
                    return return_v;
                }


                int
                f_1559_46399_46451(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 46399, 46451);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_46524_46552(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 46524, 46552);
                    return return_v;
                }


                bool
                f_1559_46524_46609(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 46524, 46609);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_46718_46746(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 46718, 46746);
                    return return_v;
                }


                bool
                f_1559_46718_46821(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 46718, 46821);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1559_46948_46964(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 46948, 46964);
                    return return_v;
                }


                string
                f_1559_47113_47133(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 47113, 47133);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1559_47275_47296(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 47275, 47296);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.StringConstantExpressionAst>
                f_1559_47275_47334(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Language.StringConstantExpressionAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 47275, 47334);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1559_47275_47355(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.StringConstantExpressionAst>
                source, System.Func<System.Management.Automation.Language.StringConstantExpressionAst, string>
                selector)
                {
                    var return_v = source.Select<System.Management.Automation.Language.StringConstantExpressionAst, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 47275, 47355);
                    return return_v;
                }


                string[]
                f_1559_47275_47365(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 47275, 47365);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1559_47418_47439(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 47418, 47439);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.StringConstantExpressionAst>
                f_1559_47418_47477(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Language.StringConstantExpressionAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 47418, 47477);
                    return return_v;
                }


                bool
                f_1559_47418_47483(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.StringConstantExpressionAst>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.Language.StringConstantExpressionAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 47418, 47483);
                    return return_v;
                }


                System.Management.Automation.Language.CommandBaseAst
                f_1559_48577_48615(System.Management.Automation.Language.CommandAst
                commandAst)
                {
                    var return_v = GetPreviousPipelineCommand(commandAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48577, 48615);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                f_1559_48715_48746()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48715, 48746);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_48786_48821(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandBaseAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48786, 48821);
                    return return_v;
                }


                int
                f_1559_48855_48870(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48855, 48870);
                    return 0;
                }


                string
                f_1559_49005_49018(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 49005, 49018);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_48990_49019(string
                name)
                {
                    var return_v = new System.Management.Automation.PSTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48990, 49019);
                    return return_v;
                }


                System.Management.Automation.PSMemberNameAndType
                f_1559_48956_49020(string
                name, System.Management.Automation.PSTypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSMemberNameAndType(name, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48956, 49020);
                    return return_v;
                }


                int
                f_1559_48944_49021(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param, System.Management.Automation.PSMemberNameAndType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48944, 49021);
                    return 0;
                }


                System.Management.Automation.PSSyntheticTypeName
                f_1559_49062_49107(string
                typename, System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                membersTypes)
                {
                    var return_v = PSSyntheticTypeName.Create(typename, (System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>)membersTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49062, 49107);
                    return return_v;
                }


                int
                f_1559_49044_49108(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSSyntheticTypeName
                item)
                {
                    this_param.Add((System.Management.Automation.PSTypeName)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49044, 49108);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                f_1559_49204_49270(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.PSTypeName
                t, System.Func<object, bool>
                isInPropertyList)
                {
                    var return_v = this_param.GetMemberNameAndTypeFromProperties(t, isInPropertyList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49204, 49270);
                    return return_v;
                }


                bool
                f_1559_49294_49318(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.PSMemberNameAndType>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49294, 49318);
                    return return_v;
                }


                int
                f_1559_49564_49579(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49564, 49579);
                    return 0;
                }


                string
                f_1559_49666_49679(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 49666, 49679);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_49651_49680(string
                name)
                {
                    var return_v = new System.Management.Automation.PSTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49651, 49680);
                    return return_v;
                }


                System.Management.Automation.PSMemberNameAndType
                f_1559_49618_49681(string
                name, System.Management.Automation.PSTypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSMemberNameAndType(name, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49618, 49681);
                    return return_v;
                }


                int
                f_1559_49606_49682(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param, System.Management.Automation.PSMemberNameAndType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49606, 49682);
                    return 0;
                }


                string
                f_1559_49770_49793(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 49770, 49793);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_49755_49794(string
                name)
                {
                    var return_v = new System.Management.Automation.PSTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49755, 49794);
                    return return_v;
                }


                System.Management.Automation.PSMemberNameAndType
                f_1559_49721_49795(string
                name, System.Management.Automation.PSTypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSMemberNameAndType(name, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49721, 49795);
                    return return_v;
                }


                int
                f_1559_49709_49796(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param, System.Management.Automation.PSMemberNameAndType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49709, 49796);
                    return 0;
                }


                System.Management.Automation.PSSyntheticTypeName
                f_1559_49841_49886(string
                typename, System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                membersTypes)
                {
                    var return_v = PSSyntheticTypeName.Create(typename, (System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>)membersTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49841, 49886);
                    return return_v;
                }


                int
                f_1559_49823_49887(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSSyntheticTypeName
                item)
                {
                    this_param.Add((System.Management.Automation.PSTypeName)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49823, 49887);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                f_1559_49496_49514_I(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 49496, 49514);
                    return return_v;
                }


                string
                f_1559_50161_50174(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 50161, 50174);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_50146_50175(string
                name)
                {
                    var return_v = new System.Management.Automation.PSTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 50146, 50175);
                    return return_v;
                }


                System.Management.Automation.PSMemberNameAndType
                f_1559_50113_50176(string
                name, System.Management.Automation.PSTypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSMemberNameAndType(name, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 50113, 50176);
                    return return_v;
                }


                int
                f_1559_50101_50177(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param, System.Management.Automation.PSMemberNameAndType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 50101, 50177);
                    return 0;
                }


                string
                f_1559_50391_50404(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 50391, 50404);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_50376_50405(string
                name)
                {
                    var return_v = new System.Management.Automation.PSTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 50376, 50405);
                    return return_v;
                }


                System.Management.Automation.PSMemberNameAndType
                f_1559_50342_50406(string
                name, System.Management.Automation.PSTypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSMemberNameAndType(name, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 50342, 50406);
                    return return_v;
                }


                int
                f_1559_50330_50407(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param, System.Management.Automation.PSMemberNameAndType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 50330, 50407);
                    return 0;
                }


                System.Management.Automation.PSSyntheticTypeName
                f_1559_50488_50533(string
                typename, System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                membersTypes)
                {
                    var return_v = PSSyntheticTypeName.Create(typename, (System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>)membersTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 50488, 50533);
                    return return_v;
                }


                int
                f_1559_50470_50534(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSSyntheticTypeName
                item)
                {
                    this_param.Add((System.Management.Automation.PSTypeName)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 50470, 50534);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_48786_48821_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 48786, 48821);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 46122, 50561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 46122, 50561);
            }
        }

        private void InferTypesFromWhereAndSortCommand(CommandAst commandAst, List<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 50573, 50767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 50699, 50756);

                f_1559_50699_50755(this, commandAst, inferredTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 50573, 50767);

                int
                f_1559_50699_50755(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandAst
                commandAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.InferTypesFromPreviousCommand(commandAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 50699, 50755);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 50573, 50767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 50573, 50767);
            }
        }

        private void InferTypesFromPreviousCommand(CommandAst commandAst, List<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 50779, 51451);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 50901, 51440) || true) && (f_1559_50905_50922(commandAst) is PipelineAst parentPipeline)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 50901, 51440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 50986, 50992);

                    int
                    i
                    = default(int);
                    try
                    {
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 51015, 51020)
   , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 51010, 51260) || true) && (i < f_1559_51026_51063(f_1559_51026_51057(parentPipeline)))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 51065, 51068)
   , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 51010, 51260))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 51010, 51260);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 51110, 51241) || true) && (f_1559_51114_51148(f_1559_51114_51145(parentPipeline), i) == commandAst)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 51110, 51241);
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 51212, 51218);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 51110, 51241);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 251);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 251);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 51280, 51425) || true) && (i > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 51280, 51425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 51331, 51406);

                        f_1559_51331_51405(inferredTypes, f_1559_51354_51404(this, f_1559_51365_51403(f_1559_51365_51396(parentPipeline), i - 1)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 51280, 51425);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 50901, 51440);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 50779, 51451);

                System.Management.Automation.Language.Ast
                f_1559_50905_50922(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 50905, 50922);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1559_51026_51057(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 51026, 51057);
                    return return_v;
                }


                int
                f_1559_51026_51063(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 51026, 51063);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1559_51114_51145(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 51114, 51145);
                    return return_v;
                }


                System.Management.Automation.Language.CommandBaseAst
                f_1559_51114_51148(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 51114, 51148);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1559_51365_51396(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 51365, 51396);
                    return return_v;
                }


                System.Management.Automation.Language.CommandBaseAst
                f_1559_51365_51403(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 51365, 51403);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_51354_51404(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandBaseAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 51354, 51404);
                    return return_v;
                }


                int
                f_1559_51331_51405(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 51331, 51405);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 50779, 51451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 50779, 51451);
            }
        }

        private void InferTypesFromSelectCommand(PseudoBindingInfo pseudoBinding, CommandAst commandAst, List<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 51463, 56288);
                System.Management.Automation.Language.AstParameterArgumentPair property = default(System.Management.Automation.Language.AstParameterArgumentPair);
                System.Management.Automation.Language.AstParameterArgumentPair excludeProperty = default(System.Management.Automation.Language.AstParameterArgumentPair);
                System.Management.Automation.Language.AstParameterArgumentPair expandedPropertyArgument = default(System.Management.Automation.Language.AstParameterArgumentPair);

                void InferFromSelectProperties(AstParameterArgumentPair astParameterArgumentPair, CommandBaseAst previousPipelineElementAst, bool includeMatchedProperties = true)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 51616, 54624);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 51811, 54609) || true) && (astParameterArgumentPair is AstPair astPair)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 51811, 54609);

                            object
                        f_1559_52282_52322(string
                        value)
                            {
                                var return_v = ToWildCardOrString(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 52282, 52322);
                                return return_v;
                            }

                            object ToWildCardOrString(string value)
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 51940, 52037);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 51943, 52037);
                                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1559, 51943, 51992) || ((f_1559_51943_51992(value) && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 51995, 52029)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 52032, 52037))) ? (object)f_1559_52003_52029(value) : value;
                                    DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 51940, 52037);
                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 51940, 52037);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 51940, 52037);
                                }
                                throw new System.Exception("Slicer error: unreachable code");
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 52060, 52087);

                            object[]
                            properties = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 52109, 52634);

                            switch (f_1559_52117_52133(astPair))
                            {

                                case StringConstantExpressionAst stringConstant:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 52109, 52634);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 52261, 52325);

                                    properties = new[] { f_1559_52282_52322(f_1559_52301_52321(stringConstant)) };
                                    DynAbs.Tracing.TraceSender.TraceBreak(1559, 52355, 52361);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 52109, 52634);

                                case ArrayLiteralAst arrayLiteral:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 52109, 52634);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 52451, 52575);

                                    properties = f_1559_52464_52574(f_1559_52464_52564(f_1559_52464_52523(f_1559_52464_52485(arrayLiteral)), c => ToWildCardOrString(c.Value)));
                                    DynAbs.Tracing.TraceSender.TraceBreak(1559, 52605, 52611);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 52109, 52634);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 52658, 52760) || true) && (properties == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 52658, 52760);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 52730, 52737);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 52658, 52760);
                            }

                            bool IsInPropertyArgument(object o)
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 52784, 54270);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 52868, 52880);

                                    string
                                    name
                                    = default(string);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 52906, 53233);

                                    switch (o)
                                    {

                                        case string s:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 52906, 53233);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 53021, 53030);

                                            name = s;
                                            DynAbs.Tracing.TraceSender.TraceBreak(1559, 53064, 53070);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 52906, 53233);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 52906, 53233);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 53142, 53166);

                                            name = f_1559_53149_53165(o);
                                            DynAbs.Tracing.TraceSender.TraceBreak(1559, 53200, 53206);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 52906, 53233);
                                    }
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 53261, 54186);
                                        foreach (var propertyNameOrPattern in f_1559_53299_53309_I(properties))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 53261, 54186);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 53367, 54159);

                                            switch (propertyNameOrPattern)
                                            {

                                                case string propertyName:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 53367, 54159);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 53525, 53757) || true) && (f_1559_53529_53599(name, propertyName, StringComparison.OrdinalIgnoreCase) == 0)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 53525, 53757);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 53686, 53718);

                                                        return includeMatchedProperties;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 53525, 53757);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceBreak(1559, 53797, 53803);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 53367, 54159);

                                                case WildcardPattern pattern:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 53367, 54159);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 53904, 54082) || true) && (f_1559_53908_53929(pattern, name))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 53904, 54082);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 54011, 54043);

                                                        return includeMatchedProperties;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 53904, 54082);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceBreak(1559, 54122, 54128);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 53367, 54159);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 53261, 54186);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 926);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 926);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 54214, 54247);

                                    return !includeMatchedProperties;
                                    DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 52784, 54270);

                                    string
                                    f_1559_53149_53165(object
                                    member)
                                    {
                                        var return_v = GetMemberName(member);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 53149, 53165);
                                        return return_v;
                                    }


                                    int
                                    f_1559_53529_53599(string
                                    strA, string
                                    strB, System.StringComparison
                                    comparisonType)
                                    {
                                        var return_v = string.Compare(strA, strB, comparisonType);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 53529, 53599);
                                        return return_v;
                                    }


                                    bool
                                    f_1559_53908_53929(System.Management.Automation.WildcardPattern
                                    this_param, string
                                    input)
                                    {
                                        var return_v = this_param.IsMatch(input);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 53908, 53929);
                                        return return_v;
                                    }


                                    object[]
                                    f_1559_53299_53309_I(object[]
                                    i)
                                    {
                                        var return_v = i;
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 53299, 53309);
                                        return return_v;
                                    }

                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 52784, 54270);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 52784, 54270);
                                }
                                throw new System.Exception("Slicer error: unreachable code");
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 54294, 54590);
                                foreach (var t in f_1559_54312_54350_I(f_1559_54312_54350(this, previousPipelineElementAst)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 54294, 54590);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 54400, 54471);

                                    var
                                    list = f_1559_54411_54470(this, t, IsInPropertyArgument)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 54497, 54567);

                                    f_1559_54497_54566(inferredTypes, f_1559_54515_54565(typeof(PSObject), list));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 54294, 54590);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 297);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 297);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 51811, 54609);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 51616, 54624);

                        bool
                        f_1559_51943_51992(string
                        pattern)
                        {
                            var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 51943, 51992);
                            return return_v;
                        }


                        System.Management.Automation.WildcardPattern
                        f_1559_52003_52029(string
                        pattern)
                        {
                            var return_v = new System.Management.Automation.WildcardPattern(pattern);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 52003, 52029);
                            return return_v;
                        }


                        System.Management.Automation.Language.CommandElementAst
                        f_1559_52117_52133(System.Management.Automation.Language.AstPair
                        this_param)
                        {
                            var return_v = this_param.Argument;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 52117, 52133);
                            return return_v;
                        }


                        string
                        f_1559_52301_52321(System.Management.Automation.Language.StringConstantExpressionAst
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 52301, 52321);
                            return return_v;
                        }


                        System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                        f_1559_52464_52485(System.Management.Automation.Language.ArrayLiteralAst
                        this_param)
                        {
                            var return_v = this_param.Elements;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 52464, 52485);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<System.Management.Automation.Language.StringConstantExpressionAst>
                        f_1559_52464_52523(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                        source)
                        {
                            var return_v = source.OfType<System.Management.Automation.Language.StringConstantExpressionAst>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 52464, 52523);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<object>
                        f_1559_52464_52564(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.StringConstantExpressionAst>
                        source, System.Func<System.Management.Automation.Language.StringConstantExpressionAst, object>
                        selector)
                        {
                            var return_v = source.Select<System.Management.Automation.Language.StringConstantExpressionAst, object>(selector);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 52464, 52564);
                            return return_v;
                        }


                        object[]
                        f_1559_52464_52574(System.Collections.Generic.IEnumerable<object>
                        source)
                        {
                            var return_v = source.ToArray<object>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 52464, 52574);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                        f_1559_54312_54350(System.Management.Automation.TypeInferenceVisitor
                        this_param, System.Management.Automation.Language.CommandBaseAst
                        ast)
                        {
                            var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 54312, 54350);
                            return return_v;
                        }


                        System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                        f_1559_54411_54470(System.Management.Automation.TypeInferenceVisitor
                        this_param, System.Management.Automation.PSTypeName
                        t, System.Func<object, bool>
                        isInPropertyList)
                        {
                            var return_v = this_param.GetMemberNameAndTypeFromProperties(t, isInPropertyList);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 54411, 54470);
                            return return_v;
                        }


                        System.Management.Automation.PSSyntheticTypeName
                        f_1559_54515_54565(System.Type
                        type, System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                        membersTypes)
                        {
                            var return_v = PSSyntheticTypeName.Create(type, (System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>)membersTypes);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 54515, 54565);
                            return return_v;
                        }


                        int
                        f_1559_54497_54566(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                        this_param, System.Management.Automation.PSSyntheticTypeName
                        item)
                        {
                            this_param.Add((System.Management.Automation.PSTypeName)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 54497, 54566);
                            return 0;
                        }


                        System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                        f_1559_54312_54350_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 54312, 54350);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 51616, 54624);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 51616, 54624);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 54640, 54709);

                var
                previousPipelineElement = f_1559_54670_54708(commandAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 54723, 54814) || true) && (previousPipelineElement == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 54723, 54814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 54792, 54799);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 54723, 54814);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 54830, 55041) || true) && (f_1559_54834_54904(f_1559_54834_54862(pseudoBinding), "Property", out property))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 54830, 55041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 54938, 54999);

                    f_1559_54938_54998(property, previousPipelineElement);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55019, 55026);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 54830, 55041);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55057, 55322) || true) && (f_1559_55061_55145(f_1559_55061_55089(pseudoBinding), "ExcludeProperty", out excludeProperty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 55057, 55322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55179, 55280);

                    f_1559_55179_55279(excludeProperty, previousPipelineElement, includeMatchedProperties: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55300, 55307);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 55057, 55322);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55338, 56204) || true) && (f_1559_55342_55434(f_1559_55342_55370(pseudoBinding), "ExpandProperty", out expandedPropertyArgument))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 55338, 56204);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55468, 56162);
                        foreach (var t in f_1559_55486_55521_I(f_1559_55486_55521(this, previousPipelineElement)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 55468, 56162);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55594, 55683);

                            var
                            temp = (f_1559_55606_55650(((AstPair)expandedPropertyArgument)) as StringConstantExpressionAst)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55705, 55755);

                            var
                            memberName = (DynAbs.Tracing.TraceSender.Conditional_F1(1559, 55722, 55734) || ((temp != null && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 55737, 55747)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 55750, 55754))) ? f_1559_55737_55747(temp) : null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55779, 56143) || true) && (memberName != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 55779, 56143);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55851, 55915);

                                var
                                members = f_1559_55865_55914(_context, t, false, null)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 55941, 55975);

                                bool
                                maybeWantDefaultCtor = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56001, 56120);

                                f_1559_56001_56119(this, t, memberName, members, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst: false, inferredTypes);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 55779, 56143);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 55468, 56162);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 695);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 695);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56182, 56189);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 55338, 56204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56220, 56277);

                f_1559_56220_56276(this, commandAst, inferredTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 51463, 56288);

                System.Management.Automation.Language.CommandBaseAst
                f_1559_54670_54708(System.Management.Automation.Language.CommandAst
                commandAst)
                {
                    var return_v = GetPreviousPipelineCommand(commandAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 54670, 54708);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_54834_54862(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 54834, 54862);
                    return return_v;
                }


                bool
                f_1559_54834_54904(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 54834, 54904);
                    return return_v;
                }


                int
                f_1559_54938_54998(System.Management.Automation.Language.AstParameterArgumentPair
                astParameterArgumentPair, System.Management.Automation.Language.CommandBaseAst
                previousPipelineElementAst)
                {
                    InferFromSelectProperties(astParameterArgumentPair, previousPipelineElementAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 54938, 54998);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_55061_55089(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 55061, 55089);
                    return return_v;
                }


                bool
                f_1559_55061_55145(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 55061, 55145);
                    return return_v;
                }


                int
                f_1559_55179_55279(System.Management.Automation.Language.AstParameterArgumentPair
                astParameterArgumentPair, System.Management.Automation.Language.CommandBaseAst
                previousPipelineElementAst, bool
                includeMatchedProperties)
                {
                    InferFromSelectProperties(astParameterArgumentPair, previousPipelineElementAst, includeMatchedProperties: includeMatchedProperties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 55179, 55279);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_55342_55370(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 55342, 55370);
                    return return_v;
                }


                bool
                f_1559_55342_55434(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 55342, 55434);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_55486_55521(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandBaseAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 55486, 55521);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1559_55606_55650(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 55606, 55650);
                    return return_v;
                }


                string
                f_1559_55737_55747(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 55737, 55747);
                    return return_v;
                }


                System.Collections.Generic.IList<object>
                f_1559_55865_55914(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.PSTypeName
                typename, bool
                isStatic, System.Func<object, bool>
                filter)
                {
                    var return_v = this_param.GetMembersByInferredType(typename, isStatic, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 55865, 55914);
                    return return_v;
                }


                int
                f_1559_56001_56119(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.PSTypeName
                thisType, string
                memberName, System.Collections.Generic.IList<object>
                members, ref bool
                maybeWantDefaultCtor, bool
                isInvokeMemberExpressionAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.GetTypesOfMembers(thisType, memberName, members, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst: isInvokeMemberExpressionAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 56001, 56119);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_55486_55521_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 55486, 55521);
                    return return_v;
                }


                int
                f_1559_56220_56276(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandAst
                commandAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.InferTypesFromPreviousCommand(commandAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 56220, 56276);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 51463, 56288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 51463, 56288);
            }
        }

        private List<PSMemberNameAndType> GetMemberNameAndTypeFromProperties(PSTypeName t, Func<object, bool> isInPropertyList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 56300, 57422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56444, 56488);

                var
                list = f_1559_56455_56487(8)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56502, 56578);

                var
                members = f_1559_56516_56577(_context, t, false, isInPropertyList)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56592, 56633);

                var
                memberTypes = f_1559_56610_56632()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56647, 57383);
                    foreach (var mem in f_1559_56667_56674_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 56647, 57383);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56708, 56798) || true) && (!f_1559_56713_56728(mem))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 56708, 56798);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56770, 56779);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 56708, 56798);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56818, 56854);

                        var
                        memberName = f_1559_56835_56853(mem)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56872, 56975) || true) && (!f_1559_56877_56905(isInPropertyList, memberName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 56872, 56975);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56947, 56956);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 56872, 56975);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 56995, 57029);

                        bool
                        maybeWantDefaultCtor = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57047, 57067);

                        f_1559_57047_57066(memberTypes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57085, 57202);

                        f_1559_57085_57201(this, t, memberName, members, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst: false, memberTypes);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57220, 57368) || true) && (f_1559_57224_57241(memberTypes) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 57220, 57368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57287, 57349);

                            f_1559_57287_57348(list, f_1559_57296_57347(memberName, f_1559_57332_57346(memberTypes, 0)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 57220, 57368);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 56647, 57383);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 737);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 737);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57399, 57411);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 56300, 57422);

                System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                f_1559_56455_56487(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 56455, 56487);
                    return return_v;
                }


                System.Collections.Generic.IList<object>
                f_1559_56516_56577(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.PSTypeName
                typename, bool
                isStatic, System.Func<object, bool>
                filter)
                {
                    var return_v = this_param.GetMembersByInferredType(typename, isStatic, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 56516, 56577);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_56610_56632()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 56610, 56632);
                    return return_v;
                }


                bool
                f_1559_56713_56728(object
                member)
                {
                    var return_v = IsProperty(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 56713, 56728);
                    return return_v;
                }


                string
                f_1559_56835_56853(object
                member)
                {
                    var return_v = GetMemberName(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 56835, 56853);
                    return return_v;
                }


                bool
                f_1559_56877_56905(System.Func<object, bool>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke((object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 56877, 56905);
                    return return_v;
                }


                int
                f_1559_57047_57066(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 57047, 57066);
                    return 0;
                }


                int
                f_1559_57085_57201(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.PSTypeName
                thisType, string
                memberName, System.Collections.Generic.IList<object>
                members, ref bool
                maybeWantDefaultCtor, bool
                isInvokeMemberExpressionAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    this_param.GetTypesOfMembers(thisType, memberName, members, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst: isInvokeMemberExpressionAst, inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 57085, 57201);
                    return 0;
                }


                int
                f_1559_57224_57241(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 57224, 57241);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_57332_57346(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 57332, 57346);
                    return return_v;
                }


                System.Management.Automation.PSMemberNameAndType
                f_1559_57296_57347(string
                name, System.Management.Automation.PSTypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSMemberNameAndType(name, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 57296, 57347);
                    return return_v;
                }


                int
                f_1559_57287_57348(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param, System.Management.Automation.PSMemberNameAndType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 57287, 57348);
                    return 0;
                }


                System.Collections.Generic.IList<object>
                f_1559_56667_56674_I(System.Collections.Generic.IList<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 56667, 56674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 56300, 57422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 56300, 57422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsProperty(object member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 57434, 57845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57504, 57834);

                switch (member)
                {

                    case PropertyInfo _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 57504, 57834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57594, 57606);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 57504, 57834);

                    case PSMemberInfo memberInfo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 57504, 57834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57675, 57758);

                        return (f_1559_57683_57704(memberInfo) & PSMemberTypes.Properties) == f_1559_57736_57757(memberInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 57504, 57834);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 57504, 57834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57806, 57819);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 57504, 57834);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 57434, 57845);

                System.Management.Automation.PSMemberTypes
                f_1559_57683_57704(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.MemberType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 57683, 57704);
                    return return_v;
                }


                System.Management.Automation.PSMemberTypes
                f_1559_57736_57757(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.MemberType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 57736, 57757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 57434, 57845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 57434, 57845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetMemberName(object member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 57857, 58722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57932, 57956);

                var
                name = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 57970, 58683);

                switch (member)
                {

                    case PSMemberInfo psMemberInfo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 57970, 58683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 58071, 58096);

                        name = f_1559_58078_58095(psMemberInfo);
                        DynAbs.Tracing.TraceSender.TraceBreak(1559, 58118, 58124);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 57970, 58683);

                    case MemberInfo memberInfo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 57970, 58683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 58191, 58214);

                        name = f_1559_58198_58213(memberInfo);
                        DynAbs.Tracing.TraceSender.TraceBreak(1559, 58236, 58242);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 57970, 58683);

                    case PropertyMemberAst propertyMember:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 57970, 58683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 58320, 58347);

                        name = f_1559_58327_58346(propertyMember);
                        DynAbs.Tracing.TraceSender.TraceBreak(1559, 58369, 58375);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 57970, 58683);

                    case FunctionMemberAst functionMember:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 57970, 58683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 58453, 58480);

                        name = f_1559_58460_58479(functionMember);
                        DynAbs.Tracing.TraceSender.TraceBreak(1559, 58502, 58508);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 57970, 58683);

                    case DotNetAdapter.MethodCacheEntry methodCacheEntry:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 57970, 58683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 58601, 58640);

                        name = f_1559_58608_58639(f_1559_58608_58627(methodCacheEntry, 0).method);
                        DynAbs.Tracing.TraceSender.TraceBreak(1559, 58662, 58668);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 57970, 58683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 58699, 58711);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 57857, 58722);

                string
                f_1559_58078_58095(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 58078, 58095);
                    return return_v;
                }


                string
                f_1559_58198_58213(System.Reflection.MemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 58198, 58213);
                    return return_v;
                }


                string
                f_1559_58327_58346(System.Management.Automation.Language.PropertyMemberAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 58327, 58346);
                    return return_v;
                }


                string
                f_1559_58460_58479(System.Management.Automation.Language.FunctionMemberAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 58460, 58479);
                    return return_v;
                }


                System.Management.Automation.MethodInformation
                f_1559_58608_58627(System.Management.Automation.DotNetAdapter.MethodCacheEntry
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 58608, 58627);
                    return return_v;
                }


                string
                f_1559_58608_58639(System.Reflection.MethodBase
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 58608, 58639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 57857, 58722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 57857, 58722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSTypeName InferTypesFromNewObjectCommand(PseudoBindingInfo pseudoBinding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 58734, 59268);
                System.Management.Automation.Language.AstParameterArgumentPair typeArgument = default(System.Management.Automation.Language.AstParameterArgumentPair);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 58848, 59229) || true) && (f_1559_58852_58926(f_1559_58852_58880(pseudoBinding), "TypeName", out typeArgument))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 58848, 59229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 58960, 59007);

                    var
                    typeArgumentPair = typeArgument as AstPair
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59025, 59214) || true) && (f_1559_59029_59055_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(typeArgumentPair, 1559, 59029, 59055)?.Argument) is StringConstantExpressionAst stringConstantExpr)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 59025, 59214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59147, 59195);

                        return f_1559_59154_59194(f_1559_59169_59193(stringConstantExpr));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 59025, 59214);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 58848, 59229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59245, 59257);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 58734, 59268);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1559_58852_58880(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 58852, 58880);
                    return return_v;
                }


                bool
                f_1559_58852_58926(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, out System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 58852, 58926);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1559_59029_59055_M(System.Management.Automation.Language.CommandElementAst
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 59029, 59055);
                    return return_v;
                }


                string
                f_1559_59169_59193(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 59169, 59193);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_59154_59194(string
                name)
                {
                    var return_v = new System.Management.Automation.PSTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 59154, 59194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 58734, 59268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 58734, 59268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<PSTypeName> InferTypesFrom(MemberExpressionAst memberExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 59280, 61322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59392, 59446);

                var
                memberCommandElement = f_1559_59419_59445(memberExpressionAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59460, 59502);

                var
                isStatic = f_1559_59475_59501(memberExpressionAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59516, 59564);

                var
                expression = f_1559_59533_59563(memberExpressionAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59645, 59723);

                var
                memberAsStringConst = memberCommandElement as StringConstantExpressionAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59737, 59850) || true) && (memberAsStringConst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 59737, 59850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59802, 59835);

                    return f_1559_59809_59834();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 59737, 59850);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59866, 59921);

                var
                exprType = f_1559_59881_59920(this, expression, isStatic)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 59935, 60061) || true) && (exprType == null || (DynAbs.Tracing.TraceSender.Expression_False(1559, 59939, 59979) || f_1559_59959_59974(exprType) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 59935, 60061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 60013, 60046);

                    return f_1559_60020_60045();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 59935, 60061);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 60077, 60112);

                var
                res = f_1559_60087_60111(10)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 60126, 60210);

                bool
                isInvokeMemberExpressionAst = memberExpressionAst is InvokeMemberExpressionAst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 60224, 60431);

                var
                maybeWantDefaultCtor = isStatic
                && (DynAbs.Tracing.TraceSender.Expression_True(1559, 60251, 60330) && isInvokeMemberExpressionAst
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 60251, 60430) && f_1559_60374_60430(f_1559_60374_60399(memberAsStringConst), "new"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 60591, 60659);

                var
                memberNameList = new List<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1559_60631_60656(memberAsStringConst), 1559, 60612, 60658) }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 60673, 61284);
                    foreach (var type in f_1559_60694_60702_I(exprType))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 60673, 61284);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 60736, 60839) || true) && (f_1559_60740_60749(type) == typeof(PSObject))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 60736, 60839);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 60811, 60820);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 60736, 60839);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 60859, 60937);

                        var
                        members = f_1559_60873_60936(_context, type, isStatic, filter: null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 60957, 61066);

                        f_1559_60957_61065(this, type, memberNameList, members, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst, res);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 61170, 61269) || true) && (maybeWantDefaultCtor)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 61170, 61269);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 61236, 61250);

                            f_1559_61236_61249(res, type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 61170, 61269);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 60673, 61284);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 61300, 61311);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 59280, 61322);

                System.Management.Automation.Language.CommandElementAst
                f_1559_59419_59445(System.Management.Automation.Language.MemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 59419, 59445);
                    return return_v;
                }


                bool
                f_1559_59475_59501(System.Management.Automation.Language.MemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Static;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 59475, 59501);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_59533_59563(System.Management.Automation.Language.MemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 59533, 59563);
                    return return_v;
                }


                System.Management.Automation.PSTypeName[]
                f_1559_59809_59834()
                {
                    var return_v = Array.Empty<PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 59809, 59834);
                    return return_v;
                }


                System.Management.Automation.PSTypeName[]
                f_1559_59881_59920(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.ExpressionAst
                expression, bool
                isStatic)
                {
                    var return_v = this_param.GetExpressionType(expression, isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 59881, 59920);
                    return return_v;
                }


                int
                f_1559_59959_59974(System.Management.Automation.PSTypeName[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 59959, 59974);
                    return return_v;
                }


                System.Management.Automation.PSTypeName[]
                f_1559_60020_60045()
                {
                    var return_v = Array.Empty<PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 60020, 60045);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_60087_60111(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 60087, 60111);
                    return return_v;
                }


                string
                f_1559_60374_60399(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 60374, 60399);
                    return return_v;
                }


                bool
                f_1559_60374_60430(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 60374, 60430);
                    return return_v;
                }


                string
                f_1559_60631_60656(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 60631, 60656);
                    return return_v;
                }


                System.Type
                f_1559_60740_60749(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 60740, 60749);
                    return return_v;
                }


                System.Collections.Generic.IList<object>
                f_1559_60873_60936(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.PSTypeName
                typename, bool
                isStatic, System.Func<object, bool>
                filter)
                {
                    var return_v = this_param.GetMembersByInferredType(typename, isStatic, filter: filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 60873, 60936);
                    return return_v;
                }


                int
                f_1559_60957_61065(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.PSTypeName
                currentType, System.Collections.Generic.List<string>
                memberNamesToCheck, System.Collections.Generic.IList<object>
                members, ref bool
                maybeWantDefaultCtor, bool
                isInvokeMemberExpressionAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                result)
                {
                    this_param.AddTypesOfMembers(currentType, memberNamesToCheck, members, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 60957, 61065);
                    return 0;
                }


                int
                f_1559_61236_61249(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 61236, 61249);
                    return 0;
                }


                System.Management.Automation.PSTypeName[]
                f_1559_60694_60702_I(System.Management.Automation.PSTypeName[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 60694, 60702);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 59280, 61322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 59280, 61322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetTypesOfMembers(
                    PSTypeName thisType,
                    string memberName,
                    IList<object> members,
                    ref bool maybeWantDefaultCtor,
                    bool isInvokeMemberExpressionAst,
                    List<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 61334, 61837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 61628, 61685);

                var
                memberNamesToCheck = new List<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => memberName, 1559, 61653, 61684) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 61699, 61826);

                f_1559_61699_61825(this, thisType, memberNamesToCheck, members, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst, inferredTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 61334, 61837);

                int
                f_1559_61699_61825(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.PSTypeName
                currentType, System.Collections.Generic.List<string>
                memberNamesToCheck, System.Collections.Generic.IList<object>
                members, ref bool
                maybeWantDefaultCtor, bool
                isInvokeMemberExpressionAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                result)
                {
                    this_param.AddTypesOfMembers(currentType, memberNamesToCheck, members, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 61699, 61825);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 61334, 61837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 61334, 61837);
            }
        }

        private void AddTypesOfMembers(
                    PSTypeName currentType,
                    List<string> memberNamesToCheck,
                    IList<object> members,
                    ref bool maybeWantDefaultCtor,
                    bool isInvokeMemberExpressionAst,
                    List<PSTypeName> result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 61849, 62646);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 62162, 62167);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 62153, 62635) || true) && (i < f_1559_62173_62197(memberNamesToCheck))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 62199, 62202)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 62153, 62635))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 62153, 62635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 62236, 62285);

                        string
                        memberNameToCheck = f_1559_62263_62284(memberNamesToCheck, i)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 62303, 62620);
                            foreach (var member in f_1559_62326_62333_I(members))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 62303, 62620);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 62375, 62601) || true) && (f_1559_62379_62522(this, currentType, member, memberNameToCheck, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst, result, memberNamesToCheck))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 62375, 62601);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1559, 62572, 62578);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 62375, 62601);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 62303, 62620);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 318);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 318);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 483);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 61849, 62646);

                int
                f_1559_62173_62197(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 62173, 62197);
                    return return_v;
                }


                string
                f_1559_62263_62284(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 62263, 62284);
                    return return_v;
                }


                bool
                f_1559_62379_62522(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.PSTypeName
                currentType, object
                member, string
                memberName, ref bool
                maybeWantDefaultCtor, bool
                isInvokeMemberExpressionAst, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                result, System.Collections.Generic.List<string>
                memberNamesToCheck)
                {
                    var return_v = this_param.TryGetTypeFromMember(currentType, member, memberName, ref maybeWantDefaultCtor, isInvokeMemberExpressionAst, result, memberNamesToCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 62379, 62522);
                    return return_v;
                }


                System.Collections.Generic.IList<object>
                f_1559_62326_62333_I(System.Collections.Generic.IList<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 62326, 62333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 61849, 62646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 61849, 62646);
            }
        }

        private bool TryGetTypeFromMember(
                    PSTypeName currentType,
                    object member,
                    string memberName,
                    ref bool maybeWantDefaultCtor,
                    bool isInvokeMemberExpressionAst,
                    List<PSTypeName> result,
                    List<string> memberNamesToCheck)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 62658, 69137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 62989, 69097);

                switch (member)
                {

                    case PropertyInfo propertyInfo: // .net property
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 62989, 69097);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 63107, 63361) || true) && (f_1559_63111_63164(f_1559_63111_63128(propertyInfo), memberName) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 63111, 63196) && !isInvokeMemberExpressionAst))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 63107, 63361);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 63246, 63300);

                            f_1559_63246_63299(result, f_1559_63257_63298(f_1559_63272_63297(propertyInfo)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 63326, 63338);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 63107, 63361);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 63385, 63398);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 62989, 69097);

                    case FieldInfo fieldInfo: // .net field
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 62989, 69097);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 63477, 63722) || true) && (f_1559_63481_63531(f_1559_63481_63495(fieldInfo), memberName) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 63481, 63563) && !isInvokeMemberExpressionAst))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 63477, 63722);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 63613, 63661);

                            f_1559_63613_63660(result, f_1559_63624_63659(f_1559_63639_63658(fieldInfo)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 63687, 63699);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 63477, 63722);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 63746, 63759);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 62989, 69097);

                    case DotNetAdapter.MethodCacheEntry methodCacheEntry: // .net method
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 62989, 69097);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 63867, 64207) || true) && (f_1559_63871_63957(f_1559_63871_63902(f_1559_63871_63890(methodCacheEntry, 0).method), memberName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 63867, 64207);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 64007, 64036);

                            maybeWantDefaultCtor = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 64062, 64146);

                            f_1559_64062_64145(this, methodCacheEntry, result, isInvokeMemberExpressionAst);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 64172, 64184);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 63867, 64207);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 64231, 64244);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 62989, 69097);

                    case MemberAst memberAst: // this is for members defined by PowerShell classes
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 62989, 69097);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 64362, 65821) || true) && (f_1559_64366_64435(f_1559_64366_64380(memberAst), memberName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 64362, 65821);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 64485, 65798) || true) && (isInvokeMemberExpressionAst)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 64485, 65798);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 64574, 64876) || true) && (memberAst is FunctionMemberAst functionMemberAst && (DynAbs.Tracing.TraceSender.Expression_True(1559, 64578, 64667) && !f_1559_64631_64667(functionMemberAst)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 64574, 64876);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 64733, 64799);

                                    f_1559_64733_64798(result, f_1559_64744_64797(f_1559_64759_64796(f_1559_64759_64787(functionMemberAst))));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 64833, 64845);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 64574, 64876);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 64485, 65798);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 64485, 65798);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 64990, 65771) || true) && (memberAst is PropertyMemberAst propertyMemberAst)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 64990, 65771);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 65108, 65362);

                                    f_1559_65108_65361(result, (DynAbs.Tracing.TraceSender.Conditional_F1(1559, 65157, 65195) || ((f_1559_65157_65187(propertyMemberAst) != null
                                    && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 65235, 65290)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 65330, 65360))) ? f_1559_65235_65290(f_1559_65250_65289(f_1559_65250_65280(propertyMemberAst))) : f_1559_65330_65360(typeof(object)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 65398, 65410);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 64990, 65771);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 64990, 65771);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 65649, 65694);

                                    f_1559_65649_65693(                                // Accessing a method as a property, we'd return a wrapper over the method.
                                                                    result, f_1559_65660_65692(typeof(PSMethod)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 65728, 65740);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 64990, 65771);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 64485, 65798);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 64362, 65821);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 65845, 65858);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 62989, 69097);

                    case PSMemberInfo memberInfo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 62989, 69097);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 65927, 66088) || true) && (!f_1559_65932_66002(f_1559_65932_65947(memberInfo), memberName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 65927, 66088);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66052, 66065);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 65927, 66088);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66112, 66143);

                        ScriptBlock
                        scriptBlock = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66165, 68031);

                        switch (memberInfo)
                        {

                            case PSMethod m:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 66165, 68031);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66279, 66574) || true) && (m.adapterData is DotNetAdapter.MethodCacheEntry methodCacheEntry)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 66279, 66574);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66413, 66497);

                                    f_1559_66413_66496(this, methodCacheEntry, result, isInvokeMemberExpressionAst);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66531, 66543);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 66279, 66574);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66606, 66619);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 66165, 68031);

                            case PSProperty p:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 66165, 68031);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66693, 66739);

                                f_1559_66693_66738(result, f_1559_66704_66737(f_1559_66719_66736(f_1559_66719_66726(p))));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66769, 66781);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 66165, 68031);

                            case PSNoteProperty noteProperty:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 66165, 68031);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66870, 66927);

                                f_1559_66870_66926(result, f_1559_66881_66925(f_1559_66896_66924(f_1559_66896_66914(noteProperty))));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 66957, 66969);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 66165, 68031);

                            case PSAliasProperty aliasProperty:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 66165, 68031);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 67060, 67119);

                                f_1559_67060_67118(memberNamesToCheck, f_1559_67083_67117(aliasProperty));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 67149, 67161);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 66165, 68031);

                            case PSCodeProperty codeProperty:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 66165, 68031);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 67250, 67463) || true) && (f_1559_67254_67286(codeProperty) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 67250, 67463);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 67360, 67432);

                                    f_1559_67360_67431(result, f_1559_67371_67430(f_1559_67386_67429(f_1559_67386_67418(codeProperty))));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 67250, 67463);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 67495, 67507);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 66165, 68031);

                            case PSScriptProperty scriptProperty:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 66165, 68031);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 67600, 67642);

                                scriptBlock = f_1559_67614_67641(scriptProperty);
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 67672, 67678);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 66165, 68031);

                            case PSScriptMethod scriptMethod:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 66165, 68031);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 67767, 67801);

                                scriptBlock = f_1559_67781_67800(scriptMethod);
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 67831, 67837);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 66165, 68031);

                            case PSInferredProperty inferredProperty:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 66165, 68031);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 67934, 67972);

                                f_1559_67934_67971(result, f_1559_67945_67970(inferredProperty));
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 68002, 68008);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 66165, 68031);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 68055, 69045) || true) && (scriptBlock != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 68055, 69045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 68128, 68173);

                            var
                            thisToRestore = f_1559_68148_68172(_context)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 68259, 68298);

                                _context.CurrentThisType = currentType;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 68328, 68368);

                                var
                                outputType = f_1559_68345_68367(scriptBlock)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 68398, 68837) || true) && (outputType != null && (DynAbs.Tracing.TraceSender.Expression_True(1559, 68402, 68445) && f_1559_68424_68440(outputType) != 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 68398, 68837);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 68511, 68539);

                                    f_1559_68511_68538(result, outputType);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 68573, 68585);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 68398, 68837);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 68398, 68837);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 68715, 68760);

                                    f_1559_68715_68759(result, f_1559_68731_68758(this, f_1559_68742_68757(scriptBlock)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 68794, 68806);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 68398, 68837);
                                }
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(1559, 68890, 69022);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 68954, 68995);

                                _context.CurrentThisType = thisToRestore;
                                DynAbs.Tracing.TraceSender.TraceExitFinally(1559, 68890, 69022);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 68055, 69045);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 69069, 69082);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 62989, 69097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 69113, 69126);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 62658, 69137);

                string
                f_1559_63111_63128(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 63111, 63128);
                    return return_v;
                }


                bool
                f_1559_63111_63164(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 63111, 63164);
                    return return_v;
                }


                System.Type
                f_1559_63272_63297(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.PropertyType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 63272, 63297);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_63257_63298(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 63257, 63298);
                    return return_v;
                }


                int
                f_1559_63246_63299(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 63246, 63299);
                    return 0;
                }


                string
                f_1559_63481_63495(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 63481, 63495);
                    return return_v;
                }


                bool
                f_1559_63481_63531(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 63481, 63531);
                    return return_v;
                }


                System.Type
                f_1559_63639_63658(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.FieldType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 63639, 63658);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_63624_63659(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 63624, 63659);
                    return return_v;
                }


                int
                f_1559_63613_63660(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 63613, 63660);
                    return 0;
                }


                System.Management.Automation.MethodInformation
                f_1559_63871_63890(System.Management.Automation.DotNetAdapter.MethodCacheEntry
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 63871, 63890);
                    return return_v;
                }


                string
                f_1559_63871_63902(System.Reflection.MethodBase
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 63871, 63902);
                    return return_v;
                }


                bool
                f_1559_63871_63957(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 63871, 63957);
                    return return_v;
                }


                int
                f_1559_64062_64145(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.DotNetAdapter.MethodCacheEntry
                methodCacheEntry, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                result, bool
                isInvokeMemberExpressionAst)
                {
                    this_param.AddTypesFromMethodCacheEntry(methodCacheEntry, result, isInvokeMemberExpressionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 64062, 64145);
                    return 0;
                }


                string
                f_1559_64366_64380(System.Management.Automation.Language.MemberAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 64366, 64380);
                    return return_v;
                }


                bool
                f_1559_64366_64435(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 64366, 64435);
                    return return_v;
                }


                bool
                f_1559_64631_64667(System.Management.Automation.Language.FunctionMemberAst
                this_param)
                {
                    var return_v = this_param.IsReturnTypeVoid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 64631, 64667);
                    return return_v;
                }


                System.Management.Automation.Language.TypeConstraintAst
                f_1559_64759_64787(System.Management.Automation.Language.FunctionMemberAst
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 64759, 64787);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1559_64759_64796(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 64759, 64796);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_64744_64797(System.Management.Automation.Language.ITypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSTypeName(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 64744, 64797);
                    return return_v;
                }


                int
                f_1559_64733_64798(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 64733, 64798);
                    return 0;
                }


                System.Management.Automation.Language.TypeConstraintAst
                f_1559_65157_65187(System.Management.Automation.Language.PropertyMemberAst
                this_param)
                {
                    var return_v = this_param.PropertyType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 65157, 65187);
                    return return_v;
                }


                System.Management.Automation.Language.TypeConstraintAst
                f_1559_65250_65280(System.Management.Automation.Language.PropertyMemberAst
                this_param)
                {
                    var return_v = this_param.PropertyType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 65250, 65280);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1559_65250_65289(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 65250, 65289);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_65235_65290(System.Management.Automation.Language.ITypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSTypeName(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 65235, 65290);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_65330_65360(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 65330, 65360);
                    return return_v;
                }


                int
                f_1559_65108_65361(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 65108, 65361);
                    return 0;
                }


                System.Management.Automation.PSTypeName
                f_1559_65660_65692(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 65660, 65692);
                    return return_v;
                }


                int
                f_1559_65649_65693(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 65649, 65693);
                    return 0;
                }


                string
                f_1559_65932_65947(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 65932, 65947);
                    return return_v;
                }


                bool
                f_1559_65932_66002(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 65932, 66002);
                    return return_v;
                }


                int
                f_1559_66413_66496(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.DotNetAdapter.MethodCacheEntry
                methodCacheEntry, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                result, bool
                isInvokeMemberExpressionAst)
                {
                    this_param.AddTypesFromMethodCacheEntry(methodCacheEntry, result, isInvokeMemberExpressionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 66413, 66496);
                    return 0;
                }


                object
                f_1559_66719_66726(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 66719, 66726);
                    return return_v;
                }


                System.Type
                f_1559_66719_66736(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 66719, 66736);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_66704_66737(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 66704, 66737);
                    return return_v;
                }


                int
                f_1559_66693_66738(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 66693, 66738);
                    return 0;
                }


                object
                f_1559_66896_66914(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 66896, 66914);
                    return return_v;
                }


                System.Type
                f_1559_66896_66924(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 66896, 66924);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_66881_66925(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 66881, 66925);
                    return return_v;
                }


                int
                f_1559_66870_66926(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 66870, 66926);
                    return 0;
                }


                string
                f_1559_67083_67117(System.Management.Automation.PSAliasProperty
                this_param)
                {
                    var return_v = this_param.ReferencedMemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 67083, 67117);
                    return return_v;
                }


                int
                f_1559_67060_67118(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 67060, 67118);
                    return 0;
                }


                System.Reflection.MethodInfo
                f_1559_67254_67286(System.Management.Automation.PSCodeProperty
                this_param)
                {
                    var return_v = this_param.GetterCodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 67254, 67286);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1559_67386_67418(System.Management.Automation.PSCodeProperty
                this_param)
                {
                    var return_v = this_param.GetterCodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 67386, 67418);
                    return return_v;
                }


                System.Type
                f_1559_67386_67429(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 67386, 67429);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_67371_67430(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 67371, 67430);
                    return return_v;
                }


                int
                f_1559_67360_67431(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 67360, 67431);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1559_67614_67641(System.Management.Automation.PSScriptProperty
                this_param)
                {
                    var return_v = this_param.GetterScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 67614, 67641);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1559_67781_67800(System.Management.Automation.PSScriptMethod
                this_param)
                {
                    var return_v = this_param.Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 67781, 67800);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_67945_67970(System.Management.Automation.PSInferredProperty
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 67945, 67970);
                    return return_v;
                }


                int
                f_1559_67934_67971(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 67934, 67971);
                    return 0;
                }


                System.Management.Automation.PSTypeName
                f_1559_68148_68172(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.CurrentThisType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 68148, 68172);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                f_1559_68345_68367(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.OutputType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 68345, 68367);
                    return return_v;
                }


                int
                f_1559_68424_68440(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 68424, 68440);
                    return return_v;
                }


                int
                f_1559_68511_68538(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 68511, 68538);
                    return 0;
                }


                System.Management.Automation.Language.Ast
                f_1559_68742_68757(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 68742, 68757);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_68731_68758(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = this_param.InferTypes(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 68731, 68758);
                    return return_v;
                }


                int
                f_1559_68715_68759(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 68715, 68759);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 62658, 69137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 62658, 69137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddTypesFromMethodCacheEntry(
                    DotNetAdapter.MethodCacheEntry methodCacheEntry,
                    List<PSTypeName> result,
                    bool isInvokeMemberExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 69149, 69976);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 69363, 69815) || true) && (isInvokeMemberExpressionAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 69363, 69815);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 69428, 69773);
                        foreach (var method in f_1559_69451_69495_I(methodCacheEntry.methodInformationStructures))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 69428, 69773);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 69537, 69754) || true) && (method.method is MethodInfo methodInfo && (DynAbs.Tracing.TraceSender.Expression_True(1559, 69541, 69631) && f_1559_69583_69631_M(!f_1559_69584_69605(methodInfo).ContainsGenericParameters)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 69537, 69754);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 69681, 69731);

                                f_1559_69681_69730(result, f_1559_69692_69729(f_1559_69707_69728(methodInfo)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 69537, 69754);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 69428, 69773);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 346);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 346);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 69793, 69800);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 69363, 69815);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 69920, 69965);

                f_1559_69920_69964(
                            // Accessing a method as a property, we'd return a wrapper over the method.
                            result, f_1559_69931_69963(typeof(PSMethod)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 69149, 69976);

                System.Type
                f_1559_69584_69605(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 69584, 69605);
                    return return_v;
                }


                bool
                f_1559_69583_69631_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 69583, 69631);
                    return return_v;
                }


                System.Type
                f_1559_69707_69728(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 69707, 69728);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_69692_69729(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 69692, 69729);
                    return return_v;
                }


                int
                f_1559_69681_69730(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 69681, 69730);
                    return 0;
                }


                System.Management.Automation.MethodInformation[]
                f_1559_69451_69495_I(System.Management.Automation.MethodInformation[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 69451, 69495);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_69931_69963(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 69931, 69963);
                    return return_v;
                }


                int
                f_1559_69920_69964(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 69920, 69964);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 69149, 69976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 69149, 69976);
            }
        }

        private PSTypeName[] GetExpressionType(ExpressionAst expression, bool isStatic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 69988, 71402);
                System.Management.Automation.PSTypeName _ = default(System.Management.Automation.PSTypeName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70092, 70114);

                PSTypeName[]
                exprType
                = default(PSTypeName[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70128, 71359) || true) && (isStatic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 70128, 71359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70174, 70223);

                    var
                    exprAsType = expression as TypeExpressionAst
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70241, 70336) || true) && (exprAsType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 70241, 70336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70305, 70317);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 70241, 70336);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70356, 70407);

                    var
                    type = f_1559_70367_70406(f_1559_70367_70386(exprAsType))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70425, 70909) || true) && (type == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 70425, 70909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70483, 70530);

                        var
                        typeName = f_1559_70498_70517(exprAsType) as TypeName
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70552, 70677) || true) && (DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(typeName, 1559, 70556, 70584)?._typeDefinitionAst == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 70552, 70677);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70642, 70654);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 70552, 70677);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70701, 70766);

                        exprType = new[] { f_1559_70720_70763(typeName._typeDefinitionAst) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 70425, 70909);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 70425, 70909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70848, 70890);

                        exprType = new[] { f_1559_70867_70887(type) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 70425, 70909);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 70128, 71359);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 70128, 71359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 70975, 71019);

                    exprType = f_1559_70986_71018(f_1559_70986_71008(this, expression));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 71037, 71344) || true) && (f_1559_71041_71056(exprType) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 71037, 71344);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 71103, 71285) || true) && (f_1559_71107_71196(_context, expression, out _))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 71103, 71285);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 71246, 71262);

                            return exprType;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 71103, 71285);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 71309, 71325);

                        return exprType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 71037, 71344);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 70128, 71359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 71375, 71391);

                return exprType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 69988, 71402);

                System.Management.Automation.Language.ITypeName
                f_1559_70367_70386(System.Management.Automation.Language.TypeExpressionAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 70367, 70386);
                    return return_v;
                }


                System.Type
                f_1559_70367_70406(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 70367, 70406);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1559_70498_70517(System.Management.Automation.Language.TypeExpressionAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 70498, 70517);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_70720_70763(System.Management.Automation.Language.TypeDefinitionAst
                typeDefinitionAst)
                {
                    var return_v = new System.Management.Automation.PSTypeName(typeDefinitionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 70720, 70763);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_70867_70887(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 70867, 70887);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_70986_71008(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.ExpressionAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 70986, 71008);
                    return return_v;
                }


                System.Management.Automation.PSTypeName[]
                f_1559_70986_71018(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                source)
                {
                    var return_v = source.ToArray<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 70986, 71018);
                    return return_v;
                }


                int
                f_1559_71041_71056(System.Management.Automation.PSTypeName[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 71041, 71056);
                    return return_v;
                }


                bool
                f_1559_71107_71196(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.Language.ExpressionAst
                expression, out System.Management.Automation.PSTypeName
                typeName)
                {
                    var return_v = this_param.TryGetRepresentativeTypeNameFromExpressionSafeEval(expression, out typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 71107, 71196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 69988, 71402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 69988, 71402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InferTypeFrom(VariableExpressionAst variableExpressionAst, List<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 71414, 82401);
                System.Management.Automation.PSTypeName evalTypeName = default(System.Management.Automation.PSTypeName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 71697, 71754);

                var
                astVariablePath = f_1559_71719_71753(variableExpressionAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 71768, 72054) || true) && (f_1559_71772_71799_M(!astVariablePath.IsVariable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 71768, 72054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 72032, 72039);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 71768, 72054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 72070, 72112);

                Ast
                parent = f_1559_72083_72111(variableExpressionAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 72126, 77191) || true) && (f_1559_72130_72159(astVariablePath) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 72130, 72330) && (f_1559_72181_72234(f_1559_72209_72233(astVariablePath)) || (DynAbs.Tracing.TraceSender.Expression_False(1559, 72181, 72329) || f_1559_72256_72329(f_1559_72256_72280(astVariablePath), SpecialVariables.PSItem)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 72126, 77191);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 72453, 72727) || true) && (parent != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 72453, 72727);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 72516, 72661) || true) && (parent is ScriptBlockExpressionAst || (DynAbs.Tracing.TraceSender.Expression_False(1559, 72520, 72582) || parent is CatchClauseAst))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 72516, 72661);
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 72632, 72638);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 72516, 72661);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 72685, 72708);

                            parent = f_1559_72694_72707(parent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 72453, 72727);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 72453, 72727);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 72453, 72727);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 72747, 77176) || true) && (parent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 72747, 77176);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 72807, 73544) || true) && (f_1559_72811_72824(parent) is CommandExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1559, 72811, 72887) && f_1559_72852_72872(f_1559_72852_72865(parent)) is PipelineAst))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 72807, 73544);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 73088, 73521) || true) && (f_1559_73092_73119(f_1559_73092_73112(f_1559_73092_73105(parent))) is HashtableAst)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 73088, 73521);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 73193, 73230);

                                parent = f_1559_73202_73229(f_1559_73202_73222(f_1559_73202_73215(parent)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 73088, 73521);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 73088, 73521);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 73288, 73521) || true) && (f_1559_73292_73319(f_1559_73292_73312(f_1559_73292_73305(parent))) is ArrayLiteralAst && (DynAbs.Tracing.TraceSender.Expression_True(1559, 73292, 73392) && f_1559_73342_73376(f_1559_73342_73369(f_1559_73342_73362(f_1559_73342_73355(parent)))) is HashtableAst))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 73288, 73521);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 73450, 73494);

                                    parent = f_1559_73459_73493(f_1559_73459_73486(f_1559_73459_73479(f_1559_73459_73472(parent))));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 73288, 73521);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 73088, 73521);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 72807, 73544);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 73568, 73704) || true) && (f_1559_73572_73585(parent) is CommandParameterAst)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 73568, 73704);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 73658, 73681);

                            parent = f_1559_73667_73680(parent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 73568, 73704);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 73728, 74691) || true) && (parent is CatchClauseAst catchBlock)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 73728, 74691);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 73817, 74633) || true) && (f_1559_73821_73848(f_1559_73821_73842(catchBlock)) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 73817, 74633);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 73910, 74437);
                                    foreach (TypeConstraintAst catchType in f_1559_73950_73971_I(f_1559_73950_73971(catchBlock)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 73910, 74437);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 74037, 74097);

                                        Type
                                        exceptionType = f_1559_74058_74096(f_1559_74058_74076(catchType))
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 74131, 74406) || true) && (exceptionType != null && (DynAbs.Tracing.TraceSender.Expression_True(1559, 74135, 74209) && f_1559_74160_74209(typeof(Exception), exceptionType)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 74131, 74406);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 74283, 74371);

                                            f_1559_74283_74370(inferredTypes, f_1559_74301_74369(f_1559_74316_74368(typeof(ErrorRecord<>), exceptionType)));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 74131, 74406);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 73910, 74437);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 528);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 528);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 73817, 74633);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 73817, 74633);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 74551, 74606);

                                f_1559_74551_74605(inferredTypes, f_1559_74569_74604(typeof(ErrorRecord)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 73817, 74633);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 74661, 74668);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 73728, 74691);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 74715, 77157) || true) && (f_1559_74719_74732(parent) is CommandAst commandAst)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 74715, 77157);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 74907, 74964);

                            PipelineAst
                            pipelineAst = (PipelineAst)f_1559_74946_74963(commandAst)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 74990, 75070);

                            var
                            previousCommandIndex = f_1559_75017_75065(f_1559_75017_75045(pipelineAst), commandAst) - 1
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 75096, 75216) || true) && (previousCommandIndex < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 75096, 75216);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 75182, 75189);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 75096, 75216);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 75244, 77099);
                                foreach (var result in f_1559_75267_75310_I(f_1559_75267_75310(this, f_1559_75278_75309(f_1559_75278_75306(pipelineAst), 0))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 75244, 77099);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 75368, 77014) || true) && (f_1559_75372_75383(result) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 75368, 77014);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 75863, 76106) || true) && (f_1559_75867_75886(f_1559_75867_75878(result)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 75863, 76106);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 75960, 76024);

                                            f_1559_75960_76023(inferredTypes, f_1559_75978_76022(f_1559_75993_76021(f_1559_75993_76004(result))));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 76062, 76071);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 75863, 76106);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 76142, 76983) || true) && (f_1559_76146_76195(typeof(IEnumerable), f_1559_76183_76194(result)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 76142, 76983);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 76376, 76431);

                                            var
                                            enumerableInterfaces = f_1559_76403_76430(f_1559_76403_76414(result))
                                            ;
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 76469, 76899);
                                                foreach (var t in f_1559_76487_76507_I(enumerableInterfaces))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 76469, 76899);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 76589, 76860) || true) && (f_1559_76593_76608(t) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 76593, 76665) && f_1559_76612_76640(t) == typeof(IEnumerable<>)))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 76589, 76860);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 76755, 76817);

                                                        f_1559_76755_76816(inferredTypes, f_1559_76773_76815(f_1559_76788_76811(t)[0]));
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 76589, 76860);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 76469, 76899);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 431);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 431);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 76939, 76948);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 76142, 76983);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 75368, 77014);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77046, 77072);

                                    f_1559_77046_77071(
                                                                inferredTypes, result);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 75244, 77099);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 1856);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 1856);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77127, 77134);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 74715, 77157);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 72747, 77176);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 72126, 77191);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77310, 78684) || true) && (f_1559_77314_77343(astVariablePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 77310, 78684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77377, 77462);

                    var
                    isThis = f_1559_77390_77461(f_1559_77390_77414(astVariablePath), SpecialVariables.This)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77480, 78509) || true) && (!isThis || (DynAbs.Tracing.TraceSender.Expression_False(1559, 77484, 77574) || (f_1559_77496_77529(_context) == null && (DynAbs.Tracing.TraceSender.Expression_True(1559, 77496, 77573) && f_1559_77541_77565(_context) == null))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 77480, 78509);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77625, 77630);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77616, 78236) || true) && (i < f_1559_77636_77678(SpecialVariables.AutomaticVariables))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77680, 77683)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 77616, 78236))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 77616, 78236);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77733, 77920) || true) && (!f_1559_77738_77826(f_1559_77738_77762(astVariablePath), SpecialVariables.AutomaticVariables[i]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 77733, 77920);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77884, 77893);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 77733, 77920);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 77948, 78002);

                                var
                                type = SpecialVariables.AutomaticVariableTypes[i]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 78028, 78179) || true) && (type != typeof(object))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 78028, 78179);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 78112, 78152);

                                    f_1559_78112_78151(inferredTypes, f_1559_78130_78150(type));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 78028, 78179);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1559, 78207, 78213);

                                break;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 621);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 621);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 77480, 78509);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 77480, 78509);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 78318, 78411);

                        var
                        typeName = f_1559_78333_78357(_context) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSTypeName>(1559, 78333, 78410) ?? f_1559_78361_78410(f_1559_78376_78409(_context)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 78433, 78461);

                        f_1559_78433_78460(inferredTypes, typeName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 78483, 78490);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 77480, 78509);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 77310, 78684);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 77310, 78684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 78575, 78644);

                    f_1559_78575_78643(inferredTypes, f_1559_78593_78642(f_1559_78608_78641(_context)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 78662, 78669);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 77310, 78684);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 78898, 78999) || true) && (f_1559_78905_78919_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(parent, 1559, 78905, 78919)?.Parent) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 78898, 78999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 78961, 78984);

                        parent = f_1559_78970_78983(parent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 78898, 78999);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 78898, 78999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 78898, 78999);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 79015, 79130) || true) && (f_1559_79019_79033_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(parent, 1559, 79019, 79033)?.Parent) is FunctionDefinitionAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 79015, 79130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 79092, 79115);

                    parent = f_1559_79101_79114(parent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 79015, 79130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 79146, 79205);

                int
                startOffset = f_1559_79164_79204(f_1559_79164_79192(variableExpressionAst))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 79219, 79995);

                var
                targetAsts = (List<Ast>)f_1559_79247_79994(parent, ast =>
                                {
                                    if (ast is ParameterAst || ast is AssignmentStatementAst || ast is CommandAst)
                                    {
                                        return variableExpressionAst.AstAssignsToSameVariable(ast)
                                            && ast.Extent.EndOffset < startOffset;
                                    }

                                    if (ast is ForEachStatementAst)
                                    {
                                        return variableExpressionAst.AstAssignsToSameVariable(ast)
                                            && ast.Extent.StartOffset < startOffset;
                                    }

                                    return false;
                                }, searchNestedScriptBlocks: true)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80011, 80440);
                    foreach (var ast in f_1559_80031_80041_I(targetAsts))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 80011, 80440);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80075, 80425) || true) && (ast is ParameterAst parameterAst)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 80075, 80425);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80153, 80192);

                            var
                            currentCount = f_1559_80172_80191(inferredTypes)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80214, 80263);

                            f_1559_80214_80262(inferredTypes, f_1559_80237_80261(this, parameterAst));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80287, 80406) || true) && (f_1559_80291_80310(inferredTypes) != currentCount)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 80287, 80406);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80376, 80383);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 80287, 80406);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 80075, 80425);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 80011, 80440);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80456, 80527);

                var
                assignAsts = f_1559_80473_80526(f_1559_80473_80516(targetAsts))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80700, 80988);
                    foreach (var assignAst in f_1559_80726_80736_I(assignAsts))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 80700, 80988);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80770, 80973) || true) && (f_1559_80774_80788(assignAst) is ConvertExpressionAst lhsConvert)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 80770, 80973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80865, 80925);

                            f_1559_80865_80924(inferredTypes, f_1559_80883_80923(f_1559_80898_80922(f_1559_80898_80913(lhsConvert))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 80947, 80954);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 80770, 80973);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 80700, 80988);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 289);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81004, 81079);

                var
                foreachAst = f_1559_81021_81078(f_1559_81021_81061(targetAsts))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81093, 81296) || true) && (foreachAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 81093, 81296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81149, 81256);

                    f_1559_81149_81255(inferredTypes, f_1559_81194_81254(this, f_1559_81221_81253(this, f_1559_81232_81252(foreachAst))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81274, 81281);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 81093, 81296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81312, 81388);

                var
                commandCompletionAst = f_1559_81339_81387(f_1559_81339_81370(targetAsts))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81402, 81565) || true) && (commandCompletionAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 81402, 81565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81468, 81525);

                    f_1559_81468_81524(inferredTypes, f_1559_81491_81523(this, commandCompletionAst));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81543, 81550);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 81402, 81565);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81581, 81613);

                int
                smallestDiff = int.MaxValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81627, 81675);

                AssignmentStatementAst
                closestAssignment = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81689, 82031);
                    foreach (var assignAst in f_1559_81715_81725_I(assignAsts))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 81689, 82031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81759, 81802);

                        var
                        endOffset = f_1559_81775_81801(f_1559_81775_81791(assignAst))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81820, 82016) || true) && ((startOffset - endOffset) < smallestDiff)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 81820, 82016);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81906, 81945);

                            smallestDiff = startOffset - endOffset;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 81967, 81997);

                            closestAssignment = assignAst;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 81820, 82016);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 81689, 82031);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 343);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 82047, 82185) || true) && (closestAssignment != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 82047, 82185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 82110, 82170);

                    f_1559_82110_82169(inferredTypes, f_1559_82133_82168(this, f_1559_82144_82167(closestAssignment)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 82047, 82185);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 82201, 82390) || true) && (f_1559_82205_82309(_context, variableExpressionAst, out evalTypeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 82201, 82390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 82343, 82375);

                    f_1559_82343_82374(inferredTypes, evalTypeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 82201, 82390);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 71414, 82401);

                System.Management.Automation.VariablePath
                f_1559_71719_71753(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 71719, 71753);
                    return return_v;
                }


                bool
                f_1559_71772_71799_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 71772, 71799);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_72083_72111(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 72083, 72111);
                    return return_v;
                }


                bool
                f_1559_72130_72159(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsUnqualified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 72130, 72159);
                    return return_v;
                }


                string
                f_1559_72209_72233(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 72209, 72233);
                    return return_v;
                }


                bool
                f_1559_72181_72234(string
                name)
                {
                    var return_v = SpecialVariables.IsUnderbar(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 72181, 72234);
                    return return_v;
                }


                string
                f_1559_72256_72280(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 72256, 72280);
                    return return_v;
                }


                bool
                f_1559_72256_72329(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 72256, 72329);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_72694_72707(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 72694, 72707);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_72811_72824(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 72811, 72824);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_72852_72865(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 72852, 72865);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_72852_72872(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 72852, 72872);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73092_73105(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73092, 73105);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73092_73112(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73092, 73112);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73092_73119(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73092, 73119);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73202_73215(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73202, 73215);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73202_73222(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73202, 73222);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73202_73229(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73202, 73229);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73292_73305(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73292, 73305);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73292_73312(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73292, 73312);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73292_73319(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73292, 73319);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73342_73355(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73342, 73355);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73342_73362(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73342, 73362);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73342_73369(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73342, 73369);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73342_73376(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73342, 73376);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73459_73472(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73459, 73472);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73459_73479(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73459, 73479);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73459_73486(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73459, 73486);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73459_73493(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73459, 73493);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73572_73585(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73572, 73585);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_73667_73680(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73667, 73680);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                f_1559_73821_73842(System.Management.Automation.Language.CatchClauseAst
                this_param)
                {
                    var return_v = this_param.CatchTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73821, 73842);
                    return return_v;
                }


                int
                f_1559_73821_73848(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73821, 73848);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                f_1559_73950_73971(System.Management.Automation.Language.CatchClauseAst
                this_param)
                {
                    var return_v = this_param.CatchTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 73950, 73971);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1559_74058_74076(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 74058, 74076);
                    return return_v;
                }


                System.Type
                f_1559_74058_74096(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 74058, 74096);
                    return return_v;
                }


                bool
                f_1559_74160_74209(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 74160, 74209);
                    return return_v;
                }


                System.Type
                f_1559_74316_74368(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 74316, 74368);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_74301_74369(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 74301, 74369);
                    return return_v;
                }


                int
                f_1559_74283_74370(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 74283, 74370);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                f_1559_73950_73971_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 73950, 73971);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_74569_74604(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 74569, 74604);
                    return return_v;
                }


                int
                f_1559_74551_74605(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 74551, 74605);
                    return 0;
                }


                System.Management.Automation.Language.Ast
                f_1559_74719_74732(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 74719, 74732);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_74946_74963(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 74946, 74963);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1559_75017_75045(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 75017, 75045);
                    return return_v;
                }


                int
                f_1559_75017_75065(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param, System.Management.Automation.Language.CommandAst
                value)
                {
                    var return_v = this_param.IndexOf((System.Management.Automation.Language.CommandBaseAst)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 75017, 75065);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1559_75278_75306(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 75278, 75306);
                    return return_v;
                }


                System.Management.Automation.Language.CommandBaseAst
                f_1559_75278_75309(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 75278, 75309);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_75267_75310(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandBaseAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 75267, 75310);
                    return return_v;
                }


                System.Type
                f_1559_75372_75383(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 75372, 75383);
                    return return_v;
                }


                System.Type
                f_1559_75867_75878(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 75867, 75878);
                    return return_v;
                }


                bool
                f_1559_75867_75886(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 75867, 75886);
                    return return_v;
                }


                System.Type
                f_1559_75993_76004(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 75993, 76004);
                    return return_v;
                }


                System.Type?
                f_1559_75993_76021(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 75993, 76021);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_75978_76022(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 75978, 76022);
                    return return_v;
                }


                int
                f_1559_75960_76023(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 75960, 76023);
                    return 0;
                }


                System.Type
                f_1559_76183_76194(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 76183, 76194);
                    return return_v;
                }


                bool
                f_1559_76146_76195(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 76146, 76195);
                    return return_v;
                }


                System.Type
                f_1559_76403_76414(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 76403, 76414);
                    return return_v;
                }


                System.Type[]
                f_1559_76403_76430(System.Type
                this_param)
                {
                    var return_v = this_param.GetInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 76403, 76430);
                    return return_v;
                }


                bool
                f_1559_76593_76608(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 76593, 76608);
                    return return_v;
                }


                System.Type
                f_1559_76612_76640(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 76612, 76640);
                    return return_v;
                }


                System.Type[]
                f_1559_76788_76811(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 76788, 76811);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_76773_76815(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 76773, 76815);
                    return return_v;
                }


                int
                f_1559_76755_76816(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 76755, 76816);
                    return 0;
                }


                System.Type[]
                f_1559_76487_76507_I(System.Type[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 76487, 76507);
                    return return_v;
                }


                int
                f_1559_77046_77071(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 77046, 77071);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_75267_75310_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 75267, 75310);
                    return return_v;
                }


                bool
                f_1559_77314_77343(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsUnqualified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 77314, 77343);
                    return return_v;
                }


                string
                f_1559_77390_77414(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 77390, 77414);
                    return return_v;
                }


                bool
                f_1559_77390_77461(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 77390, 77461);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_77496_77529(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.CurrentTypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 77496, 77529);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_77541_77565(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.CurrentThisType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 77541, 77565);
                    return return_v;
                }


                int
                f_1559_77636_77678(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 77636, 77678);
                    return return_v;
                }


                string
                f_1559_77738_77762(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 77738, 77762);
                    return return_v;
                }


                bool
                f_1559_77738_77826(string
                s, string
                t)
                {
                    var return_v = s.EqualsOrdinalIgnoreCase(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 77738, 77826);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_78130_78150(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 78130, 78150);
                    return return_v;
                }


                int
                f_1559_78112_78151(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 78112, 78151);
                    return 0;
                }


                System.Management.Automation.PSTypeName
                f_1559_78333_78357(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.CurrentThisType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 78333, 78357);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_78376_78409(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.CurrentTypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 78376, 78409);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_78361_78410(System.Management.Automation.Language.TypeDefinitionAst
                typeDefinitionAst)
                {
                    var return_v = new System.Management.Automation.PSTypeName(typeDefinitionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 78361, 78410);
                    return return_v;
                }


                int
                f_1559_78433_78460(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 78433, 78460);
                    return 0;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1559_78608_78641(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.CurrentTypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 78608, 78641);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_78593_78642(System.Management.Automation.Language.TypeDefinitionAst
                typeDefinitionAst)
                {
                    var return_v = new System.Management.Automation.PSTypeName(typeDefinitionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 78593, 78642);
                    return return_v;
                }


                int
                f_1559_78575_78643(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 78575, 78643);
                    return 0;
                }


                System.Management.Automation.Language.Ast
                f_1559_78905_78919_M(System.Management.Automation.Language.Ast
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 78905, 78919);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_78970_78983(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 78970, 78983);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_79019_79033_M(System.Management.Automation.Language.Ast
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 79019, 79033);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1559_79101_79114(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 79101, 79114);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1559_79164_79192(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 79164, 79192);
                    return return_v;
                }


                int
                f_1559_79164_79204(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 79164, 79204);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                f_1559_79247_79994(System.Management.Automation.Language.Ast
                ast, System.Func<System.Management.Automation.Language.Ast, bool>
                predicate, bool
                searchNestedScriptBlocks)
                {
                    var return_v = AstSearcher.FindAll(ast, predicate, searchNestedScriptBlocks: searchNestedScriptBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 79247, 79994);
                    return return_v;
                }


                int
                f_1559_80172_80191(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 80172, 80191);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_80237_80261(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.ParameterAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 80237, 80261);
                    return return_v;
                }


                int
                f_1559_80214_80262(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 80214, 80262);
                    return 0;
                }


                int
                f_1559_80291_80310(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 80291, 80310);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1559_80031_80041_I(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 80031, 80041);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.AssignmentStatementAst>
                f_1559_80473_80516(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Language.AssignmentStatementAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 80473, 80516);
                    return return_v;
                }


                System.Management.Automation.Language.AssignmentStatementAst[]
                f_1559_80473_80526(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.AssignmentStatementAst>
                source)
                {
                    var return_v = source.ToArray<System.Management.Automation.Language.AssignmentStatementAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 80473, 80526);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_80774_80788(System.Management.Automation.Language.AssignmentStatementAst
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 80774, 80788);
                    return return_v;
                }


                System.Management.Automation.Language.TypeConstraintAst
                f_1559_80898_80913(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 80898, 80913);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1559_80898_80922(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 80898, 80922);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_80883_80923(System.Management.Automation.Language.ITypeName
                typeName)
                {
                    var return_v = new System.Management.Automation.PSTypeName(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 80883, 80923);
                    return return_v;
                }


                int
                f_1559_80865_80924(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 80865, 80924);
                    return 0;
                }


                System.Management.Automation.Language.AssignmentStatementAst[]
                f_1559_80726_80736_I(System.Management.Automation.Language.AssignmentStatementAst[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 80726, 80736);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ForEachStatementAst>
                f_1559_81021_81061(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Language.ForEachStatementAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 81021, 81061);
                    return return_v;
                }


                System.Management.Automation.Language.ForEachStatementAst
                f_1559_81021_81078(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ForEachStatementAst>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.Language.ForEachStatementAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 81021, 81078);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineBaseAst
                f_1559_81232_81252(System.Management.Automation.Language.ForEachStatementAst
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 81232, 81252);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_81221_81253(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.PipelineBaseAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 81221, 81253);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_81194_81254(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                enumerableTypes)
                {
                    var return_v = this_param.GetInferredEnumeratedTypes(enumerableTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 81194, 81254);
                    return return_v;
                }


                int
                f_1559_81149_81255(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 81149, 81255);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandAst>
                f_1559_81339_81370(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Language.CommandAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 81339, 81370);
                    return return_v;
                }


                System.Management.Automation.Language.CommandAst
                f_1559_81339_81387(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandAst>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.Language.CommandAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 81339, 81387);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_81491_81523(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.CommandAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 81491, 81523);
                    return return_v;
                }


                int
                f_1559_81468_81524(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 81468, 81524);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1559_81775_81791(System.Management.Automation.Language.AssignmentStatementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 81775, 81791);
                    return return_v;
                }


                int
                f_1559_81775_81801(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 81775, 81801);
                    return return_v;
                }


                System.Management.Automation.Language.AssignmentStatementAst[]
                f_1559_81715_81725_I(System.Management.Automation.Language.AssignmentStatementAst[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 81715, 81725);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1559_82144_82167(System.Management.Automation.Language.AssignmentStatementAst
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 82144, 82167);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_82133_82168(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.StatementAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 82133, 82168);
                    return return_v;
                }


                int
                f_1559_82110_82169(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 82110, 82169);
                    return 0;
                }


                bool
                f_1559_82205_82309(System.Management.Automation.TypeInferenceContext
                this_param, System.Management.Automation.Language.VariableExpressionAst
                expression, out System.Management.Automation.PSTypeName
                typeName)
                {
                    var return_v = this_param.TryGetRepresentativeTypeNameFromExpressionSafeEval((System.Management.Automation.Language.ExpressionAst)expression, out typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 82205, 82309);
                    return return_v;
                }


                int
                f_1559_82343_82374(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Management.Automation.PSTypeName
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 82343, 82374);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 71414, 82401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 71414, 82401);
            }
        }

        private PSTypeName GetArrayType(IEnumerable<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 82716, 84477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 82811, 82839);

                PSTypeName
                foundType = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 82853, 83919);
                    foreach (PSTypeName inferredType in f_1559_82889_82902_I(inferredTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 82853, 83919);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 82936, 83066) || true) && (f_1559_82940_82957(inferredType) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 82936, 83066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 83007, 83047);

                            return f_1559_83014_83046(typeof(object[]));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 82936, 83066);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 83340, 83513) || true) && (f_1559_83344_83399(typeof(IEnumerator), f_1559_83381_83398(inferredType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 83340, 83513);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 83441, 83466);

                            foundType = inferredType;
                            DynAbs.Tracing.TraceSender.TraceBreak(1559, 83488, 83494);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 83340, 83513);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 83533, 83671) || true) && (foundType == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 83533, 83671);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 83596, 83621);

                            foundType = inferredType;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 83643, 83652);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 83533, 83671);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 83764, 83904) || true) && (f_1559_83768_83782(foundType) != f_1559_83786_83803(inferredType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 83764, 83904);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 83845, 83885);

                            return f_1559_83852_83884(typeof(object[]));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 83764, 83904);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 82853, 83919);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 1067);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 1067);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 83935, 84045) || true) && (foundType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 83935, 84045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 83990, 84030);

                    return f_1559_83997_84029(typeof(object[]));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 83935, 84045);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 84061, 84153) || true) && (f_1559_84065_84087(f_1559_84065_84079(foundType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 84061, 84153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 84121, 84138);

                    return foundType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 84061, 84153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 84169, 84245);

                Type
                enumeratedItemType = f_1559_84195_84244(this, f_1559_84229_84243(foundType))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 84259, 84396) || true) && (enumeratedItemType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 84259, 84396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 84323, 84381);

                    return f_1559_84330_84380(f_1559_84345_84379(enumeratedItemType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 84259, 84396);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 84412, 84466);

                return f_1559_84419_84465(f_1559_84434_84464(f_1559_84434_84448(foundType)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 82716, 84477);

                System.Type
                f_1559_82940_82957(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 82940, 82957);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_83014_83046(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 83014, 83046);
                    return return_v;
                }


                System.Type
                f_1559_83381_83398(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 83381, 83398);
                    return return_v;
                }


                bool
                f_1559_83344_83399(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 83344, 83399);
                    return return_v;
                }


                System.Type
                f_1559_83768_83782(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 83768, 83782);
                    return return_v;
                }


                System.Type
                f_1559_83786_83803(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 83786, 83803);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_83852_83884(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 83852, 83884);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_82889_82902_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 82889, 82902);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_83997_84029(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 83997, 84029);
                    return return_v;
                }


                System.Type
                f_1559_84065_84079(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 84065, 84079);
                    return return_v;
                }


                bool
                f_1559_84065_84087(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 84065, 84087);
                    return return_v;
                }


                System.Type
                f_1559_84229_84243(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 84229, 84243);
                    return return_v;
                }


                System.Type
                f_1559_84195_84244(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Type
                enumerableType)
                {
                    var return_v = this_param.GetMostSpecificEnumeratedItemType(enumerableType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 84195, 84244);
                    return return_v;
                }


                System.Type
                f_1559_84345_84379(System.Type
                this_param)
                {
                    var return_v = this_param.MakeArrayType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 84345, 84379);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_84330_84380(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 84330, 84380);
                    return return_v;
                }


                System.Type
                f_1559_84434_84448(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 84434, 84448);
                    return return_v;
                }


                System.Type
                f_1559_84434_84464(System.Type
                this_param)
                {
                    var return_v = this_param.MakeArrayType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 84434, 84464);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_84419_84465(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 84419, 84465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 82716, 84477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 82716, 84477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Type GetMostSpecificEnumeratedItemType(Type enumerableType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 84793, 86704);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 84885, 84999) || true) && (f_1559_84889_84911(enumerableType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 84885, 84999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 84945, 84984);

                    return f_1559_84952_84983(enumerableType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 84885, 84999);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 85110, 85363) || true) && (enumerableType == typeof(string) || (DynAbs.Tracing.TraceSender.Expression_False(1559, 85114, 85219) || f_1559_85167_85219(typeof(IDictionary), enumerableType)) || (DynAbs.Tracing.TraceSender.Expression_False(1559, 85114, 85292) || f_1559_85240_85292(typeof(Xml.XmlNode), enumerableType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 85110, 85363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 85326, 85348);

                    return enumerableType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 85110, 85363);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 85379, 85500) || true) && (enumerableType == typeof(Data.DataTable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 85379, 85500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 85457, 85485);

                    return typeof(Data.DataRow);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 85379, 85500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 85516, 85547);

                bool
                hasSeenNonGeneric = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 85561, 85602);

                bool
                hasSeenDictionaryEnumerator = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 85616, 85801);

                Type
                collectionInterface = f_1559_85643_85800(this, enumerableType, ref hasSeenNonGeneric, ref hasSeenDictionaryEnumerator)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 85817, 85949) || true) && (collectionInterface != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 85817, 85949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 85882, 85934);

                    return f_1559_85889_85930(collectionInterface)[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 85817, 85949);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 85965, 86430);
                    foreach (Type interfaceType in f_1559_85996_86026_I(f_1559_85996_86026(enumerableType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 85965, 86430);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 86060, 86251);

                        collectionInterface = f_1559_86082_86250(this, interfaceType, ref hasSeenNonGeneric, ref hasSeenDictionaryEnumerator);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 86271, 86415) || true) && (collectionInterface != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 86271, 86415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 86344, 86396);

                            return f_1559_86351_86392(collectionInterface)[0];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 86271, 86415);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 85965, 86430);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 466);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 86446, 86557) || true) && (hasSeenDictionaryEnumerator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 86446, 86557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 86511, 86542);

                    return typeof(DictionaryEntry);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 86446, 86557);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 86573, 86665) || true) && (hasSeenNonGeneric)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 86573, 86665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 86628, 86650);

                    return typeof(object);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 86573, 86665);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 86681, 86693);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 84793, 86704);

                bool
                f_1559_84889_84911(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 84889, 84911);
                    return return_v;
                }


                System.Type?
                f_1559_84952_84983(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 84952, 84983);
                    return return_v;
                }


                bool
                f_1559_85167_85219(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 85167, 85219);
                    return return_v;
                }


                bool
                f_1559_85240_85292(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 85240, 85292);
                    return return_v;
                }


                System.Type
                f_1559_85643_85800(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Type
                interfaceType, ref bool
                hasSeenNonGeneric, ref bool
                hasSeenDictionaryEnumerator)
                {
                    var return_v = this_param.GetGenericCollectionLikeInterface(interfaceType, ref hasSeenNonGeneric, ref hasSeenDictionaryEnumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 85643, 85800);
                    return return_v;
                }


                System.Type[]
                f_1559_85889_85930(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 85889, 85930);
                    return return_v;
                }


                System.Type[]
                f_1559_85996_86026(System.Type
                this_param)
                {
                    var return_v = this_param.GetInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 85996, 86026);
                    return return_v;
                }


                System.Type
                f_1559_86082_86250(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Type
                interfaceType, ref bool
                hasSeenNonGeneric, ref bool
                hasSeenDictionaryEnumerator)
                {
                    var return_v = this_param.GetGenericCollectionLikeInterface(interfaceType, ref hasSeenNonGeneric, ref hasSeenDictionaryEnumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 86082, 86250);
                    return return_v;
                }


                System.Type[]
                f_1559_86351_86392(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 86351, 86392);
                    return return_v;
                }


                System.Type[]
                f_1559_85996_86026_I(System.Type[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 85996, 86026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 84793, 86704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 84793, 86704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Type GetGenericCollectionLikeInterface(
                    Type interfaceType,
                    ref bool hasSeenNonGeneric,
                    ref bool hasSeenDictionaryEnumerator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 87790, 88822);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 87987, 88078) || true) && (f_1559_87991_88017_M(!interfaceType.IsInterface))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 87987, 88078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88051, 88063);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 87987, 88078);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88094, 88446) || true) && (f_1559_88098_88136(interfaceType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 88094, 88446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88170, 88230);

                    Type
                    openGeneric = f_1559_88189_88229(interfaceType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88248, 88431) || true) && (openGeneric == typeof(IEnumerator<>) || (DynAbs.Tracing.TraceSender.Expression_False(1559, 88252, 88349) || openGeneric == typeof(IEnumerable<>)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 88248, 88431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88391, 88412);

                        return interfaceType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 88248, 88431);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 88094, 88446);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88462, 88596) || true) && (interfaceType == typeof(IDictionaryEnumerator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 88462, 88596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88546, 88581);

                    hasSeenDictionaryEnumerator = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 88462, 88596);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88612, 88783) || true) && (interfaceType == typeof(IEnumerator) || (DynAbs.Tracing.TraceSender.Expression_False(1559, 88616, 88709) || interfaceType == typeof(IEnumerable)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 88612, 88783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88743, 88768);

                    hasSeenNonGeneric = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 88612, 88783);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88799, 88811);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 87790, 88822);

                bool
                f_1559_87991_88017_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 87991, 88017);
                    return return_v;
                }


                bool
                f_1559_88098_88136(System.Type
                this_param)
                {
                    var return_v = this_param.IsConstructedGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 88098, 88136);
                    return return_v;
                }


                System.Type
                f_1559_88189_88229(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 88189, 88229);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 87790, 88822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 87790, 88822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<PSTypeName> InferTypeFrom(IndexExpressionAst indexExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 88834, 91588);

                var listYield = new List<PSTypeName>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 88943, 88999);

                var
                targetTypes = f_1559_88961_88998(this, f_1559_88972_88997(indexExpressionAst))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89013, 89035);

                bool
                foundAny = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89049, 91577);
                    foreach (var psType in f_1559_89072_89083_I(targetTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 89049, 91577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89117, 89140);

                        var
                        type = f_1559_89128_89139(psType)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89158, 91112) || true) && (type != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 89158, 91112);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89216, 89393) || true) && (f_1559_89220_89232(type))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 89216, 89393);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89282, 89333);

                                listYield.Add(f_1559_89295_89332(f_1559_89310_89331(type)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89361, 89370);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 89216, 89393);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89417, 90556);
                                foreach (var iface in f_1559_89439_89459_I(f_1559_89439_89459(type)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 89417, 90556);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89509, 89549);

                                    var
                                    isGenericType = f_1559_89529_89548(iface)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89575, 90533) || true) && (isGenericType && (DynAbs.Tracing.TraceSender.Expression_True(1559, 89579, 89654) && f_1559_89596_89628(iface) == typeof(IDictionary<,>)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 89575, 90533);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89712, 89759);

                                        var
                                        valueType = f_1559_89728_89755(iface)[1]
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89789, 90015) || true) && (f_1559_89793_89829_M(!valueType.ContainsGenericParameters))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 89789, 90015);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89895, 89911);

                                            foundAny = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 89945, 89984);

                                            listYield.Add(f_1559_89958_89983(valueType));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 89789, 90015);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 89575, 90533);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 89575, 90533);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90073, 90533) || true) && (isGenericType && (DynAbs.Tracing.TraceSender.Expression_True(1559, 90077, 90145) && f_1559_90094_90126(iface) == typeof(IList<>)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 90073, 90533);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90203, 90250);

                                            var
                                            valueType = f_1559_90219_90246(iface)[0]
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90280, 90506) || true) && (f_1559_90284_90320_M(!valueType.ContainsGenericParameters))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 90280, 90506);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90386, 90402);

                                                foundAny = true;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90436, 90475);

                                                listYield.Add(f_1559_90449_90474(valueType));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 90280, 90506);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 90073, 90533);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 89575, 90533);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 89417, 90556);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 1140);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 1140);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90580, 90672);

                            var
                            defaultMember = f_1559_90600_90671(f_1559_90600_90654(type, true))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90694, 91093) || true) && (defaultMember != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 90694, 91093);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90769, 90833);

                                var
                                indexers = f_1559_90784_90832(type, f_1559_90807_90831(defaultMember))
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90859, 91070);
                                    foreach (var indexer in f_1559_90883_90891_I(indexers))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 90859, 91070);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90949, 90965);

                                        foundAny = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 90995, 91043);

                                        listYield.Add(f_1559_91008_91042(f_1559_91023_91041(indexer)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 90859, 91070);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 212);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 212);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 90694, 91093);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 89158, 91112);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 91132, 91562) || true) && (!foundAny)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 91132, 91562);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 91523, 91543);

                            listYield.Add(psType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 91132, 91562);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 89049, 91577);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 2529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 2529);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 88834, 91588);

                return listYield;

                System.Management.Automation.Language.ExpressionAst
                f_1559_88972_88997(System.Management.Automation.Language.IndexExpressionAst
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 88972, 88997);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_88961_88998(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.ExpressionAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 88961, 88998);
                    return return_v;
                }


                System.Type
                f_1559_89128_89139(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 89128, 89139);
                    return return_v;
                }


                bool
                f_1559_89220_89232(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 89220, 89232);
                    return return_v;
                }


                System.Type?
                f_1559_89310_89331(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 89310, 89331);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_89295_89332(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 89295, 89332);
                    return return_v;
                }


                System.Type[]
                f_1559_89439_89459(System.Type
                this_param)
                {
                    var return_v = this_param.GetInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 89439, 89459);
                    return return_v;
                }


                bool
                f_1559_89529_89548(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 89529, 89548);
                    return return_v;
                }


                System.Type
                f_1559_89596_89628(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 89596, 89628);
                    return return_v;
                }


                System.Type[]
                f_1559_89728_89755(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 89728, 89755);
                    return return_v;
                }


                bool
                f_1559_89793_89829_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 89793, 89829);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_89958_89983(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 89958, 89983);
                    return return_v;
                }


                System.Type
                f_1559_90094_90126(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 90094, 90126);
                    return return_v;
                }


                System.Type[]
                f_1559_90219_90246(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 90219, 90246);
                    return return_v;
                }


                bool
                f_1559_90284_90320_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 90284, 90320);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_90449_90474(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 90449, 90474);
                    return return_v;
                }


                System.Type[]
                f_1559_89439_89459_I(System.Type[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 89439, 89459);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.DefaultMemberAttribute>
                f_1559_90600_90654(System.Type
                type, bool
                inherit)
                {
                    var return_v = type.GetCustomAttributes<System.Reflection.DefaultMemberAttribute>(inherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 90600, 90654);
                    return return_v;
                }


                System.Reflection.DefaultMemberAttribute
                f_1559_90600_90671(System.Collections.Generic.IEnumerable<System.Reflection.DefaultMemberAttribute>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Reflection.DefaultMemberAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 90600, 90671);
                    return return_v;
                }


                string
                f_1559_90807_90831(System.Reflection.DefaultMemberAttribute
                this_param)
                {
                    var return_v = this_param.MemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 90807, 90831);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>
                f_1559_90784_90832(System.Type
                type, string
                propertyName)
                {
                    var return_v = type.GetGetterProperty(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 90784, 90832);
                    return return_v;
                }


                System.Type
                f_1559_91023_91041(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 91023, 91041);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_91008_91042(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 91008, 91042);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>
                f_1559_90883_90891_I(System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 90883, 90891);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_89072_89083_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 89072, 89083);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 88834, 91588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 88834, 91588);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<PSTypeName> GetInferredEnumeratedTypes(IEnumerable<PSTypeName> enumerableTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 92032, 92715);

                var listYield = new List<PSTypeName>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 92156, 92704);
                    foreach (PSTypeName maybeEnumerableType in f_1559_92199_92214_I(enumerableTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 92156, 92704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 92248, 92285);

                        Type
                        type = f_1559_92260_92284(maybeEnumerableType)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 92303, 92444) || true) && (type == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 92303, 92444);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 92361, 92394);

                            listYield.Add(maybeEnumerableType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 92416, 92425);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 92303, 92444);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 92464, 92530);

                        Type
                        enumeratedItemType = f_1559_92490_92529(this, type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 92548, 92689);

                        listYield.Add((DynAbs.Tracing.TraceSender.Conditional_F1(1559, 92561, 92587) || ((enumeratedItemType == null
                        && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 92611, 92630)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 92654, 92688))) ? maybeEnumerableType
                        : f_1559_92654_92688(enumeratedItemType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 92156, 92704);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 549);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 92032, 92715);

                return listYield;

                System.Type
                f_1559_92260_92284(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 92260, 92284);
                    return return_v;
                }


                System.Type
                f_1559_92490_92529(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Type
                enumerableType)
                {
                    var return_v = this_param.GetMostSpecificEnumeratedItemType(enumerableType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 92490, 92529);
                    return return_v;
                }


                System.Management.Automation.PSTypeName
                f_1559_92654_92688(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.PSTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 92654, 92688);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_92199_92214_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 92199, 92214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 92032, 92715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 92032, 92715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetInferredTypeFromScriptBlockParameter(AstParameterArgumentPair argument, List<PSTypeName> inferredTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 92727, 93212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 92871, 92910);

                var
                argumentPair = argument as AstPair
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 92924, 93006);

                var
                scriptBlockExpressionAst = f_1559_92955_92977_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(argumentPair, 1559, 92955, 92977)?.Argument) as ScriptBlockExpressionAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 93020, 93112) || true) && (scriptBlockExpressionAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 93020, 93112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 93090, 93097);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 93020, 93112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 93128, 93201);

                f_1559_93128_93200(
                            inferredTypes, f_1559_93151_93199(this, f_1559_93162_93198(scriptBlockExpressionAst)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 92727, 93212);

                System.Management.Automation.Language.CommandElementAst
                f_1559_92955_92977_M(System.Management.Automation.Language.CommandElementAst
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 92955, 92977);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1559_93162_93198(System.Management.Automation.Language.ScriptBlockExpressionAst
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 93162, 93198);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_93151_93199(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.ScriptBlockAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 93151, 93199);
                    return return_v;
                }


                int
                f_1559_93128_93200(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 93128, 93200);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 92727, 93212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 92727, 93212);
            }
        }

        object ICustomAstVisitor2.VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 93224, 93391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 93331, 93380);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 93224, 93391);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 93224, 93391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 93224, 93391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor2.VisitPropertyMember(PropertyMemberAst propertyMemberAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 93403, 93570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 93510, 93559);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 93403, 93570);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 93403, 93570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 93403, 93570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor2.VisitFunctionMember(FunctionMemberAst functionMemberAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 93582, 93749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 93689, 93738);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 93582, 93749);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 93582, 93749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 93582, 93749);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor2.VisitBaseCtorInvokeMemberExpression(BaseCtorInvokeMemberExpressionAst baseCtorInvokeMemberExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 93761, 94023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 93916, 94012);

                return f_1559_93923_94011(((ICustomAstVisitor)this), baseCtorInvokeMemberExpressionAst);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 93761, 94023);

                object
                f_1559_93923_94011(System.Management.Automation.Language.ICustomAstVisitor
                this_param, System.Management.Automation.Language.BaseCtorInvokeMemberExpressionAst
                invokeMemberExpressionAst)
                {
                    var return_v = this_param.VisitInvokeMemberExpression((System.Management.Automation.Language.InvokeMemberExpressionAst)invokeMemberExpressionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 93923, 94011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 93761, 94023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 93761, 94023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor2.VisitUsingStatement(UsingStatementAst usingStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 94035, 94199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 94139, 94188);

                return TypeInferenceContext.EmptyPSTypeNameArray;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 94035, 94199);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 94035, 94199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 94035, 94199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor2.VisitConfigurationDefinition(ConfigurationDefinitionAst configurationDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 94211, 94408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 94345, 94397);

                return f_1559_94352_94396(f_1559_94352_94383(configurationDefinitionAst), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 94211, 94408);

                System.Management.Automation.Language.ScriptBlockExpressionAst
                f_1559_94352_94383(System.Management.Automation.Language.ConfigurationDefinitionAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 94352, 94383);
                    return return_v;
                }


                object
                f_1559_94352_94396(System.Management.Automation.Language.ScriptBlockExpressionAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 94352, 94396);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 94211, 94408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 94211, 94408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor2.VisitDynamicKeywordStatement(DynamicKeywordStatementAst dynamicKeywordAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 94420, 94678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 94610, 94667);

                return f_1559_94617_94666(f_1559_94617_94653(f_1559_94617_94650(dynamicKeywordAst), 0), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 94420, 94678);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1559_94617_94650(System.Management.Automation.Language.DynamicKeywordStatementAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 94617, 94650);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1559_94617_94653(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 94617, 94653);
                    return return_v;
                }


                object
                f_1559_94617_94666(System.Management.Automation.Language.CommandElementAst
                this_param, System.Management.Automation.TypeInferenceVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 94617, 94666);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 94420, 94678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 94420, 94678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor2.VisitTernaryExpression(TernaryExpressionAst ternaryExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 94690, 94913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 94806, 94902);

                return f_1559_94813_94901(f_1559_94813_94852(this, f_1559_94824_94851(ternaryExpressionAst)), f_1559_94860_94900(this, f_1559_94871_94899(ternaryExpressionAst)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 94690, 94913);

                System.Management.Automation.Language.ExpressionAst
                f_1559_94824_94851(System.Management.Automation.Language.TernaryExpressionAst
                this_param)
                {
                    var return_v = this_param.IfTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 94824, 94851);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_94813_94852(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.ExpressionAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 94813, 94852);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_94871_94899(System.Management.Automation.Language.TernaryExpressionAst
                this_param)
                {
                    var return_v = this_param.IfFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 94871, 94899);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_94860_94900(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.ExpressionAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 94860, 94900);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_94813_94901(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                first, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                second)
                {
                    var return_v = first.Concat<System.Management.Automation.PSTypeName>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 94813, 94901);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 94690, 94913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 94690, 94913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        object ICustomAstVisitor2.VisitPipelineChain(PipelineChainAst pipelineChainAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1559, 94925, 95263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 95029, 95064);

                var
                types = f_1559_95041_95063()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 95078, 95140);

                f_1559_95078_95139(types, f_1559_95093_95138(this, f_1559_95104_95137(pipelineChainAst)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 95154, 95211);

                f_1559_95154_95210(types, f_1559_95169_95209(this, f_1559_95180_95208(pipelineChainAst)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 95225, 95252);

                return f_1559_95232_95251(this, types);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1559, 94925, 95263);

                System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                f_1559_95041_95063()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95041, 95063);
                    return return_v;
                }


                System.Management.Automation.Language.ChainableAst
                f_1559_95104_95137(System.Management.Automation.Language.PipelineChainAst
                this_param)
                {
                    var return_v = this_param.LhsPipelineChain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 95104, 95137);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_95093_95138(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.ChainableAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95093, 95138);
                    return return_v;
                }


                int
                f_1559_95078_95139(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95078, 95139);
                    return 0;
                }


                System.Management.Automation.Language.PipelineAst
                f_1559_95180_95208(System.Management.Automation.Language.PipelineChainAst
                this_param)
                {
                    var return_v = this_param.RhsPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 95180, 95208);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                f_1559_95169_95209(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Management.Automation.Language.PipelineAst
                ast)
                {
                    var return_v = this_param.InferTypes((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95169, 95209);
                    return return_v;
                }


                int
                f_1559_95154_95210(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95154, 95210);
                    return 0;
                }


                System.Management.Automation.PSTypeName
                f_1559_95232_95251(System.Management.Automation.TypeInferenceVisitor
                this_param, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                inferredTypes)
                {
                    var return_v = this_param.GetArrayType((System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>)inferredTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95232, 95251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 94925, 95263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 94925, 95263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandBaseAst GetPreviousPipelineCommand(CommandAst commandAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 95275, 95562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 95379, 95421);

                var
                pipe = (PipelineAst)f_1559_95403_95420(commandAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 95435, 95485);

                var
                i = f_1559_95443_95484(f_1559_95443_95464(pipe), commandAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 95499, 95551);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1559, 95506, 95512) || ((i != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1559, 95515, 95543)) || DynAbs.Tracing.TraceSender.Conditional_F3(1559, 95546, 95550))) ? f_1559_95515_95543(f_1559_95515_95536(pipe), i - 1) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 95275, 95562);

                System.Management.Automation.Language.Ast
                f_1559_95403_95420(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 95403, 95420);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1559_95443_95464(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 95443, 95464);
                    return return_v;
                }


                int
                f_1559_95443_95484(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param, System.Management.Automation.Language.CommandAst
                value)
                {
                    var return_v = this_param.IndexOf((System.Management.Automation.Language.CommandBaseAst)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95443, 95484);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1559_95515_95536(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 95515, 95536);
                    return return_v;
                }


                System.Management.Automation.Language.CommandBaseAst
                f_1559_95515_95543(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 95515, 95543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 95275, 95562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 95275, 95562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeInferenceVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1559, 18570, 95569);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 18737, 18786);
            StringPSTypeName = f_1559_18756_18786(typeof(string));
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1559, 18570, 95569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 18570, 95569);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1559, 18570, 95569);

        static System.Management.Automation.PSTypeName
        f_1559_18756_18786(System.Type
        type)
        {
            var return_v = new System.Management.Automation.PSTypeName(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 18756, 18786);
            return return_v;
        }

    }
    static class TypeInferenceExtension
    {
        public static bool EqualsOrdinalIgnoreCase(this string s, string t)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 95629, 95795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 95721, 95784);

                return f_1559_95728_95783(s, t, StringComparison.OrdinalIgnoreCase);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 95629, 95795);

                bool
                f_1559_95728_95783(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95728, 95783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 95629, 95795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 95629, 95795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<MethodInfo> GetGetterProperty(this Type type, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 95807, 96419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 95924, 95957);

                var
                res = f_1559_95934_95956()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 95971, 96381);
                    foreach (var m in f_1559_95989_96049_I(f_1559_95989_96049(type, BindingFlags.Public | BindingFlags.Instance)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 95971, 96381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 96083, 96101);

                        var
                        name = f_1559_96094_96100(m)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 96119, 96366) || true) && (f_1559_96123_96134(name) == f_1559_96138_96157(propertyName) + 4
                        && (DynAbs.Tracing.TraceSender.Expression_True(1559, 96123, 96209) && f_1559_96186_96209(name, "get_")) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 96123, 96294) && f_1559_96234_96289(propertyName, name, 4, StringComparison.Ordinal) == 4))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 96119, 96366);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 96336, 96347);

                            f_1559_96336_96346(res, m);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 96119, 96366);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 95971, 96381);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 96397, 96408);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 95807, 96419);

                System.Collections.Generic.List<System.Reflection.MethodInfo>
                f_1559_95934_95956()
                {
                    var return_v = new System.Collections.Generic.List<System.Reflection.MethodInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95934, 95956);
                    return return_v;
                }


                System.Reflection.MethodInfo[]
                f_1559_95989_96049(System.Type
                this_param, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethods(bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95989, 96049);
                    return return_v;
                }


                string
                f_1559_96094_96100(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 96094, 96100);
                    return return_v;
                }


                int
                f_1559_96123_96134(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 96123, 96134);
                    return return_v;
                }


                int
                f_1559_96138_96157(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 96138, 96157);
                    return return_v;
                }


                bool
                f_1559_96186_96209(string
                this_param, string
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 96186, 96209);
                    return return_v;
                }


                int
                f_1559_96234_96289(string
                this_param, string
                value, int
                startIndex, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, startIndex, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 96234, 96289);
                    return return_v;
                }


                int
                f_1559_96336_96346(System.Collections.Generic.List<System.Reflection.MethodInfo>
                this_param, System.Reflection.MethodInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 96336, 96346);
                    return 0;
                }


                System.Reflection.MethodInfo[]
                f_1559_95989_96049_I(System.Reflection.MethodInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 95989, 96049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 95807, 96419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 95807, 96419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AstAssignsToSameVariable(this VariableExpressionAst variableAst, Ast ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1559, 96431, 99399);
                System.Management.Automation.Language.ParameterBindingResult parameterBindingResult = default(System.Management.Automation.Language.ParameterBindingResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 96548, 96587);

                var
                parameterAst = ast as ParameterAst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 96601, 96656);

                var
                variableAstVariablePath = f_1559_96631_96655(variableAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 96670, 96951) || true) && (parameterAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 96670, 96951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 96728, 96936);

                    return f_1559_96735_96777(variableAstVariablePath) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 96735, 96935) && f_1559_96805_96935(f_1559_96805_96851(f_1559_96805_96835(f_1559_96805_96822(parameterAst))), f_1559_96859_96898(variableAstVariablePath), StringComparison.OrdinalIgnoreCase));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 96670, 96951);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 96967, 97267) || true) && (ast is ForEachStatementAst foreachAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 96967, 97267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 97042, 97252);

                    return f_1559_97049_97091(variableAstVariablePath) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 97049, 97251) && f_1559_97119_97251(f_1559_97119_97167(f_1559_97119_97151(f_1559_97119_97138(foreachAst))), f_1559_97175_97214(variableAstVariablePath), StringComparison.OrdinalIgnoreCase));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 96967, 97267);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 97283, 98301) || true) && (ast is CommandAst commandAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 97283, 98301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 97349, 97429);

                    string[]
                    variableParameters = { "PV", "PipelineVariable", "OV", "OutVariable" }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 97447, 97556);

                    StaticBindingResult
                    bindingResult = f_1559_97483_97555(commandAst, false, variableParameters)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 97576, 98253) || true) && (bindingResult != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 97576, 98253);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 97643, 98234);
                            foreach (string commandVariableParameter in f_1559_97687_97705_I(variableParameters))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 97643, 98234);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 97755, 98211) || true) && (f_1559_97759_97877(f_1559_97759_97788(bindingResult), commandVariableParameter, out parameterBindingResult))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 97755, 98211);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 97935, 98184) || true) && (f_1559_97939_98075(f_1559_97953_97992(variableAstVariablePath), f_1559_98002_98038(parameterBindingResult), StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 97935, 98184);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98141, 98153);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 97935, 98184);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 97755, 98211);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 97643, 98234);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1559, 1, 592);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1559, 1, 592);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 97576, 98253);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98273, 98286);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 97283, 98301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98317, 98365);

                var
                assignmentAst = (AssignmentStatementAst)ast
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98379, 98408);

                var
                lhs = f_1559_98389_98407(assignmentAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98422, 98538) || true) && (lhs is ConvertExpressionAst convertExpr)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 98422, 98538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98499, 98523);

                    lhs = f_1559_98505_98522(convertExpr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 98422, 98538);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98554, 98659) || true) && (!(lhs is VariableExpressionAst varExpr))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 98554, 98659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98631, 98644);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 98554, 98659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98675, 98719);

                var
                candidateVarPath = f_1559_98698_98718(varExpr)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98733, 98900) || true) && (f_1559_98737_98839(f_1559_98737_98762(candidateVarPath), f_1559_98770_98802(variableAstVariablePath), StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 98733, 98900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 98873, 98885);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 98733, 98900);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 99142, 99359) || true) && (f_1559_99146_99178(variableAstVariablePath) && (DynAbs.Tracing.TraceSender.Expression_True(1559, 99146, 99298) && f_1559_99182_99298(f_1559_99182_99221(variableAstVariablePath), f_1559_99229_99261(candidateVarPath), StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1559, 99142, 99359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 99332, 99344);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1559, 99142, 99359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1559, 99375, 99388);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1559, 96431, 99399);

                System.Management.Automation.VariablePath
                f_1559_96631_96655(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 96631, 96655);
                    return return_v;
                }


                bool
                f_1559_96735_96777(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsUnscopedVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 96735, 96777);
                    return return_v;
                }


                System.Management.Automation.Language.VariableExpressionAst
                f_1559_96805_96822(System.Management.Automation.Language.ParameterAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 96805, 96822);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1559_96805_96835(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 96805, 96835);
                    return return_v;
                }


                string
                f_1559_96805_96851(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 96805, 96851);
                    return return_v;
                }


                string
                f_1559_96859_96898(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 96859, 96898);
                    return return_v;
                }


                bool
                f_1559_96805_96935(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 96805, 96935);
                    return return_v;
                }


                bool
                f_1559_97049_97091(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsUnscopedVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 97049, 97091);
                    return return_v;
                }


                System.Management.Automation.Language.VariableExpressionAst
                f_1559_97119_97138(System.Management.Automation.Language.ForEachStatementAst
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 97119, 97138);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1559_97119_97151(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 97119, 97151);
                    return return_v;
                }


                string
                f_1559_97119_97167(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 97119, 97167);
                    return return_v;
                }


                string
                f_1559_97175_97214(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 97175, 97214);
                    return return_v;
                }


                bool
                f_1559_97119_97251(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 97119, 97251);
                    return return_v;
                }


                System.Management.Automation.Language.StaticBindingResult
                f_1559_97483_97555(System.Management.Automation.Language.CommandAst
                commandAst, bool
                resolve, string[]
                desiredParameters)
                {
                    var return_v = StaticParameterBinder.BindCommand(commandAst, resolve, desiredParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 97483, 97555);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.ParameterBindingResult>
                f_1559_97759_97788(System.Management.Automation.Language.StaticBindingResult
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 97759, 97788);
                    return return_v;
                }


                bool
                f_1559_97759_97877(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.ParameterBindingResult>
                this_param, string
                key, out System.Management.Automation.Language.ParameterBindingResult
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 97759, 97877);
                    return return_v;
                }


                string
                f_1559_97953_97992(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 97953, 97992);
                    return return_v;
                }


                object
                f_1559_98002_98038(System.Management.Automation.Language.ParameterBindingResult
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 98002, 98038);
                    return return_v;
                }


                bool
                f_1559_97939_98075(string
                a, object
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, (string)b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 97939, 98075);
                    return return_v;
                }


                string[]
                f_1559_97687_97705_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 97687, 97705);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_98389_98407(System.Management.Automation.Language.AssignmentStatementAst
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 98389, 98407);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1559_98505_98522(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 98505, 98522);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1559_98698_98718(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 98698, 98718);
                    return return_v;
                }


                string
                f_1559_98737_98762(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 98737, 98762);
                    return return_v;
                }


                string
                f_1559_98770_98802(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 98770, 98802);
                    return return_v;
                }


                bool
                f_1559_98737_98839(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 98737, 98839);
                    return return_v;
                }


                bool
                f_1559_99146_99178(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 99146, 99178);
                    return return_v;
                }


                string
                f_1559_99182_99221(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 99182, 99221);
                    return return_v;
                }


                string
                f_1559_99229_99261(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1559, 99229, 99261);
                    return return_v;
                }


                bool
                f_1559_99182_99298(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1559, 99182, 99298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1559, 96431, 99399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 96431, 99399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeInferenceExtension()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1559, 95577, 99406);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1559, 95577, 99406);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1559, 95577, 99406);
        }

    }
}
