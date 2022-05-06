// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.IO;
using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Threading;

namespace System.Management.Automation
{
    public abstract class Breakpoint
    {
        public ScriptBlock Action { get; private set; }

        public bool Enabled { get; private set; }

        internal void SetEnabled(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 824, 912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 885, 901);

                Enabled = value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 824, 912);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 824, 912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 824, 912);
            }
        }

        public int HitCount { get; private set; }

        public int Id { get; private set; }

        internal bool IsScriptBreakpoint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 1420, 1450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 1426, 1448);

                    return f_1447_1433_1439() != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 1420, 1450);

                    string
                    f_1447_1433_1439()
                    {
                        var return_v = Script;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 1433, 1439);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 1363, 1461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 1363, 1461);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Script { get; private set; }

        protected Breakpoint(string script)
        : this(f_1447_1896_1902_C(script), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 1840, 1922);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 1840, 1922);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 1840, 1922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 1840, 1922);
            }
        }

        protected Breakpoint(string script, ScriptBlock action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 2047, 2333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 611, 658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 771, 812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 1043, 1084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 1178, 1213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 1608, 1650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 2127, 2142);

                Enabled = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 2156, 2210);

                Script = (DynAbs.Tracing.TraceSender.Conditional_F1(1447, 2165, 2193) || ((f_1447_2165_2193(script) && DynAbs.Tracing.TraceSender.Conditional_F2(1447, 2196, 2200)) || DynAbs.Tracing.TraceSender.Conditional_F3(1447, 2203, 2209))) ? null : script;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 2224, 2265);

                Id = f_1447_2229_2264(ref s_lastID);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 2279, 2295);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 2309, 2322);

                HitCount = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 2047, 2333);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 2047, 2333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 2047, 2333);
            }
        }

        protected Breakpoint(string script, int id)
        : this(f_1447_2522_2528_C(script), null, id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 2458, 2552);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 2458, 2552);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 2458, 2552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 2458, 2552);
            }
        }

        protected Breakpoint(string script, ScriptBlock action, int id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 2677, 2938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 611, 658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 771, 812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 1043, 1084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 1178, 1213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 1608, 1650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 2765, 2780);

                Enabled = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 2794, 2848);

                Script = (DynAbs.Tracing.TraceSender.Conditional_F1(1447, 2803, 2831) || ((f_1447_2803_2831(script) && DynAbs.Tracing.TraceSender.Conditional_F2(1447, 2834, 2838)) || DynAbs.Tracing.TraceSender.Conditional_F3(1447, 2841, 2847))) ? null : script;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 2862, 2870);

                Id = id;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 2884, 2900);

                Action = action;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 2914, 2927);

                HitCount = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 2677, 2938);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 2677, 2938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 2677, 2938);
            }
        }

        internal BreakpointAction Trigger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 3012, 3960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 3072, 3083);

                f_1447_3072_3082_M(++HitCount);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 3097, 3194) || true) && (f_1447_3101_3107() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 3097, 3194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 3149, 3179);

                    return BreakpointAction.Break;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 3097, 3194);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 3633, 3710);

                    f_1447_3633_3709(f_1447_3633_3639(), dollarUnder: this, input: null, args: f_1447_3687_3708());
                }
                catch (BreakException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1447, 3739, 3839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 3794, 3824);

                    return BreakpointAction.Break;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1447, 3739, 3839);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1447, 3853, 3900);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1447, 3853, 3900);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 3916, 3949);

                return BreakpointAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 3012, 3960);

                int
                f_1447_3072_3082_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 3072, 3082);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1447_3101_3107()
                {
                    var return_v = Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 3101, 3107);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1447_3633_3639()
                {
                    var return_v = Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 3633, 3639);
                    return return_v;
                }


                object[]
                f_1447_3687_3708()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 3687, 3708);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1447_3633_3709(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.Breakpoint
                dollarUnder, object
                input, object[]
                args)
                {
                    var return_v = this_param.DoInvoke(dollarUnder: (object)dollarUnder, input: input, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 3633, 3709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 3012, 3960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 3012, 3960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool RemoveSelf(ScriptDebugger debugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 4030, 4038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 4033, 4038);
                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 4030, 4038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 4030, 4038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 4030, 4038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }



        internal enum BreakpointAction
        {
            Continue = 0x0,
            Break = 0x1
        }

        private static int s_lastID;

        static Breakpoint()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1447, 425, 4360);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 4306, 4314);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1447, 425, 4360);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 425, 4360);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1447, 425, 4360);

        static string
        f_1447_1896_1902_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 1840, 1922);
            return return_v;
        }


        bool
        f_1447_2165_2193(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 2165, 2193);
            return return_v;
        }


        int
        f_1447_2229_2264(ref int
        location)
        {
            var return_v = Interlocked.Increment(ref location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 2229, 2264);
            return return_v;
        }


        static string
        f_1447_2522_2528_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 2458, 2552);
            return return_v;
        }


        bool
        f_1447_2803_2831(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 2803, 2831);
            return return_v;
        }

    }
    public class CommandBreakpoint : Breakpoint
    {
        public CommandBreakpoint(string script, WildcardPattern command, string commandString)
        : this(f_1447_4730_4736_C(script), command, commandString, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 4623, 4780);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 4623, 4780);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 4623, 4780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 4623, 4780);
            }
        }

        public CommandBreakpoint(string script, WildcardPattern command, string commandString, ScriptBlock action)
        : base(f_1447_5039_5045_C(script), action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 4912, 5153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 5948, 5991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 6003, 6064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 5079, 5104);

                CommandPattern = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 5118, 5142);

                Command = commandString;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 4912, 5153);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 4912, 5153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 4912, 5153);
            }
        }

        public CommandBreakpoint(string script, WildcardPattern command, string commandString, int id)
        : this(f_1447_5400_5406_C(script), command, commandString, null, id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 5285, 5454);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 5285, 5454);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 5285, 5454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 5285, 5454);
            }
        }

        public CommandBreakpoint(string script, WildcardPattern command, string commandString, ScriptBlock action, int id)
        : base(f_1447_5721_5727_C(script), action, id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 5586, 5839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 5948, 5991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 6003, 6064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 5765, 5790);

                CommandPattern = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 5804, 5828);

                Command = commandString;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 5586, 5839);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 5586, 5839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 5586, 5839);
            }
        }

        public string Command { get; private set; }

        internal WildcardPattern CommandPattern { get; private set; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 6261, 6558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 6319, 6547);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1447, 6326, 6344) || ((f_1447_6326_6344() && DynAbs.Tracing.TraceSender.Conditional_F2(1447, 6371, 6452)) || DynAbs.Tracing.TraceSender.Conditional_F3(1447, 6479, 6546))) ? f_1447_6371_6452(f_1447_6389_6434(), f_1447_6436_6442(), f_1447_6444_6451()) : f_1447_6479_6546(f_1447_6497_6536(), f_1447_6538_6545());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 6261, 6558);

                bool
                f_1447_6326_6344()
                {
                    var return_v = IsScriptBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 6326, 6344);
                    return return_v;
                }


                string
                f_1447_6389_6434()
                {
                    var return_v = DebuggerStrings.CommandScriptBreakpointString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 6389, 6434);
                    return return_v;
                }


                string
                f_1447_6436_6442()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 6436, 6442);
                    return return_v;
                }


                string
                f_1447_6444_6451()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 6444, 6451);
                    return return_v;
                }


                string
                f_1447_6371_6452(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 6371, 6452);
                    return return_v;
                }


                string
                f_1447_6497_6536()
                {
                    var return_v = DebuggerStrings.CommandBreakpointString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 6497, 6536);
                    return return_v;
                }


                string
                f_1447_6538_6545()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 6538, 6545);
                    return return_v;
                }


                string
                f_1447_6479_6546(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 6479, 6546);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 6261, 6558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 6261, 6558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool RemoveSelf(ScriptDebugger debugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 6629, 6683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 6645, 6683);
                return f_1447_6645_6683(debugger, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 6629, 6683);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 6629, 6683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 6629, 6683);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_1447_6645_6683(System.Management.Automation.ScriptDebugger
            this_param, System.Management.Automation.CommandBreakpoint
            breakpoint)
            {
                var return_v = this_param.RemoveCommandBreakpoint(breakpoint);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 6645, 6683);
                return return_v;
            }

        }

        private bool CommandInfoMatches(CommandInfo commandInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 6696, 7858);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 6777, 6832) || true) && (commandInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 6777, 6832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 6819, 6832);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 6777, 6832);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 6848, 6923) || true) && (f_1447_6852_6892(f_1447_6852_6866(), f_1447_6875_6891(commandInfo)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 6848, 6923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 6911, 6923);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 6848, 6923);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 7172, 7412) || true) && (!f_1447_7177_7221(f_1447_7198_7220(commandInfo)) && (DynAbs.Tracing.TraceSender.Expression_True(1447, 7176, 7252) && f_1447_7225_7246(f_1447_7225_7232(), '\\') != -1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 7172, 7412);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 7286, 7397) || true) && (f_1447_7290_7362(f_1447_7290_7304(), f_1447_7313_7335(commandInfo) + "\\" + f_1447_7345_7361(commandInfo)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 7286, 7397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 7385, 7397);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 7286, 7397);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 7172, 7412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 7428, 7483);

                var
                externalScript = commandInfo as ExternalScriptInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 7497, 7818) || true) && (externalScript != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 7497, 7818);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 7557, 7667) || true) && (f_1447_7561_7632(f_1447_7561_7580(externalScript), f_1447_7588_7595(), StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 7557, 7667);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 7655, 7667);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 7557, 7667);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 7687, 7803) || true) && (f_1447_7691_7768(f_1447_7691_7705(), f_1447_7714_7767(f_1447_7747_7766(externalScript))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 7687, 7803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 7791, 7803);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 7687, 7803);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 7497, 7818);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 7834, 7847);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 6696, 7858);

                System.Management.Automation.WildcardPattern
                f_1447_6852_6866()
                {
                    var return_v = CommandPattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 6852, 6866);
                    return return_v;
                }


                string
                f_1447_6875_6891(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 6875, 6891);
                    return return_v;
                }


                bool
                f_1447_6852_6892(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 6852, 6892);
                    return return_v;
                }


                string
                f_1447_7198_7220(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 7198, 7220);
                    return return_v;
                }


                bool
                f_1447_7177_7221(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 7177, 7221);
                    return return_v;
                }


                string
                f_1447_7225_7232()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 7225, 7232);
                    return return_v;
                }


                int
                f_1447_7225_7246(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 7225, 7246);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1447_7290_7304()
                {
                    var return_v = CommandPattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 7290, 7304);
                    return return_v;
                }


                string
                f_1447_7313_7335(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 7313, 7335);
                    return return_v;
                }


                string
                f_1447_7345_7361(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 7345, 7361);
                    return return_v;
                }


                bool
                f_1447_7290_7362(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 7290, 7362);
                    return return_v;
                }


                string
                f_1447_7561_7580(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 7561, 7580);
                    return return_v;
                }


                string
                f_1447_7588_7595()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 7588, 7595);
                    return return_v;
                }


                bool
                f_1447_7561_7632(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 7561, 7632);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1447_7691_7705()
                {
                    var return_v = CommandPattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 7691, 7705);
                    return return_v;
                }


                string
                f_1447_7747_7766(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 7747, 7766);
                    return return_v;
                }


                string?
                f_1447_7714_7767(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 7714, 7767);
                    return return_v;
                }


                bool
                f_1447_7691_7768(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 7691, 7768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 6696, 7858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 6696, 7858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Trigger(InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 7870, 8336);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 8038, 8296) || true) && (f_1447_8042_8095(f_1447_8042_8056(), f_1447_8065_8094(invocationInfo)) || (DynAbs.Tracing.TraceSender.Expression_False(1447, 8042, 8143) || f_1447_8099_8143(this, f_1447_8118_8142(invocationInfo))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 8038, 8296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 8177, 8281);

                    return (f_1447_8185_8191() == null || (DynAbs.Tracing.TraceSender.Expression_False(1447, 8185, 8279) || f_1447_8203_8279(f_1447_8203_8209(), f_1447_8217_8242(invocationInfo), StringComparison.OrdinalIgnoreCase)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 8038, 8296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 8312, 8325);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 7870, 8336);

                System.Management.Automation.WildcardPattern
                f_1447_8042_8056()
                {
                    var return_v = CommandPattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 8042, 8056);
                    return return_v;
                }


                string
                f_1447_8065_8094(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.InvocationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 8065, 8094);
                    return return_v;
                }


                bool
                f_1447_8042_8095(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 8042, 8095);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1447_8118_8142(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 8118, 8142);
                    return return_v;
                }


                bool
                f_1447_8099_8143(System.Management.Automation.CommandBreakpoint
                this_param, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = this_param.CommandInfoMatches(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 8099, 8143);
                    return return_v;
                }


                string
                f_1447_8185_8191()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 8185, 8191);
                    return return_v;
                }


                string
                f_1447_8203_8209()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 8203, 8209);
                    return return_v;
                }


                string
                f_1447_8217_8242(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 8217, 8242);
                    return return_v;
                }


                bool
                f_1447_8203_8279(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 8203, 8279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 7870, 8336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 7870, 8336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandBreakpoint()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1447, 4443, 8343);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1447, 4443, 8343);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 4443, 8343);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1447, 4443, 8343);

        static string
        f_1447_4730_4736_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 4623, 4780);
            return return_v;
        }


        static string
        f_1447_5039_5045_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 4912, 5153);
            return return_v;
        }


        static string
        f_1447_5400_5406_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 5285, 5454);
            return return_v;
        }


        static string
        f_1447_5721_5727_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 5586, 5839);
            return return_v;
        }

    }

    /// <summary>
    /// The access type for variable breakpoints to break on.
    /// </summary>
    public enum VariableAccessMode
    {
        /// <summary>
        /// Break on read access only.
        /// </summary>
        Read,
        /// <summary>
        /// Break on write access only (default).
        /// </summary>
        Write,
        /// <summary>
        /// Breakon read or write access.
        /// </summary>
        ReadWrite
    }
    public class VariableBreakpoint : Breakpoint
    {
        public VariableBreakpoint(string script, string variable, VariableAccessMode accessMode)
        : this(f_1447_9198_9204_C(script), variable, accessMode, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 9089, 9246);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 9089, 9246);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 9089, 9246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 9089, 9246);
            }
        }

        public VariableBreakpoint(string script, string variable, VariableAccessMode accessMode, ScriptBlock action)
        : base(f_1447_9509_9515_C(script), action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 9380, 9618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 10433, 10491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 10601, 10645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 9549, 9569);

                Variable = variable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 9583, 9607);

                AccessMode = accessMode;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 9380, 9618);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 9380, 9618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 9380, 9618);
            }
        }

        public VariableBreakpoint(string script, string variable, VariableAccessMode accessMode, int id)
        : this(f_1447_9869_9875_C(script), variable, accessMode, null, id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 9752, 9921);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 9752, 9921);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 9752, 9921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 9752, 9921);
            }
        }

        public VariableBreakpoint(string script, string variable, VariableAccessMode accessMode, ScriptBlock action, int id)
        : base(f_1447_10192_10198_C(script), action, id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 10055, 10305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 10433, 10491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 10601, 10645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 10236, 10256);

                Variable = variable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 10270, 10294);

                AccessMode = accessMode;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 10055, 10305);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 10055, 10305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 10055, 10305);
            }
        }

        public VariableAccessMode AccessMode { get; private set; }

        public string Variable { get; private set; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 10846, 11171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 10904, 11160);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1447, 10911, 10929) || ((f_1447_10911_10929() && DynAbs.Tracing.TraceSender.Conditional_F2(1447, 10956, 11051)) || DynAbs.Tracing.TraceSender.Conditional_F3(1447, 11078, 11159))) ? f_1447_10956_11051(f_1447_10974_11020(), f_1447_11022_11028(), f_1447_11030_11038(), f_1447_11040_11050()) : f_1447_11078_11159(f_1447_11096_11136(), f_1447_11138_11146(), f_1447_11148_11158());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 10846, 11171);

                bool
                f_1447_10911_10929()
                {
                    var return_v = IsScriptBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 10911, 10929);
                    return return_v;
                }


                string
                f_1447_10974_11020()
                {
                    var return_v = DebuggerStrings.VariableScriptBreakpointString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 10974, 11020);
                    return return_v;
                }


                string
                f_1447_11022_11028()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11022, 11028);
                    return return_v;
                }


                string
                f_1447_11030_11038()
                {
                    var return_v = Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11030, 11038);
                    return return_v;
                }


                System.Management.Automation.VariableAccessMode
                f_1447_11040_11050()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11040, 11050);
                    return return_v;
                }


                string
                f_1447_10956_11051(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 10956, 11051);
                    return return_v;
                }


                string
                f_1447_11096_11136()
                {
                    var return_v = DebuggerStrings.VariableBreakpointString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11096, 11136);
                    return return_v;
                }


                string
                f_1447_11138_11146()
                {
                    var return_v = Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11138, 11146);
                    return return_v;
                }


                System.Management.Automation.VariableAccessMode
                f_1447_11148_11158()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11148, 11158);
                    return return_v;
                }


                string
                f_1447_11078_11159(string
                formatSpec, string
                o1, System.Management.Automation.VariableAccessMode
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 11078, 11159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 10846, 11171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 10846, 11171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Trigger(string currentScriptFile, bool read)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 11183, 11719);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 11266, 11310) || true) && (f_1447_11270_11278_M(!Enabled))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 11266, 11310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 11297, 11310);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 11266, 11310);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 11326, 11481) || true) && (f_1447_11330_11340() != VariableAccessMode.ReadWrite && (DynAbs.Tracing.TraceSender.Expression_True(1447, 11330, 11449) && f_1447_11376_11386() != ((DynAbs.Tracing.TraceSender.Conditional_F1(1447, 11391, 11395) || ((read && DynAbs.Tracing.TraceSender.Conditional_F2(1447, 11398, 11421)) || DynAbs.Tracing.TraceSender.Conditional_F3(1447, 11424, 11448))) ? VariableAccessMode.Read : VariableAccessMode.Write)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 11326, 11481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 11468, 11481);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 11326, 11481);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 11497, 11679) || true) && (f_1447_11501_11507() == null || (DynAbs.Tracing.TraceSender.Expression_False(1447, 11501, 11587) || f_1447_11519_11587(f_1447_11519_11525(), currentScriptFile, StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 11497, 11679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 11621, 11664);

                    return f_1447_11628_11637(this) == BreakpointAction.Break;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 11497, 11679);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 11695, 11708);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 11183, 11719);

                bool
                f_1447_11270_11278_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11270, 11278);
                    return return_v;
                }


                System.Management.Automation.VariableAccessMode
                f_1447_11330_11340()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11330, 11340);
                    return return_v;
                }


                System.Management.Automation.VariableAccessMode
                f_1447_11376_11386()
                {
                    var return_v = AccessMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11376, 11386);
                    return return_v;
                }


                string
                f_1447_11501_11507()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11501, 11507);
                    return return_v;
                }


                string
                f_1447_11519_11525()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 11519, 11525);
                    return return_v;
                }


                bool
                f_1447_11519_11587(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 11519, 11587);
                    return return_v;
                }


                System.Management.Automation.Breakpoint.BreakpointAction
                f_1447_11628_11637(System.Management.Automation.VariableBreakpoint
                this_param)
                {
                    var return_v = this_param.Trigger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 11628, 11637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 11183, 11719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 11183, 11719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool RemoveSelf(ScriptDebugger debugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 11790, 11845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 11806, 11845);
                return f_1447_11806_11845(debugger, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 11790, 11845);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 11790, 11845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 11790, 11845);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_1447_11806_11845(System.Management.Automation.ScriptDebugger
            this_param, System.Management.Automation.VariableBreakpoint
            breakpoint)
            {
                var return_v = this_param.RemoveVariableBreakpoint(breakpoint);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 11806, 11845);
                return return_v;
            }

        }

        static VariableBreakpoint()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1447, 8906, 11853);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1447, 8906, 11853);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 8906, 11853);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1447, 8906, 11853);

        static string
        f_1447_9198_9204_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 9089, 9246);
            return return_v;
        }


        static string
        f_1447_9509_9515_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 9380, 9618);
            return return_v;
        }


        static string
        f_1447_9869_9875_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 9752, 9921);
            return return_v;
        }


        static string
        f_1447_10192_10198_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 10055, 10305);
            return return_v;
        }

    }
    public class LineBreakpoint : Breakpoint
    {
        public LineBreakpoint(string script, int line)
        : this(f_1447_12187_12193_C(script), line, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 12120, 12219);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 12120, 12219);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 12120, 12219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 12120, 12219);
            }
        }

        public LineBreakpoint(string script, int line, ScriptBlock action)
        : base(f_1447_12435_12441_C(script), action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 12348, 12684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14276, 14315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14421, 14458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14960, 15005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15015, 15068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15078, 15128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 12475, 12584);

                f_1447_12475_12583(!f_1447_12495_12523(script), "Caller to verify script parameter is not null or empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 12598, 12610);

                Line = line;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 12624, 12635);

                Column = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 12649, 12673);

                SequencePointIndex = -1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 12348, 12684);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 12348, 12684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 12348, 12684);
            }
        }

        public LineBreakpoint(string script, int line, int column)
        : this(f_1447_12892_12898_C(script), line, column, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 12813, 12932);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 12813, 12932);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 12813, 12932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 12813, 12932);
            }
        }

        public LineBreakpoint(string script, int line, int column, ScriptBlock action)
        : base(f_1447_13160_13166_C(script), action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 13061, 13414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14276, 14315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14421, 14458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14960, 15005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15015, 15068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15078, 15128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 13200, 13309);

                f_1447_13200_13308(!f_1447_13220_13248(script), "Caller to verify script parameter is not null or empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 13323, 13335);

                Line = line;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 13349, 13365);

                Column = column;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 13379, 13403);

                SequencePointIndex = -1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 13061, 13414);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 13061, 13414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 13061, 13414);
            }
        }

        public LineBreakpoint(string script, int line, int column, int id)
        : this(f_1447_13630_13636_C(script), line, column, null, id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 13543, 13674);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 13543, 13674);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 13543, 13674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 13543, 13674);
            }
        }

        public LineBreakpoint(string script, int line, int column, ScriptBlock action, int id)
        : base(f_1447_13910_13916_C(script), action, id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 13803, 14168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14276, 14315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14421, 14458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14960, 15005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15015, 15068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15078, 15128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 13954, 14063);

                f_1447_13954_14062(!f_1447_13974_14002(script), "Caller to verify script parameter is not null or empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14077, 14089);

                Line = line;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14103, 14119);

                Column = column;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14133, 14157);

                SequencePointIndex = -1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 13803, 14168);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 13803, 14168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 13803, 14168);
            }
        }

        public int Column { get; private set; }

        public int Line { get; private set; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 14655, 14948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 14713, 14937);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1447, 14720, 14731) || ((f_1447_14720_14726() == 0
                && DynAbs.Tracing.TraceSender.Conditional_F2(1447, 14758, 14827)) || DynAbs.Tracing.TraceSender.Conditional_F3(1447, 14854, 14936))) ? f_1447_14758_14827(f_1447_14776_14812(), f_1447_14814_14820(), f_1447_14822_14826()) : f_1447_14854_14936(f_1447_14872_14913(), f_1447_14915_14921(), f_1447_14923_14927(), f_1447_14929_14935());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 14655, 14948);

                int
                f_1447_14720_14726()
                {
                    var return_v = Column;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 14720, 14726);
                    return return_v;
                }


                string
                f_1447_14776_14812()
                {
                    var return_v = DebuggerStrings.LineBreakpointString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 14776, 14812);
                    return return_v;
                }


                string
                f_1447_14814_14820()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 14814, 14820);
                    return return_v;
                }


                int
                f_1447_14822_14826()
                {
                    var return_v = Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 14822, 14826);
                    return return_v;
                }


                string
                f_1447_14758_14827(string
                formatSpec, string
                o1, int
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 14758, 14827);
                    return return_v;
                }


                string
                f_1447_14872_14913()
                {
                    var return_v = DebuggerStrings.StatementBreakpointString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 14872, 14913);
                    return return_v;
                }


                string
                f_1447_14915_14921()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 14915, 14921);
                    return return_v;
                }


                int
                f_1447_14923_14927()
                {
                    var return_v = Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 14923, 14927);
                    return return_v;
                }


                int
                f_1447_14929_14935()
                {
                    var return_v = Column;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 14929, 14935);
                    return return_v;
                }


                string
                f_1447_14854_14936(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 14854, 14936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 14655, 14948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 14655, 14948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int SequencePointIndex { get; set; }

        internal IScriptExtent[] SequencePoints { get; set; }

        internal BitArray BreakpointBitArray { get; set; }
        private class CheckBreakpointInScript : AstVisitor
        {
            public static bool IsInNestedScriptBlock(Ast ast, LineBreakpoint breakpoint)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1447, 15215, 15496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15324, 15395);

                    var
                    visitor = new CheckBreakpointInScript { _breakpoint = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => breakpoint, 1447, 15338, 15394) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15413, 15440);

                    f_1447_15413_15439(ast, visitor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15458, 15481);

                    return visitor._result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1447, 15215, 15496);

                    System.Management.Automation.Language.AstVisitAction
                    f_1447_15413_15439(System.Management.Automation.Language.Ast
                    this_param, System.Management.Automation.LineBreakpoint.CheckBreakpointInScript
                    visitor)
                    {
                        var return_v = this_param.InternalVisit((System.Management.Automation.Language.AstVisitor)visitor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 15413, 15439);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 15215, 15496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 15215, 15496);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private LineBreakpoint _breakpoint;

            private bool _result;

            public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 15598, 16238);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15730, 15952) || true) && (f_1447_15734_15822(f_1447_15734_15762(functionDefinitionAst), f_1447_15785_15801(_breakpoint), f_1447_15803_15821(_breakpoint)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 15730, 15952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15864, 15879);

                        _result = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15901, 15933);

                        return AstVisitAction.StopVisit;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 15730, 15952);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 16188, 16223);

                    return AstVisitAction.SkipChildren;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 15598, 16238);

                    System.Management.Automation.Language.IScriptExtent
                    f_1447_15734_15762(System.Management.Automation.Language.FunctionDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 15734, 15762);
                        return return_v;
                    }


                    int
                    f_1447_15785_15801(System.Management.Automation.LineBreakpoint
                    this_param)
                    {
                        var return_v = this_param.Line;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 15785, 15801);
                        return return_v;
                    }


                    int
                    f_1447_15803_15821(System.Management.Automation.LineBreakpoint
                    this_param)
                    {
                        var return_v = this_param.Column;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 15803, 15821);
                        return return_v;
                    }


                    bool
                    f_1447_15734_15822(System.Management.Automation.Language.IScriptExtent
                    extent, int
                    line, int
                    column)
                    {
                        var return_v = extent.ContainsLineAndColumn(line, column);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 15734, 15822);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 15598, 16238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 15598, 16238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 16254, 16906);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 16395, 16620) || true) && (f_1447_16399_16490(f_1447_16399_16430(scriptBlockExpressionAst), f_1447_16453_16469(_breakpoint), f_1447_16471_16489(_breakpoint)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 16395, 16620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 16532, 16547);

                        _result = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 16569, 16601);

                        return AstVisitAction.StopVisit;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 16395, 16620);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 16856, 16891);

                    return AstVisitAction.SkipChildren;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 16254, 16906);

                    System.Management.Automation.Language.IScriptExtent
                    f_1447_16399_16430(System.Management.Automation.Language.ScriptBlockExpressionAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 16399, 16430);
                        return return_v;
                    }


                    int
                    f_1447_16453_16469(System.Management.Automation.LineBreakpoint
                    this_param)
                    {
                        var return_v = this_param.Line;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 16453, 16469);
                        return return_v;
                    }


                    int
                    f_1447_16471_16489(System.Management.Automation.LineBreakpoint
                    this_param)
                    {
                        var return_v = this_param.Column;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 16471, 16489);
                        return return_v;
                    }


                    bool
                    f_1447_16399_16490(System.Management.Automation.Language.IScriptExtent
                    extent, int
                    line, int
                    column)
                    {
                        var return_v = extent.ContainsLineAndColumn(line, column);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 16399, 16490);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 16254, 16906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 16254, 16906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public CheckBreakpointInScript()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1447, 15140, 16917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15535, 15546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 15574, 15581);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1447, 15140, 16917);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 15140, 16917);
            }


            static CheckBreakpointInScript()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1447, 15140, 16917);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1447, 15140, 16917);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 15140, 16917);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1447, 15140, 16917);
        }

        internal bool TrySetBreakpoint(string scriptFile, FunctionContext functionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 16929, 20764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17036, 17135);

                f_1447_17036_17134(f_1447_17055_17073() == -1, "shouldn't be trying to set on a pending breakpoint");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17151, 17254) || true) && (!f_1447_17156_17222(scriptFile, f_1447_17174_17185(this), StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 17151, 17254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17241, 17254);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 17151, 17254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17352, 17384);

                bool
                couldBeInNestedScriptBlock
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17398, 17445);

                var
                scriptBlock = functionContext._scriptBlock
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17459, 18379) || true) && (scriptBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 17459, 18379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17516, 17542);

                    var
                    ast = f_1447_17526_17541(scriptBlock)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17560, 17647) || true) && (!f_1447_17565_17611(f_1447_17565_17575(ast), f_1447_17598_17602(), f_1447_17604_17610()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 17560, 17647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17634, 17647);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 17560, 17647);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17667, 17720);

                    var
                    sequencePoints = functionContext._sequencePoints
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 17738, 18122) || true) && (f_1447_17742_17763(sequencePoints) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1447, 17742, 17815) && sequencePoints[0] == f_1447_17793_17815(f_1447_17793_17808(scriptBlock))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 17738, 18122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 18090, 18103);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 17738, 18122);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 18142, 18263);

                    couldBeInNestedScriptBlock = f_1447_18171_18262(f_1447_18217_18255(((IParameterMetadataProvider)ast)), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 17459, 18379);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 17459, 18379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 18329, 18364);

                    couldBeInNestedScriptBlock = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 17459, 18379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 18395, 18418);

                int
                sequencePointIndex
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 18432, 18525);

                var
                sequencePoint = f_1447_18452_18524(functionContext, f_1447_18487_18491(), f_1447_18493_18499(), out sequencePointIndex)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 18539, 19177) || true) && (sequencePoint != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 18539, 19177);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 18927, 19162) || true) && (!couldBeInNestedScriptBlock || (DynAbs.Tracing.TraceSender.Expression_False(1447, 18931, 19016) || (f_1447_18963_18992(sequencePoint) == f_1447_18996_19000() && (DynAbs.Tracing.TraceSender.Expression_True(1447, 18963, 19015) && f_1447_19004_19010() == 0))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 18927, 19162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 19058, 19109);

                        f_1447_19058_19108(this, functionContext, sequencePointIndex);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 19131, 19143);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 18927, 19162);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 18539, 19177);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 19300, 19392) || true) && (couldBeInNestedScriptBlock)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 19300, 19392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 19364, 19377);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 19300, 19392);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 19659, 20384) || true) && (scriptBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 19659, 20384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 19716, 19742);

                    var
                    ast = f_1447_19726_19741(scriptBlock)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 19760, 19813);

                    var
                    bodyAst = f_1447_19774_19812(((IParameterMetadataProvider)ast))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 19831, 20369) || true) && ((f_1447_19836_19861(bodyAst) == null || (DynAbs.Tracing.TraceSender.Expression_False(1447, 19836, 19927) || f_1447_19873_19927(f_1447_19873_19905(f_1447_19873_19898(bodyAst)), f_1447_19914_19918(), f_1447_19920_19926()))) && (DynAbs.Tracing.TraceSender.Expression_True(1447, 19835, 20032) && (f_1447_19954_19972(bodyAst) == null || (DynAbs.Tracing.TraceSender.Expression_False(1447, 19954, 20031) || f_1447_19984_20031(f_1447_19984_20009(f_1447_19984_20002(bodyAst)), f_1447_20018_20022(), f_1447_20024_20030())))) && (DynAbs.Tracing.TraceSender.Expression_True(1447, 19835, 20140) && (f_1447_20058_20078(bodyAst) == null || (DynAbs.Tracing.TraceSender.Expression_False(1447, 20058, 20139) || f_1447_20090_20139(f_1447_20090_20117(f_1447_20090_20110(bodyAst)), f_1447_20126_20130(), f_1447_20132_20138())))) && (DynAbs.Tracing.TraceSender.Expression_True(1447, 19835, 20240) && (f_1447_20166_20182(bodyAst) == null || (DynAbs.Tracing.TraceSender.Expression_False(1447, 20166, 20239) || f_1447_20194_20239(f_1447_20194_20217(f_1447_20194_20210(bodyAst)), f_1447_20226_20230(), f_1447_20232_20238())))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 19831, 20369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 20282, 20316);

                        f_1447_20282_20315(this, functionContext, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 20338, 20350);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 19831, 20369);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 19659, 20384);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 20496, 20724) || true) && (f_1447_20500_20506() == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1447, 20500, 20594) && f_1447_20515_20586(functionContext, f_1447_20550_20554() + 1, 0, out sequencePointIndex) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 20496, 20724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 20628, 20679);

                    f_1447_20628_20678(this, functionContext, sequencePointIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 20697, 20709);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 20496, 20724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 20740, 20753);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 16929, 20764);

                int
                f_1447_17055_17073()
                {
                    var return_v = SequencePointIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 17055, 17073);
                    return return_v;
                }


                int
                f_1447_17036_17134(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 17036, 17134);
                    return 0;
                }


                string
                f_1447_17174_17185(System.Management.Automation.LineBreakpoint
                this_param)
                {
                    var return_v = this_param.Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 17174, 17185);
                    return return_v;
                }


                bool
                f_1447_17156_17222(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 17156, 17222);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1447_17526_17541(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 17526, 17541);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1447_17565_17575(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 17565, 17575);
                    return return_v;
                }


                int
                f_1447_17598_17602()
                {
                    var return_v = Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 17598, 17602);
                    return return_v;
                }


                int
                f_1447_17604_17610()
                {
                    var return_v = Column;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 17604, 17610);
                    return return_v;
                }


                bool
                f_1447_17565_17611(System.Management.Automation.Language.IScriptExtent
                extent, int
                line, int
                column)
                {
                    var return_v = extent.ContainsLineAndColumn(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 17565, 17611);
                    return return_v;
                }


                int
                f_1447_17742_17763(System.Management.Automation.Language.IScriptExtent[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 17742, 17763);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1447_17793_17808(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 17793, 17808);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1447_17793_17815(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 17793, 17815);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1447_18217_18255(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 18217, 18255);
                    return return_v;
                }


                bool
                f_1447_18171_18262(System.Management.Automation.Language.ScriptBlockAst
                ast, System.Management.Automation.LineBreakpoint
                breakpoint)
                {
                    var return_v = CheckBreakpointInScript.IsInNestedScriptBlock((System.Management.Automation.Language.Ast)ast, breakpoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 18171, 18262);
                    return return_v;
                }


                int
                f_1447_18487_18491()
                {
                    var return_v = Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 18487, 18491);
                    return return_v;
                }


                int
                f_1447_18493_18499()
                {
                    var return_v = Column;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 18493, 18499);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1447_18452_18524(System.Management.Automation.Language.FunctionContext
                functionContext, int
                line, int
                column, out int
                sequencePointIndex)
                {
                    var return_v = FindSequencePoint(functionContext, line, column, out sequencePointIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 18452, 18524);
                    return return_v;
                }


                int
                f_1447_18963_18992(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 18963, 18992);
                    return return_v;
                }


                int
                f_1447_18996_19000()
                {
                    var return_v = Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 18996, 19000);
                    return return_v;
                }


                int
                f_1447_19004_19010()
                {
                    var return_v = Column;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19004, 19010);
                    return return_v;
                }


                int
                f_1447_19058_19108(System.Management.Automation.LineBreakpoint
                this_param, System.Management.Automation.Language.FunctionContext
                functionContext, int
                sequencePointIndex)
                {
                    this_param.SetBreakpoint(functionContext, sequencePointIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 19058, 19108);
                    return 0;
                }


                System.Management.Automation.Language.Ast
                f_1447_19726_19741(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19726, 19741);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1447_19774_19812(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19774, 19812);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1447_19836_19861(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.DynamicParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19836, 19861);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1447_19873_19898(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.DynamicParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19873, 19898);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1447_19873_19905(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19873, 19905);
                    return return_v;
                }


                int
                f_1447_19914_19918()
                {
                    var return_v = Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19914, 19918);
                    return return_v;
                }


                int
                f_1447_19920_19926()
                {
                    var return_v = Column;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19920, 19926);
                    return return_v;
                }


                bool
                f_1447_19873_19927(System.Management.Automation.Language.IScriptExtent
                extent, int
                line, int
                column)
                {
                    var return_v = extent.IsAfter(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 19873, 19927);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1447_19954_19972(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.BeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19954, 19972);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1447_19984_20002(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.BeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19984, 20002);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1447_19984_20009(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 19984, 20009);
                    return return_v;
                }


                int
                f_1447_20018_20022()
                {
                    var return_v = Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20018, 20022);
                    return return_v;
                }


                int
                f_1447_20024_20030()
                {
                    var return_v = Column;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20024, 20030);
                    return return_v;
                }


                bool
                f_1447_19984_20031(System.Management.Automation.Language.IScriptExtent
                extent, int
                line, int
                column)
                {
                    var return_v = extent.IsAfter(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 19984, 20031);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1447_20058_20078(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20058, 20078);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1447_20090_20110(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20090, 20110);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1447_20090_20117(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20090, 20117);
                    return return_v;
                }


                int
                f_1447_20126_20130()
                {
                    var return_v = Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20126, 20130);
                    return return_v;
                }


                int
                f_1447_20132_20138()
                {
                    var return_v = Column;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20132, 20138);
                    return return_v;
                }


                bool
                f_1447_20090_20139(System.Management.Automation.Language.IScriptExtent
                extent, int
                line, int
                column)
                {
                    var return_v = extent.IsAfter(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 20090, 20139);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1447_20166_20182(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20166, 20182);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1447_20194_20210(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20194, 20210);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1447_20194_20217(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20194, 20217);
                    return return_v;
                }


                int
                f_1447_20226_20230()
                {
                    var return_v = Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20226, 20230);
                    return return_v;
                }


                int
                f_1447_20232_20238()
                {
                    var return_v = Column;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20232, 20238);
                    return return_v;
                }


                bool
                f_1447_20194_20239(System.Management.Automation.Language.IScriptExtent
                extent, int
                line, int
                column)
                {
                    var return_v = extent.IsAfter(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 20194, 20239);
                    return return_v;
                }


                int
                f_1447_20282_20315(System.Management.Automation.LineBreakpoint
                this_param, System.Management.Automation.Language.FunctionContext
                functionContext, int
                sequencePointIndex)
                {
                    this_param.SetBreakpoint(functionContext, sequencePointIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 20282, 20315);
                    return 0;
                }


                int
                f_1447_20500_20506()
                {
                    var return_v = Column;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20500, 20506);
                    return return_v;
                }


                int
                f_1447_20550_20554()
                {
                    var return_v = Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 20550, 20554);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1447_20515_20586(System.Management.Automation.Language.FunctionContext
                functionContext, int
                line, int
                column, out int
                sequencePointIndex)
                {
                    var return_v = FindSequencePoint(functionContext, line, column, out sequencePointIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 20515, 20586);
                    return return_v;
                }


                int
                f_1447_20628_20678(System.Management.Automation.LineBreakpoint
                this_param, System.Management.Automation.Language.FunctionContext
                functionContext, int
                sequencePointIndex)
                {
                    this_param.SetBreakpoint(functionContext, sequencePointIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 20628, 20678);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 16929, 20764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 16929, 20764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IScriptExtent FindSequencePoint(FunctionContext functionContext, int line, int column, out int sequencePointIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1447, 20776, 21386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 20930, 20983);

                var
                sequencePoints = functionContext._sequencePoints
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21008, 21013);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 20999, 21309) || true) && (i < f_1447_21019_21040(sequencePoints))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21042, 21045)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 20999, 21309))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 20999, 21309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21079, 21110);

                        var
                        extent = sequencePoints[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21128, 21294) || true) && (f_1447_21132_21174(extent, line, column))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 21128, 21294);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21216, 21239);

                            sequencePointIndex = i;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21261, 21275);

                            return extent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 21128, 21294);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1447, 1, 311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1447, 1, 311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21325, 21349);

                sequencePointIndex = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21363, 21375);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1447, 20776, 21386);

                int
                f_1447_21019_21040(System.Management.Automation.Language.IScriptExtent[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 21019, 21040);
                    return return_v;
                }


                bool
                f_1447_21132_21174(System.Management.Automation.Language.IScriptExtent
                extent, int
                line, int
                column)
                {
                    var return_v = extent.ContainsLineAndColumn(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 21132, 21174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 20776, 21386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 20776, 21386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetBreakpoint(FunctionContext functionContext, int sequencePointIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 21398, 21906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21648, 21703);

                this.BreakpointBitArray = functionContext._breakPoints;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21717, 21771);

                this.SequencePoints = functionContext._sequencePoints;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21787, 21827);

                SequencePointIndex = sequencePointIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 21841, 21895);

                f_1447_21841_21894(f_1447_21841_21864(this), f_1447_21869_21887(), true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 21398, 21906);

                System.Collections.BitArray
                f_1447_21841_21864(System.Management.Automation.LineBreakpoint
                this_param)
                {
                    var return_v = this_param.BreakpointBitArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 21841, 21864);
                    return return_v;
                }


                int
                f_1447_21869_21887()
                {
                    var return_v = SequencePointIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 21869, 21887);
                    return return_v;
                }


                int
                f_1447_21841_21894(System.Collections.BitArray
                this_param, int
                index, bool
                value)
                {
                    this_param.Set(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 21841, 21894);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 21398, 21906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 21398, 21906);
            }
        }

        internal override bool RemoveSelf(ScriptDebugger debugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1447, 21918, 23329);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 22001, 23259) || true) && (f_1447_22005_22024(this) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 22001, 23259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 22259, 22332);

                    var
                    boundBreakPoints = f_1447_22282_22331(debugger, f_1447_22311_22330(this))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 22350, 23244) || true) && (boundBreakPoints != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 22350, 23244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 22420, 22609);

                        f_1447_22420_22608(f_1447_22439_22470(boundBreakPoints, this), "If we set _scriptBlock, we should have also added the breakpoint to the bound breakpoint list");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 22631, 22661);

                        f_1447_22631_22660(boundBreakPoints, this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 22685, 23225) || true) && (f_1447_22689_22781(boundBreakPoints, breakpoint => breakpoint.SequencePointIndex != this.SequencePointIndex))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1447, 22685, 23225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 23147, 23202);

                            f_1447_23147_23201(f_1447_23147_23170(this), f_1447_23175_23193(), false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 22685, 23225);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 22350, 23244);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1447, 22001, 23259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1447, 23275, 23318);

                return f_1447_23282_23317(debugger, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1447, 21918, 23329);

                System.Management.Automation.Language.IScriptExtent[]
                f_1447_22005_22024(System.Management.Automation.LineBreakpoint
                this_param)
                {
                    var return_v = this_param.SequencePoints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 22005, 22024);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent[]
                f_1447_22311_22330(System.Management.Automation.LineBreakpoint
                this_param)
                {
                    var return_v = this_param.SequencePoints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 22311, 22330);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.LineBreakpoint>
                f_1447_22282_22331(System.Management.Automation.ScriptDebugger
                this_param, System.Management.Automation.Language.IScriptExtent[]
                sequencePoints)
                {
                    var return_v = this_param.GetBoundBreakpoints(sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 22282, 22331);
                    return return_v;
                }


                bool
                f_1447_22439_22470(System.Collections.Generic.List<System.Management.Automation.LineBreakpoint>
                this_param, System.Management.Automation.LineBreakpoint
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 22439, 22470);
                    return return_v;
                }


                int
                f_1447_22420_22608(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 22420, 22608);
                    return 0;
                }


                bool
                f_1447_22631_22660(System.Collections.Generic.List<System.Management.Automation.LineBreakpoint>
                this_param, System.Management.Automation.LineBreakpoint
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 22631, 22660);
                    return return_v;
                }


                bool
                f_1447_22689_22781(System.Collections.Generic.List<System.Management.Automation.LineBreakpoint>
                source, System.Func<System.Management.Automation.LineBreakpoint, bool>
                predicate)
                {
                    var return_v = source.All<System.Management.Automation.LineBreakpoint>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 22689, 22781);
                    return return_v;
                }


                System.Collections.BitArray
                f_1447_23147_23170(System.Management.Automation.LineBreakpoint
                this_param)
                {
                    var return_v = this_param.BreakpointBitArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 23147, 23170);
                    return return_v;
                }


                int
                f_1447_23175_23193()
                {
                    var return_v = SequencePointIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1447, 23175, 23193);
                    return return_v;
                }


                int
                f_1447_23147_23201(System.Collections.BitArray
                this_param, int
                index, bool
                value)
                {
                    this_param.Set(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 23147, 23201);
                    return 0;
                }


                bool
                f_1447_23282_23317(System.Management.Automation.ScriptDebugger
                this_param, System.Management.Automation.LineBreakpoint
                breakpoint)
                {
                    var return_v = this_param.RemoveLineBreakpoint(breakpoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 23282, 23317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1447, 21918, 23329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 21918, 23329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LineBreakpoint()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1447, 11946, 23336);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1447, 11946, 23336);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1447, 11946, 23336);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1447, 11946, 23336);

        static string
        f_1447_12187_12193_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 12120, 12219);
            return return_v;
        }


        bool
        f_1447_12495_12523(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 12495, 12523);
            return return_v;
        }


        int
        f_1447_12475_12583(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 12475, 12583);
            return 0;
        }


        static string
        f_1447_12435_12441_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 12348, 12684);
            return return_v;
        }


        static string
        f_1447_12892_12898_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 12813, 12932);
            return return_v;
        }


        bool
        f_1447_13220_13248(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 13220, 13248);
            return return_v;
        }


        int
        f_1447_13200_13308(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 13200, 13308);
            return 0;
        }


        static string
        f_1447_13160_13166_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 13061, 13414);
            return return_v;
        }


        static string
        f_1447_13630_13636_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 13543, 13674);
            return return_v;
        }


        bool
        f_1447_13974_14002(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 13974, 14002);
            return return_v;
        }


        int
        f_1447_13954_14062(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1447, 13954, 14062);
            return 0;
        }


        static string
        f_1447_13910_13916_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1447, 13803, 14168);
            return return_v;
        }

    }
}
