// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Text;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsCommon.New, "PSSessionConfigurationFile", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096791")]
    public class NewPSSessionConfigurationFileCommand : PSCmdlet
{
[Parameter(Position = 0, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Path
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,1088,1152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,1124,1137);

return _path;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,1088,1152);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,958,1244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,958,1244);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,1168,1233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,1204,1218);

_path = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,1168,1233);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,958,1244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,958,1244);
}
		}}

private string _path;

[Parameter()]
        [ValidateNotNull]
        public Version SchemaVersion
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,1487,1560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,1523,1545);

return _schemaVersion;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,1487,1560);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,1384,1661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,1384,1661);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,1576,1650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,1612,1635);

_schemaVersion = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,1576,1650);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,1384,1661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,1384,1661);
}
		}}

private Version _schemaVersion ;

[Parameter()]
        public Guid Guid
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,1890,1954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,1926,1939);

return _guid;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,1890,1954);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,1826,2046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,1826,2046);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,1970,2035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,2006,2020);

_guid = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,1970,2035);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,1826,2046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,1826,2046);
}
		}}

private Guid _guid ;

[Parameter()]
        public string Author
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,2268,2334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,2304,2319);

return _author;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,2268,2334);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,2200,2428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,2200,2428);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,2350,2417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,2386,2402);

_author = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,2350,2417);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,2200,2428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,2200,2428);
}
		}}

private string _author;

[Parameter()]
        public string Description
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,2621,2692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,2657,2677);

return _description;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,2621,2692);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,2548,2791);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,2548,2791);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,2708,2780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,2744,2765);

_description = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,2708,2780);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,2548,2791);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,2548,2791);
}
		}}

private string _description;

[Parameter()]
        public string CompanyName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,2990,3061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,3026,3046);

return _companyName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,2990,3061);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,2917,3160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,2917,3160);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,3077,3149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,3113,3134);

_companyName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,3077,3149);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,2917,3160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,2917,3160);
}
		}}

private string _companyName;

[Parameter()]
        public string Copyright
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,3366,3435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,3402,3420);

return _copyright;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,3366,3435);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,3295,3532);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,3295,3532);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,3451,3521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,3487,3506);

_copyright = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,3451,3521);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,3295,3532);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,3295,3532);
}
		}}

private string _copyright;

[Parameter()]
        public SessionType SessionType
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,3768,3839);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,3804,3824);

return _sessionType;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,3768,3839);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,3690,3938);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,3690,3938);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,3855,3927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,3891,3912);

_sessionType = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,3855,3927);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,3690,3938);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,3690,3938);
}
		}}

private SessionType _sessionType ;

[Parameter()]
        public string TranscriptDirectory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,4212,4291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,4248,4276);

return _transcriptDirectory;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,4212,4291);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,4131,4398);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,4131,4398);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,4307,4387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,4343,4372);

_transcriptDirectory = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,4307,4387);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,4131,4398);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,4131,4398);
}
		}}

private string _transcriptDirectory ;

[Parameter()]
        public SwitchParameter RunAsVirtualAccount {get; set; }

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] RunAsVirtualAccountGroups {get; set; }

[Parameter()]
        public SwitchParameter MountUserDrive
{            get;
            set;
}

[Parameter()]
        public long UserDriveMaximumSize {get; set; }

[Parameter()]
        public string GroupManagedServiceAccount {get; set; }

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] ScriptsToProcess
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,6860,6936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,6896,6921);

return _scriptsToProcess;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,6860,6936);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,6686,7040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,6686,7040);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,6952,7029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,6988,7014);

_scriptsToProcess = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,6952,7029);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,6686,7040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,6686,7040);
}
		}}

private string[] _scriptsToProcess ;

[Parameter()]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IDictionary RoleDefinitions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,7437,7512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,7473,7497);

return _roleDefinitions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,7437,7512);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,7262,7615);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,7262,7615);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,7528,7604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,7564,7589);

_roleDefinitions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,7528,7604);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,7262,7615);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,7262,7615);
}
		}}

private IDictionary _roleDefinitions;

[Parameter()]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IDictionary RequiredGroups
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,7986,8017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,7992,8015);

return _requiredGroups;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,7986,8017);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,7812,8076);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,7812,8076);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,8033,8065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,8039,8063);

_requiredGroups = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,8033,8065);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,7812,8076);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,7812,8076);
}
		}}

private IDictionary _requiredGroups;

[Parameter()]
        public PSLanguageMode LanguageMode
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,8293,8365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,8329,8350);

return _languageMode;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,8293,8365);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,8211,8515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,8211,8515);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,8381,8504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,8417,8439);

_languageMode = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,8457,8489);

_isLanguageModeSpecified = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,8381,8504);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,8211,8515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,8211,8515);
}
		}}

private PSLanguageMode _languageMode ;

private bool _isLanguageModeSpecified;

[Parameter()]
        public ExecutionPolicy ExecutionPolicy
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,8816,8891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,8852,8876);

return _executionPolicy;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,8816,8891);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,8730,8994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,8730,8994);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,8907,8983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,8943,8968);

_executionPolicy = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,8907,8983);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,8730,8994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,8730,8994);
}
		}}

private ExecutionPolicy _executionPolicy ;

[Parameter()]
        public Version PowerShellVersion
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,9248,9325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,9284,9310);

return _powerShellVersion;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,9248,9325);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,9168,9430);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,9168,9430);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,9341,9419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,9377,9404);

_powerShellVersion = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,9341,9419);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,9168,9430);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,9168,9430);
}
		}}

private Version _powerShellVersion;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public object[] ModulesToImport
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,9751,9826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,9787,9811);

return _modulesToImport;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,9751,9826);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,9578,9929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,9578,9929);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,9842,9918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,9878,9903);

_modulesToImport = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,9842,9918);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,9578,9929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,9578,9929);
}
		}}

private object[] _modulesToImport;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] VisibleAliases
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,10246,10320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,10282,10305);

return _visibleAliases;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,10246,10320);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,10074,10422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,10074,10422);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,10336,10411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,10372,10396);

_visibleAliases = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,10336,10411);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,10074,10422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,10074,10422);
}
		}}

private string[] _visibleAliases ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public object[] VisibleCmdlets
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,10762,10836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,10798,10821);

return _visibleCmdlets;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,10762,10836);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,10590,10938);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,10590,10938);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,10852,10927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,10888,10912);

_visibleCmdlets = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,10852,10927);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,10590,10938);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,10590,10938);
}
		}}

private object[] _visibleCmdlets ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public object[] VisibleFunctions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,11265,11341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,11301,11326);

return _visibleFunctions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,11265,11341);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,11091,11445);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,11091,11445);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,11357,11434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,11393,11419);

_visibleFunctions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,11357,11434);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,11091,11445);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,11091,11445);
}
		}}

private object[] _visibleFunctions ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] VisibleExternalCommands
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,11815,11898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,11851,11883);

return _visibleExternalCommands;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,11815,11898);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,11634,12009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,11634,12009);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,11914,11998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,11950,11983);

_visibleExternalCommands = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,11914,11998);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,11634,12009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,11634,12009);
}
		}}

private string[] _visibleExternalCommands ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] VisibleProviders
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,12354,12430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,12390,12415);

return _visibleProviders;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,12354,12430);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,12180,12534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,12180,12534);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,12446,12523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,12482,12508);

_visibleProviders = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,12446,12523);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,12180,12534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,12180,12534);
}
		}}

private string[] _visibleProviders ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public IDictionary[] AliasDefinitions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,12875,12951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,12911,12936);

return _aliasDefinitions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,12875,12951);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,12696,13055);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,12696,13055);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,12967,13044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,13003,13029);

_aliasDefinitions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,12967,13044);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,12696,13055);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,12696,13055);
}
		}}

private IDictionary[] _aliasDefinitions;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public IDictionary[] FunctionDefinitions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,13382,13461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,13418,13446);

return _functionDefinitions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,13382,13461);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,13200,13568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,13200,13568);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,13477,13557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,13513,13542);

_functionDefinitions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,13477,13557);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,13200,13568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,13200,13568);
}
		}}

private IDictionary[] _functionDefinitions;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public object VariableDefinitions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,13891,13970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,13927,13955);

return _variableDefinitions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,13891,13970);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,13716,14077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,13716,14077);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,13986,14066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,14022,14051);

_variableDefinitions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,13986,14066);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,13716,14077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,13716,14077);
}
		}}

private object _variableDefinitions;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IDictionary EnvironmentVariables
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,14504,14584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,14540,14569);

return _environmentVariables;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,14504,14584);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,14230,14692);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,14230,14692);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,14600,14681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,14636,14666);

_environmentVariables = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,14600,14681);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,14230,14692);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,14230,14692);
}
		}}

private IDictionary _environmentVariables;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] TypesToProcess
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,15018,15092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,15054,15077);

return _typesToProcess;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,15018,15092);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,14846,15194);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,14846,15194);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,15108,15183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,15144,15168);

_typesToProcess = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,15108,15183);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,14846,15194);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,14846,15194);
}
		}}

private string[] _typesToProcess ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] FormatsToProcess
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,15543,15619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,15579,15604);

return _formatsToProcess;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,15543,15619);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,15369,15723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,15369,15723);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,15635,15712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,15671,15697);

_formatsToProcess = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,15635,15712);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,15369,15723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,15369,15723);
}
		}}

private string[] _formatsToProcess ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] AssembliesToLoad
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,16070,16146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,16106,16131);

return _assembliesToLoad;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,16070,16146);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,15896,16250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,15896,16250);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,16162,16239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,16198,16224);

_assembliesToLoad = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,16162,16239);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,15896,16250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,15896,16250);
}
		}}

private string[] _assembliesToLoad;

[Parameter()]
        public SwitchParameter Full {get; set; }

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,16706,45807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,16770,16813);

f_1597_16770_16812(!f_1597_16784_16811(_path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,16829,16858);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,16872,16890);

PSDriveInfo 
drive
=default(PSDriveInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,16904,17008);

string 
filePath = f_1597_16922_17007(f_1597_16922_16939(f_1597_16922_16934()), _path, out provider, out drive)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,17024,17626) || true) && (!f_1597_17029_17082(provider, f_1597_17049_17081(f_1597_17049_17070(f_1597_17049_17056())))||(DynAbs.Tracing.TraceSender.Expression_False(1597, 17028, 17184)||!f_1597_17087_17184(filePath, StringLiterals.PowerShellDISCFileExtension, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,17024,17626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,17218,17322);

string 
message = f_1597_17235_17321(f_1597_17253_17313(), _path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,17340,17411);

InvalidOperationException 
ioe = f_1597_17372_17410(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,17429,17567);

ErrorRecord 
er = f_1597_17446_17566(ioe, "InvalidPSSessionConfigurationFilePath", ErrorCategory.InvalidArgument, _path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,17585,17611);

f_1597_17585_17610(this, er);
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,17024,17626);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,17642,17664);

FileStream 
fileStream
=default(FileStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,17678,17704);

StreamWriter 
streamWriter
=default(StreamWriter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,17718,17744);

FileInfo 
readOnlyFileInfo
=default(FileInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,17804,18231);

f_1597_17804_18230(this, filePath, EncodingConversion.Unicode, false, false, false, false, out fileStream, out streamWriter, out readOnlyFileInfo, false);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,18283,18326);

StringBuilder 
result = f_1597_18306_18325()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,18346,18366);

f_1597_18346_18365(
                result, "@{");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,18384,18420);

f_1597_18384_18419(                result, f_1597_18398_18418(streamWriter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,18438,18474);

f_1597_18438_18473(                result, f_1597_18452_18472(streamWriter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,18529,18764);

f_1597_18529_18763(
                // Schema version
                result, f_1597_18543_18762(ConfigFileConstants.SchemaVersion, f_1597_18619_18666(), f_1597_18689_18740(_schemaVersion), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,18809,18996);

f_1597_18809_18995(
                // Guid
                result, f_1597_18823_18994(ConfigFileConstants.Guid, f_1597_18890_18928(), f_1597_18930_18972(_guid), streamWriter, false));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,19043,19168) || true) && (f_1597_19047_19076(_author))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,19043,19168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,19118,19149);

_author = f_1597_19128_19148();
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,19043,19168);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,19188,19402);

f_1597_19188_19401(
                result, f_1597_19202_19400(ConfigFileConstants.Author, f_1597_19271_19311(), f_1597_19334_19378(_author), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,19454,19712);

f_1597_19454_19711(
                // Description
                result, f_1597_19468_19710(ConfigFileConstants.Description, f_1597_19542_19587(), f_1597_19610_19659(_description), streamWriter, f_1597_19675_19709(_description)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,19765,20289) || true) && (f_1597_19769_19818(this, "CompanyName"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,19765,20289);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,19860,20013) || true) && (f_1597_19864_19898(_companyName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,19860,20013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,19948,19990);

_companyName = f_1597_19963_19989();
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,19860,20013);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,20037,20270);

f_1597_20037_20269(
                    result, f_1597_20051_20268(ConfigFileConstants.CompanyName, f_1597_20125_20170(), f_1597_20197_20246(_companyName), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,19765,20289);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,20339,20884) || true) && (f_1597_20343_20390(this, "Copyright"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,20339,20884);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,20432,20614) || true) && (f_1597_20436_20468(_copyright))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,20432,20614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,20518,20591);

_copyright = f_1597_20531_20590(f_1597_20549_20580(), _author);
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,20432,20614);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,20638,20865);

f_1597_20638_20864(
                    result, f_1597_20652_20863(ConfigFileConstants.Copyright, f_1597_20724_20767(), f_1597_20794_20841(_copyright), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,20339,20884);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,20937,21174);

f_1597_20937_21173(
                // Session type
                result, f_1597_20951_21172(ConfigFileConstants.SessionType, f_1597_21025_21078(), f_1597_21101_21150(_sessionType), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,21194,21219);

string 
resultData = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,21280,21420);

resultData = (DynAbs.Tracing.TraceSender.Conditional_F1(1597, 21293, 21335)||((f_1597_21293_21335(_transcriptDirectory)&&DynAbs.Tracing.TraceSender.Conditional_F2(1597, 21338, 21359))||DynAbs.Tracing.TraceSender.Conditional_F3(1597, 21362, 21419)))?"'C:\\Transcripts\\'" :f_1597_21362_21419(_transcriptDirectory);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,21438,21681);

f_1597_21438_21680(                result, f_1597_21452_21679(ConfigFileConstants.TranscriptDirectory, f_1597_21534_21587(), resultData, streamWriter, f_1597_21636_21678(_transcriptDirectory)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,21744,22007);

f_1597_21744_22006(
                // Run as virtual account
                result, f_1597_21758_22005(ConfigFileConstants.RunAsVirtualAccount, f_1597_21840_21893(), f_1597_21916_21960(true), streamWriter, f_1597_21976_21995()== false));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,22077,22769) || true) && (f_1597_22081_22144(this, "RunAsVirtualAccountGroups"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,22077,22769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,22186,22296);

bool 
haveVirtualAccountGroups = (f_1597_22219_22244()!= null) &&(DynAbs.Tracing.TraceSender.Expression_True(1597, 22218, 22295)&&(f_1597_22258_22290(f_1597_22258_22283())> 0))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,22318,22486);

resultData = (DynAbs.Tracing.TraceSender.Conditional_F1(1597, 22331, 22357)||(((haveVirtualAccountGroups) &&DynAbs.Tracing.TraceSender.Conditional_F2(1597, 22360, 22431))||DynAbs.Tracing.TraceSender.Conditional_F3(1597, 22434, 22485)))?f_1597_22360_22431(f_1597_22405_22430()):"'Remote Desktop Users', 'Remote Management Users'";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,22508,22750);

f_1597_22508_22749(                    result, f_1597_22522_22748(ConfigFileConstants.RunAsVirtualAccountGroups, f_1597_22610_22669(), resultData, streamWriter, !haveVirtualAccountGroups));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,22077,22769);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,22826,23195) || true) && (f_1597_22830_22882(this, "MountUserDrive"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,22826,23195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,22924,23176);

f_1597_22924_23175(                    result, f_1597_22938_23174(ConfigFileConstants.MountUserDrive, f_1597_23015_23063(), f_1597_23090_23134(true), streamWriter, f_1597_23150_23164()== false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,22826,23195);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,23259,23758) || true) && (f_1597_23263_23321(this, "UserDriveMaximumSize"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,23259,23758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,23363,23448);

long 
userDriveMaxSize = (DynAbs.Tracing.TraceSender.Conditional_F1(1597, 23387, 23413)||(((f_1597_23388_23408()> 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(1597, 23416, 23436))||DynAbs.Tracing.TraceSender.Conditional_F3(1597, 23439, 23447)))?f_1597_23416_23436():50000000
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,23470,23739);

f_1597_23470_23738(                    result, f_1597_23484_23737(ConfigFileConstants.UserDriveMaxSize, f_1597_23563_23613(), f_1597_23640_23693(userDriveMaxSize), streamWriter, (f_1597_23710_23730()<= 0)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,23259,23758);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,24336,24932) || true) && (f_1597_24340_24404(this, "GroupManagedServiceAccount"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,24336,24932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,24446,24523);

bool 
haveGMSAAccountName = !f_1597_24474_24522(f_1597_24495_24521())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,24545,24689);

resultData = (DynAbs.Tracing.TraceSender.Conditional_F1(1597, 24558, 24580)||(((!haveGMSAAccountName) &&DynAbs.Tracing.TraceSender.Conditional_F2(1597, 24583, 24622))||DynAbs.Tracing.TraceSender.Conditional_F3(1597, 24625, 24688)))?"'CONTOSO\\GroupManagedServiceAccount'" :f_1597_24625_24688(f_1597_24661_24687());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,24711,24913);

f_1597_24711_24912(                    result, f_1597_24725_24911(ConfigFileConstants.GMSAAccount, f_1597_24799_24837(), resultData, streamWriter, !haveGMSAAccountName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,24336,24932);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,24991,25174);

resultData = (DynAbs.Tracing.TraceSender.Conditional_F1(1597, 25004, 25034)||(((f_1597_25005_25029(_scriptsToProcess)> 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(1597, 25037, 25100))||DynAbs.Tracing.TraceSender.Conditional_F3(1597, 25103, 25173)))?f_1597_25037_25100(_scriptsToProcess):"'C:\\ConfigData\\InitScript1.ps1', 'C:\\ConfigData\\InitScript2.ps1'";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,25192,25418);

f_1597_25192_25417(                result, f_1597_25206_25416(ConfigFileConstants.ScriptsToProcess, f_1597_25285_25335(), resultData, streamWriter, (f_1597_25385_25409(_scriptsToProcess)== 0)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,25475,26408) || true) && (_roleDefinitions == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,25475,26408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,25545,25965);

f_1597_25545_25964(                    result, f_1597_25559_25963(ConfigFileConstants.RoleDefinitions, f_1597_25637_25686(), "@{ 'CONTOSO\\SqlAdmins' = @{ RoleCapabilities = 'SqlAdministration' }; 'CONTOSO\\SqlManaged' = @{ RoleCapabilityFiles = 'C:\\RoleCapability\\SqlManaged.psrc' }; 'CONTOSO\\ServerMonitors' = @{ VisibleCmdlets = 'Get-Process' } } ", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,25475,26408);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,25475,26408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,26047,26099);

f_1597_26047_26098(_roleDefinitions);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,26123,26389);

f_1597_26123_26388(
                    result, f_1597_26137_26387(ConfigFileConstants.RoleDefinitions, f_1597_26215_26264(), f_1597_26291_26365(_roleDefinitions, streamWriter), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,25475,26408);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,26464,27331) || true) && (f_1597_26468_26520(this, "RequiredGroups"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,26464,27331);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,26562,27312) || true) && (_requiredGroups == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,26562,27312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,26639,26929);

f_1597_26639_26928(                        result, f_1597_26653_26927(ConfigFileConstants.RequiredGroups, f_1597_26730_26778(), "@{ And = @{ Or = 'CONTOSO\\SmartCard-Logon1', 'CONTOSO\\SmartCard-Logon2' }, 'Administrators' }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,26562,27312);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,26562,27312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,27027,27289);

f_1597_27027_27288(                        result, f_1597_27041_27287(ConfigFileConstants.RequiredGroups, f_1597_27118_27166(), f_1597_27197_27265(_requiredGroups), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,26562,27312);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,26464,27331);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,27399,28044) || true) && (f_1597_27403_27453(this, "LanguageMode"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,27399,28044);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,27495,27765) || true) && (!_isLanguageModeSpecified)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,27495,27765);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,27574,27742) || true) && (_sessionType == SessionType.Default)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,27574,27742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,27671,27715);

_languageMode = PSLanguageMode.FullLanguage;
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,27574,27742);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,27495,27765);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,27789,28025);

f_1597_27789_28024(
                    result, f_1597_27803_28023(ConfigFileConstants.LanguageMode, f_1597_27878_27924(), f_1597_27951_28001(_languageMode), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,27399,28044);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,28116,28479) || true) && (f_1597_28120_28173(this, "ExecutionPolicy"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,28116,28479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,28215,28460);

f_1597_28215_28459(                    result, f_1597_28229_28458(ConfigFileConstants.ExecutionPolicy, f_1597_28307_28356(), f_1597_28383_28436(_executionPolicy), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,28116,28479);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,28538,28561);

bool 
isExample = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,28581,29171) || true) && (f_1597_28585_28640(this, "PowerShellVersion"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,28581,29171);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,28682,28873) || true) && (_powerShellVersion == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,28682,28873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,28762,28779);

isExample = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,28805,28850);

_powerShellVersion = f_1597_28826_28849();
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,28682,28873);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,28897,29152);

f_1597_28897_29151(
                    result, f_1597_28911_29150(ConfigFileConstants.PowerShellVersion, f_1597_28991_29042(), f_1597_29069_29124(_powerShellVersion), streamWriter, isExample));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,28581,29171);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,29229,30141) || true) && (_modulesToImport == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,29229,30141);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,29299,29755) || true) && (f_1597_29303_29307())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,29299,29755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,29357,29518);

string 
exampleModulesToImport = "'MyCustomModule', @{ ModuleName = 'MyCustomModule'; ModuleVersion = '1.0.0.0'; GUID = '4d30d5f0-cb16-4898-812d-f20a6c596bdf' }"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,29544,29732);

f_1597_29544_29731(                        result, f_1597_29558_29730(ConfigFileConstants.ModulesToImport, f_1597_29636_29685(), exampleModulesToImport, streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,29299,29755);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,29229,30141);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,29229,30141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,29837,30122);

f_1597_29837_30121(                    result, f_1597_29851_30120(ConfigFileConstants.ModulesToImport, f_1597_29929_29978(), f_1597_30005_30098(_modulesToImport, streamWriter, this), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,29229,30141);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,30197,30609) || true) && (f_1597_30201_30253(this, "VisibleAliases"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,30197,30609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,30295,30590);

f_1597_30295_30589(                    result, f_1597_30309_30588(ConfigFileConstants.VisibleAliases, f_1597_30386_30434(), f_1597_30461_30544(_visibleAliases, streamWriter, this), streamWriter, f_1597_30560_30582(_visibleAliases)== 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,30197,30609);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,30665,31586) || true) && ((_visibleCmdlets == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1597, 30669, 30727)||(f_1597_30699_30721(_visibleCmdlets)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,30665,31586);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,30769,31212) || true) && (f_1597_30773_30777())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,30769,31212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,30827,31189);

f_1597_30827_31188(                        result, f_1597_30841_31187(ConfigFileConstants.VisibleCmdlets, f_1597_30918_30966(), "'Invoke-Cmdlet1', @{ Name = 'Invoke-Cmdlet2'; Parameters = @{ Name = 'Parameter1'; ValidateSet = 'Item1', 'Item2' }, @{ Name = 'Parameter2'; ValidatePattern = 'L*' } }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,30769,31212);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,30665,31586);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,30665,31586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,31294,31567);

f_1597_31294_31566(                    result, f_1597_31308_31565(ConfigFileConstants.VisibleCmdlets, f_1597_31385_31433(), f_1597_31460_31543(_visibleCmdlets, streamWriter, this), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,30665,31586);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,31644,32607) || true) && ((_visibleFunctions == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1597, 31648, 31710)||(f_1597_31680_31704(_visibleFunctions)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,31644,32607);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,31752,32203) || true) && (f_1597_31756_31760())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,31752,32203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,31810,32180);

f_1597_31810_32179(                        result, f_1597_31824_32178(ConfigFileConstants.VisibleFunctions, f_1597_31903_31953(), "'Invoke-Function1', @{ Name = 'Invoke-Function2'; Parameters = @{ Name = 'Parameter1'; ValidateSet = 'Item1', 'Item2' }, @{ Name = 'Parameter2'; ValidatePattern = 'L*' } }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,31752,32203);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,31644,32607);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,31644,32607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,32285,32588);

f_1597_32285_32587(                    result, f_1597_32299_32586(ConfigFileConstants.VisibleFunctions, f_1597_32378_32428(), f_1597_32455_32540(_visibleFunctions, streamWriter, this), streamWriter, f_1597_32556_32580(_visibleFunctions)== 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,31644,32607);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,32696,33153) || true) && (f_1597_32700_32761(this, "VisibleExternalCommands"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,32696,33153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,32803,33134);

f_1597_32803_33133(                    result, f_1597_32817_33132(ConfigFileConstants.VisibleExternalCommands, f_1597_32903_32960(), f_1597_32987_33079(_visibleExternalCommands, streamWriter, this), streamWriter, f_1597_33095_33126(_visibleExternalCommands)== 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,32696,33153);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,33211,33633) || true) && (f_1597_33215_33269(this, "VisibleProviders"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,33211,33633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,33311,33614);

f_1597_33311_33613(                    result, f_1597_33325_33612(ConfigFileConstants.VisibleProviders, f_1597_33404_33454(), f_1597_33481_33566(_visibleProviders, streamWriter, this), streamWriter, f_1597_33582_33606(_visibleProviders)== 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,33211,33633);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,33691,34543) || true) && ((_aliasDefinitions == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1597, 33695, 33757)||(f_1597_33727_33751(_aliasDefinitions)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,33691,34543);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,33799,34168) || true) && (f_1597_33803_33807())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,33799,34168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,33857,34145);

f_1597_33857_34144(                        result, f_1597_33871_34143(ConfigFileConstants.AliasDefinitions, f_1597_33950_34000(), "@{ Name = 'Alias1'; Value = 'Invoke-Alias1'}, @{ Name = 'Alias2'; Value = 'Invoke-Alias2'}", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,33799,34168);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,33691,34543);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,33691,34543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,34250,34524);

f_1597_34250_34523(                    result, f_1597_34264_34522(ConfigFileConstants.AliasDefinitions, f_1597_34343_34393(), f_1597_34420_34500(_aliasDefinitions, streamWriter), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,33691,34543);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,34604,38602) || true) && (_functionDefinitions == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,34604,38602);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,34678,35032) || true) && (f_1597_34682_34686())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,34678,35032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,34736,35009);

f_1597_34736_35008(                        result, f_1597_34750_35007(ConfigFileConstants.FunctionDefinitions, f_1597_34832_34885(), "@{ Name = 'MyFunction'; ScriptBlock = { param($MyInput) $MyInput } }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,34678,35032);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,34604,38602);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,34604,38602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,35114,35208);

Hashtable[] 
funcHash = f_1597_35137_35207(_functionDefinitions)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,35232,38583) || true) && (funcHash != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,35232,38583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,35302,35577);

f_1597_35302_35576(                        result, f_1597_35316_35575(ConfigFileConstants.FunctionDefinitions, f_1597_35398_35451(), f_1597_35482_35553(funcHash, streamWriter), streamWriter, false));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,35605,38199);
foreach(Hashtable hashtable in f_1597_35637_35645_I(funcHash) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,35605,38199);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,35703,36174) || true) && (!f_1597_35708_35768(hashtable, ConfigFileConstants.FunctionNameToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,35703,36174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,35834,36072);

PSArgumentException 
e = f_1597_35858_36071(f_1597_35882_36070(f_1597_35900_35945(), ConfigFileConstants.FunctionDefinitions, ConfigFileConstants.FunctionNameToken, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,36106,36143);

f_1597_36106_36142(this, f_1597_36128_36141(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,35703,36174);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,36206,36679) || true) && (!f_1597_36211_36272(hashtable, ConfigFileConstants.FunctionValueToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,36206,36679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,36338,36577);

PSArgumentException 
e = f_1597_36362_36576(f_1597_36386_36575(f_1597_36404_36449(), ConfigFileConstants.FunctionDefinitions, ConfigFileConstants.FunctionValueToken, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,36611,36648);

f_1597_36611_36647(this, f_1597_36633_36646(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,36206,36679);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,36711,37198) || true) && ((f_1597_36716_36765(hashtable, ConfigFileConstants.FunctionValueToken)as ScriptBlock) == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,36711,37198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,36855,37096);

PSArgumentException 
e = f_1597_36879_37095(f_1597_36903_37094(f_1597_36921_36968(), ConfigFileConstants.FunctionValueToken, ConfigFileConstants.FunctionDefinitions, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,37130,37167);

f_1597_37130_37166(this, f_1597_37152_37165(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,36711,37198);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,37230,38172);
foreach(string functionKey in f_1597_37261_37275_I(f_1597_37261_37275(hashtable)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,37230,38172);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,37341,38141) || true) && (!f_1597_37346_37447(functionKey, ConfigFileConstants.FunctionNameToken, StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1597, 37345, 37591)&&                                    !f_1597_37489_37591(functionKey, ConfigFileConstants.FunctionValueToken, StringComparison.OrdinalIgnoreCase))&&(DynAbs.Tracing.TraceSender.Expression_True(1597, 37345, 37737)&&                                    !f_1597_37633_37737(functionKey, ConfigFileConstants.FunctionOptionsToken, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,37341,38141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,37811,38031);

PSArgumentException 
e = f_1597_37835_38030(f_1597_37859_38029(f_1597_37877_37926(), functionKey, ConfigFileConstants.FunctionDefinitions, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,38069,38106);

f_1597_38069_38105(this, f_1597_38091_38104(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,37341,38141);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,37230,38172);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,943);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,943);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1597,35605,38199);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,2595);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,2595);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1597,35232,38583);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,35232,38583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,38297,38497);

PSArgumentException 
e = f_1597_38321_38496(f_1597_38345_38495(f_1597_38363_38414(), ConfigFileConstants.FunctionDefinitions, filePath))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,38523,38560);

f_1597_38523_38559(this, f_1597_38545_38558(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,35232,38583);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,34604,38602);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,38663,42665) || true) && (_variableDefinitions == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,38663,42665);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,38737,39141) || true) && (f_1597_38741_38745())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,38737,39141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,38795,39118);

f_1597_38795_39117(                        result, f_1597_38809_39116(ConfigFileConstants.VariableDefinitions, f_1597_38891_38944(), "@{ Name = 'Variable1'; Value = { 'Dynamic' + 'InitialValue' } }, @{ Name = 'Variable2'; Value = 'StaticInitialValue' }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,38737,39141);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,38663,42665);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,38663,42665);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,39223,39273);

string 
varString = _variableDefinitions as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,39297,42646) || true) && (varString != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,39297,42646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,39368,39581);

f_1597_39368_39580(                        result, f_1597_39382_39579(ConfigFileConstants.VariableDefinitions, f_1597_39464_39517(), varString, streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,39297,42646);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,39297,42646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,39679,39772);

Hashtable[] 
varHash = f_1597_39701_39771(_variableDefinitions)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,39800,42623) || true) && (varHash != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,39800,42623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,39877,40155);

f_1597_39877_40154(                            result, f_1597_39891_40153(ConfigFileConstants.VariableDefinitions, f_1597_39973_40026(), f_1597_40061_40131(varHash, streamWriter), streamWriter, false));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,40187,42211);
foreach(Hashtable hashtable in f_1597_40219_40226_I(varHash) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,40187,42211);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,40292,40783) || true) && (!f_1597_40297_40357(hashtable, ConfigFileConstants.VariableNameToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,40292,40783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,40431,40673);

PSArgumentException 
e = f_1597_40455_40672(f_1597_40479_40671(f_1597_40497_40542(), ConfigFileConstants.VariableDefinitions, ConfigFileConstants.VariableNameToken, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,40711,40748);

f_1597_40711_40747(this, f_1597_40733_40746(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,40292,40783);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,40819,41312) || true) && (!f_1597_40824_40885(hashtable, ConfigFileConstants.VariableValueToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,40819,41312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,40959,41202);

PSArgumentException 
e = f_1597_40983_41201(f_1597_41007_41200(f_1597_41025_41070(), ConfigFileConstants.VariableDefinitions, ConfigFileConstants.VariableValueToken, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,41240,41277);

f_1597_41240_41276(this, f_1597_41262_41275(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,40819,41312);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,41348,42180);
foreach(string variableKey in f_1597_41379_41393_I(f_1597_41379_41393(hashtable)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,41348,42180);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,41467,42145) || true) && (!f_1597_41472_41573(variableKey, ConfigFileConstants.VariableNameToken, StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1597, 41471, 41721)&&                                        !f_1597_41619_41721(variableKey, ConfigFileConstants.VariableValueToken, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,41467,42145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,41803,42027);

PSArgumentException 
e = f_1597_41827_42026(f_1597_41851_42025(f_1597_41869_41918(), variableKey, ConfigFileConstants.VariableDefinitions, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,42069,42106);

f_1597_42069_42105(this, f_1597_42091_42104(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,41467,42145);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,41348,42180);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,833);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,833);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1597,40187,42211);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,2025);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,2025);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1597,39800,42623);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,39800,42623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,42325,42529);

PSArgumentException 
e = f_1597_42349_42528(f_1597_42373_42527(f_1597_42391_42442(), ConfigFileConstants.VariableDefinitions, filePath))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,42559,42596);

f_1597_42559_42595(this, f_1597_42581_42594(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,39800,42623);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,39297,42646);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,38663,42665);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,42727,43548) || true) && (_environmentVariables == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,42727,43548);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,42802,43166) || true) && (f_1597_42806_42810())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,42802,43166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,42860,43143);

f_1597_42860_43142(                        result, f_1597_42874_43141(ConfigFileConstants.EnvironmentVariables, f_1597_42957_43011(), "@{ Variable1 = 'Value1'; Variable2 = 'Value2' }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,42802,43166);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,42727,43548);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,42727,43548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,43248,43529);

f_1597_43248_43528(                    result, f_1597_43262_43527(ConfigFileConstants.EnvironmentVariables, f_1597_43345_43399(), f_1597_43426_43505(_environmentVariables, streamWriter), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,42727,43548);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,43605,44148) || true) && (f_1597_43609_43661(this, "TypesToProcess"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,43605,44148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,43703,43883);

resultData = (DynAbs.Tracing.TraceSender.Conditional_F1(1597, 43716, 43744)||(((f_1597_43717_43739(_typesToProcess)> 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(1597, 43747, 43808))||DynAbs.Tracing.TraceSender.Conditional_F3(1597, 43811, 43882)))?f_1597_43747_43808(_typesToProcess):"'C:\\ConfigData\\MyTypes.ps1xml', 'C:\\ConfigData\\OtherTypes.ps1xml'";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,43905,44129);

f_1597_43905_44128(                    result, f_1597_43919_44127(ConfigFileConstants.TypesToProcess, f_1597_43996_44044(), resultData, streamWriter, (f_1597_44098_44120(_typesToProcess)== 0)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,43605,44148);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,44207,44766) || true) && (f_1597_44211_44265(this, "FormatsToProcess"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,44207,44766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,44307,44495);

resultData = (DynAbs.Tracing.TraceSender.Conditional_F1(1597, 44320, 44350)||(((f_1597_44321_44345(_formatsToProcess)> 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(1597, 44353, 44416))||DynAbs.Tracing.TraceSender.Conditional_F3(1597, 44419, 44494)))?f_1597_44353_44416(_formatsToProcess):"'C:\\ConfigData\\MyFormats.ps1xml', 'C:\\ConfigData\\OtherFormats.ps1xml'";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,44517,44747);

f_1597_44517_44746(                    result, f_1597_44531_44745(ConfigFileConstants.FormatsToProcess, f_1597_44610_44660(), resultData, streamWriter, (f_1597_44714_44738(_formatsToProcess)== 0)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,44207,44766);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,44825,45592) || true) && (f_1597_44829_44883(this, "AssembliesToLoad"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,44825,45592);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,44925,44943);

isExample = false;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,44965,45288) || true) && ((_assembliesToLoad == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1597, 44969, 45031)||(f_1597_45001_45025(_assembliesToLoad)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,44965,45288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,45081,45098);

isExample = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,45124,45265);

_assembliesToLoad = new string[] { "System.Web", "System.OtherAssembly, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" };
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,44965,45288);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,45312,45573);

f_1597_45312_45572(
                    result, f_1597_45326_45571(ConfigFileConstants.AssembliesToLoad, f_1597_45405_45455(), f_1597_45482_45545(_assembliesToLoad), streamWriter, isExample));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,44825,45592);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,45612,45631);

f_1597_45612_45630(
                result, "}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,45651,45689);

f_1597_45651_45688(
                streamWriter, f_1597_45670_45687(result));
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1597,45718,45796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,45758,45781);

f_1597_45758_45780(                streamWriter);
DynAbs.Tracing.TraceSender.TraceExitFinally(1597,45718,45796);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,16706,45807);

bool
f_1597_16784_16811(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 16784, 16811);
return return_v;
}


int
f_1597_16770_16812(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 16770, 16812);
return 0;
}


System.Management.Automation.SessionState
f_1597_16922_16934()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 16922, 16934);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1597_16922_16939(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 16922, 16939);
return return_v;
}


string
f_1597_16922_17007(System.Management.Automation.PathIntrinsics
this_param,string
path,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetUnresolvedProviderPathFromPSPath( path, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 16922, 17007);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1597_17049_17056()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 17049, 17056);
return return_v;
}


System.Management.Automation.ProviderNames
f_1597_17049_17070(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 17049, 17070);
return return_v;
}


string
f_1597_17049_17081(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 17049, 17081);
return return_v;
}


bool
f_1597_17029_17082(System.Management.Automation.ProviderInfo
this_param,string
providerName)
{
var return_v = this_param.NameEquals( providerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 17029, 17082);
return return_v;
}


bool
f_1597_17087_17184(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 17087, 17184);
return return_v;
}


string
f_1597_17253_17313()
{
var return_v = RemotingErrorIdStrings.InvalidPSSessionConfigurationFilePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 17253, 17313);
return return_v;
}


string
f_1597_17235_17321(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 17235, 17321);
return return_v;
}


System.InvalidOperationException
f_1597_17372_17410(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 17372, 17410);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_17446_17566(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 17446, 17566);
return return_v;
}


int
f_1597_17585_17610(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 17585, 17610);
return 0;
}


int
f_1597_17804_18230(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
cmdlet,string
filePath,string
encoding,bool
defaultEncoding,bool
Append,bool
Force,bool
NoClobber,out System.IO.FileStream
fileStream,out System.IO.StreamWriter
streamWriter,out System.IO.FileInfo
readOnlyFileInfo,bool
isLiteralPath)
{
PathUtils.MasterStreamOpen( (System.Management.Automation.PSCmdlet)cmdlet, filePath, encoding, defaultEncoding, Append, Force, NoClobber, out fileStream, out streamWriter, out readOnlyFileInfo, isLiteralPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 17804, 18230);
return 0;
}


System.Text.StringBuilder
f_1597_18306_18325()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 18306, 18325);
return return_v;
}


System.Text.StringBuilder
f_1597_18346_18365(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 18346, 18365);
return return_v;
}


string
f_1597_18398_18418(System.IO.StreamWriter
this_param)
{
var return_v = this_param.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 18398, 18418);
return return_v;
}


System.Text.StringBuilder
f_1597_18384_18419(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 18384, 18419);
return return_v;
}


string
f_1597_18452_18472(System.IO.StreamWriter
this_param)
{
var return_v = this_param.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 18452, 18472);
return return_v;
}


System.Text.StringBuilder
f_1597_18438_18473(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 18438, 18473);
return return_v;
}


string
f_1597_18619_18666()
{
var return_v = RemotingErrorIdStrings.DISCSchemaVersionComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 18619, 18666);
return return_v;
}


string
f_1597_18689_18740(System.Version
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 18689, 18740);
return return_v;
}


string
f_1597_18543_18762(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 18543, 18762);
return return_v;
}


System.Text.StringBuilder
f_1597_18529_18763(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 18529, 18763);
return return_v;
}


string
f_1597_18890_18928()
{
var return_v = RemotingErrorIdStrings.DISCGUIDComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 18890, 18928);
return return_v;
}


string
f_1597_18930_18972(System.Guid
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 18930, 18972);
return return_v;
}


string
f_1597_18823_18994(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 18823, 18994);
return return_v;
}


System.Text.StringBuilder
f_1597_18809_18995(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 18809, 18995);
return return_v;
}


bool
f_1597_19047_19076(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 19047, 19076);
return return_v;
}


string
f_1597_19128_19148()
{
var return_v = Environment.UserName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 19128, 19148);
return return_v;
}


string
f_1597_19271_19311()
{
var return_v = RemotingErrorIdStrings.DISCAuthorComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 19271, 19311);
return return_v;
}


string
f_1597_19334_19378(string
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 19334, 19378);
return return_v;
}


string
f_1597_19202_19400(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 19202, 19400);
return return_v;
}


System.Text.StringBuilder
f_1597_19188_19401(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 19188, 19401);
return return_v;
}


string
f_1597_19542_19587()
{
var return_v = RemotingErrorIdStrings.DISCDescriptionComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 19542, 19587);
return return_v;
}


string
f_1597_19610_19659(string
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 19610, 19659);
return return_v;
}


bool
f_1597_19675_19709(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 19675, 19709);
return return_v;
}


string
f_1597_19468_19710(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 19468, 19710);
return return_v;
}


System.Text.StringBuilder
f_1597_19454_19711(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 19454, 19711);
return return_v;
}


bool
f_1597_19769_19818(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 19769, 19818);
return return_v;
}


bool
f_1597_19864_19898(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 19864, 19898);
return return_v;
}


string
f_1597_19963_19989()
{
var return_v = Modules.DefaultCompanyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 19963, 19989);
return return_v;
}


string
f_1597_20125_20170()
{
var return_v = RemotingErrorIdStrings.DISCCompanyNameComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 20125, 20170);
return return_v;
}


string
f_1597_20197_20246(string
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20197, 20246);
return return_v;
}


string
f_1597_20051_20268(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20051, 20268);
return return_v;
}


System.Text.StringBuilder
f_1597_20037_20269(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20037, 20269);
return return_v;
}


bool
f_1597_20343_20390(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20343, 20390);
return return_v;
}


bool
f_1597_20436_20468(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20436, 20468);
return return_v;
}


string
f_1597_20549_20580()
{
var return_v = Modules.DefaultCopyrightMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 20549, 20580);
return return_v;
}


string
f_1597_20531_20590(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20531, 20590);
return return_v;
}


string
f_1597_20724_20767()
{
var return_v = RemotingErrorIdStrings.DISCCopyrightComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 20724, 20767);
return return_v;
}


string
f_1597_20794_20841(string
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20794, 20841);
return return_v;
}


string
f_1597_20652_20863(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20652, 20863);
return return_v;
}


System.Text.StringBuilder
f_1597_20638_20864(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20638, 20864);
return return_v;
}


string
f_1597_21025_21078()
{
var return_v = RemotingErrorIdStrings.DISCInitialSessionStateComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 21025, 21078);
return return_v;
}


string
f_1597_21101_21150(System.Management.Automation.Remoting.SessionType
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 21101, 21150);
return return_v;
}


string
f_1597_20951_21172(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20951, 21172);
return return_v;
}


System.Text.StringBuilder
f_1597_20937_21173(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 20937, 21173);
return return_v;
}


bool
f_1597_21293_21335(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 21293, 21335);
return return_v;
}


string
f_1597_21362_21419(string
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 21362, 21419);
return return_v;
}


string
f_1597_21534_21587()
{
var return_v = RemotingErrorIdStrings.DISCTranscriptDirectoryComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 21534, 21587);
return return_v;
}


bool
f_1597_21636_21678(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 21636, 21678);
return return_v;
}


string
f_1597_21452_21679(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 21452, 21679);
return return_v;
}


System.Text.StringBuilder
f_1597_21438_21680(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 21438, 21680);
return return_v;
}


string
f_1597_21840_21893()
{
var return_v = RemotingErrorIdStrings.DISCRunAsVirtualAccountComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 21840, 21893);
return return_v;
}


string
f_1597_21916_21960(bool
booleanToEmit)
{
var return_v = SessionConfigurationUtils.WriteBoolean( booleanToEmit);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 21916, 21960);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1597_21976_21995()
{
var return_v = RunAsVirtualAccount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 21976, 21995);
return return_v;
}


string
f_1597_21758_22005(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 21758, 22005);
return return_v;
}


System.Text.StringBuilder
f_1597_21744_22006(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 21744, 22006);
return return_v;
}


bool
f_1597_22081_22144(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 22081, 22144);
return return_v;
}


string[]
f_1597_22219_22244()
{
var return_v = RunAsVirtualAccountGroups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 22219, 22244);
return return_v;
}


string[]
f_1597_22258_22283()
{
var return_v = RunAsVirtualAccountGroups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 22258, 22283);
return return_v;
}


int
f_1597_22258_22290(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 22258, 22290);
return return_v;
}


string[]
f_1597_22405_22430()
{
var return_v = RunAsVirtualAccountGroups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 22405, 22430);
return return_v;
}


string
f_1597_22360_22431(string[]
values)
{
var return_v = SessionConfigurationUtils.CombineStringArray( values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 22360, 22431);
return return_v;
}


string
f_1597_22610_22669()
{
var return_v = RemotingErrorIdStrings.DISCRunAsVirtualAccountGroupsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 22610, 22669);
return return_v;
}


string
f_1597_22522_22748(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 22522, 22748);
return return_v;
}


System.Text.StringBuilder
f_1597_22508_22749(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 22508, 22749);
return return_v;
}


bool
f_1597_22830_22882(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 22830, 22882);
return return_v;
}


string
f_1597_23015_23063()
{
var return_v = RemotingErrorIdStrings.DISCMountUserDriveComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 23015, 23063);
return return_v;
}


string
f_1597_23090_23134(bool
booleanToEmit)
{
var return_v = SessionConfigurationUtils.WriteBoolean( booleanToEmit);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 23090, 23134);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1597_23150_23164()
{
var return_v = MountUserDrive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 23150, 23164);
return return_v;
}


string
f_1597_22938_23174(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 22938, 23174);
return return_v;
}


System.Text.StringBuilder
f_1597_22924_23175(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 22924, 23175);
return return_v;
}


bool
f_1597_23263_23321(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 23263, 23321);
return return_v;
}


long
f_1597_23388_23408()
{
var return_v = UserDriveMaximumSize;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 23388, 23408);
return return_v;
}


long
f_1597_23416_23436()
{
var return_v = UserDriveMaximumSize;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 23416, 23436);
return return_v;
}


string
f_1597_23563_23613()
{
var return_v = RemotingErrorIdStrings.DISCUserDriveMaxSizeComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 23563, 23613);
return return_v;
}


string
f_1597_23640_23693(long
longToEmit)
{
var return_v = SessionConfigurationUtils.WriteLong( longToEmit);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 23640, 23693);
return return_v;
}


long
f_1597_23710_23730()
{
var return_v = UserDriveMaximumSize;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 23710, 23730);
return return_v;
}


string
f_1597_23484_23737(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 23484, 23737);
return return_v;
}


System.Text.StringBuilder
f_1597_23470_23738(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 23470, 23738);
return return_v;
}


bool
f_1597_24340_24404(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 24340, 24404);
return return_v;
}


string
f_1597_24495_24521()
{
var return_v = GroupManagedServiceAccount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 24495, 24521);
return return_v;
}


bool
f_1597_24474_24522(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 24474, 24522);
return return_v;
}


string
f_1597_24661_24687()
{
var return_v = GroupManagedServiceAccount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 24661, 24687);
return return_v;
}


string
f_1597_24625_24688(string
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 24625, 24688);
return return_v;
}


string
f_1597_24799_24837()
{
var return_v = RemotingErrorIdStrings.DISCGMSAComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 24799, 24837);
return return_v;
}


string
f_1597_24725_24911(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 24725, 24911);
return return_v;
}


System.Text.StringBuilder
f_1597_24711_24912(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 24711, 24912);
return return_v;
}


int
f_1597_25005_25029(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 25005, 25029);
return return_v;
}


string
f_1597_25037_25100(string[]
values)
{
var return_v = SessionConfigurationUtils.CombineStringArray( values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 25037, 25100);
return return_v;
}


string
f_1597_25285_25335()
{
var return_v = RemotingErrorIdStrings.DISCScriptsToProcessComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 25285, 25335);
return return_v;
}


int
f_1597_25385_25409(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 25385, 25409);
return return_v;
}


string
f_1597_25206_25416(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 25206, 25416);
return return_v;
}


System.Text.StringBuilder
f_1597_25192_25417(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 25192, 25417);
return return_v;
}


string
f_1597_25637_25686()
{
var return_v = RemotingErrorIdStrings.DISCRoleDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 25637, 25686);
return return_v;
}


string
f_1597_25559_25963(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 25559, 25963);
return return_v;
}


System.Text.StringBuilder
f_1597_25545_25964(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 25545, 25964);
return return_v;
}


int
f_1597_26047_26098(System.Collections.IDictionary
roleDefinitions)
{
DISCUtils.ValidateRoleDefinitions( roleDefinitions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 26047, 26098);
return 0;
}


string
f_1597_26215_26264()
{
var return_v = RemotingErrorIdStrings.DISCRoleDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 26215, 26264);
return return_v;
}


string
f_1597_26291_26365(System.Collections.IDictionary
table,System.IO.StreamWriter
writer)
{
var return_v = SessionConfigurationUtils.CombineHashtable( table, writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 26291, 26365);
return return_v;
}


string
f_1597_26137_26387(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 26137, 26387);
return return_v;
}


System.Text.StringBuilder
f_1597_26123_26388(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 26123, 26388);
return return_v;
}


bool
f_1597_26468_26520(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 26468, 26520);
return return_v;
}


string
f_1597_26730_26778()
{
var return_v = RemotingErrorIdStrings.DISCRequiredGroupsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 26730, 26778);
return return_v;
}


string
f_1597_26653_26927(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 26653, 26927);
return return_v;
}


System.Text.StringBuilder
f_1597_26639_26928(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 26639, 26928);
return return_v;
}


string
f_1597_27118_27166()
{
var return_v = RemotingErrorIdStrings.DISCRequiredGroupsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 27118, 27166);
return return_v;
}


string
f_1597_27197_27265(System.Collections.IDictionary
table)
{
var return_v = SessionConfigurationUtils.CombineRequiredGroupsHash( table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 27197, 27265);
return return_v;
}


string
f_1597_27041_27287(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 27041, 27287);
return return_v;
}


System.Text.StringBuilder
f_1597_27027_27288(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 27027, 27288);
return return_v;
}


bool
f_1597_27403_27453(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 27403, 27453);
return return_v;
}


string
f_1597_27878_27924()
{
var return_v = RemotingErrorIdStrings.DISCLanguageModeComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 27878, 27924);
return return_v;
}


string
f_1597_27951_28001(System.Management.Automation.PSLanguageMode
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 27951, 28001);
return return_v;
}


string
f_1597_27803_28023(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 27803, 28023);
return return_v;
}


System.Text.StringBuilder
f_1597_27789_28024(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 27789, 28024);
return return_v;
}


bool
f_1597_28120_28173(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 28120, 28173);
return return_v;
}


string
f_1597_28307_28356()
{
var return_v = RemotingErrorIdStrings.DISCExecutionPolicyComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 28307, 28356);
return return_v;
}


string
f_1597_28383_28436(Microsoft.PowerShell.ExecutionPolicy
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 28383, 28436);
return return_v;
}


string
f_1597_28229_28458(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 28229, 28458);
return return_v;
}


System.Text.StringBuilder
f_1597_28215_28459(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 28215, 28459);
return return_v;
}


bool
f_1597_28585_28640(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 28585, 28640);
return return_v;
}


System.Version
f_1597_28826_28849()
{
var return_v = PSVersionInfo.PSVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 28826, 28849);
return return_v;
}


string
f_1597_28991_29042()
{
var return_v = RemotingErrorIdStrings.DISCPowerShellVersionComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 28991, 29042);
return return_v;
}


string
f_1597_29069_29124(System.Version
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 29069, 29124);
return return_v;
}


string
f_1597_28911_29150(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 28911, 29150);
return return_v;
}


System.Text.StringBuilder
f_1597_28897_29151(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 28897, 29151);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1597_29303_29307()
{
var return_v = Full;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 29303, 29307);
return return_v;
}


string
f_1597_29636_29685()
{
var return_v = RemotingErrorIdStrings.DISCModulesToImportComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 29636, 29685);
return return_v;
}


string
f_1597_29558_29730(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 29558, 29730);
return return_v;
}


System.Text.StringBuilder
f_1597_29544_29731(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 29544, 29731);
return return_v;
}


string
f_1597_29929_29978()
{
var return_v = RemotingErrorIdStrings.DISCModulesToImportComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 29929, 29978);
return return_v;
}


string
f_1597_30005_30098(object[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
caller)
{
var return_v = SessionConfigurationUtils.CombineHashTableOrStringArray( values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 30005, 30098);
return return_v;
}


string
f_1597_29851_30120(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 29851, 30120);
return return_v;
}


System.Text.StringBuilder
f_1597_29837_30121(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 29837, 30121);
return return_v;
}


bool
f_1597_30201_30253(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 30201, 30253);
return return_v;
}


string
f_1597_30386_30434()
{
var return_v = RemotingErrorIdStrings.DISCVisibleAliasesComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 30386, 30434);
return return_v;
}


string
f_1597_30461_30544(string[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
caller)
{
var return_v = SessionConfigurationUtils.GetVisibilityDefault( (object[])values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 30461, 30544);
return return_v;
}


int
f_1597_30560_30582(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 30560, 30582);
return return_v;
}


string
f_1597_30309_30588(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 30309, 30588);
return return_v;
}


System.Text.StringBuilder
f_1597_30295_30589(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 30295, 30589);
return return_v;
}


int
f_1597_30699_30721(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 30699, 30721);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1597_30773_30777()
{
var return_v = Full;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 30773, 30777);
return return_v;
}


string
f_1597_30918_30966()
{
var return_v = RemotingErrorIdStrings.DISCVisibleCmdletsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 30918, 30966);
return return_v;
}


string
f_1597_30841_31187(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 30841, 31187);
return return_v;
}


System.Text.StringBuilder
f_1597_30827_31188(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 30827, 31188);
return return_v;
}


string
f_1597_31385_31433()
{
var return_v = RemotingErrorIdStrings.DISCVisibleCmdletsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 31385, 31433);
return return_v;
}


string
f_1597_31460_31543(object[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
caller)
{
var return_v = SessionConfigurationUtils.GetVisibilityDefault( values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 31460, 31543);
return return_v;
}


string
f_1597_31308_31565(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 31308, 31565);
return return_v;
}


System.Text.StringBuilder
f_1597_31294_31566(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 31294, 31566);
return return_v;
}


int
f_1597_31680_31704(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 31680, 31704);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1597_31756_31760()
{
var return_v = Full;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 31756, 31760);
return return_v;
}


string
f_1597_31903_31953()
{
var return_v = RemotingErrorIdStrings.DISCVisibleFunctionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 31903, 31953);
return return_v;
}


string
f_1597_31824_32178(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 31824, 32178);
return return_v;
}


System.Text.StringBuilder
f_1597_31810_32179(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 31810, 32179);
return return_v;
}


string
f_1597_32378_32428()
{
var return_v = RemotingErrorIdStrings.DISCVisibleFunctionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 32378, 32428);
return return_v;
}


string
f_1597_32455_32540(object[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
caller)
{
var return_v = SessionConfigurationUtils.GetVisibilityDefault( values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 32455, 32540);
return return_v;
}


int
f_1597_32556_32580(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 32556, 32580);
return return_v;
}


string
f_1597_32299_32586(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 32299, 32586);
return return_v;
}


System.Text.StringBuilder
f_1597_32285_32587(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 32285, 32587);
return return_v;
}


bool
f_1597_32700_32761(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 32700, 32761);
return return_v;
}


string
f_1597_32903_32960()
{
var return_v = RemotingErrorIdStrings.DISCVisibleExternalCommandsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 32903, 32960);
return return_v;
}


string
f_1597_32987_33079(string[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
caller)
{
var return_v = SessionConfigurationUtils.GetVisibilityDefault( (object[])values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 32987, 33079);
return return_v;
}


int
f_1597_33095_33126(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 33095, 33126);
return return_v;
}


string
f_1597_32817_33132(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 32817, 33132);
return return_v;
}


System.Text.StringBuilder
f_1597_32803_33133(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 32803, 33133);
return return_v;
}


bool
f_1597_33215_33269(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 33215, 33269);
return return_v;
}


string
f_1597_33404_33454()
{
var return_v = RemotingErrorIdStrings.DISCVisibleProvidersComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 33404, 33454);
return return_v;
}


string
f_1597_33481_33566(string[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
caller)
{
var return_v = SessionConfigurationUtils.GetVisibilityDefault( (object[])values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 33481, 33566);
return return_v;
}


int
f_1597_33582_33606(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 33582, 33606);
return return_v;
}


string
f_1597_33325_33612(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 33325, 33612);
return return_v;
}


System.Text.StringBuilder
f_1597_33311_33613(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 33311, 33613);
return return_v;
}


int
f_1597_33727_33751(System.Collections.IDictionary[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 33727, 33751);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1597_33803_33807()
{
var return_v = Full;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 33803, 33807);
return return_v;
}


string
f_1597_33950_34000()
{
var return_v = RemotingErrorIdStrings.DISCAliasDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 33950, 34000);
return return_v;
}


string
f_1597_33871_34143(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 33871, 34143);
return return_v;
}


System.Text.StringBuilder
f_1597_33857_34144(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 33857, 34144);
return return_v;
}


string
f_1597_34343_34393()
{
var return_v = RemotingErrorIdStrings.DISCAliasDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 34343, 34393);
return return_v;
}


string
f_1597_34420_34500(System.Collections.IDictionary[]
tables,System.IO.StreamWriter
writer)
{
var return_v = SessionConfigurationUtils.CombineHashtableArray( tables, writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 34420, 34500);
return return_v;
}


string
f_1597_34264_34522(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 34264, 34522);
return return_v;
}


System.Text.StringBuilder
f_1597_34250_34523(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 34250, 34523);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1597_34682_34686()
{
var return_v = Full;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 34682, 34686);
return return_v;
}


string
f_1597_34832_34885()
{
var return_v = RemotingErrorIdStrings.DISCFunctionDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 34832, 34885);
return return_v;
}


string
f_1597_34750_35007(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 34750, 35007);
return return_v;
}


System.Text.StringBuilder
f_1597_34736_35008(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 34736, 35008);
return return_v;
}


System.Collections.Hashtable[]
f_1597_35137_35207(System.Collections.IDictionary[]
hashObj)
{
var return_v = DISCPowerShellConfiguration.TryGetHashtableArray( (object)hashObj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 35137, 35207);
return return_v;
}


string
f_1597_35398_35451()
{
var return_v = RemotingErrorIdStrings.DISCFunctionDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 35398, 35451);
return return_v;
}


string
f_1597_35482_35553(System.Collections.Hashtable[]
tables,System.IO.StreamWriter
writer)
{
var return_v = SessionConfigurationUtils.CombineHashtableArray( (System.Collections.IDictionary[])tables, writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 35482, 35553);
return return_v;
}


string
f_1597_35316_35575(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 35316, 35575);
return return_v;
}


System.Text.StringBuilder
f_1597_35302_35576(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 35302, 35576);
return return_v;
}


bool
f_1597_35708_35768(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 35708, 35768);
return return_v;
}


string
f_1597_35900_35945()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 35900, 35945);
return return_v;
}


string
f_1597_35882_36070(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 35882, 36070);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_35858_36071(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 35858, 36071);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_36128_36141(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 36128, 36141);
return return_v;
}


int
f_1597_36106_36142(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 36106, 36142);
return 0;
}


bool
f_1597_36211_36272(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 36211, 36272);
return return_v;
}


string
f_1597_36404_36449()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 36404, 36449);
return return_v;
}


string
f_1597_36386_36575(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 36386, 36575);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_36362_36576(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 36362, 36576);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_36633_36646(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 36633, 36646);
return return_v;
}


int
f_1597_36611_36647(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 36611, 36647);
return 0;
}


object
f_1597_36716_36765(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 36716, 36765);
return return_v;
}


string
f_1597_36921_36968()
{
var return_v = RemotingErrorIdStrings.DISCKeyMustBeScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 36921, 36968);
return return_v;
}


string
f_1597_36903_37094(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 36903, 37094);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_36879_37095(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 36879, 37095);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_37152_37165(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 37152, 37165);
return return_v;
}


int
f_1597_37130_37166(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 37130, 37166);
return 0;
}


System.Collections.ICollection
f_1597_37261_37275(System.Collections.Hashtable
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 37261, 37275);
return return_v;
}


bool
f_1597_37346_37447(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 37346, 37447);
return return_v;
}


bool
f_1597_37489_37591(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 37489, 37591);
return return_v;
}


bool
f_1597_37633_37737(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 37633, 37737);
return return_v;
}


string
f_1597_37877_37926()
{
var return_v = RemotingErrorIdStrings.DISCTypeContainsInvalidKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 37877, 37926);
return return_v;
}


string
f_1597_37859_38029(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 37859, 38029);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_37835_38030(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 37835, 38030);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_38091_38104(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 38091, 38104);
return return_v;
}


int
f_1597_38069_38105(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 38069, 38105);
return 0;
}


System.Collections.ICollection
f_1597_37261_37275_I(System.Collections.ICollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 37261, 37275);
return return_v;
}


System.Collections.Hashtable[]
f_1597_35637_35645_I(System.Collections.Hashtable[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 35637, 35645);
return return_v;
}


string
f_1597_38363_38414()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustBeHashtableArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 38363, 38414);
return return_v;
}


string
f_1597_38345_38495(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 38345, 38495);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_38321_38496(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 38321, 38496);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_38545_38558(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 38545, 38558);
return return_v;
}


int
f_1597_38523_38559(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 38523, 38559);
return 0;
}


System.Management.Automation.SwitchParameter
f_1597_38741_38745()
{
var return_v = Full;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 38741, 38745);
return return_v;
}


string
f_1597_38891_38944()
{
var return_v = RemotingErrorIdStrings.DISCVariableDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 38891, 38944);
return return_v;
}


string
f_1597_38809_39116(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 38809, 39116);
return return_v;
}


System.Text.StringBuilder
f_1597_38795_39117(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 38795, 39117);
return return_v;
}


string
f_1597_39464_39517()
{
var return_v = RemotingErrorIdStrings.DISCVariableDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 39464, 39517);
return return_v;
}


string
f_1597_39382_39579(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 39382, 39579);
return return_v;
}


System.Text.StringBuilder
f_1597_39368_39580(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 39368, 39580);
return return_v;
}


System.Collections.Hashtable[]
f_1597_39701_39771(object
hashObj)
{
var return_v = DISCPowerShellConfiguration.TryGetHashtableArray( hashObj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 39701, 39771);
return return_v;
}


string
f_1597_39973_40026()
{
var return_v = RemotingErrorIdStrings.DISCVariableDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 39973, 40026);
return return_v;
}


string
f_1597_40061_40131(System.Collections.Hashtable[]
tables,System.IO.StreamWriter
writer)
{
var return_v = SessionConfigurationUtils.CombineHashtableArray( (System.Collections.IDictionary[])tables, writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 40061, 40131);
return return_v;
}


string
f_1597_39891_40153(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 39891, 40153);
return return_v;
}


System.Text.StringBuilder
f_1597_39877_40154(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 39877, 40154);
return return_v;
}


bool
f_1597_40297_40357(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 40297, 40357);
return return_v;
}


string
f_1597_40497_40542()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 40497, 40542);
return return_v;
}


string
f_1597_40479_40671(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 40479, 40671);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_40455_40672(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 40455, 40672);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_40733_40746(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 40733, 40746);
return return_v;
}


int
f_1597_40711_40747(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 40711, 40747);
return 0;
}


bool
f_1597_40824_40885(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 40824, 40885);
return return_v;
}


string
f_1597_41025_41070()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 41025, 41070);
return return_v;
}


string
f_1597_41007_41200(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 41007, 41200);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_40983_41201(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 40983, 41201);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_41262_41275(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 41262, 41275);
return return_v;
}


int
f_1597_41240_41276(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 41240, 41276);
return 0;
}


System.Collections.ICollection
f_1597_41379_41393(System.Collections.Hashtable
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 41379, 41393);
return return_v;
}


bool
f_1597_41472_41573(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 41472, 41573);
return return_v;
}


bool
f_1597_41619_41721(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 41619, 41721);
return return_v;
}


string
f_1597_41869_41918()
{
var return_v = RemotingErrorIdStrings.DISCTypeContainsInvalidKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 41869, 41918);
return return_v;
}


string
f_1597_41851_42025(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 41851, 42025);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_41827_42026(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 41827, 42026);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_42091_42104(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 42091, 42104);
return return_v;
}


int
f_1597_42069_42105(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 42069, 42105);
return 0;
}


System.Collections.ICollection
f_1597_41379_41393_I(System.Collections.ICollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 41379, 41393);
return return_v;
}


System.Collections.Hashtable[]
f_1597_40219_40226_I(System.Collections.Hashtable[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 40219, 40226);
return return_v;
}


string
f_1597_42391_42442()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustBeHashtableArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 42391, 42442);
return return_v;
}


string
f_1597_42373_42527(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 42373, 42527);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_42349_42528(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 42349, 42528);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_42581_42594(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 42581, 42594);
return return_v;
}


int
f_1597_42559_42595(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 42559, 42595);
return 0;
}


System.Management.Automation.SwitchParameter
f_1597_42806_42810()
{
var return_v = Full;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 42806, 42810);
return return_v;
}


string
f_1597_42957_43011()
{
var return_v = RemotingErrorIdStrings.DISCEnvironmentVariablesComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 42957, 43011);
return return_v;
}


string
f_1597_42874_43141(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 42874, 43141);
return return_v;
}


System.Text.StringBuilder
f_1597_42860_43142(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 42860, 43142);
return return_v;
}


string
f_1597_43345_43399()
{
var return_v = RemotingErrorIdStrings.DISCEnvironmentVariablesComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 43345, 43399);
return return_v;
}


string
f_1597_43426_43505(System.Collections.IDictionary
table,System.IO.StreamWriter
writer)
{
var return_v = SessionConfigurationUtils.CombineHashtable( table, writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 43426, 43505);
return return_v;
}


string
f_1597_43262_43527(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 43262, 43527);
return return_v;
}


System.Text.StringBuilder
f_1597_43248_43528(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 43248, 43528);
return return_v;
}


bool
f_1597_43609_43661(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 43609, 43661);
return return_v;
}


int
f_1597_43717_43739(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 43717, 43739);
return return_v;
}


string
f_1597_43747_43808(string[]
values)
{
var return_v = SessionConfigurationUtils.CombineStringArray( values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 43747, 43808);
return return_v;
}


string
f_1597_43996_44044()
{
var return_v = RemotingErrorIdStrings.DISCTypesToProcessComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 43996, 44044);
return return_v;
}


int
f_1597_44098_44120(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 44098, 44120);
return return_v;
}


string
f_1597_43919_44127(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 43919, 44127);
return return_v;
}


System.Text.StringBuilder
f_1597_43905_44128(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 43905, 44128);
return return_v;
}


bool
f_1597_44211_44265(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 44211, 44265);
return return_v;
}


int
f_1597_44321_44345(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 44321, 44345);
return return_v;
}


string
f_1597_44353_44416(string[]
values)
{
var return_v = SessionConfigurationUtils.CombineStringArray( values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 44353, 44416);
return return_v;
}


string
f_1597_44610_44660()
{
var return_v = RemotingErrorIdStrings.DISCFormatsToProcessComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 44610, 44660);
return return_v;
}


int
f_1597_44714_44738(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 44714, 44738);
return return_v;
}


string
f_1597_44531_44745(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 44531, 44745);
return return_v;
}


System.Text.StringBuilder
f_1597_44517_44746(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 44517, 44746);
return return_v;
}


bool
f_1597_44829_44883(Microsoft.PowerShell.Commands.NewPSSessionConfigurationFileCommand
this_param,string
parameterName)
{
var return_v = this_param.ShouldGenerateConfigurationSnippet( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 44829, 44883);
return return_v;
}


int
f_1597_45001_45025(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 45001, 45025);
return return_v;
}


string
f_1597_45405_45455()
{
var return_v = RemotingErrorIdStrings.DISCAssembliesToLoadComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 45405, 45455);
return return_v;
}


string
f_1597_45482_45545(string[]
values)
{
var return_v = SessionConfigurationUtils.CombineStringArray( values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 45482, 45545);
return return_v;
}


string
f_1597_45326_45571(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 45326, 45571);
return return_v;
}


System.Text.StringBuilder
f_1597_45312_45572(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 45312, 45572);
return return_v;
}


System.Text.StringBuilder
f_1597_45612_45630(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 45612, 45630);
return return_v;
}


string
f_1597_45670_45687(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 45670, 45687);
return return_v;
}


int
f_1597_45651_45688(System.IO.StreamWriter
this_param,string
value)
{
this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 45651, 45688);
return 0;
}


int
f_1597_45758_45780(System.IO.StreamWriter
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 45758, 45780);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,16706,45807);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,16706,45807);
}
		}

private bool ShouldGenerateConfigurationSnippet(string parameterName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,45876,46052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,45970,46041);

return f_1597_45977_45981()||(DynAbs.Tracing.TraceSender.Expression_False(1597, 45977, 46040)||f_1597_45985_46040(f_1597_45985_46013(f_1597_45985_45997()), parameterName));
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,45876,46052);

System.Management.Automation.SwitchParameter
f_1597_45977_45981()
{
var return_v = Full;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 45977, 45981);
return return_v;
}


System.Management.Automation.InvocationInfo
f_1597_45985_45997()
{
var return_v = MyInvocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 45985, 45997);
return return_v;
}


System.Collections.Generic.Dictionary<string, object>
f_1597_45985_46013(System.Management.Automation.InvocationInfo
this_param)
{
var return_v = this_param.BoundParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 45985, 46013);
return return_v;
}


bool
f_1597_45985_46040(System.Collections.Generic.Dictionary<string, object>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 45985, 46040);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,45876,46052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,45876,46052);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public NewPSSessionConfigurationFileCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1597,651,46081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,1271,1276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,1689,1728);
this._schemaVersion = f_1597_1706_1728("2.0.0.0");DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,2071,2093);
this._guid = Guid.NewGuid();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,2455,2462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,2818,2830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,3187,3199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,3559,3569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,3970,4004);
this._sessionType = SessionType.Default;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,4425,4452);
this._transcriptDirectory = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,4792,4964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,5631,5700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,6517,6594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,7069,7110);
this._scriptsToProcess = f_1597_7089_7110();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,7647,7663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,8108,8123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,8550,8591);
this._languageMode = PSLanguageMode.NoLanguage;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,8615,8639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,9030,9075);
this._executionPolicy = ExecutionPolicy.Restricted;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,9458,9476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,9958,9974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,10451,10490);
this._visibleAliases = f_1597_10469_10490();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,10967,10989);
this._visibleCmdlets = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,11474,11498);
this._visibleFunctions = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,12038,12086);
this._visibleExternalCommands = f_1597_12065_12086();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,12563,12604);
this._visibleProviders = f_1597_12583_12604();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,13089,13106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,13602,13622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,14104,14124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,14724,14745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,15223,15262);
this._typesToProcess = f_1597_15241_15262();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,15752,15793);
this._formatsToProcess = f_1597_15772_15793();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,16279,16296);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1597,651,46081);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,651,46081);
}


static NewPSSessionConfigurationFileCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1597,651,46081);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1597,651,46081);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,651,46081);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1597,651,46081);

System.Version
f_1597_1706_1728(string
version)
{
var return_v = new System.Version( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 1706, 1728);
return return_v;
}


string[]
f_1597_7089_7110()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 7089, 7110);
return return_v;
}


string[]
f_1597_10469_10490()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 10469, 10490);
return return_v;
}


string[]
f_1597_12065_12086()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 12065, 12086);
return return_v;
}


string[]
f_1597_12583_12604()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 12583, 12604);
return return_v;
}


string[]
f_1597_15241_15262()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 15241, 15262);
return return_v;
}


string[]
f_1597_15772_15793()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 15772, 15793);
return return_v;
}

}
[Cmdlet(VerbsCommon.New, "PSRoleCapabilityFile", HelpUri = "https://go.microsoft.com/fwlink/?LinkId=623708")]
    public class NewPSRoleCapabilityFileCommand : PSCmdlet
{
[Parameter(Position = 0, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Path
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,46762,46826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,46798,46811);

return _path;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,46762,46826);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,46632,46918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,46632,46918);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,46842,46907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,46878,46892);

_path = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,46842,46907);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,46632,46918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,46632,46918);
}
		}}

private string _path;

[Parameter()]
        public Guid Guid
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,47112,47176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,47148,47161);

return _guid;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,47112,47176);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,47048,47268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,47048,47268);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,47192,47257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,47228,47242);

_guid = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,47192,47257);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,47048,47268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,47048,47268);
}
		}}

private Guid _guid ;

[Parameter()]
        public string Author
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,47490,47556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,47526,47541);

return _author;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,47490,47556);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,47422,47650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,47422,47650);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,47572,47639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,47608,47624);

_author = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,47572,47639);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,47422,47650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,47422,47650);
}
		}}

private string _author;

[Parameter()]
        public string Description
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,47843,47914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,47879,47899);

return _description;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,47843,47914);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,47770,48013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,47770,48013);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,47930,48002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,47966,47987);

_description = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,47930,48002);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,47770,48013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,47770,48013);
}
		}}

private string _description;

[Parameter()]
        public string CompanyName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,48212,48283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,48248,48268);

return _companyName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,48212,48283);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,48139,48382);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,48139,48382);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,48299,48371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,48335,48356);

_companyName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,48299,48371);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,48139,48382);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,48139,48382);
}
		}}

private string _companyName;

[Parameter()]
        public string Copyright
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,48588,48657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,48624,48642);

return _copyright;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,48588,48657);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,48517,48754);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,48517,48754);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,48673,48743);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,48709,48728);

_copyright = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,48673,48743);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,48517,48754);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,48517,48754);
}
		}}

private string _copyright;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public object[] ModulesToImport
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,49066,49141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,49102,49126);

return _modulesToImport;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,49066,49141);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,48893,49244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,48893,49244);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,49157,49233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,49193,49218);

_modulesToImport = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,49157,49233);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,48893,49244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,48893,49244);
}
		}}

private object[] _modulesToImport;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] VisibleAliases
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,49561,49635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,49597,49620);

return _visibleAliases;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,49561,49635);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,49389,49737);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,49389,49737);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,49651,49726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,49687,49711);

_visibleAliases = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,49651,49726);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,49389,49737);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,49389,49737);
}
		}}

private string[] _visibleAliases ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public object[] VisibleCmdlets
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,50077,50151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,50113,50136);

return _visibleCmdlets;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,50077,50151);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,49905,50253);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,49905,50253);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,50167,50242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,50203,50227);

_visibleCmdlets = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,50167,50242);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,49905,50253);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,49905,50253);
}
		}}

private object[] _visibleCmdlets ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public object[] VisibleFunctions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,50580,50656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,50616,50641);

return _visibleFunctions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,50580,50656);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,50406,50760);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,50406,50760);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,50672,50749);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,50708,50734);

_visibleFunctions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,50672,50749);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,50406,50760);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,50406,50760);
}
		}}

private object[] _visibleFunctions ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] VisibleExternalCommands
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,51130,51213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,51166,51198);

return _visibleExternalCommands;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,51130,51213);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,50949,51324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,50949,51324);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,51229,51313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,51265,51298);

_visibleExternalCommands = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,51229,51313);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,50949,51324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,50949,51324);
}
		}}

private string[] _visibleExternalCommands ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] VisibleProviders
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,51669,51745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,51705,51730);

return _visibleProviders;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,51669,51745);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,51495,51849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,51495,51849);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,51761,51838);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,51797,51823);

_visibleProviders = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,51761,51838);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,51495,51849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,51495,51849);
}
		}}

private string[] _visibleProviders ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] ScriptsToProcess
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,52186,52262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,52222,52247);

return _scriptsToProcess;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,52186,52262);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,52012,52366);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,52012,52366);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,52278,52355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,52314,52340);

_scriptsToProcess = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,52278,52355);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,52012,52366);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,52012,52366);
}
		}}

private string[] _scriptsToProcess ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public IDictionary[] AliasDefinitions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,52707,52783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,52743,52768);

return _aliasDefinitions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,52707,52783);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,52528,52887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,52528,52887);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,52799,52876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,52835,52861);

_aliasDefinitions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,52799,52876);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,52528,52887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,52528,52887);
}
		}}

private IDictionary[] _aliasDefinitions;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public IDictionary[] FunctionDefinitions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,53214,53293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,53250,53278);

return _functionDefinitions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,53214,53293);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,53032,53400);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,53032,53400);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,53309,53389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,53345,53374);

_functionDefinitions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,53309,53389);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,53032,53400);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,53032,53400);
}
		}}

private IDictionary[] _functionDefinitions;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public object VariableDefinitions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,53723,53802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,53759,53787);

return _variableDefinitions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,53723,53802);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,53548,53909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,53548,53909);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,53818,53898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,53854,53883);

_variableDefinitions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,53818,53898);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,53548,53909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,53548,53909);
}
		}}

private object _variableDefinitions;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public IDictionary EnvironmentVariables
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,54336,54416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,54372,54401);

return _environmentVariables;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,54336,54416);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,54062,54524);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,54062,54524);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,54432,54513);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,54468,54498);

_environmentVariables = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,54432,54513);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,54062,54524);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,54062,54524);
}
		}}

private IDictionary _environmentVariables;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] TypesToProcess
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,54850,54924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,54886,54909);

return _typesToProcess;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,54850,54924);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,54678,55026);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,54678,55026);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,54940,55015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,54976,55000);

_typesToProcess = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,54940,55015);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,54678,55026);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,54678,55026);
}
		}}

private string[] _typesToProcess ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] FormatsToProcess
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,55375,55451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,55411,55436);

return _formatsToProcess;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,55375,55451);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,55201,55555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,55201,55555);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,55467,55544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,55503,55529);

_formatsToProcess = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,55467,55544);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,55201,55555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,55201,55555);
}
		}}

private string[] _formatsToProcess ;

[Parameter()]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] AssembliesToLoad
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,55902,55978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,55938,55963);

return _assembliesToLoad;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,55902,55978);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,55728,56082);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,55728,56082);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,55994,56071);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,56030,56056);

_assembliesToLoad = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,55994,56071);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,55728,56082);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,55728,56082);
}
		}}

private string[] _assembliesToLoad;

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1597,56239,75617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,56303,56346);

f_1597_56303_56345(!f_1597_56317_56344(_path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,56362,56391);

ProviderInfo 
provider = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,56405,56423);

PSDriveInfo 
drive
=default(PSDriveInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,56437,56541);

string 
filePath = f_1597_56455_56540(f_1597_56455_56472(f_1597_56455_56467()), _path, out provider, out drive)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,56557,57153) || true) && (!f_1597_56562_56615(provider, f_1597_56582_56614(f_1597_56582_56603(f_1597_56582_56589())))||(DynAbs.Tracing.TraceSender.Expression_False(1597, 56561, 56727)||!f_1597_56620_56727(filePath, StringLiterals.PowerShellRoleCapabilityFileExtension, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,56557,57153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,56761,56857);

string 
message = f_1597_56778_56856(f_1597_56796_56848(), _path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,56875,56946);

InvalidOperationException 
ioe = f_1597_56907_56945(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,56964,57094);

ErrorRecord 
er = f_1597_56981_57093(ioe, "InvalidRoleCapabilityFilePath", ErrorCategory.InvalidArgument, _path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,57112,57138);

f_1597_57112_57137(this, er);
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,56557,57153);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,57169,57191);

FileStream 
fileStream
=default(FileStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,57205,57231);

StreamWriter 
streamWriter
=default(StreamWriter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,57245,57271);

FileInfo 
readOnlyFileInfo
=default(FileInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,57331,57758);

f_1597_57331_57757(this, filePath, EncodingConversion.Unicode, false, false, false, false, out fileStream, out streamWriter, out readOnlyFileInfo, false);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,57810,57853);

StringBuilder 
result = f_1597_57833_57852()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,57873,57893);

f_1597_57873_57892(
                result, "@{");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,57911,57947);

f_1597_57911_57946(                result, f_1597_57925_57945(streamWriter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,57965,58001);

f_1597_57965_58000(                result, f_1597_57979_57999(streamWriter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,58046,58233);

f_1597_58046_58232(
                // Guid
                result, f_1597_58060_58231(ConfigFileConstants.Guid, f_1597_58127_58165(), f_1597_58167_58209(_guid), streamWriter, false));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,58280,58405) || true) && (f_1597_58284_58313(_author))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,58280,58405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,58355,58386);

_author = f_1597_58365_58385();
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,58280,58405);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,58425,58639);

f_1597_58425_58638(
                result, f_1597_58439_58637(ConfigFileConstants.Author, f_1597_58508_58548(), f_1597_58571_58615(_author), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,58691,58949);

f_1597_58691_58948(
                // Description
                result, f_1597_58705_58947(ConfigFileConstants.Description, f_1597_58779_58824(), f_1597_58847_58896(_description), streamWriter, f_1597_58912_58946(_description)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,59002,59143) || true) && (f_1597_59006_59040(_companyName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,59002,59143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,59082,59124);

_companyName = f_1597_59097_59123();
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,59002,59143);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,59163,59392);

f_1597_59163_59391(
                result, f_1597_59177_59390(ConfigFileConstants.CompanyName, f_1597_59251_59296(), f_1597_59319_59368(_companyName), streamWriter, false));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,59442,59612) || true) && (f_1597_59446_59478(_copyright))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,59442,59612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,59520,59593);

_copyright = f_1597_59533_59592(f_1597_59551_59582(), _author);
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,59442,59612);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,59632,59855);

f_1597_59632_59854(
                result, f_1597_59646_59853(ConfigFileConstants.Copyright, f_1597_59718_59761(), f_1597_59784_59831(_copyright), streamWriter, false));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,59913,60740) || true) && (_modulesToImport == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,59913,60740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,59983,60144);

string 
exampleModulesToImport = "'MyCustomModule', @{ ModuleName = 'MyCustomModule'; ModuleVersion = '1.0.0.0'; GUID = '4d30d5f0-cb16-4898-812d-f20a6c596bdf' }"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,60166,60354);

f_1597_60166_60353(                    result, f_1597_60180_60352(ConfigFileConstants.ModulesToImport, f_1597_60258_60307(), exampleModulesToImport, streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,59913,60740);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,59913,60740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,60436,60721);

f_1597_60436_60720(                    result, f_1597_60450_60719(ConfigFileConstants.ModulesToImport, f_1597_60528_60577(), f_1597_60604_60697(_modulesToImport, streamWriter, this), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,59913,60740);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,60796,61087);

f_1597_60796_61086(
                // Visible aliases
                result, f_1597_60810_61085(ConfigFileConstants.VisibleAliases, f_1597_60887_60935(), f_1597_60958_61041(_visibleAliases, streamWriter, this), streamWriter, f_1597_61057_61079(_visibleAliases)== 0));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,61143,61979) || true) && ((_visibleCmdlets == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1597, 61147, 61205)||(f_1597_61177_61199(_visibleCmdlets)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,61143,61979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,61247,61605);

f_1597_61247_61604(                    result, f_1597_61261_61603(ConfigFileConstants.VisibleCmdlets, f_1597_61338_61386(), "'Invoke-Cmdlet1', @{ Name = 'Invoke-Cmdlet2'; Parameters = @{ Name = 'Parameter1'; ValidateSet = 'Item1', 'Item2' }, @{ Name = 'Parameter2'; ValidatePattern = 'L*' } }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,61143,61979);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,61143,61979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,61687,61960);

f_1597_61687_61959(                    result, f_1597_61701_61958(ConfigFileConstants.VisibleCmdlets, f_1597_61778_61826(), f_1597_61853_61936(_visibleCmdlets, streamWriter, this), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,61143,61979);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,62037,62915) || true) && ((_visibleFunctions == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1597, 62041, 62103)||(f_1597_62073_62097(_visibleFunctions)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,62037,62915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,62145,62511);

f_1597_62145_62510(                    result, f_1597_62159_62509(ConfigFileConstants.VisibleFunctions, f_1597_62238_62288(), "'Invoke-Function1', @{ Name = 'Invoke-Function2'; Parameters = @{ Name = 'Parameter1'; ValidateSet = 'Item1', 'Item2' }, @{ Name = 'Parameter2'; ValidatePattern = 'L*' } }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,62037,62915);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,62037,62915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,62593,62896);

f_1597_62593_62895(                    result, f_1597_62607_62894(ConfigFileConstants.VisibleFunctions, f_1597_62686_62736(), f_1597_62763_62848(_visibleFunctions, streamWriter, this), streamWriter, f_1597_62864_62888(_visibleFunctions)== 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,62037,62915);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,63004,63331);

f_1597_63004_63330(
                // Visible external commands (scripts, executables)
                result, f_1597_63018_63329(ConfigFileConstants.VisibleExternalCommands, f_1597_63104_63161(), f_1597_63184_63276(_visibleExternalCommands, streamWriter, this), streamWriter, f_1597_63292_63323(_visibleExternalCommands)== 0));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,63389,63688);

f_1597_63389_63687(
                // Visible providers
                result, f_1597_63403_63686(ConfigFileConstants.VisibleProviders, f_1597_63482_63532(), f_1597_63555_63640(_visibleProviders, streamWriter, this), streamWriter, f_1597_63656_63680(_visibleProviders)== 0));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,63747,63937);

string 
resultData = (DynAbs.Tracing.TraceSender.Conditional_F1(1597, 63767, 63797)||(((f_1597_63768_63792(_scriptsToProcess)> 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(1597, 63800, 63863))||DynAbs.Tracing.TraceSender.Conditional_F3(1597, 63866, 63936)))?f_1597_63800_63863(_scriptsToProcess):"'C:\\ConfigData\\InitScript1.ps1', 'C:\\ConfigData\\InitScript2.ps1'"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,63955,64181);

f_1597_63955_64180(                result, f_1597_63969_64179(ConfigFileConstants.ScriptsToProcess, f_1597_64048_64098(), resultData, streamWriter, (f_1597_64148_64172(_scriptsToProcess)== 0)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,64239,65006) || true) && ((_aliasDefinitions == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1597, 64243, 64305)||(f_1597_64275_64299(_aliasDefinitions)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,64239,65006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,64347,64631);

f_1597_64347_64630(                    result, f_1597_64361_64629(ConfigFileConstants.AliasDefinitions, f_1597_64440_64490(), "@{ Name = 'Alias1'; Value = 'Invoke-Alias1'}, @{ Name = 'Alias2'; Value = 'Invoke-Alias2'}", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,64239,65006);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,64239,65006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,64713,64987);

f_1597_64713_64986(                    result, f_1597_64727_64985(ConfigFileConstants.AliasDefinitions, f_1597_64806_64856(), f_1597_64883_64963(_aliasDefinitions, streamWriter), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,64239,65006);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,65067,68980) || true) && (_functionDefinitions == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,65067,68980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,65141,65410);

f_1597_65141_65409(                    result, f_1597_65155_65408(ConfigFileConstants.FunctionDefinitions, f_1597_65237_65290(), "@{ Name = 'MyFunction'; ScriptBlock = { param($MyInput) $MyInput } }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,65067,68980);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,65067,68980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,65492,65586);

Hashtable[] 
funcHash = f_1597_65515_65585(_functionDefinitions)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,65610,68961) || true) && (funcHash != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,65610,68961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,65680,65955);

f_1597_65680_65954(                        result, f_1597_65694_65953(ConfigFileConstants.FunctionDefinitions, f_1597_65776_65829(), f_1597_65860_65931(funcHash, streamWriter), streamWriter, false));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,65983,68577);
foreach(Hashtable hashtable in f_1597_66015_66023_I(funcHash) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,65983,68577);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,66081,66552) || true) && (!f_1597_66086_66146(hashtable, ConfigFileConstants.FunctionNameToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,66081,66552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,66212,66450);

PSArgumentException 
e = f_1597_66236_66449(f_1597_66260_66448(f_1597_66278_66323(), ConfigFileConstants.FunctionDefinitions, ConfigFileConstants.FunctionNameToken, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,66484,66521);

f_1597_66484_66520(this, f_1597_66506_66519(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,66081,66552);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,66584,67057) || true) && (!f_1597_66589_66650(hashtable, ConfigFileConstants.FunctionValueToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,66584,67057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,66716,66955);

PSArgumentException 
e = f_1597_66740_66954(f_1597_66764_66953(f_1597_66782_66827(), ConfigFileConstants.FunctionDefinitions, ConfigFileConstants.FunctionValueToken, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,66989,67026);

f_1597_66989_67025(this, f_1597_67011_67024(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,66584,67057);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,67089,67576) || true) && ((f_1597_67094_67143(hashtable, ConfigFileConstants.FunctionValueToken)as ScriptBlock) == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,67089,67576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,67233,67474);

PSArgumentException 
e = f_1597_67257_67473(f_1597_67281_67472(f_1597_67299_67346(), ConfigFileConstants.FunctionValueToken, ConfigFileConstants.FunctionDefinitions, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,67508,67545);

f_1597_67508_67544(this, f_1597_67530_67543(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,67089,67576);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,67608,68550);
foreach(string functionKey in f_1597_67639_67653_I(f_1597_67639_67653(hashtable)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,67608,68550);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,67719,68519) || true) && (!f_1597_67724_67825(functionKey, ConfigFileConstants.FunctionNameToken, StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1597, 67723, 67969)&&                                    !f_1597_67867_67969(functionKey, ConfigFileConstants.FunctionValueToken, StringComparison.OrdinalIgnoreCase))&&(DynAbs.Tracing.TraceSender.Expression_True(1597, 67723, 68115)&&                                    !f_1597_68011_68115(functionKey, ConfigFileConstants.FunctionOptionsToken, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,67719,68519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,68189,68409);

PSArgumentException 
e = f_1597_68213_68408(f_1597_68237_68407(f_1597_68255_68304(), functionKey, ConfigFileConstants.FunctionDefinitions, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,68447,68484);

f_1597_68447_68483(this, f_1597_68469_68482(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,67719,68519);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,67608,68550);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,943);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,943);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1597,65983,68577);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,2595);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,2595);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1597,65610,68961);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,65610,68961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,68675,68875);

PSArgumentException 
e = f_1597_68699_68874(f_1597_68723_68873(f_1597_68741_68792(), ConfigFileConstants.FunctionDefinitions, filePath))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,68901,68938);

f_1597_68901_68937(this, f_1597_68923_68936(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,65610,68961);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,65067,68980);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,69041,72958) || true) && (_variableDefinitions == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,69041,72958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,69115,69434);

f_1597_69115_69433(                    result, f_1597_69129_69432(ConfigFileConstants.VariableDefinitions, f_1597_69211_69264(), "@{ Name = 'Variable1'; Value = { 'Dynamic' + 'InitialValue' } }, @{ Name = 'Variable2'; Value = 'StaticInitialValue' }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,69041,72958);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,69041,72958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,69516,69566);

string 
varString = _variableDefinitions as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,69590,72939) || true) && (varString != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,69590,72939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,69661,69874);

f_1597_69661_69873(                        result, f_1597_69675_69872(ConfigFileConstants.VariableDefinitions, f_1597_69757_69810(), varString, streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,69590,72939);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,69590,72939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,69972,70065);

Hashtable[] 
varHash = f_1597_69994_70064(_variableDefinitions)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,70093,72916) || true) && (varHash != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,70093,72916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,70170,70448);

f_1597_70170_70447(                            result, f_1597_70184_70446(ConfigFileConstants.VariableDefinitions, f_1597_70266_70319(), f_1597_70354_70424(varHash, streamWriter), streamWriter, false));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,70480,72504);
foreach(Hashtable hashtable in f_1597_70512_70519_I(varHash) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,70480,72504);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,70585,71076) || true) && (!f_1597_70590_70650(hashtable, ConfigFileConstants.VariableNameToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,70585,71076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,70724,70966);

PSArgumentException 
e = f_1597_70748_70965(f_1597_70772_70964(f_1597_70790_70835(), ConfigFileConstants.VariableDefinitions, ConfigFileConstants.VariableNameToken, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,71004,71041);

f_1597_71004_71040(this, f_1597_71026_71039(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,70585,71076);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,71112,71605) || true) && (!f_1597_71117_71178(hashtable, ConfigFileConstants.VariableValueToken))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,71112,71605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,71252,71495);

PSArgumentException 
e = f_1597_71276_71494(f_1597_71300_71493(f_1597_71318_71363(), ConfigFileConstants.VariableDefinitions, ConfigFileConstants.VariableValueToken, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,71533,71570);

f_1597_71533_71569(this, f_1597_71555_71568(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,71112,71605);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,71641,72473);
foreach(string variableKey in f_1597_71672_71686_I(f_1597_71672_71686(hashtable)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,71641,72473);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,71760,72438) || true) && (!f_1597_71765_71866(variableKey, ConfigFileConstants.VariableNameToken, StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1597, 71764, 72014)&&                                        !f_1597_71912_72014(variableKey, ConfigFileConstants.VariableValueToken, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,71760,72438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,72096,72320);

PSArgumentException 
e = f_1597_72120_72319(f_1597_72144_72318(f_1597_72162_72211(), variableKey, ConfigFileConstants.VariableDefinitions, _path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,72362,72399);

f_1597_72362_72398(this, f_1597_72384_72397(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,71760,72438);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,71641,72473);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,833);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,833);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1597,70480,72504);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,2025);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,2025);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1597,70093,72916);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,70093,72916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,72618,72822);

PSArgumentException 
e = f_1597_72642_72821(f_1597_72666_72820(f_1597_72684_72735(), ConfigFileConstants.VariableDefinitions, filePath))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,72852,72889);

f_1597_72852_72888(this, f_1597_72874_72887(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,70093,72916);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,69590,72939);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,69041,72958);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,73020,73752) || true) && (_environmentVariables == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,73020,73752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,73095,73370);

f_1597_73095_73369(                    result, f_1597_73109_73368(ConfigFileConstants.EnvironmentVariables, f_1597_73192_73246(), "@{ Variable1 = 'Value1'; Variable2 = 'Value2' }", streamWriter, true));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,73020,73752);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,73020,73752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,73452,73733);

f_1597_73452_73732(                    result, f_1597_73466_73731(ConfigFileConstants.EnvironmentVariables, f_1597_73549_73603(), f_1597_73630_73709(_environmentVariables, streamWriter), streamWriter, false));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,73020,73752);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,73809,73989);

resultData = (DynAbs.Tracing.TraceSender.Conditional_F1(1597, 73822, 73850)||(((f_1597_73823_73845(_typesToProcess)> 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(1597, 73853, 73914))||DynAbs.Tracing.TraceSender.Conditional_F3(1597, 73917, 73988)))?f_1597_73853_73914(_typesToProcess):"'C:\\ConfigData\\MyTypes.ps1xml', 'C:\\ConfigData\\OtherTypes.ps1xml'";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,74007,74227);

f_1597_74007_74226(                result, f_1597_74021_74225(ConfigFileConstants.TypesToProcess, f_1597_74098_74146(), resultData, streamWriter, (f_1597_74196_74218(_typesToProcess)== 0)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,74286,74474);

resultData = (DynAbs.Tracing.TraceSender.Conditional_F1(1597, 74299, 74329)||(((f_1597_74300_74324(_formatsToProcess)> 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(1597, 74332, 74395))||DynAbs.Tracing.TraceSender.Conditional_F3(1597, 74398, 74473)))?f_1597_74332_74395(_formatsToProcess):"'C:\\ConfigData\\MyFormats.ps1xml', 'C:\\ConfigData\\OtherFormats.ps1xml'";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,74492,74718);

f_1597_74492_74717(                result, f_1597_74506_74716(ConfigFileConstants.FormatsToProcess, f_1597_74585_74635(), resultData, streamWriter, (f_1597_74685_74709(_formatsToProcess)== 0)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,74777,74800);

bool 
isExample = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,74818,75125) || true) && ((_assembliesToLoad == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1597, 74822, 74884)||(f_1597_74854_74878(_assembliesToLoad)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,74818,75125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,74926,74943);

isExample = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,74965,75106);

_assembliesToLoad = new string[] { "System.Web", "System.OtherAssembly, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" };
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,74818,75125);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,75145,75402);

f_1597_75145_75401(
                result, f_1597_75159_75400(ConfigFileConstants.AssembliesToLoad, f_1597_75238_75288(), f_1597_75311_75374(_assembliesToLoad), streamWriter, isExample));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,75422,75441);

f_1597_75422_75440(
                result, "}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,75461,75499);

f_1597_75461_75498(
                streamWriter, f_1597_75480_75497(result));
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1597,75528,75606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,75568,75591);

f_1597_75568_75590(                streamWriter);
DynAbs.Tracing.TraceSender.TraceExitFinally(1597,75528,75606);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1597,56239,75617);

bool
f_1597_56317_56344(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 56317, 56344);
return return_v;
}


int
f_1597_56303_56345(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 56303, 56345);
return 0;
}


System.Management.Automation.SessionState
f_1597_56455_56467()
{
var return_v = SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 56455, 56467);
return return_v;
}


System.Management.Automation.PathIntrinsics
f_1597_56455_56472(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 56455, 56472);
return return_v;
}


string
f_1597_56455_56540(System.Management.Automation.PathIntrinsics
this_param,string
path,out System.Management.Automation.ProviderInfo
provider,out System.Management.Automation.PSDriveInfo
drive)
{
var return_v = this_param.GetUnresolvedProviderPathFromPSPath( path, out provider, out drive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 56455, 56540);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1597_56582_56589()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 56582, 56589);
return return_v;
}


System.Management.Automation.ProviderNames
f_1597_56582_56603(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.ProviderNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 56582, 56603);
return return_v;
}


string
f_1597_56582_56614(System.Management.Automation.ProviderNames
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 56582, 56614);
return return_v;
}


bool
f_1597_56562_56615(System.Management.Automation.ProviderInfo
this_param,string
providerName)
{
var return_v = this_param.NameEquals( providerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 56562, 56615);
return return_v;
}


bool
f_1597_56620_56727(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 56620, 56727);
return return_v;
}


string
f_1597_56796_56848()
{
var return_v = RemotingErrorIdStrings.InvalidRoleCapabilityFilePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 56796, 56848);
return return_v;
}


string
f_1597_56778_56856(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 56778, 56856);
return return_v;
}


System.InvalidOperationException
f_1597_56907_56945(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 56907, 56945);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_56981_57093(System.InvalidOperationException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 56981, 57093);
return return_v;
}


int
f_1597_57112_57137(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 57112, 57137);
return 0;
}


int
f_1597_57331_57757(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
cmdlet,string
filePath,string
encoding,bool
defaultEncoding,bool
Append,bool
Force,bool
NoClobber,out System.IO.FileStream
fileStream,out System.IO.StreamWriter
streamWriter,out System.IO.FileInfo
readOnlyFileInfo,bool
isLiteralPath)
{
PathUtils.MasterStreamOpen( (System.Management.Automation.PSCmdlet)cmdlet, filePath, encoding, defaultEncoding, Append, Force, NoClobber, out fileStream, out streamWriter, out readOnlyFileInfo, isLiteralPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 57331, 57757);
return 0;
}


System.Text.StringBuilder
f_1597_57833_57852()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 57833, 57852);
return return_v;
}


System.Text.StringBuilder
f_1597_57873_57892(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 57873, 57892);
return return_v;
}


string
f_1597_57925_57945(System.IO.StreamWriter
this_param)
{
var return_v = this_param.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 57925, 57945);
return return_v;
}


System.Text.StringBuilder
f_1597_57911_57946(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 57911, 57946);
return return_v;
}


string
f_1597_57979_57999(System.IO.StreamWriter
this_param)
{
var return_v = this_param.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 57979, 57999);
return return_v;
}


System.Text.StringBuilder
f_1597_57965_58000(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 57965, 58000);
return return_v;
}


string
f_1597_58127_58165()
{
var return_v = RemotingErrorIdStrings.DISCGUIDComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 58127, 58165);
return return_v;
}


string
f_1597_58167_58209(System.Guid
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58167, 58209);
return return_v;
}


string
f_1597_58060_58231(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58060, 58231);
return return_v;
}


System.Text.StringBuilder
f_1597_58046_58232(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58046, 58232);
return return_v;
}


bool
f_1597_58284_58313(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58284, 58313);
return return_v;
}


string
f_1597_58365_58385()
{
var return_v = Environment.UserName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 58365, 58385);
return return_v;
}


string
f_1597_58508_58548()
{
var return_v = RemotingErrorIdStrings.DISCAuthorComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 58508, 58548);
return return_v;
}


string
f_1597_58571_58615(string
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58571, 58615);
return return_v;
}


string
f_1597_58439_58637(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58439, 58637);
return return_v;
}


System.Text.StringBuilder
f_1597_58425_58638(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58425, 58638);
return return_v;
}


string
f_1597_58779_58824()
{
var return_v = RemotingErrorIdStrings.DISCDescriptionComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 58779, 58824);
return return_v;
}


string
f_1597_58847_58896(string
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58847, 58896);
return return_v;
}


bool
f_1597_58912_58946(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58912, 58946);
return return_v;
}


string
f_1597_58705_58947(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58705, 58947);
return return_v;
}


System.Text.StringBuilder
f_1597_58691_58948(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 58691, 58948);
return return_v;
}


bool
f_1597_59006_59040(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 59006, 59040);
return return_v;
}


string
f_1597_59097_59123()
{
var return_v = Modules.DefaultCompanyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 59097, 59123);
return return_v;
}


string
f_1597_59251_59296()
{
var return_v = RemotingErrorIdStrings.DISCCompanyNameComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 59251, 59296);
return return_v;
}


string
f_1597_59319_59368(string
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 59319, 59368);
return return_v;
}


string
f_1597_59177_59390(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 59177, 59390);
return return_v;
}


System.Text.StringBuilder
f_1597_59163_59391(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 59163, 59391);
return return_v;
}


bool
f_1597_59446_59478(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 59446, 59478);
return return_v;
}


string
f_1597_59551_59582()
{
var return_v = Modules.DefaultCopyrightMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 59551, 59582);
return return_v;
}


string
f_1597_59533_59592(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 59533, 59592);
return return_v;
}


string
f_1597_59718_59761()
{
var return_v = RemotingErrorIdStrings.DISCCopyrightComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 59718, 59761);
return return_v;
}


string
f_1597_59784_59831(string
name)
{
var return_v = SessionConfigurationUtils.QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 59784, 59831);
return return_v;
}


string
f_1597_59646_59853(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 59646, 59853);
return return_v;
}


System.Text.StringBuilder
f_1597_59632_59854(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 59632, 59854);
return return_v;
}


string
f_1597_60258_60307()
{
var return_v = RemotingErrorIdStrings.DISCModulesToImportComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 60258, 60307);
return return_v;
}


string
f_1597_60180_60352(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 60180, 60352);
return return_v;
}


System.Text.StringBuilder
f_1597_60166_60353(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 60166, 60353);
return return_v;
}


string
f_1597_60528_60577()
{
var return_v = RemotingErrorIdStrings.DISCModulesToImportComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 60528, 60577);
return return_v;
}


string
f_1597_60604_60697(object[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
caller)
{
var return_v = SessionConfigurationUtils.CombineHashTableOrStringArray( values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 60604, 60697);
return return_v;
}


string
f_1597_60450_60719(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 60450, 60719);
return return_v;
}


System.Text.StringBuilder
f_1597_60436_60720(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 60436, 60720);
return return_v;
}


string
f_1597_60887_60935()
{
var return_v = RemotingErrorIdStrings.DISCVisibleAliasesComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 60887, 60935);
return return_v;
}


string
f_1597_60958_61041(string[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
caller)
{
var return_v = SessionConfigurationUtils.GetVisibilityDefault( (object[])values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 60958, 61041);
return return_v;
}


int
f_1597_61057_61079(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 61057, 61079);
return return_v;
}


string
f_1597_60810_61085(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 60810, 61085);
return return_v;
}


System.Text.StringBuilder
f_1597_60796_61086(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 60796, 61086);
return return_v;
}


int
f_1597_61177_61199(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 61177, 61199);
return return_v;
}


string
f_1597_61338_61386()
{
var return_v = RemotingErrorIdStrings.DISCVisibleCmdletsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 61338, 61386);
return return_v;
}


string
f_1597_61261_61603(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 61261, 61603);
return return_v;
}


System.Text.StringBuilder
f_1597_61247_61604(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 61247, 61604);
return return_v;
}


string
f_1597_61778_61826()
{
var return_v = RemotingErrorIdStrings.DISCVisibleCmdletsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 61778, 61826);
return return_v;
}


string
f_1597_61853_61936(object[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
caller)
{
var return_v = SessionConfigurationUtils.GetVisibilityDefault( values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 61853, 61936);
return return_v;
}


string
f_1597_61701_61958(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 61701, 61958);
return return_v;
}


System.Text.StringBuilder
f_1597_61687_61959(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 61687, 61959);
return return_v;
}


int
f_1597_62073_62097(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 62073, 62097);
return return_v;
}


string
f_1597_62238_62288()
{
var return_v = RemotingErrorIdStrings.DISCVisibleFunctionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 62238, 62288);
return return_v;
}


string
f_1597_62159_62509(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 62159, 62509);
return return_v;
}


System.Text.StringBuilder
f_1597_62145_62510(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 62145, 62510);
return return_v;
}


string
f_1597_62686_62736()
{
var return_v = RemotingErrorIdStrings.DISCVisibleFunctionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 62686, 62736);
return return_v;
}


string
f_1597_62763_62848(object[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
caller)
{
var return_v = SessionConfigurationUtils.GetVisibilityDefault( values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 62763, 62848);
return return_v;
}


int
f_1597_62864_62888(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 62864, 62888);
return return_v;
}


string
f_1597_62607_62894(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 62607, 62894);
return return_v;
}


System.Text.StringBuilder
f_1597_62593_62895(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 62593, 62895);
return return_v;
}


string
f_1597_63104_63161()
{
var return_v = RemotingErrorIdStrings.DISCVisibleExternalCommandsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 63104, 63161);
return return_v;
}


string
f_1597_63184_63276(string[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
caller)
{
var return_v = SessionConfigurationUtils.GetVisibilityDefault( (object[])values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 63184, 63276);
return return_v;
}


int
f_1597_63292_63323(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 63292, 63323);
return return_v;
}


string
f_1597_63018_63329(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 63018, 63329);
return return_v;
}


System.Text.StringBuilder
f_1597_63004_63330(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 63004, 63330);
return return_v;
}


string
f_1597_63482_63532()
{
var return_v = RemotingErrorIdStrings.DISCVisibleProvidersComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 63482, 63532);
return return_v;
}


string
f_1597_63555_63640(string[]
values,System.IO.StreamWriter
writer,Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
caller)
{
var return_v = SessionConfigurationUtils.GetVisibilityDefault( (object[])values, writer, (System.Management.Automation.PSCmdlet)caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 63555, 63640);
return return_v;
}


int
f_1597_63656_63680(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 63656, 63680);
return return_v;
}


string
f_1597_63403_63686(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 63403, 63686);
return return_v;
}


System.Text.StringBuilder
f_1597_63389_63687(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 63389, 63687);
return return_v;
}


int
f_1597_63768_63792(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 63768, 63792);
return return_v;
}


string
f_1597_63800_63863(string[]
values)
{
var return_v = SessionConfigurationUtils.CombineStringArray( values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 63800, 63863);
return return_v;
}


string
f_1597_64048_64098()
{
var return_v = RemotingErrorIdStrings.DISCScriptsToProcessComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 64048, 64098);
return return_v;
}


int
f_1597_64148_64172(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 64148, 64172);
return return_v;
}


string
f_1597_63969_64179(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 63969, 64179);
return return_v;
}


System.Text.StringBuilder
f_1597_63955_64180(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 63955, 64180);
return return_v;
}


int
f_1597_64275_64299(System.Collections.IDictionary[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 64275, 64299);
return return_v;
}


string
f_1597_64440_64490()
{
var return_v = RemotingErrorIdStrings.DISCAliasDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 64440, 64490);
return return_v;
}


string
f_1597_64361_64629(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 64361, 64629);
return return_v;
}


System.Text.StringBuilder
f_1597_64347_64630(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 64347, 64630);
return return_v;
}


string
f_1597_64806_64856()
{
var return_v = RemotingErrorIdStrings.DISCAliasDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 64806, 64856);
return return_v;
}


string
f_1597_64883_64963(System.Collections.IDictionary[]
tables,System.IO.StreamWriter
writer)
{
var return_v = SessionConfigurationUtils.CombineHashtableArray( tables, writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 64883, 64963);
return return_v;
}


string
f_1597_64727_64985(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 64727, 64985);
return return_v;
}


System.Text.StringBuilder
f_1597_64713_64986(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 64713, 64986);
return return_v;
}


string
f_1597_65237_65290()
{
var return_v = RemotingErrorIdStrings.DISCFunctionDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 65237, 65290);
return return_v;
}


string
f_1597_65155_65408(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 65155, 65408);
return return_v;
}


System.Text.StringBuilder
f_1597_65141_65409(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 65141, 65409);
return return_v;
}


System.Collections.Hashtable[]
f_1597_65515_65585(System.Collections.IDictionary[]
hashObj)
{
var return_v = DISCPowerShellConfiguration.TryGetHashtableArray( (object)hashObj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 65515, 65585);
return return_v;
}


string
f_1597_65776_65829()
{
var return_v = RemotingErrorIdStrings.DISCFunctionDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 65776, 65829);
return return_v;
}


string
f_1597_65860_65931(System.Collections.Hashtable[]
tables,System.IO.StreamWriter
writer)
{
var return_v = SessionConfigurationUtils.CombineHashtableArray( (System.Collections.IDictionary[])tables, writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 65860, 65931);
return return_v;
}


string
f_1597_65694_65953(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 65694, 65953);
return return_v;
}


System.Text.StringBuilder
f_1597_65680_65954(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 65680, 65954);
return return_v;
}


bool
f_1597_66086_66146(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 66086, 66146);
return return_v;
}


string
f_1597_66278_66323()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 66278, 66323);
return return_v;
}


string
f_1597_66260_66448(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 66260, 66448);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_66236_66449(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 66236, 66449);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_66506_66519(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 66506, 66519);
return return_v;
}


int
f_1597_66484_66520(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 66484, 66520);
return 0;
}


bool
f_1597_66589_66650(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 66589, 66650);
return return_v;
}


string
f_1597_66782_66827()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 66782, 66827);
return return_v;
}


string
f_1597_66764_66953(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 66764, 66953);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_66740_66954(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 66740, 66954);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_67011_67024(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 67011, 67024);
return return_v;
}


int
f_1597_66989_67025(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 66989, 67025);
return 0;
}


object
f_1597_67094_67143(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 67094, 67143);
return return_v;
}


string
f_1597_67299_67346()
{
var return_v = RemotingErrorIdStrings.DISCKeyMustBeScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 67299, 67346);
return return_v;
}


string
f_1597_67281_67472(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 67281, 67472);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_67257_67473(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 67257, 67473);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_67530_67543(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 67530, 67543);
return return_v;
}


int
f_1597_67508_67544(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 67508, 67544);
return 0;
}


System.Collections.ICollection
f_1597_67639_67653(System.Collections.Hashtable
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 67639, 67653);
return return_v;
}


bool
f_1597_67724_67825(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 67724, 67825);
return return_v;
}


bool
f_1597_67867_67969(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 67867, 67969);
return return_v;
}


bool
f_1597_68011_68115(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 68011, 68115);
return return_v;
}


string
f_1597_68255_68304()
{
var return_v = RemotingErrorIdStrings.DISCTypeContainsInvalidKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 68255, 68304);
return return_v;
}


string
f_1597_68237_68407(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 68237, 68407);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_68213_68408(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 68213, 68408);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_68469_68482(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 68469, 68482);
return return_v;
}


int
f_1597_68447_68483(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 68447, 68483);
return 0;
}


System.Collections.ICollection
f_1597_67639_67653_I(System.Collections.ICollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 67639, 67653);
return return_v;
}


System.Collections.Hashtable[]
f_1597_66015_66023_I(System.Collections.Hashtable[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 66015, 66023);
return return_v;
}


string
f_1597_68741_68792()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustBeHashtableArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 68741, 68792);
return return_v;
}


string
f_1597_68723_68873(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 68723, 68873);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_68699_68874(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 68699, 68874);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_68923_68936(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 68923, 68936);
return return_v;
}


int
f_1597_68901_68937(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 68901, 68937);
return 0;
}


string
f_1597_69211_69264()
{
var return_v = RemotingErrorIdStrings.DISCVariableDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 69211, 69264);
return return_v;
}


string
f_1597_69129_69432(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 69129, 69432);
return return_v;
}


System.Text.StringBuilder
f_1597_69115_69433(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 69115, 69433);
return return_v;
}


string
f_1597_69757_69810()
{
var return_v = RemotingErrorIdStrings.DISCVariableDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 69757, 69810);
return return_v;
}


string
f_1597_69675_69872(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 69675, 69872);
return return_v;
}


System.Text.StringBuilder
f_1597_69661_69873(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 69661, 69873);
return return_v;
}


System.Collections.Hashtable[]
f_1597_69994_70064(object
hashObj)
{
var return_v = DISCPowerShellConfiguration.TryGetHashtableArray( hashObj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 69994, 70064);
return return_v;
}


string
f_1597_70266_70319()
{
var return_v = RemotingErrorIdStrings.DISCVariableDefinitionsComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 70266, 70319);
return return_v;
}


string
f_1597_70354_70424(System.Collections.Hashtable[]
tables,System.IO.StreamWriter
writer)
{
var return_v = SessionConfigurationUtils.CombineHashtableArray( (System.Collections.IDictionary[])tables, writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 70354, 70424);
return return_v;
}


string
f_1597_70184_70446(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 70184, 70446);
return return_v;
}


System.Text.StringBuilder
f_1597_70170_70447(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 70170, 70447);
return return_v;
}


bool
f_1597_70590_70650(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 70590, 70650);
return return_v;
}


string
f_1597_70790_70835()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 70790, 70835);
return return_v;
}


string
f_1597_70772_70964(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 70772, 70964);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_70748_70965(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 70748, 70965);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_71026_71039(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 71026, 71039);
return return_v;
}


int
f_1597_71004_71040(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 71004, 71040);
return 0;
}


bool
f_1597_71117_71178(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 71117, 71178);
return return_v;
}


string
f_1597_71318_71363()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 71318, 71363);
return return_v;
}


string
f_1597_71300_71493(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 71300, 71493);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_71276_71494(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 71276, 71494);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_71555_71568(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 71555, 71568);
return return_v;
}


int
f_1597_71533_71569(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 71533, 71569);
return 0;
}


System.Collections.ICollection
f_1597_71672_71686(System.Collections.Hashtable
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 71672, 71686);
return return_v;
}


bool
f_1597_71765_71866(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 71765, 71866);
return return_v;
}


bool
f_1597_71912_72014(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 71912, 72014);
return return_v;
}


string
f_1597_72162_72211()
{
var return_v = RemotingErrorIdStrings.DISCTypeContainsInvalidKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 72162, 72211);
return return_v;
}


string
f_1597_72144_72318(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 72144, 72318);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_72120_72319(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 72120, 72319);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_72384_72397(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 72384, 72397);
return return_v;
}


int
f_1597_72362_72398(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 72362, 72398);
return 0;
}


System.Collections.ICollection
f_1597_71672_71686_I(System.Collections.ICollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 71672, 71686);
return return_v;
}


System.Collections.Hashtable[]
f_1597_70512_70519_I(System.Collections.Hashtable[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 70512, 70519);
return return_v;
}


string
f_1597_72684_72735()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustBeHashtableArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 72684, 72735);
return return_v;
}


string
f_1597_72666_72820(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 72666, 72820);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_72642_72821(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 72642, 72821);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_72874_72887(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 72874, 72887);
return return_v;
}


int
f_1597_72852_72888(Microsoft.PowerShell.Commands.NewPSRoleCapabilityFileCommand
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 72852, 72888);
return 0;
}


string
f_1597_73192_73246()
{
var return_v = RemotingErrorIdStrings.DISCEnvironmentVariablesComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 73192, 73246);
return return_v;
}


string
f_1597_73109_73368(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 73109, 73368);
return return_v;
}


System.Text.StringBuilder
f_1597_73095_73369(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 73095, 73369);
return return_v;
}


string
f_1597_73549_73603()
{
var return_v = RemotingErrorIdStrings.DISCEnvironmentVariablesComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 73549, 73603);
return return_v;
}


string
f_1597_73630_73709(System.Collections.IDictionary
table,System.IO.StreamWriter
writer)
{
var return_v = SessionConfigurationUtils.CombineHashtable( table, writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 73630, 73709);
return return_v;
}


string
f_1597_73466_73731(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 73466, 73731);
return return_v;
}


System.Text.StringBuilder
f_1597_73452_73732(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 73452, 73732);
return return_v;
}


int
f_1597_73823_73845(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 73823, 73845);
return return_v;
}


string
f_1597_73853_73914(string[]
values)
{
var return_v = SessionConfigurationUtils.CombineStringArray( values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 73853, 73914);
return return_v;
}


string
f_1597_74098_74146()
{
var return_v = RemotingErrorIdStrings.DISCTypesToProcessComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 74098, 74146);
return return_v;
}


int
f_1597_74196_74218(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 74196, 74218);
return return_v;
}


string
f_1597_74021_74225(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 74021, 74225);
return return_v;
}


System.Text.StringBuilder
f_1597_74007_74226(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 74007, 74226);
return return_v;
}


int
f_1597_74300_74324(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 74300, 74324);
return return_v;
}


string
f_1597_74332_74395(string[]
values)
{
var return_v = SessionConfigurationUtils.CombineStringArray( values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 74332, 74395);
return return_v;
}


string
f_1597_74585_74635()
{
var return_v = RemotingErrorIdStrings.DISCFormatsToProcessComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 74585, 74635);
return return_v;
}


int
f_1597_74685_74709(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 74685, 74709);
return return_v;
}


string
f_1597_74506_74716(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 74506, 74716);
return return_v;
}


System.Text.StringBuilder
f_1597_74492_74717(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 74492, 74717);
return return_v;
}


int
f_1597_74854_74878(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 74854, 74878);
return return_v;
}


string
f_1597_75238_75288()
{
var return_v = RemotingErrorIdStrings.DISCAssembliesToLoadComment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 75238, 75288);
return return_v;
}


string
f_1597_75311_75374(string[]
values)
{
var return_v = SessionConfigurationUtils.CombineStringArray( values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 75311, 75374);
return return_v;
}


string
f_1597_75159_75400(string
key,string
resourceString,string
value,System.IO.StreamWriter
streamWriter,bool
isExample)
{
var return_v = SessionConfigurationUtils.ConfigFragment( key, resourceString, value, streamWriter, isExample);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 75159, 75400);
return return_v;
}


System.Text.StringBuilder
f_1597_75145_75401(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 75145, 75401);
return return_v;
}


System.Text.StringBuilder
f_1597_75422_75440(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 75422, 75440);
return return_v;
}


string
f_1597_75480_75497(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 75480, 75497);
return return_v;
}


int
f_1597_75461_75498(System.IO.StreamWriter
this_param,string
value)
{
this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 75461, 75498);
return 0;
}


int
f_1597_75568_75590(System.IO.StreamWriter
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 75568, 75590);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,56239,75617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,56239,75617);
}
		}

public NewPSRoleCapabilityFileCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1597,46338,75646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,46945,46950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,47293,47315);
this._guid = Guid.NewGuid();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,47677,47684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,48040,48052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,48409,48421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,48781,48791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,49273,49289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,49766,49805);
this._visibleAliases = f_1597_49784_49805();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,50282,50304);
this._visibleCmdlets = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,50789,50813);
this._visibleFunctions = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,51353,51401);
this._visibleExternalCommands = f_1597_51380_51401();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,51878,51919);
this._visibleProviders = f_1597_51898_51919();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,52395,52436);
this._scriptsToProcess = f_1597_52415_52436();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,52921,52938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,53434,53454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,53936,53956);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,54556,54577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,55055,55094);
this._typesToProcess = f_1597_55073_55094();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,55584,55625);
this._formatsToProcess = f_1597_55604_55625();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,56111,56128);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1597,46338,75646);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,46338,75646);
}


static NewPSRoleCapabilityFileCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1597,46338,75646);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1597,46338,75646);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,46338,75646);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1597,46338,75646);

string[]
f_1597_49784_49805()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 49784, 49805);
return return_v;
}


string[]
f_1597_51380_51401()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 51380, 51401);
return return_v;
}


string[]
f_1597_51898_51919()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 51898, 51919);
return return_v;
}


string[]
f_1597_52415_52436()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 52415, 52436);
return return_v;
}


string[]
f_1597_55073_55094()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 55073, 55094);
return return_v;
}


string[]
f_1597_55604_55625()
{
var return_v = Array.Empty<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 55604, 55625);
return return_v;
}

}
internal class SessionConfigurationUtils
{
internal static string ConfigFragment(string key, string resourceString, string value, StreamWriter streamWriter, bool isExample)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,76114,76688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,76268,76301);

string 
nl = f_1597_76280_76300(streamWriter)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,76317,76523) || true) && (isExample)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,76317,76523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,76364,76508);

return f_1597_76371_76507(f_1597_76385_76413(), "# {0}{1}# {2:19} = {3}{4}{5}", resourceString, nl, key, value, nl, nl);
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,76317,76523);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,76539,76677);

return f_1597_76546_76676(f_1597_76560_76588(), "# {0}{1}{2:19} = {3}{4}{5}", resourceString, nl, key, value, nl, nl);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,76114,76688);

string
f_1597_76280_76300(System.IO.StreamWriter
this_param)
{
var return_v = this_param.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 76280, 76300);
return return_v;
}


System.Globalization.CultureInfo
f_1597_76385_76413()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 76385, 76413);
return return_v;
}


string
f_1597_76371_76507(System.Globalization.CultureInfo
provider,string
format,params object?[]
args)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 76371, 76507);
return return_v;
}


System.Globalization.CultureInfo
f_1597_76560_76588()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 76560, 76588);
return return_v;
}


string
f_1597_76546_76676(System.Globalization.CultureInfo
provider,string
format,params object?[]
args)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 76546, 76676);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,76114,76688);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,76114,76688);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string QuoteName(object name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,76947,77210);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,77017,77064) || true) && (name == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,77017,77064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,77052,77064);

return "''";
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,77017,77064);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,77078,77199);

return "'" + f_1597_77091_77192(f_1597_77176_77191(name))+ "'";
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,76947,77210);

string?
f_1597_77176_77191(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 77176, 77191);
return return_v;
}


string
f_1597_77091_77192(string
value)
{
var return_v = System.Management.Automation.Language.CodeGeneration.EscapeSingleQuotedStringContent( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 77091, 77192);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,76947,77210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,76947,77210);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string WrapScriptBlock(object sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,77446,77623);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,77520,77565) || true) && (sb == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,77520,77565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,77553,77565);

return "{}";
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,77520,77565);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,77579,77612);

return "{" + f_1597_77592_77605(sb)+ "}";
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,77446,77623);

string?
f_1597_77592_77605(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 77592, 77605);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,77446,77623);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,77446,77623);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string WriteBoolean(bool booleanToEmit)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,77749,78003);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,77829,77992) || true) && (booleanToEmit)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,77829,77992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,77880,77895);

return "$true";
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,77829,77992);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,77829,77992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,77961,77977);

return "$false";
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,77829,77992);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,77749,78003);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,77749,78003);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,77749,78003);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string WriteLong(long longToEmit)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,78015,78157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,78089,78146);

return f_1597_78096_78145(longToEmit, f_1597_78116_78144());
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,78015,78157);

System.Globalization.CultureInfo
f_1597_78116_78144()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 78116, 78144);
return return_v;
}


string
f_1597_78096_78145(long
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 78096, 78145);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,78015,78157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,78015,78157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string GetVisibilityDefault(object[] values, StreamWriter writer, PSCmdlet caller)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,78264,78705);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,78387,78540) || true) && ((values != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1597, 78391, 78430)&&(f_1597_78412_78425(values)> 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,78387,78540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,78464,78525);

return f_1597_78471_78524(values, writer, caller);
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,78387,78540);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,78668,78694);

return "'Item1', 'Item2'";
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,78264,78705);

int
f_1597_78412_78425(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 78412, 78425);
return return_v;
}


string
f_1597_78471_78524(object[]
values,System.IO.StreamWriter
writer,System.Management.Automation.PSCmdlet
caller)
{
var return_v = CombineHashTableOrStringArray( values, writer, caller);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 78471, 78524);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,78264,78705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,78264,78705);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string CombineHashtable(IDictionary table, StreamWriter writer, int? indent = 0)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,78826,80544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,78947,78986);

StringBuilder 
sb = f_1597_78966_78985()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79002,79018);

f_1597_79002_79017(
            sb, "@{");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79034,79087);

var 
keys = f_1597_79045_79086(f_1597_79045_79070(f_1597_79045_79055(table)), x => x)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79101,80464);
foreach(var key in f_1597_79121_79125_I(keys) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,79101,80464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79159,79185);

f_1597_79159_79184(                sb, f_1597_79169_79183(writer));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79203,79267);

f_1597_79203_79266(                sb, "{0," + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((4 * (indent + 1))).ToString(),1597,79227,79245)+ "}", string.Empty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79285,79311);

f_1597_79285_79310(                sb, f_1597_79295_79309(key));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79329,79346);

f_1597_79329_79345(                sb, " = ");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79364,79545) || true) && ((f_1597_79369_79379(table, key)as ScriptBlock) != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,79364,79545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79445,79495);

f_1597_79445_79494(                    sb, f_1597_79455_79493(f_1597_79471_79492(f_1597_79471_79481(table, key))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79517,79526);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,79364,79545);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79565,79616);

IDictionary 
tableValue = f_1597_79590_79600(table, key)as IDictionary
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79634,79808) || true) && (tableValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,79634,79808);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79698,79758);

f_1597_79698_79757(                    sb, f_1597_79708_79756(tableValue, writer, indent + 1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79780,79789);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,79634,79808);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79828,79917);

IDictionary[] 
tableValues = f_1597_79856_79916(f_1597_79905_79915(table, key))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,79935,80116) || true) && (tableValues != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,79935,80116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,80000,80066);

f_1597_80000_80065(                    sb, f_1597_80010_80064(tableValues, writer, indent + 1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,80088,80097);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,79935,80116);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,80136,80218);

string[] 
stringValues = f_1597_80160_80217(f_1597_80206_80216(table, key))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,80236,80396) || true) && (stringValues != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,80236,80396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,80302,80346);

f_1597_80302_80345(                    sb, f_1597_80312_80344(stringValues));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,80368,80377);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,80236,80396);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,80416,80449);

f_1597_80416_80448(
                sb, f_1597_80426_80447(f_1597_80436_80446(table, key)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,79101,80464);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,1364);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,1364);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,80480,80496);

f_1597_80480_80495(
            sb, " }");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,80512,80533);

return f_1597_80519_80532(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,78826,80544);

System.Text.StringBuilder
f_1597_78966_78985()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 78966, 78985);
return return_v;
}


System.Text.StringBuilder
f_1597_79002_79017(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79002, 79017);
return return_v;
}


System.Collections.ICollection
f_1597_79045_79055(System.Collections.IDictionary
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 79045, 79055);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1597_79045_79070(System.Collections.ICollection
source)
{
var return_v = source.Cast<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79045, 79070);
return return_v;
}


System.Linq.IOrderedEnumerable<string>
f_1597_79045_79086(System.Collections.Generic.IEnumerable<string>
source,System.Func<string, string>
keySelector)
{
var return_v = source.OrderBy<string,string>( keySelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79045, 79086);
return return_v;
}


string
f_1597_79169_79183(System.IO.StreamWriter
this_param)
{
var return_v = this_param.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 79169, 79183);
return return_v;
}


System.Text.StringBuilder
f_1597_79159_79184(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79159, 79184);
return return_v;
}


System.Text.StringBuilder
f_1597_79203_79266(System.Text.StringBuilder
this_param,string
format,string
arg0)
{
var return_v = this_param.AppendFormat( format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79203, 79266);
return return_v;
}


string
f_1597_79295_79309(string
name)
{
var return_v = QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79295, 79309);
return return_v;
}


System.Text.StringBuilder
f_1597_79285_79310(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79285, 79310);
return return_v;
}


System.Text.StringBuilder
f_1597_79329_79345(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79329, 79345);
return return_v;
}


object
f_1597_79369_79379(System.Collections.IDictionary
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 79369, 79379);
return return_v;
}


object
f_1597_79471_79481(System.Collections.IDictionary
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 79471, 79481);
return return_v;
}


string?
f_1597_79471_79492(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79471, 79492);
return return_v;
}


string
f_1597_79455_79493(string
sb)
{
var return_v = WrapScriptBlock( (object)sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79455, 79493);
return return_v;
}


System.Text.StringBuilder
f_1597_79445_79494(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79445, 79494);
return return_v;
}


object
f_1597_79590_79600(System.Collections.IDictionary
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 79590, 79600);
return return_v;
}


string
f_1597_79708_79756(System.Collections.IDictionary
table,System.IO.StreamWriter
writer,int?
indent)
{
var return_v = CombineHashtable( table, writer, indent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79708, 79756);
return return_v;
}


System.Text.StringBuilder
f_1597_79698_79757(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79698, 79757);
return return_v;
}


object
f_1597_79905_79915(System.Collections.IDictionary
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 79905, 79915);
return return_v;
}


System.Collections.Hashtable[]
f_1597_79856_79916(object
hashObj)
{
var return_v = DISCPowerShellConfiguration.TryGetHashtableArray( hashObj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79856, 79916);
return return_v;
}


string
f_1597_80010_80064(System.Collections.IDictionary[]
tables,System.IO.StreamWriter
writer,int?
indent)
{
var return_v = CombineHashtableArray( tables, writer, indent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 80010, 80064);
return return_v;
}


System.Text.StringBuilder
f_1597_80000_80065(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 80000, 80065);
return return_v;
}


object
f_1597_80206_80216(System.Collections.IDictionary
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 80206, 80216);
return return_v;
}


string[]
f_1597_80160_80217(object
hashObj)
{
var return_v = DISCPowerShellConfiguration.TryGetStringArray( hashObj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 80160, 80217);
return return_v;
}


string
f_1597_80312_80344(string[]
values)
{
var return_v = CombineStringArray( values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 80312, 80344);
return return_v;
}


System.Text.StringBuilder
f_1597_80302_80345(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 80302, 80345);
return return_v;
}


object
f_1597_80436_80446(System.Collections.IDictionary
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 80436, 80446);
return return_v;
}


string
f_1597_80426_80447(object
name)
{
var return_v = QuoteName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 80426, 80447);
return return_v;
}


System.Text.StringBuilder
f_1597_80416_80448(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 80416, 80448);
return return_v;
}


System.Linq.IOrderedEnumerable<string>
f_1597_79121_79125_I(System.Linq.IOrderedEnumerable<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 79121, 79125);
return return_v;
}


System.Text.StringBuilder
f_1597_80480_80495(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 80480, 80495);
return return_v;
}


string
f_1597_80519_80532(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 80519, 80532);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,78826,80544);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,78826,80544);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string CombineRequiredGroupsHash(IDictionary table)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,81056,82254);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81148,81310) || true) && (f_1597_81152_81163(table)!= 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,81148,81310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81202,81295);

throw f_1597_81208_81294(f_1597_81240_81293());
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,81148,81310);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81326,81365);

StringBuilder 
sb = f_1597_81345_81364()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81381,81428);

var 
keyEnumerator = f_1597_81401_81427(f_1597_81401_81411(table))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81442,81467);

f_1597_81442_81466(            keyEnumerator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81481,81526);

string 
key = f_1597_81494_81515(keyEnumerator)as string
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81540,81570);

object 
keyObject = f_1597_81559_81569(table, key)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81584,81601);

f_1597_81584_81600(            sb, "@{ ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81615,81641);

f_1597_81615_81640(            sb, f_1597_81625_81639(key));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81655,81672);

f_1597_81655_81671(            sb, " = ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81688,81728);

object[] 
values = keyObject as object[]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81742,82174) || true) && (values != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,81742,82174);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81803,81808);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81794,82059) || true) && (i < f_1597_81814_81827(values))
;DynAbs.Tracing.TraceSender.TraceExitCondition(1597,81794,82059))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,81794,82059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81870,81906);

f_1597_81870_81905(values[i++], sb);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,81930,82040) || true) && (i < f_1597_81938_81951(values))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,81930,82040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82001,82017);

f_1597_82001_82016(                        sb, ", ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,81930,82040);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,266);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,266);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1597,81742,82174);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,81742,82174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82125,82159);

f_1597_82125_82158(keyObject, sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,81742,82174);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82190,82206);

f_1597_82190_82205(
            sb, " }");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82222,82243);

return f_1597_82229_82242(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,81056,82254);

int
f_1597_81152_81163(System.Collections.IDictionary
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 81152, 81163);
return return_v;
}


string
f_1597_81240_81293()
{
var return_v = RemotingErrorIdStrings.RequiredGroupsHashMultipleKeys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 81240, 81293);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1597_81208_81294(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 81208, 81294);
return return_v;
}


System.Text.StringBuilder
f_1597_81345_81364()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 81345, 81364);
return return_v;
}


System.Collections.ICollection
f_1597_81401_81411(System.Collections.IDictionary
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 81401, 81411);
return return_v;
}


System.Collections.IEnumerator
f_1597_81401_81427(System.Collections.ICollection
this_param)
{
var return_v = this_param.GetEnumerator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 81401, 81427);
return return_v;
}


bool
f_1597_81442_81466(System.Collections.IEnumerator
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 81442, 81466);
return return_v;
}


object
f_1597_81494_81515(System.Collections.IEnumerator
this_param)
{
var return_v = this_param.Current ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 81494, 81515);
return return_v;
}


object
f_1597_81559_81569(System.Collections.IDictionary
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 81559, 81569);
return return_v;
}


System.Text.StringBuilder
f_1597_81584_81600(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 81584, 81600);
return return_v;
}


string
f_1597_81625_81639(string
name)
{
var return_v = QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 81625, 81639);
return return_v;
}


System.Text.StringBuilder
f_1597_81615_81640(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 81615, 81640);
return return_v;
}


System.Text.StringBuilder
f_1597_81655_81671(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 81655, 81671);
return return_v;
}


int
f_1597_81814_81827(object[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 81814, 81827);
return return_v;
}


int
f_1597_81870_81905(object
value,System.Text.StringBuilder
sb)
{
WriteRequiredGroup( value, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 81870, 81905);
return 0;
}


int
f_1597_81938_81951(object[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 81938, 81951);
return return_v;
}


System.Text.StringBuilder
f_1597_82001_82016(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 82001, 82016);
return return_v;
}


int
f_1597_82125_82158(object
value,System.Text.StringBuilder
sb)
{
WriteRequiredGroup( value, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 82125, 82158);
return 0;
}


System.Text.StringBuilder
f_1597_82190_82205(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 82190, 82205);
return return_v;
}


string
f_1597_82229_82242(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 82229, 82242);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,81056,82254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,81056,82254);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void WriteRequiredGroup(object value, StringBuilder sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,82266,82944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82361,82395);

string 
strValue = value as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82409,82933) || true) && (strValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,82409,82933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82463,82494);

f_1597_82463_82493(                sb, f_1597_82473_82492(strValue));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,82409,82933);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,82409,82933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82560,82600);

Hashtable 
subTable = value as Hashtable
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82618,82918) || true) && (subTable != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,82618,82918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82680,82727);

f_1597_82680_82726(                    sb, f_1597_82690_82725(subTable));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,82618,82918);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,82618,82918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,82809,82899);

throw f_1597_82815_82898(f_1597_82847_82897());
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,82618,82918);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,82409,82933);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,82266,82944);

string
f_1597_82473_82492(string
name)
{
var return_v = QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 82473, 82492);
return return_v;
}


System.Text.StringBuilder
f_1597_82463_82493(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 82463, 82493);
return return_v;
}


string
f_1597_82690_82725(System.Collections.Hashtable
table)
{
var return_v = CombineRequiredGroupsHash( (System.Collections.IDictionary)table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 82690, 82725);
return return_v;
}


System.Text.StringBuilder
f_1597_82680_82726(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 82680, 82726);
return return_v;
}


string
f_1597_82847_82897()
{
var return_v = RemotingErrorIdStrings.UnknownGroupMembershipValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 82847, 82897);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_1597_82815_82898(string
message)
{
var return_v = new System.Management.Automation.PSInvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 82815, 82898);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,82266,82944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,82266,82944);
}
		}

internal static string CombineHashtableArray(IDictionary[] tables, StreamWriter writer, int? indent = 0)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,83076,83574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83205,83244);

StringBuilder 
sb = f_1597_83224_83243()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83269,83274);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83260,83526) || true) && (i < f_1597_83280_83293(tables))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83295,83298)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1597,83260,83526))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,83260,83526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83332,83387);

f_1597_83332_83386(                sb, f_1597_83342_83385(tables[i], writer, indent));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83407,83511) || true) && (i < (f_1597_83416_83429(tables)- 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,83407,83511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83476,83492);

f_1597_83476_83491(                    sb, ", ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,83407,83511);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,267);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,267);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83542,83563);

return f_1597_83549_83562(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,83076,83574);

System.Text.StringBuilder
f_1597_83224_83243()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 83224, 83243);
return return_v;
}


int
f_1597_83280_83293(System.Collections.IDictionary[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 83280, 83293);
return return_v;
}


string
f_1597_83342_83385(System.Collections.IDictionary
table,System.IO.StreamWriter
writer,int?
indent)
{
var return_v = CombineHashtable( table, writer, indent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 83342, 83385);
return return_v;
}


System.Text.StringBuilder
f_1597_83332_83386(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 83332, 83386);
return return_v;
}


int
f_1597_83416_83429(System.Collections.IDictionary[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 83416, 83429);
return return_v;
}


System.Text.StringBuilder
f_1597_83476_83491(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 83476, 83491);
return return_v;
}


string
f_1597_83549_83562(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 83549, 83562);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,83076,83574);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,83076,83574);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string CombineStringArray(string[] values)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,83806,84348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83889,83928);

StringBuilder 
sb = f_1597_83908_83927()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83953,83958);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83944,84300) || true) && (i < f_1597_83964_83977(values))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,83979,83982)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1597,83944,84300))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,83944,84300);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84016,84285) || true) && (!f_1597_84021_84052(values[i]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,84016,84285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84094,84126);

f_1597_84094_84125(                    sb, f_1597_84104_84124(values[i]));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84150,84266) || true) && (i < (f_1597_84159_84172(values)- 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,84150,84266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84227,84243);

f_1597_84227_84242(                        sb, ", ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,84150,84266);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,84016,84285);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,357);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,357);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84316,84337);

return f_1597_84323_84336(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,83806,84348);

System.Text.StringBuilder
f_1597_83908_83927()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 83908, 83927);
return return_v;
}


int
f_1597_83964_83977(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 83964, 83977);
return return_v;
}


bool
f_1597_84021_84052(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 84021, 84052);
return return_v;
}


string
f_1597_84104_84124(string
name)
{
var return_v = QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 84104, 84124);
return return_v;
}


System.Text.StringBuilder
f_1597_84094_84125(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 84094, 84125);
return return_v;
}


int
f_1597_84159_84172(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 84159, 84172);
return return_v;
}


System.Text.StringBuilder
f_1597_84227_84242(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 84227, 84242);
return return_v;
}


string
f_1597_84323_84336(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 84323, 84336);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,83806,84348);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,83806,84348);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string CombineHashTableOrStringArray(object[] values, StreamWriter writer, PSCmdlet caller)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1597,84491,85766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84623,84662);

StringBuilder 
sb = f_1597_84642_84661()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84685,84690);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84676,85718) || true) && (i < f_1597_84696_84709(values))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84711,84714)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1597,84676,85718))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,84676,85718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84748,84784);

string 
strVal = values[i] as string
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84802,85579) || true) && (!f_1597_84807_84835(strVal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,84802,85579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84877,84906);

f_1597_84877_84905(                    sb, f_1597_84887_84904(strVal));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,84802,85579);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,84802,85579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,84988,85031);

Hashtable 
hashVal = values[i] as Hashtable
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,85053,85491) || true) && (hashVal == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,85053,85491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,85122,85315);

string 
message = f_1597_85139_85314(f_1597_85157_85216(), ConfigFileConstants.ModulesToImport)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,85341,85398);

PSArgumentException 
e = f_1597_85365_85397(message)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,85424,85468);

f_1597_85424_85467(                        caller, f_1597_85453_85466(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,85053,85491);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,85515,85560);

f_1597_85515_85559(
                    sb, f_1597_85525_85558(hashVal, writer));
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,84802,85579);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,85599,85703) || true) && (i < (f_1597_85608_85621(values)- 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1597,85599,85703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,85668,85684);

f_1597_85668_85683(                    sb, ", ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1597,85599,85703);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1597,1,1043);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1597,1,1043);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1597,85734,85755);

return f_1597_85741_85754(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1597,84491,85766);

System.Text.StringBuilder
f_1597_84642_84661()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 84642, 84661);
return return_v;
}


int
f_1597_84696_84709(object[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 84696, 84709);
return return_v;
}


bool
f_1597_84807_84835(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 84807, 84835);
return return_v;
}


string
f_1597_84887_84904(string
name)
{
var return_v = QuoteName( (object)name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 84887, 84904);
return return_v;
}


System.Text.StringBuilder
f_1597_84877_84905(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 84877, 84905);
return return_v;
}


string
f_1597_85157_85216()
{
var return_v = RemotingErrorIdStrings.DISCTypeMustBeStringOrHashtableArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 85157, 85216);
return return_v;
}


string
f_1597_85139_85314(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 85139, 85314);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1597_85365_85397(string
message)
{
var return_v = new System.Management.Automation.PSArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 85365, 85397);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1597_85453_85466(System.Management.Automation.PSArgumentException
this_param)
{
var return_v = this_param.ErrorRecord;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 85453, 85466);
return return_v;
}


int
f_1597_85424_85467(System.Management.Automation.PSCmdlet
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 85424, 85467);
return 0;
}


string
f_1597_85525_85558(System.Collections.Hashtable
table,System.IO.StreamWriter
writer)
{
var return_v = CombineHashtable( (System.Collections.IDictionary)table, writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 85525, 85558);
return return_v;
}


System.Text.StringBuilder
f_1597_85515_85559(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 85515, 85559);
return return_v;
}


int
f_1597_85608_85621(object[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1597, 85608, 85621);
return return_v;
}


System.Text.StringBuilder
f_1597_85668_85683(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 85668, 85683);
return return_v;
}


string
f_1597_85741_85754(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1597, 85741, 85754);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1597,84491,85766);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,84491,85766);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public SessionConfigurationUtils()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1597,75792,85773);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1597,75792,85773);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,75792,85773);
}


static SessionConfigurationUtils()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1597,75792,85773);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1597,75792,85773);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1597,75792,85773);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1597,75792,85773);
}

    }
