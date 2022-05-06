// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Internal;

//
// Now define the set of commands for manipulating modules.
//

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsDiagnostic.Test, "ModuleManifest", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096900")]
    [OutputType(typeof(PSModuleInfo))]
    public sealed class TestModuleManifestCommand : ModuleCmdletBase
    {
        public TestModuleManifestCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1541, 957, 1510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 1883, 1888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 1471, 1499);

                BaseSkipEditionCheck = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1541, 957, 1510);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1541, 957, 1510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1541, 957, 1510);
            }
        }

        [Parameter(Mandatory = true, ValueFromPipeline = true, Position = 0, ValueFromPipelineByPropertyName = true)]
        public string Path
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1541, 1786, 1807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 1792, 1805);

                    return _path;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1541, 1786, 1807);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1541, 1624, 1856);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1541, 1624, 1856);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1541, 1823, 1845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 1829, 1843);

                    _path = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1541, 1823, 1845);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1541, 1624, 1856);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1541, 1624, 1856);
                }
            }
        }

        private string _path;

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1541, 2011, 15903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 2075, 2104);

                ProviderInfo
                provider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 2118, 2147);

                Collection<string>
                filePaths
                = default(Collection<string>);

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 2199, 2613) || true) && (f_1541_2203_2280(f_1541_2203_2229(f_1541_2203_2210()), f_1541_2247_2279(f_1541_2247_2268(f_1541_2247_2254()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 2199, 2613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 2322, 2432);

                        filePaths =
                        f_1541_2359_2431(f_1541_2359_2376(f_1541_2359_2371()), _path, out provider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 2199, 2613);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 2199, 2613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 2514, 2551);

                        filePaths = f_1541_2526_2550();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 2573, 2594);

                        f_1541_2573_2593(filePaths, _path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 2199, 2613);
                    }
                }
                catch (ItemNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1541, 2642, 3069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 2704, 2770);

                    string
                    message = f_1541_2721_2769(f_1541_2739_2761(), _path)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 2788, 2851);

                    FileNotFoundException
                    fnf = f_1541_2816_2850(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 2869, 2996);

                    ErrorRecord
                    er = f_1541_2886_2995(fnf, "Modules_ModuleNotFound", ErrorCategory.ResourceUnavailable, _path)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 3014, 3029);

                    f_1541_3014_3028(this, er);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 3047, 3054);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1541, 2642, 3069);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 3187, 3539) || true) && (!f_1541_3192_3250(provider, f_1541_3212_3249(f_1541_3212_3238(f_1541_3212_3224(this)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 3187, 3539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 3352, 3524);

                    throw f_1541_3358_3523(_path, typeof(RuntimeException), null, "FileOpenError", f_1541_3476_3503(), f_1541_3505_3522(provider));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 3187, 3539);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 3612, 4055) || true) && (filePaths == null || (DynAbs.Tracing.TraceSender.Expression_False(1541, 3616, 3656) || f_1541_3637_3652(filePaths) < 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 3612, 4055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 3690, 3756);

                    string
                    message = f_1541_3707_3755(f_1541_3725_3747(), _path)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 3774, 3837);

                    FileNotFoundException
                    fnf = f_1541_3802_3836(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 3855, 3982);

                    ErrorRecord
                    er = f_1541_3872_3981(fnf, "Modules_ModuleNotFound", ErrorCategory.ResourceUnavailable, _path)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 4000, 4015);

                    f_1541_4000_4014(this, er);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 4033, 4040);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 3612, 4055);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 4071, 4400) || true) && (f_1541_4075_4090(filePaths) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 4071, 4400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 4228, 4385);

                    throw f_1541_4234_4384(filePaths, typeof(RuntimeException), null, "AmbiguousPath", f_1541_4356_4383());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 4071, 4400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 4416, 4447);

                string
                filePath = f_1541_4434_4446(filePaths, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 4461, 4498);

                ExternalScriptInfo
                scriptInfo = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 4512, 4563);

                string
                ext = f_1541_4525_4562(filePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 4577, 15892) || true) && (f_1541_4581_4671(ext, StringLiterals.PowerShellDataFileExtension, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 4577, 15892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 4770, 4788);

                    string
                    scriptName
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 4806, 4873);

                    scriptInfo = f_1541_4819_4872(this, filePath, out scriptName, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 5054, 5074);

                    PSModuleInfo
                    module
                    = default(PSModuleInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 5092, 5156);

                    string
                    _origModuleBeingProcessed = f_1541_5127_5155(f_1541_5127_5134())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 5218, 5546);

                        module = f_1541_5227_5545(this, scriptInfo, ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.WriteWarnings, null, null, null, null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 5570, 14060) || true) && (module != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 5570, 14060);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 5690, 6622) || true) && (f_1541_5694_5719(module) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 5690, 6622);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 5785, 6595);
                                    foreach (string requiredAssembliespath in f_1541_5827_5852_I(f_1541_5827_5852(module)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 5785, 6595);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 5918, 6564) || true) && (!f_1541_5923_5976(this, requiredAssembliespath, module, true) && (DynAbs.Tracing.TraceSender.Expression_True(1541, 5922, 6023) && !f_1541_5981_6023(this, requiredAssembliespath)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 5918, 6564);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 6097, 6218);

                                            string
                                            errorMsg = f_1541_6115_6217(f_1541_6133_6182(), requiredAssembliespath, filePath)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 6256, 6467);

                                            var
                                            errorRecord = f_1541_6274_6466(f_1541_6290_6330(errorMsg), "Modules_InvalidRequiredAssembliesInModuleManifest", ErrorCategory.ObjectNotFound, _path)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 6505, 6529);

                                            f_1541_6505_6528(this, errorRecord);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 5918, 6564);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 5785, 6595);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1541, 1, 811);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1541, 1, 811);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 5690, 6622);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 6650, 7133) || true) && (!f_1541_6655_6681(this, module))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 6650, 7133);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 6739, 6835);

                                string
                                errorMsg = f_1541_6757_6834(f_1541_6775_6804(), f_1541_6806_6823(module), filePath)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 6865, 7052);

                                var
                                errorRecord = f_1541_6883_7051(f_1541_6899_6930(errorMsg), "Modules_InvalidRootModuleInModuleManifest", ErrorCategory.InvalidArgument, _path)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 7082, 7106);

                                f_1541_7082_7105(this, errorRecord);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 6650, 7133);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 7161, 7183);

                            Hashtable
                            data = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 7209, 7240);

                            Hashtable
                            localizedData = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 7266, 7295);

                            bool
                            containerErrors = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 7321, 7483);

                            f_1541_7321_7482(this, scriptInfo, ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.WriteWarnings, out data, out localizedData, ref containerErrors);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 7509, 7545);

                            ModuleSpecification[]
                            nestedModules
                            = default(ModuleSpecification[]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 7571, 7725);

                            f_1541_7571_7724(this, data, f_1541_7595_7610(scriptInfo), "NestedModules", ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.WriteWarnings, out nestedModules);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 7751, 9487) || true) && (nestedModules != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 7751, 9487);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 7834, 9460);
                                    foreach (ModuleSpecification nestedModule in f_1541_7879_7892_I(nestedModules))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 7834, 9460);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 7958, 9429) || true) && (!f_1541_7963_8011(this, f_1541_7979_7996(nestedModule), module, true) && (DynAbs.Tracing.TraceSender.Expression_True(1541, 7962, 8148) && !f_1541_8053_8148(this, f_1541_8069_8086(nestedModule) + StringLiterals.PowerShellILAssemblyExtension, module, true)) && (DynAbs.Tracing.TraceSender.Expression_True(1541, 7962, 8287) && !f_1541_8190_8287(this, f_1541_8206_8223(nestedModule) + StringLiterals.PowerShellNgenAssemblyExtension, module, true)) && (DynAbs.Tracing.TraceSender.Expression_True(1541, 7962, 8426) && !f_1541_8329_8426(this, f_1541_8345_8362(nestedModule) + StringLiterals.PowerShellILExecutableExtension, module, true)) && (DynAbs.Tracing.TraceSender.Expression_True(1541, 7962, 8563) && !f_1541_8468_8563(this, f_1541_8484_8501(nestedModule) + StringLiterals.PowerShellModuleFileExtension, module, true)) && (DynAbs.Tracing.TraceSender.Expression_True(1541, 7962, 8642) && !f_1541_8605_8642(this, f_1541_8624_8641(nestedModule))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 7958, 9429);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 8716, 8786);

                                            Collection<PSModuleInfo>
                                            modules = f_1541_8751_8785(nestedModule)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 8824, 9394) || true) && (0 == f_1541_8833_8846(modules))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 8824, 9394);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 8928, 9038);

                                                string
                                                errorMsg = f_1541_8946_9037(f_1541_8964_9007(), f_1541_9009_9026(nestedModule), filePath)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 9080, 9289);

                                                var
                                                errorRecord = f_1541_9098_9288(f_1541_9114_9154(errorMsg), "Modules_InvalidNestedModuleinModuleManifest", ErrorCategory.ObjectNotFound, _path)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 9331, 9355);

                                                f_1541_9331_9354(this, errorRecord);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 8824, 9394);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 7958, 9429);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 7834, 9460);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1541, 1, 1627);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1541, 1, 1627);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 7751, 9487);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 9515, 9553);

                            ModuleSpecification[]
                            requiredModules
                            = default(ModuleSpecification[]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 9579, 9737);

                            f_1541_9579_9736(this, data, f_1541_9603_9618(scriptInfo), "RequiredModules", ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.WriteWarnings, out requiredModules);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 9763, 10704) || true) && (requiredModules != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 9763, 10704);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 9848, 10677);
                                    foreach (ModuleSpecification requiredModule in f_1541_9895_9910_I(requiredModules))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 9848, 10677);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 9976, 10058);

                                        var
                                        modules = f_1541_9990_10057(this, new[] { f_1541_10008_10027(requiredModule) }, all: false, refresh: true)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 10092, 10646) || true) && (f_1541_10096_10109(modules) == 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 10092, 10646);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 10188, 10303);

                                            string
                                            errorMsg = f_1541_10206_10302(f_1541_10224_10270(), f_1541_10272_10291(requiredModule), filePath)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 10341, 10549);

                                            var
                                            errorRecord = f_1541_10359_10548(f_1541_10375_10415(errorMsg), "Modules_InvalidRequiredModulesinModuleManifest", ErrorCategory.ObjectNotFound, _path)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 10587, 10611);

                                            f_1541_10587_10610(this, errorRecord);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 10092, 10646);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 9848, 10677);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1541, 1, 830);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1541, 1, 830);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 9763, 10704);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 10732, 10755);

                            string[]
                            fileListPaths
                            = default(string[]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 10781, 10930);

                            f_1541_10781_10929(this, data, f_1541_10805_10820(scriptInfo), "FileList", ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.WriteWarnings, out fileListPaths);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 10956, 11767) || true) && (fileListPaths != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 10956, 11767);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 11039, 11740);
                                    foreach (string fileListPath in f_1541_11071_11084_I(fileListPaths))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 11039, 11740);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 11150, 11709) || true) && (!f_1541_11155_11198(this, fileListPath, module, true))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 11150, 11709);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 11272, 11373);

                                            string
                                            errorMsg = f_1541_11290_11372(f_1541_11308_11347(), fileListPath, filePath)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 11411, 11612);

                                            var
                                            errorRecord = f_1541_11429_11611(f_1541_11445_11485(errorMsg), "Modules_InvalidFilePathinModuleManifest", ErrorCategory.ObjectNotFound, _path)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 11650, 11674);

                                            f_1541_11650_11673(this, errorRecord);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 11150, 11709);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 11039, 11740);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1541, 1, 702);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1541, 1, 702);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 10956, 11767);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 11795, 11835);

                            ModuleSpecification[]
                            moduleListModules
                            = default(ModuleSpecification[]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 11861, 12016);

                            f_1541_11861_12015(this, data, f_1541_11885_11900(scriptInfo), "ModuleList", ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.WriteWarnings, out moduleListModules);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 12042, 12983) || true) && (moduleListModules != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 12042, 12983);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 12129, 12956);
                                    foreach (ModuleSpecification moduleListModule in f_1541_12178_12195_I(moduleListModules))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 12129, 12956);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 12261, 12345);

                                        var
                                        modules = f_1541_12275_12344(this, new[] { f_1541_12293_12314(moduleListModule) }, all: false, refresh: true)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 12379, 12925) || true) && (f_1541_12383_12396(modules) == 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 12379, 12925);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 12475, 12587);

                                            string
                                            errorMsg = f_1541_12493_12586(f_1541_12511_12552(), f_1541_12554_12575(moduleListModule), filePath)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 12625, 12828);

                                            var
                                            errorRecord = f_1541_12643_12827(f_1541_12659_12699(errorMsg), "Modules_InvalidModuleListinModuleManifest", ErrorCategory.ObjectNotFound, _path)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 12866, 12890);

                                            f_1541_12866_12889(this, errorRecord);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 12379, 12925);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 12129, 12956);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1541, 1, 828);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1541, 1, 828);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 12042, 12983);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 13011, 14037) || true) && (f_1541_13015_13048(f_1541_13015_13042(module)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 13011, 14037);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 13380, 13437);

                                var
                                minimumRequiredPowerShellVersion = f_1541_13419_13436(5, 1)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 13467, 14010) || true) && ((f_1541_13472_13496(module) == null) || (DynAbs.Tracing.TraceSender.Expression_False(1541, 13471, 13568) || f_1541_13509_13533(module) < minimumRequiredPowerShellVersion))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 13467, 14010);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 13634, 13730);

                                    string
                                    errorMsg = f_1541_13652_13729(f_1541_13670_13718(), filePath)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 13764, 13921);

                                    var
                                    errorRecord = f_1541_13782_13920(f_1541_13798_13829(errorMsg), "Modules_InvalidPowerShellVersionInModuleManifest", ErrorCategory.InvalidArgument, _path)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 13955, 13979);

                                    f_1541_13955_13978(this, errorRecord);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 13467, 14010);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 13011, 14037);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 5570, 14060);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1541, 14097, 14221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 14145, 14202);

                        f_1541_14145_14152().ModuleBeingProcessed = _origModuleBeingProcessed;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1541, 14097, 14221);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 14241, 14269);

                    DirectoryInfo
                    parent = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 14331, 14370);

                        parent = f_1541_14340_14369(filePath);
                    }
                    catch (IOException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1541, 14407, 14430);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1541, 14407, 14430);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1541, 14448, 14487);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1541, 14448, 14487);
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1541, 14505, 14534);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1541, 14505, 14534);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 14554, 14570);

                    Version
                    version
                    = default(Version);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 14588, 15327) || true) && (parent != null && (DynAbs.Tracing.TraceSender.Expression_True(1541, 14592, 14652) && f_1541_14610_14652(f_1541_14627_14638(parent), out version)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 14588, 15327);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 14694, 15227) || true) && (!f_1541_14699_14729(version, f_1541_14714_14728(module)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 14694, 15227);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 14779, 14906);

                            string
                            message = f_1541_14796_14905(f_1541_14814_14850(), filePath, f_1541_14862_14887(f_1541_14862_14876(module)), f_1541_14889_14904(parent))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 14932, 14981);

                            var
                            ioe = f_1541_14942_14980(message)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 15007, 15152);

                            ErrorRecord
                            er = f_1541_15024_15151(ioe, "Modules_InvalidModuleManifestVersion", ErrorCategory.InvalidArgument, _path)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 15178, 15204);

                            f_1541_15178_15203(this, er);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 14694, 15227);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 15251, 15308);

                        f_1541_15251_15307(this, f_1541_15264_15306());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 14588, 15327);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 15347, 15446) || true) && (module != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 15347, 15446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 15407, 15427);

                        f_1541_15407_15426(this, module);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 15347, 15446);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 4577, 15892);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 4577, 15892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 15512, 15592);

                    string
                    message = f_1541_15529_15591(f_1541_15547_15580(), filePath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 15610, 15681);

                    InvalidOperationException
                    ioe = f_1541_15642_15680(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 15699, 15833);

                    ErrorRecord
                    er = f_1541_15716_15832(ioe, "Modules_InvalidModuleManifestPath", ErrorCategory.InvalidArgument, _path)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 15851, 15877);

                    f_1541_15851_15876(this, er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 4577, 15892);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1541, 2011, 15903);

                System.Management.Automation.ExecutionContext
                f_1541_2203_2210()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 2203, 2210);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1541_2203_2229(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 2203, 2229);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1541_2247_2254()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 2247, 2254);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1541_2247_2268(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 2247, 2268);
                    return return_v;
                }


                string
                f_1541_2247_2279(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 2247, 2279);
                    return return_v;
                }


                bool
                f_1541_2203_2280(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.IsProviderLoaded(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 2203, 2280);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1541_2359_2371()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 2359, 2371);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1541_2359_2376(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 2359, 2376);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1541_2359_2431(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetResolvedProviderPathFromPSPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 2359, 2431);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1541_2526_2550()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 2526, 2550);
                    return return_v;
                }


                int
                f_1541_2573_2593(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 2573, 2593);
                    return 0;
                }


                string
                f_1541_2739_2761()
                {
                    var return_v = Modules.ModuleNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 2739, 2761);
                    return return_v;
                }


                string
                f_1541_2721_2769(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 2721, 2769);
                    return return_v;
                }


                System.IO.FileNotFoundException
                f_1541_2816_2850(string
                message)
                {
                    var return_v = new System.IO.FileNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 2816, 2850);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_2886_2995(System.IO.FileNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 2886, 2995);
                    return return_v;
                }


                int
                f_1541_3014_3028(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 3014, 3028);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1541_3212_3224(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 3212, 3224);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1541_3212_3238(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 3212, 3238);
                    return return_v;
                }


                string
                f_1541_3212_3249(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 3212, 3249);
                    return return_v;
                }


                bool
                f_1541_3192_3250(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 3192, 3250);
                    return return_v;
                }


                string
                f_1541_3476_3503()
                {
                    var return_v = ParserStrings.FileOpenError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 3476, 3503);
                    return return_v;
                }


                string
                f_1541_3505_3522(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 3505, 3522);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1541_3358_3523(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 3358, 3523);
                    return return_v;
                }


                int
                f_1541_3637_3652(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 3637, 3652);
                    return return_v;
                }


                string
                f_1541_3725_3747()
                {
                    var return_v = Modules.ModuleNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 3725, 3747);
                    return return_v;
                }


                string
                f_1541_3707_3755(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 3707, 3755);
                    return return_v;
                }


                System.IO.FileNotFoundException
                f_1541_3802_3836(string
                message)
                {
                    var return_v = new System.IO.FileNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 3802, 3836);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_3872_3981(System.IO.FileNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 3872, 3981);
                    return return_v;
                }


                int
                f_1541_4000_4014(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 4000, 4014);
                    return 0;
                }


                int
                f_1541_4075_4090(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 4075, 4090);
                    return return_v;
                }


                string
                f_1541_4356_4383()
                {
                    var return_v = ParserStrings.AmbiguousPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 4356, 4383);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1541_4234_4384(System.Collections.ObjectModel.Collection<string>
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 4234, 4384);
                    return return_v;
                }


                string
                f_1541_4434_4446(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 4434, 4446);
                    return return_v;
                }


                string?
                f_1541_4525_4562(string
                path)
                {
                    var return_v = System.IO.Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 4525, 4562);
                    return return_v;
                }


                bool
                f_1541_4581_4671(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 4581, 4671);
                    return return_v;
                }


                System.Management.Automation.ExternalScriptInfo
                f_1541_4819_4872(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                fileName, out string
                scriptName, bool
                checkExecutionPolicy)
                {
                    var return_v = this_param.GetScriptInfoForFile(fileName, out scriptName, checkExecutionPolicy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 4819, 4872);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1541_5127_5134()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 5127, 5134);
                    return return_v;
                }


                string
                f_1541_5127_5155(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ModuleBeingProcessed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 5127, 5155);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1541_5227_5545(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ExternalScriptInfo
                scriptInfo, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, System.Version
                minimumVersion, System.Version
                maximumVersion, System.Version
                requiredVersion, System.Guid?
                requiredModuleGuid)
                {
                    var return_v = this_param.LoadModuleManifest(scriptInfo, manifestProcessingFlags, minimumVersion, maximumVersion, requiredVersion, requiredModuleGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 5227, 5545);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1541_5694_5719(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RequiredAssemblies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 5694, 5719);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1541_5827_5852(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RequiredAssemblies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 5827, 5852);
                    return return_v;
                }


                bool
                f_1541_5923_5976(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                path, System.Management.Automation.PSModuleInfo
                module, bool
                verifyPathScope)
                {
                    var return_v = this_param.IsValidFilePath(path, module, verifyPathScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 5923, 5976);
                    return return_v;
                }


                bool
                f_1541_5981_6023(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                assemblyName)
                {
                    var return_v = this_param.IsValidGacAssembly(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 5981, 6023);
                    return return_v;
                }


                string
                f_1541_6133_6182()
                {
                    var return_v = Modules.InvalidRequiredAssembliesInModuleManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 6133, 6182);
                    return return_v;
                }


                string
                f_1541_6115_6217(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 6115, 6217);
                    return return_v;
                }


                System.IO.DirectoryNotFoundException
                f_1541_6290_6330(string
                message)
                {
                    var return_v = new System.IO.DirectoryNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 6290, 6330);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_6274_6466(System.IO.DirectoryNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 6274, 6466);
                    return return_v;
                }


                int
                f_1541_6505_6528(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 6505, 6528);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1541_5827_5852_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 5827, 5852);
                    return return_v;
                }


                bool
                f_1541_6655_6681(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.PSModuleInfo
                module)
                {
                    var return_v = this_param.HasValidRootModule(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 6655, 6681);
                    return return_v;
                }


                string
                f_1541_6775_6804()
                {
                    var return_v = Modules.InvalidModuleManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 6775, 6804);
                    return return_v;
                }


                string
                f_1541_6806_6823(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RootModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 6806, 6823);
                    return return_v;
                }


                string
                f_1541_6757_6834(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 6757, 6834);
                    return return_v;
                }


                System.ArgumentException
                f_1541_6899_6930(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 6899, 6930);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_6883_7051(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 6883, 7051);
                    return return_v;
                }


                int
                f_1541_7082_7105(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 7082, 7105);
                    return 0;
                }


                bool
                f_1541_7321_7482(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ExternalScriptInfo
                scriptInfo, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out System.Collections.Hashtable
                data, out System.Collections.Hashtable
                localizedData, ref bool
                containedErrors)
                {
                    var return_v = this_param.LoadModuleManifestData(scriptInfo, manifestProcessingFlags, out data, out localizedData, ref containedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 7321, 7482);
                    return return_v;
                }


                string
                f_1541_7595_7610(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 7595, 7610);
                    return return_v;
                }


                bool
                f_1541_7571_7724(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Collections.Hashtable
                data, string
                moduleManifestPath, string
                key, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out Microsoft.PowerShell.Commands.ModuleSpecification[]
                result)
                {
                    var return_v = this_param.GetScalarFromData<Microsoft.PowerShell.Commands.ModuleSpecification[]>(data, moduleManifestPath, key, manifestProcessingFlags, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 7571, 7724);
                    return return_v;
                }


                string
                f_1541_7979_7996(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 7979, 7996);
                    return return_v;
                }


                bool
                f_1541_7963_8011(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                path, System.Management.Automation.PSModuleInfo
                module, bool
                verifyPathScope)
                {
                    var return_v = this_param.IsValidFilePath(path, module, verifyPathScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 7963, 8011);
                    return return_v;
                }


                string
                f_1541_8069_8086(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 8069, 8086);
                    return return_v;
                }


                bool
                f_1541_8053_8148(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                path, System.Management.Automation.PSModuleInfo
                module, bool
                verifyPathScope)
                {
                    var return_v = this_param.IsValidFilePath(path, module, verifyPathScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 8053, 8148);
                    return return_v;
                }


                string
                f_1541_8206_8223(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 8206, 8223);
                    return return_v;
                }


                bool
                f_1541_8190_8287(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                path, System.Management.Automation.PSModuleInfo
                module, bool
                verifyPathScope)
                {
                    var return_v = this_param.IsValidFilePath(path, module, verifyPathScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 8190, 8287);
                    return return_v;
                }


                string
                f_1541_8345_8362(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 8345, 8362);
                    return return_v;
                }


                bool
                f_1541_8329_8426(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                path, System.Management.Automation.PSModuleInfo
                module, bool
                verifyPathScope)
                {
                    var return_v = this_param.IsValidFilePath(path, module, verifyPathScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 8329, 8426);
                    return return_v;
                }


                string
                f_1541_8484_8501(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 8484, 8501);
                    return return_v;
                }


                bool
                f_1541_8468_8563(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                path, System.Management.Automation.PSModuleInfo
                module, bool
                verifyPathScope)
                {
                    var return_v = this_param.IsValidFilePath(path, module, verifyPathScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 8468, 8563);
                    return return_v;
                }


                string
                f_1541_8624_8641(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 8624, 8641);
                    return return_v;
                }


                bool
                f_1541_8605_8642(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                assemblyName)
                {
                    var return_v = this_param.IsValidGacAssembly(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 8605, 8642);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                f_1541_8751_8785(Microsoft.PowerShell.Commands.ModuleSpecification
                requiredModule)
                {
                    var return_v = GetModuleIfAvailable(requiredModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 8751, 8785);
                    return return_v;
                }


                int
                f_1541_8833_8846(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 8833, 8846);
                    return return_v;
                }


                string
                f_1541_8964_9007()
                {
                    var return_v = Modules.InvalidNestedModuleinModuleManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 8964, 9007);
                    return return_v;
                }


                string
                f_1541_9009_9026(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 9009, 9026);
                    return return_v;
                }


                string
                f_1541_8946_9037(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 8946, 9037);
                    return return_v;
                }


                System.IO.DirectoryNotFoundException
                f_1541_9114_9154(string
                message)
                {
                    var return_v = new System.IO.DirectoryNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 9114, 9154);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_9098_9288(System.IO.DirectoryNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 9098, 9288);
                    return return_v;
                }


                int
                f_1541_9331_9354(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 9331, 9354);
                    return 0;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1541_7879_7892_I(Microsoft.PowerShell.Commands.ModuleSpecification[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 7879, 7892);
                    return return_v;
                }


                string
                f_1541_9603_9618(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 9603, 9618);
                    return return_v;
                }


                bool
                f_1541_9579_9736(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Collections.Hashtable
                data, string
                moduleManifestPath, string
                key, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out Microsoft.PowerShell.Commands.ModuleSpecification[]
                result)
                {
                    var return_v = this_param.GetScalarFromData<Microsoft.PowerShell.Commands.ModuleSpecification[]>(data, moduleManifestPath, key, manifestProcessingFlags, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 9579, 9736);
                    return return_v;
                }


                string
                f_1541_10008_10027(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 10008, 10027);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1541_9990_10057(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string[]
                names, bool
                all, bool
                refresh)
                {
                    var return_v = this_param.GetModule(names, all: all, refresh: refresh);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 9990, 10057);
                    return return_v;
                }


                int
                f_1541_10096_10109(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 10096, 10109);
                    return return_v;
                }


                string
                f_1541_10224_10270()
                {
                    var return_v = Modules.InvalidRequiredModulesinModuleManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 10224, 10270);
                    return return_v;
                }


                string
                f_1541_10272_10291(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 10272, 10291);
                    return return_v;
                }


                string
                f_1541_10206_10302(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 10206, 10302);
                    return return_v;
                }


                System.IO.DirectoryNotFoundException
                f_1541_10375_10415(string
                message)
                {
                    var return_v = new System.IO.DirectoryNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 10375, 10415);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_10359_10548(System.IO.DirectoryNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 10359, 10548);
                    return return_v;
                }


                int
                f_1541_10587_10610(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 10587, 10610);
                    return 0;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1541_9895_9910_I(Microsoft.PowerShell.Commands.ModuleSpecification[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 9895, 9910);
                    return return_v;
                }


                string
                f_1541_10805_10820(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 10805, 10820);
                    return return_v;
                }


                bool
                f_1541_10781_10929(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Collections.Hashtable
                data, string
                moduleManifestPath, string
                key, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out string[]
                result)
                {
                    var return_v = this_param.GetScalarFromData<string[]>(data, moduleManifestPath, key, manifestProcessingFlags, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 10781, 10929);
                    return return_v;
                }


                bool
                f_1541_11155_11198(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                path, System.Management.Automation.PSModuleInfo
                module, bool
                verifyPathScope)
                {
                    var return_v = this_param.IsValidFilePath(path, module, verifyPathScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 11155, 11198);
                    return return_v;
                }


                string
                f_1541_11308_11347()
                {
                    var return_v = Modules.InvalidFilePathinModuleManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 11308, 11347);
                    return return_v;
                }


                string
                f_1541_11290_11372(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 11290, 11372);
                    return return_v;
                }


                System.IO.DirectoryNotFoundException
                f_1541_11445_11485(string
                message)
                {
                    var return_v = new System.IO.DirectoryNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 11445, 11485);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_11429_11611(System.IO.DirectoryNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 11429, 11611);
                    return return_v;
                }


                int
                f_1541_11650_11673(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 11650, 11673);
                    return 0;
                }


                string[]
                f_1541_11071_11084_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 11071, 11084);
                    return return_v;
                }


                string
                f_1541_11885_11900(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 11885, 11900);
                    return return_v;
                }


                bool
                f_1541_11861_12015(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Collections.Hashtable
                data, string
                moduleManifestPath, string
                key, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out Microsoft.PowerShell.Commands.ModuleSpecification[]
                result)
                {
                    var return_v = this_param.GetScalarFromData<Microsoft.PowerShell.Commands.ModuleSpecification[]>(data, moduleManifestPath, key, manifestProcessingFlags, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 11861, 12015);
                    return return_v;
                }


                string
                f_1541_12293_12314(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 12293, 12314);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1541_12275_12344(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string[]
                names, bool
                all, bool
                refresh)
                {
                    var return_v = this_param.GetModule(names, all: all, refresh: refresh);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 12275, 12344);
                    return return_v;
                }


                int
                f_1541_12383_12396(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 12383, 12396);
                    return return_v;
                }


                string
                f_1541_12511_12552()
                {
                    var return_v = Modules.InvalidModuleListinModuleManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 12511, 12552);
                    return return_v;
                }


                string
                f_1541_12554_12575(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 12554, 12575);
                    return return_v;
                }


                string
                f_1541_12493_12586(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 12493, 12586);
                    return return_v;
                }


                System.IO.DirectoryNotFoundException
                f_1541_12659_12699(string
                message)
                {
                    var return_v = new System.IO.DirectoryNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 12659, 12699);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_12643_12827(System.IO.DirectoryNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 12643, 12827);
                    return return_v;
                }


                int
                f_1541_12866_12889(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 12866, 12889);
                    return 0;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1541_12178_12195_I(Microsoft.PowerShell.Commands.ModuleSpecification[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 12178, 12195);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1541_13015_13042(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.CompatiblePSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 13015, 13042);
                    return return_v;
                }


                bool
                f_1541_13015_13048(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Any<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 13015, 13048);
                    return return_v;
                }


                System.Version
                f_1541_13419_13436(int
                major, int
                minor)
                {
                    var return_v = new System.Version(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 13419, 13436);
                    return return_v;
                }


                System.Version
                f_1541_13472_13496(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.PowerShellVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 13472, 13496);
                    return return_v;
                }


                System.Version
                f_1541_13509_13533(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.PowerShellVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 13509, 13533);
                    return return_v;
                }


                string
                f_1541_13670_13718()
                {
                    var return_v = Modules.InvalidPowerShellVersionInModuleManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 13670, 13718);
                    return return_v;
                }


                string
                f_1541_13652_13729(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 13652, 13729);
                    return return_v;
                }


                System.ArgumentException
                f_1541_13798_13829(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 13798, 13829);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_13782_13920(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 13782, 13920);
                    return return_v;
                }


                int
                f_1541_13955_13978(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 13955, 13978);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1541_14145_14152()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 14145, 14152);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1541_14340_14369(string
                path)
                {
                    var return_v = Directory.GetParent(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 14340, 14369);
                    return return_v;
                }


                string
                f_1541_14627_14638(System.IO.DirectoryInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 14627, 14638);
                    return return_v;
                }


                bool
                f_1541_14610_14652(string
                input, out System.Version
                result)
                {
                    var return_v = Version.TryParse(input, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 14610, 14652);
                    return return_v;
                }


                System.Version
                f_1541_14714_14728(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 14714, 14728);
                    return return_v;
                }


                bool
                f_1541_14699_14729(System.Version
                this_param, System.Version
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 14699, 14729);
                    return return_v;
                }


                string
                f_1541_14814_14850()
                {
                    var return_v = Modules.InvalidModuleManifestVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 14814, 14850);
                    return return_v;
                }


                System.Version
                f_1541_14862_14876(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 14862, 14876);
                    return return_v;
                }


                string
                f_1541_14862_14887(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 14862, 14887);
                    return return_v;
                }


                string
                f_1541_14889_14904(System.IO.DirectoryInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 14889, 14904);
                    return return_v;
                }


                string
                f_1541_14796_14905(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 14796, 14905);
                    return return_v;
                }


                System.InvalidOperationException
                f_1541_14942_14980(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 14942, 14980);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_15024_15151(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 15024, 15151);
                    return return_v;
                }


                int
                f_1541_15178_15203(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 15178, 15203);
                    return 0;
                }


                string
                f_1541_15264_15306()
                {
                    var return_v = Modules.ModuleVersionEqualsToVersionFolder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 15264, 15306);
                    return return_v;
                }


                int
                f_1541_15251_15307(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 15251, 15307);
                    return 0;
                }


                int
                f_1541_15407_15426(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 15407, 15426);
                    return 0;
                }


                string
                f_1541_15547_15580()
                {
                    var return_v = Modules.InvalidModuleManifestPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 15547, 15580);
                    return return_v;
                }


                string
                f_1541_15529_15591(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 15529, 15591);
                    return return_v;
                }


                System.InvalidOperationException
                f_1541_15642_15680(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 15642, 15680);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_15716_15832(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 15716, 15832);
                    return return_v;
                }


                int
                f_1541_15851_15876(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 15851, 15876);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1541, 2011, 15903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1541, 2011, 15903);
            }
        }

        private static readonly IReadOnlyList<string> s_validRootModuleExtensions;

        private bool HasValidRootModule(PSModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1541, 16808, 18211);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 16937, 17041) || true) && (f_1541_16941_16980(f_1541_16962_16979(module)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 16937, 17041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 17014, 17026);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 16937, 17041);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 17100, 17202) || true) && (f_1541_17104_17141(this, f_1541_17123_17140(module)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 17100, 17202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 17175, 17187);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 17100, 17202);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 17255, 17325);

                string
                rootModuleExt = f_1541_17278_17324(f_1541_17306_17323(module))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 17339, 17826) || true) && (!f_1541_17344_17379(rootModuleExt))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 17339, 17826);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 17490, 17654) || true) && (!f_1541_17495_17580(s_validRootModuleExtensions, rootModuleExt, f_1541_17547_17579()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 17490, 17654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 17622, 17635);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 17490, 17654);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 17738, 17811);

                    return f_1541_17745_17810(this, f_1541_17761_17778(module), module, verifyPathScope: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 17339, 17826);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 17912, 18171);
                    foreach (string extension in f_1541_17941_17968_I(s_validRootModuleExtensions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 17912, 18171);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 18002, 18156) || true) && (f_1541_18006_18083(this, f_1541_18022_18039(module) + extension, module, verifyPathScope: true))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 18002, 18156);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 18125, 18137);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 18002, 18156);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 17912, 18171);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1541, 1, 260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1541, 1, 260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 18187, 18200);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1541, 16808, 18211);

                string
                f_1541_16962_16979(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RootModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 16962, 16979);
                    return return_v;
                }


                bool
                f_1541_16941_16980(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 16941, 16980);
                    return return_v;
                }


                string
                f_1541_17123_17140(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RootModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 17123, 17140);
                    return return_v;
                }


                bool
                f_1541_17104_17141(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                assemblyName)
                {
                    var return_v = this_param.IsValidGacAssembly(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 17104, 17141);
                    return return_v;
                }


                string
                f_1541_17306_17323(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RootModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 17306, 17323);
                    return return_v;
                }


                string?
                f_1541_17278_17324(string
                path)
                {
                    var return_v = System.IO.Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 17278, 17324);
                    return return_v;
                }


                bool
                f_1541_17344_17379(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 17344, 17379);
                    return return_v;
                }


                System.StringComparer
                f_1541_17547_17579()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 17547, 17579);
                    return return_v;
                }


                bool
                f_1541_17495_17580(System.Collections.Generic.IReadOnlyList<string>
                source, string
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>(value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 17495, 17580);
                    return return_v;
                }


                string
                f_1541_17761_17778(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RootModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 17761, 17778);
                    return return_v;
                }


                bool
                f_1541_17745_17810(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                path, System.Management.Automation.PSModuleInfo
                module, bool
                verifyPathScope)
                {
                    var return_v = this_param.IsValidFilePath(path, module, verifyPathScope: verifyPathScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 17745, 17810);
                    return return_v;
                }


                string
                f_1541_18022_18039(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.RootModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 18022, 18039);
                    return return_v;
                }


                bool
                f_1541_18006_18083(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, string
                path, System.Management.Automation.PSModuleInfo
                module, bool
                verifyPathScope)
                {
                    var return_v = this_param.IsValidFilePath(path, module, verifyPathScope: verifyPathScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 18006, 18083);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<string>
                f_1541_17941_17968_I(System.Collections.Generic.IReadOnlyList<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 17941, 17968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1541, 16808, 18211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1541, 16808, 18211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsValidFilePath(string path, PSModuleInfo module, bool verifyPathScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1541, 18486, 20643);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 18631, 18943) || true) && (!f_1541_18636_18669(path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 18631, 18943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 18824, 18924);

                        path = f_1541_18831_18923(f_1541_18858_18875(module) + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (System.IO.Path.DirectorySeparatorChar).ToString(), 1541, 18878, 18915) + path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 18631, 18943);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 19038, 19105);

                    CmdletProviderContext
                    cmdContext = f_1541_19073_19104(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 19123, 19220);

                    Collection<PathInfo>
                    pathInfos = f_1541_19156_19219(f_1541_19156_19173(f_1541_19156_19168()), path, cmdContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 19238, 19674) || true) && (f_1541_19242_19257(pathInfos) != 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 19238, 19674);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 19304, 19380);

                        string
                        message = f_1541_19321_19379(f_1541_19339_19372(), path)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 19402, 19473);

                        InvalidOperationException
                        ioe = f_1541_19434_19472(message)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 19495, 19607);

                        ErrorRecord
                        er = f_1541_19512_19606(ioe, "Modules_InvalidModuleManifestPath", ErrorCategory.InvalidArgument, path)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 19629, 19655);

                        f_1541_19629_19654(this, er);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 19238, 19674);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 19694, 19719);

                    path = f_1541_19701_19718(f_1541_19701_19713(pathInfos, 0));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 19802, 19925) || true) && (!f_1541_19807_19824(path) && (DynAbs.Tracing.TraceSender.Expression_True(1541, 19806, 19851) && !f_1541_19829_19851(path)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 19802, 19925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 19893, 19906);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 19802, 19925);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 20017, 20241) || true) && (verifyPathScope && (DynAbs.Tracing.TraceSender.Expression_True(1541, 20021, 20167) && !f_1541_20041_20167(f_1541_20041_20073(path), f_1541_20085_20130(f_1541_20112_20129(module)), StringComparison.OrdinalIgnoreCase)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 20017, 20241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 20209, 20222);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 20017, 20241);
                    }
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1541, 20270, 20604);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 20330, 20589) || true) && (exception is ArgumentException || (DynAbs.Tracing.TraceSender.Expression_False(1541, 20334, 20402) || exception is ArgumentNullException) || (DynAbs.Tracing.TraceSender.Expression_False(1541, 20334, 20440) || exception is NotSupportedException) || (DynAbs.Tracing.TraceSender.Expression_False(1541, 20334, 20477) || exception is PathTooLongException) || (DynAbs.Tracing.TraceSender.Expression_False(1541, 20334, 20515) || exception is ItemNotFoundException))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 20330, 20589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 20557, 20570);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 20330, 20589);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1541, 20270, 20604);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 20620, 20632);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1541, 18486, 20643);

                bool
                f_1541_18636_18669(string
                path)
                {
                    var return_v = System.IO.Path.IsPathRooted(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 18636, 18669);
                    return return_v;
                }


                string
                f_1541_18858_18875(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 18858, 18875);
                    return return_v;
                }


                string
                f_1541_18831_18923(string
                path)
                {
                    var return_v = System.IO.Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 18831, 18923);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1541_19073_19104(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                command)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext((System.Management.Automation.Cmdlet)command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 19073, 19104);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1541_19156_19168()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 19156, 19168);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1541_19156_19173(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 19156, 19173);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1541_19156_19219(System.Management.Automation.PathIntrinsics
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetResolvedPSPathFromPSPath(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 19156, 19219);
                    return return_v;
                }


                int
                f_1541_19242_19257(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 19242, 19257);
                    return return_v;
                }


                string
                f_1541_19339_19372()
                {
                    var return_v = Modules.InvalidModuleManifestPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 19339, 19372);
                    return return_v;
                }


                string
                f_1541_19321_19379(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 19321, 19379);
                    return return_v;
                }


                System.InvalidOperationException
                f_1541_19434_19472(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 19434, 19472);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1541_19512_19606(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 19512, 19606);
                    return return_v;
                }


                int
                f_1541_19629_19654(Microsoft.PowerShell.Commands.TestModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 19629, 19654);
                    return 0;
                }


                System.Management.Automation.PathInfo
                f_1541_19701_19713(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 19701, 19713);
                    return return_v;
                }


                string
                f_1541_19701_19718(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 19701, 19718);
                    return return_v;
                }


                bool
                f_1541_19807_19824(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 19807, 19824);
                    return return_v;
                }


                bool
                f_1541_19829_19851(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 19829, 19851);
                    return return_v;
                }


                string
                f_1541_20041_20073(string
                path)
                {
                    var return_v = System.IO.Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 20041, 20073);
                    return return_v;
                }


                string
                f_1541_20112_20129(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 20112, 20129);
                    return return_v;
                }


                string
                f_1541_20085_20130(string
                path)
                {
                    var return_v = System.IO.Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 20085, 20130);
                    return return_v;
                }


                bool
                f_1541_20041_20167(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 20041, 20167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1541, 18486, 20643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1541, 18486, 20643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsValidGacAssembly(string assemblyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1541, 20848, 22130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 20969, 21068);

                string
                gacPath = f_1541_20986_21037("windir") + "\\Microsoft.NET\\assembly"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 21082, 21117);

                string
                assemblyFile = assemblyName
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 21131, 21170);

                string
                ngenAssemblyFile = assemblyName
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 21184, 21515) || true) && (!f_1541_21189_21292(assemblyName, StringLiterals.PowerShellILAssemblyExtension, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 21184, 21515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 21326, 21401);

                    assemblyFile = assemblyName + StringLiterals.PowerShellILAssemblyExtension;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 21419, 21500);

                    ngenAssemblyFile = assemblyName + StringLiterals.PowerShellNgenAssemblyExtension;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 21184, 21515);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 21567, 21653);

                    var
                    allFiles = f_1541_21582_21652(gacPath, assemblyFile, SearchOption.AllDirectories)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 21673, 21988) || true) && (f_1541_21677_21692(allFiles) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 21673, 21988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 21739, 21833);

                        var
                        allNgenFiles = f_1541_21758_21832(gacPath, ngenAssemblyFile, SearchOption.AllDirectories)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 21855, 21969) || true) && (f_1541_21859_21878(allNgenFiles) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1541, 21855, 21969);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 21933, 21946);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 21855, 21969);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1541, 21673, 21988);
                    }
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1541, 22017, 22083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 22055, 22068);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1541, 22017, 22083);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 22099, 22111);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1541, 20848, 22130);

                string?
                f_1541_20986_21037(string
                variable)
                {
                    var return_v = System.Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 20986, 21037);
                    return return_v;
                }


                bool
                f_1541_21189_21292(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 21189, 21292);
                    return return_v;
                }


                string[]
                f_1541_21582_21652(string
                path, string
                searchPattern, System.IO.SearchOption
                searchOption)
                {
                    var return_v = Directory.GetFiles(path, searchPattern, searchOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 21582, 21652);
                    return return_v;
                }


                int
                f_1541_21677_21692(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 21677, 21692);
                    return return_v;
                }


                string[]
                f_1541_21758_21832(string
                path, string
                searchPattern, System.IO.SearchOption
                searchOption)
                {
                    var return_v = Directory.GetFiles(path, searchPattern, searchOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 21758, 21832);
                    return return_v;
                }


                int
                f_1541_21859_21878(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1541, 21859, 21878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1541, 20848, 22130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1541, 20848, 22130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TestModuleManifestCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1541, 605, 22137);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1541, 16042, 16259);
            s_validRootModuleExtensions = f_1541_16072_16259(f_1541_16072_16235(ModuleIntrinsics.PSModuleExtensions
            , ext => !string.Equals(ext, StringLiterals.PowerShellDataFileExtension, StringComparison.OrdinalIgnoreCase)));
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1541, 605, 22137);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1541, 605, 22137);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1541, 605, 22137);

        static System.Collections.Generic.IEnumerable<string>
        f_1541_16072_16235(string[]
        source, System.Func<string, bool>
        predicate)
        {
            var return_v = source.Where<string>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 16072, 16235);
            return return_v;
        }


        static string[]
        f_1541_16072_16259(System.Collections.Generic.IEnumerable<string>
        source)
        {
            var return_v = source.ToArray<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1541, 16072, 16259);
            return return_v;
        }

    }

}
