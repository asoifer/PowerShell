// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Reflection;
using System.Text;
using Dbg = System.Management.Automation.Diagnostics;

//
// Now define the set of commands for manipulating modules.
//

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsCommon.New, "ModuleManifest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Low,
            HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096487")]
    [OutputType(typeof(string))]
    public sealed class NewModuleManifestCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string Path
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 1212, 1233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 1218, 1231);

                    return _path;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 1212, 1233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 1116, 1282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 1116, 1282);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 1249, 1271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 1255, 1269);

                    _path = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 1249, 1271);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 1116, 1282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 1116, 1282);
                }
            }
        }

        private string _path;

        [Parameter]
        [AllowEmptyCollection]
        public object[] NestedModules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 1545, 1575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 1551, 1573);

                    return _nestedModules;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 1545, 1575);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 1438, 1633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 1438, 1633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 1591, 1622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 1597, 1620);

                    _nestedModules = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 1591, 1622);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 1438, 1633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 1438, 1633);
                }
            }
        }

        private object[] _nestedModules;

        [Parameter]
        public Guid Guid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 1855, 1876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 1861, 1874);

                    return _guid;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 1855, 1876);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 1793, 1925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 1793, 1925);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 1892, 1914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 1898, 1912);

                    _guid = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 1892, 1914);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 1793, 1925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 1793, 1925);
                }
            }
        }

        private Guid _guid;

        [Parameter]
        [AllowEmptyString]
        public string Author
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 2187, 2210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 2193, 2208);

                    return _author;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 2187, 2210);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 2093, 2261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 2093, 2261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 2226, 2250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 2232, 2248);

                    _author = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 2226, 2250);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 2093, 2261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 2093, 2261);
                }
            }
        }

        private string _author;

        [Parameter]
        [AllowEmptyString]
        public string CompanyName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 2514, 2542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 2520, 2540);

                    return _companyName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 2514, 2542);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 2415, 2598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 2415, 2598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 2558, 2587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 2564, 2585);

                    _companyName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 2558, 2587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 2415, 2598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 2415, 2598);
                }
            }
        }

        private string _companyName;

        [Parameter]
        [AllowEmptyString]
        public string Copyright
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 2880, 2906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 2886, 2904);

                    return _copyright;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 2880, 2906);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 2783, 2960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 2783, 2960);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 2922, 2949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 2928, 2947);

                    _copyright = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 2922, 2949);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 2783, 2960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 2783, 2960);
                }
            }
        }

        private string _copyright;

        [Parameter]
        [AllowEmptyString]
        [Alias("ModuleToProcess")]
        public string RootModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 3234, 3261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 3240, 3259);

                    return _rootModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 3234, 3261);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 3100, 3316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 3100, 3316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 3277, 3305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 3283, 3303);

                    _rootModule = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 3277, 3305);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 3100, 3316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 3100, 3316);
                }
            }
        }

        private string _rootModule;

        [Parameter]
        [ValidateNotNull]
        public Version ModuleVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 3568, 3598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 3574, 3596);

                    return _moduleVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 3568, 3598);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 3467, 3656);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 3467, 3656);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 3614, 3645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 3620, 3643);

                    _moduleVersion = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 3614, 3645);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 3467, 3656);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 3467, 3656);
                }
            }
        }

        private Version _moduleVersion;

        [Parameter]
        [AllowEmptyString]
        public string Description
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 3930, 3958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 3936, 3956);

                    return _description;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 3930, 3958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 3831, 4014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 3831, 4014);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 3974, 4003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 3980, 4001);

                    _description = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 3974, 4003);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 3831, 4014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 3831, 4014);
                }
            }
        }

        private string _description;

        [Parameter]
        public ProcessorArchitecture ProcessorArchitecture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 4286, 4393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 4292, 4391);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1536, 4299, 4330) || ((f_1536_4299_4330(_processorArchitecture) && DynAbs.Tracing.TraceSender.Conditional_F2(1536, 4333, 4361)) || DynAbs.Tracing.TraceSender.Conditional_F3(1536, 4364, 4390))) ? f_1536_4333_4361(_processorArchitecture) : ProcessorArchitecture.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 4286, 4393);

                    bool
                    f_1536_4299_4330(System.Reflection.ProcessorArchitecture?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 4299, 4330);
                        return return_v;
                    }


                    System.Reflection.ProcessorArchitecture
                    f_1536_4333_4361(System.Reflection.ProcessorArchitecture?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 4333, 4361);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 4190, 4459);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 4190, 4459);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 4409, 4448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 4415, 4446);

                    _processorArchitecture = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 4409, 4448);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 4190, 4459);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 4190, 4459);
                }
            }
        }

        private ProcessorArchitecture? _processorArchitecture;

        [Parameter]
        public Version PowerShellVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 4743, 4777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 4749, 4775);

                    return _powerShellVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 4743, 4777);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 4665, 4839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 4665, 4839);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 4793, 4828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 4799, 4826);

                    _powerShellVersion = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 4793, 4828);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 4665, 4839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 4665, 4839);
                }
            }
        }

        private Version _powerShellVersion;

        [Parameter]
        public Version ClrVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 5089, 5116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 5095, 5114);

                    return _ClrVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 5089, 5116);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 5018, 5171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 5018, 5171);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 5132, 5160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 5138, 5158);

                    _ClrVersion = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 5132, 5160);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 5018, 5171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 5018, 5171);
                }
            }
        }

        private Version _ClrVersion;

        [Parameter]
        public Version DotNetFrameworkVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 5440, 5479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 5446, 5477);

                    return _DotNetFrameworkVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 5440, 5479);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 5357, 5546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 5357, 5546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 5495, 5535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 5501, 5533);

                    _DotNetFrameworkVersion = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 5495, 5535);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 5357, 5546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 5357, 5546);
                }
            }
        }

        private Version _DotNetFrameworkVersion;

        [Parameter]
        public string PowerShellHostName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 5820, 5855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 5826, 5853);

                    return _PowerShellHostName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 5820, 5855);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 5742, 5918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 5742, 5918);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 5871, 5907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 5877, 5905);

                    _PowerShellHostName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 5871, 5907);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 5742, 5918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 5742, 5918);
                }
            }
        }

        private string _PowerShellHostName;

        [Parameter]
        public Version PowerShellHostVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 6194, 6232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 6200, 6230);

                    return _PowerShellHostVersion;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 6194, 6232);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 6112, 6298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 6112, 6298);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 6248, 6287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 6254, 6285);

                    _PowerShellHostVersion = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 6248, 6287);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 6112, 6298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 6112, 6298);
                }
            }
        }

        private Version _PowerShellHostVersion;

        [Parameter]
        [ArgumentTypeConverter(typeof(ModuleSpecification[]))]
        public object[] RequiredModules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 6623, 6655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 6629, 6653);

                    return _requiredModules;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 6623, 6655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 6482, 6715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 6482, 6715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 6671, 6704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 6677, 6702);

                    _requiredModules = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 6671, 6704);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 6482, 6715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 6482, 6715);
                }
            }
        }

        private object[] _requiredModules;

        [Parameter]
        [AllowEmptyCollection]
        public string[] TypesToProcess
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 6994, 7016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 7000, 7014);

                    return _types;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 6994, 7016);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 6886, 7066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 6886, 7066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 7032, 7055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 7038, 7053);

                    _types = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 7032, 7055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 6886, 7066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 6886, 7066);
                }
            }
        }

        private string[] _types;

        [Parameter]
        [AllowEmptyCollection]
        public string[] FormatsToProcess
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 7339, 7363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 7345, 7361);

                    return _formats;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 7339, 7363);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 7229, 7415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 7229, 7415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 7379, 7404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 7385, 7402);

                    _formats = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 7379, 7404);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 7229, 7415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 7229, 7415);
                }
            }
        }

        private string[] _formats;

        [Parameter]
        [AllowEmptyCollection]
        public string[] ScriptsToProcess
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 7733, 7757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 7739, 7755);

                    return _scripts;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 7733, 7757);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 7623, 7809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 7623, 7809);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 7773, 7798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 7779, 7796);

                    _scripts = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 7773, 7798);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 7623, 7809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 7623, 7809);
                }
            }
        }

        private string[] _scripts;

        [Parameter]
        [AllowEmptyCollection]
        public string[] RequiredAssemblies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 8092, 8127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 8098, 8125);

                    return _requiredAssemblies;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 8092, 8127);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 7980, 8190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 7980, 8190);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 8143, 8179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 8149, 8177);

                    _requiredAssemblies = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 8143, 8179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 7980, 8190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 7980, 8190);
                }
            }
        }

        private string[] _requiredAssemblies;

        [Parameter]
        [AllowEmptyCollection]
        public string[] FileList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 8468, 8494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 8474, 8492);

                    return _miscFiles;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 8468, 8494);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 8366, 8548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 8366, 8548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 8510, 8537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 8516, 8535);

                    _miscFiles = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 8510, 8537);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 8366, 8548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 8366, 8548);
                }
            }
        }

        private string[] _miscFiles;

        [Parameter]
        [AllowEmptyCollection]
        [ArgumentTypeConverter(typeof(ModuleSpecification[]))]
        public object[] ModuleList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 9024, 9051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 9030, 9049);

                    return _moduleList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 9024, 9051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 8856, 9106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 8856, 9106);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 9067, 9095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 9073, 9093);

                    _moduleList = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 9067, 9095);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 8856, 9106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 8856, 9106);
                }
            }
        }

        private object[] _moduleList;

        [Parameter]
        [AllowEmptyCollection]
        public string[] FunctionsToExport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 9387, 9421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 9393, 9419);

                    return _exportedFunctions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 9387, 9421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 9276, 9483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 9276, 9483);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 9437, 9472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 9443, 9470);

                    _exportedFunctions = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 9437, 9472);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 9276, 9483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 9276, 9483);
                }
            }
        }

        private string[] _exportedFunctions;

        [Parameter]
        [AllowEmptyCollection]
        public string[] AliasesToExport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 9767, 9799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 9773, 9797);

                    return _exportedAliases;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 9767, 9799);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 9658, 9859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 9658, 9859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 9815, 9848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 9821, 9846);

                    _exportedAliases = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 9815, 9848);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 9658, 9859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 9658, 9859);
                }
            }
        }

        private string[] _exportedAliases;

        [Parameter]
        [AllowEmptyCollection]
        public string[] VariablesToExport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 10145, 10179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 10151, 10177);

                    return _exportedVariables;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 10145, 10179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 10034, 10241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 10034, 10241);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 10195, 10230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 10201, 10228);

                    _exportedVariables = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 10195, 10230);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 10034, 10241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 10034, 10241);
                }
            }
        }

        private string[] _exportedVariables;

        [Parameter]
        [AllowEmptyCollection]
        public string[] CmdletsToExport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 10548, 10580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 10554, 10578);

                    return _exportedCmdlets;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 10548, 10580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 10439, 10640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 10439, 10640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 10596, 10629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 10602, 10627);

                    _exportedCmdlets = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 10596, 10629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 10439, 10640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 10439, 10640);
                }
            }
        }

        private string[] _exportedCmdlets;

        [Parameter]
        [AllowEmptyCollection]
        public string[] DscResourcesToExport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 10933, 10970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 10939, 10968);

                    return _dscResourcesToExport;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 10933, 10970);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 10819, 11035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 10819, 11035);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 10986, 11024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 10992, 11022);

                    _dscResourcesToExport = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 10986, 11024);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 10819, 11035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 10819, 11035);
                }
            }
        }

        private string[] _dscResourcesToExport;

        [Parameter]
        [AllowEmptyCollection]
        [ValidateSet("Desktop", "Core")]
        public string[] CompatiblePSEditions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 11369, 11406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 11375, 11404);

                    return _compatiblePSEditions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 11369, 11406);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 11213, 11471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 11213, 11471);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 11422, 11460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 11428, 11458);

                    _compatiblePSEditions = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 11422, 11460);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 11213, 11471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 11213, 11471);
                }
            }
        }

        private string[] _compatiblePSEditions;

        [Parameter(Mandatory = false)]
        [AllowNull]
        public object PrivateData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 11757, 11785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 11763, 11783);

                    return _privateData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 11757, 11785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 11646, 11841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 11646, 11841);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 11801, 11830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 11807, 11828);

                    _privateData = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 11801, 11830);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 11646, 11841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 11646, 11841);
                }
            }
        }

        private object _privateData;

        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty]
        public string[] Tags { get; set; }

        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty]
        public Uri ProjectUri { get; set; }

        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty]
        public Uri LicenseUri { get; set; }

        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty]
        public Uri IconUri { get; set; }

        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty]
        public string ReleaseNotes { get; set; }

        [Parameter]
        [ValidateNotNullOrEmpty]
        public string Prerelease { get; set; }

        [Parameter]
        public SwitchParameter RequireLicenseAcceptance { get; set; }

        [Parameter]
        [ValidateNotNullOrEmpty]
        public string[] ExternalModuleDependencies { get; set; }

        [Parameter]
        [AllowNull]
        public string HelpInfoUri
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 13823, 13851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 13829, 13849);

                    return _helpInfoUri;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 13823, 13851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 13731, 13907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 13731, 13907);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 13867, 13896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 13873, 13894);

                    _helpInfoUri = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 13867, 13896);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 13731, 13907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 13731, 13907);
                }
            }
        }

        private string _helpInfoUri;

        [Parameter]
        public SwitchParameter PassThru
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 14176, 14218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 14182, 14216);

                    return (SwitchParameter)_passThru;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 14176, 14218);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 14099, 14271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 14099, 14271);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 14234, 14260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 14240, 14258);

                    _passThru = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 14234, 14260);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 14099, 14271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 14099, 14271);
                }
            }
        }

        private bool _passThru;

        [Parameter]
        [AllowNull]
        public string DefaultCommandPrefix
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 14520, 14557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 14526, 14555);

                    return _defaultCommandPrefix;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 14520, 14557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 14419, 14622);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 14419, 14622);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 14573, 14611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 14579, 14609);

                    _defaultCommandPrefix = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 14573, 14611);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 14419, 14622);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 14419, 14622);
                }
            }
        }

        private string _defaultCommandPrefix;

        private string _indent;

        private string QuoteName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 14980, 15170);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 15042, 15089) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 15042, 15089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 15077, 15089);

                    return "''";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 15042, 15089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 15103, 15159);

                return ("'" + f_1536_15117_15151(f_1536_15117_15132(name), "'", "''") + "'");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 14980, 15170);

                string
                f_1536_15117_15132(string
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 15117, 15132);
                    return return_v;
                }


                string
                f_1536_15117_15151(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 15117, 15151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 14980, 15170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 14980, 15170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string QuoteName(Uri name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 15450, 15616);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 15509, 15556) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 15509, 15556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 15544, 15556);

                    return "''";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 15509, 15556);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 15570, 15605);

                return f_1536_15577_15604(this, f_1536_15587_15603(name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 15450, 15616);

                string
                f_1536_15587_15603(System.Uri
                this_param)
                {
                    var return_v = this_param.AbsoluteUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 15587, 15603);
                    return return_v;
                }


                string
                f_1536_15577_15604(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                name)
                {
                    var return_v = this_param.QuoteName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 15577, 15604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 15450, 15616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 15450, 15616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string QuoteName(Version name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 15869, 16038);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 15932, 15979) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 15932, 15979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 15967, 15979);

                    return "''";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 15932, 15979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 15993, 16027);

                return f_1536_16000_16026(this, f_1536_16010_16025(name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 15869, 16038);

                string
                f_1536_16010_16025(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 16010, 16025);
                    return return_v;
                }


                string
                f_1536_16000_16026(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                name)
                {
                    var return_v = this_param.QuoteName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 16000, 16026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 15869, 16038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 15869, 16038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string QuoteNames(IEnumerable names, StreamWriter streamWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 16393, 17612);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 16489, 16538) || true) && (names == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 16489, 16538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 16525, 16538);

                    return "@()";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 16489, 16538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 16554, 16597);

                StringBuilder
                result = f_1536_16577_16596()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 16613, 16629);

                int
                offset = 15
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 16643, 16661);

                bool
                first = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 16675, 17490);
                    foreach (string name in f_1536_16699_16704_I(names))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 16675, 17490);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 16738, 17475) || true) && (!f_1536_16743_16769(name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 16738, 17475);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 16811, 17025) || true) && (first)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 16811, 17025);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 16870, 16884);

                                first = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 16811, 17025);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 16811, 17025);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 16982, 17002);

                                f_1536_16982_17001(result, ", ");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 16811, 17025);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 17049, 17087);

                            string
                            quotedString = f_1536_17071_17086(this, name)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 17109, 17139);

                            offset += f_1536_17119_17138(quotedString);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 17161, 17404) || true) && (offset > 80)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 17161, 17404);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 17226, 17262);

                                f_1536_17226_17261(result, f_1536_17240_17260(streamWriter));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 17288, 17321);

                                f_1536_17288_17320(result, "               ");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 17347, 17381);

                                offset = 15 + f_1536_17361_17380(quotedString);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 17161, 17404);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 17428, 17456);

                            f_1536_17428_17455(
                                                result, quotedString);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 16738, 17475);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 16675, 17490);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1536, 1, 816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1536, 1, 816);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 17506, 17560) || true) && (f_1536_17510_17523(result) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 17506, 17560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 17547, 17560);

                    return "@()";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 17506, 17560);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 17576, 17601);

                return f_1536_17583_17600(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 16393, 17612);

                System.Text.StringBuilder
                f_1536_16577_16596()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 16577, 16596);
                    return return_v;
                }


                bool
                f_1536_16743_16769(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 16743, 16769);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_16982_17001(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 16982, 17001);
                    return return_v;
                }


                string
                f_1536_17071_17086(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                name)
                {
                    var return_v = this_param.QuoteName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 17071, 17086);
                    return return_v;
                }


                int
                f_1536_17119_17138(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 17119, 17138);
                    return return_v;
                }


                string
                f_1536_17240_17260(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 17240, 17260);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_17226_17261(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 17226, 17261);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_17288_17320(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 17288, 17320);
                    return return_v;
                }


                int
                f_1536_17361_17380(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 17361, 17380);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_17428_17455(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 17428, 17455);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1536_16699_16704_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 16699, 16704);
                    return return_v;
                }


                int
                f_1536_17510_17523(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 17510, 17523);
                    return return_v;
                }


                string
                f_1536_17583_17600(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 17583, 17600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 16393, 17612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 16393, 17612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable PreProcessModuleSpec(IEnumerable moduleSpecs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 18124, 18635);

                var listYield = new List<object>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 18214, 18624) || true) && (moduleSpecs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 18214, 18624);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 18271, 18609);
                        foreach (object spec in f_1536_18295_18306_I(moduleSpecs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 18271, 18609);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 18348, 18590) || true) && (!(spec is Hashtable))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 18348, 18590);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 18422, 18451);

                                listYield.Add(f_1536_18435_18450(spec));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 18348, 18590);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 18348, 18590);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 18549, 18567);

                                listYield.Add(spec);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 18348, 18590);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 18271, 18609);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1536, 1, 339);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1536, 1, 339);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 18214, 18624);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 18124, 18635);

                return listYield;

                string?
                f_1536_18435_18450(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 18435, 18450);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1536_18295_18306_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 18295, 18306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 18124, 18635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 18124, 18635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string QuoteModules(IEnumerable moduleSpecs, StreamWriter streamWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 19083, 22268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19187, 19230);

                StringBuilder
                result = f_1536_19210_19229()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19244, 19264);

                f_1536_19244_19263(result, "@(");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19280, 22183) || true) && (moduleSpecs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 19280, 22183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19337, 19361);

                    bool
                    firstModule = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19379, 22168);
                        foreach (object spec in f_1536_19403_19414_I(moduleSpecs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 19379, 22168);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19456, 19554) || true) && (spec == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 19456, 19554);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19522, 19531);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 19456, 19554);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19578, 19849);

                            ModuleSpecification
                            moduleSpecification = (ModuleSpecification)
                            f_1536_19667_19848(spec, typeof(ModuleSpecification), f_1536_19819_19847())
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19873, 20103) || true) && (!firstModule)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 19873, 20103);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19939, 19959);

                                f_1536_19939_19958(result, ", ");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 19985, 20021);

                                f_1536_19985_20020(result, f_1536_19999_20019(streamWriter));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20047, 20080);

                                f_1536_20047_20079(result, "               ");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 19873, 20103);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20127, 20147);

                            firstModule = false;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20171, 22149) || true) && ((f_1536_20176_20200(moduleSpecification) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1536, 20175, 20250) && (f_1536_20214_20241(moduleSpecification) == null)) && (DynAbs.Tracing.TraceSender.Expression_True(1536, 20175, 20298) && (f_1536_20255_20289(moduleSpecification) == null)) && (DynAbs.Tracing.TraceSender.Expression_True(1536, 20175, 20347) && (f_1536_20303_20338(moduleSpecification) == null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 20171, 22149);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20397, 20448);

                                f_1536_20397_20447(result, f_1536_20411_20446(this, f_1536_20421_20445(moduleSpecification)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 20171, 22149);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 20171, 22149);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20546, 20566);

                                f_1536_20546_20565(result, "@{");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20594, 20625);

                                f_1536_20594_20624(
                                                        result, "ModuleName = ");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20651, 20702);

                                f_1536_20651_20701(result, f_1536_20665_20700(this, f_1536_20675_20699(moduleSpecification)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20728, 20748);

                                f_1536_20728_20747(result, "; ");

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20776, 21064) || true) && (f_1536_20780_20804(moduleSpecification) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 20776, 21064);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20870, 20895);

                                    f_1536_20870_20894(result, "GUID = ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 20925, 20987);

                                    f_1536_20925_20986(result, f_1536_20939_20985(this, moduleSpecification.Guid.ToString()));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21017, 21037);

                                    f_1536_21017_21036(result, "; ");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 20776, 21064);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21092, 21395) || true) && (f_1536_21096_21123(moduleSpecification) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 21092, 21395);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21189, 21223);

                                    f_1536_21189_21222(result, "ModuleVersion = ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21253, 21318);

                                    f_1536_21253_21317(result, f_1536_21267_21316(this, f_1536_21277_21315(f_1536_21277_21304(moduleSpecification))));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21348, 21368);

                                    f_1536_21348_21367(result, "; ");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 21092, 21395);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21423, 21730) || true) && (f_1536_21427_21461(moduleSpecification) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 21423, 21730);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21527, 21562);

                                    f_1536_21527_21561(result, "MaximumVersion = ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21592, 21653);

                                    f_1536_21592_21652(result, f_1536_21606_21651(this, f_1536_21616_21650(moduleSpecification)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21683, 21703);

                                    f_1536_21683_21702(result, "; ");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 21423, 21730);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21758, 22079) || true) && (f_1536_21762_21797(moduleSpecification) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 21758, 22079);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21863, 21899);

                                    f_1536_21863_21898(result, "RequiredVersion = ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 21929, 22002);

                                    f_1536_21929_22001(result, f_1536_21943_22000(this, f_1536_21953_21999(f_1536_21953_21988(moduleSpecification))));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 22032, 22052);

                                    f_1536_22032_22051(result, "; ");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 21758, 22079);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 22107, 22126);

                                f_1536_22107_22125(
                                                        result, "}");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 20171, 22149);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 19379, 22168);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1536, 1, 2790);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1536, 1, 2790);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 19280, 22183);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 22199, 22218);

                f_1536_22199_22217(
                            result, ")");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 22232, 22257);

                return f_1536_22239_22256(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 19083, 22268);

                System.Text.StringBuilder
                f_1536_19210_19229()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 19210, 19229);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_19244_19263(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 19244, 19263);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1536_19819_19847()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 19819, 19847);
                    return return_v;
                }


                object
                f_1536_19667_19848(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 19667, 19848);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_19939_19958(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 19939, 19958);
                    return return_v;
                }


                string
                f_1536_19999_20019(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 19999, 20019);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_19985_20020(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 19985, 20020);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_20047_20079(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20047, 20079);
                    return return_v;
                }


                System.Guid?
                f_1536_20176_20200(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 20176, 20200);
                    return return_v;
                }


                System.Version
                f_1536_20214_20241(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 20214, 20241);
                    return return_v;
                }


                string
                f_1536_20255_20289(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 20255, 20289);
                    return return_v;
                }


                System.Version
                f_1536_20303_20338(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 20303, 20338);
                    return return_v;
                }


                string
                f_1536_20421_20445(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 20421, 20445);
                    return return_v;
                }


                string
                f_1536_20411_20446(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                name)
                {
                    var return_v = this_param.QuoteName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20411, 20446);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_20397_20447(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20397, 20447);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_20546_20565(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20546, 20565);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_20594_20624(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20594, 20624);
                    return return_v;
                }


                string
                f_1536_20675_20699(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 20675, 20699);
                    return return_v;
                }


                string
                f_1536_20665_20700(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                name)
                {
                    var return_v = this_param.QuoteName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20665, 20700);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_20651_20701(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20651, 20701);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_20728_20747(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20728, 20747);
                    return return_v;
                }


                System.Guid?
                f_1536_20780_20804(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 20780, 20804);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_20870_20894(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20870, 20894);
                    return return_v;
                }


                string
                f_1536_20939_20985(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                name)
                {
                    var return_v = this_param.QuoteName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20939, 20985);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_20925_20986(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 20925, 20986);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_21017_21036(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21017, 21036);
                    return return_v;
                }


                System.Version
                f_1536_21096_21123(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 21096, 21123);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_21189_21222(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21189, 21222);
                    return return_v;
                }


                System.Version
                f_1536_21277_21304(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 21277, 21304);
                    return return_v;
                }


                string
                f_1536_21277_21315(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21277, 21315);
                    return return_v;
                }


                string
                f_1536_21267_21316(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                name)
                {
                    var return_v = this_param.QuoteName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21267, 21316);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_21253_21317(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21253, 21317);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_21348_21367(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21348, 21367);
                    return return_v;
                }


                string
                f_1536_21427_21461(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 21427, 21461);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_21527_21561(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21527, 21561);
                    return return_v;
                }


                string
                f_1536_21616_21650(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 21616, 21650);
                    return return_v;
                }


                string
                f_1536_21606_21651(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                name)
                {
                    var return_v = this_param.QuoteName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21606, 21651);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_21592_21652(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21592, 21652);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_21683_21702(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21683, 21702);
                    return return_v;
                }


                System.Version
                f_1536_21762_21797(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 21762, 21797);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_21863_21898(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21863, 21898);
                    return return_v;
                }


                System.Version
                f_1536_21953_21988(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 21953, 21988);
                    return return_v;
                }


                string
                f_1536_21953_21999(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21953, 21999);
                    return return_v;
                }


                string
                f_1536_21943_22000(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                name)
                {
                    var return_v = this_param.QuoteName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21943, 22000);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_21929_22001(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 21929, 22001);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_22032_22051(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 22032, 22051);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_22107_22125(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 22107, 22125);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1536_19403_19414_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 19403, 19414);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_22199_22217(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 22199, 22217);
                    return return_v;
                }


                string
                f_1536_22239_22256(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 22239, 22256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 19083, 22268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 19083, 22268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string QuoteFiles(IEnumerable names, StreamWriter streamWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 22626, 23277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 22722, 22770);

                List<string>
                resolvedPaths = f_1536_22751_22769()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 22786, 23203) || true) && (names != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 22786, 23203);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 22837, 23188);
                        foreach (string name in f_1536_22861_22866_I(names))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 22837, 23188);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 22908, 23169) || true) && (!f_1536_22913_22939(name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 22908, 23169);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 22989, 23146);
                                    foreach (string path in f_1536_23013_23037_I(f_1536_23013_23037(this, name)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 22989, 23146);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 23095, 23119);

                                        f_1536_23095_23118(resolvedPaths, path);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 22989, 23146);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1536, 1, 158);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1536, 1, 158);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 22908, 23169);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 22837, 23188);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1536, 1, 352);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1536, 1, 352);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 22786, 23203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 23219, 23266);

                return f_1536_23226_23265(this, resolvedPaths, streamWriter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 22626, 23277);

                System.Collections.Generic.List<string>
                f_1536_22751_22769()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 22751, 22769);
                    return return_v;
                }


                bool
                f_1536_22913_22939(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 22913, 22939);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1536_23013_23037(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                filePath)
                {
                    var return_v = this_param.TryResolveFilePath(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 23013, 23037);
                    return return_v;
                }


                int
                f_1536_23095_23118(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 23095, 23118);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1536_23013_23037_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 23013, 23037);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1536_22861_22866_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 22861, 22866);
                    return return_v;
                }


                string
                f_1536_23226_23265(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Collections.Generic.List<string>
                names, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.QuoteNames((System.Collections.IEnumerable)names, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 23226, 23265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 22626, 23277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 22626, 23277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<string> TryResolveFilePath(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 27893, 29602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 27974, 28015);

                List<string>
                result = f_1536_27996_28014()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 28029, 28058);

                ProviderInfo
                provider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 28072, 28121);

                SessionState
                sessionState = f_1536_28100_28120(f_1536_28100_28107())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 28171, 28299);

                    Collection<string>
                    filePaths =
                    f_1536_28223_28298(f_1536_28223_28240(sessionState), filePath, out provider)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 28427, 28652) || true) && (!f_1536_28432_28490(provider, f_1536_28452_28489(f_1536_28452_28478(f_1536_28452_28464(this)))) || (DynAbs.Tracing.TraceSender.Expression_False(1536, 28431, 28511) || filePaths == null) || (DynAbs.Tracing.TraceSender.Expression_False(1536, 28431, 28534) || f_1536_28515_28530(filePaths) < 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 28427, 28652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 28576, 28597);

                        f_1536_28576_28596(result, filePath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 28619, 28633);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 28427, 28652);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 28850, 29434);
                        foreach (string path in f_1536_28874_28883_I(filePaths))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 28850, 29434);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 28925, 29066);

                            string
                            adjustedPath = f_1536_28947_29065(f_1536_28947_28964(f_1536_28947_28959()), path, f_1536_29018_29064(f_1536_29018_29051(f_1536_29018_29035(f_1536_29018_29030()))))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 29088, 29366) || true) && (f_1536_29092_29158(adjustedPath, ".\\", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1536, 29092, 29252) || f_1536_29187_29252(adjustedPath, "./", StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 29088, 29366);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 29302, 29343);

                                adjustedPath = f_1536_29317_29342(adjustedPath, 2);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 29088, 29366);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 29390, 29415);

                            f_1536_29390_29414(
                                                result, adjustedPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 28850, 29434);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1536, 1, 585);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1536, 1, 585);
                    }
                }
                catch (ItemNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1536, 29463, 29561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 29525, 29546);

                    f_1536_29525_29545(result, filePath);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1536, 29463, 29561);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 29577, 29591);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 27893, 29602);

                System.Collections.Generic.List<string>
                f_1536_27996_28014()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 27996, 28014);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1536_28100_28107()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 28100, 28107);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1536_28100_28120(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 28100, 28120);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1536_28223_28240(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 28223, 28240);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1536_28223_28298(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetResolvedProviderPathFromPSPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 28223, 28298);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1536_28452_28464(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 28452, 28464);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1536_28452_28478(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 28452, 28478);
                    return return_v;
                }


                string
                f_1536_28452_28489(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 28452, 28489);
                    return return_v;
                }


                bool
                f_1536_28432_28490(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 28432, 28490);
                    return return_v;
                }


                int
                f_1536_28515_28530(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 28515, 28530);
                    return return_v;
                }


                int
                f_1536_28576_28596(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 28576, 28596);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1536_28947_28959()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 28947, 28959);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1536_28947_28964(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 28947, 28964);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1536_29018_29030()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 29018, 29030);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1536_29018_29035(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 29018, 29035);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1536_29018_29051(System.Management.Automation.PathIntrinsics
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 29018, 29051);
                    return return_v;
                }


                string
                f_1536_29018_29064(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.ProviderPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 29018, 29064);
                    return return_v;
                }


                string
                f_1536_28947_29065(System.Management.Automation.PathIntrinsics
                this_param, string
                path, string
                basePath)
                {
                    var return_v = this_param.NormalizeRelativePath(path, basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 28947, 29065);
                    return return_v;
                }


                bool
                f_1536_29092_29158(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 29092, 29158);
                    return return_v;
                }


                bool
                f_1536_29187_29252(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 29187, 29252);
                    return return_v;
                }


                string
                f_1536_29317_29342(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 29317, 29342);
                    return return_v;
                }


                int
                f_1536_29390_29414(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 29390, 29414);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1536_28874_28883_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 28874, 28883);
                    return return_v;
                }


                int
                f_1536_29525_29545(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 29525, 29545);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 27893, 29602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 27893, 29602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ManifestFragment(string key, string resourceString, string value, StreamWriter streamWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 30244, 30550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 30376, 30539);

                return f_1536_30383_30538(f_1536_30397_30425(), "{0}# {1}{2}{0}{3:19} = {4}{2}{2}", _indent, resourceString, f_1536_30505_30525(streamWriter), key, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 30244, 30550);

                System.Globalization.CultureInfo
                f_1536_30397_30425()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 30397, 30425);
                    return return_v;
                }


                string
                f_1536_30505_30525(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 30505, 30525);
                    return return_v;
                }


                string
                f_1536_30383_30538(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 30383, 30538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 30244, 30550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 30244, 30550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ManifestFragmentForNonSpecifiedManifestMember(string key, string resourceString, string value, StreamWriter streamWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 30562, 30899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 30723, 30888);

                return f_1536_30730_30887(f_1536_30744_30772(), "{0}# {1}{2}{0}# {3:19} = {4}{2}{2}", _indent, resourceString, f_1536_30854_30874(streamWriter), key, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 30562, 30899);

                System.Globalization.CultureInfo
                f_1536_30744_30772()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 30744, 30772);
                    return return_v;
                }


                string
                f_1536_30854_30874(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 30854, 30874);
                    return return_v;
                }


                string
                f_1536_30730_30887(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 30730, 30887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 30562, 30899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 30562, 30899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ManifestComment(string insert, StreamWriter streamWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 30911, 31312);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 31089, 31193) || true) && (!f_1536_31094_31122(insert))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 31089, 31193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 31156, 31178);

                    insert = " " + insert;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 31089, 31193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 31209, 31301);

                return f_1536_31216_31300(f_1536_31230_31258(), "#{0}{1}", insert, f_1536_31279_31299(streamWriter));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 30911, 31312);

                bool
                f_1536_31094_31122(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 31094, 31122);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1536_31230_31258()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 31230, 31258);
                    return return_v;
                }


                string
                f_1536_31279_31299(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 31279, 31299);
                    return return_v;
                }


                string
                f_1536_31216_31300(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 31216, 31300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 30911, 31312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 30911, 31312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 31416, 44938);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 32035, 32559) || true) && (f_1536_32039_32060() == ProcessorArchitecture.IA64)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 32035, 32559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 32124, 32230);

                    string
                    message = f_1536_32141_32229(f_1536_32159_32205(), f_1536_32207_32228())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 32248, 32319);

                    InvalidOperationException
                    ioe = f_1536_32280_32318(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 32337, 32500);

                    ErrorRecord
                    er = f_1536_32354_32499(ioe, "Modules_InvalidProcessorArchitectureInManifest", ErrorCategory.InvalidArgument, f_1536_32477_32498())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 32518, 32544);

                    f_1536_32518_32543(this, er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 32035, 32559);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 32575, 32604);

                ProviderInfo
                provider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 32618, 32636);

                PSDriveInfo
                drive
                = default(PSDriveInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 32650, 32754);

                string
                filePath = f_1536_32668_32753(f_1536_32668_32685(f_1536_32668_32680()), _path, out provider, out drive)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 32770, 33341) || true) && (!f_1536_32775_32828(provider, f_1536_32795_32827(f_1536_32795_32816(f_1536_32795_32802()))) || (DynAbs.Tracing.TraceSender.Expression_False(1536, 32774, 32930) || !f_1536_32833_32930(filePath, StringLiterals.PowerShellDataFileExtension, StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 32770, 33341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 32964, 33041);

                    string
                    message = f_1536_32981_33040(f_1536_32999_33032(), _path)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 33059, 33130);

                    InvalidOperationException
                    ioe = f_1536_33091_33129(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 33148, 33282);

                    ErrorRecord
                    er = f_1536_33165_33281(ioe, "Modules_InvalidModuleManifestPath", ErrorCategory.InvalidArgument, _path)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 33300, 33326);

                    f_1536_33300_33325(this, er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 32770, 33341);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34174, 34613) || true) && (_rootModule != null || (DynAbs.Tracing.TraceSender.Expression_False(1536, 34178, 34223) || _nestedModules != null) || (DynAbs.Tracing.TraceSender.Expression_False(1536, 34178, 34251) || _requiredModules != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 34174, 34613);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34285, 34380) || true) && (_exportedFunctions == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 34285, 34380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34338, 34380);

                        _exportedFunctions = new string[] { "*" };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 34285, 34380);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34398, 34489) || true) && (_exportedAliases == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 34398, 34489);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34449, 34489);

                        _exportedAliases = new string[] { "*" };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 34398, 34489);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34507, 34598) || true) && (_exportedCmdlets == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 34507, 34598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34558, 34598);

                        _exportedCmdlets = new string[] { "*" };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 34507, 34598);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 34174, 34613);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34629, 34681);

                f_1536_34629_34680(this, f_1536_34655_34665(), "ProjectUri");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34695, 34747);

                f_1536_34695_34746(this, f_1536_34721_34731(), "LicenseUri");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34761, 34807);

                f_1536_34761_34806(this, f_1536_34787_34794(), "IconUri");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34821, 34958) || true) && (_helpInfoUri != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 34821, 34958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34879, 34943);

                    f_1536_34879_34942(this, f_1536_34905_34926(_helpInfoUri), "HelpInfoUri");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 34821, 34958);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 34974, 35549) || true) && (f_1536_34978_34998() != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 34978, 35115) && (f_1536_35011_35082(f_1536_35011_35074(f_1536_35011_35031(), f_1536_35041_35073())) != f_1536_35086_35114(f_1536_35086_35106()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 34974, 35549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 35149, 35272);

                    string
                    message = f_1536_35166_35271(f_1536_35184_35230(), f_1536_35232_35270(",", f_1536_35249_35269()))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 35290, 35339);

                    var
                    ioe = f_1536_35300_35338(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 35357, 35490);

                    var
                    er = f_1536_35366_35489(ioe, "Modules_DuplicateEntriesInCompatiblePSEditions", ErrorCategory.InvalidArgument, f_1536_35468_35488())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 35508, 35534);

                    f_1536_35508_35533(this, er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 34974, 35549);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 35565, 35645);

                string
                action = f_1536_35581_35644(f_1536_35599_35633(), filePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 35661, 44927) || true) && (f_1536_35665_35696(this, filePath, action))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 35661, 44927);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 35730, 35855) || true) && (f_1536_35734_35763(_author))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 35730, 35855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 35805, 35836);

                        _author = f_1536_35815_35835();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 35730, 35855);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 35875, 36016) || true) && (f_1536_35879_35913(_companyName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 35875, 36016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 35955, 35997);

                        _companyName = f_1536_35970_35996();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 35875, 36016);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 36036, 36206) || true) && (f_1536_36040_36072(_copyright))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 36036, 36206);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 36114, 36187);

                        _copyright = f_1536_36127_36186(f_1536_36145_36176(), _author);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 36036, 36206);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 36226, 36248);

                    FileStream
                    fileStream
                    = default(FileStream);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 36266, 36292);

                    StreamWriter
                    streamWriter
                    = default(StreamWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 36310, 36336);

                    FileInfo
                    readOnlyFileInfo
                    = default(FileInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 36404, 36984);

                    f_1536_36404_36983(cmdlet: this, filePath: filePath, resolvedEncoding: f_1536_36547_36603(encoderShouldEmitUTF8Identifier: false), defaultEncoding: false, Append: false, Force: false, NoClobber: false, fileStream: out fileStream, streamWriter: out streamWriter, readOnlyFileInfo: out readOnlyFileInfo, isLiteralPath: false);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 37048, 37091);

                        StringBuilder
                        result = f_1536_37071_37090()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 37179, 37238);

                        f_1536_37179_37237(
                                            // Insert the formatted manifest header...
                                            result, f_1536_37193_37236(this, string.Empty, streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 37260, 37436);

                        f_1536_37260_37435(result, f_1536_37274_37434(this, f_1536_37290_37390(f_1536_37308_37335(), f_1536_37337_37389(filePath)), streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 37458, 37517);

                        f_1536_37458_37516(result, f_1536_37472_37515(this, string.Empty, streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 37539, 37670);

                        f_1536_37539_37669(result, f_1536_37553_37668(this, f_1536_37569_37624(f_1536_37587_37614(), _author), streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 37692, 37751);

                        f_1536_37692_37750(result, f_1536_37706_37749(this, string.Empty, streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 37773, 37951);

                        f_1536_37773_37950(result, f_1536_37787_37949(this, f_1536_37803_37905(f_1536_37821_37848(), DateTime.Now.ToString("d", f_1536_37877_37903())), streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 37973, 38032);

                        f_1536_37973_38031(result, f_1536_37987_38030(this, string.Empty, streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 38054, 38090);

                        f_1536_38054_38089(result, f_1536_38068_38088(streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 38112, 38132);

                        f_1536_38112_38131(result, "@{");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 38154, 38190);

                        f_1536_38154_38189(result, f_1536_38168_38188(streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 38212, 38248);

                        f_1536_38212_38247(result, f_1536_38226_38246(streamWriter));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 38272, 38349) || true) && (_rootModule == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 38272, 38349);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 38322, 38349);

                            _rootModule = string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 38272, 38349);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 38373, 38521);

                        f_1536_38373_38520(this, result, nameof(RootModule), f_1536_38421_38439(), !f_1536_38442_38475(_rootModule), () => QuoteName(_rootModule), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 38545, 38742);

                        f_1536_38545_38741(this, result, nameof(ModuleVersion), f_1536_38596_38617(), _moduleVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 38619, 38693) && !f_1536_38646_38693(f_1536_38667_38692(_moduleVersion))), () => QuoteName(_moduleVersion), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 38766, 38990);

                        f_1536_38766_38989(this, result, nameof(CompatiblePSEditions), f_1536_38824_38852(), _compatiblePSEditions != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 38854, 38919) && f_1536_38887_38915(_compatiblePSEditions) > 0), () => QuoteNames(_compatiblePSEditions, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 39014, 39168);

                        f_1536_39014_39167(this, result, nameof(Modules.GUID), f_1536_39064_39076(), !f_1536_39079_39117(_guid.ToString()), () => QuoteName(_guid.ToString()), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 39192, 39323);

                        f_1536_39192_39322(this, result, nameof(Author), f_1536_39236_39250(), !f_1536_39253_39282(_author), () => QuoteName(Author), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 39347, 39499);

                        f_1536_39347_39498(this, result, nameof(CompanyName), f_1536_39396_39415(), !f_1536_39418_39452(_companyName), () => QuoteName(_companyName), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 39523, 39667);

                        f_1536_39523_39666(this, result, nameof(Copyright), f_1536_39570_39587(), !f_1536_39590_39622(_copyright), () => QuoteName(_copyright), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 39691, 39843);

                        f_1536_39691_39842(this, result, nameof(Description), f_1536_39740_39759(), !f_1536_39762_39796(_description), () => QuoteName(_description), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 39867, 40084);

                        f_1536_39867_40083(this, result, nameof(PowerShellVersion), f_1536_39922_39947(), _powerShellVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 39949, 40031) && !f_1536_39980_40031(f_1536_40001_40030(_powerShellVersion))), () => QuoteName(_powerShellVersion), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 40108, 40288);

                        f_1536_40108_40287(this, result, nameof(PowerShellHostName), f_1536_40164_40190(), !f_1536_40193_40234(_PowerShellHostName), () => QuoteName(_PowerShellHostName), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 40312, 40549);

                        f_1536_40312_40548(this, result, nameof(PowerShellHostVersion), f_1536_40371_40400(), _PowerShellHostVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 40402, 40492) && !f_1536_40437_40492(f_1536_40458_40491(_PowerShellHostVersion))), () => QuoteName(_PowerShellHostVersion), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 40573, 40877);

                        f_1536_40573_40876(this, result, nameof(DotNetFrameworkVersion), f_1536_40633_40725(f_1536_40651_40681(), f_1536_40683_40724()), _DotNetFrameworkVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 40727, 40819) && !f_1536_40763_40819(f_1536_40784_40818(_DotNetFrameworkVersion))), () => QuoteName(_DotNetFrameworkVersion), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 40901, 41145);

                        f_1536_40901_41144(this, result, nameof(ClrVersion), f_1536_40949_41029(f_1536_40967_40985(), f_1536_40987_41028()), _ClrVersion != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 41031, 41099) && !f_1536_41055_41099(f_1536_41076_41098(_ClrVersion))), () => QuoteName(_ClrVersion), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 41169, 41358);

                        f_1536_41169_41357(this, result, nameof(ProcessorArchitecture), f_1536_41228_41257(), f_1536_41259_41290(_processorArchitecture), () => QuoteName(_processorArchitecture.ToString()), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 41382, 41583);

                        f_1536_41382_41582(this, result, nameof(RequiredModules), f_1536_41435_41458(), _requiredModules != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 41460, 41515) && f_1536_41488_41511(_requiredModules) > 0), () => QuoteModules(_requiredModules, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 41607, 41787);

                        f_1536_41607_41786(this, result, nameof(RequiredAssemblies), f_1536_41663_41689(), _requiredAssemblies != null, () => QuoteFiles(_requiredAssemblies, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 41811, 41965);

                        f_1536_41811_41964(this, result, nameof(ScriptsToProcess), f_1536_41865_41889(), _scripts != null, () => QuoteFiles(_scripts, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 41989, 42135);

                        f_1536_41989_42134(this, result, nameof(TypesToProcess), f_1536_42041_42063(), _types != null, () => QuoteFiles(_types, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 42159, 42313);

                        f_1536_42159_42312(this, result, nameof(FormatsToProcess), f_1536_42213_42237(), _formats != null, () => QuoteFiles(_formats, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 42337, 42521);

                        f_1536_42337_42520(this, result, nameof(NestedModules), f_1536_42388_42409(), _nestedModules != null, () => QuoteModules(PreProcessModuleSpec(_nestedModules), streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 42545, 42699);

                        f_1536_42545_42698(this, result, nameof(FunctionsToExport), f_1536_42600_42625(), true, () => QuoteNames(_exportedFunctions, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 42723, 42871);

                        f_1536_42723_42870(this, result, nameof(CmdletsToExport), f_1536_42776_42799(), true, () => QuoteNames(_exportedCmdlets, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 42895, 43104);

                        f_1536_42895_43103(this, result, nameof(VariablesToExport), f_1536_42950_42975(), _exportedVariables != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 42977, 43036) && f_1536_43007_43032(_exportedVariables) > 0), () => QuoteNames(_exportedVariables, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 43128, 43276);

                        f_1536_43128_43275(this, result, nameof(AliasesToExport), f_1536_43181_43204(), true, () => QuoteNames(_exportedAliases, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 43300, 43524);

                        f_1536_43300_43523(this, result, nameof(DscResourcesToExport), f_1536_43358_43386(), _dscResourcesToExport != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 43388, 43453) && f_1536_43421_43449(_dscResourcesToExport) > 0), () => QuoteNames(_dscResourcesToExport, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 43548, 43698);

                        f_1536_43548_43697(this, result, nameof(ModuleList), f_1536_43596_43614(), _moduleList != null, () => QuoteModules(_moduleList, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 43722, 43864);

                        f_1536_43722_43863(this, result, nameof(FileList), f_1536_43768_43784(), _miscFiles != null, () => QuoteFiles(_miscFiles, streamWriter), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 43888, 43943);

                        f_1536_43888_43942(this, result, streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 43967, 44168);

                        f_1536_43967_44167(this, result, nameof(Modules.HelpInfoURI), f_1536_44024_44043(), !f_1536_44046_44080(_helpInfoUri), () => QuoteName((_helpInfoUri != null) ? new Uri(_helpInfoUri) : null), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 44192, 44380);

                        f_1536_44192_44379(this, result, nameof(DefaultCommandPrefix), f_1536_44250_44278(), !f_1536_44281_44324(_defaultCommandPrefix), () => QuoteName(_defaultCommandPrefix), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 44404, 44423);

                        f_1536_44404_44422(
                                            result, "}");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 44445, 44481);

                        f_1536_44445_44480(result, f_1536_44459_44479(streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 44503, 44539);

                        f_1536_44503_44538(result, f_1536_44517_44537(streamWriter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 44561, 44598);

                        string
                        strResult = f_1536_44580_44597(result)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 44622, 44731) || true) && (_passThru)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 44622, 44731);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 44685, 44708);

                            f_1536_44685_44707(this, strResult);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 44622, 44731);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 44755, 44785);

                        f_1536_44755_44784(
                                            streamWriter, strResult);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1536, 44822, 44912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 44870, 44893);

                        f_1536_44870_44892(streamWriter);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1536, 44822, 44912);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 35661, 44927);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 31416, 44938);

                System.Reflection.ProcessorArchitecture
                f_1536_32039_32060()
                {
                    var return_v = ProcessorArchitecture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 32039, 32060);
                    return return_v;
                }


                string
                f_1536_32159_32205()
                {
                    var return_v = Modules.InvalidProcessorArchitectureInManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 32159, 32205);
                    return return_v;
                }


                System.Reflection.ProcessorArchitecture
                f_1536_32207_32228()
                {
                    var return_v = ProcessorArchitecture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 32207, 32228);
                    return return_v;
                }


                string
                f_1536_32141_32229(string
                formatSpec, System.Reflection.ProcessorArchitecture
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 32141, 32229);
                    return return_v;
                }


                System.InvalidOperationException
                f_1536_32280_32318(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 32280, 32318);
                    return return_v;
                }


                System.Reflection.ProcessorArchitecture
                f_1536_32477_32498()
                {
                    var return_v = ProcessorArchitecture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 32477, 32498);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1536_32354_32499(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Reflection.ProcessorArchitecture
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 32354, 32499);
                    return return_v;
                }


                int
                f_1536_32518_32543(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 32518, 32543);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1536_32668_32680()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 32668, 32680);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1536_32668_32685(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 32668, 32685);
                    return return_v;
                }


                string
                f_1536_32668_32753(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetUnresolvedProviderPathFromPSPath(path, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 32668, 32753);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1536_32795_32802()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 32795, 32802);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1536_32795_32816(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 32795, 32816);
                    return return_v;
                }


                string
                f_1536_32795_32827(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 32795, 32827);
                    return return_v;
                }


                bool
                f_1536_32775_32828(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 32775, 32828);
                    return return_v;
                }


                bool
                f_1536_32833_32930(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 32833, 32930);
                    return return_v;
                }


                string
                f_1536_32999_33032()
                {
                    var return_v = Modules.InvalidModuleManifestPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 32999, 33032);
                    return return_v;
                }


                string
                f_1536_32981_33040(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 32981, 33040);
                    return return_v;
                }


                System.InvalidOperationException
                f_1536_33091_33129(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 33091, 33129);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1536_33165_33281(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 33165, 33281);
                    return return_v;
                }


                int
                f_1536_33300_33325(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 33300, 33325);
                    return 0;
                }


                System.Uri
                f_1536_34655_34665()
                {
                    var return_v = ProjectUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 34655, 34665);
                    return return_v;
                }


                int
                f_1536_34629_34680(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Uri
                uri, string
                parameterName)
                {
                    this_param.ValidateUriParameterValue(uri, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 34629, 34680);
                    return 0;
                }


                System.Uri
                f_1536_34721_34731()
                {
                    var return_v = LicenseUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 34721, 34731);
                    return return_v;
                }


                int
                f_1536_34695_34746(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Uri
                uri, string
                parameterName)
                {
                    this_param.ValidateUriParameterValue(uri, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 34695, 34746);
                    return 0;
                }


                System.Uri
                f_1536_34787_34794()
                {
                    var return_v = IconUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 34787, 34794);
                    return return_v;
                }


                int
                f_1536_34761_34806(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Uri
                uri, string
                parameterName)
                {
                    this_param.ValidateUriParameterValue(uri, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 34761, 34806);
                    return 0;
                }


                System.Uri
                f_1536_34905_34926(string
                uriString)
                {
                    var return_v = new System.Uri(uriString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 34905, 34926);
                    return return_v;
                }


                int
                f_1536_34879_34942(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Uri
                uri, string
                parameterName)
                {
                    this_param.ValidateUriParameterValue(uri, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 34879, 34942);
                    return 0;
                }


                string[]
                f_1536_34978_34998()
                {
                    var return_v = CompatiblePSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 34978, 34998);
                    return return_v;
                }


                string[]
                f_1536_35011_35031()
                {
                    var return_v = CompatiblePSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 35011, 35031);
                    return return_v;
                }


                System.StringComparer
                f_1536_35041_35073()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 35041, 35073);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1536_35011_35074(string[]
                source, System.StringComparer
                comparer)
                {
                    var return_v = source.Distinct<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35011, 35074);
                    return return_v;
                }


                int
                f_1536_35011_35082(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Count<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35011, 35082);
                    return return_v;
                }


                string[]
                f_1536_35086_35106()
                {
                    var return_v = CompatiblePSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 35086, 35106);
                    return return_v;
                }


                int
                f_1536_35086_35114(string[]
                source)
                {
                    var return_v = source.Count<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35086, 35114);
                    return return_v;
                }


                string
                f_1536_35184_35230()
                {
                    var return_v = Modules.DuplicateEntriesInCompatiblePSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 35184, 35230);
                    return return_v;
                }


                string[]
                f_1536_35249_35269()
                {
                    var return_v = CompatiblePSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 35249, 35269);
                    return return_v;
                }


                string
                f_1536_35232_35270(string
                separator, params string[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35232, 35270);
                    return return_v;
                }


                string
                f_1536_35166_35271(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35166, 35271);
                    return return_v;
                }


                System.InvalidOperationException
                f_1536_35300_35338(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35300, 35338);
                    return return_v;
                }


                string[]
                f_1536_35468_35488()
                {
                    var return_v = CompatiblePSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 35468, 35488);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1536_35366_35489(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string[]
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35366, 35489);
                    return return_v;
                }


                int
                f_1536_35508_35533(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35508, 35533);
                    return 0;
                }


                string
                f_1536_35599_35633()
                {
                    var return_v = Modules.CreatingModuleManifestFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 35599, 35633);
                    return return_v;
                }


                string
                f_1536_35581_35644(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35581, 35644);
                    return return_v;
                }


                bool
                f_1536_35665_35696(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35665, 35696);
                    return return_v;
                }


                bool
                f_1536_35734_35763(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35734, 35763);
                    return return_v;
                }


                string
                f_1536_35815_35835()
                {
                    var return_v = Environment.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 35815, 35835);
                    return return_v;
                }


                bool
                f_1536_35879_35913(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 35879, 35913);
                    return return_v;
                }


                string
                f_1536_35970_35996()
                {
                    var return_v = Modules.DefaultCompanyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 35970, 35996);
                    return return_v;
                }


                bool
                f_1536_36040_36072(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 36040, 36072);
                    return return_v;
                }


                string
                f_1536_36145_36176()
                {
                    var return_v = Modules.DefaultCopyrightMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 36145, 36176);
                    return return_v;
                }


                string
                f_1536_36127_36186(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 36127, 36186);
                    return return_v;
                }


                System.Text.UTF8Encoding
                f_1536_36547_36603(bool
                encoderShouldEmitUTF8Identifier)
                {
                    var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: encoderShouldEmitUTF8Identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 36547, 36603);
                    return return_v;
                }


                int
                f_1536_36404_36983(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                cmdlet, string
                filePath, System.Text.UTF8Encoding
                resolvedEncoding, bool
                defaultEncoding, bool
                Append, bool
                Force, bool
                NoClobber, out System.IO.FileStream
                fileStream, out System.IO.StreamWriter
                streamWriter, out System.IO.FileInfo
                readOnlyFileInfo, bool
                isLiteralPath)
                {
                    PathUtils.MasterStreamOpen(cmdlet: (System.Management.Automation.PSCmdlet)cmdlet, filePath: filePath, resolvedEncoding: (System.Text.Encoding)resolvedEncoding, defaultEncoding: defaultEncoding, Append: Append, Force: Force, NoClobber: NoClobber, out fileStream, out streamWriter, out readOnlyFileInfo, isLiteralPath: isLiteralPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 36404, 36983);
                    return 0;
                }


                System.Text.StringBuilder
                f_1536_37071_37090()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37071, 37090);
                    return return_v;
                }


                string
                f_1536_37193_37236(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                insert, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestComment(insert, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37193, 37236);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_37179_37237(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37179, 37237);
                    return return_v;
                }


                string
                f_1536_37308_37335()
                {
                    var return_v = Modules.ManifestHeaderLine1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 37308, 37335);
                    return return_v;
                }


                string?
                f_1536_37337_37389(string
                path)
                {
                    var return_v = System.IO.Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37337, 37389);
                    return return_v;
                }


                string
                f_1536_37290_37390(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37290, 37390);
                    return return_v;
                }


                string
                f_1536_37274_37434(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                insert, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestComment(insert, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37274, 37434);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_37260_37435(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37260, 37435);
                    return return_v;
                }


                string
                f_1536_37472_37515(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                insert, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestComment(insert, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37472, 37515);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_37458_37516(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37458, 37516);
                    return return_v;
                }


                string
                f_1536_37587_37614()
                {
                    var return_v = Modules.ManifestHeaderLine2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 37587, 37614);
                    return return_v;
                }


                string
                f_1536_37569_37624(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37569, 37624);
                    return return_v;
                }


                string
                f_1536_37553_37668(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                insert, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestComment(insert, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37553, 37668);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_37539_37669(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37539, 37669);
                    return return_v;
                }


                string
                f_1536_37706_37749(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                insert, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestComment(insert, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37706, 37749);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_37692_37750(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37692, 37750);
                    return return_v;
                }


                string
                f_1536_37821_37848()
                {
                    var return_v = Modules.ManifestHeaderLine3;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 37821, 37848);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1536_37877_37903()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 37877, 37903);
                    return return_v;
                }


                string
                f_1536_37803_37905(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37803, 37905);
                    return return_v;
                }


                string
                f_1536_37787_37949(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                insert, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestComment(insert, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37787, 37949);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_37773_37950(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37773, 37950);
                    return return_v;
                }


                string
                f_1536_37987_38030(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                insert, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestComment(insert, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37987, 38030);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_37973_38031(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 37973, 38031);
                    return return_v;
                }


                string
                f_1536_38068_38088(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 38068, 38088);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_38054_38089(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 38054, 38089);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_38112_38131(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 38112, 38131);
                    return return_v;
                }


                string
                f_1536_38168_38188(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 38168, 38188);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_38154_38189(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 38154, 38189);
                    return return_v;
                }


                string
                f_1536_38226_38246(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 38226, 38246);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_38212_38247(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 38212, 38247);
                    return return_v;
                }


                string
                f_1536_38421_38439()
                {
                    var return_v = Modules.RootModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 38421, 38439);
                    return return_v;
                }


                bool
                f_1536_38442_38475(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 38442, 38475);
                    return return_v;
                }


                int
                f_1536_38373_38520(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 38373, 38520);
                    return 0;
                }


                string
                f_1536_38596_38617()
                {
                    var return_v = Modules.ModuleVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 38596, 38617);
                    return return_v;
                }


                string
                f_1536_38667_38692(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 38667, 38692);
                    return return_v;
                }


                bool
                f_1536_38646_38693(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 38646, 38693);
                    return return_v;
                }


                int
                f_1536_38545_38741(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 38545, 38741);
                    return 0;
                }


                string
                f_1536_38824_38852()
                {
                    var return_v = Modules.CompatiblePSEditions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 38824, 38852);
                    return return_v;
                }


                int
                f_1536_38887_38915(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 38887, 38915);
                    return return_v;
                }


                int
                f_1536_38766_38989(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 38766, 38989);
                    return 0;
                }


                string
                f_1536_39064_39076()
                {
                    var return_v = Modules.GUID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 39064, 39076);
                    return return_v;
                }


                bool
                f_1536_39079_39117(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39079, 39117);
                    return return_v;
                }


                int
                f_1536_39014_39167(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39014, 39167);
                    return 0;
                }


                string
                f_1536_39236_39250()
                {
                    var return_v = Modules.Author;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 39236, 39250);
                    return return_v;
                }


                bool
                f_1536_39253_39282(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39253, 39282);
                    return return_v;
                }


                int
                f_1536_39192_39322(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39192, 39322);
                    return 0;
                }


                string
                f_1536_39396_39415()
                {
                    var return_v = Modules.CompanyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 39396, 39415);
                    return return_v;
                }


                bool
                f_1536_39418_39452(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39418, 39452);
                    return return_v;
                }


                int
                f_1536_39347_39498(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39347, 39498);
                    return 0;
                }


                string
                f_1536_39570_39587()
                {
                    var return_v = Modules.Copyright;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 39570, 39587);
                    return return_v;
                }


                bool
                f_1536_39590_39622(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39590, 39622);
                    return return_v;
                }


                int
                f_1536_39523_39666(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39523, 39666);
                    return 0;
                }


                string
                f_1536_39740_39759()
                {
                    var return_v = Modules.Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 39740, 39759);
                    return return_v;
                }


                bool
                f_1536_39762_39796(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39762, 39796);
                    return return_v;
                }


                int
                f_1536_39691_39842(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39691, 39842);
                    return 0;
                }


                string
                f_1536_39922_39947()
                {
                    var return_v = Modules.PowerShellVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 39922, 39947);
                    return return_v;
                }


                string
                f_1536_40001_40030(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40001, 40030);
                    return return_v;
                }


                bool
                f_1536_39980_40031(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39980, 40031);
                    return return_v;
                }


                int
                f_1536_39867_40083(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 39867, 40083);
                    return 0;
                }


                string
                f_1536_40164_40190()
                {
                    var return_v = Modules.PowerShellHostName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 40164, 40190);
                    return return_v;
                }


                bool
                f_1536_40193_40234(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40193, 40234);
                    return return_v;
                }


                int
                f_1536_40108_40287(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40108, 40287);
                    return 0;
                }


                string
                f_1536_40371_40400()
                {
                    var return_v = Modules.PowerShellHostVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 40371, 40400);
                    return return_v;
                }


                string
                f_1536_40458_40491(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40458, 40491);
                    return return_v;
                }


                bool
                f_1536_40437_40492(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40437, 40492);
                    return return_v;
                }


                int
                f_1536_40312_40548(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40312, 40548);
                    return 0;
                }


                string
                f_1536_40651_40681()
                {
                    var return_v = Modules.DotNetFrameworkVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 40651, 40681);
                    return return_v;
                }


                string
                f_1536_40683_40724()
                {
                    var return_v = Modules.PrerequisiteForDesktopEditionOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 40683, 40724);
                    return return_v;
                }


                string
                f_1536_40633_40725(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40633, 40725);
                    return return_v;
                }


                string
                f_1536_40784_40818(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40784, 40818);
                    return return_v;
                }


                bool
                f_1536_40763_40819(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40763, 40819);
                    return return_v;
                }


                int
                f_1536_40573_40876(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40573, 40876);
                    return 0;
                }


                string
                f_1536_40967_40985()
                {
                    var return_v = Modules.CLRVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 40967, 40985);
                    return return_v;
                }


                string
                f_1536_40987_41028()
                {
                    var return_v = Modules.PrerequisiteForDesktopEditionOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 40987, 41028);
                    return return_v;
                }


                string
                f_1536_40949_41029(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40949, 41029);
                    return return_v;
                }


                string
                f_1536_41076_41098(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 41076, 41098);
                    return return_v;
                }


                bool
                f_1536_41055_41099(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 41055, 41099);
                    return return_v;
                }


                int
                f_1536_40901_41144(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 40901, 41144);
                    return 0;
                }


                string
                f_1536_41228_41257()
                {
                    var return_v = Modules.ProcessorArchitecture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 41228, 41257);
                    return return_v;
                }


                bool
                f_1536_41259_41290(System.Reflection.ProcessorArchitecture?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 41259, 41290);
                    return return_v;
                }


                int
                f_1536_41169_41357(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 41169, 41357);
                    return 0;
                }


                string
                f_1536_41435_41458()
                {
                    var return_v = Modules.RequiredModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 41435, 41458);
                    return return_v;
                }


                int
                f_1536_41488_41511(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 41488, 41511);
                    return return_v;
                }


                int
                f_1536_41382_41582(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 41382, 41582);
                    return 0;
                }


                string
                f_1536_41663_41689()
                {
                    var return_v = Modules.RequiredAssemblies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 41663, 41689);
                    return return_v;
                }


                int
                f_1536_41607_41786(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 41607, 41786);
                    return 0;
                }


                string
                f_1536_41865_41889()
                {
                    var return_v = Modules.ScriptsToProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 41865, 41889);
                    return return_v;
                }


                int
                f_1536_41811_41964(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 41811, 41964);
                    return 0;
                }


                string
                f_1536_42041_42063()
                {
                    var return_v = Modules.TypesToProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 42041, 42063);
                    return return_v;
                }


                int
                f_1536_41989_42134(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 41989, 42134);
                    return 0;
                }


                string
                f_1536_42213_42237()
                {
                    var return_v = Modules.FormatsToProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 42213, 42237);
                    return return_v;
                }


                int
                f_1536_42159_42312(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 42159, 42312);
                    return 0;
                }


                string
                f_1536_42388_42409()
                {
                    var return_v = Modules.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 42388, 42409);
                    return return_v;
                }


                int
                f_1536_42337_42520(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 42337, 42520);
                    return 0;
                }


                string
                f_1536_42600_42625()
                {
                    var return_v = Modules.FunctionsToExport;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 42600, 42625);
                    return return_v;
                }


                int
                f_1536_42545_42698(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 42545, 42698);
                    return 0;
                }


                string
                f_1536_42776_42799()
                {
                    var return_v = Modules.CmdletsToExport;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 42776, 42799);
                    return return_v;
                }


                int
                f_1536_42723_42870(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 42723, 42870);
                    return 0;
                }


                string
                f_1536_42950_42975()
                {
                    var return_v = Modules.VariablesToExport;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 42950, 42975);
                    return return_v;
                }


                int
                f_1536_43007_43032(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 43007, 43032);
                    return return_v;
                }


                int
                f_1536_42895_43103(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 42895, 43103);
                    return 0;
                }


                string
                f_1536_43181_43204()
                {
                    var return_v = Modules.AliasesToExport;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 43181, 43204);
                    return return_v;
                }


                int
                f_1536_43128_43275(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 43128, 43275);
                    return 0;
                }


                string
                f_1536_43358_43386()
                {
                    var return_v = Modules.DscResourcesToExport;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 43358, 43386);
                    return return_v;
                }


                int
                f_1536_43421_43449(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 43421, 43449);
                    return return_v;
                }


                int
                f_1536_43300_43523(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 43300, 43523);
                    return 0;
                }


                string
                f_1536_43596_43614()
                {
                    var return_v = Modules.ModuleList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 43596, 43614);
                    return return_v;
                }


                int
                f_1536_43548_43697(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 43548, 43697);
                    return 0;
                }


                string
                f_1536_43768_43784()
                {
                    var return_v = Modules.FileList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 43768, 43784);
                    return return_v;
                }


                int
                f_1536_43722_43863(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 43722, 43863);
                    return 0;
                }


                int
                f_1536_43888_43942(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildPrivateDataInModuleManifest(result, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 43888, 43942);
                    return 0;
                }


                string
                f_1536_44024_44043()
                {
                    var return_v = Modules.HelpInfoURI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 44024, 44043);
                    return return_v;
                }


                bool
                f_1536_44046_44080(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 44046, 44080);
                    return return_v;
                }


                int
                f_1536_43967_44167(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 43967, 44167);
                    return 0;
                }


                string
                f_1536_44250_44278()
                {
                    var return_v = Modules.DefaultCommandPrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 44250, 44278);
                    return return_v;
                }


                bool
                f_1536_44281_44324(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 44281, 44324);
                    return return_v;
                }


                int
                f_1536_44192_44379(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 44192, 44379);
                    return 0;
                }


                System.Text.StringBuilder
                f_1536_44404_44422(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 44404, 44422);
                    return return_v;
                }


                string
                f_1536_44459_44479(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 44459, 44479);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_44445_44480(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 44445, 44480);
                    return return_v;
                }


                string
                f_1536_44517_44537(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 44517, 44537);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_44503_44538(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 44503, 44538);
                    return return_v;
                }


                string
                f_1536_44580_44597(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 44580, 44597);
                    return return_v;
                }


                int
                f_1536_44685_44707(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 44685, 44707);
                    return 0;
                }


                int
                f_1536_44755_44784(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 44755, 44784);
                    return 0;
                }


                int
                f_1536_44870_44892(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 44870, 44892);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 31416, 44938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 31416, 44938);
            }
        }

        private void BuildModuleManifest(StringBuilder result, string key, string keyDescription, bool hasValue, Func<string> action, StreamWriter streamWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 44950, 45448);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 45127, 45437) || true) && (hasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 45127, 45437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 45173, 45250);

                    f_1536_45173_45249(result, f_1536_45187_45248(this, key, keyDescription, f_1536_45225_45233(action), streamWriter));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 45127, 45437);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 45127, 45437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 45316, 45422);

                    f_1536_45316_45421(result, f_1536_45330_45420(this, key, keyDescription, f_1536_45397_45405(action), streamWriter));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 45127, 45437);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 44950, 45448);

                string
                f_1536_45225_45233(System.Func<string>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 45225, 45233);
                    return return_v;
                }


                string
                f_1536_45187_45248(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                key, string
                resourceString, string
                value, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestFragment(key, resourceString, value, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 45187, 45248);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_45173_45249(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 45173, 45249);
                    return return_v;
                }


                string
                f_1536_45397_45405(System.Func<string>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 45397, 45405);
                    return return_v;
                }


                string
                f_1536_45330_45420(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                key, string
                resourceString, string
                value, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestFragmentForNonSpecifiedManifestMember(key, resourceString, value, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 45330, 45420);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_45316_45421(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 45316, 45421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 44950, 45448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 44950, 45448);
            }
        }

        private void BuildPrivateDataInModuleManifest(StringBuilder result, StreamWriter streamWriter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 46221, 50443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 46340, 46392);

                var
                privateDataHashTable = f_1536_46367_46378() as Hashtable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 46406, 46542);

                bool
                specifiedPSDataProperties = !(f_1536_46441_46445() == null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 46441, 46477) && f_1536_46457_46469() == null) && (DynAbs.Tracing.TraceSender.Expression_True(1536, 46441, 46499) && f_1536_46481_46491() == null) && (DynAbs.Tracing.TraceSender.Expression_True(1536, 46441, 46518) && f_1536_46503_46510() == null) && (DynAbs.Tracing.TraceSender.Expression_True(1536, 46441, 46540) && f_1536_46522_46532() == null))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 46558, 50432) || true) && (_privateData != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 46562, 46614) && privateDataHashTable == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 46558, 50432);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 46648, 47460) || true) && (specifiedPSDataProperties)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 46648, 47460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 46719, 46811);

                        var
                        ioe = f_1536_46729_46810(f_1536_46759_46809())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 46833, 46949);

                        var
                        er = f_1536_46842_46948(ioe, "PrivateDataValueTypeShouldBeHashTable", ErrorCategory.InvalidArgument, _privateData)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 46971, 46997);

                        f_1536_46971_46996(this, er);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 46648, 47460);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 46648, 47460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47079, 47146);

                        f_1536_47079_47145(this, f_1536_47092_47144());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47170, 47441);

                        f_1536_47170_47440(this, result, nameof(PrivateData), f_1536_47219_47238(), _privateData != null, () => QuoteName((string)LanguagePrimitives.ConvertTo(_privateData, typeof(string), CultureInfo.InvariantCulture)), streamWriter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 46648, 47460);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 46558, 50432);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 46558, 50432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47526, 47592);

                    f_1536_47526_47591(result, f_1536_47540_47590(this, f_1536_47556_47575(), streamWriter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47610, 47644);

                    f_1536_47610_47643(result, "PrivateData = @{");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47662, 47698);

                    f_1536_47662_47697(result, f_1536_47676_47696(streamWriter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47718, 47754);

                    f_1536_47718_47753(
                                    result, f_1536_47732_47752(streamWriter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47772, 47805);

                    f_1536_47772_47804(result, "    PSData = @{");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47823, 47859);

                    f_1536_47823_47858(result, f_1536_47837_47857(streamWriter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47877, 47913);

                    f_1536_47877_47912(result, f_1536_47891_47911(streamWriter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47933, 47954);

                    _indent = "        ";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 47974, 48115);

                    f_1536_47974_48114(this, result, nameof(Tags), f_1536_48016_48028(), f_1536_48030_48034() != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 48030, 48061) && f_1536_48046_48057(f_1536_48046_48050()) > 0), () => QuoteNames(Tags, streamWriter), streamWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 48133, 48264);

                    f_1536_48133_48263(this, result, nameof(LicenseUri), f_1536_48181_48199(), f_1536_48201_48211() != null, () => QuoteName(LicenseUri), streamWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 48282, 48413);

                    f_1536_48282_48412(this, result, nameof(ProjectUri), f_1536_48330_48348(), f_1536_48350_48360() != null, () => QuoteName(ProjectUri), streamWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 48431, 48550);

                    f_1536_48431_48549(this, result, nameof(IconUri), f_1536_48476_48491(), f_1536_48493_48500() != null, () => QuoteName(IconUri), streamWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 48568, 48722);

                    f_1536_48568_48721(this, result, nameof(ReleaseNotes), f_1536_48618_48638(), !f_1536_48641_48675(f_1536_48662_48674()), () => QuoteName(ReleaseNotes), streamWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 48740, 48886);

                    f_1536_48740_48885(this, result, nameof(Prerelease), f_1536_48788_48806(), !f_1536_48809_48841(f_1536_48830_48840()), () => QuoteName(Prerelease), streamWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 48904, 49125);

                    f_1536_48904_49124(this, result, nameof(RequireLicenseAcceptance), f_1536_48966_48998(), f_1536_49000_49024().IsPresent, () => { return RequireLicenseAcceptance.IsPresent ? "$true" : "$false"; }, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 49143, 49394);

                    f_1536_49143_49393(this, result, nameof(ExternalModuleDependencies), f_1536_49207_49241(), f_1536_49243_49269() != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 49243, 49318) && f_1536_49281_49314(f_1536_49281_49307()) > 0), () => QuoteNames(ExternalModuleDependencies, streamWriter), streamWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 49414, 49438);

                    f_1536_49414_49437(
                                    result, "    } ");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 49456, 49562);

                    f_1536_49456_49561(result, f_1536_49470_49560(this, f_1536_49486_49545(f_1536_49504_49534(), "PSData"), streamWriter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 49580, 49616);

                    f_1536_49580_49615(result, f_1536_49594_49614(streamWriter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 49636, 49653);

                    _indent = "    ";

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 49671, 50149) || true) && (privateDataHashTable != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 49671, 50149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 49745, 49781);

                        f_1536_49745_49780(result, f_1536_49759_49779(streamWriter));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 49805, 50130);
                            foreach (DictionaryEntry entry in f_1536_49839_49859_I(privateDataHashTable))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 49805, 50130);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 49909, 50107);

                                f_1536_49909_50106(result, f_1536_49923_50105(this, f_1536_49940_49960(entry.Key), f_1536_49962_49982(entry.Key), f_1536_49984_50090(this, f_1536_50002_50089(entry.Value, typeof(string), f_1536_50060_50088())), streamWriter));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 49805, 50130);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1536, 1, 326);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1536, 1, 326);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 49671, 50149);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 50169, 50189);

                    f_1536_50169_50188(
                                    result, "} ");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 50207, 50318);

                    f_1536_50207_50317(result, f_1536_50221_50316(this, f_1536_50237_50301(f_1536_50255_50285(), "PrivateData"), streamWriter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 50338, 50361);

                    _indent = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 50381, 50417);

                    f_1536_50381_50416(
                                    result, f_1536_50395_50415(streamWriter));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 46558, 50432);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 46221, 50443);

                object
                f_1536_46367_46378()
                {
                    var return_v = PrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 46367, 46378);
                    return return_v;
                }


                string[]
                f_1536_46441_46445()
                {
                    var return_v = Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 46441, 46445);
                    return return_v;
                }


                string
                f_1536_46457_46469()
                {
                    var return_v = ReleaseNotes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 46457, 46469);
                    return return_v;
                }


                System.Uri
                f_1536_46481_46491()
                {
                    var return_v = ProjectUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 46481, 46491);
                    return return_v;
                }


                System.Uri
                f_1536_46503_46510()
                {
                    var return_v = IconUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 46503, 46510);
                    return return_v;
                }


                System.Uri
                f_1536_46522_46532()
                {
                    var return_v = LicenseUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 46522, 46532);
                    return return_v;
                }


                string
                f_1536_46759_46809()
                {
                    var return_v = Modules.PrivateDataValueTypeShouldBeHashTableError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 46759, 46809);
                    return return_v;
                }


                System.InvalidOperationException
                f_1536_46729_46810(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 46729, 46810);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1536_46842_46948(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 46842, 46948);
                    return return_v;
                }


                int
                f_1536_46971_46996(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 46971, 46996);
                    return 0;
                }


                string
                f_1536_47092_47144()
                {
                    var return_v = Modules.PrivateDataValueTypeShouldBeHashTableWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 47092, 47144);
                    return return_v;
                }


                int
                f_1536_47079_47145(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47079, 47145);
                    return 0;
                }


                string
                f_1536_47219_47238()
                {
                    var return_v = Modules.PrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 47219, 47238);
                    return return_v;
                }


                int
                f_1536_47170_47440(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47170, 47440);
                    return 0;
                }


                string
                f_1536_47556_47575()
                {
                    var return_v = Modules.PrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 47556, 47575);
                    return return_v;
                }


                string
                f_1536_47540_47590(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                insert, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestComment(insert, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47540, 47590);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_47526_47591(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47526, 47591);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_47610_47643(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47610, 47643);
                    return return_v;
                }


                string
                f_1536_47676_47696(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 47676, 47696);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_47662_47697(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47662, 47697);
                    return return_v;
                }


                string
                f_1536_47732_47752(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 47732, 47752);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_47718_47753(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47718, 47753);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_47772_47804(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47772, 47804);
                    return return_v;
                }


                string
                f_1536_47837_47857(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 47837, 47857);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_47823_47858(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47823, 47858);
                    return return_v;
                }


                string
                f_1536_47891_47911(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 47891, 47911);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_47877_47912(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47877, 47912);
                    return return_v;
                }


                string
                f_1536_48016_48028()
                {
                    var return_v = Modules.Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48016, 48028);
                    return return_v;
                }


                string[]
                f_1536_48030_48034()
                {
                    var return_v = Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48030, 48034);
                    return return_v;
                }


                string[]
                f_1536_48046_48050()
                {
                    var return_v = Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48046, 48050);
                    return return_v;
                }


                int
                f_1536_48046_48057(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48046, 48057);
                    return return_v;
                }


                int
                f_1536_47974_48114(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 47974, 48114);
                    return 0;
                }


                string
                f_1536_48181_48199()
                {
                    var return_v = Modules.LicenseUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48181, 48199);
                    return return_v;
                }


                System.Uri
                f_1536_48201_48211()
                {
                    var return_v = LicenseUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48201, 48211);
                    return return_v;
                }


                int
                f_1536_48133_48263(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 48133, 48263);
                    return 0;
                }


                string
                f_1536_48330_48348()
                {
                    var return_v = Modules.ProjectUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48330, 48348);
                    return return_v;
                }


                System.Uri
                f_1536_48350_48360()
                {
                    var return_v = ProjectUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48350, 48360);
                    return return_v;
                }


                int
                f_1536_48282_48412(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 48282, 48412);
                    return 0;
                }


                string
                f_1536_48476_48491()
                {
                    var return_v = Modules.IconUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48476, 48491);
                    return return_v;
                }


                System.Uri
                f_1536_48493_48500()
                {
                    var return_v = IconUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48493, 48500);
                    return return_v;
                }


                int
                f_1536_48431_48549(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 48431, 48549);
                    return 0;
                }


                string
                f_1536_48618_48638()
                {
                    var return_v = Modules.ReleaseNotes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48618, 48638);
                    return return_v;
                }


                string
                f_1536_48662_48674()
                {
                    var return_v = ReleaseNotes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48662, 48674);
                    return return_v;
                }


                bool
                f_1536_48641_48675(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 48641, 48675);
                    return return_v;
                }


                int
                f_1536_48568_48721(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 48568, 48721);
                    return 0;
                }


                string
                f_1536_48788_48806()
                {
                    var return_v = Modules.Prerelease;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48788, 48806);
                    return return_v;
                }


                string
                f_1536_48830_48840()
                {
                    var return_v = Prerelease;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48830, 48840);
                    return return_v;
                }


                bool
                f_1536_48809_48841(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 48809, 48841);
                    return return_v;
                }


                int
                f_1536_48740_48885(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 48740, 48885);
                    return 0;
                }


                string
                f_1536_48966_48998()
                {
                    var return_v = Modules.RequireLicenseAcceptance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 48966, 48998);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1536_49000_49024()
                {
                    var return_v = RequireLicenseAcceptance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 49000, 49024);
                    return return_v;
                }


                int
                f_1536_48904_49124(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 48904, 49124);
                    return 0;
                }


                string
                f_1536_49207_49241()
                {
                    var return_v = Modules.ExternalModuleDependencies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 49207, 49241);
                    return return_v;
                }


                string[]
                f_1536_49243_49269()
                {
                    var return_v = ExternalModuleDependencies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 49243, 49269);
                    return return_v;
                }


                string[]
                f_1536_49281_49307()
                {
                    var return_v = ExternalModuleDependencies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 49281, 49307);
                    return return_v;
                }


                int
                f_1536_49281_49314(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 49281, 49314);
                    return return_v;
                }


                int
                f_1536_49143_49393(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Text.StringBuilder
                result, string
                key, string
                keyDescription, bool
                hasValue, System.Func<string>
                action, System.IO.StreamWriter
                streamWriter)
                {
                    this_param.BuildModuleManifest(result, key, keyDescription, hasValue, action, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49143, 49393);
                    return 0;
                }


                System.Text.StringBuilder
                f_1536_49414_49437(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49414, 49437);
                    return return_v;
                }


                string
                f_1536_49504_49534()
                {
                    var return_v = Modules.EndOfManifestHashTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 49504, 49534);
                    return return_v;
                }


                string
                f_1536_49486_49545(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49486, 49545);
                    return return_v;
                }


                string
                f_1536_49470_49560(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                insert, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestComment(insert, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49470, 49560);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_49456_49561(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49456, 49561);
                    return return_v;
                }


                string
                f_1536_49594_49614(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 49594, 49614);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_49580_49615(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49580, 49615);
                    return return_v;
                }


                string
                f_1536_49759_49779(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 49759, 49779);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_49745_49780(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49745, 49780);
                    return return_v;
                }


                string?
                f_1536_49940_49960(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49940, 49960);
                    return return_v;
                }


                string?
                f_1536_49962_49982(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49962, 49982);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1536_50060_50088()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 50060, 50088);
                    return return_v;
                }


                object
                f_1536_50002_50089(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50002, 50089);
                    return return_v;
                }


                string
                f_1536_49984_50090(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, object
                name)
                {
                    var return_v = this_param.QuoteName((string)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49984, 50090);
                    return return_v;
                }


                string
                f_1536_49923_50105(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                key, string
                resourceString, string
                value, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestFragment(key, resourceString, value, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49923, 50105);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_49909_50106(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49909, 50106);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1536_49839_49859_I(System.Collections.Hashtable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 49839, 49859);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_50169_50188(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50169, 50188);
                    return return_v;
                }


                string
                f_1536_50255_50285()
                {
                    var return_v = Modules.EndOfManifestHashTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 50255, 50285);
                    return return_v;
                }


                string
                f_1536_50237_50301(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50237, 50301);
                    return return_v;
                }


                string
                f_1536_50221_50316(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, string
                insert, System.IO.StreamWriter
                streamWriter)
                {
                    var return_v = this_param.ManifestComment(insert, streamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50221, 50316);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_50207_50317(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50207, 50317);
                    return return_v;
                }


                string
                f_1536_50395_50415(System.IO.StreamWriter
                this_param)
                {
                    var return_v = this_param.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 50395, 50415);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1536_50381_50416(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50381, 50416);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 46221, 50443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 46221, 50443);
            }
        }

        private void ValidateUriParameterValue(Uri uri, string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1536, 50455, 51125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 50549, 50653);

                f_1536_50549_50652(!f_1536_50561_50601(parameterName), "parameterName should not be null or whitespace");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 50669, 51114) || true) && (uri != null && (DynAbs.Tracing.TraceSender.Expression_True(1536, 50673, 50749) && !f_1536_50689_50749(f_1536_50715_50730(uri), UriKind.Absolute)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1536, 50669, 51114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 50783, 50851);

                    var
                    message = f_1536_50797_50850(f_1536_50815_50844(), uri)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 50869, 50918);

                    var
                    ioe = f_1536_50879_50917(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 50936, 51055);

                    var
                    er = f_1536_50945_51054(ioe, "Modules_InvalidUri", ErrorCategory.InvalidArgument, parameterName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 51073, 51099);

                    f_1536_51073_51098(this, er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1536, 50669, 51114);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1536, 50455, 51125);

                bool
                f_1536_50561_50601(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50561, 50601);
                    return return_v;
                }


                int
                f_1536_50549_50652(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50549, 50652);
                    return 0;
                }


                string
                f_1536_50715_50730(System.Uri
                this_param)
                {
                    var return_v = this_param.AbsoluteUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 50715, 50730);
                    return return_v;
                }


                bool
                f_1536_50689_50749(string
                uriString, System.UriKind
                uriKind)
                {
                    var return_v = Uri.IsWellFormedUriString(uriString, uriKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50689, 50749);
                    return return_v;
                }


                string
                f_1536_50815_50844()
                {
                    var return_v = Modules.InvalidParameterValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1536, 50815, 50844);
                    return return_v;
                }


                string
                f_1536_50797_50850(string
                formatSpec, System.Uri
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50797, 50850);
                    return return_v;
                }


                System.InvalidOperationException
                f_1536_50879_50917(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50879, 50917);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1536_50945_51054(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 50945, 51054);
                    return return_v;
                }


                int
                f_1536_51073_51098(Microsoft.PowerShell.Commands.NewModuleManifestCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 51073, 51098);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1536, 50455, 51125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 50455, 51125);
            }
        }

        public NewModuleManifestCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1536, 713, 51132);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 1309, 1314);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 1662, 1676);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 1950, 1972);
            this._guid = Guid.NewGuid();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 2288, 2295);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 2625, 2652);
            this._companyName = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 2987, 2997);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 3343, 3361);
            this._rootModule = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 3684, 3721);
            this._moduleVersion = f_1536_3701_3721(0, 0, 1);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 4041, 4053);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 4502, 4531);
            this._processorArchitecture = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 4867, 4892);
            this._powerShellVersion = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 5199, 5217);
            this._ClrVersion = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 5574, 5604);
            this._DotNetFrameworkVersion = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 5945, 5971);
            this._PowerShellHostName = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 6326, 6355);
            this._PowerShellHostVersion = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 6744, 6760);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 7095, 7101);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 7444, 7452);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 7838, 7846);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 8219, 8238);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 8577, 8587);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 9135, 9146);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 9512, 9530);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 9888, 9904);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 10270, 10311);
            this._exportedVariables = new string[] { "*" };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 10669, 10685);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 11064, 11085);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 11500, 11521);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 11868, 11880);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 11976, 12084);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 12185, 12294);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 12395, 12504);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 12602, 12708);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 12811, 12925);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 13053, 13146);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 13517, 13628);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 13934, 13946);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 14296, 14305);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 14649, 14670);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1536, 14698, 14720);
            this._indent = string.Empty;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1536, 713, 51132);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 713, 51132);
        }


        static NewModuleManifestCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1536, 713, 51132);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1536, 713, 51132);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1536, 713, 51132);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1536, 713, 51132);

        System.Version
        f_1536_3701_3721(int
        major, int
        minor, int
        build)
        {
            var return_v = new System.Version(major, minor, build);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1536, 3701, 3721);
            return return_v;
        }

    }

}
