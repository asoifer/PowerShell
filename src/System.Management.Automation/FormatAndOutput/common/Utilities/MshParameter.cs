// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Text;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal class MshParameter
    {
        internal Hashtable hash;

        internal object GetEntry(string key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1138, 760, 947);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 821, 892) || true) && (f_1138_825_851(this.hash, key))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 821, 892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 870, 892);

                    return f_1138_877_891(this.hash, key);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 821, 892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 908, 936);

                return f_1138_915_935();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1138, 760, 947);

                bool
                f_1138_825_851(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 825, 851);
                    return return_v;
                }


                object
                f_1138_877_891(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 877, 891);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1138_915_935()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 915, 935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 760, 947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 760, 947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MshParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1138, 673, 954);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 736, 747);
            this.hash = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1138, 673, 954);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 673, 954);
        }


        static MshParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1138, 673, 954);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1138, 673, 954);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 673, 954);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1138, 673, 954);
    }
    internal class NameEntryDefinition : HashtableEntryDefinition
    {
        internal const string
        NameEntryKey = "name"
        ;

        internal NameEntryDefinition()
        : base(f_1138_1145_1157_C(NameEntryKey), new string[] { FormatParameterDefinitionKeys.LabelEntryKey }, new Type[] { typeof(string) }, false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1138, 1094, 1280);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1138, 1094, 1280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 1094, 1280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 1094, 1280);
            }
        }

        static NameEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1138, 962, 1287);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 1062, 1083);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1138, 962, 1287);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 962, 1287);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1138, 962, 1287);

        static string
        f_1138_1145_1157_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1138, 1094, 1280);
            return return_v;
        }

    }
    internal class HashtableEntryDefinition
    {
        internal HashtableEntryDefinition(string name, IEnumerable<string> secondaryNames, Type[] types, bool mandatory)
        : this(f_1138_1694_1698_C(name), types, mandatory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1138, 1561, 1785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 1742, 1774);

                SecondaryNames = secondaryNames;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1138, 1561, 1785);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 1561, 1785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 1561, 1785);
            }
        }

        internal HashtableEntryDefinition(string name, Type[] types, bool mandatory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1138, 1797, 1995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 3429, 3461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 3473, 3510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 3522, 3554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 3566, 3618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 1898, 1913);

                KeyName = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 1927, 1948);

                AllowedTypes = types;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 1962, 1984);

                Mandatory = mandatory;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1138, 1797, 1995);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 1797, 1995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 1797, 1995);
            }
        }

        internal HashtableEntryDefinition(string name, Type[] types)
        : this(f_1138_2088_2092_C(name), types, false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1138, 2007, 2129);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1138, 2007, 2129);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 2007, 2129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 2007, 2129);
            }
        }

        internal virtual Hashtable CreateHashtableFromSingleType(object val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1138, 2141, 2434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 2376, 2423);

                throw f_1138_2382_2422();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1138, 2141, 2434);

                System.Management.Automation.PSNotSupportedException
                f_1138_2382_2422()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 2382, 2422);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 2141, 2434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 2141, 2434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsKeyMatch(string key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1138, 2446, 3033);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 2507, 2634) || true) && (f_1138_2511_2573(key, f_1138_2560_2572(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 2507, 2634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 2607, 2619);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 2507, 2634);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 2650, 2993) || true) && (f_1138_2654_2673(this) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 2650, 2993);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 2715, 2978);
                        foreach (string secondaryKey in f_1138_2747_2766_I(f_1138_2747_2766(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 2715, 2978);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 2808, 2959) || true) && (f_1138_2812_2874(key, secondaryKey))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 2808, 2959);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 2924, 2936);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 2808, 2959);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 2715, 2978);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1138, 1, 264);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1138, 1, 264);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 2650, 2993);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 3009, 3022);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1138, 2446, 3033);

                string
                f_1138_2560_2572(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 2560, 2572);
                    return return_v;
                }


                bool
                f_1138_2511_2573(string
                key, string
                normalizedKey)
                {
                    var return_v = CommandParameterDefinition.FindPartialMatch(key, normalizedKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 2511, 2573);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1138_2654_2673(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.SecondaryNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 2654, 2673);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1138_2747_2766(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.SecondaryNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 2747, 2766);
                    return return_v;
                }


                bool
                f_1138_2812_2874(string
                key, string
                normalizedKey)
                {
                    var return_v = CommandParameterDefinition.FindPartialMatch(key, normalizedKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 2812, 2874);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1138_2747_2766_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 2747, 2766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 2446, 3033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 2446, 3033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual object Verify(object val,
                                                TerminatingErrorContext invocationContext,
                                                bool originalParameterWasHashTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1138, 3045, 3296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 3273, 3285);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1138, 3045, 3296);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 3045, 3296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 3045, 3296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual object ComputeDefaultValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1138, 3308, 3417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 3378, 3406);

                return f_1138_3385_3405();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1138, 3308, 3417);

                System.Management.Automation.PSObject
                f_1138_3385_3405()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 3385, 3405);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 3308, 3417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 3308, 3417);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string KeyName { get; }

        internal Type[] AllowedTypes { get; }

        internal bool Mandatory { get; }

        internal IEnumerable<string> SecondaryNames { get; }

        static HashtableEntryDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1138, 1505, 3625);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1138, 1505, 3625);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 1505, 3625);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1138, 1505, 3625);

        static string
        f_1138_1694_1698_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1138, 1561, 1785);
            return return_v;
        }


        static string
        f_1138_2088_2092_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1138, 2007, 2129);
            return return_v;
        }

    }
    internal abstract class CommandParameterDefinition
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal CommandParameterDefinition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1138, 3814, 3998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 7896, 7946);
                this.hashEntries = f_1138_7910_7946();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 3974, 3987);

                f_1138_3974_3986(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1138, 3814, 3998);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 3814, 3998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 3814, 3998);
            }
        }

        protected abstract void SetEntries();

        internal virtual MshParameter CreateInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1138, 4059, 4136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 4108, 4134);

                return f_1138_4115_4133();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1138, 4059, 4136);

                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1138_4115_4133()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.MshParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 4115, 4133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 4059, 4136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 4059, 4136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal HashtableEntryDefinition MatchEntry(string keyName, TerminatingErrorContext invocationContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1138, 4716, 6090);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 4844, 4946) || true) && (f_1138_4848_4877(keyName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 4844, 4946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 4896, 4946);

                    f_1138_4896_4945("keyName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 4844, 4946);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 4962, 5008);

                HashtableEntryDefinition
                matchingEntry = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 5031, 5036);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 5022, 5792) || true) && (k < f_1138_5042_5064(this.hashEntries))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 5066, 5069)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 5022, 5792))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 5022, 5792);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 5103, 5777) || true) && (f_1138_5107_5146(f_1138_5107_5126(this.hashEntries, k), keyName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 5103, 5777);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 5228, 5758) || true) && (matchingEntry == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 5228, 5758);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 5440, 5476);

                                matchingEntry = f_1138_5456_5475(this.hashEntries, k);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 5228, 5758);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 5228, 5758);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 5651, 5735);

                                f_1138_5651_5734(invocationContext, keyName, matchingEntry, f_1138_5714_5733(this.hashEntries, k));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 5228, 5758);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 5103, 5777);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1138, 1, 771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1138, 1, 771);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 5808, 5953) || true) && (matchingEntry != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 5808, 5953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 5917, 5938);

                    return matchingEntry;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 5808, 5953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 6007, 6053);

                f_1138_6007_6052(invocationContext, keyName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 6067, 6079);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1138, 4716, 6090);

                bool
                f_1138_4848_4877(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 4848, 4877);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1138_4896_4945(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 4896, 4945);
                    return return_v;
                }


                int
                f_1138_5042_5064(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 5042, 5064);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_5107_5126(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 5107, 5126);
                    return return_v;
                }


                bool
                f_1138_5107_5146(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param, string
                key)
                {
                    var return_v = this_param.IsKeyMatch(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 5107, 5146);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_5456_5475(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 5456, 5475);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_5714_5733(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 5714, 5733);
                    return return_v;
                }


                int
                f_1138_5651_5734(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                keyName, Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                matchingEntry, Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                currentEntry)
                {
                    ProcessAmbiguousKey(invocationContext, keyName, matchingEntry, currentEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 5651, 5734);
                    return 0;
                }


                int
                f_1138_6007_6052(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                keyName)
                {
                    ProcessIllegalKey(invocationContext, keyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 6007, 6052);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 4716, 6090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 4716, 6090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool FindPartialMatch(string key, string normalizedKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 6102, 6779);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 6198, 6552) || true) && (f_1138_6202_6212(key) < f_1138_6215_6235(normalizedKey))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 6198, 6552);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 6323, 6537) || true) && (f_1138_6327_6421(key, f_1138_6346_6384(normalizedKey, 0, f_1138_6373_6383(key)), StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 6323, 6537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 6506, 6518);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 6323, 6537);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 6198, 6552);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 6568, 6739) || true) && (f_1138_6572_6641(key, normalizedKey, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 6568, 6739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 6712, 6724);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 6568, 6739);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 6755, 6768);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 6102, 6779);

                int
                f_1138_6202_6212(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 6202, 6212);
                    return return_v;
                }


                int
                f_1138_6215_6235(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 6215, 6235);
                    return return_v;
                }


                int
                f_1138_6373_6383(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 6373, 6383);
                    return return_v;
                }


                string
                f_1138_6346_6384(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 6346, 6384);
                    return return_v;
                }


                bool
                f_1138_6327_6421(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 6327, 6421);
                    return return_v;
                }


                bool
                f_1138_6572_6641(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 6572, 6641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 6102, 6779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 6102, 6779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ProcessAmbiguousKey(TerminatingErrorContext invocationContext,
                                                    string keyName,
                                                    HashtableEntryDefinition matchingEntry,
                                                    HashtableEntryDefinition currentEntry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 6827, 7438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 7164, 7311);

                string
                msg = f_1138_7177_7310(f_1138_7195_7238(), keyName, f_1138_7266_7287(matchingEntry), f_1138_7289_7309(currentEntry))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 7327, 7427);

                f_1138_7327_7426(invocationContext, "DictionaryKeyAmbiguous", msg);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 6827, 7438);

                string
                f_1138_7195_7238()
                {
                    var return_v = FormatAndOut_MshParameter.AmbiguousKeyError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 7195, 7238);
                    return return_v;
                }


                string
                f_1138_7266_7287(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 7266, 7287);
                    return return_v;
                }


                string
                f_1138_7289_7309(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 7289, 7309);
                    return return_v;
                }


                string
                f_1138_7177_7310(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 7177, 7310);
                    return return_v;
                }


                int
                f_1138_7327_7426(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 7327, 7426);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 6827, 7438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 6827, 7438);
            }
        }

        private static void ProcessIllegalKey(TerminatingErrorContext invocationContext,
                                                    string keyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 7450, 7824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 7616, 7699);

                string
                msg = f_1138_7629_7698(f_1138_7647_7688(), keyName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 7715, 7813);

                f_1138_7715_7812(invocationContext, "DictionaryKeyIllegal", msg);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 7450, 7824);

                string
                f_1138_7647_7688()
                {
                    var return_v = FormatAndOut_MshParameter.IllegalKeyError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 7647, 7688);
                    return return_v;
                }


                string
                f_1138_7629_7698(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 7629, 7698);
                    return return_v;
                }


                int
                f_1138_7715_7812(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 7715, 7812);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 7450, 7824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 7450, 7824);
            }
        }

        internal List<HashtableEntryDefinition> hashEntries;

        static CommandParameterDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1138, 3747, 7954);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1138, 3747, 7954);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 3747, 7954);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1138, 3747, 7954);

        int
        f_1138_3974_3986(Microsoft.PowerShell.Commands.Internal.Format.CommandParameterDefinition
        this_param)
        {
            this_param.SetEntries();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 3974, 3986);
            return 0;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
        f_1138_7910_7946()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 7910, 7946);
            return return_v;
        }

    }
    internal sealed class ParameterProcessor
    {
        [TraceSource("ParameterProcessor", "ParameterProcessor")]
        internal static PSTraceSource tracer;

        internal static void ThrowParameterBindingException(TerminatingErrorContext invocationContext,
                                                                    string errorId,
                                                                    string msg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 8507, 9169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 8776, 9026);

                ErrorRecord
                errorRecord = f_1138_8802_9025(f_1138_8852_8879(), errorId, ErrorCategory.InvalidArgument, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9042, 9091);

                errorRecord.ErrorDetails = f_1138_9069_9090(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9105, 9158);

                f_1138_9105_9157(invocationContext, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 8507, 9169);

                System.NotSupportedException
                f_1138_8852_8879()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 8852, 8879);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1138_8802_9025(System.NotSupportedException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 8802, 9025);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1138_9069_9090(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 9069, 9090);
                    return return_v;
                }


                int
                f_1138_9105_9157(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 9105, 9157);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 8507, 9169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 8507, 9169);
            }
        }

        internal ParameterProcessor(CommandParameterDefinition p)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1138, 9181, 9288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20584, 20600);
                this._paramDef = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9263, 9277);

                _paramDef = p;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1138, 9181, 9288);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 9181, 9288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 9181, 9288);
            }
        }

        internal List<MshParameter> ProcessParameters(object[] p, TerminatingErrorContext invocationContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1138, 9362, 11156);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9487, 9548) || true) && (p == null || (DynAbs.Tracing.TraceSender.Expression_False(1138, 9491, 9517) || f_1138_9504_9512(p) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 9487, 9548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9536, 9548);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 9487, 9548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9564, 9617);

                List<MshParameter>
                retVal = f_1138_9592_9616()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9631, 9654);

                MshParameter
                currParam
                = default(MshParameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9670, 9713);

                bool
                originalParameterWasHashTable = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9736, 9741);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9727, 11115) || true) && (k < f_1138_9747_9755(p))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9757, 9760)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 9727, 11115))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 9727, 11115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9853, 9892);

                        currParam = f_1138_9865_9891(_paramDef);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9910, 9949);

                        var
                        actualObject = f_1138_9929_9948(p[k])
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 9967, 10870) || true) && (actualObject is IDictionary)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 9967, 10870);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 10040, 10077);

                            originalParameterWasHashTable = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 10099, 10178);

                            currParam.hash = f_1138_10116_10177(this, actualObject, invocationContext);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 9967, 10870);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 9967, 10870);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 10220, 10870) || true) && ((actualObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1138, 10224, 10332) && f_1138_10250_10332(f_1138_10270_10292(actualObject), f_1138_10294_10331(f_1138_10294_10318(_paramDef.hashEntries, 0)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 10220, 10870);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 10455, 10541);

                                currParam.hash = f_1138_10472_10540(f_1138_10472_10496(_paramDef.hashEntries, 0), actualObject);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 10220, 10870);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 10220, 10870);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 10751, 10851);

                                f_1138_10751_10850(invocationContext, actualObject, f_1138_10812_10849(f_1138_10812_10836(_paramDef.hashEntries, 0)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 10220, 10870);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 9967, 10870);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 10971, 11060);

                        f_1138_10971_11059(this, currParam, invocationContext, originalParameterWasHashTable);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11078, 11100);

                        f_1138_11078_11099(retVal, currParam);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1138, 1, 1389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1138, 1, 1389);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11131, 11145);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1138, 9362, 11156);

                int
                f_1138_9504_9512(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 9504, 9512);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                f_1138_9592_9616()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 9592, 9616);
                    return return_v;
                }


                int
                f_1138_9747_9755(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 9747, 9755);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1138_9865_9891(Microsoft.PowerShell.Commands.Internal.Format.CommandParameterDefinition
                this_param)
                {
                    var return_v = this_param.CreateInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 9865, 9891);
                    return return_v;
                }


                object
                f_1138_9929_9948(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 9929, 9948);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1138_10116_10177(Microsoft.PowerShell.Commands.Internal.Format.ParameterProcessor
                this_param, object
                hash, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext)
                {
                    var return_v = this_param.VerifyHashTable((System.Collections.IDictionary)hash, invocationContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 10116, 10177);
                    return return_v;
                }


                System.Type
                f_1138_10270_10292(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 10270, 10292);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_10294_10318(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 10294, 10318);
                    return return_v;
                }


                System.Type[]
                f_1138_10294_10331(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.AllowedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 10294, 10331);
                    return return_v;
                }


                bool
                f_1138_10250_10332(System.Type
                t, System.Type[]
                allowedTypes)
                {
                    var return_v = MatchesAllowedTypes(t, allowedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 10250, 10332);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_10472_10496(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 10472, 10496);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1138_10472_10540(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param, object
                val)
                {
                    var return_v = this_param.CreateHashtableFromSingleType(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 10472, 10540);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_10812_10836(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 10812, 10836);
                    return return_v;
                }


                System.Type[]
                f_1138_10812_10849(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.AllowedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 10812, 10849);
                    return return_v;
                }


                int
                f_1138_10751_10850(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, object
                actualObject, System.Type[]
                allowedTypes)
                {
                    ProcessUnknownParameterType(invocationContext, actualObject, allowedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 10751, 10850);
                    return 0;
                }


                int
                f_1138_10971_11059(Microsoft.PowerShell.Commands.Internal.Format.ParameterProcessor
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                parameter, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, bool
                originalParameterWasHashTable)
                {
                    this_param.VerifyAndNormalizeParameter(parameter, invocationContext, originalParameterWasHashTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 10971, 11059);
                    return 0;
                }


                int
                f_1138_11078_11099(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 11078, 11099);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 9362, 11156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 9362, 11156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool MatchesAllowedTypes(Type t, Type[] allowedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 11168, 11468);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11270, 11275);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11261, 11428) || true) && (k < f_1138_11281_11300(allowedTypes))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11302, 11305)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 11261, 11428))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 11261, 11428);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11339, 11413) || true) && (f_1138_11343_11378(allowedTypes[k], t))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 11339, 11413);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11401, 11413);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 11339, 11413);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1138, 1, 168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1138, 1, 168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11444, 11457);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 11168, 11468);

                int
                f_1138_11281_11300(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 11281, 11300);
                    return return_v;
                }


                bool
                f_1138_11343_11378(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 11343, 11378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 11168, 11468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 11168, 11468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Hashtable VerifyHashTable(IDictionary hash, TerminatingErrorContext invocationContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1138, 11542, 13977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11825, 11860);

                Hashtable
                retVal = f_1138_11844_11859()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11876, 13936);
                    foreach (DictionaryEntry e in f_1138_11906_11910_I(hash))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 11876, 13936);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 11944, 12065) || true) && (e.Key == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 11944, 12065);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 12003, 12046);

                            f_1138_12003_12045(invocationContext);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 11944, 12065);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 12085, 12127);

                        string
                        currentStringKey = e.Key as string
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 12145, 12289) || true) && (currentStringKey == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 12145, 12289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 12215, 12270);

                            f_1138_12215_12269(invocationContext, e.Key);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 12145, 12289);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 12354, 12443);

                        HashtableEntryDefinition
                        def = f_1138_12385_12442(_paramDef, currentStringKey, invocationContext)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 12461, 12677) || true) && (f_1138_12465_12493(retVal, f_1138_12481_12492(def)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 12461, 12677);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 12579, 12658);

                            f_1138_12579_12657(invocationContext, currentStringKey, f_1138_12645_12656(def));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 12461, 12677);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 12765, 12788);

                        bool
                        matchType = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 12808, 13628) || true) && (f_1138_12812_12828(def) == null || (DynAbs.Tracing.TraceSender.Expression_False(1138, 12812, 12868) || f_1138_12840_12863(f_1138_12840_12856(def)) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 12808, 13628);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13000, 13017);

                            matchType = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 12808, 13628);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 12808, 13628);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13108, 13113);
                                for (int
            t = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13099, 13609) || true) && (t < f_1138_13119_13142(f_1138_13119_13135(def)))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13144, 13147)
            , t++, DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 13099, 13609))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 13099, 13609);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13197, 13361) || true) && (e.Value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 13197, 13361);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13274, 13334);

                                        f_1138_13274_13333(invocationContext, currentStringKey);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 13197, 13361);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13389, 13586) || true) && (f_1138_13393_13448(f_1138_13393_13409(def)[t], f_1138_13430_13447(e.Value)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 13389, 13586);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13506, 13523);

                                        matchType = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1138, 13553, 13559);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 13389, 13586);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1138, 1, 511);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1138, 1, 511);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 12808, 13628);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13648, 13868) || true) && (!matchType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 13648, 13868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13743, 13849);

                            f_1138_13743_13848(invocationContext, currentStringKey, f_1138_13812_13829(e.Value), f_1138_13831_13847(def));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 13648, 13868);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13888, 13921);

                        f_1138_13888_13920(
                                        retVal, f_1138_13899_13910(def), e.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 11876, 13936);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1138, 1, 2061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1138, 1, 2061);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 13952, 13966);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1138, 11542, 13977);

                System.Collections.Hashtable
                f_1138_11844_11859()
                {
                    var return_v = new System.Collections.Hashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 11844, 11859);
                    return return_v;
                }


                int
                f_1138_12003_12045(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext)
                {
                    ProcessNullHashTableKey(invocationContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 12003, 12045);
                    return 0;
                }


                int
                f_1138_12215_12269(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, object
                key)
                {
                    ProcessNonStringHashTableKey(invocationContext, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 12215, 12269);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_12385_12442(Microsoft.PowerShell.Commands.Internal.Format.CommandParameterDefinition
                this_param, string
                keyName, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext)
                {
                    var return_v = this_param.MatchEntry(keyName, invocationContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 12385, 12442);
                    return return_v;
                }


                string
                f_1138_12481_12492(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 12481, 12492);
                    return return_v;
                }


                bool
                f_1138_12465_12493(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 12465, 12493);
                    return return_v;
                }


                string
                f_1138_12645_12656(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 12645, 12656);
                    return return_v;
                }


                int
                f_1138_12579_12657(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                duplicateKey, string
                existingKey)
                {
                    ProcessDuplicateHashTableKey(invocationContext, duplicateKey, existingKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 12579, 12657);
                    return 0;
                }


                System.Type[]
                f_1138_12812_12828(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.AllowedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 12812, 12828);
                    return return_v;
                }


                System.Type[]
                f_1138_12840_12856(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.AllowedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 12840, 12856);
                    return return_v;
                }


                int
                f_1138_12840_12863(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 12840, 12863);
                    return return_v;
                }


                System.Type[]
                f_1138_13119_13135(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.AllowedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 13119, 13135);
                    return return_v;
                }


                int
                f_1138_13119_13142(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 13119, 13142);
                    return return_v;
                }


                int
                f_1138_13274_13333(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                keyName)
                {
                    ProcessMissingKeyValue(invocationContext, keyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 13274, 13333);
                    return 0;
                }


                System.Type[]
                f_1138_13393_13409(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.AllowedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 13393, 13409);
                    return return_v;
                }


                System.Type
                f_1138_13430_13447(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 13430, 13447);
                    return return_v;
                }


                bool
                f_1138_13393_13448(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 13393, 13448);
                    return return_v;
                }


                System.Type
                f_1138_13812_13829(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 13812, 13829);
                    return return_v;
                }


                System.Type[]
                f_1138_13831_13847(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.AllowedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 13831, 13847);
                    return return_v;
                }


                int
                f_1138_13743_13848(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                key, System.Type
                actualType, System.Type[]
                allowedTypes)
                {
                    ProcessIllegalHashTableKeyValue(invocationContext, key, actualType, allowedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 13743, 13848);
                    return 0;
                }


                string
                f_1138_13899_13910(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 13899, 13910);
                    return return_v;
                }


                int
                f_1138_13888_13920(System.Collections.Hashtable
                this_param, string
                key, object
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 13888, 13920);
                    return 0;
                }


                System.Collections.IDictionary
                f_1138_11906_11910_I(System.Collections.IDictionary
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 11906, 11910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 11542, 13977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 11542, 13977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VerifyAndNormalizeParameter(MshParameter parameter,
                                                            TerminatingErrorContext invocationContext,
                                                            bool originalParameterWasHashTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1138, 14051, 15930);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 14334, 14339);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 14325, 15919) || true) && (k < f_1138_14345_14372(_paramDef.hashEntries))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 14374, 14377)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 14325, 15919))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 14325, 15919);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 14411, 15904) || true) && (f_1138_14415_14475(parameter.hash, f_1138_14442_14474(f_1138_14442_14466(_paramDef.hashEntries, k))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 14411, 15904);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 14642, 14704);

                            object
                            val = f_1138_14655_14703(parameter.hash, f_1138_14670_14702(f_1138_14670_14694(_paramDef.hashEntries, k)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 14726, 14829);

                            object
                            newVal = f_1138_14742_14828(f_1138_14742_14766(_paramDef.hashEntries, k), val, invocationContext, originalParameterWasHashTable)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 14853, 15091) || true) && (newVal != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 14853, 15091);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 15010, 15068);

                                parameter.hash[f_1138_15025_15057(f_1138_15025_15049(_paramDef.hashEntries, k))] = newVal;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 14853, 15091);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 14411, 15904);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 14411, 15904);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 15259, 15328);

                            object
                            defaultValue = f_1138_15281_15327(f_1138_15281_15305(_paramDef.hashEntries, k))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 15352, 15885) || true) && (defaultValue != f_1138_15372_15392())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 15352, 15885);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 15502, 15566);

                                parameter.hash[f_1138_15517_15549(f_1138_15517_15541(_paramDef.hashEntries, k))] = defaultValue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 15352, 15885);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 15352, 15885);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 15616, 15885) || true) && (f_1138_15620_15654(f_1138_15620_15644(_paramDef.hashEntries, k)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 15616, 15885);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 15782, 15862);

                                    f_1138_15782_15861(invocationContext, f_1138_15828_15860(f_1138_15828_15852(_paramDef.hashEntries, k)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 15616, 15885);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 15352, 15885);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 14411, 15904);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1138, 1, 1595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1138, 1, 1595);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1138, 14051, 15930);

                int
                f_1138_14345_14372(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 14345, 14372);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_14442_14466(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 14442, 14466);
                    return return_v;
                }


                string
                f_1138_14442_14474(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 14442, 14474);
                    return return_v;
                }


                bool
                f_1138_14415_14475(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 14415, 14475);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_14670_14694(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 14670, 14694);
                    return return_v;
                }


                string
                f_1138_14670_14702(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 14670, 14702);
                    return return_v;
                }


                object
                f_1138_14655_14703(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 14655, 14703);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_14742_14766(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 14742, 14766);
                    return return_v;
                }


                object
                f_1138_14742_14828(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param, object
                val, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, bool
                originalParameterWasHashTable)
                {
                    var return_v = this_param.Verify(val, invocationContext, originalParameterWasHashTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 14742, 14828);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_15025_15049(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 15025, 15049);
                    return return_v;
                }


                string
                f_1138_15025_15057(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 15025, 15057);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_15281_15305(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 15281, 15305);
                    return return_v;
                }


                object
                f_1138_15281_15327(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.ComputeDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 15281, 15327);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1138_15372_15392()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 15372, 15392);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_15517_15541(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 15517, 15541);
                    return return_v;
                }


                string
                f_1138_15517_15549(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 15517, 15549);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_15620_15644(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 15620, 15644);
                    return return_v;
                }


                bool
                f_1138_15620_15654(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.Mandatory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 15620, 15654);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                f_1138_15828_15852(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 15828, 15852);
                    return return_v;
                }


                string
                f_1138_15828_15860(Microsoft.PowerShell.Commands.Internal.Format.HashtableEntryDefinition
                this_param)
                {
                    var return_v = this_param.KeyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 15828, 15860);
                    return return_v;
                }


                int
                f_1138_15782_15861(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                keyName)
                {
                    ProcessMissingMandatoryKey(invocationContext, keyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 15782, 15861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 14051, 15930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 14051, 15930);
            }
        }

        private static void ProcessUnknownParameterType(TerminatingErrorContext invocationContext, object actualObject, Type[] allowedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 15978, 16764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 16135, 16193);

                string
                allowedTypesList = f_1138_16161_16192(allowedTypes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 16207, 16218);

                string
                msg
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 16234, 16635) || true) && (actualObject != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 16234, 16635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 16292, 16441);

                    msg = f_1138_16298_16440(f_1138_16316_16367(), f_1138_16390_16421(f_1138_16390_16412(actualObject)), allowedTypesList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 16234, 16635);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 16234, 16635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 16507, 16620);

                    msg = f_1138_16513_16619(f_1138_16531_16579(), allowedTypesList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 16234, 16635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 16651, 16753);

                f_1138_16651_16752(invocationContext, "DictionaryKeyUnknownType", msg);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 15978, 16764);

                string
                f_1138_16161_16192(System.Type[]
                arr)
                {
                    var return_v = CatenateTypeArray(arr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 16161, 16192);
                    return return_v;
                }


                string
                f_1138_16316_16367()
                {
                    var return_v = FormatAndOut_MshParameter.UnknownParameterTypeError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 16316, 16367);
                    return return_v;
                }


                System.Type
                f_1138_16390_16412(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 16390, 16412);
                    return return_v;
                }


                string
                f_1138_16390_16421(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 16390, 16421);
                    return return_v;
                }


                string
                f_1138_16298_16440(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 16298, 16440);
                    return return_v;
                }


                string
                f_1138_16531_16579()
                {
                    var return_v = FormatAndOut_MshParameter.NullParameterTypeError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 16531, 16579);
                    return return_v;
                }


                string
                f_1138_16513_16619(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 16513, 16619);
                    return return_v;
                }


                int
                f_1138_16651_16752(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 16651, 16752);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 15978, 16764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 15978, 16764);
            }
        }

        private static void ProcessDuplicateHashTableKey(TerminatingErrorContext invocationContext, string duplicateKey, string existingKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 16776, 17191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 16933, 17064);

                string
                msg = f_1138_16946_17063(f_1138_16964_17007(), duplicateKey, existingKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 17080, 17180);

                f_1138_17080_17179(invocationContext, "DictionaryKeyDuplicate", msg);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 16776, 17191);

                string
                f_1138_16964_17007()
                {
                    var return_v = FormatAndOut_MshParameter.DuplicateKeyError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 16964, 17007);
                    return return_v;
                }


                string
                f_1138_16946_17063(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 16946, 17063);
                    return return_v;
                }


                int
                f_1138_17080_17179(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 17080, 17179);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 16776, 17191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 16776, 17191);
            }
        }

        private static void ProcessNullHashTableKey(TerminatingErrorContext invocationContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 17203, 17515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 17314, 17395);

                string
                msg = f_1138_17327_17394(f_1138_17345_17393())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 17409, 17504);

                f_1138_17409_17503(invocationContext, "DictionaryKeyNull", msg);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 17203, 17515);

                string
                f_1138_17345_17393()
                {
                    var return_v = FormatAndOut_MshParameter.DictionaryKeyNullError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 17345, 17393);
                    return return_v;
                }


                string
                f_1138_17327_17394(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 17327, 17394);
                    return return_v;
                }


                int
                f_1138_17409_17503(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 17409, 17503);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 17203, 17515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 17203, 17515);
            }
        }

        private static void ProcessNonStringHashTableKey(TerminatingErrorContext invocationContext, object key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 17527, 17886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 17655, 17761);

                string
                msg = f_1138_17668_17760(f_1138_17686_17739(), f_1138_17741_17759(f_1138_17741_17754(key)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 17775, 17875);

                f_1138_17775_17874(invocationContext, "DictionaryKeyNonString", msg);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 17527, 17886);

                string
                f_1138_17686_17739()
                {
                    var return_v = FormatAndOut_MshParameter.DictionaryKeyNonStringError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 17686, 17739);
                    return return_v;
                }


                System.Type
                f_1138_17741_17754(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 17741, 17754);
                    return return_v;
                }


                string
                f_1138_17741_17759(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 17741, 17759);
                    return return_v;
                }


                string
                f_1138_17668_17760(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 17668, 17760);
                    return return_v;
                }


                int
                f_1138_17775_17874(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 17775, 17874);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 17527, 17886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 17527, 17886);
            }
        }

        private static void ProcessIllegalHashTableKeyValue(TerminatingErrorContext invocationContext, string key, Type actualType, Type[] allowedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 17898, 18961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 18067, 18078);

                string
                msg
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 18092, 18107);

                string
                errorID
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 18121, 18851) || true) && (f_1138_18125_18144(allowedTypes) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 18121, 18851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 18182, 18234);

                    string
                    legalTypes = f_1138_18202_18233(allowedTypes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 18254, 18450);

                    msg = f_1138_18260_18449(f_1138_18278_18325(), key, f_1138_18374_18393(actualType), legalTypes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 18470, 18509);

                    errorID = "DictionaryKeyIllegalValue1";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 18121, 18851);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 18121, 18851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 18575, 18777);

                    msg = f_1138_18581_18776(f_1138_18599_18647(), key, f_1138_18696_18715(actualType), allowedTypes[0]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 18797, 18836);

                    errorID = "DictionaryKeyIllegalValue2";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 18121, 18851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 18867, 18950);

                f_1138_18867_18949(invocationContext, errorID, msg);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 17898, 18961);

                int
                f_1138_18125_18144(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 18125, 18144);
                    return return_v;
                }


                string
                f_1138_18202_18233(System.Type[]
                arr)
                {
                    var return_v = CatenateTypeArray(arr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 18202, 18233);
                    return return_v;
                }


                string
                f_1138_18278_18325()
                {
                    var return_v = FormatAndOut_MshParameter.IllegalTypeMultiError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 18278, 18325);
                    return return_v;
                }


                string
                f_1138_18374_18393(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 18374, 18393);
                    return return_v;
                }


                string
                f_1138_18260_18449(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 18260, 18449);
                    return return_v;
                }


                string
                f_1138_18599_18647()
                {
                    var return_v = FormatAndOut_MshParameter.IllegalTypeSingleError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 18599, 18647);
                    return return_v;
                }


                string
                f_1138_18696_18715(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 18696, 18715);
                    return return_v;
                }


                string
                f_1138_18581_18776(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 18581, 18776);
                    return return_v;
                }


                int
                f_1138_18867_18949(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 18867, 18949);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 17898, 18961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 17898, 18961);
            }
        }

        private static void ProcessMissingKeyValue(TerminatingErrorContext invocationContext, string keyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 18973, 19315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 19099, 19187);

                string
                msg = f_1138_19112_19186(f_1138_19130_19176(), keyName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 19201, 19304);

                f_1138_19201_19303(invocationContext, "DictionaryKeyMissingValue", msg);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 18973, 19315);

                string
                f_1138_19130_19176()
                {
                    var return_v = FormatAndOut_MshParameter.MissingKeyValueError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 19130, 19176);
                    return return_v;
                }


                string
                f_1138_19112_19186(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 19112, 19186);
                    return return_v;
                }


                int
                f_1138_19201_19303(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 19201, 19303);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 18973, 19315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 18973, 19315);
            }
        }

        private static void ProcessMissingMandatoryKey(TerminatingErrorContext invocationContext, string keyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 19327, 19684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 19457, 19554);

                string
                msg = f_1138_19470_19553(f_1138_19488_19543(), keyName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 19568, 19673);

                f_1138_19568_19672(invocationContext, "DictionaryKeyMandatoryEntry", msg);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 19327, 19684);

                string
                f_1138_19488_19543()
                {
                    var return_v = FormatAndOut_MshParameter.MissingKeyMandatoryEntryError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 19488, 19543);
                    return return_v;
                }


                string
                f_1138_19470_19553(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 19470, 19553);
                    return return_v;
                }


                int
                f_1138_19568_19672(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext, string
                errorId, string
                msg)
                {
                    ParameterProcessor.ThrowParameterBindingException(invocationContext, errorId, msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 19568, 19672);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 19327, 19684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 19327, 19684);
            }
        }

        private static string CatenateTypeArray(Type[] arr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 19747, 20055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 19823, 19865);

                string[]
                strings = new string[f_1138_19853_19863(arr)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 19888, 19893);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 19879, 19992) || true) && (k < f_1138_19899_19909(arr))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 19911, 19914)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 19879, 19992))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 19879, 19992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 19948, 19977);

                        strings[k] = f_1138_19961_19976(arr[k]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1138, 1, 114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1138, 1, 114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20008, 20044);

                return f_1138_20015_20043(strings);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 19747, 20055);

                int
                f_1138_19853_19863(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 19853, 19863);
                    return return_v;
                }


                int
                f_1138_19899_19909(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 19899, 19909);
                    return return_v;
                }


                string
                f_1138_19961_19976(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 19961, 19976);
                    return return_v;
                }


                string
                f_1138_20015_20043(string[]
                arr)
                {
                    var return_v = CatenateStringArray(arr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 20015, 20043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 19747, 20055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 19747, 20055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CatenateStringArray(string[] arr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1138, 20067, 20515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20148, 20187);

                StringBuilder
                sb = f_1138_20167_20186()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20201, 20216);

                f_1138_20201_20215(sb, "{");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20239, 20244);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20230, 20438) || true) && (k < f_1138_20250_20260(arr))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20262, 20265)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 20230, 20438))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 20230, 20438);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20299, 20385) || true) && (k > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1138, 20299, 20385);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20350, 20366);

                            f_1138_20350_20365(sb, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1138, 20299, 20385);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20405, 20423);

                        f_1138_20405_20422(
                                        sb, arr[k]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1138, 1, 209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1138, 1, 209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20454, 20469);

                f_1138_20454_20468(
                            sb, "}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 20483, 20504);

                return f_1138_20490_20503(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1138, 20067, 20515);

                System.Text.StringBuilder
                f_1138_20167_20186()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 20167, 20186);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1138_20201_20215(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 20201, 20215);
                    return return_v;
                }


                int
                f_1138_20250_20260(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1138, 20250, 20260);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1138_20350_20365(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 20350, 20365);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1138_20405_20422(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 20405, 20422);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1138_20454_20468(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 20454, 20468);
                    return return_v;
                }


                string
                f_1138_20490_20503(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 20490, 20503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1138, 20067, 20515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 20067, 20515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandParameterDefinition _paramDef;

        static ParameterProcessor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1138, 8213, 20608);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1138, 8391, 8467);
            tracer = f_1138_8400_8467("ParameterProcessor", "ParameterProcessor");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1138, 8213, 20608);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1138, 8213, 20608);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1138, 8213, 20608);

        static System.Management.Automation.PSTraceSource
        f_1138_8400_8467(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1138, 8400, 8467);
            return return_v;
        }

    }
}

