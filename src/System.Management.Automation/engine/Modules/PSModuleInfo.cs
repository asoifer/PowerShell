// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Reflection;

using Microsoft.PowerShell.Commands;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    public sealed class PSModuleInfo
    {
        internal const string
        DynamicModulePrefixString = "__DynamicModule_"
        ;

        private static readonly ReadOnlyDictionary<string, TypeDefinitionAst> s_emptyTypeDefinitionDictionary;

        private ReadOnlyDictionary<string, TypeDefinitionAst> _exportedTypeDefinitionsNoNested { set; get; }

        private static readonly HashSet<string> s_scriptModuleExtensions;

        internal static void SetDefaultDynamicNameAndPath(PSModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1537, 1463, 1690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 1558, 1596);

                string
                gs = Guid.NewGuid().ToString()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 1610, 1627);

                module.Path = gs;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 1641, 1679);

                module.Name = "__DynamicModule_" + gs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1537, 1463, 1690);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 1463, 1690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 1463, 1690);
            }
        }

        internal PSModuleInfo(string path, ExecutionContext context, SessionState sessionState)
        : this(f_1537_2203_2207_C(null), path, context, sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1537, 2095, 2259);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1537, 2095, 2259);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 2095, 2259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 2095, 2259);
            }
        }

        internal PSModuleInfo(string name, string path, ExecutionContext context, SessionState sessionState, PSLanguageMode? languageMode)
        : this(f_1537_3011_3015_C(name), path, context, sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1537, 2860, 3109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 3070, 3098);

                LanguageMode = languageMode;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1537, 2860, 3109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 2860, 3109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 2860, 3109);
            }
        }

        internal PSModuleInfo(string name, string path, ExecutionContext context, SessionState sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1537, 3622, 4454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 1125, 1225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8386, 8512);
                this.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8663, 8720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8732, 8783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8901, 8945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9352, 9414);
                this.LogPipelineExecutionDetails = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9511, 9567);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9956, 10013);
                this.Path = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10253, 10312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10697, 10714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10996, 11023);
                this._description = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 11438, 11574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 11586, 11645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 12523, 12534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13091, 13110);
                this._privateData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15125, 15264);
                this.ExperimentalFeatures = f_1537_15211_15263();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15487, 15513);
                this._tags = f_1537_15495_15513();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15711, 15755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15851, 15892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15991, 16035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16136, 16185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16299, 16357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16457, 16522);
                this.Version = f_1537_16504_16521(0, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16951, 17022);
                this.ModuleType = ModuleType.Script;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17307, 17381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17885, 17925);
                this._accessMode = ModuleAccessMode.ReadWrite;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18011, 18103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18189, 18281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18364, 18454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18550, 18654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18694, 18724);
                this.DeclaredFunctionExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18763, 18791);
                this.DeclaredCmdletExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18830, 18857);
                this.DeclaredAliasExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18896, 18926);
                this.DeclaredVariableExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18961, 19005);
                this.DetectedFunctionExports = f_1537_18987_19005();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19038, 19080);
                this.DetectedCmdletExports = f_1537_19062_19080();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19127, 19182);
                this.DetectedAliasExports = f_1537_19150_19182();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 25667, 25754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 31706, 31747);
                this._compiledExports = f_1537_31725_31747();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 32532, 32611);
                this.CompiledAliasExports = f_1537_32589_32610();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 32822, 32852);
                this._fileList = f_1537_32834_32852();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 33484, 33526);
                this._compatiblePSEditions = f_1537_33508_33526();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 34484, 34549);
                this.IsConsideredEditionCompatible = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 34772, 34810);
                this._moduleList = f_1537_34786_34810();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35432, 35454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35823, 35864);
                this._nestedModules = f_1537_35840_35864();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35959, 36058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36155, 36258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36350, 36449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36545, 36662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36881, 36910);
                this._scripts = f_1537_36892_36910();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 37256, 37302);
                this._requiredAssemblies = f_1537_37278_37302();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 37961, 37985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 38358, 38401);
                this._requiredModules = f_1537_38377_38401();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 39036, 39073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 39526, 39589);
                this._requiredModulesSpecification = f_1537_39558_39589();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 39675, 39766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 40029, 40124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 46024, 46058);
                this._declaredDscResourceExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 46187, 46233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53365, 53406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53528, 53657);
                this.ExportedFormatFiles = f_1537_53606_53656(f_1537_53637_53655());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53924, 54051);
                this.ExportedTypeFiles = f_1537_54000_54050(f_1537_54031_54049());
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 3747, 4105) || true) && (path != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 3747, 4105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 3797, 3867);

                    string
                    resolvedPath = f_1537_3819_3866(path, context)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 4062, 4090);

                    Path = resolvedPath ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1537, 4069, 4089) ?? path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 3747, 4105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 4121, 4149);

                SessionState = sessionState;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 4163, 4272) || true) && (sessionState != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 4163, 4272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 4221, 4257);

                    f_1537_4221_4242(sessionState).Module = this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 4163, 4272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 4391, 4443);

                Name = name ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1537, 4398, 4442) ?? f_1537_4406_4442(f_1537_4437_4441()));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1537, 3622, 4454);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 3622, 4454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 3622, 4454);
            }
        }

        public PSModuleInfo(bool linkToGlobal)
        : this(f_1537_4637_4679_C(f_1537_4637_4679()), linkToGlobal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1537, 4578, 4716);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1537, 4578, 4716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 4578, 4716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 4578, 4716);
            }
        }

        internal PSModuleInfo(ExecutionContext context, bool linkToGlobal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1537, 4840, 5656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 1125, 1225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8386, 8512);
                this.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8663, 8720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8732, 8783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8901, 8945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9352, 9414);
                this.LogPipelineExecutionDetails = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9511, 9567);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9956, 10013);
                this.Path = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10253, 10312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10697, 10714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10996, 11023);
                this._description = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 11438, 11574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 11586, 11645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 12523, 12534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13091, 13110);
                this._privateData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15125, 15264);
                this.ExperimentalFeatures = f_1537_15211_15263();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15487, 15513);
                this._tags = f_1537_15495_15513();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15711, 15755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15851, 15892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15991, 16035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16136, 16185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16299, 16357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16457, 16522);
                this.Version = f_1537_16504_16521(0, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16951, 17022);
                this.ModuleType = ModuleType.Script;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17307, 17381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17885, 17925);
                this._accessMode = ModuleAccessMode.ReadWrite;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18011, 18103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18189, 18281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18364, 18454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18550, 18654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18694, 18724);
                this.DeclaredFunctionExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18763, 18791);
                this.DeclaredCmdletExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18830, 18857);
                this.DeclaredAliasExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18896, 18926);
                this.DeclaredVariableExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18961, 19005);
                this.DetectedFunctionExports = f_1537_18987_19005();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19038, 19080);
                this.DetectedCmdletExports = f_1537_19062_19080();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19127, 19182);
                this.DetectedAliasExports = f_1537_19150_19182();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 25667, 25754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 31706, 31747);
                this._compiledExports = f_1537_31725_31747();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 32532, 32611);
                this.CompiledAliasExports = f_1537_32589_32610();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 32822, 32852);
                this._fileList = f_1537_32834_32852();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 33484, 33526);
                this._compatiblePSEditions = f_1537_33508_33526();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 34484, 34549);
                this.IsConsideredEditionCompatible = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 34772, 34810);
                this._moduleList = f_1537_34786_34810();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35432, 35454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35823, 35864);
                this._nestedModules = f_1537_35840_35864();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35959, 36058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36155, 36258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36350, 36449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36545, 36662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36881, 36910);
                this._scripts = f_1537_36892_36910();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 37256, 37302);
                this._requiredAssemblies = f_1537_37278_37302();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 37961, 37985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 38358, 38401);
                this._requiredModules = f_1537_38377_38401();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 39036, 39073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 39526, 39589);
                this._requiredModulesSpecification = f_1537_39558_39589();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 39675, 39766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 40029, 40124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 46024, 46058);
                this._declaredDscResourceExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 46187, 46233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53365, 53406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53528, 53657);
                this.ExportedFormatFiles = f_1537_53606_53656(f_1537_53637_53655());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53924, 54051);
                this.ExportedTypeFiles = f_1537_54000_54050(f_1537_54031_54049());
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 4931, 5021) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 4931, 5021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 4969, 5021);

                    throw f_1537_4975_5020("PSModuleInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 4931, 5021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 5037, 5072);

                f_1537_5037_5071(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 5534, 5595);

                SessionState = f_1537_5549_5594(context, true, linkToGlobal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 5609, 5645);

                f_1537_5609_5630(f_1537_5609_5621()).Module = this;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1537, 4840, 5656);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 4840, 5656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 4840, 5656);
            }
        }

        public PSModuleInfo(ScriptBlock scriptBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1537, 5919, 8260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 1125, 1225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8386, 8512);
                this.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8663, 8720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8732, 8783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8901, 8945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9352, 9414);
                this.LogPipelineExecutionDetails = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9511, 9567);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9956, 10013);
                this.Path = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10253, 10312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10697, 10714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10996, 11023);
                this._description = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 11438, 11574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 11586, 11645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 12523, 12534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13091, 13110);
                this._privateData = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15125, 15264);
                this.ExperimentalFeatures = f_1537_15211_15263();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15487, 15513);
                this._tags = f_1537_15495_15513();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15711, 15755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15851, 15892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15991, 16035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16136, 16185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16299, 16357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16457, 16522);
                this.Version = f_1537_16504_16521(0, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16951, 17022);
                this.ModuleType = ModuleType.Script;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17307, 17381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17885, 17925);
                this._accessMode = ModuleAccessMode.ReadWrite;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18011, 18103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18189, 18281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18364, 18454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18550, 18654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18694, 18724);
                this.DeclaredFunctionExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18763, 18791);
                this.DeclaredCmdletExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18830, 18857);
                this.DeclaredAliasExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18896, 18926);
                this.DeclaredVariableExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 18961, 19005);
                this.DetectedFunctionExports = f_1537_18987_19005();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19038, 19080);
                this.DetectedCmdletExports = f_1537_19062_19080();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19127, 19182);
                this.DetectedAliasExports = f_1537_19150_19182();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 25667, 25754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 31706, 31747);
                this._compiledExports = f_1537_31725_31747();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 32532, 32611);
                this.CompiledAliasExports = f_1537_32589_32610();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 32822, 32852);
                this._fileList = f_1537_32834_32852();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 33484, 33526);
                this._compatiblePSEditions = f_1537_33508_33526();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 34484, 34549);
                this.IsConsideredEditionCompatible = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 34772, 34810);
                this._moduleList = f_1537_34786_34810();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35432, 35454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35823, 35864);
                this._nestedModules = f_1537_35840_35864();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35959, 36058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36155, 36258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36350, 36449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36545, 36662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36881, 36910);
                this._scripts = f_1537_36892_36910();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 37256, 37302);
                this._requiredAssemblies = f_1537_37278_37302();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 37961, 37985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 38358, 38401);
                this._requiredModules = f_1537_38377_38401();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 39036, 39073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 39526, 39589);
                this._requiredModulesSpecification = f_1537_39558_39589();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 39675, 39766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 40029, 40124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 46024, 46058);
                this._declaredDscResourceExports = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 46187, 46233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53365, 53406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53528, 53657);
                this.ExportedFormatFiles = f_1537_53606_53656(f_1537_53637_53655());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53924, 54051);
                this.ExportedTypeFiles = f_1537_54000_54050(f_1537_54031_54049());
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 5988, 6116) || true) && (scriptBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 5988, 6116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 6045, 6101);

                    throw f_1537_6051_6100("scriptBlock");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 5988, 6116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 6190, 6247);

                var
                context = f_1537_6204_6246()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 6263, 6353) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 6263, 6353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 6301, 6353);

                    throw f_1537_6307_6352("PSModuleInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 6263, 6353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 6369, 6404);

                f_1537_6369_6403(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 6866, 6919);

                SessionState = f_1537_6881_6918(context, true, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 6933, 6969);

                f_1537_6933_6954(f_1537_6933_6945()).Module = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 6985, 7025);

                LanguageMode = f_1537_7000_7024(scriptBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 7127, 7193);

                SessionStateInternal
                oldSessionState = f_1537_7166_7192(context)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 7243, 7294);

                    context.EngineSessionState = f_1537_7272_7293(f_1537_7272_7284());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 7367, 7431);

                    f_1537_7367_7430(
                                    // Set the PSScriptRoot variable...
                                    context, SpecialVariables.PSScriptRootVarPath, f_1537_7425_7429());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 7451, 7485);

                    scriptBlock = f_1537_7465_7484(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 7503, 7543);

                    scriptBlock.SessionState = f_1537_7530_7542();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 7563, 7610);

                    Pipe
                    outputPipe = new Pipe { NullPipe = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1537, 7581, 7609) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 7675, 8120);

                    f_1537_7675_8119(                // And run the scriptblock...
                                    scriptBlock, useLocalScope: false, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1537_7883_7903(), input: f_1537_7933_7953(), scriptThis: f_1537_7988_8008(), outputPipe: outputPipe, invocationInfo: null);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1537, 8149, 8249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 8189, 8234);

                    context.EngineSessionState = oldSessionState;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1537, 8149, 8249);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1537, 5919, 8260);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 5919, 8260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 5919, 8260);
            }
        }

        internal PSLanguageMode? LanguageMode
        {
            get;
            set;
        }

        internal bool ModuleAutoExportsAllFunctions { get; set; }

        internal bool ModuleHasPrivateMembers { get; set; }

        internal bool HadErrorsLoading { get; set; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 9137, 9223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9195, 9212);

                return f_1537_9202_9211(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 9137, 9223);

                string
                f_1537_9202_9211(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 9202, 9211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 9137, 9223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 9137, 9223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool LogPipelineExecutionDetails { get; set; }

        public string Name { get; private set; }

        internal void SetName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 9753, 9835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 9812, 9824);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 9753, 9835);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 9753, 9835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 9753, 9835);
            }
        }

        public string Path { get; internal set; }

        public Assembly ImplementingAssembly { get; internal set; }

        public string Definition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 10570, 10651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10576, 10649);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1537, 10583, 10608) || ((_definitionExtent == null && DynAbs.Tracing.TraceSender.Conditional_F2(1537, 10611, 10623)) || DynAbs.Tracing.TraceSender.Conditional_F3(1537, 10626, 10648))) ? string.Empty : f_1537_10626_10648(_definitionExtent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 10570, 10651);

                    string
                    f_1537_10626_10648(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.Text;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 10626, 10648);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 10521, 10662);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 10521, 10662);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IScriptExtent _definitionExtent;

        public string Description
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 10869, 10897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10875, 10895);

                    return _description;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 10869, 10897);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 10819, 10969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 10819, 10969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 10913, 10958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 10919, 10956);

                    _description = value ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1537, 10934, 10955) ?? string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 10913, 10958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 10819, 10969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 10819, 10969);
                }
            }
        }

        private string _description;

        public Guid Guid { get; private set; }

        internal void SetGuid(Guid guid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 11214, 11294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 11271, 11283);

                Guid = guid;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 11214, 11294);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 11214, 11294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 11214, 11294);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public string HelpInfoUri { get; private set; }

        internal bool IsWindowsPowerShellCompatModule { get; set; }

        internal void SetHelpInfoUri(string uri)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 11657, 11751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 11722, 11740);

                HelpInfoUri = uri;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 11657, 11751);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 11657, 11751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 11657, 11751);
            }
        }

        public string ModuleBase
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 12177, 12366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 12213, 12351);

                    return _moduleBase ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1537, 12220, 12350) ?? (_moduleBase = (DynAbs.Tracing.TraceSender.Conditional_F1(1537, 12274, 12301) || ((!f_1537_12275_12301(f_1537_12296_12300()) && DynAbs.Tracing.TraceSender.Conditional_F2(1537, 12304, 12334)) || DynAbs.Tracing.TraceSender.Conditional_F3(1537, 12337, 12349))) ? f_1537_12304_12334(f_1537_12329_12333()) : string.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 12177, 12366);

                    string
                    f_1537_12296_12300()
                    {
                        var return_v = Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 12296, 12300);
                        return return_v;
                    }


                    bool
                    f_1537_12275_12301(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 12275, 12301);
                        return return_v;
                    }


                    string
                    f_1537_12329_12333()
                    {
                        var return_v = Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 12329, 12333);
                        return return_v;
                    }


                    string?
                    f_1537_12304_12334(string
                    path)
                    {
                        var return_v = IO.Path.GetDirectoryName(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 12304, 12334);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 12128, 12377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 12128, 12377);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SetModuleBase(string moduleBase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 12389, 12496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 12460, 12485);

                _moduleBase = moduleBase;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 12389, 12496);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 12389, 12496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 12389, 12496);
            }
        }

        private string _moduleBase;

        public object PrivateData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 12839, 12910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 12875, 12895);

                    return _privateData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 12839, 12910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 12789, 13064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 12789, 13064);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 12926, 13053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 12962, 12983);

                    _privateData = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13001, 13038);

                    f_1537_13001_13037(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 12926, 13053);

                    int
                    f_1537_13001_13037(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        this_param.SetPSDataPropertiesFromPrivateData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 13001, 13037);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 12789, 13064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 12789, 13064);
                }
            }
        }

        private object _privateData;

        private void SetPSDataPropertiesFromPrivateData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 13123, 14539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13256, 13270);

                f_1537_13256_13269(            // Reset the old values of PSData properties.
                            _tags);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13284, 13304);

                ReleaseNotes = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13318, 13336);

                LicenseUri = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13350, 13368);

                ProjectUri = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13382, 13397);

                IconUri = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13413, 14528) || true) && (_privateData is Hashtable hashData && (DynAbs.Tracing.TraceSender.Expression_True(1537, 13417, 13493) && f_1537_13455_13473(hashData, "PSData") is Hashtable psData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 13413, 14528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13527, 13558);

                    var
                    tagsValue = f_1537_13543_13557(psData, "Tags")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13576, 13953) || true) && (tagsValue is object[] tags && (DynAbs.Tracing.TraceSender.Expression_True(1537, 13580, 13625) && f_1537_13610_13621(tags) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 13576, 13953);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13667, 13808);
                            foreach (var tagString in f_1537_13693_13714_I(f_1537_13693_13714(tags)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 13667, 13808);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13764, 13785);

                                f_1537_13764_13784(this, tagString);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 13667, 13808);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 142);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 142);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 13576, 13953);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 13576, 13953);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13850, 13953) || true) && (tagsValue is string tag)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 13850, 13953);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13919, 13934);

                            f_1537_13919_13933(this, tag);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 13850, 13953);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 13576, 13953);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 13973, 14121) || true) && (f_1537_13977_13997(psData, "LicenseUri") is string licenseUri)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 13973, 14121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 14060, 14102);

                        LicenseUri = f_1537_14073_14101(licenseUri);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 13973, 14121);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 14141, 14289) || true) && (f_1537_14145_14165(psData, "ProjectUri") is string projectUri)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 14141, 14289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 14228, 14270);

                        ProjectUri = f_1537_14241_14269(projectUri);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 14141, 14289);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 14309, 14445) || true) && (f_1537_14313_14330(psData, "IconUri") is string iconUri)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 14309, 14445);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 14390, 14426);

                        IconUri = f_1537_14400_14425(iconUri);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 14309, 14445);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 14465, 14513);

                    ReleaseNotes = f_1537_14480_14502(psData, "ReleaseNotes") as string;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 13413, 14528);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 13123, 14539);

                int
                f_1537_13256_13269(System.Collections.Generic.List<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 13256, 13269);
                    return 0;
                }


                object
                f_1537_13455_13473(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 13455, 13473);
                    return return_v;
                }


                object
                f_1537_13543_13557(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 13543, 13557);
                    return return_v;
                }


                int
                f_1537_13610_13621(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 13610, 13621);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1537_13693_13714(object[]
                source)
                {
                    var return_v = source.OfType<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 13693, 13714);
                    return return_v;
                }


                int
                f_1537_13764_13784(System.Management.Automation.PSModuleInfo
                this_param, string
                tag)
                {
                    this_param.AddToTags(tag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 13764, 13784);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1537_13693_13714_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 13693, 13714);
                    return return_v;
                }


                int
                f_1537_13919_13933(System.Management.Automation.PSModuleInfo
                this_param, string
                tag)
                {
                    this_param.AddToTags(tag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 13919, 13933);
                    return 0;
                }


                object
                f_1537_13977_13997(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 13977, 13997);
                    return return_v;
                }


                System.Uri
                f_1537_14073_14101(string
                uriString)
                {
                    var return_v = GetUriFromString(uriString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 14073, 14101);
                    return return_v;
                }


                object
                f_1537_14145_14165(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 14145, 14165);
                    return return_v;
                }


                System.Uri
                f_1537_14241_14269(string
                uriString)
                {
                    var return_v = GetUriFromString(uriString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 14241, 14269);
                    return return_v;
                }


                object
                f_1537_14313_14330(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 14313, 14330);
                    return return_v;
                }


                System.Uri
                f_1537_14400_14425(string
                uriString)
                {
                    var return_v = GetUriFromString(uriString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 14400, 14425);
                    return return_v;
                }


                object
                f_1537_14480_14502(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 14480, 14502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 13123, 14539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 13123, 14539);
            }
        }

        private static Uri GetUriFromString(string uriString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1537, 14551, 14998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 14629, 14644);

                Uri
                uri = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 14658, 14960) || true) && (uriString != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 14658, 14960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 14893, 14945);

                    f_1537_14893_14944(uriString, UriKind.Absolute, out uri);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 14658, 14960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 14976, 14987);

                return uri;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1537, 14551, 14998);

                bool
                f_1537_14893_14944(string
                uriString, System.UriKind
                uriKind, out System.Uri
                result)
                {
                    var return_v = Uri.TryCreate(uriString, uriKind, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 14893, 14944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 14551, 14998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 14551, 14998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<ExperimentalFeature> ExperimentalFeatures { get; internal set; }

        public IEnumerable<string> Tags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 15413, 15434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15419, 15432);

                    return _tags;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 15413, 15434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 15357, 15445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 15357, 15445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly List<string> _tags;

        internal void AddToTags(string tag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 15526, 15612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 15586, 15601);

                f_1537_15586_15600(_tags, tag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 15526, 15612);

                int
                f_1537_15586_15600(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 15586, 15600);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 15526, 15612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 15526, 15612);
            }
        }

        public Uri ProjectUri { get; internal set; }

        public Uri IconUri { get; internal set; }

        public Uri LicenseUri { get; internal set; }

        public string ReleaseNotes { get; internal set; }

        public Uri RepositorySourceLocation { get; internal set; }

        public Version Version { get; private set; }

        internal void SetVersion(Version version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 16684, 16779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 16750, 16768);

                Version = version;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 16684, 16779);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 16684, 16779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 16684, 16779);
            }
        }

        public ModuleType ModuleType { get; private set; }

        internal void SetModuleType(ModuleType moduleType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 17141, 17220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17194, 17218);

                ModuleType = moduleType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 17141, 17220);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 17141, 17220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 17141, 17220);
            }
        }

        public string Author
        {
            get; internal set;
        }

        public ModuleAccessMode AccessMode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 17547, 17574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17553, 17572);

                    return _accessMode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 17547, 17574);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 17488, 17848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 17488, 17848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 17590, 17837);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17626, 17782) || true) && (_accessMode == ModuleAccessMode.Constant)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 17626, 17782);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17712, 17763);

                        throw f_1537_17718_17762();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 17626, 17782);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 17802, 17822);

                    _accessMode = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 17590, 17837);

                    System.Management.Automation.PSInvalidOperationException
                    f_1537_17718_17762()
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 17718, 17762);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 17488, 17848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 17488, 17848);
                }
            }
        }

        private ModuleAccessMode _accessMode;

        public Version ClrVersion
        {
            get;
            internal set;
        }

        public string CompanyName
        {
            get;
            internal set;
        }

        public string Copyright
        {
            get;
            internal set;
        }

        public Version DotNetFrameworkVersion
        {
            get;
            internal set;
        }

        internal Collection<string> DeclaredFunctionExports;

        internal Collection<string> DeclaredCmdletExports;

        internal Collection<string> DeclaredAliasExports;

        internal Collection<string> DeclaredVariableExports;

        internal List<string> DetectedFunctionExports;

        internal List<string> DetectedCmdletExports;

        internal Dictionary<string, string> DetectedAliasExports;

        public Dictionary<string, FunctionInfo> ExportedFunctions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 19384, 21391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19420, 19534);

                    Dictionary<string, FunctionInfo>
                    exports = f_1537_19463_19533(f_1537_19500_19532())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19633, 21341) || true) && (DeclaredFunctionExports != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 19633, 21341);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19710, 19769) || true) && (f_1537_19714_19743(DeclaredFunctionExports) == 0)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 19710, 19769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19752, 19767);

                            return exports;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 19710, 19769);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19793, 20067);
                            foreach (string fn in f_1537_19815_19838_I(DeclaredFunctionExports))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 19793, 20067);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 19888, 19991);

                                FunctionInfo
                                tempFunction = new FunctionInfo(fn, ScriptBlock.EmptyScriptBlock, null) { Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => this, 1537, 19916, 19990) }
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 20017, 20044);

                                exports[fn] = tempFunction;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 19793, 20067);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 275);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 275);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 19633, 21341);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 19633, 21341);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 20109, 21341) || true) && (f_1537_20113_20125() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 20109, 21341);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 20324, 20804) || true) && (f_1537_20328_20367(f_1537_20328_20349(f_1537_20328_20340())) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 20324, 20804);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 20425, 20781);
                                    foreach (FunctionInfo fi in f_1537_20453_20492_I(f_1537_20453_20492(f_1537_20453_20474(f_1537_20453_20465()))))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 20425, 20781);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 20550, 20754) || true) && (!f_1537_20555_20583(exports, f_1537_20575_20582(fi)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 20550, 20754);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 20649, 20723);

                                            exports[f_1537_20657_20716(f_1537_20697_20704(fi), f_1537_20706_20715(fi))] = fi;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 20550, 20754);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 20425, 20781);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 357);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 357);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 20324, 20804);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 20109, 21341);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 20109, 21341);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 20886, 21322);
                                foreach (var detectedExport in f_1537_20917_20940_I(DetectedFunctionExports))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 20886, 21322);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 20990, 21299) || true) && (!f_1537_20995_21030(exports, detectedExport))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 20990, 21299);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 21088, 21203);

                                        FunctionInfo
                                        tempFunction = new FunctionInfo(detectedExport, ScriptBlock.EmptyScriptBlock, null) { Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => this, 1537, 21116, 21202) }
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 21233, 21272);

                                        exports[detectedExport] = tempFunction;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 20990, 21299);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 20886, 21322);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 437);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 437);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 20109, 21341);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 19633, 21341);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 21361, 21376);

                    return exports;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 19384, 21391);

                    System.StringComparer
                    f_1537_19500_19532()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 19500, 19532);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                    f_1537_19463_19533(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 19463, 19533);
                        return return_v;
                    }


                    int
                    f_1537_19714_19743(System.Collections.ObjectModel.Collection<string>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 19714, 19743);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<string>
                    f_1537_19815_19838_I(System.Collections.ObjectModel.Collection<string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 19815, 19838);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_20113_20125()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 20113, 20125);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_20328_20340()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 20328, 20340);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1537_20328_20349(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 20328, 20349);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                    f_1537_20328_20367(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExportedFunctions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 20328, 20367);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_20453_20465()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 20453, 20465);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1537_20453_20474(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 20453, 20474);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                    f_1537_20453_20492(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExportedFunctions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 20453, 20492);
                        return return_v;
                    }


                    string
                    f_1537_20575_20582(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 20575, 20582);
                        return return_v;
                    }


                    bool
                    f_1537_20555_20583(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                    this_param, string
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 20555, 20583);
                        return return_v;
                    }


                    string
                    f_1537_20697_20704(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 20697, 20704);
                        return return_v;
                    }


                    string
                    f_1537_20706_20715(System.Management.Automation.FunctionInfo
                    this_param)
                    {
                        var return_v = this_param.Prefix;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 20706, 20715);
                        return return_v;
                    }


                    string
                    f_1537_20657_20716(string
                    commandName, string
                    prefix)
                    {
                        var return_v = ModuleCmdletBase.AddPrefixToCommandName(commandName, prefix);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 20657, 20716);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                    f_1537_20453_20492_I(System.Collections.Generic.List<System.Management.Automation.FunctionInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 20453, 20492);
                        return return_v;
                    }


                    bool
                    f_1537_20995_21030(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                    this_param, string
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 20995, 21030);
                        return return_v;
                    }


                    System.Collections.Generic.List<string>
                    f_1537_20917_20940_I(System.Collections.Generic.List<string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 20917, 20940);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 19302, 21402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 19302, 21402);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsScriptModuleFile(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 21414, 21613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 21483, 21527);

                var
                ext = f_1537_21493_21526(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 21541, 21602);

                return ext != null && (DynAbs.Tracing.TraceSender.Expression_True(1537, 21548, 21601) && f_1537_21563_21601(s_scriptModuleExtensions, ext));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 21414, 21613);

                string?
                f_1537_21493_21526(string
                path)
                {
                    var return_v = System.IO.Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 21493, 21526);
                    return return_v;
                }


                bool
                f_1537_21563_21601(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 21563, 21601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 21414, 21613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 21414, 21613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ReadOnlyDictionary<string, TypeDefinitionAst> GetExportedTypeDefinitions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 21831, 24420);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 22197, 23010) || true) && (f_1537_22201_22233() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 22197, 23010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 22275, 22300);

                    string
                    rootedPath = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 22318, 22663) || true) && (f_1537_22322_22332() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 22318, 22663);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 22382, 22499) || true) && (f_1537_22386_22395(this) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 22382, 22499);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 22453, 22476);

                            rootedPath = f_1537_22466_22475(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 22382, 22499);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 22318, 22663);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 22318, 22663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 22581, 22644);

                        rootedPath = f_1537_22594_22643(f_1537_22610_22625(this), f_1537_22627_22642(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 22318, 22663);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 22782, 22995);

                    f_1537_22782_22994(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1537, 22812, 22894) || ((rootedPath != null && (DynAbs.Tracing.TraceSender.Expression_True(1537, 22812, 22864) && f_1537_22834_22864(this, rootedPath)) && (DynAbs.Tracing.TraceSender.Expression_True(1537, 22812, 22894) && f_1537_22868_22894(rootedPath)) && DynAbs.Tracing.TraceSender.Conditional_F2(1537, 22918, 22986)) || DynAbs.Tracing.TraceSender.Conditional_F3(1537, 22989, 22993))) ? f_1537_22918_22986((f_1537_22919_22965(rootedPath, rootedPath))) : null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 22197, 23010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 23026, 23112);

                var
                res = f_1537_23036_23111(f_1537_23078_23110())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 23126, 24171);
                    foreach (var nestedModule in f_1537_23155_23173_I(f_1537_23155_23173(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 23126, 24171);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 23207, 23778) || true) && (nestedModule == this)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 23207, 23778);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 23750, 23759);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 23207, 23778);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 23798, 24156);
                            foreach (var typePairs in f_1537_23824_23865_I(f_1537_23824_23865(nestedModule)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 23798, 24156);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 24100, 24137);

                                res[typePairs.Key] = typePairs.Value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 23798, 24156);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 359);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 359);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 23126, 24171);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 1046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 1046);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 24187, 24331);
                    foreach (var typePairs in f_1537_24213_24245_I(f_1537_24213_24245()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 24187, 24331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 24279, 24316);

                        res[typePairs.Key] = typePairs.Value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 24187, 24331);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 24347, 24409);

                return f_1537_24354_24408(res);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 21831, 24420);

                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_22201_22233()
                {
                    var return_v = _exportedTypeDefinitionsNoNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 22201, 22233);
                    return return_v;
                }


                string
                f_1537_22322_22332()
                {
                    var return_v = RootModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 22322, 22332);
                    return return_v;
                }


                string
                f_1537_22386_22395(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 22386, 22395);
                    return return_v;
                }


                string
                f_1537_22466_22475(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 22466, 22475);
                    return return_v;
                }


                string
                f_1537_22610_22625(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 22610, 22625);
                    return return_v;
                }


                string
                f_1537_22627_22642(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RootModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 22627, 22642);
                    return return_v;
                }


                string
                f_1537_22594_22643(string
                path1, string
                path2)
                {
                    var return_v = IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 22594, 22643);
                    return return_v;
                }


                bool
                f_1537_22834_22864(System.Management.Automation.PSModuleInfo
                this_param, string
                path)
                {
                    var return_v = this_param.IsScriptModuleFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 22834, 22864);
                    return return_v;
                }


                bool
                f_1537_22868_22894(string
                path)
                {
                    var return_v = IO.File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 22868, 22894);
                    return return_v;
                }


                System.Management.Automation.ExternalScriptInfo
                f_1537_22919_22965(string
                name, string
                path)
                {
                    var return_v = new System.Management.Automation.ExternalScriptInfo(name, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 22919, 22965);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1537_22918_22986(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.GetScriptBlockAst();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 22918, 22986);
                    return return_v;
                }


                int
                f_1537_22782_22994(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.Language.ScriptBlockAst
                moduleContentScriptBlockAsts)
                {
                    this_param.CreateExportedTypeDefinitions(moduleContentScriptBlockAsts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 22782, 22994);
                    return 0;
                }


                System.StringComparer
                f_1537_23078_23110()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 23078, 23110);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_23036_23111(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 23036, 23111);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1537_23155_23173(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 23155, 23173);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_23824_23865(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.GetExportedTypeDefinitions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 23824, 23865);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_23824_23865_I(System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 23824, 23865);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1537_23155_23173_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 23155, 23173);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_24213_24245()
                {
                    var return_v = _exportedTypeDefinitionsNoNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 24213, 24245);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_24213_24245_I(System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 24213, 24245);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_24354_24408(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                dictionary)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>((System.Collections.Generic.IDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>)dictionary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 24354, 24408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 21831, 24420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 21831, 24420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CreateExportedTypeDefinitions(ScriptBlockAst moduleContentScriptBlockAsts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 24598, 25277);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 24711, 25266) || true) && (moduleContentScriptBlockAsts == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 24711, 25266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 24785, 24857);

                    this._exportedTypeDefinitionsNoNested = s_emptyTypeDefinitionDictionary;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 24711, 25266);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 24711, 25266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 24923, 25251);

                    this._exportedTypeDefinitionsNoNested = f_1537_24963_25250(f_1537_25035_25249(f_1537_25035_25163(f_1537_25035_25109(moduleContentScriptBlockAsts, a => (a is TypeDefinitionAst), false)), a => a.Name, f_1537_25216_25248()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 24711, 25266);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 24598, 25277);

                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                f_1537_25035_25109(System.Management.Automation.Language.ScriptBlockAst
                this_param, System.Func<System.Management.Automation.Language.Ast, bool>
                predicate, bool
                searchNestedScriptBlocks)
                {
                    var return_v = this_param.FindAll(predicate, searchNestedScriptBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 25035, 25109);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_25035_25163(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Language.TypeDefinitionAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 25035, 25163);
                    return return_v;
                }


                System.StringComparer
                f_1537_25216_25248()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 25216, 25248);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_25035_25249(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeDefinitionAst>
                source, System.Func<System.Management.Automation.Language.TypeDefinitionAst, string>
                keySelector, System.StringComparer
                comparer)
                {
                    var return_v = source.ToDictionary<System.Management.Automation.Language.TypeDefinitionAst, string>(keySelector, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 25035, 25249);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_24963_25250(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                dictionary)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>((System.Collections.Generic.IDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>)dictionary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 24963, 25250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 24598, 25277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 24598, 25277);
            }
        }

        internal void AddDetectedTypeExports(List<TypeDefinitionAst> typeDefinitions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 25289, 25587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 25391, 25576);

                this._exportedTypeDefinitionsNoNested = f_1537_25431_25575(f_1537_25499_25574(typeDefinitions, a => a.Name, f_1537_25541_25573()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 25289, 25587);

                System.StringComparer
                f_1537_25541_25573()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 25541, 25573);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_25499_25574(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                source, System.Func<System.Management.Automation.Language.TypeDefinitionAst, string>
                keySelector, System.StringComparer
                comparer)
                {
                    var return_v = source.ToDictionary<System.Management.Automation.Language.TypeDefinitionAst, string>(keySelector, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 25499, 25574);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                f_1537_25431_25575(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
                dictionary)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>((System.Collections.Generic.IDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>)dictionary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 25431, 25575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 25289, 25587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 25289, 25587);
            }
        }

        public string Prefix
        {
            get;
            internal set;
        }

        internal void AddDetectedFunctionExport(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 25927, 26250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 26004, 26097);

                f_1537_26004_26096(name != null, "AddDetectedFunctionExport should not be called with a null value");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 26113, 26239) || true) && (!f_1537_26118_26156(DetectedFunctionExports, name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 26113, 26239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 26190, 26224);

                    f_1537_26190_26223(DetectedFunctionExports, name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 26113, 26239);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 25927, 26250);

                int
                f_1537_26004_26096(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 26004, 26096);
                    return 0;
                }


                bool
                f_1537_26118_26156(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 26118, 26156);
                    return return_v;
                }


                int
                f_1537_26190_26223(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 26190, 26223);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 25927, 26250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 25927, 26250);
            }
        }

        public Dictionary<string, CmdletInfo> ExportedCmdlets
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 26447, 27881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 26483, 26593);

                    Dictionary<string, CmdletInfo>
                    exports = f_1537_26524_26592(f_1537_26559_26591())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 26613, 27831) || true) && (DeclaredCmdletExports != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 26613, 27831);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 26688, 26745) || true) && (f_1537_26692_26719(DeclaredCmdletExports) == 0)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 26688, 26745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 26728, 26743);

                            return exports;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 26688, 26745);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 26769, 27021);
                            foreach (string fn in f_1537_26791_26812_I(DeclaredCmdletExports))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 26769, 27021);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 26862, 26947);

                                CmdletInfo
                                tempCmdlet = new CmdletInfo(fn, null, null, null, null) { Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => this, 1537, 26886, 26946) }
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 26973, 26998);

                                exports[fn] = tempCmdlet;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 26769, 27021);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 253);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 253);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 26613, 27831);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 26613, 27831);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 27063, 27831) || true) && ((f_1537_27068_27083() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1537, 27067, 27123) && (f_1537_27097_27118(f_1537_27097_27112()) > 0)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 27063, 27831);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 27165, 27313);
                                foreach (CmdletInfo cmdlet in f_1537_27195_27210_I(f_1537_27195_27210()))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 27165, 27313);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 27260, 27290);

                                    exports[f_1537_27268_27279(cmdlet)] = cmdlet;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 27165, 27313);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 149);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 149);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 27063, 27831);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 27063, 27831);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 27395, 27812);
                                foreach (string detectedExport in f_1537_27429_27450_I(DetectedCmdletExports))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 27395, 27812);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 27500, 27789) || true) && (!f_1537_27505_27540(exports, detectedExport))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 27500, 27789);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 27598, 27695);

                                        CmdletInfo
                                        tempCmdlet = new CmdletInfo(detectedExport, null, null, null, null) { Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => this, 1537, 27622, 27694) }
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 27725, 27762);

                                        exports[detectedExport] = tempCmdlet;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 27500, 27789);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 27395, 27812);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 418);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 418);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 27063, 27831);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 26613, 27831);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 27851, 27866);

                    return exports;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 26447, 27881);

                    System.StringComparer
                    f_1537_26559_26591()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 26559, 26591);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.CmdletInfo>
                    f_1537_26524_26592(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.CmdletInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 26524, 26592);
                        return return_v;
                    }


                    int
                    f_1537_26692_26719(System.Collections.ObjectModel.Collection<string>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 26692, 26719);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<string>
                    f_1537_26791_26812_I(System.Collections.ObjectModel.Collection<string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 26791, 26812);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    f_1537_27068_27083()
                    {
                        var return_v = CompiledExports;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 27068, 27083);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    f_1537_27097_27112()
                    {
                        var return_v = CompiledExports;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 27097, 27112);
                        return return_v;
                    }


                    int
                    f_1537_27097_27118(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 27097, 27118);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    f_1537_27195_27210()
                    {
                        var return_v = CompiledExports;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 27195, 27210);
                        return return_v;
                    }


                    string
                    f_1537_27268_27279(System.Management.Automation.CmdletInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 27268, 27279);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    f_1537_27195_27210_I(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 27195, 27210);
                        return return_v;
                    }


                    bool
                    f_1537_27505_27540(System.Collections.Generic.Dictionary<string, System.Management.Automation.CmdletInfo>
                    this_param, string
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 27505, 27540);
                        return return_v;
                    }


                    System.Collections.Generic.List<string>
                    f_1537_27429_27450_I(System.Collections.Generic.List<string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 27429, 27450);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 26369, 27892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 26369, 27892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void AddDetectedCmdletExport(string cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 28071, 28394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 28148, 28241);

                f_1537_28148_28240(cmdlet != null, "AddDetectedCmdletExport should not be called with a null value");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 28257, 28383) || true) && (!f_1537_28262_28300(DetectedCmdletExports, cmdlet))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 28257, 28383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 28334, 28368);

                    f_1537_28334_28367(DetectedCmdletExports, cmdlet);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 28257, 28383);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 28071, 28394);

                int
                f_1537_28148_28240(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 28148, 28240);
                    return 0;
                }


                bool
                f_1537_28262_28300(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 28262, 28300);
                    return return_v;
                }


                int
                f_1537_28334_28367(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 28334, 28367);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 28071, 28394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 28071, 28394);
            }
        }

        public Dictionary<string, CommandInfo> ExportedCommands
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 28889, 30051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 28925, 29037);

                    Dictionary<string, CommandInfo>
                    exports = f_1537_28967_29036(f_1537_29003_29035())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29055, 29117);

                    Dictionary<string, CmdletInfo>
                    cmdlets = f_1537_29096_29116(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29135, 29353) || true) && (cmdlets != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 29135, 29353);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29196, 29334);
                            foreach (var cmdlet in f_1537_29219_29226_I(cmdlets))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 29196, 29334);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29276, 29311);

                                exports[cmdlet.Key] = cmdlet.Value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 29196, 29334);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 139);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 139);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 29135, 29353);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29373, 29441);

                    Dictionary<string, FunctionInfo>
                    functions = f_1537_29418_29440(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29459, 29687) || true) && (functions != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 29459, 29687);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29522, 29668);
                            foreach (var function in f_1537_29547_29556_I(functions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 29522, 29668);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29606, 29645);

                                exports[function.Key] = function.Value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 29522, 29668);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 147);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 147);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 29459, 29687);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29707, 29768);

                    Dictionary<string, AliasInfo>
                    aliases = f_1537_29747_29767(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29786, 30001) || true) && (aliases != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 29786, 30001);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29847, 29982);
                            foreach (var alias in f_1537_29869_29876_I(aliases))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 29847, 29982);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 29926, 29959);

                                exports[alias.Key] = alias.Value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 29847, 29982);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 136);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 136);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 29786, 30001);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 30021, 30036);

                    return exports;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 28889, 30051);

                    System.StringComparer
                    f_1537_29003_29035()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 29003, 29035);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                    f_1537_28967_29036(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 28967, 29036);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.CmdletInfo>
                    f_1537_29096_29116(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.ExportedCmdlets;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 29096, 29116);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.CmdletInfo>
                    f_1537_29219_29226_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.CmdletInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 29219, 29226);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                    f_1537_29418_29440(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.ExportedFunctions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 29418, 29440);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                    f_1537_29547_29556_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 29547, 29556);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                    f_1537_29747_29767(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.ExportedAliases;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 29747, 29767);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                    f_1537_29869_29876_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 29869, 29876);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 28809, 30062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 28809, 30062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void AddExportedCmdlet(CmdletInfo cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 30241, 30457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 30316, 30403);

                f_1537_30316_30402(cmdlet != null, "AddExportedCmdlet should not be called with a null value");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 30417, 30446);

                f_1537_30417_30445(_compiledExports, cmdlet);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 30241, 30457);

                int
                f_1537_30316_30402(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 30316, 30402);
                    return 0;
                }


                int
                f_1537_30417_30445(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                this_param, System.Management.Automation.CmdletInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 30417, 30445);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 30241, 30457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 30241, 30457);
            }
        }

        internal List<CmdletInfo> CompiledExports
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 30900, 31649);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 31153, 31590) || true) && (f_1537_31157_31169() != null && (DynAbs.Tracing.TraceSender.Expression_True(1537, 31157, 31226) && f_1537_31181_31218(f_1537_31181_31202(f_1537_31181_31193())) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1537, 31157, 31298) && f_1537_31251_31294(f_1537_31251_31288(f_1537_31251_31272(f_1537_31251_31263()))) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 31153, 31590);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 31340, 31501);
                            foreach (CmdletInfo ci in f_1537_31366_31403_I(f_1537_31366_31403(f_1537_31366_31387(f_1537_31366_31378()))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 31340, 31501);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 31453, 31478);

                                f_1537_31453_31477(_compiledExports, ci);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 31340, 31501);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 162);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 162);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 31525, 31571);

                        f_1537_31525_31570(f_1537_31525_31562(f_1537_31525_31546(f_1537_31525_31537())));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 31153, 31590);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 31610, 31634);

                    return _compiledExports;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 30900, 31649);

                    System.Management.Automation.SessionState
                    f_1537_31157_31169()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31157, 31169);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_31181_31193()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31181, 31193);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1537_31181_31202(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31181, 31202);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    f_1537_31181_31218(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExportedCmdlets;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31181, 31218);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_31251_31263()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31251, 31263);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1537_31251_31272(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31251, 31272);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    f_1537_31251_31288(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExportedCmdlets;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31251, 31288);
                        return return_v;
                    }


                    int
                    f_1537_31251_31294(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31251, 31294);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_31366_31378()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31366, 31378);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1537_31366_31387(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31366, 31387);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    f_1537_31366_31403(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExportedCmdlets;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31366, 31403);
                        return return_v;
                    }


                    int
                    f_1537_31453_31477(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    this_param, System.Management.Automation.CmdletInfo
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 31453, 31477);
                        return 0;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    f_1537_31366_31403_I(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 31366, 31403);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_31525_31537()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31525, 31537);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1537_31525_31546(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31525, 31546);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    f_1537_31525_31562(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExportedCmdlets;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 31525, 31562);
                        return return_v;
                    }


                    int
                    f_1537_31525_31570(System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 31525, 31570);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 30834, 31660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 30834, 31660);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly List<CmdletInfo> _compiledExports;

        internal void AddExportedAlias(AliasInfo aliasInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 31929, 32155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 32005, 32094);

                f_1537_32005_32093(aliasInfo != null, "AddExportedAlias should not be called with a null value");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 32108, 32144);

                f_1537_32108_32143(f_1537_32108_32128(), aliasInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 31929, 32155);

                int
                f_1537_32005_32093(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 32005, 32093);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                f_1537_32108_32128()
                {
                    var return_v = CompiledAliasExports;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 32108, 32128);
                    return return_v;
                }


                int
                f_1537_32108_32143(System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                this_param, System.Management.Automation.AliasInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 32108, 32143);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 31929, 32155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 31929, 32155);
            }
        }

        internal List<AliasInfo> CompiledAliasExports { get; }

        public IEnumerable<string> FileList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 32753, 32778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 32759, 32776);

                    return _fileList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 32753, 32778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 32693, 32789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 32693, 32789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private List<string> _fileList;

        internal void AddToFileList(string file)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 32865, 32961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 32930, 32950);

                f_1537_32930_32949(_fileList, file);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 32865, 32961);

                int
                f_1537_32930_32949(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 32930, 32949);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 32865, 32961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 32865, 32961);
            }
        }

        public IEnumerable<string> CompatiblePSEditions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 33403, 33440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 33409, 33438);

                    return _compatiblePSEditions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 33403, 33440);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 33331, 33451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 33331, 33451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private List<string> _compatiblePSEditions;

        internal void AddToCompatiblePSEditions(string psEdition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 33539, 33669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 33621, 33658);

                f_1537_33621_33657(_compatiblePSEditions, psEdition);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 33539, 33669);

                int
                f_1537_33621_33657(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 33621, 33657);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 33539, 33669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 33539, 33669);
            }
        }

        internal void AddToCompatiblePSEditions(IEnumerable<string> psEditions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 33681, 33831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 33777, 33820);

                f_1537_33777_33819(_compatiblePSEditions, psEditions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 33681, 33831);

                int
                f_1537_33777_33819(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 33777, 33819);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 33681, 33831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 33681, 33831);
            }
        }

        internal bool IsConsideredEditionCompatible { get; set; }

        public IEnumerable<object> ModuleList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 34695, 34722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 34701, 34720);

                    return _moduleList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 34695, 34722);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 34633, 34733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 34633, 34733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Collection<object> _moduleList;

        internal void AddToModuleList(object m)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 34823, 34917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 34887, 34906);

                f_1537_34887_34905(_moduleList, m);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 34823, 34917);

                int
                f_1537_34887_34905(System.Collections.ObjectModel.Collection<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 34887, 34905);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 34823, 34917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 34823, 34917);
            }
        }

        public ReadOnlyCollection<PSModuleInfo> NestedModules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 35180, 35368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35216, 35353);

                    return _readonlyNestedModules ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>>(1537, 35223, 35352) ?? (_readonlyNestedModules = f_1537_35299_35351(_nestedModules)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 35180, 35368);

                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                    f_1537_35299_35351(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                    list)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>((System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>)list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 35299, 35351);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 35102, 35379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 35102, 35379);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReadOnlyCollection<PSModuleInfo> _readonlyNestedModules;

        internal void AddNestedModule(PSModuleInfo nestedModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 35637, 35775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 35718, 35764);

                f_1537_35718_35763(nestedModule, _nestedModules);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 35637, 35775);

                int
                f_1537_35718_35763(System.Management.Automation.PSModuleInfo
                module, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                moduleList)
                {
                    AddModuleToList(module, moduleList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 35718, 35763);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 35637, 35775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 35637, 35775);
            }
        }

        private readonly List<PSModuleInfo> _nestedModules;

        public string PowerShellHostName
        {
            get;
            internal set;
        }

        public Version PowerShellHostVersion
        {
            get;
            internal set;
        }

        public Version PowerShellVersion
        {
            get;
            internal set;
        }

        public ProcessorArchitecture ProcessorArchitecture
        {
            get;
            internal set;
        }

        public IEnumerable<string> Scripts
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 36813, 36837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36819, 36835);

                    return _scripts;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 36813, 36837);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 36754, 36848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 36754, 36848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private List<string> _scripts;

        internal void AddScript(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 36923, 37008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 36981, 36997);

                f_1537_36981_36996(_scripts, s);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 36923, 37008);

                int
                f_1537_36981_36996(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 36981, 36996);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 36923, 37008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 36923, 37008);
            }
        }

        public IEnumerable<string> RequiredAssemblies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 37171, 37206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 37177, 37204);

                    return _requiredAssemblies;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 37171, 37206);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 37101, 37217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 37101, 37217);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Collection<string> _requiredAssemblies;

        internal void AddRequiredAssembly(string assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 37315, 37435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 37390, 37424);

                f_1537_37390_37423(_requiredAssemblies, assembly);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 37315, 37435);

                int
                f_1537_37390_37423(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 37390, 37423);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 37315, 37435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 37315, 37435);
            }
        }

        public ReadOnlyCollection<PSModuleInfo> RequiredModules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 37703, 37897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 37739, 37882);

                    return _readonlyRequiredModules ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>>(1537, 37746, 37881) ?? (_readonlyRequiredModules = f_1537_37826_37880(_requiredModules)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 37703, 37897);

                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                    f_1537_37826_37880(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                    list)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>((System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>)list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 37826, 37880);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 37623, 37908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 37623, 37908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReadOnlyCollection<PSModuleInfo> _readonlyRequiredModules;

        internal void AddRequiredModule(PSModuleInfo requiredModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 38173, 38319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 38258, 38308);

                f_1537_38258_38307(requiredModule, _requiredModules);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 38173, 38319);

                int
                f_1537_38258_38307(System.Management.Automation.PSModuleInfo
                module, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                moduleList)
                {
                    AddModuleToList(module, moduleList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 38258, 38307);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 38173, 38319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 38173, 38319);
            }
        }

        private List<PSModuleInfo> _requiredModules;

        internal ReadOnlyCollection<ModuleSpecification> RequiredModulesSpecification
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 38725, 38965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 38761, 38950);

                    return _readonlyRequiredModulesSpecification ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>>(1537, 38768, 38949) ?? (_readonlyRequiredModulesSpecification = f_1537_38874_38948(_requiredModulesSpecification)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 38725, 38965);

                    System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                    f_1537_38874_38948(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                    list)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>((System.Collections.Generic.IList<Microsoft.PowerShell.Commands.ModuleSpecification>)list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 38874, 38948);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 38623, 38976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 38623, 38976);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReadOnlyCollection<ModuleSpecification> _readonlyRequiredModulesSpecification;

        internal void AddRequiredModuleSpecification(ModuleSpecification requiredModuleSpecification)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 39288, 39480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 39406, 39469);

                f_1537_39406_39468(_requiredModulesSpecification, requiredModuleSpecification);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 39288, 39480);

                int
                f_1537_39406_39468(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                this_param, Microsoft.PowerShell.Commands.ModuleSpecification
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 39406, 39468);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 39288, 39480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 39288, 39480);
            }
        }

        private List<ModuleSpecification> _requiredModulesSpecification;

        public string RootModule
        {
            get;
            internal set;
        }

        internal string RootModuleForManifest
        {
            get;
            set;
        }

        private static void AddModuleToList(PSModuleInfo module, List<PSModuleInfo> moduleList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1537, 40261, 40764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 40373, 40458);

                f_1537_40373_40457(module != null, "AddModuleToList should not be called with a null value");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 40532, 40714);
                    foreach (PSModuleInfo m in f_1537_40559_40569_I(moduleList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 40532, 40714);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 40603, 40699) || true) && (f_1537_40607_40669(f_1537_40607_40613(m), f_1537_40621_40632(module), StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 40603, 40699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 40692, 40699);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 40603, 40699);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 40532, 40714);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 183);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 40730, 40753);

                f_1537_40730_40752(
                            moduleList, module);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1537, 40261, 40764);

                int
                f_1537_40373_40457(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 40373, 40457);
                    return 0;
                }


                string
                f_1537_40607_40613(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 40607, 40613);
                    return return_v;
                }


                string
                f_1537_40621_40632(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 40621, 40632);
                    return return_v;
                }


                bool
                f_1537_40607_40669(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 40607, 40669);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1537_40559_40569_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 40559, 40569);
                    return return_v;
                }


                int
                f_1537_40730_40752(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 40730, 40752);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 40261, 40764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 40261, 40764);
            }
        }

        internal static string[] _builtinVariables;

        public Dictionary<string, PSVariable> ExportedVariables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 41222, 42413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 41258, 41378);

                    Dictionary<string, PSVariable>
                    exportedVariables = f_1537_41309_41377(f_1537_41344_41376())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 41398, 42353) || true) && ((DeclaredVariableExports != null) && (DynAbs.Tracing.TraceSender.Expression_True(1537, 41402, 41474) && (f_1537_41440_41469(DeclaredVariableExports) > 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 41398, 42353);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 41516, 41663);
                            foreach (string fn in f_1537_41538_41561_I(DeclaredVariableExports))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 41516, 41663);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 41611, 41640);

                                exportedVariables[fn] = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 41516, 41663);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 148);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 148);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 41398, 42353);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 41398, 42353);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 41970, 42143) || true) && (f_1537_41974_41986() == null || (DynAbs.Tracing.TraceSender.Expression_False(1537, 41974, 42045) || f_1537_41998_42037(f_1537_41998_42019(f_1537_41998_42010())) == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 41970, 42143);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 42095, 42120);

                            return exportedVariables;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 41970, 42143);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 42167, 42334);
                            foreach (PSVariable v in f_1537_42192_42231_I(f_1537_42192_42231(f_1537_42192_42213(f_1537_42192_42204()))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 42167, 42334);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 42281, 42311);

                                exportedVariables[f_1537_42299_42305(v)] = v;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 42167, 42334);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 168);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 168);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 41398, 42353);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 42373, 42398);

                    return exportedVariables;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 41222, 42413);

                    System.StringComparer
                    f_1537_41344_41376()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 41344, 41376);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                    f_1537_41309_41377(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 41309, 41377);
                        return return_v;
                    }


                    int
                    f_1537_41440_41469(System.Collections.ObjectModel.Collection<string>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 41440, 41469);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<string>
                    f_1537_41538_41561_I(System.Collections.ObjectModel.Collection<string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 41538, 41561);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_41974_41986()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 41974, 41986);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_41998_42010()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 41998, 42010);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1537_41998_42019(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 41998, 42019);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.PSVariable>
                    f_1537_41998_42037(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExportedVariables;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 41998, 42037);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_42192_42204()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 42192, 42204);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1537_42192_42213(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 42192, 42213);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.PSVariable>
                    f_1537_42192_42231(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExportedVariables;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 42192, 42231);
                        return return_v;
                    }


                    string
                    f_1537_42299_42305(System.Management.Automation.PSVariable
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 42299, 42305);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.PSVariable>
                    f_1537_42192_42231_I(System.Collections.Generic.List<System.Management.Automation.PSVariable>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 42192, 42231);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 41142, 42424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 41142, 42424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Dictionary<string, AliasInfo> ExportedAliases
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 42616, 45107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 42652, 42768);

                    Dictionary<string, AliasInfo>
                    exportedAliases = f_1537_42700_42767(f_1537_42734_42766())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 42788, 45049) || true) && ((DeclaredAliasExports != null) && (DynAbs.Tracing.TraceSender.Expression_True(1537, 42792, 42858) && (f_1537_42827_42853(DeclaredAliasExports) > 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 42788, 45049);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 42900, 43143);
                            foreach (string fn in f_1537_42922_42942_I(DeclaredAliasExports))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 42900, 43143);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 42992, 43062);

                                AliasInfo
                                tempAlias = new AliasInfo(fn, null, null) { Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => this, 1537, 43014, 43061) }
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 43088, 43120);

                                exportedAliases[fn] = tempAlias;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 42900, 43143);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 244);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 244);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 42788, 45049);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 42788, 45049);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 43185, 45049) || true) && ((f_1537_43190_43210() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1537, 43189, 43255) && (f_1537_43224_43250(f_1537_43224_43244()) > 0)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 43185, 45049);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 43297, 43445);
                                foreach (AliasInfo ai in f_1537_43322_43342_I(f_1537_43322_43342()))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 43297, 43445);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 43392, 43422);

                                    exportedAliases[f_1537_43408_43415(ai)] = ai;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 43297, 43445);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 149);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 149);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 43185, 45049);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 43185, 45049);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 43611, 45030) || true) && (f_1537_43615_43627() == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 43611, 45030);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 43738, 44680) || true) && (f_1537_43742_43768(DetectedAliasExports) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 43738, 44680);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 43830, 44362);
                                        foreach (var pair in f_1537_43851_43871_I(DetectedAliasExports))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 43830, 44362);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 43937, 43970);

                                            string
                                            detectedExport = pair.Key
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 44004, 44331) || true) && (!f_1537_44009_44052(exportedAliases, detectedExport))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 44004, 44331);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 44126, 44214);

                                                AliasInfo
                                                tempAlias = new AliasInfo(detectedExport, pair.Value, null) { Module = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => this, 1537, 44148, 44213) }
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 44252, 44296);

                                                exportedAliases[detectedExport] = tempAlias;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 44004, 44331);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 43830, 44362);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 533);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 533);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 43738, 44680);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 43738, 44680);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 44630, 44653);

                                    return exportedAliases;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 43738, 44680);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 43611, 45030);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 43611, 45030);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 44830, 45007);
                                    foreach (AliasInfo ai in f_1537_44855_44892_I(f_1537_44855_44892(f_1537_44855_44876(f_1537_44855_44867()))))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 44830, 45007);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 44950, 44980);

                                        exportedAliases[f_1537_44966_44973(ai)] = ai;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 44830, 45007);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 178);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 178);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 43611, 45030);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 43185, 45049);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 42788, 45049);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 45069, 45092);

                    return exportedAliases;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 42616, 45107);

                    System.StringComparer
                    f_1537_42734_42766()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 42734, 42766);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                    f_1537_42700_42767(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 42700, 42767);
                        return return_v;
                    }


                    int
                    f_1537_42827_42853(System.Collections.ObjectModel.Collection<string>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 42827, 42853);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<string>
                    f_1537_42922_42942_I(System.Collections.ObjectModel.Collection<string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 42922, 42942);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                    f_1537_43190_43210()
                    {
                        var return_v = CompiledAliasExports;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 43190, 43210);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                    f_1537_43224_43244()
                    {
                        var return_v = CompiledAliasExports;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 43224, 43244);
                        return return_v;
                    }


                    int
                    f_1537_43224_43250(System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 43224, 43250);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                    f_1537_43322_43342()
                    {
                        var return_v = CompiledAliasExports;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 43322, 43342);
                        return return_v;
                    }


                    string
                    f_1537_43408_43415(System.Management.Automation.AliasInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 43408, 43415);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                    f_1537_43322_43342_I(System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 43322, 43342);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_43615_43627()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 43615, 43627);
                        return return_v;
                    }


                    int
                    f_1537_43742_43768(System.Collections.Generic.Dictionary<string, string>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 43742, 43768);
                        return return_v;
                    }


                    bool
                    f_1537_44009_44052(System.Collections.Generic.Dictionary<string, System.Management.Automation.AliasInfo>
                    this_param, string
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 44009, 44052);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, string>
                    f_1537_43851_43871_I(System.Collections.Generic.Dictionary<string, string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 43851, 43871);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1537_44855_44867()
                    {
                        var return_v = SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 44855, 44867);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateInternal
                    f_1537_44855_44876(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Internal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 44855, 44876);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                    f_1537_44855_44892(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExportedAliases;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 44855, 44892);
                        return return_v;
                    }


                    string
                    f_1537_44966_44973(System.Management.Automation.AliasInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 44966, 44973);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                    f_1537_44855_44892_I(System.Collections.Generic.List<System.Management.Automation.AliasInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 44855, 44892);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 42539, 45118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 42539, 45118);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void AddDetectedAliasExport(string name, string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 45355, 45595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 45443, 45533);

                f_1537_45443_45532(name != null, "AddDetectedAliasExport should not be called with a null value");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 45549, 45584);

                DetectedAliasExports[name] = value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 45355, 45595);

                int
                f_1537_45443_45532(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 45443, 45532);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 45355, 45595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 45355, 45595);
            }
        }

        public ReadOnlyCollection<string> ExportedDscResources
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 45733, 45973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 45769, 45958);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1537, 45776, 45811) || ((_declaredDscResourceExports != null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1537, 45835, 45894)) || DynAbs.Tracing.TraceSender.Conditional_F3(1537, 45918, 45957))) ? f_1537_45835_45894(_declaredDscResourceExports) : f_1537_45918_45957();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 45733, 45973);

                    System.Collections.ObjectModel.ReadOnlyCollection<string>
                    f_1537_45835_45894(System.Collections.ObjectModel.Collection<string>
                    list)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>((System.Collections.Generic.IList<string>)list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 45835, 45894);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<string>
                    f_1537_45918_45957()
                    {
                        var return_v = Utils.EmptyReadOnlyCollection<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 45918, 45957);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 45654, 45984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 45654, 45984);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Collection<string> _declaredDscResourceExports;

        public SessionState SessionState { get; set; }

        public ScriptBlock NewBoundScriptBlock(ScriptBlock scriptBlockToBind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 46500, 46731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 46594, 46651);

                var
                context = f_1537_46608_46650()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 46665, 46720);

                return f_1537_46672_46719(this, scriptBlockToBind, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 46500, 46731);

                System.Management.Automation.ExecutionContext
                f_1537_46608_46650()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 46608, 46650);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1537_46672_46719(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.ScriptBlock
                scriptBlockToBind, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.NewBoundScriptBlock(scriptBlockToBind, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 46672, 46719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 46500, 46731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 46500, 46731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ScriptBlock NewBoundScriptBlock(ScriptBlock scriptBlockToBind, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 46743, 47745);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 46865, 47046) || true) && (f_1537_46869_46881() == null || (DynAbs.Tracing.TraceSender.Expression_False(1537, 46869, 46908) || context == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 46865, 47046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 46942, 47031);

                    throw f_1537_46948_47030(f_1537_46991_47029());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 46865, 47046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 47062, 47080);

                ScriptBlock
                newsb
                = default(ScriptBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 47188, 47214);

                // Now set up the module's session state to be the current session state
                lock (f_1537_47188_47214(context))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 47248, 47314);

                    SessionStateInternal
                    oldSessionState = f_1537_47287_47313(context)
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 47378, 47429);

                        context.EngineSessionState = f_1537_47407_47428(f_1537_47407_47419());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 47451, 47485);

                        newsb = f_1537_47459_47484(scriptBlockToBind);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 47507, 47541);

                        newsb.SessionState = f_1537_47528_47540();
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1537, 47578, 47690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 47626, 47671);

                        context.EngineSessionState = oldSessionState;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1537, 47578, 47690);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 47721, 47734);

                return newsb;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 46743, 47745);

                System.Management.Automation.SessionState
                f_1537_46869_46881()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 46869, 46881);
                    return return_v;
                }


                string
                f_1537_46991_47029()
                {
                    var return_v = Modules.InvalidOperationOnBinaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 46991, 47029);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1537_46948_47030(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 46948, 47030);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1537_47188_47214(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 47188, 47214);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1537_47287_47313(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 47287, 47313);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1537_47407_47419()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 47407, 47419);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1537_47407_47428(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 47407, 47428);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1537_47459_47484(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 47459, 47484);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1537_47528_47540()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 47528, 47540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 46743, 47745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 46743, 47745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object Invoke(ScriptBlock sb, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 48068, 48787);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 48151, 48196) || true) && (sb == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 48151, 48196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 48184, 48196);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 48151, 48196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 48312, 48375);

                SessionStateInternal
                oldSessionState = f_1537_48351_48374(sb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 48389, 48403);

                object
                result
                = default(object);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 48453, 48501);

                    sb.SessionStateInternal = f_1537_48479_48500(f_1537_48479_48491());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 48519, 48554);

                    result = f_1537_48528_48553(sb, args);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1537, 48583, 48746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 48689, 48731);

                    sb.SessionStateInternal = oldSessionState;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1537, 48583, 48746);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 48762, 48776);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 48068, 48787);

                System.Management.Automation.SessionStateInternal
                f_1537_48351_48374(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 48351, 48374);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1537_48479_48491()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 48479, 48491);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1537_48479_48500(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 48479, 48500);
                    return return_v;
                }


                object
                f_1537_48528_48553(System.Management.Automation.ScriptBlock
                this_param, params object[]
                args)
                {
                    var return_v = this_param.InvokeReturnAsIs(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 48528, 48553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 48068, 48787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 48068, 48787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSVariable GetVariableFromCallersModule(string variableName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 49096, 50244);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 49188, 49323) || true) && (f_1537_49192_49226(variableName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 49188, 49323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 49260, 49308);

                    throw f_1537_49266_49307("variableName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 49188, 49323);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 49339, 49396);

                var
                context = f_1537_49353_49395()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 49410, 49450);

                SessionState
                callersSessionState = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 49464, 49947);
                    foreach (var sf in f_1537_49483_49514_I(f_1537_49483_49514(f_1537_49483_49499(context))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 49464, 49947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 49548, 49601);

                        var
                        frameModule = f_1537_49566_49600(f_1537_49566_49593(f_1537_49566_49583(sf)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 49619, 49709) || true) && (frameModule == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 49619, 49709);
                            DynAbs.Tracing.TraceSender.TraceBreak(1537, 49684, 49690);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 49619, 49709);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 49729, 49932) || true) && (f_1537_49733_49757(frameModule) != f_1537_49761_49773())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 49729, 49932);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 49815, 49885);

                            callersSessionState = f_1537_49837_49884(f_1537_49837_49871(f_1537_49837_49864(f_1537_49837_49854(sf))));
                            DynAbs.Tracing.TraceSender.TraceBreak(1537, 49907, 49913);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 49729, 49932);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 49464, 49947);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 484);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 49963, 50233) || true) && (callersSessionState != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 49963, 50233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 50028, 50090);

                    return f_1537_50035_50089(f_1537_50035_50063(callersSessionState), variableName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 49963, 50233);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 49963, 50233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 50156, 50218);

                    return f_1537_50163_50217(f_1537_50163_50191(context), variableName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 49963, 50233);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 49096, 50244);

                bool
                f_1537_49192_49226(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 49192, 49226);
                    return return_v;
                }


                System.ArgumentNullException
                f_1537_49266_49307(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 49266, 49307);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1537_49353_49395()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 49353, 49395);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1537_49483_49499(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 49483, 49499);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                f_1537_49483_49514(System.Management.Automation.ScriptDebugger
                this_param)
                {
                    var return_v = this_param.GetCallStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 49483, 49514);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1537_49566_49583(System.Management.Automation.CallStackFrame
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 49566, 49583);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1537_49566_49593(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 49566, 49593);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1537_49566_49600(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 49566, 49600);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1537_49733_49757(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 49733, 49757);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1537_49761_49773()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 49761, 49773);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1537_49837_49854(System.Management.Automation.CallStackFrame
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 49837, 49854);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1537_49837_49864(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 49837, 49864);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1537_49837_49871(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 49837, 49871);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1537_49837_49884(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 49837, 49884);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                f_1537_49483_49514_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CallStackFrame>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 49483, 49514);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1537_50035_50063(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50035, 50063);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1537_50035_50089(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 50035, 50089);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1537_50163_50191(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TopLevelSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50163, 50191);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1537_50163_50217(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 50163, 50217);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 49096, 50244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 49096, 50244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CaptureLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 50383, 51997);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 50437, 50599) || true) && (f_1537_50441_50453() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 50437, 50599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 50495, 50584);

                    throw f_1537_50501_50583(f_1537_50544_50582());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 50437, 50599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 50615, 50672);

                var
                context = f_1537_50629_50671()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 50686, 50750);

                var
                tuple = f_1537_50698_50749(f_1537_50698_50737(f_1537_50698_50724(context)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 50764, 50857);

                IEnumerable<PSVariable>
                variables = f_1537_50800_50856(f_1537_50800_50849(f_1537_50800_50839(f_1537_50800_50826(context))))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 50871, 51105) || true) && (tuple != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 50871, 51105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 50922, 50972);

                    var
                    result = f_1537_50935_50971()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 50990, 51028);

                    f_1537_50990_51027(tuple, result, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 51046, 51090);

                    variables = f_1537_51058_51089(f_1537_51058_51071(result), variables);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 50871, 51105);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 51121, 51986);
                    foreach (PSVariable v in f_1537_51146_51155_I(variables))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 51121, 51986);
                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 51295, 51867) || true) && (f_1537_51299_51308(v) == ScopedItemOptions.None && (DynAbs.Tracing.TraceSender.Expression_True(1537, 51299, 51358) && !(v is NullVariable)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 51295, 51867);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 51408, 51486);

                                PSVariable
                                newVar = f_1537_51428_51485(f_1537_51443_51449(v), f_1537_51451_51458(v), f_1537_51460_51469(v), f_1537_51471_51484(v))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 51717, 51769);

                                f_1537_51717_51768(                        // The variable is already defined/set in the scope, and that means the attributes
                                                                           // have already been checked if it was needed, so we don't do it again.
                                                        newVar, f_1537_51755_51767(v));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 51795, 51844);

                                f_1537_51795_51843(f_1537_51795_51816(f_1537_51795_51807()), newVar, false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 51295, 51867);
                            }
                        }
                        catch (SessionStateException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1537, 51904, 51971);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1537, 51904, 51971);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 51121, 51986);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 866);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 50383, 51997);

                System.Management.Automation.SessionState
                f_1537_50441_50453()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50441, 50453);
                    return return_v;
                }


                string
                f_1537_50544_50582()
                {
                    var return_v = Modules.InvalidOperationOnBinaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50544, 50582);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1537_50501_50583(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 50501, 50583);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1537_50629_50671()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 50629, 50671);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1537_50698_50724(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50698, 50724);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1537_50698_50737(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50698, 50737);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1537_50698_50749(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.LocalsTuple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50698, 50749);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1537_50800_50826(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50800, 50826);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1537_50800_50839(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50800, 50839);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                f_1537_50800_50849(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50800, 50849);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Management.Automation.PSVariable>
                f_1537_50800_50856(System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 50800, 50856);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                f_1537_50935_50971()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 50935, 50971);
                    return return_v;
                }


                int
                f_1537_50990_51027(System.Management.Automation.MutableTuple
                this_param, System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                result, bool
                includePrivate)
                {
                    this_param.GetVariableTable(result, includePrivate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 50990, 51027);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>.ValueCollection
                f_1537_51058_51071(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 51058, 51071);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSVariable>
                f_1537_51058_51089(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>.ValueCollection
                first, System.Collections.Generic.IEnumerable<System.Management.Automation.PSVariable>
                second)
                {
                    var return_v = first.Concat<System.Management.Automation.PSVariable>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 51058, 51089);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1537_51299_51308(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 51299, 51308);
                    return return_v;
                }


                string
                f_1537_51443_51449(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 51443, 51449);
                    return return_v;
                }


                object
                f_1537_51451_51458(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 51451, 51458);
                    return return_v;
                }


                System.Management.Automation.ScopedItemOptions
                f_1537_51460_51469(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 51460, 51469);
                    return return_v;
                }


                string
                f_1537_51471_51484(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 51471, 51484);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1537_51428_51485(string
                name, object
                value, System.Management.Automation.ScopedItemOptions
                options, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, value, options, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 51428, 51485);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1537_51755_51767(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 51755, 51767);
                    return return_v;
                }


                int
                f_1537_51717_51768(System.Management.Automation.PSVariable
                this_param, System.Collections.ObjectModel.Collection<System.Attribute>
                attributes)
                {
                    this_param.AddParameterAttributesNoChecks(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 51717, 51768);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1537_51795_51807()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 51795, 51807);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1537_51795_51816(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 51795, 51816);
                    return return_v;
                }


                object
                f_1537_51795_51843(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSVariable
                variable, bool
                force)
                {
                    var return_v = this_param.NewVariable(variable, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 51795, 51843);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSVariable>
                f_1537_51146_51155_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSVariable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 51146, 51155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 50383, 51997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 50383, 51997);
            }
        }

        public PSObject AsCustomObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 52162, 53197);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52219, 52381) || true) && (f_1537_52223_52235() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 52219, 52381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52277, 52366);

                    throw f_1537_52283_52365(f_1537_52326_52364());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 52219, 52381);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52397, 52427);

                PSObject
                obj = f_1537_52412_52426()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52443, 52804);
                    foreach (KeyValuePair<string, FunctionInfo> entry in f_1537_52496_52518_I(f_1537_52496_52518(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 52443, 52804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52552, 52584);

                        FunctionInfo
                        func = entry.Value
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52602, 52789) || true) && (func != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 52602, 52789);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52660, 52728);

                            PSScriptMethod
                            sm = f_1537_52680_52727(f_1537_52699_52708(func), f_1537_52710_52726(func))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52750, 52770);

                            f_1537_52750_52769(f_1537_52750_52761(obj), sm);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 52602, 52789);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 52443, 52804);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 362);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52820, 53159);
                    foreach (KeyValuePair<string, PSVariable> entry in f_1537_52871_52893_I(f_1537_52871_52893(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 52820, 53159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52927, 52956);

                        PSVariable
                        var = entry.Value
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 52974, 53144) || true) && (var != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 52974, 53144);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53031, 53083);

                            PSVariableProperty
                            sm = f_1537_53055_53082(var)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53105, 53125);

                            f_1537_53105_53124(f_1537_53105_53116(obj), sm);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 52974, 53144);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 52820, 53159);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53175, 53186);

                return obj;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 52162, 53197);

                System.Management.Automation.SessionState
                f_1537_52223_52235()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 52223, 52235);
                    return return_v;
                }


                string
                f_1537_52326_52364()
                {
                    var return_v = Modules.InvalidOperationOnBinaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 52326, 52364);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1537_52283_52365(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 52283, 52365);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1537_52412_52426()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 52412, 52426);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1537_52496_52518(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 52496, 52518);
                    return return_v;
                }


                string
                f_1537_52699_52708(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 52699, 52708);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1537_52710_52726(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 52710, 52726);
                    return return_v;
                }


                System.Management.Automation.PSScriptMethod
                f_1537_52680_52727(string
                name, System.Management.Automation.ScriptBlock
                script)
                {
                    var return_v = new System.Management.Automation.PSScriptMethod(name, script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 52680, 52727);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1537_52750_52761(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 52750, 52761);
                    return return_v;
                }


                int
                f_1537_52750_52769(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSScriptMethod
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 52750, 52769);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                f_1537_52496_52518_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.FunctionInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 52496, 52518);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                f_1537_52871_52893(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 52871, 52893);
                    return return_v;
                }


                System.Management.Automation.PSVariableProperty
                f_1537_53055_53082(System.Management.Automation.PSVariable
                variable)
                {
                    var return_v = new System.Management.Automation.PSVariableProperty(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 53055, 53082);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1537_53105_53116(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 53105, 53116);
                    return return_v;
                }


                int
                f_1537_53105_53124(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSVariableProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 53105, 53124);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                f_1537_52871_52893_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 52871, 52893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 52162, 53197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 52162, 53197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ScriptBlock OnRemove { get; set; }

        public ReadOnlyCollection<string> ExportedFormatFiles { get; private set; }

        internal void SetExportedFormatFiles(ReadOnlyCollection<string> files)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 53669, 53803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 53764, 53792);

                ExportedFormatFiles = files;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 53669, 53803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 53669, 53803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 53669, 53803);
            }
        }

        public ReadOnlyCollection<string> ExportedTypeFiles { get; private set; }

        internal void SetExportedTypeFiles(ReadOnlyCollection<string> files)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 54063, 54193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 54156, 54182);

                ExportedTypeFiles = files;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 54063, 54193);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 54063, 54193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 54063, 54193);
            }
        }

        public PSModuleInfo Clone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 54375, 55767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 54427, 54485);

                PSModuleInfo
                clone = (PSModuleInfo)f_1537_54462_54484(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 54501, 54551);

                clone._fileList = f_1537_54519_54550(f_1537_54536_54549(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 54565, 54621);

                clone._moduleList = f_1537_54585_54620(_moduleList);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 54637, 54747);
                    foreach (var n in f_1537_54655_54673_I(f_1537_54655_54673(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 54637, 54747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 54707, 54732);

                        f_1537_54707_54731(clone, n);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 54637, 54747);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 54763, 54851);

                clone._readonlyNestedModules = f_1537_54794_54850(f_1537_54831_54849(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 54865, 54957);

                clone._readonlyRequiredModules = f_1537_54898_54956(f_1537_54935_54955(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 54971, 55096);

                clone._readonlyRequiredModulesSpecification = f_1537_55017_55095(f_1537_55061_55094(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55110, 55182);

                clone._requiredAssemblies = f_1537_55138_55181(_requiredAssemblies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55196, 55266);

                clone._requiredModulesSpecification = f_1537_55234_55265();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55280, 55330);

                clone._requiredModules = f_1537_55305_55329();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55346, 55456);
                    foreach (var r in f_1537_55364_55380_I(_requiredModules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 55346, 55456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55414, 55441);

                        f_1537_55414_55440(clone, r);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 55346, 55456);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 111);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55472, 55608);
                    foreach (var r in f_1537_55490_55519_I(_requiredModulesSpecification))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 55472, 55608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55553, 55593);

                        f_1537_55553_55592(clone, r);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 55472, 55608);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1537, 1, 137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1537, 1, 137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55624, 55672);

                clone._scripts = f_1537_55641_55671(f_1537_55658_55670(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55688, 55727);

                clone.SessionState = f_1537_55709_55726(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55743, 55756);

                return clone;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 54375, 55767);

                object
                f_1537_54462_54484(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.MemberwiseClone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 54462, 54484);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1537_54536_54549(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.FileList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 54536, 54549);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1537_54519_54550(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 54519, 54550);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1537_54585_54620(System.Collections.ObjectModel.Collection<object>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.Collection<object>((System.Collections.Generic.IList<object>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 54585, 54620);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1537_54655_54673(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 54655, 54673);
                    return return_v;
                }


                int
                f_1537_54707_54731(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.PSModuleInfo
                nestedModule)
                {
                    this_param.AddNestedModule(nestedModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 54707, 54731);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1537_54655_54673_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 54655, 54673);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1537_54831_54849(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 54831, 54849);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1537_54794_54850(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>((System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 54794, 54850);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1537_54935_54955(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RequiredModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 54935, 54955);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1537_54898_54956(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>((System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 54898, 54956);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1537_55061_55094(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RequiredModulesSpecification;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 55061, 55094);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1537_55017_55095(System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<Microsoft.PowerShell.Commands.ModuleSpecification>((System.Collections.Generic.IList<Microsoft.PowerShell.Commands.ModuleSpecification>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 55017, 55095);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1537_55138_55181(System.Collections.ObjectModel.Collection<string>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>((System.Collections.Generic.IList<string>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 55138, 55181);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1537_55234_55265()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 55234, 55265);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1537_55305_55329()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 55305, 55329);
                    return return_v;
                }


                int
                f_1537_55414_55440(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.PSModuleInfo
                requiredModule)
                {
                    this_param.AddRequiredModule(requiredModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 55414, 55440);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1537_55364_55380_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 55364, 55380);
                    return return_v;
                }


                int
                f_1537_55553_55592(System.Management.Automation.PSModuleInfo
                this_param, Microsoft.PowerShell.Commands.ModuleSpecification
                requiredModuleSpecification)
                {
                    this_param.AddRequiredModuleSpecification(requiredModuleSpecification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 55553, 55592);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1537_55490_55519_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 55490, 55519);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1537_55658_55670(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Scripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 55658, 55670);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1537_55641_55671(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 55641, 55671);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1537_55709_55726(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 55709, 55726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 54375, 55767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 54375, 55767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool UseAppDomainLevelModuleCache { get; set; }

        public static void ClearAppDomainLevelModulePathCache()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1537, 56074, 56200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 56154, 56189);

                f_1537_56154_56188(s_appdomainModulePathCache);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1537, 56074, 56200);

                int
                f_1537_56154_56188(System.Collections.Concurrent.ConcurrentDictionary<string, string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 56154, 56188);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 56074, 56200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 56074, 56200);
            }
        }

        public static object GetAppDomainLevelModuleCache()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1537, 56392, 56513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 56468, 56502);

                return s_appdomainModulePathCache;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1537, 56392, 56513);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 56392, 56513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 56392, 56513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ResolveUsingAppDomainLevelModuleCache(string moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1537, 56783, 57135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 56887, 56899);

                string
                path
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 56913, 57124) || true) && (f_1537_56917_56977(s_appdomainModulePathCache, moduleName, out path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 56913, 57124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 57011, 57023);

                    return path;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 56913, 57124);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 56913, 57124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 57089, 57109);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 56913, 57124);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1537, 56783, 57135);

                bool
                f_1537_56917_56977(System.Collections.Concurrent.ConcurrentDictionary<string, string>
                this_param, string
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 56917, 56977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 56783, 57135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 56783, 57135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void AddToAppDomainLevelModuleCache(string moduleName, string path, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1537, 57517, 57912);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 57637, 57901) || true) && (force)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 57637, 57901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 57680, 57768);

                    f_1537_57680_57767(s_appdomainModulePathCache, moduleName, path, (modulename, oldPath) => path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 57637, 57901);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 57637, 57901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 57834, 57886);

                    f_1537_57834_57885(s_appdomainModulePathCache, moduleName, path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 57637, 57901);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1537, 57517, 57912);

                string
                f_1537_57680_57767(System.Collections.Concurrent.ConcurrentDictionary<string, string>
                this_param, string
                key, string
                addValue, System.Func<string, string, string>
                updateValueFactory)
                {
                    var return_v = this_param.AddOrUpdate(key, addValue, updateValueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 57680, 57767);
                    return return_v;
                }


                bool
                f_1537_57834_57885(System.Collections.Concurrent.ConcurrentDictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 57834, 57885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 57517, 57912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 57517, 57912);
            }
        }

        internal static bool RemoveFromAppDomainLevelCache(string moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1537, 58237, 58444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 58331, 58348);

                string
                outString
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 58362, 58433);

                return f_1537_58369_58432(s_appdomainModulePathCache, moduleName, out outString);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1537, 58237, 58444);

                bool
                f_1537_58369_58432(System.Collections.Concurrent.ConcurrentDictionary<string, string>
                this_param, string
                key, out string
                value)
                {
                    var return_v = this_param.TryRemove(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 58369, 58432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 58237, 58444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 58237, 58444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly System.Collections.Concurrent.ConcurrentDictionary<string, string> s_appdomainModulePathCache;

        static PSModuleInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1537, 660, 58701);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 731, 777);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 860, 1033);
            s_emptyTypeDefinitionDictionary = f_1537_907_1033(f_1537_957_1032(f_1537_999_1031()));
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 1277, 1450);
            s_scriptModuleExtensions = new HashSet<string>(f_1537_1324_1356())
            {
                DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => StringLiterals.PowerShellModuleFileExtension,1537,1304,1450)            };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 40801, 41024);
            _builtinVariables = new string[] { "_", "this", "input", "args", "true", "false", "null",
            "PSDefaultParameterValues", "Error", "PSScriptRoot", "PSCommandPath", "MyInvocation", "ExecutionContext", "StackTrace" };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 55892, 55953);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 58547, 58693);
            s_appdomainModulePathCache = f_1537_58589_58693(f_1537_58660_58692());
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1537, 660, 58701);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 660, 58701);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1537, 660, 58701);

        static System.StringComparer
        f_1537_999_1031()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 999, 1031);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
        f_1537_957_1032(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 957, 1032);
            return return_v;
        }


        static System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
        f_1537_907_1033(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
        dictionary)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>((System.Collections.Generic.IDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>)dictionary);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 907, 1033);
            return return_v;
        }


        static System.StringComparer
        f_1537_1324_1356()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 1324, 1356);
            return return_v;
        }


        static string
        f_1537_2203_2207_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1537, 2095, 2259);
            return return_v;
        }


        static string
        f_1537_3011_3015_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1537, 2860, 3109);
            return return_v;
        }


        string
        f_1537_3819_3866(string
        filePath, System.Management.Automation.ExecutionContext
        context)
        {
            var return_v = ModuleCmdletBase.GetResolvedPath(filePath, context);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 3819, 3866);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1537_4221_4242(System.Management.Automation.SessionState
        this_param)
        {
            var return_v = this_param.Internal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 4221, 4242);
            return return_v;
        }


        string
        f_1537_4437_4441()
        {
            var return_v = Path;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 4437, 4441);
            return return_v;
        }


        string
        f_1537_4406_4442(string
        path)
        {
            var return_v = ModuleIntrinsics.GetModuleName(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 4406, 4442);
            return return_v;
        }


        static System.Management.Automation.ExecutionContext
        f_1537_4637_4679()
        {
            var return_v = LocalPipeline.GetExecutionContextFromTLS();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 4637, 4679);
            return return_v;
        }


        static System.Management.Automation.ExecutionContext
        f_1537_4637_4679_C(System.Management.Automation.ExecutionContext
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1537, 4578, 4716);
            return return_v;
        }


        System.InvalidOperationException
        f_1537_4975_5020(string
        message)
        {
            var return_v = new System.InvalidOperationException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 4975, 5020);
            return return_v;
        }


        int
        f_1537_5037_5071(System.Management.Automation.PSModuleInfo
        module)
        {
            SetDefaultDynamicNameAndPath(module);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 5037, 5071);
            return 0;
        }


        System.Management.Automation.SessionState
        f_1537_5549_5594(System.Management.Automation.ExecutionContext
        context, bool
        createAsChild, bool
        linkToGlobal)
        {
            var return_v = new System.Management.Automation.SessionState(context, createAsChild, linkToGlobal);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 5549, 5594);
            return return_v;
        }


        System.Management.Automation.SessionState
        f_1537_5609_5621()
        {
            var return_v = SessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 5609, 5621);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1537_5609_5630(System.Management.Automation.SessionState
        this_param)
        {
            var return_v = this_param.Internal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 5609, 5630);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1537_6051_6100(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 6051, 6100);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1537_6204_6246()
        {
            var return_v = LocalPipeline.GetExecutionContextFromTLS();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 6204, 6246);
            return return_v;
        }


        System.InvalidOperationException
        f_1537_6307_6352(string
        message)
        {
            var return_v = new System.InvalidOperationException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 6307, 6352);
            return return_v;
        }


        int
        f_1537_6369_6403(System.Management.Automation.PSModuleInfo
        module)
        {
            SetDefaultDynamicNameAndPath(module);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 6369, 6403);
            return 0;
        }


        System.Management.Automation.SessionState
        f_1537_6881_6918(System.Management.Automation.ExecutionContext
        context, bool
        createAsChild, bool
        linkToGlobal)
        {
            var return_v = new System.Management.Automation.SessionState(context, createAsChild, linkToGlobal);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 6881, 6918);
            return return_v;
        }


        System.Management.Automation.SessionState
        f_1537_6933_6945()
        {
            var return_v = SessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 6933, 6945);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1537_6933_6954(System.Management.Automation.SessionState
        this_param)
        {
            var return_v = this_param.Internal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 6933, 6954);
            return return_v;
        }


        System.Management.Automation.PSLanguageMode?
        f_1537_7000_7024(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.LanguageMode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 7000, 7024);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1537_7166_7192(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineSessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 7166, 7192);
            return return_v;
        }


        System.Management.Automation.SessionState
        f_1537_7272_7284()
        {
            var return_v = SessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 7272, 7284);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1537_7272_7293(System.Management.Automation.SessionState
        this_param)
        {
            var return_v = this_param.Internal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 7272, 7293);
            return return_v;
        }


        string
        f_1537_7425_7429()
        {
            var return_v = Path;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 7425, 7429);
            return return_v;
        }


        int
        f_1537_7367_7430(System.Management.Automation.ExecutionContext
        this_param, System.Management.Automation.VariablePath
        path, string
        newValue)
        {
            this_param.SetVariable(path, (object)newValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 7367, 7430);
            return 0;
        }


        System.Management.Automation.ScriptBlock
        f_1537_7465_7484(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.Clone();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 7465, 7484);
            return return_v;
        }


        System.Management.Automation.SessionState
        f_1537_7530_7542()
        {
            var return_v = SessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 7530, 7542);
            return return_v;
        }


        System.Management.Automation.PSObject
        f_1537_7883_7903()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 7883, 7903);
            return return_v;
        }


        System.Management.Automation.PSObject
        f_1537_7933_7953()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 7933, 7953);
            return return_v;
        }


        System.Management.Automation.PSObject
        f_1537_7988_8008()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 7988, 8008);
            return return_v;
        }


        int
        f_1537_7675_8119(System.Management.Automation.ScriptBlock
        this_param, bool
        useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
        errorHandlingBehavior, System.Management.Automation.PSObject
        dollarUnder, System.Management.Automation.PSObject
        input, System.Management.Automation.PSObject
        scriptThis, System.Management.Automation.Internal.Pipe
        outputPipe, System.Management.Automation.InvocationInfo
        invocationInfo)
        {
            this_param.InvokeWithPipe(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, outputPipe: outputPipe, invocationInfo: invocationInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 7675, 8119);
            return 0;
        }


        System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.ExperimentalFeature>
        f_1537_15211_15263()
        {
            var return_v = Utils.EmptyReadOnlyCollection<ExperimentalFeature>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 15211, 15263);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1537_15495_15513()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 15495, 15513);
            return return_v;
        }


        System.Version
        f_1537_16504_16521(int
        major, int
        minor)
        {
            var return_v = new System.Version(major, minor);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 16504, 16521);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1537_18987_19005()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 18987, 19005);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1537_19062_19080()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 19062, 19080);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, string>
        f_1537_19150_19182()
        {
            var return_v = new System.Collections.Generic.Dictionary<string, string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 19150, 19182);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
        f_1537_31725_31747()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.CmdletInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 31725, 31747);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.AliasInfo>
        f_1537_32589_32610()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.AliasInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 32589, 32610);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1537_32834_32852()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 32834, 32852);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1537_33508_33526()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 33508, 33526);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1537_34786_34810()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 34786, 34810);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
        f_1537_35840_35864()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 35840, 35864);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1537_36892_36910()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 36892, 36910);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1537_37278_37302()
        {
            var return_v = new System.Collections.ObjectModel.Collection<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 37278, 37302);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
        f_1537_38377_38401()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 38377, 38401);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
        f_1537_39558_39589()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 39558, 39589);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1537_53637_53655()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 53637, 53655);
            return return_v;
        }


        System.Collections.ObjectModel.ReadOnlyCollection<string>
        f_1537_53606_53656(System.Collections.Generic.List<string>
        list)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>((System.Collections.Generic.IList<string>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 53606, 53656);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1537_54031_54049()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 54031, 54049);
            return return_v;
        }


        System.Collections.ObjectModel.ReadOnlyCollection<string>
        f_1537_54000_54050(System.Collections.Generic.List<string>
        list)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>((System.Collections.Generic.IList<string>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 54000, 54050);
            return return_v;
        }


        static System.StringComparer
        f_1537_58660_58692()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 58660, 58692);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<string, string>
        f_1537_58589_58693(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 58589, 58693);
            return return_v;
        }

    }

    /// <summary>
    /// Indicates the type of a module.
    /// </summary>
    public enum ModuleType
    {
        /// <summary>
        /// Indicates that this is a script module (a powershell file with a .PSM1 extension)
        /// </summary>
        Script = 0,
        /// <summary>
        /// Indicates that this is compiled .dll containing cmdlet definitions.
        /// </summary>
        Binary = 1,
        /// <summary>
        /// Indicates that this module entry was derived from a module manifest and
        /// may have child modules.
        /// </summary>
        Manifest,
        /// <summary>
        /// Indicates that this is cmdlets-over-objects module (a powershell file with a .CDXML extension)
        /// </summary>
        Cim,
    }

    /// <summary>
    /// Defines the possible access modes for a module...
    /// </summary>
    public enum ModuleAccessMode
    {
        /// <summary>
        /// The default access mode for the module.
        /// </summary>
        ReadWrite = 0,
        /// <summary>
        /// The module is readonly and can only be removed with -force.
        /// </summary>
        ReadOnly = 1,
        /// <summary>
        /// The module cannot be removed.
        /// </summary>
        Constant = 2
    }
    internal sealed class PSModuleInfoComparer : IEqualityComparer<PSModuleInfo>
    {
        public bool Equals(PSModuleInfo x, PSModuleInfo y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 60315, 60901);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 60466, 60512) || true) && (f_1537_60470_60498(x, y))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 60466, 60512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 60500, 60512);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 60466, 60512);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 60595, 60697) || true) && (f_1537_60599_60630(x, null) || (DynAbs.Tracing.TraceSender.Expression_False(1537, 60599, 60665) || f_1537_60634_60665(y, null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 60595, 60697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 60684, 60697);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 60595, 60697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 60713, 60860);

                bool
                result = f_1537_60727_60792(f_1537_60741_60747(x), f_1537_60749_60755(y), StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1537, 60727, 60831) && (f_1537_60814_60820(x) == f_1537_60824_60830(y))) && (DynAbs.Tracing.TraceSender.Expression_True(1537, 60727, 60859) && (f_1537_60836_60845(x) == f_1537_60849_60858(y)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 60876, 60890);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 60315, 60901);

                bool
                f_1537_60470_60498(System.Management.Automation.PSModuleInfo
                objA, System.Management.Automation.PSModuleInfo
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 60470, 60498);
                    return return_v;
                }


                bool
                f_1537_60599_60630(System.Management.Automation.PSModuleInfo
                objA, object?
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 60599, 60630);
                    return return_v;
                }


                bool
                f_1537_60634_60665(System.Management.Automation.PSModuleInfo
                objA, object?
                objB)
                {
                    var return_v = Object.ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 60634, 60665);
                    return return_v;
                }


                string
                f_1537_60741_60747(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 60741, 60747);
                    return return_v;
                }


                string
                f_1537_60749_60755(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 60749, 60755);
                    return return_v;
                }


                bool
                f_1537_60727_60792(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 60727, 60792);
                    return return_v;
                }


                System.Guid
                f_1537_60814_60820(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 60814, 60820);
                    return return_v;
                }


                System.Guid
                f_1537_60824_60830(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 60824, 60830);
                    return return_v;
                }


                System.Version
                f_1537_60836_60845(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 60836, 60845);
                    return return_v;
                }


                System.Version
                f_1537_60849_60858(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 60849, 60858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 60315, 60901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 60315, 60901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(PSModuleInfo obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1537, 60913, 61813);
                unchecked // Overflow is fine, just wrap
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 61051, 61066);

                    int
                    result = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 61086, 61753) || true) && (obj != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 61086, 61753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 61223, 61235);

                        result = 23;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 61257, 61396) || true) && (f_1537_61261_61269(obj) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 61257, 61396);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 61327, 61373);

                            result = result * 17 + f_1537_61350_61372(f_1537_61350_61358(obj));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 61257, 61396);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 61420, 61565) || true) && (f_1537_61424_61432(obj) != Guid.Empty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 61420, 61565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 61496, 61542);

                            result = result * 17 + obj.Guid.GetHashCode();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 61420, 61565);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 61589, 61734) || true) && (f_1537_61593_61604(obj) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1537, 61589, 61734);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 61662, 61711);

                            result = result * 17 + f_1537_61685_61710(f_1537_61685_61696(obj));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 61589, 61734);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1537, 61086, 61753);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1537, 61773, 61787);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1537, 60913, 61813);

                string
                f_1537_61261_61269(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 61261, 61269);
                    return return_v;
                }


                string
                f_1537_61350_61358(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 61350, 61358);
                    return return_v;
                }


                int
                f_1537_61350_61372(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 61350, 61372);
                    return return_v;
                }


                System.Guid
                f_1537_61424_61432(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 61424, 61432);
                    return return_v;
                }


                System.Version
                f_1537_61593_61604(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 61593, 61604);
                    return return_v;
                }


                System.Version
                f_1537_61685_61696(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1537, 61685, 61696);
                    return return_v;
                }


                int
                f_1537_61685_61710(System.Version
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1537, 61685, 61710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1537, 60913, 61813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 60913, 61813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSModuleInfoComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1537, 60222, 61820);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1537, 60222, 61820);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 60222, 61820);
        }


        static PSModuleInfoComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1537, 60222, 61820);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1537, 60222, 61820);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1537, 60222, 61820);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1537, 60222, 61820);
    }
}
