// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Help;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Net;

namespace Microsoft.PowerShell.Commands
{
    public class UpdatableHelpCommandBase : PSCmdlet
    {
        internal const string
        PathParameterSetName = "Path"
        ;

        internal const string
        LiteralPathParameterSetName = "LiteralPath"
        ;

        internal UpdatableHelpCommandType _commandType;

        internal UpdatableHelpSystem _helpSystem;

        internal bool _stopping;

        internal int activityId;

        private Dictionary<string, UpdatableHelpExceptionContext> _exceptions;

        [Parameter(Position = 2)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public CultureInfo[] UICulture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 1535, 1989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1571, 1599);

                    CultureInfo[]
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1617, 1940) || true) && (_language != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 1617, 1940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1680, 1723);

                        result = new CultureInfo[f_1177_1705_1721(_language)];
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1754, 1763);
                            for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1745, 1921) || true) && (index < f_1177_1773_1789(_language))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1791, 1798)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 1745, 1921))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 1745, 1921);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1848, 1898);

                                result[index] = f_1177_1864_1897(_language[index]);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 177);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 177);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 1617, 1940);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1960, 1974);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 1535, 1989);

                    int
                    f_1177_1705_1721(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 1705, 1721);
                        return return_v;
                    }


                    int
                    f_1177_1773_1789(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 1773, 1789);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1177_1864_1897(string
                    name)
                    {
                        var return_v = new System.Globalization.CultureInfo(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 1864, 1897);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 1324, 2313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 1324, 2313);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 2005, 2302);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2041, 2067) || true) && (value == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 2041, 2067);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2060, 2067);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 2041, 2067);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2085, 2122);

                    _language = new string[f_1177_2108_2120(value)];
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2149, 2158);
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2140, 2287) || true) && (index < f_1177_2168_2180(value))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2182, 2189)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 2140, 2287))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 2140, 2287);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2231, 2268);

                            _language[index] = f_1177_2250_2267(value[index]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 148);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 2005, 2302);

                    int
                    f_1177_2108_2120(System.Globalization.CultureInfo[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 2108, 2120);
                        return return_v;
                    }


                    int
                    f_1177_2168_2180(System.Globalization.CultureInfo[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 2168, 2180);
                        return return_v;
                    }


                    string
                    f_1177_2250_2267(System.Globalization.CultureInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 2250, 2267);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 1324, 2313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 1324, 2313);
                }
            }
        }

        internal string[] _language;

        [Parameter()]
        [Credential()]
        public PSCredential Credential
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 2566, 2593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2572, 2591);

                    return _credential;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 2566, 2593);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 2464, 2648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 2464, 2648);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 2609, 2637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2615, 2635);

                    _credential = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 2609, 2637);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 2464, 2648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 2464, 2648);
                }
            }
        }

        internal PSCredential _credential;

        [Parameter]
        public SwitchParameter UseDefaultCredentials
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 2928, 3009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2964, 2994);

                    return _useDefaultCredentials;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 2928, 3009);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 2838, 3118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 2838, 3118);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 3025, 3107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 3061, 3092);

                    _useDefaultCredentials = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 3025, 3107);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 2838, 3118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 2838, 3118);
                }
            }
        }

        internal bool _useDefaultCredentials;

        [Parameter]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 3355, 3420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 3391, 3405);

                    return _force;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 3355, 3420);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 3281, 3513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 3281, 3513);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 3436, 3502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 3472, 3487);

                    _force = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 3436, 3502);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 3281, 3513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 3281, 3513);
                }
            }
        }

        internal bool _force;

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true)]
        public UpdateHelpScope Scope
        {
            get;
            set;
        }

        private void HandleProgressChanged(object sender, UpdatableHelpProgressEventArgs e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 4090, 4813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 4198, 4350);

                f_1177_4198_4349(f_1177_4211_4224(e) == UpdatableHelpCommandType.UpdateHelpCommand
                || (DynAbs.Tracing.TraceSender.Expression_False(1177, 4211, 4348) || f_1177_4291_4304(e) == UpdatableHelpCommandType.SaveHelpCommand));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 4366, 4567);

                string
                activity = (DynAbs.Tracing.TraceSender.Conditional_F1(1177, 4384, 4445) || (((f_1177_4385_4398(e) == UpdatableHelpCommandType.UpdateHelpCommand) && DynAbs.Tracing.TraceSender.Conditional_F2(1177, 4465, 4515)) || DynAbs.Tracing.TraceSender.Conditional_F3(1177, 4518, 4566))) ? f_1177_4465_4515() : f_1177_4518_4566()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 4583, 4701);

                ProgressRecord
                progress = f_1177_4609_4700(activityId, f_1177_4640_4681(activity, f_1177_4668_4680(e)), f_1177_4683_4699(e))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 4717, 4762);

                progress.PercentComplete = f_1177_4744_4761(e);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 4778, 4802);

                f_1177_4778_4801(this, progress);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 4090, 4813);

                System.Management.Automation.Help.UpdatableHelpCommandType
                f_1177_4211_4224(System.Management.Automation.Help.UpdatableHelpProgressEventArgs
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 4211, 4224);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpCommandType
                f_1177_4291_4304(System.Management.Automation.Help.UpdatableHelpProgressEventArgs
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 4291, 4304);
                    return return_v;
                }


                int
                f_1177_4198_4349(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 4198, 4349);
                    return 0;
                }


                System.Management.Automation.Help.UpdatableHelpCommandType
                f_1177_4385_4398(System.Management.Automation.Help.UpdatableHelpProgressEventArgs
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 4385, 4398);
                    return return_v;
                }


                string
                f_1177_4465_4515()
                {
                    var return_v = HelpDisplayStrings.UpdateProgressActivityForModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 4465, 4515);
                    return return_v;
                }


                string
                f_1177_4518_4566()
                {
                    var return_v = HelpDisplayStrings.SaveProgressActivityForModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 4518, 4566);
                    return return_v;
                }


                string
                f_1177_4668_4680(System.Management.Automation.Help.UpdatableHelpProgressEventArgs
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 4668, 4680);
                    return return_v;
                }


                string
                f_1177_4640_4681(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 4640, 4681);
                    return return_v;
                }


                string
                f_1177_4683_4699(System.Management.Automation.Help.UpdatableHelpProgressEventArgs
                this_param)
                {
                    var return_v = this_param.ProgressStatus;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 4683, 4699);
                    return return_v;
                }


                System.Management.Automation.ProgressRecord
                f_1177_4609_4700(int
                activityId, string
                activity, string
                statusDescription)
                {
                    var return_v = new System.Management.Automation.ProgressRecord(activityId, activity, statusDescription);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 4609, 4700);
                    return return_v;
                }


                int
                f_1177_4744_4761(System.Management.Automation.Help.UpdatableHelpProgressEventArgs
                this_param)
                {
                    var return_v = this_param.ProgressPercent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 4744, 4761);
                    return return_v;
                }


                int
                f_1177_4778_4801(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.ProgressRecord
                progressRecord)
                {
                    this_param.WriteProgress(progressRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 4778, 4801);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 4090, 4813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 4090, 4813);
            }
        }

        private static Dictionary<string, string> s_metadataCache;

        static UpdatableHelpCommandBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1177, 5292, 6319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 821, 850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 883, 926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 4920, 4935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 5350, 5433);

                s_metadataCache = f_1177_5368_5432(f_1177_5399_5431());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 5503, 5610);

                f_1177_5503_5609(
                            // TODO: assign real TechNet addresses

                            s_metadataCache, "Microsoft.PowerShell.Diagnostics", "https://go.microsoft.com/fwlink/?linkid=2113532");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 5624, 5724);

                f_1177_5624_5723(s_metadataCache, "Microsoft.PowerShell.Core", "https://go.microsoft.com/fwlink/?linkid=2113534");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 5738, 5841);

                f_1177_5738_5840(s_metadataCache, "Microsoft.PowerShell.Utility", "https://go.microsoft.com/fwlink/?linkid=2113633");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 5855, 5955);

                f_1177_5855_5954(s_metadataCache, "Microsoft.PowerShell.Host", "https://go.microsoft.com/fwlink/?linkid=2113538");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 5969, 6075);

                f_1177_5969_6074(s_metadataCache, "Microsoft.PowerShell.Management", "https://go.microsoft.com/fwlink/?linkid=2113632");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 6089, 6193);

                f_1177_6089_6192(s_metadataCache, "Microsoft.PowerShell.Security", "https://go.microsoft.com/fwlink/?linkid=2113533");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 6207, 6308);

                f_1177_6207_6307(s_metadataCache, "Microsoft.WSMan.Management", "https://go.microsoft.com/fwlink/?linkid=2113537");
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1177, 5292, 6319);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 5292, 6319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 5292, 6319);
            }
        }

        internal static bool IsSystemModule(string module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1177, 6631, 6760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 6706, 6749);

                return f_1177_6713_6748(s_metadataCache, module);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1177, 6631, 6760);

                bool
                f_1177_6713_6748(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 6713, 6748);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 6631, 6760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 6631, 6760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal UpdatableHelpCommandBase(UpdatableHelpCommandType commandType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1177, 6912, 7415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 973, 985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1025, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1061, 1070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1096, 1106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 1175, 1186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2343, 2352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 2682, 2693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 3144, 3174);
                this._useDefaultCredentials = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 3539, 3545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 3657, 3823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 7008, 7035);

                _commandType = commandType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 7049, 7117);

                _helpSystem = f_1177_7063_7116(this, _useDefaultCredentials);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 7131, 7201);

                _exceptions = f_1177_7145_7200();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 7215, 7320);

                _helpSystem.OnProgressChanged += new EventHandler<UpdatableHelpProgressEventArgs>(HandleProgressChanged);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 7336, 7363);

                Random
                rand = f_1177_7350_7362()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 7379, 7404);

                activityId = f_1177_7392_7403(rand);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1177, 6912, 7415);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 6912, 7415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 6912, 7415);
            }
        }

        private void ProcessSingleModuleObject(PSModuleInfo module, ExecutionContext context, Dictionary<Tuple<string, Version>, UpdatableHelpModuleInfo> helpModules, bool noErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 7483, 9925);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 7681, 8475) || true) && (f_1177_7685_7732(f_1177_7720_7731(module)) && (DynAbs.Tracing.TraceSender.Expression_True(1177, 7685, 7790) && !f_1177_7737_7790(f_1177_7778_7789(module))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 7681, 8475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 7824, 7914);

                    f_1177_7824_7913(this, f_1177_7835_7912("Found engine module: {0}, {1}.", f_1177_7887_7898(module), f_1177_7900_7911(module)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 7934, 8005);

                    var
                    keyTuple = f_1177_7949_8004(f_1177_7976_7987(module), f_1177_7989_8003(module))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 8023, 8301) || true) && (!f_1177_8028_8061(helpModules, keyTuple))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 8023, 8301);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 8103, 8282);

                        f_1177_8103_8281(helpModules, keyTuple, f_1177_8129_8280(f_1177_8157_8168(module), f_1177_8170_8181(module), f_1177_8208_8249(f_1177_8233_8248(context)), f_1177_8251_8279(s_metadataCache, f_1177_8267_8278(module))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 8023, 8301);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 8321, 8328);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 7681, 8475);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 7681, 8475);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 8362, 8475) || true) && (f_1177_8366_8419(f_1177_8407_8418(module)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 8362, 8475);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 8453, 8460);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 8362, 8475);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 7681, 8475);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 8491, 8964) || true) && (f_1177_8495_8535(f_1177_8516_8534(module)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 8491, 8964);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 8569, 8922) || true) && (!noErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 8569, 8922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 8624, 8903);

                        f_1177_8624_8902(this, f_1177_8641_8652(module), null, f_1177_8660_8901("HelpInfoUriNotFound", f_1177_8742_8799(f_1177_8760_8798()), ErrorCategory.NotSpecified, f_1177_8854_8894("HelpInfoUri", UriKind.Relative), null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 8569, 8922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 8942, 8949);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 8491, 8964);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 8980, 9603) || true) && (!(f_1177_8986_9062(f_1177_8986_9004(module), "http://", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1177, 8986, 9143) || f_1177_9066_9143(f_1177_9066_9084(module), "https://", StringComparison.OrdinalIgnoreCase))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 8980, 9603);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 9178, 9561) || true) && (!noErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 9178, 9561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 9233, 9542);

                        f_1177_9233_9541(this, f_1177_9250_9261(module), null, f_1177_9269_9540("InvalidHelpInfoUriFormat", f_1177_9356_9438(f_1177_9374_9417(), f_1177_9419_9437(module)), ErrorCategory.NotSpecified, f_1177_9493_9533("HelpInfoUri", UriKind.Relative), null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 9178, 9561);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 9581, 9588);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 8980, 9603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 9619, 9691);

                var
                keyTuple2 = f_1177_9635_9690(f_1177_9662_9673(module), f_1177_9675_9689(module))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 9705, 9914) || true) && (!f_1177_9710_9744(helpModules, keyTuple2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 9705, 9914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 9778, 9899);

                    f_1177_9778_9898(helpModules, keyTuple2, f_1177_9805_9897(f_1177_9833_9844(module), f_1177_9846_9857(module), f_1177_9859_9876(module), f_1177_9878_9896(module)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 9705, 9914);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 7483, 9925);

                string
                f_1177_7720_7731(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 7720, 7731);
                    return return_v;
                }


                bool
                f_1177_7685_7732(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 7685, 7732);
                    return return_v;
                }


                string
                f_1177_7778_7789(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 7778, 7789);
                    return return_v;
                }


                bool
                f_1177_7737_7790(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsNestedEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 7737, 7790);
                    return return_v;
                }


                string
                f_1177_7887_7898(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 7887, 7898);
                    return return_v;
                }


                System.Guid
                f_1177_7900_7911(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 7900, 7911);
                    return return_v;
                }


                string
                f_1177_7835_7912(string
                formatSpec, string
                o1, System.Guid
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 7835, 7912);
                    return return_v;
                }


                int
                f_1177_7824_7913(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                text)
                {
                    this_param.WriteDebug(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 7824, 7913);
                    return 0;
                }


                string
                f_1177_7976_7987(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 7976, 7987);
                    return return_v;
                }


                System.Version
                f_1177_7989_8003(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 7989, 8003);
                    return return_v;
                }


                System.Tuple<string, System.Version>
                f_1177_7949_8004(string
                item1, System.Version
                item2)
                {
                    var return_v = new System.Tuple<string, System.Version>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 7949, 8004);
                    return return_v;
                }


                bool
                f_1177_8028_8061(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                this_param, System.Tuple<string, System.Version>
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8028, 8061);
                    return return_v;
                }


                string
                f_1177_8157_8168(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 8157, 8168);
                    return return_v;
                }


                System.Guid
                f_1177_8170_8181(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 8170, 8181);
                    return return_v;
                }


                string
                f_1177_8233_8248(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 8233, 8248);
                    return return_v;
                }


                string
                f_1177_8208_8249(string
                shellId)
                {
                    var return_v = Utils.GetApplicationBase(shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8208, 8249);
                    return return_v;
                }


                string
                f_1177_8267_8278(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 8267, 8278);
                    return return_v;
                }


                string
                f_1177_8251_8279(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 8251, 8279);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpModuleInfo
                f_1177_8129_8280(string
                name, System.Guid
                guid, string
                path, string
                uri)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpModuleInfo(name, guid, path, uri);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8129, 8280);
                    return return_v;
                }


                int
                f_1177_8103_8281(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                this_param, System.Tuple<string, System.Version>
                key, System.Management.Automation.Help.UpdatableHelpModuleInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8103, 8281);
                    return 0;
                }


                string
                f_1177_8407_8418(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 8407, 8418);
                    return return_v;
                }


                bool
                f_1177_8366_8419(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsNestedEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8366, 8419);
                    return return_v;
                }


                string
                f_1177_8516_8534(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.HelpInfoUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 8516, 8534);
                    return return_v;
                }


                bool
                f_1177_8495_8535(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8495, 8535);
                    return return_v;
                }


                string
                f_1177_8641_8652(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 8641, 8652);
                    return return_v;
                }


                string
                f_1177_8760_8798()
                {
                    var return_v = HelpDisplayStrings.HelpInfoUriNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 8760, 8798);
                    return return_v;
                }


                string
                f_1177_8742_8799(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8742, 8799);
                    return return_v;
                }


                System.Uri
                f_1177_8854_8894(string
                uriString, System.UriKind
                uriKind)
                {
                    var return_v = new System.Uri(uriString, uriKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8854, 8894);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_8660_8901(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, System.Uri
                targetObject, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, (object)targetObject, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8660, 8901);
                    return return_v;
                }


                int
                f_1177_8624_8902(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                moduleName, string
                culture, System.Management.Automation.Help.UpdatableHelpSystemException
                e)
                {
                    this_param.ProcessException(moduleName, culture, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8624, 8902);
                    return 0;
                }


                string
                f_1177_8986_9004(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.HelpInfoUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 8986, 9004);
                    return return_v;
                }


                bool
                f_1177_8986_9062(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 8986, 9062);
                    return return_v;
                }


                string
                f_1177_9066_9084(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.HelpInfoUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 9066, 9084);
                    return return_v;
                }


                bool
                f_1177_9066_9143(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 9066, 9143);
                    return return_v;
                }


                string
                f_1177_9250_9261(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 9250, 9261);
                    return return_v;
                }


                string
                f_1177_9374_9417()
                {
                    var return_v = HelpDisplayStrings.InvalidHelpInfoUriFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 9374, 9417);
                    return return_v;
                }


                string
                f_1177_9419_9437(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.HelpInfoUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 9419, 9437);
                    return return_v;
                }


                string
                f_1177_9356_9438(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 9356, 9438);
                    return return_v;
                }


                System.Uri
                f_1177_9493_9533(string
                uriString, System.UriKind
                uriKind)
                {
                    var return_v = new System.Uri(uriString, uriKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 9493, 9533);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_9269_9540(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, System.Uri
                targetObject, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, (object)targetObject, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 9269, 9540);
                    return return_v;
                }


                int
                f_1177_9233_9541(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                moduleName, string
                culture, System.Management.Automation.Help.UpdatableHelpSystemException
                e)
                {
                    this_param.ProcessException(moduleName, culture, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 9233, 9541);
                    return 0;
                }


                string
                f_1177_9662_9673(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 9662, 9673);
                    return return_v;
                }


                System.Version
                f_1177_9675_9689(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 9675, 9689);
                    return return_v;
                }


                System.Tuple<string, System.Version>
                f_1177_9635_9690(string
                item1, System.Version
                item2)
                {
                    var return_v = new System.Tuple<string, System.Version>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 9635, 9690);
                    return return_v;
                }


                bool
                f_1177_9710_9744(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                this_param, System.Tuple<string, System.Version>
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 9710, 9744);
                    return return_v;
                }


                string
                f_1177_9833_9844(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 9833, 9844);
                    return return_v;
                }


                System.Guid
                f_1177_9846_9857(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 9846, 9857);
                    return return_v;
                }


                string
                f_1177_9859_9876(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 9859, 9876);
                    return return_v;
                }


                string
                f_1177_9878_9896(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.HelpInfoUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 9878, 9896);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpModuleInfo
                f_1177_9805_9897(string
                name, System.Guid
                guid, string
                path, string
                uri)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpModuleInfo(name, guid, path, uri);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 9805, 9897);
                    return return_v;
                }


                int
                f_1177_9778_9898(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                this_param, System.Tuple<string, System.Version>
                key, System.Management.Automation.Help.UpdatableHelpModuleInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 9778, 9898);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 7483, 9925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 7483, 9925);
            }
        }

        private Dictionary<Tuple<string, Version>, UpdatableHelpModuleInfo> GetModuleInfo(ExecutionContext context, string pattern, ModuleSpecification fullyQualifiedName, bool noErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 10395, 14164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 10598, 10632);

                List<PSModuleInfo>
                modules = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 10646, 10678);

                string
                moduleNamePattern = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 10694, 11069) || true) && (pattern != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 10694, 11069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 10747, 10775);

                    moduleNamePattern = pattern;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 10793, 10838);

                    modules = f_1177_10803_10837(pattern, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 10694, 11069);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 10694, 11069);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 10872, 11069) || true) && (fullyQualifiedName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 10872, 11069);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 10936, 10980);

                        moduleNamePattern = f_1177_10956_10979(fullyQualifiedName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 10998, 11054);

                        modules = f_1177_11008_11053(fullyQualifiedName, context);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 10872, 11069);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 10694, 11069);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 11085, 11169);

                var
                helpModules = f_1177_11103_11168()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 11183, 11417) || true) && (modules != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 11183, 11417);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 11236, 11402);
                        foreach (PSModuleInfo module in f_1177_11268_11275_I(modules))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 11236, 11402);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 11317, 11383);

                            f_1177_11317_11382(this, module, context, helpModules, noErrors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 11236, 11402);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 167);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 167);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 11183, 11417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 11465, 11561);

                WildcardOptions
                wildcardOptions = WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 11575, 11721);

                IEnumerable<WildcardPattern>
                patternList = f_1177_11618_11720(new string[1] { moduleNamePattern }, wildcardOptions)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 11737, 14118);
                    foreach (KeyValuePair<string, string> name in f_1177_11783_11798_I(s_metadataCache))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 11737, 14118);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 11832, 14103) || true) && (f_1177_11836_11912(name.Key, patternList, true))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 11832, 14103);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 12074, 14084) || true) && (!f_1177_12079_12162(name.Key, InitialSessionState.CoreSnapin, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 12074, 14084);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 12212, 12284);

                                var
                                keyTuple = f_1177_12227_12283(name.Key, f_1177_12264_12282("1.0"))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 12310, 13416) || true) && (!f_1177_12315_12348(helpModules, keyTuple))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 12310, 13416);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 12406, 12480);

                                    List<PSModuleInfo>
                                    availableModules = f_1177_12444_12479(name.Key, context)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 12510, 13389) || true) && (availableModules != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 12510, 13389);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 12604, 13358);
                                            foreach (PSModuleInfo module in f_1177_12636_12652_I(availableModules))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 12604, 13358);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 12726, 12793);

                                                keyTuple = f_1177_12737_12792(f_1177_12764_12775(module), f_1177_12777_12791(module));

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 12831, 13323) || true) && (!f_1177_12836_12869(helpModules, keyTuple))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 12831, 13323);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 12951, 13041);

                                                    f_1177_12951_13040(this, f_1177_12962_13039("Found engine module: {0}, {1}.", f_1177_13014_13025(module), f_1177_13027_13038(module)));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 13085, 13284);

                                                    f_1177_13085_13283(
                                                                                            helpModules, keyTuple, f_1177_13111_13282(f_1177_13139_13150(module), f_1177_13197_13208(module), f_1177_13210_13251(f_1177_13235_13250(context)), f_1177_13253_13281(s_metadataCache, f_1177_13269_13280(module))));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 12831, 13323);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 12604, 13358);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 755);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 755);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 12510, 13389);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 12310, 13416);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 12074, 14084);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 12074, 14084);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 13514, 13587);

                                var
                                keyTuple2 = f_1177_13530_13586(name.Key, f_1177_13567_13585("1.0"))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 13613, 14061) || true) && (!f_1177_13618_13652(helpModules, keyTuple2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 13613, 14061);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 13710, 14034);

                                    f_1177_13710_14033(helpModules, keyTuple2, f_1177_13782_14032(name.Key, Guid.Empty, f_1177_13905_13946(f_1177_13930_13945(context)), name.Value));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 13613, 14061);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 12074, 14084);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 11832, 14103);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 11737, 14118);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 2382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 2382);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 14134, 14153);

                return helpModules;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 10395, 14164);

                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1177_10803_10837(string
                module, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Utils.GetModules(module, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 10803, 10837);
                    return return_v;
                }


                string
                f_1177_10956_10979(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 10956, 10979);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1177_11008_11053(Microsoft.PowerShell.Commands.ModuleSpecification
                fullyQualifiedName, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Utils.GetModules(fullyQualifiedName, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 11008, 11053);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                f_1177_11103_11168()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 11103, 11168);
                    return return_v;
                }


                int
                f_1177_11317_11382(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.PSModuleInfo
                module, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                helpModules, bool
                noErrors)
                {
                    this_param.ProcessSingleModuleObject(module, context, helpModules, noErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 11317, 11382);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1177_11268_11275_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 11268, 11275);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1177_11618_11720(string[]
                globPatterns, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 11618, 11720);
                    return return_v;
                }


                bool
                f_1177_11836_11912(string
                text, System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 11836, 11912);
                    return return_v;
                }


                bool
                f_1177_12079_12162(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 12079, 12162);
                    return return_v;
                }


                System.Version
                f_1177_12264_12282(string
                version)
                {
                    var return_v = new System.Version(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 12264, 12282);
                    return return_v;
                }


                System.Tuple<string, System.Version>
                f_1177_12227_12283(string
                item1, System.Version
                item2)
                {
                    var return_v = new System.Tuple<string, System.Version>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 12227, 12283);
                    return return_v;
                }


                bool
                f_1177_12315_12348(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                this_param, System.Tuple<string, System.Version>
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 12315, 12348);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1177_12444_12479(string
                module, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Utils.GetModules(module, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 12444, 12479);
                    return return_v;
                }


                string
                f_1177_12764_12775(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 12764, 12775);
                    return return_v;
                }


                System.Version
                f_1177_12777_12791(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 12777, 12791);
                    return return_v;
                }


                System.Tuple<string, System.Version>
                f_1177_12737_12792(string
                item1, System.Version
                item2)
                {
                    var return_v = new System.Tuple<string, System.Version>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 12737, 12792);
                    return return_v;
                }


                bool
                f_1177_12836_12869(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                this_param, System.Tuple<string, System.Version>
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 12836, 12869);
                    return return_v;
                }


                string
                f_1177_13014_13025(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 13014, 13025);
                    return return_v;
                }


                System.Guid
                f_1177_13027_13038(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 13027, 13038);
                    return return_v;
                }


                string
                f_1177_12962_13039(string
                formatSpec, string
                o1, System.Guid
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 12962, 13039);
                    return return_v;
                }


                int
                f_1177_12951_13040(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                text)
                {
                    this_param.WriteDebug(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 12951, 13040);
                    return 0;
                }


                string
                f_1177_13139_13150(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 13139, 13150);
                    return return_v;
                }


                System.Guid
                f_1177_13197_13208(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 13197, 13208);
                    return return_v;
                }


                string
                f_1177_13235_13250(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 13235, 13250);
                    return return_v;
                }


                string
                f_1177_13210_13251(string
                shellId)
                {
                    var return_v = Utils.GetApplicationBase(shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 13210, 13251);
                    return return_v;
                }


                string
                f_1177_13269_13280(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 13269, 13280);
                    return return_v;
                }


                string
                f_1177_13253_13281(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 13253, 13281);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpModuleInfo
                f_1177_13111_13282(string
                name, System.Guid
                guid, string
                path, string
                uri)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpModuleInfo(name, guid, path, uri);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 13111, 13282);
                    return return_v;
                }


                int
                f_1177_13085_13283(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                this_param, System.Tuple<string, System.Version>
                key, System.Management.Automation.Help.UpdatableHelpModuleInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 13085, 13283);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1177_12636_12652_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 12636, 12652);
                    return return_v;
                }


                System.Version
                f_1177_13567_13585(string
                version)
                {
                    var return_v = new System.Version(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 13567, 13585);
                    return return_v;
                }


                System.Tuple<string, System.Version>
                f_1177_13530_13586(string
                item1, System.Version
                item2)
                {
                    var return_v = new System.Tuple<string, System.Version>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 13530, 13586);
                    return return_v;
                }


                bool
                f_1177_13618_13652(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                this_param, System.Tuple<string, System.Version>
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 13618, 13652);
                    return return_v;
                }


                string
                f_1177_13930_13945(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 13930, 13945);
                    return return_v;
                }


                string
                f_1177_13905_13946(string
                shellId)
                {
                    var return_v = Utils.GetApplicationBase(shellId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 13905, 13946);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpModuleInfo
                f_1177_13782_14032(string
                name, System.Guid
                guid, string
                path, string
                uri)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpModuleInfo(name, guid, path, uri);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 13782, 14032);
                    return return_v;
                }


                int
                f_1177_13710_14033(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                this_param, System.Tuple<string, System.Version>
                key, System.Management.Automation.Help.UpdatableHelpModuleInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 13710, 14033);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1177_11783_11798_I(System.Collections.Generic.Dictionary<string, string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 11783, 11798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 10395, 14164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 10395, 14164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 14252, 14388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 14317, 14334);

                _stopping = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 14348, 14377);

                f_1177_14348_14376(_helpSystem);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 14252, 14388);

                int
                f_1177_14348_14376(System.Management.Automation.Help.UpdatableHelpSystem
                this_param)
                {
                    this_param.CancelDownload();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 14348, 14376);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 14252, 14388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 14252, 14388);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 14476, 16041);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 14540, 16030);
                    foreach (UpdatableHelpExceptionContext exception in f_1177_14592_14610_I(f_1177_14592_14610(_exceptions)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 14540, 16030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 14644, 14688);

                        UpdatableHelpExceptionContext
                        e = exception
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 14708, 15630) || true) && ((f_1177_14713_14754(f_1177_14713_14732(exception)) == "HelpCultureNotSupported") && (DynAbs.Tracing.TraceSender.Expression_True(1177, 14712, 14954) && ((f_1177_14811_14829(exception) != null && (DynAbs.Tracing.TraceSender.Expression_True(1177, 14811, 14869) && f_1177_14841_14865(f_1177_14841_14859(exception)) > 1)) || (DynAbs.Tracing.TraceSender.Expression_False(1177, 14810, 14953) || (f_1177_14896_14913(exception) != null && (DynAbs.Tracing.TraceSender.Expression_True(1177, 14896, 14952) && f_1177_14925_14948(f_1177_14925_14942(exception)) > 1))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 14708, 15630);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 15167, 15505);

                            e = f_1177_15171_15504(f_1177_15205_15503("HelpCultureNotSupported", f_1177_15291_15420(f_1177_15309_15355(), f_1177_15382_15419(", ", f_1177_15400_15418(exception))), ErrorCategory.InvalidArgument, f_1177_15478_15496(exception), null));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 15527, 15557);

                            e.Modules = f_1177_15539_15556(exception);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 15579, 15611);

                            e.Cultures = f_1177_15592_15610(exception);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 14708, 15630);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 15650, 15696);

                        f_1177_15650_15695(this, f_1177_15661_15694(e, _commandType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 15716, 15781);

                        LogContext
                        context = f_1177_15737_15780(f_1177_15758_15765(), f_1177_15767_15779())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 15801, 15828);

                        context.Severity = "Error";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 15848, 16015);

                        f_1177_15848_16014(PSEventId.Pipeline_Detail, PSOpcode.Exception, PSTask.ExecutePipeline, context, f_1177_15978_16013(e, _commandType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 14540, 16030);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 1491);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 1491);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 14476, 16041);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>.ValueCollection
                f_1177_14592_14610(System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 14592, 14610);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_14713_14732(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 14713, 14732);
                    return return_v;
                }


                string
                f_1177_14713_14754(System.Management.Automation.Help.UpdatableHelpSystemException
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 14713, 14754);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1177_14811_14829(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Cultures;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 14811, 14829);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1177_14841_14859(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Cultures;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 14841, 14859);
                    return return_v;
                }


                int
                f_1177_14841_14865(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 14841, 14865);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1177_14896_14913(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 14896, 14913);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1177_14925_14942(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 14925, 14942);
                    return return_v;
                }


                int
                f_1177_14925_14948(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 14925, 14948);
                    return return_v;
                }


                string
                f_1177_15309_15355()
                {
                    var return_v = HelpDisplayStrings.CannotMatchUICulturePattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 15309, 15355);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1177_15400_15418(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Cultures;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 15400, 15418);
                    return return_v;
                }


                string
                f_1177_15382_15419(string
                separator, System.Collections.Generic.HashSet<string>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 15382, 15419);
                    return return_v;
                }


                string
                f_1177_15291_15420(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 15291, 15420);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1177_15478_15496(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Cultures;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 15478, 15496);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_15205_15503(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, System.Collections.Generic.HashSet<string>
                targetObject, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, (object)targetObject, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 15205, 15503);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpExceptionContext
                f_1177_15171_15504(System.Management.Automation.Help.UpdatableHelpSystemException
                exception)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpExceptionContext(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 15171, 15504);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1177_15539_15556(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 15539, 15556);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1177_15592_15610(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Cultures;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 15592, 15610);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1177_15661_15694(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param, System.Management.Automation.Help.UpdatableHelpCommandType
                commandType)
                {
                    var return_v = this_param.CreateErrorRecord(commandType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 15661, 15694);
                    return return_v;
                }


                int
                f_1177_15650_15695(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 15650, 15695);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1177_15758_15765()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 15758, 15765);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1177_15767_15779()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 15767, 15779);
                    return return_v;
                }


                System.Management.Automation.LogContext
                f_1177_15737_15780(System.Management.Automation.ExecutionContext
                executionContext, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = MshLog.GetLogContext(executionContext, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 15737, 15780);
                    return return_v;
                }


                string
                f_1177_15978_16013(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param, System.Management.Automation.Help.UpdatableHelpCommandType
                commandType)
                {
                    var return_v = this_param.GetExceptionMessage(commandType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 15978, 16013);
                    return return_v;
                }


                int
                f_1177_15848_16014(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.LogContext
                logContext, string
                payLoad)
                {
                    PSEtwLog.LogOperationalError(id, opcode, task, logContext, payLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 15848, 16014);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>.ValueCollection
                f_1177_14592_14610_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 14592, 14610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 14476, 16041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 14476, 16041);
            }
        }

        internal void Process(IEnumerable<string> moduleNames, IEnumerable<ModuleSpecification> fullyQualifiedNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 16347, 17650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 16480, 16549);

                f_1177_16480_16501(_helpSystem).UseDefaultCredentials = _useDefaultCredentials;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 16565, 17639) || true) && (moduleNames != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 16565, 17639);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 16622, 16866);
                        foreach (string name in f_1177_16646_16657_I(moduleNames))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 16622, 16866);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 16699, 16791) || true) && (_stopping)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 16699, 16791);
                                DynAbs.Tracing.TraceSender.TraceBreak(1177, 16762, 16768);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 16699, 16791);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 16815, 16847);

                            f_1177_16815_16846(this, name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 16622, 16866);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 245);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 245);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 16565, 17639);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 16565, 17639);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 16900, 17639) || true) && (fullyQualifiedNames != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 16900, 17639);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 16965, 17242);
                            foreach (var fullyQualifiedName in f_1177_17000_17019_I(fullyQualifiedNames))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 16965, 17242);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 17061, 17153) || true) && (_stopping)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 17061, 17153);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1177, 17124, 17130);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 17061, 17153);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 17177, 17223);

                                f_1177_17177_17222(this, fullyQualifiedName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 16965, 17242);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 278);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 278);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 16900, 17639);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 16900, 17639);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 17308, 17624);
                            foreach (KeyValuePair<Tuple<string, Version>, UpdatableHelpModuleInfo> module in f_1177_17389_17419_I(f_1177_17389_17419(this, "*", null, true)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 17308, 17624);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 17461, 17553) || true) && (_stopping)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 17461, 17553);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1177, 17524, 17530);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 17461, 17553);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 17577, 17605);

                                f_1177_17577_17604(this, module.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 17308, 17624);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 317);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 317);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 16900, 17639);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 16565, 17639);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 16347, 17650);

                System.Net.WebClient
                f_1177_16480_16501(System.Management.Automation.Help.UpdatableHelpSystem
                this_param)
                {
                    var return_v = this_param.WebClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 16480, 16501);
                    return return_v;
                }


                int
                f_1177_16815_16846(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                name)
                {
                    this_param.ProcessModuleWithGlobbing(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 16815, 16846);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1177_16646_16657_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 16646, 16657);
                    return return_v;
                }


                int
                f_1177_17177_17222(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, Microsoft.PowerShell.Commands.ModuleSpecification
                fullyQualifiedName)
                {
                    this_param.ProcessModuleWithGlobbing(fullyQualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 17177, 17222);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1177_17000_17019_I(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 17000, 17019);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                f_1177_17389_17419(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                pattern, Microsoft.PowerShell.Commands.ModuleSpecification
                fullyQualifiedName, bool
                noErrors)
                {
                    var return_v = this_param.GetModuleInfo(pattern, fullyQualifiedName, noErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 17389, 17419);
                    return return_v;
                }


                int
                f_1177_17577_17604(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.Help.UpdatableHelpModuleInfo
                module)
                {
                    this_param.ProcessModule(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 17577, 17604);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                f_1177_17389_17419_I(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 17389, 17419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 16347, 17650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 16347, 17650);
            }
        }

        internal void Process(IEnumerable<PSModuleInfo> modules)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 17840, 18442);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 17921, 17971) || true) && (modules == null || (DynAbs.Tracing.TraceSender.Expression_False(1177, 17925, 17958) || !f_1177_17945_17958(modules)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 17921, 17971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 17962, 17969);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 17921, 17971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 17987, 18071);

                var
                helpModules = f_1177_18005_18070()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 18087, 18238);
                    foreach (PSModuleInfo module in f_1177_18119_18126_I(modules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 18087, 18238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 18160, 18223);

                        f_1177_18160_18222(this, module, f_1177_18194_18201(), helpModules, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 18087, 18238);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 152);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 18254, 18431);
                    foreach (KeyValuePair<Tuple<string, Version>, UpdatableHelpModuleInfo> helpModule in f_1177_18339_18350_I(helpModules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 18254, 18431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 18384, 18416);

                        f_1177_18384_18415(this, helpModule.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 18254, 18431);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 178);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 17840, 18442);

                bool
                f_1177_17945_17958(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 17945, 17958);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                f_1177_18005_18070()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 18005, 18070);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1177_18194_18201()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 18194, 18201);
                    return return_v;
                }


                int
                f_1177_18160_18222(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.PSModuleInfo
                module, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                helpModules, bool
                noErrors)
                {
                    this_param.ProcessSingleModuleObject(module, context, helpModules, noErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 18160, 18222);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1177_18119_18126_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 18119, 18126);
                    return return_v;
                }


                int
                f_1177_18384_18415(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.Help.UpdatableHelpModuleInfo
                module)
                {
                    this_param.ProcessModule(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 18384, 18415);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                f_1177_18339_18350_I(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 18339, 18350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 17840, 18442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 17840, 18442);
            }
        }

        private void ProcessModuleWithGlobbing(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 18625, 19175);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 18701, 18958) || true) && (f_1177_18705_18731(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 18701, 18958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 18765, 18874);

                    PSArgumentException
                    e = f_1177_18789_18873(f_1177_18813_18872(f_1177_18831_18871()))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 18892, 18918);

                    f_1177_18892_18917(this, f_1177_18903_18916(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 18936, 18943);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 18701, 18958);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 18974, 19164);
                    foreach (KeyValuePair<Tuple<string, Version>, UpdatableHelpModuleInfo> module in f_1177_19055_19087_I(f_1177_19055_19087(this, name, null, false)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 18974, 19164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 19121, 19149);

                        f_1177_19121_19148(this, module.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 18974, 19164);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 191);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 18625, 19175);

                bool
                f_1177_18705_18731(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 18705, 18731);
                    return return_v;
                }


                string
                f_1177_18831_18871()
                {
                    var return_v = HelpDisplayStrings.ModuleNameNullOrEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 18831, 18871);
                    return return_v;
                }


                string
                f_1177_18813_18872(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 18813, 18872);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1177_18789_18873(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 18789, 18873);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1177_18903_18916(System.Management.Automation.PSArgumentException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 18903, 18916);
                    return return_v;
                }


                int
                f_1177_18892_18917(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 18892, 18917);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                f_1177_19055_19087(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                pattern, Microsoft.PowerShell.Commands.ModuleSpecification
                fullyQualifiedName, bool
                noErrors)
                {
                    var return_v = this_param.GetModuleInfo(pattern, fullyQualifiedName, noErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 19055, 19087);
                    return return_v;
                }


                int
                f_1177_19121_19148(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.Help.UpdatableHelpModuleInfo
                module)
                {
                    this_param.ProcessModule(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 19121, 19148);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                f_1177_19055_19087_I(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 19055, 19087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 18625, 19175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 18625, 19175);
            }
        }

        private void ProcessModuleWithGlobbing(ModuleSpecification fullyQualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 19379, 19697);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 19482, 19686);
                    foreach (KeyValuePair<Tuple<string, Version>, UpdatableHelpModuleInfo> module in f_1177_19563_19609_I(f_1177_19563_19609(this, null, fullyQualifiedName, false)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 19482, 19686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 19643, 19671);

                        f_1177_19643_19670(this, module.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 19482, 19686);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 19379, 19697);

                System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                f_1177_19563_19609(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                pattern, Microsoft.PowerShell.Commands.ModuleSpecification
                fullyQualifiedName, bool
                noErrors)
                {
                    var return_v = this_param.GetModuleInfo(pattern, fullyQualifiedName, noErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 19563, 19609);
                    return return_v;
                }


                int
                f_1177_19643_19670(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.Help.UpdatableHelpModuleInfo
                module)
                {
                    this_param.ProcessModule(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 19643, 19670);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                f_1177_19563_19609_I(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 19563, 19609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 19379, 19697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 19379, 19697);
            }
        }

        private void ProcessModule(UpdatableHelpModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 19880, 23719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 19963, 20009);

                _helpSystem.CurrentModule = f_1177_19991_20008(module);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 20025, 20441) || true) && (this is UpdateHelpCommand && (DynAbs.Tracing.TraceSender.Expression_True(1177, 20029, 20094) && !f_1177_20059_20094(f_1177_20076_20093(module))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 20025, 20441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 20128, 20401);

                    f_1177_20128_20400(this, f_1177_20145_20162(module), null, f_1177_20191_20399("ModuleBaseMustExist", f_1177_20272_20329(f_1177_20290_20328()), ErrorCategory.InvalidOperation, null, null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 20419, 20426);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 20025, 20441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 20611, 20673);

                var
                cultures = _language ?? (DynAbs.Tracing.TraceSender.Expression_Null<string[]>(1177, 20626, 20672) ?? f_1177_20639_20672(_helpSystem))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 20689, 23708);
                    foreach (string culture in f_1177_20716_20724_I(cultures))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 20689, 23708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 20758, 20780);

                        bool
                        installed = true
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 20800, 20880) || true) && (_stopping)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 20800, 20880);
                            DynAbs.Tracing.TraceSender.TraceBreak(1177, 20855, 20861);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 20800, 20880);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 20944, 20986);

                            f_1177_20944_20985(this, module, culture);
                        }
                        catch (IOException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1177, 21023, 21280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 21085, 21261);

                            f_1177_21085_21260(this, f_1177_21102_21119(module), culture, f_1177_21130_21259("FailedToCopyFile", f_1177_21208_21217(e), ErrorCategory.InvalidOperation, null, e));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1177, 21023, 21280);
                        }
                        catch (UnauthorizedAccessException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1177, 21298, 21569);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 21376, 21550);

                            f_1177_21376_21549(this, f_1177_21393_21410(module), culture, f_1177_21421_21548("AccessIsDenied", f_1177_21497_21506(e), ErrorCategory.PermissionDenied, null, e));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1177, 21298, 21569);
                        }
                        catch (UpdatableHelpSystemException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1177, 22200, 22875);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 22279, 22856) || true) && (f_1177_22283_22306(e) == "HelpCultureNotSupported")
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 22279, 22856);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 22385, 22403);

                                installed = false;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 22431, 22687) || true) && (_language != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 22431, 22687);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 22612, 22660);

                                    f_1177_22612_22659(this, f_1177_22629_22646(module), culture, e);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 22431, 22687);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 22279, 22856);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 22279, 22856);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 22785, 22833);

                                f_1177_22785_22832(this, f_1177_22802_22819(module), culture, e);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 22279, 22856);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1177, 22200, 22875);
                        }
                        catch (Exception e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1177, 22893, 23020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 22953, 23001);

                            f_1177_22953_23000(this, f_1177_22970_22987(module), culture, e);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1177, 22893, 23020);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1177, 23038, 23449);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 23086, 23430) || true) && (f_1177_23090_23114(f_1177_23090_23108(_helpSystem)) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 23086, 23430);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 23169, 23352);
                                    foreach (Exception error in f_1177_23197_23215_I(f_1177_23197_23215(_helpSystem)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 23169, 23352);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 23273, 23325);

                                        f_1177_23273_23324(this, f_1177_23290_23307(module), culture, error);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 23169, 23352);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 184);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 184);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 23380, 23407);

                                f_1177_23380_23406(f_1177_23380_23398(_helpSystem));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 23086, 23430);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1177, 23038, 23449);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 23592, 23693) || true) && (_language == null && (DynAbs.Tracing.TraceSender.Expression_True(1177, 23596, 23626) && installed))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 23592, 23693);
                            DynAbs.Tracing.TraceSender.TraceBreak(1177, 23668, 23674);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 23592, 23693);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 20689, 23708);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 3020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 3020);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 19880, 23719);

                string
                f_1177_19991_20008(System.Management.Automation.Help.UpdatableHelpModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 19991, 20008);
                    return return_v;
                }


                string
                f_1177_20076_20093(System.Management.Automation.Help.UpdatableHelpModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 20076, 20093);
                    return return_v;
                }


                bool
                f_1177_20059_20094(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 20059, 20094);
                    return return_v;
                }


                string
                f_1177_20145_20162(System.Management.Automation.Help.UpdatableHelpModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 20145, 20162);
                    return return_v;
                }


                string
                f_1177_20290_20328()
                {
                    var return_v = HelpDisplayStrings.ModuleBaseMustExist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 20290, 20328);
                    return return_v;
                }


                string
                f_1177_20272_20329(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 20272, 20329);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_20191_20399(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, object
                targetObject, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, targetObject, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 20191, 20399);
                    return return_v;
                }


                int
                f_1177_20128_20400(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                moduleName, string
                culture, System.Management.Automation.Help.UpdatableHelpSystemException
                e)
                {
                    this_param.ProcessException(moduleName, culture, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 20128, 20400);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1177_20639_20672(System.Management.Automation.Help.UpdatableHelpSystem
                this_param)
                {
                    var return_v = this_param.GetCurrentUICulture();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 20639, 20672);
                    return return_v;
                }


                bool
                f_1177_20944_20985(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.Help.UpdatableHelpModuleInfo
                module, string
                culture)
                {
                    var return_v = this_param.ProcessModuleWithCulture(module, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 20944, 20985);
                    return return_v;
                }


                string
                f_1177_21102_21119(System.Management.Automation.Help.UpdatableHelpModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 21102, 21119);
                    return return_v;
                }


                string
                f_1177_21208_21217(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 21208, 21217);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_21130_21259(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, object
                targetObject, System.IO.IOException
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, targetObject, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 21130, 21259);
                    return return_v;
                }


                int
                f_1177_21085_21260(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                moduleName, string
                culture, System.Management.Automation.Help.UpdatableHelpSystemException
                e)
                {
                    this_param.ProcessException(moduleName, culture, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 21085, 21260);
                    return 0;
                }


                string
                f_1177_21393_21410(System.Management.Automation.Help.UpdatableHelpModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 21393, 21410);
                    return return_v;
                }


                string
                f_1177_21497_21506(System.UnauthorizedAccessException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 21497, 21506);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_21421_21548(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, object
                targetObject, System.UnauthorizedAccessException
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, targetObject, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 21421, 21548);
                    return return_v;
                }


                int
                f_1177_21376_21549(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                moduleName, string
                culture, System.Management.Automation.Help.UpdatableHelpSystemException
                e)
                {
                    this_param.ProcessException(moduleName, culture, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 21376, 21549);
                    return 0;
                }


                string
                f_1177_22283_22306(System.Management.Automation.Help.UpdatableHelpSystemException
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 22283, 22306);
                    return return_v;
                }


                string
                f_1177_22629_22646(System.Management.Automation.Help.UpdatableHelpModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 22629, 22646);
                    return return_v;
                }


                int
                f_1177_22612_22659(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                moduleName, string
                culture, System.Management.Automation.Help.UpdatableHelpSystemException
                e)
                {
                    this_param.ProcessException(moduleName, culture, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 22612, 22659);
                    return 0;
                }


                string
                f_1177_22802_22819(System.Management.Automation.Help.UpdatableHelpModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 22802, 22819);
                    return return_v;
                }


                int
                f_1177_22785_22832(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                moduleName, string
                culture, System.Management.Automation.Help.UpdatableHelpSystemException
                e)
                {
                    this_param.ProcessException(moduleName, culture, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 22785, 22832);
                    return 0;
                }


                string
                f_1177_22970_22987(System.Management.Automation.Help.UpdatableHelpModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 22970, 22987);
                    return return_v;
                }


                int
                f_1177_22953_23000(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                moduleName, string
                culture, System.Exception
                e)
                {
                    this_param.ProcessException(moduleName, culture, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 22953, 23000);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Exception>
                f_1177_23090_23108(System.Management.Automation.Help.UpdatableHelpSystem
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 23090, 23108);
                    return return_v;
                }


                int
                f_1177_23090_23114(System.Collections.ObjectModel.Collection<System.Exception>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 23090, 23114);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Exception>
                f_1177_23197_23215(System.Management.Automation.Help.UpdatableHelpSystem
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 23197, 23215);
                    return return_v;
                }


                string
                f_1177_23290_23307(System.Management.Automation.Help.UpdatableHelpModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 23290, 23307);
                    return return_v;
                }


                int
                f_1177_23273_23324(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                moduleName, string
                culture, System.Exception
                e)
                {
                    this_param.ProcessException(moduleName, culture, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 23273, 23324);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Exception>
                f_1177_23197_23215_I(System.Collections.ObjectModel.Collection<System.Exception>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 23197, 23215);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Exception>
                f_1177_23380_23398(System.Management.Automation.Help.UpdatableHelpSystem
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 23380, 23398);
                    return return_v;
                }


                int
                f_1177_23380_23406(System.Collections.ObjectModel.Collection<System.Exception>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 23380, 23406);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1177_20716_20724_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 20716, 20724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 19880, 23719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 19880, 23719);
            }
        }

        internal virtual bool ProcessModuleWithCulture(UpdatableHelpModuleInfo module, string culture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 24042, 24185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 24161, 24174);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 24042, 24185);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 24042, 24185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 24042, 24185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Dictionary<Tuple<string, Version>, UpdatableHelpModuleInfo> GetModuleInfo(string pattern, ModuleSpecification fullyQualifiedName, bool noErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 24627, 25599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 24805, 24937);

                Dictionary<Tuple<string, Version>, UpdatableHelpModuleInfo>
                modules = f_1177_24875_24936(this, f_1177_24889_24896(), pattern, fullyQualifiedName, noErrors)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 24953, 25557) || true) && (f_1177_24957_24970(modules) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1177, 24957, 25001) && f_1177_24979_24996(_exceptions) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1177, 24957, 25014) && !noErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 24953, 25557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 25048, 25328);

                    var
                    errorMessage = (DynAbs.Tracing.TraceSender.Conditional_F1(1177, 25067, 25093) || ((fullyQualifiedName != null && DynAbs.Tracing.TraceSender.Conditional_F2(1177, 25096, 25190)) || DynAbs.Tracing.TraceSender.Conditional_F3(1177, 25256, 25327))) ? f_1177_25096_25190(f_1177_25114_25169(), fullyQualifiedName) : f_1177_25256_25327(f_1177_25274_25317(), pattern)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 25348, 25498);

                    ErrorRecord
                    errorRecord = f_1177_25374_25497(f_1177_25390_25417(errorMessage), "ModuleNotFound", ErrorCategory.InvalidArgument, pattern)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 25518, 25542);

                    f_1177_25518_25541(this, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 24953, 25557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 25573, 25588);

                return modules;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 24627, 25599);

                System.Management.Automation.ExecutionContext
                f_1177_24889_24896()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 24889, 24896);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                f_1177_24875_24936(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.ExecutionContext
                context, string
                pattern, Microsoft.PowerShell.Commands.ModuleSpecification
                fullyQualifiedName, bool
                noErrors)
                {
                    var return_v = this_param.GetModuleInfo(context, pattern, fullyQualifiedName, noErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 24875, 24936);
                    return return_v;
                }


                int
                f_1177_24957_24970(System.Collections.Generic.Dictionary<System.Tuple<string, System.Version>, System.Management.Automation.Help.UpdatableHelpModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 24957, 24970);
                    return return_v;
                }


                int
                f_1177_24979_24996(System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 24979, 24996);
                    return return_v;
                }


                string
                f_1177_25114_25169()
                {
                    var return_v = HelpDisplayStrings.ModuleNotFoundWithFullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 25114, 25169);
                    return return_v;
                }


                string
                f_1177_25096_25190(string
                formatSpec, Microsoft.PowerShell.Commands.ModuleSpecification
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 25096, 25190);
                    return return_v;
                }


                string
                f_1177_25274_25317()
                {
                    var return_v = HelpDisplayStrings.CannotMatchModulePattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 25274, 25317);
                    return return_v;
                }


                string
                f_1177_25256_25327(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 25256, 25327);
                    return return_v;
                }


                System.Exception
                f_1177_25390_25417(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 25390, 25417);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1177_25374_25497(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 25374, 25497);
                    return return_v;
                }


                int
                f_1177_25518_25541(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 25518, 25541);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 24627, 25599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 24627, 25599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsUpdateNecessary(UpdatableHelpModuleInfo module, UpdatableHelpInfo currentHelpInfo,
                    UpdatableHelpInfo newHelpInfo, CultureInfo culture, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 26106, 27308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 26306, 26335);

                f_1177_26306_26334(module != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 26351, 26663) || true) && (newHelpInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 26351, 26663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 26408, 26648);

                    throw f_1177_26414_26647("UnableToRetrieveHelpInfoXml", f_1177_26499_26578(f_1177_26517_26563(), f_1177_26565_26577(culture)), ErrorCategory.ResourceUnavailable, null, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 26351, 26663);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 26709, 27067) || true) && (!f_1177_26714_26753(newHelpInfo, culture))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 26709, 27067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 26787, 27052);

                    throw f_1177_26793_27051("HelpCultureNotSupported", f_1177_26874_27006(f_1177_26892_26934(), f_1177_26957_26969(culture), f_1177_26971_27005(newHelpInfo)), ErrorCategory.InvalidOperation, null, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 26709, 27067);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 27113, 27269) || true) && (!force && (DynAbs.Tracing.TraceSender.Expression_True(1177, 27117, 27150) && currentHelpInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1177, 27117, 27207) && !f_1177_27155_27207(currentHelpInfo, newHelpInfo, culture)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 27113, 27269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 27241, 27254);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 27113, 27269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 27285, 27297);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 26106, 27308);

                int
                f_1177_26306_26334(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 26306, 26334);
                    return 0;
                }


                string
                f_1177_26517_26563()
                {
                    var return_v = HelpDisplayStrings.UnableToRetrieveHelpInfoXml;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 26517, 26563);
                    return return_v;
                }


                string
                f_1177_26565_26577(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 26565, 26577);
                    return return_v;
                }


                string
                f_1177_26499_26578(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 26499, 26578);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_26414_26647(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, object
                targetObject, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, targetObject, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 26414, 26647);
                    return return_v;
                }


                bool
                f_1177_26714_26753(System.Management.Automation.Help.UpdatableHelpInfo
                this_param, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.IsCultureSupported(culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 26714, 26753);
                    return return_v;
                }


                string
                f_1177_26892_26934()
                {
                    var return_v = HelpDisplayStrings.HelpCultureNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 26892, 26934);
                    return return_v;
                }


                string
                f_1177_26957_26969(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 26957, 26969);
                    return return_v;
                }


                string
                f_1177_26971_27005(System.Management.Automation.Help.UpdatableHelpInfo
                this_param)
                {
                    var return_v = this_param.GetSupportedCultures();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 26971, 27005);
                    return return_v;
                }


                string
                f_1177_26874_27006(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 26874, 27006);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_26793_27051(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, object
                targetObject, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, targetObject, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 26793, 27051);
                    return return_v;
                }


                bool
                f_1177_27155_27207(System.Management.Automation.Help.UpdatableHelpInfo
                this_param, System.Management.Automation.Help.UpdatableHelpInfo
                helpInfo, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.IsNewerVersion(helpInfo, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 27155, 27207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 26106, 27308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 26106, 27308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CheckOncePerDayPerModule(string moduleName, string path, string filename, DateTime time, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 27843, 29028);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28028, 28098) || true) && (force)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 28028, 28098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28071, 28083);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 28028, 28098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28114, 28182);

                string
                helpInfoFilePath = f_1177_28140_28181(f_1177_28140_28157(f_1177_28140_28152()), path, filename)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28230, 28325) || true) && (!f_1177_28235_28264(helpInfoFilePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 28230, 28325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28298, 28310);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 28230, 28325);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28341, 28408);

                DateTime
                lastModified = f_1177_28365_28407(helpInfoFilePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28422, 28464);

                TimeSpan
                difference = time - lastModified
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28480, 28565) || true) && (difference.Days >= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 28480, 28565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28538, 28550);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 28480, 28565);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28581, 28988) || true) && (_commandType == UpdatableHelpCommandType.UpdateHelpCommand)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 28581, 28988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28677, 28762);

                    f_1177_28677_28761(this, f_1177_28690_28760(f_1177_28708_28747(), moduleName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 28581, 28988);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 28581, 28988);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28796, 28988) || true) && (_commandType == UpdatableHelpCommandType.SaveHelpCommand)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 28796, 28988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 28890, 28973);

                        f_1177_28890_28972(this, f_1177_28903_28971(f_1177_28921_28958(), moduleName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 28796, 28988);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 28581, 28988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 29004, 29017);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 27843, 29028);

                System.Management.Automation.SessionState
                f_1177_28140_28152()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 28140, 28152);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1177_28140_28157(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 28140, 28157);
                    return return_v;
                }


                string
                f_1177_28140_28181(System.Management.Automation.PathIntrinsics
                this_param, string
                parent, string
                child)
                {
                    var return_v = this_param.Combine(parent, child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 28140, 28181);
                    return return_v;
                }


                bool
                f_1177_28235_28264(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 28235, 28264);
                    return return_v;
                }


                System.DateTime
                f_1177_28365_28407(string
                path)
                {
                    var return_v = File.GetLastWriteTimeUtc(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 28365, 28407);
                    return return_v;
                }


                string
                f_1177_28708_28747()
                {
                    var return_v = HelpDisplayStrings.UseForceToUpdateHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 28708, 28747);
                    return return_v;
                }


                string
                f_1177_28690_28760(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 28690, 28760);
                    return return_v;
                }


                int
                f_1177_28677_28761(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 28677, 28761);
                    return 0;
                }


                string
                f_1177_28921_28958()
                {
                    var return_v = HelpDisplayStrings.UseForceToSaveHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 28921, 28958);
                    return return_v;
                }


                string
                f_1177_28903_28971(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 28903, 28971);
                    return return_v;
                }


                int
                f_1177_28890_28972(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 28890, 28972);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 27843, 29028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 27843, 29028);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<string> ResolvePath(string path, bool recurse, bool isLiteralPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 29423, 31497);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 29535, 29583);

                List<string>
                resolvedPaths = f_1177_29564_29582()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 29599, 30548) || true) && (isLiteralPath)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 29599, 30548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 29650, 29727);

                    string
                    newPath = f_1177_29667_29726(f_1177_29667_29684(f_1177_29667_29679()), path)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 29747, 30093) || true) && (!f_1177_29752_29777(newPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 29747, 30093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 29819, 30074);

                        throw f_1177_29825_30073("PathMustBeValidContainers", f_1177_29912_29981(f_1177_29930_29974(), path), ErrorCategory.InvalidArgument, null, f_1177_30045_30072());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 29747, 30093);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 30113, 30140);

                    f_1177_30113_30139(
                                    resolvedPaths, newPath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 29599, 30548);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 29599, 30548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 30206, 30299);

                    Collection<PathInfo>
                    resolvedPathInfos = f_1177_30247_30298(f_1177_30247_30264(f_1177_30247_30259()), path)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 30317, 30533);
                        foreach (PathInfo resolvedPath in f_1177_30351_30368_I(resolvedPathInfos))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 30317, 30533);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 30410, 30445);

                            f_1177_30410_30444(this, resolvedPath);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 30469, 30514);

                            f_1177_30469_30513(
                                                resolvedPaths, f_1177_30487_30512(resolvedPath));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 30317, 30533);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 217);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 217);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 29599, 30548);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 30564, 31458);
                    foreach (string resolvedPath in f_1177_30596_30609_I(resolvedPaths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 30564, 31458);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 30643, 31443) || true) && (recurse)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 30643, 31443);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 30696, 30877);
                                foreach (string innerResolvedPath in f_1177_30733_30773_I(f_1177_30733_30773(this, resolvedPath)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 30696, 30877);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 30823, 30854);

                                    listYield.Add(innerResolvedPath);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 30696, 30877);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 182);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 182);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 30643, 31443);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 30643, 31443);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 30996, 31068);

                            CmdletProviderContext
                            context = f_1177_31028_31067(f_1177_31054_31066(this))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 31187, 31228);

                            context.SuppressWildcardExpansion = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 31250, 31424) || true) && (isLiteralPath || (DynAbs.Tracing.TraceSender.Expression_False(1177, 31254, 31325) || f_1177_31271_31325(f_1177_31271_31290(f_1177_31271_31285()), resolvedPath, context)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 31250, 31424);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 31375, 31401);

                                listYield.Add(resolvedPath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 31250, 31424);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 30643, 31443);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 30564, 31458);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 895);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 895);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 31474, 31486);

                return listYield;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 29423, 31497);

                return listYield;

                System.Collections.Generic.List<string>
                f_1177_29564_29582()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 29564, 29582);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1177_29667_29679()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 29667, 29679);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1177_29667_29684(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 29667, 29684);
                    return return_v;
                }


                string
                f_1177_29667_29726(System.Management.Automation.PathIntrinsics
                this_param, string
                path)
                {
                    var return_v = this_param.GetUnresolvedProviderPathFromPSPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 29667, 29726);
                    return return_v;
                }


                bool
                f_1177_29752_29777(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 29752, 29777);
                    return return_v;
                }


                string
                f_1177_29930_29974()
                {
                    var return_v = HelpDisplayStrings.PathMustBeValidContainers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 29930, 29974);
                    return return_v;
                }


                string
                f_1177_29912_29981(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 29912, 29981);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1177_30045_30072()
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 30045, 30072);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_29825_30073(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, object
                targetObject, System.Management.Automation.ItemNotFoundException
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, targetObject, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 29825, 30073);
                    return return_v;
                }


                int
                f_1177_30113_30139(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 30113, 30139);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1177_30247_30259()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 30247, 30259);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1177_30247_30264(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 30247, 30264);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1177_30247_30298(System.Management.Automation.PathIntrinsics
                this_param, string
                path)
                {
                    var return_v = this_param.GetResolvedPSPathFromPSPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 30247, 30298);
                    return return_v;
                }


                int
                f_1177_30410_30444(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, System.Management.Automation.PathInfo
                path)
                {
                    this_param.ValidatePathProvider(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 30410, 30444);
                    return 0;
                }


                string
                f_1177_30487_30512(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.ProviderPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 30487, 30512);
                    return return_v;
                }


                int
                f_1177_30469_30513(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 30469, 30513);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1177_30351_30368_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 30351, 30368);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1177_30733_30773(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                path)
                {
                    var return_v = this_param.RecursiveResolvePathHelper(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 30733, 30773);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1177_30733_30773_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 30733, 30773);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1177_31054_31066(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 31054, 31066);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1177_31028_31067(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 31028, 31067);
                    return return_v;
                }


                System.Management.Automation.ProviderIntrinsics
                f_1177_31271_31285()
                {
                    var return_v = InvokeProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 31271, 31285);
                    return return_v;
                }


                System.Management.Automation.ItemCmdletProviderIntrinsics
                f_1177_31271_31290(System.Management.Automation.ProviderIntrinsics
                this_param)
                {
                    var return_v = this_param.Item;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 31271, 31290);
                    return return_v;
                }


                bool
                f_1177_31271_31325(System.Management.Automation.ItemCmdletProviderIntrinsics
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.IsContainer(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 31271, 31325);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1177_30596_30609_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 30596, 30609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 29423, 31497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 29423, 31497);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<string> RecursiveResolvePathHelper(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 31741, 32291);

                var listYield = new List<String>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 31833, 32252) || true) && (f_1177_31837_31869(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 31833, 32252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 31903, 31921);

                    listYield.Add(path);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 31941, 32237);
                        foreach (string subDirectory in f_1177_31973_32003_I(f_1177_31973_32003(path)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 31941, 32237);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 32045, 32218);
                                foreach (string subDirectory2 in f_1177_32078_32118_I(f_1177_32078_32118(this, subDirectory)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 32045, 32218);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 32168, 32195);

                                    listYield.Add(subDirectory2);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 32045, 32218);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 174);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 174);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 31941, 32237);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1177, 1, 297);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1177, 1, 297);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 31833, 32252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 32268, 32280);

                return listYield;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 31741, 32291);

                return listYield;

                bool
                f_1177_31837_31869(string
                path)
                {
                    var return_v = System.IO.Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 31837, 31869);
                    return return_v;
                }


                string[]
                f_1177_31973_32003(string
                path)
                {
                    var return_v = Directory.GetDirectories(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 31973, 32003);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1177_32078_32118(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
                this_param, string
                path)
                {
                    var return_v = this_param.RecursiveResolvePathHelper(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 32078, 32118);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1177_32078_32118_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 32078, 32118);
                    return return_v;
                }


                string[]
                f_1177_31973_32003_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 31973, 32003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 31741, 32291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 31741, 32291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ValidatePathProvider(PathInfo path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 32551, 32892);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 32625, 32881) || true) && (f_1177_32629_32642(path) == null || (DynAbs.Tracing.TraceSender.Expression_False(1177, 32629, 32707) || f_1177_32654_32672(f_1177_32654_32667(path)) != FileSystemProvider.ProviderName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 32625, 32881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 32741, 32866);

                    throw f_1177_32747_32865(f_1177_32771_32864(f_1177_32789_32831(), f_1177_32854_32863(path)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 32625, 32881);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 32551, 32892);

                System.Management.Automation.ProviderInfo
                f_1177_32629_32642(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 32629, 32642);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1177_32654_32667(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 32654, 32667);
                    return return_v;
                }


                string
                f_1177_32654_32672(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 32654, 32672);
                    return return_v;
                }


                string
                f_1177_32789_32831()
                {
                    var return_v = HelpDisplayStrings.ProviderIsNotFileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 32789, 32831);
                    return return_v;
                }


                string
                f_1177_32854_32863(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 32854, 32863);
                    return return_v;
                }


                string
                f_1177_32771_32864(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 32771, 32864);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1177_32747_32865(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 32747, 32865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 32551, 32892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 32551, 32892);
            }
        }

        internal void LogMessage(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 33096, 33477);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 33096, 33477);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 33096, 33477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 33096, 33477);
            }
        }

        internal void ProcessException(string moduleName, string culture, Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1177, 33825, 35284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 33928, 33971);

                UpdatableHelpSystemException
                except = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 33987, 34831) || true) && (e is UpdatableHelpSystemException)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 33987, 34831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 34058, 34099);

                    except = (UpdatableHelpSystemException)e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 33987, 34831);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 33987, 34831);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 34422, 34831) || true) && (e is PSArgumentException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 34422, 34831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 34484, 34617);

                        except = f_1177_34493_34616("InvalidArgument", f_1177_34566_34575(e), ErrorCategory.InvalidArgument, null, e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 34422, 34831);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 34422, 34831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 34683, 34816);

                        except = f_1177_34692_34815("UnknownErrorId", f_1177_34764_34773(e), ErrorCategory.InvalidOperation, null, e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 34422, 34831);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 33987, 34831);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 34847, 35043) || true) && (!f_1177_34852_34905(_exceptions, f_1177_34876_34904(except)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 34847, 35043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 34939, 35028);

                    f_1177_34939_35027(_exceptions, f_1177_34955_34983(except), f_1177_34985_35026(except));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 34847, 35043);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 35059, 35125);

                f_1177_35059_35124(f_1177_35059_35108(f_1177_35059_35100(_exceptions, f_1177_35071_35099(except))), moduleName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 35141, 35273) || true) && (culture != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1177, 35141, 35273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1177, 35194, 35258);

                    f_1177_35194_35257(f_1177_35194_35244(f_1177_35194_35235(_exceptions, f_1177_35206_35234(except))), culture);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1177, 35141, 35273);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1177, 33825, 35284);

                string
                f_1177_34566_34575(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 34566, 34575);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_34493_34616(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, object
                targetObject, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, targetObject, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 34493, 34616);
                    return return_v;
                }


                string
                f_1177_34764_34773(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 34764, 34773);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpSystemException
                f_1177_34692_34815(string
                errorId, string
                message, System.Management.Automation.ErrorCategory
                cat, object
                targetObject, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException(errorId, message, cat, targetObject, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 34692, 34815);
                    return return_v;
                }


                string
                f_1177_34876_34904(System.Management.Automation.Help.UpdatableHelpSystemException
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 34876, 34904);
                    return return_v;
                }


                bool
                f_1177_34852_34905(System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 34852, 34905);
                    return return_v;
                }


                string
                f_1177_34955_34983(System.Management.Automation.Help.UpdatableHelpSystemException
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 34955, 34983);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpExceptionContext
                f_1177_34985_35026(System.Management.Automation.Help.UpdatableHelpSystemException
                exception)
                {
                    var return_v = new System.Management.Automation.Help.UpdatableHelpExceptionContext(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 34985, 35026);
                    return return_v;
                }


                int
                f_1177_34939_35027(System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>
                this_param, string
                key, System.Management.Automation.Help.UpdatableHelpExceptionContext
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 34939, 35027);
                    return 0;
                }


                string
                f_1177_35071_35099(System.Management.Automation.Help.UpdatableHelpSystemException
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 35071, 35099);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpExceptionContext
                f_1177_35059_35100(System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 35059, 35100);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1177_35059_35108(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 35059, 35108);
                    return return_v;
                }


                bool
                f_1177_35059_35124(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 35059, 35124);
                    return return_v;
                }


                string
                f_1177_35206_35234(System.Management.Automation.Help.UpdatableHelpSystemException
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 35206, 35234);
                    return return_v;
                }


                System.Management.Automation.Help.UpdatableHelpExceptionContext
                f_1177_35194_35235(System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 35194, 35235);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1177_35194_35244(System.Management.Automation.Help.UpdatableHelpExceptionContext
                this_param)
                {
                    var return_v = this_param.Cultures;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 35194, 35244);
                    return return_v;
                }


                bool
                f_1177_35194_35257(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 35194, 35257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1177, 33825, 35284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1177, 33825, 35284);
            }
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1177, 734, 35313);

        static System.StringComparer
        f_1177_5399_5431()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1177, 5399, 5431);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, string>
        f_1177_5368_5432(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 5368, 5432);
            return return_v;
        }


        static int
        f_1177_5503_5609(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 5503, 5609);
            return 0;
        }


        static int
        f_1177_5624_5723(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 5624, 5723);
            return 0;
        }


        static int
        f_1177_5738_5840(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 5738, 5840);
            return 0;
        }


        static int
        f_1177_5855_5954(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 5855, 5954);
            return 0;
        }


        static int
        f_1177_5969_6074(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 5969, 6074);
            return 0;
        }


        static int
        f_1177_6089_6192(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 6089, 6192);
            return 0;
        }


        static int
        f_1177_6207_6307(System.Collections.Generic.Dictionary<string, string>
        this_param, string
        key, string
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 6207, 6307);
            return 0;
        }


        System.Management.Automation.Help.UpdatableHelpSystem
        f_1177_7063_7116(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
        cmdlet, bool
        useDefaultCredentials)
        {
            var return_v = new System.Management.Automation.Help.UpdatableHelpSystem(cmdlet, useDefaultCredentials);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 7063, 7116);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>
        f_1177_7145_7200()
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Help.UpdatableHelpExceptionContext>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 7145, 7200);
            return return_v;
        }


        System.Random
        f_1177_7350_7362()
        {
            var return_v = new System.Random();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 7350, 7362);
            return return_v;
        }


        int
        f_1177_7392_7403(System.Random
        this_param)
        {
            var return_v = this_param.Next();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1177, 7392, 7403);
            return return_v;
        }

    }

    /// <summary>
    /// Scope to which the help should be saved.
    /// </summary>
    public enum UpdateHelpScope
    {
        /// <summary>
        /// Save the help content to the user directory.
        CurrentUser,

        /// <summary>
        /// Save the help content to the module directory. This is the default behavior.
        /// </summary>
        AllUsers
    }
}
