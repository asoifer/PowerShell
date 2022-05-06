// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation.Language;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace System.Management.Automation
{
    internal class CompletionContext
    {
        internal List<Ast> RelatedAsts { get; set; }

        internal Token TokenAtCursor { get; set; }

        internal Token TokenBeforeCursor { get; set; }

        internal IScriptPosition CursorPosition { get; set; }

        internal PowerShellExecutionHelper Helper { get; set; }

        internal Hashtable Options { get; set; }

        internal Dictionary<string, ScriptBlock> CustomArgumentCompleters { get; set; }

        internal Dictionary<string, ScriptBlock> NativeArgumentCompleters { get; set; }

        internal string WordToComplete { get; set; }

        internal int ReplacementIndex { get; set; }

        internal int ReplacementLength { get; set; }

        internal ExecutionContext ExecutionContext { get; set; }

        internal PseudoBindingInfo PseudoBindingInfo { get; set; }

        internal TypeInferenceContext TypeInferenceContext { get; set; }

        internal bool GetOption(string option, bool @default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 1556, 1836);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1634, 1750) || true) && (f_1442_1638_1645() == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 1638, 1685) || !f_1442_1658_1685(f_1442_1658_1665(), option)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 1634, 1750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1719, 1735);

                    return @default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 1634, 1750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1766, 1825);

                return f_1442_1773_1824(f_1442_1808_1823(f_1442_1808_1815(), option));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 1556, 1836);

                System.Collections.Hashtable
                f_1442_1638_1645()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 1638, 1645);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1442_1658_1665()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 1658, 1665);
                    return return_v;
                }


                bool
                f_1442_1658_1685(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 1658, 1685);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1442_1808_1815()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 1808, 1815);
                    return return_v;
                }


                object
                f_1442_1808_1823(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 1808, 1823);
                    return return_v;
                }


                bool
                f_1442_1773_1824(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<bool>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 1773, 1824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 1556, 1836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 1556, 1836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompletionContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1442, 362, 1843);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 411, 455);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 719, 761);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 771, 817);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 827, 880);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 892, 947);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 957, 997);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1007, 1086);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1096, 1175);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1185, 1229);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1239, 1282);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1292, 1336);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1346, 1402);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1412, 1470);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1480, 1544);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1442, 362, 1843);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 362, 1843);
        }


        static CompletionContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1442, 362, 1843);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1442, 362, 1843);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 362, 1843);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1442, 362, 1843);
    }
    internal class CompletionAnalysis
    {
        private readonly Ast _ast;

        private readonly Token[] _tokens;

        private readonly IScriptPosition _cursorPosition;

        private readonly Hashtable _options;

        internal CompletionAnalysis(Ast ast, Token[] tokens, IScriptPosition cursorPosition, Hashtable options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1442, 2087, 2348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1922, 1926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 1962, 1969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 2013, 2028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 2066, 2074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 2215, 2226);

                _ast = ast;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 2240, 2257);

                _tokens = tokens;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 2271, 2304);

                _cursorPosition = cursorPosition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 2318, 2337);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1442, 2087, 2348);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 2087, 2348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 2087, 2348);
            }
        }

        private static bool IsInterestingToken(Token token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 2360, 2524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 2436, 2513);

                return f_1442_2443_2453(token) != TokenKind.NewLine && (DynAbs.Tracing.TraceSender.Expression_True(1442, 2443, 2512) && f_1442_2478_2488(token) != TokenKind.EndOfInput);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 2360, 2524);

                System.Management.Automation.Language.TokenKind
                f_1442_2443_2453(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 2443, 2453);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_2478_2488(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 2478, 2488);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 2360, 2524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 2360, 2524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsCursorWithinOrJustAfterExtent(IScriptPosition cursor, IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 2536, 2748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 2658, 2737);

                return f_1442_2665_2678(cursor) > f_1442_2681_2699(extent) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 2665, 2736) && f_1442_2703_2716(cursor) <= f_1442_2720_2736(extent));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 2536, 2748);

                int
                f_1442_2665_2678(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 2665, 2678);
                    return return_v;
                }


                int
                f_1442_2681_2699(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 2681, 2699);
                    return return_v;
                }


                int
                f_1442_2703_2716(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 2703, 2716);
                    return return_v;
                }


                int
                f_1442_2720_2736(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 2720, 2736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 2536, 2748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 2536, 2748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsCursorRightAfterExtent(IScriptPosition cursor, IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 2760, 2927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 2875, 2916);

                return f_1442_2882_2895(cursor) == f_1442_2899_2915(extent);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 2760, 2927);

                int
                f_1442_2882_2895(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 2882, 2895);
                    return return_v;
                }


                int
                f_1442_2899_2915(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 2899, 2915);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 2760, 2927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 2760, 2927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsCursorAfterExtentAndInTheSameLine(IScriptPosition cursor, IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 2939, 3162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 3065, 3151);

                return f_1442_3072_3085(cursor) >= f_1442_3089_3105(extent) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 3072, 3150) && f_1442_3109_3129(extent) == f_1442_3133_3150(cursor));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 2939, 3162);

                int
                f_1442_3072_3085(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3072, 3085);
                    return return_v;
                }


                int
                f_1442_3089_3105(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3089, 3105);
                    return return_v;
                }


                int
                f_1442_3109_3129(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3109, 3129);
                    return return_v;
                }


                int
                f_1442_3133_3150(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.LineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3133, 3150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 2939, 3162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 2939, 3162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsCursorBeforeExtent(IScriptPosition cursor, IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 3174, 3338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 3285, 3327);

                return f_1442_3292_3305(cursor) < f_1442_3308_3326(extent);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 3174, 3338);

                int
                f_1442_3292_3305(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3292, 3305);
                    return return_v;
                }


                int
                f_1442_3308_3326(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3308, 3326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 3174, 3338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 3174, 3338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsCursorAfterExtent(IScriptPosition cursor, IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 3350, 3511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 3460, 3500);

                return f_1442_3467_3483(extent) < f_1442_3486_3499(cursor);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 3350, 3511);

                int
                f_1442_3467_3483(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3467, 3483);
                    return return_v;
                }


                int
                f_1442_3486_3499(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3486, 3499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 3350, 3511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 3350, 3511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsCursorOutsideOfExtent(IScriptPosition cursor, IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 3523, 3726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 3637, 3715);

                return f_1442_3644_3657(cursor) < f_1442_3660_3678(extent) || (DynAbs.Tracing.TraceSender.Expression_False(1442, 3644, 3714) || f_1442_3682_3695(cursor) > f_1442_3698_3714(extent));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 3523, 3726);

                int
                f_1442_3644_3657(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3644, 3657);
                    return return_v;
                }


                int
                f_1442_3660_3678(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3660, 3678);
                    return return_v;
                }


                int
                f_1442_3682_3695(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3682, 3695);
                    return return_v;
                }


                int
                f_1442_3698_3714(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 3698, 3714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 3523, 3726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 3523, 3726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompletionContext CreateCompletionContext(PowerShell powerShell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 3738, 3982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 3836, 3900);

                var
                typeInferenceContext = f_1442_3863_3899(powerShell)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 3914, 3971);

                return f_1442_3921_3970(this, typeInferenceContext);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 3738, 3982);

                System.Management.Automation.TypeInferenceContext
                f_1442_3863_3899(System.Management.Automation.PowerShell
                powerShell)
                {
                    var return_v = new System.Management.Automation.TypeInferenceContext(powerShell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 3863, 3899);
                    return return_v;
                }


                System.Management.Automation.CompletionContext
                f_1442_3921_3970(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.TypeInferenceContext
                typeInferenceContext)
                {
                    var return_v = this_param.InitializeCompletionContext(typeInferenceContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 3921, 3970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 3738, 3982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 3738, 3982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompletionContext CreateCompletionContext(TypeInferenceContext typeInferenceContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 3994, 4180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4112, 4169);

                return f_1442_4119_4168(this, typeInferenceContext);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 3994, 4180);

                System.Management.Automation.CompletionContext
                f_1442_4119_4168(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.TypeInferenceContext
                typeInferenceContext)
                {
                    var return_v = this_param.InitializeCompletionContext(typeInferenceContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 4119, 4168);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 3994, 4180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 3994, 4180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CompletionContext InitializeCompletionContext(TypeInferenceContext typeInferenceContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 4192, 6683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4313, 4344);

                Token
                tokenBeforeCursor = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4358, 4413);

                IScriptPosition
                positionForAstSearch = _cursorPosition
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4427, 4459);

                var
                adjustLineAndColumn = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4473, 4552);

                var
                tokenAtCursor = f_1442_4493_4551(_tokens, _cursorPosition)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4566, 5332) || true) && (tokenAtCursor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 4566, 5332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4625, 4708);

                    tokenBeforeCursor = f_1442_4645_4707(_tokens, _cursorPosition);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4726, 4931) || true) && (tokenBeforeCursor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 4726, 4931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4797, 4863);

                        positionForAstSearch = f_1442_4820_4862(f_1442_4820_4844(tokenBeforeCursor));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4885, 4912);

                        adjustLineAndColumn = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 4726, 4931);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 4566, 5332);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 4566, 5332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 4997, 5064);

                    var
                    stringExpandableToken = tokenAtCursor as StringExpandableToken
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 5082, 5317) || true) && (f_1442_5086_5121_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(stringExpandableToken, 1442, 5086, 5121)?.NestedTokens) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 5082, 5317);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 5171, 5298);

                        tokenAtCursor = f_1442_5187_5272(f_1442_5220_5254(stringExpandableToken), _cursorPosition) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.Token>(1442, 5187, 5297) ?? stringExpandableToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 5082, 5317);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 4566, 5332);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 5348, 5500);

                var
                asts = f_1442_5359_5499(f_1442_5359_5490(_ast, ast => IsCursorWithinOrJustAfterExtent(positionForAstSearch, ast.Extent), searchNestedScriptBlocks: true))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 5516, 5631);

                f_1442_5516_5630(tokenAtCursor == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 5535, 5585) || tokenBeforeCursor == null), "Only one of these tokens can be non-null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 5647, 5847) || true) && (f_1442_5651_5696(typeInferenceContext) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 5647, 5847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 5738, 5832);

                    typeInferenceContext.CurrentTypeDefinitionAst = f_1442_5786_5831(f_1442_5819_5830(asts));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 5647, 5847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 5863, 5937);

                ExecutionContext
                executionContext = f_1442_5899_5936(typeInferenceContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 5953, 6672);

                return new CompletionContext
                {
                    TokenAtCursor = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => tokenAtCursor, 1442, 5960, 6671),
                    TokenBeforeCursor = tokenBeforeCursor,
                    CursorPosition = _cursorPosition,
                    RelatedAsts = asts,
                    Options = _options,
                    ExecutionContext = executionContext,
                    ReplacementIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(1442, 6316, 6335) || ((adjustLineAndColumn && DynAbs.Tracing.TraceSender.Conditional_F2(1442, 6338, 6360)) || DynAbs.Tracing.TraceSender.Conditional_F3(1442, 6363, 6364))) ? f_1442_6338_6360(_cursorPosition) : 0,
                    TypeInferenceContext = typeInferenceContext,
                    Helper = f_1442_6454_6481(typeInferenceContext),
                    CustomArgumentCompleters = f_1442_6527_6568(executionContext),
                    NativeArgumentCompleters = f_1442_6614_6655(executionContext)
                };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 4192, 6683);

                System.Management.Automation.Language.Token
                f_1442_4493_4551(System.Management.Automation.Language.Token[]
                tokens, System.Management.Automation.Language.IScriptPosition
                cursorPosition)
                {
                    var return_v = InterstingTokenAtCursorOrDefault((System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Token>)tokens, cursorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 4493, 4551);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_4645_4707(System.Management.Automation.Language.Token[]
                tokens, System.Management.Automation.Language.IScriptPosition
                cursorPosition)
                {
                    var return_v = InterstingTokenBeforeCursorOrDefault((System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Token>)tokens, cursorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 4645, 4707);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_4820_4844(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 4820, 4844);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_4820_4862(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 4820, 4862);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Token>
                f_1442_5086_5121_M(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Token>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 5086, 5121);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Token>
                f_1442_5220_5254(System.Management.Automation.Language.StringExpandableToken
                this_param)
                {
                    var return_v = this_param.NestedTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 5220, 5254);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_5187_5272(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Token>
                tokens, System.Management.Automation.Language.IScriptPosition
                cursorPosition)
                {
                    var return_v = InterstingTokenAtCursorOrDefault((System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Token>)tokens, cursorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 5187, 5272);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                f_1442_5359_5490(System.Management.Automation.Language.Ast
                ast, System.Func<System.Management.Automation.Language.Ast, bool>
                predicate, bool
                searchNestedScriptBlocks)
                {
                    var return_v = AstSearcher.FindAll(ast, predicate, searchNestedScriptBlocks: searchNestedScriptBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 5359, 5490);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_5359_5499(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.Language.Ast>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 5359, 5499);
                    return return_v;
                }


                int
                f_1442_5516_5630(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 5516, 5630);
                    return 0;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1442_5651_5696(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.CurrentTypeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 5651, 5696);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_5819_5830(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.Last<System.Management.Automation.Language.Ast>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 5819, 5830);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefinitionAst
                f_1442_5786_5831(System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = Ast.GetAncestorTypeDefinitionAst(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 5786, 5831);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1442_5899_5936(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 5899, 5936);
                    return return_v;
                }


                int
                f_1442_6338_6360(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 6338, 6360);
                    return return_v;
                }


                System.Management.Automation.PowerShellExecutionHelper
                f_1442_6454_6481(System.Management.Automation.TypeInferenceContext
                this_param)
                {
                    var return_v = this_param.Helper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 6454, 6481);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                f_1442_6527_6568(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CustomArgumentCompleters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 6527, 6568);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ScriptBlock>
                f_1442_6614_6655(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.NativeArgumentCompleters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 6614, 6655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 4192, 6683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 4192, 6683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Token InterstingTokenAtCursorOrDefault(IEnumerable<Token> tokens, IScriptPosition cursorPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 6695, 6972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 6832, 6961);

                return f_1442_6839_6960(tokens, token => IsCursorWithinOrJustAfterExtent(cursorPosition, token.Extent) && IsInterestingToken(token));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 6695, 6972);

                System.Management.Automation.Language.Token
                f_1442_6839_6960(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Token>
                source, System.Func<System.Management.Automation.Language.Token, bool>
                predicate)
                {
                    var return_v = source.LastOrDefault<System.Management.Automation.Language.Token>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 6839, 6960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 6695, 6972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 6695, 6972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Token InterstingTokenBeforeCursorOrDefault(IEnumerable<Token> tokens, IScriptPosition cursorPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 6984, 7253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 7125, 7242);

                return f_1442_7132_7241(tokens, token => IsCursorAfterExtent(cursorPosition, token.Extent) && IsInterestingToken(token));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 6984, 7253);

                System.Management.Automation.Language.Token
                f_1442_7132_7241(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Token>
                source, System.Func<System.Management.Automation.Language.Token, bool>
                predicate)
                {
                    var return_v = source.LastOrDefault<System.Management.Automation.Language.Token>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 7132, 7241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 6984, 7253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 6984, 7253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Ast GetLastAstAtCursor(ScriptBlockAst scriptBlockAst, IScriptPosition cursorPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 7265, 7583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 7390, 7530);

                var
                asts = f_1442_7401_7529(scriptBlockAst, ast => IsCursorRightAfterExtent(cursorPosition, ast.Extent), searchNestedScriptBlocks: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 7544, 7572);

                return f_1442_7551_7571(asts);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 7265, 7583);

                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                f_1442_7401_7529(System.Management.Automation.Language.ScriptBlockAst
                ast, System.Func<System.Management.Automation.Language.Ast, bool>
                predicate, bool
                searchNestedScriptBlocks)
                {
                    var return_v = AstSearcher.FindAll((System.Management.Automation.Language.Ast)ast, predicate, searchNestedScriptBlocks: searchNestedScriptBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 7401, 7529);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_7551_7571(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.LastOrDefault<System.Management.Automation.Language.Ast>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 7551, 7571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 7265, 7583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 7265, 7583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CompleteAgainstSwitchFile(Ast lastAst, Token tokenBeforeCursor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 7746, 9267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 7854, 7891);

                Tuple<Token, Ast>
                fileConditionTuple
                = default(Tuple<Token, Ast>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 7907, 7957);

                var
                errorStatement = lastAst as ErrorStatementAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 7971, 8411) || true) && (errorStatement != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 7975, 8029) && f_1442_8001_8021(errorStatement) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 7975, 8060) && f_1442_8033_8052(errorStatement) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 7975, 8089) && tokenBeforeCursor != null) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 7975, 8159) && f_1442_8110_8159(f_1442_8110_8134(f_1442_8110_8129(errorStatement)), TokenKind.Switch)) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 7975, 8227) && f_1442_8163_8227(f_1442_8163_8183(errorStatement), "file", out fileConditionTuple)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 7971, 8411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 8309, 8396);

                    return f_1442_8316_8357(f_1442_8316_8347(f_1442_8316_8340(fileConditionTuple))) == f_1442_8361_8395(f_1442_8361_8385(tokenBeforeCursor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 7971, 8411);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 8427, 9227) || true) && (f_1442_8431_8445(lastAst) is CommandExpressionAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 8427, 9227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 8581, 8633);

                    var
                    pipeline = f_1442_8596_8617(f_1442_8596_8610(lastAst)) as PipelineAst
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 8651, 8745) || true) && (pipeline == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 8651, 8745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 8713, 8726);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 8651, 8745);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 8765, 8819);

                    errorStatement = f_1442_8782_8797(pipeline) as ErrorStatementAst;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 8837, 9000) || true) && (errorStatement == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 8841, 8894) || f_1442_8867_8886(errorStatement) == null) || (DynAbs.Tracing.TraceSender.Expression_False(1442, 8841, 8926) || f_1442_8898_8918(errorStatement) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 8837, 9000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 8968, 8981);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 8837, 9000);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 9020, 9212);

                    return (f_1442_9028_9077(f_1442_9028_9052(f_1442_9028_9047(errorStatement)), TokenKind.Switch) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 9028, 9170) && f_1442_9106_9170(f_1442_9106_9126(errorStatement), "file", out fileConditionTuple)) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 9028, 9210) && f_1442_9174_9198(fileConditionTuple) == pipeline));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 8427, 9227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 9243, 9256);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 7746, 9267);

                System.Collections.Generic.Dictionary<string, System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>>
                f_1442_8001_8021(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8001, 8021);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_8033_8052(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8033, 8052);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_8110_8129(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8110, 8129);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_8110_8134(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8110, 8134);
                    return return_v;
                }


                bool
                f_1442_8110_8159(System.Management.Automation.Language.TokenKind
                this_param, System.Management.Automation.Language.TokenKind
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 8110, 8159);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>>
                f_1442_8163_8183(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8163, 8183);
                    return return_v;
                }


                bool
                f_1442_8163_8227(System.Collections.Generic.Dictionary<string, System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>>
                this_param, string
                key, out System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 8163, 8227);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_8316_8340(System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8316, 8340);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_8316_8347(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8316, 8347);
                    return return_v;
                }


                int
                f_1442_8316_8357(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8316, 8357);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_8361_8385(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8361, 8385);
                    return return_v;
                }


                int
                f_1442_8361_8395(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8361, 8395);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_8431_8445(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8431, 8445);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_8596_8610(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8596, 8610);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_8596_8617(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8596, 8617);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_8782_8797(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8782, 8797);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_8867_8886(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8867, 8886);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>>
                f_1442_8898_8918(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 8898, 8918);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_9028_9047(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 9028, 9047);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_9028_9052(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 9028, 9052);
                    return return_v;
                }


                bool
                f_1442_9028_9077(System.Management.Automation.Language.TokenKind
                this_param, System.Management.Automation.Language.TokenKind
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 9028, 9077);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>>
                f_1442_9106_9126(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 9106, 9126);
                    return return_v;
                }


                bool
                f_1442_9106_9170(System.Collections.Generic.Dictionary<string, System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>>
                this_param, string
                key, out System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 9106, 9170);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_9174_9198(System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 9174, 9198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 7746, 9267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 7746, 9267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CompleteOperator(Token tokenAtCursor, Ast lastAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 9279, 9751);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 9374, 9711) || true) && (f_1442_9378_9396(tokenAtCursor) == TokenKind.Minus)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 9374, 9711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 9449, 9487);

                    return lastAst is BinaryExpressionAst;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 9374, 9711);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 9374, 9711);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 9521, 9711) || true) && (f_1442_9525_9543(tokenAtCursor) == TokenKind.Parameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 9521, 9711);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 9600, 9696) || true) && (lastAst is CommandParameterAst)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 9600, 9696);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 9657, 9696);

                            return f_1442_9664_9678(lastAst) is ExpressionAst;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 9600, 9696);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 9521, 9711);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 9374, 9711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 9727, 9740);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 9279, 9751);

                System.Management.Automation.Language.TokenKind
                f_1442_9378_9396(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 9378, 9396);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_9525_9543(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 9525, 9543);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_9664_9678(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 9664, 9678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 9279, 9751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 9279, 9751);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CompleteAgainstStatementFlags(Ast scriptAst, Ast lastAst, Token token, out TokenKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 9763, 12114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 9898, 9923);

                kind = TokenKind.Unknown;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 9979, 10029);

                var
                errorStatement = lastAst as ErrorStatementAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 10043, 10414) || true) && (errorStatement != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 10047, 10100) && f_1442_10073_10092(errorStatement) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 10043, 10414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 10134, 10399);

                    switch (f_1442_10142_10166(f_1442_10142_10161(errorStatement)))
                    {

                        case TokenKind.Switch:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 10134, 10399);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 10256, 10280);

                            kind = TokenKind.Switch;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 10306, 10318);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 10134, 10399);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 10134, 10399);
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 10374, 10380);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 10134, 10399);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 10043, 10414);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 10511, 10560);

                var
                scriptBlockAst = scriptAst as ScriptBlockAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 10574, 12074) || true) && (token != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 10578, 10624) && f_1442_10595_10605(token) == TokenKind.Minus) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 10578, 10650) && scriptBlockAst != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 10574, 12074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 10684, 10837);

                    var
                    asts = f_1442_10695_10836(scriptBlockAst, ast => IsCursorAfterExtent(token.Extent.StartScriptPosition, ast.Extent), searchNestedScriptBlocks: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 10857, 10889);

                    Ast
                    last = f_1442_10868_10888(asts)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 10907, 10929);

                    errorStatement = null;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 10949, 11175) || true) && (last != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 10949, 11175);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 11010, 11053);

                            errorStatement = last as ErrorStatementAst;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 11075, 11113) || true) && (errorStatement != null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 11075, 11113);
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 11105, 11111);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 11075, 11113);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 11137, 11156);

                            last = f_1442_11144_11155(last);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 10949, 11175);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 10949, 11175);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 10949, 11175);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 11195, 12059) || true) && (errorStatement != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 11199, 11252) && f_1442_11225_11244(errorStatement) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 11195, 12059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 11294, 12040);

                        switch (f_1442_11302_11326(f_1442_11302_11321(errorStatement)))
                        {

                            case TokenKind.Switch:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 11294, 12040);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 11430, 11454);

                                Tuple<Token, Ast>
                                value
                                = default(Tuple<Token, Ast>);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 11484, 11907) || true) && (f_1442_11488_11508(errorStatement) != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 11488, 11589) && f_1442_11520_11589(f_1442_11520_11540(errorStatement), Parser.VERBATIM_ARGUMENT, out value)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 11484, 11907);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 11655, 11876) || true) && (f_1442_11659_11693(f_1442_11674_11685(value), token))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 11655, 11876);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 11767, 11791);

                                        kind = TokenKind.Switch;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 11829, 11841);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 11655, 11876);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 11484, 11907);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 11939, 11945);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 11294, 12040);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 11294, 12040);
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 12011, 12017);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 11294, 12040);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 11195, 12059);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 10574, 12074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 12090, 12103);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 9763, 12114);

                System.Management.Automation.Language.Token
                f_1442_10073_10092(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 10073, 10092);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_10142_10161(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 10142, 10161);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_10142_10166(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 10142, 10166);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_10595_10605(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 10595, 10605);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                f_1442_10695_10836(System.Management.Automation.Language.ScriptBlockAst
                ast, System.Func<System.Management.Automation.Language.Ast, bool>
                predicate, bool
                searchNestedScriptBlocks)
                {
                    var return_v = AstSearcher.FindAll((System.Management.Automation.Language.Ast)ast, predicate, searchNestedScriptBlocks: searchNestedScriptBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 10695, 10836);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_10868_10888(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.LastOrDefault<System.Management.Automation.Language.Ast>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 10868, 10888);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_11144_11155(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 11144, 11155);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_11225_11244(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 11225, 11244);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_11302_11321(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 11302, 11321);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_11302_11326(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 11302, 11326);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>>
                f_1442_11488_11508(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 11488, 11508);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>>
                f_1442_11520_11540(System.Management.Automation.Language.ErrorStatementAst
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 11520, 11540);
                    return return_v;
                }


                bool
                f_1442_11520_11589(System.Collections.Generic.Dictionary<string, System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>>
                this_param, string
                key, out System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 11520, 11589);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_11674_11685(System.Tuple<System.Management.Automation.Language.Token, System.Management.Automation.Language.Ast>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 11674, 11685);
                    return return_v;
                }


                bool
                f_1442_11659_11693(System.Management.Automation.Language.Token
                x, System.Management.Automation.Language.Token
                y)
                {
                    var return_v = IsTokenTheSame(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 11659, 11693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 9763, 12114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 9763, 12114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsTokenTheSame(Token x, Token y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 12126, 12648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 12203, 12608) || true) && (f_1442_12207_12213(x) == f_1442_12217_12223(y) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 12207, 12255) && f_1442_12227_12239(x) == f_1442_12243_12255(y)) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 12207, 12328) && f_1442_12276_12300(f_1442_12276_12284(x)) == f_1442_12304_12328(f_1442_12304_12312(y))) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 12207, 12405) && f_1442_12349_12375(f_1442_12349_12357(x)) == f_1442_12379_12405(f_1442_12379_12387(y))) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 12207, 12474) && f_1442_12426_12448(f_1442_12426_12434(x)) == f_1442_12452_12474(f_1442_12452_12460(y))) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 12207, 12547) && f_1442_12495_12519(f_1442_12495_12503(x)) == f_1442_12523_12547(f_1442_12523_12531(y))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 12203, 12608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 12581, 12593);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 12203, 12608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 12624, 12637);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 12126, 12648);

                System.Management.Automation.Language.TokenKind
                f_1442_12207_12213(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12207, 12213);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_12217_12223(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12217, 12223);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1442_12227_12239(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.TokenFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12227, 12239);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1442_12243_12255(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.TokenFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12243, 12255);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_12276_12284(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12276, 12284);
                    return return_v;
                }


                int
                f_1442_12276_12300(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12276, 12300);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_12304_12312(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12304, 12312);
                    return return_v;
                }


                int
                f_1442_12304_12328(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12304, 12328);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_12349_12357(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12349, 12357);
                    return return_v;
                }


                int
                f_1442_12349_12375(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12349, 12375);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_12379_12387(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12379, 12387);
                    return return_v;
                }


                int
                f_1442_12379_12405(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12379, 12405);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_12426_12434(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12426, 12434);
                    return return_v;
                }


                int
                f_1442_12426_12448(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12426, 12448);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_12452_12460(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12452, 12460);
                    return return_v;
                }


                int
                f_1442_12452_12474(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12452, 12474);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_12495_12503(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12495, 12503);
                    return return_v;
                }


                int
                f_1442_12495_12519(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12495, 12519);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_12523_12531(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12523, 12531);
                    return return_v;
                }


                int
                f_1442_12523_12547(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 12523, 12547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 12126, 12648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 12126, 12648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<CompletionResult> GetResults(PowerShell powerShell, out int replacementIndex, out int replacementLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 12696, 13829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 12839, 12899);

                var
                completionContext = f_1442_12863_12898(this, powerShell)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 12915, 12959);

                PSLanguageMode?
                previousLanguageMode = null
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 13129, 13449) || true) && (f_1442_13133_13210(f_1442_13133_13167(completionContext)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 13129, 13449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 13252, 13323);

                        previousLanguageMode = f_1442_13275_13322(f_1442_13275_13309(completionContext));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 13345, 13430);

                        f_1442_13345_13379(completionContext).LanguageMode = PSLanguageMode.ConstrainedLanguage;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 13129, 13449);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 13469, 13563);

                    return f_1442_13476_13562(this, completionContext, out replacementIndex, out replacementLength, false);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1442, 13592, 13818);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 13632, 13803) || true) && (f_1442_13636_13665(previousLanguageMode))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 13632, 13803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 13707, 13784);

                        f_1442_13707_13741(completionContext).LanguageMode = f_1442_13757_13783(previousLanguageMode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 13632, 13803);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1442, 13592, 13818);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 12696, 13829);

                System.Management.Automation.CompletionContext
                f_1442_12863_12898(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.PowerShell
                powerShell)
                {
                    var return_v = this_param.CreateCompletionContext(powerShell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 12863, 12898);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1442_13133_13167(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 13133, 13167);
                    return return_v;
                }


                bool
                f_1442_13133_13210(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.HasRunspaceEverUsedConstrainedLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 13133, 13210);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1442_13275_13309(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 13275, 13309);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1442_13275_13322(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 13275, 13322);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1442_13345_13379(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 13345, 13379);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_13476_13562(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, out int
                replacementIndex, out int
                replacementLength, bool
                isQuotedString)
                {
                    var return_v = this_param.GetResultHelper(completionContext, out replacementIndex, out replacementLength, isQuotedString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 13476, 13562);
                    return return_v;
                }


                bool
                f_1442_13636_13665(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 13636, 13665);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1442_13707_13741(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 13707, 13741);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1442_13757_13783(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 13757, 13783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 12696, 13829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 12696, 13829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<CompletionResult> GetResultHelper(CompletionContext completionContext, out int replacementIndex, out int replacementLength, bool isQuotedString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 13841, 43854);
                System.Collections.Generic.List<System.Management.Automation.CompletionResult> completions = default(System.Collections.Generic.List<System.Management.Automation.CompletionResult>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14024, 14046);

                replacementIndex = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14060, 14083);

                replacementLength = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14099, 14151);

                var
                tokenAtCursor = f_1442_14119_14150(completionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14165, 14216);

                var
                lastAst = f_1442_14179_14215(f_1442_14179_14208(completionContext))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14230, 14267);

                List<CompletionResult>
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14281, 41459) || true) && (tokenAtCursor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14281, 41459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14340, 14407);

                    replacementIndex = f_1442_14359_14406(f_1442_14359_14399(f_1442_14359_14379(tokenAtCursor)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14425, 14510);

                    replacementLength = f_1442_14445_14490(f_1442_14445_14483(f_1442_14445_14465(tokenAtCursor))) - replacementIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14530, 14584);

                    completionContext.ReplacementIndex = replacementIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14602, 14658);

                    completionContext.ReplacementLength = replacementLength;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14678, 30901);

                    switch (f_1442_14686_14704(tokenAtCursor))
                    {

                        case TokenKind.Variable:
                        case TokenKind.SplattedVariable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14850, 14938);

                            completionContext.WordToComplete = f_1442_14885_14937(f_1442_14885_14928(((VariableToken)tokenAtCursor)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 14964, 15030);

                            result = f_1442_14973_15029(completionContext);
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 15056, 15062);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.Multiply:
                        case TokenKind.Generic:
                        case TokenKind.MinusMinus: // for native commands '--'
                        case TokenKind.Identifier:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 15305, 15417);

                            result = f_1442_15314_15416(this, completionContext, ref replacementIndex, ref replacementLength, isQuotedString);
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 15443, 15449);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.Parameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 15636, 15691) || true) && (isQuotedString)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 15636, 15691);
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 15685, 15691);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 15636, 15691);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 15719, 15773);

                            completionContext.WordToComplete = f_1442_15754_15772(tokenAtCursor);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 15799, 15841);

                            var
                            cmdAst = f_1442_15812_15826(lastAst) as CommandAst
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 15867, 16139) || true) && (lastAst is StringConstantExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 15871, 15927) && cmdAst != null) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 15871, 15964) && f_1442_15931_15959(f_1442_15931_15953(cmdAst)) == 1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 15867, 16139);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 16022, 16076);

                                result = f_1442_16031_16075(completionContext);
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 16106, 16112);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 15867, 16139);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 16167, 16191);

                            TokenKind
                            statementKind
                            = default(TokenKind);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 16217, 16513) || true) && (f_1442_16221_16290(null, lastAst, null, out statementKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 16217, 16513);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 16348, 16450);

                                result = f_1442_16357_16449(statementKind, f_1442_16416_16448(completionContext));
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 16480, 16486);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 16217, 16513);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 16541, 16787) || true) && (f_1442_16545_16585(tokenAtCursor, lastAst))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 16541, 16787);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 16643, 16724);

                                result = f_1442_16652_16723(f_1442_16690_16722(completionContext));
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 16754, 16760);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 16541, 16787);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 16887, 17510) || true) && (f_1442_16891_16937(f_1442_16891_16923(completionContext), ':'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 16887, 17510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 16995, 17060);

                                replacementIndex = f_1442_17014_17059(f_1442_17014_17052(f_1442_17014_17034(tokenAtCursor)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 17090, 17112);

                                replacementLength = 0;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 17144, 17192);

                                completionContext.WordToComplete = string.Empty;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 17222, 17295);

                                result = f_1442_17231_17294(completionContext);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 16887, 17510);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 16887, 17510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 17409, 17483);

                                result = f_1442_17418_17482(completionContext);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 16887, 17510);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 17538, 17544);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.Dot:
                        case TokenKind.ColonColon:
                        case TokenKind.QuestionDot:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 17710, 17756);

                            replacementIndex += f_1442_17730_17755(f_1442_17730_17748(tokenAtCursor));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 17782, 17804);

                            replacementLength = 0;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 17830, 17947);

                            result = f_1442_17839_17946(completionContext, @static: f_1442_17903_17921(tokenAtCursor) == TokenKind.ColonColon);
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 17973, 17979);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.Comment:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 18164, 18219) || true) && (isQuotedString)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 18164, 18219);
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 18213, 18219);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 18164, 18219);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 18247, 18301);

                            completionContext.WordToComplete = f_1442_18282_18300(tokenAtCursor);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 18327, 18392);

                            result = f_1442_18336_18391(completionContext);
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 18418, 18424);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.StringExpandable:
                        case TokenKind.StringLiteral:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 18633, 19174) || true) && (f_1442_18637_18651(lastAst) is CommandExpressionAst
                            && (DynAbs.Tracing.TraceSender.Expression_True(1442, 18637, 18769) && f_1442_18708_18729(f_1442_18708_18722(lastAst)) is AssignmentStatementAst assignmentAst))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 18633, 19174);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 18915, 19147) || true) && (f_1442_18919_19031(completionContext, assignmentAst, out completions))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 18915, 19147);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 19097, 19116);

                                    return completions;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 18915, 19147);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 18633, 19174);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 19202, 19310);

                            result = f_1442_19211_19309(this, completionContext, ref replacementIndex, ref replacementLength, isQuotedString);
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 19336, 19342);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.RBracket:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 19416, 20484) || true) && (lastAst is TypeExpressionAst)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 19416, 20484);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 19506, 19550);

                                var
                                targetExpr = (TypeExpressionAst)lastAst
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 19580, 19628);

                                var
                                memberResult = f_1442_19599_19627()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 19660, 19891);

                                f_1442_19660_19890(true, "*", targetExpr, completionContext, memberResult);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 19923, 20457) || true) && (f_1442_19927_19945(memberResult) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 19923, 20457);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 20015, 20034);

                                    replacementIndex++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 20068, 20090);

                                    replacementLength = 0;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 20124, 20426);

                                    result = f_1442_20133_20425((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from entry in memberResult
                                                                                                                         let completionText = TokenKind.ColonColon.Text() + entry.CompletionText
                                                                                                                         select new CompletionResult(completionText, entry.ListItemText, entry.ResultType, entry.ToolTip), 1442, 20134, 20415)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 19923, 20457);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 19416, 20484);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 20512, 20518);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.Comma:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 20687, 21892) || true) && (lastAst is ErrorExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 20691, 20824) && (f_1442_20754_20768(lastAst) is CommandAst || (DynAbs.Tracing.TraceSender.Expression_False(1442, 20754, 20823) || f_1442_20786_20800(lastAst) is CommandParameterAst))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 20687, 21892);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 20882, 20920);

                                replacementIndex += replacementLength;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 20950, 20972);

                                replacementLength = 0;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 21004, 21077);

                                result = f_1442_21013_21076(completionContext);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 20687, 21892);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 20687, 21892);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 21681, 21693);

                                bool
                                unused
                                = default(bool);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 21723, 21865);

                                result = f_1442_21732_21864(this, completionContext, string.Empty, ref replacementIndex, ref replacementLength, out unused);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 20687, 21892);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 21920, 21926);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.AtCurly:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 22101, 22151);

                            result = f_1442_22110_22150(this, completionContext);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 22177, 22199);

                            replacementIndex += 2;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 22225, 22247);

                            replacementLength = 0;
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 22273, 22279);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.Semi:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 22441, 22707) || true) && (lastAst is HashtableAst)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 22441, 22707);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 22526, 22576);

                                result = f_1442_22535_22575(this, completionContext);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 22606, 22628);

                                replacementIndex += 1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 22658, 22680);

                                replacementLength = 0;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 22441, 22707);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 22735, 22741);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.Number:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 22954, 24285) || true) && (lastAst is ConstantExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 22958, 23281) && (f_1442_23024_23038(lastAst) is CommandAst || (DynAbs.Tracing.TraceSender.Expression_False(1442, 23024, 23093) || f_1442_23056_23070(lastAst) is CommandParameterAst) || (DynAbs.Tracing.TraceSender.Expression_False(1442, 23024, 23280) || (f_1442_23127_23141(lastAst) is ArrayLiteralAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 23127, 23279) && (f_1442_23195_23216(f_1442_23195_23209(lastAst)) is CommandAst || (DynAbs.Tracing.TraceSender.Expression_False(1442, 23195, 23278) || f_1442_23234_23255(f_1442_23234_23248(lastAst)) is CommandParameterAst))))))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 22954, 24285);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 23339, 23393);

                                completionContext.WordToComplete = f_1442_23374_23392(tokenAtCursor);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 23423, 23496);

                                result = f_1442_23432_23495(completionContext);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 23528, 23582);

                                replacementIndex = f_1442_23547_23581(completionContext);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 23612, 23668);

                                replacementLength = f_1442_23632_23667(completionContext);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 22954, 24285);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 22954, 24285);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 23726, 24285) || true) && (f_1442_23730_23744(lastAst) is CommandExpressionAst
                                && (DynAbs.Tracing.TraceSender.Expression_True(1442, 23730, 23863) && f_1442_23801_23822(f_1442_23801_23815(lastAst)) is AssignmentStatementAst assignmentAst2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 23726, 24285);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 24023, 24258) || true) && (f_1442_24027_24140(completionContext, assignmentAst2, out completions))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 24023, 24258);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 24206, 24227);

                                        result = completions;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 24023, 24258);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 23726, 24285);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 22954, 24285);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 24313, 24319);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.Redirection:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 24549, 25084) || true) && (lastAst is ErrorExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 24553, 24622) && f_1442_24586_24600(lastAst) is FileRedirectionAst))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 24549, 25084);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 24680, 24728);

                                completionContext.WordToComplete = string.Empty;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 24758, 24843);

                                completionContext.ReplacementIndex = (replacementIndex += f_1442_24816_24841(f_1442_24816_24834(tokenAtCursor)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 24873, 24933);

                                completionContext.ReplacementLength = replacementLength = 0;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 24963, 25057);

                                result = f_1442_24972_25056(f_1442_24999_25055(completionContext));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 24549, 25084);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 25112, 25118);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.Minus:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 25300, 25526) || true) && (f_1442_25304_25344(tokenAtCursor, lastAst))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 25300, 25526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 25402, 25463);

                                result = f_1442_25411_25462(string.Empty);
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 25493, 25499);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 25300, 25526);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 25654, 26068) || true) && (f_1442_25658_25761(f_1442_25688_25720(f_1442_25688_25717(completionContext), 0), null, tokenAtCursor, out statementKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 25654, 26068);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 25819, 25873);

                                completionContext.WordToComplete = f_1442_25854_25872(tokenAtCursor);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 25903, 26005);

                                result = f_1442_25912_26004(statementKind, f_1442_25971_26003(completionContext));
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 26035, 26041);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 25654, 26068);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 26096, 26102);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.DynamicKeyword:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 26213, 26251);

                                DynamicKeywordStatementAst
                                keywordAst
                                = default(DynamicKeywordStatementAst);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 26281, 26457);

                                ConfigurationDefinitionAst
                                configureAst = f_1442_26323_26456(this, f_1442_26398_26430(completionContext), lastAst, out keywordAst)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 26487, 26579);

                                f_1442_26487_26578(configureAst != null, "ConfigurationDefinitionAst should never be null");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 26609, 26630);

                                bool
                                matched = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 26660, 26721);

                                completionContext.WordToComplete = f_1442_26695_26720(f_1442_26695_26713(tokenAtCursor));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 26864, 26961);

                                return f_1442_26871_26960(this, completionContext, configureAst, null, out matched);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        case TokenKind.Equals:
                        case TokenKind.AtParen:
                        case TokenKind.LParen:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 27178, 29792) || true) && (lastAst is AttributeAst)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 27178, 29792);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 27271, 27354);

                                    completionContext.ReplacementIndex = replacementIndex += f_1442_27328_27353(f_1442_27328_27346(tokenAtCursor));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 27388, 27448);

                                    completionContext.ReplacementLength = replacementLength = 0;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 27482, 27585);

                                    result = f_1442_27491_27584(this, completionContext, ref replacementIndex, ref replacementLength);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 27178, 29792);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 27178, 29792);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 27651, 29792) || true) && (lastAst is HashtableAst hashTableAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 27655, 27742) && !(f_1442_27697_27711(lastAst) is DynamicKeywordStatementAst)) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 27655, 27785) && f_1442_27746_27785(this, hashTableAst)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 27651, 29792);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 27988, 28000);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 27651, 29792);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 27651, 29792);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 28066, 29792) || true) && (lastAst is AssignmentStatementAst assignmentAst2)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 28066, 29792);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 28184, 28267);

                                            completionContext.ReplacementIndex = replacementIndex += f_1442_28241_28266(f_1442_28241_28259(tokenAtCursor));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 28301, 28361);

                                            completionContext.ReplacementLength = replacementLength = 0;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 28487, 28732) || true) && (f_1442_28491_28604(completionContext, assignmentAst2, out completions))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 28487, 28732);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 28678, 28697);

                                                return completions;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 28487, 28732);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 28066, 29792);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 28066, 29792);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 29573, 29585);

                                            bool
                                            unused
                                            = default(bool);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 29619, 29761);

                                            result = f_1442_29628_29760(this, completionContext, string.Empty, ref replacementIndex, ref replacementLength, out unused);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 28066, 29792);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 27651, 29792);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 27178, 29792);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 29824, 29830);

                                break;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14678, 30901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 29913, 30848) || true) && ((f_1442_29918_29942(tokenAtCursor) & TokenFlags.Keyword) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 29913, 30848);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 30027, 30081);

                                completionContext.WordToComplete = f_1442_30062_30080(tokenAtCursor);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 30177, 30231);

                                result = f_1442_30186_30230(completionContext);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 30330, 30410);

                                var
                                commandNameResult = f_1442_30354_30409(completionContext)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 30440, 30632) || true) && (commandNameResult != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 30444, 30500) && f_1442_30473_30496(commandNameResult) > 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 30440, 30632);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 30566, 30601);

                                    f_1442_30566_30600(result, commandNameResult);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 30440, 30632);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 29913, 30848);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 29913, 30848);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 30746, 30768);

                                replacementIndex = -1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 30798, 30821);

                                replacementLength = -1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 29913, 30848);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 30876, 30882);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14678, 30901);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14281, 41459);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 14281, 41459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 30967, 31025);

                    IScriptPosition
                    cursor = f_1442_30992_31024(completionContext)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 31043, 31107);

                    bool
                    isCursorLineEmpty = f_1442_31068_31106(f_1442_31094_31105(cursor))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 31125, 31185);

                    var
                    tokenBeforeCursor = f_1442_31149_31184(completionContext)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 31203, 31247);

                    bool
                    isLineContinuationBeforeCursor = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 31265, 32074) || true) && (tokenBeforeCursor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 31265, 32074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 31951, 32055);

                        isLineContinuationBeforeCursor = f_1442_31984_32024(f_1442_31984_32019(completionContext)) == TokenKind.LineContinuation;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 31265, 32074);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 32094, 32185);

                    bool
                    skipAutoCompleteForCommandCall = isCursorLineEmpty && (DynAbs.Tracing.TraceSender.Expression_True(1442, 32132, 32184) && !isLineContinuationBeforeCursor)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 32203, 32258);

                    bool
                    lastAstIsExpressionAst = lastAst is ExpressionAst
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 32276, 41444) || true) && (!isQuotedString && (DynAbs.Tracing.TraceSender.Expression_True(1442, 32280, 32351) && !skipAutoCompleteForCommandCall) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 32280, 32800) && (lastAst is CommandParameterAst || (DynAbs.Tracing.TraceSender.Expression_False(1442, 32377, 32432) || lastAst is CommandAst) || (DynAbs.Tracing.TraceSender.Expression_False(1442, 32377, 32513) || (lastAstIsExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 32458, 32512) && f_1442_32484_32498(lastAst) is CommandAst))) || (DynAbs.Tracing.TraceSender.Expression_False(1442, 32377, 32603) || (lastAstIsExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 32539, 32602) && f_1442_32565_32579(lastAst) is CommandParameterAst))) || (DynAbs.Tracing.TraceSender.Expression_False(1442, 32377, 32799) || (lastAstIsExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 32629, 32688) && f_1442_32655_32669(lastAst) is ArrayLiteralAst) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 32629, 32798) && (f_1442_32714_32735(f_1442_32714_32728(lastAst)) is CommandAst || (DynAbs.Tracing.TraceSender.Expression_False(1442, 32714, 32797) || f_1442_32753_32774(f_1442_32753_32767(lastAst)) is CommandParameterAst))))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 32276, 41444);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 32842, 32890);

                        completionContext.WordToComplete = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 32914, 32957);

                        var
                        hashTableAst = lastAst as HashtableAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 33766, 33945) || true) && (hashTableAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 33770, 33858) && f_1442_33819_33858(this, hashTableAst)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 33766, 33945);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 33908, 33922);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 33766, 33945);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 33969, 34691) || true) && (hashTableAst != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 33969, 34691);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 34043, 34139);

                            completionContext.ReplacementIndex = replacementIndex = f_1442_34099_34138(f_1442_34099_34131(completionContext));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 34165, 34225);

                            completionContext.ReplacementLength = replacementLength = 0;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 34251, 34335);

                            result = f_1442_34260_34334(completionContext, hashTableAst);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 33969, 34691);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 33969, 34691);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 34433, 34506);

                            result = f_1442_34442_34505(completionContext);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 34532, 34586);

                            replacementIndex = f_1442_34551_34585(completionContext);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 34612, 34668);

                            replacementLength = f_1442_34632_34667(completionContext);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 33969, 34691);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 32276, 41444);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 32276, 41444);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 34733, 41444) || true) && (!isQuotedString)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 34733, 41444);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 35030, 35060);

                            bool
                            cursorAtLineContinuation
                            = default(bool);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 35082, 35417) || true) && ((tokenAtCursor != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 35087, 35160) && f_1442_35112_35130(tokenAtCursor) == TokenKind.LineContinuation)) || (DynAbs.Tracing.TraceSender.Expression_False(1442, 35086, 35273) || (tokenBeforeCursor != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 35191, 35272) && f_1442_35220_35242(tokenBeforeCursor) == TokenKind.LineContinuation))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 35082, 35417);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 35300, 35332);

                                cursorAtLineContinuation = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 35082, 35417);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 35082, 35417);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 35384, 35417);

                                cursorAtLineContinuation = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 35082, 35417);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 35439, 39839) || true) && (isCursorLineEmpty && (DynAbs.Tracing.TraceSender.Expression_True(1442, 35443, 35489) && !cursorAtLineContinuation))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 35439, 39839);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 36038, 36088);

                                result = f_1442_36047_36087(this, completionContext);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 36114, 36716) || true) && (result == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 36118, 36153) || f_1442_36136_36148(result) == 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 36114, 36716);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 36211, 36249);

                                    DynamicKeywordStatementAst
                                    keywordAst
                                    = default(DynamicKeywordStatementAst);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 36279, 36392);

                                    ConfigurationDefinitionAst
                                    configAst = f_1442_36318_36391(this, cursor, lastAst, out keywordAst)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 36422, 36689) || true) && (configAst != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 36422, 36689);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 36509, 36522);

                                        bool
                                        matched
                                        = default(bool);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 36556, 36658);

                                        result = f_1442_36565_36657(this, completionContext, configAst, keywordAst, out matched);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 36422, 36689);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 36114, 36716);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 35439, 39839);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 35439, 39839);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 36766, 39839) || true) && (f_1442_36770_36801(completionContext) == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 36766, 39839);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 36859, 39816) || true) && (tokenBeforeCursor != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 36859, 39816);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 37612, 39789);

                                        switch (f_1442_37620_37642(tokenBeforeCursor))
                                        {

                                            case TokenKind.Equals:
                                            case TokenKind.Comma:
                                            case TokenKind.AtParen:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 37612, 39789);
                                                {

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 37923, 38449) || true) && (lastAst is AssignmentStatementAst assignmentAst)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 37923, 38449);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 38167, 38406) || true) && (f_1442_38171_38255(completionContext, assignmentAst, out result))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 38167, 38406);
                                                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 38353, 38359);

                                                            break;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 38167, 38406);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 37923, 38449);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 38493, 38505);

                                                    bool
                                                    unused
                                                    = default(bool);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 38547, 38689);

                                                    result = f_1442_38556_38688(this, completionContext, string.Empty, ref replacementIndex, ref replacementLength, out unused);
                                                    DynAbs.Tracing.TraceSender.TraceBreak(1442, 38731, 38737);

                                                    break;
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 37612, 39789);

                                            case TokenKind.LParen:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 37612, 39789);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 38870, 39626) || true) && (lastAst is AttributeAst)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 38870, 39626);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 38979, 39039);

                                                    completionContext.ReplacementLength = replacementLength = 0;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 39081, 39184);

                                                    result = f_1442_39090_39183(this, completionContext, ref replacementIndex, ref replacementLength);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 38870, 39626);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 38870, 39626);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 39346, 39358);

                                                    bool
                                                    unused
                                                    = default(bool);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 39400, 39587);

                                                    result = f_1442_39409_39586(this, completionContext, string.Empty, ref replacementIndex, ref replacementLength, out unused);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 38870, 39626);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 39666, 39672);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 37612, 39789);

                                            default:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 37612, 39789);
                                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 39752, 39758);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 37612, 39789);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 36859, 39816);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 36766, 39839);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 35439, 39839);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 39863, 41425) || true) && (result != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 39867, 39901) && f_1442_39885_39897(result) > 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 39863, 41425);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 39951, 40047);

                                completionContext.ReplacementIndex = replacementIndex = f_1442_40007_40046(f_1442_40007_40039(completionContext));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 40073, 40133);

                                completionContext.ReplacementLength = replacementLength = 0;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 39863, 41425);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 39863, 41425);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 40231, 40263);

                                bool
                                needFileCompletion = false
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 40289, 40923) || true) && (lastAst is ErrorExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 40293, 40362) && f_1442_40326_40340(lastAst) is FileRedirectionAst))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 40289, 40923);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 40520, 40546);

                                    needFileCompletion = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 40289, 40923);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 40289, 40923);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 40604, 40923) || true) && (lastAst is ErrorStatementAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 40608, 40711) && f_1442_40640_40711(lastAst, f_1442_40675_40710(completionContext))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 40604, 40923);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 40870, 40896);

                                        needFileCompletion = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 40604, 40923);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 40289, 40923);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 40951, 41402) || true) && (needFileCompletion)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 40951, 41402);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 41031, 41079);

                                    completionContext.WordToComplete = string.Empty;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 41109, 41203);

                                    result = f_1442_41118_41202(f_1442_41145_41201(completionContext));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 41235, 41289);

                                    replacementIndex = f_1442_41254_41288(completionContext);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 41319, 41375);

                                    replacementLength = f_1442_41339_41374(completionContext);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 40951, 41402);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 39863, 41425);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 34733, 41444);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 32276, 41444);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 14281, 41459);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 41475, 42846) || true) && (result == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 41479, 41514) || f_1442_41497_41509(result) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 41475, 42846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 41548, 41637);

                    var
                    typeAst = f_1442_41562_41636(f_1442_41562_41619(f_1442_41562_41591(completionContext)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 41655, 41690);

                    TypeName
                    typeNameToComplete = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 41708, 42261) || true) && (typeAst != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 41708, 42261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 41769, 41848);

                        typeNameToComplete = f_1442_41790_41847(f_1442_41813_41829(typeAst), _cursorPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 41708, 42261);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 41708, 42261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 41930, 42029);

                        var
                        typeConstraintAst = f_1442_41954_42028(f_1442_41954_42011(f_1442_41954_41983(completionContext)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 42051, 42242) || true) && (typeConstraintAst != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 42051, 42242);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 42130, 42219);

                            typeNameToComplete = f_1442_42151_42218(f_1442_42174_42200(typeConstraintAst), _cursorPosition);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 42051, 42242);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 41708, 42261);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 42281, 42831) || true) && (typeNameToComplete != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 42281, 42831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 42489, 42546);

                        replacementIndex = f_1442_42508_42545(f_1442_42508_42533(typeNameToComplete));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 42568, 42643);

                        replacementLength = f_1442_42588_42623(f_1442_42588_42613(typeNameToComplete)) - replacementIndex;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 42665, 42728);

                        completionContext.WordToComplete = f_1442_42700_42727(typeNameToComplete);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 42750, 42812);

                        result = f_1442_42759_42811(completionContext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 42281, 42831);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 41475, 42846);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 42862, 43000) || true) && (result == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 42866, 42901) || f_1442_42884_42896(result) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 42862, 43000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 42935, 42985);

                    result = f_1442_42944_42984(this, completionContext);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 42862, 43000);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 43016, 43813) || true) && (result == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 43020, 43055) || f_1442_43038_43050(result) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 43016, 43813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 43173, 43233);

                    string
                    input = f_1442_43188_43232(f_1442_43188_43227(f_1442_43188_43220(f_1442_43188_43217(completionContext), 0)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 43251, 43798) || true) && (f_1442_43255_43287(input, @"^[\S]+$") && (DynAbs.Tracing.TraceSender.Expression_True(1442, 43255, 43330) && f_1442_43291_43326(f_1442_43291_43320(completionContext)) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 43255, 43384) && f_1442_43334_43366(f_1442_43334_43363(completionContext), 0) is ScriptBlockAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 43251, 43798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 43426, 43512);

                        replacementIndex = f_1442_43445_43511(f_1442_43445_43504(f_1442_43445_43484(f_1442_43445_43477(f_1442_43445_43474(completionContext), 0))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 43534, 43638);

                        replacementLength = f_1442_43554_43618(f_1442_43554_43611(f_1442_43554_43593(f_1442_43554_43586(f_1442_43554_43583(completionContext), 0)))) - replacementIndex;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 43662, 43703);

                        completionContext.WordToComplete = input;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 43725, 43779);

                        result = f_1442_43734_43778(completionContext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 43251, 43798);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 43016, 43813);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 43829, 43843);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 13841, 43854);

                System.Management.Automation.Language.Token
                f_1442_14119_14150(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14119, 14150);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_14179_14208(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14179, 14208);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_14179_14215(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.Last<System.Management.Automation.Language.Ast>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 14179, 14215);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_14359_14379(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14359, 14379);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_14359_14399(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14359, 14399);
                    return return_v;
                }


                int
                f_1442_14359_14406(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14359, 14406);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_14445_14465(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14445, 14465);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_14445_14483(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14445, 14483);
                    return return_v;
                }


                int
                f_1442_14445_14490(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14445, 14490);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_14686_14704(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14686, 14704);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1442_14885_14928(System.Management.Automation.Language.VariableToken
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14885, 14928);
                    return return_v;
                }


                string
                f_1442_14885_14937(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 14885, 14937);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_14973_15029(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteVariable(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 14973, 15029);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_15314_15416(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, ref int
                replacementIndex, ref int
                replacementLength, bool
                isQuotedString)
                {
                    var return_v = this_param.GetResultForIdentifier(completionContext, ref replacementIndex, ref replacementLength, isQuotedString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 15314, 15416);
                    return return_v;
                }


                string
                f_1442_15754_15772(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 15754, 15772);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_15812_15826(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 15812, 15826);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1442_15931_15953(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 15931, 15953);
                    return return_v;
                }


                int
                f_1442_15931_15959(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 15931, 15959);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_16031_16075(System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = CompleteFileNameAsCommand(completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 16031, 16075);
                    return return_v;
                }


                bool
                f_1442_16221_16290(System.Management.Automation.Language.Ast
                scriptAst, System.Management.Automation.Language.Ast
                lastAst, System.Management.Automation.Language.Token
                token, out System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = CompleteAgainstStatementFlags(scriptAst, lastAst, token, out kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 16221, 16290);
                    return return_v;
                }


                string
                f_1442_16416_16448(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.WordToComplete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 16416, 16448);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_16357_16449(System.Management.Automation.Language.TokenKind
                kind, string
                wordToComplete)
                {
                    var return_v = CompletionCompleters.CompleteStatementFlags(kind, wordToComplete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 16357, 16449);
                    return return_v;
                }


                bool
                f_1442_16545_16585(System.Management.Automation.Language.Token
                tokenAtCursor, System.Management.Automation.Language.Ast
                lastAst)
                {
                    var return_v = CompleteOperator(tokenAtCursor, lastAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 16545, 16585);
                    return return_v;
                }


                string
                f_1442_16690_16722(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.WordToComplete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 16690, 16722);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_16652_16723(string
                wordToComplete)
                {
                    var return_v = CompletionCompleters.CompleteOperator(wordToComplete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 16652, 16723);
                    return return_v;
                }


                string
                f_1442_16891_16923(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.WordToComplete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 16891, 16923);
                    return return_v;
                }


                bool
                f_1442_16891_16937(string
                this_param, char
                value)
                {
                    var return_v = this_param.EndsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 16891, 16937);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_17014_17034(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 17014, 17034);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_17014_17052(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 17014, 17052);
                    return return_v;
                }


                int
                f_1442_17014_17059(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 17014, 17059);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_17231_17294(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommandArgument(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 17231, 17294);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_17418_17482(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommandParameter(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 17418, 17482);
                    return return_v;
                }


                string
                f_1442_17730_17748(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 17730, 17748);
                    return return_v;
                }


                int
                f_1442_17730_17755(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 17730, 17755);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_17903_17921(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 17903, 17921);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_17839_17946(System.Management.Automation.CompletionContext
                context, bool
                @static)
                {
                    var return_v = CompletionCompleters.CompleteMember(context, @static: @static);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 17839, 17946);
                    return return_v;
                }


                string
                f_1442_18282_18300(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 18282, 18300);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_18336_18391(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteComment(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 18336, 18391);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_18637_18651(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 18637, 18651);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_18708_18722(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 18708, 18722);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_18708_18729(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 18708, 18729);
                    return return_v;
                }


                bool
                f_1442_18919_19031(System.Management.Automation.CompletionContext
                completionContext, System.Management.Automation.Language.AssignmentStatementAst
                assignmentAst, out System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                completions)
                {
                    var return_v = TryGetCompletionsForVariableAssignment(completionContext, assignmentAst, out completions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 18919, 19031);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_19211_19309(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, ref int
                replacementIndex, ref int
                replacementLength, bool
                isQuotedString)
                {
                    var return_v = this_param.GetResultForString(completionContext, ref replacementIndex, ref replacementLength, isQuotedString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 19211, 19309);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_19599_19627()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 19599, 19627);
                    return return_v;
                }


                int
                f_1442_19660_19890(bool
                @static, string
                memberName, System.Management.Automation.Language.TypeExpressionAst
                targetExpr, System.Management.Automation.CompletionContext
                context, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                results)
                {
                    CompletionCompleters.CompleteMemberHelper(@static, memberName, (System.Management.Automation.Language.ExpressionAst)targetExpr, context, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 19660, 19890);
                    return 0;
                }


                int
                f_1442_19927_19945(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 19927, 19945);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_20133_20425(System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 20133, 20425);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_20754_20768(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 20754, 20768);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_20786_20800(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 20786, 20800);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_21013_21076(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommandArgument(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 21013, 21076);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_21732_21864(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, string
                stringToComplete, ref int
                replacementIndex, ref int
                replacementLength, out bool
                shouldContinue)
                {
                    var return_v = this_param.GetResultForEnumPropertyValueOfDSCResource(completionContext, stringToComplete, ref replacementIndex, ref replacementLength, out shouldContinue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 21732, 21864);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_22110_22150(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = this_param.GetResultForHashtable(completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 22110, 22150);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_22535_22575(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = this_param.GetResultForHashtable(completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 22535, 22575);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_23024_23038(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23024, 23038);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_23056_23070(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23056, 23070);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_23127_23141(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23127, 23141);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_23195_23209(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23195, 23209);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_23195_23216(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23195, 23216);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_23234_23248(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23234, 23248);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_23234_23255(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23234, 23255);
                    return return_v;
                }


                string
                f_1442_23374_23392(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23374, 23392);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_23432_23495(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommandArgument(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 23432, 23495);
                    return return_v;
                }


                int
                f_1442_23547_23581(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ReplacementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23547, 23581);
                    return return_v;
                }


                int
                f_1442_23632_23667(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ReplacementLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23632, 23667);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_23730_23744(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23730, 23744);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_23801_23815(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23801, 23815);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_23801_23822(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 23801, 23822);
                    return return_v;
                }


                bool
                f_1442_24027_24140(System.Management.Automation.CompletionContext
                completionContext, System.Management.Automation.Language.AssignmentStatementAst
                assignmentAst, out System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                completions)
                {
                    var return_v = TryGetCompletionsForVariableAssignment(completionContext, assignmentAst, out completions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 24027, 24140);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_24586_24600(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 24586, 24600);
                    return return_v;
                }


                string
                f_1442_24816_24834(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 24816, 24834);
                    return return_v;
                }


                int
                f_1442_24816_24841(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 24816, 24841);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                f_1442_24999_25055(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteFilename(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 24999, 25055);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_24972_25056(System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 24972, 25056);
                    return return_v;
                }


                bool
                f_1442_25304_25344(System.Management.Automation.Language.Token
                tokenAtCursor, System.Management.Automation.Language.Ast
                lastAst)
                {
                    var return_v = CompleteOperator(tokenAtCursor, lastAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 25304, 25344);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_25411_25462(string
                wordToComplete)
                {
                    var return_v = CompletionCompleters.CompleteOperator(wordToComplete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 25411, 25462);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_25688_25717(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 25688, 25717);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_25688_25720(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 25688, 25720);
                    return return_v;
                }


                bool
                f_1442_25658_25761(System.Management.Automation.Language.Ast
                scriptAst, System.Management.Automation.Language.Ast
                lastAst, System.Management.Automation.Language.Token
                token, out System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = CompleteAgainstStatementFlags(scriptAst, lastAst, token, out kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 25658, 25761);
                    return return_v;
                }


                string
                f_1442_25854_25872(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 25854, 25872);
                    return return_v;
                }


                string
                f_1442_25971_26003(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.WordToComplete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 25971, 26003);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_25912_26004(System.Management.Automation.Language.TokenKind
                kind, string
                wordToComplete)
                {
                    var return_v = CompletionCompleters.CompleteStatementFlags(kind, wordToComplete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 25912, 26004);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_26398_26430(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 26398, 26430);
                    return return_v;
                }


                System.Management.Automation.Language.ConfigurationDefinitionAst
                f_1442_26323_26456(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.Language.IScriptPosition
                cursorPosition, System.Management.Automation.Language.Ast
                ast, out System.Management.Automation.Language.DynamicKeywordStatementAst
                keywordAst)
                {
                    var return_v = this_param.GetAncestorConfigurationAstAndKeywordAst(cursorPosition, ast, out keywordAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 26323, 26456);
                    return return_v;
                }


                int
                f_1442_26487_26578(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 26487, 26578);
                    return 0;
                }


                string
                f_1442_26695_26713(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 26695, 26713);
                    return return_v;
                }


                string
                f_1442_26695_26720(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 26695, 26720);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_26871_26960(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, System.Management.Automation.Language.ConfigurationDefinitionAst
                configureAst, System.Management.Automation.Language.DynamicKeywordStatementAst
                keywordAst, out bool
                matched)
                {
                    var return_v = this_param.GetResultForIdentifierInConfiguration(completionContext, configureAst, keywordAst, out matched);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 26871, 26960);
                    return return_v;
                }


                string
                f_1442_27328_27346(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 27328, 27346);
                    return return_v;
                }


                int
                f_1442_27328_27353(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 27328, 27353);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_27491_27584(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, ref int
                replacementIndex, ref int
                replacementLength)
                {
                    var return_v = this_param.GetResultForAttributeArgument(completionContext, ref replacementIndex, ref replacementLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 27491, 27584);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_27697_27711(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 27697, 27711);
                    return return_v;
                }


                bool
                f_1442_27746_27785(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.Language.HashtableAst
                hashTableAst)
                {
                    var return_v = this_param.CheckForPendingAssignment(hashTableAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 27746, 27785);
                    return return_v;
                }


                string
                f_1442_28241_28259(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 28241, 28259);
                    return return_v;
                }


                int
                f_1442_28241_28266(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 28241, 28266);
                    return return_v;
                }


                bool
                f_1442_28491_28604(System.Management.Automation.CompletionContext
                completionContext, System.Management.Automation.Language.AssignmentStatementAst
                assignmentAst, out System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                completions)
                {
                    var return_v = TryGetCompletionsForVariableAssignment(completionContext, assignmentAst, out completions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 28491, 28604);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_29628_29760(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, string
                stringToComplete, ref int
                replacementIndex, ref int
                replacementLength, out bool
                shouldContinue)
                {
                    var return_v = this_param.GetResultForEnumPropertyValueOfDSCResource(completionContext, stringToComplete, ref replacementIndex, ref replacementLength, out shouldContinue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 29628, 29760);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1442_29918_29942(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.TokenFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 29918, 29942);
                    return return_v;
                }


                string
                f_1442_30062_30080(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 30062, 30080);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_30186_30230(System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = CompleteFileNameAsCommand(completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 30186, 30230);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_30354_30409(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommand(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 30354, 30409);
                    return return_v;
                }


                int
                f_1442_30473_30496(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 30473, 30496);
                    return return_v;
                }


                int
                f_1442_30566_30600(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 30566, 30600);
                    return 0;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_30992_31024(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 30992, 31024);
                    return return_v;
                }


                string
                f_1442_31094_31105(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 31094, 31105);
                    return return_v;
                }


                bool
                f_1442_31068_31106(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 31068, 31106);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_31149_31184(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenBeforeCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 31149, 31184);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_31984_32019(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenBeforeCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 31984, 32019);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_31984_32024(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 31984, 32024);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_32484_32498(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 32484, 32498);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_32565_32579(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 32565, 32579);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_32655_32669(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 32655, 32669);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_32714_32728(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 32714, 32728);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_32714_32735(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 32714, 32735);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_32753_32767(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 32753, 32767);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_32753_32774(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 32753, 32774);
                    return return_v;
                }


                bool
                f_1442_33819_33858(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.Language.HashtableAst
                hashTableAst)
                {
                    var return_v = this_param.CheckForPendingAssignment(hashTableAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 33819, 33858);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_34099_34131(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 34099, 34131);
                    return return_v;
                }


                int
                f_1442_34099_34138(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 34099, 34138);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_34260_34334(System.Management.Automation.CompletionContext
                completionContext, System.Management.Automation.Language.HashtableAst
                hashtableAst)
                {
                    var return_v = CompletionCompleters.CompleteHashtableKey(completionContext, hashtableAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 34260, 34334);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_34442_34505(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommandArgument(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 34442, 34505);
                    return return_v;
                }


                int
                f_1442_34551_34585(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ReplacementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 34551, 34585);
                    return return_v;
                }


                int
                f_1442_34632_34667(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ReplacementLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 34632, 34667);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_35112_35130(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 35112, 35130);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_35220_35242(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 35220, 35242);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_36047_36087(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = this_param.GetResultForHashtable(completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 36047, 36087);
                    return return_v;
                }


                int
                f_1442_36136_36148(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 36136, 36148);
                    return return_v;
                }


                System.Management.Automation.Language.ConfigurationDefinitionAst
                f_1442_36318_36391(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.Language.IScriptPosition
                cursorPosition, System.Management.Automation.Language.Ast
                ast, out System.Management.Automation.Language.DynamicKeywordStatementAst
                keywordAst)
                {
                    var return_v = this_param.GetAncestorConfigurationAstAndKeywordAst(cursorPosition, ast, out keywordAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 36318, 36391);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_36565_36657(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, System.Management.Automation.Language.ConfigurationDefinitionAst
                configureAst, System.Management.Automation.Language.DynamicKeywordStatementAst
                keywordAst, out bool
                matched)
                {
                    var return_v = this_param.GetResultForIdentifierInConfiguration(completionContext, configureAst, keywordAst, out matched);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 36565, 36657);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_36770_36801(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 36770, 36801);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_37620_37642(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 37620, 37642);
                    return return_v;
                }


                bool
                f_1442_38171_38255(System.Management.Automation.CompletionContext
                completionContext, System.Management.Automation.Language.AssignmentStatementAst
                assignmentAst, out System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                completions)
                {
                    var return_v = TryGetCompletionsForVariableAssignment(completionContext, assignmentAst, out completions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 38171, 38255);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_38556_38688(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, string
                stringToComplete, ref int
                replacementIndex, ref int
                replacementLength, out bool
                shouldContinue)
                {
                    var return_v = this_param.GetResultForEnumPropertyValueOfDSCResource(completionContext, stringToComplete, ref replacementIndex, ref replacementLength, out shouldContinue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 38556, 38688);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_39090_39183(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, ref int
                replacementIndex, ref int
                replacementLength)
                {
                    var return_v = this_param.GetResultForAttributeArgument(completionContext, ref replacementIndex, ref replacementLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 39090, 39183);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_39409_39586(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, string
                stringToComplete, ref int
                replacementIndex, ref int
                replacementLength, out bool
                shouldContinue)
                {
                    var return_v = this_param.GetResultForEnumPropertyValueOfDSCResource(completionContext, stringToComplete, ref replacementIndex, ref replacementLength, out shouldContinue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 39409, 39586);
                    return return_v;
                }


                int
                f_1442_39885_39897(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 39885, 39897);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_40007_40039(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 40007, 40039);
                    return return_v;
                }


                int
                f_1442_40007_40046(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 40007, 40046);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_40326_40340(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 40326, 40340);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_40675_40710(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenBeforeCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 40675, 40710);
                    return return_v;
                }


                bool
                f_1442_40640_40711(System.Management.Automation.Language.Ast
                lastAst, System.Management.Automation.Language.Token
                tokenBeforeCursor)
                {
                    var return_v = CompleteAgainstSwitchFile(lastAst, tokenBeforeCursor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 40640, 40711);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                f_1442_41145_41201(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteFilename(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 41145, 41201);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_41118_41202(System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 41118, 41202);
                    return return_v;
                }


                int
                f_1442_41254_41288(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ReplacementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 41254, 41288);
                    return return_v;
                }


                int
                f_1442_41339_41374(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ReplacementLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 41339, 41374);
                    return return_v;
                }


                int
                f_1442_41497_41509(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 41497, 41509);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_41562_41591(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 41562, 41591);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeExpressionAst>
                f_1442_41562_41619(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Language.TypeExpressionAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 41562, 41619);
                    return return_v;
                }


                System.Management.Automation.Language.TypeExpressionAst
                f_1442_41562_41636(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeExpressionAst>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.Language.TypeExpressionAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 41562, 41636);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1442_41813_41829(System.Management.Automation.Language.TypeExpressionAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 41813, 41829);
                    return return_v;
                }


                System.Management.Automation.Language.TypeName
                f_1442_41790_41847(System.Management.Automation.Language.ITypeName
                type, System.Management.Automation.Language.IScriptPosition
                cursor)
                {
                    var return_v = FindTypeNameToComplete(type, cursor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 41790, 41847);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_41954_41983(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 41954, 41983);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeConstraintAst>
                f_1442_41954_42011(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Language.TypeConstraintAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 41954, 42011);
                    return return_v;
                }


                System.Management.Automation.Language.TypeConstraintAst
                f_1442_41954_42028(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeConstraintAst>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.Language.TypeConstraintAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 41954, 42028);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1442_42174_42200(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 42174, 42200);
                    return return_v;
                }


                System.Management.Automation.Language.TypeName
                f_1442_42151_42218(System.Management.Automation.Language.ITypeName
                type, System.Management.Automation.Language.IScriptPosition
                cursor)
                {
                    var return_v = FindTypeNameToComplete(type, cursor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 42151, 42218);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_42508_42533(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 42508, 42533);
                    return return_v;
                }


                int
                f_1442_42508_42545(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 42508, 42545);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_42588_42613(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 42588, 42613);
                    return return_v;
                }


                int
                f_1442_42588_42623(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 42588, 42623);
                    return return_v;
                }


                string
                f_1442_42700_42727(System.Management.Automation.Language.TypeName
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 42700, 42727);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_42759_42811(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 42759, 42811);
                    return return_v;
                }


                int
                f_1442_42884_42896(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 42884, 42896);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_42944_42984(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = this_param.GetResultForHashtable(completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 42944, 42984);
                    return return_v;
                }


                int
                f_1442_43038_43050(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43038, 43050);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_43188_43217(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43188, 43217);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_43188_43220(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43188, 43220);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_43188_43227(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43188, 43227);
                    return return_v;
                }


                string
                f_1442_43188_43232(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43188, 43232);
                    return return_v;
                }


                bool
                f_1442_43255_43287(string
                input, string
                pattern)
                {
                    var return_v = Regex.IsMatch(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 43255, 43287);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_43291_43320(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43291, 43320);
                    return return_v;
                }


                int
                f_1442_43291_43326(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43291, 43326);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_43334_43363(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43334, 43363);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_43334_43366(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43334, 43366);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_43445_43474(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43445, 43474);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_43445_43477(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43445, 43477);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_43445_43484(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43445, 43484);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_43445_43504(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43445, 43504);
                    return return_v;
                }


                int
                f_1442_43445_43511(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43445, 43511);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_43554_43583(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43554, 43583);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_43554_43586(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43554, 43586);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_43554_43593(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43554, 43593);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_43554_43611(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43554, 43611);
                    return return_v;
                }


                int
                f_1442_43554_43618(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 43554, 43618);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_43734_43778(System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = CompleteFileNameAsCommand(completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 43734, 43778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 13841, 43854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 13841, 43854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<CompletionResult> GetResultForHashtable(CompletionContext completionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 43923, 46655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 44037, 44088);

                var
                lastAst = f_1442_44051_44087(f_1442_44051_44080(completionContext))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 44102, 44139);

                HashtableAst
                tempHashtableAst = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 44153, 44211);

                IScriptPosition
                cursor = f_1442_44178_44210(completionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 44225, 44268);

                var
                hashTableAst = lastAst as HashtableAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 44282, 46246) || true) && (hashTableAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 44282, 46246);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 44401, 45007) || true) && (f_1442_44405_44418(cursor) < f_1442_44421_44450(f_1442_44421_44440(hashTableAst)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 44401, 45007);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 44492, 44524);

                        tempHashtableAst = hashTableAst;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 44401, 45007);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 44401, 45007);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 44566, 45007) || true) && (f_1442_44570_44583(cursor) == f_1442_44587_44616(f_1442_44587_44606(hashTableAst)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 44566, 45007);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 44755, 44988) || true) && (f_1442_44759_44790(completionContext) == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 44759, 44883) || f_1442_44827_44863(f_1442_44827_44858(completionContext)) != TokenKind.RCurly))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 44755, 44988);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 44933, 44965);

                                tempHashtableAst = hashTableAst;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 44755, 44988);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 44566, 45007);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 44401, 45007);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 44282, 46246);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 44282, 46246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 45165, 45193);

                    Ast
                    lastChildofHashtableAst
                    = default(Ast);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 45211, 45292);

                    hashTableAst = f_1442_45226_45291(lastAst, out lastChildofHashtableAst);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 45389, 46231) || true) && (hashTableAst != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 45389, 46231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 45455, 45533);

                        var
                        keywordAst = f_1442_45472_45532(hashTableAst)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 45555, 46212) || true) && (keywordAst != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 45555, 46212);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 45678, 46189) || true) && (f_1442_45682_45720(f_1442_45708_45719(cursor)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 45678, 46189);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 45890, 46162) || true) && (f_1442_45894_45907(cursor) > f_1442_45910_45950(f_1442_45910_45940(lastChildofHashtableAst)) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 45894, 46033) && f_1442_45987_46000(cursor) <= f_1442_46004_46033(f_1442_46004_46023(hashTableAst))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 45890, 46162);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 46099, 46131);

                                    tempHashtableAst = hashTableAst;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 45890, 46162);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 45678, 46189);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 45555, 46212);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 45389, 46231);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 44282, 46246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 46262, 46294);

                hashTableAst = tempHashtableAst;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 46308, 46616) || true) && (hashTableAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 46308, 46616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 46366, 46443);

                    completionContext.ReplacementIndex = f_1442_46403_46442(f_1442_46403_46435(completionContext));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 46461, 46501);

                    completionContext.ReplacementLength = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 46519, 46601);

                    return f_1442_46526_46600(completionContext, hashTableAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 46308, 46616);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 46632, 46644);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 43923, 46655);

                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_44051_44080(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44051, 44080);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_44051_44087(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.Last<System.Management.Automation.Language.Ast>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 44051, 44087);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_44178_44210(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44178, 44210);
                    return return_v;
                }


                int
                f_1442_44405_44418(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44405, 44418);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_44421_44440(System.Management.Automation.Language.HashtableAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44421, 44440);
                    return return_v;
                }


                int
                f_1442_44421_44450(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44421, 44450);
                    return return_v;
                }


                int
                f_1442_44570_44583(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44570, 44583);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_44587_44606(System.Management.Automation.Language.HashtableAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44587, 44606);
                    return return_v;
                }


                int
                f_1442_44587_44616(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44587, 44616);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_44759_44790(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44759, 44790);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_44827_44858(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44827, 44858);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_44827_44863(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 44827, 44863);
                    return return_v;
                }


                System.Management.Automation.Language.HashtableAst
                f_1442_45226_45291(System.Management.Automation.Language.Ast
                ast, out System.Management.Automation.Language.Ast
                lastChildOfHashtable)
                {
                    var return_v = Ast.GetAncestorHashtableAst(ast, out lastChildOfHashtable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 45226, 45291);
                    return return_v;
                }


                System.Management.Automation.Language.DynamicKeywordStatementAst
                f_1442_45472_45532(System.Management.Automation.Language.HashtableAst
                ast)
                {
                    var return_v = Ast.GetAncestorAst<DynamicKeywordStatementAst>((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 45472, 45532);
                    return return_v;
                }


                string
                f_1442_45708_45719(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 45708, 45719);
                    return return_v;
                }


                bool
                f_1442_45682_45720(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 45682, 45720);
                    return return_v;
                }


                int
                f_1442_45894_45907(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 45894, 45907);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_45910_45940(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 45910, 45940);
                    return return_v;
                }


                int
                f_1442_45910_45950(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 45910, 45950);
                    return return_v;
                }


                int
                f_1442_45987_46000(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 45987, 46000);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_46004_46023(System.Management.Automation.Language.HashtableAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 46004, 46023);
                    return return_v;
                }


                int
                f_1442_46004_46033(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 46004, 46033);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_46403_46435(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 46403, 46435);
                    return return_v;
                }


                int
                f_1442_46403_46442(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 46403, 46442);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_46526_46600(System.Management.Automation.CompletionContext
                completionContext, System.Management.Automation.Language.HashtableAst
                hashtableAst)
                {
                    var return_v = CompletionCompleters.CompleteHashtableKey(completionContext, hashtableAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 46526, 46600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 43923, 46655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 43923, 46655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckForPendingAssignment(HashtableAst hashTableAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 46750, 47165);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 46840, 47125);
                    foreach (var keyValue in f_1442_46865_46891_I(f_1442_46865_46891(hashTableAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 46840, 47125);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 46925, 47110) || true) && (f_1442_46929_46943(keyValue) is ErrorStatementAst)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 46925, 47110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 47079, 47091);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 46925, 47110);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 46840, 47125);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 286);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 47141, 47154);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 46750, 47165);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1442_46865_46891(System.Management.Automation.Language.HashtableAst
                this_param)
                {
                    var return_v = this_param.KeyValuePairs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 46865, 46891);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1442_46929_46943(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 46929, 46943);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1442_46865_46891_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 46865, 46891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 46750, 47165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 46750, 47165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeName FindTypeNameToComplete(ITypeName type, IScriptPosition cursor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 47177, 48674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 47289, 47321);

                var
                typeName = type as TypeName
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 47335, 47828) || true) && (typeName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 47335, 47828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 47648, 47813);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1442, 47655, 47738) || (((f_1442_47656_47669(cursor) > f_1442_47672_47695(f_1442_47672_47683(type)) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 47656, 47737) && f_1442_47699_47712(cursor) <= f_1442_47716_47737(f_1442_47716_47727(type))))
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1442, 47769, 47777)) || DynAbs.Tracing.TraceSender.Conditional_F3(1442, 47808, 47812))) ? typeName
                    : null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 47335, 47828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 47844, 47890);

                var
                genericTypeName = type as GenericTypeName
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 47904, 48416) || true) && (genericTypeName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 47904, 48416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 47965, 48033);

                    typeName = f_1442_47976_48032(f_1442_47999_48023(genericTypeName), cursor);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48051, 48110) || true) && (typeName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 48051, 48110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48094, 48110);

                        return typeName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 48051, 48110);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48128, 48369);
                        foreach (var t in f_1442_48146_48178_I(f_1442_48146_48178(genericTypeName)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 48128, 48369);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48220, 48265);

                            typeName = f_1442_48231_48264(t, cursor);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48287, 48350) || true) && (typeName != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 48287, 48350);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48334, 48350);

                                return typeName;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 48287, 48350);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 48128, 48369);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 242);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 242);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48389, 48401);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 47904, 48416);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48432, 48474);

                var
                arrayTypeName = type as ArrayTypeName
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48488, 48635) || true) && (arrayTypeName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 48488, 48635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48547, 48620);

                    return f_1442_48554_48611(f_1442_48577_48602(arrayTypeName), cursor) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.TypeName>(1442, 48554, 48619) ?? null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 48488, 48635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48651, 48663);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 47177, 48674);

                int
                f_1442_47656_47669(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 47656, 47669);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_47672_47683(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 47672, 47683);
                    return return_v;
                }


                int
                f_1442_47672_47695(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 47672, 47695);
                    return return_v;
                }


                int
                f_1442_47699_47712(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 47699, 47712);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_47716_47727(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 47716, 47727);
                    return return_v;
                }


                int
                f_1442_47716_47737(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 47716, 47737);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1442_47999_48023(System.Management.Automation.Language.GenericTypeName
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 47999, 48023);
                    return return_v;
                }


                System.Management.Automation.Language.TypeName
                f_1442_47976_48032(System.Management.Automation.Language.ITypeName
                type, System.Management.Automation.Language.IScriptPosition
                cursor)
                {
                    var return_v = FindTypeNameToComplete(type, cursor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 47976, 48032);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ITypeName>
                f_1442_48146_48178(System.Management.Automation.Language.GenericTypeName
                this_param)
                {
                    var return_v = this_param.GenericArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 48146, 48178);
                    return return_v;
                }


                System.Management.Automation.Language.TypeName
                f_1442_48231_48264(System.Management.Automation.Language.ITypeName
                type, System.Management.Automation.Language.IScriptPosition
                cursor)
                {
                    var return_v = FindTypeNameToComplete(type, cursor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 48231, 48264);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ITypeName>
                f_1442_48146_48178_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ITypeName>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 48146, 48178);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1442_48577_48602(System.Management.Automation.Language.ArrayTypeName
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 48577, 48602);
                    return return_v;
                }


                System.Management.Automation.Language.TypeName
                f_1442_48554_48611(System.Management.Automation.Language.ITypeName
                type, System.Management.Automation.Language.IScriptPosition
                cursor)
                {
                    var return_v = FindTypeNameToComplete(type, cursor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 48554, 48611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 47177, 48674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 47177, 48674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetFirstLineSubString(string stringToComplete, out bool hasNewLine)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 48686, 49228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48800, 48819);

                hasNewLine = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48833, 49177) || true) && (!f_1442_48838_48876(stringToComplete))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 48833, 49177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48910, 48973);

                    var
                    index = f_1442_48922_48972(stringToComplete, Utils.Separators.CrLf)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 48991, 49162) || true) && (index >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 48991, 49162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 49047, 49103);

                        stringToComplete = f_1442_49066_49102(stringToComplete, 0, index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 49125, 49143);

                        hasNewLine = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 48991, 49162);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 48833, 49177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 49193, 49217);

                return stringToComplete;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 48686, 49228);

                bool
                f_1442_48838_48876(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 48838, 48876);
                    return return_v;
                }


                int
                f_1442_48922_48972(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 48922, 48972);
                    return return_v;
                }


                string
                f_1442_49066_49102(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 49066, 49102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 48686, 49228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 48686, 49228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tuple<ExpressionAst, StatementAst> GetHashEntryContainsCursor(
                    IScriptPosition cursor,
                    HashtableAst hashTableAst,
                    bool isCursorInString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 49240, 51768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 49448, 49513);

                Tuple<ExpressionAst, StatementAst>
                keyValuePairWithCursor = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 49527, 51711);
                    foreach (var kvp in f_1442_49547_49573_I(f_1442_49547_49573(hashTableAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 49527, 51711);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 49607, 49786) || true) && (f_1442_49611_49668(cursor, f_1442_49651_49667(f_1442_49651_49660(kvp))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 49607, 49786);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 49710, 49739);

                            keyValuePairWithCursor = kvp;
                            DynAbs.Tracing.TraceSender.TraceBreak(1442, 49761, 49767);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 49607, 49786);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 49806, 51696) || true) && (!isCursorInString)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 49806, 51696);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 50507, 50800) || true) && (f_1442_50511_50543(f_1442_50511_50527(f_1442_50511_50520(kvp))) > f_1442_50546_50576(f_1442_50546_50562(f_1442_50546_50555(kvp))) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 50511, 50666) && f_1442_50605_50666(cursor, f_1442_50649_50665(f_1442_50649_50658(kvp)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 50507, 50800);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 50716, 50745);

                                keyValuePairWithCursor = kvp;
                                DynAbs.Tracing.TraceSender.TraceBreak(1442, 50771, 50777);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 50507, 50800);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 51434, 51677) || true) && (!f_1442_51439_51485(cursor, f_1442_51468_51484(f_1442_51468_51477(kvp))) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 51438, 51575) && f_1442_51514_51575(cursor, f_1442_51558_51574(f_1442_51558_51567(kvp)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 51434, 51677);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 51625, 51654);

                                keyValuePairWithCursor = kvp;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 51434, 51677);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 49806, 51696);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 49527, 51711);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 2185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 2185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 51727, 51757);

                return keyValuePairWithCursor;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 49240, 51768);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1442_49547_49573(System.Management.Automation.Language.HashtableAst
                this_param)
                {
                    var return_v = this_param.KeyValuePairs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 49547, 49573);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1442_49651_49660(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 49651, 49660);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_49651_49667(System.Management.Automation.Language.StatementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 49651, 49667);
                    return return_v;
                }


                bool
                f_1442_49611_49668(System.Management.Automation.Language.IScriptPosition
                cursor, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    var return_v = IsCursorWithinOrJustAfterExtent(cursor, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 49611, 49668);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1442_50511_50520(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 50511, 50520);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_50511_50527(System.Management.Automation.Language.StatementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 50511, 50527);
                    return return_v;
                }


                int
                f_1442_50511_50543(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 50511, 50543);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1442_50546_50555(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 50546, 50555);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_50546_50562(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 50546, 50562);
                    return return_v;
                }


                int
                f_1442_50546_50576(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 50546, 50576);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1442_50649_50658(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 50649, 50658);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_50649_50665(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 50649, 50665);
                    return return_v;
                }


                bool
                f_1442_50605_50666(System.Management.Automation.Language.IScriptPosition
                cursor, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    var return_v = IsCursorAfterExtentAndInTheSameLine(cursor, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 50605, 50666);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1442_51468_51477(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 51468, 51477);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_51468_51484(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 51468, 51484);
                    return return_v;
                }


                bool
                f_1442_51439_51485(System.Management.Automation.Language.IScriptPosition
                cursor, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    var return_v = IsCursorBeforeExtent(cursor, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 51439, 51485);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1442_51558_51567(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 51558, 51567);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_51558_51574(System.Management.Automation.Language.StatementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 51558, 51574);
                    return return_v;
                }


                bool
                f_1442_51514_51575(System.Management.Automation.Language.IScriptPosition
                cursor, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    var return_v = IsCursorAfterExtentAndInTheSameLine(cursor, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 51514, 51575);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1442_49547_49573_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 49547, 49573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 49240, 51768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 49240, 51768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static VariableExpressionAst GetVariableFromExpressionAst(
                    ExpressionAst expression,
                    ref Type typeConstraint,
                    ref ValidateSetAttribute setConstraint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 51924, 53441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 52145, 53430);

                switch (expression)
                {

                    case VariableExpressionAst variableExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 52145, 53430);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 52294, 52320);

                        return variableExpression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 52145, 53430);

                    case ConvertExpressionAst convertExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 52145, 53430);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 52441, 52510);

                        typeConstraint = f_1442_52458_52509(f_1442_52458_52489(f_1442_52458_52480(convertExpression)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 52532, 52632);

                        return f_1442_52539_52631(f_1442_52568_52591(convertExpression), ref typeConstraint, ref setConstraint);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 52145, 53430);

                    case AttributedExpressionAst attributedExpressionAst:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 52145, 53430);

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 52829, 52918);

                            setConstraint = f_1442_52845_52893(f_1442_52845_52878(attributedExpressionAst)) as ValidateSetAttribute;
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1442, 52963, 53117);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1442, 52963, 53117);
                            // Do nothing, just prevent fallout from an unsuccessful attribute conversion
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 53141, 53247);

                        return f_1442_53148_53246(f_1442_53177_53206(attributedExpressionAst), ref typeConstraint, ref setConstraint);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 52145, 53430);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 52145, 53430);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 53403, 53415);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 52145, 53430);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 51924, 53441);

                System.Management.Automation.Language.TypeConstraintAst
                f_1442_52458_52480(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 52458, 52480);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1442_52458_52489(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 52458, 52489);
                    return return_v;
                }


                System.Type
                f_1442_52458_52509(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 52458, 52509);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1442_52568_52591(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 52568, 52591);
                    return return_v;
                }


                System.Management.Automation.Language.VariableExpressionAst
                f_1442_52539_52631(System.Management.Automation.Language.ExpressionAst
                expression, ref System.Type
                typeConstraint, ref System.Management.Automation.ValidateSetAttribute
                setConstraint)
                {
                    var return_v = GetVariableFromExpressionAst(expression, ref typeConstraint, ref setConstraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 52539, 52631);
                    return return_v;
                }


                System.Management.Automation.Language.AttributeBaseAst
                f_1442_52845_52878(System.Management.Automation.Language.AttributedExpressionAst
                this_param)
                {
                    var return_v = this_param.Attribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 52845, 52878);
                    return return_v;
                }


                System.Attribute
                f_1442_52845_52893(System.Management.Automation.Language.AttributeBaseAst
                this_param)
                {
                    var return_v = this_param.GetAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 52845, 52893);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1442_53177_53206(System.Management.Automation.Language.AttributedExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 53177, 53206);
                    return return_v;
                }


                System.Management.Automation.Language.VariableExpressionAst
                f_1442_53148_53246(System.Management.Automation.Language.ExpressionAst
                expression, ref System.Type
                typeConstraint, ref System.Management.Automation.ValidateSetAttribute
                setConstraint)
                {
                    var return_v = GetVariableFromExpressionAst(expression, ref typeConstraint, ref setConstraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 53148, 53246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 51924, 53441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 51924, 53441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetTypeConstraintOnVariable(
                    CompletionContext completionContext,
                    string variableName,
                    out Type typeConstraint,
                    out ValidateSetAttribute setConstraint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 53538, 54683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 53789, 53811);

                typeConstraint = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 53825, 53846);

                setConstraint = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 53862, 53964);

                PSVariable
                variable = f_1442_53884_53963(f_1442_53884_53937(f_1442_53884_53918(completionContext)), variableName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 53980, 54096) || true) && (variable == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 53984, 54034) || f_1442_54004_54029(f_1442_54004_54023(variable)) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 53980, 54096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 54068, 54081);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 53980, 54096);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 54112, 54601);
                    foreach (Attribute attribute in f_1442_54144_54163_I(f_1442_54144_54163(variable)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 54112, 54601);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 54197, 54410) || true) && (attribute is ArgumentTypeConverterAttribute typeConverterAttribute)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 54197, 54410);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 54309, 54360);

                            typeConstraint = f_1442_54326_54359(typeConverterAttribute);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 54382, 54391);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 54197, 54410);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 54430, 54586) || true) && (attribute is ValidateSetAttribute validateSetAttribute)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 54430, 54586);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 54530, 54567);

                            setConstraint = validateSetAttribute;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 54430, 54586);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 54112, 54601);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 490);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 54617, 54672);

                return typeConstraint != null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 54624, 54671) || setConstraint != null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 53538, 54683);

                System.Management.Automation.ExecutionContext
                f_1442_53884_53918(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 53884, 53918);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1442_53884_53937(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 53884, 53937);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1442_53884_53963(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 53884, 53963);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1442_54004_54023(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 54004, 54023);
                    return return_v;
                }


                int
                f_1442_54004_54029(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 54004, 54029);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1442_54144_54163(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 54144, 54163);
                    return return_v;
                }


                System.Type
                f_1442_54326_54359(System.Management.Automation.ArgumentTypeConverterAttribute
                this_param)
                {
                    var return_v = this_param.TargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 54326, 54359);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1442_54144_54163_I(System.Collections.ObjectModel.Collection<System.Attribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 54144, 54163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 53538, 54683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 53538, 54683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetCompletionsForVariableAssignment(
                    CompletionContext completionContext,
                    AssignmentStatementAst assignmentAst,
                    out List<CompletionResult> completions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 54695, 57695);

                bool TryGetResultForEnum(Type typeConstraint, CompletionContext completionContext, out List<CompletionResult> completions)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 54933, 55387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55088, 55107);

                        completions = null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55127, 55339) || true) && (typeConstraint != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 55131, 55178) && f_1442_55157_55178(typeConstraint)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 55127, 55339);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55220, 55286);

                            completions = f_1442_55234_55285(typeConstraint, completionContext);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55308, 55320);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 55127, 55339);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55359, 55372);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 54933, 55387);

                        bool
                        f_1442_55157_55178(System.Type
                        this_param)
                        {
                            var return_v = this_param.IsEnum;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 55157, 55178);
                            return return_v;
                        }


                        System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                        f_1442_55234_55285(System.Type
                        type, System.Management.Automation.CompletionContext
                        completionContext)
                        {
                            var return_v = GetResultForEnum(type, completionContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 55234, 55285);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 54933, 55387);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 54933, 55387);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool TryGetResultForSet(Type typeConstraint, ValidateSetAttribute setConstraint, CompletionContext completionContext1, out List<CompletionResult> completions)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 55403, 55906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55594, 55613);

                        completions = null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55633, 55858) || true) && (f_1442_55637_55663_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(setConstraint, 1442, 55637, 55663)?.ValidValues) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 55633, 55858);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55713, 55805);

                            completions = f_1442_55727_55804(typeConstraint, f_1442_55759_55784(setConstraint), completionContext);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55827, 55839);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 55633, 55858);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55878, 55891);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 55403, 55906);

                        System.Collections.Generic.IList<string>
                        f_1442_55637_55663_M(System.Collections.Generic.IList<string>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 55637, 55663);
                            return return_v;
                        }


                        System.Collections.Generic.IList<string>
                        f_1442_55759_55784(System.Management.Automation.ValidateSetAttribute
                        this_param)
                        {
                            var return_v = this_param.ValidValues;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 55759, 55784);
                            return return_v;
                        }


                        System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                        f_1442_55727_55804(System.Type
                        typeConstraint, System.Collections.Generic.IList<string>
                        validValues, System.Management.Automation.CompletionContext
                        completionContext)
                        {
                            var return_v = GetResultForSet(typeConstraint, validValues, completionContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 55727, 55804);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 55403, 55906);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 55403, 55906);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 55922, 55941);

                completions = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 56049, 56076);

                Type
                typeConstraint = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 56090, 56132);

                ValidateSetAttribute
                setConstraint = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 56146, 56270);

                VariableExpressionAst
                variableAst = f_1442_56182_56269(f_1442_56211_56229(assignmentAst), ref typeConstraint, ref setConstraint)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 56286, 56371) || true) && (variableAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 56286, 56371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 56343, 56356);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 56286, 56371);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 56564, 56714) || true) && (f_1442_56568_56653(typeConstraint, setConstraint, completionContext, out completions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 56564, 56714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 56687, 56699);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 56564, 56714);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 56784, 56920) || true) && (f_1442_56788_56859(typeConstraint, completionContext, out completions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 56784, 56920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 56893, 56905);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 56784, 56920);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 57024, 57214) || true) && (!f_1442_57029_57152(completionContext, f_1442_57079_57112(f_1442_57079_57103(variableAst)), out typeConstraint, out setConstraint))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 57024, 57214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 57186, 57199);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 57024, 57214);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 57293, 57443) || true) && (f_1442_57297_57382(typeConstraint, setConstraint, completionContext, out completions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 57293, 57443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 57416, 57428);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 57293, 57443);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 57519, 57655) || true) && (f_1442_57523_57594(typeConstraint, completionContext, out completions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 57519, 57655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 57628, 57640);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 57519, 57655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 57671, 57684);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 54695, 57695);

                System.Management.Automation.Language.ExpressionAst
                f_1442_56211_56229(System.Management.Automation.Language.AssignmentStatementAst
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 56211, 56229);
                    return return_v;
                }


                System.Management.Automation.Language.VariableExpressionAst
                f_1442_56182_56269(System.Management.Automation.Language.ExpressionAst
                expression, ref System.Type
                typeConstraint, ref System.Management.Automation.ValidateSetAttribute
                setConstraint)
                {
                    var return_v = GetVariableFromExpressionAst(expression, ref typeConstraint, ref setConstraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 56182, 56269);
                    return return_v;
                }


                bool
                f_1442_56568_56653(System.Type
                typeConstraint, System.Management.Automation.ValidateSetAttribute
                setConstraint, System.Management.Automation.CompletionContext
                completionContext1, out System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                completions)
                {
                    var return_v = TryGetResultForSet(typeConstraint, setConstraint, completionContext1, out completions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 56568, 56653);
                    return return_v;
                }


                bool
                f_1442_56788_56859(System.Type
                typeConstraint, System.Management.Automation.CompletionContext
                completionContext, out System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                completions)
                {
                    var return_v = TryGetResultForEnum(typeConstraint, completionContext, out completions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 56788, 56859);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1442_57079_57103(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 57079, 57103);
                    return return_v;
                }


                string
                f_1442_57079_57112(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 57079, 57112);
                    return return_v;
                }


                bool
                f_1442_57029_57152(System.Management.Automation.CompletionContext
                completionContext, string
                variableName, out System.Type
                typeConstraint, out System.Management.Automation.ValidateSetAttribute
                setConstraint)
                {
                    var return_v = TryGetTypeConstraintOnVariable(completionContext, variableName, out typeConstraint, out setConstraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 57029, 57152);
                    return return_v;
                }


                bool
                f_1442_57297_57382(System.Type
                typeConstraint, System.Management.Automation.ValidateSetAttribute
                setConstraint, System.Management.Automation.CompletionContext
                completionContext1, out System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                completions)
                {
                    var return_v = TryGetResultForSet(typeConstraint, setConstraint, completionContext1, out completions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 57297, 57382);
                    return return_v;
                }


                bool
                f_1442_57523_57594(System.Type
                typeConstraint, System.Management.Automation.CompletionContext
                completionContext, out System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                completions)
                {
                    var return_v = TryGetResultForEnum(typeConstraint, completionContext, out completions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 57523, 57594);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 54695, 57695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 54695, 57695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<CompletionResult> GetResultForSet(
                    Type typeConstraint,
                    IList<string> validValues,
                    CompletionContext completionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 57707, 58436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 57910, 57945);

                var
                allValues = f_1442_57926_57944()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 57959, 58354);
                    foreach (string value in f_1442_57984_57995_I(validValues))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 57959, 58354);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 58029, 58339) || true) && (typeConstraint != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 58033, 58118) && (typeConstraint == typeof(string) || (DynAbs.Tracing.TraceSender.Expression_False(1442, 58060, 58117) || f_1442_58096_58117(typeConstraint)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 58029, 58339);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 58160, 58217);

                            f_1442_58160_58216(allValues, f_1442_58174_58215(value, completionContext));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 58029, 58339);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 58029, 58339);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 58299, 58320);

                            f_1442_58299_58319(allValues, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 58029, 58339);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 57959, 58354);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 396);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 58370, 58425);

                return f_1442_58377_58424(allValues, completionContext);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 57707, 58436);

                System.Collections.Generic.List<string>
                f_1442_57926_57944()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 57926, 57944);
                    return return_v;
                }


                bool
                f_1442_58096_58117(System.Type
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 58096, 58117);
                    return return_v;
                }


                string
                f_1442_58174_58215(string
                value, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = GetQuotedString(value, completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 58174, 58215);
                    return return_v;
                }


                int
                f_1442_58160_58216(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 58160, 58216);
                    return 0;
                }


                int
                f_1442_58299_58319(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 58299, 58319);
                    return 0;
                }


                System.Collections.Generic.IList<string>
                f_1442_57984_57995_I(System.Collections.Generic.IList<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 57984, 57995);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_58377_58424(System.Collections.Generic.List<string>
                allValues, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = GetMatchedResults(allValues, completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 58377, 58424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 57707, 58436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 57707, 58436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<CompletionResult> GetMatchedResults(
                    List<string> allValues,
                    CompletionContext completionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 58448, 59637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 58616, 58652);

                var
                stringToComplete = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 58666, 58874) || true) && (f_1442_58670_58701(completionContext) != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 58670, 58769) && f_1442_58713_58749(f_1442_58713_58744(completionContext)) != TokenKind.Equals))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 58666, 58874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 58803, 58859);

                    stringToComplete = f_1442_58822_58858(f_1442_58822_58853(completionContext));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 58666, 58874);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 58890, 58932);

                IEnumerable<string>
                matchedResults = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 58948, 59399) || true) && (!f_1442_58953_58991(stringToComplete))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 58948, 59399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59025, 59069);

                    string
                    matchString = stringToComplete + "*"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59087, 59205);

                    var
                    wildcardPattern = f_1442_59109_59204(matchString, WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59225, 59291);

                    matchedResults = f_1442_59242_59290(allValues, r => wildcardPattern.IsMatch(r));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 58948, 59399);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 58948, 59399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59357, 59384);

                    matchedResults = allValues;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 58948, 59399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59415, 59457);

                var
                result = f_1442_59428_59456()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59471, 59596);
                    foreach (var match in f_1442_59493_59507_I(matchedResults))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 59471, 59596);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59541, 59581);

                        f_1442_59541_59580(result, f_1442_59552_59579(match));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 59471, 59596);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59612, 59626);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 58448, 59637);

                System.Management.Automation.Language.Token
                f_1442_58670_58701(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 58670, 58701);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_58713_58744(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 58713, 58744);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_58713_58749(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 58713, 58749);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_58822_58853(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 58822, 58853);
                    return return_v;
                }


                string
                f_1442_58822_58858(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 58822, 58858);
                    return return_v;
                }


                bool
                f_1442_58953_58991(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 58953, 58991);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1442_59109_59204(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 59109, 59204);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1442_59242_59290(System.Collections.Generic.List<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 59242, 59290);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_59428_59456()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 59428, 59456);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1442_59552_59579(string
                completionText)
                {
                    var return_v = new System.Management.Automation.CompletionResult(completionText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 59552, 59579);
                    return return_v;
                }


                int
                f_1442_59541_59580(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Management.Automation.CompletionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 59541, 59580);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1442_59493_59507_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 59493, 59507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 58448, 59637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 58448, 59637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetQuotedString(
                    string value,
                    CompletionContext completionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 59649, 60115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59789, 59825);

                var
                stringToComplete = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59839, 59987) || true) && (f_1442_59843_59874(completionContext) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 59839, 59987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 59916, 59972);

                    stringToComplete = f_1442_59935_59971(f_1442_59935_59966(completionContext));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 59839, 59987);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 60003, 60061);

                var
                quote = (DynAbs.Tracing.TraceSender.Conditional_F1(1442, 60015, 60047) || ((f_1442_60015_60047(stringToComplete, '"') && DynAbs.Tracing.TraceSender.Conditional_F2(1442, 60050, 60054)) || DynAbs.Tracing.TraceSender.Conditional_F3(1442, 60057, 60060))) ? "\"" : "'"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 60075, 60104);

                return quote + value + quote;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 59649, 60115);

                System.Management.Automation.Language.Token
                f_1442_59843_59874(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 59843, 59874);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_59935_59966(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 59935, 59966);
                    return return_v;
                }


                string
                f_1442_59935_59971(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 59935, 59971);
                    return return_v;
                }


                bool
                f_1442_60015_60047(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 60015, 60047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 59649, 60115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 59649, 60115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<CompletionResult> GetResultForEnum(
                    Type type,
                    CompletionContext completionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 60127, 60586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 60281, 60315);

                var
                allNames = f_1442_60296_60314()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 60329, 60473);
                    foreach (var name in f_1442_60350_60369_I(f_1442_60350_60369(type)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 60329, 60473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 60403, 60458);

                        f_1442_60403_60457(allNames, f_1442_60416_60456(name, completionContext));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 60329, 60473);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 60489, 60505);

                f_1442_60489_60504(
                            allNames);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 60521, 60575);

                return f_1442_60528_60574(allNames, completionContext);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 60127, 60586);

                System.Collections.Generic.List<string>
                f_1442_60296_60314()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 60296, 60314);
                    return return_v;
                }


                string[]
                f_1442_60350_60369(System.Type
                enumType)
                {
                    var return_v = Enum.GetNames(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 60350, 60369);
                    return return_v;
                }


                string
                f_1442_60416_60456(string
                value, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = GetQuotedString(value, completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 60416, 60456);
                    return return_v;
                }


                int
                f_1442_60403_60457(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 60403, 60457);
                    return 0;
                }


                string[]
                f_1442_60350_60369_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 60350, 60369);
                    return return_v;
                }


                int
                f_1442_60489_60504(System.Collections.Generic.List<string>
                this_param)
                {
                    this_param.Sort();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 60489, 60504);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_60528_60574(System.Collections.Generic.List<string>
                allValues, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = GetMatchedResults(allValues, completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 60528, 60574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 60127, 60586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 60127, 60586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<CompletionResult> GetResultForEnumPropertyValueOfDSCResource(
                    CompletionContext completionContext,
                    string stringToComplete,
                    ref int replacementIndex,
                    ref int replacementLength,
                    out bool shouldContinue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 60598, 71919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 60902, 60924);

                shouldContinue = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 60938, 61009);

                bool
                isCursorInString = f_1442_60962_60993(completionContext) is StringToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61023, 61060);

                List<CompletionResult>
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61074, 61125);

                var
                lastAst = f_1442_61088_61124(f_1442_61088_61117(completionContext))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61139, 61167);

                Ast
                lastChildofHashtableAst
                = default(Ast);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61181, 61266);

                var
                hashTableAst = f_1442_61200_61265(lastAst, out lastChildofHashtableAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61280, 61366);

                f_1442_61280_61365(stringToComplete != null, "stringToComplete should never be null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61453, 71878) || true) && (hashTableAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 61453, 71878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61511, 61589);

                    var
                    keywordAst = f_1442_61528_61588(hashTableAst)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61607, 71863) || true) && (keywordAst != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 61607, 71863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61671, 61729);

                        IScriptPosition
                        cursor = f_1442_61696_61728(completionContext)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61751, 61847);

                        var
                        keyValuePairWithCursor = f_1442_61780_61846(this, cursor, hashTableAst, isCursorInString)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61869, 71844) || true) && (keyValuePairWithCursor != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 61869, 71844);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 61953, 62035);

                            var
                            propertyNameAst = f_1442_61975_62003(keyValuePairWithCursor) as StringConstantExpressionAst
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 62061, 71821) || true) && (propertyNameAst != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 62061, 71821);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 62146, 62178);

                                DynamicKeywordProperty
                                property
                                = default(DynamicKeywordProperty);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 62208, 71794) || true) && (f_1442_62212_62290(f_1442_62212_62241(f_1442_62212_62230(keywordAst)), f_1442_62254_62275(propertyNameAst), out property))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 62208, 71794);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 62356, 62391);

                                    List<string>
                                    existingValues = null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 62425, 62464);

                                    WildcardPattern
                                    wildcardPattern = null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 62498, 62604);

                                    bool
                                    isDependsOnProperty = f_1442_62525_62603(f_1442_62539_62552(property), @"DependsOn", StringComparison.OrdinalIgnoreCase)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 62638, 62662);

                                    bool
                                    hasNewLine = false
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 62696, 62789);

                                    string
                                    stringQuote = (DynAbs.Tracing.TraceSender.Conditional_F1(1442, 62717, 62775) || (((f_1442_62718_62749(completionContext) is StringExpandableToken) && DynAbs.Tracing.TraceSender.Conditional_F2(1442, 62778, 62782)) || DynAbs.Tracing.TraceSender.Conditional_F3(1442, 62785, 62788))) ? "\"" : "'"
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 62823, 66138) || true) && ((f_1442_62828_62845(property) != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 62828, 62884) && f_1442_62857_62880(f_1442_62857_62874(property)) > 0)) || (DynAbs.Tracing.TraceSender.Expression_False(1442, 62827, 62908) || isDependsOnProperty))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 62823, 66138);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 62982, 63005);

                                        shouldContinue = false;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 63043, 63079);

                                        existingValues = f_1442_63060_63078();

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 63117, 64467) || true) && (f_1442_63121_63210(f_1442_63135_63158(property), "StringArray", StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 63117, 64467);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 63292, 63352);

                                            var
                                            arrayAst = f_1442_63307_63351(lastAst)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 63394, 64428) || true) && (arrayAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 63398, 63445) && f_1442_63418_63441(f_1442_63418_63435(arrayAst)) > 0))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 63394, 64428);
                                                try
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 63535, 64385);
                                                    foreach (ExpressionAst expression in f_1442_63572_63589_I(f_1442_63572_63589(arrayAst)))
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 63535, 64385);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 63962, 64020);

                                                        var
                                                        stringAst = expression as StringConstantExpressionAst
                                                        ;

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 64070, 64338) || true) && (stringAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 64074, 64145) && f_1442_64095_64145(cursor, f_1442_64127_64144(expression))))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 64070, 64338);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 64251, 64287);

                                                            f_1442_64251_64286(existingValues, f_1442_64270_64285(stringAst));
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 64070, 64338);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 63535, 64385);
                                                    }
                                                }
                                                catch (System.Exception)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 851);
                                                    throw;
                                                }
                                                finally
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 851);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 63394, 64428);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 63117, 64467);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 64683, 64758);

                                        stringToComplete = f_1442_64702_64757(stringToComplete, out hasNewLine);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 64796, 64848);

                                        completionContext.WordToComplete = stringToComplete;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 64886, 64968);

                                        replacementLength = completionContext.ReplacementLength = f_1442_64944_64967(stringToComplete);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 65213, 65699) || true) && (f_1442_65217_65248(completionContext) is StringToken)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 65213, 65699);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 65345, 65419);

                                            replacementIndex = f_1442_65364_65414(f_1442_65364_65402(f_1442_65364_65395(completionContext))) + 1;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 65213, 65699);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 65213, 65699);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 65581, 65660);

                                            replacementIndex = f_1442_65600_65639(f_1442_65600_65632(completionContext)) - replacementLength;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 65213, 65699);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 65739, 65793);

                                        completionContext.ReplacementIndex = replacementIndex;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 65831, 65875);

                                        string
                                        matchString = stringToComplete + "*"
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 65913, 66027);

                                        wildcardPattern = f_1442_65931_66026(matchString, WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 66065, 66103);

                                        result = f_1442_66074_66102();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 62823, 66138);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 66174, 66289);

                                    f_1442_66174_66288(isCursorInString || (DynAbs.Tracing.TraceSender.Expression_False(1442, 66193, 66226) || (!hasNewLine)), "hasNoQuote and hasNewLine cannot be true at the same time");

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 66323, 71763) || true) && (f_1442_66327_66344(property) != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 66327, 66383) && f_1442_66356_66379(f_1442_66356_66373(property)) > 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 66323, 71763);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 66457, 66606);

                                        IEnumerable<string>
                                        orderedValues = f_1442_66493_66605(f_1442_66493_66531(f_1442_66493_66515(f_1442_66493_66510(property)), x => x), v => !existingValues.Contains(v, StringComparer.OrdinalIgnoreCase))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 66644, 66718);

                                        var
                                        matchedResults = f_1442_66665_66717(orderedValues, v => wildcardPattern.IsMatch(v))
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 66756, 67034) || true) && (matchedResults == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 66760, 66807) || !f_1442_66787_66807(matchedResults)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 66756, 67034);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 66964, 66995);

                                            matchedResults = orderedValues;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 66756, 67034);
                                        }
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 67074, 67778);
                                            foreach (var value in f_1442_67096_67110_I(matchedResults))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 67074, 67778);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 67192, 67277);

                                                string
                                                completionText = (DynAbs.Tracing.TraceSender.Conditional_F1(1442, 67216, 67232) || ((isCursorInString && DynAbs.Tracing.TraceSender.Conditional_F2(1442, 67235, 67240)) || DynAbs.Tracing.TraceSender.Conditional_F3(1442, 67243, 67276))) ? value : stringQuote + value + stringQuote
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 67319, 67426) || true) && (hasNewLine)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 67319, 67426);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 67380, 67426);

                                                    completionText = completionText + stringQuote;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 67319, 67426);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 67468, 67739);

                                                f_1442_67468_67738(result, f_1442_67479_67737(completionText, value, CompletionResultType.Text, value));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 67074, 67778);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 705);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 705);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 66323, 71763);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 66323, 71763);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 67852, 71763) || true) && (isDependsOnProperty)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 67852, 71763);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 67949, 68024);

                                            var
                                            configAst = f_1442_67965_68023(keywordAst)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 68062, 71728) || true) && (configAst != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 68062, 71728);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 68165, 68231);

                                                var
                                                namedBlockAst = f_1442_68185_68230(keywordAst)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 68273, 71689) || true) && (namedBlockAst != null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 68273, 71689);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 68388, 68435);

                                                    List<string>
                                                    allResources = f_1442_68416_68434()
                                                    ;
                                                    try
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 68481, 70323);
                                                        foreach (var statementAst in f_1442_68510_68534_I(f_1442_68510_68534(namedBlockAst)))
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 68481, 70323);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 68632, 68699);

                                                            var
                                                            dynamicKeywordAst = statementAst as DynamicKeywordStatementAst
                                                            ;

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 68749, 70276) || true) && (dynamicKeywordAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 68753, 68866) && dynamicKeywordAst != keywordAst) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 68753, 69017) && !f_1442_68924_69017(f_1442_68938_68971(f_1442_68938_68963(dynamicKeywordAst)), @"Node", StringComparison.OrdinalIgnoreCase)))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 68749, 70276);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 69123, 70225) || true) && (!f_1442_69128_69179(f_1442_69149_69178(dynamicKeywordAst)))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 69123, 70225);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 69293, 69339);

                                                                    StringBuilder
                                                                    sb = f_1442_69312_69338("[", 50)
                                                                    ;
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 69397, 69442);

                                                                    f_1442_69397_69441(sb, f_1442_69407_69440(f_1442_69407_69432(dynamicKeywordAst)));
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 69500, 69515);

                                                                    f_1442_69500_69514(sb, "]");
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 69573, 69614);

                                                                    f_1442_69573_69613(sb, f_1442_69583_69612(dynamicKeywordAst));
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 69672, 69701);

                                                                    var
                                                                    resource = f_1442_69687_69700(sb)
                                                                    ;

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 69759, 70170) || true) && (!f_1442_69764_69831(existingValues, resource, f_1442_69798_69830()) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 69763, 69962) && !f_1442_69897_69962(allResources, resource, f_1442_69929_69961())))
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 69759, 70170);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 70084, 70111);

                                                                        f_1442_70084_70110(allResources, resource);
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 69759, 70170);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 69123, 70225);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 68749, 70276);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 68481, 70323);
                                                        }
                                                    }
                                                    catch (System.Exception)
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 1843);
                                                        throw;
                                                    }
                                                    finally
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 1843);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 70371, 70444);

                                                    var
                                                    matchedResults = f_1442_70392_70443(allResources, r => wildcardPattern.IsMatch(r))
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 70490, 70799) || true) && (matchedResults == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 70494, 70541) || !f_1442_70521_70541(matchedResults)))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 70490, 70799);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 70722, 70752);

                                                        matchedResults = allResources;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 70490, 70799);
                                                    }
                                                    try
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 70847, 71646);
                                                        foreach (var resource in f_1442_70872_70886_I(matchedResults))
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 70847, 71646);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 70984, 71075);

                                                            string
                                                            completionText = (DynAbs.Tracing.TraceSender.Conditional_F1(1442, 71008, 71024) || ((isCursorInString && DynAbs.Tracing.TraceSender.Conditional_F2(1442, 71027, 71035)) || DynAbs.Tracing.TraceSender.Conditional_F3(1442, 71038, 71074))) ? resource : stringQuote + resource + stringQuote
                                                            ;

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 71125, 71240) || true) && (hasNewLine)
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 71125, 71240);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 71194, 71240);

                                                                completionText = completionText + stringQuote;
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 71125, 71240);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 71290, 71599);

                                                            f_1442_71290_71598(result, f_1442_71301_71597(completionText, resource, CompletionResultType.Text, resource));
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 70847, 71646);
                                                        }
                                                    }
                                                    catch (System.Exception)
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 800);
                                                        throw;
                                                    }
                                                    finally
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 800);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 68273, 71689);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 68062, 71728);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 67852, 71763);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 66323, 71763);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 62208, 71794);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 62061, 71821);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 61869, 71844);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 61607, 71863);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 61453, 71878);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 71894, 71908);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 60598, 71919);

                System.Management.Automation.Language.Token
                f_1442_60962_60993(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 60962, 60993);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_61088_61117(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 61088, 61117);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_61088_61124(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.Last<System.Management.Automation.Language.Ast>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 61088, 61124);
                    return return_v;
                }


                System.Management.Automation.Language.HashtableAst
                f_1442_61200_61265(System.Management.Automation.Language.Ast
                ast, out System.Management.Automation.Language.Ast
                lastChildOfHashtable)
                {
                    var return_v = Ast.GetAncestorHashtableAst(ast, out lastChildOfHashtable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 61200, 61265);
                    return return_v;
                }


                int
                f_1442_61280_61365(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 61280, 61365);
                    return 0;
                }


                System.Management.Automation.Language.DynamicKeywordStatementAst
                f_1442_61528_61588(System.Management.Automation.Language.HashtableAst
                ast)
                {
                    var return_v = Ast.GetAncestorAst<DynamicKeywordStatementAst>((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 61528, 61588);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_61696_61728(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 61696, 61728);
                    return return_v;
                }


                System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                f_1442_61780_61846(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.Language.IScriptPosition
                cursor, System.Management.Automation.Language.HashtableAst
                hashTableAst, bool
                isCursorInString)
                {
                    var return_v = this_param.GetHashEntryContainsCursor(cursor, hashTableAst, isCursorInString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 61780, 61846);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1442_61975_62003(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 61975, 62003);
                    return return_v;
                }


                System.Management.Automation.Language.DynamicKeyword
                f_1442_62212_62230(System.Management.Automation.Language.DynamicKeywordStatementAst
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 62212, 62230);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
                f_1442_62212_62241(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 62212, 62241);
                    return return_v;
                }


                string
                f_1442_62254_62275(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 62254, 62275);
                    return return_v;
                }


                bool
                f_1442_62212_62290(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
                this_param, string
                key, out System.Management.Automation.Language.DynamicKeywordProperty
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 62212, 62290);
                    return return_v;
                }


                string
                f_1442_62539_62552(System.Management.Automation.Language.DynamicKeywordProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 62539, 62552);
                    return return_v;
                }


                bool
                f_1442_62525_62603(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 62525, 62603);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_62718_62749(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 62718, 62749);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1442_62828_62845(System.Management.Automation.Language.DynamicKeywordProperty
                this_param)
                {
                    var return_v = this_param.ValueMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 62828, 62845);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1442_62857_62874(System.Management.Automation.Language.DynamicKeywordProperty
                this_param)
                {
                    var return_v = this_param.ValueMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 62857, 62874);
                    return return_v;
                }


                int
                f_1442_62857_62880(System.Collections.Generic.Dictionary<string, string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 62857, 62880);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1442_63060_63078()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 63060, 63078);
                    return return_v;
                }


                string
                f_1442_63135_63158(System.Management.Automation.Language.DynamicKeywordProperty
                this_param)
                {
                    var return_v = this_param.TypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 63135, 63158);
                    return return_v;
                }


                bool
                f_1442_63121_63210(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 63121, 63210);
                    return return_v;
                }


                System.Management.Automation.Language.ArrayLiteralAst
                f_1442_63307_63351(System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = Ast.GetAncestorAst<ArrayLiteralAst>(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 63307, 63351);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1442_63418_63435(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 63418, 63435);
                    return return_v;
                }


                int
                f_1442_63418_63441(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 63418, 63441);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1442_63572_63589(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 63572, 63589);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_64127_64144(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 64127, 64144);
                    return return_v;
                }


                bool
                f_1442_64095_64145(System.Management.Automation.Language.IScriptPosition
                cursor, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    var return_v = IsCursorOutsideOfExtent(cursor, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 64095, 64145);
                    return return_v;
                }


                string
                f_1442_64270_64285(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 64270, 64285);
                    return return_v;
                }


                int
                f_1442_64251_64286(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 64251, 64286);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1442_63572_63589_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 63572, 63589);
                    return return_v;
                }


                string
                f_1442_64702_64757(string
                stringToComplete, out bool
                hasNewLine)
                {
                    var return_v = GetFirstLineSubString(stringToComplete, out hasNewLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 64702, 64757);
                    return return_v;
                }


                int
                f_1442_64944_64967(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 64944, 64967);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_65217_65248(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 65217, 65248);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_65364_65395(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 65364, 65395);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_65364_65402(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 65364, 65402);
                    return return_v;
                }


                int
                f_1442_65364_65414(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 65364, 65414);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_65600_65632(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 65600, 65632);
                    return return_v;
                }


                int
                f_1442_65600_65639(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 65600, 65639);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1442_65931_66026(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 65931, 66026);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_66074_66102()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 66074, 66102);
                    return return_v;
                }


                int
                f_1442_66174_66288(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 66174, 66288);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1442_66327_66344(System.Management.Automation.Language.DynamicKeywordProperty
                this_param)
                {
                    var return_v = this_param.ValueMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 66327, 66344);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1442_66356_66373(System.Management.Automation.Language.DynamicKeywordProperty
                this_param)
                {
                    var return_v = this_param.ValueMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 66356, 66373);
                    return return_v;
                }


                int
                f_1442_66356_66379(System.Collections.Generic.Dictionary<string, string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 66356, 66379);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1442_66493_66510(System.Management.Automation.Language.DynamicKeywordProperty
                this_param)
                {
                    var return_v = this_param.ValueMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 66493, 66510);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>.KeyCollection
                f_1442_66493_66515(System.Collections.Generic.Dictionary<string, string>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 66493, 66515);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<string>
                f_1442_66493_66531(System.Collections.Generic.Dictionary<string, string>.KeyCollection
                source, System.Func<string, string>
                keySelector)
                {
                    var return_v = source.OrderBy<string, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 66493, 66531);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1442_66493_66605(System.Linq.IOrderedEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 66493, 66605);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1442_66665_66717(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 66665, 66717);
                    return return_v;
                }


                bool
                f_1442_66787_66807(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Any<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 66787, 66807);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1442_67479_67737(string
                completionText, string
                listItemText, System.Management.Automation.CompletionResultType
                resultType, string
                toolTip)
                {
                    var return_v = new System.Management.Automation.CompletionResult(completionText, listItemText, resultType, toolTip);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 67479, 67737);
                    return return_v;
                }


                int
                f_1442_67468_67738(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Management.Automation.CompletionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 67468, 67738);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1442_67096_67110_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 67096, 67110);
                    return return_v;
                }


                System.Management.Automation.Language.ConfigurationDefinitionAst
                f_1442_67965_68023(System.Management.Automation.Language.DynamicKeywordStatementAst
                ast)
                {
                    var return_v = Ast.GetAncestorAst<ConfigurationDefinitionAst>((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 67965, 68023);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1442_68185_68230(System.Management.Automation.Language.DynamicKeywordStatementAst
                ast)
                {
                    var return_v = Ast.GetAncestorAst<NamedBlockAst>((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 68185, 68230);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1442_68416_68434()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 68416, 68434);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1442_68510_68534(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 68510, 68534);
                    return return_v;
                }


                System.Management.Automation.Language.DynamicKeyword
                f_1442_68938_68963(System.Management.Automation.Language.DynamicKeywordStatementAst
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 68938, 68963);
                    return return_v;
                }


                string
                f_1442_68938_68971(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 68938, 68971);
                    return return_v;
                }


                bool
                f_1442_68924_69017(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 68924, 69017);
                    return return_v;
                }


                string
                f_1442_69149_69178(System.Management.Automation.Language.DynamicKeywordStatementAst
                this_param)
                {
                    var return_v = this_param.ElementName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 69149, 69178);
                    return return_v;
                }


                bool
                f_1442_69128_69179(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 69128, 69179);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1442_69312_69338(string
                value, int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(value, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 69312, 69338);
                    return return_v;
                }


                System.Management.Automation.Language.DynamicKeyword
                f_1442_69407_69432(System.Management.Automation.Language.DynamicKeywordStatementAst
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 69407, 69432);
                    return return_v;
                }


                string
                f_1442_69407_69440(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 69407, 69440);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1442_69397_69441(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 69397, 69441);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1442_69500_69514(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 69500, 69514);
                    return return_v;
                }


                string
                f_1442_69583_69612(System.Management.Automation.Language.DynamicKeywordStatementAst
                this_param)
                {
                    var return_v = this_param.ElementName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 69583, 69612);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1442_69573_69613(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 69573, 69613);
                    return return_v;
                }


                string
                f_1442_69687_69700(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 69687, 69700);
                    return return_v;
                }


                System.StringComparer
                f_1442_69798_69830()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 69798, 69830);
                    return return_v;
                }


                bool
                f_1442_69764_69831(System.Collections.Generic.List<string>
                source, string
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>(value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 69764, 69831);
                    return return_v;
                }


                System.StringComparer
                f_1442_69929_69961()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 69929, 69961);
                    return return_v;
                }


                bool
                f_1442_69897_69962(System.Collections.Generic.List<string>
                source, string
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>(value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 69897, 69962);
                    return return_v;
                }


                int
                f_1442_70084_70110(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 70084, 70110);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1442_68510_68534_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 68510, 68534);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1442_70392_70443(System.Collections.Generic.List<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 70392, 70443);
                    return return_v;
                }


                bool
                f_1442_70521_70541(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Any<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 70521, 70541);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1442_71301_71597(string
                completionText, string
                listItemText, System.Management.Automation.CompletionResultType
                resultType, string
                toolTip)
                {
                    var return_v = new System.Management.Automation.CompletionResult(completionText, listItemText, resultType, toolTip);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 71301, 71597);
                    return return_v;
                }


                int
                f_1442_71290_71598(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Management.Automation.CompletionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 71290, 71598);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1442_70872_70886_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 70872, 70886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 60598, 71919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 60598, 71919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<CompletionResult> GetResultForString(CompletionContext completionContext, ref int replacementIndex, ref int replacementLength, bool isQuotedString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 71931, 77748);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72216, 72252) || true) && (isQuotedString)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 72216, 72252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72238, 72250);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 72216, 72252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72268, 72320);

                var
                tokenAtCursor = f_1442_72288_72319(completionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72334, 72385);

                var
                lastAst = f_1442_72348_72384(f_1442_72348_72377(completionContext))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72401, 72438);

                List<CompletionResult>
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72452, 72516);

                var
                expandableString = lastAst as ExpandableStringExpressionAst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72530, 72590);

                var
                constantString = lastAst as StringConstantExpressionAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72604, 72676) || true) && (constantString == null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 72608, 72658) && expandableString == null))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 72604, 72676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72662, 72674);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 72604, 72676);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72692, 72781);

                string
                strValue = (DynAbs.Tracing.TraceSender.Conditional_F1(1442, 72710, 72732) || ((constantString != null && DynAbs.Tracing.TraceSender.Conditional_F2(1442, 72735, 72755)) || DynAbs.Tracing.TraceSender.Conditional_F3(1442, 72758, 72780))) ? f_1442_72735_72755(constantString) : f_1442_72758_72780(expandableString)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72795, 72921);

                StringConstantType
                strType = (DynAbs.Tracing.TraceSender.Conditional_F1(1442, 72824, 72846) || ((constantString != null && DynAbs.Tracing.TraceSender.Conditional_F2(1442, 72849, 72882)) || DynAbs.Tracing.TraceSender.Conditional_F3(1442, 72885, 72920))) ? f_1442_72849_72882(constantString) : f_1442_72885_72920(expandableString)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72935, 72958);

                string
                subInput = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 72974, 72994);

                bool
                shouldContinue
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73008, 73154);

                result = f_1442_73017_73153(this, completionContext, strValue, ref replacementIndex, ref replacementLength, out shouldContinue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73168, 73290) || true) && (!shouldContinue || (DynAbs.Tracing.TraceSender.Expression_False(1442, 73172, 73227) || (result != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 73192, 73226) && f_1442_73210_73222(result) > 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 73168, 73290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73261, 73275);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 73168, 73290);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73306, 73784) || true) && (strType == StringConstantType.DoubleQuoted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 73306, 73784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73386, 73448);

                    var
                    match = f_1442_73398_73447(strValue, @"(\$[\w\d]+\.[\w\d\*]*)$")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73466, 73769) || true) && (f_1442_73470_73483(match))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 73466, 73769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73525, 73558);

                        subInput = f_1442_73536_73557(f_1442_73536_73551(f_1442_73536_73548(match), 1));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 73466, 73769);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 73466, 73769);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73600, 73769) || true) && (f_1442_73604_73675((match = f_1442_73613_73666(strValue, @"(\[[\w\d\.]+\]::[\w\d\*]*)$"))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 73600, 73769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73717, 73750);

                            subInput = f_1442_73728_73749(f_1442_73728_73743(f_1442_73728_73740(match), 1));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 73600, 73769);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 73466, 73769);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 73306, 73784);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73850, 77707) || true) && (subInput != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 73850, 77707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73904, 73975);

                    int
                    stringStartIndex = f_1442_73927_73974(f_1442_73927_73967(f_1442_73927_73947(tokenAtCursor)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 73993, 74065);

                    int
                    cursorIndexInString = f_1442_74019_74041(_cursorPosition) - stringStartIndex - 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74083, 74186) || true) && (cursorIndexInString >= f_1442_74110_74125(strValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 74083, 74186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74148, 74186);

                        cursorIndexInString = f_1442_74170_74185(strValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 74083, 74186);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74206, 74286);

                    var
                    analysis = f_1442_74221_74285(_ast, _tokens, _cursorPosition, _options)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74304, 74394);

                    var
                    subContext = f_1442_74321_74393(analysis, f_1442_74354_74392(completionContext))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74414, 74452);

                    int
                    subReplaceIndex
                    = default(int),
                    subReplaceLength
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74470, 74572);

                    var
                    subResult = f_1442_74486_74571(analysis, subContext, out subReplaceIndex, out subReplaceLength, true)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74592, 75831) || true) && (subResult != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 74596, 74636) && f_1442_74617_74632(subResult) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 74592, 75831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74678, 74716);

                        result = f_1442_74687_74715();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74738, 74820);

                        replacementIndex = stringStartIndex + 1 + (cursorIndexInString - f_1442_74803_74818(subInput));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74842, 74878);

                        replacementLength = f_1442_74862_74877(subInput);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74900, 74955);

                        string
                        prefix = f_1442_74916_74954(subInput, 0, subReplaceIndex)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 74979, 75812);
                            foreach (CompletionResult entry in f_1442_75014_75023_I(subResult))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 74979, 75812);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 75073, 75127);

                                string
                                completionText = prefix + f_1442_75106_75126(entry)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 75153, 75610) || true) && (f_1442_75157_75173(entry) == CompletionResultType.Property)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 75153, 75610);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 75264, 75353);

                                    completionText = f_1442_75281_75309(TokenKind.DollarParen) + completionText + f_1442_75329_75352(TokenKind.RParen);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 75153, 75610);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 75153, 75610);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 75411, 75610) || true) && (f_1442_75415_75431(entry) == CompletionResultType.Method)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 75411, 75610);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 75520, 75583);

                                        completionText = f_1442_75537_75565(TokenKind.DollarParen) + completionText;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 75411, 75610);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 75153, 75610);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 75638, 75661);

                                completionText += "\"";
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 75687, 75789);

                                f_1442_75687_75788(result, f_1442_75698_75787(completionText, f_1442_75735_75753(entry), f_1442_75755_75771(entry), f_1442_75773_75786(entry)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 74979, 75812);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 834);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 834);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 74592, 75831);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 73850, 77707);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 73850, 77707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 75897, 75950);

                    var
                    commandElementAst = lastAst as CommandElementAst
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 75968, 76117);

                    string
                    wordToComplete =
                    f_1442_76013_76116(commandElementAst, string.Empty, completionContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 76137, 77692) || true) && (wordToComplete != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 76137, 77692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 76205, 76255);

                        completionContext.WordToComplete = wordToComplete;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 76356, 77673) || true) && (f_1442_76360_76374(lastAst) is CommandAst || (DynAbs.Tracing.TraceSender.Expression_False(1442, 76360, 76429) || f_1442_76392_76406(lastAst) is CommandParameterAst))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 76356, 77673);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 76479, 76552);

                            result = f_1442_76488_76551(completionContext);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 76578, 76632);

                            replacementIndex = f_1442_76597_76631(completionContext);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 76658, 76714);

                            replacementLength = f_1442_76678_76713(completionContext);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 76356, 77673);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 76356, 77673);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 77018, 77112);

                            result = f_1442_77027_77111(f_1442_77054_77110(completionContext));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 77226, 77650) || true) && (f_1442_77230_77257(wordToComplete, '-') != -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 77226, 77650);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 77321, 77401);

                                var
                                commandNameResult = f_1442_77345_77400(completionContext)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 77431, 77623) || true) && (commandNameResult != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 77435, 77491) && f_1442_77464_77487(commandNameResult) > 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 77431, 77623);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 77557, 77592);

                                    f_1442_77557_77591(result, commandNameResult);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 77431, 77623);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 77226, 77650);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 76356, 77673);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 76137, 77692);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 73850, 77707);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 77723, 77737);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 71931, 77748);

                System.Management.Automation.Language.Token
                f_1442_72288_72319(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 72288, 72319);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_72348_72377(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 72348, 72377);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_72348_72384(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.Last<System.Management.Automation.Language.Ast>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 72348, 72384);
                    return return_v;
                }


                string
                f_1442_72735_72755(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 72735, 72755);
                    return return_v;
                }


                string
                f_1442_72758_72780(System.Management.Automation.Language.ExpandableStringExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 72758, 72780);
                    return return_v;
                }


                System.Management.Automation.Language.StringConstantType
                f_1442_72849_72882(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.StringConstantType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 72849, 72882);
                    return return_v;
                }


                System.Management.Automation.Language.StringConstantType
                f_1442_72885_72920(System.Management.Automation.Language.ExpandableStringExpressionAst
                this_param)
                {
                    var return_v = this_param.StringConstantType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 72885, 72920);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_73017_73153(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, string
                stringToComplete, ref int
                replacementIndex, ref int
                replacementLength, out bool
                shouldContinue)
                {
                    var return_v = this_param.GetResultForEnumPropertyValueOfDSCResource(completionContext, stringToComplete, ref replacementIndex, ref replacementLength, out shouldContinue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 73017, 73153);
                    return return_v;
                }


                int
                f_1442_73210_73222(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73210, 73222);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1442_73398_73447(string
                input, string
                pattern)
                {
                    var return_v = Regex.Match(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 73398, 73447);
                    return return_v;
                }


                bool
                f_1442_73470_73483(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73470, 73483);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1442_73536_73548(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73536, 73548);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1442_73536_73551(System.Text.RegularExpressions.GroupCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73536, 73551);
                    return return_v;
                }


                string
                f_1442_73536_73557(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73536, 73557);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1442_73613_73666(string
                input, string
                pattern)
                {
                    var return_v = Regex.Match(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 73613, 73666);
                    return return_v;
                }


                bool
                f_1442_73604_73675(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73604, 73675);
                    return return_v;
                }


                System.Text.RegularExpressions.GroupCollection
                f_1442_73728_73740(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73728, 73740);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_1442_73728_73743(System.Text.RegularExpressions.GroupCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73728, 73743);
                    return return_v;
                }


                string
                f_1442_73728_73749(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73728, 73749);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_73927_73947(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73927, 73947);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_73927_73967(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73927, 73967);
                    return return_v;
                }


                int
                f_1442_73927_73974(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 73927, 73974);
                    return return_v;
                }


                int
                f_1442_74019_74041(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 74019, 74041);
                    return return_v;
                }


                int
                f_1442_74110_74125(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 74110, 74125);
                    return return_v;
                }


                int
                f_1442_74170_74185(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 74170, 74185);
                    return return_v;
                }


                System.Management.Automation.CompletionAnalysis
                f_1442_74221_74285(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.Language.Token[]
                tokens, System.Management.Automation.Language.IScriptPosition
                cursorPosition, System.Collections.Hashtable
                options)
                {
                    var return_v = new System.Management.Automation.CompletionAnalysis(ast, tokens, cursorPosition, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 74221, 74285);
                    return return_v;
                }


                System.Management.Automation.TypeInferenceContext
                f_1442_74354_74392(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TypeInferenceContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 74354, 74392);
                    return return_v;
                }


                System.Management.Automation.CompletionContext
                f_1442_74321_74393(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.TypeInferenceContext
                typeInferenceContext)
                {
                    var return_v = this_param.CreateCompletionContext(typeInferenceContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 74321, 74393);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_74486_74571(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, out int
                replacementIndex, out int
                replacementLength, bool
                isQuotedString)
                {
                    var return_v = this_param.GetResultHelper(completionContext, out replacementIndex, out replacementLength, isQuotedString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 74486, 74571);
                    return return_v;
                }


                int
                f_1442_74617_74632(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 74617, 74632);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_74687_74715()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 74687, 74715);
                    return return_v;
                }


                int
                f_1442_74803_74818(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 74803, 74818);
                    return return_v;
                }


                int
                f_1442_74862_74877(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 74862, 74877);
                    return return_v;
                }


                string
                f_1442_74916_74954(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 74916, 74954);
                    return return_v;
                }


                string
                f_1442_75106_75126(System.Management.Automation.CompletionResult
                this_param)
                {
                    var return_v = this_param.CompletionText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 75106, 75126);
                    return return_v;
                }


                System.Management.Automation.CompletionResultType
                f_1442_75157_75173(System.Management.Automation.CompletionResult
                this_param)
                {
                    var return_v = this_param.ResultType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 75157, 75173);
                    return return_v;
                }


                string
                f_1442_75281_75309(System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = kind.Text();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 75281, 75309);
                    return return_v;
                }


                string
                f_1442_75329_75352(System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = kind.Text();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 75329, 75352);
                    return return_v;
                }


                System.Management.Automation.CompletionResultType
                f_1442_75415_75431(System.Management.Automation.CompletionResult
                this_param)
                {
                    var return_v = this_param.ResultType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 75415, 75431);
                    return return_v;
                }


                string
                f_1442_75537_75565(System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = kind.Text();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 75537, 75565);
                    return return_v;
                }


                string
                f_1442_75735_75753(System.Management.Automation.CompletionResult
                this_param)
                {
                    var return_v = this_param.ListItemText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 75735, 75753);
                    return return_v;
                }


                System.Management.Automation.CompletionResultType
                f_1442_75755_75771(System.Management.Automation.CompletionResult
                this_param)
                {
                    var return_v = this_param.ResultType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 75755, 75771);
                    return return_v;
                }


                string
                f_1442_75773_75786(System.Management.Automation.CompletionResult
                this_param)
                {
                    var return_v = this_param.ToolTip;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 75773, 75786);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1442_75698_75787(string
                completionText, string
                listItemText, System.Management.Automation.CompletionResultType
                resultType, string
                toolTip)
                {
                    var return_v = new System.Management.Automation.CompletionResult(completionText, listItemText, resultType, toolTip);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 75698, 75787);
                    return return_v;
                }


                int
                f_1442_75687_75788(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Management.Automation.CompletionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 75687, 75788);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_75014_75023_I(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 75014, 75023);
                    return return_v;
                }


                string
                f_1442_76013_76116(System.Management.Automation.Language.CommandElementAst
                stringAst, string
                partialPath, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = CompletionCompleters.ConcatenateStringPathArguments(stringAst, partialPath, completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 76013, 76116);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_76360_76374(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 76360, 76374);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_76392_76406(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 76392, 76406);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_76488_76551(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommandArgument(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 76488, 76551);
                    return return_v;
                }


                int
                f_1442_76597_76631(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ReplacementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 76597, 76631);
                    return return_v;
                }


                int
                f_1442_76678_76713(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ReplacementLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 76678, 76713);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                f_1442_77054_77110(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteFilename(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 77054, 77110);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_77027_77111(System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 77027, 77111);
                    return return_v;
                }


                int
                f_1442_77230_77257(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 77230, 77257);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_77345_77400(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommand(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 77345, 77400);
                    return return_v;
                }


                int
                f_1442_77464_77487(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 77464, 77487);
                    return return_v;
                }


                int
                f_1442_77557_77591(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 77557, 77591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 71931, 77748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 71931, 77748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConfigurationDefinitionAst GetAncestorConfigurationAstAndKeywordAst(
                    IScriptPosition cursorPosition,
                    Ast ast,
                    out DynamicKeywordStatementAst keywordAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 78049, 79008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 78273, 78407);

                ConfigurationDefinitionAst
                configureAst = f_1442_78315_78406(ast, out keywordAst)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 78745, 78961) || true) && (configureAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 78752, 78829) && f_1442_78776_78797(cursorPosition) > f_1442_78800_78829(f_1442_78800_78819(configureAst))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 78745, 78961);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 78863, 78946);

                        configureAst = f_1442_78878_78945(f_1442_78925_78944(configureAst));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 78745, 78961);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 78745, 78961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 78745, 78961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 78977, 78997);

                return configureAst;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 78049, 79008);

                System.Management.Automation.Language.ConfigurationDefinitionAst
                f_1442_78315_78406(System.Management.Automation.Language.Ast
                ast, out System.Management.Automation.Language.DynamicKeywordStatementAst
                keywordAst)
                {
                    var return_v = Ast.GetAncestorConfigurationDefinitionAstAndDynamicKeywordStatementAst(ast, out keywordAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 78315, 78406);
                    return return_v;
                }


                int
                f_1442_78776_78797(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 78776, 78797);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_78800_78819(System.Management.Automation.Language.ConfigurationDefinitionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 78800, 78819);
                    return return_v;
                }


                int
                f_1442_78800_78829(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 78800, 78829);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_78925_78944(System.Management.Automation.Language.ConfigurationDefinitionAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 78925, 78944);
                    return return_v;
                }


                System.Management.Automation.Language.ConfigurationDefinitionAst
                f_1442_78878_78945(System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = Ast.GetAncestorAst<ConfigurationDefinitionAst>(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 78878, 78945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 78049, 79008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 78049, 79008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<CompletionResult> GetResultForIdentifierInConfiguration(
                    CompletionContext completionContext,
                    ConfigurationDefinitionAst configureAst,
                    DynamicKeywordStatementAst keywordAst,
                    out bool matched)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 79767, 82422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 80048, 80086);

                List<CompletionResult>
                results = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 80100, 80116);

                matched = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 80132, 80762);

                IEnumerable<DynamicKeyword>
                keywords = f_1442_80171_80761(f_1442_80171_80199(configureAst), k => // Node is special case, legal in both Resource and Meta configuration
                                    string.Compare(k.Keyword, @"Node", StringComparison.OrdinalIgnoreCase) == 0 ||
                                    (
                                        // Check compatibility between Resource and Configuration Type
                                        k.IsCompatibleWithConfigurationType(configureAst.ConfigurationType) &&
                                        !DynamicKeyword.IsHiddenKeyword(k.Keyword) &&
                                        !k.IsReservedKeyword
                                    ))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 80778, 80951) || true) && (keywordAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 80782, 80873) && f_1442_80804_80843(f_1442_80804_80836(completionContext)) < f_1442_80846_80873(f_1442_80846_80863(keywordAst))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 80778, 80951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 80892, 80951);

                    keywords = f_1442_80903_80950(f_1442_80903_80921(keywordAst), keywords);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 80778, 80951);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 80967, 82380) || true) && (keywords != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 80971, 81005) && f_1442_80991_81005(keywords)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 80967, 82380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 81039, 81117);

                    string
                    commandName = (f_1442_81061_81093(completionContext) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1442, 81061, 81109) ?? string.Empty)) + "*"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 81135, 81253);

                    var
                    wildcardPattern = f_1442_81157_81252(commandName, WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 81308, 81385);

                    var
                    matchedResults = f_1442_81329_81384(keywords, k => wildcardPattern.IsMatch(k.Keyword))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 81403, 81724) || true) && (matchedResults == null || (DynAbs.Tracing.TraceSender.Expression_False(1442, 81407, 81454) || !f_1442_81434_81454(matchedResults)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 81403, 81724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 81582, 81608);

                        matchedResults = keywords;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 81403, 81724);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 81403, 81724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 81690, 81705);

                        matched = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 81403, 81724);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 81744, 82365);
                        foreach (var keyword in f_1442_81768_81782_I(matchedResults))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 81744, 82365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 81824, 81950);

                            string
                            usageString = f_1442_81845_81949(keyword)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 81972, 82103) || true) && (results == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 81972, 82103);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 82041, 82080);

                                results = f_1442_82051_82079();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 81972, 82103);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 82127, 82346);

                            f_1442_82127_82345(
                                                results, f_1442_82139_82344(f_1442_82186_82201(keyword), f_1442_82228_82243(keyword), CompletionResultType.DynamicKeyword, usageString));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 81744, 82365);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 622);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 622);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 80967, 82380);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 82396, 82411);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 79767, 82422);

                System.Collections.Generic.List<System.Management.Automation.Language.DynamicKeyword>
                f_1442_80171_80199(System.Management.Automation.Language.ConfigurationDefinitionAst
                this_param)
                {
                    var return_v = this_param.DefinedKeywords;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 80171, 80199);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                f_1442_80171_80761(System.Collections.Generic.List<System.Management.Automation.Language.DynamicKeyword>
                source, System.Func<System.Management.Automation.Language.DynamicKeyword, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.Language.DynamicKeyword>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 80171, 80761);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_80804_80836(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 80804, 80836);
                    return return_v;
                }


                int
                f_1442_80804_80843(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 80804, 80843);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_80846_80863(System.Management.Automation.Language.DynamicKeywordStatementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 80846, 80863);
                    return return_v;
                }


                int
                f_1442_80846_80873(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 80846, 80873);
                    return return_v;
                }


                System.Management.Automation.Language.DynamicKeyword
                f_1442_80903_80921(System.Management.Automation.Language.DynamicKeywordStatementAst
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 80903, 80921);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                f_1442_80903_80950(System.Management.Automation.Language.DynamicKeyword
                keyword, System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                allowedKeywords)
                {
                    var return_v = keyword.GetAllowedKeywords(allowedKeywords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 80903, 80950);
                    return return_v;
                }


                bool
                f_1442_80991_81005(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.Language.DynamicKeyword>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 80991, 81005);
                    return return_v;
                }


                string
                f_1442_81061_81093(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.WordToComplete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 81061, 81093);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1442_81157_81252(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 81157, 81252);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                f_1442_81329_81384(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                source, System.Func<System.Management.Automation.Language.DynamicKeyword, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.Language.DynamicKeyword>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 81329, 81384);
                    return return_v;
                }


                bool
                f_1442_81434_81454(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.Language.DynamicKeyword>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 81434, 81454);
                    return return_v;
                }


                string
                f_1442_81845_81949(System.Management.Automation.Language.DynamicKeyword
                keyword)
                {
                    var return_v = Microsoft.PowerShell.DesiredStateConfiguration.Internal.DscClassCache.GetDSCResourceUsageString(keyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 81845, 81949);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_82051_82079()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 82051, 82079);
                    return return_v;
                }


                string
                f_1442_82186_82201(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 82186, 82201);
                    return return_v;
                }


                string
                f_1442_82228_82243(System.Management.Automation.Language.DynamicKeyword
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 82228, 82243);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1442_82139_82344(string
                completionText, string
                listItemText, System.Management.Automation.CompletionResultType
                resultType, string
                toolTip)
                {
                    var return_v = new System.Management.Automation.CompletionResult(completionText, listItemText, resultType, toolTip);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 82139, 82344);
                    return return_v;
                }


                int
                f_1442_82127_82345(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Management.Automation.CompletionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 82127, 82345);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                f_1442_81768_81782_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.DynamicKeyword>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 81768, 81782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 79767, 82422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 79767, 82422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<CompletionResult> GetResultForIdentifier(CompletionContext completionContext, ref int replacementIndex, ref int replacementLength, bool isQuotedString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 82434, 101548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 82623, 82675);

                var
                tokenAtCursor = f_1442_82643_82674(completionContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 82689, 82740);

                var
                lastAst = f_1442_82703_82739(f_1442_82703_82732(completionContext))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 82756, 82793);

                List<CompletionResult>
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 82807, 82850);

                var
                tokenAtCursorText = f_1442_82831_82849(tokenAtCursor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 82864, 82917);

                completionContext.WordToComplete = tokenAtCursorText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 82933, 82987);

                var
                strConst = lastAst as StringConstantExpressionAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 83001, 86187) || true) && (strConst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 83001, 86187);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 83055, 86172) || true) && (f_1442_83059_83111(f_1442_83059_83073(strConst), "$", StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 83055, 86172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 83153, 83201);

                        completionContext.WordToComplete = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 83223, 83287);

                        return f_1442_83230_83286(completionContext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 83055, 86172);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 83055, 86172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 83369, 83437);

                        UsingStatementAst
                        usingState = f_1442_83400_83415(strConst) as UsingStatementAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 83459, 86153) || true) && (usingState != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 83459, 86153);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 83531, 83596);

                            completionContext.ReplacementIndex = f_1442_83568_83595(f_1442_83568_83583(strConst));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 83622, 83705);

                            completionContext.ReplacementLength = f_1442_83660_83685(f_1442_83660_83675(strConst)) - replacementIndex;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 83731, 83787);

                            completionContext.WordToComplete = f_1442_83766_83786(f_1442_83766_83781(strConst));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 83813, 86130);

                            switch (f_1442_83821_83850(usingState))
                            {

                                case UsingStatementKind.Assembly:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 83813, 86130);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1442, 83975, 83981);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 83813, 86130);

                                case UsingStatementKind.Command:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 83813, 86130);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1442, 84077, 84083);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 83813, 86130);

                                case UsingStatementKind.Module:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 83813, 86130);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 84178, 84831);

                                    var
                                    moduleExtensions = new HashSet<string>(f_1442_84221_84253())
                                                                    {
                                    DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => StringLiterals.PowerShellModuleFileExtension,1442,84201,84830),                                    StringLiterals.PowerShellDataFileExtension,                                    StringLiterals.PowerShellNgenAssemblyExtension,                                    StringLiterals.PowerShellILAssemblyExtension,                                    StringLiterals.PowerShellILExecutableExtension,                                    StringLiterals.PowerShellCmdletizationFileExtension
                                                                    }
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 84865, 84965);

                                    result = f_1442_84874_84964(f_1442_84874_84955(completionContext, false, moduleExtensions));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 84999, 85333) || true) && (f_1442_85003_85081(f_1442_85003_85035(completionContext), Utils.Separators.DirectoryOrDrive) != -1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 84999, 85333);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 85284, 85298);

                                        return result;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 84999, 85333);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 85369, 85455);

                                    var
                                    moduleResults = f_1442_85389_85454(completionContext, false)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 85489, 85611) || true) && (moduleResults != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 85493, 85541) && f_1442_85518_85537(moduleResults) > 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 85489, 85611);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 85580, 85611);

                                        f_1442_85580_85610(result, moduleResults);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 85489, 85611);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 85645, 85659);

                                    return result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 83813, 86130);

                                case UsingStatementKind.Namespace:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 83813, 86130);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 85757, 85824);

                                    result = f_1442_85766_85823(completionContext);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 85858, 85872);

                                    return result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 83813, 86130);

                                case UsingStatementKind.Type:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 83813, 86130);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1442, 85965, 85971);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 83813, 86130);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 83813, 86130);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86043, 86103);

                                    throw f_1442_86049_86102("UsingStatementKind");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 83813, 86130);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 83459, 86153);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 83055, 86172);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 83001, 86187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86203, 86306);

                result = f_1442_86212_86305(this, completionContext, ref replacementIndex, ref replacementLength);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86320, 86354) || true) && (result != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 86320, 86354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86340, 86354);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 86320, 86354);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86370, 93398) || true) && ((f_1442_86375_86399(tokenAtCursor) & TokenFlags.CommandName) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 86370, 93398);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86553, 90244) || true) && (f_1442_86557_86592(f_1442_86557_86586(completionContext)) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1442, 86557, 86650) && f_1442_86600_86632(f_1442_86600_86629(completionContext), 0) is ScriptBlockAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 86553, 90244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86692, 86713);

                        Ast
                        cursorAst = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86735, 86796);

                        var
                        cursorPosition = (InternalScriptPosition)_cursorPosition
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86818, 86893);

                        int
                        offsetBeforeCmdName = f_1442_86844_86865(cursorPosition) - f_1442_86868_86892(tokenAtCursorText)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86915, 87287) || true) && (offsetBeforeCmdName >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 86915, 87287);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 86993, 87074);

                            var
                            cursorBeforeCmdName = f_1442_87019_87073(cursorPosition, offsetBeforeCmdName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 87100, 87170);

                            var
                            scriptBlockAst = (ScriptBlockAst)f_1442_87137_87169(f_1442_87137_87166(completionContext), 0)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 87196, 87264);

                            cursorAst = f_1442_87208_87263(scriptBlockAst, cursorBeforeCmdName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 86915, 87287);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 87311, 90225) || true) && (cursorAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 87315, 87431) && f_1442_87361_87391(f_1442_87361_87377(cursorAst)) == f_1442_87395_87431(f_1442_87395_87415(tokenAtCursor))) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 87315, 87534) && f_1442_87460_87492(f_1442_87460_87476(cursorAst)) == f_1442_87496_87534(f_1442_87496_87516(tokenAtCursor))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 87311, 90225);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 87584, 90202) || true) && (f_1442_87588_87644(tokenAtCursorText, Utils.Separators.Directory) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 87584, 90202);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 87707, 87886);

                                string
                                wordToComplete =
                                f_1442_87764_87885(cursorAst as CommandElementAst, tokenAtCursorText, completionContext)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 87916, 89846) || true) && (wordToComplete != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 87916, 89846);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 88008, 88058);

                                    completionContext.WordToComplete = wordToComplete;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 88092, 88186);

                                    result = f_1442_88101_88185(f_1442_88128_88184(completionContext));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 88220, 88500) || true) && (f_1442_88224_88236(result) > 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 88220, 88500);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 88314, 88377);

                                        replacementIndex = f_1442_88333_88376(f_1442_88333_88369(f_1442_88333_88349(cursorAst)));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 88415, 88465);

                                        replacementLength += f_1442_88436_88464(f_1442_88436_88457(f_1442_88436_88452(cursorAst)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 88220, 88500);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 88536, 88550);

                                    return result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 87916, 89846);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 87916, 89846);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 88680, 88733);

                                    var
                                    variableAst = cursorAst as VariableExpressionAst
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 88767, 89174);

                                    string
                                    fullPath = (DynAbs.Tracing.TraceSender.Conditional_F1(1442, 88785, 88804) || ((variableAst != null
                                    && DynAbs.Tracing.TraceSender.Conditional_F2(1442, 88844, 89129)) || DynAbs.Tracing.TraceSender.Conditional_F3(1442, 89169, 89173))) ? f_1442_88844_89129(variableAst: variableAst, extraText: tokenAtCursorText, executionContext: f_1442_89094_89128(completionContext)) : null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 89210, 89250) || true) && (fullPath == null)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 89210, 89250);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 89234, 89248);

                                        return result;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 89210, 89250);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 89410, 89454);

                                    completionContext.WordToComplete = fullPath;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 89488, 89551);

                                    replacementIndex = f_1442_89507_89550(f_1442_89507_89543(f_1442_89507_89523(cursorAst)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 89585, 89635);

                                    replacementLength += f_1442_89606_89634(f_1442_89606_89627(f_1442_89606_89622(cursorAst)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 89671, 89725);

                                    completionContext.ReplacementIndex = replacementIndex;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 89759, 89815);

                                    completionContext.ReplacementLength = replacementLength;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 87916, 89846);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 87584, 90202);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 87584, 90202);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 90023, 90202) || true) && (!(cursorAst is ErrorExpressionAst && (DynAbs.Tracing.TraceSender.Expression_True(1442, 90029, 90102) && f_1442_90064_90080(cursorAst) is IndexExpressionAst)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 90023, 90202);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 90161, 90175);

                                    return result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 90023, 90202);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 87584, 90202);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 87311, 90225);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 86553, 90244);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 90368, 90406) || true) && (isQuotedString)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 90368, 90406);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 90390, 90404);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 90368, 90406);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 90480, 90534);

                    var
                    strToken = tokenAtCursor as StringExpandableToken
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 90552, 91775) || true) && (strToken != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 90556, 90605) && f_1442_90576_90597(strToken) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 90556, 90625) && strConst != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 90552, 91775);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 90719, 90748);

                            string
                            expandedString = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 90774, 90896);

                            var
                            expandableStringAst = f_1442_90800_90895(f_1442_90834_90849(strConst), f_1442_90851_90865(strConst), StringConstantType.BareWord)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 90922, 91608) || true) && (f_1442_90926_91345(expandableStringAst: expandableStringAst, extraText: string.Empty, executionContext: f_1442_91201_91235(completionContext), expandedString: out expandedString))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 90922, 91608);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 91403, 91453);

                                completionContext.WordToComplete = expandedString;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 90922, 91608);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 90922, 91608);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 91567, 91581);

                                return result;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 90922, 91608);
                            }
                        }
                        catch (Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1442, 91653, 91756);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 91719, 91733);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1442, 91653, 91756);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 90552, 91775);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 91911, 91949);

                    DynamicKeywordStatementAst
                    keywordAst
                    = default(DynamicKeywordStatementAst);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 91967, 92109);

                    ConfigurationDefinitionAst
                    configureAst = f_1442_92009_92108(this, f_1442_92050_92082(completionContext), lastAst, out keywordAst)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 92127, 92148);

                    bool
                    matched = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 92166, 92210);

                    List<CompletionResult>
                    keywordResult = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 92228, 92530) || true) && (configureAst != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 92228, 92530);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 92399, 92511);

                        keywordResult = f_1442_92415_92510(this, completionContext, configureAst, keywordAst, out matched);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 92228, 92530);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 92628, 92682);

                    result = f_1442_92637_92681(completionContext);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 92755, 92835);

                    var
                    commandNameResult = f_1442_92779_92834(completionContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 92855, 93011) || true) && (commandNameResult != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 92859, 92915) && f_1442_92888_92911(commandNameResult) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 92855, 93011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 92957, 92992);

                        f_1442_92957_92991(result, commandNameResult);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 92855, 93011);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 93031, 93349) || true) && (matched && (DynAbs.Tracing.TraceSender.Expression_True(1442, 93035, 93067) && keywordResult != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 93031, 93349);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 93109, 93146);

                        f_1442_93109_93145(result, 0, keywordResult);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 93031, 93349);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 93031, 93349);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 93188, 93349) || true) && (!matched && (DynAbs.Tracing.TraceSender.Expression_True(1442, 93192, 93225) && keywordResult != null) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 93192, 93257) && f_1442_93229_93252(commandNameResult) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 93188, 93349);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 93299, 93330);

                            f_1442_93299_93329(result, keywordResult);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 93188, 93349);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 93031, 93349);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 93369, 93383);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 86370, 93398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 93414, 93496);

                var
                isSingleDash = f_1442_93433_93457(tokenAtCursorText) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1442, 93433, 93495) && f_1442_93466_93495(f_1442_93466_93486(tokenAtCursorText, 0)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 93510, 93625);

                var
                isDoubleDash = f_1442_93529_93553(tokenAtCursorText) == 2 && (DynAbs.Tracing.TraceSender.Expression_True(1442, 93529, 93591) && f_1442_93562_93591(f_1442_93562_93582(tokenAtCursorText, 0))) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 93529, 93624) && f_1442_93595_93624(f_1442_93595_93615(tokenAtCursorText, 1)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 93639, 93756);

                var
                isParentCommandOrDynamicKeyword = (f_1442_93678_93692(lastAst) is CommandAst || (DynAbs.Tracing.TraceSender.Expression_False(1442, 93678, 93754) || f_1442_93710_93724(lastAst) is DynamicKeywordStatementAst))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 93770, 94421) || true) && ((isSingleDash || (DynAbs.Tracing.TraceSender.Expression_False(1442, 93775, 93803) || isDoubleDash)) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 93774, 93839) && isParentCommandOrDynamicKeyword))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 93770, 94421);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 93977, 94315) || true) && (isSingleDash)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 93977, 94315);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94035, 94073) || true) && (isQuotedString)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 94035, 94073);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94057, 94071);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 94035, 94073);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94097, 94172);

                        var
                        res = f_1442_94107_94171(completionContext)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94194, 94296) || true) && (f_1442_94198_94207(res) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 94194, 94296);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94262, 94273);

                            return res;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 94194, 94296);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 93977, 94315);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94335, 94406);

                    return f_1442_94342_94405(completionContext);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 93770, 94421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94437, 94482);

                TokenKind
                memberOperator = TokenKind.Unknown
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94496, 94562);

                bool
                isMemberCompletion = (f_1442_94523_94537(lastAst) is MemberExpressionAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94576, 94659);

                bool
                isStatic = isMemberCompletion && (DynAbs.Tracing.TraceSender.Expression_True(1442, 94592, 94658) && f_1442_94614_94658(((MemberExpressionAst)f_1442_94636_94650(lastAst))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94673, 94697);

                bool
                isWildcard = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 94713, 97303) || true) && (!isMemberCompletion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 94713, 97303);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 95045, 97288) || true) && (f_1442_95049_95121(tokenAtCursorText, f_1442_95074_95094(TokenKind.Dot), StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 95045, 97288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 95163, 95194);

                        memberOperator = TokenKind.Dot;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 95216, 95242);

                        isMemberCompletion = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 95045, 97288);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 95045, 97288);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 95284, 97288) || true) && (f_1442_95288_95367(tokenAtCursorText, f_1442_95313_95340(TokenKind.ColonColon), StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 95284, 97288);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 95409, 95447);

                            memberOperator = TokenKind.ColonColon;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 95469, 95495);

                            isMemberCompletion = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 95284, 97288);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 95284, 97288);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 95537, 97288) || true) && (f_1442_95541_95586(f_1442_95541_95559(tokenAtCursor), TokenKind.Multiply) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 95541, 95620) && lastAst is BinaryExpressionAst))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 95537, 97288);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 95756, 95811);

                                var
                                binaryExpressionAst = (BinaryExpressionAst)lastAst
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 95833, 95907);

                                var
                                memberExpressionAst = f_1442_95859_95883(binaryExpressionAst) as MemberExpressionAst
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 95929, 95983);

                                var
                                errorPosition = f_1442_95949_95982(binaryExpressionAst)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 96007, 97269) || true) && (memberExpressionAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 96011, 96092) && f_1442_96042_96070(binaryExpressionAst) == TokenKind.Multiply) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 96011, 96193) && f_1442_96121_96146(errorPosition) == f_1442_96150_96193(f_1442_96150_96183(f_1442_96150_96176(memberExpressionAst)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 96007, 97269);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 96243, 96281);

                                    isStatic = f_1442_96254_96280(memberExpressionAst);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 96307, 96372);

                                    memberOperator = (DynAbs.Tracing.TraceSender.Conditional_F1(1442, 96324, 96332) || ((isStatic && DynAbs.Tracing.TraceSender.Conditional_F2(1442, 96335, 96355)) || DynAbs.Tracing.TraceSender.Conditional_F3(1442, 96358, 96371))) ? TokenKind.ColonColon : TokenKind.Dot;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 96398, 96424);

                                    isMemberCompletion = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 96450, 96468);

                                    isWildcard = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 96730, 96788);

                                    f_1442_96730_96787(f_1442_96730_96759(completionContext), binaryExpressionAst);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 96814, 96869);

                                    f_1442_96814_96868(f_1442_96814_96843(completionContext), memberExpressionAst);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 96897, 96971);

                                    var
                                    memberAst = f_1442_96913_96939(memberExpressionAst) as StringConstantExpressionAst
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 96997, 97246) || true) && (memberAst != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 96997, 97246);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 97076, 97139);

                                        replacementIndex = f_1442_97095_97138(f_1442_97095_97131(f_1442_97095_97111(memberAst)));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 97169, 97219);

                                        replacementLength += f_1442_97190_97218(f_1442_97190_97211(f_1442_97190_97206(memberAst)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 96997, 97246);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 96007, 97269);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 95537, 97288);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 95284, 97288);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 95045, 97288);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 94713, 97303);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 97319, 98132) || true) && (isMemberCompletion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 97319, 98132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 97375, 97502);

                    result = f_1442_97384_97501(completionContext, @static: (isStatic || (DynAbs.Tracing.TraceSender.Expression_False(1442, 97449, 97499) || memberOperator == TokenKind.ColonColon)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 97782, 98117) || true) && (f_1442_97786_97798(result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 97782, 98117);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 97840, 98060) || true) && (!isWildcard && (DynAbs.Tracing.TraceSender.Expression_True(1442, 97844, 97894) && memberOperator != TokenKind.Unknown))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 97840, 98060);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 97944, 97989);

                            replacementIndex += f_1442_97964_97988(tokenAtCursorText);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98015, 98037);

                            replacementLength = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 97840, 98060);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98084, 98098);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 97782, 98117);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 97319, 98132);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98148, 98458) || true) && (f_1442_98152_98166(lastAst) is HashtableAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 98148, 98458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98216, 98316);

                    result = f_1442_98225_98315(completionContext, f_1442_98300_98314(lastAst));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98334, 98443) || true) && (result != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 98338, 98368) && f_1442_98356_98368(result)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 98334, 98443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98410, 98424);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 98334, 98443);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 98148, 98458);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98574, 98612) || true) && (isQuotedString)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 98574, 98612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98596, 98610);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 98574, 98612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98628, 98660);

                bool
                needFileCompletion = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98674, 100722) || true) && (f_1442_98678_98692(lastAst) is FileRedirectionAst || (DynAbs.Tracing.TraceSender.Expression_False(1442, 98678, 98789) || f_1442_98718_98789(lastAst, f_1442_98753_98788(completionContext))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 98674, 100722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 98823, 98983);

                    string
                    wordToComplete =
                    f_1442_98868_98982(lastAst as CommandElementAst, string.Empty, completionContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 99001, 99186) || true) && (wordToComplete != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 99001, 99186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 99069, 99095);

                        needFileCompletion = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 99117, 99167);

                        completionContext.WordToComplete = wordToComplete;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 99001, 99186);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 98674, 100722);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 98674, 100722);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 99220, 100722) || true) && (f_1442_99224_99280(tokenAtCursorText, Utils.Separators.Directory) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 99220, 100722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 99319, 99366);

                        var
                        command = f_1442_99333_99347(lastAst) as CommandBaseAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 99384, 100707) || true) && (command != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 99388, 99433) && f_1442_99407_99433(f_1442_99407_99427(command))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 99384, 100707);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 99475, 99543);

                            var
                            fileRedirection = f_1442_99497_99520(f_1442_99497_99517(command), 0) as FileRedirectionAst
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 99565, 100688) || true) && (fileRedirection != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 99569, 99691) && f_1442_99621_99657(f_1442_99621_99643(fileRedirection)) == f_1442_99661_99691(f_1442_99661_99675(lastAst))) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 99569, 99794) && f_1442_99720_99758(f_1442_99720_99742(fileRedirection)) == f_1442_99762_99794(f_1442_99762_99776(lastAst))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 99565, 100688);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 99844, 100013);

                                string
                                wordToComplete =
                                f_1442_99897_100012(f_1442_99949_99973(fileRedirection), tokenAtCursorText, completionContext)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 100041, 100665) || true) && (wordToComplete != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 100041, 100665);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 100125, 100151);

                                    needFileCompletion = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 100181, 100231);

                                    completionContext.WordToComplete = wordToComplete;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 100261, 100339);

                                    replacementIndex = f_1442_100280_100338(f_1442_100280_100331(f_1442_100280_100311(f_1442_100280_100304(fileRedirection))));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 100369, 100466);

                                    replacementLength += f_1442_100390_100446(f_1442_100390_100439(f_1442_100390_100421(f_1442_100390_100414(fileRedirection)))) - replacementIndex;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 100498, 100552);

                                    completionContext.ReplacementIndex = replacementIndex;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 100582, 100638);

                                    completionContext.ReplacementLength = replacementLength;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 100041, 100665);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 99565, 100688);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 99384, 100707);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 99220, 100722);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 98674, 100722);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 100738, 101282) || true) && (needFileCompletion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 100738, 101282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 100794, 100886);

                    return f_1442_100801_100885(f_1442_100828_100884(completionContext));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 100738, 101282);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 100738, 101282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 100952, 101112);

                    string
                    wordToComplete =
                    f_1442_100997_101111(lastAst as CommandElementAst, string.Empty, completionContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 101130, 101267) || true) && (wordToComplete != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 101130, 101267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 101198, 101248);

                        completionContext.WordToComplete = wordToComplete;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 101130, 101267);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 100738, 101282);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 101298, 101371);

                result = f_1442_101307_101370(completionContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 101385, 101439);

                replacementIndex = f_1442_101404_101438(completionContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 101453, 101509);

                replacementLength = f_1442_101473_101508(completionContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 101523, 101537);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 82434, 101548);

                System.Management.Automation.Language.Token
                f_1442_82643_82674(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenAtCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 82643, 82674);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_82703_82732(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 82703, 82732);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_82703_82739(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.Last<System.Management.Automation.Language.Ast>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 82703, 82739);
                    return return_v;
                }


                string
                f_1442_82831_82849(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 82831, 82849);
                    return return_v;
                }


                string
                f_1442_83059_83073(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 83059, 83073);
                    return return_v;
                }


                bool
                f_1442_83059_83111(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 83059, 83111);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_83230_83286(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteVariable(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 83230, 83286);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_83400_83415(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 83400, 83415);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_83568_83583(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 83568, 83583);
                    return return_v;
                }


                int
                f_1442_83568_83595(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 83568, 83595);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_83660_83675(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 83660, 83675);
                    return return_v;
                }


                int
                f_1442_83660_83685(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 83660, 83685);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_83766_83781(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 83766, 83781);
                    return return_v;
                }


                string
                f_1442_83766_83786(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 83766, 83786);
                    return return_v;
                }


                System.Management.Automation.Language.UsingStatementKind
                f_1442_83821_83850(System.Management.Automation.Language.UsingStatementAst
                this_param)
                {
                    var return_v = this_param.UsingStatementKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 83821, 83850);
                    return return_v;
                }


                System.StringComparer
                f_1442_84221_84253()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 84221, 84253);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                f_1442_84874_84955(System.Management.Automation.CompletionContext
                context, bool
                containerOnly, System.Collections.Generic.HashSet<string>
                extension)
                {
                    var return_v = CompletionCompleters.CompleteFilename(context, containerOnly, extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 84874, 84955);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_84874_84964(System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 84874, 84964);
                    return return_v;
                }


                string
                f_1442_85003_85035(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.WordToComplete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 85003, 85035);
                    return return_v;
                }


                int
                f_1442_85003_85081(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 85003, 85081);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_85389_85454(System.Management.Automation.CompletionContext
                context, bool
                loadedModulesOnly)
                {
                    var return_v = CompletionCompleters.CompleteModuleName(context, loadedModulesOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 85389, 85454);
                    return return_v;
                }


                int
                f_1442_85518_85537(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 85518, 85537);
                    return return_v;
                }


                int
                f_1442_85580_85610(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 85580, 85610);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_85766_85823(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteNamespace(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 85766, 85823);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_1442_86049_86102(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 86049, 86102);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_86212_86305(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, ref int
                replacementIndex, ref int
                replacementLength)
                {
                    var return_v = this_param.GetResultForAttributeArgument(completionContext, ref replacementIndex, ref replacementLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 86212, 86305);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1442_86375_86399(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.TokenFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 86375, 86399);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_86557_86586(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 86557, 86586);
                    return return_v;
                }


                int
                f_1442_86557_86592(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 86557, 86592);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_86600_86629(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 86600, 86629);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_86600_86632(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 86600, 86632);
                    return return_v;
                }


                int
                f_1442_86844_86865(System.Management.Automation.Language.InternalScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 86844, 86865);
                    return return_v;
                }


                int
                f_1442_86868_86892(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 86868, 86892);
                    return return_v;
                }


                System.Management.Automation.Language.InternalScriptPosition
                f_1442_87019_87073(System.Management.Automation.Language.InternalScriptPosition
                this_param, int
                offset)
                {
                    var return_v = this_param.CloneWithNewOffset(offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 87019, 87073);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_87137_87166(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 87137, 87166);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_87137_87169(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 87137, 87169);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_87208_87263(System.Management.Automation.Language.ScriptBlockAst
                scriptBlockAst, System.Management.Automation.Language.InternalScriptPosition
                cursorPosition)
                {
                    var return_v = GetLastAstAtCursor(scriptBlockAst, (System.Management.Automation.Language.IScriptPosition)cursorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 87208, 87263);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_87361_87377(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 87361, 87377);
                    return return_v;
                }


                int
                f_1442_87361_87391(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 87361, 87391);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_87395_87415(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 87395, 87415);
                    return return_v;
                }


                int
                f_1442_87395_87431(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 87395, 87431);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_87460_87476(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 87460, 87476);
                    return return_v;
                }


                int
                f_1442_87460_87492(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 87460, 87492);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_87496_87516(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 87496, 87516);
                    return return_v;
                }


                int
                f_1442_87496_87534(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 87496, 87534);
                    return return_v;
                }


                int
                f_1442_87588_87644(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 87588, 87644);
                    return return_v;
                }


                string
                f_1442_87764_87885(System.Management.Automation.Language.Ast
                stringAst, string
                partialPath, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = CompletionCompleters.ConcatenateStringPathArguments((System.Management.Automation.Language.CommandElementAst)stringAst, partialPath, completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 87764, 87885);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                f_1442_88128_88184(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteFilename(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 88128, 88184);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_88101_88185(System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 88101, 88185);
                    return return_v;
                }


                int
                f_1442_88224_88236(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 88224, 88236);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_88333_88349(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 88333, 88349);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_88333_88369(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 88333, 88369);
                    return return_v;
                }


                int
                f_1442_88333_88376(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 88333, 88376);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_88436_88452(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 88436, 88452);
                    return return_v;
                }


                string
                f_1442_88436_88457(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 88436, 88457);
                    return return_v;
                }


                int
                f_1442_88436_88464(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 88436, 88464);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1442_89094_89128(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 89094, 89128);
                    return return_v;
                }


                string
                f_1442_88844_89129(System.Management.Automation.Language.VariableExpressionAst
                variableAst, string
                extraText, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = CompletionCompleters.CombineVariableWithPartialPath(variableAst: variableAst, extraText: extraText, executionContext: executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 88844, 89129);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_89507_89523(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 89507, 89523);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_89507_89543(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 89507, 89543);
                    return return_v;
                }


                int
                f_1442_89507_89550(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 89507, 89550);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_89606_89622(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 89606, 89622);
                    return return_v;
                }


                string
                f_1442_89606_89627(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 89606, 89627);
                    return return_v;
                }


                int
                f_1442_89606_89634(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 89606, 89634);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_90064_90080(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 90064, 90080);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Token>
                f_1442_90576_90597(System.Management.Automation.Language.StringExpandableToken
                this_param)
                {
                    var return_v = this_param.NestedTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 90576, 90597);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_90834_90849(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 90834, 90849);
                    return return_v;
                }


                string
                f_1442_90851_90865(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 90851, 90865);
                    return return_v;
                }


                System.Management.Automation.Language.ExpandableStringExpressionAst
                f_1442_90800_90895(System.Management.Automation.Language.IScriptExtent
                extent, string
                value, System.Management.Automation.Language.StringConstantType
                type)
                {
                    var return_v = new System.Management.Automation.Language.ExpandableStringExpressionAst(extent, value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 90800, 90895);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1442_91201_91235(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 91201, 91235);
                    return return_v;
                }


                bool
                f_1442_90926_91345(System.Management.Automation.Language.ExpandableStringExpressionAst
                expandableStringAst, string
                extraText, System.Management.Automation.ExecutionContext
                executionContext, out string
                expandedString)
                {
                    var return_v = CompletionCompleters.IsPathSafelyExpandable(expandableStringAst: expandableStringAst, extraText: extraText, executionContext: executionContext, out expandedString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 90926, 91345);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_92050_92082(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.CursorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 92050, 92082);
                    return return_v;
                }


                System.Management.Automation.Language.ConfigurationDefinitionAst
                f_1442_92009_92108(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.Language.IScriptPosition
                cursorPosition, System.Management.Automation.Language.Ast
                ast, out System.Management.Automation.Language.DynamicKeywordStatementAst
                keywordAst)
                {
                    var return_v = this_param.GetAncestorConfigurationAstAndKeywordAst(cursorPosition, ast, out keywordAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 92009, 92108);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_92415_92510(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.CompletionContext
                completionContext, System.Management.Automation.Language.ConfigurationDefinitionAst
                configureAst, System.Management.Automation.Language.DynamicKeywordStatementAst
                keywordAst, out bool
                matched)
                {
                    var return_v = this_param.GetResultForIdentifierInConfiguration(completionContext, configureAst, keywordAst, out matched);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 92415, 92510);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_92637_92681(System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = CompleteFileNameAsCommand(completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 92637, 92681);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_92779_92834(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommand(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 92779, 92834);
                    return return_v;
                }


                int
                f_1442_92888_92911(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 92888, 92911);
                    return return_v;
                }


                int
                f_1442_92957_92991(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 92957, 92991);
                    return 0;
                }


                int
                f_1442_93109_93145(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, int
                index, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                collection)
                {
                    this_param.InsertRange(index, (System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 93109, 93145);
                    return 0;
                }


                int
                f_1442_93229_93252(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 93229, 93252);
                    return return_v;
                }


                int
                f_1442_93299_93329(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 93299, 93329);
                    return 0;
                }


                int
                f_1442_93433_93457(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 93433, 93457);
                    return return_v;
                }


                char
                f_1442_93466_93486(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 93466, 93486);
                    return return_v;
                }


                bool
                f_1442_93466_93495(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 93466, 93495);
                    return return_v;
                }


                int
                f_1442_93529_93553(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 93529, 93553);
                    return return_v;
                }


                char
                f_1442_93562_93582(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 93562, 93582);
                    return return_v;
                }


                bool
                f_1442_93562_93591(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 93562, 93591);
                    return return_v;
                }


                char
                f_1442_93595_93615(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 93595, 93615);
                    return return_v;
                }


                bool
                f_1442_93595_93624(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 93595, 93624);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_93678_93692(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 93678, 93692);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_93710_93724(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 93710, 93724);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_94107_94171(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommandParameter(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 94107, 94171);
                    return return_v;
                }


                int
                f_1442_94198_94207(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 94198, 94207);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_94342_94405(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommandArgument(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 94342, 94405);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_94523_94537(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 94523, 94537);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_94636_94650(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 94636, 94650);
                    return return_v;
                }


                bool
                f_1442_94614_94658(System.Management.Automation.Language.MemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Static;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 94614, 94658);
                    return return_v;
                }


                string
                f_1442_95074_95094(System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = kind.Text();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 95074, 95094);
                    return return_v;
                }


                bool
                f_1442_95049_95121(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 95049, 95121);
                    return return_v;
                }


                string
                f_1442_95313_95340(System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = kind.Text();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 95313, 95340);
                    return return_v;
                }


                bool
                f_1442_95288_95367(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 95288, 95367);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_95541_95559(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 95541, 95559);
                    return return_v;
                }


                bool
                f_1442_95541_95586(System.Management.Automation.Language.TokenKind
                this_param, System.Management.Automation.Language.TokenKind
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 95541, 95586);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1442_95859_95883(System.Management.Automation.Language.BinaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 95859, 95883);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_95949_95982(System.Management.Automation.Language.BinaryExpressionAst
                this_param)
                {
                    var return_v = this_param.ErrorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 95949, 95982);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1442_96042_96070(System.Management.Automation.Language.BinaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Operator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 96042, 96070);
                    return return_v;
                }


                int
                f_1442_96121_96146(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 96121, 96146);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1442_96150_96176(System.Management.Automation.Language.MemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 96150, 96176);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_96150_96183(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 96150, 96183);
                    return return_v;
                }


                int
                f_1442_96150_96193(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 96150, 96193);
                    return return_v;
                }


                bool
                f_1442_96254_96280(System.Management.Automation.Language.MemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Static;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 96254, 96280);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_96730_96759(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 96730, 96759);
                    return return_v;
                }


                bool
                f_1442_96730_96787(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, System.Management.Automation.Language.BinaryExpressionAst
                item)
                {
                    var return_v = this_param.Remove((System.Management.Automation.Language.Ast)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 96730, 96787);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_96814_96843(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 96814, 96843);
                    return return_v;
                }


                int
                f_1442_96814_96868(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, System.Management.Automation.Language.MemberExpressionAst
                item)
                {
                    this_param.Add((System.Management.Automation.Language.Ast)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 96814, 96868);
                    return 0;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1442_96913_96939(System.Management.Automation.Language.MemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 96913, 96939);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_97095_97111(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 97095, 97111);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_97095_97131(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 97095, 97131);
                    return return_v;
                }


                int
                f_1442_97095_97138(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 97095, 97138);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_97190_97206(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 97190, 97206);
                    return return_v;
                }


                string
                f_1442_97190_97211(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 97190, 97211);
                    return return_v;
                }


                int
                f_1442_97190_97218(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 97190, 97218);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_97384_97501(System.Management.Automation.CompletionContext
                context, bool
                @static)
                {
                    var return_v = CompletionCompleters.CompleteMember(context, @static);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 97384, 97501);
                    return return_v;
                }


                bool
                f_1442_97786_97798(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 97786, 97798);
                    return return_v;
                }


                int
                f_1442_97964_97988(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 97964, 97988);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_98152_98166(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 98152, 98166);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_98300_98314(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 98300, 98314);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_98225_98315(System.Management.Automation.CompletionContext
                completionContext, System.Management.Automation.Language.Ast
                hashtableAst)
                {
                    var return_v = CompletionCompleters.CompleteHashtableKey(completionContext, (System.Management.Automation.Language.HashtableAst)hashtableAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 98225, 98315);
                    return return_v;
                }


                bool
                f_1442_98356_98368(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 98356, 98368);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_98678_98692(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 98678, 98692);
                    return return_v;
                }


                System.Management.Automation.Language.Token
                f_1442_98753_98788(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.TokenBeforeCursor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 98753, 98788);
                    return return_v;
                }


                bool
                f_1442_98718_98789(System.Management.Automation.Language.Ast
                lastAst, System.Management.Automation.Language.Token
                tokenBeforeCursor)
                {
                    var return_v = CompleteAgainstSwitchFile(lastAst, tokenBeforeCursor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 98718, 98789);
                    return return_v;
                }


                string
                f_1442_98868_98982(System.Management.Automation.Language.Ast
                stringAst, string
                partialPath, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = CompletionCompleters.ConcatenateStringPathArguments((System.Management.Automation.Language.CommandElementAst)stringAst, partialPath, completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 98868, 98982);
                    return return_v;
                }


                int
                f_1442_99224_99280(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 99224, 99280);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_99333_99347(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99333, 99347);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                f_1442_99407_99427(System.Management.Automation.Language.CommandBaseAst
                this_param)
                {
                    var return_v = this_param.Redirections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99407, 99427);
                    return return_v;
                }


                bool
                f_1442_99407_99433(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.Language.RedirectionAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 99407, 99433);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                f_1442_99497_99517(System.Management.Automation.Language.CommandBaseAst
                this_param)
                {
                    var return_v = this_param.Redirections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99497, 99517);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionAst
                f_1442_99497_99520(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99497, 99520);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_99621_99643(System.Management.Automation.Language.FileRedirectionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99621, 99643);
                    return return_v;
                }


                int
                f_1442_99621_99657(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99621, 99657);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_99661_99675(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99661, 99675);
                    return return_v;
                }


                int
                f_1442_99661_99691(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99661, 99691);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_99720_99742(System.Management.Automation.Language.FileRedirectionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99720, 99742);
                    return return_v;
                }


                int
                f_1442_99720_99758(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99720, 99758);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_99762_99776(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99762, 99776);
                    return return_v;
                }


                int
                f_1442_99762_99794(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99762, 99794);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1442_99949_99973(System.Management.Automation.Language.FileRedirectionAst
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 99949, 99973);
                    return return_v;
                }


                string
                f_1442_99897_100012(System.Management.Automation.Language.ExpressionAst
                stringAst, string
                partialPath, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = CompletionCompleters.ConcatenateStringPathArguments((System.Management.Automation.Language.CommandElementAst)stringAst, partialPath, completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 99897, 100012);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1442_100280_100304(System.Management.Automation.Language.FileRedirectionAst
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 100280, 100304);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_100280_100311(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 100280, 100311);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_100280_100331(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 100280, 100331);
                    return return_v;
                }


                int
                f_1442_100280_100338(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 100280, 100338);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1442_100390_100414(System.Management.Automation.Language.FileRedirectionAst
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 100390, 100414);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_100390_100421(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 100390, 100421);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1442_100390_100439(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 100390, 100439);
                    return return_v;
                }


                int
                f_1442_100390_100446(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 100390, 100446);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                f_1442_100828_100884(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteFilename(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 100828, 100884);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_100801_100885(System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 100801, 100885);
                    return return_v;
                }


                string
                f_1442_100997_101111(System.Management.Automation.Language.Ast
                stringAst, string
                partialPath, System.Management.Automation.CompletionContext
                completionContext)
                {
                    var return_v = CompletionCompleters.ConcatenateStringPathArguments((System.Management.Automation.Language.CommandElementAst)stringAst, partialPath, completionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 100997, 101111);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_101307_101370(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteCommandArgument(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 101307, 101370);
                    return return_v;
                }


                int
                f_1442_101404_101438(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ReplacementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 101404, 101438);
                    return return_v;
                }


                int
                f_1442_101473_101508(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.ReplacementLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 101473, 101508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 82434, 101548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 82434, 101548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<CompletionResult> GetResultForAttributeArgument(CompletionContext completionContext, ref int replacementIndex, ref int replacementLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1442, 101560, 103750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 101778, 101804);

                Type
                attributeType = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 101818, 101848);

                string
                argName = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 101862, 101951);

                Ast
                argAst = f_1442_101875_101950(f_1442_101875_101904(completionContext), ast => ast is NamedAttributeArgumentAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 101965, 102041);

                NamedAttributeArgumentAst
                namedArgAst = argAst as NamedAttributeArgumentAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102055, 102789) || true) && (argAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 102059, 102096) && namedArgAst != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 102055, 102789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102130, 102219);

                    attributeType = f_1442_102146_102218(f_1442_102146_102189(((AttributeAst)f_1442_102161_102179(namedArgAst))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102237, 102272);

                    argName = f_1442_102247_102271(namedArgAst);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102290, 102340);

                    replacementIndex = f_1442_102309_102339(f_1442_102309_102327(namedArgAst));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102358, 102393);

                    replacementLength = f_1442_102378_102392(argName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 102055, 102789);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 102055, 102789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102459, 102535);

                    Ast
                    astAtt = f_1442_102472_102534(f_1442_102472_102501(completionContext), ast => ast is AttributeAst)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102553, 102598);

                    AttributeAst
                    attAst = astAtt as AttributeAst
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102616, 102774) || true) && (astAtt != null && (DynAbs.Tracing.TraceSender.Expression_True(1442, 102620, 102652) && attAst != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 102616, 102774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102694, 102755);

                        attributeType = f_1442_102710_102754(f_1442_102710_102725(attAst));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 102616, 102774);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 102055, 102789);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102805, 103711) || true) && (attributeType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 102805, 103711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102864, 102968);

                    PropertyInfo[]
                    propertyInfos = f_1442_102895_102967(attributeType, BindingFlags.Public | BindingFlags.Instance)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 102986, 103047);

                    List<CompletionResult>
                    result = f_1442_103018_103046()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 103065, 103662);
                        foreach (PropertyInfo property in f_1442_103099_103112_I(propertyInfos))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 103065, 103662);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 103257, 103294) || true) && (f_1442_103261_103279_M(!property.CanWrite))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 103257, 103294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 103283, 103292);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 103257, 103294);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 103318, 103643) || true) && (f_1442_103322_103391(f_1442_103322_103335(property), argName, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 103318, 103643);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 103441, 103620);

                                f_1442_103441_103619(result, f_1442_103452_103618(f_1442_103473_103486(property), f_1442_103488_103501(property), CompletionResultType.Property, f_1442_103563_103595(f_1442_103563_103584(property)) + " " + f_1442_103604_103617(property)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 103318, 103643);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 103065, 103662);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 598);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 598);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 103682, 103696);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 102805, 103711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 103727, 103739);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1442, 101560, 103750);

                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_101875_101904(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 101875, 101904);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_101875_101950(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, System.Predicate<System.Management.Automation.Language.Ast>
                match)
                {
                    var return_v = this_param.Find(match);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 101875, 101950);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_102161_102179(System.Management.Automation.Language.NamedAttributeArgumentAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 102161, 102179);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1442_102146_102189(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 102146, 102189);
                    return return_v;
                }


                System.Type
                f_1442_102146_102218(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionAttributeType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 102146, 102218);
                    return return_v;
                }


                string
                f_1442_102247_102271(System.Management.Automation.Language.NamedAttributeArgumentAst
                this_param)
                {
                    var return_v = this_param.ArgumentName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 102247, 102271);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1442_102309_102327(System.Management.Automation.Language.NamedAttributeArgumentAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 102309, 102327);
                    return return_v;
                }


                int
                f_1442_102309_102339(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 102309, 102339);
                    return return_v;
                }


                int
                f_1442_102378_102392(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 102378, 102392);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1442_102472_102501(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.RelatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 102472, 102501);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1442_102472_102534(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, System.Predicate<System.Management.Automation.Language.Ast>
                match)
                {
                    var return_v = this_param.Find(match);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 102472, 102534);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1442_102710_102725(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 102710, 102725);
                    return return_v;
                }


                System.Type
                f_1442_102710_102754(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionAttributeType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 102710, 102754);
                    return return_v;
                }


                System.Reflection.PropertyInfo[]
                f_1442_102895_102967(System.Type
                this_param, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetProperties(bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 102895, 102967);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_103018_103046()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 103018, 103046);
                    return return_v;
                }


                bool
                f_1442_103261_103279_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 103261, 103279);
                    return return_v;
                }


                string
                f_1442_103322_103335(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 103322, 103335);
                    return return_v;
                }


                bool
                f_1442_103322_103391(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 103322, 103391);
                    return return_v;
                }


                string
                f_1442_103473_103486(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 103473, 103486);
                    return return_v;
                }


                string
                f_1442_103488_103501(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 103488, 103501);
                    return return_v;
                }


                System.Type
                f_1442_103563_103584(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.PropertyType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 103563, 103584);
                    return return_v;
                }


                string
                f_1442_103563_103595(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 103563, 103595);
                    return return_v;
                }


                string
                f_1442_103604_103617(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 103604, 103617);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1442_103452_103618(string
                completionText, string
                listItemText, System.Management.Automation.CompletionResultType
                resultType, string
                toolTip)
                {
                    var return_v = new System.Management.Automation.CompletionResult(completionText, listItemText, resultType, toolTip);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 103452, 103618);
                    return return_v;
                }


                int
                f_1442_103441_103619(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Management.Automation.CompletionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 103441, 103619);
                    return 0;
                }


                System.Reflection.PropertyInfo[]
                f_1442_103099_103112_I(System.Reflection.PropertyInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 103099, 103112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 101560, 103750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 101560, 103750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<CompletionResult> CompleteFileNameAsCommand(CompletionContext completionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1442, 103940, 105869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 104065, 104159);

                var
                addAmpersandIfNecessary = f_1442_104095_104158(completionContext, true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 104173, 104215);

                var
                result = f_1442_104186_104214()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 104229, 104262);

                var
                clearLiteralPathsKey = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 104278, 104749) || true) && (f_1442_104282_104307(completionContext) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 104278, 104749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 104349, 104420);

                    completionContext.Options = new Hashtable { { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "LiteralPaths", 1442, 104377, 104419), true } };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 104278, 104749);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 104278, 104749);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 104454, 104749) || true) && (!f_1442_104459_104512(f_1442_104459_104484(completionContext), "LiteralPaths"))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 104454, 104749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 104636, 104688);

                        f_1442_104636_104687(f_1442_104636_104661(completionContext), "LiteralPaths", true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 104706, 104734);

                        clearLiteralPathsKey = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 104454, 104749);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 104278, 104749);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 104801, 104879);

                    var
                    fileNameResult = f_1442_104822_104878(completionContext)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 104897, 105648);
                        foreach (var entry in f_1442_104919_104933_I(fileNameResult))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 104897, 105648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 105037, 105079);

                            var
                            completionText = f_1442_105058_105078(entry)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 105101, 105133);

                            var
                            len = f_1442_105111_105132(completionText)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 105155, 105629) || true) && (addAmpersandIfNecessary && (DynAbs.Tracing.TraceSender.Expression_True(1442, 105159, 105193) && len > 2) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 105159, 105230) && f_1442_105197_105230(f_1442_105197_105214(completionText, 0))) && (DynAbs.Tracing.TraceSender.Expression_True(1442, 105159, 105273) && f_1442_105234_105273(f_1442_105234_105257(completionText, len - 1))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 105155, 105629);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 105323, 105362);

                                completionText = "& " + completionText;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 105388, 105490);

                                f_1442_105388_105489(result, f_1442_105399_105488(completionText, f_1442_105436_105454(entry), f_1442_105456_105472(entry), f_1442_105474_105487(entry)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 105155, 105629);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 105155, 105629);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 105588, 105606);

                                f_1442_105588_105605(result, entry);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 105155, 105629);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 104897, 105648);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1442, 1, 752);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1442, 1, 752);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1442, 105677, 105828);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 105717, 105813) || true) && (clearLiteralPathsKey)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1442, 105717, 105813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 105764, 105813);

                        f_1442_105764_105812(f_1442_105764_105789(completionContext), "LiteralPaths");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1442, 105717, 105813);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1442, 105677, 105828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1442, 105844, 105858);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1442, 103940, 105869);

                bool
                f_1442_104095_104158(System.Management.Automation.CompletionContext
                context, bool
                defaultChoice)
                {
                    var return_v = CompletionCompleters.IsAmpersandNeeded(context, defaultChoice);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 104095, 104158);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1442_104186_104214()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 104186, 104214);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1442_104282_104307(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 104282, 104307);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1442_104459_104484(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 104459, 104484);
                    return return_v;
                }


                bool
                f_1442_104459_104512(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 104459, 104512);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1442_104636_104661(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 104636, 104661);
                    return return_v;
                }


                int
                f_1442_104636_104687(System.Collections.Hashtable
                this_param, string
                key, bool
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 104636, 104687);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                f_1442_104822_104878(System.Management.Automation.CompletionContext
                context)
                {
                    var return_v = CompletionCompleters.CompleteFilename(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 104822, 104878);
                    return return_v;
                }


                string
                f_1442_105058_105078(System.Management.Automation.CompletionResult
                this_param)
                {
                    var return_v = this_param.CompletionText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 105058, 105078);
                    return return_v;
                }


                int
                f_1442_105111_105132(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 105111, 105132);
                    return return_v;
                }


                char
                f_1442_105197_105214(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 105197, 105214);
                    return return_v;
                }


                bool
                f_1442_105197_105230(char
                c)
                {
                    var return_v = c.IsSingleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 105197, 105230);
                    return return_v;
                }


                char
                f_1442_105234_105257(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 105234, 105257);
                    return return_v;
                }


                bool
                f_1442_105234_105273(char
                c)
                {
                    var return_v = c.IsSingleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 105234, 105273);
                    return return_v;
                }


                string
                f_1442_105436_105454(System.Management.Automation.CompletionResult
                this_param)
                {
                    var return_v = this_param.ListItemText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 105436, 105454);
                    return return_v;
                }


                System.Management.Automation.CompletionResultType
                f_1442_105456_105472(System.Management.Automation.CompletionResult
                this_param)
                {
                    var return_v = this_param.ResultType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 105456, 105472);
                    return return_v;
                }


                string
                f_1442_105474_105487(System.Management.Automation.CompletionResult
                this_param)
                {
                    var return_v = this_param.ToolTip;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 105474, 105487);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1442_105399_105488(string
                completionText, string
                listItemText, System.Management.Automation.CompletionResultType
                resultType, string
                toolTip)
                {
                    var return_v = new System.Management.Automation.CompletionResult(completionText, listItemText, resultType, toolTip);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 105399, 105488);
                    return return_v;
                }


                int
                f_1442_105388_105489(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Management.Automation.CompletionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 105388, 105489);
                    return 0;
                }


                int
                f_1442_105588_105605(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Management.Automation.CompletionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 105588, 105605);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                f_1442_104919_104933_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 104919, 104933);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1442_105764_105789(System.Management.Automation.CompletionContext
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1442, 105764, 105789);
                    return return_v;
                }


                int
                f_1442_105764_105812(System.Collections.Hashtable
                this_param, string
                key)
                {
                    this_param.Remove((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1442, 105764, 105812);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1442, 103940, 105869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 103940, 105869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompletionAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1442, 1851, 105876);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1442, 1851, 105876);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1442, 1851, 105876);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1442, 1851, 105876);
    }
}
