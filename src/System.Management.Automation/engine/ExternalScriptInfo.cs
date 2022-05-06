// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Security;
using System.Text;

using Microsoft.PowerShell.Commands;

namespace System.Management.Automation
{
    public class ExternalScriptInfo : CommandInfo, IScriptCommandInfo
    {
        internal ExternalScriptInfo(string name, string path, ExecutionContext context)
        : base(f_1275_1539_1543_C(name), CommandTypes.ExternalScript, context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1275, 1439, 2069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 5500, 5520);
                this._path = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8358, 8370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8404, 8419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 13308, 13325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 13825, 13841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 17025, 17040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 17457, 17474);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 1607, 1735) || true) && (f_1275_1611_1637(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 1607, 1735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 1671, 1720);

                    throw f_1275_1677_1719("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 1607, 1735);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 1751, 1852);

                f_1275_1751_1851(f_1275_1770_1796(path), "Caller makes sure that 'path' is already resolved.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 1987, 2021);

                _path = f_1275_1995_2020(path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 2035, 2058);

                f_1275_2035_2057(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1275, 1439, 2069);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 1439, 2069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 1439, 2069);
            }
        }

        internal ExternalScriptInfo(string name, string path) : base(f_1275_2703_2707_C(name), CommandTypes.ExternalScript)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1275, 2642, 3224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 5500, 5520);
                this._path = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8358, 8370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8404, 8419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 13308, 13325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 13825, 13841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 17025, 17040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 17457, 17474);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 2762, 2890) || true) && (f_1275_2766_2792(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 2762, 2890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 2826, 2875);

                    throw f_1275_2832_2874("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 2762, 2890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 2906, 3007);

                f_1275_2906_3006(f_1275_2925_2951(path), "Caller makes sure that 'path' is already resolved.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 3142, 3176);

                _path = f_1275_3150_3175(path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 3190, 3213);

                f_1275_3190_3212(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1275, 2642, 3224);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 2642, 3224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 2642, 3224);
            }
        }

        internal ExternalScriptInfo(ExternalScriptInfo other)
        : base(f_1275_3430_3435_C(other))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1275, 3356, 3529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 5500, 5520);
                this._path = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8358, 8370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8404, 8419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 13308, 13325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 13825, 13841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 17025, 17040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 17457, 17474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 3461, 3481);

                _path = other._path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 3495, 3518);

                f_1275_3495_3517(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1275, 3356, 3529);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 3356, 3529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 3356, 3529);
            }
        }

        private void CommonInitialization()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 3645, 4637);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 3857, 4626) || true) && (f_1275_3861_3899() != SystemEnforcementMode.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 3857, 4626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 4185, 4274);

                    SystemEnforcementMode
                    scriptSpecificPolicy = f_1275_4230_4273(_path, null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 4292, 4611) || true) && (scriptSpecificPolicy != SystemEnforcementMode.Enforce)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 4292, 4611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 4391, 4447);

                        this.DefiningLanguageMode = PSLanguageMode.FullLanguage;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 4292, 4611);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 4292, 4611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 4529, 4592);

                        this.DefiningLanguageMode = PSLanguageMode.ConstrainedLanguage;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 4292, 4611);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 3857, 4626);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 3645, 4637);

                System.Management.Automation.Security.SystemEnforcementMode
                f_1275_3861_3899()
                {
                    var return_v = SystemPolicy.GetSystemLockdownPolicy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 3861, 3899);
                    return return_v;
                }


                System.Management.Automation.Security.SystemEnforcementMode
                f_1275_4230_4273(string
                path, System.Runtime.InteropServices.SafeHandle
                handle)
                {
                    var return_v = SystemPolicy.GetLockdownPolicy(path, handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 4230, 4273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 3645, 4637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 3645, 4637);
            }
        }

        internal override CommandInfo CreateGetCommandCopy(object[] argumentList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 4878, 5122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 4976, 5085);

                ExternalScriptInfo
                copy = new ExternalScriptInfo(this) { IsGetCommandCopy = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1275, 5002, 5084), Arguments = argumentList }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 5099, 5111);

                return copy;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 4878, 5122);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 4878, 5122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 4878, 5122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override HelpCategory HelpCategory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 5229, 5272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 5235, 5270);

                    return HelpCategory.ExternalScript;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 5229, 5272);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 5161, 5283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 5161, 5283);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Path
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 5432, 5453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 5438, 5451);

                    return _path;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 5432, 5453);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 5389, 5464);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 5389, 5464);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly string _path;

        public override string Definition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 5685, 5705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 5691, 5703);

                    return f_1275_5698_5702();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 5685, 5705);

                    string
                    f_1275_5698_5702()
                    {
                        var return_v = Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 5698, 5702);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 5627, 5716);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 5627, 5716);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Source
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 5875, 5906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 5881, 5904);

                    return f_1275_5888_5903(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 5875, 5906);

                    string
                    f_1275_5888_5903(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        var return_v = this_param.Definition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 5888, 5903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 5821, 5917);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 5821, 5917);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override string Syntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 6078, 6615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 6114, 6159);

                    StringBuilder
                    synopsis = f_1275_6139_6158()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 6179, 6553);
                        foreach (CommandParameterSetInfo parameterSet in f_1275_6228_6241_I(f_1275_6228_6241()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 6179, 6553);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 6283, 6534);

                            f_1275_6283_6533(synopsis, f_1275_6329_6532(f_1275_6373_6413(), "{0} {1}", f_1275_6484_6488(), parameterSet));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 6179, 6553);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1275, 1, 375);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1275, 1, 375);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 6573, 6600);

                    return f_1275_6580_6599(synopsis);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 6078, 6615);

                    System.Text.StringBuilder
                    f_1275_6139_6158()
                    {
                        var return_v = new System.Text.StringBuilder();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 6139, 6158);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                    f_1275_6228_6241()
                    {
                        var return_v = ParameterSets;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 6228, 6241);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1275_6373_6413()
                    {
                        var return_v = Globalization.CultureInfo.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 6373, 6413);
                        return return_v;
                    }


                    string
                    f_1275_6484_6488()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 6484, 6488);
                        return return_v;
                    }


                    string
                    f_1275_6329_6532(System.Globalization.CultureInfo
                    provider, string
                    format, string
                    arg0, System.Management.Automation.CommandParameterSetInfo
                    arg1)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 6329, 6532);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_1275_6283_6533(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.AppendLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 6283, 6533);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                    f_1275_6228_6241_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 6228, 6241);
                        return return_v;
                    }


                    string
                    f_1275_6580_6599(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 6580, 6599);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 6022, 6626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 6022, 6626);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SessionStateEntryVisibility Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 6821, 7018);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 6857, 6920) || true) && (f_1275_6861_6868() == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 6857, 6920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 6878, 6920);

                        return SessionStateEntryVisibility.Public;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 6857, 6920);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 6940, 7003);

                    return f_1275_6947_7002(f_1275_6947_6973(f_1275_6947_6954()), _path);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 6821, 7018);

                    System.Management.Automation.ExecutionContext
                    f_1275_6861_6868()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 6861, 6868);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1275_6947_6954()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 6947, 6954);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1275_6947_6973(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.EngineSessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 6947, 6973);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateEntryVisibility
                    f_1275_6947_7002(System.Management.Automation.SessionStateInternal
                    this_param, string
                    scriptPath)
                    {
                        var return_v = this_param.CheckScriptVisibility(scriptPath);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 6947, 7002);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 6742, 7102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 6742, 7102);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 7034, 7091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 7040, 7089);

                    throw f_1275_7046_7088();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 7034, 7091);

                    System.Management.Automation.PSNotImplementedException
                    f_1275_7046_7088()
                    {
                        var return_v = PSTraceSource.NewNotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 7046, 7088);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 6742, 7102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 6742, 7102);
                }
            }
        }

        public ScriptBlock ScriptBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 7283, 8069);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 7319, 8014) || true) && (_scriptBlock == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 7319, 8014);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 7577, 7739) || true) && (!f_1275_7582_7641(_path, ".psd1", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 7577, 7739);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 7691, 7716);

                            f_1275_7691_7715(this, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 7577, 7739);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 7831, 7939);

                        ScriptBlock
                        newScriptBlock = f_1275_7860_7938(f_1275_7880_7892(), _path, f_1275_7901_7915(), f_1275_7917_7937())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 7961, 7995);

                        this.ScriptBlock = newScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 7319, 8014);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8034, 8054);

                    return _scriptBlock;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 7283, 8069);

                    bool
                    f_1275_7582_7641(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.EndsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 7582, 7641);
                        return return_v;
                    }


                    int
                    f_1275_7691_7715(System.Management.Automation.ExternalScriptInfo
                    this_param, System.Management.Automation.Host.PSHost
                    host)
                    {
                        this_param.ValidateScriptInfo(host);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 7691, 7715);
                        return 0;
                    }


                    System.Management.Automation.Language.Parser
                    f_1275_7880_7892()
                    {
                        var return_v = new System.Management.Automation.Language.Parser();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 7880, 7892);
                        return return_v;
                    }


                    string
                    f_1275_7901_7915()
                    {
                        var return_v = ScriptContents;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 7901, 7915);
                        return return_v;
                    }


                    System.Management.Automation.PSLanguageMode?
                    f_1275_7917_7937()
                    {
                        var return_v = DefiningLanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 7917, 7937);
                        return return_v;
                    }


                    System.Management.Automation.ScriptBlock
                    f_1275_7860_7938(System.Management.Automation.Language.Parser
                    parser, string
                    fileName, string
                    fileContents, System.Management.Automation.PSLanguageMode?
                    definingLanguageMode)
                    {
                        var return_v = ParseScriptContents(parser, fileName, fileContents, definingLanguageMode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 7860, 7938);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 7228, 8326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 7228, 8326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            private set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 8085, 8315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8129, 8150);

                    _scriptBlock = value;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8168, 8300) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 8168, 8300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8227, 8281);

                        _scriptBlock.LanguageMode = f_1275_8255_8280(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 8168, 8300);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 8085, 8315);

                    System.Management.Automation.PSLanguageMode?
                    f_1275_8255_8280(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        var return_v = this_param.DefiningLanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 8255, 8280);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 7228, 8326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 7228, 8326);
                }
            }
        }

        private ScriptBlock _scriptBlock;

        private ScriptBlockAst _scriptBlockAst;

        private static ScriptBlock ParseScriptContents(Parser parser, string fileName, string fileContents, PSLanguageMode? definingLanguageMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1275, 8432, 9699);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 8889, 9614) || true) && (f_1275_8893_8922(definingLanguageMode) && (DynAbs.Tracing.TraceSender.Expression_True(1275, 8893, 8979) && (definingLanguageMode == PSLanguageMode.FullLanguage)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 8889, 9614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 9013, 9070);

                    var
                    context = f_1275_9027_9069()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 9088, 9599) || true) && ((context != null) && (DynAbs.Tracing.TraceSender.Expression_True(1275, 9092, 9173) && (f_1275_9114_9134(context) == PSLanguageMode.ConstrainedLanguage)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 9088, 9599);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 9215, 9266);

                        context.LanguageMode = PSLanguageMode.FullLanguage;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 9340, 9398);

                            return f_1275_9347_9397(parser, fileName, fileContents);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1275, 9443, 9580);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 9499, 9557);

                            context.LanguageMode = PSLanguageMode.ConstrainedLanguage;
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1275, 9443, 9580);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 9088, 9599);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 8889, 9614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 9630, 9688);

                return f_1275_9637_9687(parser, fileName, fileContents);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1275, 8432, 9699);

                bool
                f_1275_8893_8922(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 8893, 8922);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1275_9027_9069()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 9027, 9069);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1275_9114_9134(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 9114, 9134);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1275_9347_9397(System.Management.Automation.Language.Parser
                parser, string
                fileName, string
                fileContents)
                {
                    var return_v = ScriptBlock.Create(parser, fileName, fileContents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 9347, 9397);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1275_9637_9687(System.Management.Automation.Language.Parser
                parser, string
                fileName, string
                fileContents)
                {
                    var return_v = ScriptBlock.Create(parser, fileName, fileContents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 9637, 9687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 8432, 9699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 8432, 9699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ScriptBlockAst GetScriptBlockAst()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 9711, 11786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 9779, 9815);

                var
                scriptContents = f_1275_9800_9814()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 9829, 9980) || true) && (_scriptBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 9829, 9980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 9887, 9965);

                    this.ScriptBlock = f_1275_9906_9964(_path, scriptContents);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 9829, 9980);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 9996, 10109) || true) && (_scriptBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 9996, 10109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 10054, 10094);

                    return (ScriptBlockAst)f_1275_10077_10093(_scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 9996, 10109);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 10125, 11736) || true) && (_scriptBlockAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 10125, 11736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 10186, 10206);

                    ParseError[]
                    errors
                    = default(ParseError[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 10224, 10253);

                    Parser
                    parser = f_1275_10240_10252()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 10589, 10646);

                    var
                    context = f_1275_10603_10645()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 10664, 11453) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1275, 10668, 10745) && f_1275_10687_10707(context) == PSLanguageMode.ConstrainedLanguage) && (DynAbs.Tracing.TraceSender.Expression_True(1275, 10668, 10821) && f_1275_10770_10790() == PSLanguageMode.FullLanguage))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 10664, 11453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 10863, 10914);

                        context.LanguageMode = PSLanguageMode.FullLanguage;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 10988, 11079);

                            _scriptBlockAst = f_1275_11006_11078(parser, _path, f_1275_11026_11040(), null, out errors, ParseMode.Default);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1275, 11124, 11261);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 11180, 11238);

                            context.LanguageMode = PSLanguageMode.ConstrainedLanguage;
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1275, 11124, 11261);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 10664, 11453);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 10664, 11453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 11343, 11434);

                        _scriptBlockAst = f_1275_11361_11433(parser, _path, f_1275_11381_11395(), null, out errors, ParseMode.Default);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 10664, 11453);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 11473, 11721) || true) && (f_1275_11477_11490(errors) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 11473, 11721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 11537, 11606);

                        this.ScriptBlock = f_1275_11556_11605(_scriptBlockAst, isFilter: false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 11628, 11702);

                        f_1275_11628_11701(f_1275_11657_11677(_scriptBlock), _path, scriptContents);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 11473, 11721);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 10125, 11736);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 11752, 11775);

                return _scriptBlockAst;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 9711, 11786);

                string
                f_1275_9800_9814()
                {
                    var return_v = ScriptContents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 9800, 9814);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1275_9906_9964(string
                fileName, string
                fileContents)
                {
                    var return_v = ScriptBlock.TryGetCachedScriptBlock(fileName, fileContents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 9906, 9964);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1275_10077_10093(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 10077, 10093);
                    return return_v;
                }


                System.Management.Automation.Language.Parser
                f_1275_10240_10252()
                {
                    var return_v = new System.Management.Automation.Language.Parser();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 10240, 10252);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1275_10603_10645()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 10603, 10645);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1275_10687_10707(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 10687, 10707);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1275_10770_10790()
                {
                    var return_v = DefiningLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 10770, 10790);
                    return return_v;
                }


                string
                f_1275_11026_11040()
                {
                    var return_v = ScriptContents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 11026, 11040);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1275_11006_11078(System.Management.Automation.Language.Parser
                this_param, string
                fileName, string
                input, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                tokenList, out System.Management.Automation.Language.ParseError[]
                errors, System.Management.Automation.Language.ParseMode
                parseMode)
                {
                    var return_v = this_param.Parse(fileName, input, tokenList, out errors, parseMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 11006, 11078);
                    return return_v;
                }


                string
                f_1275_11381_11395()
                {
                    var return_v = ScriptContents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 11381, 11395);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1275_11361_11433(System.Management.Automation.Language.Parser
                this_param, string
                fileName, string
                input, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                tokenList, out System.Management.Automation.Language.ParseError[]
                errors, System.Management.Automation.Language.ParseMode
                parseMode)
                {
                    var return_v = this_param.Parse(fileName, input, tokenList, out errors, parseMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 11361, 11433);
                    return return_v;
                }


                int
                f_1275_11477_11490(System.Management.Automation.Language.ParseError[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 11477, 11490);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1275_11556_11605(System.Management.Automation.Language.ScriptBlockAst
                ast, bool
                isFilter)
                {
                    var return_v = new System.Management.Automation.ScriptBlock((System.Management.Automation.Language.IParameterMetadataProvider)ast, isFilter: isFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 11556, 11605);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1275_11657_11677(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 11657, 11677);
                    return return_v;
                }


                int
                f_1275_11628_11701(System.Management.Automation.ScriptBlock
                scriptBlock, string
                fileName, string
                fileContents)
                {
                    ScriptBlock.CacheScriptBlock(scriptBlock, fileName, fileContents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 11628, 11701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 9711, 11786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 9711, 11786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void ValidateScriptInfo(Host.PSHost host)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 11935, 12915);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 12008, 12904) || true) && (!_signatureChecked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 12008, 12904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 12064, 12145);

                    ExecutionContext
                    context = f_1275_12091_12098() ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.ExecutionContext>(1275, 12091, 12144) ?? f_1275_12102_12144())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 12165, 12186);

                    f_1275_12165_12185(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 12690, 12889) || true) && (context != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 12690, 12889);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 12751, 12823);

                        f_1275_12751_12822(context, host, this, CommandOrigin.Internal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 12845, 12870);

                        _signatureChecked = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 12690, 12889);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 12008, 12904);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 11935, 12915);

                System.Management.Automation.ExecutionContext
                f_1275_12091_12098()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 12091, 12098);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1275_12102_12144()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 12102, 12144);
                    return return_v;
                }


                int
                f_1275_12165_12185(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    this_param.ReadScriptContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 12165, 12185);
                    return 0;
                }


                int
                f_1275_12751_12822(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Host.PSHost
                host, System.Management.Automation.ExternalScriptInfo
                commandInfo, System.Management.Automation.CommandOrigin
                commandOrigin)
                {
                    CommandDiscovery.ShouldRun(context, host, (System.Management.Automation.CommandInfo)commandInfo, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 12751, 12822);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 11935, 12915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 11935, 12915);
            }
        }

        public override ReadOnlyCollection<PSTypeName> OutputType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 13122, 13160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 13128, 13158);

                    return f_1275_13135_13157(f_1275_13135_13146());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 13122, 13160);

                    System.Management.Automation.ScriptBlock
                    f_1275_13135_13146()
                    {
                        var return_v = ScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 13135, 13146);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    f_1275_13135_13157(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.OutputType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 13135, 13157);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 13040, 13171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 13040, 13171);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool SignatureChecked
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 13238, 13272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 13244, 13270);

                    _signatureChecked = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 13238, 13272);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 13183, 13283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 13183, 13283);
                }
            }
        }

        private bool _signatureChecked;

        internal override CommandMetadata CommandMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 13537, 13778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 13573, 13763);

                    return _commandMetadata ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CommandMetadata>(1275, 13580, 13762) ?? (_commandMetadata =
                    f_1275_13669_13761(f_1275_13689_13705(this), f_1275_13707_13716(this), f_1275_13718_13760())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 13537, 13778);

                    System.Management.Automation.ScriptBlock
                    f_1275_13689_13705(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        var return_v = this_param.ScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 13689, 13705);
                        return return_v;
                    }


                    string
                    f_1275_13707_13716(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 13707, 13716);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1275_13718_13760()
                    {
                        var return_v = LocalPipeline.GetExecutionContextFromTLS();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 13718, 13760);
                        return return_v;
                    }


                    System.Management.Automation.CommandMetadata
                    f_1275_13669_13761(System.Management.Automation.ScriptBlock
                    scriptblock, string
                    commandName, System.Management.Automation.ExecutionContext
                    context)
                    {
                        var return_v = new System.Management.Automation.CommandMetadata(scriptblock, commandName, context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 13669, 13761);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 13463, 13789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 13463, 13789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CommandMetadata _commandMetadata;

        internal override bool ImplementsDynamicParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 14050, 14776);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 14130, 14170);

                        return f_1275_14137_14169(f_1275_14137_14148());
                    }
                    catch (ParseException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1275, 14207, 14233);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1275, 14207, 14233);
                    }
                    catch (ScriptRequiresException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1275, 14251, 14286);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1275, 14251, 14286);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 14667, 14687);

                    _scriptBlock = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 14705, 14728);

                    _scriptContents = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 14748, 14761);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 14050, 14776);

                    System.Management.Automation.ScriptBlock
                    f_1275_14137_14148()
                    {
                        var return_v = ScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 14137, 14148);
                        return return_v;
                    }


                    bool
                    f_1275_14137_14169(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.HasDynamicParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 14137, 14169);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 13975, 14787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 13975, 14787);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ScriptRequirements GetRequiresData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 14830, 14956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 14899, 14945);

                return f_1275_14906_14944(f_1275_14906_14925(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 14830, 14956);

                System.Management.Automation.Language.ScriptBlockAst
                f_1275_14906_14925(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.GetScriptBlockAst();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 14906, 14925);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptRequirements
                f_1275_14906_14944(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ScriptRequirements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 14906, 14944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 14830, 14956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 14830, 14956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string RequiresApplicationID
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 15030, 15184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 15066, 15095);

                    var
                    data = f_1275_15077_15094(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 15113, 15169);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1275, 15120, 15132) || ((data == null && DynAbs.Tracing.TraceSender.Conditional_F2(1275, 15135, 15139)) || DynAbs.Tracing.TraceSender.Conditional_F3(1275, 15142, 15168))) ? null : f_1275_15142_15168(data);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 15030, 15184);

                    System.Management.Automation.Language.ScriptRequirements
                    f_1275_15077_15094(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        var return_v = this_param.GetRequiresData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 15077, 15094);
                        return return_v;
                    }


                    string
                    f_1275_15142_15168(System.Management.Automation.Language.ScriptRequirements
                    this_param)
                    {
                        var return_v = this_param.RequiredApplicationId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 15142, 15168);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 14968, 15195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 14968, 15195);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal uint ApplicationIDLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 15269, 15286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 15275, 15284);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 15269, 15286);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 15207, 15297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 15207, 15297);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Version RequiresPSVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 15368, 15518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 15404, 15433);

                    var
                    data = f_1275_15415_15432(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 15451, 15503);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1275, 15458, 15470) || ((data == null && DynAbs.Tracing.TraceSender.Conditional_F2(1275, 15473, 15477)) || DynAbs.Tracing.TraceSender.Conditional_F3(1275, 15480, 15502))) ? null : f_1275_15480_15502(data);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 15368, 15518);

                    System.Management.Automation.Language.ScriptRequirements
                    f_1275_15415_15432(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        var return_v = this_param.GetRequiresData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 15415, 15432);
                        return return_v;
                    }


                    System.Version
                    f_1275_15480_15502(System.Management.Automation.Language.ScriptRequirements
                    this_param)
                    {
                        var return_v = this_param.RequiredPSVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 15480, 15502);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 15309, 15529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 15309, 15529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IEnumerable<string> RequiresPSEditions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 15613, 15764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 15649, 15678);

                    var
                    data = f_1275_15660_15677(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 15696, 15749);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1275, 15703, 15715) || ((data == null && DynAbs.Tracing.TraceSender.Conditional_F2(1275, 15718, 15722)) || DynAbs.Tracing.TraceSender.Conditional_F3(1275, 15725, 15748))) ? null : f_1275_15725_15748(data);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 15613, 15764);

                    System.Management.Automation.Language.ScriptRequirements
                    f_1275_15660_15677(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        var return_v = this_param.GetRequiresData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 15660, 15677);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<string>
                    f_1275_15725_15748(System.Management.Automation.Language.ScriptRequirements
                    this_param)
                    {
                        var return_v = this_param.RequiredPSEditions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 15725, 15748);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 15541, 15775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 15541, 15775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IEnumerable<ModuleSpecification> RequiresModules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 15869, 16017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 15905, 15934);

                    var
                    data = f_1275_15916_15933(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 15952, 16002);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1275, 15959, 15971) || ((data == null && DynAbs.Tracing.TraceSender.Conditional_F2(1275, 15974, 15978)) || DynAbs.Tracing.TraceSender.Conditional_F3(1275, 15981, 16001))) ? null : f_1275_15981_16001(data);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 15869, 16017);

                    System.Management.Automation.Language.ScriptRequirements
                    f_1275_15916_15933(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        var return_v = this_param.GetRequiresData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 15916, 15933);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                    f_1275_15981_16001(System.Management.Automation.Language.ScriptRequirements
                    this_param)
                    {
                        var return_v = this_param.RequiredModules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 15981, 16001);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 15787, 16028);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 15787, 16028);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool RequiresElevation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 16096, 16249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 16132, 16161);

                    var
                    data = f_1275_16143_16160(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 16179, 16234);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1275, 16186, 16198) || ((data == null && DynAbs.Tracing.TraceSender.Conditional_F2(1275, 16201, 16206)) || DynAbs.Tracing.TraceSender.Conditional_F3(1275, 16209, 16233))) ? false : f_1275_16209_16233(data);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 16096, 16249);

                    System.Management.Automation.Language.ScriptRequirements
                    f_1275_16143_16160(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        var return_v = this_param.GetRequiresData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 16143, 16160);
                        return return_v;
                    }


                    bool
                    f_1275_16209_16233(System.Management.Automation.Language.ScriptRequirements
                    this_param)
                    {
                        var return_v = this_param.IsElevationRequired;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 16209, 16233);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 16040, 16260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 16040, 16260);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal uint PSVersionLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 16330, 16347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 16336, 16345);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 16330, 16347);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 16272, 16358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 16272, 16358);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IEnumerable<PSSnapInSpecification> RequiresPSSnapIns
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 16456, 16606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 16492, 16521);

                    var
                    data = f_1275_16503_16520(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 16539, 16591);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1275, 16546, 16558) || ((data == null && DynAbs.Tracing.TraceSender.Conditional_F2(1275, 16561, 16565)) || DynAbs.Tracing.TraceSender.Conditional_F3(1275, 16568, 16590))) ? null : f_1275_16568_16590(data);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 16456, 16606);

                    System.Management.Automation.Language.ScriptRequirements
                    f_1275_16503_16520(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        var return_v = this_param.GetRequiresData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 16503, 16520);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSSnapInSpecification>
                    f_1275_16568_16590(System.Management.Automation.Language.ScriptRequirements
                    this_param)
                    {
                        var return_v = this_param.RequiresPSSnapIns;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 16568, 16590);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 16370, 16617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 16370, 16617);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string ScriptContents
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 16784, 16987);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 16820, 16929) || true) && (_scriptContents == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 16820, 16929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 16889, 16910);

                        f_1275_16889_16909(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 16820, 16929);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 16949, 16972);

                    return _scriptContents;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 16784, 16987);

                    int
                    f_1275_16889_16909(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        this_param.ReadScriptContents();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 16889, 16909);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 16731, 16998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 16731, 16998);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _scriptContents;

        public Encoding OriginalEncoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 17212, 17417);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 17248, 17357) || true) && (_scriptContents == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 17248, 17357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 17317, 17338);

                        f_1275_17317_17337(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 17248, 17357);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 17377, 17402);

                    return _originalEncoding;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 17212, 17417);

                    int
                    f_1275_17317_17337(System.Management.Automation.ExternalScriptInfo
                    this_param)
                    {
                        this_param.ReadScriptContents();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 17317, 17337);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 17155, 17428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 17155, 17428);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Encoding _originalEncoding;

        private void ReadScriptContents()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1275, 17487, 20722);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 17545, 20711) || true) && (_scriptContents == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 17545, 20711);
                    // make sure we can actually load the script and that it's non-empty
                    // before we call it.

                    // Note, although we are passing ASCII as the encoding, the StreamReader
                    // class still obeys the byte order marks at the beginning of the file
                    // if present. If not present, then ASCII is used as the default encoding.

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 18049, 19897);
                        using (FileStream
                        readerStream = f_1275_18082_18135(_path, FileMode.Open, FileAccess.Read)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 18185, 18243);

                            Encoding
                            defaultEncoding = f_1275_18212_18242()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 18269, 18357);

                            Microsoft.Win32.SafeHandles.SafeFileHandle
                            safeFileHandle = f_1275_18329_18356(readerStream)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 18385, 19874);
                            using (StreamReader
                            scriptReader = f_1275_18420_18467(readerStream, defaultEncoding)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 18525, 18568);

                                _scriptContents = f_1275_18543_18567(scriptReader);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 18598, 18647);

                                _originalEncoding = f_1275_18618_18646(scriptReader);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 18797, 19847) || true) && (f_1275_18801_18839() != SystemEnforcementMode.None)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 18797, 19847);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 18935, 19034);

                                    SystemEnforcementMode
                                    scriptSpecificPolicy = f_1275_18980_19033(_path, safeFileHandle)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 19068, 19499) || true) && (scriptSpecificPolicy != SystemEnforcementMode.Enforce)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 19068, 19499);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 19199, 19255);

                                        this.DefiningLanguageMode = PSLanguageMode.FullLanguage;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 19068, 19499);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 19068, 19499);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 19401, 19464);

                                        this.DefiningLanguageMode = PSLanguageMode.ConstrainedLanguage;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 19068, 19499);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 18797, 19847);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 18797, 19847);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 19629, 19816) || true) && (f_1275_19633_19645(this) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1275, 19629, 19816);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 19727, 19781);

                                        this.DefiningLanguageMode = f_1275_19755_19780(f_1275_19755_19767(this));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 19629, 19816);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 18797, 19847);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitUsing(1275, 18385, 19874);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1275, 18049, 19897);
                        }
                    }
                    catch (ArgumentException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1275, 19934, 20120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 20068, 20101);

                        f_1275_20068_20100(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1275, 19934, 20120);
                    }
                    catch (IOException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1275, 20138, 20252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 20200, 20233);

                        f_1275_20200_20232(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1275, 20138, 20252);
                    }
                    catch (NotSupportedException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1275, 20270, 20394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 20342, 20375);

                        f_1275_20342_20374(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1275, 20270, 20394);
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1275, 20412, 20696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 20644, 20677);

                        f_1275_20644_20676(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1275, 20412, 20696);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1275, 17545, 20711);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1275, 17487, 20722);

                System.IO.FileStream
                f_1275_18082_18135(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access)
                {
                    var return_v = new System.IO.FileStream(path, mode, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 18082, 18135);
                    return return_v;
                }


                System.Text.Encoding
                f_1275_18212_18242()
                {
                    var return_v = ClrFacade.GetDefaultEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 18212, 18242);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_1275_18329_18356(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.SafeFileHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 18329, 18356);
                    return return_v;
                }


                System.IO.StreamReader
                f_1275_18420_18467(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 18420, 18467);
                    return return_v;
                }


                string
                f_1275_18543_18567(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 18543, 18567);
                    return return_v;
                }


                System.Text.Encoding
                f_1275_18618_18646(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.CurrentEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 18618, 18646);
                    return return_v;
                }


                System.Management.Automation.Security.SystemEnforcementMode
                f_1275_18801_18839()
                {
                    var return_v = SystemPolicy.GetSystemLockdownPolicy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 18801, 18839);
                    return return_v;
                }


                System.Management.Automation.Security.SystemEnforcementMode
                f_1275_18980_19033(string
                path, Microsoft.Win32.SafeHandles.SafeFileHandle
                handle)
                {
                    var return_v = SystemPolicy.GetLockdownPolicy(path, (System.Runtime.InteropServices.SafeHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 18980, 19033);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1275_19633_19645(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 19633, 19645);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1275_19755_19767(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 19755, 19767);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1275_19755_19780(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 19755, 19780);
                    return return_v;
                }


                int
                f_1275_20068_20100(System.ArgumentException
                innerException)
                {
                    ThrowCommandNotFoundException((System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 20068, 20100);
                    return 0;
                }


                int
                f_1275_20200_20232(System.IO.IOException
                innerException)
                {
                    ThrowCommandNotFoundException((System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 20200, 20232);
                    return 0;
                }


                int
                f_1275_20342_20374(System.NotSupportedException
                innerException)
                {
                    ThrowCommandNotFoundException((System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 20342, 20374);
                    return 0;
                }


                int
                f_1275_20644_20676(System.UnauthorizedAccessException
                innerException)
                {
                    ThrowCommandNotFoundException((System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 20644, 20676);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 17487, 20722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 17487, 20722);
            }
        }

        private static void ThrowCommandNotFoundException(Exception innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1275, 20734, 20971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 20834, 20935);

                CommandNotFoundException
                cmdE = f_1275_20866_20934(f_1275_20895_20917(innerException), innerException)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 20949, 20960);

                throw cmdE;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1275, 20734, 20971);

                string
                f_1275_20895_20917(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1275, 20895, 20917);
                    return return_v;
                }


                System.Management.Automation.CommandNotFoundException
                f_1275_20866_20934(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Management.Automation.CommandNotFoundException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 20866, 20934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 20734, 20971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 20734, 20971);
            }
        }

        static ExternalScriptInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1275, 621, 20978);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1275, 621, 20978);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 621, 20978);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1275, 621, 20978);

        bool
        f_1275_1611_1637(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 1611, 1637);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1275_1677_1719(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 1677, 1719);
            return return_v;
        }


        bool
        f_1275_1770_1796(string
        path)
        {
            var return_v = IO.Path.IsPathRooted(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 1770, 1796);
            return return_v;
        }


        int
        f_1275_1751_1851(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 1751, 1851);
            return 0;
        }


        string
        f_1275_1995_2020(string
        path)
        {
            var return_v = IO.Path.GetFullPath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 1995, 2020);
            return return_v;
        }


        int
        f_1275_2035_2057(System.Management.Automation.ExternalScriptInfo
        this_param)
        {
            this_param.CommonInitialization();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 2035, 2057);
            return 0;
        }


        static string
        f_1275_1539_1543_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1275, 1439, 2069);
            return return_v;
        }


        bool
        f_1275_2766_2792(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 2766, 2792);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1275_2832_2874(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 2832, 2874);
            return return_v;
        }


        bool
        f_1275_2925_2951(string
        path)
        {
            var return_v = IO.Path.IsPathRooted(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 2925, 2951);
            return return_v;
        }


        int
        f_1275_2906_3006(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 2906, 3006);
            return 0;
        }


        string
        f_1275_3150_3175(string
        path)
        {
            var return_v = IO.Path.GetFullPath(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 3150, 3175);
            return return_v;
        }


        int
        f_1275_3190_3212(System.Management.Automation.ExternalScriptInfo
        this_param)
        {
            this_param.CommonInitialization();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 3190, 3212);
            return 0;
        }


        static string
        f_1275_2703_2707_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1275, 2642, 3224);
            return return_v;
        }


        int
        f_1275_3495_3517(System.Management.Automation.ExternalScriptInfo
        this_param)
        {
            this_param.CommonInitialization();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 3495, 3517);
            return 0;
        }


        static System.Management.Automation.CommandInfo
        f_1275_3430_3435_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1275, 3356, 3529);
            return return_v;
        }

    }
    internal class ScriptRequiresSyntaxException : ScriptRequiresException
    {
        internal ScriptRequiresSyntaxException(string message)
        : base(f_1275_21272_21279_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1275, 21197, 21302);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1275, 21197, 21302);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 21197, 21302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 21197, 21302);
            }
        }

        static ScriptRequiresSyntaxException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1275, 21110, 21309);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1275, 21110, 21309);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 21110, 21309);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1275, 21110, 21309);

        static string
        f_1275_21272_21279_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1275, 21197, 21302);
            return return_v;
        }

    }
    [Serializable]
    public class PSSnapInSpecification
    {
        internal PSSnapInSpecification(string psSnapinName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1275, 21486, 21696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 21792, 21833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 21932, 21977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 21562, 21622);

                f_1275_21562_21621(psSnapinName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 21636, 21656);

                Name = psSnapinName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1275, 21670, 21685);

                Version = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1275, 21486, 21696);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1275, 21486, 21696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 21486, 21696);
            }
        }

        public string Name { get; internal set; }

        public Version Version { get; internal set; }

        static PSSnapInSpecification()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1275, 21415, 21984);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1275, 21415, 21984);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1275, 21415, 21984);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1275, 21415, 21984);

        int
        f_1275_21562_21621(string
        psSnapinId)
        {
            PSSnapInInfo.VerifyPSSnapInFormatThrowIfError(psSnapinId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1275, 21562, 21621);
            return 0;
        }

    }
}

